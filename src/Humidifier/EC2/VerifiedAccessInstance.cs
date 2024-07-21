namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VerifiedAccessInstanceTypes;

    public class VerifiedAccessInstance : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string VerifiedAccessInstanceId =  "VerifiedAccessInstanceId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::VerifiedAccessInstance";
            }
        }

        /// <summary>
        /// VerifiedAccessTrustProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VerifiedAccessTrustProvider
        /// </summary>
        public List<VerifiedAccessTrustProvider> VerifiedAccessTrustProviders { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// FipsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-fipsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic FipsEnabled { get; set; }
        /// <summary>
        /// LoggingConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-loggingconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VerifiedAccessLogs
        /// </summary>
        public VerifiedAccessLogs LoggingConfigurations { get; set; }
        /// <summary>
        /// VerifiedAccessTrustProviderIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustproviderids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic VerifiedAccessTrustProviderIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessinstance.html#cfn-ec2-verifiedaccessinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace VerifiedAccessInstanceTypes
    {
        public class CloudWatchLogs
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-cloudwatchlogs.html#cfn-ec2-verifiedaccessinstance-cloudwatchlogs-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-cloudwatchlogs.html#cfn-ec2-verifiedaccessinstance-cloudwatchlogs-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class KinesisDataFirehose
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-kinesisdatafirehose.html#cfn-ec2-verifiedaccessinstance-kinesisdatafirehose-deliverystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-kinesisdatafirehose.html#cfn-ec2-verifiedaccessinstance-kinesisdatafirehose-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class S3
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-s3.html#cfn-ec2-verifiedaccessinstance-s3-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
        }

        public class VerifiedAccessLogs
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public S3 S3 { get; set; }
            /// <summary>
            /// LogVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-logversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogVersion { get; set; }
            /// <summary>
            /// KinesisDataFirehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-kinesisdatafirehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisDataFirehose
            /// </summary>
            public KinesisDataFirehose KinesisDataFirehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogs
            /// </summary>
            public CloudWatchLogs CloudWatchLogs { get; set; }
            /// <summary>
            /// IncludeTrustContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesslogs.html#cfn-ec2-verifiedaccessinstance-verifiedaccesslogs-includetrustcontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeTrustContext { get; set; }
        }

        public class VerifiedAccessTrustProvider
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// DeviceTrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-devicetrustprovidertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTrustProviderType { get; set; }
            /// <summary>
            /// VerifiedAccessTrustProviderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-verifiedaccesstrustproviderid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerifiedAccessTrustProviderId { get; set; }
            /// <summary>
            /// TrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-trustprovidertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrustProviderType { get; set; }
            /// <summary>
            /// UserTrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessinstance-verifiedaccesstrustprovider.html#cfn-ec2-verifiedaccessinstance-verifiedaccesstrustprovider-usertrustprovidertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserTrustProviderType { get; set; }
        }
    }
}