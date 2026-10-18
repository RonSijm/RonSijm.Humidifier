namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using UsagePlanTypes;

    public class UsagePlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveApiGatewayUsagePlanTypesQuotaSettingsQuota, IHaveListOfApiGatewayUsagePlanTypesApiStageApiStages, IHaveApiGatewayUsagePlanTypesThrottleSettingsThrottle, IHaveUsagePlanName
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Quota
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-quota
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QuotaSettings
        /// </summary>
        public Union<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings, BaseFunction>? Quota { get; set; }
        /// <summary>
        /// ApiStages
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-apistages
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ApiStage
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApiGateway.UsagePlanTypes.ApiStage>, IReadOnlyList<Union<Humidifier.ApiGateway.UsagePlanTypes.ApiStage, BaseFunction>>, BaseFunction>? ApiStages { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Throttle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-throttle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThrottleSettings
        /// </summary>
        public Union<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings, BaseFunction>? Throttle { get; set; }
        public Union<string, BaseFunction>? UsagePlanName { get => GivenName; set => GivenName = value; }
    }

    namespace UsagePlanTypes
    {
        public class ApiStage : Humidifier.Base.BaseSubResource, IHaveStage, IHaveApiId, IHaveMapOfApiGatewayUsagePlanTypesThrottleSettingsThrottle
        {
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-stage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stage { get; set; }
            /// <summary>
            /// ApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-apiid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiId { get; set; }
            /// <summary>
            /// Throttle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-throttle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ThrottleSettings
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings>, IReadOnlyDictionary<string, Union<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings, BaseFunction>>, BaseFunction>? Throttle { get; set; }
        }

        public class QuotaSettings : Humidifier.Base.BaseSubResource, IHavePeriod, IHaveLimit_Integer, IHaveOffset_Integer
        {
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Limit { get; set; }
            /// <summary>
            /// Offset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-offset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Offset { get; set; }
        }

        public class ThrottleSettings : Humidifier.Base.BaseSubResource, IHaveBurstLimit_Integer, IHaveRateLimit_Double
        {
            /// <summary>
            /// BurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html#cfn-apigateway-usageplan-throttlesettings-burstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BurstLimit { get; set; }
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html#cfn-apigateway-usageplan-throttlesettings-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RateLimit { get; set; }
        }
    }
}