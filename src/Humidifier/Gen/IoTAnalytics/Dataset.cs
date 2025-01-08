namespace Humidifier.IoTAnalytics
{
    using System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDatasetName
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
        public List<Humidifier.IoTAnalytics.DatasetTypes.Action> Actions { get; set; }
        /// <summary>
        /// LateDataRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-latedatarules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LateDataRule
        /// </summary>
        public List<Humidifier.IoTAnalytics.DatasetTypes.LateDataRule> LateDataRules { get; set; }
        public dynamic DatasetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ContentDeliveryRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-contentdeliveryrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatasetContentDeliveryRule
        /// </summary>
        public List<Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRule> ContentDeliveryRules { get; set; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Trigger
        /// </summary>
        public List<Humidifier.IoTAnalytics.DatasetTypes.Trigger> Triggers { get; set; }
        /// <summary>
        /// VersioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-versioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersioningConfiguration
        /// </summary>
        public Humidifier.IoTAnalytics.DatasetTypes.VersioningConfiguration VersioningConfiguration { get; set; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public Humidifier.IoTAnalytics.DatasetTypes.RetentionPeriod RetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html#cfn-iotanalytics-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DatasetTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveActionName
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionName { get; set; }
            /// <summary>
            /// ContainerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-containeraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerAction
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.ContainerAction ContainerAction { get; set; }
            /// <summary>
            /// QueryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html#cfn-iotanalytics-dataset-action-queryaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryAction
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.QueryAction QueryAction { get; set; }
        }

        public class ContainerAction : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveImage
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Variable
            /// </summary>
            public List<Humidifier.IoTAnalytics.DatasetTypes.Variable> Variables { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-executionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// ResourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html#cfn-iotanalytics-dataset-containeraction-resourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration ResourceConfiguration { get; set; }
        }

        public class DatasetContentDeliveryRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html#cfn-iotanalytics-dataset-datasetcontentdeliveryrule-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatasetContentDeliveryRuleDestination
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.DatasetContentDeliveryRuleDestination Destination { get; set; }
            /// <summary>
            /// EntryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html#cfn-iotanalytics-dataset-datasetcontentdeliveryrule-entryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryName { get; set; }
        }

        public class DatasetContentDeliveryRuleDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IotEventsDestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html#cfn-iotanalytics-dataset-datasetcontentdeliveryruledestination-ioteventsdestinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotEventsDestinationConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration IotEventsDestinationConfiguration { get; set; }
            /// <summary>
            /// S3DestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html#cfn-iotanalytics-dataset-datasetcontentdeliveryruledestination-s3destinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.S3DestinationConfiguration S3DestinationConfiguration { get; set; }
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
            public dynamic DatasetName { get; set; }
        }

        public class DeltaTime : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TimeExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html#cfn-iotanalytics-dataset-deltatime-timeexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeExpression { get; set; }
            /// <summary>
            /// OffsetSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatime.html#cfn-iotanalytics-dataset-deltatime-offsetseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OffsetSeconds { get; set; }
        }

        public class DeltaTimeSessionWindowConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutInMinutes
        {
            /// <summary>
            /// TimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-deltatimesessionwindowconfiguration.html#cfn-iotanalytics-dataset-deltatimesessionwindowconfiguration-timeoutinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutInMinutes { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeltaTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-filter.html#cfn-iotanalytics-dataset-filter-deltatime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeltaTime
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.DeltaTime DeltaTime { get; set; }
        }

        public class GlueConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveTableName
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html#cfn-iotanalytics-dataset-glueconfiguration-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-glueconfiguration.html#cfn-iotanalytics-dataset-glueconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
        }

        public class IotEventsDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveInputName
        {
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html#cfn-iotanalytics-dataset-ioteventsdestinationconfiguration-inputname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html#cfn-iotanalytics-dataset-ioteventsdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class LateDataRule : Humidifier.Base.BaseSubResource, IHaveRuleName
        {
            /// <summary>
            /// RuleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedatarule.html#cfn-iotanalytics-dataset-latedatarule-ruleconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LateDataRuleConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration RuleConfiguration { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedatarule.html#cfn-iotanalytics-dataset-latedatarule-rulename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }

        public class LateDataRuleConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeltaTimeSessionWindowConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedataruleconfiguration.html#cfn-iotanalytics-dataset-latedataruleconfiguration-deltatimesessionwindowconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeltaTimeSessionWindowConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration DeltaTimeSessionWindowConfiguration { get; set; }
        }

        public class OutputFileUriValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-outputfileurivalue.html#cfn-iotanalytics-dataset-outputfileurivalue-filename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileName { get; set; }
        }

        public class QueryAction : Humidifier.Base.BaseSubResource, IHaveSqlQuery
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html#cfn-iotanalytics-dataset-queryaction-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.IoTAnalytics.DatasetTypes.Filter> Filters { get; set; }
            /// <summary>
            /// SqlQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html#cfn-iotanalytics-dataset-queryaction-sqlquery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SqlQuery { get; set; }
        }

        public class ResourceConfiguration : Humidifier.Base.BaseSubResource, IHaveVolumeSizeInGB, IHaveComputeType
        {
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html#cfn-iotanalytics-dataset-resourceconfiguration-volumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html#cfn-iotanalytics-dataset-resourceconfiguration-computetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputeType { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveUnlimited, IHaveNumberOfDays
        {
            /// <summary>
            /// NumberOfDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html#cfn-iotanalytics-dataset-retentionperiod-numberofdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfDays { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-retentionperiod.html#cfn-iotanalytics-dataset-retentionperiod-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Unlimited { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveKey, IHaveBucket
        {
            /// <summary>
            /// GlueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-glueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration GlueConfiguration { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html#cfn-iotanalytics-dataset-s3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
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
            public dynamic ScheduleExpression { get; set; }
        }

        public class Trigger : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html#cfn-iotanalytics-dataset-trigger-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.Schedule Schedule { get; set; }
            /// <summary>
            /// TriggeringDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html#cfn-iotanalytics-dataset-trigger-triggeringdataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TriggeringDataset
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset TriggeringDataset { get; set; }
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
            public dynamic DatasetName { get; set; }
        }

        public class Variable : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDoubleValue, IHaveVariableName
        {
            /// <summary>
            /// DatasetContentVersionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-datasetcontentversionvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetContentVersionValue
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.DatasetContentVersionValue DatasetContentVersionValue { get; set; }
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DoubleValue { get; set; }
            /// <summary>
            /// OutputFileUriValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-outputfileurivalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputFileUriValue
            /// </summary>
            public Humidifier.IoTAnalytics.DatasetTypes.OutputFileUriValue OutputFileUriValue { get; set; }
            /// <summary>
            /// VariableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-variablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariableName { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html#cfn-iotanalytics-dataset-variable-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
        }

        public class VersioningConfiguration : Humidifier.Base.BaseSubResource, IHaveUnlimited
        {
            /// <summary>
            /// MaxVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html#cfn-iotanalytics-dataset-versioningconfiguration-maxversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxVersions { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html#cfn-iotanalytics-dataset-versioningconfiguration-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Unlimited { get; set; }
        }
    }
}