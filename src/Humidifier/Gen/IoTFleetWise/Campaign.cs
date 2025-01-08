namespace Humidifier.IoTFleetWise
{
    using System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveAction, IHavePriority, IHaveStartTime, IHaveTargetArn, IHaveCompression, IHaveSignalCatalogArn, IHaveDataExtraDimensions
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
        public dynamic Action { get; set; }
        /// <summary>
        /// Compression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-compression
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Compression { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DataPartitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-datapartitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DataPartition
        /// </summary>
        public List<Humidifier.IoTFleetWise.CampaignTypes.DataPartition> DataPartitions { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Priority { get; set; }
        /// <summary>
        /// SignalsToCollect
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-signalstocollect
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SignalInformation
        /// </summary>
        public List<Humidifier.IoTFleetWise.CampaignTypes.SignalInformation> SignalsToCollect { get; set; }
        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-starttime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StartTime { get; set; }
        /// <summary>
        /// SignalsToFetch
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-signalstofetch
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SignalFetchInformation
        /// </summary>
        public List<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation> SignalsToFetch { get; set; }
        /// <summary>
        /// ExpiryTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-expirytime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExpiryTime { get; set; }
        /// <summary>
        /// SpoolingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-spoolingmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SpoolingMode { get; set; }
        /// <summary>
        /// DataDestinationConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-datadestinationconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataDestinationConfig
        /// </summary>
        public List<Humidifier.IoTFleetWise.CampaignTypes.DataDestinationConfig> DataDestinationConfigs { get; set; }

        /// <summary>
        /// SignalCatalogArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-signalcatalogarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SignalCatalogArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PostTriggerCollectionDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-posttriggercollectionduration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic PostTriggerCollectionDuration { get; set; }
        /// <summary>
        /// DataExtraDimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-dataextradimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DataExtraDimensions { get; set; }
        /// <summary>
        /// DiagnosticsMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-diagnosticsmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DiagnosticsMode { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetArn { get; set; }

        /// <summary>
        /// CollectionScheme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-collectionscheme
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CollectionScheme
        /// </summary>
        [Required]
        public Humidifier.IoTFleetWise.CampaignTypes.CollectionScheme CollectionScheme { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-campaign.html#cfn-iotfleetwise-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace CampaignTypes
    {
        public class CollectionScheme : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TimeBasedCollectionScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-collectionscheme.html#cfn-iotfleetwise-campaign-collectionscheme-timebasedcollectionscheme
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeBasedCollectionScheme
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme TimeBasedCollectionScheme { get; set; }
            /// <summary>
            /// ConditionBasedCollectionScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-collectionscheme.html#cfn-iotfleetwise-campaign-collectionscheme-conditionbasedcollectionscheme
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConditionBasedCollectionScheme
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme ConditionBasedCollectionScheme { get; set; }
        }

        public class ConditionBasedCollectionScheme : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveConditionLanguageVersion, IHaveTriggerMode
        {
            /// <summary>
            /// MinimumTriggerIntervalMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-minimumtriggerintervalms
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumTriggerIntervalMs { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-expression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// TriggerMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-triggermode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TriggerMode { get; set; }
            /// <summary>
            /// ConditionLanguageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedcollectionscheme.html#cfn-iotfleetwise-campaign-conditionbasedcollectionscheme-conditionlanguageversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConditionLanguageVersion { get; set; }
        }

        public class ConditionBasedSignalFetchConfig : Humidifier.Base.BaseSubResource, IHaveTriggerMode, IHaveConditionExpression
        {
            /// <summary>
            /// ConditionExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedsignalfetchconfig.html#cfn-iotfleetwise-campaign-conditionbasedsignalfetchconfig-conditionexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionExpression { get; set; }
            /// <summary>
            /// TriggerMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-conditionbasedsignalfetchconfig.html#cfn-iotfleetwise-campaign-conditionbasedsignalfetchconfig-triggermode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TriggerMode { get; set; }
        }

        public class DataDestinationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datadestinationconfig.html#cfn-iotfleetwise-campaign-datadestinationconfig-s3config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Config
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.S3Config S3Config { get; set; }
            /// <summary>
            /// MqttTopicConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datadestinationconfig.html#cfn-iotfleetwise-campaign-datadestinationconfig-mqtttopicconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MqttTopicConfig
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig MqttTopicConfig { get; set; }
            /// <summary>
            /// TimestreamConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datadestinationconfig.html#cfn-iotfleetwise-campaign-datadestinationconfig-timestreamconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimestreamConfig
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig TimestreamConfig { get; set; }
        }

        public class DataPartition : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// UploadOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartition.html#cfn-iotfleetwise-campaign-datapartition-uploadoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DataPartitionUploadOptions
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.DataPartitionUploadOptions UploadOptions { get; set; }
            /// <summary>
            /// StorageOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartition.html#cfn-iotfleetwise-campaign-datapartition-storageoptions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataPartitionStorageOptions
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.DataPartitionStorageOptions StorageOptions { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartition.html#cfn-iotfleetwise-campaign-datapartition-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class DataPartitionStorageOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionstorageoptions.html#cfn-iotfleetwise-campaign-datapartitionstorageoptions-maximumsize
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StorageMaximumSize
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.StorageMaximumSize MaximumSize { get; set; }
            /// <summary>
            /// StorageLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionstorageoptions.html#cfn-iotfleetwise-campaign-datapartitionstorageoptions-storagelocation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageLocation { get; set; }
            /// <summary>
            /// MinimumTimeToLive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionstorageoptions.html#cfn-iotfleetwise-campaign-datapartitionstorageoptions-minimumtimetolive
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StorageMinimumTimeToLive
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.StorageMinimumTimeToLive MinimumTimeToLive { get; set; }
        }

        public class DataPartitionUploadOptions : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveConditionLanguageVersion
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionuploadoptions.html#cfn-iotfleetwise-campaign-datapartitionuploadoptions-expression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// ConditionLanguageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-datapartitionuploadoptions.html#cfn-iotfleetwise-campaign-datapartitionuploadoptions-conditionlanguageversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConditionLanguageVersion { get; set; }
        }

        public class MqttTopicConfig : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-mqtttopicconfig.html#cfn-iotfleetwise-campaign-mqtttopicconfig-executionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// MqttTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-mqtttopicconfig.html#cfn-iotfleetwise-campaign-mqtttopicconfig-mqtttopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MqttTopicArn { get; set; }
        }

        public class S3Config : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBucketArn, IHaveDataFormat
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// DataFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-dataformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataFormat { get; set; }
            /// <summary>
            /// StorageCompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-storagecompressionformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageCompressionFormat { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-s3config.html#cfn-iotfleetwise-campaign-s3config-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class SignalFetchConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchconfig.html#cfn-iotfleetwise-campaign-signalfetchconfig-conditionbased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionBasedSignalFetchConfig
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig ConditionBased { get; set; }
            /// <summary>
            /// TimeBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchconfig.html#cfn-iotfleetwise-campaign-signalfetchconfig-timebased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedSignalFetchConfig
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig TimeBased { get; set; }
        }

        public class SignalFetchInformation : Humidifier.Base.BaseSubResource, IHaveActions, IHaveFullyQualifiedName, IHaveConditionLanguageVersion
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// FullyQualifiedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-fullyqualifiedname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FullyQualifiedName { get; set; }
            /// <summary>
            /// SignalFetchConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-signalfetchconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SignalFetchConfig
            /// </summary>
            public Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig SignalFetchConfig { get; set; }
            /// <summary>
            /// ConditionLanguageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalfetchinformation.html#cfn-iotfleetwise-campaign-signalfetchinformation-conditionlanguageversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ConditionLanguageVersion { get; set; }
        }

        public class SignalInformation : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// MaxSampleCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-maxsamplecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxSampleCount { get; set; }
            /// <summary>
            /// DataPartitionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-datapartitionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataPartitionId { get; set; }
            /// <summary>
            /// MinimumSamplingIntervalMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-minimumsamplingintervalms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumSamplingIntervalMs { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-signalinformation.html#cfn-iotfleetwise-campaign-signalinformation-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StorageMaximumSize : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storagemaximumsize.html#cfn-iotfleetwise-campaign-storagemaximumsize-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storagemaximumsize.html#cfn-iotfleetwise-campaign-storagemaximumsize-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class StorageMinimumTimeToLive : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storageminimumtimetolive.html#cfn-iotfleetwise-campaign-storageminimumtimetolive-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-storageminimumtimetolive.html#cfn-iotfleetwise-campaign-storageminimumtimetolive-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class TimeBasedCollectionScheme : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PeriodMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timebasedcollectionscheme.html#cfn-iotfleetwise-campaign-timebasedcollectionscheme-periodms
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodMs { get; set; }
        }

        public class TimeBasedSignalFetchConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExecutionFrequencyMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timebasedsignalfetchconfig.html#cfn-iotfleetwise-campaign-timebasedsignalfetchconfig-executionfrequencyms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ExecutionFrequencyMs { get; set; }
        }

        public class TimestreamConfig : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timestreamconfig.html#cfn-iotfleetwise-campaign-timestreamconfig-executionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// TimestreamTableArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-campaign-timestreamconfig.html#cfn-iotfleetwise-campaign-timestreamconfig-timestreamtablearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimestreamTableArn { get; set; }
        }
    }
}