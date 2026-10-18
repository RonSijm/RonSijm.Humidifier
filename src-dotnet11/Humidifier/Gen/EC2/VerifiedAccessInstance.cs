namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VerifiedAccessInstanceTypes;

    public class VerifiedAccessInstance : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfEC2VerifiedAccessInstanceTypesVerifiedAccessTrustProviderVerifiedAccessTrustProviders, IHaveDescription, IHaveFipsEnabled_Boolean, IHaveEC2VerifiedAccessInstanceTypesVerifiedAccessLogsLoggingConfigurations, IHaveCidrEndpointsCustomSubDomain, IHaveStringListOfVerifiedAccessTrustProviderIds
    {
        public class Attributes
        {
            public static string CidrEndpointsCustomSubDomainNameServers =  "CidrEndpointsCustomSubDomainNameServers" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string VerifiedAccessInstanceId =  "VerifiedAccessInstanceId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VerifiedAccessInstance; }
        /// <summary>
        /// VerifiedAccessTrustProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VerifiedAccessTrustProvider
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider>, IReadOnlyList<Union<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessTrustProvider, BaseFunction>>, BaseFunction>? VerifiedAccessTrustProviders { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// FipsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-fipsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FipsEnabled { get; set; }
        /// <summary>
        /// LoggingConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-loggingconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VerifiedAccessLogs
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessInstanceTypes.VerifiedAccessLogs, BaseFunction>? LoggingConfigurations { get; set; }
        /// <summary>
        /// CidrEndpointsCustomSubDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-cidrendpointscustomsubdomain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CidrEndpointsCustomSubDomain { get; set; }
        /// <summary>
        /// VerifiedAccessTrustProviderIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustproviderids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VerifiedAccessTrustProviderIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VerifiedAccessInstanceTypes
    {
        public class CloudWatchLogs : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveEnabled_Boolean
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-cloudwatchlogs.html#cfn-ec2-verifiedaccessinstance-cloudwatchlogs-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-cloudwatchlogs.html#cfn-ec2-verifiedaccessinstance-cloudwatchlogs-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class KinesisDataFirehose : Humidifier.Base.BaseSubResource, IHaveDeliveryStream, IHaveEnabled_Boolean
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-kinesisdatafirehose.html#cfn-ec2-verifiedaccessinstance-kinesisdatafirehose-deliverystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-kinesisdatafirehose.html#cfn-ec2-verifiedaccessinstance-kinesisdatafirehose-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveEnabled_Boolean, IHavePrefix, IHaveBucketOwner
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
        }

        public class VerifiedAccessLogs : Humidifier.Base.BaseSubResource, IHaveEC2VerifiedAccessInstanceTypesS3S3, IHaveLogVersion, IHaveEC2VerifiedAccessInstanceTypesKinesisDataFirehoseKinesisDataFirehose, IHaveEC2VerifiedAccessInstanceTypesCloudWatchLogsCloudWatchLogs, IHaveIncludeTrustContext_Boolean
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Union<Humidifier.EC2.VerifiedAccessInstanceTypes.S3, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// LogVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-logversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogVersion { get; set; }
            /// <summary>
            /// KinesisDataFirehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-kinesisdatafirehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisDataFirehose
            /// </summary>
            public Union<Humidifier.EC2.VerifiedAccessInstanceTypes.KinesisDataFirehose, BaseFunction>? KinesisDataFirehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogs
            /// </summary>
            public Union<Humidifier.EC2.VerifiedAccessInstanceTypes.CloudWatchLogs, BaseFunction>? CloudWatchLogs { get; set; }
            /// <summary>
            /// IncludeTrustContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-includetrustcontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeTrustContext { get; set; }
        }

        public class VerifiedAccessTrustProvider : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveDeviceTrustProviderType, IHaveVerifiedAccessTrustProviderId, IHaveTrustProviderType, IHaveUserTrustProviderType
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// DeviceTrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-devicetrustprovidertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTrustProviderType { get; set; }
            /// <summary>
            /// VerifiedAccessTrustProviderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-verifiedaccesstrustproviderid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VerifiedAccessTrustProviderId { get; set; }
            /// <summary>
            /// TrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-trustprovidertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustProviderType { get; set; }
            /// <summary>
            /// UserTrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-usertrustprovidertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserTrustProviderType { get; set; }
        }
    }
}