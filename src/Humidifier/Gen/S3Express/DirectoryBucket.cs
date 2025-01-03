namespace Humidifier.S3Express
{
    using System.Collections.Generic;
    using DirectoryBucketTypes;

    public class DirectoryBucket : Humidifier.Base.BaseResource, IHaveBucketName, IHaveLocationName
    {
        public class Attributes
        {
            public static string AvailabilityZoneName =  "AvailabilityZoneName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.S3Express.DirectoryBucket; }
        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-bucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketName { get; set; }
        /// <summary>
        /// BucketEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-bucketencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BucketEncryption
        /// </summary>
        public Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption BucketEncryption { get; set; }

        /// <summary>
        /// DataRedundancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-dataredundancy
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataRedundancy { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration LifecycleConfiguration { get; set; }

        /// <summary>
        /// LocationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-locationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocationName { get; set; }
    }

    namespace DirectoryBucketTypes
    {
        public class AbortIncompleteMultipartUpload : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DaysAfterInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-abortincompletemultipartupload.html#cfn-s3express-directorybucket-abortincompletemultipartupload-daysafterinitiation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysAfterInitiation { get; set; }
        }

        public class BucketEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerSideEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-bucketencryption.html#cfn-s3express-directorybucket-bucketencryption-serversideencryptionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerSideEncryptionRule
            /// </summary>
            public List<Humidifier.S3Express.DirectoryBucketTypes.ServerSideEncryptionRule> ServerSideEncryptionConfiguration { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-lifecycleconfiguration.html#cfn-s3express-directorybucket-lifecycleconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public List<Humidifier.S3Express.DirectoryBucketTypes.Rule> Rules { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveId, IHavePrefix, IHaveExpirationInDays
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpirationInDays { get; set; }
            /// <summary>
            /// ObjectSizeGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-objectsizegreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectSizeGreaterThan { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// AbortIncompleteMultipartUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-abortincompletemultipartupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbortIncompleteMultipartUpload
            /// </summary>
            public Humidifier.S3Express.DirectoryBucketTypes.AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload { get; set; }
            /// <summary>
            /// ObjectSizeLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-objectsizelessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectSizeLessThan { get; set; }
        }

        public class ServerSideEncryptionByDefault : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionbydefault.html#cfn-s3express-directorybucket-serversideencryptionbydefault-ssealgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SSEAlgorithm { get; set; }
            /// <summary>
            /// KMSMasterKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionbydefault.html#cfn-s3express-directorybucket-serversideencryptionbydefault-kmsmasterkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSMasterKeyID { get; set; }
        }

        public class ServerSideEncryptionRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionrule.html#cfn-s3express-directorybucket-serversideencryptionrule-bucketkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BucketKeyEnabled { get; set; }
            /// <summary>
            /// ServerSideEncryptionByDefault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionrule.html#cfn-s3express-directorybucket-serversideencryptionrule-serversideencryptionbydefault
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerSideEncryptionByDefault
            /// </summary>
            public Humidifier.S3Express.DirectoryBucketTypes.ServerSideEncryptionByDefault ServerSideEncryptionByDefault { get; set; }
        }
    }
}