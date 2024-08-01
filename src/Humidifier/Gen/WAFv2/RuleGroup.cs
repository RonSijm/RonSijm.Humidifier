namespace Humidifier.WAFv2
{
    using System.Collections.Generic;
    using RuleGroupTypes;

    public class RuleGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string LabelNamespace =  "LabelNamespace" ;
        }

        public override string AWSTypeName { get => AWS.WAFv2.RuleGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Scope { get; set; }

        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-capacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Capacity { get; set; }
        /// <summary>
        /// AvailableLabels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-availablelabels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LabelSummary
        /// </summary>
        public List<RuleGroupTypes.LabelSummary> AvailableLabels { get; set; }
        /// <summary>
        /// CustomResponseBodies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-customresponsebodies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: CustomResponseBody
        /// </summary>
        public Dictionary<string, RuleGroupTypes.CustomResponseBody> CustomResponseBodies { get; set; }
        /// <summary>
        /// ConsumedLabels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-consumedlabels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LabelSummary
        /// </summary>
        public List<RuleGroupTypes.LabelSummary> ConsumedLabels { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        public List<RuleGroupTypes.Rule> Rules { get; set; }

        /// <summary>
        /// VisibilityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-visibilityconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VisibilityConfig
        /// </summary>
        [Required]
        public RuleGroupTypes.VisibilityConfig VisibilityConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuleGroupTypes
    {
        public class AllowAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-allowaction.html#cfn-wafv2-rulegroup-allowaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public RuleGroupTypes.CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class AndStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-andstatement.html#cfn-wafv2-rulegroup-andstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public List<RuleGroupTypes.Statement> Statements { get; set; }
        }

        public class BlockAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-blockaction.html#cfn-wafv2-rulegroup-blockaction-customresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomResponse
            /// </summary>
            public RuleGroupTypes.CustomResponse CustomResponse { get; set; }
        }

        public class Body : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-body.html#cfn-wafv2-rulegroup-body-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class ByteMatchStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SearchStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-searchstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SearchStringBase64 { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositionalConstraint { get; set; }
            /// <summary>
            /// SearchString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-searchstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SearchString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
        }

        public class CaptchaAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-captchaaction.html#cfn-wafv2-rulegroup-captchaaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public RuleGroupTypes.CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class CaptchaConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-captchaconfig.html#cfn-wafv2-rulegroup-captchaconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public RuleGroupTypes.ImmunityTimeProperty ImmunityTimeProperty { get; set; }
        }

        public class ChallengeAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-challengeaction.html#cfn-wafv2-rulegroup-challengeaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public RuleGroupTypes.CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class ChallengeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-challengeconfig.html#cfn-wafv2-rulegroup-challengeconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public RuleGroupTypes.ImmunityTimeProperty ImmunityTimeProperty { get; set; }
        }

        public class CookieMatchPattern : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookiematchpattern.html#cfn-wafv2-rulegroup-cookiematchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic All { get; set; }
            /// <summary>
            /// IncludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookiematchpattern.html#cfn-wafv2-rulegroup-cookiematchpattern-includedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedCookies { get; set; }
            /// <summary>
            /// ExcludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookiematchpattern.html#cfn-wafv2-rulegroup-cookiematchpattern-excludedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedCookies { get; set; }
        }

        public class Cookies : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookies.html#cfn-wafv2-rulegroup-cookies-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookies.html#cfn-wafv2-rulegroup-cookies-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookieMatchPattern
            /// </summary>
            public RuleGroupTypes.CookieMatchPattern MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookies.html#cfn-wafv2-rulegroup-cookies-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class CountAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-countaction.html#cfn-wafv2-rulegroup-countaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public RuleGroupTypes.CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class CustomHTTPHeader : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customhttpheader.html#cfn-wafv2-rulegroup-customhttpheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customhttpheader.html#cfn-wafv2-rulegroup-customhttpheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CustomRequestHandling : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InsertHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customrequesthandling.html#cfn-wafv2-rulegroup-customrequesthandling-insertheaders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public List<RuleGroupTypes.CustomHTTPHeader> InsertHeaders { get; set; }
        }

        public class CustomResponse : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResponseCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponse.html#cfn-wafv2-rulegroup-customresponse-responsecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResponseCode { get; set; }
            /// <summary>
            /// CustomResponseBodyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponse.html#cfn-wafv2-rulegroup-customresponse-customresponsebodykey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomResponseBodyKey { get; set; }
            /// <summary>
            /// ResponseHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponse.html#cfn-wafv2-rulegroup-customresponse-responseheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public List<RuleGroupTypes.CustomHTTPHeader> ResponseHeaders { get; set; }
        }

        public class CustomResponseBody : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponsebody.html#cfn-wafv2-rulegroup-customresponsebody-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponsebody.html#cfn-wafv2-rulegroup-customresponsebody-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JsonBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-jsonbody
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonBody
            /// </summary>
            public RuleGroupTypes.JsonBody JsonBody { get; set; }
            /// <summary>
            /// AllQueryArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-allqueryarguments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllQueryArguments { get; set; }
            /// <summary>
            /// JA3Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-ja3fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JA3Fingerprint
            /// </summary>
            public RuleGroupTypes.JA3Fingerprint JA3Fingerprint { get; set; }
            /// <summary>
            /// SingleQueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-singlequeryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleQueryArgument
            /// </summary>
            public RuleGroupTypes.SingleQueryArgument SingleQueryArgument { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic UriPath { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Headers
            /// </summary>
            public RuleGroupTypes.Headers Headers { get; set; }
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cookies
            /// </summary>
            public RuleGroupTypes.Cookies Cookies { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Method { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-body
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Body
            /// </summary>
            public RuleGroupTypes.Body Body { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public RuleGroupTypes.SingleHeader SingleHeader { get; set; }
        }

        public class ForwardedIPConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-forwardedipconfiguration.html#cfn-wafv2-rulegroup-forwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-forwardedipconfiguration.html#cfn-wafv2-rulegroup-forwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
        }

        public class GeoMatchStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-geomatchstatement.html#cfn-wafv2-rulegroup-geomatchstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public RuleGroupTypes.ForwardedIPConfiguration ForwardedIPConfig { get; set; }
            /// <summary>
            /// CountryCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-geomatchstatement.html#cfn-wafv2-rulegroup-geomatchstatement-countrycodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CountryCodes { get; set; }
        }

        public class HeaderMatchPattern : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headermatchpattern.html#cfn-wafv2-rulegroup-headermatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic All { get; set; }
            /// <summary>
            /// IncludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headermatchpattern.html#cfn-wafv2-rulegroup-headermatchpattern-includedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedHeaders { get; set; }
            /// <summary>
            /// ExcludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headermatchpattern.html#cfn-wafv2-rulegroup-headermatchpattern-excludedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedHeaders { get; set; }
        }

        public class Headers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headers.html#cfn-wafv2-rulegroup-headers-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headers.html#cfn-wafv2-rulegroup-headers-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeaderMatchPattern
            /// </summary>
            public RuleGroupTypes.HeaderMatchPattern MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headers.html#cfn-wafv2-rulegroup-headers-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class IPSetForwardedIPConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetforwardedipconfiguration.html#cfn-wafv2-rulegroup-ipsetforwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetforwardedipconfiguration.html#cfn-wafv2-rulegroup-ipsetforwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetforwardedipconfiguration.html#cfn-wafv2-rulegroup-ipsetforwardedipconfiguration-position
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
        }

        public class IPSetReferenceStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IPSetForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetreferencestatement.html#cfn-wafv2-rulegroup-ipsetreferencestatement-ipsetforwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetForwardedIPConfiguration
            /// </summary>
            public RuleGroupTypes.IPSetForwardedIPConfiguration IPSetForwardedIPConfig { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetreferencestatement.html#cfn-wafv2-rulegroup-ipsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class ImmunityTimeProperty : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImmunityTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-immunitytimeproperty.html#cfn-wafv2-rulegroup-immunitytimeproperty-immunitytime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ImmunityTime { get; set; }
        }

        public class JA3Fingerprint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ja3fingerprint.html#cfn-wafv2-rulegroup-ja3fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackBehavior { get; set; }
        }

        public class JsonBody : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: JsonMatchPattern
            /// </summary>
            public RuleGroupTypes.JsonMatchPattern MatchPattern { get; set; }
            /// <summary>
            /// InvalidFallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-invalidfallbackbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvalidFallbackBehavior { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class JsonMatchPattern : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonmatchpattern.html#cfn-wafv2-rulegroup-jsonmatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic All { get; set; }
            /// <summary>
            /// IncludedPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonmatchpattern.html#cfn-wafv2-rulegroup-jsonmatchpattern-includedpaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedPaths { get; set; }
        }

        public class Label : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-label.html#cfn-wafv2-rulegroup-label-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LabelMatchStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-labelmatchstatement.html#cfn-wafv2-rulegroup-labelmatchstatement-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-labelmatchstatement.html#cfn-wafv2-rulegroup-labelmatchstatement-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class LabelSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-labelsummary.html#cfn-wafv2-rulegroup-labelsummary-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class NotStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-notstatement.html#cfn-wafv2-rulegroup-notstatement-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public RuleGroupTypes.Statement Statement { get; set; }
        }

        public class OrStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatement.html#cfn-wafv2-rulegroup-orstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public List<RuleGroupTypes.Statement> Statements { get; set; }
        }

        public class RateBasedStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AggregateKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-aggregatekeytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregateKeyType { get; set; }
            /// <summary>
            /// CustomKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-customkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateBasedStatementCustomKey
            /// </summary>
            public List<RuleGroupTypes.RateBasedStatementCustomKey> CustomKeys { get; set; }
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public RuleGroupTypes.ForwardedIPConfiguration ForwardedIPConfig { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-limit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Limit { get; set; }
            /// <summary>
            /// EvaluationWindowSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-evaluationwindowsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EvaluationWindowSec { get; set; }
            /// <summary>
            /// ScopeDownStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-scopedownstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public RuleGroupTypes.Statement ScopeDownStatement { get; set; }
        }

        public class RateBasedStatementCustomKey : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Cookie
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-cookie
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitCookie
            /// </summary>
            public RuleGroupTypes.RateLimitCookie Cookie { get; set; }
            /// <summary>
            /// ForwardedIP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-forwardedip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ForwardedIP { get; set; }
            /// <summary>
            /// QueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-queryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryArgument
            /// </summary>
            public RuleGroupTypes.RateLimitQueryArgument QueryArgument { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitHeader
            /// </summary>
            public RuleGroupTypes.RateLimitHeader Header { get; set; }
            /// <summary>
            /// HTTPMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic HTTPMethod { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryString
            /// </summary>
            public RuleGroupTypes.RateLimitQueryString QueryString { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitUriPath
            /// </summary>
            public RuleGroupTypes.RateLimitUriPath UriPath { get; set; }
            /// <summary>
            /// IP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic IP { get; set; }
            /// <summary>
            /// LabelNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-labelnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitLabelNamespace
            /// </summary>
            public RuleGroupTypes.RateLimitLabelNamespace LabelNamespace { get; set; }
        }

        public class RateLimitCookie : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitcookie.html#cfn-wafv2-rulegroup-ratelimitcookie-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitcookie.html#cfn-wafv2-rulegroup-ratelimitcookie-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RateLimitHeader : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitheader.html#cfn-wafv2-rulegroup-ratelimitheader-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitheader.html#cfn-wafv2-rulegroup-ratelimitheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RateLimitLabelNamespace : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Namespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitlabelnamespace.html#cfn-wafv2-rulegroup-ratelimitlabelnamespace-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace { get; set; }
        }

        public class RateLimitQueryArgument : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitqueryargument.html#cfn-wafv2-rulegroup-ratelimitqueryargument-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitqueryargument.html#cfn-wafv2-rulegroup-ratelimitqueryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RateLimitQueryString : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitquerystring.html#cfn-wafv2-rulegroup-ratelimitquerystring-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
        }

        public class RateLimitUriPath : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimituripath.html#cfn-wafv2-rulegroup-ratelimituripath-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
        }

        public class RegexMatchStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// RegexString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-regexstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegexString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
        }

        public class RegexPatternSetReferenceStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleAction
            /// </summary>
            public RuleGroupTypes.RuleAction Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public RuleGroupTypes.Statement Statement { get; set; }
            /// <summary>
            /// ChallengeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-challengeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeConfig
            /// </summary>
            public RuleGroupTypes.ChallengeConfig ChallengeConfig { get; set; }
            /// <summary>
            /// RuleLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-rulelabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Label
            /// </summary>
            public List<RuleGroupTypes.Label> RuleLabels { get; set; }
            /// <summary>
            /// VisibilityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-visibilityconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VisibilityConfig
            /// </summary>
            public RuleGroupTypes.VisibilityConfig VisibilityConfig { get; set; }
            /// <summary>
            /// CaptchaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-captchaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaConfig
            /// </summary>
            public RuleGroupTypes.CaptchaConfig CaptchaConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RuleAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Captcha
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-captcha
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaAction
            /// </summary>
            public RuleGroupTypes.CaptchaAction Captcha { get; set; }
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-block
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockAction
            /// </summary>
            public RuleGroupTypes.BlockAction Block { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-count
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CountAction
            /// </summary>
            public RuleGroupTypes.CountAction Count { get; set; }
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowAction
            /// </summary>
            public RuleGroupTypes.AllowAction Allow { get; set; }
            /// <summary>
            /// Challenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-challenge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeAction
            /// </summary>
            public RuleGroupTypes.ChallengeAction Challenge { get; set; }
        }

        public class SingleHeader : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-singleheader.html#cfn-wafv2-rulegroup-singleheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SingleQueryArgument : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-singlequeryargument.html#cfn-wafv2-rulegroup-singlequeryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SizeConstraintStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Size { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
        }

        public class SqliMatchStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SensitivityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-sensitivitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SensitivityLevel { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
        }

        public class Statement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SizeConstraintStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-sizeconstraintstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SizeConstraintStatement
            /// </summary>
            public RuleGroupTypes.SizeConstraintStatement SizeConstraintStatement { get; set; }
            /// <summary>
            /// AndStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-andstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndStatement
            /// </summary>
            public RuleGroupTypes.AndStatement AndStatement { get; set; }
            /// <summary>
            /// XssMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-xssmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: XssMatchStatement
            /// </summary>
            public RuleGroupTypes.XssMatchStatement XssMatchStatement { get; set; }
            /// <summary>
            /// NotStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-notstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotStatement
            /// </summary>
            public RuleGroupTypes.NotStatement NotStatement { get; set; }
            /// <summary>
            /// ByteMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-bytematchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ByteMatchStatement
            /// </summary>
            public RuleGroupTypes.ByteMatchStatement ByteMatchStatement { get; set; }
            /// <summary>
            /// RateBasedStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-ratebasedstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateBasedStatement
            /// </summary>
            public RuleGroupTypes.RateBasedStatement RateBasedStatement { get; set; }
            /// <summary>
            /// GeoMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-geomatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoMatchStatement
            /// </summary>
            public RuleGroupTypes.GeoMatchStatement GeoMatchStatement { get; set; }
            /// <summary>
            /// LabelMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-labelmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelMatchStatement
            /// </summary>
            public RuleGroupTypes.LabelMatchStatement LabelMatchStatement { get; set; }
            /// <summary>
            /// RegexMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-regexmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexMatchStatement
            /// </summary>
            public RuleGroupTypes.RegexMatchStatement RegexMatchStatement { get; set; }
            /// <summary>
            /// SqliMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-sqlimatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqliMatchStatement
            /// </summary>
            public RuleGroupTypes.SqliMatchStatement SqliMatchStatement { get; set; }
            /// <summary>
            /// RegexPatternSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-regexpatternsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexPatternSetReferenceStatement
            /// </summary>
            public RuleGroupTypes.RegexPatternSetReferenceStatement RegexPatternSetReferenceStatement { get; set; }
            /// <summary>
            /// OrStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-orstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrStatement
            /// </summary>
            public RuleGroupTypes.OrStatement OrStatement { get; set; }
            /// <summary>
            /// IPSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-ipsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetReferenceStatement
            /// </summary>
            public RuleGroupTypes.IPSetReferenceStatement IPSetReferenceStatement { get; set; }
        }

        public class TextTransformation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-texttransformation.html#cfn-wafv2-rulegroup-texttransformation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-texttransformation.html#cfn-wafv2-rulegroup-texttransformation-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
        }

        public class VisibilityConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// SampledRequestsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-sampledrequestsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SampledRequestsEnabled { get; set; }
            /// <summary>
            /// CloudWatchMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-cloudwatchmetricsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CloudWatchMetricsEnabled { get; set; }
        }

        public class XssMatchStatement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<RuleGroupTypes.TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public RuleGroupTypes.FieldToMatch FieldToMatch { get; set; }
        }
    }
}