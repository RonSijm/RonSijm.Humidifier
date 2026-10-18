namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using ManagedInstanceTypes;

    public class ManagedInstance : Humidifier.Base.BaseResource, IHaveListOfSSMManagedInstanceTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string PlatformName =  "PlatformName" ;
            public static string PlatformVersion =  "PlatformVersion" ;
            public static string IsLatestVersion =  "IsLatestVersion" ;
            public static string InstanceId =  "InstanceId" ;
            public static string AgentVersion =  "AgentVersion" ;
            public static string ComputerName =  "ComputerName" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Arn =  "Arn" ;
            public static string PlatformType =  "PlatformType" ;
            public static string IPAddress =  "IPAddress" ;
            public static string PingStatus =  "PingStatus" ;
        }

        public override string AWSTypeName { get => AWS.SSM.ManagedInstance; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-managedinstance.html#cfn-ssm-managedinstance-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSM.ManagedInstanceTypes.TagsItems>, IReadOnlyList<Union<Humidifier.SSM.ManagedInstanceTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ManagedInstanceTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-managedinstance-tagsitems.html#cfn-ssm-managedinstance-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-managedinstance-tagsitems.html#cfn-ssm-managedinstance-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}