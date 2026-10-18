namespace Humidifier.Scheduler
{
    using global::System.Collections.Generic;
    using ScheduleTypes;

    public class Schedule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGroupName, IHaveStartDate, IHaveScheduleExpression, IHaveSchedulerScheduleTypesTargetTarget, IHaveDescription, IHaveKmsKeyArn, IHaveState, IHaveSchedulerScheduleTypesFlexibleTimeWindowFlexibleTimeWindow, IHaveScheduleExpressionTimezone, IHaveEndDate, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Scheduler.Schedule; }
        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-groupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupName { get; set; }
        /// <summary>
        /// StartDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-startdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartDate { get; set; }

        /// <summary>
        /// ScheduleExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-scheduleexpression
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScheduleExpression { get; set; }

        /// <summary>
        /// Target
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-target
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Target
        /// </summary>
        [Required]
        public Union<Humidifier.Scheduler.ScheduleTypes.Target, BaseFunction>? Target { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }

        /// <summary>
        /// FlexibleTimeWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-flexibletimewindow
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FlexibleTimeWindow
        /// </summary>
        [Required]
        public Union<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow, BaseFunction>? FlexibleTimeWindow { get; set; }
        /// <summary>
        /// ScheduleExpressionTimezone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-scheduleexpressiontimezone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScheduleExpressionTimezone { get; set; }
        /// <summary>
        /// EndDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedule.html#cfn-scheduler-schedule-enddate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndDate { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ScheduleTypes
    {
        public class AwsVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets, IHaveAssignPublicIp
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-awsvpcconfiguration.html#cfn-scheduler-schedule-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-awsvpcconfiguration.html#cfn-scheduler-schedule-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-awsvpcconfiguration.html#cfn-scheduler-schedule-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssignPublicIp { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveWeight_Double, IHaveBase_Double
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-capacityproviderstrategyitem.html#cfn-scheduler-schedule-capacityproviderstrategyitem-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-capacityproviderstrategyitem.html#cfn-scheduler-schedule-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-capacityproviderstrategyitem.html#cfn-scheduler-schedule-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Base { get; set; }
        }

        public class DeadLetterConfig : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-deadletterconfig.html#cfn-scheduler-schedule-deadletterconfig-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class EcsParameters : Humidifier.Base.BaseSubResource, IHavePlatformVersion, IHaveGroup, IHaveEnableECSManagedTags_Boolean, IHaveTaskCount_Double, IHaveEnableExecuteCommand_Boolean, IHaveListOfSchedulerScheduleTypesPlacementConstraintPlacementConstraints, IHavePropagateTags, IHaveListOfSchedulerScheduleTypesPlacementStrategyPlacementStrategy, IHaveLaunchType, IHaveListOfSchedulerScheduleTypesCapacityProviderStrategyItemCapacityProviderStrategy, IHaveReferenceId, IHaveSchedulerScheduleTypesNetworkConfigurationNetworkConfiguration, IHaveTags_Json, IHaveTaskDefinitionArn
        {
            /// <summary>
            /// PlatformVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-platformversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlatformVersion { get; set; }
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-group
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Group { get; set; }
            /// <summary>
            /// EnableECSManagedTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-enableecsmanagedtags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableECSManagedTags { get; set; }
            /// <summary>
            /// TaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-taskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TaskCount { get; set; }
            /// <summary>
            /// EnableExecuteCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-enableexecutecommand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableExecuteCommand { get; set; }
            /// <summary>
            /// PlacementConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-placementconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PlacementConstraint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Scheduler.ScheduleTypes.PlacementConstraint>, IReadOnlyList<Union<Humidifier.Scheduler.ScheduleTypes.PlacementConstraint, BaseFunction>>, BaseFunction>? PlacementConstraints { get; set; }
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// PlacementStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-placementstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PlacementStrategy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Scheduler.ScheduleTypes.PlacementStrategy>, IReadOnlyList<Union<Humidifier.Scheduler.ScheduleTypes.PlacementStrategy, BaseFunction>>, BaseFunction>? PlacementStrategy { get; set; }
            /// <summary>
            /// LaunchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-launchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchType { get; set; }
            /// <summary>
            /// CapacityProviderStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-capacityproviderstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CapacityProviderStrategyItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Scheduler.ScheduleTypes.CapacityProviderStrategyItem>, IReadOnlyList<Union<Humidifier.Scheduler.ScheduleTypes.CapacityProviderStrategyItem, BaseFunction>>, BaseFunction>? CapacityProviderStrategy { get; set; }
            /// <summary>
            /// ReferenceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-referenceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferenceId { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-tags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// TaskDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-ecsparameters.html#cfn-scheduler-schedule-ecsparameters-taskdefinitionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskDefinitionArn { get; set; }
        }

        public class EventBridgeParameters : Humidifier.Base.BaseSubResource, IHaveDetailType, IHaveSource
        {
            /// <summary>
            /// DetailType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-eventbridgeparameters.html#cfn-scheduler-schedule-eventbridgeparameters-detailtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DetailType { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-eventbridgeparameters.html#cfn-scheduler-schedule-eventbridgeparameters-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class FlexibleTimeWindow : Humidifier.Base.BaseSubResource, IHaveMode, IHaveMaximumWindowInMinutes_Double
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-flexibletimewindow.html#cfn-scheduler-schedule-flexibletimewindow-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// MaximumWindowInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-flexibletimewindow.html#cfn-scheduler-schedule-flexibletimewindow-maximumwindowinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaximumWindowInMinutes { get; set; }
        }

        public class KinesisParameters : Humidifier.Base.BaseSubResource, IHavePartitionKey
        {
            /// <summary>
            /// PartitionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-kinesisparameters.html#cfn-scheduler-schedule-kinesisparameters-partitionkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionKey { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveSchedulerScheduleTypesAwsVpcConfigurationAwsvpcConfiguration
        {
            /// <summary>
            /// AwsvpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-networkconfiguration.html#cfn-scheduler-schedule-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration, BaseFunction>? AwsvpcConfiguration { get; set; }
        }

        public class PlacementConstraint : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-placementconstraint.html#cfn-scheduler-schedule-placementconstraint-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-placementconstraint.html#cfn-scheduler-schedule-placementconstraint-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class PlacementStrategy : Humidifier.Base.BaseSubResource, IHaveField, IHaveType
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-placementstrategy.html#cfn-scheduler-schedule-placementstrategy-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-placementstrategy.html#cfn-scheduler-schedule-placementstrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class RetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaximumRetryAttempts_Double, IHaveMaximumEventAgeInSeconds_Double
        {
            /// <summary>
            /// MaximumRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-retrypolicy.html#cfn-scheduler-schedule-retrypolicy-maximumretryattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaximumRetryAttempts { get; set; }
            /// <summary>
            /// MaximumEventAgeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-retrypolicy.html#cfn-scheduler-schedule-retrypolicy-maximumeventageinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaximumEventAgeInSeconds { get; set; }
        }

        public class SageMakerPipelineParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-sagemakerpipelineparameter.html#cfn-scheduler-schedule-sagemakerpipelineparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-sagemakerpipelineparameter.html#cfn-scheduler-schedule-sagemakerpipelineparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SageMakerPipelineParameters : Humidifier.Base.BaseSubResource, IHaveListOfSchedulerScheduleTypesSageMakerPipelineParameterPipelineParameterList
        {
            /// <summary>
            /// PipelineParameterList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-sagemakerpipelineparameters.html#cfn-scheduler-schedule-sagemakerpipelineparameters-pipelineparameterlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SageMakerPipelineParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameter>, IReadOnlyList<Union<Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameter, BaseFunction>>, BaseFunction>? PipelineParameterList { get; set; }
        }

        public class SqsParameters : Humidifier.Base.BaseSubResource, IHaveMessageGroupId
        {
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-sqsparameters.html#cfn-scheduler-schedule-sqsparameters-messagegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageGroupId { get; set; }
        }

        public class Target : Humidifier.Base.BaseSubResource, IHaveInput, IHaveSchedulerScheduleTypesSqsParametersSqsParameters, IHaveSchedulerScheduleTypesDeadLetterConfigDeadLetterConfig, IHaveSchedulerScheduleTypesEcsParametersEcsParameters, IHaveSchedulerScheduleTypesEventBridgeParametersEventBridgeParameters, IHaveArn, IHaveSchedulerScheduleTypesKinesisParametersKinesisParameters, IHaveSchedulerScheduleTypesSageMakerPipelineParametersSageMakerPipelineParameters, IHaveSchedulerScheduleTypesRetryPolicyRetryPolicy, IHaveRoleArn
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Input { get; set; }
            /// <summary>
            /// SqsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-sqsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqsParameters
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.SqsParameters, BaseFunction>? SqsParameters { get; set; }
            /// <summary>
            /// DeadLetterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-deadletterconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeadLetterConfig
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.DeadLetterConfig, BaseFunction>? DeadLetterConfig { get; set; }
            /// <summary>
            /// EcsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-ecsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsParameters
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.EcsParameters, BaseFunction>? EcsParameters { get; set; }
            /// <summary>
            /// EventBridgeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-eventbridgeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBridgeParameters
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.EventBridgeParameters, BaseFunction>? EventBridgeParameters { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// KinesisParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-kinesisparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisParameters
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.KinesisParameters, BaseFunction>? KinesisParameters { get; set; }
            /// <summary>
            /// SageMakerPipelineParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-sagemakerpipelineparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SageMakerPipelineParameters
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.SageMakerPipelineParameters, BaseFunction>? SageMakerPipelineParameters { get; set; }
            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetryPolicy
            /// </summary>
            public Union<Humidifier.Scheduler.ScheduleTypes.RetryPolicy, BaseFunction>? RetryPolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scheduler-schedule-target.html#cfn-scheduler-schedule-target-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}