namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using OriginRequestPolicyTypes;

    public class OriginRequestPolicy : Humidifier.Base.BaseResource
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
        public Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig OriginRequestPolicyConfig { get; set; }
    }

    namespace OriginRequestPolicyTypes
    {
        public class CookiesConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-cookiesconfig.html#cfn-cloudfront-originrequestpolicy-cookiesconfig-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Cookies { get; set; }
            /// <summary>
            /// CookieBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-cookiesconfig.html#cfn-cloudfront-originrequestpolicy-cookiesconfig-cookiebehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CookieBehavior { get; set; }
        }

        public class HeadersConfig : Humidifier.Base.BaseSubResource, IHaveHeaders
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html#cfn-cloudfront-originrequestpolicy-headersconfig-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Headers { get; set; }
            /// <summary>
            /// HeaderBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html#cfn-cloudfront-originrequestpolicy-headersconfig-headerbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderBehavior { get; set; }
        }

        public class OriginRequestPolicyConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveComment
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
            /// <summary>
            /// HeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-headersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeadersConfig
            /// </summary>
            public Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig HeadersConfig { get; set; }
            /// <summary>
            /// CookiesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-cookiesconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookiesConfig
            /// </summary>
            public Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig CookiesConfig { get; set; }
            /// <summary>
            /// QueryStringsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-querystringsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: QueryStringsConfig
            /// </summary>
            public Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig QueryStringsConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html#cfn-cloudfront-originrequestpolicy-originrequestpolicyconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class QueryStringsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-querystringsconfig.html#cfn-cloudfront-originrequestpolicy-querystringsconfig-querystrings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic QueryStrings { get; set; }
            /// <summary>
            /// QueryStringBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-querystringsconfig.html#cfn-cloudfront-originrequestpolicy-querystringsconfig-querystringbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryStringBehavior { get; set; }
        }
    }
}