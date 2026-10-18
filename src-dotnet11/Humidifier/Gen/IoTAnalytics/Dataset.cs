namespace Humidifier.IoTAnalytics
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfIoTAnalyticsDatasetTypesActionActions, IHaveListOfIoTAnalyticsDatasetTypesLateDataRuleLateDataRules, IHaveDatasetName, IHaveListOfIoTAnalyticsDatasetTypesDatasetContentDeliveryRuleContentDeliveryRules, IHaveListOfIoTAnalyticsDatasetTypesTriggerTriggers, IHaveIoTAnalyticsDatasetTypesVersioningConfigurationVersioningConfiguration, IHaveIoTAnalyticsDatasetTypesRetentionPeriodRetentionPeriod
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.IoTAnalytics.Dataset; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatasetTypes.Action>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatasetTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// LateDataRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-latedatarules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LateDataRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatasetTypes.LateDataRule>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatasetTypes.LateDataRule, BaseFunction>>, BaseFunction>? LateDataRules { get; set; }
        public Union<string, BaseFunction>? DatasetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ContentDeliveryRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-contentdeliveryrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatasetContentDeliveryRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule, BaseFunction>>, BaseFunction>? ContentDeliveryRules { get; set; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Trigger
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatasetTypes.Trigger>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatasetTypes.Trigger, BaseFunction>>, BaseFunction>? Triggers { get; set; }
        /// <summary>
        /// VersioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-versioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersioningConfiguration
        /// </summary>
        public Union<Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration, BaseFunction>? VersioningConfiguration { get; set; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public Union<Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod, BaseFunction>? RetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DatasetTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveActionName, IHaveIoTAnalyticsDatasetTypesContainerActionContainerAction, IHaveIoTAnalyticsDatasetTypesQueryActionQueryAction
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionName { get; set; }
            /// <summary>
            /// ContainerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-containeraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerAction
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction, BaseFunction>? ContainerAction { get; set; }
            /// <summary>
            /// QueryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-queryaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryAction
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.QueryAction, BaseFunction>? QueryAction { get; set; }
        }

        public class ContainerAction : Humidifier.Base.BaseSubResource, IHaveListOfIoTAnalyticsDatasetTypesVariableVariables, IHaveExecutionRoleArn, IHaveImage, IHaveIoTAnalyticsDatasetTypesResourceConfigurationResourceConfiguration
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Variable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatasetTypes.Variable>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatasetTypes.Variable, BaseFunction>>, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-executionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// ResourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-resourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration, BaseFunction>? ResourceConfiguration { get; set; }
        }

        public class DatasetContentDeliveryRule : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesDatasetContentDeliveryRuleDestinationDestination, IHaveEntryName
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html#cfn-iotanalytics-dataset-datasetcontentdeliveryrule-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatasetContentDeliveryRuleDestination
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// EntryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html#cfn-iotanalytics-dataset-datasetcontentdeliveryrule-entryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryName { get; set; }
        }

        public class DatasetContentDeliveryRuleDestination : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesIotEventsDestinationConfigurationIotEventsDestinationConfiguration, IHaveIoTAnalyticsDatasetTypesS3DestinationConfigurationS3DestinationConfiguration
        {
            /// <summary>
            /// IotEventsDestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html#cfn-iotanalytics-dataset-datasetcontentdeliveryruledestination-ioteventsdestinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotEventsDestinationConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration, BaseFunction>? IotEventsDestinationConfiguration { get; set; }
            /// <summary>
            /// S3DestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html#cfn-iotanalytics-dataset-datasetcontentdeliveryruledestination-s3destinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration, BaseFunction>? S3DestinationConfiguration { get; set; }
        }

        public class DatasetContentVersionValue : Humidifier.Base.BaseSubResource, IHaveDatasetName
        {
            /// <summary>
            /// DatasetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentversionvalue.html#cfn-iotanalytics-dataset-datasetcontentversionvalue-datasetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetName { get; set; }
        }

        public class DeltaTime : Humidifier.Base.BaseSubResource, IHaveTimeExpression, IHaveOffsetSeconds_Integer
        {
            /// <summary>
            /// TimeExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html#cfn-iotanalytics-dataset-deltatime-timeexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeExpression { get; set; }
            /// <summary>
            /// OffsetSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html#cfn-iotanalytics-dataset-deltatime-offsetseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OffsetSeconds { get; set; }
        }

        public class DeltaTimeSessionWindowConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutInMinutes_Integer
        {
            /// <summary>
            /// TimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatimesessionwindowconfiguration.html#cfn-iotanalytics-dataset-deltatimesessionwindowconfiguration-timeoutinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMinutes { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesDeltaTimeDeltaTime
        {
            /// <summary>
            /// DeltaTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-filter.html#cfn-iotanalytics-dataset-filter-deltatime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeltaTime
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.DeltaTime, BaseFunction>? DeltaTime { get; set; }
        }

        public class GlueConfiguration : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDatabaseName
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html#cfn-iotanalytics-dataset-glueconfiguration-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html#cfn-iotanalytics-dataset-glueconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
        }

        public class IotEventsDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveInputName, IHaveRoleArn
        {
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html#cfn-iotanalytics-dataset-ioteventsdestinationconfiguration-inputname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html#cfn-iotanalytics-dataset-ioteventsdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class LateDataRule : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesLateDataRuleConfigurationRuleConfiguration, IHaveRuleName
        {
            /// <summary>
            /// RuleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedatarule.html#cfn-iotanalytics-dataset-latedatarule-ruleconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LateDataRuleConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration, BaseFunction>? RuleConfiguration { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedatarule.html#cfn-iotanalytics-dataset-latedatarule-rulename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }

        public class LateDataRuleConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesDeltaTimeSessionWindowConfigurationDeltaTimeSessionWindowConfiguration
        {
            /// <summary>
            /// DeltaTimeSessionWindowConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedataruleconfiguration.html#cfn-iotanalytics-dataset-latedataruleconfiguration-deltatimesessionwindowconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeltaTimeSessionWindowConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration, BaseFunction>? DeltaTimeSessionWindowConfiguration { get; set; }
        }

        public class OutputFileUriValue : Humidifier.Base.BaseSubResource, IHaveFileName
        {
            /// <summary>
            /// FileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-outputfileurivalue.html#cfn-iotanalytics-dataset-outputfileurivalue-filename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileName { get; set; }
        }

        public class QueryAction : Humidifier.Base.BaseSubResource, IHaveListOfIoTAnalyticsDatasetTypesFilterFilters, IHaveSqlQuery
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html#cfn-iotanalytics-dataset-queryaction-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatasetTypes.Filter>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatasetTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// SqlQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html#cfn-iotanalytics-dataset-queryaction-sqlquery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SqlQuery { get; set; }
        }

        public class ResourceConfiguration : Humidifier.Base.BaseSubResource, IHaveVolumeSizeInGB_Integer, IHaveComputeType
        {
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html#cfn-iotanalytics-dataset-resourceconfiguration-volumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html#cfn-iotanalytics-dataset-resourceconfiguration-computetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeType { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveNumberOfDays_Integer, IHaveUnlimited_Boolean
        {
            /// <summary>
            /// NumberOfDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html#cfn-iotanalytics-dataset-retentionperiod-numberofdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfDays { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html#cfn-iotanalytics-dataset-retentionperiod-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Unlimited { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesGlueConfigurationGlueConfiguration, IHaveBucket, IHaveKey, IHaveRoleArn
        {
            /// <summary>
            /// GlueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-glueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration, BaseFunction>? GlueConfiguration { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveScheduleExpression
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-schedule.html#cfn-iotanalytics-dataset-schedule-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
        }

        public class Trigger : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesScheduleSchedule, IHaveIoTAnalyticsDatasetTypesTriggeringDatasetTriggeringDataset
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html#cfn-iotanalytics-dataset-trigger-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.Schedule, BaseFunction>? Schedule { get; set; }
            /// <summary>
            /// TriggeringDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html#cfn-iotanalytics-dataset-trigger-triggeringdataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TriggeringDataset
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset, BaseFunction>? TriggeringDataset { get; set; }
        }

        public class TriggeringDataset : Humidifier.Base.BaseSubResource, IHaveDatasetName
        {
            /// <summary>
            /// DatasetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-triggeringdataset.html#cfn-iotanalytics-dataset-triggeringdataset-datasetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetName { get; set; }
        }

        public class Variable : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatasetTypesDatasetContentVersionValueDatasetContentVersionValue, IHaveDoubleValue_Double, IHaveIoTAnalyticsDatasetTypesOutputFileUriValueOutputFileUriValue, IHaveVariableName, IHaveStringValue
        {
            /// <summary>
            /// DatasetContentVersionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-datasetcontentversionvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetContentVersionValue
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentVersionValue, BaseFunction>? DatasetContentVersionValue { get; set; }
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// OutputFileUriValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-outputfileurivalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputFileUriValue
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatasetTypes.OutputFileUriValue, BaseFunction>? OutputFileUriValue { get; set; }
            /// <summary>
            /// VariableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-variablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariableName { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class VersioningConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxVersions_Integer, IHaveUnlimited_Boolean
        {
            /// <summary>
            /// MaxVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html#cfn-iotanalytics-dataset-versioningconfiguration-maxversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxVersions { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html#cfn-iotanalytics-dataset-versioningconfiguration-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Unlimited { get; set; }
        }
    }
}