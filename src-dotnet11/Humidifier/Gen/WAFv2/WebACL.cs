namespace Humidifier.WAFv2
{
    using global::System.Collections.Generic;
    using WebACLTypes;

    public class WebACL : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveWAFv2WebACLTypesAssociationConfigAssociationConfig, IHaveWAFv2WebACLTypesChallengeConfigChallengeConfig, IHaveWAFv2WebACLTypesDataProtectionConfigDataProtectionConfig, IHaveWAFv2WebACLTypesMonetizationConfigMonetizationConfig, IHaveWAFv2WebACLTypesOnSourceDDoSProtectionConfigOnSourceDDoSProtectionConfig, IHaveListOfWAFv2WebACLTypesRuleRules, IHaveWAFv2WebACLTypesVisibilityConfigVisibilityConfig, IHaveName, IHaveStringListOfTokenDomains, IHaveWAFv2WebACLTypesDefaultActionDefaultAction, IHaveScope, IHaveWAFv2WebACLTypesApplicationConfigApplicationConfig, IHaveMapOfWAFv2WebACLTypesCustomResponseBodyCustomResponseBodies, IHaveWAFv2WebACLTypesCaptchaConfigCaptchaConfig
    {
        public class Attributes
        {
            public static string Capacity =  "Capacity" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string LabelNamespace =  "LabelNamespace" ;
        }

        public override string AWSTypeName { get => AWS.WAFv2.WebACL; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AssociationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-associationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AssociationConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.AssociationConfig, BaseFunction>? AssociationConfig { get; set; }
        /// <summary>
        /// ChallengeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-challengeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChallengeConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.ChallengeConfig, BaseFunction>? ChallengeConfig { get; set; }
        /// <summary>
        /// DataProtectionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-dataprotectionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataProtectionConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.DataProtectionConfig, BaseFunction>? DataProtectionConfig { get; set; }
        /// <summary>
        /// MonetizationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-monetizationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MonetizationConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.MonetizationConfig, BaseFunction>? MonetizationConfig { get; set; }
        /// <summary>
        /// OnSourceDDoSProtectionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-onsourceddosprotectionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnSourceDDoSProtectionConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.OnSourceDDoSProtectionConfig, BaseFunction>? OnSourceDDoSProtectionConfig { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.Rule>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }

        /// <summary>
        /// VisibilityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-visibilityconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VisibilityConfig
        /// </summary>
        [Required]
        public Union<Humidifier.WAFv2.WebACLTypes.VisibilityConfig, BaseFunction>? VisibilityConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TokenDomains
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-tokendomains
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TokenDomains { get; set; }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DefaultAction
        /// </summary>
        [Required]
        public Union<Humidifier.WAFv2.WebACLTypes.DefaultAction, BaseFunction>? DefaultAction { get; set; }

        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Scope { get; set; }
        /// <summary>
        /// ApplicationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-applicationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.ApplicationConfig, BaseFunction>? ApplicationConfig { get; set; }
        /// <summary>
        /// CustomResponseBodies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-customresponsebodies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: CustomResponseBody
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.WAFv2.WebACLTypes.CustomResponseBody>, IReadOnlyDictionary<string, Union<Humidifier.WAFv2.WebACLTypes.CustomResponseBody, BaseFunction>>, BaseFunction>? CustomResponseBodies { get; set; }
        /// <summary>
        /// CaptchaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-captchaconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CaptchaConfig
        /// </summary>
        public Union<Humidifier.WAFv2.WebACLTypes.CaptchaConfig, BaseFunction>? CaptchaConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html#cfn-wafv2-webacl-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WebACLTypes
    {
        public class AWSManagedRulesACFPRuleSet : Humidifier.Base.BaseSubResource, IHaveRegistrationPagePath, IHaveWAFv2WebACLTypesResponseInspectionResponseInspection, IHaveCreationPath, IHaveEnableRegexInPath_Boolean, IHaveWAFv2WebACLTypesRequestInspectionACFPRequestInspection
        {
            /// <summary>
            /// RegistrationPagePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-registrationpagepath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistrationPagePath { get; set; }
            /// <summary>
            /// ResponseInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-responseinspection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspection
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ResponseInspection, BaseFunction>? ResponseInspection { get; set; }
            /// <summary>
            /// CreationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-creationpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreationPath { get; set; }
            /// <summary>
            /// EnableRegexInPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-enableregexinpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableRegexInPath { get; set; }
            /// <summary>
            /// RequestInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesacfpruleset.html#cfn-wafv2-webacl-awsmanagedrulesacfpruleset-requestinspection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RequestInspectionACFP
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RequestInspectionACFP, BaseFunction>? RequestInspection { get; set; }
        }

        public class AWSManagedRulesATPRuleSet : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesResponseInspectionResponseInspection, IHaveEnableRegexInPath_Boolean, IHaveLoginPath, IHaveWAFv2WebACLTypesRequestInspectionRequestInspection
        {
            /// <summary>
            /// ResponseInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-responseinspection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspection
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ResponseInspection, BaseFunction>? ResponseInspection { get; set; }
            /// <summary>
            /// EnableRegexInPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-enableregexinpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableRegexInPath { get; set; }
            /// <summary>
            /// LoginPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-loginpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoginPath { get; set; }
            /// <summary>
            /// RequestInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesatpruleset.html#cfn-wafv2-webacl-awsmanagedrulesatpruleset-requestinspection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RequestInspection
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RequestInspection, BaseFunction>? RequestInspection { get; set; }
        }

        public class AWSManagedRulesAntiDDoSRuleSet : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesClientSideActionConfigClientSideActionConfig, IHaveSensitivityToBlock
        {
            /// <summary>
            /// ClientSideActionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesantiddosruleset.html#cfn-wafv2-webacl-awsmanagedrulesantiddosruleset-clientsideactionconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClientSideActionConfig
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ClientSideActionConfig, BaseFunction>? ClientSideActionConfig { get; set; }
            /// <summary>
            /// SensitivityToBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesantiddosruleset.html#cfn-wafv2-webacl-awsmanagedrulesantiddosruleset-sensitivitytoblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SensitivityToBlock { get; set; }
        }

        public class AWSManagedRulesBotControlRuleSet : Humidifier.Base.BaseSubResource, IHaveInspectionLevel, IHaveEnableMachineLearning_Boolean
        {
            /// <summary>
            /// InspectionLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesbotcontrolruleset.html#cfn-wafv2-webacl-awsmanagedrulesbotcontrolruleset-inspectionlevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InspectionLevel { get; set; }
            /// <summary>
            /// EnableMachineLearning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-awsmanagedrulesbotcontrolruleset.html#cfn-wafv2-webacl-awsmanagedrulesbotcontrolruleset-enablemachinelearning
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableMachineLearning { get; set; }
        }

        public class AllowAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-allowaction.html#cfn-wafv2-webacl-allowaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class AndStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesStatementStatements
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-andstatement.html#cfn-wafv2-webacl-andstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.Statement>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.Statement, BaseFunction>>, BaseFunction>? Statements { get; set; }
        }

        public class ApplicationAttribute : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-applicationattribute.html#cfn-wafv2-webacl-applicationattribute-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-applicationattribute.html#cfn-wafv2-webacl-applicationattribute-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ApplicationConfig : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesApplicationAttributeAttributes_
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-applicationconfig.html#cfn-wafv2-webacl-applicationconfig-attributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.ApplicationAttribute>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.ApplicationAttribute, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }

        public class AsnMatchStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesForwardedIPConfigurationForwardedIPConfig, IHaveIntegerListOfAsnList
        {
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-asnmatchstatement.html#cfn-wafv2-webacl-asnmatchstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration, BaseFunction>? ForwardedIPConfig { get; set; }
            /// <summary>
            /// AsnList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-asnmatchstatement.html#cfn-wafv2-webacl-asnmatchstatement-asnlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? AsnList { get; set; }
        }

        public class AssociationConfig : Humidifier.Base.BaseSubResource, IHaveMapOfWAFv2WebACLTypesRequestBodyAssociatedResourceTypeConfigRequestBody
        {
            /// <summary>
            /// RequestBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-associationconfig.html#cfn-wafv2-webacl-associationconfig-requestbody
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: RequestBodyAssociatedResourceTypeConfig
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.WAFv2.WebACLTypes.RequestBodyAssociatedResourceTypeConfig>, IReadOnlyDictionary<string, Union<Humidifier.WAFv2.WebACLTypes.RequestBodyAssociatedResourceTypeConfig, BaseFunction>>, BaseFunction>? RequestBody { get; set; }
        }

        public class BlockAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesCustomResponseCustomResponse
        {
            /// <summary>
            /// CustomResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-blockaction.html#cfn-wafv2-webacl-blockaction-customresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomResponse
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CustomResponse, BaseFunction>? CustomResponse { get; set; }
        }

        public class Body : Humidifier.Base.BaseSubResource, IHaveOversizeHandling
        {
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-body.html#cfn-wafv2-webacl-body-oversizehandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class ByteMatchStatement : Humidifier.Base.BaseSubResource, IHaveSearchStringBase64, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveListOfWAFv2WebACLTypesPreParseTextTransformationPreParseTextTransformations, IHavePositionalConstraint, IHaveSearchString, IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// SearchStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-searchstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchStringBase64 { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PositionalConstraint { get; set; }
            /// <summary>
            /// SearchString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-searchstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html#cfn-wafv2-webacl-bytematchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class CaptchaAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-captchaaction.html#cfn-wafv2-webacl-captchaaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class CaptchaConfig : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesImmunityTimePropertyImmunityTimeProperty
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-captchaconfig.html#cfn-wafv2-webacl-captchaconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty, BaseFunction>? ImmunityTimeProperty { get; set; }
        }

        public class ChallengeAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-challengeaction.html#cfn-wafv2-webacl-challengeaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class ChallengeConfig : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesImmunityTimePropertyImmunityTimeProperty
        {
            /// <summary>
            /// ImmunityTimeProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-challengeconfig.html#cfn-wafv2-webacl-challengeconfig-immunitytimeproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImmunityTimeProperty
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty, BaseFunction>? ImmunityTimeProperty { get; set; }
        }

        public class ClientSideAction : Humidifier.Base.BaseSubResource, IHaveUsageOfAction, IHaveSensitivity, IHaveListOfWAFv2WebACLTypesRegexExemptUriRegularExpressions
        {
            /// <summary>
            /// UsageOfAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-clientsideaction.html#cfn-wafv2-webacl-clientsideaction-usageofaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageOfAction { get; set; }
            /// <summary>
            /// Sensitivity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-clientsideaction.html#cfn-wafv2-webacl-clientsideaction-sensitivity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sensitivity { get; set; }
            /// <summary>
            /// ExemptUriRegularExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-clientsideaction.html#cfn-wafv2-webacl-clientsideaction-exempturiregularexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Regex
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.Regex>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.Regex, BaseFunction>>, BaseFunction>? ExemptUriRegularExpressions { get; set; }
        }

        public class ClientSideActionConfig : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesClientSideActionChallenge
        {
            /// <summary>
            /// Challenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-clientsideactionconfig.html#cfn-wafv2-webacl-clientsideactionconfig-challenge
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClientSideAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ClientSideAction, BaseFunction>? Challenge { get; set; }
        }

        public class CookieMatchPattern : Humidifier.Base.BaseSubResource, IHaveAll_Json, IHaveStringListOfIncludedCookies, IHaveStringListOfExcludedCookies
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookiematchpattern.html#cfn-wafv2-webacl-cookiematchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// IncludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookiematchpattern.html#cfn-wafv2-webacl-cookiematchpattern-includedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedCookies { get; set; }
            /// <summary>
            /// ExcludedCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookiematchpattern.html#cfn-wafv2-webacl-cookiematchpattern-excludedcookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedCookies { get; set; }
        }

        public class Cookies : Humidifier.Base.BaseSubResource, IHaveMatchScope, IHaveWAFv2WebACLTypesCookieMatchPatternMatchPattern, IHaveOversizeHandling
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookies.html#cfn-wafv2-webacl-cookies-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookies.html#cfn-wafv2-webacl-cookies-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CookieMatchPattern
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern, BaseFunction>? MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cookies.html#cfn-wafv2-webacl-cookies-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class CountAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesCustomRequestHandlingCustomRequestHandling
        {
            /// <summary>
            /// CustomRequestHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-countaction.html#cfn-wafv2-webacl-countaction-customrequesthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomRequestHandling
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling, BaseFunction>? CustomRequestHandling { get; set; }
        }

        public class CryptoConfig : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesPaymentNetworkPaymentNetworks
        {
            /// <summary>
            /// PaymentNetworks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-cryptoconfig.html#cfn-wafv2-webacl-cryptoconfig-paymentnetworks
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PaymentNetwork
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PaymentNetwork>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PaymentNetwork, BaseFunction>>, BaseFunction>? PaymentNetworks { get; set; }
        }

        public class CustomHTTPHeader : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customhttpheader.html#cfn-wafv2-webacl-customhttpheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customhttpheader.html#cfn-wafv2-webacl-customhttpheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CustomRequestHandling : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesCustomHTTPHeaderInsertHeaders
        {
            /// <summary>
            /// InsertHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customrequesthandling.html#cfn-wafv2-webacl-customrequesthandling-insertheaders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.CustomHTTPHeader>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.CustomHTTPHeader, BaseFunction>>, BaseFunction>? InsertHeaders { get; set; }
        }

        public class CustomResponse : Humidifier.Base.BaseSubResource, IHaveResponseCode_Integer, IHaveCustomResponseBodyKey, IHaveListOfWAFv2WebACLTypesCustomHTTPHeaderResponseHeaders
        {
            /// <summary>
            /// ResponseCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html#cfn-wafv2-webacl-customresponse-responsecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResponseCode { get; set; }
            /// <summary>
            /// CustomResponseBodyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html#cfn-wafv2-webacl-customresponse-customresponsebodykey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomResponseBodyKey { get; set; }
            /// <summary>
            /// ResponseHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html#cfn-wafv2-webacl-customresponse-responseheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomHTTPHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.CustomHTTPHeader>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.CustomHTTPHeader, BaseFunction>>, BaseFunction>? ResponseHeaders { get; set; }
        }

        public class CustomResponseBody : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContent
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponsebody.html#cfn-wafv2-webacl-customresponsebody-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponsebody.html#cfn-wafv2-webacl-customresponsebody-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
        }

        public class DataProtect : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesFieldToProtectField, IHaveAction, IHaveExcludeRateBasedDetails_Boolean, IHaveExcludeRuleMatchDetails_Boolean
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-dataprotect.html#cfn-wafv2-webacl-dataprotect-field
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToProtect
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToProtect, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-dataprotect.html#cfn-wafv2-webacl-dataprotect-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ExcludeRateBasedDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-dataprotect.html#cfn-wafv2-webacl-dataprotect-excluderatebaseddetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExcludeRateBasedDetails { get; set; }
            /// <summary>
            /// ExcludeRuleMatchDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-dataprotect.html#cfn-wafv2-webacl-dataprotect-excluderulematchdetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExcludeRuleMatchDetails { get; set; }
        }

        public class DataProtectionConfig : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesDataProtectDataProtections
        {
            /// <summary>
            /// DataProtections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-dataprotectionconfig.html#cfn-wafv2-webacl-dataprotectionconfig-dataprotections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataProtect
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.DataProtect>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.DataProtect, BaseFunction>>, BaseFunction>? DataProtections { get; set; }
        }

        public class DefaultAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesBlockActionBlock, IHaveWAFv2WebACLTypesAllowActionAllow
        {
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-defaultaction.html#cfn-wafv2-webacl-defaultaction-block
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.BlockAction, BaseFunction>? Block { get; set; }
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-defaultaction.html#cfn-wafv2-webacl-defaultaction-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AllowAction, BaseFunction>? Allow { get; set; }
        }

        public class ExcludedRule : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-excludedrule.html#cfn-wafv2-webacl-excludedrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FieldIdentifier : Humidifier.Base.BaseSubResource, IHaveIdentifier
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldidentifier.html#cfn-wafv2-webacl-fieldidentifier-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveAllQueryArguments_Json, IHaveWAFv2WebACLTypesJA3FingerprintJA3Fingerprint, IHaveWAFv2WebACLTypesSingleQueryArgumentSingleQueryArgument, IHaveQueryString_Json, IHaveWAFv2WebACLTypesHeadersHeaders, IHaveMethod_Json, IHaveWAFv2WebACLTypesUriFragmentUriFragment, IHaveWAFv2WebACLTypesJsonBodyJsonBody, IHaveUriPath_Json, IHaveWAFv2WebACLTypesCookiesCookies, IHaveWAFv2WebACLTypesJA4FingerprintJA4Fingerprint, IHaveWAFv2WebACLTypesHeaderOrderHeaderOrder, IHaveWAFv2WebACLTypesBodyBody, IHaveWAFv2WebACLTypesSingleHeaderSingleHeader
        {
            /// <summary>
            /// AllQueryArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-allqueryarguments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllQueryArguments { get; set; }
            /// <summary>
            /// JA3Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-ja3fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JA3Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.JA3Fingerprint, BaseFunction>? JA3Fingerprint { get; set; }
            /// <summary>
            /// SingleQueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-singlequeryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleQueryArgument
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.SingleQueryArgument, BaseFunction>? SingleQueryArgument { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Headers
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Headers, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Method { get; set; }
            /// <summary>
            /// UriFragment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-urifragment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UriFragment
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.UriFragment, BaseFunction>? UriFragment { get; set; }
            /// <summary>
            /// JsonBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-jsonbody
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonBody
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.JsonBody, BaseFunction>? JsonBody { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cookies
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Cookies, BaseFunction>? Cookies { get; set; }
            /// <summary>
            /// JA4Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-ja4fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JA4Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.JA4Fingerprint, BaseFunction>? JA4Fingerprint { get; set; }
            /// <summary>
            /// HeaderOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-headerorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderOrder
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.HeaderOrder, BaseFunction>? HeaderOrder { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-body
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Body
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Body, BaseFunction>? Body { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtomatch.html#cfn-wafv2-webacl-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.SingleHeader, BaseFunction>? SingleHeader { get; set; }
        }

        public class FieldToProtect : Humidifier.Base.BaseSubResource, IHaveStringListOfFieldKeys, IHaveFieldType
        {
            /// <summary>
            /// FieldKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtoprotect.html#cfn-wafv2-webacl-fieldtoprotect-fieldkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FieldKeys { get; set; }
            /// <summary>
            /// FieldType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-fieldtoprotect.html#cfn-wafv2-webacl-fieldtoprotect-fieldtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldType { get; set; }
        }

        public class ForwardedIPConfiguration : Humidifier.Base.BaseSubResource, IHaveFallbackBehavior, IHaveHeaderName
        {
            /// <summary>
            /// FallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-forwardedipconfiguration.html#cfn-wafv2-webacl-forwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-forwardedipconfiguration.html#cfn-wafv2-webacl-forwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
        }

        public class GeoMatchStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesForwardedIPConfigurationForwardedIPConfig, IHaveStringListOfCountryCodes
        {
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html#cfn-wafv2-webacl-geomatchstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration, BaseFunction>? ForwardedIPConfig { get; set; }
            /// <summary>
            /// CountryCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html#cfn-wafv2-webacl-geomatchstatement-countrycodes
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headermatchpattern.html#cfn-wafv2-webacl-headermatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// IncludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headermatchpattern.html#cfn-wafv2-webacl-headermatchpattern-includedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedHeaders { get; set; }
            /// <summary>
            /// ExcludedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headermatchpattern.html#cfn-wafv2-webacl-headermatchpattern-excludedheaders
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headerorder.html#cfn-wafv2-webacl-headerorder-oversizehandling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OversizeHandling { get; set; }
        }

        public class Headers : Humidifier.Base.BaseSubResource, IHaveMatchScope, IHaveWAFv2WebACLTypesHeaderMatchPatternMatchPattern, IHaveOversizeHandling
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headers.html#cfn-wafv2-webacl-headers-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headers.html#cfn-wafv2-webacl-headers-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HeaderMatchPattern
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern, BaseFunction>? MatchPattern { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-headers.html#cfn-wafv2-webacl-headers-oversizehandling
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html#cfn-wafv2-webacl-ipsetforwardedipconfiguration-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html#cfn-wafv2-webacl-ipsetforwardedipconfiguration-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetforwardedipconfiguration.html#cfn-wafv2-webacl-ipsetforwardedipconfiguration-position
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Position { get; set; }
        }

        public class IPSetReferenceStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesIPSetForwardedIPConfigurationIPSetForwardedIPConfig, IHaveArn
        {
            /// <summary>
            /// IPSetForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetreferencestatement.html#cfn-wafv2-webacl-ipsetreferencestatement-ipsetforwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration, BaseFunction>? IPSetForwardedIPConfig { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ipsetreferencestatement.html#cfn-wafv2-webacl-ipsetreferencestatement-arn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-immunitytimeproperty.html#cfn-wafv2-webacl-immunitytimeproperty-immunitytime
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ja3fingerprint.html#cfn-wafv2-webacl-ja3fingerprint-fallbackbehavior
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ja4fingerprint.html#cfn-wafv2-webacl-ja4fingerprint-fallbackbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FallbackBehavior { get; set; }
        }

        public class JsonBody : Humidifier.Base.BaseSubResource, IHaveMatchScope, IHaveWAFv2WebACLTypesJsonMatchPatternMatchPattern, IHaveInvalidFallbackBehavior, IHaveOversizeHandling
        {
            /// <summary>
            /// MatchScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-matchscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchScope { get; set; }
            /// <summary>
            /// MatchPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-matchpattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: JsonMatchPattern
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern, BaseFunction>? MatchPattern { get; set; }
            /// <summary>
            /// InvalidFallbackBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-invalidfallbackbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvalidFallbackBehavior { get; set; }
            /// <summary>
            /// OversizeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonbody.html#cfn-wafv2-webacl-jsonbody-oversizehandling
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonmatchpattern.html#cfn-wafv2-webacl-jsonmatchpattern-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// IncludedPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-jsonmatchpattern.html#cfn-wafv2-webacl-jsonmatchpattern-includedpaths
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-label.html#cfn-wafv2-webacl-label-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-labelmatchstatement.html#cfn-wafv2-webacl-labelmatchstatement-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-labelmatchstatement.html#cfn-wafv2-webacl-labelmatchstatement-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ManagedRuleGroupConfig : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesAWSManagedRulesAntiDDoSRuleSetAWSManagedRulesAntiDDoSRuleSet, IHaveWAFv2WebACLTypesFieldIdentifierUsernameField, IHaveLoginPath, IHaveWAFv2WebACLTypesAWSManagedRulesATPRuleSetAWSManagedRulesATPRuleSet, IHaveWAFv2WebACLTypesAWSManagedRulesBotControlRuleSetAWSManagedRulesBotControlRuleSet, IHaveWAFv2WebACLTypesFieldIdentifierPasswordField, IHaveWAFv2WebACLTypesAWSManagedRulesACFPRuleSetAWSManagedRulesACFPRuleSet, IHavePayloadType
        {
            /// <summary>
            /// AWSManagedRulesAntiDDoSRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesantiddosruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesAntiDDoSRuleSet
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AWSManagedRulesAntiDDoSRuleSet, BaseFunction>? AWSManagedRulesAntiDDoSRuleSet { get; set; }
            /// <summary>
            /// UsernameField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-usernamefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? UsernameField { get; set; }
            /// <summary>
            /// LoginPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-loginpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoginPath { get; set; }
            /// <summary>
            /// AWSManagedRulesATPRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesatpruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesATPRuleSet
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AWSManagedRulesATPRuleSet, BaseFunction>? AWSManagedRulesATPRuleSet { get; set; }
            /// <summary>
            /// AWSManagedRulesBotControlRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesbotcontrolruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesBotControlRuleSet
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AWSManagedRulesBotControlRuleSet, BaseFunction>? AWSManagedRulesBotControlRuleSet { get; set; }
            /// <summary>
            /// PasswordField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-passwordfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? PasswordField { get; set; }
            /// <summary>
            /// AWSManagedRulesACFPRuleSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-awsmanagedrulesacfpruleset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSManagedRulesACFPRuleSet
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AWSManagedRulesACFPRuleSet, BaseFunction>? AWSManagedRulesACFPRuleSet { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupconfig.html#cfn-wafv2-webacl-managedrulegroupconfig-payloadtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadType { get; set; }
        }

        public class ManagedRuleGroupStatement : Humidifier.Base.BaseSubResource, IHaveVendorName, IHaveVersion, IHaveListOfWAFv2WebACLTypesRuleActionOverrideRuleActionOverrides, IHaveListOfWAFv2WebACLTypesManagedRuleGroupConfigManagedRuleGroupConfigs, IHaveListOfWAFv2WebACLTypesExcludedRuleExcludedRules, IHaveName, IHaveWAFv2WebACLTypesStatementScopeDownStatement
        {
            /// <summary>
            /// VendorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-vendorname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VendorName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// RuleActionOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-ruleactionoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleActionOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.RuleActionOverride>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.RuleActionOverride, BaseFunction>>, BaseFunction>? RuleActionOverrides { get; set; }
            /// <summary>
            /// ManagedRuleGroupConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-managedrulegroupconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedRuleGroupConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupConfig>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupConfig, BaseFunction>>, BaseFunction>? ManagedRuleGroupConfigs { get; set; }
            /// <summary>
            /// ExcludedRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-excludedrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExcludedRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.ExcludedRule>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.ExcludedRule, BaseFunction>>, BaseFunction>? ExcludedRules { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ScopeDownStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-scopedownstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Statement, BaseFunction>? ScopeDownStatement { get; set; }
        }

        public class MonetizationConfig : Humidifier.Base.BaseSubResource, IHaveCurrencyMode, IHaveWAFv2WebACLTypesCryptoConfigCryptoConfig
        {
            /// <summary>
            /// CurrencyMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-monetizationconfig.html#cfn-wafv2-webacl-monetizationconfig-currencymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CurrencyMode { get; set; }
            /// <summary>
            /// CryptoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-monetizationconfig.html#cfn-wafv2-webacl-monetizationconfig-cryptoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CryptoConfig
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CryptoConfig, BaseFunction>? CryptoConfig { get; set; }
        }

        public class MonetizeAction : Humidifier.Base.BaseSubResource, IHavePriceMultiplier
        {
            /// <summary>
            /// PriceMultiplier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-monetizeaction.html#cfn-wafv2-webacl-monetizeaction-pricemultiplier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PriceMultiplier { get; set; }
        }

        public class NotStatement : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesStatementStatement
        {
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-notstatement.html#cfn-wafv2-webacl-notstatement-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Statement, BaseFunction>? Statement { get; set; }
        }

        public class OnSourceDDoSProtectionConfig : Humidifier.Base.BaseSubResource, IHaveALBLowReputationMode
        {
            /// <summary>
            /// ALBLowReputationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-onsourceddosprotectionconfig.html#cfn-wafv2-webacl-onsourceddosprotectionconfig-alblowreputationmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ALBLowReputationMode { get; set; }
        }

        public class OrStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesStatementStatements
        {
            /// <summary>
            /// Statements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-orstatement.html#cfn-wafv2-webacl-orstatement-statements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Statement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.Statement>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.Statement, BaseFunction>>, BaseFunction>? Statements { get; set; }
        }

        public class OverrideAction : Humidifier.Base.BaseSubResource, IHaveCount_Json, IHaveNone_Json
        {
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-overrideaction.html#cfn-wafv2-webacl-overrideaction-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Count { get; set; }
            /// <summary>
            /// None
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-overrideaction.html#cfn-wafv2-webacl-overrideaction-none
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? None { get; set; }
        }

        public class PaymentNetwork : Humidifier.Base.BaseSubResource, IHaveChain, IHaveListOfWAFv2WebACLTypesPricePrices, IHaveWalletAddress
        {
            /// <summary>
            /// Chain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-paymentnetwork.html#cfn-wafv2-webacl-paymentnetwork-chain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Chain { get; set; }
            /// <summary>
            /// Prices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-paymentnetwork.html#cfn-wafv2-webacl-paymentnetwork-prices
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Price
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.Price>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.Price, BaseFunction>>, BaseFunction>? Prices { get; set; }
            /// <summary>
            /// WalletAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-paymentnetwork.html#cfn-wafv2-webacl-paymentnetwork-walletaddress
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-preparsetexttransformation.html#cfn-wafv2-webacl-preparsetexttransformation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-preparsetexttransformation.html#cfn-wafv2-webacl-preparsetexttransformation-priority
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-price.html#cfn-wafv2-webacl-price-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Amount { get; set; }
            /// <summary>
            /// Currency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-price.html#cfn-wafv2-webacl-price-currency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Currency { get; set; }
        }

        public class RateBasedStatement : Humidifier.Base.BaseSubResource, IHaveAggregateKeyType, IHaveListOfWAFv2WebACLTypesRateBasedStatementCustomKeyCustomKeys, IHaveWAFv2WebACLTypesForwardedIPConfigurationForwardedIPConfig, IHaveLimit_Integer, IHaveEvaluationWindowSec_Integer, IHaveWAFv2WebACLTypesStatementScopeDownStatement
        {
            /// <summary>
            /// AggregateKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-aggregatekeytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AggregateKeyType { get; set; }
            /// <summary>
            /// CustomKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-customkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RateBasedStatementCustomKey
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.RateBasedStatementCustomKey>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.RateBasedStatementCustomKey, BaseFunction>>, BaseFunction>? CustomKeys { get; set; }
            /// <summary>
            /// ForwardedIPConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-forwardedipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardedIPConfiguration
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration, BaseFunction>? ForwardedIPConfig { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-limit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Limit { get; set; }
            /// <summary>
            /// EvaluationWindowSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-evaluationwindowsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationWindowSec { get; set; }
            /// <summary>
            /// ScopeDownStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatement.html#cfn-wafv2-webacl-ratebasedstatement-scopedownstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Statement, BaseFunction>? ScopeDownStatement { get; set; }
        }

        public class RateBasedStatementCustomKey : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesRateLimitCookieCookie, IHaveForwardedIP_Json, IHaveWAFv2WebACLTypesRateLimitQueryArgumentQueryArgument, IHaveWAFv2WebACLTypesRateLimitJA3FingerprintJA3Fingerprint, IHaveWAFv2WebACLTypesRateLimitHeaderHeader, IHaveHTTPMethod_Json, IHaveWAFv2WebACLTypesRateLimitQueryStringQueryString, IHaveWAFv2WebACLTypesRateLimitUriPathUriPath, IHaveIP_Json, IHaveWAFv2WebACLTypesRateLimitJA4FingerprintJA4Fingerprint, IHaveASN_Json, IHaveWAFv2WebACLTypesRateLimitLabelNamespaceLabelNamespace
        {
            /// <summary>
            /// Cookie
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-cookie
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitCookie
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitCookie, BaseFunction>? Cookie { get; set; }
            /// <summary>
            /// ForwardedIP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-forwardedip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ForwardedIP { get; set; }
            /// <summary>
            /// QueryArgument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-queryargument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryArgument
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitQueryArgument, BaseFunction>? QueryArgument { get; set; }
            /// <summary>
            /// JA3Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-ja3fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitJA3Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitJA3Fingerprint, BaseFunction>? JA3Fingerprint { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitHeader
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitHeader, BaseFunction>? Header { get; set; }
            /// <summary>
            /// HTTPMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? HTTPMethod { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitQueryString
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitQueryString, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitUriPath
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitUriPath, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// IP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? IP { get; set; }
            /// <summary>
            /// JA4Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-ja4fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitJA4Fingerprint
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitJA4Fingerprint, BaseFunction>? JA4Fingerprint { get; set; }
            /// <summary>
            /// ASN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-asn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ASN { get; set; }
            /// <summary>
            /// LabelNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratebasedstatementcustomkey.html#cfn-wafv2-webacl-ratebasedstatementcustomkey-labelnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateLimitLabelNamespace
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateLimitLabelNamespace, BaseFunction>? LabelNamespace { get; set; }
        }

        public class RateLimitCookie : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveName
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitcookie.html#cfn-wafv2-webacl-ratelimitcookie-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitcookie.html#cfn-wafv2-webacl-ratelimitcookie-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RateLimitHeader : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveName
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitheader.html#cfn-wafv2-webacl-ratelimitheader-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitheader.html#cfn-wafv2-webacl-ratelimitheader-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitja3fingerprint.html#cfn-wafv2-webacl-ratelimitja3fingerprint-fallbackbehavior
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitja4fingerprint.html#cfn-wafv2-webacl-ratelimitja4fingerprint-fallbackbehavior
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitlabelnamespace.html#cfn-wafv2-webacl-ratelimitlabelnamespace-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class RateLimitQueryArgument : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveName
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitqueryargument.html#cfn-wafv2-webacl-ratelimitqueryargument-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitqueryargument.html#cfn-wafv2-webacl-ratelimitqueryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RateLimitQueryString : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimitquerystring.html#cfn-wafv2-webacl-ratelimitquerystring-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
        }

        public class RateLimitUriPath : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ratelimituripath.html#cfn-wafv2-webacl-ratelimituripath-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
        }

        public class Regex : Humidifier.Base.BaseSubResource, IHaveRegexString
        {
            /// <summary>
            /// RegexString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regex.html#cfn-wafv2-webacl-regex-regexstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegexString { get; set; }
        }

        public class RegexMatchStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveListOfWAFv2WebACLTypesPreParseTextTransformationPreParseTextTransformations, IHaveRegexString, IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// RegexString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-regexstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegexString { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexmatchstatement.html#cfn-wafv2-webacl-regexmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class RegexPatternSetReferenceStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveListOfWAFv2WebACLTypesPreParseTextTransformationPreParseTextTransformations, IHaveArn, IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html#cfn-wafv2-webacl-regexpatternsetreferencestatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class RequestBodyAssociatedResourceTypeConfig : Humidifier.Base.BaseSubResource, IHaveDefaultSizeInspectionLimit
        {
            /// <summary>
            /// DefaultSizeInspectionLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestbodyassociatedresourcetypeconfig.html#cfn-wafv2-webacl-requestbodyassociatedresourcetypeconfig-defaultsizeinspectionlimit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultSizeInspectionLimit { get; set; }
        }

        public class RequestInspection : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesFieldIdentifierUsernameField, IHaveWAFv2WebACLTypesFieldIdentifierPasswordField, IHavePayloadType
        {
            /// <summary>
            /// UsernameField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspection.html#cfn-wafv2-webacl-requestinspection-usernamefield
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? UsernameField { get; set; }
            /// <summary>
            /// PasswordField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspection.html#cfn-wafv2-webacl-requestinspection-passwordfield
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? PasswordField { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspection.html#cfn-wafv2-webacl-requestinspection-payloadtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadType { get; set; }
        }

        public class RequestInspectionACFP : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesFieldIdentifierUsernameField, IHaveWAFv2WebACLTypesFieldIdentifierEmailField, IHaveWAFv2WebACLTypesFieldIdentifierPasswordField, IHaveListOfWAFv2WebACLTypesFieldIdentifierAddressFields, IHavePayloadType, IHaveListOfWAFv2WebACLTypesFieldIdentifierPhoneNumberFields
        {
            /// <summary>
            /// UsernameField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-usernamefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? UsernameField { get; set; }
            /// <summary>
            /// EmailField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-emailfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? EmailField { get; set; }
            /// <summary>
            /// PasswordField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-passwordfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldIdentifier
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>? PasswordField { get; set; }
            /// <summary>
            /// AddressFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-addressfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldIdentifier
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.FieldIdentifier>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>>, BaseFunction>? AddressFields { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-payloadtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadType { get; set; }
            /// <summary>
            /// PhoneNumberFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-requestinspectionacfp.html#cfn-wafv2-webacl-requestinspectionacfp-phonenumberfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldIdentifier
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.FieldIdentifier>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.FieldIdentifier, BaseFunction>>, BaseFunction>? PhoneNumberFields { get; set; }
        }

        public class ResponseInspection : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesResponseInspectionJsonJson, IHaveWAFv2WebACLTypesResponseInspectionHeaderHeader, IHaveWAFv2WebACLTypesResponseInspectionStatusCodeStatusCode, IHaveWAFv2WebACLTypesResponseInspectionBodyContainsBodyContains
        {
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionJson
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ResponseInspectionJson, BaseFunction>? Json { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionHeader
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ResponseInspectionHeader, BaseFunction>? Header { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-statuscode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionStatusCode
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ResponseInspectionStatusCode, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// BodyContains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspection.html#cfn-wafv2-webacl-responseinspection-bodycontains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseInspectionBodyContains
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ResponseInspectionBodyContains, BaseFunction>? BodyContains { get; set; }
        }

        public class ResponseInspectionBodyContains : Humidifier.Base.BaseSubResource, IHaveStringListOfSuccessStrings, IHaveStringListOfFailureStrings
        {
            /// <summary>
            /// SuccessStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionbodycontains.html#cfn-wafv2-webacl-responseinspectionbodycontains-successstrings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SuccessStrings { get; set; }
            /// <summary>
            /// FailureStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionbodycontains.html#cfn-wafv2-webacl-responseinspectionbodycontains-failurestrings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FailureStrings { get; set; }
        }

        public class ResponseInspectionHeader : Humidifier.Base.BaseSubResource, IHaveStringListOfSuccessValues, IHaveStringListOfFailureValues, IHaveName
        {
            /// <summary>
            /// SuccessValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionheader.html#cfn-wafv2-webacl-responseinspectionheader-successvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SuccessValues { get; set; }
            /// <summary>
            /// FailureValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionheader.html#cfn-wafv2-webacl-responseinspectionheader-failurevalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FailureValues { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionheader.html#cfn-wafv2-webacl-responseinspectionheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ResponseInspectionJson : Humidifier.Base.BaseSubResource, IHaveIdentifier, IHaveStringListOfSuccessValues, IHaveStringListOfFailureValues
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionjson.html#cfn-wafv2-webacl-responseinspectionjson-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// SuccessValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionjson.html#cfn-wafv2-webacl-responseinspectionjson-successvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SuccessValues { get; set; }
            /// <summary>
            /// FailureValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionjson.html#cfn-wafv2-webacl-responseinspectionjson-failurevalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FailureValues { get; set; }
        }

        public class ResponseInspectionStatusCode : Humidifier.Base.BaseSubResource, IHaveIntegerListOfSuccessCodes, IHaveIntegerListOfFailureCodes
        {
            /// <summary>
            /// SuccessCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionstatuscode.html#cfn-wafv2-webacl-responseinspectionstatuscode-successcodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? SuccessCodes { get; set; }
            /// <summary>
            /// FailureCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-responseinspectionstatuscode.html#cfn-wafv2-webacl-responseinspectionstatuscode-failurecodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? FailureCodes { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesRuleActionAction, IHavePriority_Integer, IHaveWAFv2WebACLTypesStatementStatement, IHaveWAFv2WebACLTypesChallengeConfigChallengeConfig, IHaveWAFv2WebACLTypesOverrideActionOverrideAction, IHaveListOfWAFv2WebACLTypesLabelRuleLabels, IHaveWAFv2WebACLTypesVisibilityConfigVisibilityConfig, IHaveWAFv2WebACLTypesCaptchaConfigCaptchaConfig, IHaveName
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RuleAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-statement
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Statement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.Statement, BaseFunction>? Statement { get; set; }
            /// <summary>
            /// ChallengeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-challengeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeConfig
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ChallengeConfig, BaseFunction>? ChallengeConfig { get; set; }
            /// <summary>
            /// OverrideAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-overrideaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.OverrideAction, BaseFunction>? OverrideAction { get; set; }
            /// <summary>
            /// RuleLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-rulelabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Label
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.Label>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.Label, BaseFunction>>, BaseFunction>? RuleLabels { get; set; }
            /// <summary>
            /// VisibilityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-visibilityconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VisibilityConfig
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.VisibilityConfig, BaseFunction>? VisibilityConfig { get; set; }
            /// <summary>
            /// CaptchaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-captchaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaConfig
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CaptchaConfig, BaseFunction>? CaptchaConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html#cfn-wafv2-webacl-rule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RuleAction : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesMonetizeActionMonetize, IHaveWAFv2WebACLTypesBlockActionBlock, IHaveWAFv2WebACLTypesCaptchaActionCaptcha, IHaveWAFv2WebACLTypesCountActionCount, IHaveWAFv2WebACLTypesAllowActionAllow, IHaveWAFv2WebACLTypesChallengeActionChallenge
        {
            /// <summary>
            /// Monetize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-monetize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonetizeAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.MonetizeAction, BaseFunction>? Monetize { get; set; }
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-block
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.BlockAction, BaseFunction>? Block { get; set; }
            /// <summary>
            /// Captcha
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-captcha
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptchaAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CaptchaAction, BaseFunction>? Captcha { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-count
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CountAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.CountAction, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AllowAction, BaseFunction>? Allow { get; set; }
            /// <summary>
            /// Challenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleaction.html#cfn-wafv2-webacl-ruleaction-challenge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChallengeAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ChallengeAction, BaseFunction>? Challenge { get; set; }
        }

        public class RuleActionOverride : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesRuleActionActionToUse, IHaveName
        {
            /// <summary>
            /// ActionToUse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleactionoverride.html#cfn-wafv2-webacl-ruleactionoverride-actiontouse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleAction
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RuleAction, BaseFunction>? ActionToUse { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-ruleactionoverride.html#cfn-wafv2-webacl-ruleactionoverride-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RuleGroupReferenceStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesRuleActionOverrideRuleActionOverrides, IHaveArn, IHaveListOfWAFv2WebACLTypesExcludedRuleExcludedRules
        {
            /// <summary>
            /// RuleActionOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html#cfn-wafv2-webacl-rulegroupreferencestatement-ruleactionoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleActionOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.RuleActionOverride>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.RuleActionOverride, BaseFunction>>, BaseFunction>? RuleActionOverrides { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html#cfn-wafv2-webacl-rulegroupreferencestatement-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// ExcludedRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html#cfn-wafv2-webacl-rulegroupreferencestatement-excludedrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExcludedRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.ExcludedRule>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.ExcludedRule, BaseFunction>>, BaseFunction>? ExcludedRules { get; set; }
        }

        public class SingleHeader : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-singleheader.html#cfn-wafv2-webacl-singleheader-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-singlequeryargument.html#cfn-wafv2-webacl-singlequeryargument-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SizeConstraintStatement : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveListOfWAFv2WebACLTypesPreParseTextTransformationPreParseTextTransformations, IHaveSize_Double, IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Size { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html#cfn-wafv2-webacl-sizeconstraintstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class SqliMatchStatement : Humidifier.Base.BaseSubResource, IHaveSensitivityLevel, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveListOfWAFv2WebACLTypesPreParseTextTransformationPreParseTextTransformations, IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// SensitivityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-sensitivitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SensitivityLevel { get; set; }
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sqlimatchstatement.html#cfn-wafv2-webacl-sqlimatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }

        public class Statement : Humidifier.Base.BaseSubResource, IHaveWAFv2WebACLTypesSizeConstraintStatementSizeConstraintStatement, IHaveWAFv2WebACLTypesAndStatementAndStatement, IHaveWAFv2WebACLTypesXssMatchStatementXssMatchStatement, IHaveWAFv2WebACLTypesNotStatementNotStatement, IHaveWAFv2WebACLTypesByteMatchStatementByteMatchStatement, IHaveWAFv2WebACLTypesRateBasedStatementRateBasedStatement, IHaveWAFv2WebACLTypesGeoMatchStatementGeoMatchStatement, IHaveWAFv2WebACLTypesRuleGroupReferenceStatementRuleGroupReferenceStatement, IHaveWAFv2WebACLTypesLabelMatchStatementLabelMatchStatement, IHaveWAFv2WebACLTypesRegexMatchStatementRegexMatchStatement, IHaveWAFv2WebACLTypesSqliMatchStatementSqliMatchStatement, IHaveWAFv2WebACLTypesRegexPatternSetReferenceStatementRegexPatternSetReferenceStatement, IHaveWAFv2WebACLTypesOrStatementOrStatement, IHaveWAFv2WebACLTypesAsnMatchStatementAsnMatchStatement, IHaveWAFv2WebACLTypesManagedRuleGroupStatementManagedRuleGroupStatement, IHaveWAFv2WebACLTypesIPSetReferenceStatementIPSetReferenceStatement
        {
            /// <summary>
            /// SizeConstraintStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-sizeconstraintstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SizeConstraintStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement, BaseFunction>? SizeConstraintStatement { get; set; }
            /// <summary>
            /// AndStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-andstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AndStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AndStatement, BaseFunction>? AndStatement { get; set; }
            /// <summary>
            /// XssMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-xssmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: XssMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.XssMatchStatement, BaseFunction>? XssMatchStatement { get; set; }
            /// <summary>
            /// NotStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-notstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.NotStatement, BaseFunction>? NotStatement { get; set; }
            /// <summary>
            /// ByteMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-bytematchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ByteMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ByteMatchStatement, BaseFunction>? ByteMatchStatement { get; set; }
            /// <summary>
            /// RateBasedStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-ratebasedstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RateBasedStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RateBasedStatement, BaseFunction>? RateBasedStatement { get; set; }
            /// <summary>
            /// GeoMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-geomatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.GeoMatchStatement, BaseFunction>? GeoMatchStatement { get; set; }
            /// <summary>
            /// RuleGroupReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-rulegroupreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleGroupReferenceStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RuleGroupReferenceStatement, BaseFunction>? RuleGroupReferenceStatement { get; set; }
            /// <summary>
            /// LabelMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-labelmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.LabelMatchStatement, BaseFunction>? LabelMatchStatement { get; set; }
            /// <summary>
            /// RegexMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-regexmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RegexMatchStatement, BaseFunction>? RegexMatchStatement { get; set; }
            /// <summary>
            /// SqliMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-sqlimatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqliMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.SqliMatchStatement, BaseFunction>? SqliMatchStatement { get; set; }
            /// <summary>
            /// RegexPatternSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-regexpatternsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegexPatternSetReferenceStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.RegexPatternSetReferenceStatement, BaseFunction>? RegexPatternSetReferenceStatement { get; set; }
            /// <summary>
            /// OrStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-orstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.OrStatement, BaseFunction>? OrStatement { get; set; }
            /// <summary>
            /// AsnMatchStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-asnmatchstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AsnMatchStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.AsnMatchStatement, BaseFunction>? AsnMatchStatement { get; set; }
            /// <summary>
            /// ManagedRuleGroupStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-managedrulegroupstatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedRuleGroupStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement, BaseFunction>? ManagedRuleGroupStatement { get; set; }
            /// <summary>
            /// IPSetReferenceStatement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statement.html#cfn-wafv2-webacl-statement-ipsetreferencestatement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IPSetReferenceStatement
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement, BaseFunction>? IPSetReferenceStatement { get; set; }
        }

        public class TextTransformation : Humidifier.Base.BaseSubResource, IHaveType, IHavePriority_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-texttransformation.html#cfn-wafv2-webacl-texttransformation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-texttransformation.html#cfn-wafv2-webacl-texttransformation-priority
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-urifragment.html#cfn-wafv2-webacl-urifragment-fallbackbehavior
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html#cfn-wafv2-webacl-visibilityconfig-sampledrequestsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SampledRequestsEnabled { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html#cfn-wafv2-webacl-visibilityconfig-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// CloudWatchMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-visibilityconfig.html#cfn-wafv2-webacl-visibilityconfig-cloudwatchmetricsenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudWatchMetricsEnabled { get; set; }
        }

        public class XssMatchStatement : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2WebACLTypesTextTransformationTextTransformations, IHaveListOfWAFv2WebACLTypesPreParseTextTransformationPreParseTextTransformations, IHaveWAFv2WebACLTypesFieldToMatchFieldToMatch
        {
            /// <summary>
            /// TextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-xssmatchstatement.html#cfn-wafv2-webacl-xssmatchstatement-texttransformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.TextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.TextTransformation, BaseFunction>>, BaseFunction>? TextTransformations { get; set; }
            /// <summary>
            /// PreParseTextTransformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-xssmatchstatement.html#cfn-wafv2-webacl-xssmatchstatement-preparsetexttransformations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PreParseTextTransformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation>, IReadOnlyList<Union<Humidifier.WAFv2.WebACLTypes.PreParseTextTransformation, BaseFunction>>, BaseFunction>? PreParseTextTransformations { get; set; }
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-xssmatchstatement.html#cfn-wafv2-webacl-xssmatchstatement-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public Union<Humidifier.WAFv2.WebACLTypes.FieldToMatch, BaseFunction>? FieldToMatch { get; set; }
        }
    }
}