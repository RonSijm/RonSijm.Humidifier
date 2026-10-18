using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Humidifier.Tests;

public class UnionCompilationTests
{
    private static readonly MetadataReference[] References =
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!).Split(Path.PathSeparator)
        .Append(typeof(Fn).Assembly.Location)
        .Distinct(StringComparer.OrdinalIgnoreCase)
        .Select(path => MetadataReference.CreateFromFile(path))
        .ToArray();

    [Fact]
    public void OrdinaryObjectInitializersAndBroadFunctionsCompile()
    {
        var errors = Compile("""
            var function = new Function
            {
                Timeout = 30,
                Role = Fn.Sub("arn:aws:iam::${AWS::AccountId}:role/app"),
                Code = new Code { ZipFile = "source" },
                Architectures = new[] { "arm64" },
                Layers = new List<string> { "layer" }
            };
            function.Code = Fn.Sub("hello");
            function.Timeout = Fn.Ref("Timeout");
            """);

        Assert.Empty(errors);
    }

    [Theory]
    [InlineData("new Function { Timeout = \"thirty\" };")]
    [InlineData("new Function { Code = 42 };")]
    [InlineData("new Function { Role = new Code() };")]
    [InlineData("new Function { Architectures = new[] { 42 } };")]
    [InlineData("new Function { Environment = new Humidifier.Lambda.FunctionTypes.Environment { Variables = new Dictionary<string, int>() } };")]
    [InlineData("new Humidifier.Serverless.Function { Timeout = \"slow\" };")]
    [InlineData("new Humidifier.Serverless.Api { CacheClusterEnabled = \"true\" };")]
    [InlineData("new Humidifier.Serverless.Api { Cors = 42 };")]
    [InlineData("new Humidifier.Serverless.SimpleTableTypes.ProvisionedThroughput { ReadCapacityUnits = \"5\" };")]
    [InlineData("new ResourceSignal { Count = \"two\" };")]
    [InlineData("new AutoScalingReplacingUpdate { WillReplace = \"true\" };")]
    [InlineData("new Statement { Action = 42 };")]
    [InlineData("new Statement { Resource = false };")]
    [InlineData("new PolicyPrincipal { Service = 42 };")]
    [InlineData("new Output { Value = 42 };")]
    [InlineData("new Output { Export = \"Name\" };")]
    public void IncompatibleLiteralShapesFailAtCompileTime(string expression)
    {
        var errors = Compile("var invalid = " + expression);
        Assert.Contains(errors, error => error.Id == "CS0029");
    }

    [Fact]
    public void HandWrittenModelsAcceptTheirLiteralShapesAndDeferredFunctions()
    {
        var errors = Compile("""
            var sam = new Humidifier.Serverless.Function
            {
                Handler = "app.handler",
                Timeout = Fn.Ref("Timeout"),
                CodeUri = new Humidifier.Serverless.FunctionTypes.S3LocationObject { Bucket = "code", Key = "app.zip" },
                Policies = new object[] { "AmazonS3ReadOnlyAccess", new PolicyDocument() }
            };
            sam.Policies = "AmazonS3ReadOnlyAccess";
            sam.Policies = new PolicyDocument();
            sam.Policies = Fn.Ref("Policies");
            var statement = new Statement
            {
                Principal = new PolicyPrincipal { Service = new[] { "lambda.amazonaws.com", "events.amazonaws.com" } },
                Action = new[] { "s3:GetObject" },
                Resource = new Union<string, BaseFunction>[] { "arn:aws:s3:::images/*", Fn.Ref("OtherResource") }
            };
            var output = new Output { Value = Fn.Ref("Result"), Export = new OutputExport { Name = Fn.Sub("${AWS::StackName}-Result") } };
            """);
        Assert.Empty(errors);
    }

    private static Diagnostic[] Compile(string statements)
    {
        var source = """
            using System.Collections.Generic;
            using Humidifier;
            using Humidifier.Lambda;
            using Humidifier.Lambda.FunctionTypes;
            public static class AssignmentProbe
            {
                public static void Check()
                {
            """ + statements + "\n}\n}";

        var compilation = CSharpCompilation.Create("AssignmentProbe",
            [CSharpSyntaxTree.ParseText(source, new CSharpParseOptions(LanguageVersion.Preview))],
            References, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        return compilation.GetDiagnostics().Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error).ToArray();
    }
}
