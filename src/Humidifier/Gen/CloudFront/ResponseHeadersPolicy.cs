namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using ResponseHeadersPolicyTypes;

    public class ResponseHeadersPolicy : Humidifier.Base.BaseResource
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
        public Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig ResponseHeadersPolicyConfig { get; set; }
    }

    namespace ResponseHeadersPolicyTypes
    {
        public class AccessControlAllowHeaders : Humidifier.Base.BaseSubResource, IHaveItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolallowheaders.html#cfn-cloudfront-responseheaderspolicy-accesscontrolallowheaders-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Items { get; set; }
        }

        public class AccessControlAllowMethods : Humidifier.Base.BaseSubResource, IHaveItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolallowmethods.html#cfn-cloudfront-responseheaderspolicy-accesscontrolallowmethods-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Items { get; set; }
        }

        public class AccessControlAllowOrigins : Humidifier.Base.BaseSubResource, IHaveItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolalloworigins.html#cfn-cloudfront-responseheaderspolicy-accesscontrolalloworigins-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Items { get; set; }
        }

        public class AccessControlExposeHeaders : Humidifier.Base.BaseSubResource, IHaveItems
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-accesscontrolexposeheaders.html#cfn-cloudfront-responseheaderspolicy-accesscontrolexposeheaders-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Items { get; set; }
        }

        public class ContentSecurityPolicy : Humidifier.Base.BaseSubResource, IHaveOverride
        {
            /// <summary>
            /// ContentSecurityPolicy_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-contentsecuritypolicy.html#cfn-cloudfront-responseheaderspolicy-contentsecuritypolicy-contentsecuritypolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentSecurityPolicy_ { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-contentsecuritypolicy.html#cfn-cloudfront-responseheaderspolicy-contentsecuritypolicy-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
        }

        public class ContentTypeOptions : Humidifier.Base.BaseSubResource, IHaveOverride
        {
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-contenttypeoptions.html#cfn-cloudfront-responseheaderspolicy-contenttypeoptions-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
        }

        public class CorsConfig : Humidifier.Base.BaseSubResource, IHaveAccessControlMaxAgeSec
        {
            /// <summary>
            /// AccessControlAllowCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolallowcredentials
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AccessControlAllowCredentials { get; set; }
            /// <summary>
            /// AccessControlAllowHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolallowheaders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAllowHeaders
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowHeaders AccessControlAllowHeaders { get; set; }
            /// <summary>
            /// OriginOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-originoverride
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OriginOverride { get; set; }
            /// <summary>
            /// AccessControlAllowMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolallowmethods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAllowMethods
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowMethods AccessControlAllowMethods { get; set; }
            /// <summary>
            /// AccessControlExposeHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolexposeheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessControlExposeHeaders
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlExposeHeaders AccessControlExposeHeaders { get; set; }
            /// <summary>
            /// AccessControlAllowOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolalloworigins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAllowOrigins
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.AccessControlAllowOrigins AccessControlAllowOrigins { get; set; }
            /// <summary>
            /// AccessControlMaxAgeSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-corsconfig.html#cfn-cloudfront-responseheaderspolicy-corsconfig-accesscontrolmaxagesec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AccessControlMaxAgeSec { get; set; }
        }

        public class CustomHeader : Humidifier.Base.BaseSubResource, IHaveValue, IHaveHeader, IHaveOverride
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheader.html#cfn-cloudfront-responseheaderspolicy-customheader-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Header { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheader.html#cfn-cloudfront-responseheaderspolicy-customheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheader.html#cfn-cloudfront-responseheaderspolicy-customheader-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
        }

        public class CustomHeadersConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-customheadersconfig.html#cfn-cloudfront-responseheaderspolicy-customheadersconfig-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHeader
            /// </summary>
            public List<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeader> Items { get; set; }
        }

        public class FrameOptions : Humidifier.Base.BaseSubResource, IHaveOverride
        {
            /// <summary>
            /// FrameOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-frameoptions.html#cfn-cloudfront-responseheaderspolicy-frameoptions-frameoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FrameOption { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-frameoptions.html#cfn-cloudfront-responseheaderspolicy-frameoptions-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
        }

        public class ReferrerPolicy : Humidifier.Base.BaseSubResource, IHaveOverride
        {
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-referrerpolicy.html#cfn-cloudfront-responseheaderspolicy-referrerpolicy-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
            /// <summary>
            /// ReferrerPolicy_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-referrerpolicy.html#cfn-cloudfront-responseheaderspolicy-referrerpolicy-referrerpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReferrerPolicy_ { get; set; }
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
            public dynamic Header { get; set; }
        }

        public class RemoveHeadersConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-removeheadersconfig.html#cfn-cloudfront-responseheaderspolicy-removeheadersconfig-items
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RemoveHeader
            /// </summary>
            public List<Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeader> Items { get; set; }
        }

        public class ResponseHeadersPolicyConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveComment
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
            /// <summary>
            /// SecurityHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-securityheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityHeadersConfig
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.SecurityHeadersConfig SecurityHeadersConfig { get; set; }
            /// <summary>
            /// RemoveHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-removeheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RemoveHeadersConfig
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig RemoveHeadersConfig { get; set; }
            /// <summary>
            /// CorsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-corsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CorsConfig
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.CorsConfig CorsConfig { get; set; }
            /// <summary>
            /// ServerTimingHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-servertimingheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerTimingHeadersConfig
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig ServerTimingHeadersConfig { get; set; }
            /// <summary>
            /// CustomHeadersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-customheadersconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomHeadersConfig
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig CustomHeadersConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-responseheaderspolicyconfig.html#cfn-cloudfront-responseheaderspolicy-responseheaderspolicyconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SecurityHeadersConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentSecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-contentsecuritypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContentSecurityPolicy
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentSecurityPolicy ContentSecurityPolicy { get; set; }
            /// <summary>
            /// FrameOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-frameoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameOptions
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions FrameOptions { get; set; }
            /// <summary>
            /// ContentTypeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-contenttypeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContentTypeOptions
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.ContentTypeOptions ContentTypeOptions { get; set; }
            /// <summary>
            /// StrictTransportSecurity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-stricttransportsecurity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StrictTransportSecurity
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.StrictTransportSecurity StrictTransportSecurity { get; set; }
            /// <summary>
            /// XSSProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-xssprotection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: XSSProtection
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection XSSProtection { get; set; }
            /// <summary>
            /// ReferrerPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-securityheadersconfig.html#cfn-cloudfront-responseheaderspolicy-securityheadersconfig-referrerpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferrerPolicy
            /// </summary>
            public Humidifier.CloudFront.ResponseHeadersPolicyTypes.ReferrerPolicy ReferrerPolicy { get; set; }
        }

        public class ServerTimingHeadersConfig : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveSamplingRate
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-servertimingheadersconfig.html#cfn-cloudfront-responseheaderspolicy-servertimingheadersconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// SamplingRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-servertimingheadersconfig.html#cfn-cloudfront-responseheaderspolicy-servertimingheadersconfig-samplingrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SamplingRate { get; set; }
        }

        public class StrictTransportSecurity : Humidifier.Base.BaseSubResource, IHaveOverride, IHaveAccessControlMaxAgeSec
        {
            /// <summary>
            /// Preload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-preload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Preload { get; set; }
            /// <summary>
            /// AccessControlMaxAgeSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-accesscontrolmaxagesec
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AccessControlMaxAgeSec { get; set; }
            /// <summary>
            /// IncludeSubdomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-includesubdomains
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSubdomains { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-stricttransportsecurity.html#cfn-cloudfront-responseheaderspolicy-stricttransportsecurity-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
        }

        public class XSSProtection : Humidifier.Base.BaseSubResource, IHaveOverride
        {
            /// <summary>
            /// ReportUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-reporturi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportUri { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-override
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Override { get; set; }
            /// <summary>
            /// Protection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-protection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Protection { get; set; }
            /// <summary>
            /// ModeBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-responseheaderspolicy-xssprotection.html#cfn-cloudfront-responseheaderspolicy-xssprotection-modeblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ModeBlock { get; set; }
        }
    }
}