namespace Humidifier.SecurityLake
{
    using System.Collections.Generic;
    using DataLakeTypes;

    public class DataLake : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string S3BucketArn =  "S3BucketArn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecurityLake::DataLake";
            }
        }

        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public LifecycleConfiguration LifecycleConfiguration { get; set; }
        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public ReplicationConfiguration ReplicationConfiguration { get; set; }
        /// <summary>
        /// MetaStoreManagerRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-metastoremanagerrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MetaStoreManagerRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DataLakeTypes
    {
        public class EncryptionConfiguration
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-encryptionconfiguration.html#cfn-securitylake-datalake-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
        }

        public class Expiration
        {
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-expiration.html#cfn-securitylake-datalake-expiration-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Days { get; set; }
        }

        public class LifecycleConfiguration
        {
            /// <summary>
            /// Transitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-lifecycleconfiguration.html#cfn-securitylake-datalake-lifecycleconfiguration-transitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transitions
            /// </summary>
            public List<Transitions> Transitions { get; set; }
            /// <summary>
            /// Expiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-lifecycleconfiguration.html#cfn-securitylake-datalake-lifecycleconfiguration-expiration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expiration
            /// </summary>
            public Expiration Expiration { get; set; }
        }

        public class ReplicationConfiguration
        {
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-replicationconfiguration.html#cfn-securitylake-datalake-replicationconfiguration-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Regions { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-replicationconfiguration.html#cfn-securitylake-datalake-replicationconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class Transitions
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-transitions.html#cfn-securitylake-datalake-transitions-storageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-transitions.html#cfn-securitylake-datalake-transitions-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Days { get; set; }
        }
    }
}