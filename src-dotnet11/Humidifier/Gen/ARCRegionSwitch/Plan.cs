namespace Humidifier.ARCRegionSwitch
{
    using global::System.Collections.Generic;
    using PlanTypes;

    public class Plan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHavePrimaryRegion, IHaveListOfARCRegionSwitchPlanTypesWorkflowWorkflows, IHaveStringListOfRegions, IHaveListOfARCRegionSwitchPlanTypesTriggerTriggers, IHaveName, IHaveRecoveryTimeObjectiveMinutes_Double, IHaveMapOfARCRegionSwitchPlanTypesAssociatedAlarmAssociatedAlarms, IHaveRecoveryApproach, IHaveARCRegionSwitchPlanTypesReportConfigurationReportConfiguration, IHaveExecutionRole, IHaveStringDictionaryOfTags, IHaveServiceQuotaChecksEnabled_Boolean
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
            public static string PlanHealthChecks =  "PlanHealthChecks" ;
        }

        public override string AWSTypeName { get => AWS.ARCRegionSwitch.Plan; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PrimaryRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-primaryregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrimaryRegion { get; set; }

        /// <summary>
        /// Workflows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-workflows
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Workflow
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Workflow>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Workflow, BaseFunction>>, BaseFunction>? Workflows { get; set; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-regions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Trigger
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Trigger>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Trigger, BaseFunction>>, BaseFunction>? Triggers { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RecoveryTimeObjectiveMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-recoverytimeobjectiveminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? RecoveryTimeObjectiveMinutes { get; set; }
        /// <summary>
        /// AssociatedAlarms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-associatedalarms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: AssociatedAlarm
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.ARCRegionSwitch.PlanTypes.AssociatedAlarm>, IReadOnlyDictionary<string, Union<Humidifier.ARCRegionSwitch.PlanTypes.AssociatedAlarm, BaseFunction>>, BaseFunction>? AssociatedAlarms { get; set; }

        /// <summary>
        /// RecoveryApproach
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-recoveryapproach
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RecoveryApproach { get; set; }
        /// <summary>
        /// ReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-reportconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReportConfiguration
        /// </summary>
        public Union<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration, BaseFunction>? ReportConfiguration { get; set; }

        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-executionrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ServiceQuotaChecksEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-servicequotachecksenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ServiceQuotaChecksEnabled { get; set; }
    }

    namespace PlanTypes
    {
        public class ArcRoutingControlConfiguration : Humidifier.Base.BaseSubResource, IHaveRegionAndRoutingControls_Json, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveCrossAccountRole
        {
            /// <summary>
            /// RegionAndRoutingControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-regionandroutingcontrols
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? RegionAndRoutingControls { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class Asg : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveCrossAccountRole, IHaveArn
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-asg.html#cfn-arcregionswitch-plan-asg-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-asg.html#cfn-arcregionswitch-plan-asg-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-asg.html#cfn-arcregionswitch-plan-asg-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class AssociatedAlarm : Humidifier.Base.BaseSubResource, IHaveResourceIdentifier, IHaveExternalId, IHaveAlarmType, IHaveCrossAccountRole
        {
            /// <summary>
            /// ResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-resourceidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceIdentifier { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// AlarmType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-alarmtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmType { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class AuroraProvisionedScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfInstanceArns, IHaveTimeoutMinutes_Double, IHaveStringDictionaryOfRegionDatabaseClusterArns, IHaveExternalId, IHaveCrossAccountRole, IHaveGlobalClusterIdentifier
        {
            /// <summary>
            /// InstanceArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-instancearns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? InstanceArns { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionDatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-regiondatabaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RegionDatabaseClusterArns { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
        }

        public class AuroraServerlessScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes_Double, IHaveStringDictionaryOfRegionDatabaseClusterArns, IHaveExternalId, IHaveCrossAccountRole, IHaveGlobalClusterIdentifier, IHaveTargetPercent_Double
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionDatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-regiondatabaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RegionDatabaseClusterArns { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetPercent { get; set; }
        }

        public class CustomActionLambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfARCRegionSwitchPlanTypesLambdasLambdas, IHaveRetryIntervalMinutes_Double, IHaveTimeoutMinutes_Double, IHaveRegionToRun, IHaveARCRegionSwitchPlanTypesLambdaUngracefulUngraceful
        {
            /// <summary>
            /// Lambdas
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-lambdas
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Lambdas
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Lambdas>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Lambdas, BaseFunction>>, BaseFunction>? Lambdas { get; set; }
            /// <summary>
            /// RetryIntervalMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-retryintervalminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RetryIntervalMinutes { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionToRun
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-regiontorun
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionToRun { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.LambdaUngraceful, BaseFunction>? Ungraceful { get; set; }
        }

        public class DocumentDbConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfDatabaseClusterArns, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveBehavior_Json, IHaveCrossAccountRole, IHaveARCRegionSwitchPlanTypesDocumentDbUngracefulUngraceful, IHaveGlobalClusterIdentifier
        {
            /// <summary>
            /// DatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-databaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DatabaseClusterArns { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentDbUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.DocumentDbUngraceful, BaseFunction>? Ungraceful { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
        }

        public class DocumentDbUngraceful : Humidifier.Base.BaseSubResource, IHaveUngraceful
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbungraceful.html#cfn-arcregionswitch-plan-documentdbungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ungraceful { get; set; }
        }

        public class Ec2AsgCapacityIncreaseConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfARCRegionSwitchPlanTypesAsgAsgs, IHaveCapacityMonitoringApproach_Json, IHaveTimeoutMinutes_Double, IHaveWaitELBTargetGroupHealthy, IHaveARCRegionSwitchPlanTypesEc2UngracefulUngraceful, IHaveTargetPercent_Double
        {
            /// <summary>
            /// Asgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-asgs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Asg
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Asg>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Asg, BaseFunction>>, BaseFunction>? Asgs { get; set; }
            /// <summary>
            /// CapacityMonitoringApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-capacitymonitoringapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CapacityMonitoringApproach { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// WaitELBTargetGroupHealthy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-waitelbtargetgrouphealthy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WaitELBTargetGroupHealthy { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ec2Ungraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.Ec2Ungraceful, BaseFunction>? Ungraceful { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetPercent { get; set; }
        }

        public class Ec2Ungraceful : Humidifier.Base.BaseSubResource, IHaveMinimumSuccessPercentage_Double
        {
            /// <summary>
            /// MinimumSuccessPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2ungraceful.html#cfn-arcregionswitch-plan-ec2ungraceful-minimumsuccesspercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimumSuccessPercentage { get; set; }
        }

        public class EcsCapacityIncreaseConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfARCRegionSwitchPlanTypesServiceServices, IHaveCapacityMonitoringApproach_Json, IHaveTimeoutMinutes_Double, IHaveWaitELBTargetGroupHealthy, IHaveARCRegionSwitchPlanTypesEcsUngracefulUngraceful, IHaveTargetPercent_Double
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-services
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Service
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Service>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Service, BaseFunction>>, BaseFunction>? Services { get; set; }
            /// <summary>
            /// CapacityMonitoringApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-capacitymonitoringapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CapacityMonitoringApproach { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// WaitELBTargetGroupHealthy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-waitelbtargetgrouphealthy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WaitELBTargetGroupHealthy { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.EcsUngraceful, BaseFunction>? Ungraceful { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetPercent { get; set; }
        }

        public class EcsUngraceful : Humidifier.Base.BaseSubResource, IHaveMinimumSuccessPercentage_Double
        {
            /// <summary>
            /// MinimumSuccessPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecsungraceful.html#cfn-arcregionswitch-plan-ecsungraceful-minimumsuccesspercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimumSuccessPercentage { get; set; }
        }

        public class EksCluster : Humidifier.Base.BaseSubResource, IHaveClusterArn, IHaveExternalId, IHaveCrossAccountRole
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ekscluster.html#cfn-arcregionswitch-plan-ekscluster-clusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterArn { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ekscluster.html#cfn-arcregionswitch-plan-ekscluster-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ekscluster.html#cfn-arcregionswitch-plan-ekscluster-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class EksResourceScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveARCRegionSwitchPlanTypesKubernetesResourceTypeKubernetesResourceType, IHaveCapacityMonitoringApproach_Json, IHaveListOfARCRegionSwitchPlanTypesEksClusterEksClusters, IHaveTimeoutMinutes_Double, IHaveScalingResources_Json, IHaveARCRegionSwitchPlanTypesEksResourceScalingUngracefulUngraceful, IHaveTargetPercent_Double
        {
            /// <summary>
            /// KubernetesResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-kubernetesresourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KubernetesResourceType
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.KubernetesResourceType, BaseFunction>? KubernetesResourceType { get; set; }
            /// <summary>
            /// CapacityMonitoringApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-capacitymonitoringapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CapacityMonitoringApproach { get; set; }
            /// <summary>
            /// EksClusters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-eksclusters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksCluster
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.EksCluster>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.EksCluster, BaseFunction>>, BaseFunction>? EksClusters { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ScalingResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-scalingresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ScalingResources { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksResourceScalingUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.EksResourceScalingUngraceful, BaseFunction>? Ungraceful { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetPercent { get; set; }
        }

        public class EksResourceScalingUngraceful : Humidifier.Base.BaseSubResource, IHaveMinimumSuccessPercentage_Double
        {
            /// <summary>
            /// MinimumSuccessPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingungraceful.html#cfn-arcregionswitch-plan-eksresourcescalingungraceful-minimumsuccesspercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinimumSuccessPercentage { get; set; }
        }

        public class EventSourceMapping : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveArn, IHaveCrossAccountRole
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eventsourcemapping.html#cfn-arcregionswitch-plan-eventsourcemapping-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eventsourcemapping.html#cfn-arcregionswitch-plan-eventsourcemapping-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eventsourcemapping.html#cfn-arcregionswitch-plan-eventsourcemapping-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class ExecutionApprovalConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes_Double, IHaveApprovalRole
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionapprovalconfiguration.html#cfn-arcregionswitch-plan-executionapprovalconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ApprovalRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionapprovalconfiguration.html#cfn-arcregionswitch-plan-executionapprovalconfiguration-approvalrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApprovalRole { get; set; }
        }

        public class ExecutionBlockConfiguration : Humidifier.Base.BaseSubResource, IHaveARCRegionSwitchPlanTypesAuroraServerlessScalingConfigurationAuroraServerlessScalingConfig, IHaveARCRegionSwitchPlanTypesRdsPromoteReadReplicaConfigurationRdsPromoteReadReplicaConfig, IHaveARCRegionSwitchPlanTypesParallelExecutionBlockConfigurationParallelConfig, IHaveARCRegionSwitchPlanTypesEcsCapacityIncreaseConfigurationEcsCapacityIncreaseConfig, IHaveARCRegionSwitchPlanTypesExecutionApprovalConfigurationExecutionApprovalConfig, IHaveARCRegionSwitchPlanTypesLambdaEventSourceMappingConfigurationLambdaEventSourceMappingConfig, IHaveARCRegionSwitchPlanTypesRegionSwitchPlanConfigurationRegionSwitchPlanConfig, IHaveARCRegionSwitchPlanTypesRdsSwitchoverReadReplicaConfigurationRdsSwitchoverReadReplicaConfig, IHaveARCRegionSwitchPlanTypesGlobalAuroraConfigurationGlobalAuroraConfig, IHaveARCRegionSwitchPlanTypesRoute53HealthCheckConfigurationRoute53HealthCheckConfig, IHaveARCRegionSwitchPlanTypesRdsCreateCrossRegionReplicaConfigurationRdsCreateCrossRegionReadReplicaConfig, IHaveARCRegionSwitchPlanTypesNeptuneGlobalDatabaseConfigurationNeptuneGlobalDatabaseConfig, IHaveARCRegionSwitchPlanTypesArcRoutingControlConfigurationArcRoutingControlConfig, IHaveARCRegionSwitchPlanTypesDocumentDbConfigurationDocumentDbConfig, IHaveARCRegionSwitchPlanTypesEksResourceScalingConfigurationEksResourceScalingConfig, IHaveARCRegionSwitchPlanTypesCustomActionLambdaConfigurationCustomActionLambdaConfig, IHaveARCRegionSwitchPlanTypesAuroraProvisionedScalingConfigurationAuroraProvisionedScalingConfig, IHaveARCRegionSwitchPlanTypesSsmSendCommandConfigurationSsmSendCommandConfig, IHaveARCRegionSwitchPlanTypesEc2AsgCapacityIncreaseConfigurationEc2AsgCapacityIncreaseConfig
        {
            /// <summary>
            /// AuroraServerlessScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-auroraserverlessscalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuroraServerlessScalingConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.AuroraServerlessScalingConfiguration, BaseFunction>? AuroraServerlessScalingConfig { get; set; }
            /// <summary>
            /// RdsPromoteReadReplicaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-rdspromotereadreplicaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsPromoteReadReplicaConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.RdsPromoteReadReplicaConfiguration, BaseFunction>? RdsPromoteReadReplicaConfig { get; set; }
            /// <summary>
            /// ParallelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-parallelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParallelExecutionBlockConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.ParallelExecutionBlockConfiguration, BaseFunction>? ParallelConfig { get; set; }
            /// <summary>
            /// EcsCapacityIncreaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-ecscapacityincreaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsCapacityIncreaseConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.EcsCapacityIncreaseConfiguration, BaseFunction>? EcsCapacityIncreaseConfig { get; set; }
            /// <summary>
            /// ExecutionApprovalConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-executionapprovalconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExecutionApprovalConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.ExecutionApprovalConfiguration, BaseFunction>? ExecutionApprovalConfig { get; set; }
            /// <summary>
            /// LambdaEventSourceMappingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-lambdaeventsourcemappingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaEventSourceMappingConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.LambdaEventSourceMappingConfiguration, BaseFunction>? LambdaEventSourceMappingConfig { get; set; }
            /// <summary>
            /// RegionSwitchPlanConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-regionswitchplanconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegionSwitchPlanConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.RegionSwitchPlanConfiguration, BaseFunction>? RegionSwitchPlanConfig { get; set; }
            /// <summary>
            /// RdsSwitchoverReadReplicaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-rdsswitchoverreadreplicaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsSwitchoverReadReplicaConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.RdsSwitchoverReadReplicaConfiguration, BaseFunction>? RdsSwitchoverReadReplicaConfig { get; set; }
            /// <summary>
            /// GlobalAuroraConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-globalauroraconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalAuroraConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.GlobalAuroraConfiguration, BaseFunction>? GlobalAuroraConfig { get; set; }
            /// <summary>
            /// Route53HealthCheckConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-route53healthcheckconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Route53HealthCheckConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.Route53HealthCheckConfiguration, BaseFunction>? Route53HealthCheckConfig { get; set; }
            /// <summary>
            /// RdsCreateCrossRegionReadReplicaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-rdscreatecrossregionreadreplicaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsCreateCrossRegionReplicaConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.RdsCreateCrossRegionReplicaConfiguration, BaseFunction>? RdsCreateCrossRegionReadReplicaConfig { get; set; }
            /// <summary>
            /// NeptuneGlobalDatabaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-neptuneglobaldatabaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NeptuneGlobalDatabaseConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.NeptuneGlobalDatabaseConfiguration, BaseFunction>? NeptuneGlobalDatabaseConfig { get; set; }
            /// <summary>
            /// ArcRoutingControlConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-arcroutingcontrolconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcRoutingControlConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.ArcRoutingControlConfiguration, BaseFunction>? ArcRoutingControlConfig { get; set; }
            /// <summary>
            /// DocumentDbConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-documentdbconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentDbConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.DocumentDbConfiguration, BaseFunction>? DocumentDbConfig { get; set; }
            /// <summary>
            /// EksResourceScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-eksresourcescalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksResourceScalingConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.EksResourceScalingConfiguration, BaseFunction>? EksResourceScalingConfig { get; set; }
            /// <summary>
            /// CustomActionLambdaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-customactionlambdaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionLambdaConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.CustomActionLambdaConfiguration, BaseFunction>? CustomActionLambdaConfig { get; set; }
            /// <summary>
            /// AuroraProvisionedScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-auroraprovisionedscalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuroraProvisionedScalingConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.AuroraProvisionedScalingConfiguration, BaseFunction>? AuroraProvisionedScalingConfig { get; set; }
            /// <summary>
            /// SsmSendCommandConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-ssmsendcommandconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmSendCommandConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.SsmSendCommandConfiguration, BaseFunction>? SsmSendCommandConfig { get; set; }
            /// <summary>
            /// Ec2AsgCapacityIncreaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-ec2asgcapacityincreaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ec2AsgCapacityIncreaseConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.Ec2AsgCapacityIncreaseConfiguration, BaseFunction>? Ec2AsgCapacityIncreaseConfig { get; set; }
        }

        public class GlobalAuroraConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfDatabaseClusterArns, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveBehavior_Json, IHaveCrossAccountRole, IHaveARCRegionSwitchPlanTypesGlobalAuroraUngracefulUngraceful, IHaveGlobalClusterIdentifier
        {
            /// <summary>
            /// DatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-databaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DatabaseClusterArns { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalAuroraUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.GlobalAuroraUngraceful, BaseFunction>? Ungraceful { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
        }

        public class GlobalAuroraUngraceful : Humidifier.Base.BaseSubResource, IHaveUngraceful
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraungraceful.html#cfn-arcregionswitch-plan-globalauroraungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ungraceful { get; set; }
        }

        public class KubernetesResourceType : Humidifier.Base.BaseSubResource, IHaveApiVersion, IHaveKind
        {
            /// <summary>
            /// ApiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-kubernetesresourcetype.html#cfn-arcregionswitch-plan-kubernetesresourcetype-apiversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiVersion { get; set; }
            /// <summary>
            /// Kind
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-kubernetesresourcetype.html#cfn-arcregionswitch-plan-kubernetesresourcetype-kind
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Kind { get; set; }
        }

        public class LambdaEventSourceMappingConfiguration : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTimeoutMinutes_Double, IHaveMapOfARCRegionSwitchPlanTypesEventSourceMappingRegionEventSourceMappings, IHaveARCRegionSwitchPlanTypesLambdaEventSourceMappingUngracefulUngraceful
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionEventSourceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-regioneventsourcemappings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: EventSourceMapping
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.ARCRegionSwitch.PlanTypes.EventSourceMapping>, IReadOnlyDictionary<string, Union<Humidifier.ARCRegionSwitch.PlanTypes.EventSourceMapping, BaseFunction>>, BaseFunction>? RegionEventSourceMappings { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaEventSourceMappingUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.LambdaEventSourceMappingUngraceful, BaseFunction>? Ungraceful { get; set; }
        }

        public class LambdaEventSourceMappingUngraceful : Humidifier.Base.BaseSubResource, IHaveBehavior
        {
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingungraceful.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingungraceful-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
        }

        public class LambdaUngraceful : Humidifier.Base.BaseSubResource, IHaveBehavior_Json
        {
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaungraceful.html#cfn-arcregionswitch-plan-lambdaungraceful-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Behavior { get; set; }
        }

        public class Lambdas : Humidifier.Base.BaseSubResource, IHaveExternalId, IHavePayload, IHaveCrossAccountRole, IHaveArn
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-payload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Payload { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class NeptuneGlobalDatabaseConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes_Double, IHaveStringDictionaryOfRegionDatabaseClusterArns, IHaveExternalId, IHaveBehavior_Json, IHaveCrossAccountRole, IHaveARCRegionSwitchPlanTypesNeptuneUngracefulUngraceful, IHaveGlobalClusterIdentifier
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionDatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-regiondatabaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RegionDatabaseClusterArns { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NeptuneUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.NeptuneUngraceful, BaseFunction>? Ungraceful { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
        }

        public class NeptuneUngraceful : Humidifier.Base.BaseSubResource, IHaveUngraceful
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneungraceful.html#cfn-arcregionswitch-plan-neptuneungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ungraceful { get; set; }
        }

        public class ParallelExecutionBlockConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfARCRegionSwitchPlanTypesStepSteps
        {
            /// <summary>
            /// Steps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-parallelexecutionblockconfiguration.html#cfn-arcregionswitch-plan-parallelexecutionblockconfiguration-steps
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Step
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Step>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Step, BaseFunction>>, BaseFunction>? Steps { get; set; }
        }

        public class RdsCreateCrossRegionReplicaConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfDbInstanceArnMap, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveCrossAccountRole
        {
            /// <summary>
            /// DbInstanceArnMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-dbinstancearnmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DbInstanceArnMap { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class RdsPromoteReadReplicaConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfDbInstanceArnMap, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveCrossAccountRole
        {
            /// <summary>
            /// DbInstanceArnMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-dbinstancearnmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DbInstanceArnMap { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class RdsSwitchoverReadReplicaConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfDbInstanceArnMap, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveCrossAccountRole, IHaveARCRegionSwitchPlanTypesRdsUngracefulUngraceful
        {
            /// <summary>
            /// DbInstanceArnMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-dbinstancearnmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DbInstanceArnMap { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.RdsUngraceful, BaseFunction>? Ungraceful { get; set; }
        }

        public class RdsUngraceful : Humidifier.Base.BaseSubResource, IHaveUngraceful
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsungraceful.html#cfn-arcregionswitch-plan-rdsungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ungraceful { get; set; }
        }

        public class RegionSwitchPlanConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveCrossAccountRole, IHaveArn
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-regionswitchplanconfiguration.html#cfn-arcregionswitch-plan-regionswitchplanconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-regionswitchplanconfiguration.html#cfn-arcregionswitch-plan-regionswitchplanconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-regionswitchplanconfiguration.html#cfn-arcregionswitch-plan-regionswitchplanconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class ReportConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfARCRegionSwitchPlanTypesReportOutputConfigurationReportOutput
        {
            /// <summary>
            /// ReportOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-reportconfiguration.html#cfn-arcregionswitch-plan-reportconfiguration-reportoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReportOutputConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.ReportOutputConfiguration>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.ReportOutputConfiguration, BaseFunction>>, BaseFunction>? ReportOutput { get; set; }
        }

        public class ReportOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveARCRegionSwitchPlanTypesS3ReportOutputConfigurationS3Configuration
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-reportoutputconfiguration.html#cfn-arcregionswitch-plan-reportoutputconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ReportOutputConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.S3ReportOutputConfiguration, BaseFunction>? S3Configuration { get; set; }
        }

        public class Route53HealthCheckConfiguration : Humidifier.Base.BaseSubResource, IHaveRecordName, IHaveTimeoutMinutes_Double, IHaveExternalId, IHaveHostedZoneId, IHaveCrossAccountRole, IHaveListOfARCRegionSwitchPlanTypesRoute53ResourceRecordSetRecordSets
        {
            /// <summary>
            /// RecordName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-recordname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordName { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-hostedzoneid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// RecordSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-recordsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Route53ResourceRecordSet
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Route53ResourceRecordSet>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Route53ResourceRecordSet, BaseFunction>>, BaseFunction>? RecordSets { get; set; }
        }

        public class Route53ResourceRecordSet : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveRecordSetIdentifier
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53resourcerecordset.html#cfn-arcregionswitch-plan-route53resourcerecordset-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// RecordSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53resourcerecordset.html#cfn-arcregionswitch-plan-route53resourcerecordset-recordsetidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordSetIdentifier { get; set; }
        }

        public class S3ReportOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketPath, IHaveBucketOwner
        {
            /// <summary>
            /// BucketPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-s3reportoutputconfiguration.html#cfn-arcregionswitch-plan-s3reportoutputconfiguration-bucketpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPath { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-s3reportoutputconfiguration.html#cfn-arcregionswitch-plan-s3reportoutputconfiguration-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
        }

        public class Service : Humidifier.Base.BaseSubResource, IHaveClusterArn, IHaveExternalId, IHaveServiceArn, IHaveCrossAccountRole
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-clusterarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterArn { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// ServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-servicearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceArn { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
        }

        public class SsmDocumentConfig : Humidifier.Base.BaseSubResource, IHaveParameters_Json, IHaveExternalId, IHaveListOfARCRegionSwitchPlanTypesSsmTargetTargets, IHaveDocumentVersion, IHaveCrossAccountRole, IHaveDocumentArn
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-targets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsmTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.SsmTarget>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.SsmTarget, BaseFunction>>, BaseFunction>? Targets { get; set; }
            /// <summary>
            /// DocumentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-documentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentVersion { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRole { get; set; }
            /// <summary>
            /// DocumentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-documentarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentArn { get; set; }
        }

        public class SsmSendCommandConfiguration : Humidifier.Base.BaseSubResource, IHaveMapOfARCRegionSwitchPlanTypesSsmDocumentConfigRegionDocuments, IHaveRetryIntervalMinutes_Double, IHaveTimeoutMinutes_Double, IHaveARCRegionSwitchPlanTypesSsmSendCommandUngracefulUngraceful
        {
            /// <summary>
            /// RegionDocuments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-regiondocuments
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SsmDocumentConfig
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.ARCRegionSwitch.PlanTypes.SsmDocumentConfig>, IReadOnlyDictionary<string, Union<Humidifier.ARCRegionSwitch.PlanTypes.SsmDocumentConfig, BaseFunction>>, BaseFunction>? RegionDocuments { get; set; }
            /// <summary>
            /// RetryIntervalMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-retryintervalminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RetryIntervalMinutes { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmSendCommandUngraceful
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.SsmSendCommandUngraceful, BaseFunction>? Ungraceful { get; set; }
        }

        public class SsmSendCommandUngraceful : Humidifier.Base.BaseSubResource, IHaveBehavior
        {
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandungraceful.html#cfn-arcregionswitch-plan-ssmsendcommandungraceful-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
        }

        public class SsmTarget : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmtarget.html#cfn-arcregionswitch-plan-ssmtarget-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmtarget.html#cfn-arcregionswitch-plan-ssmtarget-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Step : Humidifier.Base.BaseSubResource, IHaveARCRegionSwitchPlanTypesExecutionBlockConfigurationExecutionBlockConfiguration, IHaveDescription, IHaveExecutionBlockType, IHaveName
        {
            /// <summary>
            /// ExecutionBlockConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-executionblockconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExecutionBlockConfiguration
            /// </summary>
            public Union<Humidifier.ARCRegionSwitch.PlanTypes.ExecutionBlockConfiguration, BaseFunction>? ExecutionBlockConfiguration { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ExecutionBlockType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-executionblocktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionBlockType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Trigger : Humidifier.Base.BaseSubResource, IHaveTargetRegion, IHaveAction, IHaveMinDelayMinutesBetweenExecutions_Double, IHaveDescription, IHaveListOfARCRegionSwitchPlanTypesTriggerConditionConditions
        {
            /// <summary>
            /// TargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-targetregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetRegion { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// MinDelayMinutesBetweenExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-mindelayminutesbetweenexecutions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinDelayMinutesBetweenExecutions { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TriggerCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.TriggerCondition>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.TriggerCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class TriggerCondition : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveAssociatedAlarmName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-triggercondition.html#cfn-arcregionswitch-plan-triggercondition-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// AssociatedAlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-triggercondition.html#cfn-arcregionswitch-plan-triggercondition-associatedalarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssociatedAlarmName { get; set; }
        }

        public class Workflow : Humidifier.Base.BaseSubResource, IHaveListOfARCRegionSwitchPlanTypesStepSteps, IHaveWorkflowTargetAction, IHaveWorkflowDescription, IHaveWorkflowTargetRegion
        {
            /// <summary>
            /// Steps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-steps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Step
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCRegionSwitch.PlanTypes.Step>, IReadOnlyList<Union<Humidifier.ARCRegionSwitch.PlanTypes.Step, BaseFunction>>, BaseFunction>? Steps { get; set; }
            /// <summary>
            /// WorkflowTargetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-workflowtargetaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowTargetAction { get; set; }
            /// <summary>
            /// WorkflowDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-workflowdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowDescription { get; set; }
            /// <summary>
            /// WorkflowTargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-workflowtargetregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowTargetRegion { get; set; }
        }
    }
}