namespace Humidifier.CodeBuild
{
    using System.Collections.Generic;
    using FleetTypes;

    public class Fleet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveImageId, IHaveComputeType, IHaveBaseCapacity
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
        public dynamic FleetServiceRole { get; set; }
        /// <summary>
        /// EnvironmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-environmenttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentType { get; set; }
        /// <summary>
        /// OverflowBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-overflowbehavior
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OverflowBehavior { get; set; }
        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-imageid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageId { get; set; }
        /// <summary>
        /// ScalingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-scalingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfigurationInput
        /// </summary>
        public Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput ScalingConfiguration { get; set; }
        /// <summary>
        /// BaseCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-basecapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic BaseCapacity { get; set; }
        /// <summary>
        /// FleetProxyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-fleetproxyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProxyConfiguration
        /// </summary>
        public Humidifier.CodeBuild.FleetTypes.ProxyConfiguration FleetProxyConfiguration { get; set; }
        /// <summary>
        /// ComputeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-computeconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ComputeConfiguration
        /// </summary>
        public Humidifier.CodeBuild.FleetTypes.ComputeConfiguration ComputeConfiguration { get; set; }
        /// <summary>
        /// ComputeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-computetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ComputeType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FleetVpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-fleet.html#cfn-codebuild-fleet-fleetvpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.CodeBuild.FleetTypes.VpcConfig FleetVpcConfig { get; set; }
    }

    namespace FleetTypes
    {
        public class ComputeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// disk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-disk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic disk { get; set; }
            /// <summary>
            /// memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic memory { get; set; }
            /// <summary>
            /// vCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic vCpu { get; set; }
            /// <summary>
            /// machineType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-computeconfiguration.html#cfn-codebuild-fleet-computeconfiguration-machinetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic machineType { get; set; }
        }

        public class FleetProxyRule : Humidifier.Base.BaseSubResource, IHaveType, IHaveEffect
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-fleetproxyrule.html#cfn-codebuild-fleet-fleetproxyrule-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Effect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-fleetproxyrule.html#cfn-codebuild-fleet-fleetproxyrule-effect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Effect { get; set; }
            /// <summary>
            /// Entities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-fleetproxyrule.html#cfn-codebuild-fleet-fleetproxyrule-entities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Entities { get; set; }
        }

        public class ProxyConfiguration : Humidifier.Base.BaseSubResource, IHaveDefaultBehavior
        {
            /// <summary>
            /// DefaultBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-proxyconfiguration.html#cfn-codebuild-fleet-proxyconfiguration-defaultbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultBehavior { get; set; }
            /// <summary>
            /// OrderedProxyRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-proxyconfiguration.html#cfn-codebuild-fleet-proxyconfiguration-orderedproxyrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetProxyRule
            /// </summary>
            public List<Humidifier.CodeBuild.FleetTypes.FleetProxyRule> OrderedProxyRules { get; set; }
        }

        public class ScalingConfigurationInput : Humidifier.Base.BaseSubResource, IHaveMaxCapacity, IHaveScalingType
        {
            /// <summary>
            /// TargetTrackingScalingConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-scalingconfigurationinput.html#cfn-codebuild-fleet-scalingconfigurationinput-targettrackingscalingconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingScalingConfiguration
            /// </summary>
            public List<Humidifier.CodeBuild.FleetTypes.TargetTrackingScalingConfiguration> TargetTrackingScalingConfigs { get; set; }
            /// <summary>
            /// ScalingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-scalingconfigurationinput.html#cfn-codebuild-fleet-scalingconfigurationinput-scalingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScalingType { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-scalingconfigurationinput.html#cfn-codebuild-fleet-scalingconfigurationinput-maxcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacity { get; set; }
        }

        public class TargetTrackingScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue, IHaveMetricType
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-targettrackingscalingconfiguration.html#cfn-codebuild-fleet-targettrackingscalingconfiguration-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
            /// <summary>
            /// MetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-targettrackingscalingconfiguration.html#cfn-codebuild-fleet-targettrackingscalingconfiguration-metrictype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricType { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveVpcId, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-vpcconfig.html#cfn-codebuild-fleet-vpcconfig-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-vpcconfig.html#cfn-codebuild-fleet-vpcconfig-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-fleet-vpcconfig.html#cfn-codebuild-fleet-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}