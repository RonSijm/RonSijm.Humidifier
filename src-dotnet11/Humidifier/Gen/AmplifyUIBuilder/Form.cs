namespace Humidifier.AmplifyUIBuilder
{
    using global::System.Collections.Generic;
    using FormTypes;

    public class Form : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFormActionType, IHaveAmplifyUIBuilderFormTypesFormCTACta, IHaveMapOfAmplifyUIBuilderFormTypesFieldConfigFields, IHaveSchemaVersion, IHaveAppId, IHaveEnvironmentName, IHaveLabelDecorator, IHaveMapOfAmplifyUIBuilderFormTypesSectionalElementSectionalElements, IHaveAmplifyUIBuilderFormTypesFormDataTypeConfigDataType, IHaveAmplifyUIBuilderFormTypesFormStyleStyle, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.AmplifyUIBuilder.Form; }
        /// <summary>
        /// FormActionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-formactiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FormActionType { get; set; }
        /// <summary>
        /// Cta
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-cta
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FormCTA
        /// </summary>
        public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA, BaseFunction>? Cta { get; set; }
        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-fields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: FieldConfig
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.FormTypes.FieldConfig>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.FormTypes.FieldConfig, BaseFunction>>, BaseFunction>? Fields { get; set; }
        /// <summary>
        /// SchemaVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-schemaversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SchemaVersion { get; set; }
        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-appid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppId { get; set; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-environmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentName { get; set; }
        /// <summary>
        /// LabelDecorator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-labeldecorator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LabelDecorator { get; set; }
        /// <summary>
        /// SectionalElements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-sectionalelements
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: SectionalElement
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.FormTypes.SectionalElement>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.FormTypes.SectionalElement, BaseFunction>>, BaseFunction>? SectionalElements { get; set; }
        /// <summary>
        /// DataType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-datatype
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FormDataTypeConfig
        /// </summary>
        public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig, BaseFunction>? DataType { get; set; }
        /// <summary>
        /// Style
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-style
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FormStyle
        /// </summary>
        public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle, BaseFunction>? Style { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-form.html#cfn-amplifyuibuilder-form-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FormTypes
    {
        public class FieldConfig : Humidifier.Base.BaseSubResource, IHaveListOfAmplifyUIBuilderFormTypesFieldValidationConfigurationValidations, IHaveAmplifyUIBuilderFormTypesFieldInputConfigInputType, IHaveAmplifyUIBuilderFormTypesFieldPositionPosition, IHaveLabel, IHaveExcluded_Boolean
        {
            /// <summary>
            /// Validations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldconfig.html#cfn-amplifyuibuilder-form-fieldconfig-validations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldValidationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.FormTypes.FieldValidationConfiguration>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.FormTypes.FieldValidationConfiguration, BaseFunction>>, BaseFunction>? Validations { get; set; }
            /// <summary>
            /// InputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldconfig.html#cfn-amplifyuibuilder-form-fieldconfig-inputtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldInputConfig
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FieldInputConfig, BaseFunction>? InputType { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldconfig.html#cfn-amplifyuibuilder-form-fieldconfig-position
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldPosition
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition, BaseFunction>? Position { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldconfig.html#cfn-amplifyuibuilder-form-fieldconfig-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// Excluded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldconfig.html#cfn-amplifyuibuilder-form-fieldconfig-excluded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Excluded { get; set; }
        }

        public class FieldInputConfig : Humidifier.Base.BaseSubResource, IHaveReadOnly_Boolean, IHavePlaceholder, IHaveAmplifyUIBuilderFormTypesFileUploaderFieldConfigFileUploaderConfig, IHaveIsArray_Boolean, IHaveAmplifyUIBuilderFormTypesValueMappingsValueMappings, IHaveDefaultCountryCode, IHaveMaxValue_Double, IHaveStep_Double, IHaveName, IHaveDefaultValue, IHaveDescriptiveText, IHaveType, IHaveRequired_Boolean, IHaveMinValue_Double, IHaveValue, IHaveDefaultChecked_Boolean
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-readonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadOnly { get; set; }
            /// <summary>
            /// Placeholder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-placeholder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Placeholder { get; set; }
            /// <summary>
            /// FileUploaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-fileuploaderconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileUploaderFieldConfig
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FileUploaderFieldConfig, BaseFunction>? FileUploaderConfig { get; set; }
            /// <summary>
            /// IsArray
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-isarray
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsArray { get; set; }
            /// <summary>
            /// ValueMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-valuemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ValueMappings
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.ValueMappings, BaseFunction>? ValueMappings { get; set; }
            /// <summary>
            /// DefaultCountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-defaultcountrycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultCountryCode { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// Step
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-step
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Step { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// DescriptiveText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-descriptivetext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DescriptiveText { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// DefaultChecked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldinputconfig.html#cfn-amplifyuibuilder-form-fieldinputconfig-defaultchecked
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DefaultChecked { get; set; }
        }

        public class FieldPosition : Humidifier.Base.BaseSubResource, IHaveBelow, IHaveRightOf, IHaveFixed
        {
            /// <summary>
            /// Below
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldposition.html#cfn-amplifyuibuilder-form-fieldposition-below
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Below { get; set; }
            /// <summary>
            /// RightOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldposition.html#cfn-amplifyuibuilder-form-fieldposition-rightof
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RightOf { get; set; }
            /// <summary>
            /// Fixed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldposition.html#cfn-amplifyuibuilder-form-fieldposition-fixed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Fixed { get; set; }
        }

        public class FieldValidationConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveValidationMessage, IHaveStringListOfStrValues, IHaveDoubleListOfNumValues
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldvalidationconfiguration.html#cfn-amplifyuibuilder-form-fieldvalidationconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ValidationMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldvalidationconfiguration.html#cfn-amplifyuibuilder-form-fieldvalidationconfiguration-validationmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidationMessage { get; set; }
            /// <summary>
            /// StrValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldvalidationconfiguration.html#cfn-amplifyuibuilder-form-fieldvalidationconfiguration-strvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StrValues { get; set; }
            /// <summary>
            /// NumValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fieldvalidationconfiguration.html#cfn-amplifyuibuilder-form-fieldvalidationconfiguration-numvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyList<double>, IReadOnlyList<Union<double, BaseFunction>>, BaseFunction>? NumValues { get; set; }
        }

        public class FileUploaderFieldConfig : Humidifier.Base.BaseSubResource, IHaveIsResumable_Boolean, IHaveShowThumbnails_Boolean, IHaveStringListOfAcceptedFileTypes, IHaveMaxFileCount_Double, IHaveMaxSize_Double, IHaveAccessLevel
        {
            /// <summary>
            /// IsResumable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fileuploaderfieldconfig.html#cfn-amplifyuibuilder-form-fileuploaderfieldconfig-isresumable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResumable { get; set; }
            /// <summary>
            /// ShowThumbnails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fileuploaderfieldconfig.html#cfn-amplifyuibuilder-form-fileuploaderfieldconfig-showthumbnails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ShowThumbnails { get; set; }
            /// <summary>
            /// AcceptedFileTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fileuploaderfieldconfig.html#cfn-amplifyuibuilder-form-fileuploaderfieldconfig-acceptedfiletypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceptedFileTypes { get; set; }
            /// <summary>
            /// MaxFileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fileuploaderfieldconfig.html#cfn-amplifyuibuilder-form-fileuploaderfieldconfig-maxfilecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxFileCount { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fileuploaderfieldconfig.html#cfn-amplifyuibuilder-form-fileuploaderfieldconfig-maxsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxSize { get; set; }
            /// <summary>
            /// AccessLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-fileuploaderfieldconfig.html#cfn-amplifyuibuilder-form-fileuploaderfieldconfig-accesslevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessLevel { get; set; }
        }

        public class FormButton : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderFormTypesFieldPositionPosition, IHaveChildren, IHaveExcluded_Boolean
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formbutton.html#cfn-amplifyuibuilder-form-formbutton-position
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldPosition
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition, BaseFunction>? Position { get; set; }
            /// <summary>
            /// Children
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formbutton.html#cfn-amplifyuibuilder-form-formbutton-children
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Children { get; set; }
            /// <summary>
            /// Excluded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formbutton.html#cfn-amplifyuibuilder-form-formbutton-excluded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Excluded { get; set; }
        }

        public class FormCTA : Humidifier.Base.BaseSubResource, IHavePosition, IHaveAmplifyUIBuilderFormTypesFormButtonCancel, IHaveAmplifyUIBuilderFormTypesFormButtonSubmit, IHaveAmplifyUIBuilderFormTypesFormButtonClear
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formcta.html#cfn-amplifyuibuilder-form-formcta-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Position { get; set; }
            /// <summary>
            /// Cancel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formcta.html#cfn-amplifyuibuilder-form-formcta-cancel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormButton
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormButton, BaseFunction>? Cancel { get; set; }
            /// <summary>
            /// Submit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formcta.html#cfn-amplifyuibuilder-form-formcta-submit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormButton
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormButton, BaseFunction>? Submit { get; set; }
            /// <summary>
            /// Clear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formcta.html#cfn-amplifyuibuilder-form-formcta-clear
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormButton
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormButton, BaseFunction>? Clear { get; set; }
        }

        public class FormDataTypeConfig : Humidifier.Base.BaseSubResource, IHaveDataSourceType, IHaveDataTypeName
        {
            /// <summary>
            /// DataSourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formdatatypeconfig.html#cfn-amplifyuibuilder-form-formdatatypeconfig-datasourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceType { get; set; }
            /// <summary>
            /// DataTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formdatatypeconfig.html#cfn-amplifyuibuilder-form-formdatatypeconfig-datatypename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTypeName { get; set; }
        }

        public class FormInputBindingPropertiesValue : Humidifier.Base.BaseSubResource, IHaveType, IHaveAmplifyUIBuilderFormTypesFormInputBindingPropertiesValuePropertiesBindingProperties
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputbindingpropertiesvalue.html#cfn-amplifyuibuilder-form-forminputbindingpropertiesvalue-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// BindingProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputbindingpropertiesvalue.html#cfn-amplifyuibuilder-form-forminputbindingpropertiesvalue-bindingproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormInputBindingPropertiesValueProperties
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormInputBindingPropertiesValueProperties, BaseFunction>? BindingProperties { get; set; }
        }

        public class FormInputBindingPropertiesValueProperties : Humidifier.Base.BaseSubResource, IHaveModel
        {
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputbindingpropertiesvalueproperties.html#cfn-amplifyuibuilder-form-forminputbindingpropertiesvalueproperties-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
        }

        public class FormInputValueProperty : Humidifier.Base.BaseSubResource, IHaveListOfAmplifyUIBuilderFormTypesFormInputValuePropertyConcat, IHaveValue, IHaveAmplifyUIBuilderFormTypesFormInputValuePropertyBindingPropertiesBindingProperties
        {
            /// <summary>
            /// Concat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputvalueproperty.html#cfn-amplifyuibuilder-form-forminputvalueproperty-concat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FormInputValueProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.FormTypes.FormInputValueProperty>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.FormTypes.FormInputValueProperty, BaseFunction>>, BaseFunction>? Concat { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputvalueproperty.html#cfn-amplifyuibuilder-form-forminputvalueproperty-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// BindingProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputvalueproperty.html#cfn-amplifyuibuilder-form-forminputvalueproperty-bindingproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormInputValuePropertyBindingProperties
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormInputValuePropertyBindingProperties, BaseFunction>? BindingProperties { get; set; }
        }

        public class FormInputValuePropertyBindingProperties : Humidifier.Base.BaseSubResource, IHaveField, IHaveProperty
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputvaluepropertybindingproperties.html#cfn-amplifyuibuilder-form-forminputvaluepropertybindingproperties-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-forminputvaluepropertybindingproperties.html#cfn-amplifyuibuilder-form-forminputvaluepropertybindingproperties-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class FormStyle : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderFormTypesFormStyleConfigVerticalGap, IHaveAmplifyUIBuilderFormTypesFormStyleConfigOuterPadding, IHaveAmplifyUIBuilderFormTypesFormStyleConfigHorizontalGap
        {
            /// <summary>
            /// VerticalGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formstyle.html#cfn-amplifyuibuilder-form-formstyle-verticalgap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormStyleConfig
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig, BaseFunction>? VerticalGap { get; set; }
            /// <summary>
            /// OuterPadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formstyle.html#cfn-amplifyuibuilder-form-formstyle-outerpadding
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormStyleConfig
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig, BaseFunction>? OuterPadding { get; set; }
            /// <summary>
            /// HorizontalGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formstyle.html#cfn-amplifyuibuilder-form-formstyle-horizontalgap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormStyleConfig
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig, BaseFunction>? HorizontalGap { get; set; }
        }

        public class FormStyleConfig : Humidifier.Base.BaseSubResource, IHaveValue, IHaveTokenReference
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formstyleconfig.html#cfn-amplifyuibuilder-form-formstyleconfig-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// TokenReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-formstyleconfig.html#cfn-amplifyuibuilder-form-formstyleconfig-tokenreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenReference { get; set; }
        }

        public class SectionalElement : Humidifier.Base.BaseSubResource, IHaveType, IHaveAmplifyUIBuilderFormTypesFieldPositionPosition, IHaveText, IHaveLevel_Double, IHaveOrientation, IHaveExcluded_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-sectionalelement.html#cfn-amplifyuibuilder-form-sectionalelement-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-sectionalelement.html#cfn-amplifyuibuilder-form-sectionalelement-position
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldPosition
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition, BaseFunction>? Position { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-sectionalelement.html#cfn-amplifyuibuilder-form-sectionalelement-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-sectionalelement.html#cfn-amplifyuibuilder-form-sectionalelement-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Level { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-sectionalelement.html#cfn-amplifyuibuilder-form-sectionalelement-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Orientation { get; set; }
            /// <summary>
            /// Excluded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-sectionalelement.html#cfn-amplifyuibuilder-form-sectionalelement-excluded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Excluded { get; set; }
        }

        public class ValueMapping : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderFormTypesFormInputValuePropertyDisplayValue, IHaveAmplifyUIBuilderFormTypesFormInputValuePropertyValue
        {
            /// <summary>
            /// DisplayValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-valuemapping.html#cfn-amplifyuibuilder-form-valuemapping-displayvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormInputValueProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormInputValueProperty, BaseFunction>? DisplayValue { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-valuemapping.html#cfn-amplifyuibuilder-form-valuemapping-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FormInputValueProperty
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.FormTypes.FormInputValueProperty, BaseFunction>? Value { get; set; }
        }

        public class ValueMappings : Humidifier.Base.BaseSubResource, IHaveMapOfAmplifyUIBuilderFormTypesFormInputBindingPropertiesValueBindingProperties, IHaveListOfAmplifyUIBuilderFormTypesValueMappingValues
        {
            /// <summary>
            /// BindingProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-valuemappings.html#cfn-amplifyuibuilder-form-valuemappings-bindingproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: FormInputBindingPropertiesValue
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.AmplifyUIBuilder.FormTypes.FormInputBindingPropertiesValue>, IReadOnlyDictionary<string, Union<Humidifier.AmplifyUIBuilder.FormTypes.FormInputBindingPropertiesValue, BaseFunction>>, BaseFunction>? BindingProperties { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-form-valuemappings.html#cfn-amplifyuibuilder-form-valuemappings-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ValueMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.FormTypes.ValueMapping>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.FormTypes.ValueMapping, BaseFunction>>, BaseFunction>? Values { get; set; }
        }
    }
}