namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using FeatureGroupTypes;

    public class FeatureGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveRoleArn
    {
        public class Attributes
        {
            public static string FeatureGroupStatus =  "FeatureGroupStatus" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.FeatureGroup; }
        /// <summary>
        /// ThroughputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-throughputconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThroughputConfig
        /// </summary>
        public Humidifier.SageMaker.FeatureGroupTypes.ThroughputConfig ThroughputConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// OfflineStoreConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-offlinestoreconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OfflineStoreConfig
        /// </summary>
        public Humidifier.SageMaker.FeatureGroupTypes.OfflineStoreConfig OfflineStoreConfig { get; set; }

        /// <summary>
        /// FeatureDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-featuredefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FeatureDefinition
        /// </summary>
        [Required]
        public List<Humidifier.SageMaker.FeatureGroupTypes.FeatureDefinition> FeatureDefinitions { get; set; }

        /// <summary>
        /// RecordIdentifierFeatureName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-recordidentifierfeaturename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecordIdentifierFeatureName { get; set; }

        /// <summary>
        /// EventTimeFeatureName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-eventtimefeaturename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventTimeFeatureName { get; set; }
        public dynamic FeatureGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OnlineStoreConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-onlinestoreconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnlineStoreConfig
        /// </summary>
        public Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig OnlineStoreConfig { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html#cfn-sagemaker-featuregroup-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace FeatureGroupTypes
    {
        public class DataCatalogConfig : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDatabase, IHaveCatalog
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-datacatalogconfig.html#cfn-sagemaker-featuregroup-datacatalogconfig-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-datacatalogconfig.html#cfn-sagemaker-featuregroup-datacatalogconfig-database
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Database { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-datacatalogconfig.html#cfn-sagemaker-featuregroup-datacatalogconfig-catalog
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Catalog { get; set; }
        }

        public class FeatureDefinition : Humidifier.Base.BaseSubResource, IHaveFeatureName
        {
            /// <summary>
            /// FeatureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-featuredefinition.html#cfn-sagemaker-featuregroup-featuredefinition-featuretype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeatureType { get; set; }
            /// <summary>
            /// FeatureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-featuredefinition.html#cfn-sagemaker-featuregroup-featuredefinition-featurename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeatureName { get; set; }
        }

        public class OfflineStoreConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataCatalogConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-offlinestoreconfig.html#cfn-sagemaker-featuregroup-offlinestoreconfig-datacatalogconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DataCatalogConfig
            /// </summary>
            public Humidifier.SageMaker.FeatureGroupTypes.DataCatalogConfig DataCatalogConfig { get; set; }
            /// <summary>
            /// S3StorageConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-offlinestoreconfig.html#cfn-sagemaker-featuregroup-offlinestoreconfig-s3storageconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3StorageConfig
            /// </summary>
            public Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig S3StorageConfig { get; set; }
            /// <summary>
            /// DisableGlueTableCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-offlinestoreconfig.html#cfn-sagemaker-featuregroup-offlinestoreconfig-disablegluetablecreation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableGlueTableCreation { get; set; }
            /// <summary>
            /// TableFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-offlinestoreconfig.html#cfn-sagemaker-featuregroup-offlinestoreconfig-tableformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableFormat { get; set; }
        }

        public class OnlineStoreConfig : Humidifier.Base.BaseSubResource, IHaveStorageType
        {
            /// <summary>
            /// EnableOnlineStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-onlinestoreconfig.html#cfn-sagemaker-featuregroup-onlinestoreconfig-enableonlinestore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableOnlineStore { get; set; }
            /// <summary>
            /// StorageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-onlinestoreconfig.html#cfn-sagemaker-featuregroup-onlinestoreconfig-storagetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageType { get; set; }
            /// <summary>
            /// SecurityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-onlinestoreconfig.html#cfn-sagemaker-featuregroup-onlinestoreconfig-securityconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OnlineStoreSecurityConfig
            /// </summary>
            public Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig SecurityConfig { get; set; }
            /// <summary>
            /// TtlDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-onlinestoreconfig.html#cfn-sagemaker-featuregroup-onlinestoreconfig-ttlduration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TtlDuration
            /// </summary>
            public Humidifier.SageMaker.FeatureGroupTypes.TtlDuration TtlDuration { get; set; }
        }

        public class OnlineStoreSecurityConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-onlinestoresecurityconfig.html#cfn-sagemaker-featuregroup-onlinestoresecurityconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
        }

        public class S3StorageConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3Uri
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-s3storageconfig.html#cfn-sagemaker-featuregroup-s3storageconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-s3storageconfig.html#cfn-sagemaker-featuregroup-s3storageconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class ThroughputConfig : Humidifier.Base.BaseSubResource, IHaveThroughputMode
        {
            /// <summary>
            /// ProvisionedReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-throughputconfig.html#cfn-sagemaker-featuregroup-throughputconfig-provisionedreadcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProvisionedReadCapacityUnits { get; set; }
            /// <summary>
            /// ProvisionedWriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-throughputconfig.html#cfn-sagemaker-featuregroup-throughputconfig-provisionedwritecapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProvisionedWriteCapacityUnits { get; set; }
            /// <summary>
            /// ThroughputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-throughputconfig.html#cfn-sagemaker-featuregroup-throughputconfig-throughputmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThroughputMode { get; set; }
        }

        public class TtlDuration : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-ttlduration.html#cfn-sagemaker-featuregroup-ttlduration-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-ttlduration.html#cfn-sagemaker-featuregroup-ttlduration-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }
    }
}