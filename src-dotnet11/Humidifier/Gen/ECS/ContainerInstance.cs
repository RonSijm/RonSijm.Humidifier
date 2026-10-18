namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ContainerInstanceTypes;

    public class ContainerInstance : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Ec2InstanceId =  "Ec2InstanceId" ;
            public static string Status =  "Status" ;
            public static string RemainingResources =  "RemainingResources" ;
            public static string ContainerInstanceArn =  "ContainerInstanceArn" ;
            public static string ContainerInstanceId =  "ContainerInstanceId" ;
            public static string Attributes_ =  "Attributes_" ;
            public static string Cluster =  "Cluster" ;
            public static string RunningTasksCount =  "RunningTasksCount" ;
            public static string VersionInfo =  "VersionInfo" ;
            public static string AgentConnected =  "AgentConnected" ;
            public static string Version =  "Version" ;
            public static string PendingTasksCount =  "PendingTasksCount" ;
            public static string RegisteredResources =  "RegisteredResources" ;
            public static string RegisteredAt =  "RegisteredAt" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.ECS.ContainerInstance; }
    }

    namespace ContainerInstanceTypes
    {
        public class Attribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-attribute.html#cfn-ecs-containerinstance-attribute-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-attribute.html#cfn-ecs-containerinstance-attribute-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource, IHaveLongValue_Double, IHaveType, IHaveStringListOfStringSetValue, IHaveDoubleValue_Double, IHaveIntegerValue_Integer, IHaveName
        {
            /// <summary>
            /// LongValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-resource.html#cfn-ecs-containerinstance-resource-longvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LongValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-resource.html#cfn-ecs-containerinstance-resource-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// StringSetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-resource.html#cfn-ecs-containerinstance-resource-stringsetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringSetValue { get; set; }
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-resource.html#cfn-ecs-containerinstance-resource-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// IntegerValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-resource.html#cfn-ecs-containerinstance-resource-integervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntegerValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-resource.html#cfn-ecs-containerinstance-resource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class VersionInfo : Humidifier.Base.BaseSubResource, IHaveDockerVersion, IHaveAgentVersion, IHaveAgentHash
        {
            /// <summary>
            /// DockerVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-versioninfo.html#cfn-ecs-containerinstance-versioninfo-dockerversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DockerVersion { get; set; }
            /// <summary>
            /// AgentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-versioninfo.html#cfn-ecs-containerinstance-versioninfo-agentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentVersion { get; set; }
            /// <summary>
            /// AgentHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-containerinstance-versioninfo.html#cfn-ecs-containerinstance-versioninfo-agenthash
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentHash { get; set; }
        }
    }
}