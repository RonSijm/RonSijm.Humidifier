namespace Humidifier.CodeDeploy
{
    using global::System.Collections.Generic;
    using DeploymentConfigTypes;

    public class DeploymentConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveComputePlatform, IHaveCodeDeployDeploymentConfigTypesZonalConfigZonalConfig, IHaveDeploymentConfigName, IHaveCodeDeployDeploymentConfigTypesTrafficRoutingConfigTrafficRoutingConfig, IHaveCodeDeployDeploymentConfigTypesMinimumHealthyHostsMinimumHealthyHosts
    {
        public override string AWSTypeName { get => AWS.CodeDeploy.DeploymentConfig; }
        /// <summary>
        /// ComputePlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-computeplatform
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputePlatform { get; set; }
        /// <summary>
        /// ZonalConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-zonalconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ZonalConfig
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig, BaseFunction>? ZonalConfig { get; set; }
        public Union<string, BaseFunction>? DeploymentConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TrafficRoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-trafficroutingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TrafficRoutingConfig
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentConfigTypes.TrafficRoutingConfig, BaseFunction>? TrafficRoutingConfig { get; set; }
        /// <summary>
        /// MinimumHealthyHosts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MinimumHealthyHosts
        /// </summary>
        public Union<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHosts, BaseFunction>? MinimumHealthyHosts { get; set; }
    }

    namespace DeploymentConfigTypes
    {
        public class MinimumHealthyHosts : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class MinimumHealthyHostsPerZone : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhostsperzone.html#cfn-codedeploy-deploymentconfig-minimumhealthyhostsperzone-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhostsperzone.html#cfn-codedeploy-deploymentconfig-minimumhealthyhostsperzone-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class TimeBasedCanary : Humidifier.Base.BaseSubResource, IHaveCanaryPercentage_Integer, IHaveCanaryInterval_Integer
        {
            /// <summary>
            /// CanaryPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-timebasedcanary.html#cfn-codedeploy-deploymentconfig-timebasedcanary-canarypercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CanaryPercentage { get; set; }
            /// <summary>
            /// CanaryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-timebasedcanary.html#cfn-codedeploy-deploymentconfig-timebasedcanary-canaryinterval
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CanaryInterval { get; set; }
        }

        public class TimeBasedLinear : Humidifier.Base.BaseSubResource, IHaveLinearInterval_Integer, IHaveLinearPercentage_Integer
        {
            /// <summary>
            /// LinearInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-timebasedlinear.html#cfn-codedeploy-deploymentconfig-timebasedlinear-linearinterval
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LinearInterval { get; set; }
            /// <summary>
            /// LinearPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-timebasedlinear.html#cfn-codedeploy-deploymentconfig-timebasedlinear-linearpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LinearPercentage { get; set; }
        }

        public class TrafficRoutingConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveCodeDeployDeploymentConfigTypesTimeBasedLinearTimeBasedLinear, IHaveCodeDeployDeploymentConfigTypesTimeBasedCanaryTimeBasedCanary
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-trafficroutingconfig.html#cfn-codedeploy-deploymentconfig-trafficroutingconfig-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// TimeBasedLinear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-trafficroutingconfig.html#cfn-codedeploy-deploymentconfig-trafficroutingconfig-timebasedlinear
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeBasedLinear
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedLinear, BaseFunction>? TimeBasedLinear { get; set; }
            /// <summary>
            /// TimeBasedCanary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-trafficroutingconfig.html#cfn-codedeploy-deploymentconfig-trafficroutingconfig-timebasedcanary
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeBasedCanary
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedCanary, BaseFunction>? TimeBasedCanary { get; set; }
        }

        public class ZonalConfig : Humidifier.Base.BaseSubResource, IHaveMonitorDurationInSeconds_Long, IHaveCodeDeployDeploymentConfigTypesMinimumHealthyHostsPerZoneMinimumHealthyHostsPerZone, IHaveFirstZoneMonitorDurationInSeconds_Long
        {
            /// <summary>
            /// MonitorDurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-zonalconfig.html#cfn-codedeploy-deploymentconfig-zonalconfig-monitordurationinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? MonitorDurationInSeconds { get; set; }
            /// <summary>
            /// MinimumHealthyHostsPerZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-zonalconfig.html#cfn-codedeploy-deploymentconfig-zonalconfig-minimumhealthyhostsperzone
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MinimumHealthyHostsPerZone
            /// </summary>
            public Union<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone, BaseFunction>? MinimumHealthyHostsPerZone { get; set; }
            /// <summary>
            /// FirstZoneMonitorDurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-zonalconfig.html#cfn-codedeploy-deploymentconfig-zonalconfig-firstzonemonitordurationinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? FirstZoneMonitorDurationInSeconds { get; set; }
        }
    }
}