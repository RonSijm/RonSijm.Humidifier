namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using GatewayRateLimitTypes;

    public class GatewayRateLimit : Humidifier.Base.BaseResource, IHaveRateLimitId, IHaveDescription, IHaveGatewayIdentifier, IHaveStringListOfDimensionKeys, IHaveListOfBedrockAgentCoreGatewayRateLimitTypesLimitEntryEntries
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.GatewayRateLimit; }
        /// <summary>
        /// RateLimitId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayratelimit.html#cfn-bedrockagentcore-gatewayratelimit-ratelimitid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RateLimitId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayratelimit.html#cfn-bedrockagentcore-gatewayratelimit-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// GatewayIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayratelimit.html#cfn-bedrockagentcore-gatewayratelimit-gatewayidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GatewayIdentifier { get; set; }

        /// <summary>
        /// DimensionKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayratelimit.html#cfn-bedrockagentcore-gatewayratelimit-dimensionkeys
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DimensionKeys { get; set; }

        /// <summary>
        /// Entries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayratelimit.html#cfn-bedrockagentcore-gatewayratelimit-entries
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LimitEntry
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry, BaseFunction>>, BaseFunction>? Entries { get; set; }
    }

    namespace GatewayRateLimitTypes
    {
        public class LimitEntry : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayRateLimitTypesRateConfigConnections, IHaveStringDictionaryOfDimensions, IHaveListOfBedrockAgentCoreGatewayRateLimitTypesRateConfigRequests, IHaveListOfBedrockAgentCoreGatewayRateLimitTypesRateConfigTokens
        {
            /// <summary>
            /// Connections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayratelimit-limitentry.html#cfn-bedrockagentcore-gatewayratelimit-limitentry-connections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.RateConfig>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.RateConfig, BaseFunction>>, BaseFunction>? Connections { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayratelimit-limitentry.html#cfn-bedrockagentcore-gatewayratelimit-limitentry-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Requests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayratelimit-limitentry.html#cfn-bedrockagentcore-gatewayratelimit-limitentry-requests
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.RateConfig>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.RateConfig, BaseFunction>>, BaseFunction>? Requests { get; set; }
            /// <summary>
            /// Tokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayratelimit-limitentry.html#cfn-bedrockagentcore-gatewayratelimit-limitentry-tokens
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.RateConfig>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.RateConfig, BaseFunction>>, BaseFunction>? Tokens { get; set; }
        }

        public class RateConfig : Humidifier.Base.BaseSubResource, IHavePeriod, IHaveRate_Double
        {
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayratelimit-rateconfig.html#cfn-bedrockagentcore-gatewayratelimit-rateconfig-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Rate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayratelimit-rateconfig.html#cfn-bedrockagentcore-gatewayratelimit-rateconfig-rate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Rate { get; set; }
        }
    }
}