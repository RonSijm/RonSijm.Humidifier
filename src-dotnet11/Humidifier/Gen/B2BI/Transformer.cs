namespace Humidifier.B2BI
{
    using global::System.Collections.Generic;
    using TransformerTypes;

    public class Transformer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveB2BITransformerTypesMappingMapping, IHaveB2BITransformerTypesInputConversionInputConversion, IHaveB2BITransformerTypesSampleDocumentsSampleDocuments, IHaveB2BITransformerTypesOutputConversionOutputConversion, IHaveName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string TransformerId =  "TransformerId" ;
            public static string TransformerArn =  "TransformerArn" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.B2BI.Transformer; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Mapping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-mapping
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Mapping
        /// </summary>
        public Union<Humidifier.B2BI.TransformerTypes.Mapping, BaseFunction>? Mapping { get; set; }
        /// <summary>
        /// InputConversion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-inputconversion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputConversion
        /// </summary>
        public Union<Humidifier.B2BI.TransformerTypes.InputConversion, BaseFunction>? InputConversion { get; set; }
        /// <summary>
        /// SampleDocuments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-sampledocuments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SampleDocuments
        /// </summary>
        public Union<Humidifier.B2BI.TransformerTypes.SampleDocuments, BaseFunction>? SampleDocuments { get; set; }
        /// <summary>
        /// OutputConversion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-outputconversion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputConversion
        /// </summary>
        public Union<Humidifier.B2BI.TransformerTypes.OutputConversion, BaseFunction>? OutputConversion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TransformerTypes
    {
        public class AdvancedOptions : Humidifier.Base.BaseSubResource, IHaveB2BITransformerTypesX12AdvancedOptionsX12
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-advancedoptions.html#cfn-b2bi-transformer-advancedoptions-x12
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12AdvancedOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions, BaseFunction>? X12 { get; set; }
        }

        public class FormatOptions : Humidifier.Base.BaseSubResource, IHaveB2BITransformerTypesX12DetailsX12
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-formatoptions.html#cfn-b2bi-transformer-formatoptions-x12
            /// Required: True
            /// UpdateType: Mutable
            /// Type: X12Details
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12Details, BaseFunction>? X12 { get; set; }
        }

        public class InputConversion : Humidifier.Base.BaseSubResource, IHaveB2BITransformerTypesAdvancedOptionsAdvancedOptions, IHaveB2BITransformerTypesFormatOptionsFormatOptions, IHaveFromFormat
        {
            /// <summary>
            /// AdvancedOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-inputconversion.html#cfn-b2bi-transformer-inputconversion-advancedoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.AdvancedOptions, BaseFunction>? AdvancedOptions { get; set; }
            /// <summary>
            /// FormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-inputconversion.html#cfn-b2bi-transformer-inputconversion-formatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.FormatOptions, BaseFunction>? FormatOptions { get; set; }
            /// <summary>
            /// FromFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-inputconversion.html#cfn-b2bi-transformer-inputconversion-fromformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromFormat { get; set; }
        }

        public class Mapping : Humidifier.Base.BaseSubResource, IHaveTemplateLanguage, IHaveTemplate
        {
            /// <summary>
            /// TemplateLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-mapping.html#cfn-b2bi-transformer-mapping-templatelanguage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateLanguage { get; set; }
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-mapping.html#cfn-b2bi-transformer-mapping-template
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Template { get; set; }
        }

        public class OutputConversion : Humidifier.Base.BaseSubResource, IHaveB2BITransformerTypesAdvancedOptionsAdvancedOptions, IHaveToFormat, IHaveB2BITransformerTypesFormatOptionsFormatOptions
        {
            /// <summary>
            /// AdvancedOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-outputconversion.html#cfn-b2bi-transformer-outputconversion-advancedoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.AdvancedOptions, BaseFunction>? AdvancedOptions { get; set; }
            /// <summary>
            /// ToFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-outputconversion.html#cfn-b2bi-transformer-outputconversion-toformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ToFormat { get; set; }
            /// <summary>
            /// FormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-outputconversion.html#cfn-b2bi-transformer-outputconversion-formatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.FormatOptions, BaseFunction>? FormatOptions { get; set; }
        }

        public class SampleDocumentKeys : Humidifier.Base.BaseSubResource, IHaveInput, IHaveOutput
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocumentkeys.html#cfn-b2bi-transformer-sampledocumentkeys-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Input { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocumentkeys.html#cfn-b2bi-transformer-sampledocumentkeys-output
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Output { get; set; }
        }

        public class SampleDocuments : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveListOfB2BITransformerTypesSampleDocumentKeysKeys
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocuments.html#cfn-b2bi-transformer-sampledocuments-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Keys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocuments.html#cfn-b2bi-transformer-sampledocuments-keys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleDocumentKeys
            /// </summary>
            public Union<IReadOnlyList<Humidifier.B2BI.TransformerTypes.SampleDocumentKeys>, IReadOnlyList<Union<Humidifier.B2BI.TransformerTypes.SampleDocumentKeys, BaseFunction>>, BaseFunction>? Keys { get; set; }
        }

        public class X12AdvancedOptions : Humidifier.Base.BaseSubResource, IHaveB2BITransformerTypesX12ValidationOptionsValidationOptions, IHaveB2BITransformerTypesX12SplitOptionsSplitOptions
        {
            /// <summary>
            /// ValidationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12advancedoptions.html#cfn-b2bi-transformer-x12advancedoptions-validationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12ValidationOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12ValidationOptions, BaseFunction>? ValidationOptions { get; set; }
            /// <summary>
            /// SplitOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12advancedoptions.html#cfn-b2bi-transformer-x12advancedoptions-splitoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12SplitOptions
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12SplitOptions, BaseFunction>? SplitOptions { get; set; }
        }

        public class X12CodeListValidationRule : Humidifier.Base.BaseSubResource, IHaveStringListOfCodesToAdd, IHaveStringListOfCodesToRemove, IHaveElementId
        {
            /// <summary>
            /// CodesToAdd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12codelistvalidationrule.html#cfn-b2bi-transformer-x12codelistvalidationrule-codestoadd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CodesToAdd { get; set; }
            /// <summary>
            /// CodesToRemove
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12codelistvalidationrule.html#cfn-b2bi-transformer-x12codelistvalidationrule-codestoremove
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CodesToRemove { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12codelistvalidationrule.html#cfn-b2bi-transformer-x12codelistvalidationrule-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ElementId { get; set; }
        }

        public class X12Details : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveTransactionSet
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12details.html#cfn-b2bi-transformer-x12details-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// TransactionSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12details.html#cfn-b2bi-transformer-x12details-transactionset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransactionSet { get; set; }
        }

        public class X12ElementLengthValidationRule : Humidifier.Base.BaseSubResource, IHaveMinLength_Double, IHaveMaxLength_Double, IHaveElementId
        {
            /// <summary>
            /// MinLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12elementlengthvalidationrule.html#cfn-b2bi-transformer-x12elementlengthvalidationrule-minlength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinLength { get; set; }
            /// <summary>
            /// MaxLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12elementlengthvalidationrule.html#cfn-b2bi-transformer-x12elementlengthvalidationrule-maxlength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxLength { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12elementlengthvalidationrule.html#cfn-b2bi-transformer-x12elementlengthvalidationrule-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ElementId { get; set; }
        }

        public class X12ElementRequirementValidationRule : Humidifier.Base.BaseSubResource, IHaveRequirement, IHaveElementPosition
        {
            /// <summary>
            /// Requirement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12elementrequirementvalidationrule.html#cfn-b2bi-transformer-x12elementrequirementvalidationrule-requirement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Requirement { get; set; }
            /// <summary>
            /// ElementPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12elementrequirementvalidationrule.html#cfn-b2bi-transformer-x12elementrequirementvalidationrule-elementposition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ElementPosition { get; set; }
        }

        public class X12SplitOptions : Humidifier.Base.BaseSubResource, IHaveSplitBy
        {
            /// <summary>
            /// SplitBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12splitoptions.html#cfn-b2bi-transformer-x12splitoptions-splitby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SplitBy { get; set; }
        }

        public class X12ValidationOptions : Humidifier.Base.BaseSubResource, IHaveListOfB2BITransformerTypesX12ValidationRuleValidationRules
        {
            /// <summary>
            /// ValidationRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12validationoptions.html#cfn-b2bi-transformer-x12validationoptions-validationrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: X12ValidationRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.B2BI.TransformerTypes.X12ValidationRule>, IReadOnlyList<Union<Humidifier.B2BI.TransformerTypes.X12ValidationRule, BaseFunction>>, BaseFunction>? ValidationRules { get; set; }
        }

        public class X12ValidationRule : Humidifier.Base.BaseSubResource, IHaveB2BITransformerTypesX12ElementRequirementValidationRuleElementRequirementValidationRule, IHaveB2BITransformerTypesX12CodeListValidationRuleCodeListValidationRule, IHaveB2BITransformerTypesX12ElementLengthValidationRuleElementLengthValidationRule
        {
            /// <summary>
            /// ElementRequirementValidationRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12validationrule.html#cfn-b2bi-transformer-x12validationrule-elementrequirementvalidationrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12ElementRequirementValidationRule
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12ElementRequirementValidationRule, BaseFunction>? ElementRequirementValidationRule { get; set; }
            /// <summary>
            /// CodeListValidationRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12validationrule.html#cfn-b2bi-transformer-x12validationrule-codelistvalidationrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12CodeListValidationRule
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12CodeListValidationRule, BaseFunction>? CodeListValidationRule { get; set; }
            /// <summary>
            /// ElementLengthValidationRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12validationrule.html#cfn-b2bi-transformer-x12validationrule-elementlengthvalidationrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12ElementLengthValidationRule
            /// </summary>
            public Union<Humidifier.B2BI.TransformerTypes.X12ElementLengthValidationRule, BaseFunction>? ElementLengthValidationRule { get; set; }
        }
    }
}