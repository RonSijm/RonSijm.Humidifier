namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using CapacityProviderTypes;

    public class CapacityProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLambdaCapacityProviderTypesCapacityProviderScalingConfigCapacityProviderScalingConfig, IHaveKmsKeyArn, IHaveLambdaCapacityProviderTypesCapacityProviderVpcConfigVpcConfig, IHaveLambdaCapacityProviderTypesPropagateTagsConfigPropagateTags, IHaveCapacityProviderName, IHaveLambdaCapacityProviderTypesInstanceRequirementsInstanceRequirements, IHaveLambdaCapacityProviderTypesCapacityProviderPermissionsConfigPermissionsConfig, IHaveLambdaCapacityProviderTypesCapacityProviderTelemetryConfigTelemetryConfig
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.CapacityProvider; }
        /// <summary>
        /// CapacityProviderScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityProviderScalingConfig
        /// </summary>
        public Union<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig, BaseFunction>? CapacityProviderScalingConfig { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-vpcconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CapacityProviderVpcConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PropagateTagsConfig
        /// </summary>
        public Union<Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig, BaseFunction>? PropagateTags { get; set; }
        public Union<string, BaseFunction>? CapacityProviderName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InstanceRequirements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-instancerequirements
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceRequirements
        /// </summary>
        public Union<Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements, BaseFunction>? InstanceRequirements { get; set; }

        /// <summary>
        /// PermissionsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-permissionsconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CapacityProviderPermissionsConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig, BaseFunction>? PermissionsConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TelemetryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-telemetryconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityProviderTelemetryConfig
        /// </summary>
        public Union<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig, BaseFunction>? TelemetryConfig { get; set; }
    }

    namespace CapacityProviderTypes
    {
        public class CapacityProviderLoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveSystemLogLevel
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderloggingconfig.html#cfn-lambda-capacityprovider-capacityproviderloggingconfig-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// SystemLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderloggingconfig.html#cfn-lambda-capacityprovider-capacityproviderloggingconfig-systemloglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SystemLogLevel { get; set; }
        }

        public class CapacityProviderPermissionsConfig : Humidifier.Base.BaseSubResource, IHaveCapacityProviderOperatorRoleArn
        {
            /// <summary>
            /// CapacityProviderOperatorRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderpermissionsconfig.html#cfn-lambda-capacityprovider-capacityproviderpermissionsconfig-capacityprovideroperatorrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProviderOperatorRoleArn { get; set; }
        }

        public class CapacityProviderScalingConfig : Humidifier.Base.BaseSubResource, IHaveListOfLambdaCapacityProviderTypesTargetTrackingScalingPolicyScalingPolicies, IHaveScalingMode, IHaveMaxVCpuCount_Integer
        {
            /// <summary>
            /// ScalingPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderscalingconfig.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig-scalingpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingScalingPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lambda.CapacityProviderTypes.TargetTrackingScalingPolicy>, IReadOnlyList<Union<Humidifier.Lambda.CapacityProviderTypes.TargetTrackingScalingPolicy, BaseFunction>>, BaseFunction>? ScalingPolicies { get; set; }
            /// <summary>
            /// ScalingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderscalingconfig.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig-scalingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingMode { get; set; }
            /// <summary>
            /// MaxVCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderscalingconfig.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig-maxvcpucount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxVCpuCount { get; set; }
        }

        public class CapacityProviderTelemetryConfig : Humidifier.Base.BaseSubResource, IHaveLambdaCapacityProviderTypesCapacityProviderLoggingConfigLoggingConfig
        {
            /// <summary>
            /// LoggingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityprovidertelemetryconfig.html#cfn-lambda-capacityprovider-capacityprovidertelemetryconfig-loggingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityProviderLoggingConfig
            /// </summary>
            public Union<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig, BaseFunction>? LoggingConfig { get; set; }
        }

        public class CapacityProviderVpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityprovidervpcconfig.html#cfn-lambda-capacityprovider-capacityprovidervpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityprovidervpcconfig.html#cfn-lambda-capacityprovider-capacityprovidervpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedInstanceTypes, IHaveStringListOfExcludedInstanceTypes, IHaveStringListOfArchitectures
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-instancerequirements.html#cfn-lambda-capacityprovider-instancerequirements-allowedinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-instancerequirements.html#cfn-lambda-capacityprovider-instancerequirements-excludedinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-instancerequirements.html#cfn-lambda-capacityprovider-instancerequirements-architectures
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Architectures { get; set; }
        }

        public class PropagateTagsConfig : Humidifier.Base.BaseSubResource, IHaveMode, IHaveTagListOfExplicitTags
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-propagatetagsconfig.html#cfn-lambda-capacityprovider-propagatetagsconfig-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// ExplicitTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-propagatetagsconfig.html#cfn-lambda-capacityprovider-propagatetagsconfig-explicittags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? ExplicitTags { get; set; }
        }

        public class TargetTrackingScalingPolicy : Humidifier.Base.BaseSubResource, IHavePredefinedMetricType, IHaveTargetValue_Double
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-targettrackingscalingpolicy.html#cfn-lambda-capacityprovider-targettrackingscalingpolicy-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedMetricType { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-targettrackingscalingpolicy.html#cfn-lambda-capacityprovider-targettrackingscalingpolicy-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
        }
    }
}