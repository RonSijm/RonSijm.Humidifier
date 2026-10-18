namespace Humidifier.Athena
{
    using global::System.Collections.Generic;
    using WorkGroupTypes;

    public class WorkGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRecursiveDeleteOption_Boolean, IHaveAthenaWorkGroupTypesWorkGroupConfigurationWorkGroupConfiguration, IHaveDescription, IHaveState, IHaveName
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.Athena.WorkGroup; }
        /// <summary>
        /// RecursiveDeleteOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-workgroup.html#cfn-athena-workgroup-recursivedeleteoption
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RecursiveDeleteOption { get; set; }
        /// <summary>
        /// WorkGroupConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-workgroup.html#cfn-athena-workgroup-workgroupconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkGroupConfiguration
        /// </summary>
        public Union<Humidifier.Athena.WorkGroupTypes.WorkGroupConfiguration, BaseFunction>? WorkGroupConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-workgroup.html#cfn-athena-workgroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-workgroup.html#cfn-athena-workgroup-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-workgroup.html#cfn-athena-workgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkGroupTypes
    {
        public class AclConfiguration : Humidifier.Base.BaseSubResource, IHaveS3AclOption
        {
            /// <summary>
            /// S3AclOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-aclconfiguration.html#cfn-athena-workgroup-aclconfiguration-s3acloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3AclOption { get; set; }
        }

        public class Classification : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveName
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-classification.html#cfn-athena-workgroup-classification-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-classification.html#cfn-athena-workgroup-classification-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CloudWatchLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveEnabled_Boolean, IHaveLogStreamNamePrefix, IHaveLogTypes_Json
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-cloudwatchloggingconfiguration.html#cfn-athena-workgroup-cloudwatchloggingconfiguration-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-cloudwatchloggingconfiguration.html#cfn-athena-workgroup-cloudwatchloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-cloudwatchloggingconfiguration.html#cfn-athena-workgroup-cloudwatchloggingconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-cloudwatchloggingconfiguration.html#cfn-athena-workgroup-cloudwatchloggingconfiguration-logtypes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? LogTypes { get; set; }
        }

        public class CustomerContentEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKey
        {
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-customercontentencryptionconfiguration.html#cfn-athena-workgroup-customercontentencryptionconfiguration-kmskey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionOption, IHaveKmsKey
        {
            /// <summary>
            /// EncryptionOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-encryptionconfiguration.html#cfn-athena-workgroup-encryptionconfiguration-encryptionoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionOption { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-encryptionconfiguration.html#cfn-athena-workgroup-encryptionconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class EngineConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfSparkProperties, IHaveListOfAthenaWorkGroupTypesClassificationClassifications, IHaveMaxConcurrentDpus_Integer, IHaveCoordinatorDpuSize_Integer, IHaveDefaultExecutorDpuSize_Integer, IHaveStringDictionaryOfAdditionalConfigs
        {
            /// <summary>
            /// SparkProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineconfiguration.html#cfn-athena-workgroup-engineconfiguration-sparkproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? SparkProperties { get; set; }
            /// <summary>
            /// Classifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineconfiguration.html#cfn-athena-workgroup-engineconfiguration-classifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Classification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Athena.WorkGroupTypes.Classification>, IReadOnlyList<Union<Humidifier.Athena.WorkGroupTypes.Classification, BaseFunction>>, BaseFunction>? Classifications { get; set; }
            /// <summary>
            /// MaxConcurrentDpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineconfiguration.html#cfn-athena-workgroup-engineconfiguration-maxconcurrentdpus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentDpus { get; set; }
            /// <summary>
            /// CoordinatorDpuSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineconfiguration.html#cfn-athena-workgroup-engineconfiguration-coordinatordpusize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoordinatorDpuSize { get; set; }
            /// <summary>
            /// DefaultExecutorDpuSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineconfiguration.html#cfn-athena-workgroup-engineconfiguration-defaultexecutordpusize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DefaultExecutorDpuSize { get; set; }
            /// <summary>
            /// AdditionalConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineconfiguration.html#cfn-athena-workgroup-engineconfiguration-additionalconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalConfigs { get; set; }
        }

        public class EngineVersion : Humidifier.Base.BaseSubResource, IHaveSelectedEngineVersion, IHaveEffectiveEngineVersion
        {
            /// <summary>
            /// SelectedEngineVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineversion.html#cfn-athena-workgroup-engineversion-selectedengineversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectedEngineVersion { get; set; }
            /// <summary>
            /// EffectiveEngineVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineversion.html#cfn-athena-workgroup-engineversion-effectiveengineversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EffectiveEngineVersion { get; set; }
        }

        public class ManagedLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveKmsKey
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-managedloggingconfiguration.html#cfn-athena-workgroup-managedloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-managedloggingconfiguration.html#cfn-athena-workgroup-managedloggingconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class ManagedQueryResultsConfiguration : Humidifier.Base.BaseSubResource, IHaveAthenaWorkGroupTypesManagedStorageEncryptionConfigurationEncryptionConfiguration, IHaveEnabled_Boolean
        {
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-managedqueryresultsconfiguration.html#cfn-athena-workgroup-managedqueryresultsconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedStorageEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-managedqueryresultsconfiguration.html#cfn-athena-workgroup-managedqueryresultsconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ManagedStorageEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKey
        {
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-managedstorageencryptionconfiguration.html#cfn-athena-workgroup-managedstorageencryptionconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveAthenaWorkGroupTypesS3LoggingConfigurationS3LoggingConfiguration, IHaveAthenaWorkGroupTypesManagedLoggingConfigurationManagedLoggingConfiguration, IHaveAthenaWorkGroupTypesCloudWatchLoggingConfigurationCloudWatchLoggingConfiguration
        {
            /// <summary>
            /// S3LoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-monitoringconfiguration.html#cfn-athena-workgroup-monitoringconfiguration-s3loggingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3LoggingConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.S3LoggingConfiguration, BaseFunction>? S3LoggingConfiguration { get; set; }
            /// <summary>
            /// ManagedLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-monitoringconfiguration.html#cfn-athena-workgroup-monitoringconfiguration-managedloggingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedLoggingConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.ManagedLoggingConfiguration, BaseFunction>? ManagedLoggingConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-monitoringconfiguration.html#cfn-athena-workgroup-monitoringconfiguration-cloudwatchloggingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.CloudWatchLoggingConfiguration, BaseFunction>? CloudWatchLoggingConfiguration { get; set; }
        }

        public class ResultConfiguration : Humidifier.Base.BaseSubResource, IHaveAthenaWorkGroupTypesEncryptionConfigurationEncryptionConfiguration, IHaveOutputLocation, IHaveAthenaWorkGroupTypesAclConfigurationAclConfiguration, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-resultconfiguration.html#cfn-athena-workgroup-resultconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-resultconfiguration.html#cfn-athena-workgroup-resultconfiguration-outputlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputLocation { get; set; }
            /// <summary>
            /// AclConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-resultconfiguration.html#cfn-athena-workgroup-resultconfiguration-aclconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AclConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.AclConfiguration, BaseFunction>? AclConfiguration { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-resultconfiguration.html#cfn-athena-workgroup-resultconfiguration-expectedbucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        }

        public class S3LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogLocation, IHaveEnabled_Boolean, IHaveKmsKey
        {
            /// <summary>
            /// LogLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-s3loggingconfiguration.html#cfn-athena-workgroup-s3loggingconfiguration-loglocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLocation { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-s3loggingconfiguration.html#cfn-athena-workgroup-s3loggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-s3loggingconfiguration.html#cfn-athena-workgroup-s3loggingconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class WorkGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveEnforceWorkGroupConfiguration_Boolean, IHaveAthenaWorkGroupTypesEngineVersionEngineVersion, IHavePublishCloudWatchMetricsEnabled_Boolean, IHaveAthenaWorkGroupTypesResultConfigurationResultConfiguration, IHaveAdditionalConfiguration, IHaveAthenaWorkGroupTypesEngineConfigurationEngineConfiguration, IHaveAthenaWorkGroupTypesCustomerContentEncryptionConfigurationCustomerContentEncryptionConfiguration, IHaveBytesScannedCutoffPerQuery_Long, IHaveAthenaWorkGroupTypesMonitoringConfigurationMonitoringConfiguration, IHaveRequesterPaysEnabled_Boolean, IHaveAthenaWorkGroupTypesManagedQueryResultsConfigurationManagedQueryResultsConfiguration, IHaveExecutionRole
        {
            /// <summary>
            /// EnforceWorkGroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-enforceworkgroupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnforceWorkGroupConfiguration { get; set; }
            /// <summary>
            /// EngineVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-engineversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EngineVersion
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.EngineVersion, BaseFunction>? EngineVersion { get; set; }
            /// <summary>
            /// PublishCloudWatchMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-publishcloudwatchmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PublishCloudWatchMetricsEnabled { get; set; }
            /// <summary>
            /// ResultConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-resultconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResultConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.ResultConfiguration, BaseFunction>? ResultConfiguration { get; set; }
            /// <summary>
            /// AdditionalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-additionalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalConfiguration { get; set; }
            /// <summary>
            /// EngineConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-engineconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EngineConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.EngineConfiguration, BaseFunction>? EngineConfiguration { get; set; }
            /// <summary>
            /// CustomerContentEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-customercontentencryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerContentEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.CustomerContentEncryptionConfiguration, BaseFunction>? CustomerContentEncryptionConfiguration { get; set; }
            /// <summary>
            /// BytesScannedCutoffPerQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-bytesscannedcutoffperquery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? BytesScannedCutoffPerQuery { get; set; }
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-monitoringconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.MonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
            /// <summary>
            /// RequesterPaysEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-requesterpaysenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequesterPaysEnabled { get; set; }
            /// <summary>
            /// ManagedQueryResultsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-managedqueryresultsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedQueryResultsConfiguration
            /// </summary>
            public Union<Humidifier.Athena.WorkGroupTypes.ManagedQueryResultsConfiguration, BaseFunction>? ManagedQueryResultsConfiguration { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfiguration.html#cfn-athena-workgroup-workgroupconfiguration-executionrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRole { get; set; }
        }
    }
}