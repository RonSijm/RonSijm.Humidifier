namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using ContinuousDeploymentPolicyTypes;

    public class ContinuousDeploymentPolicy : Humidifier.Base.BaseResource, IHaveCloudFrontContinuousDeploymentPolicyTypesContinuousDeploymentPolicyConfigContinuousDeploymentPolicyConfig
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.ContinuousDeploymentPolicy; }

        /// <summary>
        /// ContinuousDeploymentPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-continuousdeploymentpolicy.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ContinuousDeploymentPolicyConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig, BaseFunction>? ContinuousDeploymentPolicyConfig { get; set; }
    }

    namespace ContinuousDeploymentPolicyTypes
    {
        public class ContinuousDeploymentPolicyConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveCloudFrontContinuousDeploymentPolicyTypesSingleHeaderPolicyConfigSingleHeaderPolicyConfig, IHaveEnabled_Boolean, IHaveStringListOfStagingDistributionDnsNames, IHaveCloudFrontContinuousDeploymentPolicyTypesTrafficConfigTrafficConfig, IHaveCloudFrontContinuousDeploymentPolicyTypesSingleWeightPolicyConfigSingleWeightPolicyConfig
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SingleHeaderPolicyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-singleheaderpolicyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeaderPolicyConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig, BaseFunction>? SingleHeaderPolicyConfig { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// StagingDistributionDnsNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-stagingdistributiondnsnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StagingDistributionDnsNames { get; set; }
            /// <summary>
            /// TrafficConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-trafficconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrafficConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.TrafficConfig, BaseFunction>? TrafficConfig { get; set; }
            /// <summary>
            /// SingleWeightPolicyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-singleweightpolicyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleWeightPolicyConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig, BaseFunction>? SingleWeightPolicyConfig { get; set; }
        }

        public class SessionStickinessConfig : Humidifier.Base.BaseSubResource, IHaveIdleTTL_Integer, IHaveMaximumTTL_Integer
        {
            /// <summary>
            /// IdleTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig.html#cfn-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig-idlettl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTTL { get; set; }
            /// <summary>
            /// MaximumTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig.html#cfn-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig-maximumttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumTTL { get; set; }
        }

        public class SingleHeaderConfig : Humidifier.Base.BaseSubResource, IHaveHeader, IHaveValue
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderconfig-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderconfig-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class SingleHeaderPolicyConfig : Humidifier.Base.BaseSubResource, IHaveHeader, IHaveValue
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class SingleWeightConfig : Humidifier.Base.BaseSubResource, IHaveCloudFrontContinuousDeploymentPolicyTypesSessionStickinessConfigSessionStickinessConfig, IHaveWeight_Double
        {
            /// <summary>
            /// SessionStickinessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightconfig-sessionstickinessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStickinessConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig, BaseFunction>? SessionStickinessConfig { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightconfig-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
        }

        public class SingleWeightPolicyConfig : Humidifier.Base.BaseSubResource, IHaveCloudFrontContinuousDeploymentPolicyTypesSessionStickinessConfigSessionStickinessConfig, IHaveWeight_Double
        {
            /// <summary>
            /// SessionStickinessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig-sessionstickinessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStickinessConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig, BaseFunction>? SessionStickinessConfig { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
        }

        public class TrafficConfig : Humidifier.Base.BaseSubResource, IHaveCloudFrontContinuousDeploymentPolicyTypesSingleWeightConfigSingleWeightConfig, IHaveType, IHaveCloudFrontContinuousDeploymentPolicyTypesSingleHeaderConfigSingleHeaderConfig
        {
            /// <summary>
            /// SingleWeightConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-trafficconfig.html#cfn-cloudfront-continuousdeploymentpolicy-trafficconfig-singleweightconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleWeightConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig, BaseFunction>? SingleWeightConfig { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-trafficconfig.html#cfn-cloudfront-continuousdeploymentpolicy-trafficconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SingleHeaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-trafficconfig.html#cfn-cloudfront-continuousdeploymentpolicy-trafficconfig-singleheaderconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeaderConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig, BaseFunction>? SingleHeaderConfig { get; set; }
        }
    }
}