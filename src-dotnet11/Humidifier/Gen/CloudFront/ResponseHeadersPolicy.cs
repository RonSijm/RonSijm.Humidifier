namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using ResponseHeadersPolicyTypes;

    public class ResponseHeadersPolicy : Humidifier.Base.BaseResource, IHaveCloudFrontResponseHeadersPolicyTypesResponseHeadersPolicyConfigResponseHeadersPolicyConfig
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.ResponseHeadersPolicy; }

        /// <summary>
        /// ResponseHeadersPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-responseheaderspolicy.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ResponseHeadersPolicyConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig, BaseFunction>? ResponseHeadersPolicyConfig { get; set; }
    }

    namespace ResponseHeadersPolicyTypes
    {
        public class AccessControlAllowHeaders : Humidifier.Base.BaseSubResource, IHaveStringListOfItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolallowheaders.html#cfn-cloudfront-responseheaderspolicy-accesscontrolallowheaders-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class AccessControlAllowMethods : Humidifier.Base.BaseSubResource, IHaveStringListOfItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolallowmethods.html#cfn-cloudfront-responseheaderspolicy-accesscontrolallowmethods-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class AccessControlAllowOrigins : Humidifier.Base.BaseSubResource, IHaveStringListOfItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolalloworigins.html#cfn-cloudfront-responseheaderspolicy-accesscontrolalloworigins-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class AccessControlExposeHeaders : Humidifier.Base.BaseSubResource, IHaveStringListOfItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolexposeheaders.html#cfn-cloudfront-responseheaderspolicy-accesscontrolexposeheaders-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class ContentSecurityPolicy : Humidifier.Base.BaseSubResource, IHaveContentSecurityPolicy_, IHaveOverride_Boolean
        {
            /// <summary>
            /// ContentSecurityPolicy_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-contentsecuritypolicy.html#cfn-cloudfront-responseheaderspolicy-contentsecuritypolicy-contentsecuritypolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentSecurityPolicy_ { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-contentsecuritypolicy.html#cfn-cloudfront-responseheaderspolicy-contentsecuritypolicy-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
        }

        public class ContentTypeOptions : Humidifier.Base.BaseSubResource, IHaveOverride_Boolean
        {
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-contenttypeoptions.html#cfn-cloudfront-responseheaderspolicy-contenttypeoptions-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
        }

        public class CorsConfig : Humidifier.Base.BaseSubResource, IHaveAccessControlAllowCredentials_Boolean, IHaveCloudFrontResponseHeadersPolicyTypesAccessControlAllowHeadersAccessControlAllowHeaders, IHaveOriginOverride_Boolean, IHaveCloudFrontResponseHeadersPolicyTypesAccessControlAllowMethodsAccessControlAllowMethods, IHaveCloudFrontResponseHeadersPolicyTypesAccessControlExposeHeadersAccessControlExposeHeaders, IHaveCloudFrontResponseHeadersPolicyTypesAccessControlAllowOriginsAccessControlAllowOrigins, IHaveAccessControlMaxAgeSec_Integer
        {
            /// <summary>
            /// AccessControlAllowCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolallowcredentials
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AccessControlAllowCredentials { get; set; }
            /// <summary>
            /// AccessControlAllowHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolallowheaders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAllowHeaders
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders, BaseFunction>? AccessControlAllowHeaders { get; set; }
            /// <summary>
            /// OriginOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-originoverride
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OriginOverride { get; set; }
            /// <summary>
            /// AccessControlAllowMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolallowmethods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAllowMethods
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods, BaseFunction>? AccessControlAllowMethods { get; set; }
            /// <summary>
            /// AccessControlExposeHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolexposeheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessControlExposeHeaders
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders, BaseFunction>? AccessControlExposeHeaders { get; set; }
            /// <summary>
            /// AccessControlAllowOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolalloworigins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAllowOrigins
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins, BaseFunction>? AccessControlAllowOrigins { get; set; }
            /// <summary>
            /// AccessControlMaxAgeSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolmaxagesec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AccessControlMaxAgeSec { get; set; }
        }

        public class CustomHeader : Humidifier.Base.BaseSubResource, IHaveHeader, IHaveValue, IHaveOverride_Boolean
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheader.html#cfn-cloudfront-responseheaderspolicy-customheader-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheader.html#cfn-cloudfront-responseheaderspolicy-customheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheader.html#cfn-cloudfront-responseheaderspolicy-customheader-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
        }

        public class CustomHeadersConfig : Humidifier.Base.BaseSubResource, IHaveListOfCloudFrontResponseHeadersPolicyTypesCustomHeaderItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheadersconfig.html#cfn-cloudfront-responseheaderspolicy-customheadersconfig-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeader>, IReadOnlyList<Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeader, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class FrameOptions : Humidifier.Base.BaseSubResource, IHaveFrameOption, IHaveOverride_Boolean
        {
            /// <summary>
            /// FrameOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-frameoptions.html#cfn-cloudfront-responseheaderspolicy-frameoptions-frameoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FrameOption { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-frameoptions.html#cfn-cloudfront-responseheaderspolicy-frameoptions-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
        }

        public class ReferrerPolicy : Humidifier.Base.BaseSubResource, IHaveOverride_Boolean, IHaveReferrerPolicy_
        {
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-referrerpolicy.html#cfn-cloudfront-responseheaderspolicy-referrerpolicy-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
            /// <summary>
            /// ReferrerPolicy_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-referrerpolicy.html#cfn-cloudfront-responseheaderspolicy-referrerpolicy-referrerpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferrerPolicy_ { get; set; }
        }

        public class RemoveHeader : Humidifier.Base.BaseSubResource, IHaveHeader
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-removeheader.html#cfn-cloudfront-responseheaderspolicy-removeheader-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
        }

        public class RemoveHeadersConfig : Humidifier.Base.BaseSubResource, IHaveListOfCloudFrontResponseHeadersPolicyTypesRemoveHeaderItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-removeheadersconfig.html#cfn-cloudfront-responseheaderspolicy-removeheadersconfig-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RemoveHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeader>, IReadOnlyList<Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeader, BaseFunction>>, BaseFunction>? Items { get; set; }
        }

        public class ResponseHeadersPolicyConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveCloudFrontResponseHeadersPolicyTypesSecurityHeadersConfigSecurityHeadersConfig, IHaveCloudFrontResponseHeadersPolicyTypesRemoveHeadersConfigRemoveHeadersConfig, IHaveCloudFrontResponseHeadersPolicyTypesCorsConfigCorsConfig, IHaveCloudFrontResponseHeadersPolicyTypesServerTimingHeadersConfigServerTimingHeadersConfig, IHaveCloudFrontResponseHeadersPolicyTypesCustomHeadersConfigCustomHeadersConfig, IHaveName
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// SecurityHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-securityheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityHeadersConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.SecurityHeadersConfig, BaseFunction>? SecurityHeadersConfig { get; set; }
            /// <summary>
            /// RemoveHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-removeheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RemoveHeadersConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig, BaseFunction>? RemoveHeadersConfig { get; set; }
            /// <summary>
            /// CorsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-corsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CorsConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CorsConfig, BaseFunction>? CorsConfig { get; set; }
            /// <summary>
            /// ServerTimingHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-servertimingheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerTimingHeadersConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig, BaseFunction>? ServerTimingHeadersConfig { get; set; }
            /// <summary>
            /// CustomHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-customheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomHeadersConfig
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig, BaseFunction>? CustomHeadersConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SecurityHeadersConfig : Humidifier.Base.BaseSubResource, IHaveCloudFrontResponseHeadersPolicyTypesContentSecurityPolicyContentSecurityPolicy, IHaveCloudFrontResponseHeadersPolicyTypesFrameOptionsFrameOptions, IHaveCloudFrontResponseHeadersPolicyTypesContentTypeOptionsContentTypeOptions, IHaveCloudFrontResponseHeadersPolicyTypesStrictTransportSecurityStrictTransportSecurity, IHaveCloudFrontResponseHeadersPolicyTypesXSSProtectionXSSProtection, IHaveCloudFrontResponseHeadersPolicyTypesReferrerPolicyReferrerPolicy
        {
            /// <summary>
            /// ContentSecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-contentsecuritypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContentSecurityPolicy
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy, BaseFunction>? ContentSecurityPolicy { get; set; }
            /// <summary>
            /// FrameOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-frameoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameOptions
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions, BaseFunction>? FrameOptions { get; set; }
            /// <summary>
            /// ContentTypeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-contenttypeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContentTypeOptions
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions, BaseFunction>? ContentTypeOptions { get; set; }
            /// <summary>
            /// StrictTransportSecurity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-stricttransportsecurity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StrictTransportSecurity
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity, BaseFunction>? StrictTransportSecurity { get; set; }
            /// <summary>
            /// XSSProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-xssprotection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: XSSProtection
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection, BaseFunction>? XSSProtection { get; set; }
            /// <summary>
            /// ReferrerPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-referrerpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferrerPolicy
            /// </summary>
            public Union<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy, BaseFunction>? ReferrerPolicy { get; set; }
        }

        public class ServerTimingHeadersConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveSamplingRate_Double
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-servertimingheadersconfig.html#cfn-cloudfront-responseheaderspolicy-servertimingheadersconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// SamplingRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-servertimingheadersconfig.html#cfn-cloudfront-responseheaderspolicy-servertimingheadersconfig-samplingrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SamplingRate { get; set; }
        }

        public class StrictTransportSecurity : Humidifier.Base.BaseSubResource, IHavePreload_Boolean, IHaveAccessControlMaxAgeSec_Integer, IHaveIncludeSubdomains_Boolean, IHaveOverride_Boolean
        {
            /// <summary>
            /// Preload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-preload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Preload { get; set; }
            /// <summary>
            /// AccessControlMaxAgeSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-accesscontrolmaxagesec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AccessControlMaxAgeSec { get; set; }
            /// <summary>
            /// IncludeSubdomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-includesubdomains
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSubdomains { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
        }

        public class XSSProtection : Humidifier.Base.BaseSubResource, IHaveReportUri, IHaveOverride_Boolean, IHaveProtection_Boolean, IHaveModeBlock_Boolean
        {
            /// <summary>
            /// ReportUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-reporturi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReportUri { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Override { get; set; }
            /// <summary>
            /// Protection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-protection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Protection { get; set; }
            /// <summary>
            /// ModeBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-modeblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ModeBlock { get; set; }
        }
    }
}