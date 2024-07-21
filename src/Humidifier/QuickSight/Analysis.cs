namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using AnalysisTypes;

    public class Analysis : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string DataSetArns =  "DataSetArns" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::QuickSight::Analysis";
            }
        }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Parameters
        /// </summary>
        public Parameters Parameters { get; set; }
        /// <summary>
        /// SourceEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-sourceentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalysisSourceEntity
        /// </summary>
        public AnalysisSourceEntity SourceEntity { get; set; }
        /// <summary>
        /// ThemeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-themearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThemeArn { get; set; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-definition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalysisDefinition
        /// </summary>
        public AnalysisDefinition Definition { get; set; }
        /// <summary>
        /// ValidationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-validationstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ValidationStrategy
        /// </summary>
        public ValidationStrategy ValidationStrategy { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
        /// <summary>
        /// Errors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-errors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AnalysisError
        /// </summary>
        public List<AnalysisError> Errors { get; set; }
        /// <summary>
        /// AnalysisId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-analysisid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AnalysisId { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Sheets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-sheets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Sheet
        /// </summary>
        public List<Sheet> Sheets { get; set; }
    }

    namespace AnalysisTypes
    {
        public class AggregationFunction
        {
            /// <summary>
            /// AttributeAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationfunction.html#cfn-quicksight-analysis-aggregationfunction-attributeaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeAggregationFunction
            /// </summary>
            public AttributeAggregationFunction AttributeAggregationFunction { get; set; }
            /// <summary>
            /// DateAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationfunction.html#cfn-quicksight-analysis-aggregationfunction-dateaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateAggregationFunction { get; set; }
            /// <summary>
            /// NumericalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationfunction.html#cfn-quicksight-analysis-aggregationfunction-numericalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public NumericalAggregationFunction NumericalAggregationFunction { get; set; }
            /// <summary>
            /// CategoricalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationfunction.html#cfn-quicksight-analysis-aggregationfunction-categoricalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoricalAggregationFunction { get; set; }
        }

        public class AggregationSortConfiguration
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationsortconfiguration.html#cfn-quicksight-analysis-aggregationsortconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortDirection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationsortconfiguration.html#cfn-quicksight-analysis-aggregationsortconfiguration-sortdirection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortDirection { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationsortconfiguration.html#cfn-quicksight-analysis-aggregationsortconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
        }

        public class AnalysisDefaults
        {
            /// <summary>
            /// DefaultNewSheetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefaults.html#cfn-quicksight-analysis-analysisdefaults-defaultnewsheetconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultNewSheetConfiguration
            /// </summary>
            public DefaultNewSheetConfiguration DefaultNewSheetConfiguration { get; set; }
        }

        public class AnalysisDefinition
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetOptions
            /// </summary>
            public AssetOptions Options { get; set; }
            /// <summary>
            /// FilterGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-filtergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterGroup
            /// </summary>
            public List<FilterGroup> FilterGroups { get; set; }
            /// <summary>
            /// CalculatedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-calculatedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedField
            /// </summary>
            public List<CalculatedField> CalculatedFields { get; set; }
            /// <summary>
            /// DataSetIdentifierDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-datasetidentifierdeclarations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetIdentifierDeclaration
            /// </summary>
            public List<DataSetIdentifierDeclaration> DataSetIdentifierDeclarations { get; set; }
            /// <summary>
            /// ColumnConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-columnconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnConfiguration
            /// </summary>
            public List<ColumnConfiguration> ColumnConfigurations { get; set; }
            /// <summary>
            /// AnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-analysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisDefaults
            /// </summary>
            public AnalysisDefaults AnalysisDefaults { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetDefinition
            /// </summary>
            public List<SheetDefinition> Sheets { get; set; }
            /// <summary>
            /// ParameterDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-parameterdeclarations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterDeclaration
            /// </summary>
            public List<ParameterDeclaration> ParameterDeclarations { get; set; }
        }

        public class AnalysisError
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysiserror.html#cfn-quicksight-analysis-analysiserror-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysiserror.html#cfn-quicksight-analysis-analysiserror-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// ViolatedEntities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysiserror.html#cfn-quicksight-analysis-analysiserror-violatedentities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Entity
            /// </summary>
            public List<Entity> ViolatedEntities { get; set; }
        }

        public class AnalysisSourceEntity
        {
            /// <summary>
            /// SourceTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourceentity.html#cfn-quicksight-analysis-analysissourceentity-sourcetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisSourceTemplate
            /// </summary>
            public AnalysisSourceTemplate SourceTemplate { get; set; }
        }

        public class AnalysisSourceTemplate
        {
            /// <summary>
            /// DataSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourcetemplate.html#cfn-quicksight-analysis-analysissourcetemplate-datasetreferences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetReference
            /// </summary>
            public List<DataSetReference> DataSetReferences { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourcetemplate.html#cfn-quicksight-analysis-analysissourcetemplate-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class AnchorDateConfiguration
        {
            /// <summary>
            /// AnchorOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-anchordateconfiguration.html#cfn-quicksight-analysis-anchordateconfiguration-anchoroption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnchorOption { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-anchordateconfiguration.html#cfn-quicksight-analysis-anchordateconfiguration-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
        }

        public class ArcAxisConfiguration
        {
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcaxisconfiguration.html#cfn-quicksight-analysis-arcaxisconfiguration-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisDisplayRange
            /// </summary>
            public ArcAxisDisplayRange Range { get; set; }
            /// <summary>
            /// ReserveRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcaxisconfiguration.html#cfn-quicksight-analysis-arcaxisconfiguration-reserverange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ReserveRange { get; set; }
        }

        public class ArcAxisDisplayRange
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcaxisdisplayrange.html#cfn-quicksight-analysis-arcaxisdisplayrange-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcaxisdisplayrange.html#cfn-quicksight-analysis-arcaxisdisplayrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class ArcConfiguration
        {
            /// <summary>
            /// ArcAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcconfiguration.html#cfn-quicksight-analysis-arcconfiguration-arcangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ArcAngle { get; set; }
            /// <summary>
            /// ArcThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcconfiguration.html#cfn-quicksight-analysis-arcconfiguration-arcthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArcThickness { get; set; }
        }

        public class ArcOptions
        {
            /// <summary>
            /// ArcThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcoptions.html#cfn-quicksight-analysis-arcoptions-arcthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArcThickness { get; set; }
        }

        public class AssetOptions
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-assetoptions.html#cfn-quicksight-analysis-assetoptions-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// WeekStart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-assetoptions.html#cfn-quicksight-analysis-assetoptions-weekstart
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WeekStart { get; set; }
        }

        public class AttributeAggregationFunction
        {
            /// <summary>
            /// SimpleAttributeAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-attributeaggregationfunction.html#cfn-quicksight-analysis-attributeaggregationfunction-simpleattributeaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleAttributeAggregation { get; set; }
            /// <summary>
            /// ValueForMultipleValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-attributeaggregationfunction.html#cfn-quicksight-analysis-attributeaggregationfunction-valueformultiplevalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueForMultipleValues { get; set; }
        }

        public class AxisDataOptions
        {
            /// <summary>
            /// DateAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdataoptions.html#cfn-quicksight-analysis-axisdataoptions-dateaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateAxisOptions
            /// </summary>
            public DateAxisOptions DateAxisOptions { get; set; }
            /// <summary>
            /// NumericAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdataoptions.html#cfn-quicksight-analysis-axisdataoptions-numericaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericAxisOptions
            /// </summary>
            public NumericAxisOptions NumericAxisOptions { get; set; }
        }

        public class AxisDisplayMinMaxRange
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayminmaxrange.html#cfn-quicksight-analysis-axisdisplayminmaxrange-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayminmaxrange.html#cfn-quicksight-analysis-axisdisplayminmaxrange-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Maximum { get; set; }
        }

        public class AxisDisplayOptions
        {
            /// <summary>
            /// DataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-dataoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDataOptions
            /// </summary>
            public AxisDataOptions DataOptions { get; set; }
            /// <summary>
            /// TickLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-ticklabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisTickLabelOptions
            /// </summary>
            public AxisTickLabelOptions TickLabelOptions { get; set; }
            /// <summary>
            /// AxisOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-axisoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisOffset { get; set; }
            /// <summary>
            /// AxisLineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-axislinevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisLineVisibility { get; set; }
            /// <summary>
            /// GridLineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-gridlinevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GridLineVisibility { get; set; }
            /// <summary>
            /// ScrollbarOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-scrollbaroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScrollBarOptions
            /// </summary>
            public ScrollBarOptions ScrollbarOptions { get; set; }
        }

        public class AxisDisplayRange
        {
            /// <summary>
            /// DataDriven
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayrange.html#cfn-quicksight-analysis-axisdisplayrange-datadriven
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic DataDriven { get; set; }
            /// <summary>
            /// MinMax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayrange.html#cfn-quicksight-analysis-axisdisplayrange-minmax
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayMinMaxRange
            /// </summary>
            public AxisDisplayMinMaxRange MinMax { get; set; }
        }

        public class AxisLabelOptions
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabeloptions.html#cfn-quicksight-analysis-axislabeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ApplyTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabeloptions.html#cfn-quicksight-analysis-axislabeloptions-applyto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLabelReferenceOptions
            /// </summary>
            public AxisLabelReferenceOptions ApplyTo { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabeloptions.html#cfn-quicksight-analysis-axislabeloptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
        }

        public class AxisLabelReferenceOptions
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabelreferenceoptions.html#cfn-quicksight-analysis-axislabelreferenceoptions-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabelreferenceoptions.html#cfn-quicksight-analysis-axislabelreferenceoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class AxisLinearScale
        {
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislinearscale.html#cfn-quicksight-analysis-axislinearscale-stepsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// StepCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislinearscale.html#cfn-quicksight-analysis-axislinearscale-stepcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepCount { get; set; }
        }

        public class AxisLogarithmicScale
        {
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislogarithmicscale.html#cfn-quicksight-analysis-axislogarithmicscale-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Base { get; set; }
        }

        public class AxisScale
        {
            /// <summary>
            /// Logarithmic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisscale.html#cfn-quicksight-analysis-axisscale-logarithmic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLogarithmicScale
            /// </summary>
            public AxisLogarithmicScale Logarithmic { get; set; }
            /// <summary>
            /// Linear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisscale.html#cfn-quicksight-analysis-axisscale-linear
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLinearScale
            /// </summary>
            public AxisLinearScale Linear { get; set; }
        }

        public class AxisTickLabelOptions
        {
            /// <summary>
            /// RotationAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisticklabeloptions.html#cfn-quicksight-analysis-axisticklabeloptions-rotationangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RotationAngle { get; set; }
            /// <summary>
            /// LabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisticklabeloptions.html#cfn-quicksight-analysis-axisticklabeloptions-labeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions LabelOptions { get; set; }
        }

        public class BarChartAggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> SmallMultiples { get; set; }
        }

        public class BarChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartSortConfiguration
            /// </summary>
            public BarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Orientation { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// BarsArrangement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-barsarrangement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BarsArrangement { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartFieldWells
            /// </summary>
            public BarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ValueAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-valueaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions ValueAxis { get; set; }
        }

        public class BarChartFieldWells
        {
            /// <summary>
            /// BarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartfieldwells.html#cfn-quicksight-analysis-barchartfieldwells-barchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartAggregatedFieldWells
            /// </summary>
            public BarChartAggregatedFieldWells BarChartAggregatedFieldWells { get; set; }
        }

        public class BarChartSortConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class BarChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartConfiguration
            /// </summary>
            public BarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class BinCountOptions
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bincountoptions.html#cfn-quicksight-analysis-bincountoptions-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class BinWidthOptions
        {
            /// <summary>
            /// BinCountLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-binwidthoptions.html#cfn-quicksight-analysis-binwidthoptions-bincountlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BinCountLimit { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-binwidthoptions.html#cfn-quicksight-analysis-binwidthoptions-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class BodySectionConfiguration
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BodySectionContent
            /// </summary>
            public BodySectionContent Content { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public SectionStyle Style { get; set; }
            /// <summary>
            /// PageBreakConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-pagebreakconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionPageBreakConfiguration
            /// </summary>
            public SectionPageBreakConfiguration PageBreakConfiguration { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-sectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SectionId { get; set; }
        }

        public class BodySectionContent
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectioncontent.html#cfn-quicksight-analysis-bodysectioncontent-layout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public SectionLayoutConfiguration Layout { get; set; }
        }

        public class BoxPlotAggregatedFieldWells
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotaggregatedfieldwells.html#cfn-quicksight-analysis-boxplotaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotaggregatedfieldwells.html#cfn-quicksight-analysis-boxplotaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class BoxPlotChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotSortConfiguration
            /// </summary>
            public BoxPlotSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotFieldWells
            /// </summary>
            public BoxPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// BoxPlotOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-boxplotoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotOptions
            /// </summary>
            public BoxPlotOptions BoxPlotOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
        }

        public class BoxPlotFieldWells
        {
            /// <summary>
            /// BoxPlotAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotfieldwells.html#cfn-quicksight-analysis-boxplotfieldwells-boxplotaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotAggregatedFieldWells
            /// </summary>
            public BoxPlotAggregatedFieldWells BoxPlotAggregatedFieldWells { get; set; }
        }

        public class BoxPlotOptions
        {
            /// <summary>
            /// StyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotoptions.html#cfn-quicksight-analysis-boxplotoptions-styleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotStyleOptions
            /// </summary>
            public BoxPlotStyleOptions StyleOptions { get; set; }
            /// <summary>
            /// OutlierVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotoptions.html#cfn-quicksight-analysis-boxplotoptions-outliervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutlierVisibility { get; set; }
            /// <summary>
            /// AllDataPointsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotoptions.html#cfn-quicksight-analysis-boxplotoptions-alldatapointsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllDataPointsVisibility { get; set; }
        }

        public class BoxPlotSortConfiguration
        {
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotsortconfiguration.html#cfn-quicksight-analysis-boxplotsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotsortconfiguration.html#cfn-quicksight-analysis-boxplotsortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class BoxPlotStyleOptions
        {
            /// <summary>
            /// FillStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotstyleoptions.html#cfn-quicksight-analysis-boxplotstyleoptions-fillstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FillStyle { get; set; }
        }

        public class BoxPlotVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotChartConfiguration
            /// </summary>
            public BoxPlotChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class CalculatedField
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-calculatedfield.html#cfn-quicksight-analysis-calculatedfield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-calculatedfield.html#cfn-quicksight-analysis-calculatedfield-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-calculatedfield.html#cfn-quicksight-analysis-calculatedfield-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CalculatedMeasureField
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-calculatedmeasurefield.html#cfn-quicksight-analysis-calculatedmeasurefield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-calculatedmeasurefield.html#cfn-quicksight-analysis-calculatedmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CascadingControlConfiguration
        {
            /// <summary>
            /// SourceControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-cascadingcontrolconfiguration.html#cfn-quicksight-analysis-cascadingcontrolconfiguration-sourcecontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CascadingControlSource
            /// </summary>
            public List<CascadingControlSource> SourceControls { get; set; }
        }

        public class CascadingControlSource
        {
            /// <summary>
            /// SourceSheetControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-cascadingcontrolsource.html#cfn-quicksight-analysis-cascadingcontrolsource-sourcesheetcontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceSheetControlId { get; set; }
            /// <summary>
            /// ColumnToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-cascadingcontrolsource.html#cfn-quicksight-analysis-cascadingcontrolsource-columntomatch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier ColumnToMatch { get; set; }
        }

        public class CategoricalDimensionField
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricaldimensionfield.html#cfn-quicksight-analysis-categoricaldimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricaldimensionfield.html#cfn-quicksight-analysis-categoricaldimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricaldimensionfield.html#cfn-quicksight-analysis-categoricaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricaldimensionfield.html#cfn-quicksight-analysis-categoricaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoricalMeasureField
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricalmeasurefield.html#cfn-quicksight-analysis-categoricalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricalmeasurefield.html#cfn-quicksight-analysis-categoricalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricalmeasurefield.html#cfn-quicksight-analysis-categoricalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricalmeasurefield.html#cfn-quicksight-analysis-categoricalmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoryDrillDownFilter
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categorydrilldownfilter.html#cfn-quicksight-analysis-categorydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categorydrilldownfilter.html#cfn-quicksight-analysis-categorydrilldownfilter-categoryvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
        }

        public class CategoryFilter
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class CategoryFilterConfiguration
        {
            /// <summary>
            /// CustomFilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilterconfiguration.html#cfn-quicksight-analysis-categoryfilterconfiguration-customfilterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterListConfiguration
            /// </summary>
            public CustomFilterListConfiguration CustomFilterListConfiguration { get; set; }
            /// <summary>
            /// CustomFilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilterconfiguration.html#cfn-quicksight-analysis-categoryfilterconfiguration-customfilterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterConfiguration
            /// </summary>
            public CustomFilterConfiguration CustomFilterConfiguration { get; set; }
            /// <summary>
            /// FilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilterconfiguration.html#cfn-quicksight-analysis-categoryfilterconfiguration-filterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListConfiguration
            /// </summary>
            public FilterListConfiguration FilterListConfiguration { get; set; }
        }

        public class ChartAxisLabelOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-chartaxislabeloptions.html#cfn-quicksight-analysis-chartaxislabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// SortIconVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-chartaxislabeloptions.html#cfn-quicksight-analysis-chartaxislabeloptions-sorticonvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortIconVisibility { get; set; }
            /// <summary>
            /// AxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-chartaxislabeloptions.html#cfn-quicksight-analysis-chartaxislabeloptions-axislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AxisLabelOptions
            /// </summary>
            public List<AxisLabelOptions> AxisLabelOptions { get; set; }
        }

        public class ClusterMarker
        {
            /// <summary>
            /// SimpleClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-clustermarker.html#cfn-quicksight-analysis-clustermarker-simpleclustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SimpleClusterMarker
            /// </summary>
            public SimpleClusterMarker SimpleClusterMarker { get; set; }
        }

        public class ClusterMarkerConfiguration
        {
            /// <summary>
            /// ClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-clustermarkerconfiguration.html#cfn-quicksight-analysis-clustermarkerconfiguration-clustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarker
            /// </summary>
            public ClusterMarker ClusterMarker { get; set; }
        }

        public class ColorScale
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-colorscale.html#cfn-quicksight-analysis-colorscale-colors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataColor
            /// </summary>
            public List<DataColor> Colors { get; set; }
            /// <summary>
            /// ColorFillType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-colorscale.html#cfn-quicksight-analysis-colorscale-colorfilltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorFillType { get; set; }
            /// <summary>
            /// NullValueColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-colorscale.html#cfn-quicksight-analysis-colorscale-nullvaluecolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataColor
            /// </summary>
            public DataColor NullValueColor { get; set; }
        }

        public class ColorsConfiguration
        {
            /// <summary>
            /// CustomColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-colorsconfiguration.html#cfn-quicksight-analysis-colorsconfiguration-customcolors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomColor
            /// </summary>
            public List<CustomColor> CustomColors { get; set; }
        }

        public class ColumnConfiguration
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnconfiguration.html#cfn-quicksight-analysis-columnconfiguration-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnconfiguration.html#cfn-quicksight-analysis-columnconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnconfiguration.html#cfn-quicksight-analysis-columnconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// ColorsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnconfiguration.html#cfn-quicksight-analysis-columnconfiguration-colorsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorsConfiguration
            /// </summary>
            public ColorsConfiguration ColorsConfiguration { get; set; }
        }

        public class ColumnHierarchy
        {
            /// <summary>
            /// DateTimeHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnhierarchy.html#cfn-quicksight-analysis-columnhierarchy-datetimehierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeHierarchy
            /// </summary>
            public DateTimeHierarchy DateTimeHierarchy { get; set; }
            /// <summary>
            /// ExplicitHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnhierarchy.html#cfn-quicksight-analysis-columnhierarchy-explicithierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExplicitHierarchy
            /// </summary>
            public ExplicitHierarchy ExplicitHierarchy { get; set; }
            /// <summary>
            /// PredefinedHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnhierarchy.html#cfn-quicksight-analysis-columnhierarchy-predefinedhierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedHierarchy
            /// </summary>
            public PredefinedHierarchy PredefinedHierarchy { get; set; }
        }

        public class ColumnIdentifier
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnidentifier.html#cfn-quicksight-analysis-columnidentifier-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnidentifier.html#cfn-quicksight-analysis-columnidentifier-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class ColumnSort
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnsort.html#cfn-quicksight-analysis-columnsort-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnsort.html#cfn-quicksight-analysis-columnsort-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier SortBy { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnsort.html#cfn-quicksight-analysis-columnsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class ColumnTooltipItem
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction Aggregation { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class ComboChartAggregatedFieldWells
        {
            /// <summary>
            /// BarValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-barvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> BarValues { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// LineValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-linevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> LineValues { get; set; }
        }

        public class ComboChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartSortConfiguration
            /// </summary>
            public ComboChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// BarDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-bardatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions BarDataLabels { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// BarsArrangement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-barsarrangement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BarsArrangement { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// LineDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-linedatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions LineDataLabels { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartFieldWells
            /// </summary>
            public ComboChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
        }

        public class ComboChartFieldWells
        {
            /// <summary>
            /// ComboChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartfieldwells.html#cfn-quicksight-analysis-combochartfieldwells-combochartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartAggregatedFieldWells
            /// </summary>
            public ComboChartAggregatedFieldWells ComboChartAggregatedFieldWells { get; set; }
        }

        public class ComboChartSortConfiguration
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
        }

        public class ComboChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartConfiguration
            /// </summary>
            public ComboChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ComparisonConfiguration
        {
            /// <summary>
            /// ComparisonMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-comparisonconfiguration.html#cfn-quicksight-analysis-comparisonconfiguration-comparisonmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonMethod { get; set; }
            /// <summary>
            /// ComparisonFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-comparisonconfiguration.html#cfn-quicksight-analysis-comparisonconfiguration-comparisonformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonFormatConfiguration
            /// </summary>
            public ComparisonFormatConfiguration ComparisonFormat { get; set; }
        }

        public class ComparisonFormatConfiguration
        {
            /// <summary>
            /// NumberDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-comparisonformatconfiguration.html#cfn-quicksight-analysis-comparisonformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-comparisonformatconfiguration.html#cfn-quicksight-analysis-comparisonformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class Computation
        {
            /// <summary>
            /// PeriodToDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-periodtodate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodToDateComputation
            /// </summary>
            public PeriodToDateComputation PeriodToDate { get; set; }
            /// <summary>
            /// GrowthRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-growthrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrowthRateComputation
            /// </summary>
            public GrowthRateComputation GrowthRate { get; set; }
            /// <summary>
            /// TopBottomRanked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-topbottomranked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomRankedComputation
            /// </summary>
            public TopBottomRankedComputation TopBottomRanked { get; set; }
            /// <summary>
            /// TotalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-totalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalAggregationComputation
            /// </summary>
            public TotalAggregationComputation TotalAggregation { get; set; }
            /// <summary>
            /// Forecast
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-forecast
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastComputation
            /// </summary>
            public ForecastComputation Forecast { get; set; }
            /// <summary>
            /// MaximumMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-maximumminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumMinimumComputation
            /// </summary>
            public MaximumMinimumComputation MaximumMinimum { get; set; }
            /// <summary>
            /// PeriodOverPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-periodoverperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodOverPeriodComputation
            /// </summary>
            public PeriodOverPeriodComputation PeriodOverPeriod { get; set; }
            /// <summary>
            /// MetricComparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-metriccomparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricComparisonComputation
            /// </summary>
            public MetricComparisonComputation MetricComparison { get; set; }
            /// <summary>
            /// TopBottomMovers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-topbottommovers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomMoversComputation
            /// </summary>
            public TopBottomMoversComputation TopBottomMovers { get; set; }
            /// <summary>
            /// UniqueValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-uniquevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UniqueValuesComputation
            /// </summary>
            public UniqueValuesComputation UniqueValues { get; set; }
        }

        public class ConditionalFormattingColor
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcolor.html#cfn-quicksight-analysis-conditionalformattingcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingGradientColor
            /// </summary>
            public ConditionalFormattingGradientColor Gradient { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcolor.html#cfn-quicksight-analysis-conditionalformattingcolor-solid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingSolidColor
            /// </summary>
            public ConditionalFormattingSolidColor Solid { get; set; }
        }

        public class ConditionalFormattingCustomIconCondition
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconcondition.html#cfn-quicksight-analysis-conditionalformattingcustomiconcondition-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconcondition.html#cfn-quicksight-analysis-conditionalformattingcustomiconcondition-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// DisplayConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconcondition.html#cfn-quicksight-analysis-conditionalformattingcustomiconcondition-displayconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconDisplayConfiguration
            /// </summary>
            public ConditionalFormattingIconDisplayConfiguration DisplayConfiguration { get; set; }
            /// <summary>
            /// IconOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconcondition.html#cfn-quicksight-analysis-conditionalformattingcustomiconcondition-iconoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconOptions
            /// </summary>
            public ConditionalFormattingCustomIconOptions IconOptions { get; set; }
        }

        public class ConditionalFormattingCustomIconOptions
        {
            /// <summary>
            /// UnicodeIcon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconoptions.html#cfn-quicksight-analysis-conditionalformattingcustomiconoptions-unicodeicon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnicodeIcon { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconoptions.html#cfn-quicksight-analysis-conditionalformattingcustomiconoptions-icon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Icon { get; set; }
        }

        public class ConditionalFormattingGradientColor
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattinggradientcolor.html#cfn-quicksight-analysis-conditionalformattinggradientcolor-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattinggradientcolor.html#cfn-quicksight-analysis-conditionalformattinggradientcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GradientColor
            /// </summary>
            public GradientColor Color { get; set; }
        }

        public class ConditionalFormattingIcon
        {
            /// <summary>
            /// CustomCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingicon.html#cfn-quicksight-analysis-conditionalformattingicon-customcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconCondition
            /// </summary>
            public ConditionalFormattingCustomIconCondition CustomCondition { get; set; }
            /// <summary>
            /// IconSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingicon.html#cfn-quicksight-analysis-conditionalformattingicon-iconset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconSet
            /// </summary>
            public ConditionalFormattingIconSet IconSet { get; set; }
        }

        public class ConditionalFormattingIconDisplayConfiguration
        {
            /// <summary>
            /// IconDisplayOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingicondisplayconfiguration.html#cfn-quicksight-analysis-conditionalformattingicondisplayconfiguration-icondisplayoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IconDisplayOption { get; set; }
        }

        public class ConditionalFormattingIconSet
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingiconset.html#cfn-quicksight-analysis-conditionalformattingiconset-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// IconSetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingiconset.html#cfn-quicksight-analysis-conditionalformattingiconset-iconsettype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IconSetType { get; set; }
        }

        public class ConditionalFormattingSolidColor
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingsolidcolor.html#cfn-quicksight-analysis-conditionalformattingsolidcolor-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingsolidcolor.html#cfn-quicksight-analysis-conditionalformattingsolidcolor-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class ContributionAnalysisDefault
        {
            /// <summary>
            /// MeasureFieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-contributionanalysisdefault.html#cfn-quicksight-analysis-contributionanalysisdefault-measurefieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureFieldId { get; set; }
            /// <summary>
            /// ContributorDimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-contributionanalysisdefault.html#cfn-quicksight-analysis-contributionanalysisdefault-contributordimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<ColumnIdentifier> ContributorDimensions { get; set; }
        }

        public class CurrencyDisplayFormatConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NumberScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-numberscale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NumberScale { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Symbol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-symbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Symbol { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class CustomActionFilterOperation
        {
            /// <summary>
            /// SelectedFieldsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionfilteroperation.html#cfn-quicksight-analysis-customactionfilteroperation-selectedfieldsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationSelectedFieldsConfiguration
            /// </summary>
            public FilterOperationSelectedFieldsConfiguration SelectedFieldsConfiguration { get; set; }
            /// <summary>
            /// TargetVisualsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionfilteroperation.html#cfn-quicksight-analysis-customactionfilteroperation-targetvisualsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationTargetVisualsConfiguration
            /// </summary>
            public FilterOperationTargetVisualsConfiguration TargetVisualsConfiguration { get; set; }
        }

        public class CustomActionNavigationOperation
        {
            /// <summary>
            /// LocalNavigationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionnavigationoperation.html#cfn-quicksight-analysis-customactionnavigationoperation-localnavigationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocalNavigationConfiguration
            /// </summary>
            public LocalNavigationConfiguration LocalNavigationConfiguration { get; set; }
        }

        public class CustomActionSetParametersOperation
        {
            /// <summary>
            /// ParameterValueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionsetparametersoperation.html#cfn-quicksight-analysis-customactionsetparametersoperation-parametervalueconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SetParameterValueConfiguration
            /// </summary>
            public List<SetParameterValueConfiguration> ParameterValueConfigurations { get; set; }
        }

        public class CustomActionURLOperation
        {
            /// <summary>
            /// URLTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionurloperation.html#cfn-quicksight-analysis-customactionurloperation-urltemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic URLTemplate { get; set; }
            /// <summary>
            /// URLTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionurloperation.html#cfn-quicksight-analysis-customactionurloperation-urltarget
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic URLTarget { get; set; }
        }

        public class CustomColor
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcolor.html#cfn-quicksight-analysis-customcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcolor.html#cfn-quicksight-analysis-customcolor-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
            /// <summary>
            /// SpecialValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcolor.html#cfn-quicksight-analysis-customcolor-specialvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpecialValue { get; set; }
        }

        public class CustomContentConfiguration
        {
            /// <summary>
            /// ContentUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentconfiguration.html#cfn-quicksight-analysis-customcontentconfiguration-contenturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentUrl { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentconfiguration.html#cfn-quicksight-analysis-customcontentconfiguration-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// ImageScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentconfiguration.html#cfn-quicksight-analysis-customcontentconfiguration-imagescaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageScaling { get; set; }
        }

        public class CustomContentVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentConfiguration
            /// </summary>
            public CustomContentConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class CustomFilterConfiguration
        {
            /// <summary>
            /// CategoryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterconfiguration.html#cfn-quicksight-analysis-customfilterconfiguration-categoryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterconfiguration.html#cfn-quicksight-analysis-customfilterconfiguration-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterconfiguration.html#cfn-quicksight-analysis-customfilterconfiguration-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterconfiguration.html#cfn-quicksight-analysis-customfilterconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterconfiguration.html#cfn-quicksight-analysis-customfilterconfiguration-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
        }

        public class CustomFilterListConfiguration
        {
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterlistconfiguration.html#cfn-quicksight-analysis-customfilterlistconfiguration-categoryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterlistconfiguration.html#cfn-quicksight-analysis-customfilterlistconfiguration-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterlistconfiguration.html#cfn-quicksight-analysis-customfilterlistconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customfilterlistconfiguration.html#cfn-quicksight-analysis-customfilterlistconfiguration-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
        }

        public class CustomNarrativeOptions
        {
            /// <summary>
            /// Narrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customnarrativeoptions.html#cfn-quicksight-analysis-customnarrativeoptions-narrative
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Narrative { get; set; }
        }

        public class CustomParameterValues
        {
            /// <summary>
            /// DecimalValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customparametervalues.html#cfn-quicksight-analysis-customparametervalues-decimalvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> DecimalValues { get; set; }
            /// <summary>
            /// IntegerValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customparametervalues.html#cfn-quicksight-analysis-customparametervalues-integervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> IntegerValues { get; set; }
            /// <summary>
            /// StringValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customparametervalues.html#cfn-quicksight-analysis-customparametervalues-stringvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringValues { get; set; }
            /// <summary>
            /// DateTimeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customparametervalues.html#cfn-quicksight-analysis-customparametervalues-datetimevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DateTimeValues { get; set; }
        }

        public class CustomValuesConfiguration
        {
            /// <summary>
            /// IncludeNullValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customvaluesconfiguration.html#cfn-quicksight-analysis-customvaluesconfiguration-includenullvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeNullValue { get; set; }
            /// <summary>
            /// CustomValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customvaluesconfiguration.html#cfn-quicksight-analysis-customvaluesconfiguration-customvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomParameterValues
            /// </summary>
            public CustomParameterValues CustomValues { get; set; }
        }

        public class DataBarsOptions
        {
            /// <summary>
            /// PositiveColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-databarsoptions.html#cfn-quicksight-analysis-databarsoptions-positivecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositiveColor { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-databarsoptions.html#cfn-quicksight-analysis-databarsoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// NegativeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-databarsoptions.html#cfn-quicksight-analysis-databarsoptions-negativecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NegativeColor { get; set; }
        }

        public class DataColor
        {
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datacolor.html#cfn-quicksight-analysis-datacolor-datavalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datacolor.html#cfn-quicksight-analysis-datacolor-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class DataFieldSeriesItem
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datafieldseriesitem.html#cfn-quicksight-analysis-datafieldseriesitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datafieldseriesitem.html#cfn-quicksight-analysis-datafieldseriesitem-axisbinding
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datafieldseriesitem.html#cfn-quicksight-analysis-datafieldseriesitem-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datafieldseriesitem.html#cfn-quicksight-analysis-datafieldseriesitem-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSeriesSettings
            /// </summary>
            public LineChartSeriesSettings Settings { get; set; }
        }

        public class DataLabelOptions
        {
            /// <summary>
            /// DataLabelTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-datalabeltypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataLabelType
            /// </summary>
            public List<DataLabelType> DataLabelTypes { get; set; }
            /// <summary>
            /// MeasureLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-measurelabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureLabelVisibility { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// LabelContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-labelcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelContent { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// Overlap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-overlap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Overlap { get; set; }
            /// <summary>
            /// CategoryLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-categorylabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryLabelVisibility { get; set; }
            /// <summary>
            /// LabelColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-labelcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColor { get; set; }
            /// <summary>
            /// LabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-labelfontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class DataLabelType
        {
            /// <summary>
            /// MaximumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-maximumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumLabelType
            /// </summary>
            public MaximumLabelType MaximumLabelType { get; set; }
            /// <summary>
            /// DataPathLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-datapathlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathLabelType
            /// </summary>
            public DataPathLabelType DataPathLabelType { get; set; }
            /// <summary>
            /// RangeEndsLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-rangeendslabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangeEndsLabelType
            /// </summary>
            public RangeEndsLabelType RangeEndsLabelType { get; set; }
            /// <summary>
            /// FieldLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-fieldlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldLabelType
            /// </summary>
            public FieldLabelType FieldLabelType { get; set; }
            /// <summary>
            /// MinimumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-minimumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MinimumLabelType
            /// </summary>
            public MinimumLabelType MinimumLabelType { get; set; }
        }

        public class DataPathColor
        {
            /// <summary>
            /// Element
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathcolor.html#cfn-quicksight-analysis-datapathcolor-element
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPathValue
            /// </summary>
            public DataPathValue Element { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathcolor.html#cfn-quicksight-analysis-datapathcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathcolor.html#cfn-quicksight-analysis-datapathcolor-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
        }

        public class DataPathLabelType
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathlabeltype.html#cfn-quicksight-analysis-datapathlabeltype-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathlabeltype.html#cfn-quicksight-analysis-datapathlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathlabeltype.html#cfn-quicksight-analysis-datapathlabeltype-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
        }

        public class DataPathSort
        {
            /// <summary>
            /// SortPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathsort.html#cfn-quicksight-analysis-datapathsort-sortpaths
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<DataPathValue> SortPaths { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathsort.html#cfn-quicksight-analysis-datapathsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class DataPathType
        {
            /// <summary>
            /// PivotTableDataPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathtype.html#cfn-quicksight-analysis-datapathtype-pivottabledatapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PivotTableDataPathType { get; set; }
        }

        public class DataPathValue
        {
            /// <summary>
            /// DataPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathvalue.html#cfn-quicksight-analysis-datapathvalue-datapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathType
            /// </summary>
            public DataPathType DataPathType { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathvalue.html#cfn-quicksight-analysis-datapathvalue-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathvalue.html#cfn-quicksight-analysis-datapathvalue-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
        }

        public class DataSetIdentifierDeclaration
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datasetidentifierdeclaration.html#cfn-quicksight-analysis-datasetidentifierdeclaration-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datasetidentifierdeclaration.html#cfn-quicksight-analysis-datasetidentifierdeclaration-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
        }

        public class DataSetReference
        {
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datasetreference.html#cfn-quicksight-analysis-datasetreference-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
            /// <summary>
            /// DataSetPlaceholder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datasetreference.html#cfn-quicksight-analysis-datasetreference-datasetplaceholder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetPlaceholder { get; set; }
        }

        public class DateAxisOptions
        {
            /// <summary>
            /// MissingDateVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dateaxisoptions.html#cfn-quicksight-analysis-dateaxisoptions-missingdatevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MissingDateVisibility { get; set; }
        }

        public class DateDimensionField
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datedimensionfield.html#cfn-quicksight-analysis-datedimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datedimensionfield.html#cfn-quicksight-analysis-datedimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datedimensionfield.html#cfn-quicksight-analysis-datedimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datedimensionfield.html#cfn-quicksight-analysis-datedimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// DateGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datedimensionfield.html#cfn-quicksight-analysis-datedimensionfield-dategranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateGranularity { get; set; }
        }

        public class DateMeasureField
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datemeasurefield.html#cfn-quicksight-analysis-datemeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datemeasurefield.html#cfn-quicksight-analysis-datemeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datemeasurefield.html#cfn-quicksight-analysis-datemeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datemeasurefield.html#cfn-quicksight-analysis-datemeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class DateTimeDefaultValues
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimedefaultvalues.html#cfn-quicksight-analysis-datetimedefaultvalues-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimedefaultvalues.html#cfn-quicksight-analysis-datetimedefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimedefaultvalues.html#cfn-quicksight-analysis-datetimedefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class DateTimeFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeformatconfiguration.html#cfn-quicksight-analysis-datetimeformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeformatconfiguration.html#cfn-quicksight-analysis-datetimeformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeformatconfiguration.html#cfn-quicksight-analysis-datetimeformatconfiguration-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class DateTimeHierarchy
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimehierarchy.html#cfn-quicksight-analysis-datetimehierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimehierarchy.html#cfn-quicksight-analysis-datetimehierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<DrillDownFilter> DrillDownFilters { get; set; }
        }

        public class DateTimeParameter
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameter.html#cfn-quicksight-analysis-datetimeparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameter.html#cfn-quicksight-analysis-datetimeparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DateTimeParameterDeclaration
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDefaultValues
            /// </summary>
            public DateTimeDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeValueWhenUnsetConfiguration
            /// </summary>
            public DateTimeValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DateTimePickerControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimepickercontroldisplayoptions.html#cfn-quicksight-analysis-datetimepickercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimepickercontroldisplayoptions.html#cfn-quicksight-analysis-datetimepickercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimepickercontroldisplayoptions.html#cfn-quicksight-analysis-datetimepickercontroldisplayoptions-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class DateTimeValueWhenUnsetConfiguration
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimevaluewhenunsetconfiguration.html#cfn-quicksight-analysis-datetimevaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimevaluewhenunsetconfiguration.html#cfn-quicksight-analysis-datetimevaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class DecimalDefaultValues
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimaldefaultvalues.html#cfn-quicksight-analysis-decimaldefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimaldefaultvalues.html#cfn-quicksight-analysis-decimaldefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class DecimalParameter
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameter.html#cfn-quicksight-analysis-decimalparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameter.html#cfn-quicksight-analysis-decimalparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DecimalParameterDeclaration
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDefaultValues
            /// </summary>
            public DecimalDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalValueWhenUnsetConfiguration
            /// </summary>
            public DecimalValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DecimalPlacesConfiguration
        {
            /// <summary>
            /// DecimalPlaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalplacesconfiguration.html#cfn-quicksight-analysis-decimalplacesconfiguration-decimalplaces
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DecimalPlaces { get; set; }
        }

        public class DecimalValueWhenUnsetConfiguration
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalvaluewhenunsetconfiguration.html#cfn-quicksight-analysis-decimalvaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalvaluewhenunsetconfiguration.html#cfn-quicksight-analysis-decimalvaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class DefaultDateTimePickerControlOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultdatetimepickercontroloptions.html#cfn-quicksight-analysis-defaultdatetimepickercontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultdatetimepickercontroloptions.html#cfn-quicksight-analysis-defaultdatetimepickercontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DefaultFilterControlConfiguration
        {
            /// <summary>
            /// ControlOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontrolconfiguration.html#cfn-quicksight-analysis-defaultfiltercontrolconfiguration-controloptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlOptions
            /// </summary>
            public DefaultFilterControlOptions ControlOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontrolconfiguration.html#cfn-quicksight-analysis-defaultfiltercontrolconfiguration-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class DefaultFilterControlOptions
        {
            /// <summary>
            /// DefaultSliderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultslideroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSliderControlOptions
            /// </summary>
            public DefaultSliderControlOptions DefaultSliderOptions { get; set; }
            /// <summary>
            /// DefaultRelativeDateTimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultrelativedatetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRelativeDateTimeControlOptions
            /// </summary>
            public DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions { get; set; }
            /// <summary>
            /// DefaultTextFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaulttextfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextFieldControlOptions
            /// </summary>
            public DefaultTextFieldControlOptions DefaultTextFieldOptions { get; set; }
            /// <summary>
            /// DefaultTextAreaOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaulttextareaoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextAreaControlOptions
            /// </summary>
            public DefaultTextAreaControlOptions DefaultTextAreaOptions { get; set; }
            /// <summary>
            /// DefaultDropdownOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultdropdownoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterDropDownControlOptions
            /// </summary>
            public DefaultFilterDropDownControlOptions DefaultDropdownOptions { get; set; }
            /// <summary>
            /// DefaultDateTimePickerOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultdatetimepickeroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultDateTimePickerControlOptions
            /// </summary>
            public DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions { get; set; }
            /// <summary>
            /// DefaultListOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultlistoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterListControlOptions
            /// </summary>
            public DefaultFilterListControlOptions DefaultListOptions { get; set; }
        }

        public class DefaultFilterDropDownControlOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterdropdowncontroloptions.html#cfn-quicksight-analysis-defaultfilterdropdowncontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterdropdowncontroloptions.html#cfn-quicksight-analysis-defaultfilterdropdowncontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterdropdowncontroloptions.html#cfn-quicksight-analysis-defaultfilterdropdowncontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFilterListControlOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterlistcontroloptions.html#cfn-quicksight-analysis-defaultfilterlistcontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterlistcontroloptions.html#cfn-quicksight-analysis-defaultfilterlistcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterlistcontroloptions.html#cfn-quicksight-analysis-defaultfilterlistcontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFreeFormLayoutConfiguration
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfreeformlayoutconfiguration.html#cfn-quicksight-analysis-defaultfreeformlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultGridLayoutConfiguration
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultgridlayoutconfiguration.html#cfn-quicksight-analysis-defaultgridlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultInteractiveLayoutConfiguration
        {
            /// <summary>
            /// FreeForm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultinteractivelayoutconfiguration.html#cfn-quicksight-analysis-defaultinteractivelayoutconfiguration-freeform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFreeFormLayoutConfiguration
            /// </summary>
            public DefaultFreeFormLayoutConfiguration FreeForm { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultinteractivelayoutconfiguration.html#cfn-quicksight-analysis-defaultinteractivelayoutconfiguration-grid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultGridLayoutConfiguration
            /// </summary>
            public DefaultGridLayoutConfiguration Grid { get; set; }
        }

        public class DefaultNewSheetConfiguration
        {
            /// <summary>
            /// SheetContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultnewsheetconfiguration.html#cfn-quicksight-analysis-defaultnewsheetconfiguration-sheetcontenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetContentType { get; set; }
            /// <summary>
            /// InteractiveLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultnewsheetconfiguration.html#cfn-quicksight-analysis-defaultnewsheetconfiguration-interactivelayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultInteractiveLayoutConfiguration
            /// </summary>
            public DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration { get; set; }
            /// <summary>
            /// PaginatedLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultnewsheetconfiguration.html#cfn-quicksight-analysis-defaultnewsheetconfiguration-paginatedlayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultPaginatedLayoutConfiguration
            /// </summary>
            public DefaultPaginatedLayoutConfiguration PaginatedLayoutConfiguration { get; set; }
        }

        public class DefaultPaginatedLayoutConfiguration
        {
            /// <summary>
            /// SectionBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultpaginatedlayoutconfiguration.html#cfn-quicksight-analysis-defaultpaginatedlayoutconfiguration-sectionbased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSectionBasedLayoutConfiguration
            /// </summary>
            public DefaultSectionBasedLayoutConfiguration SectionBased { get; set; }
        }

        public class DefaultRelativeDateTimeControlOptions
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultrelativedatetimecontroloptions.html#cfn-quicksight-analysis-defaultrelativedatetimecontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DefaultSectionBasedLayoutConfiguration
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultsectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-defaultsectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultSliderControlOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultslidercontroloptions.html#cfn-quicksight-analysis-defaultslidercontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultslidercontroloptions.html#cfn-quicksight-analysis-defaultslidercontroloptions-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultslidercontroloptions.html#cfn-quicksight-analysis-defaultslidercontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultslidercontroloptions.html#cfn-quicksight-analysis-defaultslidercontroloptions-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultslidercontroloptions.html#cfn-quicksight-analysis-defaultslidercontroloptions-minimumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumValue { get; set; }
        }

        public class DefaultTextAreaControlOptions
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaulttextareacontroloptions.html#cfn-quicksight-analysis-defaulttextareacontroloptions-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaulttextareacontroloptions.html#cfn-quicksight-analysis-defaulttextareacontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public TextAreaControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DefaultTextFieldControlOptions
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaulttextfieldcontroloptions.html#cfn-quicksight-analysis-defaulttextfieldcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public TextFieldControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DestinationParameterValueConfiguration
        {
            /// <summary>
            /// CustomValuesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-destinationparametervalueconfiguration.html#cfn-quicksight-analysis-destinationparametervalueconfiguration-customvaluesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomValuesConfiguration
            /// </summary>
            public CustomValuesConfiguration CustomValuesConfiguration { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-destinationparametervalueconfiguration.html#cfn-quicksight-analysis-destinationparametervalueconfiguration-sourceparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// SelectAllValueOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-destinationparametervalueconfiguration.html#cfn-quicksight-analysis-destinationparametervalueconfiguration-selectallvalueoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllValueOptions { get; set; }
            /// <summary>
            /// SourceField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-destinationparametervalueconfiguration.html#cfn-quicksight-analysis-destinationparametervalueconfiguration-sourcefield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceField { get; set; }
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-destinationparametervalueconfiguration.html#cfn-quicksight-analysis-destinationparametervalueconfiguration-sourcecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier SourceColumn { get; set; }
        }

        public class DimensionField
        {
            /// <summary>
            /// DateDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dimensionfield.html#cfn-quicksight-analysis-dimensionfield-datedimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateDimensionField
            /// </summary>
            public DateDimensionField DateDimensionField { get; set; }
            /// <summary>
            /// NumericalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dimensionfield.html#cfn-quicksight-analysis-dimensionfield-numericaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalDimensionField
            /// </summary>
            public NumericalDimensionField NumericalDimensionField { get; set; }
            /// <summary>
            /// CategoricalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dimensionfield.html#cfn-quicksight-analysis-dimensionfield-categoricaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalDimensionField
            /// </summary>
            public CategoricalDimensionField CategoricalDimensionField { get; set; }
        }

        public class DonutCenterOptions
        {
            /// <summary>
            /// LabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-donutcenteroptions.html#cfn-quicksight-analysis-donutcenteroptions-labelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelVisibility { get; set; }
        }

        public class DonutOptions
        {
            /// <summary>
            /// DonutCenterOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-donutoptions.html#cfn-quicksight-analysis-donutoptions-donutcenteroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutCenterOptions
            /// </summary>
            public DonutCenterOptions DonutCenterOptions { get; set; }
            /// <summary>
            /// ArcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-donutoptions.html#cfn-quicksight-analysis-donutoptions-arcoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcOptions
            /// </summary>
            public ArcOptions ArcOptions { get; set; }
        }

        public class DrillDownFilter
        {
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-drilldownfilter.html#cfn-quicksight-analysis-drilldownfilter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityDrillDownFilter
            /// </summary>
            public NumericEqualityDrillDownFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-drilldownfilter.html#cfn-quicksight-analysis-drilldownfilter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeDrillDownFilter
            /// </summary>
            public TimeRangeDrillDownFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-drilldownfilter.html#cfn-quicksight-analysis-drilldownfilter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryDrillDownFilter
            /// </summary>
            public CategoryDrillDownFilter CategoryFilter { get; set; }
        }

        public class DropDownControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dropdowncontroldisplayoptions.html#cfn-quicksight-analysis-dropdowncontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dropdowncontroldisplayoptions.html#cfn-quicksight-analysis-dropdowncontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dropdowncontroldisplayoptions.html#cfn-quicksight-analysis-dropdowncontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class DynamicDefaultValue
        {
            /// <summary>
            /// GroupNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dynamicdefaultvalue.html#cfn-quicksight-analysis-dynamicdefaultvalue-groupnamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier GroupNameColumn { get; set; }
            /// <summary>
            /// DefaultValueColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dynamicdefaultvalue.html#cfn-quicksight-analysis-dynamicdefaultvalue-defaultvaluecolumn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier DefaultValueColumn { get; set; }
            /// <summary>
            /// UserNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dynamicdefaultvalue.html#cfn-quicksight-analysis-dynamicdefaultvalue-usernamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier UserNameColumn { get; set; }
        }

        public class EmptyVisual
        {
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-emptyvisual.html#cfn-quicksight-analysis-emptyvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-emptyvisual.html#cfn-quicksight-analysis-emptyvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-emptyvisual.html#cfn-quicksight-analysis-emptyvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class Entity
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-entity.html#cfn-quicksight-analysis-entity-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
        }

        public class ExcludePeriodConfiguration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-excludeperiodconfiguration.html#cfn-quicksight-analysis-excludeperiodconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-excludeperiodconfiguration.html#cfn-quicksight-analysis-excludeperiodconfiguration-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Amount { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-excludeperiodconfiguration.html#cfn-quicksight-analysis-excludeperiodconfiguration-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class ExplicitHierarchy
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-explicithierarchy.html#cfn-quicksight-analysis-explicithierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-explicithierarchy.html#cfn-quicksight-analysis-explicithierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-explicithierarchy.html#cfn-quicksight-analysis-explicithierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<ColumnIdentifier> Columns { get; set; }
        }

        public class FieldBasedTooltip
        {
            /// <summary>
            /// TooltipFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldbasedtooltip.html#cfn-quicksight-analysis-fieldbasedtooltip-tooltipfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TooltipItem
            /// </summary>
            public List<TooltipItem> TooltipFields { get; set; }
            /// <summary>
            /// AggregationVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldbasedtooltip.html#cfn-quicksight-analysis-fieldbasedtooltip-aggregationvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationVisibility { get; set; }
            /// <summary>
            /// TooltipTitleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldbasedtooltip.html#cfn-quicksight-analysis-fieldbasedtooltip-tooltiptitletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTitleType { get; set; }
        }

        public class FieldLabelType
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldlabeltype.html#cfn-quicksight-analysis-fieldlabeltype-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldlabeltype.html#cfn-quicksight-analysis-fieldlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FieldSeriesItem
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldseriesitem.html#cfn-quicksight-analysis-fieldseriesitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldseriesitem.html#cfn-quicksight-analysis-fieldseriesitem-axisbinding
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldseriesitem.html#cfn-quicksight-analysis-fieldseriesitem-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSeriesSettings
            /// </summary>
            public LineChartSeriesSettings Settings { get; set; }
        }

        public class FieldSort
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldsort.html#cfn-quicksight-analysis-fieldsort-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldsort.html#cfn-quicksight-analysis-fieldsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class FieldSortOptions
        {
            /// <summary>
            /// FieldSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldsortoptions.html#cfn-quicksight-analysis-fieldsortoptions-fieldsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public FieldSort FieldSort { get; set; }
            /// <summary>
            /// ColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldsortoptions.html#cfn-quicksight-analysis-fieldsortoptions-columnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public ColumnSort ColumnSort { get; set; }
        }

        public class FieldTooltipItem
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldtooltipitem.html#cfn-quicksight-analysis-fieldtooltipitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldtooltipitem.html#cfn-quicksight-analysis-fieldtooltipitem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldtooltipitem.html#cfn-quicksight-analysis-fieldtooltipitem-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FilledMapAggregatedFieldWells
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapaggregatedfieldwells.html#cfn-quicksight-analysis-filledmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapaggregatedfieldwells.html#cfn-quicksight-analysis-filledmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Geospatial { get; set; }
        }

        public class FilledMapConditionalFormatting
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconditionalformatting.html#cfn-quicksight-analysis-filledmapconditionalformatting-conditionalformattingoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilledMapConditionalFormattingOption
            /// </summary>
            public List<FilledMapConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class FilledMapConditionalFormattingOption
        {
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconditionalformattingoption.html#cfn-quicksight-analysis-filledmapconditionalformattingoption-shape
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilledMapShapeConditionalFormatting
            /// </summary>
            public FilledMapShapeConditionalFormatting Shape { get; set; }
        }

        public class FilledMapConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapSortConfiguration
            /// </summary>
            public FilledMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapFieldWells
            /// </summary>
            public FilledMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public GeospatialWindowOptions WindowOptions { get; set; }
        }

        public class FilledMapFieldWells
        {
            /// <summary>
            /// FilledMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapfieldwells.html#cfn-quicksight-analysis-filledmapfieldwells-filledmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapAggregatedFieldWells
            /// </summary>
            public FilledMapAggregatedFieldWells FilledMapAggregatedFieldWells { get; set; }
        }

        public class FilledMapShapeConditionalFormatting
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapshapeconditionalformatting.html#cfn-quicksight-analysis-filledmapshapeconditionalformatting-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShapeConditionalFormat
            /// </summary>
            public ShapeConditionalFormat Format { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapshapeconditionalformatting.html#cfn-quicksight-analysis-filledmapshapeconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class FilledMapSortConfiguration
        {
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapsortconfiguration.html#cfn-quicksight-analysis-filledmapsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
        }

        public class FilledMapVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConditionalFormatting
            /// </summary>
            public FilledMapConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConfiguration
            /// </summary>
            public FilledMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class Filter
        {
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityFilter
            /// </summary>
            public NumericEqualityFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// NumericRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-numericrangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilter
            /// </summary>
            public NumericRangeFilter NumericRangeFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilter
            /// </summary>
            public TimeRangeFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// RelativeDatesFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-relativedatesfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDatesFilter
            /// </summary>
            public RelativeDatesFilter RelativeDatesFilter { get; set; }
            /// <summary>
            /// TopBottomFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-topbottomfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomFilter
            /// </summary>
            public TopBottomFilter TopBottomFilter { get; set; }
            /// <summary>
            /// TimeEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-timeequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeEqualityFilter
            /// </summary>
            public TimeEqualityFilter TimeEqualityFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryFilter
            /// </summary>
            public CategoryFilter CategoryFilter { get; set; }
        }

        public class FilterControl
        {
            /// <summary>
            /// Slider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSliderControl
            /// </summary>
            public FilterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextAreaControl
            /// </summary>
            public FilterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDropDownControl
            /// </summary>
            public FilterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextFieldControl
            /// </summary>
            public FilterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListControl
            /// </summary>
            public FilterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDateTimePickerControl
            /// </summary>
            public FilterDateTimePickerControl DateTimePicker { get; set; }
            /// <summary>
            /// RelativeDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-relativedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterRelativeDateTimeControl
            /// </summary>
            public FilterRelativeDateTimeControl RelativeDateTime { get; set; }
            /// <summary>
            /// CrossSheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-crosssheet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterCrossSheetControl
            /// </summary>
            public FilterCrossSheetControl CrossSheet { get; set; }
        }

        public class FilterCrossSheetControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercrosssheetcontrol.html#cfn-quicksight-analysis-filtercrosssheetcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercrosssheetcontrol.html#cfn-quicksight-analysis-filtercrosssheetcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercrosssheetcontrol.html#cfn-quicksight-analysis-filtercrosssheetcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDateTimePickerControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDropDownControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterGroup
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtergroup.html#cfn-quicksight-analysis-filtergroup-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtergroup.html#cfn-quicksight-analysis-filtergroup-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Filter> Filters { get; set; }
            /// <summary>
            /// CrossDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtergroup.html#cfn-quicksight-analysis-filtergroup-crossdataset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossDataset { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtergroup.html#cfn-quicksight-analysis-filtergroup-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterScopeConfiguration
            /// </summary>
            public FilterScopeConfiguration ScopeConfiguration { get; set; }
            /// <summary>
            /// FilterGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtergroup.html#cfn-quicksight-analysis-filtergroup-filtergroupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterGroupId { get; set; }
        }

        public class FilterListConfiguration
        {
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistconfiguration.html#cfn-quicksight-analysis-filterlistconfiguration-categoryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistconfiguration.html#cfn-quicksight-analysis-filterlistconfiguration-nulloption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistconfiguration.html#cfn-quicksight-analysis-filterlistconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistconfiguration.html#cfn-quicksight-analysis-filterlistconfiguration-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
        }

        public class FilterListControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterOperationSelectedFieldsConfiguration
        {
            /// <summary>
            /// SelectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-analysis-filteroperationselectedfieldsconfiguration-selectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<ColumnIdentifier> SelectedColumns { get; set; }
            /// <summary>
            /// SelectedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-analysis-filteroperationselectedfieldsconfiguration-selectedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SelectedFields { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-analysis-filteroperationselectedfieldsconfiguration-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedFieldOptions { get; set; }
        }

        public class FilterOperationTargetVisualsConfiguration
        {
            /// <summary>
            /// SameSheetTargetVisualConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filteroperationtargetvisualsconfiguration.html#cfn-quicksight-analysis-filteroperationtargetvisualsconfiguration-samesheettargetvisualconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SameSheetTargetVisualConfiguration
            /// </summary>
            public SameSheetTargetVisualConfiguration SameSheetTargetVisualConfiguration { get; set; }
        }

        public class FilterRelativeDateTimeControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterScopeConfiguration
        {
            /// <summary>
            /// AllSheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterscopeconfiguration.html#cfn-quicksight-analysis-filterscopeconfiguration-allsheets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllSheets { get; set; }
            /// <summary>
            /// SelectedSheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterscopeconfiguration.html#cfn-quicksight-analysis-filterscopeconfiguration-selectedsheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelectedSheetsFilterScopeConfiguration
            /// </summary>
            public SelectedSheetsFilterScopeConfiguration SelectedSheets { get; set; }
        }

        public class FilterSelectableValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterselectablevalues.html#cfn-quicksight-analysis-filterselectablevalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class FilterSliderControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterslidercontrol.html#cfn-quicksight-analysis-filterslidercontrol-minimumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumValue { get; set; }
        }

        public class FilterTextAreaControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextareacontrol.html#cfn-quicksight-analysis-filtertextareacontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextareacontrol.html#cfn-quicksight-analysis-filtertextareacontrol-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextareacontrol.html#cfn-quicksight-analysis-filtertextareacontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public TextAreaControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextareacontrol.html#cfn-quicksight-analysis-filtertextareacontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextareacontrol.html#cfn-quicksight-analysis-filtertextareacontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterTextFieldControl
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextfieldcontrol.html#cfn-quicksight-analysis-filtertextfieldcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextfieldcontrol.html#cfn-quicksight-analysis-filtertextfieldcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public TextFieldControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextfieldcontrol.html#cfn-quicksight-analysis-filtertextfieldcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtertextfieldcontrol.html#cfn-quicksight-analysis-filtertextfieldcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FontConfiguration
        {
            /// <summary>
            /// FontStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontconfiguration.html#cfn-quicksight-analysis-fontconfiguration-fontstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontStyle { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontconfiguration.html#cfn-quicksight-analysis-fontconfiguration-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontSize
            /// </summary>
            public FontSize FontSize { get; set; }
            /// <summary>
            /// FontDecoration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontconfiguration.html#cfn-quicksight-analysis-fontconfiguration-fontdecoration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontDecoration { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontconfiguration.html#cfn-quicksight-analysis-fontconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// FontWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontconfiguration.html#cfn-quicksight-analysis-fontconfiguration-fontweight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontWeight
            /// </summary>
            public FontWeight FontWeight { get; set; }
        }

        public class FontSize
        {
            /// <summary>
            /// Relative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontsize.html#cfn-quicksight-analysis-fontsize-relative
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Relative { get; set; }
        }

        public class FontWeight
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontweight.html#cfn-quicksight-analysis-fontweight-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ForecastComputation
        {
            /// <summary>
            /// PeriodsBackward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-periodsbackward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsBackward { get; set; }
            /// <summary>
            /// PeriodsForward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-periodsforward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsForward { get; set; }
            /// <summary>
            /// PredictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-predictioninterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PredictionInterval { get; set; }
            /// <summary>
            /// Seasonality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-seasonality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Seasonality { get; set; }
            /// <summary>
            /// CustomSeasonalityValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-customseasonalityvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomSeasonalityValue { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// UpperBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-upperboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperBoundary { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// LowerBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-lowerboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LowerBoundary { get; set; }
        }

        public class ForecastConfiguration
        {
            /// <summary>
            /// ForecastProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastconfiguration.html#cfn-quicksight-analysis-forecastconfiguration-forecastproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedForecastProperties
            /// </summary>
            public TimeBasedForecastProperties ForecastProperties { get; set; }
            /// <summary>
            /// Scenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastconfiguration.html#cfn-quicksight-analysis-forecastconfiguration-scenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastScenario
            /// </summary>
            public ForecastScenario Scenario { get; set; }
        }

        public class ForecastScenario
        {
            /// <summary>
            /// WhatIfRangeScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastscenario.html#cfn-quicksight-analysis-forecastscenario-whatifrangescenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfRangeScenario
            /// </summary>
            public WhatIfRangeScenario WhatIfRangeScenario { get; set; }
            /// <summary>
            /// WhatIfPointScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastscenario.html#cfn-quicksight-analysis-forecastscenario-whatifpointscenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfPointScenario
            /// </summary>
            public WhatIfPointScenario WhatIfPointScenario { get; set; }
        }

        public class FormatConfiguration
        {
            /// <summary>
            /// NumberFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-formatconfiguration.html#cfn-quicksight-analysis-formatconfiguration-numberformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public NumberFormatConfiguration NumberFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-formatconfiguration.html#cfn-quicksight-analysis-formatconfiguration-datetimeformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public DateTimeFormatConfiguration DateTimeFormatConfiguration { get; set; }
            /// <summary>
            /// StringFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-formatconfiguration.html#cfn-quicksight-analysis-formatconfiguration-stringformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public StringFormatConfiguration StringFormatConfiguration { get; set; }
        }

        public class FreeFormLayoutCanvasSizeOptions
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutcanvassizeoptions.html#cfn-quicksight-analysis-freeformlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutScreenCanvasSizeOptions
            /// </summary>
            public FreeFormLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class FreeFormLayoutConfiguration
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutconfiguration.html#cfn-quicksight-analysis-freeformlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutconfiguration.html#cfn-quicksight-analysis-freeformlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<FreeFormLayoutElement> Elements { get; set; }
        }

        public class FreeFormLayoutElement
        {
            /// <summary>
            /// ElementType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-elementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementType { get; set; }
            /// <summary>
            /// BorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-borderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBorderStyle
            /// </summary>
            public FreeFormLayoutElementBorderStyle BorderStyle { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-height
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// RenderingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-renderingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetElementRenderingRule
            /// </summary>
            public List<SheetElementRenderingRule> RenderingRules { get; set; }
            /// <summary>
            /// YAxisLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-yaxislocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic YAxisLocation { get; set; }
            /// <summary>
            /// LoadingAnimation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-loadinganimation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoadingAnimation
            /// </summary>
            public LoadingAnimation LoadingAnimation { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-width
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
            /// <summary>
            /// BackgroundStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-backgroundstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBackgroundStyle
            /// </summary>
            public FreeFormLayoutElementBackgroundStyle BackgroundStyle { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementId { get; set; }
            /// <summary>
            /// XAxisLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-xaxislocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic XAxisLocation { get; set; }
            /// <summary>
            /// SelectedBorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelement.html#cfn-quicksight-analysis-freeformlayoutelement-selectedborderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBorderStyle
            /// </summary>
            public FreeFormLayoutElementBorderStyle SelectedBorderStyle { get; set; }
        }

        public class FreeFormLayoutElementBackgroundStyle
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelementbackgroundstyle.html#cfn-quicksight-analysis-freeformlayoutelementbackgroundstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelementbackgroundstyle.html#cfn-quicksight-analysis-freeformlayoutelementbackgroundstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FreeFormLayoutElementBorderStyle
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelementborderstyle.html#cfn-quicksight-analysis-freeformlayoutelementborderstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutelementborderstyle.html#cfn-quicksight-analysis-freeformlayoutelementborderstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FreeFormLayoutScreenCanvasSizeOptions
        {
            /// <summary>
            /// OptimizedViewPortWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutscreencanvassizeoptions.html#cfn-quicksight-analysis-freeformlayoutscreencanvassizeoptions-optimizedviewportwidth
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedViewPortWidth { get; set; }
        }

        public class FreeFormSectionLayoutConfiguration
        {
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformsectionlayoutconfiguration.html#cfn-quicksight-analysis-freeformsectionlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<FreeFormLayoutElement> Elements { get; set; }
        }

        public class FunnelChartAggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartaggregatedfieldwells.html#cfn-quicksight-analysis-funnelchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartaggregatedfieldwells.html#cfn-quicksight-analysis-funnelchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class FunnelChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartSortConfiguration
            /// </summary>
            public FunnelChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-datalabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartDataLabelOptions
            /// </summary>
            public FunnelChartDataLabelOptions DataLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartFieldWells
            /// </summary>
            public FunnelChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
        }

        public class FunnelChartDataLabelOptions
        {
            /// <summary>
            /// MeasureLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-measurelabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureLabelVisibility { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// CategoryLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-categorylabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryLabelVisibility { get; set; }
            /// <summary>
            /// LabelColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-labelcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColor { get; set; }
            /// <summary>
            /// MeasureDataLabelStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-measuredatalabelstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureDataLabelStyle { get; set; }
            /// <summary>
            /// LabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartdatalabeloptions.html#cfn-quicksight-analysis-funnelchartdatalabeloptions-labelfontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class FunnelChartFieldWells
        {
            /// <summary>
            /// FunnelChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartfieldwells.html#cfn-quicksight-analysis-funnelchartfieldwells-funnelchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartAggregatedFieldWells
            /// </summary>
            public FunnelChartAggregatedFieldWells FunnelChartAggregatedFieldWells { get; set; }
        }

        public class FunnelChartSortConfiguration
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartsortconfiguration.html#cfn-quicksight-analysis-funnelchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartsortconfiguration.html#cfn-quicksight-analysis-funnelchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
        }

        public class FunnelChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartConfiguration
            /// </summary>
            public FunnelChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GaugeChartArcConditionalFormatting
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartarcconditionalformatting.html#cfn-quicksight-analysis-gaugechartarcconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class GaugeChartConditionalFormatting
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconditionalformatting.html#cfn-quicksight-analysis-gaugechartconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GaugeChartConditionalFormattingOption
            /// </summary>
            public List<GaugeChartConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class GaugeChartConditionalFormattingOption
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconditionalformattingoption.html#cfn-quicksight-analysis-gaugechartconditionalformattingoption-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartArcConditionalFormatting
            /// </summary>
            public GaugeChartArcConditionalFormatting Arc { get; set; }
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconditionalformattingoption.html#cfn-quicksight-analysis-gaugechartconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartPrimaryValueConditionalFormatting
            /// </summary>
            public GaugeChartPrimaryValueConditionalFormatting PrimaryValue { get; set; }
        }

        public class GaugeChartConfiguration
        {
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartFieldWells
            /// </summary>
            public GaugeChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// TooltipOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-tooltipoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions TooltipOptions { get; set; }
            /// <summary>
            /// GaugeChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-gaugechartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartOptions
            /// </summary>
            public GaugeChartOptions GaugeChartOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
        }

        public class GaugeChartFieldWells
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartfieldwells.html#cfn-quicksight-analysis-gaugechartfieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> TargetValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartfieldwells.html#cfn-quicksight-analysis-gaugechartfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class GaugeChartOptions
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcConfiguration
            /// </summary>
            public ArcConfiguration Arc { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public ComparisonConfiguration Comparison { get; set; }
            /// <summary>
            /// PrimaryValueDisplayType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-primaryvaluedisplaytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryValueDisplayType { get; set; }
            /// <summary>
            /// ArcAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-arcaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisConfiguration
            /// </summary>
            public ArcAxisConfiguration ArcAxis { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration PrimaryValueFontConfiguration { get; set; }
        }

        public class GaugeChartPrimaryValueConditionalFormatting
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-gaugechartprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-gaugechartprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public ConditionalFormattingIcon Icon { get; set; }
        }

        public class GaugeChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConditionalFormatting
            /// </summary>
            public GaugeChartConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConfiguration
            /// </summary>
            public GaugeChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class GeospatialCoordinateBounds
        {
            /// <summary>
            /// West
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcoordinatebounds.html#cfn-quicksight-analysis-geospatialcoordinatebounds-west
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic West { get; set; }
            /// <summary>
            /// South
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcoordinatebounds.html#cfn-quicksight-analysis-geospatialcoordinatebounds-south
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic South { get; set; }
            /// <summary>
            /// North
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcoordinatebounds.html#cfn-quicksight-analysis-geospatialcoordinatebounds-north
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic North { get; set; }
            /// <summary>
            /// East
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcoordinatebounds.html#cfn-quicksight-analysis-geospatialcoordinatebounds-east
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic East { get; set; }
        }

        public class GeospatialHeatmapColorScale
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialheatmapcolorscale.html#cfn-quicksight-analysis-geospatialheatmapcolorscale-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialHeatmapDataColor
            /// </summary>
            public List<GeospatialHeatmapDataColor> Colors { get; set; }
        }

        public class GeospatialHeatmapConfiguration
        {
            /// <summary>
            /// HeatmapColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialheatmapconfiguration.html#cfn-quicksight-analysis-geospatialheatmapconfiguration-heatmapcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapColorScale
            /// </summary>
            public GeospatialHeatmapColorScale HeatmapColor { get; set; }
        }

        public class GeospatialHeatmapDataColor
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialheatmapdatacolor.html#cfn-quicksight-analysis-geospatialheatmapdatacolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GeospatialMapAggregatedFieldWells
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapaggregatedfieldwells.html#cfn-quicksight-analysis-geospatialmapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapaggregatedfieldwells.html#cfn-quicksight-analysis-geospatialmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapaggregatedfieldwells.html#cfn-quicksight-analysis-geospatialmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Geospatial { get; set; }
        }

        public class GeospatialMapConfiguration
        {
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapFieldWells
            /// </summary>
            public GeospatialMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public GeospatialWindowOptions WindowOptions { get; set; }
            /// <summary>
            /// PointStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-pointstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyleOptions
            /// </summary>
            public GeospatialPointStyleOptions PointStyleOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
        }

        public class GeospatialMapFieldWells
        {
            /// <summary>
            /// GeospatialMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapfieldwells.html#cfn-quicksight-analysis-geospatialmapfieldwells-geospatialmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapAggregatedFieldWells
            /// </summary>
            public GeospatialMapAggregatedFieldWells GeospatialMapAggregatedFieldWells { get; set; }
        }

        public class GeospatialMapStyleOptions
        {
            /// <summary>
            /// BaseMapStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstyleoptions.html#cfn-quicksight-analysis-geospatialmapstyleoptions-basemapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapStyle { get; set; }
        }

        public class GeospatialMapVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapConfiguration
            /// </summary>
            public GeospatialMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GeospatialPointStyleOptions
        {
            /// <summary>
            /// SelectedPointStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpointstyleoptions.html#cfn-quicksight-analysis-geospatialpointstyleoptions-selectedpointstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedPointStyle { get; set; }
            /// <summary>
            /// ClusterMarkerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpointstyleoptions.html#cfn-quicksight-analysis-geospatialpointstyleoptions-clustermarkerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarkerConfiguration
            /// </summary>
            public ClusterMarkerConfiguration ClusterMarkerConfiguration { get; set; }
            /// <summary>
            /// HeatmapConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpointstyleoptions.html#cfn-quicksight-analysis-geospatialpointstyleoptions-heatmapconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapConfiguration
            /// </summary>
            public GeospatialHeatmapConfiguration HeatmapConfiguration { get; set; }
        }

        public class GeospatialWindowOptions
        {
            /// <summary>
            /// Bounds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialwindowoptions.html#cfn-quicksight-analysis-geospatialwindowoptions-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapZoomMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialwindowoptions.html#cfn-quicksight-analysis-geospatialwindowoptions-mapzoommode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MapZoomMode { get; set; }
        }

        public class GlobalTableBorderOptions
        {
            /// <summary>
            /// UniformBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-globaltableborderoptions.html#cfn-quicksight-analysis-globaltableborderoptions-uniformborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions UniformBorder { get; set; }
            /// <summary>
            /// SideSpecificBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-globaltableborderoptions.html#cfn-quicksight-analysis-globaltableborderoptions-sidespecificborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSideBorderOptions
            /// </summary>
            public TableSideBorderOptions SideSpecificBorder { get; set; }
        }

        public class GradientColor
        {
            /// <summary>
            /// Stops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gradientcolor.html#cfn-quicksight-analysis-gradientcolor-stops
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GradientStop
            /// </summary>
            public List<GradientStop> Stops { get; set; }
        }

        public class GradientStop
        {
            /// <summary>
            /// GradientOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gradientstop.html#cfn-quicksight-analysis-gradientstop-gradientoffset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GradientOffset { get; set; }
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gradientstop.html#cfn-quicksight-analysis-gradientstop-datavalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gradientstop.html#cfn-quicksight-analysis-gradientstop-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GridLayoutCanvasSizeOptions
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutcanvassizeoptions.html#cfn-quicksight-analysis-gridlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutScreenCanvasSizeOptions
            /// </summary>
            public GridLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class GridLayoutConfiguration
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutconfiguration.html#cfn-quicksight-analysis-gridlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutconfiguration.html#cfn-quicksight-analysis-gridlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GridLayoutElement
            /// </summary>
            public List<GridLayoutElement> Elements { get; set; }
        }

        public class GridLayoutElement
        {
            /// <summary>
            /// ElementType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutelement.html#cfn-quicksight-analysis-gridlayoutelement-elementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementType { get; set; }
            /// <summary>
            /// ColumnSpan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutelement.html#cfn-quicksight-analysis-gridlayoutelement-columnspan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ColumnSpan { get; set; }
            /// <summary>
            /// ColumnIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutelement.html#cfn-quicksight-analysis-gridlayoutelement-columnindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ColumnIndex { get; set; }
            /// <summary>
            /// RowIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutelement.html#cfn-quicksight-analysis-gridlayoutelement-rowindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RowIndex { get; set; }
            /// <summary>
            /// RowSpan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutelement.html#cfn-quicksight-analysis-gridlayoutelement-rowspan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RowSpan { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutelement.html#cfn-quicksight-analysis-gridlayoutelement-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementId { get; set; }
        }

        public class GridLayoutScreenCanvasSizeOptions
        {
            /// <summary>
            /// OptimizedViewPortWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutscreencanvassizeoptions.html#cfn-quicksight-analysis-gridlayoutscreencanvassizeoptions-optimizedviewportwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedViewPortWidth { get; set; }
            /// <summary>
            /// ResizeOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutscreencanvassizeoptions.html#cfn-quicksight-analysis-gridlayoutscreencanvassizeoptions-resizeoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResizeOption { get; set; }
        }

        public class GrowthRateComputation
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// PeriodSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-periodsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodSize { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HeaderFooterSectionConfiguration
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-headerfootersectionconfiguration.html#cfn-quicksight-analysis-headerfootersectionconfiguration-layout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public SectionLayoutConfiguration Layout { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-headerfootersectionconfiguration.html#cfn-quicksight-analysis-headerfootersectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public SectionStyle Style { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-headerfootersectionconfiguration.html#cfn-quicksight-analysis-headerfootersectionconfiguration-sectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SectionId { get; set; }
        }

        public class HeatMapAggregatedFieldWells
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapaggregatedfieldwells.html#cfn-quicksight-analysis-heatmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapaggregatedfieldwells.html#cfn-quicksight-analysis-heatmapaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapaggregatedfieldwells.html#cfn-quicksight-analysis-heatmapaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Rows { get; set; }
        }

        public class HeatMapConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapSortConfiguration
            /// </summary>
            public HeatMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// ColumnLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-columnlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColumnLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapFieldWells
            /// </summary>
            public HeatMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public ColorScale ColorScale { get; set; }
            /// <summary>
            /// RowLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-rowlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions RowLabelOptions { get; set; }
        }

        public class HeatMapFieldWells
        {
            /// <summary>
            /// HeatMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapfieldwells.html#cfn-quicksight-analysis-heatmapfieldwells-heatmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapAggregatedFieldWells
            /// </summary>
            public HeatMapAggregatedFieldWells HeatMapAggregatedFieldWells { get; set; }
        }

        public class HeatMapSortConfiguration
        {
            /// <summary>
            /// HeatMapRowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmaprowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> HeatMapRowSort { get; set; }
            /// <summary>
            /// HeatMapRowItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmaprowitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration HeatMapRowItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmapcolumnitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration HeatMapColumnItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmapcolumnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> HeatMapColumnSort { get; set; }
        }

        public class HeatMapVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapConfiguration
            /// </summary>
            public HeatMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class HistogramAggregatedFieldWells
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramaggregatedfieldwells.html#cfn-quicksight-analysis-histogramaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class HistogramBinOptions
        {
            /// <summary>
            /// BinWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogrambinoptions.html#cfn-quicksight-analysis-histogrambinoptions-binwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinWidthOptions
            /// </summary>
            public BinWidthOptions BinWidth { get; set; }
            /// <summary>
            /// StartValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogrambinoptions.html#cfn-quicksight-analysis-histogrambinoptions-startvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartValue { get; set; }
            /// <summary>
            /// SelectedBinType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogrambinoptions.html#cfn-quicksight-analysis-histogrambinoptions-selectedbintype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedBinType { get; set; }
            /// <summary>
            /// BinCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogrambinoptions.html#cfn-quicksight-analysis-histogrambinoptions-bincount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinCountOptions
            /// </summary>
            public BinCountOptions BinCount { get; set; }
        }

        public class HistogramConfiguration
        {
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// BinOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-binoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramBinOptions
            /// </summary>
            public HistogramBinOptions BinOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramFieldWells
            /// </summary>
            public HistogramFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class HistogramFieldWells
        {
            /// <summary>
            /// HistogramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramfieldwells.html#cfn-quicksight-analysis-histogramfieldwells-histogramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramAggregatedFieldWells
            /// </summary>
            public HistogramAggregatedFieldWells HistogramAggregatedFieldWells { get; set; }
        }

        public class HistogramVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramConfiguration
            /// </summary>
            public HistogramConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class InsightConfiguration
        {
            /// <summary>
            /// Computations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightconfiguration.html#cfn-quicksight-analysis-insightconfiguration-computations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Computation
            /// </summary>
            public List<Computation> Computations { get; set; }
            /// <summary>
            /// CustomNarrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightconfiguration.html#cfn-quicksight-analysis-insightconfiguration-customnarrative
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomNarrativeOptions
            /// </summary>
            public CustomNarrativeOptions CustomNarrative { get; set; }
        }

        public class InsightVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// InsightConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-insightconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightConfiguration
            /// </summary>
            public InsightConfiguration InsightConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class IntegerDefaultValues
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerdefaultvalues.html#cfn-quicksight-analysis-integerdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerdefaultvalues.html#cfn-quicksight-analysis-integerdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class IntegerParameter
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameter.html#cfn-quicksight-analysis-integerparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameter.html#cfn-quicksight-analysis-integerparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegerParameterDeclaration
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDefaultValues
            /// </summary>
            public IntegerDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerValueWhenUnsetConfiguration
            /// </summary>
            public IntegerValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegerValueWhenUnsetConfiguration
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integervaluewhenunsetconfiguration.html#cfn-quicksight-analysis-integervaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integervaluewhenunsetconfiguration.html#cfn-quicksight-analysis-integervaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class ItemsLimitConfiguration
        {
            /// <summary>
            /// ItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-itemslimitconfiguration.html#cfn-quicksight-analysis-itemslimitconfiguration-itemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ItemsLimit { get; set; }
            /// <summary>
            /// OtherCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-itemslimitconfiguration.html#cfn-quicksight-analysis-itemslimitconfiguration-othercategories
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OtherCategories { get; set; }
        }

        public class KPIActualValueConditionalFormatting
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiactualvalueconditionalformatting.html#cfn-quicksight-analysis-kpiactualvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiactualvalueconditionalformatting.html#cfn-quicksight-analysis-kpiactualvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIComparisonValueConditionalFormatting
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-analysis-kpicomparisonvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-analysis-kpicomparisonvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIConditionalFormatting
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformatting.html#cfn-quicksight-analysis-kpiconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KPIConditionalFormattingOption
            /// </summary>
            public List<KPIConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class KPIConditionalFormattingOption
        {
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIPrimaryValueConditionalFormatting
            /// </summary>
            public KPIPrimaryValueConditionalFormatting PrimaryValue { get; set; }
            /// <summary>
            /// ActualValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-actualvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIActualValueConditionalFormatting
            /// </summary>
            public KPIActualValueConditionalFormatting ActualValue { get; set; }
            /// <summary>
            /// ComparisonValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-comparisonvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIComparisonValueConditionalFormatting
            /// </summary>
            public KPIComparisonValueConditionalFormatting ComparisonValue { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIProgressBarConditionalFormatting
            /// </summary>
            public KPIProgressBarConditionalFormatting ProgressBar { get; set; }
        }

        public class KPIConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconfiguration.html#cfn-quicksight-analysis-kpiconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISortConfiguration
            /// </summary>
            public KPISortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// KPIOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconfiguration.html#cfn-quicksight-analysis-kpiconfiguration-kpioptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIOptions
            /// </summary>
            public KPIOptions KPIOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconfiguration.html#cfn-quicksight-analysis-kpiconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIFieldWells
            /// </summary>
            public KPIFieldWells FieldWells { get; set; }
        }

        public class KPIFieldWells
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpifieldwells.html#cfn-quicksight-analysis-kpifieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> TargetValues { get; set; }
            /// <summary>
            /// TrendGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpifieldwells.html#cfn-quicksight-analysis-kpifieldwells-trendgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> TrendGroups { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpifieldwells.html#cfn-quicksight-analysis-kpifieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class KPIOptions
        {
            /// <summary>
            /// SecondaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-secondaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration SecondaryValueFontConfiguration { get; set; }
            /// <summary>
            /// VisualLayoutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-visuallayoutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualLayoutOptions
            /// </summary>
            public KPIVisualLayoutOptions VisualLayoutOptions { get; set; }
            /// <summary>
            /// TrendArrows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-trendarrows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendArrowOptions
            /// </summary>
            public TrendArrowOptions TrendArrows { get; set; }
            /// <summary>
            /// SecondaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-secondaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecondaryValueOptions
            /// </summary>
            public SecondaryValueOptions SecondaryValue { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public ComparisonConfiguration Comparison { get; set; }
            /// <summary>
            /// PrimaryValueDisplayType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-primaryvaluedisplaytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryValueDisplayType { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressBarOptions
            /// </summary>
            public ProgressBarOptions ProgressBar { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration PrimaryValueFontConfiguration { get; set; }
            /// <summary>
            /// Sparkline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-sparkline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISparklineOptions
            /// </summary>
            public KPISparklineOptions Sparkline { get; set; }
        }

        public class KPIPrimaryValueConditionalFormatting
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-kpiprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-kpiprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIProgressBarConditionalFormatting
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiprogressbarconditionalformatting.html#cfn-quicksight-analysis-kpiprogressbarconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class KPISortConfiguration
        {
            /// <summary>
            /// TrendGroupSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpisortconfiguration.html#cfn-quicksight-analysis-kpisortconfiguration-trendgroupsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> TrendGroupSort { get; set; }
        }

        public class KPISparklineOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpisparklineoptions.html#cfn-quicksight-analysis-kpisparklineoptions-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpisparklineoptions.html#cfn-quicksight-analysis-kpisparklineoptions-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// TooltipVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpisparklineoptions.html#cfn-quicksight-analysis-kpisparklineoptions-tooltipvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipVisibility { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpisparklineoptions.html#cfn-quicksight-analysis-kpisparklineoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class KPIVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConditionalFormatting
            /// </summary>
            public KPIConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConfiguration
            /// </summary>
            public KPIConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class KPIVisualLayoutOptions
        {
            /// <summary>
            /// StandardLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisuallayoutoptions.html#cfn-quicksight-analysis-kpivisuallayoutoptions-standardlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualStandardLayout
            /// </summary>
            public KPIVisualStandardLayout StandardLayout { get; set; }
        }

        public class KPIVisualStandardLayout
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisualstandardlayout.html#cfn-quicksight-analysis-kpivisualstandardlayout-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class LabelOptions
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-labeloptions.html#cfn-quicksight-analysis-labeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-labeloptions.html#cfn-quicksight-analysis-labeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-labeloptions.html#cfn-quicksight-analysis-labeloptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
        }

        public class Layout
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layout.html#cfn-quicksight-analysis-layout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LayoutConfiguration
            /// </summary>
            public LayoutConfiguration Configuration { get; set; }
        }

        public class LayoutConfiguration
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layoutconfiguration.html#cfn-quicksight-analysis-layoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public GridLayoutConfiguration GridLayout { get; set; }
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layoutconfiguration.html#cfn-quicksight-analysis-layoutconfiguration-freeformlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutConfiguration
            /// </summary>
            public FreeFormLayoutConfiguration FreeFormLayout { get; set; }
            /// <summary>
            /// SectionBasedLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layoutconfiguration.html#cfn-quicksight-analysis-layoutconfiguration-sectionbasedlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutConfiguration
            /// </summary>
            public SectionBasedLayoutConfiguration SectionBasedLayout { get; set; }
        }

        public class LegendOptions
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions Title { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class LineChartAggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> SmallMultiples { get; set; }
        }

        public class LineChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSortConfiguration
            /// </summary>
            public LineChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions XAxisDisplayOptions { get; set; }
            /// <summary>
            /// DefaultSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-defaultseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartDefaultSeriesSettings
            /// </summary>
            public LineChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ForecastConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-forecastconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ForecastConfiguration
            /// </summary>
            public List<ForecastConfiguration> ForecastConfigurations { get; set; }
            /// <summary>
            /// Series
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-series
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeriesItem
            /// </summary>
            public List<SeriesItem> Series { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartFieldWells
            /// </summary>
            public LineChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions XAxisLabelOptions { get; set; }
        }

        public class LineChartDefaultSeriesSettings
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartdefaultseriessettings.html#cfn-quicksight-analysis-linechartdefaultseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartdefaultseriessettings.html#cfn-quicksight-analysis-linechartdefaultseriessettings-axisbinding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartdefaultseriessettings.html#cfn-quicksight-analysis-linechartdefaultseriessettings-markerstylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartMarkerStyleSettings
            /// </summary>
            public LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartFieldWells
        {
            /// <summary>
            /// LineChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartfieldwells.html#cfn-quicksight-analysis-linechartfieldwells-linechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartAggregatedFieldWells
            /// </summary>
            public LineChartAggregatedFieldWells LineChartAggregatedFieldWells { get; set; }
        }

        public class LineChartLineStyleSettings
        {
            /// <summary>
            /// LineInterpolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartlinestylesettings.html#cfn-quicksight-analysis-linechartlinestylesettings-lineinterpolation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineInterpolation { get; set; }
            /// <summary>
            /// LineStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartlinestylesettings.html#cfn-quicksight-analysis-linechartlinestylesettings-linestyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineStyle { get; set; }
            /// <summary>
            /// LineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartlinestylesettings.html#cfn-quicksight-analysis-linechartlinestylesettings-linevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineVisibility { get; set; }
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartlinestylesettings.html#cfn-quicksight-analysis-linechartlinestylesettings-linewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineWidth { get; set; }
        }

        public class LineChartMarkerStyleSettings
        {
            /// <summary>
            /// MarkerShape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartmarkerstylesettings.html#cfn-quicksight-analysis-linechartmarkerstylesettings-markershape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerShape { get; set; }
            /// <summary>
            /// MarkerSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartmarkerstylesettings.html#cfn-quicksight-analysis-linechartmarkerstylesettings-markersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerSize { get; set; }
            /// <summary>
            /// MarkerVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartmarkerstylesettings.html#cfn-quicksight-analysis-linechartmarkerstylesettings-markervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerVisibility { get; set; }
            /// <summary>
            /// MarkerColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartmarkerstylesettings.html#cfn-quicksight-analysis-linechartmarkerstylesettings-markercolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerColor { get; set; }
        }

        public class LineChartSeriesSettings
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartseriessettings.html#cfn-quicksight-analysis-linechartseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartseriessettings.html#cfn-quicksight-analysis-linechartseriessettings-markerstylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartMarkerStyleSettings
            /// </summary>
            public LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartSortConfiguration
        {
            /// <summary>
            /// CategoryItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-categoryitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimitConfiguration { get; set; }
            /// <summary>
            /// ColorItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-coloritemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimitConfiguration { get; set; }
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class LineChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartConfiguration
            /// </summary>
            public LineChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class LineSeriesAxisDisplayOptions
        {
            /// <summary>
            /// MissingDataConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-lineseriesaxisdisplayoptions.html#cfn-quicksight-analysis-lineseriesaxisdisplayoptions-missingdataconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MissingDataConfiguration
            /// </summary>
            public List<MissingDataConfiguration> MissingDataConfigurations { get; set; }
            /// <summary>
            /// AxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-lineseriesaxisdisplayoptions.html#cfn-quicksight-analysis-lineseriesaxisdisplayoptions-axisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions AxisOptions { get; set; }
        }

        public class ListControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SearchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-searchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSearchOptions
            /// </summary>
            public ListControlSearchOptions SearchOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ListControlSearchOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontrolsearchoptions.html#cfn-quicksight-analysis-listcontrolsearchoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class ListControlSelectAllOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontrolselectalloptions.html#cfn-quicksight-analysis-listcontrolselectalloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class LoadingAnimation
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-loadinganimation.html#cfn-quicksight-analysis-loadinganimation-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class LocalNavigationConfiguration
        {
            /// <summary>
            /// TargetSheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-localnavigationconfiguration.html#cfn-quicksight-analysis-localnavigationconfiguration-targetsheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetSheetId { get; set; }
        }

        public class LongFormatText
        {
            /// <summary>
            /// RichText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-longformattext.html#cfn-quicksight-analysis-longformattext-richtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RichText { get; set; }
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-longformattext.html#cfn-quicksight-analysis-longformattext-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlainText { get; set; }
        }

        public class MappedDataSetParameter
        {
            /// <summary>
            /// DataSetParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-mappeddatasetparameter.html#cfn-quicksight-analysis-mappeddatasetparameter-datasetparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetParameterName { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-mappeddatasetparameter.html#cfn-quicksight-analysis-mappeddatasetparameter-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class MaximumLabelType
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumlabeltype.html#cfn-quicksight-analysis-maximumlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class MaximumMinimumComputation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumminimumcomputation.html#cfn-quicksight-analysis-maximumminimumcomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumminimumcomputation.html#cfn-quicksight-analysis-maximumminimumcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumminimumcomputation.html#cfn-quicksight-analysis-maximumminimumcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumminimumcomputation.html#cfn-quicksight-analysis-maximumminimumcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumminimumcomputation.html#cfn-quicksight-analysis-maximumminimumcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MeasureField
        {
            /// <summary>
            /// DateMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-datemeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateMeasureField
            /// </summary>
            public DateMeasureField DateMeasureField { get; set; }
            /// <summary>
            /// NumericalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-numericalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalMeasureField
            /// </summary>
            public NumericalMeasureField NumericalMeasureField { get; set; }
            /// <summary>
            /// CategoricalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-categoricalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalMeasureField
            /// </summary>
            public CategoricalMeasureField CategoricalMeasureField { get; set; }
            /// <summary>
            /// CalculatedMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-calculatedmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CalculatedMeasureField
            /// </summary>
            public CalculatedMeasureField CalculatedMeasureField { get; set; }
        }

        public class MetricComparisonComputation
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField TargetValue { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// FromValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-fromvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField FromValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MinimumLabelType
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-minimumlabeltype.html#cfn-quicksight-analysis-minimumlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class MissingDataConfiguration
        {
            /// <summary>
            /// TreatmentOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-missingdataconfiguration.html#cfn-quicksight-analysis-missingdataconfiguration-treatmentoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TreatmentOption { get; set; }
        }

        public class NegativeValueConfiguration
        {
            /// <summary>
            /// DisplayMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-negativevalueconfiguration.html#cfn-quicksight-analysis-negativevalueconfiguration-displaymode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayMode { get; set; }
        }

        public class NullValueFormatConfiguration
        {
            /// <summary>
            /// NullString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-nullvalueformatconfiguration.html#cfn-quicksight-analysis-nullvalueformatconfiguration-nullstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullString { get; set; }
        }

        public class NumberDisplayFormatConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NumberScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-numberscale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NumberScale { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class NumberFormatConfiguration
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberformatconfiguration.html#cfn-quicksight-analysis-numberformatconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration FormatConfiguration { get; set; }
        }

        public class NumericAxisOptions
        {
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaxisoptions.html#cfn-quicksight-analysis-numericaxisoptions-scale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisScale
            /// </summary>
            public AxisScale Scale { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaxisoptions.html#cfn-quicksight-analysis-numericaxisoptions-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayRange
            /// </summary>
            public AxisDisplayRange Range { get; set; }
        }

        public class NumericEqualityDrillDownFilter
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalitydrilldownfilter.html#cfn-quicksight-analysis-numericequalitydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalitydrilldownfilter.html#cfn-quicksight-analysis-numericequalitydrilldownfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class NumericEqualityFilter
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class NumericFormatConfiguration
        {
            /// <summary>
            /// NumberDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericformatconfiguration.html#cfn-quicksight-analysis-numericformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// CurrencyDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericformatconfiguration.html#cfn-quicksight-analysis-numericformatconfiguration-currencydisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CurrencyDisplayFormatConfiguration
            /// </summary>
            public CurrencyDisplayFormatConfiguration CurrencyDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericformatconfiguration.html#cfn-quicksight-analysis-numericformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class NumericRangeFilter
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilterValue
            /// </summary>
            public NumericRangeFilterValue RangeMinimum { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilterValue
            /// </summary>
            public NumericRangeFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
        }

        public class NumericRangeFilterValue
        {
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefiltervalue.html#cfn-quicksight-analysis-numericrangefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StaticValue { get; set; }
            /// <summary>
            /// Parameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefiltervalue.html#cfn-quicksight-analysis-numericrangefiltervalue-parameter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Parameter { get; set; }
        }

        public class NumericSeparatorConfiguration
        {
            /// <summary>
            /// DecimalSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericseparatorconfiguration.html#cfn-quicksight-analysis-numericseparatorconfiguration-decimalseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DecimalSeparator { get; set; }
            /// <summary>
            /// ThousandsSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericseparatorconfiguration.html#cfn-quicksight-analysis-numericseparatorconfiguration-thousandsseparator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThousandSeparatorOptions
            /// </summary>
            public ThousandSeparatorOptions ThousandsSeparator { get; set; }
        }

        public class NumericalAggregationFunction
        {
            /// <summary>
            /// PercentileAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalaggregationfunction.html#cfn-quicksight-analysis-numericalaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentileAggregation
            /// </summary>
            public PercentileAggregation PercentileAggregation { get; set; }
            /// <summary>
            /// SimpleNumericalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalaggregationfunction.html#cfn-quicksight-analysis-numericalaggregationfunction-simplenumericalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleNumericalAggregation { get; set; }
        }

        public class NumericalDimensionField
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaldimensionfield.html#cfn-quicksight-analysis-numericaldimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaldimensionfield.html#cfn-quicksight-analysis-numericaldimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaldimensionfield.html#cfn-quicksight-analysis-numericaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaldimensionfield.html#cfn-quicksight-analysis-numericaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class NumericalMeasureField
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public NumericalAggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class PaginationConfiguration
        {
            /// <summary>
            /// PageSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-paginationconfiguration.html#cfn-quicksight-analysis-paginationconfiguration-pagesize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PageSize { get; set; }
            /// <summary>
            /// PageNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-paginationconfiguration.html#cfn-quicksight-analysis-paginationconfiguration-pagenumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PageNumber { get; set; }
        }

        public class PanelConfiguration
        {
            /// <summary>
            /// BorderThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-borderthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderThickness { get; set; }
            /// <summary>
            /// BorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-borderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderStyle { get; set; }
            /// <summary>
            /// GutterSpacing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-gutterspacing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GutterSpacing { get; set; }
            /// <summary>
            /// BackgroundVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-backgroundvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundVisibility { get; set; }
            /// <summary>
            /// BorderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-bordervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderVisibility { get; set; }
            /// <summary>
            /// BorderColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-bordercolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderColor { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PanelTitleOptions
            /// </summary>
            public PanelTitleOptions Title { get; set; }
            /// <summary>
            /// GutterVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-guttervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GutterVisibility { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-panelconfiguration.html#cfn-quicksight-analysis-panelconfiguration-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class PanelTitleOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-paneltitleoptions.html#cfn-quicksight-analysis-paneltitleoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-paneltitleoptions.html#cfn-quicksight-analysis-paneltitleoptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-paneltitleoptions.html#cfn-quicksight-analysis-paneltitleoptions-horizontaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalTextAlignment { get; set; }
        }

        public class ParameterControl
        {
            /// <summary>
            /// Slider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSliderControl
            /// </summary>
            public ParameterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextAreaControl
            /// </summary>
            public ParameterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDropDownControl
            /// </summary>
            public ParameterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextFieldControl
            /// </summary>
            public ParameterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterListControl
            /// </summary>
            public ParameterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDateTimePickerControl
            /// </summary>
            public ParameterDateTimePickerControl DateTimePicker { get; set; }
        }

        public class ParameterDateTimePickerControl
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdatetimepickercontrol.html#cfn-quicksight-analysis-parameterdatetimepickercontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdatetimepickercontrol.html#cfn-quicksight-analysis-parameterdatetimepickercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdatetimepickercontrol.html#cfn-quicksight-analysis-parameterdatetimepickercontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdatetimepickercontrol.html#cfn-quicksight-analysis-parameterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class ParameterDeclaration
        {
            /// <summary>
            /// StringParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-stringparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringParameterDeclaration
            /// </summary>
            public StringParameterDeclaration StringParameterDeclaration { get; set; }
            /// <summary>
            /// DateTimeParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-datetimeparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeParameterDeclaration
            /// </summary>
            public DateTimeParameterDeclaration DateTimeParameterDeclaration { get; set; }
            /// <summary>
            /// DecimalParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-decimalparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalParameterDeclaration
            /// </summary>
            public DecimalParameterDeclaration DecimalParameterDeclaration { get; set; }
            /// <summary>
            /// IntegerParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-integerparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerParameterDeclaration
            /// </summary>
            public IntegerParameterDeclaration IntegerParameterDeclaration { get; set; }
        }

        public class ParameterDropDownControl
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSelectableValues
            /// </summary>
            public ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterListControl
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterlistcontrol.html#cfn-quicksight-analysis-parameterlistcontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSelectableValues
            /// </summary>
            public ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterSelectableValues
        {
            /// <summary>
            /// LinkToDataSetColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterselectablevalues.html#cfn-quicksight-analysis-parameterselectablevalues-linktodatasetcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier LinkToDataSetColumn { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterselectablevalues.html#cfn-quicksight-analysis-parameterselectablevalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class ParameterSliderControl
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterslidercontrol.html#cfn-quicksight-analysis-parameterslidercontrol-minimumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumValue { get; set; }
        }

        public class ParameterTextAreaControl
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextareacontrol.html#cfn-quicksight-analysis-parametertextareacontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextareacontrol.html#cfn-quicksight-analysis-parametertextareacontrol-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextareacontrol.html#cfn-quicksight-analysis-parametertextareacontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public TextAreaControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextareacontrol.html#cfn-quicksight-analysis-parametertextareacontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextareacontrol.html#cfn-quicksight-analysis-parametertextareacontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class ParameterTextFieldControl
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextfieldcontrol.html#cfn-quicksight-analysis-parametertextfieldcontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextfieldcontrol.html#cfn-quicksight-analysis-parametertextfieldcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public TextFieldControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextfieldcontrol.html#cfn-quicksight-analysis-parametertextfieldcontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametertextfieldcontrol.html#cfn-quicksight-analysis-parametertextfieldcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class Parameters
        {
            /// <summary>
            /// StringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-stringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringParameter
            /// </summary>
            public List<StringParameter> StringParameters { get; set; }
            /// <summary>
            /// DecimalParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-decimalparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DecimalParameter
            /// </summary>
            public List<DecimalParameter> DecimalParameters { get; set; }
            /// <summary>
            /// IntegerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-integerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerParameter
            /// </summary>
            public List<IntegerParameter> IntegerParameters { get; set; }
            /// <summary>
            /// DateTimeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-datetimeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateTimeParameter
            /// </summary>
            public List<DateTimeParameter> DateTimeParameters { get; set; }
        }

        public class PercentVisibleRange
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentvisiblerange.html#cfn-quicksight-analysis-percentvisiblerange-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentvisiblerange.html#cfn-quicksight-analysis-percentvisiblerange-to
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic To { get; set; }
        }

        public class PercentageDisplayFormatConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class PercentileAggregation
        {
            /// <summary>
            /// PercentileValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentileaggregation.html#cfn-quicksight-analysis-percentileaggregation-percentilevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentileValue { get; set; }
        }

        public class PeriodOverPeriodComputation
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodoverperiodcomputation.html#cfn-quicksight-analysis-periodoverperiodcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodoverperiodcomputation.html#cfn-quicksight-analysis-periodoverperiodcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodoverperiodcomputation.html#cfn-quicksight-analysis-periodoverperiodcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodoverperiodcomputation.html#cfn-quicksight-analysis-periodoverperiodcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PeriodToDateComputation
        {
            /// <summary>
            /// PeriodTimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodtodatecomputation.html#cfn-quicksight-analysis-periodtodatecomputation-periodtimegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeriodTimeGranularity { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodtodatecomputation.html#cfn-quicksight-analysis-periodtodatecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodtodatecomputation.html#cfn-quicksight-analysis-periodtodatecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodtodatecomputation.html#cfn-quicksight-analysis-periodtodatecomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodtodatecomputation.html#cfn-quicksight-analysis-periodtodatecomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PieChartAggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartaggregatedfieldwells.html#cfn-quicksight-analysis-piechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartaggregatedfieldwells.html#cfn-quicksight-analysis-piechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartaggregatedfieldwells.html#cfn-quicksight-analysis-piechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> SmallMultiples { get; set; }
        }

        public class PieChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartSortConfiguration
            /// </summary>
            public PieChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartFieldWells
            /// </summary>
            public PieChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// DonutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-donutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutOptions
            /// </summary>
            public DonutOptions DonutOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
        }

        public class PieChartFieldWells
        {
            /// <summary>
            /// PieChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartfieldwells.html#cfn-quicksight-analysis-piechartfieldwells-piechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartAggregatedFieldWells
            /// </summary>
            public PieChartAggregatedFieldWells PieChartAggregatedFieldWells { get; set; }
        }

        public class PieChartSortConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class PieChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartConfiguration
            /// </summary>
            public PieChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class PivotFieldSortOptions
        {
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivotfieldsortoptions.html#cfn-quicksight-analysis-pivotfieldsortoptions-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableSortBy
            /// </summary>
            public PivotTableSortBy SortBy { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivotfieldsortoptions.html#cfn-quicksight-analysis-pivotfieldsortoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class PivotTableAggregatedFieldWells
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableaggregatedfieldwells.html#cfn-quicksight-analysis-pivottableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableaggregatedfieldwells.html#cfn-quicksight-analysis-pivottableaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableaggregatedfieldwells.html#cfn-quicksight-analysis-pivottableaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Rows { get; set; }
        }

        public class PivotTableCellConditionalFormatting
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablecellconditionalformatting.html#cfn-quicksight-analysis-pivottablecellconditionalformatting-scope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormattingScope
            /// </summary>
            public PivotTableConditionalFormattingScope Scope { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablecellconditionalformatting.html#cfn-quicksight-analysis-pivottablecellconditionalformatting-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingScope
            /// </summary>
            public List<PivotTableConditionalFormattingScope> Scopes { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablecellconditionalformatting.html#cfn-quicksight-analysis-pivottablecellconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablecellconditionalformatting.html#cfn-quicksight-analysis-pivottablecellconditionalformatting-textformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextConditionalFormat
            /// </summary>
            public TextConditionalFormat TextFormat { get; set; }
        }

        public class PivotTableConditionalFormatting
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconditionalformatting.html#cfn-quicksight-analysis-pivottableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingOption
            /// </summary>
            public List<PivotTableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class PivotTableConditionalFormattingOption
        {
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconditionalformattingoption.html#cfn-quicksight-analysis-pivottableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableCellConditionalFormatting
            /// </summary>
            public PivotTableCellConditionalFormatting Cell { get; set; }
        }

        public class PivotTableConditionalFormattingScope
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconditionalformattingscope.html#cfn-quicksight-analysis-pivottableconditionalformattingscope-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
        }

        public class PivotTableConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableSortConfiguration
            /// </summary>
            public PivotTableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTablePaginatedReportOptions
            /// </summary>
            public PivotTablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableOptions
            /// </summary>
            public PivotTableOptions TableOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldWells
            /// </summary>
            public PivotTableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldOptions
            /// </summary>
            public PivotTableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableTotalOptions
            /// </summary>
            public PivotTableTotalOptions TotalOptions { get; set; }
        }

        public class PivotTableDataPathOption
        {
            /// <summary>
            /// DataPathList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabledatapathoption.html#cfn-quicksight-analysis-pivottabledatapathoption-datapathlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<DataPathValue> DataPathList { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabledatapathoption.html#cfn-quicksight-analysis-pivottabledatapathoption-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class PivotTableFieldCollapseStateOption
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldcollapsestateoption.html#cfn-quicksight-analysis-pivottablefieldcollapsestateoption-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableFieldCollapseStateTarget
            /// </summary>
            public PivotTableFieldCollapseStateTarget Target { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldcollapsestateoption.html#cfn-quicksight-analysis-pivottablefieldcollapsestateoption-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class PivotTableFieldCollapseStateTarget
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldcollapsestatetarget.html#cfn-quicksight-analysis-pivottablefieldcollapsestatetarget-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// FieldDataPathValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldcollapsestatetarget.html#cfn-quicksight-analysis-pivottablefieldcollapsestatetarget-fielddatapathvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<DataPathValue> FieldDataPathValues { get; set; }
        }

        public class PivotTableFieldOption
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoption.html#cfn-quicksight-analysis-pivottablefieldoption-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoption.html#cfn-quicksight-analysis-pivottablefieldoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoption.html#cfn-quicksight-analysis-pivottablefieldoption-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class PivotTableFieldOptions
        {
            /// <summary>
            /// CollapseStateOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoptions.html#cfn-quicksight-analysis-pivottablefieldoptions-collapsestateoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldCollapseStateOption
            /// </summary>
            public List<PivotTableFieldCollapseStateOption> CollapseStateOptions { get; set; }
            /// <summary>
            /// DataPathOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoptions.html#cfn-quicksight-analysis-pivottablefieldoptions-datapathoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableDataPathOption
            /// </summary>
            public List<PivotTableDataPathOption> DataPathOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoptions.html#cfn-quicksight-analysis-pivottablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldOption
            /// </summary>
            public List<PivotTableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class PivotTableFieldSubtotalOptions
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldsubtotaloptions.html#cfn-quicksight-analysis-pivottablefieldsubtotaloptions-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class PivotTableFieldWells
        {
            /// <summary>
            /// PivotTableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldwells.html#cfn-quicksight-analysis-pivottablefieldwells-pivottableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableAggregatedFieldWells
            /// </summary>
            public PivotTableAggregatedFieldWells PivotTableAggregatedFieldWells { get; set; }
        }

        public class PivotTableOptions
        {
            /// <summary>
            /// RowFieldNamesStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowfieldnamesstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle RowFieldNamesStyle { get; set; }
            /// <summary>
            /// RowHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle RowHeaderStyle { get; set; }
            /// <summary>
            /// CollapsedRowDimensionsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-collapsedrowdimensionsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollapsedRowDimensionsVisibility { get; set; }
            /// <summary>
            /// RowsLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowslayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RowsLayout { get; set; }
            /// <summary>
            /// MetricPlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-metricplacement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricPlacement { get; set; }
            /// <summary>
            /// DefaultCellWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-defaultcellwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultCellWidth { get; set; }
            /// <summary>
            /// ColumnNamesVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-columnnamesvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnNamesVisibility { get; set; }
            /// <summary>
            /// RowsLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowslabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableRowsLabelOptions
            /// </summary>
            public PivotTableRowsLabelOptions RowsLabelOptions { get; set; }
            /// <summary>
            /// SingleMetricVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-singlemetricvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SingleMetricVisibility { get; set; }
            /// <summary>
            /// ColumnHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-columnheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle ColumnHeaderStyle { get; set; }
            /// <summary>
            /// ToggleButtonsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-togglebuttonsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToggleButtonsVisibility { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowalternatecoloroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowAlternateColorOptions
            /// </summary>
            public RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class PivotTablePaginatedReportOptions
        {
            /// <summary>
            /// OverflowColumnHeaderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablepaginatedreportoptions.html#cfn-quicksight-analysis-pivottablepaginatedreportoptions-overflowcolumnheadervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverflowColumnHeaderVisibility { get; set; }
            /// <summary>
            /// VerticalOverflowVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablepaginatedreportoptions.html#cfn-quicksight-analysis-pivottablepaginatedreportoptions-verticaloverflowvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalOverflowVisibility { get; set; }
        }

        public class PivotTableRowsLabelOptions
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablerowslabeloptions.html#cfn-quicksight-analysis-pivottablerowslabeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablerowslabeloptions.html#cfn-quicksight-analysis-pivottablerowslabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class PivotTableSortBy
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortby.html#cfn-quicksight-analysis-pivottablesortby-field
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public FieldSort Field { get; set; }
            /// <summary>
            /// DataPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortby.html#cfn-quicksight-analysis-pivottablesortby-datapath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathSort
            /// </summary>
            public DataPathSort DataPath { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortby.html#cfn-quicksight-analysis-pivottablesortby-column
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public ColumnSort Column { get; set; }
        }

        public class PivotTableSortConfiguration
        {
            /// <summary>
            /// FieldSortOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortconfiguration.html#cfn-quicksight-analysis-pivottablesortconfiguration-fieldsortoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotFieldSortOptions
            /// </summary>
            public List<PivotFieldSortOptions> FieldSortOptions { get; set; }
        }

        public class PivotTableTotalOptions
        {
            /// <summary>
            /// ColumnSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-columnsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public SubtotalOptions ColumnSubtotalOptions { get; set; }
            /// <summary>
            /// RowSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-rowsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public SubtotalOptions RowSubtotalOptions { get; set; }
            /// <summary>
            /// RowTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-rowtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public PivotTotalOptions RowTotalOptions { get; set; }
            /// <summary>
            /// ColumnTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-columntotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public PivotTotalOptions ColumnTotalOptions { get; set; }
        }

        public class PivotTableVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormatting
            /// </summary>
            public PivotTableConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConfiguration
            /// </summary>
            public PivotTableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class PivotTotalOptions
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<TotalAggregationOption> TotalAggregationOptions { get; set; }
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// ScrollStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-scrollstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScrollStatus { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// MetricHeaderCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-metricheadercellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle MetricHeaderCellStyle { get; set; }
        }

        public class PredefinedHierarchy
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-predefinedhierarchy.html#cfn-quicksight-analysis-predefinedhierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-predefinedhierarchy.html#cfn-quicksight-analysis-predefinedhierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-predefinedhierarchy.html#cfn-quicksight-analysis-predefinedhierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<ColumnIdentifier> Columns { get; set; }
        }

        public class ProgressBarOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-progressbaroptions.html#cfn-quicksight-analysis-progressbaroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class RadarChartAggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartaggregatedfieldwells.html#cfn-quicksight-analysis-radarchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartaggregatedfieldwells.html#cfn-quicksight-analysis-radarchartaggregatedfieldwells-color
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Color { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartaggregatedfieldwells.html#cfn-quicksight-analysis-radarchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class RadarChartAreaStyleSettings
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartareastylesettings.html#cfn-quicksight-analysis-radarchartareastylesettings-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class RadarChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSortConfiguration
            /// </summary>
            public RadarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-shape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Shape { get; set; }
            /// <summary>
            /// BaseSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-baseseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSeriesSettings
            /// </summary>
            public RadarChartSeriesSettings BaseSeriesSettings { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// AxesRangeScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-axesrangescale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxesRangeScale { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// AlternateBandColorsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-alternatebandcolorsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandColorsVisibility { get; set; }
            /// <summary>
            /// StartAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-startangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartAngle { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartFieldWells
            /// </summary>
            public RadarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ColorAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-coloraxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions ColorAxis { get; set; }
            /// <summary>
            /// AlternateBandOddColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-alternatebandoddcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandOddColor { get; set; }
            /// <summary>
            /// AlternateBandEvenColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-alternatebandevencolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandEvenColor { get; set; }
        }

        public class RadarChartFieldWells
        {
            /// <summary>
            /// RadarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartfieldwells.html#cfn-quicksight-analysis-radarchartfieldwells-radarchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAggregatedFieldWells
            /// </summary>
            public RadarChartAggregatedFieldWells RadarChartAggregatedFieldWells { get; set; }
        }

        public class RadarChartSeriesSettings
        {
            /// <summary>
            /// AreaStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartseriessettings.html#cfn-quicksight-analysis-radarchartseriessettings-areastylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAreaStyleSettings
            /// </summary>
            public RadarChartAreaStyleSettings AreaStyleSettings { get; set; }
        }

        public class RadarChartSortConfiguration
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
        }

        public class RadarChartVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartConfiguration
            /// </summary>
            public RadarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class RangeEndsLabelType
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-rangeendslabeltype.html#cfn-quicksight-analysis-rangeendslabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class ReferenceLine
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referenceline.html#cfn-quicksight-analysis-referenceline-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// DataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referenceline.html#cfn-quicksight-analysis-referenceline-dataconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReferenceLineDataConfiguration
            /// </summary>
            public ReferenceLineDataConfiguration DataConfiguration { get; set; }
            /// <summary>
            /// LabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referenceline.html#cfn-quicksight-analysis-referenceline-labelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineLabelConfiguration
            /// </summary>
            public ReferenceLineLabelConfiguration LabelConfiguration { get; set; }
            /// <summary>
            /// StyleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referenceline.html#cfn-quicksight-analysis-referenceline-styleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineStyleConfiguration
            /// </summary>
            public ReferenceLineStyleConfiguration StyleConfiguration { get; set; }
        }

        public class ReferenceLineCustomLabelConfiguration
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinecustomlabelconfiguration.html#cfn-quicksight-analysis-referencelinecustomlabelconfiguration-customlabel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
        }

        public class ReferenceLineDataConfiguration
        {
            /// <summary>
            /// DynamicConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedataconfiguration.html#cfn-quicksight-analysis-referencelinedataconfiguration-dynamicconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineDynamicDataConfiguration
            /// </summary>
            public ReferenceLineDynamicDataConfiguration DynamicConfiguration { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedataconfiguration.html#cfn-quicksight-analysis-referencelinedataconfiguration-axisbinding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// SeriesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedataconfiguration.html#cfn-quicksight-analysis-referencelinedataconfiguration-seriestype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SeriesType { get; set; }
            /// <summary>
            /// StaticConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedataconfiguration.html#cfn-quicksight-analysis-referencelinedataconfiguration-staticconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineStaticDataConfiguration
            /// </summary>
            public ReferenceLineStaticDataConfiguration StaticConfiguration { get; set; }
        }

        public class ReferenceLineDynamicDataConfiguration
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedynamicdataconfiguration.html#cfn-quicksight-analysis-referencelinedynamicdataconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// MeasureAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedynamicdataconfiguration.html#cfn-quicksight-analysis-referencelinedynamicdataconfiguration-measureaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction MeasureAggregationFunction { get; set; }
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedynamicdataconfiguration.html#cfn-quicksight-analysis-referencelinedynamicdataconfiguration-calculation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public NumericalAggregationFunction Calculation { get; set; }
        }

        public class ReferenceLineLabelConfiguration
        {
            /// <summary>
            /// HorizontalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-horizontalposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalPosition { get; set; }
            /// <summary>
            /// ValueLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-valuelabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineValueLabelConfiguration
            /// </summary>
            public ReferenceLineValueLabelConfiguration ValueLabelConfiguration { get; set; }
            /// <summary>
            /// CustomLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-customlabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineCustomLabelConfiguration
            /// </summary>
            public ReferenceLineCustomLabelConfiguration CustomLabelConfiguration { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// VerticalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-verticalposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalPosition { get; set; }
        }

        public class ReferenceLineStaticDataConfiguration
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinestaticdataconfiguration.html#cfn-quicksight-analysis-referencelinestaticdataconfiguration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class ReferenceLineStyleConfiguration
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinestyleconfiguration.html#cfn-quicksight-analysis-referencelinestyleconfiguration-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinestyleconfiguration.html#cfn-quicksight-analysis-referencelinestyleconfiguration-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class ReferenceLineValueLabelConfiguration
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinevaluelabelconfiguration.html#cfn-quicksight-analysis-referencelinevaluelabelconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// RelativePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinevaluelabelconfiguration.html#cfn-quicksight-analysis-referencelinevaluelabelconfiguration-relativeposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativePosition { get; set; }
        }

        public class RelativeDateTimeControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatetimecontroldisplayoptions.html#cfn-quicksight-analysis-relativedatetimecontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatetimecontroldisplayoptions.html#cfn-quicksight-analysis-relativedatetimecontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatetimecontroldisplayoptions.html#cfn-quicksight-analysis-relativedatetimecontroldisplayoptions-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class RelativeDatesFilter
        {
            /// <summary>
            /// RelativeDateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-relativedatevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RelativeDateValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RelativeDateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-relativedatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativeDateType { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-timegranularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// AnchorDateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-anchordateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AnchorDateConfiguration
            /// </summary>
            public AnchorDateConfiguration AnchorDateConfiguration { get; set; }
            /// <summary>
            /// MinimumGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-minimumgranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinimumGranularity { get; set; }
            /// <summary>
            /// ExcludePeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatesfilter.html#cfn-quicksight-analysis-relativedatesfilter-excludeperiodconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExcludePeriodConfiguration
            /// </summary>
            public ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class ResourcePermission
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-resourcepermission.html#cfn-quicksight-analysis-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-resourcepermission.html#cfn-quicksight-analysis-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }

        public class RollingDateConfiguration
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-rollingdateconfiguration.html#cfn-quicksight-analysis-rollingdateconfiguration-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-rollingdateconfiguration.html#cfn-quicksight-analysis-rollingdateconfiguration-datasetidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class RowAlternateColorOptions
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-rowalternatecoloroptions.html#cfn-quicksight-analysis-rowalternatecoloroptions-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// UsePrimaryBackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-rowalternatecoloroptions.html#cfn-quicksight-analysis-rowalternatecoloroptions-useprimarybackgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsePrimaryBackgroundColor { get; set; }
            /// <summary>
            /// RowAlternateColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-rowalternatecoloroptions.html#cfn-quicksight-analysis-rowalternatecoloroptions-rowalternatecolors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RowAlternateColors { get; set; }
        }

        public class SameSheetTargetVisualConfiguration
        {
            /// <summary>
            /// TargetVisualOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-samesheettargetvisualconfiguration.html#cfn-quicksight-analysis-samesheettargetvisualconfiguration-targetvisualoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetVisualOptions { get; set; }
            /// <summary>
            /// TargetVisuals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-samesheettargetvisualconfiguration.html#cfn-quicksight-analysis-samesheettargetvisualconfiguration-targetvisuals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TargetVisuals { get; set; }
        }

        public class SankeyDiagramAggregatedFieldWells
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-analysis-sankeydiagramaggregatedfieldwells-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-analysis-sankeydiagramaggregatedfieldwells-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Source { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-analysis-sankeydiagramaggregatedfieldwells-weight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Weight { get; set; }
        }

        public class SankeyDiagramChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramchartconfiguration.html#cfn-quicksight-analysis-sankeydiagramchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramSortConfiguration
            /// </summary>
            public SankeyDiagramSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramchartconfiguration.html#cfn-quicksight-analysis-sankeydiagramchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramchartconfiguration.html#cfn-quicksight-analysis-sankeydiagramchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramFieldWells
            /// </summary>
            public SankeyDiagramFieldWells FieldWells { get; set; }
        }

        public class SankeyDiagramFieldWells
        {
            /// <summary>
            /// SankeyDiagramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramfieldwells.html#cfn-quicksight-analysis-sankeydiagramfieldwells-sankeydiagramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramAggregatedFieldWells
            /// </summary>
            public SankeyDiagramAggregatedFieldWells SankeyDiagramAggregatedFieldWells { get; set; }
        }

        public class SankeyDiagramSortConfiguration
        {
            /// <summary>
            /// WeightSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramsortconfiguration.html#cfn-quicksight-analysis-sankeydiagramsortconfiguration-weightsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> WeightSort { get; set; }
            /// <summary>
            /// SourceItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramsortconfiguration.html#cfn-quicksight-analysis-sankeydiagramsortconfiguration-sourceitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration SourceItemsLimit { get; set; }
            /// <summary>
            /// DestinationItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramsortconfiguration.html#cfn-quicksight-analysis-sankeydiagramsortconfiguration-destinationitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration DestinationItemsLimit { get; set; }
        }

        public class SankeyDiagramVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramChartConfiguration
            /// </summary>
            public SankeyDiagramChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class ScatterPlotCategoricallyAggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> YAxis { get; set; }
        }

        public class ScatterPlotConfiguration
        {
            /// <summary>
            /// YAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-yaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions YAxisLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotFieldWells
            /// </summary>
            public ScatterPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class ScatterPlotFieldWells
        {
            /// <summary>
            /// ScatterPlotUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotfieldwells.html#cfn-quicksight-analysis-scatterplotfieldwells-scatterplotunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotUnaggregatedFieldWells
            /// </summary>
            public ScatterPlotUnaggregatedFieldWells ScatterPlotUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// ScatterPlotCategoricallyAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotfieldwells.html#cfn-quicksight-analysis-scatterplotfieldwells-scatterplotcategoricallyaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotCategoricallyAggregatedFieldWells
            /// </summary>
            public ScatterPlotCategoricallyAggregatedFieldWells ScatterPlotCategoricallyAggregatedFieldWells { get; set; }
        }

        public class ScatterPlotUnaggregatedFieldWells
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> YAxis { get; set; }
        }

        public class ScatterPlotVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotConfiguration
            /// </summary>
            public ScatterPlotConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ScrollBarOptions
        {
            /// <summary>
            /// VisibleRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scrollbaroptions.html#cfn-quicksight-analysis-scrollbaroptions-visiblerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisibleRangeOptions
            /// </summary>
            public VisibleRangeOptions VisibleRange { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scrollbaroptions.html#cfn-quicksight-analysis-scrollbaroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SecondaryValueOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-secondaryvalueoptions.html#cfn-quicksight-analysis-secondaryvalueoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SectionAfterPageBreak
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionafterpagebreak.html#cfn-quicksight-analysis-sectionafterpagebreak-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class SectionBasedLayoutCanvasSizeOptions
        {
            /// <summary>
            /// PaperCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutcanvassizeoptions.html#cfn-quicksight-analysis-sectionbasedlayoutcanvassizeoptions-papercanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutPaperCanvasSizeOptions
            /// </summary>
            public SectionBasedLayoutPaperCanvasSizeOptions PaperCanvasSizeOptions { get; set; }
        }

        public class SectionBasedLayoutConfiguration
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// FooterSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-footersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<HeaderFooterSectionConfiguration> FooterSections { get; set; }
            /// <summary>
            /// BodySections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-bodysections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BodySectionConfiguration
            /// </summary>
            public List<BodySectionConfiguration> BodySections { get; set; }
            /// <summary>
            /// HeaderSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-headersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<HeaderFooterSectionConfiguration> HeaderSections { get; set; }
        }

        public class SectionBasedLayoutPaperCanvasSizeOptions
        {
            /// <summary>
            /// PaperMargin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions-papermargin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Spacing PaperMargin { get; set; }
            /// <summary>
            /// PaperSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions-papersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PaperSize { get; set; }
            /// <summary>
            /// PaperOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions-paperorientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PaperOrientation { get; set; }
        }

        public class SectionLayoutConfiguration
        {
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionlayoutconfiguration.html#cfn-quicksight-analysis-sectionlayoutconfiguration-freeformlayout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormSectionLayoutConfiguration
            /// </summary>
            public FreeFormSectionLayoutConfiguration FreeFormLayout { get; set; }
        }

        public class SectionPageBreakConfiguration
        {
            /// <summary>
            /// After
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionpagebreakconfiguration.html#cfn-quicksight-analysis-sectionpagebreakconfiguration-after
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionAfterPageBreak
            /// </summary>
            public SectionAfterPageBreak After { get; set; }
        }

        public class SectionStyle
        {
            /// <summary>
            /// Padding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionstyle.html#cfn-quicksight-analysis-sectionstyle-padding
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Spacing Padding { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionstyle.html#cfn-quicksight-analysis-sectionstyle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
        }

        public class SelectedSheetsFilterScopeConfiguration
        {
            /// <summary>
            /// SheetVisualScopingConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-selectedsheetsfilterscopeconfiguration.html#cfn-quicksight-analysis-selectedsheetsfilterscopeconfiguration-sheetvisualscopingconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetVisualScopingConfiguration
            /// </summary>
            public List<SheetVisualScopingConfiguration> SheetVisualScopingConfigurations { get; set; }
        }

        public class SeriesItem
        {
            /// <summary>
            /// FieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-seriesitem.html#cfn-quicksight-analysis-seriesitem-fieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSeriesItem
            /// </summary>
            public FieldSeriesItem FieldSeriesItem { get; set; }
            /// <summary>
            /// DataFieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-seriesitem.html#cfn-quicksight-analysis-seriesitem-datafieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataFieldSeriesItem
            /// </summary>
            public DataFieldSeriesItem DataFieldSeriesItem { get; set; }
        }

        public class SetParameterValueConfiguration
        {
            /// <summary>
            /// DestinationParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-setparametervalueconfiguration.html#cfn-quicksight-analysis-setparametervalueconfiguration-destinationparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationParameterName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-setparametervalueconfiguration.html#cfn-quicksight-analysis-setparametervalueconfiguration-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationParameterValueConfiguration
            /// </summary>
            public DestinationParameterValueConfiguration Value { get; set; }
        }

        public class ShapeConditionalFormat
        {
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-shapeconditionalformat.html#cfn-quicksight-analysis-shapeconditionalformat-backgroundcolor
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class Sheet
        {
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheet.html#cfn-quicksight-analysis-sheet-sheetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheet.html#cfn-quicksight-analysis-sheet-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SheetControlInfoIconLabelOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetcontrolinfoiconlabeloptions.html#cfn-quicksight-analysis-sheetcontrolinfoiconlabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// InfoIconText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetcontrolinfoiconlabeloptions.html#cfn-quicksight-analysis-sheetcontrolinfoiconlabeloptions-infoicontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InfoIconText { get; set; }
        }

        public class SheetControlLayout
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetcontrollayout.html#cfn-quicksight-analysis-sheetcontrollayout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetControlLayoutConfiguration
            /// </summary>
            public SheetControlLayoutConfiguration Configuration { get; set; }
        }

        public class SheetControlLayoutConfiguration
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetcontrollayoutconfiguration.html#cfn-quicksight-analysis-sheetcontrollayoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public GridLayoutConfiguration GridLayout { get; set; }
        }

        public class SheetDefinition
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ParameterControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-parametercontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterControl
            /// </summary>
            public List<ParameterControl> ParameterControls { get; set; }
            /// <summary>
            /// TextBoxes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-textboxes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetTextBox
            /// </summary>
            public List<SheetTextBox> TextBoxes { get; set; }
            /// <summary>
            /// Layouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-layouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Layout
            /// </summary>
            public List<Layout> Layouts { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-sheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// FilterControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-filtercontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterControl
            /// </summary>
            public List<FilterControl> FilterControls { get; set; }
            /// <summary>
            /// SheetControlLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-sheetcontrollayouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetControlLayout
            /// </summary>
            public List<SheetControlLayout> SheetControlLayouts { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// Visuals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-visuals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Visual
            /// </summary>
            public List<Visual> Visuals { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SheetElementConfigurationOverrides
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetelementconfigurationoverrides.html#cfn-quicksight-analysis-sheetelementconfigurationoverrides-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SheetElementRenderingRule
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetelementrenderingrule.html#cfn-quicksight-analysis-sheetelementrenderingrule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// ConfigurationOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetelementrenderingrule.html#cfn-quicksight-analysis-sheetelementrenderingrule-configurationoverrides
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetElementConfigurationOverrides
            /// </summary>
            public SheetElementConfigurationOverrides ConfigurationOverrides { get; set; }
        }

        public class SheetTextBox
        {
            /// <summary>
            /// SheetTextBoxId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheettextbox.html#cfn-quicksight-analysis-sheettextbox-sheettextboxid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetTextBoxId { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheettextbox.html#cfn-quicksight-analysis-sheettextbox-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
        }

        public class SheetVisualScopingConfiguration
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetvisualscopingconfiguration.html#cfn-quicksight-analysis-sheetvisualscopingconfiguration-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetvisualscopingconfiguration.html#cfn-quicksight-analysis-sheetvisualscopingconfiguration-sheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// VisualIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetvisualscopingconfiguration.html#cfn-quicksight-analysis-sheetvisualscopingconfiguration-visualids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic VisualIds { get; set; }
        }

        public class ShortFormatText
        {
            /// <summary>
            /// RichText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-shortformattext.html#cfn-quicksight-analysis-shortformattext-richtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RichText { get; set; }
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-shortformattext.html#cfn-quicksight-analysis-shortformattext-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlainText { get; set; }
        }

        public class SimpleClusterMarker
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-simpleclustermarker.html#cfn-quicksight-analysis-simpleclustermarker-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class SliderControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-slidercontroldisplayoptions.html#cfn-quicksight-analysis-slidercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-slidercontroldisplayoptions.html#cfn-quicksight-analysis-slidercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class SmallMultiplesAxisProperties
        {
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesaxisproperties.html#cfn-quicksight-analysis-smallmultiplesaxisproperties-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesaxisproperties.html#cfn-quicksight-analysis-smallmultiplesaxisproperties-scale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scale { get; set; }
        }

        public class SmallMultiplesOptions
        {
            /// <summary>
            /// MaxVisibleRows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesoptions.html#cfn-quicksight-analysis-smallmultiplesoptions-maxvisiblerows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxVisibleRows { get; set; }
            /// <summary>
            /// PanelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesoptions.html#cfn-quicksight-analysis-smallmultiplesoptions-panelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PanelConfiguration
            /// </summary>
            public PanelConfiguration PanelConfiguration { get; set; }
            /// <summary>
            /// MaxVisibleColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesoptions.html#cfn-quicksight-analysis-smallmultiplesoptions-maxvisiblecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxVisibleColumns { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesoptions.html#cfn-quicksight-analysis-smallmultiplesoptions-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public SmallMultiplesAxisProperties XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesoptions.html#cfn-quicksight-analysis-smallmultiplesoptions-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public SmallMultiplesAxisProperties YAxis { get; set; }
        }

        public class Spacing
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-spacing.html#cfn-quicksight-analysis-spacing-left
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-spacing.html#cfn-quicksight-analysis-spacing-top
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Top { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-spacing.html#cfn-quicksight-analysis-spacing-right
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-spacing.html#cfn-quicksight-analysis-spacing-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bottom { get; set; }
        }

        public class StringDefaultValues
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringdefaultvalues.html#cfn-quicksight-analysis-stringdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringdefaultvalues.html#cfn-quicksight-analysis-stringdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class StringFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringformatconfiguration.html#cfn-quicksight-analysis-stringformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringformatconfiguration.html#cfn-quicksight-analysis-stringformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
        }

        public class StringParameter
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameter.html#cfn-quicksight-analysis-stringparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameter.html#cfn-quicksight-analysis-stringparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StringParameterDeclaration
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDefaultValues
            /// </summary>
            public StringDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringValueWhenUnsetConfiguration
            /// </summary>
            public StringValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StringValueWhenUnsetConfiguration
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringvaluewhenunsetconfiguration.html#cfn-quicksight-analysis-stringvaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringvaluewhenunsetconfiguration.html#cfn-quicksight-analysis-stringvaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class SubtotalOptions
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// FieldLevelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-fieldleveloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldSubtotalOptions
            /// </summary>
            public List<PivotTableFieldSubtotalOptions> FieldLevelOptions { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// FieldLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-fieldlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldLevel { get; set; }
            /// <summary>
            /// MetricHeaderCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-metricheadercellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle MetricHeaderCellStyle { get; set; }
            /// <summary>
            /// StyleTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-styletargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableStyleTarget
            /// </summary>
            public List<TableStyleTarget> StyleTargets { get; set; }
        }

        public class TableAggregatedFieldWells
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableaggregatedfieldwells.html#cfn-quicksight-analysis-tableaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableaggregatedfieldwells.html#cfn-quicksight-analysis-tableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class TableBorderOptions
        {
            /// <summary>
            /// Thickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableborderoptions.html#cfn-quicksight-analysis-tableborderoptions-thickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Thickness { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableborderoptions.html#cfn-quicksight-analysis-tableborderoptions-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableborderoptions.html#cfn-quicksight-analysis-tableborderoptions-style
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Style { get; set; }
        }

        public class TableCellConditionalFormatting
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellconditionalformatting.html#cfn-quicksight-analysis-tablecellconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellconditionalformatting.html#cfn-quicksight-analysis-tablecellconditionalformatting-textformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextConditionalFormat
            /// </summary>
            public TextConditionalFormat TextFormat { get; set; }
        }

        public class TableCellImageSizingConfiguration
        {
            /// <summary>
            /// TableCellImageScalingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellimagesizingconfiguration.html#cfn-quicksight-analysis-tablecellimagesizingconfiguration-tablecellimagescalingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableCellImageScalingConfiguration { get; set; }
        }

        public class TableCellStyle
        {
            /// <summary>
            /// VerticalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-verticaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalTextAlignment { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalTableBorderOptions
            /// </summary>
            public GlobalTableBorderOptions Border { get; set; }
            /// <summary>
            /// TextWrap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-textwrap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextWrap { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-horizontaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalTextAlignment { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class TableConditionalFormatting
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconditionalformatting.html#cfn-quicksight-analysis-tableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableConditionalFormattingOption
            /// </summary>
            public List<TableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class TableConditionalFormattingOption
        {
            /// <summary>
            /// Row
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconditionalformattingoption.html#cfn-quicksight-analysis-tableconditionalformattingoption-row
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableRowConditionalFormatting
            /// </summary>
            public TableRowConditionalFormatting Row { get; set; }
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconditionalformattingoption.html#cfn-quicksight-analysis-tableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellConditionalFormatting
            /// </summary>
            public TableCellConditionalFormatting Cell { get; set; }
        }

        public class TableConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSortConfiguration
            /// </summary>
            public TableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePaginatedReportOptions
            /// </summary>
            public TablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableOptions
            /// </summary>
            public TableOptions TableOptions { get; set; }
            /// <summary>
            /// TableInlineVisualizations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-tableinlinevisualizations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableInlineVisualization
            /// </summary>
            public List<TableInlineVisualization> TableInlineVisualizations { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldWells
            /// </summary>
            public TableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldOptions
            /// </summary>
            public TableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalOptions
            /// </summary>
            public TotalOptions TotalOptions { get; set; }
        }

        public class TableFieldCustomIconContent
        {
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldcustomiconcontent.html#cfn-quicksight-analysis-tablefieldcustomiconcontent-icon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Icon { get; set; }
        }

        public class TableFieldCustomTextContent
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldcustomtextcontent.html#cfn-quicksight-analysis-tablefieldcustomtextcontent-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldcustomtextcontent.html#cfn-quicksight-analysis-tablefieldcustomtextcontent-fontconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
        }

        public class TableFieldImageConfiguration
        {
            /// <summary>
            /// SizingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldimageconfiguration.html#cfn-quicksight-analysis-tablefieldimageconfiguration-sizingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellImageSizingConfiguration
            /// </summary>
            public TableCellImageSizingConfiguration SizingOptions { get; set; }
        }

        public class TableFieldLinkConfiguration
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldlinkconfiguration.html#cfn-quicksight-analysis-tablefieldlinkconfiguration-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldlinkconfiguration.html#cfn-quicksight-analysis-tablefieldlinkconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TableFieldLinkContentConfiguration
            /// </summary>
            public TableFieldLinkContentConfiguration Content { get; set; }
        }

        public class TableFieldLinkContentConfiguration
        {
            /// <summary>
            /// CustomIconContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldlinkcontentconfiguration.html#cfn-quicksight-analysis-tablefieldlinkcontentconfiguration-customiconcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomIconContent
            /// </summary>
            public TableFieldCustomIconContent CustomIconContent { get; set; }
            /// <summary>
            /// CustomTextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldlinkcontentconfiguration.html#cfn-quicksight-analysis-tablefieldlinkcontentconfiguration-customtextcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomTextContent
            /// </summary>
            public TableFieldCustomTextContent CustomTextContent { get; set; }
        }

        public class TableFieldOption
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoption.html#cfn-quicksight-analysis-tablefieldoption-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// URLStyling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoption.html#cfn-quicksight-analysis-tablefieldoption-urlstyling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldURLConfiguration
            /// </summary>
            public TableFieldURLConfiguration URLStyling { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoption.html#cfn-quicksight-analysis-tablefieldoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoption.html#cfn-quicksight-analysis-tablefieldoption-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoption.html#cfn-quicksight-analysis-tablefieldoption-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class TableFieldOptions
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoptions.html#cfn-quicksight-analysis-tablefieldoptions-order
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Order { get; set; }
            /// <summary>
            /// PinnedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoptions.html#cfn-quicksight-analysis-tablefieldoptions-pinnedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePinnedFieldOptions
            /// </summary>
            public TablePinnedFieldOptions PinnedFieldOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoptions.html#cfn-quicksight-analysis-tablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableFieldOption
            /// </summary>
            public List<TableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class TableFieldURLConfiguration
        {
            /// <summary>
            /// LinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldurlconfiguration.html#cfn-quicksight-analysis-tablefieldurlconfiguration-linkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldLinkConfiguration
            /// </summary>
            public TableFieldLinkConfiguration LinkConfiguration { get; set; }
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldurlconfiguration.html#cfn-quicksight-analysis-tablefieldurlconfiguration-imageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldImageConfiguration
            /// </summary>
            public TableFieldImageConfiguration ImageConfiguration { get; set; }
        }

        public class TableFieldWells
        {
            /// <summary>
            /// TableUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldwells.html#cfn-quicksight-analysis-tablefieldwells-tableunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableUnaggregatedFieldWells
            /// </summary>
            public TableUnaggregatedFieldWells TableUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// TableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldwells.html#cfn-quicksight-analysis-tablefieldwells-tableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableAggregatedFieldWells
            /// </summary>
            public TableAggregatedFieldWells TableAggregatedFieldWells { get; set; }
        }

        public class TableInlineVisualization
        {
            /// <summary>
            /// DataBars
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableinlinevisualization.html#cfn-quicksight-analysis-tableinlinevisualization-databars
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataBarsOptions
            /// </summary>
            public DataBarsOptions DataBars { get; set; }
        }

        public class TableOptions
        {
            /// <summary>
            /// HeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableoptions.html#cfn-quicksight-analysis-tableoptions-headerstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle HeaderStyle { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableoptions.html#cfn-quicksight-analysis-tableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableoptions.html#cfn-quicksight-analysis-tableoptions-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Orientation { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableoptions.html#cfn-quicksight-analysis-tableoptions-rowalternatecoloroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowAlternateColorOptions
            /// </summary>
            public RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class TablePaginatedReportOptions
        {
            /// <summary>
            /// OverflowColumnHeaderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablepaginatedreportoptions.html#cfn-quicksight-analysis-tablepaginatedreportoptions-overflowcolumnheadervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverflowColumnHeaderVisibility { get; set; }
            /// <summary>
            /// VerticalOverflowVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablepaginatedreportoptions.html#cfn-quicksight-analysis-tablepaginatedreportoptions-verticaloverflowvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalOverflowVisibility { get; set; }
        }

        public class TablePinnedFieldOptions
        {
            /// <summary>
            /// PinnedLeftFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablepinnedfieldoptions.html#cfn-quicksight-analysis-tablepinnedfieldoptions-pinnedleftfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PinnedLeftFields { get; set; }
        }

        public class TableRowConditionalFormatting
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablerowconditionalformatting.html#cfn-quicksight-analysis-tablerowconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablerowconditionalformatting.html#cfn-quicksight-analysis-tablerowconditionalformatting-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TableSideBorderOptions
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-left
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-top
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Top { get; set; }
            /// <summary>
            /// InnerHorizontal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-innerhorizontal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions InnerHorizontal { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-right
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Bottom { get; set; }
            /// <summary>
            /// InnerVertical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-innervertical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions InnerVertical { get; set; }
        }

        public class TableSortConfiguration
        {
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesortconfiguration.html#cfn-quicksight-analysis-tablesortconfiguration-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> RowSort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesortconfiguration.html#cfn-quicksight-analysis-tablesortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class TableStyleTarget
        {
            /// <summary>
            /// CellType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablestyletarget.html#cfn-quicksight-analysis-tablestyletarget-celltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CellType { get; set; }
        }

        public class TableUnaggregatedFieldWells
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableunaggregatedfieldwells.html#cfn-quicksight-analysis-tableunaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<UnaggregatedField> Values { get; set; }
        }

        public class TableVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConditionalFormatting
            /// </summary>
            public TableConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConfiguration
            /// </summary>
            public TableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
        }

        public class TextAreaControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textareacontroldisplayoptions.html#cfn-quicksight-analysis-textareacontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textareacontroldisplayoptions.html#cfn-quicksight-analysis-textareacontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textareacontroldisplayoptions.html#cfn-quicksight-analysis-textareacontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class TextConditionalFormat
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textconditionalformat.html#cfn-quicksight-analysis-textconditionalformat-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textconditionalformat.html#cfn-quicksight-analysis-textconditionalformat-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public ConditionalFormattingIcon Icon { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textconditionalformat.html#cfn-quicksight-analysis-textconditionalformat-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TextControlPlaceholderOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textcontrolplaceholderoptions.html#cfn-quicksight-analysis-textcontrolplaceholderoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class TextFieldControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textfieldcontroldisplayoptions.html#cfn-quicksight-analysis-textfieldcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textfieldcontroldisplayoptions.html#cfn-quicksight-analysis-textfieldcontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textfieldcontroldisplayoptions.html#cfn-quicksight-analysis-textfieldcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ThousandSeparatorOptions
        {
            /// <summary>
            /// Symbol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-thousandseparatoroptions.html#cfn-quicksight-analysis-thousandseparatoroptions-symbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Symbol { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-thousandseparatoroptions.html#cfn-quicksight-analysis-thousandseparatoroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class TimeBasedForecastProperties
        {
            /// <summary>
            /// PeriodsBackward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timebasedforecastproperties.html#cfn-quicksight-analysis-timebasedforecastproperties-periodsbackward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsBackward { get; set; }
            /// <summary>
            /// PeriodsForward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timebasedforecastproperties.html#cfn-quicksight-analysis-timebasedforecastproperties-periodsforward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsForward { get; set; }
            /// <summary>
            /// PredictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timebasedforecastproperties.html#cfn-quicksight-analysis-timebasedforecastproperties-predictioninterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PredictionInterval { get; set; }
            /// <summary>
            /// Seasonality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timebasedforecastproperties.html#cfn-quicksight-analysis-timebasedforecastproperties-seasonality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Seasonality { get; set; }
            /// <summary>
            /// UpperBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timebasedforecastproperties.html#cfn-quicksight-analysis-timebasedforecastproperties-upperboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperBoundary { get; set; }
            /// <summary>
            /// LowerBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timebasedforecastproperties.html#cfn-quicksight-analysis-timebasedforecastproperties-lowerboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LowerBoundary { get; set; }
        }

        public class TimeEqualityFilter
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TimeRangeDrillDownFilter
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangedrilldownfilter.html#cfn-quicksight-analysis-timerangedrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangedrilldownfilter.html#cfn-quicksight-analysis-timerangedrilldownfilter-rangeminimum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeMinimum { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangedrilldownfilter.html#cfn-quicksight-analysis-timerangedrilldownfilter-timegranularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangedrilldownfilter.html#cfn-quicksight-analysis-timerangedrilldownfilter-rangemaximum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeMaximum { get; set; }
        }

        public class TimeRangeFilter
        {
            /// <summary>
            /// RangeMinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-rangeminimumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public TimeRangeFilterValue RangeMinimumValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-rangemaximumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public TimeRangeFilterValue RangeMaximumValue { get; set; }
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
            /// <summary>
            /// ExcludePeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-excludeperiodconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExcludePeriodConfiguration
            /// </summary>
            public ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class TimeRangeFilterValue
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefiltervalue.html#cfn-quicksight-analysis-timerangefiltervalue-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefiltervalue.html#cfn-quicksight-analysis-timerangefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticValue { get; set; }
            /// <summary>
            /// Parameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefiltervalue.html#cfn-quicksight-analysis-timerangefiltervalue-parameter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Parameter { get; set; }
        }

        public class TooltipItem
        {
            /// <summary>
            /// FieldTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipitem.html#cfn-quicksight-analysis-tooltipitem-fieldtooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldTooltipItem
            /// </summary>
            public FieldTooltipItem FieldTooltipItem { get; set; }
            /// <summary>
            /// ColumnTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipitem.html#cfn-quicksight-analysis-tooltipitem-columntooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnTooltipItem
            /// </summary>
            public ColumnTooltipItem ColumnTooltipItem { get; set; }
        }

        public class TooltipOptions
        {
            /// <summary>
            /// SelectedTooltipType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipoptions.html#cfn-quicksight-analysis-tooltipoptions-selectedtooltiptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedTooltipType { get; set; }
            /// <summary>
            /// TooltipVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipoptions.html#cfn-quicksight-analysis-tooltipoptions-tooltipvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipVisibility { get; set; }
            /// <summary>
            /// FieldBasedTooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipoptions.html#cfn-quicksight-analysis-tooltipoptions-fieldbasedtooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldBasedTooltip
            /// </summary>
            public FieldBasedTooltip FieldBasedTooltip { get; set; }
        }

        public class TopBottomFilter
        {
            /// <summary>
            /// AggregationSortConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-aggregationsortconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationSortConfiguration
            /// </summary>
            public List<AggregationSortConfiguration> AggregationSortConfigurations { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Limit { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TopBottomMoversComputation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Category { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-sortorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortOrder { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// MoverSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-moversize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MoverSize { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TopBottomRankedComputation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomrankedcomputation.html#cfn-quicksight-analysis-topbottomrankedcomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomrankedcomputation.html#cfn-quicksight-analysis-topbottomrankedcomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Category { get; set; }
            /// <summary>
            /// ResultSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomrankedcomputation.html#cfn-quicksight-analysis-topbottomrankedcomputation-resultsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResultSize { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomrankedcomputation.html#cfn-quicksight-analysis-topbottomrankedcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomrankedcomputation.html#cfn-quicksight-analysis-topbottomrankedcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomrankedcomputation.html#cfn-quicksight-analysis-topbottomrankedcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TotalAggregationComputation
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationcomputation.html#cfn-quicksight-analysis-totalaggregationcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationcomputation.html#cfn-quicksight-analysis-totalaggregationcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationcomputation.html#cfn-quicksight-analysis-totalaggregationcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TotalAggregationFunction
        {
            /// <summary>
            /// SimpleTotalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationfunction.html#cfn-quicksight-analysis-totalaggregationfunction-simpletotalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleTotalAggregationFunction { get; set; }
        }

        public class TotalAggregationOption
        {
            /// <summary>
            /// TotalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationoption.html#cfn-quicksight-analysis-totalaggregationoption-totalaggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TotalAggregationFunction
            /// </summary>
            public TotalAggregationFunction TotalAggregationFunction { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationoption.html#cfn-quicksight-analysis-totalaggregationoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class TotalOptions
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<TotalAggregationOption> TotalAggregationOptions { get; set; }
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ScrollStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-scrollstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScrollStatus { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
        }

        public class TreeMapAggregatedFieldWells
        {
            /// <summary>
            /// Sizes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapaggregatedfieldwells.html#cfn-quicksight-analysis-treemapaggregatedfieldwells-sizes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Sizes { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapaggregatedfieldwells.html#cfn-quicksight-analysis-treemapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Colors { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapaggregatedfieldwells.html#cfn-quicksight-analysis-treemapaggregatedfieldwells-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Groups { get; set; }
        }

        public class TreeMapConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapSortConfiguration
            /// </summary>
            public TreeMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// SizeLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-sizelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions SizeLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapFieldWells
            /// </summary>
            public TreeMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public ColorScale ColorScale { get; set; }
            /// <summary>
            /// GroupLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-grouplabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions GroupLabelOptions { get; set; }
        }

        public class TreeMapFieldWells
        {
            /// <summary>
            /// TreeMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapfieldwells.html#cfn-quicksight-analysis-treemapfieldwells-treemapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapAggregatedFieldWells
            /// </summary>
            public TreeMapAggregatedFieldWells TreeMapAggregatedFieldWells { get; set; }
        }

        public class TreeMapSortConfiguration
        {
            /// <summary>
            /// TreeMapSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapsortconfiguration.html#cfn-quicksight-analysis-treemapsortconfiguration-treemapsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> TreeMapSort { get; set; }
            /// <summary>
            /// TreeMapGroupItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapsortconfiguration.html#cfn-quicksight-analysis-treemapsortconfiguration-treemapgroupitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration TreeMapGroupItemsLimitConfiguration { get; set; }
        }

        public class TreeMapVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapConfiguration
            /// </summary>
            public TreeMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class TrendArrowOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-trendarrowoptions.html#cfn-quicksight-analysis-trendarrowoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class UnaggregatedField
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-unaggregatedfield.html#cfn-quicksight-analysis-unaggregatedfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-unaggregatedfield.html#cfn-quicksight-analysis-unaggregatedfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-unaggregatedfield.html#cfn-quicksight-analysis-unaggregatedfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class UniqueValuesComputation
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-uniquevaluescomputation.html#cfn-quicksight-analysis-uniquevaluescomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Category { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-uniquevaluescomputation.html#cfn-quicksight-analysis-uniquevaluescomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-uniquevaluescomputation.html#cfn-quicksight-analysis-uniquevaluescomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ValidationStrategy
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-validationstrategy.html#cfn-quicksight-analysis-validationstrategy-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class VisibleRangeOptions
        {
            /// <summary>
            /// PercentRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visiblerangeoptions.html#cfn-quicksight-analysis-visiblerangeoptions-percentrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentVisibleRange
            /// </summary>
            public PercentVisibleRange PercentRange { get; set; }
        }

        public class Visual
        {
            /// <summary>
            /// FunnelChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-funnelchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartVisual
            /// </summary>
            public FunnelChartVisual FunnelChartVisual { get; set; }
            /// <summary>
            /// FilledMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-filledmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapVisual
            /// </summary>
            public FilledMapVisual FilledMapVisual { get; set; }
            /// <summary>
            /// BoxPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-boxplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotVisual
            /// </summary>
            public BoxPlotVisual BoxPlotVisual { get; set; }
            /// <summary>
            /// WaterfallVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-waterfallvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallVisual
            /// </summary>
            public WaterfallVisual WaterfallVisual { get; set; }
            /// <summary>
            /// CustomContentVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-customcontentvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentVisual
            /// </summary>
            public CustomContentVisual CustomContentVisual { get; set; }
            /// <summary>
            /// PieChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-piechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartVisual
            /// </summary>
            public PieChartVisual PieChartVisual { get; set; }
            /// <summary>
            /// KPIVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-kpivisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisual
            /// </summary>
            public KPIVisual KPIVisual { get; set; }
            /// <summary>
            /// HistogramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-histogramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramVisual
            /// </summary>
            public HistogramVisual HistogramVisual { get; set; }
            /// <summary>
            /// TableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-tablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableVisual
            /// </summary>
            public TableVisual TableVisual { get; set; }
            /// <summary>
            /// PivotTableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-pivottablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableVisual
            /// </summary>
            public PivotTableVisual PivotTableVisual { get; set; }
            /// <summary>
            /// GeospatialMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-geospatialmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapVisual
            /// </summary>
            public GeospatialMapVisual GeospatialMapVisual { get; set; }
            /// <summary>
            /// BarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-barchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartVisual
            /// </summary>
            public BarChartVisual BarChartVisual { get; set; }
            /// <summary>
            /// ScatterPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-scatterplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotVisual
            /// </summary>
            public ScatterPlotVisual ScatterPlotVisual { get; set; }
            /// <summary>
            /// RadarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-radarchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartVisual
            /// </summary>
            public RadarChartVisual RadarChartVisual { get; set; }
            /// <summary>
            /// HeatMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-heatmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapVisual
            /// </summary>
            public HeatMapVisual HeatMapVisual { get; set; }
            /// <summary>
            /// TreeMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-treemapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapVisual
            /// </summary>
            public TreeMapVisual TreeMapVisual { get; set; }
            /// <summary>
            /// ComboChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-combochartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartVisual
            /// </summary>
            public ComboChartVisual ComboChartVisual { get; set; }
            /// <summary>
            /// WordCloudVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-wordcloudvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudVisual
            /// </summary>
            public WordCloudVisual WordCloudVisual { get; set; }
            /// <summary>
            /// InsightVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-insightvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightVisual
            /// </summary>
            public InsightVisual InsightVisual { get; set; }
            /// <summary>
            /// SankeyDiagramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-sankeydiagramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramVisual
            /// </summary>
            public SankeyDiagramVisual SankeyDiagramVisual { get; set; }
            /// <summary>
            /// GaugeChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-gaugechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartVisual
            /// </summary>
            public GaugeChartVisual GaugeChartVisual { get; set; }
            /// <summary>
            /// LineChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-linechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartVisual
            /// </summary>
            public LineChartVisual LineChartVisual { get; set; }
            /// <summary>
            /// EmptyVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-emptyvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyVisual
            /// </summary>
            public EmptyVisual EmptyVisual { get; set; }
        }

        public class VisualCustomAction
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomaction.html#cfn-quicksight-analysis-visualcustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomaction.html#cfn-quicksight-analysis-visualcustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomaction.html#cfn-quicksight-analysis-visualcustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomaction.html#cfn-quicksight-analysis-visualcustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomaction.html#cfn-quicksight-analysis-visualcustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomActionOperation
            /// </summary>
            public List<VisualCustomActionOperation> ActionOperations { get; set; }
        }

        public class VisualCustomActionOperation
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public CustomActionURLOperation URLOperation { get; set; }
        }

        public class VisualPalette
        {
            /// <summary>
            /// ChartColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualpalette.html#cfn-quicksight-analysis-visualpalette-chartcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChartColor { get; set; }
            /// <summary>
            /// ColorMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualpalette.html#cfn-quicksight-analysis-visualpalette-colormap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathColor
            /// </summary>
            public List<DataPathColor> ColorMap { get; set; }
        }

        public class VisualSubtitleLabelOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualsubtitlelabeloptions.html#cfn-quicksight-analysis-visualsubtitlelabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FormatText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualsubtitlelabeloptions.html#cfn-quicksight-analysis-visualsubtitlelabeloptions-formattext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LongFormatText
            /// </summary>
            public LongFormatText FormatText { get; set; }
        }

        public class VisualTitleLabelOptions
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualtitlelabeloptions.html#cfn-quicksight-analysis-visualtitlelabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FormatText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualtitlelabeloptions.html#cfn-quicksight-analysis-visualtitlelabeloptions-formattext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShortFormatText
            /// </summary>
            public ShortFormatText FormatText { get; set; }
        }

        public class WaterfallChartAggregatedFieldWells
        {
            /// <summary>
            /// Categories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartaggregatedfieldwells.html#cfn-quicksight-analysis-waterfallchartaggregatedfieldwells-categories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Categories { get; set; }
            /// <summary>
            /// Breakdowns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartaggregatedfieldwells.html#cfn-quicksight-analysis-waterfallchartaggregatedfieldwells-breakdowns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Breakdowns { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartaggregatedfieldwells.html#cfn-quicksight-analysis-waterfallchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
        }

        public class WaterfallChartColorConfiguration
        {
            /// <summary>
            /// GroupColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartcolorconfiguration.html#cfn-quicksight-analysis-waterfallchartcolorconfiguration-groupcolorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartGroupColorConfiguration
            /// </summary>
            public WaterfallChartGroupColorConfiguration GroupColorConfiguration { get; set; }
        }

        public class WaterfallChartConfiguration
        {
            /// <summary>
            /// CategoryAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-categoryaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryAxisLabelOptions { get; set; }
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartSortConfiguration
            /// </summary>
            public WaterfallChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartFieldWells
            /// </summary>
            public WaterfallChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// WaterfallChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-waterfallchartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartOptions
            /// </summary>
            public WaterfallChartOptions WaterfallChartOptions { get; set; }
            /// <summary>
            /// ColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-colorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartColorConfiguration
            /// </summary>
            public WaterfallChartColorConfiguration ColorConfiguration { get; set; }
            /// <summary>
            /// CategoryAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-categoryaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxisDisplayOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
        }

        public class WaterfallChartFieldWells
        {
            /// <summary>
            /// WaterfallChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartfieldwells.html#cfn-quicksight-analysis-waterfallchartfieldwells-waterfallchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartAggregatedFieldWells
            /// </summary>
            public WaterfallChartAggregatedFieldWells WaterfallChartAggregatedFieldWells { get; set; }
        }

        public class WaterfallChartGroupColorConfiguration
        {
            /// <summary>
            /// NegativeBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-analysis-waterfallchartgroupcolorconfiguration-negativebarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NegativeBarColor { get; set; }
            /// <summary>
            /// TotalBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-analysis-waterfallchartgroupcolorconfiguration-totalbarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalBarColor { get; set; }
            /// <summary>
            /// PositiveBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-analysis-waterfallchartgroupcolorconfiguration-positivebarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositiveBarColor { get; set; }
        }

        public class WaterfallChartOptions
        {
            /// <summary>
            /// TotalBarLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartoptions.html#cfn-quicksight-analysis-waterfallchartoptions-totalbarlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalBarLabel { get; set; }
        }

        public class WaterfallChartSortConfiguration
        {
            /// <summary>
            /// BreakdownItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartsortconfiguration.html#cfn-quicksight-analysis-waterfallchartsortconfiguration-breakdownitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration BreakdownItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartsortconfiguration.html#cfn-quicksight-analysis-waterfallchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
        }

        public class WaterfallVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartConfiguration
            /// </summary>
            public WaterfallChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class WhatIfPointScenario
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-whatifpointscenario.html#cfn-quicksight-analysis-whatifpointscenario-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Date
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-whatifpointscenario.html#cfn-quicksight-analysis-whatifpointscenario-date
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Date { get; set; }
        }

        public class WhatIfRangeScenario
        {
            /// <summary>
            /// StartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-whatifrangescenario.html#cfn-quicksight-analysis-whatifrangescenario-startdate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartDate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-whatifrangescenario.html#cfn-quicksight-analysis-whatifrangescenario-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-whatifrangescenario.html#cfn-quicksight-analysis-whatifrangescenario-enddate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndDate { get; set; }
        }

        public class WordCloudAggregatedFieldWells
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudaggregatedfieldwells.html#cfn-quicksight-analysis-wordcloudaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudaggregatedfieldwells.html#cfn-quicksight-analysis-wordcloudaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Size { get; set; }
        }

        public class WordCloudChartConfiguration
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudSortConfiguration
            /// </summary>
            public WordCloudSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudFieldWells
            /// </summary>
            public WordCloudFieldWells FieldWells { get; set; }
            /// <summary>
            /// WordCloudOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-wordcloudoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudOptions
            /// </summary>
            public WordCloudOptions WordCloudOptions { get; set; }
        }

        public class WordCloudFieldWells
        {
            /// <summary>
            /// WordCloudAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudfieldwells.html#cfn-quicksight-analysis-wordcloudfieldwells-wordcloudaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudAggregatedFieldWells
            /// </summary>
            public WordCloudAggregatedFieldWells WordCloudAggregatedFieldWells { get; set; }
        }

        public class WordCloudOptions
        {
            /// <summary>
            /// WordOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudoptions.html#cfn-quicksight-analysis-wordcloudoptions-wordorientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordOrientation { get; set; }
            /// <summary>
            /// WordScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudoptions.html#cfn-quicksight-analysis-wordcloudoptions-wordscaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordScaling { get; set; }
            /// <summary>
            /// CloudLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudoptions.html#cfn-quicksight-analysis-wordcloudoptions-cloudlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudLayout { get; set; }
            /// <summary>
            /// MaximumStringLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudoptions.html#cfn-quicksight-analysis-wordcloudoptions-maximumstringlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumStringLength { get; set; }
            /// <summary>
            /// WordCasing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudoptions.html#cfn-quicksight-analysis-wordcloudoptions-wordcasing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordCasing { get; set; }
            /// <summary>
            /// WordPadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudoptions.html#cfn-quicksight-analysis-wordcloudoptions-wordpadding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordPadding { get; set; }
        }

        public class WordCloudSortConfiguration
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudsortconfiguration.html#cfn-quicksight-analysis-wordcloudsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudsortconfiguration.html#cfn-quicksight-analysis-wordcloudsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
        }

        public class WordCloudVisual
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudChartConfiguration
            /// </summary>
            public WordCloudChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }
    }
}