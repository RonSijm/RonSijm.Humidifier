namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using DataAutomationProjectTypes;

    public class DataAutomationProject : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyId, IHaveProjectName, IHaveBedrockDataAutomationProjectTypesStandardOutputConfigurationStandardOutputConfiguration, IHaveBedrockDataAutomationProjectTypesOverrideConfigurationOverrideConfiguration, IHaveProjectType, IHaveStringDictionaryOfKmsEncryptionContext, IHaveBedrockDataAutomationProjectTypesCustomOutputConfigurationCustomOutputConfiguration, IHaveProjectDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ProjectArn =  "ProjectArn" ;
            public static string ProjectStage =  "ProjectStage" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.DataAutomationProject; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }

        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-projectname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProjectName { get; set; }
        /// <summary>
        /// StandardOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StandardOutputConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.DataAutomationProjectTypes.StandardOutputConfiguration, BaseFunction>? StandardOutputConfiguration { get; set; }
        /// <summary>
        /// OverrideConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-overrideconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OverrideConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.DataAutomationProjectTypes.OverrideConfiguration, BaseFunction>? OverrideConfiguration { get; set; }
        /// <summary>
        /// ProjectType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-projecttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectType { get; set; }
        /// <summary>
        /// KmsEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-kmsencryptioncontext
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? KmsEncryptionContext { get; set; }
        /// <summary>
        /// CustomOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-customoutputconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomOutputConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration, BaseFunction>? CustomOutputConfiguration { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-projectdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectDescription { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataAutomationProjectTypes
    {
        public class AudioExtractionCategory : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveState, IHaveBedrockDataAutomationProjectTypesAudioExtractionCategoryTypeConfigurationTypeConfiguration
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategory.html#cfn-bedrock-dataautomationproject-audioextractioncategory-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategory.html#cfn-bedrock-dataautomationproject-audioextractioncategory-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// TypeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategory.html#cfn-bedrock-dataautomationproject-audioextractioncategory-typeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioExtractionCategoryTypeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration, BaseFunction>? TypeConfiguration { get; set; }
        }

        public class AudioExtractionCategoryTypeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesTranscriptConfigurationTranscript
        {
            /// <summary>
            /// Transcript
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategorytypeconfiguration.html#cfn-bedrock-dataautomationproject-audioextractioncategorytypeconfiguration-transcript
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TranscriptConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration, BaseFunction>? Transcript { get; set; }
        }

        public class AudioLanguageConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentifyMultipleLanguages_Boolean, IHaveGenerativeOutputLanguage, IHaveStringListOfInputLanguages
        {
            /// <summary>
            /// IdentifyMultipleLanguages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiolanguageconfiguration.html#cfn-bedrock-dataautomationproject-audiolanguageconfiguration-identifymultiplelanguages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IdentifyMultipleLanguages { get; set; }
            /// <summary>
            /// GenerativeOutputLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiolanguageconfiguration.html#cfn-bedrock-dataautomationproject-audiolanguageconfiguration-generativeoutputlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GenerativeOutputLanguage { get; set; }
            /// <summary>
            /// InputLanguages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiolanguageconfiguration.html#cfn-bedrock-dataautomationproject-audiolanguageconfiguration-inputlanguages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InputLanguages { get; set; }
        }

        public class AudioOverrideConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesSensitiveDataConfigurationSensitiveDataConfiguration, IHaveBedrockDataAutomationProjectTypesAudioLanguageConfigurationLanguageConfiguration, IHaveBedrockDataAutomationProjectTypesModalityProcessingConfigurationModalityProcessing
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiooverrideconfiguration.html#cfn-bedrock-dataautomationproject-audiooverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration, BaseFunction>? SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// LanguageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiooverrideconfiguration.html#cfn-bedrock-dataautomationproject-audiooverrideconfiguration-languageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioLanguageConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration, BaseFunction>? LanguageConfiguration { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiooverrideconfiguration.html#cfn-bedrock-dataautomationproject-audiooverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration, BaseFunction>? ModalityProcessing { get; set; }
        }

        public class AudioStandardExtraction : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesAudioExtractionCategoryCategory
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardextraction.html#cfn-bedrock-dataautomationproject-audiostandardextraction-category
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudioExtractionCategory
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory, BaseFunction>? Category { get; set; }
        }

        public class AudioStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveState
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardgenerativefield.html#cfn-bedrock-dataautomationproject-audiostandardgenerativefield-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardgenerativefield.html#cfn-bedrock-dataautomationproject-audiostandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class AudioStandardOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesAudioStandardGenerativeFieldGenerativeField, IHaveBedrockDataAutomationProjectTypesAudioStandardExtractionExtraction
        {
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-audiostandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioStandardGenerativeField
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField, BaseFunction>? GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-audiostandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioStandardExtraction
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction, BaseFunction>? Extraction { get; set; }
        }

        public class BlueprintItem : Humidifier.Base.BaseSubResource, IHaveBlueprintVersion, IHaveBlueprintStage, IHaveBlueprintArn
        {
            /// <summary>
            /// BlueprintVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-blueprintitem.html#cfn-bedrock-dataautomationproject-blueprintitem-blueprintversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlueprintVersion { get; set; }
            /// <summary>
            /// BlueprintStage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-blueprintitem.html#cfn-bedrock-dataautomationproject-blueprintitem-blueprintstage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlueprintStage { get; set; }
            /// <summary>
            /// BlueprintArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-blueprintitem.html#cfn-bedrock-dataautomationproject-blueprintitem-blueprintarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlueprintArn { get; set; }
        }

        public class ChannelLabelingConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-channellabelingconfiguration.html#cfn-bedrock-dataautomationproject-channellabelingconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class CustomOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockDataAutomationProjectTypesBlueprintItemBlueprints
        {
            /// <summary>
            /// Blueprints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-customoutputconfiguration.html#cfn-bedrock-dataautomationproject-customoutputconfiguration-blueprints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BlueprintItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.DataAutomationProjectTypes.BlueprintItem>, IReadOnlyList<Union<Humidifier.Bedrock.DataAutomationProjectTypes.BlueprintItem, BaseFunction>>, BaseFunction>? Blueprints { get; set; }
        }

        public class DocumentBoundingBox : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentboundingbox.html#cfn-bedrock-dataautomationproject-documentboundingbox-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class DocumentExtractionGranularity : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentextractiongranularity.html#cfn-bedrock-dataautomationproject-documentextractiongranularity-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
        }

        public class DocumentOutputAdditionalFileFormat : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputadditionalfileformat.html#cfn-bedrock-dataautomationproject-documentoutputadditionalfileformat-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class DocumentOutputFormat : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesDocumentOutputTextFormatTextFormat, IHaveBedrockDataAutomationProjectTypesDocumentOutputAdditionalFileFormatAdditionalFileFormat
        {
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputformat.html#cfn-bedrock-dataautomationproject-documentoutputformat-textformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentOutputTextFormat
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat, BaseFunction>? TextFormat { get; set; }
            /// <summary>
            /// AdditionalFileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputformat.html#cfn-bedrock-dataautomationproject-documentoutputformat-additionalfileformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentOutputAdditionalFileFormat
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat, BaseFunction>? AdditionalFileFormat { get; set; }
        }

        public class DocumentOutputTextFormat : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputtextformat.html#cfn-bedrock-dataautomationproject-documentoutputtextformat-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
        }

        public class DocumentOverrideConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesSensitiveDataConfigurationSensitiveDataConfiguration, IHaveBedrockDataAutomationProjectTypesSplitterConfigurationSplitter, IHaveBedrockDataAutomationProjectTypesModalityProcessingConfigurationModalityProcessing
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoverrideconfiguration.html#cfn-bedrock-dataautomationproject-documentoverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration, BaseFunction>? SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// Splitter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoverrideconfiguration.html#cfn-bedrock-dataautomationproject-documentoverrideconfiguration-splitter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SplitterConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration, BaseFunction>? Splitter { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoverrideconfiguration.html#cfn-bedrock-dataautomationproject-documentoverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration, BaseFunction>? ModalityProcessing { get; set; }
        }

        public class DocumentStandardExtraction : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesDocumentBoundingBoxBoundingBox, IHaveBedrockDataAutomationProjectTypesDocumentExtractionGranularityGranularity
        {
            /// <summary>
            /// BoundingBox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardextraction.html#cfn-bedrock-dataautomationproject-documentstandardextraction-boundingbox
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentBoundingBox
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox, BaseFunction>? BoundingBox { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardextraction.html#cfn-bedrock-dataautomationproject-documentstandardextraction-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentExtractionGranularity
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity, BaseFunction>? Granularity { get; set; }
        }

        public class DocumentStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardgenerativefield.html#cfn-bedrock-dataautomationproject-documentstandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class DocumentStandardOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesDocumentOutputFormatOutputFormat, IHaveBedrockDataAutomationProjectTypesDocumentStandardGenerativeFieldGenerativeField, IHaveBedrockDataAutomationProjectTypesDocumentStandardExtractionExtraction
        {
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-documentstandardoutputconfiguration-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentOutputFormat
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputFormat, BaseFunction>? OutputFormat { get; set; }
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-documentstandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentStandardGenerativeField
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField, BaseFunction>? GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-documentstandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentStandardExtraction
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardExtraction, BaseFunction>? Extraction { get; set; }
        }

        public class ImageBoundingBox : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageboundingbox.html#cfn-bedrock-dataautomationproject-imageboundingbox-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class ImageExtractionCategory : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveState
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageextractioncategory.html#cfn-bedrock-dataautomationproject-imageextractioncategory-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageextractioncategory.html#cfn-bedrock-dataautomationproject-imageextractioncategory-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class ImageOverrideConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesSensitiveDataConfigurationSensitiveDataConfiguration, IHaveBedrockDataAutomationProjectTypesModalityProcessingConfigurationModalityProcessing
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageoverrideconfiguration.html#cfn-bedrock-dataautomationproject-imageoverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration, BaseFunction>? SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageoverrideconfiguration.html#cfn-bedrock-dataautomationproject-imageoverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration, BaseFunction>? ModalityProcessing { get; set; }
        }

        public class ImageStandardExtraction : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesImageExtractionCategoryCategory, IHaveBedrockDataAutomationProjectTypesImageBoundingBoxBoundingBox
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardextraction.html#cfn-bedrock-dataautomationproject-imagestandardextraction-category
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ImageExtractionCategory
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory, BaseFunction>? Category { get; set; }
            /// <summary>
            /// BoundingBox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardextraction.html#cfn-bedrock-dataautomationproject-imagestandardextraction-boundingbox
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ImageBoundingBox
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox, BaseFunction>? BoundingBox { get; set; }
        }

        public class ImageStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveState
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardgenerativefield.html#cfn-bedrock-dataautomationproject-imagestandardgenerativefield-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardgenerativefield.html#cfn-bedrock-dataautomationproject-imagestandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class ImageStandardOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesImageStandardGenerativeFieldGenerativeField, IHaveBedrockDataAutomationProjectTypesImageStandardExtractionExtraction
        {
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-imagestandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStandardGenerativeField
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField, BaseFunction>? GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-imagestandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStandardExtraction
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardExtraction, BaseFunction>? Extraction { get; set; }
        }

        public class ModalityProcessingConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityprocessingconfiguration.html#cfn-bedrock-dataautomationproject-modalityprocessingconfiguration-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class ModalityRoutingConfiguration : Humidifier.Base.BaseSubResource, IHavemp4, IHavemov, IHavepng, IHavejpeg
        {
            /// <summary>
            /// mp4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-mp4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? mp4 { get; set; }
            /// <summary>
            /// mov
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-mov
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? mov { get; set; }
            /// <summary>
            /// png
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-png
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? png { get; set; }
            /// <summary>
            /// jpeg
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-jpeg
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? jpeg { get; set; }
        }

        public class OverrideConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesVideoOverrideConfigurationVideo, IHaveBedrockDataAutomationProjectTypesModalityRoutingConfigurationModalityRouting, IHaveBedrockDataAutomationProjectTypesDocumentOverrideConfigurationDocument, IHaveBedrockDataAutomationProjectTypesAudioOverrideConfigurationAudio, IHaveBedrockDataAutomationProjectTypesImageOverrideConfigurationImage
        {
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-video
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoOverrideConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.VideoOverrideConfiguration, BaseFunction>? Video { get; set; }
            /// <summary>
            /// ModalityRouting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-modalityrouting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityRoutingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration, BaseFunction>? ModalityRouting { get; set; }
            /// <summary>
            /// Document
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-document
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentOverrideConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOverrideConfiguration, BaseFunction>? Document { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-audio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioOverrideConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioOverrideConfiguration, BaseFunction>? Audio { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-image
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageOverrideConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ImageOverrideConfiguration, BaseFunction>? Image { get; set; }
        }

        public class PIIEntitiesConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfPiiEntityTypes, IHaveRedactionMaskMode
        {
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-piientitiesconfiguration.html#cfn-bedrock-dataautomationproject-piientitiesconfiguration-piientitytypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PiiEntityTypes { get; set; }
            /// <summary>
            /// RedactionMaskMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-piientitiesconfiguration.html#cfn-bedrock-dataautomationproject-piientitiesconfiguration-redactionmaskmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedactionMaskMode { get; set; }
        }

        public class SensitiveDataConfiguration : Humidifier.Base.BaseSubResource, IHaveDetectionMode, IHaveStringListOfDetectionScope, IHaveBedrockDataAutomationProjectTypesPIIEntitiesConfigurationPiiEntitiesConfiguration
        {
            /// <summary>
            /// DetectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-sensitivedataconfiguration.html#cfn-bedrock-dataautomationproject-sensitivedataconfiguration-detectionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DetectionMode { get; set; }
            /// <summary>
            /// DetectionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-sensitivedataconfiguration.html#cfn-bedrock-dataautomationproject-sensitivedataconfiguration-detectionscope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DetectionScope { get; set; }
            /// <summary>
            /// PiiEntitiesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-sensitivedataconfiguration.html#cfn-bedrock-dataautomationproject-sensitivedataconfiguration-piientitiesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PIIEntitiesConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration, BaseFunction>? PiiEntitiesConfiguration { get; set; }
        }

        public class SpeakerLabelingConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-speakerlabelingconfiguration.html#cfn-bedrock-dataautomationproject-speakerlabelingconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class SplitterConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-splitterconfiguration.html#cfn-bedrock-dataautomationproject-splitterconfiguration-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class StandardOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesVideoStandardOutputConfigurationVideo, IHaveBedrockDataAutomationProjectTypesDocumentStandardOutputConfigurationDocument, IHaveBedrockDataAutomationProjectTypesImageStandardOutputConfigurationImage, IHaveBedrockDataAutomationProjectTypesAudioStandardOutputConfigurationAudio
        {
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-video
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoStandardOutputConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardOutputConfiguration, BaseFunction>? Video { get; set; }
            /// <summary>
            /// Document
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-document
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentStandardOutputConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardOutputConfiguration, BaseFunction>? Document { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-image
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStandardOutputConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardOutputConfiguration, BaseFunction>? Image { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-audio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioStandardOutputConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardOutputConfiguration, BaseFunction>? Audio { get; set; }
        }

        public class TranscriptConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesChannelLabelingConfigurationChannelLabeling, IHaveBedrockDataAutomationProjectTypesSpeakerLabelingConfigurationSpeakerLabeling
        {
            /// <summary>
            /// ChannelLabeling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-transcriptconfiguration.html#cfn-bedrock-dataautomationproject-transcriptconfiguration-channellabeling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChannelLabelingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration, BaseFunction>? ChannelLabeling { get; set; }
            /// <summary>
            /// SpeakerLabeling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-transcriptconfiguration.html#cfn-bedrock-dataautomationproject-transcriptconfiguration-speakerlabeling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpeakerLabelingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration, BaseFunction>? SpeakerLabeling { get; set; }
        }

        public class VideoBoundingBox : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videoboundingbox.html#cfn-bedrock-dataautomationproject-videoboundingbox-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class VideoExtractionCategory : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveState
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videoextractioncategory.html#cfn-bedrock-dataautomationproject-videoextractioncategory-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videoextractioncategory.html#cfn-bedrock-dataautomationproject-videoextractioncategory-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class VideoOverrideConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesSensitiveDataConfigurationSensitiveDataConfiguration, IHaveBedrockDataAutomationProjectTypesModalityProcessingConfigurationModalityProcessing
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videooverrideconfiguration.html#cfn-bedrock-dataautomationproject-videooverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration, BaseFunction>? SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videooverrideconfiguration.html#cfn-bedrock-dataautomationproject-videooverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration, BaseFunction>? ModalityProcessing { get; set; }
        }

        public class VideoStandardExtraction : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesVideoExtractionCategoryCategory, IHaveBedrockDataAutomationProjectTypesVideoBoundingBoxBoundingBox
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardextraction.html#cfn-bedrock-dataautomationproject-videostandardextraction-category
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VideoExtractionCategory
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory, BaseFunction>? Category { get; set; }
            /// <summary>
            /// BoundingBox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardextraction.html#cfn-bedrock-dataautomationproject-videostandardextraction-boundingbox
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VideoBoundingBox
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox, BaseFunction>? BoundingBox { get; set; }
        }

        public class VideoStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveState
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardgenerativefield.html#cfn-bedrock-dataautomationproject-videostandardgenerativefield-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardgenerativefield.html#cfn-bedrock-dataautomationproject-videostandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class VideoStandardOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataAutomationProjectTypesVideoStandardGenerativeFieldGenerativeField, IHaveBedrockDataAutomationProjectTypesVideoStandardExtractionExtraction
        {
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-videostandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoStandardGenerativeField
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField, BaseFunction>? GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-videostandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoStandardExtraction
            /// </summary>
            public Union<Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardExtraction, BaseFunction>? Extraction { get; set; }
        }
    }
}