namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using UsagePlanTypes;

    public class UsagePlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.UsagePlan; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Quota
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-quota
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QuotaSettings
        /// </summary>
        public Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings Quota { get; set; }
        /// <summary>
        /// ApiStages
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-apistages
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ApiStage
        /// </summary>
        public List<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> ApiStages { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Throttle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-throttle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThrottleSettings
        /// </summary>
        public Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings Throttle { get; set; }
        public dynamic UsagePlanName { get => GivenName; set => GivenName = value; }
    }

    namespace UsagePlanTypes
    {
        public class ApiStage : Humidifier.Base.BaseSubResource, IHaveApiId, IHaveStage
        {
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-stage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stage { get; set; }
            /// <summary>
            /// ApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-apiid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiId { get; set; }
            /// <summary>
            /// Throttle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-throttle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ThrottleSettings
            /// </summary>
            public Dictionary<string, Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> Throttle { get; set; }
        }

        public class QuotaSettings : Humidifier.Base.BaseSubResource, IHavePeriod, IHaveLimit, IHaveOffset
        {
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Period { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Limit { get; set; }
            /// <summary>
            /// Offset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-offset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Offset { get; set; }
        }

        public class ThrottleSettings : Humidifier.Base.BaseSubResource, IHaveRateLimit
        {
            /// <summary>
            /// BurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html#cfn-apigateway-usageplan-throttlesettings-burstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BurstLimit { get; set; }
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html#cfn-apigateway-usageplan-throttlesettings-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RateLimit { get; set; }
        }
    }
}