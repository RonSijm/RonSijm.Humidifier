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