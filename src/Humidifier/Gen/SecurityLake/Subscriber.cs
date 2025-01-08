namespace Humidifier.SecurityLake
{
    using System.Collections.Generic;
    using SubscriberTypes;

    public class Subscriber : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataLakeArn, IHaveDescription
    {
        public class Attributes
        {
            public static string ResourceShareName =  "ResourceShareName" ;
            public static string SubscriberRoleArn =  "SubscriberRoleArn" ;
            public static string ResourceShareArn =  "ResourceShareArn" ;
            public static string SubscriberArn =  "SubscriberArn" ;
            public static string S3BucketArn =  "S3BucketArn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityLake.Subscriber; }

        /// <summary>
        /// SubscriberIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-subscriberidentity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SubscriberIdentity
        /// </summary>
        [Required]
        public Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity SubscriberIdentity { get; set; }
        public dynamic SubscriberName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SubscriberDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-subscriberdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SubscriberDescription { get; set; }

        [Ignore]
        public dynamic Description { get => SubscriberDescription; set => SubscriberDescription = value; }

        /// <summary>
        /// AccessTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-accesstypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic AccessTypes { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-sources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Source
        /// </summary>
        [Required]
        public List<Humidifier.SecurityLake.SubscriberTypes.Source> Sources { get; set; }

        /// <summary>
        /// DataLakeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-datalakearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataLakeArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace SubscriberTypes
    {
        public class AwsLogSource : Humidifier.Base.BaseSubResource, IHaveSourceVersion, IHaveSourceName
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-awslogsource.html#cfn-securitylake-subscriber-awslogsource-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
            /// <summary>
            /// SourceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-awslogsource.html#cfn-securitylake-subscriber-awslogsource-sourceversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceVersion { get; set; }
        }

        public class CustomLogSource : Humidifier.Base.BaseSubResource, IHaveSourceVersion, IHaveSourceName
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-customlogsource.html#cfn-securitylake-subscriber-customlogsource-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
            /// <summary>
            /// SourceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-customlogsource.html#cfn-securitylake-subscriber-customlogsource-sourceversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceVersion { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AwsLogSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-source.html#cfn-securitylake-subscriber-source-awslogsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsLogSource
            /// </summary>
            public Humidifier.SecurityLake.SubscriberTypes.AwsLogSource AwsLogSource { get; set; }
            /// <summary>
            /// CustomLogSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-source.html#cfn-securitylake-subscriber-source-customlogsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomLogSource
            /// </summary>
            public Humidifier.SecurityLake.SubscriberTypes.CustomLogSource CustomLogSource { get; set; }
        }

        public class SubscriberIdentity : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveExternalId
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-subscriberidentity.html#cfn-securitylake-subscriber-subscriberidentity-externalid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-subscriberidentity.html#cfn-securitylake-subscriber-subscriberidentity-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }
    }
}