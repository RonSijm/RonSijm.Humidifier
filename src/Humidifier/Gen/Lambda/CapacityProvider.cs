namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using CapacityProviderTypes;

    public class CapacityProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyArn
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
        public Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig CapacityProviderScalingConfig { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-vpcconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CapacityProviderVpcConfig
        /// </summary>
        [Required]
        public Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig VpcConfig { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PropagateTagsConfig
        /// </summary>
        public Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig PropagateTags { get; set; }
        public dynamic CapacityProviderName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InstanceRequirements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-instancerequirements
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceRequirements
        /// </summary>
        public Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements InstanceRequirements { get; set; }

        /// <summary>
        /// PermissionsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-permissionsconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CapacityProviderPermissionsConfig
        /// </summary>
        [Required]
        public Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig PermissionsConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// TelemetryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-capacityprovider.html#cfn-lambda-capacityprovider-telemetryconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityProviderTelemetryConfig
        /// </summary>
        public Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig TelemetryConfig { get; set; }
    }

    namespace CapacityProviderTypes
    {
        public class CapacityProviderLoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderloggingconfig.html#cfn-lambda-capacityprovider-capacityproviderloggingconfig-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// SystemLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderloggingconfig.html#cfn-lambda-capacityprovider-capacityproviderloggingconfig-systemloglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SystemLogLevel { get; set; }
        }

        public class CapacityProviderPermissionsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CapacityProviderOperatorRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderpermissionsconfig.html#cfn-lambda-capacityprovider-capacityproviderpermissionsconfig-capacityprovideroperatorrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityProviderOperatorRoleArn { get; set; }
        }

        public class CapacityProviderScalingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScalingPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderscalingconfig.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig-scalingpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingScalingPolicy
            /// </summary>
            public List<Humidifier.Lambda.CapacityProviderTypes.TargetTrackingScalingPolicy> ScalingPolicies { get; set; }
            /// <summary>
            /// ScalingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderscalingconfig.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig-scalingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScalingMode { get; set; }
            /// <summary>
            /// MaxVCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityproviderscalingconfig.html#cfn-lambda-capacityprovider-capacityproviderscalingconfig-maxvcpucount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxVCpuCount { get; set; }
        }

        public class CapacityProviderTelemetryConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoggingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityprovidertelemetryconfig.html#cfn-lambda-capacityprovider-capacityprovidertelemetryconfig-loggingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityProviderLoggingConfig
            /// </summary>
            public Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig LoggingConfig { get; set; }
        }

        public class CapacityProviderVpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityprovidervpcconfig.html#cfn-lambda-capacityprovider-capacityprovidervpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-capacityprovidervpcconfig.html#cfn-lambda-capacityprovider-capacityprovidervpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveExcludedInstanceTypes, IHaveAllowedInstanceTypes, IHaveArchitectures
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-instancerequirements.html#cfn-lambda-capacityprovider-instancerequirements-allowedinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedInstanceTypes { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-instancerequirements.html#cfn-lambda-capacityprovider-instancerequirements-excludedinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-instancerequirements.html#cfn-lambda-capacityprovider-instancerequirements-architectures
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Architectures { get; set; }
        }

        public class PropagateTagsConfig : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-propagatetagsconfig.html#cfn-lambda-capacityprovider-propagatetagsconfig-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// ExplicitTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-propagatetagsconfig.html#cfn-lambda-capacityprovider-propagatetagsconfig-explicittags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> ExplicitTags { get; set; }
        }

        public class TargetTrackingScalingPolicy : Humidifier.Base.BaseSubResource, IHaveTargetValue, IHavePredefinedMetricType
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-targettrackingscalingpolicy.html#cfn-lambda-capacityprovider-targettrackingscalingpolicy-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PredefinedMetricType { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-capacityprovider-targettrackingscalingpolicy.html#cfn-lambda-capacityprovider-targettrackingscalingpolicy-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
        }
    }
}