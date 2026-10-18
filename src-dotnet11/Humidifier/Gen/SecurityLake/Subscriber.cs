namespace Humidifier.SecurityLake
{
    using global::System.Collections.Generic;
    using SubscriberTypes;

    public class Subscriber : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSecurityLakeSubscriberTypesSubscriberIdentitySubscriberIdentity, IHaveSubscriberName, IHaveSubscriberDescription, IHaveStringListOfAccessTypes, IHaveListOfSecurityLakeSubscriberTypesSourceSources, IHaveDataLakeArn, IHaveDescription
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
        public Union<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity, BaseFunction>? SubscriberIdentity { get; set; }
        public Union<string, BaseFunction>? SubscriberName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SubscriberDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-subscriberdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubscriberDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => SubscriberDescription; set => SubscriberDescription = value; }

        /// <summary>
        /// AccessTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-accesstypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccessTypes { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-sources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Source
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SecurityLake.SubscriberTypes.Source>, IReadOnlyList<Union<Humidifier.SecurityLake.SubscriberTypes.Source, BaseFunction>>, BaseFunction>? Sources { get; set; }

        /// <summary>
        /// DataLakeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-datalakearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataLakeArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscriber.html#cfn-securitylake-subscriber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SubscriberTypes
    {
        public class AwsLogSource : Humidifier.Base.BaseSubResource, IHaveSourceName, IHaveSourceVersion
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-awslogsource.html#cfn-securitylake-subscriber-awslogsource-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
            /// <summary>
            /// SourceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-awslogsource.html#cfn-securitylake-subscriber-awslogsource-sourceversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceVersion { get; set; }
        }

        public class CustomLogSource : Humidifier.Base.BaseSubResource, IHaveSourceName, IHaveSourceVersion
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-customlogsource.html#cfn-securitylake-subscriber-customlogsource-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
            /// <summary>
            /// SourceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-customlogsource.html#cfn-securitylake-subscriber-customlogsource-sourceversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceVersion { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveSecurityLakeSubscriberTypesAwsLogSourceAwsLogSource, IHaveSecurityLakeSubscriberTypesCustomLogSourceCustomLogSource
        {
            /// <summary>
            /// AwsLogSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-source.html#cfn-securitylake-subscriber-source-awslogsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsLogSource
            /// </summary>
            public Union<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource, BaseFunction>? AwsLogSource { get; set; }
            /// <summary>
            /// CustomLogSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-source.html#cfn-securitylake-subscriber-source-customlogsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomLogSource
            /// </summary>
            public Union<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource, BaseFunction>? CustomLogSource { get; set; }
        }

        public class SubscriberIdentity : Humidifier.Base.BaseSubResource, IHaveExternalId, IHavePrincipal
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-subscriberidentity.html#cfn-securitylake-subscriber-subscriberidentity-externalid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscriber-subscriberidentity.html#cfn-securitylake-subscriber-subscriberidentity-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }
    }
}