namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using TopicTypes;

    public class Topic : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveQuickSightTopicTypesCustomInstructionsCustomInstructions, IHaveDescription, IHaveListOfQuickSightTopicTypesDatasetMetadataDataSets, IHaveAwsAccountId, IHaveStringListOfFolderArns, IHaveTopicId, IHaveUserExperienceVersion, IHaveQuickSightTopicTypesTopicConfigOptionsConfigOptions, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Topic; }
        /// <summary>
        /// CustomInstructions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-custominstructions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomInstructions
        /// </summary>
        public Union<Humidifier.QuickSight.TopicTypes.CustomInstructions, BaseFunction>? CustomInstructions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DataSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-datasets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatasetMetadata
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.DatasetMetadata>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.DatasetMetadata, BaseFunction>>, BaseFunction>? DataSets { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-folderarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FolderArns { get; set; }
        /// <summary>
        /// TopicId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-topicid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TopicId { get; set; }
        /// <summary>
        /// UserExperienceVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-userexperienceversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserExperienceVersion { get; set; }
        /// <summary>
        /// ConfigOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-configoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TopicConfigOptions
        /// </summary>
        public Union<Humidifier.QuickSight.TopicTypes.TopicConfigOptions, BaseFunction>? ConfigOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-topic.html#cfn-quicksight-topic-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TopicTypes
    {
        public class CellValueSynonym : Humidifier.Base.BaseSubResource, IHaveStringListOfSynonyms, IHaveCellValue
        {
            /// <summary>
            /// Synonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-cellvaluesynonym.html#cfn-quicksight-topic-cellvaluesynonym-synonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Synonyms { get; set; }
            /// <summary>
            /// CellValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-cellvaluesynonym.html#cfn-quicksight-topic-cellvaluesynonym-cellvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CellValue { get; set; }
        }

        public class CollectiveConstant : Humidifier.Base.BaseSubResource, IHaveStringListOfValueList
        {
            /// <summary>
            /// ValueList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-collectiveconstant.html#cfn-quicksight-topic-collectiveconstant-valuelist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ValueList { get; set; }
        }

        public class ComparativeOrder : Humidifier.Base.BaseSubResource, IHaveStringListOfSpecifedOrder, IHaveUseOrdering, IHaveTreatUndefinedSpecifiedValues
        {
            /// <summary>
            /// SpecifedOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-comparativeorder.html#cfn-quicksight-topic-comparativeorder-specifedorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SpecifedOrder { get; set; }
            /// <summary>
            /// UseOrdering
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-comparativeorder.html#cfn-quicksight-topic-comparativeorder-useordering
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOrdering { get; set; }
            /// <summary>
            /// TreatUndefinedSpecifiedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-comparativeorder.html#cfn-quicksight-topic-comparativeorder-treatundefinedspecifiedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TreatUndefinedSpecifiedValues { get; set; }
        }

        public class CustomInstructions : Humidifier.Base.BaseSubResource, IHaveCustomInstructionsString
        {
            /// <summary>
            /// CustomInstructionsString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-custominstructions.html#cfn-quicksight-topic-custominstructions-custominstructionsstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomInstructionsString { get; set; }
        }

        public class DataAggregation : Humidifier.Base.BaseSubResource, IHaveDatasetRowDateGranularity, IHaveDefaultDateColumnName
        {
            /// <summary>
            /// DatasetRowDateGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-dataaggregation.html#cfn-quicksight-topic-dataaggregation-datasetrowdategranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetRowDateGranularity { get; set; }
            /// <summary>
            /// DefaultDateColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-dataaggregation.html#cfn-quicksight-topic-dataaggregation-defaultdatecolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultDateColumnName { get; set; }
        }

        public class DatasetMetadata : Humidifier.Base.BaseSubResource, IHaveDatasetArn, IHaveListOfQuickSightTopicTypesTopicFilterFilters, IHaveListOfQuickSightTopicTypesTopicNamedEntityNamedEntities, IHaveDatasetName, IHaveListOfQuickSightTopicTypesTopicCalculatedFieldCalculatedFields, IHaveListOfQuickSightTopicTypesTopicColumnColumns, IHaveQuickSightTopicTypesDataAggregationDataAggregation, IHaveDatasetDescription
        {
            /// <summary>
            /// DatasetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetArn { get; set; }
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.TopicFilter>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.TopicFilter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// NamedEntities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-namedentities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicNamedEntity
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.TopicNamedEntity>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.TopicNamedEntity, BaseFunction>>, BaseFunction>? NamedEntities { get; set; }
            /// <summary>
            /// DatasetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-datasetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetName { get; set; }
            /// <summary>
            /// CalculatedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-calculatedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicCalculatedField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.TopicCalculatedField>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.TopicCalculatedField, BaseFunction>>, BaseFunction>? CalculatedFields { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.TopicColumn>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.TopicColumn, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// DataAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-dataaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataAggregation
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.DataAggregation, BaseFunction>? DataAggregation { get; set; }
            /// <summary>
            /// DatasetDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-datasetmetadata.html#cfn-quicksight-topic-datasetmetadata-datasetdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetDescription { get; set; }
        }

        public class DefaultFormatting : Humidifier.Base.BaseSubResource, IHaveDisplayFormat, IHaveQuickSightTopicTypesDisplayFormatOptionsDisplayFormatOptions
        {
            /// <summary>
            /// DisplayFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-defaultformatting.html#cfn-quicksight-topic-defaultformatting-displayformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayFormat { get; set; }
            /// <summary>
            /// DisplayFormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-defaultformatting.html#cfn-quicksight-topic-defaultformatting-displayformatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DisplayFormatOptions
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.DisplayFormatOptions, BaseFunction>? DisplayFormatOptions { get; set; }
        }

        public class DisplayFormatOptions : Humidifier.Base.BaseSubResource, IHaveDecimalSeparator, IHaveFractionDigits_Double, IHaveSuffix, IHaveDateFormat, IHaveUnitScaler, IHaveQuickSightTopicTypesNegativeFormatNegativeFormat, IHaveUseBlankCellFormat_Boolean, IHavePrefix, IHaveBlankCellFormat, IHaveCurrencySymbol, IHaveGroupingSeparator, IHaveUseGrouping_Boolean
        {
            /// <summary>
            /// DecimalSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-decimalseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DecimalSeparator { get; set; }
            /// <summary>
            /// FractionDigits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-fractiondigits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FractionDigits { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Suffix { get; set; }
            /// <summary>
            /// DateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-dateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateFormat { get; set; }
            /// <summary>
            /// UnitScaler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-unitscaler
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnitScaler { get; set; }
            /// <summary>
            /// NegativeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-negativeformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeFormat
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.NegativeFormat, BaseFunction>? NegativeFormat { get; set; }
            /// <summary>
            /// UseBlankCellFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-useblankcellformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseBlankCellFormat { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// BlankCellFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-blankcellformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlankCellFormat { get; set; }
            /// <summary>
            /// CurrencySymbol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-currencysymbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CurrencySymbol { get; set; }
            /// <summary>
            /// GroupingSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-groupingseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupingSeparator { get; set; }
            /// <summary>
            /// UseGrouping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-displayformatoptions.html#cfn-quicksight-topic-displayformatoptions-usegrouping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseGrouping { get; set; }
        }

        public class NamedEntityDefinition : Humidifier.Base.BaseSubResource, IHavePropertyName, IHavePropertyUsage, IHavePropertyRole, IHaveQuickSightTopicTypesNamedEntityDefinitionMetricMetric, IHaveFieldName
        {
            /// <summary>
            /// PropertyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinition.html#cfn-quicksight-topic-namedentitydefinition-propertyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyName { get; set; }
            /// <summary>
            /// PropertyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinition.html#cfn-quicksight-topic-namedentitydefinition-propertyusage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyUsage { get; set; }
            /// <summary>
            /// PropertyRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinition.html#cfn-quicksight-topic-namedentitydefinition-propertyrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyRole { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinition.html#cfn-quicksight-topic-namedentitydefinition-metric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamedEntityDefinitionMetric
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.NamedEntityDefinitionMetric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinition.html#cfn-quicksight-topic-namedentitydefinition-fieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class NamedEntityDefinitionMetric : Humidifier.Base.BaseSubResource, IHaveAggregation, IHaveStringDictionaryOfAggregationFunctionParameters
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinitionmetric.html#cfn-quicksight-topic-namedentitydefinitionmetric-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// AggregationFunctionParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-namedentitydefinitionmetric.html#cfn-quicksight-topic-namedentitydefinitionmetric-aggregationfunctionparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AggregationFunctionParameters { get; set; }
        }

        public class NegativeFormat : Humidifier.Base.BaseSubResource, IHaveSuffix, IHavePrefix
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-negativeformat.html#cfn-quicksight-topic-negativeformat-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Suffix { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-negativeformat.html#cfn-quicksight-topic-negativeformat-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class RangeConstant : Humidifier.Base.BaseSubResource, IHaveMinimum, IHaveMaximum
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-rangeconstant.html#cfn-quicksight-topic-rangeconstant-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-rangeconstant.html#cfn-quicksight-topic-rangeconstant-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Maximum { get; set; }
        }

        public class SemanticEntityType : Humidifier.Base.BaseSubResource, IHaveTypeName, IHaveStringDictionaryOfTypeParameters, IHaveSubTypeName
        {
            /// <summary>
            /// TypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semanticentitytype.html#cfn-quicksight-topic-semanticentitytype-typename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeName { get; set; }
            /// <summary>
            /// TypeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semanticentitytype.html#cfn-quicksight-topic-semanticentitytype-typeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TypeParameters { get; set; }
            /// <summary>
            /// SubTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semanticentitytype.html#cfn-quicksight-topic-semanticentitytype-subtypename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubTypeName { get; set; }
        }

        public class SemanticType : Humidifier.Base.BaseSubResource, IHaveStringListOfTruthyCellValueSynonyms, IHaveTypeName, IHaveStringDictionaryOfTypeParameters, IHaveSubTypeName, IHaveTruthyCellValue, IHaveFalseyCellValue, IHaveStringListOfFalseyCellValueSynonyms
        {
            /// <summary>
            /// TruthyCellValueSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-truthycellvaluesynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TruthyCellValueSynonyms { get; set; }
            /// <summary>
            /// TypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-typename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeName { get; set; }
            /// <summary>
            /// TypeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-typeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TypeParameters { get; set; }
            /// <summary>
            /// SubTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-subtypename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubTypeName { get; set; }
            /// <summary>
            /// TruthyCellValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-truthycellvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TruthyCellValue { get; set; }
            /// <summary>
            /// FalseyCellValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-falseycellvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FalseyCellValue { get; set; }
            /// <summary>
            /// FalseyCellValueSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-semantictype.html#cfn-quicksight-topic-semantictype-falseycellvaluesynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FalseyCellValueSynonyms { get; set; }
        }

        public class TopicCalculatedField : Humidifier.Base.BaseSubResource, IHaveQuickSightTopicTypesSemanticTypeSemanticType, IHaveStringListOfNotAllowedAggregations, IHaveQuickSightTopicTypesDefaultFormattingDefaultFormatting, IHaveStringListOfAllowedAggregations, IHaveCalculatedFieldDescription, IHaveStringListOfCalculatedFieldSynonyms, IHaveIsIncludedInTopic_Boolean, IHaveColumnDataRole, IHaveAggregation, IHaveExpression, IHaveNonAdditive_Boolean, IHaveCalculatedFieldName, IHaveNeverAggregateInFilter_Boolean, IHaveTimeGranularity, IHaveDisableIndexing_Boolean, IHaveQuickSightTopicTypesComparativeOrderComparativeOrder, IHaveListOfQuickSightTopicTypesCellValueSynonymCellValueSynonyms
        {
            /// <summary>
            /// SemanticType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-semantictype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticType
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.SemanticType, BaseFunction>? SemanticType { get; set; }
            /// <summary>
            /// NotAllowedAggregations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-notallowedaggregations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotAllowedAggregations { get; set; }
            /// <summary>
            /// DefaultFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-defaultformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFormatting
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.DefaultFormatting, BaseFunction>? DefaultFormatting { get; set; }
            /// <summary>
            /// AllowedAggregations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-allowedaggregations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAggregations { get; set; }
            /// <summary>
            /// CalculatedFieldDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-calculatedfielddescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CalculatedFieldDescription { get; set; }
            /// <summary>
            /// CalculatedFieldSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-calculatedfieldsynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CalculatedFieldSynonyms { get; set; }
            /// <summary>
            /// IsIncludedInTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-isincludedintopic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsIncludedInTopic { get; set; }
            /// <summary>
            /// ColumnDataRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-columndatarole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnDataRole { get; set; }
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// NonAdditive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-nonadditive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NonAdditive { get; set; }
            /// <summary>
            /// CalculatedFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-calculatedfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CalculatedFieldName { get; set; }
            /// <summary>
            /// NeverAggregateInFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-neveraggregateinfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NeverAggregateInFilter { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeGranularity { get; set; }
            /// <summary>
            /// DisableIndexing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-disableindexing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableIndexing { get; set; }
            /// <summary>
            /// ComparativeOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-comparativeorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparativeOrder
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.ComparativeOrder, BaseFunction>? ComparativeOrder { get; set; }
            /// <summary>
            /// CellValueSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccalculatedfield.html#cfn-quicksight-topic-topiccalculatedfield-cellvaluesynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CellValueSynonym
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.CellValueSynonym>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.CellValueSynonym, BaseFunction>>, BaseFunction>? CellValueSynonyms { get; set; }
        }

        public class TopicCategoryFilter : Humidifier.Base.BaseSubResource, IHaveCategoryFilterType, IHaveCategoryFilterFunction, IHaveQuickSightTopicTypesTopicCategoryFilterConstantConstant, IHaveInverse_Boolean
        {
            /// <summary>
            /// CategoryFilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilter.html#cfn-quicksight-topic-topiccategoryfilter-categoryfiltertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CategoryFilterType { get; set; }
            /// <summary>
            /// CategoryFilterFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilter.html#cfn-quicksight-topic-topiccategoryfilter-categoryfilterfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CategoryFilterFunction { get; set; }
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilter.html#cfn-quicksight-topic-topiccategoryfilter-constant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicCategoryFilterConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicCategoryFilterConstant, BaseFunction>? Constant { get; set; }
            /// <summary>
            /// Inverse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilter.html#cfn-quicksight-topic-topiccategoryfilter-inverse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Inverse { get; set; }
        }

        public class TopicCategoryFilterConstant : Humidifier.Base.BaseSubResource, IHaveSingularConstant, IHaveConstantType, IHaveQuickSightTopicTypesCollectiveConstantCollectiveConstant
        {
            /// <summary>
            /// SingularConstant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilterconstant.html#cfn-quicksight-topic-topiccategoryfilterconstant-singularconstant
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SingularConstant { get; set; }
            /// <summary>
            /// ConstantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilterconstant.html#cfn-quicksight-topic-topiccategoryfilterconstant-constanttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantType { get; set; }
            /// <summary>
            /// CollectiveConstant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccategoryfilterconstant.html#cfn-quicksight-topic-topiccategoryfilterconstant-collectiveconstant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CollectiveConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.CollectiveConstant, BaseFunction>? CollectiveConstant { get; set; }
        }

        public class TopicColumn : Humidifier.Base.BaseSubResource, IHaveQuickSightTopicTypesSemanticTypeSemanticType, IHaveStringListOfNotAllowedAggregations, IHaveStringListOfAllowedAggregations, IHaveQuickSightTopicTypesDefaultFormattingDefaultFormatting, IHaveColumnDescription, IHaveIsIncludedInTopic_Boolean, IHaveColumnDataRole, IHaveAggregation, IHaveColumnName, IHaveNonAdditive_Boolean, IHaveStringListOfColumnSynonyms, IHaveNeverAggregateInFilter_Boolean, IHaveTimeGranularity, IHaveColumnFriendlyName, IHaveDisableIndexing_Boolean, IHaveQuickSightTopicTypesComparativeOrderComparativeOrder, IHaveListOfQuickSightTopicTypesCellValueSynonymCellValueSynonyms
        {
            /// <summary>
            /// SemanticType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-semantictype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticType
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.SemanticType, BaseFunction>? SemanticType { get; set; }
            /// <summary>
            /// NotAllowedAggregations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-notallowedaggregations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotAllowedAggregations { get; set; }
            /// <summary>
            /// AllowedAggregations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-allowedaggregations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAggregations { get; set; }
            /// <summary>
            /// DefaultFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-defaultformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFormatting
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.DefaultFormatting, BaseFunction>? DefaultFormatting { get; set; }
            /// <summary>
            /// ColumnDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-columndescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnDescription { get; set; }
            /// <summary>
            /// IsIncludedInTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-isincludedintopic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsIncludedInTopic { get; set; }
            /// <summary>
            /// ColumnDataRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-columndatarole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnDataRole { get; set; }
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// NonAdditive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-nonadditive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NonAdditive { get; set; }
            /// <summary>
            /// ColumnSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-columnsynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnSynonyms { get; set; }
            /// <summary>
            /// NeverAggregateInFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-neveraggregateinfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NeverAggregateInFilter { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeGranularity { get; set; }
            /// <summary>
            /// ColumnFriendlyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-columnfriendlyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnFriendlyName { get; set; }
            /// <summary>
            /// DisableIndexing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-disableindexing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableIndexing { get; set; }
            /// <summary>
            /// ComparativeOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-comparativeorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparativeOrder
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.ComparativeOrder, BaseFunction>? ComparativeOrder { get; set; }
            /// <summary>
            /// CellValueSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topiccolumn.html#cfn-quicksight-topic-topiccolumn-cellvaluesynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CellValueSynonym
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.CellValueSynonym>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.CellValueSynonym, BaseFunction>>, BaseFunction>? CellValueSynonyms { get; set; }
        }

        public class TopicConfigOptions : Humidifier.Base.BaseSubResource, IHaveQBusinessInsightsEnabled_Boolean
        {
            /// <summary>
            /// QBusinessInsightsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicconfigoptions.html#cfn-quicksight-topic-topicconfigoptions-qbusinessinsightsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QBusinessInsightsEnabled { get; set; }
        }

        public class TopicDateRangeFilter : Humidifier.Base.BaseSubResource, IHaveInclusive_Boolean, IHaveQuickSightTopicTypesTopicRangeFilterConstantConstant
        {
            /// <summary>
            /// Inclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicdaterangefilter.html#cfn-quicksight-topic-topicdaterangefilter-inclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Inclusive { get; set; }
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicdaterangefilter.html#cfn-quicksight-topic-topicdaterangefilter-constant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicRangeFilterConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicRangeFilterConstant, BaseFunction>? Constant { get; set; }
        }

        public class TopicFilter : Humidifier.Base.BaseSubResource, IHaveFilterClass, IHaveStringListOfFilterSynonyms, IHaveFilterType, IHaveQuickSightTopicTypesTopicRelativeDateFilterRelativeDateFilter, IHaveOperandFieldName, IHaveQuickSightTopicTypesTopicNumericEqualityFilterNumericEqualityFilter, IHaveFilterDescription, IHaveQuickSightTopicTypesTopicNumericRangeFilterNumericRangeFilter, IHaveQuickSightTopicTypesTopicDateRangeFilterDateRangeFilter, IHaveFilterName, IHaveQuickSightTopicTypesTopicCategoryFilterCategoryFilter
        {
            /// <summary>
            /// FilterClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-filterclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterClass { get; set; }
            /// <summary>
            /// FilterSynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-filtersynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FilterSynonyms { get; set; }
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-filtertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterType { get; set; }
            /// <summary>
            /// RelativeDateFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-relativedatefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicRelativeDateFilter
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicRelativeDateFilter, BaseFunction>? RelativeDateFilter { get; set; }
            /// <summary>
            /// OperandFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-operandfieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperandFieldName { get; set; }
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicNumericEqualityFilter
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicNumericEqualityFilter, BaseFunction>? NumericEqualityFilter { get; set; }
            /// <summary>
            /// FilterDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-filterdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterDescription { get; set; }
            /// <summary>
            /// NumericRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-numericrangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicNumericRangeFilter
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicNumericRangeFilter, BaseFunction>? NumericRangeFilter { get; set; }
            /// <summary>
            /// DateRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-daterangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicDateRangeFilter
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicDateRangeFilter, BaseFunction>? DateRangeFilter { get; set; }
            /// <summary>
            /// FilterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-filtername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterName { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicfilter.html#cfn-quicksight-topic-topicfilter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicCategoryFilter
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicCategoryFilter, BaseFunction>? CategoryFilter { get; set; }
        }

        public class TopicNamedEntity : Humidifier.Base.BaseSubResource, IHaveStringListOfEntitySynonyms, IHaveEntityName, IHaveQuickSightTopicTypesSemanticEntityTypeSemanticEntityType, IHaveEntityDescription, IHaveListOfQuickSightTopicTypesNamedEntityDefinitionDefinition
        {
            /// <summary>
            /// EntitySynonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnamedentity.html#cfn-quicksight-topic-topicnamedentity-entitysynonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntitySynonyms { get; set; }
            /// <summary>
            /// EntityName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnamedentity.html#cfn-quicksight-topic-topicnamedentity-entityname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityName { get; set; }
            /// <summary>
            /// SemanticEntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnamedentity.html#cfn-quicksight-topic-topicnamedentity-semanticentitytype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticEntityType
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.SemanticEntityType, BaseFunction>? SemanticEntityType { get; set; }
            /// <summary>
            /// EntityDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnamedentity.html#cfn-quicksight-topic-topicnamedentity-entitydescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityDescription { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnamedentity.html#cfn-quicksight-topic-topicnamedentity-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NamedEntityDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.TopicTypes.NamedEntityDefinition>, IReadOnlyList<Union<Humidifier.QuickSight.TopicTypes.NamedEntityDefinition, BaseFunction>>, BaseFunction>? Definition { get; set; }
        }

        public class TopicNumericEqualityFilter : Humidifier.Base.BaseSubResource, IHaveAggregation, IHaveQuickSightTopicTypesTopicSingularFilterConstantConstant
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnumericequalityfilter.html#cfn-quicksight-topic-topicnumericequalityfilter-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnumericequalityfilter.html#cfn-quicksight-topic-topicnumericequalityfilter-constant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicSingularFilterConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicSingularFilterConstant, BaseFunction>? Constant { get; set; }
        }

        public class TopicNumericRangeFilter : Humidifier.Base.BaseSubResource, IHaveAggregation, IHaveInclusive_Boolean, IHaveQuickSightTopicTypesTopicRangeFilterConstantConstant
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnumericrangefilter.html#cfn-quicksight-topic-topicnumericrangefilter-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// Inclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnumericrangefilter.html#cfn-quicksight-topic-topicnumericrangefilter-inclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Inclusive { get; set; }
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicnumericrangefilter.html#cfn-quicksight-topic-topicnumericrangefilter-constant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicRangeFilterConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicRangeFilterConstant, BaseFunction>? Constant { get; set; }
        }

        public class TopicRangeFilterConstant : Humidifier.Base.BaseSubResource, IHaveConstantType, IHaveQuickSightTopicTypesRangeConstantRangeConstant
        {
            /// <summary>
            /// ConstantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicrangefilterconstant.html#cfn-quicksight-topic-topicrangefilterconstant-constanttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantType { get; set; }
            /// <summary>
            /// RangeConstant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicrangefilterconstant.html#cfn-quicksight-topic-topicrangefilterconstant-rangeconstant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangeConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.RangeConstant, BaseFunction>? RangeConstant { get; set; }
        }

        public class TopicRelativeDateFilter : Humidifier.Base.BaseSubResource, IHaveRelativeDateFilterFunction, IHaveQuickSightTopicTypesTopicSingularFilterConstantConstant, IHaveTimeGranularity
        {
            /// <summary>
            /// RelativeDateFilterFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicrelativedatefilter.html#cfn-quicksight-topic-topicrelativedatefilter-relativedatefilterfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelativeDateFilterFunction { get; set; }
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicrelativedatefilter.html#cfn-quicksight-topic-topicrelativedatefilter-constant
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicSingularFilterConstant
            /// </summary>
            public Union<Humidifier.QuickSight.TopicTypes.TopicSingularFilterConstant, BaseFunction>? Constant { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicrelativedatefilter.html#cfn-quicksight-topic-topicrelativedatefilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeGranularity { get; set; }
        }

        public class TopicSingularFilterConstant : Humidifier.Base.BaseSubResource, IHaveSingularConstant, IHaveConstantType
        {
            /// <summary>
            /// SingularConstant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicsingularfilterconstant.html#cfn-quicksight-topic-topicsingularfilterconstant-singularconstant
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SingularConstant { get; set; }
            /// <summary>
            /// ConstantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-topic-topicsingularfilterconstant.html#cfn-quicksight-topic-topicsingularfilterconstant-constanttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantType { get; set; }
        }
    }
}