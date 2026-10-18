using Humidifier.Base;
using Humidifier.Json.Serializer;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json.Linq;

namespace Humidifier.Tests;

public class HandWrittenUnionTests
{
    [Fact]
    public void ServerlessModelsSerializeTypedValuesAndNestedExpressions()
    {
        var function = new Serverless.Function
        {
            Handler = "app.handler",
            Runtime = "dotnet10",
            Timeout = 0,
            CodeUri = new Serverless.FunctionTypes.S3LocationObject
            {
                Bucket = Fn.Ref("CodeBucket"), Key = "app.zip", Version = "v1"
            },
            Policies = new object[] { "AmazonS3ReadOnlyAccess", new PolicyDocument { Version = "2012-10-17" } },
            Environment = new Serverless.FunctionTypes.Environment
            {
                Variables = new Dictionary<string, Union<string, BaseFunction>> { ["ENV"] = Fn.Ref("Environment") }
            },
            VpcConfig = new Serverless.FunctionTypes.VpcConfig
            {
                SubnetIds = new Union<string, BaseFunction>[] { "subnet-a", Fn.Ref("SubnetB") }
            },
            DeploymentPreference = new Serverless.FunctionTypes.DeploymentPreference { Enabled = false, Alarms = new[] { "Errors" } }
        };
        var properties = Properties(function);
        Assert.Equal(0, (int)properties["Timeout"]!);
        Assert.Equal("CodeBucket", (string)properties["CodeUri"]!["Bucket"]!["Ref"]!);
        Assert.Equal("AmazonS3ReadOnlyAccess", (string)properties["Policies"]![0]!);
        Assert.Equal("Environment", (string)properties["Environment"]!["Variables"]!["ENV"]!["Ref"]!);
        Assert.Equal("SubnetB", (string)properties["VpcConfig"]!["SubnetIds"]![1]!["Ref"]!);
        Assert.False((bool)properties["DeploymentPreference"]!["Enabled"]!);
        Assert.Null(properties["MemorySize"]);

        var api = Properties(new Serverless.Api
        {
            CacheClusterEnabled = false,
            DefinitionUri = new Serverless.ApiTypes.S3LocationObject { Bucket = "definitions", Key = "api.yaml" },
            Cors = new Serverless.ApiTypes.CorsConfiguration { AllowOrigin = "'*'", AllowCredentials = false },
            EndpointConfiguration = new Serverless.ApiTypes.EndpointConfiguration { Type = "PRIVATE", VPCEndpointIds = Fn.Ref("Endpoints") }
        });
        Assert.False((bool)api["Cors"]!["AllowCredentials"]!);
        Assert.Equal("Endpoints", (string)api["EndpointConfiguration"]!["VPCEndpointIds"]!["Ref"]!);

        var table = Properties(new Serverless.SimpleTable
        {
            PrimaryKey = new Serverless.SimpleTableTypes.PrimaryKey { Name = "Id", Type = "String" },
            ProvisionedThroughput = new Serverless.SimpleTableTypes.ProvisionedThroughput { ReadCapacityUnits = 5L, WriteCapacityUnits = Fn.Ref("Capacity") }
        });
        Assert.Equal(5, (long)table["ProvisionedThroughput"]!["ReadCapacityUnits"]!);
    }

    [Fact]
    public void PolicyStatementsKeepScalarListAndDeferredResourceShapes()
    {
        var arn = "arn:aws:s3:::before/*";
        var statement = new Statement
        {
            Principal = new PolicyPrincipal { Service = new[] { "lambda.amazonaws.com", "events.amazonaws.com" } },
            NotPrincipal = "*",
            Action = "s3:GetObject",
            NotAction = new[] { "s3:DeleteObject" },
            Resource = new Lazy<string>(() => arn),
            NotResource = new Union<string, BaseFunction>[] { "arn:aws:s3:::other/*", Fn.Ref("Protected") },
            Condition = new() { ["Bool"] = new() { ["aws:SecureTransport"] = true } }
        };
        arn = "arn:aws:s3:::after/*";
        var json = Properties(new S3.BucketPolicy { Bucket = "images", PolicyDocument = new PolicyDocument { Statement = [statement] } });
        var result = json["PolicyDocument"]!["Statement"]![0]!;
        Assert.Equal("s3:GetObject", (string)result["Action"]!);
        Assert.Equal("s3:DeleteObject", (string)result["NotAction"]![0]!);
        Assert.Equal("arn:aws:s3:::after/*", (string)result["Resource"]!);
        Assert.Equal("Protected", (string)result["NotResource"]![1]!["Ref"]!);
        Assert.Equal(2, result["Principal"]!["Service"]!.Count());
        Assert.True((bool)result["Condition"]!["Bool"]!["aws:SecureTransport"]!);
    }

    [Fact]
    public void OutputsMetadataDependenciesAndPoliciesRetainTheirWireFormat()
    {
        var stack = new Stack();
        stack.Add("IsProduction", new Condition(Fn.Equals(Fn.Ref("Environment"), "prod")));
        stack.Add("Result", new Output
        {
            Value = Fn.Ref("Resource"), Export = new OutputExport { Name = Fn.Sub("${AWS::StackName}-Result") }, Condition = "IsProduction"
        });
        stack.Add("Resource", new S3.Bucket(), metadata: new { Owner = "App", Revision = 2 }, dependsOn: ["Other"],
            creationPolicy: new CreationPolicy { ResourceSignal = new ResourceSignal { Count = 0, Timeout = "PT1S" } },
            updatePolicy: new UpdatePolicy
            {
                AutoScalingReplacingUpdate = new AutoScalingReplacingUpdate { WillReplace = false },
                AutoScalingRollingUpdate = new AutoScalingRollingUpdate { MaxBatchSize = 0, SuspendProcesses = new[] { "AlarmNotification" } }
            });
        stack.AddTemplateMetadata("Settings", new { Enabled = true });
        var json = JObject.Parse(new JsonStackSerializer().Serialize(stack));
        Assert.Equal("Other", (string)json["Resources"]!["Resource"]!["DependsOn"]![0]!);
        Assert.Equal(2, (int)json["Resources"]!["Resource"]!["Metadata"]!["Revision"]!);
        Assert.True((bool)json["Metadata"]!["Settings"]!["Enabled"]!);
        Assert.Equal("IsProduction", (string)json["Outputs"]!["Result"]!["Condition"]!);
        Assert.Equal("${AWS::StackName}-Result", (string)json["Outputs"]!["Result"]!["Export"]!["Name"]!["Fn::Sub"]!);
        Assert.Equal(0, (int)json["Resources"]!["Resource"]!["CreationPolicy"]!["ResourceSignal"]!["Count"]!);
        Assert.False((bool)json["Resources"]!["Resource"]!["UpdatePolicy"]!["AutoScalingReplacingUpdate"]!["WillReplace"]!);
    }

    [Fact]
    public void SourceCannotReintroduceDynamicKeywords()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory != null && !File.Exists(Path.Combine(directory.FullName, "Humidifier", "Humidifier.csproj")))
            directory = directory.Parent;
        Assert.NotNull(directory);
        var source = directory!.FullName;
        var violations = Directory.EnumerateFiles(source, "*.cs", SearchOption.AllDirectories)
            .Where(path => !path.Split(Path.DirectorySeparatorChar).Any(part => part is "bin" or "obj"))
            .Where(path => File.ReadAllText(path).Contains("dynamic", StringComparison.Ordinal))
            .Where(path => CSharpSyntaxTree.ParseText(File.ReadAllText(path), new CSharpParseOptions(LanguageVersion.Preview))
                .GetRoot().DescendantTokens().Any(token => token.Text == "dynamic"))
            .Select(path => Path.GetRelativePath(source, path));
        Assert.Empty(violations);
    }

    private static JObject Properties(BaseResource resource)
    {
        var stack = new Stack();
        stack.Add("Resource", resource);
        return (JObject)JObject.Parse(new JsonStackSerializer().Serialize(stack))["Resources"]!["Resource"]!["Properties"]!;
    }
}
