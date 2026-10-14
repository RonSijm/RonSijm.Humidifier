namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using DataAutomationProjectTypes;

    public class DataAutomationProject : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyId, IHaveProjectName, IHaveProjectDescription
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
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-projectname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProjectName { get; set; }
        /// <summary>
        /// StandardOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StandardOutputConfiguration
        /// </summary>
        public Humidifier.Bedrock.DataAutomationProjectTypes.StandardOutputConfiguration StandardOutputConfiguration { get; set; }
        /// <summary>
        /// OverrideConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-overrideconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OverrideConfiguration
        /// </summary>
        public Humidifier.Bedrock.DataAutomationProjectTypes.OverrideConfiguration OverrideConfiguration { get; set; }
        /// <summary>
        /// ProjectType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-projecttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectType { get; set; }
        /// <summary>
        /// KmsEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-kmsencryptioncontext
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> KmsEncryptionContext { get; set; }
        /// <summary>
        /// CustomOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-customoutputconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomOutputConfiguration
        /// </summary>
        public Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration CustomOutputConfiguration { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-projectdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectDescription { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationproject.html#cfn-bedrock-dataautomationproject-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DataAutomationProjectTypes
    {
        public class AudioExtractionCategory : Humidifier.Base.BaseSubResource, IHaveState, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategory.html#cfn-bedrock-dataautomationproject-audioextractioncategory-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategory.html#cfn-bedrock-dataautomationproject-audioextractioncategory-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// TypeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategory.html#cfn-bedrock-dataautomationproject-audioextractioncategory-typeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioExtractionCategoryTypeConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategoryTypeConfiguration TypeConfiguration { get; set; }
        }

        public class AudioExtractionCategoryTypeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Transcript
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audioextractioncategorytypeconfiguration.html#cfn-bedrock-dataautomationproject-audioextractioncategorytypeconfiguration-transcript
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TranscriptConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.TranscriptConfiguration Transcript { get; set; }
        }

        public class AudioLanguageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdentifyMultipleLanguages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiolanguageconfiguration.html#cfn-bedrock-dataautomationproject-audiolanguageconfiguration-identifymultiplelanguages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IdentifyMultipleLanguages { get; set; }
            /// <summary>
            /// GenerativeOutputLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiolanguageconfiguration.html#cfn-bedrock-dataautomationproject-audiolanguageconfiguration-generativeoutputlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GenerativeOutputLanguage { get; set; }
            /// <summary>
            /// InputLanguages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiolanguageconfiguration.html#cfn-bedrock-dataautomationproject-audiolanguageconfiguration-inputlanguages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InputLanguages { get; set; }
        }

        public class AudioOverrideConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiooverrideconfiguration.html#cfn-bedrock-dataautomationproject-audiooverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// LanguageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiooverrideconfiguration.html#cfn-bedrock-dataautomationproject-audiooverrideconfiguration-languageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioLanguageConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioLanguageConfiguration LanguageConfiguration { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiooverrideconfiguration.html#cfn-bedrock-dataautomationproject-audiooverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration ModalityProcessing { get; set; }
        }

        public class AudioStandardExtraction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardextraction.html#cfn-bedrock-dataautomationproject-audiostandardextraction-category
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudioExtractionCategory
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioExtractionCategory Category { get; set; }
        }

        public class AudioStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveState, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardgenerativefield.html#cfn-bedrock-dataautomationproject-audiostandardgenerativefield-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardgenerativefield.html#cfn-bedrock-dataautomationproject-audiostandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class AudioStandardOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-audiostandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioStandardGenerativeField
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-audiostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-audiostandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioStandardExtraction
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardExtraction Extraction { get; set; }
        }

        public class BlueprintItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BlueprintVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-blueprintitem.html#cfn-bedrock-dataautomationproject-blueprintitem-blueprintversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BlueprintVersion { get; set; }
            /// <summary>
            /// BlueprintStage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-blueprintitem.html#cfn-bedrock-dataautomationproject-blueprintitem-blueprintstage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BlueprintStage { get; set; }
            /// <summary>
            /// BlueprintArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-blueprintitem.html#cfn-bedrock-dataautomationproject-blueprintitem-blueprintarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BlueprintArn { get; set; }
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
            public dynamic State { get; set; }
        }

        public class CustomOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Blueprints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-customoutputconfiguration.html#cfn-bedrock-dataautomationproject-customoutputconfiguration-blueprints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BlueprintItem
            /// </summary>
            public List<Humidifier.Bedrock.DataAutomationProjectTypes.BlueprintItem> Blueprints { get; set; }
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
            public dynamic State { get; set; }
        }

        public class DocumentExtractionGranularity : Humidifier.Base.BaseSubResource, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentextractiongranularity.html#cfn-bedrock-dataautomationproject-documentextractiongranularity-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
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
            public dynamic State { get; set; }
        }

        public class DocumentOutputFormat : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputformat.html#cfn-bedrock-dataautomationproject-documentoutputformat-textformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentOutputTextFormat
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat TextFormat { get; set; }
            /// <summary>
            /// AdditionalFileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputformat.html#cfn-bedrock-dataautomationproject-documentoutputformat-additionalfileformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentOutputAdditionalFileFormat
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat AdditionalFileFormat { get; set; }
        }

        public class DocumentOutputTextFormat : Humidifier.Base.BaseSubResource, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoutputtextformat.html#cfn-bedrock-dataautomationproject-documentoutputtextformat-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
        }

        public class DocumentOverrideConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoverrideconfiguration.html#cfn-bedrock-dataautomationproject-documentoverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// Splitter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoverrideconfiguration.html#cfn-bedrock-dataautomationproject-documentoverrideconfiguration-splitter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SplitterConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration Splitter { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentoverrideconfiguration.html#cfn-bedrock-dataautomationproject-documentoverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration ModalityProcessing { get; set; }
        }

        public class DocumentStandardExtraction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BoundingBox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardextraction.html#cfn-bedrock-dataautomationproject-documentstandardextraction-boundingbox
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentBoundingBox
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox BoundingBox { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardextraction.html#cfn-bedrock-dataautomationproject-documentstandardextraction-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DocumentExtractionGranularity
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity Granularity { get; set; }
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
            public dynamic State { get; set; }
        }

        public class DocumentStandardOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-documentstandardoutputconfiguration-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentOutputFormat
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputFormat OutputFormat { get; set; }
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-documentstandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentStandardGenerativeField
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-documentstandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-documentstandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentStandardExtraction
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardExtraction Extraction { get; set; }
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
            public dynamic State { get; set; }
        }

        public class ImageExtractionCategory : Humidifier.Base.BaseSubResource, IHaveState, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageextractioncategory.html#cfn-bedrock-dataautomationproject-imageextractioncategory-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageextractioncategory.html#cfn-bedrock-dataautomationproject-imageextractioncategory-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class ImageOverrideConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageoverrideconfiguration.html#cfn-bedrock-dataautomationproject-imageoverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imageoverrideconfiguration.html#cfn-bedrock-dataautomationproject-imageoverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration ModalityProcessing { get; set; }
        }

        public class ImageStandardExtraction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardextraction.html#cfn-bedrock-dataautomationproject-imagestandardextraction-category
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ImageExtractionCategory
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory Category { get; set; }
            /// <summary>
            /// BoundingBox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardextraction.html#cfn-bedrock-dataautomationproject-imagestandardextraction-boundingbox
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ImageBoundingBox
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox BoundingBox { get; set; }
        }

        public class ImageStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveState, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardgenerativefield.html#cfn-bedrock-dataautomationproject-imagestandardgenerativefield-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardgenerativefield.html#cfn-bedrock-dataautomationproject-imagestandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class ImageStandardOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-imagestandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStandardGenerativeField
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-imagestandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-imagestandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStandardExtraction
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardExtraction Extraction { get; set; }
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
            public dynamic State { get; set; }
        }

        public class ModalityRoutingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// mp4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-mp4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic mp4 { get; set; }
            /// <summary>
            /// mov
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-mov
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic mov { get; set; }
            /// <summary>
            /// png
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-png
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic png { get; set; }
            /// <summary>
            /// jpeg
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-modalityroutingconfiguration.html#cfn-bedrock-dataautomationproject-modalityroutingconfiguration-jpeg
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic jpeg { get; set; }
        }

        public class OverrideConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-video
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoOverrideConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.VideoOverrideConfiguration Video { get; set; }
            /// <summary>
            /// ModalityRouting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-modalityrouting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityRoutingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration ModalityRouting { get; set; }
            /// <summary>
            /// Document
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-document
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentOverrideConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOverrideConfiguration Document { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-audio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioOverrideConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioOverrideConfiguration Audio { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-overrideconfiguration.html#cfn-bedrock-dataautomationproject-overrideconfiguration-image
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageOverrideConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ImageOverrideConfiguration Image { get; set; }
        }

        public class PIIEntitiesConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-piientitiesconfiguration.html#cfn-bedrock-dataautomationproject-piientitiesconfiguration-piientitytypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PiiEntityTypes { get; set; }
            /// <summary>
            /// RedactionMaskMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-piientitiesconfiguration.html#cfn-bedrock-dataautomationproject-piientitiesconfiguration-redactionmaskmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedactionMaskMode { get; set; }
        }

        public class SensitiveDataConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DetectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-sensitivedataconfiguration.html#cfn-bedrock-dataautomationproject-sensitivedataconfiguration-detectionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DetectionMode { get; set; }
            /// <summary>
            /// DetectionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-sensitivedataconfiguration.html#cfn-bedrock-dataautomationproject-sensitivedataconfiguration-detectionscope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DetectionScope { get; set; }
            /// <summary>
            /// PiiEntitiesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-sensitivedataconfiguration.html#cfn-bedrock-dataautomationproject-sensitivedataconfiguration-piientitiesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PIIEntitiesConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration PiiEntitiesConfiguration { get; set; }
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
            public dynamic State { get; set; }
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
            public dynamic State { get; set; }
        }

        public class StandardOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-video
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoStandardOutputConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardOutputConfiguration Video { get; set; }
            /// <summary>
            /// Document
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-document
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentStandardOutputConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardOutputConfiguration Document { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-image
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStandardOutputConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardOutputConfiguration Image { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-standardoutputconfiguration.html#cfn-bedrock-dataautomationproject-standardoutputconfiguration-audio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioStandardOutputConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardOutputConfiguration Audio { get; set; }
        }

        public class TranscriptConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChannelLabeling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-transcriptconfiguration.html#cfn-bedrock-dataautomationproject-transcriptconfiguration-channellabeling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChannelLabelingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration ChannelLabeling { get; set; }
            /// <summary>
            /// SpeakerLabeling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-transcriptconfiguration.html#cfn-bedrock-dataautomationproject-transcriptconfiguration-speakerlabeling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpeakerLabelingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.SpeakerLabelingConfiguration SpeakerLabeling { get; set; }
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
            public dynamic State { get; set; }
        }

        public class VideoExtractionCategory : Humidifier.Base.BaseSubResource, IHaveState, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videoextractioncategory.html#cfn-bedrock-dataautomationproject-videoextractioncategory-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videoextractioncategory.html#cfn-bedrock-dataautomationproject-videoextractioncategory-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class VideoOverrideConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SensitiveDataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videooverrideconfiguration.html#cfn-bedrock-dataautomationproject-videooverrideconfiguration-sensitivedataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SensitiveDataConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration SensitiveDataConfiguration { get; set; }
            /// <summary>
            /// ModalityProcessing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videooverrideconfiguration.html#cfn-bedrock-dataautomationproject-videooverrideconfiguration-modalityprocessing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModalityProcessingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration ModalityProcessing { get; set; }
        }

        public class VideoStandardExtraction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardextraction.html#cfn-bedrock-dataautomationproject-videostandardextraction-category
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VideoExtractionCategory
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory Category { get; set; }
            /// <summary>
            /// BoundingBox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardextraction.html#cfn-bedrock-dataautomationproject-videostandardextraction-boundingbox
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VideoBoundingBox
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox BoundingBox { get; set; }
        }

        public class VideoStandardGenerativeField : Humidifier.Base.BaseSubResource, IHaveState, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardgenerativefield.html#cfn-bedrock-dataautomationproject-videostandardgenerativefield-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardgenerativefield.html#cfn-bedrock-dataautomationproject-videostandardgenerativefield-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class VideoStandardOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GenerativeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-videostandardoutputconfiguration-generativefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoStandardGenerativeField
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField GenerativeField { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationproject-videostandardoutputconfiguration.html#cfn-bedrock-dataautomationproject-videostandardoutputconfiguration-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoStandardExtraction
            /// </summary>
            public Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardExtraction Extraction { get; set; }
        }
    }
}