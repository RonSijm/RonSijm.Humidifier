namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;
    using FleetTypes;

    public class Fleet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveFleetServiceRole, IHaveEnvironmentType, IHaveOverflowBehavior, IHaveImageId, IHaveCodeBuildFleetTypesScalingConfigurationInputScalingConfiguration, IHaveBaseCapacity_Integer, IHaveCodeBuildFleetTypesProxyConfigurationFleetProxyConfiguration, IHaveCodeBuildFleetTypesComputeConfigurationComputeConfiguration, IHaveComputeType, IHaveName, IHaveCodeBuildFleetTypesVpcConfigFleetVpcConfig
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.Fleet; }
        /// <summary>
        /// FleetServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-fleetservicerole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FleetServiceRole { get; set; }
        /// <summary>
        /// EnvironmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-environmenttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentType { get; set; }
        /// <summary>
        /// OverflowBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-overflowbehavior
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OverflowBehavior { get; set; }
        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-imageid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageId { get; set; }
        /// <summary>
        /// ScalingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-scalingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfigurationInput
        /// </summary>
        public Union<Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput, BaseFunction>? ScalingConfiguration { get; set; }
        /// <summary>
        /// BaseCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-basecapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BaseCapacity { get; set; }
        /// <summary>
        /// FleetProxyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-fleetproxyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProxyConfiguration
        /// </summary>
        public Union<Humidifier.CodeBuild.FleetTypes.ProxyConfiguration, BaseFunction>? FleetProxyConfiguration { get; set; }
        /// <summary>
        /// ComputeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-computeconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ComputeConfiguration
        /// </summary>
        public Union<Humidifier.CodeBuild.FleetTypes.ComputeConfiguration, BaseFunction>? ComputeConfiguration { get; set; }
        /// <summary>
        /// ComputeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-computetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputeType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FleetVpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-fleetvpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.CodeBuild.FleetTypes.VpcConfig, BaseFunction>? FleetVpcConfig { get; set; }
    }

    namespace FleetTypes
    {
        public class ComputeConfiguration : Humidifier.Base.BaseSubResource, IHavedisk_Integer, IHavememory_Integer, IHavevCpu_Integer, IHaveinstanceType, IHavemachineType
        {
            /// <summary>
            /// disk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-disk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? disk { get; set; }
            /// <summary>
            /// memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? memory { get; set; }
            /// <summary>
            /// vCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? vCpu { get; set; }
            /// <summary>
            /// instanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? instanceType { get; set; }
            /// <summary>
            /// machineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? machineType { get; set; }
        }

        public class FleetProxyRule : Humidifier.Base.BaseSubResource, IHaveType, IHaveEffect, IHaveStringListOfEntities
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-fleetproxyrule.html#cfn-codebuild-fleet-fleetproxyrule-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Effect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-fleetproxyrule.html#cfn-codebuild-fleet-fleetproxyrule-effect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Effect { get; set; }
            /// <summary>
            /// Entities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-fleetproxyrule.html#cfn-codebuild-fleet-fleetproxyrule-entities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Entities { get; set; }
        }

        public class ProxyConfiguration : Humidifier.Base.BaseSubResource, IHaveDefaultBehavior, IHaveListOfCodeBuildFleetTypesFleetProxyRuleOrderedProxyRules
        {
            /// <summary>
            /// DefaultBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-proxyconfiguration.html#cfn-codebuild-fleet-proxyconfiguration-defaultbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultBehavior { get; set; }
            /// <summary>
            /// OrderedProxyRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-proxyconfiguration.html#cfn-codebuild-fleet-proxyconfiguration-orderedproxyrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetProxyRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeBuild.FleetTypes.FleetProxyRule>, IReadOnlyList<Union<Humidifier.CodeBuild.FleetTypes.FleetProxyRule, BaseFunction>>, BaseFunction>? OrderedProxyRules { get; set; }
        }

        public class ScalingConfigurationInput : Humidifier.Base.BaseSubResource, IHaveListOfCodeBuildFleetTypesTargetTrackingScalingConfigurationTargetTrackingScalingConfigs, IHaveScalingType, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// TargetTrackingScalingConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-scalingconfigurationinput.html#cfn-codebuild-fleet-scalingconfigurationinput-targettrackingscalingconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingScalingConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeBuild.FleetTypes.TargetTrackingScalingConfiguration>, IReadOnlyList<Union<Humidifier.CodeBuild.FleetTypes.TargetTrackingScalingConfiguration, BaseFunction>>, BaseFunction>? TargetTrackingScalingConfigs { get; set; }
            /// <summary>
            /// ScalingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-scalingconfigurationinput.html#cfn-codebuild-fleet-scalingconfigurationinput-scalingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingType { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-scalingconfigurationinput.html#cfn-codebuild-fleet-scalingconfigurationinput-maxcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }

        public class TargetTrackingScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue_Double, IHaveMetricType
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-targettrackingscalingconfiguration.html#cfn-codebuild-fleet-targettrackingscalingconfiguration-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// MetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-targettrackingscalingconfiguration.html#cfn-codebuild-fleet-targettrackingscalingconfiguration-metrictype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricType { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveVpcId, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-vpcconfig.html#cfn-codebuild-fleet-vpcconfig-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-vpcconfig.html#cfn-codebuild-fleet-vpcconfig-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-vpcconfig.html#cfn-codebuild-fleet-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}