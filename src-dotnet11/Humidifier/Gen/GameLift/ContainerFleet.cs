namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using ContainerFleetTypes;

    public class ContainerFleet : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfGameLiftContainerFleetTypesScalingPolicyScalingPolicies, IHaveGameServerContainerGroupDefinitionName, IHaveDescription, IHaveFleetRoleArn, IHavePerInstanceContainerGroupDefinitionName, IHaveListOfGameLiftContainerFleetTypesLocationConfigurationLocations, IHaveGameLiftContainerFleetTypesGameSessionCreationLimitPolicyGameSessionCreationLimitPolicy, IHaveNewGameSessionProtectionPolicy, IHaveGameServerContainerGroupsPerInstance_Integer, IHaveGameLiftContainerFleetTypesLogConfigurationLogConfiguration, IHaveGameLiftContainerFleetTypesConnectionPortRangeInstanceConnectionPortRange, IHavePlayerGatewayMode, IHaveStringListOfMetricGroups, IHaveListOfGameLiftContainerFleetTypesIpPermissionInstanceInboundPermissions, IHaveInstanceType, IHaveGameLiftContainerFleetTypesDeploymentConfigurationDeploymentConfiguration, IHaveBillingType
    {
        public class Attributes
        {
            public static string DeploymentDetails =  "DeploymentDetails" ;
            public static string PerInstanceContainerGroupDefinitionArn =  "PerInstanceContainerGroupDefinitionArn" ;
            public static string Status =  "Status" ;
            public static string GameServerContainerGroupDefinitionArn =  "GameServerContainerGroupDefinitionArn" ;
            public static string FleetId =  "FleetId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string MaximumGameServerContainerGroupsPerInstance =  "MaximumGameServerContainerGroupsPerInstance" ;
            public static string FleetArn =  "FleetArn" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.ContainerFleet; }
        /// <summary>
        /// ScalingPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-scalingpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ScalingPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy>, IReadOnlyList<Union<Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy, BaseFunction>>, BaseFunction>? ScalingPolicies { get; set; }
        /// <summary>
        /// GameServerContainerGroupDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-gameservercontainergroupdefinitionname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GameServerContainerGroupDefinitionName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// FleetRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-fleetrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FleetRoleArn { get; set; }
        /// <summary>
        /// PerInstanceContainerGroupDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-perinstancecontainergroupdefinitionname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PerInstanceContainerGroupDefinitionName { get; set; }
        /// <summary>
        /// Locations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-locations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LocationConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration>, IReadOnlyList<Union<Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration, BaseFunction>>, BaseFunction>? Locations { get; set; }
        /// <summary>
        /// GameSessionCreationLimitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-gamesessioncreationlimitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GameSessionCreationLimitPolicy
        /// </summary>
        public Union<Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy, BaseFunction>? GameSessionCreationLimitPolicy { get; set; }
        /// <summary>
        /// NewGameSessionProtectionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-newgamesessionprotectionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NewGameSessionProtectionPolicy { get; set; }
        /// <summary>
        /// GameServerContainerGroupsPerInstance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-gameservercontainergroupsperinstance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? GameServerContainerGroupsPerInstance { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.ContainerFleetTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
        /// <summary>
        /// InstanceConnectionPortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-instanceconnectionportrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionPortRange
        /// </summary>
        public Union<Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange, BaseFunction>? InstanceConnectionPortRange { get; set; }
        /// <summary>
        /// PlayerGatewayMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-playergatewaymode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlayerGatewayMode { get; set; }
        /// <summary>
        /// MetricGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-metricgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricGroups { get; set; }
        /// <summary>
        /// InstanceInboundPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-instanceinboundpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpPermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.ContainerFleetTypes.IpPermission>, IReadOnlyList<Union<Humidifier.GameLift.ContainerFleetTypes.IpPermission, BaseFunction>>, BaseFunction>? InstanceInboundPermissions { get; set; }
        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-instancetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration, BaseFunction>? DeploymentConfiguration { get; set; }
        /// <summary>
        /// BillingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-billingtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingType { get; set; }
    }

    namespace ContainerFleetTypes
    {
        public class ConnectionPortRange : Humidifier.Base.BaseSubResource, IHaveFromPort_Integer, IHaveToPort_Integer
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-connectionportrange.html#cfn-gamelift-containerfleet-connectionportrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-connectionportrange.html#cfn-gamelift-containerfleet-connectionportrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
        }

        public class DeploymentConfiguration : Humidifier.Base.BaseSubResource, IHaveProtectionStrategy, IHaveImpairmentStrategy, IHaveMinimumHealthyPercentage_Integer
        {
            /// <summary>
            /// ProtectionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentconfiguration.html#cfn-gamelift-containerfleet-deploymentconfiguration-protectionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProtectionStrategy { get; set; }
            /// <summary>
            /// ImpairmentStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentconfiguration.html#cfn-gamelift-containerfleet-deploymentconfiguration-impairmentstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImpairmentStrategy { get; set; }
            /// <summary>
            /// MinimumHealthyPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentconfiguration.html#cfn-gamelift-containerfleet-deploymentconfiguration-minimumhealthypercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumHealthyPercentage { get; set; }
        }

        public class DeploymentDetails : Humidifier.Base.BaseSubResource, IHaveLatestDeploymentId
        {
            /// <summary>
            /// LatestDeploymentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentdetails.html#cfn-gamelift-containerfleet-deploymentdetails-latestdeploymentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LatestDeploymentId { get; set; }
        }

        public class GameSessionCreationLimitPolicy : Humidifier.Base.BaseSubResource, IHavePolicyPeriodInMinutes_Integer, IHaveNewGameSessionsPerCreator_Integer
        {
            /// <summary>
            /// PolicyPeriodInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-gamesessioncreationlimitpolicy.html#cfn-gamelift-containerfleet-gamesessioncreationlimitpolicy-policyperiodinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PolicyPeriodInMinutes { get; set; }
            /// <summary>
            /// NewGameSessionsPerCreator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-gamesessioncreationlimitpolicy.html#cfn-gamelift-containerfleet-gamesessioncreationlimitpolicy-newgamesessionspercreator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NewGameSessionsPerCreator { get; set; }
        }

        public class IpPermission : Humidifier.Base.BaseSubResource, IHaveIpRange, IHaveFromPort_Integer, IHaveToPort_Integer, IHaveProtocol
        {
            /// <summary>
            /// IpRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-iprange
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpRange { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class LocationCapacity : Humidifier.Base.BaseSubResource, IHaveMinSize_Integer, IHaveGameLiftContainerFleetTypesManagedCapacityConfigurationManagedCapacityConfiguration, IHaveDesiredEC2Instances_Integer, IHaveMaxSize_Integer
        {
            /// <summary>
            /// MinSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-minsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinSize { get; set; }
            /// <summary>
            /// ManagedCapacityConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-managedcapacityconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedCapacityConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration, BaseFunction>? ManagedCapacityConfiguration { get; set; }
            /// <summary>
            /// DesiredEC2Instances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-desiredec2instances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DesiredEC2Instances { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-maxsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSize { get; set; }
        }

        public class LocationConfiguration : Humidifier.Base.BaseSubResource, IHavePlayerGatewayStatus, IHaveGameLiftContainerFleetTypesLocationCapacityLocationCapacity, IHaveStringListOfStoppedActions, IHaveLocation
        {
            /// <summary>
            /// PlayerGatewayStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-playergatewaystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlayerGatewayStatus { get; set; }
            /// <summary>
            /// LocationCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-locationcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocationCapacity
            /// </summary>
            public Union<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity, BaseFunction>? LocationCapacity { get; set; }
            /// <summary>
            /// StoppedActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-stoppedactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StoppedActions { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLogDestination, IHaveS3BucketName, IHaveLogGroupArn
        {
            /// <summary>
            /// LogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-logconfiguration.html#cfn-gamelift-containerfleet-logconfiguration-logdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogDestination { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-logconfiguration.html#cfn-gamelift-containerfleet-logconfiguration-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-logconfiguration.html#cfn-gamelift-containerfleet-logconfiguration-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
        }

        public class ManagedCapacityConfiguration : Humidifier.Base.BaseSubResource, IHaveScaleInAfterInactivityMinutes_Integer, IHaveZeroCapacityStrategy
        {
            /// <summary>
            /// ScaleInAfterInactivityMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-managedcapacityconfiguration.html#cfn-gamelift-containerfleet-managedcapacityconfiguration-scaleinafterinactivityminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInAfterInactivityMinutes { get; set; }
            /// <summary>
            /// ZeroCapacityStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-managedcapacityconfiguration.html#cfn-gamelift-containerfleet-managedcapacityconfiguration-zerocapacitystrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZeroCapacityStrategy { get; set; }
        }

        public class ScalingPolicy : Humidifier.Base.BaseSubResource, IHaveMetricName, IHavePolicyType, IHaveComparisonOperator, IHaveGameLiftContainerFleetTypesTargetConfigurationTargetConfiguration, IHaveScalingAdjustment_Integer, IHaveEvaluationPeriods_Integer, IHaveName, IHaveScalingAdjustmentType, IHaveThreshold_Double
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-policytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyType { get; set; }
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// TargetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-targetconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration, BaseFunction>? TargetConfiguration { get; set; }
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-scalingadjustment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScalingAdjustment { get; set; }
            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationPeriods { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ScalingAdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-scalingadjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingAdjustmentType { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue_Double
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-targetconfiguration.html#cfn-gamelift-containerfleet-targetconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
        }
    }
}