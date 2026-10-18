namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using FleetTypes;

    public class Fleet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfGameLiftFleetTypesScalingPolicyScalingPolicies, IHaveDescription, IHavePeerVpcId, IHaveApplyCapacity, IHaveFleetType, IHaveListOfGameLiftFleetTypesIpPermissionEC2InboundPermissions, IHaveListOfGameLiftFleetTypesLocationConfigurationLocations, IHaveGameLiftFleetTypesPlayerGatewayConfigurationPlayerGatewayConfiguration, IHaveNewGameSessionProtectionPolicy, IHaveScriptId, IHaveComputeType, IHaveGameLiftFleetTypesRuntimeConfigurationRuntimeConfiguration, IHaveName, IHavePlayerGatewayMode, IHavePeerVpcAwsAccountId, IHaveGameLiftFleetTypesAnywhereConfigurationAnywhereConfiguration, IHaveInstanceRoleARN, IHaveStringListOfMetricGroups, IHaveBuildId, IHaveGameLiftFleetTypesResourceCreationLimitPolicyResourceCreationLimitPolicy, IHaveEC2InstanceType, IHaveGameLiftFleetTypesCertificateConfigurationCertificateConfiguration, IHaveInstanceRoleCredentialsProvider
    {
        public class Attributes
        {
            public static string FleetId =  "FleetId" ;
            public static string FleetArn =  "FleetArn" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.Fleet; }
        /// <summary>
        /// ScalingPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-scalingpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ScalingPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.FleetTypes.ScalingPolicy>, IReadOnlyList<Union<Humidifier.GameLift.FleetTypes.ScalingPolicy, BaseFunction>>, BaseFunction>? ScalingPolicies { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PeerVpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-peervpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PeerVpcId { get; set; }
        /// <summary>
        /// ApplyCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-applycapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplyCapacity { get; set; }
        /// <summary>
        /// FleetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-fleettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FleetType { get; set; }
        /// <summary>
        /// EC2InboundPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-ec2inboundpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpPermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.FleetTypes.IpPermission>, IReadOnlyList<Union<Humidifier.GameLift.FleetTypes.IpPermission, BaseFunction>>, BaseFunction>? EC2InboundPermissions { get; set; }
        /// <summary>
        /// Locations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-locations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LocationConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.FleetTypes.LocationConfiguration>, IReadOnlyList<Union<Humidifier.GameLift.FleetTypes.LocationConfiguration, BaseFunction>>, BaseFunction>? Locations { get; set; }
        /// <summary>
        /// PlayerGatewayConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-playergatewayconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PlayerGatewayConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.FleetTypes.PlayerGatewayConfiguration, BaseFunction>? PlayerGatewayConfiguration { get; set; }
        /// <summary>
        /// NewGameSessionProtectionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-newgamesessionprotectionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NewGameSessionProtectionPolicy { get; set; }
        /// <summary>
        /// ScriptId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-scriptid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScriptId { get; set; }
        /// <summary>
        /// ComputeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-computetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputeType { get; set; }
        /// <summary>
        /// RuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-runtimeconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuntimeConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.FleetTypes.RuntimeConfiguration, BaseFunction>? RuntimeConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PlayerGatewayMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-playergatewaymode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlayerGatewayMode { get; set; }
        /// <summary>
        /// PeerVpcAwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-peervpcawsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PeerVpcAwsAccountId { get; set; }
        /// <summary>
        /// AnywhereConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-anywhereconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnywhereConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.FleetTypes.AnywhereConfiguration, BaseFunction>? AnywhereConfiguration { get; set; }
        /// <summary>
        /// InstanceRoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-instancerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceRoleARN { get; set; }
        /// <summary>
        /// MetricGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-metricgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricGroups { get; set; }
        /// <summary>
        /// BuildId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-buildid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BuildId { get; set; }
        /// <summary>
        /// ResourceCreationLimitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-resourcecreationlimitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourceCreationLimitPolicy
        /// </summary>
        public Union<Humidifier.GameLift.FleetTypes.ResourceCreationLimitPolicy, BaseFunction>? ResourceCreationLimitPolicy { get; set; }
        /// <summary>
        /// EC2InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-ec2instancetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EC2InstanceType { get; set; }
        /// <summary>
        /// CertificateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-certificateconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CertificateConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.FleetTypes.CertificateConfiguration, BaseFunction>? CertificateConfiguration { get; set; }
        /// <summary>
        /// InstanceRoleCredentialsProvider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-instancerolecredentialsprovider
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceRoleCredentialsProvider { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html#cfn-gamelift-fleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FleetTypes
    {
        public class AnywhereConfiguration : Humidifier.Base.BaseSubResource, IHaveCost
        {
            /// <summary>
            /// Cost
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-anywhereconfiguration.html#cfn-gamelift-fleet-anywhereconfiguration-cost
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cost { get; set; }
        }

        public class CertificateConfiguration : Humidifier.Base.BaseSubResource, IHaveCertificateType
        {
            /// <summary>
            /// CertificateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-certificateconfiguration.html#cfn-gamelift-fleet-certificateconfiguration-certificatetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateType { get; set; }
        }

        public class IpPermission : Humidifier.Base.BaseSubResource, IHaveIpRange, IHaveFromPort_Integer, IHaveToPort_Integer, IHaveProtocol
        {
            /// <summary>
            /// IpRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ippermission.html#cfn-gamelift-fleet-ippermission-iprange
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpRange { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ippermission.html#cfn-gamelift-fleet-ippermission-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ippermission.html#cfn-gamelift-fleet-ippermission-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ippermission.html#cfn-gamelift-fleet-ippermission-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class LocationCapacity : Humidifier.Base.BaseSubResource, IHaveMinSize_Integer, IHaveGameLiftFleetTypesManagedCapacityConfigurationManagedCapacityConfiguration, IHaveDesiredEC2Instances_Integer, IHaveMaxSize_Integer
        {
            /// <summary>
            /// MinSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationcapacity.html#cfn-gamelift-fleet-locationcapacity-minsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinSize { get; set; }
            /// <summary>
            /// ManagedCapacityConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationcapacity.html#cfn-gamelift-fleet-locationcapacity-managedcapacityconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedCapacityConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration, BaseFunction>? ManagedCapacityConfiguration { get; set; }
            /// <summary>
            /// DesiredEC2Instances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationcapacity.html#cfn-gamelift-fleet-locationcapacity-desiredec2instances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DesiredEC2Instances { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationcapacity.html#cfn-gamelift-fleet-locationcapacity-maxsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSize { get; set; }
        }

        public class LocationConfiguration : Humidifier.Base.BaseSubResource, IHavePlayerGatewayStatus, IHaveGameLiftFleetTypesLocationCapacityLocationCapacity, IHaveLocation
        {
            /// <summary>
            /// PlayerGatewayStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationconfiguration.html#cfn-gamelift-fleet-locationconfiguration-playergatewaystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlayerGatewayStatus { get; set; }
            /// <summary>
            /// LocationCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationconfiguration.html#cfn-gamelift-fleet-locationconfiguration-locationcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocationCapacity
            /// </summary>
            public Union<Humidifier.GameLift.FleetTypes.LocationCapacity, BaseFunction>? LocationCapacity { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationconfiguration.html#cfn-gamelift-fleet-locationconfiguration-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class ManagedCapacityConfiguration : Humidifier.Base.BaseSubResource, IHaveScaleInAfterInactivityMinutes_Integer, IHaveZeroCapacityStrategy
        {
            /// <summary>
            /// ScaleInAfterInactivityMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-managedcapacityconfiguration.html#cfn-gamelift-fleet-managedcapacityconfiguration-scaleinafterinactivityminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInAfterInactivityMinutes { get; set; }
            /// <summary>
            /// ZeroCapacityStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-managedcapacityconfiguration.html#cfn-gamelift-fleet-managedcapacityconfiguration-zerocapacitystrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZeroCapacityStrategy { get; set; }
        }

        public class PlayerGatewayConfiguration : Humidifier.Base.BaseSubResource, IHaveGameServerIpProtocolSupported
        {
            /// <summary>
            /// GameServerIpProtocolSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-playergatewayconfiguration.html#cfn-gamelift-fleet-playergatewayconfiguration-gameserveripprotocolsupported
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GameServerIpProtocolSupported { get; set; }
        }

        public class ResourceCreationLimitPolicy : Humidifier.Base.BaseSubResource, IHavePolicyPeriodInMinutes_Integer, IHaveNewGameSessionsPerCreator_Integer
        {
            /// <summary>
            /// PolicyPeriodInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-resourcecreationlimitpolicy.html#cfn-gamelift-fleet-resourcecreationlimitpolicy-policyperiodinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PolicyPeriodInMinutes { get; set; }
            /// <summary>
            /// NewGameSessionsPerCreator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-resourcecreationlimitpolicy.html#cfn-gamelift-fleet-resourcecreationlimitpolicy-newgamesessionspercreator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NewGameSessionsPerCreator { get; set; }
        }

        public class RuntimeConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfGameLiftFleetTypesServerProcessServerProcesses, IHaveMaxConcurrentGameSessionActivations_Integer, IHaveGameSessionActivationTimeoutSeconds_Integer
        {
            /// <summary>
            /// ServerProcesses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-runtimeconfiguration.html#cfn-gamelift-fleet-runtimeconfiguration-serverprocesses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerProcess
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.FleetTypes.ServerProcess>, IReadOnlyList<Union<Humidifier.GameLift.FleetTypes.ServerProcess, BaseFunction>>, BaseFunction>? ServerProcesses { get; set; }
            /// <summary>
            /// MaxConcurrentGameSessionActivations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-runtimeconfiguration.html#cfn-gamelift-fleet-runtimeconfiguration-maxconcurrentgamesessionactivations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentGameSessionActivations { get; set; }
            /// <summary>
            /// GameSessionActivationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-runtimeconfiguration.html#cfn-gamelift-fleet-runtimeconfiguration-gamesessionactivationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GameSessionActivationTimeoutSeconds { get; set; }
        }

        public class ScalingPolicy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMetricName, IHavePolicyType, IHaveComparisonOperator, IHaveGameLiftFleetTypesTargetConfigurationTargetConfiguration, IHaveUpdateStatus, IHaveScalingAdjustment_Integer, IHaveEvaluationPeriods_Integer, IHaveLocation, IHaveName, IHaveScalingAdjustmentType, IHaveThreshold_Double
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-policytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyType { get; set; }
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// TargetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-targetconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.FleetTypes.TargetConfiguration, BaseFunction>? TargetConfiguration { get; set; }
            /// <summary>
            /// UpdateStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-updatestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateStatus { get; set; }
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-scalingadjustment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScalingAdjustment { get; set; }
            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationPeriods { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ScalingAdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-scalingadjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingAdjustmentType { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-scalingpolicy.html#cfn-gamelift-fleet-scalingpolicy-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
        }

        public class ServerProcess : Humidifier.Base.BaseSubResource, IHaveConcurrentExecutions_Integer, IHaveParameters, IHaveLaunchPath
        {
            /// <summary>
            /// ConcurrentExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-serverprocess.html#cfn-gamelift-fleet-serverprocess-concurrentexecutions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConcurrentExecutions { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-serverprocess.html#cfn-gamelift-fleet-serverprocess-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// LaunchPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-serverprocess.html#cfn-gamelift-fleet-serverprocess-launchpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchPath { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue_Double
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-targetconfiguration.html#cfn-gamelift-fleet-targetconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
        }
    }
}