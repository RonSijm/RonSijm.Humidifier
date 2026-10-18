namespace Humidifier.SecurityLake
{
    using global::System.Collections.Generic;
    using DataLakeTypes;

    public class DataLake : Humidifier.Base.BaseResource, IHaveTags, IHaveSecurityLakeDataLakeTypesEncryptionConfigurationEncryptionConfiguration, IHaveSecurityLakeDataLakeTypesLifecycleConfigurationLifecycleConfiguration, IHaveSecurityLakeDataLakeTypesReplicationConfigurationReplicationConfiguration, IHaveMetaStoreManagerRoleArn
    {
        public class Attributes
        {
            public static string S3BucketArn =  "S3BucketArn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityLake.DataLake; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public Union<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }
        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public Union<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration, BaseFunction>? ReplicationConfiguration { get; set; }
        /// <summary>
        /// MetaStoreManagerRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-metastoremanagerrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MetaStoreManagerRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-datalake.html#cfn-securitylake-datalake-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataLakeTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-encryptionconfiguration.html#cfn-securitylake-datalake-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class Expiration : Humidifier.Base.BaseSubResource, IHaveDays_Integer
        {
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-expiration.html#cfn-securitylake-datalake-expiration-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Days { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfSecurityLakeDataLakeTypesTransitionsTransitions, IHaveSecurityLakeDataLakeTypesExpirationExpiration
        {
            /// <summary>
            /// Transitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-lifecycleconfiguration.html#cfn-securitylake-datalake-lifecycleconfiguration-transitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transitions
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityLake.DataLakeTypes.Transitions>, IReadOnlyList<Union<Humidifier.SecurityLake.DataLakeTypes.Transitions, BaseFunction>>, BaseFunction>? Transitions { get; set; }
            /// <summary>
            /// Expiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-lifecycleconfiguration.html#cfn-securitylake-datalake-lifecycleconfiguration-expiration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expiration
            /// </summary>
            public Union<Humidifier.SecurityLake.DataLakeTypes.Expiration, BaseFunction>? Expiration { get; set; }
        }

        public class ReplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfRegions, IHaveRoleArn
        {
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-replicationconfiguration.html#cfn-securitylake-datalake-replicationconfiguration-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-replicationconfiguration.html#cfn-securitylake-datalake-replicationconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class Transitions : Humidifier.Base.BaseSubResource, IHaveStorageClass, IHaveDays_Integer
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-transitions.html#cfn-securitylake-datalake-transitions-storageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-datalake-transitions.html#cfn-securitylake-datalake-transitions-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Days { get; set; }
        }
    }
}