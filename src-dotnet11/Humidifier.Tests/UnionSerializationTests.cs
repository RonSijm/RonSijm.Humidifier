using Humidifier.Base;
using Humidifier.Json.Serializer;
using Humidifier.Lambda.FunctionTypes;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Humidifier.Tests;

public class UnionSerializationTests
{
    [Fact]
    public void ObjectInitializersSerializeLiteralsAndFunctionsWithoutWrappers()
    {
        var function = new Lambda.Function
        {
            Timeout = 30,
            Role = Fn.Sub("arn:aws:iam::${AWS::AccountId}:role/app"),
            Code = new Code { ZipFile = "source" }
        };

        var properties = SerializeProperties(function);

        Assert.Equal(30, (int)properties["Timeout"]!);
        Assert.Equal("arn:aws:iam::${AWS::AccountId}:role/app", (string)properties["Role"]!["Fn::Sub"]!);
        Assert.Equal("source", (string)properties["Code"]!["ZipFile"]!);
        Assert.Null(properties["MemorySize"]);
    }

    [Fact]
    public void DefaultUnionsAreOmittedButZeroAndFalseArePreserved()
    {
        var properties = SerializeProperties(new EC2.VPC
        {
            EnableDnsSupport = false,
            EnableDnsHostnames = default(Union<bool, BaseFunction>),
            Ipv4IpamPoolId = default(Union<string, BaseFunction>)
        });

        Assert.False((bool)properties["EnableDnsSupport"]!);
        Assert.Null(properties["EnableDnsHostnames"]);
        Assert.Null(properties["Ipv4IpamPoolId"]);
        Assert.Null(properties["CidrBlock"]);
        Assert.Equal(0, (int)SerializeProperties(new Lambda.Function { Timeout = 0 })["Timeout"]!);
    }

    [Fact]
    public void FunctionsCanSupplyObjectsAndConditionalOmission()
    {
        var properties = SerializeProperties(new Lambda.Function
        {
            Code = Fn.If("UseInline", new Code { ZipFile = "source" }, Fn.Ref("AWS::NoValue"))
        });

        var branches = (JArray)properties["Code"]!["Fn::If"]!;
        Assert.Equal("UseInline", (string)branches[0]!);
        Assert.Equal("source", (string)branches[1]["ZipFile"]!);
        Assert.Equal("AWS::NoValue", (string)branches[2]["Ref"]!);

        // The deliberately broad BaseFunction case remains part of the public contract.
        properties = SerializeProperties(new Lambda.Function { Code = Fn.Sub("hello") });
        Assert.Equal("hello", (string)properties["Code"]!["Fn::Sub"]!);
    }

    [Fact]
    public void CollectionsAcceptListsArraysExpressionsAndMixedEntries()
    {
        var function = new Lambda.Function
        {
            Architectures = new List<string> { "arm64" },
            Layers = new[] { "layer-arn" },
            Tags = new List<Tag> { new() { Key = "Environment", Value = Fn.Ref("Environment") } },
            VpcConfig = new VpcConfig
            {
                SubnetIds = new Union<string, BaseFunction>[] { "subnet-a", Fn.Ref("SubnetB") },
                SecurityGroupIds = Fn.Split(",", Fn.Ref("SecurityGroups"))
            },
            Environment = new Lambda.FunctionTypes.Environment
            {
                Variables = new Dictionary<string, Union<string, BaseFunction>>
                {
                    ["PLAIN"] = "value",
                    ["REFERENCE"] = Fn.Ref("Environment")
                }
            }
        };

        var properties = SerializeProperties(function);
        Assert.Equal("arm64", (string)properties["Architectures"]![0]!);
        Assert.Equal("layer-arn", (string)properties["Layers"]![0]!);
        Assert.Equal("Environment", (string)properties["Tags"]![0]!["Value"]!["Ref"]!);
        Assert.Equal("SubnetB", (string)properties["VpcConfig"]!["SubnetIds"]![1]!["Ref"]!);
        Assert.NotNull(properties["VpcConfig"]!["SecurityGroupIds"]!["Fn::Split"]);
        Assert.Equal("value", (string)properties["Environment"]!["Variables"]!["PLAIN"]!);
        Assert.Equal("Environment", (string)properties["Environment"]!["Variables"]!["REFERENCE"]!["Ref"]!);
    }

    [Fact]
    public void MapsAcceptPlainDictionariesAndWholeMapExpressions()
    {
        var properties = SerializeProperties(new Lambda.Function
        {
            Environment = new Lambda.FunctionTypes.Environment
            {
                Variables = new Dictionary<string, string> { ["ENV"] = "test" }
            }
        });
        Assert.Equal("test", (string)properties["Environment"]!["Variables"]!["ENV"]!);

        properties = SerializeProperties(new Lambda.Function
        {
            Environment = new Lambda.FunctionTypes.Environment { Variables = Fn.Ref("EnvironmentMap") }
        });
        Assert.Equal("EnvironmentMap", (string)properties["Environment"]!["Variables"]!["Ref"]!);
    }

    [Fact]
    public void ResourceNamesAndFactoryReferencesStillSerializeCorrectly()
    {
        var bucket = new S3.Bucket { BucketName = "Images" };
        Assert.Equal("Images", bucket.ResourceName);

        var properties = SerializeProperties(new S3.BucketPolicy
        {
            Bucket = new FFnREF(new ResultHolder(bucket)),
            PolicyDocument = new PolicyDocument { Version = "2012-10-17" }
        });
        Assert.Equal("Images", (string)properties["Bucket"]!["Ref"]!);
        Assert.Equal("2012-10-17", (string)properties["PolicyDocument"]!["Version"]!);

        bucket.BucketName = Fn.Sub("${AWS::StackName}-images");
        Assert.Equal("${AWS::StackName}-images", (string)SerializeProperties(bucket)["BucketName"]!["Fn::Sub"]!);
    }

    [Fact]
    public void ExplicitLiteralsKeepAlternativeWireRepresentations()
    {
        var properties = SerializeProperties(new AutoScaling.AutoScalingGroup
        {
            MinSize = Fn.Literal(1),
            MaxSize = "2"
        });
        Assert.Equal(JTokenType.Integer, properties["MinSize"]!.Type);
        Assert.Equal(1, (int)properties["MinSize"]!);
        Assert.Equal(JTokenType.String, properties["MaxSize"]!.Type);
    }

    [Fact]
    public void FunctionsCanConsumeAlreadyWrappedPropertyValues()
    {
        Union<string, BaseFunction> text = "hello";
        var properties = SerializeProperties(new Lambda.Function
        {
            Description = new FnStringJoin(text, " world"),
            Code = new Code { ZipFile = Fn.Base64(text) }
        });

        Assert.Equal("hello world", (string)properties["Description"]!);
        Assert.Equal("hello" + System.Environment.NewLine, (string)properties["Code"]!["ZipFile"]!["Fn::Base64"]!);
    }

    [Fact]
    public void WrappedValuesKeepTheirLiteralStringRepresentation()
    {
        Union<string, BaseFunction>? name = "Images";
        Assert.Equal("Images", $"{name}");
        Assert.Equal(string.Empty, default(Union<string, BaseFunction>).ToString());
    }

    [Fact]
    public void JoinListSerializesFlatLiteralsMixedEntriesAndDeferredLists()
    {
        Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? values = new[] { "a", "b" };
        var properties = SerializeProperties(new Lambda.Function { Description = Fn.JoinList(",", values) });
        Assert.Equal("[\"a\",\"b\"]", properties["Description"]!["Fn::Join"]![1]!.ToString(Newtonsoft.Json.Formatting.None));

        values = new Union<string, BaseFunction>[] { "a", Fn.Ref("Other") };
        properties = SerializeProperties(new Lambda.Function { Description = Fn.JoinList(",", values) });
        Assert.Equal("Other", (string)properties["Description"]!["Fn::Join"]![1]![1]!["Ref"]!);

        values = Fn.Ref("Subnets");
        properties = SerializeProperties(new Lambda.Function { Description = Fn.JoinList(",", values) });
        Assert.Equal("Subnets", (string)properties["Description"]!["Fn::Join"]![1]!["Ref"]!);
    }

    [Fact]
    public void AllGeneratedDtoPropertiesUseUnions()
    {
        var properties = typeof(Fn).Assembly.GetTypes()
            .Where(type => typeof(BaseHumidifierDTO).IsAssignableFrom(type) &&
                           type.Namespace?.StartsWith("Humidifier.", StringComparison.Ordinal) == true &&
                           type.Namespace != typeof(BaseResource).Namespace &&
                           !type.Namespace!.StartsWith("Humidifier.Serverless", StringComparison.Ordinal))
            .SelectMany(type => type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            .Where(property => property.Name != "AWSTypeName")
            .ToArray();

        Assert.NotEmpty(properties);
        Assert.All(properties, property =>
        {
            var type = Nullable.GetUnderlyingType(property.PropertyType);
            Assert.True(type?.IsGenericType == true &&
                        (type.GetGenericTypeDefinition() == typeof(Union<,>) ||
                         type.GetGenericTypeDefinition() == typeof(Union<,,>)),
                $"{property.DeclaringType!.FullName}.{property.Name}: {property.PropertyType}");
        });
    }

    [Fact]
    public void AllIntrinsicAndFactoryExpressionsDeriveFromBaseFunction()
    {
        var expressionTypes = typeof(Fn).Assembly.GetTypes().Where(type => type.IsClass && type != typeof(Fn) &&
            (type.Name.StartsWith("Fn", StringComparison.Ordinal) ||
             type.Name.StartsWith("FFn", StringComparison.Ordinal) || type == typeof(FFNamedList)));

        Assert.All(expressionTypes, type => Assert.True(typeof(BaseFunction).IsAssignableFrom(type), type.FullName));
    }

    private static JObject SerializeProperties(BaseResource resource)
    {
        var stack = new Stack();
        stack.Add("Resource", resource);
        var json = JObject.Parse(new JsonStackSerializer().Serialize(stack));
        return (JObject)json["Resources"]!["Resource"]!["Properties"]!;
    }
}
