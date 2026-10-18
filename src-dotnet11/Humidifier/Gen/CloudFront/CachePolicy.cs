namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using CachePolicyTypes;

    public class CachePolicy : Humidifier.Base.BaseResource, IHaveCloudFrontCachePolicyTypesCachePolicyConfigCachePolicyConfig
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.CachePolicy; }

        /// <summary>
        /// CachePolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cachepolicy.html#cfn-cloudfront-cachepolicy-cachepolicyconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CachePolicyConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig, BaseFunction>? CachePolicyConfig { get; set; }
    }

    namespace CachePolicyTypes
    {
        public class CachePolicyConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveMinTTL_Double, IHaveMaxTTL_Double, IHaveCloudFrontCachePolicyTypesParametersInCacheKeyAndForwardedToOriginParametersInCacheKeyAndForwardedToOrigin, IHaveDefaultTTL_Double, IHaveName
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// MinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-minttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinTTL { get; set; }
            /// <summary>
            /// MaxTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-maxttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTTL { get; set; }
            /// <summary>
            /// ParametersInCacheKeyAndForwardedToOrigin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-parametersincachekeyandforwardedtoorigin
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ParametersInCacheKeyAndForwardedToOrigin
            /// </summary>
            public Union<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin, BaseFunction>? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-defaultttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DefaultTTL { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html#cfn-cloudfront-cachepolicy-cachepolicyconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CookiesConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfCookies, IHaveCookieBehavior
        {
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cookiesconfig.html#cfn-cloudfront-cachepolicy-cookiesconfig-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cookies { get; set; }
            /// <summary>
            /// CookieBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cookiesconfig.html#cfn-cloudfront-cachepolicy-cookiesconfig-cookiebehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CookieBehavior { get; set; }
        }

        public class HeadersConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfHeaders, IHaveHeaderBehavior
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-headersconfig.html#cfn-cloudfront-cachepolicy-headersconfig-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// HeaderBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-headersconfig.html#cfn-cloudfront-cachepolicy-headersconfig-headerbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderBehavior { get; set; }
        }

        public class ParametersInCacheKeyAndForwardedToOrigin : Humidifier.Base.BaseSubResource, IHaveEnableAcceptEncodingBrotli_Boolean, IHaveCloudFrontCachePolicyTypesHeadersConfigHeadersConfig, IHaveCloudFrontCachePolicyTypesCookiesConfigCookiesConfig, IHaveEnableAcceptEncodingGzip_Boolean, IHaveCloudFrontCachePolicyTypesQueryStringsConfigQueryStringsConfig
        {
            /// <summary>
            /// EnableAcceptEncodingBrotli
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin.html#cfn-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin-enableacceptencodingbrotli
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAcceptEncodingBrotli { get; set; }
            /// <summary>
            /// HeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin.html#cfn-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin-headersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeadersConfig
            /// </summary>
            public Union<Humidifier.CloudFront.CachePolicyTypes.HeadersConfig, BaseFunction>? HeadersConfig { get; set; }
            /// <summary>
            /// CookiesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin.html#cfn-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin-cookiesconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookiesConfig
            /// </summary>
            public Union<Humidifier.CloudFront.CachePolicyTypes.CookiesConfig, BaseFunction>? CookiesConfig { get; set; }
            /// <summary>
            /// EnableAcceptEncodingGzip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin.html#cfn-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin-enableacceptencodinggzip
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAcceptEncodingGzip { get; set; }
            /// <summary>
            /// QueryStringsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin.html#cfn-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin-querystringsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: QueryStringsConfig
            /// </summary>
            public Union<Humidifier.CloudFront.CachePolicyTypes.QueryStringsConfig, BaseFunction>? QueryStringsConfig { get; set; }
        }

        public class QueryStringsConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfQueryStrings, IHaveQueryStringBehavior
        {
            /// <summary>
            /// QueryStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-querystringsconfig.html#cfn-cloudfront-cachepolicy-querystringsconfig-querystrings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? QueryStrings { get; set; }
            /// <summary>
            /// QueryStringBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-querystringsconfig.html#cfn-cloudfront-cachepolicy-querystringsconfig-querystringbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryStringBehavior { get; set; }
        }
    }
}