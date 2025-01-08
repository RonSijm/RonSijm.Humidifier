namespace Humidifier.GameLift
{
    using System.Collections.Generic;
    using ContainerFleetTypes;

    public class ContainerFleet : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveInstanceType, IHaveNewGameSessionProtectionPolicy, IHaveMetricGroups
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
        public List<Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy> ScalingPolicies { get; set; }
        /// <summary>
        /// GameServerContainerGroupDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-gameservercontainergroupdefinitionname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GameServerContainerGroupDefinitionName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// FleetRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-fleetrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FleetRoleArn { get; set; }
        /// <summary>
        /// PerInstanceContainerGroupDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-perinstancecontainergroupdefinitionname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PerInstanceContainerGroupDefinitionName { get; set; }
        /// <summary>
        /// Locations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-locations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LocationConfiguration
        /// </summary>
        public List<Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration> Locations { get; set; }
        /// <summary>
        /// GameSessionCreationLimitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-gamesessioncreationlimitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GameSessionCreationLimitPolicy
        /// </summary>
        public Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy GameSessionCreationLimitPolicy { get; set; }
        /// <summary>
        /// NewGameSessionProtectionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-newgamesessionprotectionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NewGameSessionProtectionPolicy { get; set; }
        /// <summary>
        /// GameServerContainerGroupsPerInstance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-gameservercontainergroupsperinstance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic GameServerContainerGroupsPerInstance { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Humidifier.GameLift.ContainerFleetTypes.LogConfiguration LogConfiguration { get; set; }
        /// <summary>
        /// InstanceConnectionPortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-instanceconnectionportrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionPortRange
        /// </summary>
        public Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange InstanceConnectionPortRange { get; set; }
        /// <summary>
        /// MetricGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-metricgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic MetricGroups { get; set; }
        /// <summary>
        /// InstanceInboundPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-instanceinboundpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpPermission
        /// </summary>
        public List<Humidifier.GameLift.ContainerFleetTypes.IpPermission> InstanceInboundPermissions { get; set; }
        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-instancetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfiguration
        /// </summary>
        public Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration DeploymentConfiguration { get; set; }
        /// <summary>
        /// BillingType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containerfleet.html#cfn-gamelift-containerfleet-billingtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BillingType { get; set; }
    }

    namespace ContainerFleetTypes
    {
        public class ConnectionPortRange : Humidifier.Base.BaseSubResource, IHaveFromPort, IHaveToPort
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-connectionportrange.html#cfn-gamelift-containerfleet-connectionportrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-connectionportrange.html#cfn-gamelift-containerfleet-connectionportrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort { get; set; }
        }

        public class DeploymentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProtectionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentconfiguration.html#cfn-gamelift-containerfleet-deploymentconfiguration-protectionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProtectionStrategy { get; set; }
            /// <summary>
            /// ImpairmentStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentconfiguration.html#cfn-gamelift-containerfleet-deploymentconfiguration-impairmentstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImpairmentStrategy { get; set; }
            /// <summary>
            /// MinimumHealthyPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentconfiguration.html#cfn-gamelift-containerfleet-deploymentconfiguration-minimumhealthypercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumHealthyPercentage { get; set; }
        }

        public class DeploymentDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LatestDeploymentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-deploymentdetails.html#cfn-gamelift-containerfleet-deploymentdetails-latestdeploymentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LatestDeploymentId { get; set; }
        }

        public class GameSessionCreationLimitPolicy : Humidifier.Base.BaseSubResource, IHavePolicyPeriodInMinutes, IHaveNewGameSessionsPerCreator
        {
            /// <summary>
            /// PolicyPeriodInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-gamesessioncreationlimitpolicy.html#cfn-gamelift-containerfleet-gamesessioncreationlimitpolicy-policyperiodinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PolicyPeriodInMinutes { get; set; }
            /// <summary>
            /// NewGameSessionsPerCreator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-gamesessioncreationlimitpolicy.html#cfn-gamelift-containerfleet-gamesessioncreationlimitpolicy-newgamesessionspercreator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NewGameSessionsPerCreator { get; set; }
        }

        public class IpPermission : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveFromPort, IHaveToPort, IHaveIpRange
        {
            /// <summary>
            /// IpRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-iprange
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpRange { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-ippermission.html#cfn-gamelift-containerfleet-ippermission-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class LocationCapacity : Humidifier.Base.BaseSubResource, IHaveMinSize, IHaveMaxSize, IHaveDesiredEC2Instances
        {
            /// <summary>
            /// MinSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-minsize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinSize { get; set; }
            /// <summary>
            /// DesiredEC2Instances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-desiredec2instances
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DesiredEC2Instances { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationcapacity.html#cfn-gamelift-containerfleet-locationcapacity-maxsize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSize { get; set; }
        }

        public class LocationConfiguration : Humidifier.Base.BaseSubResource, IHaveLocation
        {
            /// <summary>
            /// LocationCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-locationcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocationCapacity
            /// </summary>
            public Humidifier.GameLift.ContainerFleetTypes.LocationCapacity LocationCapacity { get; set; }
            /// <summary>
            /// StoppedActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-stoppedactions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StoppedActions { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-locationconfiguration.html#cfn-gamelift-containerfleet-locationconfiguration-location
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Location { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketName, IHaveLogDestination
        {
            /// <summary>
            /// LogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-logconfiguration.html#cfn-gamelift-containerfleet-logconfiguration-logdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogDestination { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-logconfiguration.html#cfn-gamelift-containerfleet-logconfiguration-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketName { get; set; }
        }

        public class ScalingPolicy : Humidifier.Base.BaseSubResource, IHaveName, IHaveMetricName, IHaveComparisonOperator, IHaveThreshold, IHavePolicyType, IHaveScalingAdjustment, IHaveEvaluationPeriods, IHaveScalingAdjustmentType
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-policytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyType { get; set; }
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// TargetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-targetconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetConfiguration
            /// </summary>
            public Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration TargetConfiguration { get; set; }
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-scalingadjustment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScalingAdjustment { get; set; }
            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EvaluationPeriods { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ScalingAdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-scalingadjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScalingAdjustmentType { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-scalingpolicy.html#cfn-gamelift-containerfleet-scalingpolicy-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Threshold { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containerfleet-targetconfiguration.html#cfn-gamelift-containerfleet-targetconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
        }
    }
}