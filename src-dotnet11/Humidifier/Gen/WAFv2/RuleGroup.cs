namespace Humidifier.WAFv2
{
    using global::System.Collections.Generic;
    using RuleGroupTypes;

    public class RuleGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveScope, IHaveCapacity_Integer, IHaveListOfWAFv2RuleGroupTypesLabelSummaryAvailableLabels, IHaveMapOfWAFv2RuleGroupTypesCustomResponseBodyCustomResponseBodies, IHaveWAFv2RuleGroupTypesMonetizationConfigMonetizationConfig, IHaveListOfWAFv2RuleGroupTypesLabelSummaryConsumedLabels, IHaveListOfWAFv2RuleGroupTypesRuleRules, IHaveWAFv2RuleGroupTypesVisibilityConfigVisibilityConfig, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Scope { get; set; }

        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-capacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Capacity { get; set; }
        /// <summary>
        /// AvailableLabels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-availablelabels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LabelSummary
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.LabelSummary>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.LabelSummary, BaseFunction>>, BaseFunction>? AvailableLabels { get; set; }
        /// <summary>
        /// CustomResponseBodies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-customresponsebodies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: CustomResponseBody
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.WAFv2.RuleGroupTypes.CustomResponseBody>, IReadOnlyDictionary<string, Union<Humidifier.WAFv2.RuleGroupTypes.CustomResponseBody, BaseFunction>>, BaseFunction>? CustomResponseBodies { get; set; }
        /// <summary>
        /// MonetizationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-monetizationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MonetizationConfig
        /// </summary>
        public Union<Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig, BaseFunction>? MonetizationConfig { get; set; }
        /// <summary>
        /// ConsumedLabels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-consumedlabels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LabelSummary
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.LabelSummary>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.LabelSummary, BaseFunction>>, BaseFunction>? ConsumedLabels { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.Rule>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }

        /// <summary>
        /// VisibilityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-visibilityconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VisibilityConfig
        /// </summary>
        [Required]
        public Union<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig, BaseFunction>? VisibilityConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-rulegroup.html#cfn-wafv2-rulegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuleGroupTypes
    {
        public class AllowAction : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-allowaction.html#cfn-wafv2-rulegroup-allowaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class AndStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesStatementStatements
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-andstatement.html#cfn-wafv2-rulegroup-andstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.Statement>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.Statement, BaseFunction>>, BaseFunction>? Statements { get; set; }
        }

        public class AsnMatchStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesForwardedIPConfigurationForwardedIPConfig, IHaveIntegerListOfAsnList
        {
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-asnmatchstatement.html#cfn-wafv2-rulegroup-asnmatchstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration, BaseFunction>? ForwardedIPConfig { get; set; }
            /// <summary>
            /// AsnList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-asnmatchstatement.html#cfn-wafv2-rulegroup-asnmatchstatement-asnlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? AsnList { get; set; }
        }

        public class BlockAction : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesCustomResponseCustomResponse
        {
            /// <summary>
            /// CustomResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-blockaction.html#cfn-wafv2-rulegroup-blockaction-customresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomResponse
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CustomResponse, BaseFunction>? CustomResponse { get; set; }
        }

        public class Body : Humidifier.Base.BaseSubResource, IHaveOversizeHandling
        {
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-body.html#cfn-wafv2-rulegroup-body-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class ByteMatchStatement : Humidifier.Base.BaseSubResource, IHaveSearchStringBase64, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveListOfWAFv2RuleGroupTypesPreParseTextTransformationPreParseTextTransformations, IHavePositionalConstraint, IHaveSearchString, IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// SearchStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-searchstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchStringBase64 { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PositionalConstraint { get; set; }
            /// <summary>
            /// SearchString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-searchstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-bytematchstatement.html#cfn-wafv2-rulegroup-bytematchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class CaptchaAction : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-captchaaction.html#cfn-wafv2-rulegroup-captchaaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class CaptchaConfig : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesImmunityTimePropertyImmunityTimeProperty
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-captchaconfig.html#cfn-wafv2-rulegroup-captchaconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty, BaseFunction>? ImmunityTimeProperty { get; set; }
        }

        public class ChallengeAction : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-challengeaction.html#cfn-wafv2-rulegroup-challengeaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class ChallengeConfig : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesImmunityTimePropertyImmunityTimeProperty
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-challengeconfig.html#cfn-wafv2-rulegroup-challengeconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty, BaseFunction>? ImmunityTimeProperty { get; set; }
        }

        public class CookieMatchPattern : Humidifier.Base.BaseSubResource, IHaveAll_Json, IHaveStringListOfIncludedCookies, IHaveStringListOfExcludedCookies
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookiematchpattern.html#cfn-wafv2-rulegroup-cookiematchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// IncludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookiematchpattern.html#cfn-wafv2-rulegroup-cookiematchpattern-includedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedCookies { get; set; }
            /// <summary>
            /// ExcludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookiematchpattern.html#cfn-wafv2-rulegroup-cookiematchpattern-excludedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedCookies { get; set; }
        }

        public class Cookies : Humidifier.Base.BaseSubResource, IHaveMatchScope, IHaveWAFv2RuleGroupTypesCookieMatchPatternMatchPattern, IHaveOversizeHandling
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookies.html#cfn-wafv2-rulegroup-cookies-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookies.html#cfn-wafv2-rulegroup-cookies-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookieMatchPattern
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern, BaseFunction>? MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cookies.html#cfn-wafv2-rulegroup-cookies-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class CountAction : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-countaction.html#cfn-wafv2-rulegroup-countaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class CryptoConfig : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesPaymentNetworkPaymentNetworks
        {
            /// <summary>
            /// PaymentNetworks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-cryptoconfig.html#cfn-wafv2-rulegroup-cryptoconfig-paymentnetworks
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PaymentNetwork
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PaymentNetwork>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PaymentNetwork, BaseFunction>>, BaseFunction>? PaymentNetworks { get; set; }
        }

        public class CustomHTTPHeader : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customhttpheader.html#cfn-wafv2-rulegroup-customhttpheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customhttpheader.html#cfn-wafv2-rulegroup-customhttpheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CustomRequestHandling : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesCustomHTTPHeaderInsertHeaders
        {
            /// <summary>
            /// InsertHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customrequesthandling.html#cfn-wafv2-rulegroup-customrequesthandling-insertheaders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.CustomHTTPHeader>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.CustomHTTPHeader, BaseFunction>>, BaseFunction>? InsertHeaders { get; set; }
        }

        public class CustomResponse : Humidifier.Base.BaseSubResource, IHaveResponseCode_Integer, IHaveCustomResponseBodyKey, IHaveListOfWAFv2RuleGroupTypesCustomHTTPHeaderResponseHeaders
        {
            /// <summary>
            /// ResponseCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponse.html#cfn-wafv2-rulegroup-customresponse-responsecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResponseCode { get; set; }
            /// <summary>
            /// CustomResponseBodyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponse.html#cfn-wafv2-rulegroup-customresponse-customresponsebodykey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomResponseBodyKey { get; set; }
            /// <summary>
            /// ResponseHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponse.html#cfn-wafv2-rulegroup-customresponse-responseheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.CustomHTTPHeader>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.CustomHTTPHeader, BaseFunction>>, BaseFunction>? ResponseHeaders { get; set; }
        }

        public class CustomResponseBody : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContent
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponsebody.html#cfn-wafv2-rulegroup-customresponsebody-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-customresponsebody.html#cfn-wafv2-rulegroup-customresponsebody-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveAllQueryArguments_Json, IHaveWAFv2RuleGroupTypesJA3FingerprintJA3Fingerprint, IHaveWAFv2RuleGroupTypesSingleQueryArgumentSingleQueryArgument, IHaveQueryString_Json, IHaveWAFv2RuleGroupTypesHeadersHeaders, IHaveMethod_Json, IHaveWAFv2RuleGroupTypesUriFragmentUriFragment, IHaveWAFv2RuleGroupTypesJsonBodyJsonBody, IHaveUriPath_Json, IHaveWAFv2RuleGroupTypesCookiesCookies, IHaveWAFv2RuleGroupTypesJA4FingerprintJA4Fingerprint, IHaveWAFv2RuleGroupTypesHeaderOrderHeaderOrder, IHaveWAFv2RuleGroupTypesBodyBody, IHaveWAFv2RuleGroupTypesSingleHeaderSingleHeader
        {
            /// <summary>
            /// AllQueryArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-allqueryarguments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllQueryArguments { get; set; }
            /// <summary>
            /// JA3Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-ja3fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JA3Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.JA3Fingerprint, BaseFunction>? JA3Fingerprint { get; set; }
            /// <summary>
            /// SingleQueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-singlequeryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleQueryArgument
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.SingleQueryArgument, BaseFunction>? SingleQueryArgument { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Headers
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.Headers, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Method { get; set; }
            /// <summary>
            /// UriFragment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-urifragment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UriFragment
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.UriFragment, BaseFunction>? UriFragment { get; set; }
            /// <summary>
            /// JsonBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-jsonbody
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonBody
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.JsonBody, BaseFunction>? JsonBody { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cookies
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.Cookies, BaseFunction>? Cookies { get; set; }
            /// <summary>
            /// JA4Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-ja4fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JA4Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.JA4Fingerprint, BaseFunction>? JA4Fingerprint { get; set; }
            /// <summary>
            /// HeaderOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-headerorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderOrder
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.HeaderOrder, BaseFunction>? HeaderOrder { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-body
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Body
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.Body, BaseFunction>? Body { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html#cfn-wafv2-rulegroup-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.SingleHeader, BaseFunction>? SingleHeader { get; set; }
        }

        public class ForwardedIPConfiguration : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior, IHaveHeaderName
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-forwardedipconfiguration.html#cfn-wafv2-rulegroup-forwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-forwardedipconfiguration.html#cfn-wafv2-rulegroup-forwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
        }

        public class GeoMatchStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesForwardedIPConfigurationForwardedIPConfig, IHaveStringListOfCountryCodes
        {
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-geomatchstatement.html#cfn-wafv2-rulegroup-geomatchstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration, BaseFunction>? ForwardedIPConfig { get; set; }
            /// <summary>
            /// CountryCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-geomatchstatement.html#cfn-wafv2-rulegroup-geomatchstatement-countrycodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CountryCodes { get; set; }
        }

        public class HeaderMatchPattern : Humidifier.Base.BaseSubResource, IHaveAll_Json, IHaveStringListOfIncludedHeaders, IHaveStringListOfExcludedHeaders
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headermatchpattern.html#cfn-wafv2-rulegroup-headermatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// IncludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headermatchpattern.html#cfn-wafv2-rulegroup-headermatchpattern-includedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedHeaders { get; set; }
            /// <summary>
            /// ExcludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headermatchpattern.html#cfn-wafv2-rulegroup-headermatchpattern-excludedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedHeaders { get; set; }
        }

        public class HeaderOrder : Humidifier.Base.BaseSubResource, IHaveOversizeHandling
        {
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headerorder.html#cfn-wafv2-rulegroup-headerorder-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class Headers : Humidifier.Base.BaseSubResource, IHaveMatchScope, IHaveWAFv2RuleGroupTypesHeaderMatchPatternMatchPattern, IHaveOversizeHandling
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headers.html#cfn-wafv2-rulegroup-headers-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headers.html#cfn-wafv2-rulegroup-headers-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeaderMatchPattern
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern, BaseFunction>? MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-headers.html#cfn-wafv2-rulegroup-headers-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class IPSetForwardedIPConfiguration : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior, IHaveHeaderName, IHavePosition
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetforwardedipconfiguration.html#cfn-wafv2-rulegroup-ipsetforwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetforwardedipconfiguration.html#cfn-wafv2-rulegroup-ipsetforwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetforwardedipconfiguration.html#cfn-wafv2-rulegroup-ipsetforwardedipconfiguration-position
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Position { get; set; }
        }

        public class IPSetReferenceStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesIPSetForwardedIPConfigurationIPSetForwardedIPConfig, IHaveArn
        {
            /// <summary>
            /// IPSetForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetreferencestatement.html#cfn-wafv2-rulegroup-ipsetreferencestatement-ipsetforwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration, BaseFunction>? IPSetForwardedIPConfig { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ipsetreferencestatement.html#cfn-wafv2-rulegroup-ipsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class ImmunityTimeProperty : Humidifier.Base.BaseSubResource, IHaveImmunityTime_Integer
        {
            /// <summary>
            /// ImmunityTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-immunitytimeproperty.html#cfn-wafv2-rulegroup-immunitytimeproperty-immunitytime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ImmunityTime { get; set; }
        }

        public class JA3Fingerprint : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ja3fingerprint.html#cfn-wafv2-rulegroup-ja3fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
        }

        public class JA4Fingerprint : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ja4fingerprint.html#cfn-wafv2-rulegroup-ja4fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
        }

        public class JsonBody : Humidifier.Base.BaseSubResource, IHaveMatchScope, IHaveWAFv2RuleGroupTypesJsonMatchPatternMatchPattern, IHaveInvalidFallbackBehavior, IHaveOversizeHandling
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: JsonMatchPattern
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern, BaseFunction>? MatchPattern { get; set; }
            /// <summary>
            /// InvalidFallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-invalidfallbackbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvalidFallbackBehavior { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html#cfn-wafv2-rulegroup-jsonbody-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class JsonMatchPattern : Humidifier.Base.BaseSubResource, IHaveAll_Json, IHaveStringListOfIncludedPaths
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonmatchpattern.html#cfn-wafv2-rulegroup-jsonmatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// IncludedPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonmatchpattern.html#cfn-wafv2-rulegroup-jsonmatchpattern-includedpaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedPaths { get; set; }
        }

        public class Label : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-label.html#cfn-wafv2-rulegroup-label-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LabelMatchStatement : Humidifier.Base.BaseSubResource, IHaveScope, IHaveKey
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-labelmatchstatement.html#cfn-wafv2-rulegroup-labelmatchstatement-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-labelmatchstatement.html#cfn-wafv2-rulegroup-labelmatchstatement-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class LabelSummary : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-labelsummary.html#cfn-wafv2-rulegroup-labelsummary-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MonetizationConfig : Humidifier.Base.BaseSubResource, IHaveCurrencyMode, IHaveWAFv2RuleGroupTypesCryptoConfigCryptoConfig
        {
            /// <summary>
            /// CurrencyMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-monetizationconfig.html#cfn-wafv2-rulegroup-monetizationconfig-currencymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CurrencyMode { get; set; }
            /// <summary>
            /// CryptoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-monetizationconfig.html#cfn-wafv2-rulegroup-monetizationconfig-cryptoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CryptoConfig
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig, BaseFunction>? CryptoConfig { get; set; }
        }

        public class MonetizeAction : Humidifier.Base.BaseSubResource, IHavePriceMultiplier
        {
            /// <summary>
            /// PriceMultiplier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-monetizeaction.html#cfn-wafv2-rulegroup-monetizeaction-pricemultiplier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PriceMultiplier { get; set; }
        }

        public class NotStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesStatementStatement
        {
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-notstatement.html#cfn-wafv2-rulegroup-notstatement-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.Statement, BaseFunction>? Statement { get; set; }
        }

        public class OrStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesStatementStatements
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatement.html#cfn-wafv2-rulegroup-orstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.Statement>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.Statement, BaseFunction>>, BaseFunction>? Statements { get; set; }
        }

        public class PaymentNetwork : Humidifier.Base.BaseSubResource, IHaveChain, IHaveListOfWAFv2RuleGroupTypesPricePrices, IHaveWalletAddress
        {
            /// <summary>
            /// Chain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-paymentnetwork.html#cfn-wafv2-rulegroup-paymentnetwork-chain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Chain { get; set; }
            /// <summary>
            /// Prices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-paymentnetwork.html#cfn-wafv2-rulegroup-paymentnetwork-prices
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Price
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.Price>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.Price, BaseFunction>>, BaseFunction>? Prices { get; set; }
            /// <summary>
            /// WalletAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-paymentnetwork.html#cfn-wafv2-rulegroup-paymentnetwork-walletaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WalletAddress { get; set; }
        }

        public class PreParseTextTransformation : Humidifier.Base.BaseSubResource, IHaveType, IHavePriority_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-preparsetexttransformation.html#cfn-wafv2-rulegroup-preparsetexttransformation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-preparsetexttransformation.html#cfn-wafv2-rulegroup-preparsetexttransformation-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
        }

        public class Price : Humidifier.Base.BaseSubResource, IHaveAmount, IHaveCurrency
        {
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-price.html#cfn-wafv2-rulegroup-price-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Amount { get; set; }
            /// <summary>
            /// Currency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-price.html#cfn-wafv2-rulegroup-price-currency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Currency { get; set; }
        }

        public class RateBasedStatement : Humidifier.Base.BaseSubResource, IHaveAggregateKeyType, IHaveListOfWAFv2RuleGroupTypesRateBasedStatementCustomKeyCustomKeys, IHaveWAFv2RuleGroupTypesForwardedIPConfigurationForwardedIPConfig, IHaveLimit_Integer, IHaveEvaluationWindowSec_Integer, IHaveWAFv2RuleGroupTypesStatementScopeDownStatement
        {
            /// <summary>
            /// AggregateKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-aggregatekeytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AggregateKeyType { get; set; }
            /// <summary>
            /// CustomKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-customkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateBasedStatementCustomKey
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.RateBasedStatementCustomKey>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.RateBasedStatementCustomKey, BaseFunction>>, BaseFunction>? CustomKeys { get; set; }
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration, BaseFunction>? ForwardedIPConfig { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-limit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Limit { get; set; }
            /// <summary>
            /// EvaluationWindowSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-evaluationwindowsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationWindowSec { get; set; }
            /// <summary>
            /// ScopeDownStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatement.html#cfn-wafv2-rulegroup-ratebasedstatement-scopedownstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.Statement, BaseFunction>? ScopeDownStatement { get; set; }
        }

        public class RateBasedStatementCustomKey : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesRateLimitCookieCookie, IHaveForwardedIP_Json, IHaveWAFv2RuleGroupTypesRateLimitQueryArgumentQueryArgument, IHaveWAFv2RuleGroupTypesRateLimitJA3FingerprintJA3Fingerprint, IHaveWAFv2RuleGroupTypesRateLimitHeaderHeader, IHaveHTTPMethod_Json, IHaveWAFv2RuleGroupTypesRateLimitQueryStringQueryString, IHaveWAFv2RuleGroupTypesRateLimitUriPathUriPath, IHaveIP_Json, IHaveWAFv2RuleGroupTypesRateLimitJA4FingerprintJA4Fingerprint, IHaveASN_Json, IHaveWAFv2RuleGroupTypesRateLimitLabelNamespaceLabelNamespace
        {
            /// <summary>
            /// Cookie
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-cookie
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitCookie
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitCookie, BaseFunction>? Cookie { get; set; }
            /// <summary>
            /// ForwardedIP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-forwardedip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ForwardedIP { get; set; }
            /// <summary>
            /// QueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-queryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryArgument
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitQueryArgument, BaseFunction>? QueryArgument { get; set; }
            /// <summary>
            /// JA3Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-ja3fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitJA3Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitJA3Fingerprint, BaseFunction>? JA3Fingerprint { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitHeader
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitHeader, BaseFunction>? Header { get; set; }
            /// <summary>
            /// HTTPMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? HTTPMethod { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryString
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitQueryString, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitUriPath
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitUriPath, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// IP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? IP { get; set; }
            /// <summary>
            /// JA4Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-ja4fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitJA4Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitJA4Fingerprint, BaseFunction>? JA4Fingerprint { get; set; }
            /// <summary>
            /// ASN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-asn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ASN { get; set; }
            /// <summary>
            /// LabelNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratebasedstatementcustomkey.html#cfn-wafv2-rulegroup-ratebasedstatementcustomkey-labelnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitLabelNamespace
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateLimitLabelNamespace, BaseFunction>? LabelNamespace { get; set; }
        }

        public class RateLimitCookie : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveName
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitcookie.html#cfn-wafv2-rulegroup-ratelimitcookie-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitcookie.html#cfn-wafv2-rulegroup-ratelimitcookie-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RateLimitHeader : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveName
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitheader.html#cfn-wafv2-rulegroup-ratelimitheader-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitheader.html#cfn-wafv2-rulegroup-ratelimitheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RateLimitJA3Fingerprint : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitja3fingerprint.html#cfn-wafv2-rulegroup-ratelimitja3fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
        }

        public class RateLimitJA4Fingerprint : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitja4fingerprint.html#cfn-wafv2-rulegroup-ratelimitja4fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
        }

        public class RateLimitLabelNamespace : Humidifier.Base.BaseSubResource, IHaveNamespace_
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitlabelnamespace.html#cfn-wafv2-rulegroup-ratelimitlabelnamespace-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class RateLimitQueryArgument : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveName
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitqueryargument.html#cfn-wafv2-rulegroup-ratelimitqueryargument-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitqueryargument.html#cfn-wafv2-rulegroup-ratelimitqueryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RateLimitQueryString : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimitquerystring.html#cfn-wafv2-rulegroup-ratelimitquerystring-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
        }

        public class RateLimitUriPath : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ratelimituripath.html#cfn-wafv2-rulegroup-ratelimituripath-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
        }

        public class RegexMatchStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveListOfWAFv2RuleGroupTypesPreParseTextTransformationPreParseTextTransformations, IHaveRegexString, IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// RegexString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-regexstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegexString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexmatchstatement.html#cfn-wafv2-rulegroup-regexmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class RegexPatternSetReferenceStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveListOfWAFv2RuleGroupTypesPreParseTextTransformationPreParseTextTransformations, IHaveArn, IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-regexpatternsetreferencestatement.html#cfn-wafv2-rulegroup-regexpatternsetreferencestatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesRuleActionAction, IHavePriority_Integer, IHaveWAFv2RuleGroupTypesStatementStatement, IHaveWAFv2RuleGroupTypesChallengeConfigChallengeConfig, IHaveListOfWAFv2RuleGroupTypesLabelRuleLabels, IHaveWAFv2RuleGroupTypesVisibilityConfigVisibilityConfig, IHaveWAFv2RuleGroupTypesCaptchaConfigCaptchaConfig, IHaveName
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RuleAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.Statement, BaseFunction>? Statement { get; set; }
            /// <summary>
            /// ChallengeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-challengeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeConfig
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig, BaseFunction>? ChallengeConfig { get; set; }
            /// <summary>
            /// RuleLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-rulelabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Label
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.Label>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.Label, BaseFunction>>, BaseFunction>? RuleLabels { get; set; }
            /// <summary>
            /// VisibilityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-visibilityconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VisibilityConfig
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig, BaseFunction>? VisibilityConfig { get; set; }
            /// <summary>
            /// CaptchaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-captchaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaConfig
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig, BaseFunction>? CaptchaConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html#cfn-wafv2-rulegroup-rule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RuleAction : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesMonetizeActionMonetize, IHaveWAFv2RuleGroupTypesCaptchaActionCaptcha, IHaveWAFv2RuleGroupTypesBlockActionBlock, IHaveWAFv2RuleGroupTypesCountActionCount, IHaveWAFv2RuleGroupTypesAllowActionAllow, IHaveWAFv2RuleGroupTypesChallengeActionChallenge
        {
            /// <summary>
            /// Monetize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-monetize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonetizeAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.MonetizeAction, BaseFunction>? Monetize { get; set; }
            /// <summary>
            /// Captcha
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-captcha
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CaptchaAction, BaseFunction>? Captcha { get; set; }
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-block
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.BlockAction, BaseFunction>? Block { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-count
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CountAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.CountAction, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.AllowAction, BaseFunction>? Allow { get; set; }
            /// <summary>
            /// Challenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-ruleaction.html#cfn-wafv2-rulegroup-ruleaction-challenge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeAction
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ChallengeAction, BaseFunction>? Challenge { get; set; }
        }

        public class SingleHeader : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-singleheader.html#cfn-wafv2-rulegroup-singleheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SingleQueryArgument : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-singlequeryargument.html#cfn-wafv2-rulegroup-singlequeryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SizeConstraintStatement : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveListOfWAFv2RuleGroupTypesPreParseTextTransformationPreParseTextTransformations, IHaveSize_Double, IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Size { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sizeconstraintstatement.html#cfn-wafv2-rulegroup-sizeconstraintstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class SqliMatchStatement : Humidifier.Base.BaseSubResource, IHaveSensitivityLevel, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveListOfWAFv2RuleGroupTypesPreParseTextTransformationPreParseTextTransformations, IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// SensitivityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-sensitivitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SensitivityLevel { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-sqlimatchstatement.html#cfn-wafv2-rulegroup-sqlimatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class Statement : Humidifier.Base.BaseSubResource, IHaveWAFv2RuleGroupTypesSizeConstraintStatementSizeConstraintStatement, IHaveWAFv2RuleGroupTypesAndStatementAndStatement, IHaveWAFv2RuleGroupTypesXssMatchStatementXssMatchStatement, IHaveWAFv2RuleGroupTypesNotStatementNotStatement, IHaveWAFv2RuleGroupTypesByteMatchStatementByteMatchStatement, IHaveWAFv2RuleGroupTypesRateBasedStatementRateBasedStatement, IHaveWAFv2RuleGroupTypesGeoMatchStatementGeoMatchStatement, IHaveWAFv2RuleGroupTypesLabelMatchStatementLabelMatchStatement, IHaveWAFv2RuleGroupTypesRegexMatchStatementRegexMatchStatement, IHaveWAFv2RuleGroupTypesSqliMatchStatementSqliMatchStatement, IHaveWAFv2RuleGroupTypesRegexPatternSetReferenceStatementRegexPatternSetReferenceStatement, IHaveWAFv2RuleGroupTypesOrStatementOrStatement, IHaveWAFv2RuleGroupTypesAsnMatchStatementAsnMatchStatement, IHaveWAFv2RuleGroupTypesIPSetReferenceStatementIPSetReferenceStatement
        {
            /// <summary>
            /// SizeConstraintStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-sizeconstraintstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SizeConstraintStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement, BaseFunction>? SizeConstraintStatement { get; set; }
            /// <summary>
            /// AndStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-andstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.AndStatement, BaseFunction>? AndStatement { get; set; }
            /// <summary>
            /// XssMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-xssmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: XssMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement, BaseFunction>? XssMatchStatement { get; set; }
            /// <summary>
            /// NotStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-notstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.NotStatement, BaseFunction>? NotStatement { get; set; }
            /// <summary>
            /// ByteMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-bytematchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ByteMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement, BaseFunction>? ByteMatchStatement { get; set; }
            /// <summary>
            /// RateBasedStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-ratebasedstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateBasedStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement, BaseFunction>? RateBasedStatement { get; set; }
            /// <summary>
            /// GeoMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-geomatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement, BaseFunction>? GeoMatchStatement { get; set; }
            /// <summary>
            /// LabelMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-labelmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.LabelMatchStatement, BaseFunction>? LabelMatchStatement { get; set; }
            /// <summary>
            /// RegexMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-regexmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement, BaseFunction>? RegexMatchStatement { get; set; }
            /// <summary>
            /// SqliMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-sqlimatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqliMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement, BaseFunction>? SqliMatchStatement { get; set; }
            /// <summary>
            /// RegexPatternSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-regexpatternsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexPatternSetReferenceStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.RegexPatternSetReferenceStatement, BaseFunction>? RegexPatternSetReferenceStatement { get; set; }
            /// <summary>
            /// OrStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-orstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.OrStatement, BaseFunction>? OrStatement { get; set; }
            /// <summary>
            /// AsnMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-asnmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AsnMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement, BaseFunction>? AsnMatchStatement { get; set; }
            /// <summary>
            /// IPSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statement.html#cfn-wafv2-rulegroup-statement-ipsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetReferenceStatement
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement, BaseFunction>? IPSetReferenceStatement { get; set; }
        }

        public class TextTransformation : Humidifier.Base.BaseSubResource, IHaveType, IHavePriority_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-texttransformation.html#cfn-wafv2-rulegroup-texttransformation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-texttransformation.html#cfn-wafv2-rulegroup-texttransformation-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
        }

        public class UriFragment : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-urifragment.html#cfn-wafv2-rulegroup-urifragment-fallbackbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
        }

        public class VisibilityConfig : Humidifier.Base.BaseSubResource, IHaveSampledRequestsEnabled_Boolean, IHaveMetricName, IHaveCloudWatchMetricsEnabled_Boolean
        {
            /// <summary>
            /// SampledRequestsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-sampledrequestsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SampledRequestsEnabled { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// CloudWatchMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-cloudwatchmetricsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudWatchMetricsEnabled { get; set; }
        }

        public class XssMatchStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2RuleGroupTypesTextTransformationTextTransformations, IHaveListOfWAFv2RuleGroupTypesPreParseTextTransformationPreParseTextTransformations, IHaveWAFv2RuleGroupTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.RuleGroupTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }
    }
}