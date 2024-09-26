namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using ContinuousDeploymentPolicyTypes;

    public class ContinuousDeploymentPolicy : Humidifier.Base.BaseResource
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
        public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig ContinuousDeploymentPolicyConfig { get; set; }
    }

    namespace ContinuousDeploymentPolicyTypes
    {
        public class ContinuousDeploymentPolicyConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveEnabled
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SingleHeaderPolicyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-singleheaderpolicyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeaderPolicyConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderPolicyConfig SingleHeaderPolicyConfig { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// StagingDistributionDnsNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-stagingdistributiondnsnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StagingDistributionDnsNames { get; set; }
            /// <summary>
            /// TrafficConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-trafficconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrafficConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.TrafficConfig TrafficConfig { get; set; }
            /// <summary>
            /// SingleWeightPolicyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-continuousdeploymentpolicyconfig-singleweightpolicyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleWeightPolicyConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig SingleWeightPolicyConfig { get; set; }
        }

        public class SessionStickinessConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdleTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig.html#cfn-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig-idlettl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleTTL { get; set; }
            /// <summary>
            /// MaximumTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig.html#cfn-cloudfront-continuousdeploymentpolicy-sessionstickinessconfig-maximumttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumTTL { get; set; }
        }

        public class SingleHeaderConfig : Humidifier.Base.BaseSubResource, IHaveValue, IHaveHeader
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderconfig-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Header { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderconfig-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class SingleHeaderPolicyConfig : Humidifier.Base.BaseSubResource, IHaveValue, IHaveHeader
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Header { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleheaderpolicyconfig-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class SingleWeightConfig : Humidifier.Base.BaseSubResource, IHaveWeight
        {
            /// <summary>
            /// SessionStickinessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightconfig-sessionstickinessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStickinessConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig SessionStickinessConfig { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightconfig-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class SingleWeightPolicyConfig : Humidifier.Base.BaseSubResource, IHaveWeight
        {
            /// <summary>
            /// SessionStickinessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig-sessionstickinessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionStickinessConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig SessionStickinessConfig { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig.html#cfn-cloudfront-continuousdeploymentpolicy-singleweightpolicyconfig-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class TrafficConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// SingleWeightConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-trafficconfig.html#cfn-cloudfront-continuousdeploymentpolicy-trafficconfig-singleweightconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleWeightConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig SingleWeightConfig { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-trafficconfig.html#cfn-cloudfront-continuousdeploymentpolicy-trafficconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SingleHeaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-continuousdeploymentpolicy-trafficconfig.html#cfn-cloudfront-continuousdeploymentpolicy-trafficconfig-singleheaderconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeaderConfig
            /// </summary>
            public Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleHeaderConfig SingleHeaderConfig { get; set; }
        }
    }
}