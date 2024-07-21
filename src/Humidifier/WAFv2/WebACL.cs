namespace Humidifier.WAFv2
{
    using System.Collections.Generic;
    using WebACLTypes;

    public class WebACL : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Capacity =  "Capacity" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string LabelNamespace =  "LabelNamespace" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WAFv2::WebACL";
            }
        }

        /// <summary>
        /// TokenDomains
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-tokendomains
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TokenDomains { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// AssociationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-associationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AssociationConfig
        /// </summary>
        public AssociationConfig AssociationConfig { get; set; }
        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DefaultAction
        /// </summary>
        public DefaultAction DefaultAction { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Scope { get; set; }
        /// <summary>
        /// CustomResponseBodies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-customresponsebodies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: CustomResponseBody
        /// </summary>
        public Dictionary<string, CustomResponseBody> CustomResponseBodies { get; set; }
        /// <summary>
        /// ChallengeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-challengeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChallengeConfig
        /// </summary>
        public ChallengeConfig ChallengeConfig { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        public List<Rule> Rules { get; set; }
        /// <summary>
        /// VisibilityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-visibilityconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VisibilityConfig
        /// </summary>
        public VisibilityConfig VisibilityConfig { get; set; }
        /// <summary>
        /// CaptchaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-captchaconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CaptchaConfig
        /// </summary>
        public CaptchaConfig CaptchaConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace WebACLTypes
    {
        public class AWSManagedRulesACFPRuleSet
        {
            /// <summary>
            /// RegistrationPagePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-registrationpagepath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistrationPagePath { get; set; }
            /// <summary>
            /// ResponseInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-responseinspection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspection
            /// </summary>
            public ResponseInspection ResponseInspection { get; set; }
            /// <summary>
            /// CreationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-creationpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreationPath { get; set; }
            /// <summary>
            /// EnableRegexInPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-enableregexinpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableRegexInPath { get; set; }
            /// <summary>
            /// RequestInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-requestinspection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RequestInspectionACFP
            /// </summary>
            public RequestInspectionACFP RequestInspection { get; set; }
        }

        public class AWSManagedRulesATPRuleSet
        {
            /// <summary>
            /// ResponseInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-responseinspection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspection
            /// </summary>
            public ResponseInspection ResponseInspection { get; set; }
            /// <summary>
            /// EnableRegexInPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-enableregexinpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableRegexInPath { get; set; }
            /// <summary>
            /// LoginPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-loginpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoginPath { get; set; }
            /// <summary>
            /// RequestInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-requestinspection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RequestInspection
            /// </summary>
            public RequestInspection RequestInspection { get; set; }
        }

        public class AWSManagedRulesBotControlRuleSet
        {
            /// <summary>
            /// InspectionLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesbotcontrolruleset.html#cfn-wafv2-webacl-awsmanagedrulesbotcontrolruleset-inspectionlevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InspectionLevel { get; set; }
            /// <summary>
            /// EnableMachineLearning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesbotcontrolruleset.html#cfn-wafv2-webacl-awsmanagedrulesbotcontrolruleset-enablemachinelearning
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableMachineLearning { get; set; }
        }

        public class AllowAction
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-allowaction.html#cfn-wafv2-webacl-allowaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class AndStatement
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-andstatement.html#cfn-wafv2-webacl-andstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public List<Statement> Statements { get; set; }
        }

        public class AssociationConfig
        {
            /// <summary>
            /// RequestBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-associationconfig.html#cfn-wafv2-webacl-associationconfig-requestbody
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: RequestBodyAssociatedResourceTypeConfig
            /// </summary>
            public Dictionary<string, RequestBodyAssociatedResourceTypeConfig> RequestBody { get; set; }
        }

        public class BlockAction
        {
            /// <summary>
            /// CustomResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-blockaction.html#cfn-wafv2-webacl-blockaction-customresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomResponse
            /// </summary>
            public CustomResponse CustomResponse { get; set; }
        }

        public class Body
        {
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-body.html#cfn-wafv2-webacl-body-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class ByteMatchStatement
        {
            /// <summary>
            /// SearchStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-searchstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SearchStringBase64 { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositionalConstraint { get; set; }
            /// <summary>
            /// SearchString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-searchstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SearchString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch { get; set; }
        }

        public class CaptchaAction
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-captchaaction.html#cfn-wafv2-webacl-captchaaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class CaptchaConfig
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-captchaconfig.html#cfn-wafv2-webacl-captchaconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public ImmunityTimeProperty ImmunityTimeProperty { get; set; }
        }

        public class ChallengeAction
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-challengeaction.html#cfn-wafv2-webacl-challengeaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class ChallengeConfig
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-challengeconfig.html#cfn-wafv2-webacl-challengeconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public ImmunityTimeProperty ImmunityTimeProperty { get; set; }
        }

        public class CookieMatchPattern
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookiematchpattern.html#cfn-wafv2-webacl-cookiematchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic All { get; set; }
            /// <summary>
            /// IncludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookiematchpattern.html#cfn-wafv2-webacl-cookiematchpattern-includedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedCookies { get; set; }
            /// <summary>
            /// ExcludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookiematchpattern.html#cfn-wafv2-webacl-cookiematchpattern-excludedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedCookies { get; set; }
        }

        public class Cookies
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookies.html#cfn-wafv2-webacl-cookies-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookies.html#cfn-wafv2-webacl-cookies-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookieMatchPattern
            /// </summary>
            public CookieMatchPattern MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookies.html#cfn-wafv2-webacl-cookies-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class CountAction
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-countaction.html#cfn-wafv2-webacl-countaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public CustomRequestHandling CustomRequestHandling { get; set; }
        }

        public class CustomHTTPHeader
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customhttpheader.html#cfn-wafv2-webacl-customhttpheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customhttpheader.html#cfn-wafv2-webacl-customhttpheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CustomRequestHandling
        {
            /// <summary>
            /// InsertHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customrequesthandling.html#cfn-wafv2-webacl-customrequesthandling-insertheaders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public List<CustomHTTPHeader> InsertHeaders { get; set; }
        }

        public class CustomResponse
        {
            /// <summary>
            /// ResponseCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html#cfn-wafv2-webacl-customresponse-responsecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResponseCode { get; set; }
            /// <summary>
            /// CustomResponseBodyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html#cfn-wafv2-webacl-customresponse-customresponsebodykey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomResponseBodyKey { get; set; }
            /// <summary>
            /// ResponseHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html#cfn-wafv2-webacl-customresponse-responseheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public List<CustomHTTPHeader> ResponseHeaders { get; set; }
        }

        public class CustomResponseBody
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponsebody.html#cfn-wafv2-webacl-customresponsebody-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponsebody.html#cfn-wafv2-webacl-customresponsebody-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
        }

        public class DefaultAction
        {
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-defaultaction.html#cfn-wafv2-webacl-defaultaction-block
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockAction
            /// </summary>
            public BlockAction Block { get; set; }
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-defaultaction.html#cfn-wafv2-webacl-defaultaction-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowAction
            /// </summary>
            public AllowAction Allow { get; set; }
        }

        public class ExcludedRule
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-excludedrule.html#cfn-wafv2-webacl-excludedrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FieldIdentifier
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldidentifier.html#cfn-wafv2-webacl-fieldidentifier-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class FieldToMatch
        {
            /// <summary>
            /// JsonBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-jsonbody
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonBody
            /// </summary>
            public JsonBody JsonBody { get; set; }
            /// <summary>
            /// AllQueryArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-allqueryarguments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllQueryArguments { get; set; }
            /// <summary>
            /// JA3Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-ja3fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JA3Fingerprint
            /// </summary>
            public JA3Fingerprint JA3Fingerprint { get; set; }
            /// <summary>
            /// SingleQueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-singlequeryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleQueryArgument
            /// </summary>
            public SingleQueryArgument SingleQueryArgument { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic UriPath { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Headers
            /// </summary>
            public Headers Headers { get; set; }
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cookies
            /// </summary>
            public Cookies Cookies { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Method { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-body
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Body
            /// </summary>
            public Body Body { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public SingleHeader SingleHeader { get; set; }
        }

        public class ForwardedIPConfiguration
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-forwardedipconfiguration.html#cfn-wafv2-webacl-forwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-forwardedipconfiguration.html#cfn-wafv2-webacl-forwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
        }

        public class GeoMatchStatement
        {
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html#cfn-wafv2-webacl-geomatchstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public ForwardedIPConfiguration ForwardedIPConfig { get; set; }
            /// <summary>
            /// CountryCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html#cfn-wafv2-webacl-geomatchstatement-countrycodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CountryCodes { get; set; }
        }

        public class HeaderMatchPattern
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headermatchpattern.html#cfn-wafv2-webacl-headermatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic All { get; set; }
            /// <summary>
            /// IncludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headermatchpattern.html#cfn-wafv2-webacl-headermatchpattern-includedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedHeaders { get; set; }
            /// <summary>
            /// ExcludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headermatchpattern.html#cfn-wafv2-webacl-headermatchpattern-excludedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedHeaders { get; set; }
        }

        public class Headers
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headers.html#cfn-wafv2-webacl-headers-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headers.html#cfn-wafv2-webacl-headers-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeaderMatchPattern
            /// </summary>
            public HeaderMatchPattern MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headers.html#cfn-wafv2-webacl-headers-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class IPSetForwardedIPConfiguration
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html#cfn-wafv2-webacl-ipsetforwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html#cfn-wafv2-webacl-ipsetforwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html#cfn-wafv2-webacl-ipsetforwardedipconfiguration-position
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
        }

        public class IPSetReferenceStatement
        {
            /// <summary>
            /// IPSetForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetreferencestatement.html#cfn-wafv2-webacl-ipsetreferencestatement-ipsetforwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetForwardedIPConfiguration
            /// </summary>
            public IPSetForwardedIPConfiguration IPSetForwardedIPConfig { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetreferencestatement.html#cfn-wafv2-webacl-ipsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class ImmunityTimeProperty
        {
            /// <summary>
            /// ImmunityTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-immunitytimeproperty.html#cfn-wafv2-webacl-immunitytimeproperty-immunitytime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ImmunityTime { get; set; }
        }

        public class JA3Fingerprint
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ja3fingerprint.html#cfn-wafv2-webacl-ja3fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FallbackBehavior { get; set; }
        }

        public class JsonBody
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: JsonMatchPattern
            /// </summary>
            public JsonMatchPattern MatchPattern { get; set; }
            /// <summary>
            /// InvalidFallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-invalidfallbackbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvalidFallbackBehavior { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OversizeHandling { get; set; }
        }

        public class JsonMatchPattern
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonmatchpattern.html#cfn-wafv2-webacl-jsonmatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic All { get; set; }
            /// <summary>
            /// IncludedPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonmatchpattern.html#cfn-wafv2-webacl-jsonmatchpattern-includedpaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedPaths { get; set; }
        }

        public class Label
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-label.html#cfn-wafv2-webacl-label-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LabelMatchStatement
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-labelmatchstatement.html#cfn-wafv2-webacl-labelmatchstatement-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-labelmatchstatement.html#cfn-wafv2-webacl-labelmatchstatement-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ManagedRuleGroupConfig
        {
            /// <summary>
            /// UsernameField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-usernamefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier UsernameField { get; set; }
            /// <summary>
            /// LoginPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-loginpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoginPath { get; set; }
            /// <summary>
            /// AWSManagedRulesATPRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesatpruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesATPRuleSet
            /// </summary>
            public AWSManagedRulesATPRuleSet AWSManagedRulesATPRuleSet { get; set; }
            /// <summary>
            /// AWSManagedRulesBotControlRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesbotcontrolruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesBotControlRuleSet
            /// </summary>
            public AWSManagedRulesBotControlRuleSet AWSManagedRulesBotControlRuleSet { get; set; }
            /// <summary>
            /// PasswordField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-passwordfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier PasswordField { get; set; }
            /// <summary>
            /// AWSManagedRulesACFPRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesacfpruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesACFPRuleSet
            /// </summary>
            public AWSManagedRulesACFPRuleSet AWSManagedRulesACFPRuleSet { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-payloadtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadType { get; set; }
        }

        public class ManagedRuleGroupStatement
        {
            /// <summary>
            /// VendorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-vendorname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VendorName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// RuleActionOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-ruleactionoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleActionOverride
            /// </summary>
            public List<RuleActionOverride> RuleActionOverrides { get; set; }
            /// <summary>
            /// ManagedRuleGroupConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-managedrulegroupconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedRuleGroupConfig
            /// </summary>
            public List<ManagedRuleGroupConfig> ManagedRuleGroupConfigs { get; set; }
            /// <summary>
            /// ExcludedRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-excludedrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExcludedRule
            /// </summary>
            public List<ExcludedRule> ExcludedRules { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ScopeDownStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-scopedownstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Statement ScopeDownStatement { get; set; }
        }

        public class NotStatement
        {
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-notstatement.html#cfn-wafv2-webacl-notstatement-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Statement Statement { get; set; }
        }

        public class OrStatement
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-orstatement.html#cfn-wafv2-webacl-orstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public List<Statement> Statements { get; set; }
        }

        public class OverrideAction
        {
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-overrideaction.html#cfn-wafv2-webacl-overrideaction-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Count { get; set; }
            /// <summary>
            /// None
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-overrideaction.html#cfn-wafv2-webacl-overrideaction-none
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic None { get; set; }
        }

        public class RateBasedStatement
        {
            /// <summary>
            /// AggregateKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-aggregatekeytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregateKeyType { get; set; }
            /// <summary>
            /// CustomKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-customkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateBasedStatementCustomKey
            /// </summary>
            public List<RateBasedStatementCustomKey> CustomKeys { get; set; }
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public ForwardedIPConfiguration ForwardedIPConfig { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-limit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Limit { get; set; }
            /// <summary>
            /// EvaluationWindowSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-evaluationwindowsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EvaluationWindowSec { get; set; }
            /// <summary>
            /// ScopeDownStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-scopedownstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Statement ScopeDownStatement { get; set; }
        }

        public class RateBasedStatementCustomKey
        {
            /// <summary>
            /// Cookie
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-cookie
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitCookie
            /// </summary>
            public RateLimitCookie Cookie { get; set; }
            /// <summary>
            /// ForwardedIP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-forwardedip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ForwardedIP { get; set; }
            /// <summary>
            /// QueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-queryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryArgument
            /// </summary>
            public RateLimitQueryArgument QueryArgument { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitHeader
            /// </summary>
            public RateLimitHeader Header { get; set; }
            /// <summary>
            /// HTTPMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic HTTPMethod { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryString
            /// </summary>
            public RateLimitQueryString QueryString { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitUriPath
            /// </summary>
            public RateLimitUriPath UriPath { get; set; }
            /// <summary>
            /// IP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic IP { get; set; }
            /// <summary>
            /// LabelNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-labelnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitLabelNamespace
            /// </summary>
            public RateLimitLabelNamespace LabelNamespace { get; set; }
        }

        public class RateLimitCookie
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitcookie.html#cfn-wafv2-webacl-ratelimitcookie-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitcookie.html#cfn-wafv2-webacl-ratelimitcookie-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RateLimitHeader
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitheader.html#cfn-wafv2-webacl-ratelimitheader-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitheader.html#cfn-wafv2-webacl-ratelimitheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RateLimitLabelNamespace
        {
            /// <summary>
            /// Namespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitlabelnamespace.html#cfn-wafv2-webacl-ratelimitlabelnamespace-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace { get; set; }
        }

        public class RateLimitQueryArgument
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitqueryargument.html#cfn-wafv2-webacl-ratelimitqueryargument-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitqueryargument.html#cfn-wafv2-webacl-ratelimitqueryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RateLimitQueryString
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitquerystring.html#cfn-wafv2-webacl-ratelimitquerystring-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
        }

        public class RateLimitUriPath
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimituripath.html#cfn-wafv2-webacl-ratelimituripath-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
        }

        public class RegexMatchStatement
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// RegexString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-regexstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegexString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch { get; set; }
        }

        public class RegexPatternSetReferenceStatement
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch { get; set; }
        }

        public class RequestBodyAssociatedResourceTypeConfig
        {
            /// <summary>
            /// DefaultSizeInspectionLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestbodyassociatedresourcetypeconfig.html#cfn-wafv2-webacl-requestbodyassociatedresourcetypeconfig-defaultsizeinspectionlimit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultSizeInspectionLimit { get; set; }
        }

        public class RequestInspection
        {
            /// <summary>
            /// UsernameField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspection.html#cfn-wafv2-webacl-requestinspection-usernamefield
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier UsernameField { get; set; }
            /// <summary>
            /// PasswordField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspection.html#cfn-wafv2-webacl-requestinspection-passwordfield
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier PasswordField { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspection.html#cfn-wafv2-webacl-requestinspection-payloadtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadType { get; set; }
        }

        public class RequestInspectionACFP
        {
            /// <summary>
            /// UsernameField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-usernamefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier UsernameField { get; set; }
            /// <summary>
            /// EmailField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-emailfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier EmailField { get; set; }
            /// <summary>
            /// PasswordField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-passwordfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public FieldIdentifier PasswordField { get; set; }
            /// <summary>
            /// AddressFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-addressfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldIdentifier
            /// </summary>
            public List<FieldIdentifier> AddressFields { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-payloadtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadType { get; set; }
            /// <summary>
            /// PhoneNumberFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-phonenumberfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldIdentifier
            /// </summary>
            public List<FieldIdentifier> PhoneNumberFields { get; set; }
        }

        public class ResponseInspection
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionHeader
            /// </summary>
            public ResponseInspectionHeader Header { get; set; }
            /// <summary>
            /// BodyContains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-bodycontains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionBodyContains
            /// </summary>
            public ResponseInspectionBodyContains BodyContains { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionJson
            /// </summary>
            public ResponseInspectionJson Json { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-statuscode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionStatusCode
            /// </summary>
            public ResponseInspectionStatusCode StatusCode { get; set; }
        }

        public class ResponseInspectionBodyContains
        {
            /// <summary>
            /// SuccessStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionbodycontains.html#cfn-wafv2-webacl-responseinspectionbodycontains-successstrings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SuccessStrings { get; set; }
            /// <summary>
            /// FailureStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionbodycontains.html#cfn-wafv2-webacl-responseinspectionbodycontains-failurestrings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FailureStrings { get; set; }
        }

        public class ResponseInspectionHeader
        {
            /// <summary>
            /// SuccessValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionheader.html#cfn-wafv2-webacl-responseinspectionheader-successvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SuccessValues { get; set; }
            /// <summary>
            /// FailureValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionheader.html#cfn-wafv2-webacl-responseinspectionheader-failurevalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FailureValues { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionheader.html#cfn-wafv2-webacl-responseinspectionheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ResponseInspectionJson
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionjson.html#cfn-wafv2-webacl-responseinspectionjson-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
            /// <summary>
            /// SuccessValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionjson.html#cfn-wafv2-webacl-responseinspectionjson-successvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SuccessValues { get; set; }
            /// <summary>
            /// FailureValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionjson.html#cfn-wafv2-webacl-responseinspectionjson-failurevalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FailureValues { get; set; }
        }

        public class ResponseInspectionStatusCode
        {
            /// <summary>
            /// SuccessCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionstatuscode.html#cfn-wafv2-webacl-responseinspectionstatuscode-successcodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> SuccessCodes { get; set; }
            /// <summary>
            /// FailureCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionstatuscode.html#cfn-wafv2-webacl-responseinspectionstatuscode-failurecodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> FailureCodes { get; set; }
        }

        public class Rule
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleAction
            /// </summary>
            public RuleAction Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Statement Statement { get; set; }
            /// <summary>
            /// ChallengeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-challengeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeConfig
            /// </summary>
            public ChallengeConfig ChallengeConfig { get; set; }
            /// <summary>
            /// OverrideAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-overrideaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideAction
            /// </summary>
            public OverrideAction OverrideAction { get; set; }
            /// <summary>
            /// RuleLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-rulelabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Label
            /// </summary>
            public List<Label> RuleLabels { get; set; }
            /// <summary>
            /// VisibilityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-visibilityconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VisibilityConfig
            /// </summary>
            public VisibilityConfig VisibilityConfig { get; set; }
            /// <summary>
            /// CaptchaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-captchaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaConfig
            /// </summary>
            public CaptchaConfig CaptchaConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RuleAction
        {
            /// <summary>
            /// Captcha
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-captcha
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaAction
            /// </summary>
            public CaptchaAction Captcha { get; set; }
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-block
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockAction
            /// </summary>
            public BlockAction Block { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-count
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CountAction
            /// </summary>
            public CountAction Count { get; set; }
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowAction
            /// </summary>
            public AllowAction Allow { get; set; }
            /// <summary>
            /// Challenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-challenge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeAction
            /// </summary>
            public ChallengeAction Challenge { get; set; }
        }

        public class RuleActionOverride
        {
            /// <summary>
            /// ActionToUse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleactionoverride.html#cfn-wafv2-webacl-ruleactionoverride-actiontouse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleAction
            /// </summary>
            public RuleAction ActionToUse { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleactionoverride.html#cfn-wafv2-webacl-ruleactionoverride-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RuleGroupReferenceStatement
        {
            /// <summary>
            /// RuleActionOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html#cfn-wafv2-webacl-rulegroupreferencestatement-ruleactionoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleActionOverride
            /// </summary>
            public List<RuleActionOverride> RuleActionOverrides { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html#cfn-wafv2-webacl-rulegroupreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// ExcludedRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html#cfn-wafv2-webacl-rulegroupreferencestatement-excludedrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExcludedRule
            /// </summary>
            public List<ExcludedRule> ExcludedRules { get; set; }
        }

        public class SingleHeader
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-singleheader.html#cfn-wafv2-webacl-singleheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SingleQueryArgument
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-singlequeryargument.html#cfn-wafv2-webacl-singlequeryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SizeConstraintStatement
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Size { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch { get; set; }
        }

        public class SqliMatchStatement
        {
            /// <summary>
            /// SensitivityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-sensitivitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SensitivityLevel { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch { get; set; }
        }

        public class Statement
        {
            /// <summary>
            /// SizeConstraintStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-sizeconstraintstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SizeConstraintStatement
            /// </summary>
            public SizeConstraintStatement SizeConstraintStatement { get; set; }
            /// <summary>
            /// AndStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-andstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndStatement
            /// </summary>
            public AndStatement AndStatement { get; set; }
            /// <summary>
            /// XssMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-xssmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: XssMatchStatement
            /// </summary>
            public XssMatchStatement XssMatchStatement { get; set; }
            /// <summary>
            /// NotStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-notstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotStatement
            /// </summary>
            public NotStatement NotStatement { get; set; }
            /// <summary>
            /// ByteMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-bytematchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ByteMatchStatement
            /// </summary>
            public ByteMatchStatement ByteMatchStatement { get; set; }
            /// <summary>
            /// RateBasedStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-ratebasedstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateBasedStatement
            /// </summary>
            public RateBasedStatement RateBasedStatement { get; set; }
            /// <summary>
            /// GeoMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-geomatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoMatchStatement
            /// </summary>
            public GeoMatchStatement GeoMatchStatement { get; set; }
            /// <summary>
            /// RuleGroupReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-rulegroupreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleGroupReferenceStatement
            /// </summary>
            public RuleGroupReferenceStatement RuleGroupReferenceStatement { get; set; }
            /// <summary>
            /// LabelMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-labelmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelMatchStatement
            /// </summary>
            public LabelMatchStatement LabelMatchStatement { get; set; }
            /// <summary>
            /// RegexMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-regexmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexMatchStatement
            /// </summary>
            public RegexMatchStatement RegexMatchStatement { get; set; }
            /// <summary>
            /// SqliMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-sqlimatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqliMatchStatement
            /// </summary>
            public SqliMatchStatement SqliMatchStatement { get; set; }
            /// <summary>
            /// RegexPatternSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-regexpatternsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexPatternSetReferenceStatement
            /// </summary>
            public RegexPatternSetReferenceStatement RegexPatternSetReferenceStatement { get; set; }
            /// <summary>
            /// OrStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-orstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrStatement
            /// </summary>
            public OrStatement OrStatement { get; set; }
            /// <summary>
            /// ManagedRuleGroupStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-managedrulegroupstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedRuleGroupStatement
            /// </summary>
            public ManagedRuleGroupStatement ManagedRuleGroupStatement { get; set; }
            /// <summary>
            /// IPSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-ipsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetReferenceStatement
            /// </summary>
            public IPSetReferenceStatement IPSetReferenceStatement { get; set; }
        }

        public class TextTransformation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-texttransformation.html#cfn-wafv2-webacl-texttransformation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-texttransformation.html#cfn-wafv2-webacl-texttransformation-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
        }

        public class VisibilityConfig
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html#cfn-wafv2-webacl-visibilityconfig-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// SampledRequestsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html#cfn-wafv2-webacl-visibilityconfig-sampledrequestsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SampledRequestsEnabled { get; set; }
            /// <summary>
            /// CloudWatchMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html#cfn-wafv2-webacl-visibilityconfig-cloudwatchmetricsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CloudWatchMetricsEnabled { get; set; }
        }

        public class XssMatchStatement
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-xssmatchstatement.html#cfn-wafv2-webacl-xssmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public List<TextTransformation> TextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-xssmatchstatement.html#cfn-wafv2-webacl-xssmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch { get; set; }
        }
    }
}