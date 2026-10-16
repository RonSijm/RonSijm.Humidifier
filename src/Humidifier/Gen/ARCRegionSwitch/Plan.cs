namespace Humidifier.ARCRegionSwitch
{
    using global::System.Collections.Generic;
    using PlanTypes;

    public class Plan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveExecutionRole, IHaveRegions
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
        public dynamic Description { get; set; }
        /// <summary>
        /// PrimaryRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-primaryregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrimaryRegion { get; set; }

        /// <summary>
        /// Workflows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-workflows
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Workflow
        /// </summary>
        [Required]
        public List<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> Workflows { get; set; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-regions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Regions { get; set; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Trigger
        /// </summary>
        public List<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> Triggers { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RecoveryTimeObjectiveMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-recoverytimeobjectiveminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic RecoveryTimeObjectiveMinutes { get; set; }
        /// <summary>
        /// AssociatedAlarms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-associatedalarms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: AssociatedAlarm
        /// </summary>
        public Dictionary<string, Humidifier.ARCRegionSwitch.PlanTypes.AssociatedAlarm> AssociatedAlarms { get; set; }

        /// <summary>
        /// RecoveryApproach
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-recoveryapproach
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecoveryApproach { get; set; }
        /// <summary>
        /// ReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-reportconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReportConfiguration
        /// </summary>
        public Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-executionrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        /// <summary>
        /// ServiceQuotaChecksEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arcregionswitch-plan.html#cfn-arcregionswitch-plan-servicequotachecksenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ServiceQuotaChecksEnabled { get; set; }
    }

    namespace PlanTypes
    {
        public class ArcRoutingControlConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveTimeoutMinutes
        {
            /// <summary>
            /// RegionAndRoutingControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-regionandroutingcontrols
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic RegionAndRoutingControls { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-arcroutingcontrolconfiguration.html#cfn-arcregionswitch-plan-arcroutingcontrolconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class Asg : Humidifier.Base.BaseSubResource, IHaveArn, IHaveExternalId
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-asg.html#cfn-arcregionswitch-plan-asg-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-asg.html#cfn-arcregionswitch-plan-asg-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-asg.html#cfn-arcregionswitch-plan-asg-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class AssociatedAlarm : Humidifier.Base.BaseSubResource, IHaveResourceIdentifier, IHaveExternalId
        {
            /// <summary>
            /// ResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-resourceidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceIdentifier { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// AlarmType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-alarmtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmType { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-associatedalarm.html#cfn-arcregionswitch-plan-associatedalarm-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class AuroraProvisionedScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveGlobalClusterIdentifier, IHaveTimeoutMinutes
        {
            /// <summary>
            /// InstanceArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-instancearns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> InstanceArns { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionDatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-regiondatabaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> RegionDatabaseClusterArns { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraprovisionedscalingconfiguration.html#cfn-arcregionswitch-plan-auroraprovisionedscalingconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlobalClusterIdentifier { get; set; }
        }

        public class AuroraServerlessScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveGlobalClusterIdentifier, IHaveTimeoutMinutes
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionDatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-regiondatabaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> RegionDatabaseClusterArns { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlobalClusterIdentifier { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-auroraserverlessscalingconfiguration.html#cfn-arcregionswitch-plan-auroraserverlessscalingconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetPercent { get; set; }
        }

        public class CustomActionLambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes
        {
            /// <summary>
            /// Lambdas
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-lambdas
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Lambdas
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.Lambdas> Lambdas { get; set; }
            /// <summary>
            /// RetryIntervalMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-retryintervalminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RetryIntervalMinutes { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionToRun
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-regiontorun
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionToRun { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-customactionlambdaconfiguration.html#cfn-arcregionswitch-plan-customactionlambdaconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.LambdaUngraceful Ungraceful { get; set; }
        }

        public class DocumentDbConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveBehavior, IHaveGlobalClusterIdentifier, IHaveTimeoutMinutes
        {
            /// <summary>
            /// DatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-databaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DatabaseClusterArns { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Behavior { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentDbUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.DocumentDbUngraceful Ungraceful { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbconfiguration.html#cfn-arcregionswitch-plan-documentdbconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlobalClusterIdentifier { get; set; }
        }

        public class DocumentDbUngraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-documentdbungraceful.html#cfn-arcregionswitch-plan-documentdbungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ungraceful { get; set; }
        }

        public class Ec2AsgCapacityIncreaseConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes
        {
            /// <summary>
            /// Asgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-asgs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Asg
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.Asg> Asgs { get; set; }
            /// <summary>
            /// CapacityMonitoringApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-capacitymonitoringapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CapacityMonitoringApproach { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// WaitELBTargetGroupHealthy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-waitelbtargetgrouphealthy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WaitELBTargetGroupHealthy { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ec2Ungraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.Ec2Ungraceful Ungraceful { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ec2asgcapacityincreaseconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetPercent { get; set; }
        }

        public class Ec2Ungraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumSuccessPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ec2ungraceful.html#cfn-arcregionswitch-plan-ec2ungraceful-minimumsuccesspercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumSuccessPercentage { get; set; }
        }

        public class EcsCapacityIncreaseConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-services
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Service
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.Service> Services { get; set; }
            /// <summary>
            /// CapacityMonitoringApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-capacitymonitoringapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CapacityMonitoringApproach { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// WaitELBTargetGroupHealthy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-waitelbtargetgrouphealthy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WaitELBTargetGroupHealthy { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.EcsUngraceful Ungraceful { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecscapacityincreaseconfiguration.html#cfn-arcregionswitch-plan-ecscapacityincreaseconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetPercent { get; set; }
        }

        public class EcsUngraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumSuccessPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ecsungraceful.html#cfn-arcregionswitch-plan-ecsungraceful-minimumsuccesspercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumSuccessPercentage { get; set; }
        }

        public class EksCluster : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveClusterArn
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ekscluster.html#cfn-arcregionswitch-plan-ekscluster-clusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterArn { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ekscluster.html#cfn-arcregionswitch-plan-ekscluster-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ekscluster.html#cfn-arcregionswitch-plan-ekscluster-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class EksResourceScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes
        {
            /// <summary>
            /// KubernetesResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-kubernetesresourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KubernetesResourceType
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.KubernetesResourceType KubernetesResourceType { get; set; }
            /// <summary>
            /// CapacityMonitoringApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-capacitymonitoringapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CapacityMonitoringApproach { get; set; }
            /// <summary>
            /// EksClusters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-eksclusters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksCluster
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.EksCluster> EksClusters { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ScalingResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-scalingresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ScalingResources { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksResourceScalingUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.EksResourceScalingUngraceful Ungraceful { get; set; }
            /// <summary>
            /// TargetPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingconfiguration.html#cfn-arcregionswitch-plan-eksresourcescalingconfiguration-targetpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetPercent { get; set; }
        }

        public class EksResourceScalingUngraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumSuccessPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eksresourcescalingungraceful.html#cfn-arcregionswitch-plan-eksresourcescalingungraceful-minimumsuccesspercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumSuccessPercentage { get; set; }
        }

        public class EventSourceMapping : Humidifier.Base.BaseSubResource, IHaveArn, IHaveExternalId
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eventsourcemapping.html#cfn-arcregionswitch-plan-eventsourcemapping-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eventsourcemapping.html#cfn-arcregionswitch-plan-eventsourcemapping-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-eventsourcemapping.html#cfn-arcregionswitch-plan-eventsourcemapping-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class ExecutionApprovalConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionapprovalconfiguration.html#cfn-arcregionswitch-plan-executionapprovalconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ApprovalRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionapprovalconfiguration.html#cfn-arcregionswitch-plan-executionapprovalconfiguration-approvalrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApprovalRole { get; set; }
        }

        public class ExecutionBlockConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuroraServerlessScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-auroraserverlessscalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuroraServerlessScalingConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.AuroraServerlessScalingConfiguration AuroraServerlessScalingConfig { get; set; }
            /// <summary>
            /// RdsPromoteReadReplicaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-rdspromotereadreplicaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsPromoteReadReplicaConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.RdsPromoteReadReplicaConfiguration RdsPromoteReadReplicaConfig { get; set; }
            /// <summary>
            /// ParallelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-parallelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParallelExecutionBlockConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.ParallelExecutionBlockConfiguration ParallelConfig { get; set; }
            /// <summary>
            /// EcsCapacityIncreaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-ecscapacityincreaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsCapacityIncreaseConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.EcsCapacityIncreaseConfiguration EcsCapacityIncreaseConfig { get; set; }
            /// <summary>
            /// ExecutionApprovalConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-executionapprovalconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExecutionApprovalConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.ExecutionApprovalConfiguration ExecutionApprovalConfig { get; set; }
            /// <summary>
            /// LambdaEventSourceMappingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-lambdaeventsourcemappingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaEventSourceMappingConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.LambdaEventSourceMappingConfiguration LambdaEventSourceMappingConfig { get; set; }
            /// <summary>
            /// RegionSwitchPlanConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-regionswitchplanconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegionSwitchPlanConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.RegionSwitchPlanConfiguration RegionSwitchPlanConfig { get; set; }
            /// <summary>
            /// RdsSwitchoverReadReplicaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-rdsswitchoverreadreplicaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsSwitchoverReadReplicaConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.RdsSwitchoverReadReplicaConfiguration RdsSwitchoverReadReplicaConfig { get; set; }
            /// <summary>
            /// GlobalAuroraConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-globalauroraconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalAuroraConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.GlobalAuroraConfiguration GlobalAuroraConfig { get; set; }
            /// <summary>
            /// Route53HealthCheckConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-route53healthcheckconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Route53HealthCheckConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.Route53HealthCheckConfiguration Route53HealthCheckConfig { get; set; }
            /// <summary>
            /// RdsCreateCrossRegionReadReplicaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-rdscreatecrossregionreadreplicaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsCreateCrossRegionReplicaConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.RdsCreateCrossRegionReplicaConfiguration RdsCreateCrossRegionReadReplicaConfig { get; set; }
            /// <summary>
            /// NeptuneGlobalDatabaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-neptuneglobaldatabaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NeptuneGlobalDatabaseConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.NeptuneGlobalDatabaseConfiguration NeptuneGlobalDatabaseConfig { get; set; }
            /// <summary>
            /// ArcRoutingControlConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-arcroutingcontrolconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcRoutingControlConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.ArcRoutingControlConfiguration ArcRoutingControlConfig { get; set; }
            /// <summary>
            /// DocumentDbConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-documentdbconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentDbConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.DocumentDbConfiguration DocumentDbConfig { get; set; }
            /// <summary>
            /// EksResourceScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-eksresourcescalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksResourceScalingConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.EksResourceScalingConfiguration EksResourceScalingConfig { get; set; }
            /// <summary>
            /// CustomActionLambdaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-customactionlambdaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionLambdaConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.CustomActionLambdaConfiguration CustomActionLambdaConfig { get; set; }
            /// <summary>
            /// AuroraProvisionedScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-auroraprovisionedscalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuroraProvisionedScalingConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.AuroraProvisionedScalingConfiguration AuroraProvisionedScalingConfig { get; set; }
            /// <summary>
            /// SsmSendCommandConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-ssmsendcommandconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmSendCommandConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.SsmSendCommandConfiguration SsmSendCommandConfig { get; set; }
            /// <summary>
            /// Ec2AsgCapacityIncreaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-executionblockconfiguration.html#cfn-arcregionswitch-plan-executionblockconfiguration-ec2asgcapacityincreaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ec2AsgCapacityIncreaseConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.Ec2AsgCapacityIncreaseConfiguration Ec2AsgCapacityIncreaseConfig { get; set; }
        }

        public class GlobalAuroraConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveBehavior, IHaveGlobalClusterIdentifier, IHaveTimeoutMinutes
        {
            /// <summary>
            /// DatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-databaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DatabaseClusterArns { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Behavior { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalAuroraUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.GlobalAuroraUngraceful Ungraceful { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraconfiguration.html#cfn-arcregionswitch-plan-globalauroraconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlobalClusterIdentifier { get; set; }
        }

        public class GlobalAuroraUngraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-globalauroraungraceful.html#cfn-arcregionswitch-plan-globalauroraungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ungraceful { get; set; }
        }

        public class KubernetesResourceType : Humidifier.Base.BaseSubResource, IHaveApiVersion
        {
            /// <summary>
            /// ApiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-kubernetesresourcetype.html#cfn-arcregionswitch-plan-kubernetesresourcetype-apiversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiVersion { get; set; }
            /// <summary>
            /// Kind
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-kubernetesresourcetype.html#cfn-arcregionswitch-plan-kubernetesresourcetype-kind
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Kind { get; set; }
        }

        public class LambdaEventSourceMappingConfiguration : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTimeoutMinutes
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionEventSourceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-regioneventsourcemappings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: EventSourceMapping
            /// </summary>
            public Dictionary<string, Humidifier.ARCRegionSwitch.PlanTypes.EventSourceMapping> RegionEventSourceMappings { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaeventsourcemappingconfiguration.html#cfn-arcregionswitch-plan-lambdaeventsourcemappingconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaEventSourceMappingUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.LambdaEventSourceMappingUngraceful Ungraceful { get; set; }
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
            public dynamic Behavior { get; set; }
        }

        public class LambdaUngraceful : Humidifier.Base.BaseSubResource, IHaveBehavior
        {
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdaungraceful.html#cfn-arcregionswitch-plan-lambdaungraceful-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Behavior { get; set; }
        }

        public class Lambdas : Humidifier.Base.BaseSubResource, IHaveArn, IHaveExternalId
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-lambdas.html#cfn-arcregionswitch-plan-lambdas-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class NeptuneGlobalDatabaseConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveBehavior, IHaveGlobalClusterIdentifier, IHaveTimeoutMinutes
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// RegionDatabaseClusterArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-regiondatabaseclusterarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> RegionDatabaseClusterArns { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Behavior { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NeptuneUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.NeptuneUngraceful Ungraceful { get; set; }
            /// <summary>
            /// GlobalClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneglobaldatabaseconfiguration.html#cfn-arcregionswitch-plan-neptuneglobaldatabaseconfiguration-globalclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlobalClusterIdentifier { get; set; }
        }

        public class NeptuneUngraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-neptuneungraceful.html#cfn-arcregionswitch-plan-neptuneungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ungraceful { get; set; }
        }

        public class ParallelExecutionBlockConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Steps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-parallelexecutionblockconfiguration.html#cfn-arcregionswitch-plan-parallelexecutionblockconfiguration-steps
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Step
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.Step> Steps { get; set; }
        }

        public class RdsCreateCrossRegionReplicaConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveTimeoutMinutes
        {
            /// <summary>
            /// DbInstanceArnMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-dbinstancearnmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> DbInstanceArnMap { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration.html#cfn-arcregionswitch-plan-rdscreatecrossregionreplicaconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class RdsPromoteReadReplicaConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveTimeoutMinutes
        {
            /// <summary>
            /// DbInstanceArnMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-dbinstancearnmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> DbInstanceArnMap { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdspromotereadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdspromotereadreplicaconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class RdsSwitchoverReadReplicaConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveTimeoutMinutes
        {
            /// <summary>
            /// DbInstanceArnMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-dbinstancearnmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> DbInstanceArnMap { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration.html#cfn-arcregionswitch-plan-rdsswitchoverreadreplicaconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.RdsUngraceful Ungraceful { get; set; }
        }

        public class RdsUngraceful : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-rdsungraceful.html#cfn-arcregionswitch-plan-rdsungraceful-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ungraceful { get; set; }
        }

        public class RegionSwitchPlanConfiguration : Humidifier.Base.BaseSubResource, IHaveArn, IHaveExternalId
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-regionswitchplanconfiguration.html#cfn-arcregionswitch-plan-regionswitchplanconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-regionswitchplanconfiguration.html#cfn-arcregionswitch-plan-regionswitchplanconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-regionswitchplanconfiguration.html#cfn-arcregionswitch-plan-regionswitchplanconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class ReportConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReportOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-reportconfiguration.html#cfn-arcregionswitch-plan-reportconfiguration-reportoutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReportOutputConfiguration
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.ReportOutputConfiguration> ReportOutput { get; set; }
        }

        public class ReportOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-reportoutputconfiguration.html#cfn-arcregionswitch-plan-reportoutputconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ReportOutputConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.S3ReportOutputConfiguration S3Configuration { get; set; }
        }

        public class Route53HealthCheckConfiguration : Humidifier.Base.BaseSubResource, IHaveHostedZoneId, IHaveExternalId, IHaveTimeoutMinutes
        {
            /// <summary>
            /// RecordName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-recordname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordName { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-hostedzoneid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// RecordSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53healthcheckconfiguration.html#cfn-arcregionswitch-plan-route53healthcheckconfiguration-recordsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Route53ResourceRecordSet
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.Route53ResourceRecordSet> RecordSets { get; set; }
        }

        public class Route53ResourceRecordSet : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53resourcerecordset.html#cfn-arcregionswitch-plan-route53resourcerecordset-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// RecordSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-route53resourcerecordset.html#cfn-arcregionswitch-plan-route53resourcerecordset-recordsetidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordSetIdentifier { get; set; }
        }

        public class S3ReportOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketOwner
        {
            /// <summary>
            /// BucketPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-s3reportoutputconfiguration.html#cfn-arcregionswitch-plan-s3reportoutputconfiguration-bucketpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPath { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-s3reportoutputconfiguration.html#cfn-arcregionswitch-plan-s3reportoutputconfiguration-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
        }

        public class Service : Humidifier.Base.BaseSubResource, IHaveExternalId, IHaveClusterArn
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-clusterarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterArn { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// ServiceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-servicearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceArn { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-service.html#cfn-arcregionswitch-plan-service-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
        }

        public class SsmDocumentConfig : Humidifier.Base.BaseSubResource, IHaveParameters, IHaveExternalId, IHaveDocumentVersion
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Parameters { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-targets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsmTarget
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.SsmTarget> Targets { get; set; }
            /// <summary>
            /// DocumentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-documentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentVersion { get; set; }
            /// <summary>
            /// CrossAccountRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-crossaccountrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRole { get; set; }
            /// <summary>
            /// DocumentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmdocumentconfig.html#cfn-arcregionswitch-plan-ssmdocumentconfig-documentarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentArn { get; set; }
        }

        public class SsmSendCommandConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes
        {
            /// <summary>
            /// RegionDocuments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-regiondocuments
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SsmDocumentConfig
            /// </summary>
            public Dictionary<string, Humidifier.ARCRegionSwitch.PlanTypes.SsmDocumentConfig> RegionDocuments { get; set; }
            /// <summary>
            /// RetryIntervalMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-retryintervalminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RetryIntervalMinutes { get; set; }
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeoutMinutes { get; set; }
            /// <summary>
            /// Ungraceful
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmsendcommandconfiguration.html#cfn-arcregionswitch-plan-ssmsendcommandconfiguration-ungraceful
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmSendCommandUngraceful
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.SsmSendCommandUngraceful Ungraceful { get; set; }
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
            public dynamic Behavior { get; set; }
        }

        public class SsmTarget : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmtarget.html#cfn-arcregionswitch-plan-ssmtarget-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-ssmtarget.html#cfn-arcregionswitch-plan-ssmtarget-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Step : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// ExecutionBlockConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-executionblockconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExecutionBlockConfiguration
            /// </summary>
            public Humidifier.ARCRegionSwitch.PlanTypes.ExecutionBlockConfiguration ExecutionBlockConfiguration { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ExecutionBlockType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-executionblocktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionBlockType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-step.html#cfn-arcregionswitch-plan-step-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Trigger : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveAction, IHaveTargetRegion
        {
            /// <summary>
            /// TargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-targetregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetRegion { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// MinDelayMinutesBetweenExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-mindelayminutesbetweenexecutions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinDelayMinutesBetweenExecutions { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-trigger.html#cfn-arcregionswitch-plan-trigger-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TriggerCondition
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.TriggerCondition> Conditions { get; set; }
        }

        public class TriggerCondition : Humidifier.Base.BaseSubResource, IHaveCondition
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-triggercondition.html#cfn-arcregionswitch-plan-triggercondition-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
            /// <summary>
            /// AssociatedAlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-triggercondition.html#cfn-arcregionswitch-plan-triggercondition-associatedalarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssociatedAlarmName { get; set; }
        }

        public class Workflow : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Steps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-steps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Step
            /// </summary>
            public List<Humidifier.ARCRegionSwitch.PlanTypes.Step> Steps { get; set; }
            /// <summary>
            /// WorkflowTargetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-workflowtargetaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkflowTargetAction { get; set; }
            /// <summary>
            /// WorkflowDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-workflowdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkflowDescription { get; set; }
            /// <summary>
            /// WorkflowTargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arcregionswitch-plan-workflow.html#cfn-arcregionswitch-plan-workflow-workflowtargetregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkflowTargetRegion { get; set; }
        }
    }
}