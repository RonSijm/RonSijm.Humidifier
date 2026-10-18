namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using GameServerGroupTypes;

    public class GameServerGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveGameLiftGameServerGroupTypesAutoScalingPolicyAutoScalingPolicy, IHaveMinSize_Double, IHaveDeleteOption, IHaveBalancingStrategy, IHaveGameServerGroupName, IHaveGameLiftGameServerGroupTypesLaunchTemplateLaunchTemplate, IHaveGameServerProtectionPolicy, IHaveStringListOfVpcSubnets, IHaveMaxSize_Double, IHaveListOfGameLiftGameServerGroupTypesInstanceDefinitionInstanceDefinitions, IHaveRoleArn
    {
        public class Attributes
        {
            public static string AutoScalingGroupArn =  "AutoScalingGroupArn" ;
            public static string GameServerGroupArn =  "GameServerGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.GameServerGroup; }
        /// <summary>
        /// AutoScalingPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-autoscalingpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoScalingPolicy
        /// </summary>
        public Union<Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy, BaseFunction>? AutoScalingPolicy { get; set; }
        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-minsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? MinSize { get; set; }
        /// <summary>
        /// DeleteOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-deleteoption
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeleteOption { get; set; }
        /// <summary>
        /// BalancingStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-balancingstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BalancingStrategy { get; set; }
        public Union<string, BaseFunction>? GameServerGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-launchtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LaunchTemplate
        /// </summary>
        public Union<Humidifier.GameLift.GameServerGroupTypes.LaunchTemplate, BaseFunction>? LaunchTemplate { get; set; }
        /// <summary>
        /// GameServerProtectionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-gameserverprotectionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GameServerProtectionPolicy { get; set; }
        /// <summary>
        /// VpcSubnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-vpcsubnets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSubnets { get; set; }
        /// <summary>
        /// MaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-maxsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? MaxSize { get; set; }

        /// <summary>
        /// InstanceDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-instancedefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InstanceDefinition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition>, IReadOnlyList<Union<Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition, BaseFunction>>, BaseFunction>? InstanceDefinitions { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html#cfn-gamelift-gameservergroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace GameServerGroupTypes
    {
        public class AutoScalingPolicy : Humidifier.Base.BaseSubResource, IHaveGameLiftGameServerGroupTypesTargetTrackingConfigurationTargetTrackingConfiguration, IHaveEstimatedInstanceWarmup_Double
        {
            /// <summary>
            /// TargetTrackingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-autoscalingpolicy.html#cfn-gamelift-gameservergroup-autoscalingpolicy-targettrackingconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TargetTrackingConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration, BaseFunction>? TargetTrackingConfiguration { get; set; }
            /// <summary>
            /// EstimatedInstanceWarmup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-autoscalingpolicy.html#cfn-gamelift-gameservergroup-autoscalingpolicy-estimatedinstancewarmup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? EstimatedInstanceWarmup { get; set; }
        }

        public class InstanceDefinition : Humidifier.Base.BaseSubResource, IHaveWeightedCapacity, IHaveInstanceType
        {
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-instancedefinition.html#cfn-gamelift-gameservergroup-instancedefinition-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeightedCapacity { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-instancedefinition.html#cfn-gamelift-gameservergroup-instancedefinition-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class LaunchTemplate : Humidifier.Base.BaseSubResource, IHaveLaunchTemplateName, IHaveVersion, IHaveLaunchTemplateId
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-launchtemplate.html#cfn-gamelift-gameservergroup-launchtemplate-launchtemplatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-launchtemplate.html#cfn-gamelift-gameservergroup-launchtemplate-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-launchtemplate.html#cfn-gamelift-gameservergroup-launchtemplate-launchtemplateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class TargetTrackingConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue_Double
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-targettrackingconfiguration.html#cfn-gamelift-gameservergroup-targettrackingconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
        }
    }
}