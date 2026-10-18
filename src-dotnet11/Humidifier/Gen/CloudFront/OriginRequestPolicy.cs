namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using OriginRequestPolicyTypes;

    public class OriginRequestPolicy : Humidifier.Base.BaseResource, IHaveCloudFrontOriginRequestPolicyTypesOriginRequestPolicyConfigOriginRequestPolicyConfig
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.OriginRequestPolicy; }

        /// <summary>
        /// OriginRequestPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-originrequestpolicy.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: OriginRequestPolicyConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig, BaseFunction>? OriginRequestPolicyConfig { get; set; }
    }

    namespace OriginRequestPolicyTypes
    {
        public class CookiesConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfCookies, IHaveCookieBehavior
        {
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-cookiesconfig.html#cfn-cloudfront-originrequestpolicy-cookiesconfig-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cookies { get; set; }
            /// <summary>
            /// CookieBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-cookiesconfig.html#cfn-cloudfront-originrequestpolicy-cookiesconfig-cookiebehavior
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html#cfn-cloudfront-originrequestpolicy-headersconfig-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// HeaderBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html#cfn-cloudfront-originrequestpolicy-headersconfig-headerbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderBehavior { get; set; }
        }

        public class OriginRequestPolicyConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveCloudFrontOriginRequestPolicyTypesHeadersConfigHeadersConfig, IHaveCloudFrontOriginRequestPolicyTypesCookiesConfigCookiesConfig, IHaveCloudFrontOriginRequestPolicyTypesQueryStringsConfigQueryStringsConfig, IHaveName
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// HeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-headersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeadersConfig
            /// </summary>
            public Union<Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig, BaseFunction>? HeadersConfig { get; set; }
            /// <summary>
            /// CookiesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-cookiesconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookiesConfig
            /// </summary>
            public Union<Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig, BaseFunction>? CookiesConfig { get; set; }
            /// <summary>
            /// QueryStringsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-querystringsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: QueryStringsConfig
            /// </summary>
            public Union<Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig, BaseFunction>? QueryStringsConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class QueryStringsConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfQueryStrings, IHaveQueryStringBehavior
        {
            /// <summary>
            /// QueryStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-querystringsconfig.html#cfn-cloudfront-originrequestpolicy-querystringsconfig-querystrings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? QueryStrings { get; set; }
            /// <summary>
            /// QueryStringBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-querystringsconfig.html#cfn-cloudfront-originrequestpolicy-querystringsconfig-querystringbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryStringBehavior { get; set; }
        }
    }
}