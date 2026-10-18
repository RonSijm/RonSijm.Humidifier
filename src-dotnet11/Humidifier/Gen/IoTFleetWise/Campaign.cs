namespace Humidifier.IoTFleetWise
{
    using global::System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAction, IHaveCompression, IHaveDescription, IHaveListOfIoTFleetWiseCampaignTypesDataPartitionDataPartitions, IHavePriority_Integer, IHaveListOfIoTFleetWiseCampaignTypesSignalInformationSignalsToCollect, IHaveStartTime, IHaveListOfIoTFleetWiseCampaignTypesSignalFetchInformationSignalsToFetch, IHaveExpiryTime, IHaveSpoolingMode, IHaveListOfIoTFleetWiseCampaignTypesDataDestinationConfigDataDestinationConfigs, IHaveSignalCatalogArn, IHaveName, IHavePostTriggerCollectionDuration_Double, IHaveStringListOfDataExtraDimensions, IHaveDiagnosticsMode, IHaveTargetArn, IHaveIoTFleetWiseCampaignTypesCollectionSchemeCollectionScheme
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastModificationTime =  "LastModificationTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTFleetWise.Campaign; }
        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-action
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Action { get; set; }
        /// <summary>
        /// Compression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-compression
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Compression { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DataPartitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-datapartitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DataPartition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.CampaignTypes.DataPartition>, IReadOnlyList<Union<Humidifier.IoTFleetWise.CampaignTypes.DataPartition, BaseFunction>>, BaseFunction>? DataPartitions { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// SignalsToCollect
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-signalstocollect
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: SignalInformation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.CampaignTypes.SignalInformation>, IReadOnlyList<Union<Humidifier.IoTFleetWise.CampaignTypes.SignalInformation, BaseFunction>>, BaseFunction>? SignalsToCollect { get; set; }
        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-starttime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartTime { get; set; }
        /// <summary>
        /// SignalsToFetch
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-signalstofetch
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: SignalFetchInformation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation>, IReadOnlyList<Union<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation, BaseFunction>>, BaseFunction>? SignalsToFetch { get; set; }
        /// <summary>
        /// ExpiryTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-expirytime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpiryTime { get; set; }
        /// <summary>
        /// SpoolingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-spoolingmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SpoolingMode { get; set; }
        /// <summary>
        /// DataDestinationConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-datadestinationconfigs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DataDestinationConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.CampaignTypes.DataDestinationConfig>, IReadOnlyList<Union<Humidifier.IoTFleetWise.CampaignTypes.DataDestinationConfig, BaseFunction>>, BaseFunction>? DataDestinationConfigs { get; set; }

        /// <summary>
        /// SignalCatalogArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-signalcatalogarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SignalCatalogArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PostTriggerCollectionDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-posttriggercollectionduration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? PostTriggerCollectionDuration { get; set; }
        /// <summary>
        /// DataExtraDimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-dataextradimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DataExtraDimensions { get; set; }
        /// <summary>
        /// DiagnosticsMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-diagnosticsmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DiagnosticsMode { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetArn { get; set; }

        /// <summary>
        /// CollectionScheme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-collectionscheme
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CollectionScheme
        /// </summary>
        [Required]
        public Union<Humidifier.IoTFleetWise.CampaignTypes.CollectionScheme, BaseFunction>? CollectionScheme { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CampaignTypes
    {
        public class CollectionScheme : Humidifier.Base.BaseSubResource, IHaveIoTFleetWiseCampaignTypesTimeBasedCollectionSchemeTimeBasedCollectionScheme, IHaveIoTFleetWiseCampaignTypesConditionBasedCollectionSchemeConditionBasedCollectionScheme
        {
            /// <summary>
            /// TimeBasedCollectionScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-collectionscheme.html#cfn-iotfleetwise-campaign-collectionscheme-timebasedcollectionscheme
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeBasedCollectionScheme
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme, BaseFunction>? TimeBasedCollectionScheme { get; set; }
            /// <summary>
            /// ConditionBasedCollectionScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-collectionscheme.html#cfn-iotfleetwise-campaign-collectionscheme-conditionbasedcollectionscheme
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConditionBasedCollectionScheme
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme, BaseFunction>? ConditionBasedCollectionScheme { get; set; }
        }

        public class ConditionBasedCollectionScheme : Humidifier.Base.BaseSubResource, IHaveMinimumTriggerIntervalMs_Double, IHaveExpression, IHaveTriggerMode, IHaveConditionLanguageVersion_Integer
        {
            /// <summary>
            /// MinimumTriggerIntervalMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-minimumtriggerintervalms
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimumTriggerIntervalMs { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-expression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// TriggerMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-triggermode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TriggerMode { get; set; }
            /// <summary>
            /// ConditionLanguageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-conditionlanguageversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConditionLanguageVersion { get; set; }
        }

        public class ConditionBasedSignalFetchConfig : Humidifier.Base.BaseSubResource, IHaveConditionExpression, IHaveTriggerMode
        {
            /// <summary>
            /// ConditionExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedsignalfetchconfig.html#cfn-iotfleetwise-campaign-conditionbasedsignalfetchconfig-conditionexpression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConditionExpression { get; set; }
            /// <summary>
            /// TriggerMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedsignalfetchconfig.html#cfn-iotfleetwise-campaign-conditionbasedsignalfetchconfig-triggermode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TriggerMode { get; set; }
        }

        public class DataDestinationConfig : Humidifier.Base.BaseSubResource, IHaveIoTFleetWiseCampaignTypesS3ConfigS3Config, IHaveIoTFleetWiseCampaignTypesMqttTopicConfigMqttTopicConfig, IHaveIoTFleetWiseCampaignTypesTimestreamConfigTimestreamConfig
        {
            /// <summary>
            /// S3Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datadestinationconfig.html#cfn-iotfleetwise-campaign-datadestinationconfig-s3config
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Config
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.S3Config, BaseFunction>? S3Config { get; set; }
            /// <summary>
            /// MqttTopicConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datadestinationconfig.html#cfn-iotfleetwise-campaign-datadestinationconfig-mqtttopicconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MqttTopicConfig
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig, BaseFunction>? MqttTopicConfig { get; set; }
            /// <summary>
            /// TimestreamConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datadestinationconfig.html#cfn-iotfleetwise-campaign-datadestinationconfig-timestreamconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimestreamConfig
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig, BaseFunction>? TimestreamConfig { get; set; }
        }

        public class DataPartition : Humidifier.Base.BaseSubResource, IHaveIoTFleetWiseCampaignTypesDataPartitionUploadOptionsUploadOptions, IHaveIoTFleetWiseCampaignTypesDataPartitionStorageOptionsStorageOptions, IHaveId
        {
            /// <summary>
            /// UploadOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartition.html#cfn-iotfleetwise-campaign-datapartition-uploadoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DataPartitionUploadOptions
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions, BaseFunction>? UploadOptions { get; set; }
            /// <summary>
            /// StorageOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartition.html#cfn-iotfleetwise-campaign-datapartition-storageoptions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataPartitionStorageOptions
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions, BaseFunction>? StorageOptions { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartition.html#cfn-iotfleetwise-campaign-datapartition-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class DataPartitionStorageOptions : Humidifier.Base.BaseSubResource, IHaveIoTFleetWiseCampaignTypesStorageMaximumSizeMaximumSize, IHaveStorageLocation, IHaveIoTFleetWiseCampaignTypesStorageMinimumTimeToLiveMinimumTimeToLive
        {
            /// <summary>
            /// MaximumSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionstorageoptions.html#cfn-iotfleetwise-campaign-datapartitionstorageoptions-maximumsize
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StorageMaximumSize
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize, BaseFunction>? MaximumSize { get; set; }
            /// <summary>
            /// StorageLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionstorageoptions.html#cfn-iotfleetwise-campaign-datapartitionstorageoptions-storagelocation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageLocation { get; set; }
            /// <summary>
            /// MinimumTimeToLive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionstorageoptions.html#cfn-iotfleetwise-campaign-datapartitionstorageoptions-minimumtimetolive
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StorageMinimumTimeToLive
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive, BaseFunction>? MinimumTimeToLive { get; set; }
        }

        public class DataPartitionUploadOptions : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveConditionLanguageVersion_Integer
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionuploadoptions.html#cfn-iotfleetwise-campaign-datapartitionuploadoptions-expression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// ConditionLanguageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionuploadoptions.html#cfn-iotfleetwise-campaign-datapartitionuploadoptions-conditionlanguageversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConditionLanguageVersion { get; set; }
        }

        public class MqttTopicConfig : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveMqttTopicArn
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-mqtttopicconfig.html#cfn-iotfleetwise-campaign-mqtttopicconfig-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
            /// <summary>
            /// MqttTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-mqtttopicconfig.html#cfn-iotfleetwise-campaign-mqtttopicconfig-mqtttopicarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MqttTopicArn { get; set; }
        }

        public class S3Config : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveDataFormat, IHaveStorageCompressionFormat, IHavePrefix
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// DataFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-dataformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFormat { get; set; }
            /// <summary>
            /// StorageCompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-storagecompressionformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageCompressionFormat { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class SignalFetchConfig : Humidifier.Base.BaseSubResource, IHaveIoTFleetWiseCampaignTypesConditionBasedSignalFetchConfigConditionBased, IHaveIoTFleetWiseCampaignTypesTimeBasedSignalFetchConfigTimeBased
        {
            /// <summary>
            /// ConditionBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchconfig.html#cfn-iotfleetwise-campaign-signalfetchconfig-conditionbased
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConditionBasedSignalFetchConfig
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig, BaseFunction>? ConditionBased { get; set; }
            /// <summary>
            /// TimeBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchconfig.html#cfn-iotfleetwise-campaign-signalfetchconfig-timebased
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeBasedSignalFetchConfig
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig, BaseFunction>? TimeBased { get; set; }
        }

        public class SignalFetchInformation : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveFullyQualifiedName, IHaveIoTFleetWiseCampaignTypesSignalFetchConfigSignalFetchConfig, IHaveConditionLanguageVersion_Double
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-actions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// FullyQualifiedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-fullyqualifiedname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FullyQualifiedName { get; set; }
            /// <summary>
            /// SignalFetchConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-signalfetchconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: SignalFetchConfig
            /// </summary>
            public Union<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig, BaseFunction>? SignalFetchConfig { get; set; }
            /// <summary>
            /// ConditionLanguageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-conditionlanguageversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ConditionLanguageVersion { get; set; }
        }

        public class SignalInformation : Humidifier.Base.BaseSubResource, IHaveMaxSampleCount_Double, IHaveDataPartitionId, IHaveMinimumSamplingIntervalMs_Double, IHaveName
        {
            /// <summary>
            /// MaxSampleCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-maxsamplecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxSampleCount { get; set; }
            /// <summary>
            /// DataPartitionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-datapartitionid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataPartitionId { get; set; }
            /// <summary>
            /// MinimumSamplingIntervalMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-minimumsamplingintervalms
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimumSamplingIntervalMs { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class StorageMaximumSize : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storagemaximumsize.html#cfn-iotfleetwise-campaign-storagemaximumsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storagemaximumsize.html#cfn-iotfleetwise-campaign-storagemaximumsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class StorageMinimumTimeToLive : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storageminimumtimetolive.html#cfn-iotfleetwise-campaign-storageminimumtimetolive-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storageminimumtimetolive.html#cfn-iotfleetwise-campaign-storageminimumtimetolive-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class TimeBasedCollectionScheme : Humidifier.Base.BaseSubResource, IHavePeriodMs_Double
        {
            /// <summary>
            /// PeriodMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timebasedcollectionscheme.html#cfn-iotfleetwise-campaign-timebasedcollectionscheme-periodms
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PeriodMs { get; set; }
        }

        public class TimeBasedSignalFetchConfig : Humidifier.Base.BaseSubResource, IHaveExecutionFrequencyMs_Double
        {
            /// <summary>
            /// ExecutionFrequencyMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timebasedsignalfetchconfig.html#cfn-iotfleetwise-campaign-timebasedsignalfetchconfig-executionfrequencyms
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ExecutionFrequencyMs { get; set; }
        }

        public class TimestreamConfig : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveTimestreamTableArn
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timestreamconfig.html#cfn-iotfleetwise-campaign-timestreamconfig-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
            /// <summary>
            /// TimestreamTableArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timestreamconfig.html#cfn-iotfleetwise-campaign-timestreamconfig-timestreamtablearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestreamTableArn { get; set; }
        }
    }
}