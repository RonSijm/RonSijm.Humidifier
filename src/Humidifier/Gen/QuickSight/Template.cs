namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAwsAccountId, IHaveVersionDescription, IHaveTemplateId
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Template; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionDescription { get; set; }
        /// <summary>
        /// SourceEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-sourceentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TemplateSourceEntity
        /// </summary>
        public Humidifier.QuickSight.TemplateTypes.TemplateSourceEntity SourceEntity { get; set; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-definition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TemplateVersionDefinition
        /// </summary>
        public Humidifier.QuickSight.TemplateTypes.TemplateVersionDefinition Definition { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.TemplateTypes.ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// ValidationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-validationstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ValidationStrategy
        /// </summary>
        public Humidifier.QuickSight.TemplateTypes.ValidationStrategy ValidationStrategy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// TemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html#cfn-quicksight-template-templateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TemplateId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TemplateTypes
    {
        public class AggregationFunction : Humidifier.Base.BaseSubResource, IHaveDateAggregationFunction, IHaveCategoricalAggregationFunction
        {
            /// <summary>
            /// AttributeAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationfunction.html#cfn-quicksight-template-aggregationfunction-attributeaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AttributeAggregationFunction AttributeAggregationFunction { get; set; }
            /// <summary>
            /// DateAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationfunction.html#cfn-quicksight-template-aggregationfunction-dateaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateAggregationFunction { get; set; }
            /// <summary>
            /// NumericalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationfunction.html#cfn-quicksight-template-aggregationfunction-numericalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericalAggregationFunction NumericalAggregationFunction { get; set; }
            /// <summary>
            /// CategoricalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationfunction.html#cfn-quicksight-template-aggregationfunction-categoricalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoricalAggregationFunction { get; set; }
        }

        public class AggregationSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveQuickSightTemplateTypesAggregationFunctionAggregationFunction, IHaveSortDirection
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationsortconfiguration.html#cfn-quicksight-template-aggregationsortconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortDirection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationsortconfiguration.html#cfn-quicksight-template-aggregationsortconfiguration-sortdirection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortDirection { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-aggregationsortconfiguration.html#cfn-quicksight-template-aggregationsortconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
        }

        public class AnalysisDefaults : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultNewSheetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-analysisdefaults.html#cfn-quicksight-template-analysisdefaults-defaultnewsheetconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultNewSheetConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration DefaultNewSheetConfiguration { get; set; }
        }

        public class AnchorDateConfiguration : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveAnchorOption
        {
            /// <summary>
            /// AnchorOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-anchordateconfiguration.html#cfn-quicksight-template-anchordateconfiguration-anchoroption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnchorOption { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-anchordateconfiguration.html#cfn-quicksight-template-anchordateconfiguration-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
        }

        public class ArcAxisConfiguration : Humidifier.Base.BaseSubResource, IHaveReserveRange
        {
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcaxisconfiguration.html#cfn-quicksight-template-arcaxisconfiguration-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisDisplayRange
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ArcAxisDisplayRange Range { get; set; }
            /// <summary>
            /// ReserveRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcaxisconfiguration.html#cfn-quicksight-template-arcaxisconfiguration-reserverange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ReserveRange { get; set; }
        }

        public class ArcAxisDisplayRange : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcaxisdisplayrange.html#cfn-quicksight-template-arcaxisdisplayrange-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcaxisdisplayrange.html#cfn-quicksight-template-arcaxisdisplayrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class ArcConfiguration : Humidifier.Base.BaseSubResource, IHaveArcThickness, IHaveArcAngle
        {
            /// <summary>
            /// ArcAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcconfiguration.html#cfn-quicksight-template-arcconfiguration-arcangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ArcAngle { get; set; }
            /// <summary>
            /// ArcThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcconfiguration.html#cfn-quicksight-template-arcconfiguration-arcthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArcThickness { get; set; }
        }

        public class ArcOptions : Humidifier.Base.BaseSubResource, IHaveArcThickness
        {
            /// <summary>
            /// ArcThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-arcoptions.html#cfn-quicksight-template-arcoptions-arcthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ArcThickness { get; set; }
        }

        public class AssetOptions : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveWeekStart
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-assetoptions.html#cfn-quicksight-template-assetoptions-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// WeekStart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-assetoptions.html#cfn-quicksight-template-assetoptions-weekstart
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WeekStart { get; set; }
        }

        public class AttributeAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleAttributeAggregation, IHaveValueForMultipleValues
        {
            /// <summary>
            /// SimpleAttributeAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-attributeaggregationfunction.html#cfn-quicksight-template-attributeaggregationfunction-simpleattributeaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleAttributeAggregation { get; set; }
            /// <summary>
            /// ValueForMultipleValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-attributeaggregationfunction.html#cfn-quicksight-template-attributeaggregationfunction-valueformultiplevalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueForMultipleValues { get; set; }
        }

        public class AxisDataOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdataoptions.html#cfn-quicksight-template-axisdataoptions-dateaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateAxisOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateAxisOptions DateAxisOptions { get; set; }
            /// <summary>
            /// NumericAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdataoptions.html#cfn-quicksight-template-axisdataoptions-numericaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericAxisOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericAxisOptions NumericAxisOptions { get; set; }
        }

        public class AxisDisplayMinMaxRange : Humidifier.Base.BaseSubResource, IHaveMinimum, IHaveMaximum
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayminmaxrange.html#cfn-quicksight-template-axisdisplayminmaxrange-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayminmaxrange.html#cfn-quicksight-template-axisdisplayminmaxrange-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Maximum { get; set; }
        }

        public class AxisDisplayOptions : Humidifier.Base.BaseSubResource, IHaveAxisOffset, IHaveAxisLineVisibility, IHaveGridLineVisibility
        {
            /// <summary>
            /// DataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayoptions.html#cfn-quicksight-template-axisdisplayoptions-dataoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDataOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDataOptions DataOptions { get; set; }
            /// <summary>
            /// TickLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayoptions.html#cfn-quicksight-template-axisdisplayoptions-ticklabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisTickLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisTickLabelOptions TickLabelOptions { get; set; }
            /// <summary>
            /// AxisOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayoptions.html#cfn-quicksight-template-axisdisplayoptions-axisoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisOffset { get; set; }
            /// <summary>
            /// AxisLineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayoptions.html#cfn-quicksight-template-axisdisplayoptions-axislinevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AxisLineVisibility { get; set; }
            /// <summary>
            /// GridLineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayoptions.html#cfn-quicksight-template-axisdisplayoptions-gridlinevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic GridLineVisibility { get; set; }
            /// <summary>
            /// ScrollbarOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayoptions.html#cfn-quicksight-template-axisdisplayoptions-scrollbaroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScrollBarOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ScrollBarOptions ScrollbarOptions { get; set; }
        }

        public class AxisDisplayRange : Humidifier.Base.BaseSubResource, IHaveDataDriven
        {
            /// <summary>
            /// DataDriven
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayrange.html#cfn-quicksight-template-axisdisplayrange-datadriven
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic DataDriven { get; set; }
            /// <summary>
            /// MinMax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisdisplayrange.html#cfn-quicksight-template-axisdisplayrange-minmax
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayMinMaxRange
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayMinMaxRange MinMax { get; set; }
        }

        public class AxisLabelOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislabeloptions.html#cfn-quicksight-template-axislabeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ApplyTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislabeloptions.html#cfn-quicksight-template-axislabeloptions-applyto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLabelReferenceOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisLabelReferenceOptions ApplyTo { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislabeloptions.html#cfn-quicksight-template-axislabeloptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class AxisLabelReferenceOptions : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislabelreferenceoptions.html#cfn-quicksight-template-axislabelreferenceoptions-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislabelreferenceoptions.html#cfn-quicksight-template-axislabelreferenceoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class AxisLinearScale : Humidifier.Base.BaseSubResource, IHaveStepSize, IHaveStepCount
        {
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislinearscale.html#cfn-quicksight-template-axislinearscale-stepsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// StepCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislinearscale.html#cfn-quicksight-template-axislinearscale-stepcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepCount { get; set; }
        }

        public class AxisLogarithmicScale : Humidifier.Base.BaseSubResource, IHaveBase
        {
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axislogarithmicscale.html#cfn-quicksight-template-axislogarithmicscale-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Base { get; set; }
        }

        public class AxisScale : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Logarithmic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisscale.html#cfn-quicksight-template-axisscale-logarithmic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLogarithmicScale
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisLogarithmicScale Logarithmic { get; set; }
            /// <summary>
            /// Linear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisscale.html#cfn-quicksight-template-axisscale-linear
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLinearScale
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisLinearScale Linear { get; set; }
        }

        public class AxisTickLabelOptions : Humidifier.Base.BaseSubResource, IHaveRotationAngle
        {
            /// <summary>
            /// RotationAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisticklabeloptions.html#cfn-quicksight-template-axisticklabeloptions-rotationangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RotationAngle { get; set; }
            /// <summary>
            /// LabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-axisticklabeloptions.html#cfn-quicksight-template-axisticklabeloptions-labeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions LabelOptions { get; set; }
        }

        public class BarChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartaggregatedfieldwells.html#cfn-quicksight-template-barchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartaggregatedfieldwells.html#cfn-quicksight-template-barchartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartaggregatedfieldwells.html#cfn-quicksight-template-barchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartaggregatedfieldwells.html#cfn-quicksight-template-barchartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class BarChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveOrientation, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveBarsArrangement, IHaveQuickSightTemplateTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightTemplateTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightTemplateTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Orientation { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// BarsArrangement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-barsarrangement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BarsArrangement { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ValueAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartconfiguration.html#cfn-quicksight-template-barchartconfiguration-valueaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions ValueAxis { get; set; }
        }

        public class BarChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartfieldwells.html#cfn-quicksight-template-barchartfieldwells-barchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BarChartAggregatedFieldWells BarChartAggregatedFieldWells { get; set; }
        }

        public class BarChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightTemplateTypesItemsLimitConfigurationColorItemsLimit, IHaveQuickSightTemplateTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartsortconfiguration.html#cfn-quicksight-template-barchartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartsortconfiguration.html#cfn-quicksight-template-barchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartsortconfiguration.html#cfn-quicksight-template-barchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartsortconfiguration.html#cfn-quicksight-template-barchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartsortconfiguration.html#cfn-quicksight-template-barchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartsortconfiguration.html#cfn-quicksight-template-barchartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class BarChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-barchartvisual.html#cfn-quicksight-template-barchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class BinCountOptions : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-bincountoptions.html#cfn-quicksight-template-bincountoptions-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class BinWidthOptions : Humidifier.Base.BaseSubResource, IHaveValue, IHaveBinCountLimit
        {
            /// <summary>
            /// BinCountLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-binwidthoptions.html#cfn-quicksight-template-binwidthoptions-bincountlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BinCountLimit { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-binwidthoptions.html#cfn-quicksight-template-binwidthoptions-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class BodySectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSectionId
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-bodysectionconfiguration.html#cfn-quicksight-template-bodysectionconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BodySectionContent
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BodySectionContent Content { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-bodysectionconfiguration.html#cfn-quicksight-template-bodysectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionStyle Style { get; set; }
            /// <summary>
            /// PageBreakConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-bodysectionconfiguration.html#cfn-quicksight-template-bodysectionconfiguration-pagebreakconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionPageBreakConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionPageBreakConfiguration PageBreakConfiguration { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-bodysectionconfiguration.html#cfn-quicksight-template-bodysectionconfiguration-sectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SectionId { get; set; }
        }

        public class BodySectionContent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-bodysectioncontent.html#cfn-quicksight-template-bodysectioncontent-layout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionLayoutConfiguration Layout { get; set; }
        }

        public class BoxPlotAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotaggregatedfieldwells.html#cfn-quicksight-template-boxplotaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotaggregatedfieldwells.html#cfn-quicksight-template-boxplotaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class BoxPlotChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightTemplateTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// BoxPlotOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-boxplotoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotOptions BoxPlotOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotchartconfiguration.html#cfn-quicksight-template-boxplotchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
        }

        public class BoxPlotFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BoxPlotAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotfieldwells.html#cfn-quicksight-template-boxplotfieldwells-boxplotaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotAggregatedFieldWells BoxPlotAggregatedFieldWells { get; set; }
        }

        public class BoxPlotOptions : Humidifier.Base.BaseSubResource, IHaveOutlierVisibility, IHaveAllDataPointsVisibility
        {
            /// <summary>
            /// StyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotoptions.html#cfn-quicksight-template-boxplotoptions-styleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotStyleOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotStyleOptions StyleOptions { get; set; }
            /// <summary>
            /// OutlierVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotoptions.html#cfn-quicksight-template-boxplotoptions-outliervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OutlierVisibility { get; set; }
            /// <summary>
            /// AllDataPointsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotoptions.html#cfn-quicksight-template-boxplotoptions-alldatapointsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllDataPointsVisibility { get; set; }
        }

        public class BoxPlotSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotsortconfiguration.html#cfn-quicksight-template-boxplotsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotsortconfiguration.html#cfn-quicksight-template-boxplotsortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class BoxPlotStyleOptions : Humidifier.Base.BaseSubResource, IHaveFillStyle
        {
            /// <summary>
            /// FillStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotstyleoptions.html#cfn-quicksight-template-boxplotstyleoptions-fillstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FillStyle { get; set; }
        }

        public class BoxPlotVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-boxplotvisual.html#cfn-quicksight-template-boxplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class CalculatedField : Humidifier.Base.BaseSubResource, IHaveName, IHaveExpression, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-calculatedfield.html#cfn-quicksight-template-calculatedfield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-calculatedfield.html#cfn-quicksight-template-calculatedfield-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-calculatedfield.html#cfn-quicksight-template-calculatedfield-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CalculatedMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-calculatedmeasurefield.html#cfn-quicksight-template-calculatedmeasurefield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-calculatedmeasurefield.html#cfn-quicksight-template-calculatedmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CascadingControlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-cascadingcontrolconfiguration.html#cfn-quicksight-template-cascadingcontrolconfiguration-sourcecontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CascadingControlSource
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.CascadingControlSource> SourceControls { get; set; }
        }

        public class CascadingControlSource : Humidifier.Base.BaseSubResource, IHaveSourceSheetControlId
        {
            /// <summary>
            /// SourceSheetControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-cascadingcontrolsource.html#cfn-quicksight-template-cascadingcontrolsource-sourcesheetcontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceSheetControlId { get; set; }
            /// <summary>
            /// ColumnToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-cascadingcontrolsource.html#cfn-quicksight-template-cascadingcontrolsource-columntomatch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier ColumnToMatch { get; set; }
        }

        public class CategoricalDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveHierarchyId
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricaldimensionfield.html#cfn-quicksight-template-categoricaldimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricaldimensionfield.html#cfn-quicksight-template-categoricaldimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricaldimensionfield.html#cfn-quicksight-template-categoricaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricaldimensionfield.html#cfn-quicksight-template-categoricaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoricalMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricalmeasurefield.html#cfn-quicksight-template-categoricalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricalmeasurefield.html#cfn-quicksight-template-categoricalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricalmeasurefield.html#cfn-quicksight-template-categoricalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoricalmeasurefield.html#cfn-quicksight-template-categoricalmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoryDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveCategoryValues
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categorydrilldownfilter.html#cfn-quicksight-template-categorydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categorydrilldownfilter.html#cfn-quicksight-template-categorydrilldownfilter-categoryvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
        }

        public class CategoryFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilter.html#cfn-quicksight-template-categoryfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilter.html#cfn-quicksight-template-categoryfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilter.html#cfn-quicksight-template-categoryfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilter.html#cfn-quicksight-template-categoryfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class CategoryFilterConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomFilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilterconfiguration.html#cfn-quicksight-template-categoryfilterconfiguration-customfilterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterListConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomFilterListConfiguration CustomFilterListConfiguration { get; set; }
            /// <summary>
            /// CustomFilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilterconfiguration.html#cfn-quicksight-template-categoryfilterconfiguration-customfilterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomFilterConfiguration CustomFilterConfiguration { get; set; }
            /// <summary>
            /// FilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryfilterconfiguration.html#cfn-quicksight-template-categoryfilterconfiguration-filterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterListConfiguration FilterListConfiguration { get; set; }
        }

        public class CategoryInnerFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryinnerfilter.html#cfn-quicksight-template-categoryinnerfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryinnerfilter.html#cfn-quicksight-template-categoryinnerfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-categoryinnerfilter.html#cfn-quicksight-template-categoryinnerfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
        }

        public class ChartAxisLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveSortIconVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-chartaxislabeloptions.html#cfn-quicksight-template-chartaxislabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// SortIconVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-chartaxislabeloptions.html#cfn-quicksight-template-chartaxislabeloptions-sorticonvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SortIconVisibility { get; set; }
            /// <summary>
            /// AxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-chartaxislabeloptions.html#cfn-quicksight-template-chartaxislabeloptions-axislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AxisLabelOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.AxisLabelOptions> AxisLabelOptions { get; set; }
        }

        public class ClusterMarker : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SimpleClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-clustermarker.html#cfn-quicksight-template-clustermarker-simpleclustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SimpleClusterMarker
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SimpleClusterMarker SimpleClusterMarker { get; set; }
        }

        public class ClusterMarkerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-clustermarkerconfiguration.html#cfn-quicksight-template-clustermarkerconfiguration-clustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarker
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ClusterMarker ClusterMarker { get; set; }
        }

        public class ColorScale : Humidifier.Base.BaseSubResource, IHaveColorFillType
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-colorscale.html#cfn-quicksight-template-colorscale-colors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataColor
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataColor> Colors { get; set; }
            /// <summary>
            /// ColorFillType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-colorscale.html#cfn-quicksight-template-colorscale-colorfilltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorFillType { get; set; }
            /// <summary>
            /// NullValueColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-colorscale.html#cfn-quicksight-template-colorscale-nullvaluecolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataColor NullValueColor { get; set; }
        }

        public class ColorsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-colorsconfiguration.html#cfn-quicksight-template-colorsconfiguration-customcolors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomColor
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.CustomColor> CustomColors { get; set; }
        }

        public class ColumnConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveRole
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnconfiguration.html#cfn-quicksight-template-columnconfiguration-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnconfiguration.html#cfn-quicksight-template-columnconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnconfiguration.html#cfn-quicksight-template-columnconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// ColorsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnconfiguration.html#cfn-quicksight-template-columnconfiguration-colorsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorsConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColorsConfiguration ColorsConfiguration { get; set; }
        }

        public class ColumnGroupColumnSchema : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columngroupcolumnschema.html#cfn-quicksight-template-columngroupcolumnschema-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ColumnGroupSchema : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// ColumnGroupColumnSchemaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columngroupschema.html#cfn-quicksight-template-columngroupschema-columngroupcolumnschemalist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnGroupColumnSchema
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnGroupColumnSchema> ColumnGroupColumnSchemaList { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columngroupschema.html#cfn-quicksight-template-columngroupschema-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ColumnHierarchy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateTimeHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnhierarchy.html#cfn-quicksight-template-columnhierarchy-datetimehierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeHierarchy
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeHierarchy DateTimeHierarchy { get; set; }
            /// <summary>
            /// ExplicitHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnhierarchy.html#cfn-quicksight-template-columnhierarchy-explicithierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExplicitHierarchy
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ExplicitHierarchy ExplicitHierarchy { get; set; }
            /// <summary>
            /// PredefinedHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnhierarchy.html#cfn-quicksight-template-columnhierarchy-predefinedhierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedHierarchy
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PredefinedHierarchy PredefinedHierarchy { get; set; }
        }

        public class ColumnIdentifier : Humidifier.Base.BaseSubResource, IHaveDataSetIdentifier, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnidentifier.html#cfn-quicksight-template-columnidentifier-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnidentifier.html#cfn-quicksight-template-columnidentifier-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class ColumnSchema : Humidifier.Base.BaseSubResource, IHaveName, IHaveDataType
        {
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnschema.html#cfn-quicksight-template-columnschema-datatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataType { get; set; }
            /// <summary>
            /// GeographicRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnschema.html#cfn-quicksight-template-columnschema-geographicrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeographicRole { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnschema.html#cfn-quicksight-template-columnschema-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ColumnSort : Humidifier.Base.BaseSubResource, IHaveDirection, IHaveQuickSightTemplateTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnsort.html#cfn-quicksight-template-columnsort-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnsort.html#cfn-quicksight-template-columnsort-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier SortBy { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnsort.html#cfn-quicksight-template-columnsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class ColumnTooltipItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveLabel
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columntooltipitem.html#cfn-quicksight-template-columntooltipitem-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AggregationFunction Aggregation { get; set; }
            /// <summary>
            /// TooltipTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columntooltipitem.html#cfn-quicksight-template-columntooltipitem-tooltiptarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTarget { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columntooltipitem.html#cfn-quicksight-template-columntooltipitem-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columntooltipitem.html#cfn-quicksight-template-columntooltipitem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columntooltipitem.html#cfn-quicksight-template-columntooltipitem-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class ComboChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BarValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartaggregatedfieldwells.html#cfn-quicksight-template-combochartaggregatedfieldwells-barvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> BarValues { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartaggregatedfieldwells.html#cfn-quicksight-template-combochartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartaggregatedfieldwells.html#cfn-quicksight-template-combochartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// LineValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartaggregatedfieldwells.html#cfn-quicksight-template-combochartaggregatedfieldwells-linevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> LineValues { get; set; }
        }

        public class ComboChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveBarsArrangement, IHaveQuickSightTemplateTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightTemplateTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComboChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// BarDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-bardatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions BarDataLabels { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SingleAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-singleaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleAxisOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SingleAxisOptions SingleAxisOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// BarsArrangement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-barsarrangement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BarsArrangement { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// LineDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-linedatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions LineDataLabels { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComboChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartconfiguration.html#cfn-quicksight-template-combochartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
        }

        public class ComboChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ComboChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartfieldwells.html#cfn-quicksight-template-combochartfieldwells-combochartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComboChartAggregatedFieldWells ComboChartAggregatedFieldWells { get; set; }
        }

        public class ComboChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightTemplateTypesItemsLimitConfigurationColorItemsLimit
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartsortconfiguration.html#cfn-quicksight-template-combochartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartsortconfiguration.html#cfn-quicksight-template-combochartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartsortconfiguration.html#cfn-quicksight-template-combochartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartsortconfiguration.html#cfn-quicksight-template-combochartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class ComboChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComboChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-combochartvisual.html#cfn-quicksight-template-combochartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ComparisonConfiguration : Humidifier.Base.BaseSubResource, IHaveComparisonMethod
        {
            /// <summary>
            /// ComparisonMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-comparisonconfiguration.html#cfn-quicksight-template-comparisonconfiguration-comparisonmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonMethod { get; set; }
            /// <summary>
            /// ComparisonFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-comparisonconfiguration.html#cfn-quicksight-template-comparisonconfiguration-comparisonformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComparisonFormatConfiguration ComparisonFormat { get; set; }
        }

        public class ComparisonFormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-comparisonformatconfiguration.html#cfn-quicksight-template-comparisonformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-comparisonformatconfiguration.html#cfn-quicksight-template-comparisonformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class Computation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PeriodToDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-periodtodate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodToDateComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PeriodToDateComputation PeriodToDate { get; set; }
            /// <summary>
            /// GrowthRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-growthrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrowthRateComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GrowthRateComputation GrowthRate { get; set; }
            /// <summary>
            /// TopBottomRanked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-topbottomranked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomRankedComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TopBottomRankedComputation TopBottomRanked { get; set; }
            /// <summary>
            /// TotalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-totalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalAggregationComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TotalAggregationComputation TotalAggregation { get; set; }
            /// <summary>
            /// Forecast
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-forecast
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ForecastComputation Forecast { get; set; }
            /// <summary>
            /// MaximumMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-maximumminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumMinimumComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MaximumMinimumComputation MaximumMinimum { get; set; }
            /// <summary>
            /// PeriodOverPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-periodoverperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodOverPeriodComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PeriodOverPeriodComputation PeriodOverPeriod { get; set; }
            /// <summary>
            /// MetricComparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-metriccomparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricComparisonComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MetricComparisonComputation MetricComparison { get; set; }
            /// <summary>
            /// TopBottomMovers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-topbottommovers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomMoversComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TopBottomMoversComputation TopBottomMovers { get; set; }
            /// <summary>
            /// UniqueValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-computation.html#cfn-quicksight-template-computation-uniquevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UniqueValuesComputation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.UniqueValuesComputation UniqueValues { get; set; }
        }

        public class ConditionalFormattingColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcolor.html#cfn-quicksight-template-conditionalformattingcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingGradientColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingGradientColor Gradient { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcolor.html#cfn-quicksight-template-conditionalformattingcolor-solid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingSolidColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingSolidColor Solid { get; set; }
        }

        public class ConditionalFormattingCustomIconCondition : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColor
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcustomiconcondition.html#cfn-quicksight-template-conditionalformattingcustomiconcondition-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcustomiconcondition.html#cfn-quicksight-template-conditionalformattingcustomiconcondition-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// DisplayConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcustomiconcondition.html#cfn-quicksight-template-conditionalformattingcustomiconcondition-displayconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconDisplayConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIconDisplayConfiguration DisplayConfiguration { get; set; }
            /// <summary>
            /// IconOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcustomiconcondition.html#cfn-quicksight-template-conditionalformattingcustomiconcondition-iconoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingCustomIconOptions IconOptions { get; set; }
        }

        public class ConditionalFormattingCustomIconOptions : Humidifier.Base.BaseSubResource, IHaveIcon, IHaveUnicodeIcon
        {
            /// <summary>
            /// UnicodeIcon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcustomiconoptions.html#cfn-quicksight-template-conditionalformattingcustomiconoptions-unicodeicon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnicodeIcon { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingcustomiconoptions.html#cfn-quicksight-template-conditionalformattingcustomiconoptions-icon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Icon { get; set; }
        }

        public class ConditionalFormattingGradientColor : Humidifier.Base.BaseSubResource, IHaveExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattinggradientcolor.html#cfn-quicksight-template-conditionalformattinggradientcolor-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattinggradientcolor.html#cfn-quicksight-template-conditionalformattinggradientcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GradientColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GradientColor Color { get; set; }
        }

        public class ConditionalFormattingIcon : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingicon.html#cfn-quicksight-template-conditionalformattingicon-customcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconCondition
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingCustomIconCondition CustomCondition { get; set; }
            /// <summary>
            /// IconSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingicon.html#cfn-quicksight-template-conditionalformattingicon-iconset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconSet
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIconSet IconSet { get; set; }
        }

        public class ConditionalFormattingIconDisplayConfiguration : Humidifier.Base.BaseSubResource, IHaveIconDisplayOption
        {
            /// <summary>
            /// IconDisplayOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingicondisplayconfiguration.html#cfn-quicksight-template-conditionalformattingicondisplayconfiguration-icondisplayoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IconDisplayOption { get; set; }
        }

        public class ConditionalFormattingIconSet : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveIconSetType
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingiconset.html#cfn-quicksight-template-conditionalformattingiconset-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// IconSetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingiconset.html#cfn-quicksight-template-conditionalformattingiconset-iconsettype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IconSetType { get; set; }
        }

        public class ConditionalFormattingSolidColor : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColor
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingsolidcolor.html#cfn-quicksight-template-conditionalformattingsolidcolor-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-conditionalformattingsolidcolor.html#cfn-quicksight-template-conditionalformattingsolidcolor-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class ContributionAnalysisDefault : Humidifier.Base.BaseSubResource, IHaveMeasureFieldId
        {
            /// <summary>
            /// MeasureFieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-contributionanalysisdefault.html#cfn-quicksight-template-contributionanalysisdefault-measurefieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureFieldId { get; set; }
            /// <summary>
            /// ContributorDimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-contributionanalysisdefault.html#cfn-quicksight-template-contributionanalysisdefault-contributordimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnIdentifier> ContributorDimensions { get; set; }
        }

        public class CurrencyDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveNumberScale, IHaveSymbol, IHaveQuickSightTemplateTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightTemplateTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightTemplateTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightTemplateTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NumberScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-numberscale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NumberScale { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Symbol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-symbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Symbol { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-currencydisplayformatconfiguration.html#cfn-quicksight-template-currencydisplayformatconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class CustomActionFilterOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelectedFieldsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customactionfilteroperation.html#cfn-quicksight-template-customactionfilteroperation-selectedfieldsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationSelectedFieldsConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterOperationSelectedFieldsConfiguration SelectedFieldsConfiguration { get; set; }
            /// <summary>
            /// TargetVisualsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customactionfilteroperation.html#cfn-quicksight-template-customactionfilteroperation-targetvisualsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationTargetVisualsConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterOperationTargetVisualsConfiguration TargetVisualsConfiguration { get; set; }
        }

        public class CustomActionNavigationOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LocalNavigationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customactionnavigationoperation.html#cfn-quicksight-template-customactionnavigationoperation-localnavigationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocalNavigationConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LocalNavigationConfiguration LocalNavigationConfiguration { get; set; }
        }

        public class CustomActionSetParametersOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParameterValueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customactionsetparametersoperation.html#cfn-quicksight-template-customactionsetparametersoperation-parametervalueconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SetParameterValueConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SetParameterValueConfiguration> ParameterValueConfigurations { get; set; }
        }

        public class CustomActionURLOperation : Humidifier.Base.BaseSubResource, IHaveURLTemplate, IHaveURLTarget
        {
            /// <summary>
            /// URLTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customactionurloperation.html#cfn-quicksight-template-customactionurloperation-urltemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic URLTemplate { get; set; }
            /// <summary>
            /// URLTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customactionurloperation.html#cfn-quicksight-template-customactionurloperation-urltarget
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic URLTarget { get; set; }
        }

        public class CustomColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveFieldValue, IHaveSpecialValue
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcolor.html#cfn-quicksight-template-customcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcolor.html#cfn-quicksight-template-customcolor-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
            /// <summary>
            /// SpecialValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcolor.html#cfn-quicksight-template-customcolor-specialvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpecialValue { get; set; }
        }

        public class CustomContentConfiguration : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContentUrl, IHaveImageScaling
        {
            /// <summary>
            /// ContentUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentconfiguration.html#cfn-quicksight-template-customcontentconfiguration-contenturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentUrl { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentconfiguration.html#cfn-quicksight-template-customcontentconfiguration-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// ImageScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentconfiguration.html#cfn-quicksight-template-customcontentconfiguration-imagescaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageScaling { get; set; }
        }

        public class CustomContentVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomContentConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customcontentvisual.html#cfn-quicksight-template-customcontentvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class CustomFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveCategoryValue
        {
            /// <summary>
            /// CategoryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterconfiguration.html#cfn-quicksight-template-customfilterconfiguration-categoryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterconfiguration.html#cfn-quicksight-template-customfilterconfiguration-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterconfiguration.html#cfn-quicksight-template-customfilterconfiguration-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterconfiguration.html#cfn-quicksight-template-customfilterconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterconfiguration.html#cfn-quicksight-template-customfilterconfiguration-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
        }

        public class CustomFilterListConfiguration : Humidifier.Base.BaseSubResource, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveCategoryValues
        {
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterlistconfiguration.html#cfn-quicksight-template-customfilterlistconfiguration-categoryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterlistconfiguration.html#cfn-quicksight-template-customfilterlistconfiguration-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterlistconfiguration.html#cfn-quicksight-template-customfilterlistconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customfilterlistconfiguration.html#cfn-quicksight-template-customfilterlistconfiguration-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
        }

        public class CustomNarrativeOptions : Humidifier.Base.BaseSubResource, IHaveNarrative
        {
            /// <summary>
            /// Narrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customnarrativeoptions.html#cfn-quicksight-template-customnarrativeoptions-narrative
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Narrative { get; set; }
        }

        public class CustomParameterValues : Humidifier.Base.BaseSubResource, IHaveStringValues, IHaveDateTimeValues
        {
            /// <summary>
            /// DecimalValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customparametervalues.html#cfn-quicksight-template-customparametervalues-decimalvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> DecimalValues { get; set; }
            /// <summary>
            /// IntegerValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customparametervalues.html#cfn-quicksight-template-customparametervalues-integervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> IntegerValues { get; set; }
            /// <summary>
            /// StringValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customparametervalues.html#cfn-quicksight-template-customparametervalues-stringvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringValues { get; set; }
            /// <summary>
            /// DateTimeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customparametervalues.html#cfn-quicksight-template-customparametervalues-datetimevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DateTimeValues { get; set; }
        }

        public class CustomValuesConfiguration : Humidifier.Base.BaseSubResource, IHaveIncludeNullValue
        {
            /// <summary>
            /// IncludeNullValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customvaluesconfiguration.html#cfn-quicksight-template-customvaluesconfiguration-includenullvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeNullValue { get; set; }
            /// <summary>
            /// CustomValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-customvaluesconfiguration.html#cfn-quicksight-template-customvaluesconfiguration-customvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomParameterValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomParameterValues CustomValues { get; set; }
        }

        public class DataBarsOptions : Humidifier.Base.BaseSubResource, IHaveFieldId, IHavePositiveColor, IHaveNegativeColor
        {
            /// <summary>
            /// PositiveColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-databarsoptions.html#cfn-quicksight-template-databarsoptions-positivecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositiveColor { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-databarsoptions.html#cfn-quicksight-template-databarsoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// NegativeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-databarsoptions.html#cfn-quicksight-template-databarsoptions-negativecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NegativeColor { get; set; }
        }

        public class DataColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
        {
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datacolor.html#cfn-quicksight-template-datacolor-datavalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datacolor.html#cfn-quicksight-template-datacolor-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class DataFieldSeriesItem : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveFieldValue, IHaveAxisBinding
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datafieldseriesitem.html#cfn-quicksight-template-datafieldseriesitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datafieldseriesitem.html#cfn-quicksight-template-datafieldseriesitem-axisbinding
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datafieldseriesitem.html#cfn-quicksight-template-datafieldseriesitem-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datafieldseriesitem.html#cfn-quicksight-template-datafieldseriesitem-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSeriesSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartSeriesSettings Settings { get; set; }
        }

        public class DataLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHavePosition, IHaveTotalsVisibility, IHaveMeasureLabelVisibility, IHaveCategoryLabelVisibility, IHaveLabelColor, IHaveLabelContent, IHaveOverlap
        {
            /// <summary>
            /// DataLabelTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-datalabeltypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataLabelType
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataLabelType> DataLabelTypes { get; set; }
            /// <summary>
            /// MeasureLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-measurelabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic MeasureLabelVisibility { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// LabelContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-labelcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelContent { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// Overlap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-overlap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Overlap { get; set; }
            /// <summary>
            /// CategoryLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-categorylabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CategoryLabelVisibility { get; set; }
            /// <summary>
            /// LabelColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-labelcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColor { get; set; }
            /// <summary>
            /// LabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeloptions.html#cfn-quicksight-template-datalabeloptions-labelfontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class DataLabelType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeltype.html#cfn-quicksight-template-datalabeltype-maximumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumLabelType
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MaximumLabelType MaximumLabelType { get; set; }
            /// <summary>
            /// DataPathLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeltype.html#cfn-quicksight-template-datalabeltype-datapathlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathLabelType
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataPathLabelType DataPathLabelType { get; set; }
            /// <summary>
            /// RangeEndsLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeltype.html#cfn-quicksight-template-datalabeltype-rangeendslabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangeEndsLabelType
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RangeEndsLabelType RangeEndsLabelType { get; set; }
            /// <summary>
            /// FieldLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeltype.html#cfn-quicksight-template-datalabeltype-fieldlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldLabelType
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FieldLabelType FieldLabelType { get; set; }
            /// <summary>
            /// MinimumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datalabeltype.html#cfn-quicksight-template-datalabeltype-minimumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MinimumLabelType
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MinimumLabelType MinimumLabelType { get; set; }
        }

        public class DataPathColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveTimeGranularity
        {
            /// <summary>
            /// Element
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathcolor.html#cfn-quicksight-template-datapathcolor-element
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPathValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataPathValue Element { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathcolor.html#cfn-quicksight-template-datapathcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathcolor.html#cfn-quicksight-template-datapathcolor-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
        }

        public class DataPathLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveFieldValue
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathlabeltype.html#cfn-quicksight-template-datapathlabeltype-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathlabeltype.html#cfn-quicksight-template-datapathlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathlabeltype.html#cfn-quicksight-template-datapathlabeltype-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
        }

        public class DataPathSort : Humidifier.Base.BaseSubResource, IHaveDirection
        {
            /// <summary>
            /// SortPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathsort.html#cfn-quicksight-template-datapathsort-sortpaths
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataPathValue> SortPaths { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathsort.html#cfn-quicksight-template-datapathsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class DataPathType : Humidifier.Base.BaseSubResource, IHavePivotTableDataPathType
        {
            /// <summary>
            /// PivotTableDataPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathtype.html#cfn-quicksight-template-datapathtype-pivottabledatapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PivotTableDataPathType { get; set; }
        }

        public class DataPathValue : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveFieldValue
        {
            /// <summary>
            /// DataPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathvalue.html#cfn-quicksight-template-datapathvalue-datapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathType
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataPathType DataPathType { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathvalue.html#cfn-quicksight-template-datapathvalue-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datapathvalue.html#cfn-quicksight-template-datapathvalue-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
        }

        public class DataSetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Placeholder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetconfiguration.html#cfn-quicksight-template-datasetconfiguration-placeholder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placeholder { get; set; }
            /// <summary>
            /// DataSetSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetconfiguration.html#cfn-quicksight-template-datasetconfiguration-datasetschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetSchema
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataSetSchema DataSetSchema { get; set; }
            /// <summary>
            /// ColumnGroupSchemaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetconfiguration.html#cfn-quicksight-template-datasetconfiguration-columngroupschemalist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnGroupSchema
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnGroupSchema> ColumnGroupSchemaList { get; set; }
        }

        public class DataSetReference : Humidifier.Base.BaseSubResource, IHaveDataSetArn, IHaveDataSetPlaceholder
        {
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetreference.html#cfn-quicksight-template-datasetreference-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
            /// <summary>
            /// DataSetPlaceholder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetreference.html#cfn-quicksight-template-datasetreference-datasetplaceholder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetPlaceholder { get; set; }
        }

        public class DataSetSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnSchemaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetschema.html#cfn-quicksight-template-datasetschema-columnschemalist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSchema
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnSchema> ColumnSchemaList { get; set; }
        }

        public class DateAxisOptions : Humidifier.Base.BaseSubResource, IHaveMissingDateVisibility
        {
            /// <summary>
            /// MissingDateVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dateaxisoptions.html#cfn-quicksight-template-dateaxisoptions-missingdatevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic MissingDateVisibility { get; set; }
        }

        public class DateDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveHierarchyId, IHaveDateGranularity
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datedimensionfield.html#cfn-quicksight-template-datedimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datedimensionfield.html#cfn-quicksight-template-datedimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datedimensionfield.html#cfn-quicksight-template-datedimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datedimensionfield.html#cfn-quicksight-template-datedimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// DateGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datedimensionfield.html#cfn-quicksight-template-datedimensionfield-dategranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateGranularity { get; set; }
        }

        public class DateMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datemeasurefield.html#cfn-quicksight-template-datemeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datemeasurefield.html#cfn-quicksight-template-datemeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datemeasurefield.html#cfn-quicksight-template-datemeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datemeasurefield.html#cfn-quicksight-template-datemeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class DateTimeDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues, IHaveQuickSightTemplateTypesDynamicDefaultValueDynamicValue, IHaveQuickSightTemplateTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimedefaultvalues.html#cfn-quicksight-template-datetimedefaultvalues-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimedefaultvalues.html#cfn-quicksight-template-datetimedefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimedefaultvalues.html#cfn-quicksight-template-datetimedefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class DateTimeFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightTemplateTypesNullValueFormatConfigurationNullValueFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeformatconfiguration.html#cfn-quicksight-template-datetimeformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeformatconfiguration.html#cfn-quicksight-template-datetimeformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeformatconfiguration.html#cfn-quicksight-template-datetimeformatconfiguration-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class DateTimeHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimehierarchy.html#cfn-quicksight-template-datetimehierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimehierarchy.html#cfn-quicksight-template-datetimehierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DrillDownFilter> DrillDownFilters { get; set; }
        }

        public class DateTimeParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveTimeGranularity
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeparameterdeclaration.html#cfn-quicksight-template-datetimeparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeparameterdeclaration.html#cfn-quicksight-template-datetimeparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDefaultValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeparameterdeclaration.html#cfn-quicksight-template-datetimeparameterdeclaration-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeparameterdeclaration.html#cfn-quicksight-template-datetimeparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeValueWhenUnsetConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimeparameterdeclaration.html#cfn-quicksight-template-datetimeparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DateTimePickerControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimepickercontroldisplayoptions.html#cfn-quicksight-template-datetimepickercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimepickercontroldisplayoptions.html#cfn-quicksight-template-datetimepickercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimepickercontroldisplayoptions.html#cfn-quicksight-template-datetimepickercontroldisplayoptions-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class DateTimeValueWhenUnsetConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomValue, IHaveValueWhenUnsetOption
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimevaluewhenunsetconfiguration.html#cfn-quicksight-template-datetimevaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datetimevaluewhenunsetconfiguration.html#cfn-quicksight-template-datetimevaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class DecimalDefaultValues : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimaldefaultvalues.html#cfn-quicksight-template-decimaldefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimaldefaultvalues.html#cfn-quicksight-template-decimaldefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class DecimalParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalparameterdeclaration.html#cfn-quicksight-template-decimalparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalparameterdeclaration.html#cfn-quicksight-template-decimalparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDefaultValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DecimalDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalparameterdeclaration.html#cfn-quicksight-template-decimalparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalparameterdeclaration.html#cfn-quicksight-template-decimalparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalValueWhenUnsetConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DecimalValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalparameterdeclaration.html#cfn-quicksight-template-decimalparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DecimalPlacesConfiguration : Humidifier.Base.BaseSubResource, IHaveDecimalPlaces
        {
            /// <summary>
            /// DecimalPlaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalplacesconfiguration.html#cfn-quicksight-template-decimalplacesconfiguration-decimalplaces
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DecimalPlaces { get; set; }
        }

        public class DecimalValueWhenUnsetConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomValue, IHaveValueWhenUnsetOption
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalvaluewhenunsetconfiguration.html#cfn-quicksight-template-decimalvaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-decimalvaluewhenunsetconfiguration.html#cfn-quicksight-template-decimalvaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class DefaultDateTimePickerControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightTemplateTypesDateTimePickerControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultdatetimepickercontroloptions.html#cfn-quicksight-template-defaultdatetimepickercontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultdatetimepickercontroloptions.html#cfn-quicksight-template-defaultdatetimepickercontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultdatetimepickercontroloptions.html#cfn-quicksight-template-defaultdatetimepickercontroloptions-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
        }

        public class DefaultFilterControlConfiguration : Humidifier.Base.BaseSubResource, IHaveTitle
        {
            /// <summary>
            /// ControlOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontrolconfiguration.html#cfn-quicksight-template-defaultfiltercontrolconfiguration-controloptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlOptions ControlOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontrolconfiguration.html#cfn-quicksight-template-defaultfiltercontrolconfiguration-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class DefaultFilterControlOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultSliderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaultslideroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSliderControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultSliderControlOptions DefaultSliderOptions { get; set; }
            /// <summary>
            /// DefaultRelativeDateTimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaultrelativedatetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRelativeDateTimeControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions { get; set; }
            /// <summary>
            /// DefaultTextFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaulttextfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextFieldControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultTextFieldControlOptions DefaultTextFieldOptions { get; set; }
            /// <summary>
            /// DefaultTextAreaOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaulttextareaoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextAreaControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultTextAreaControlOptions DefaultTextAreaOptions { get; set; }
            /// <summary>
            /// DefaultDropdownOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaultdropdownoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterDropDownControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterDropDownControlOptions DefaultDropdownOptions { get; set; }
            /// <summary>
            /// DefaultDateTimePickerOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaultdatetimepickeroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultDateTimePickerControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions { get; set; }
            /// <summary>
            /// DefaultListOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfiltercontroloptions.html#cfn-quicksight-template-defaultfiltercontroloptions-defaultlistoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterListControlOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterListControlOptions DefaultListOptions { get; set; }
        }

        public class DefaultFilterDropDownControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightTemplateTypesFilterSelectableValuesSelectableValues, IHaveQuickSightTemplateTypesDropDownControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterdropdowncontroloptions.html#cfn-quicksight-template-defaultfilterdropdowncontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterdropdowncontroloptions.html#cfn-quicksight-template-defaultfilterdropdowncontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterdropdowncontroloptions.html#cfn-quicksight-template-defaultfilterdropdowncontroloptions-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterdropdowncontroloptions.html#cfn-quicksight-template-defaultfilterdropdowncontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFilterListControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightTemplateTypesFilterSelectableValuesSelectableValues, IHaveQuickSightTemplateTypesListControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterlistcontroloptions.html#cfn-quicksight-template-defaultfilterlistcontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterlistcontroloptions.html#cfn-quicksight-template-defaultfilterlistcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfilterlistcontroloptions.html#cfn-quicksight-template-defaultfilterlistcontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFreeFormLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultfreeformlayoutconfiguration.html#cfn-quicksight-template-defaultfreeformlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultGridLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultgridlayoutconfiguration.html#cfn-quicksight-template-defaultgridlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultInteractiveLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FreeForm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultinteractivelayoutconfiguration.html#cfn-quicksight-template-defaultinteractivelayoutconfiguration-freeform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFreeFormLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration FreeForm { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultinteractivelayoutconfiguration.html#cfn-quicksight-template-defaultinteractivelayoutconfiguration-grid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultGridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration Grid { get; set; }
        }

        public class DefaultNewSheetConfiguration : Humidifier.Base.BaseSubResource, IHaveSheetContentType
        {
            /// <summary>
            /// SheetContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultnewsheetconfiguration.html#cfn-quicksight-template-defaultnewsheetconfiguration-sheetcontenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetContentType { get; set; }
            /// <summary>
            /// InteractiveLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultnewsheetconfiguration.html#cfn-quicksight-template-defaultnewsheetconfiguration-interactivelayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultInteractiveLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration { get; set; }
            /// <summary>
            /// PaginatedLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultnewsheetconfiguration.html#cfn-quicksight-template-defaultnewsheetconfiguration-paginatedlayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultPaginatedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration PaginatedLayoutConfiguration { get; set; }
        }

        public class DefaultPaginatedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SectionBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultpaginatedlayoutconfiguration.html#cfn-quicksight-template-defaultpaginatedlayoutconfiguration-sectionbased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSectionBasedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration SectionBased { get; set; }
        }

        public class DefaultRelativeDateTimeControlOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultrelativedatetimecontroloptions.html#cfn-quicksight-template-defaultrelativedatetimecontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultrelativedatetimecontroloptions.html#cfn-quicksight-template-defaultrelativedatetimecontroloptions-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
        }

        public class DefaultSectionBasedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultsectionbasedlayoutconfiguration.html#cfn-quicksight-template-defaultsectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultSliderControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightTemplateTypesSliderControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultslidercontroloptions.html#cfn-quicksight-template-defaultslidercontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultslidercontroloptions.html#cfn-quicksight-template-defaultslidercontroloptions-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultslidercontroloptions.html#cfn-quicksight-template-defaultslidercontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultslidercontroloptions.html#cfn-quicksight-template-defaultslidercontroloptions-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaultslidercontroloptions.html#cfn-quicksight-template-defaultslidercontroloptions-minimumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumValue { get; set; }
        }

        public class DefaultTextAreaControlOptions : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveQuickSightTemplateTypesTextAreaControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaulttextareacontroloptions.html#cfn-quicksight-template-defaulttextareacontroloptions-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaulttextareacontroloptions.html#cfn-quicksight-template-defaulttextareacontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DefaultTextFieldControlOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesTextFieldControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-defaulttextfieldcontroloptions.html#cfn-quicksight-template-defaulttextfieldcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DestinationParameterValueConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceParameterName, IHaveSelectAllValueOptions, IHaveSourceField
        {
            /// <summary>
            /// CustomValuesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-destinationparametervalueconfiguration.html#cfn-quicksight-template-destinationparametervalueconfiguration-customvaluesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomValuesConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomValuesConfiguration CustomValuesConfiguration { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-destinationparametervalueconfiguration.html#cfn-quicksight-template-destinationparametervalueconfiguration-sourceparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// SelectAllValueOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-destinationparametervalueconfiguration.html#cfn-quicksight-template-destinationparametervalueconfiguration-selectallvalueoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllValueOptions { get; set; }
            /// <summary>
            /// SourceField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-destinationparametervalueconfiguration.html#cfn-quicksight-template-destinationparametervalueconfiguration-sourcefield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceField { get; set; }
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-destinationparametervalueconfiguration.html#cfn-quicksight-template-destinationparametervalueconfiguration-sourcecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier SourceColumn { get; set; }
        }

        public class DimensionField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dimensionfield.html#cfn-quicksight-template-dimensionfield-datedimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateDimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateDimensionField DateDimensionField { get; set; }
            /// <summary>
            /// NumericalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dimensionfield.html#cfn-quicksight-template-dimensionfield-numericaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalDimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericalDimensionField NumericalDimensionField { get; set; }
            /// <summary>
            /// CategoricalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dimensionfield.html#cfn-quicksight-template-dimensionfield-categoricaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalDimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoricalDimensionField CategoricalDimensionField { get; set; }
        }

        public class DonutCenterOptions : Humidifier.Base.BaseSubResource, IHaveLabelVisibility
        {
            /// <summary>
            /// LabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-donutcenteroptions.html#cfn-quicksight-template-donutcenteroptions-labelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic LabelVisibility { get; set; }
        }

        public class DonutOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DonutCenterOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-donutoptions.html#cfn-quicksight-template-donutoptions-donutcenteroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutCenterOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DonutCenterOptions DonutCenterOptions { get; set; }
            /// <summary>
            /// ArcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-donutoptions.html#cfn-quicksight-template-donutoptions-arcoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ArcOptions ArcOptions { get; set; }
        }

        public class DrillDownFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-drilldownfilter.html#cfn-quicksight-template-drilldownfilter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericEqualityDrillDownFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-drilldownfilter.html#cfn-quicksight-template-drilldownfilter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TimeRangeDrillDownFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-drilldownfilter.html#cfn-quicksight-template-drilldownfilter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoryDrillDownFilter CategoryFilter { get; set; }
        }

        public class DropDownControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dropdowncontroldisplayoptions.html#cfn-quicksight-template-dropdowncontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dropdowncontroldisplayoptions.html#cfn-quicksight-template-dropdowncontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dropdowncontroldisplayoptions.html#cfn-quicksight-template-dropdowncontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class DynamicDefaultValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dynamicdefaultvalue.html#cfn-quicksight-template-dynamicdefaultvalue-groupnamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier GroupNameColumn { get; set; }
            /// <summary>
            /// DefaultValueColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dynamicdefaultvalue.html#cfn-quicksight-template-dynamicdefaultvalue-defaultvaluecolumn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier DefaultValueColumn { get; set; }
            /// <summary>
            /// UserNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-dynamicdefaultvalue.html#cfn-quicksight-template-dynamicdefaultvalue-usernamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier UserNameColumn { get; set; }
        }

        public class EmptyVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveDataSetIdentifier
        {
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-emptyvisual.html#cfn-quicksight-template-emptyvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-emptyvisual.html#cfn-quicksight-template-emptyvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-emptyvisual.html#cfn-quicksight-template-emptyvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class Entity : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-entity.html#cfn-quicksight-template-entity-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
        }

        public class ExcludePeriodConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveGranularity, IHaveAmount
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-excludeperiodconfiguration.html#cfn-quicksight-template-excludeperiodconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-excludeperiodconfiguration.html#cfn-quicksight-template-excludeperiodconfiguration-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Amount { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-excludeperiodconfiguration.html#cfn-quicksight-template-excludeperiodconfiguration-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class ExplicitHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-explicithierarchy.html#cfn-quicksight-template-explicithierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-explicithierarchy.html#cfn-quicksight-template-explicithierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-explicithierarchy.html#cfn-quicksight-template-explicithierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnIdentifier> Columns { get; set; }
        }

        public class FieldBasedTooltip : Humidifier.Base.BaseSubResource, IHaveAggregationVisibility, IHaveTooltipTitleType
        {
            /// <summary>
            /// TooltipFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldbasedtooltip.html#cfn-quicksight-template-fieldbasedtooltip-tooltipfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TooltipItem
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TooltipItem> TooltipFields { get; set; }
            /// <summary>
            /// AggregationVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldbasedtooltip.html#cfn-quicksight-template-fieldbasedtooltip-aggregationvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AggregationVisibility { get; set; }
            /// <summary>
            /// TooltipTitleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldbasedtooltip.html#cfn-quicksight-template-fieldbasedtooltip-tooltiptitletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTitleType { get; set; }
        }

        public class FieldLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldlabeltype.html#cfn-quicksight-template-fieldlabeltype-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldlabeltype.html#cfn-quicksight-template-fieldlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FieldSeriesItem : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveAxisBinding
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldseriesitem.html#cfn-quicksight-template-fieldseriesitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldseriesitem.html#cfn-quicksight-template-fieldseriesitem-axisbinding
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldseriesitem.html#cfn-quicksight-template-fieldseriesitem-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSeriesSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartSeriesSettings Settings { get; set; }
        }

        public class FieldSort : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveDirection
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldsort.html#cfn-quicksight-template-fieldsort-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldsort.html#cfn-quicksight-template-fieldsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class FieldSortOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldsortoptions.html#cfn-quicksight-template-fieldsortoptions-fieldsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FieldSort FieldSort { get; set; }
            /// <summary>
            /// ColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldsortoptions.html#cfn-quicksight-template-fieldsortoptions-columnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnSort ColumnSort { get; set; }
        }

        public class FieldTooltipItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveLabel
        {
            /// <summary>
            /// TooltipTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldtooltipitem.html#cfn-quicksight-template-fieldtooltipitem-tooltiptarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTarget { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldtooltipitem.html#cfn-quicksight-template-fieldtooltipitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldtooltipitem.html#cfn-quicksight-template-fieldtooltipitem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fieldtooltipitem.html#cfn-quicksight-template-fieldtooltipitem-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FilledMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapaggregatedfieldwells.html#cfn-quicksight-template-filledmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapaggregatedfieldwells.html#cfn-quicksight-template-filledmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Geospatial { get; set; }
        }

        public class FilledMapConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconditionalformatting.html#cfn-quicksight-template-filledmapconditionalformatting-conditionalformattingoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilledMapConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FilledMapConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class FilledMapConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconditionalformattingoption.html#cfn-quicksight-template-filledmapconditionalformattingoption-shape
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilledMapShapeConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapShapeConditionalFormatting Shape { get; set; }
        }

        public class FilledMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconfiguration.html#cfn-quicksight-template-filledmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconfiguration.html#cfn-quicksight-template-filledmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconfiguration.html#cfn-quicksight-template-filledmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconfiguration.html#cfn-quicksight-template-filledmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconfiguration.html#cfn-quicksight-template-filledmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapconfiguration.html#cfn-quicksight-template-filledmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialWindowOptions WindowOptions { get; set; }
        }

        public class FilledMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilledMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapfieldwells.html#cfn-quicksight-template-filledmapfieldwells-filledmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapAggregatedFieldWells FilledMapAggregatedFieldWells { get; set; }
        }

        public class FilledMapShapeConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapshapeconditionalformatting.html#cfn-quicksight-template-filledmapshapeconditionalformatting-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShapeConditionalFormat
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ShapeConditionalFormat Format { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapshapeconditionalformatting.html#cfn-quicksight-template-filledmapshapeconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class FilledMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapsortconfiguration.html#cfn-quicksight-template-filledmapsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class FilledMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filledmapvisual.html#cfn-quicksight-template-filledmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NestedFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-nestedfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NestedFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NestedFilter NestedFilter { get; set; }
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericEqualityFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// NumericRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-numericrangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericRangeFilter NumericRangeFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TimeRangeFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// RelativeDatesFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-relativedatesfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDatesFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RelativeDatesFilter RelativeDatesFilter { get; set; }
            /// <summary>
            /// TopBottomFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-topbottomfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TopBottomFilter TopBottomFilter { get; set; }
            /// <summary>
            /// TimeEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-timeequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeEqualityFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TimeEqualityFilter TimeEqualityFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filter.html#cfn-quicksight-template-filter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoryFilter CategoryFilter { get; set; }
        }

        public class FilterControl : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Slider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSliderControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextAreaControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDropDownControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextFieldControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDateTimePickerControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterDateTimePickerControl DateTimePicker { get; set; }
            /// <summary>
            /// RelativeDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-relativedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterRelativeDateTimeControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterRelativeDateTimeControl RelativeDateTime { get; set; }
            /// <summary>
            /// CrossSheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercontrol.html#cfn-quicksight-template-filtercontrol-crosssheet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterCrossSheetControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterCrossSheetControl CrossSheet { get; set; }
        }

        public class FilterCrossSheetControl : Humidifier.Base.BaseSubResource, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightTemplateTypesCascadingControlConfigurationCascadingControlConfiguration
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercrosssheetcontrol.html#cfn-quicksight-template-filtercrosssheetcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercrosssheetcontrol.html#cfn-quicksight-template-filtercrosssheetcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtercrosssheetcontrol.html#cfn-quicksight-template-filtercrosssheetcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDateTimePickerControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightTemplateTypesDateTimePickerControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdatetimepickercontrol.html#cfn-quicksight-template-filterdatetimepickercontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdatetimepickercontrol.html#cfn-quicksight-template-filterdatetimepickercontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdatetimepickercontrol.html#cfn-quicksight-template-filterdatetimepickercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdatetimepickercontrol.html#cfn-quicksight-template-filterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdatetimepickercontrol.html#cfn-quicksight-template-filterdatetimepickercontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdatetimepickercontrol.html#cfn-quicksight-template-filterdatetimepickercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDropDownControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightTemplateTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightTemplateTypesFilterSelectableValuesSelectableValues, IHaveQuickSightTemplateTypesDropDownControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterdropdowncontrol.html#cfn-quicksight-template-filterdropdowncontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCrossDataset, IHaveFilterGroupId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtergroup.html#cfn-quicksight-template-filtergroup-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtergroup.html#cfn-quicksight-template-filtergroup-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.Filter> Filters { get; set; }
            /// <summary>
            /// CrossDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtergroup.html#cfn-quicksight-template-filtergroup-crossdataset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossDataset { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtergroup.html#cfn-quicksight-template-filtergroup-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterScopeConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterScopeConfiguration ScopeConfiguration { get; set; }
            /// <summary>
            /// FilterGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtergroup.html#cfn-quicksight-template-filtergroup-filtergroupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterGroupId { get; set; }
        }

        public class FilterListConfiguration : Humidifier.Base.BaseSubResource, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveCategoryValues
        {
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistconfiguration.html#cfn-quicksight-template-filterlistconfiguration-categoryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistconfiguration.html#cfn-quicksight-template-filterlistconfiguration-nulloption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistconfiguration.html#cfn-quicksight-template-filterlistconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistconfiguration.html#cfn-quicksight-template-filterlistconfiguration-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
        }

        public class FilterListControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightTemplateTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightTemplateTypesFilterSelectableValuesSelectableValues, IHaveQuickSightTemplateTypesListControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterlistcontrol.html#cfn-quicksight-template-filterlistcontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterOperationSelectedFieldsConfiguration : Humidifier.Base.BaseSubResource, IHaveSelectedFields, IHaveSelectedFieldOptions
        {
            /// <summary>
            /// SelectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-template-filteroperationselectedfieldsconfiguration-selectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnIdentifier> SelectedColumns { get; set; }
            /// <summary>
            /// SelectedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-template-filteroperationselectedfieldsconfiguration-selectedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SelectedFields { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-template-filteroperationselectedfieldsconfiguration-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedFieldOptions { get; set; }
        }

        public class FilterOperationTargetVisualsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SameSheetTargetVisualConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filteroperationtargetvisualsconfiguration.html#cfn-quicksight-template-filteroperationtargetvisualsconfiguration-samesheettargetvisualconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SameSheetTargetVisualConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SameSheetTargetVisualConfiguration SameSheetTargetVisualConfiguration { get; set; }
        }

        public class FilterRelativeDateTimeControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterrelativedatetimecontrol.html#cfn-quicksight-template-filterrelativedatetimecontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterrelativedatetimecontrol.html#cfn-quicksight-template-filterrelativedatetimecontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterrelativedatetimecontrol.html#cfn-quicksight-template-filterrelativedatetimecontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterrelativedatetimecontrol.html#cfn-quicksight-template-filterrelativedatetimecontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterrelativedatetimecontrol.html#cfn-quicksight-template-filterrelativedatetimecontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterScopeConfiguration : Humidifier.Base.BaseSubResource, IHaveAllSheets
        {
            /// <summary>
            /// AllSheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterscopeconfiguration.html#cfn-quicksight-template-filterscopeconfiguration-allsheets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllSheets { get; set; }
            /// <summary>
            /// SelectedSheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterscopeconfiguration.html#cfn-quicksight-template-filterscopeconfiguration-selectedsheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelectedSheetsFilterScopeConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SelectedSheetsFilterScopeConfiguration SelectedSheets { get; set; }
        }

        public class FilterSelectableValues : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterselectablevalues.html#cfn-quicksight-template-filterselectablevalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class FilterSliderControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightTemplateTypesSliderControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filterslidercontrol.html#cfn-quicksight-template-filterslidercontrol-minimumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumValue { get; set; }
        }

        public class FilterTextAreaControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveDelimiter, IHaveQuickSightTemplateTypesTextAreaControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextareacontrol.html#cfn-quicksight-template-filtertextareacontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextareacontrol.html#cfn-quicksight-template-filtertextareacontrol-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextareacontrol.html#cfn-quicksight-template-filtertextareacontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextareacontrol.html#cfn-quicksight-template-filtertextareacontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextareacontrol.html#cfn-quicksight-template-filtertextareacontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterTextFieldControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightTemplateTypesTextFieldControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// FilterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextfieldcontrol.html#cfn-quicksight-template-filtertextfieldcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextfieldcontrol.html#cfn-quicksight-template-filtertextfieldcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextfieldcontrol.html#cfn-quicksight-template-filtertextfieldcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-filtertextfieldcontrol.html#cfn-quicksight-template-filtertextfieldcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FontConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveFontStyle, IHaveFontDecoration
        {
            /// <summary>
            /// FontStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontconfiguration.html#cfn-quicksight-template-fontconfiguration-fontstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontStyle { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontconfiguration.html#cfn-quicksight-template-fontconfiguration-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontSize
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontSize FontSize { get; set; }
            /// <summary>
            /// FontDecoration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontconfiguration.html#cfn-quicksight-template-fontconfiguration-fontdecoration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontDecoration { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontconfiguration.html#cfn-quicksight-template-fontconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// FontWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontconfiguration.html#cfn-quicksight-template-fontconfiguration-fontweight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontWeight
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontWeight FontWeight { get; set; }
        }

        public class FontSize : Humidifier.Base.BaseSubResource, IHaveRelative
        {
            /// <summary>
            /// Relative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontsize.html#cfn-quicksight-template-fontsize-relative
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Relative { get; set; }
        }

        public class FontWeight : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-fontweight.html#cfn-quicksight-template-fontweight-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ForecastComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveQuickSightTemplateTypesDimensionFieldTime, IHavePeriodsBackward, IHavePeriodsForward, IHavePredictionInterval, IHaveSeasonality, IHaveUpperBoundary, IHaveLowerBoundary, IHaveCustomSeasonalityValue
        {
            /// <summary>
            /// PeriodsBackward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-periodsbackward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsBackward { get; set; }
            /// <summary>
            /// PeriodsForward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-periodsforward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsForward { get; set; }
            /// <summary>
            /// PredictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-predictioninterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PredictionInterval { get; set; }
            /// <summary>
            /// Seasonality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-seasonality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Seasonality { get; set; }
            /// <summary>
            /// CustomSeasonalityValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-customseasonalityvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomSeasonalityValue { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// UpperBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-upperboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperBoundary { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// LowerBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastcomputation.html#cfn-quicksight-template-forecastcomputation-lowerboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LowerBoundary { get; set; }
        }

        public class ForecastConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForecastProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastconfiguration.html#cfn-quicksight-template-forecastconfiguration-forecastproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedForecastProperties
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TimeBasedForecastProperties ForecastProperties { get; set; }
            /// <summary>
            /// Scenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastconfiguration.html#cfn-quicksight-template-forecastconfiguration-scenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastScenario
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ForecastScenario Scenario { get; set; }
        }

        public class ForecastScenario : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WhatIfRangeScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastscenario.html#cfn-quicksight-template-forecastscenario-whatifrangescenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfRangeScenario
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WhatIfRangeScenario WhatIfRangeScenario { get; set; }
            /// <summary>
            /// WhatIfPointScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-forecastscenario.html#cfn-quicksight-template-forecastscenario-whatifpointscenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfPointScenario
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WhatIfPointScenario WhatIfPointScenario { get; set; }
        }

        public class FormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-formatconfiguration.html#cfn-quicksight-template-formatconfiguration-numberformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumberFormatConfiguration NumberFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-formatconfiguration.html#cfn-quicksight-template-formatconfiguration-datetimeformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeFormatConfiguration DateTimeFormatConfiguration { get; set; }
            /// <summary>
            /// StringFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-formatconfiguration.html#cfn-quicksight-template-formatconfiguration-stringformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.StringFormatConfiguration StringFormatConfiguration { get; set; }
        }

        public class FreeFormLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutcanvassizeoptions.html#cfn-quicksight-template-freeformlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutScreenCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class FreeFormLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutconfiguration.html#cfn-quicksight-template-freeformlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutconfiguration.html#cfn-quicksight-template-freeformlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutElement> Elements { get; set; }
        }

        public class FreeFormLayoutElement : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveWidth, IHaveElementType, IHaveElementId, IHaveYAxisLocation, IHaveXAxisLocation
        {
            /// <summary>
            /// ElementType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-elementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementType { get; set; }
            /// <summary>
            /// BorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-borderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBorderStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutElementBorderStyle BorderStyle { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-height
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// RenderingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-renderingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetElementRenderingRule
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetElementRenderingRule> RenderingRules { get; set; }
            /// <summary>
            /// YAxisLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-yaxislocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic YAxisLocation { get; set; }
            /// <summary>
            /// LoadingAnimation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-loadinganimation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoadingAnimation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LoadingAnimation LoadingAnimation { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-width
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
            /// <summary>
            /// BackgroundStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-backgroundstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBackgroundStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutElementBackgroundStyle BackgroundStyle { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementId { get; set; }
            /// <summary>
            /// XAxisLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-xaxislocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic XAxisLocation { get; set; }
            /// <summary>
            /// SelectedBorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelement.html#cfn-quicksight-template-freeformlayoutelement-selectedborderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBorderStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutElementBorderStyle SelectedBorderStyle { get; set; }
        }

        public class FreeFormLayoutElementBackgroundStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveColor
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelementbackgroundstyle.html#cfn-quicksight-template-freeformlayoutelementbackgroundstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelementbackgroundstyle.html#cfn-quicksight-template-freeformlayoutelementbackgroundstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FreeFormLayoutElementBorderStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveColor
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelementborderstyle.html#cfn-quicksight-template-freeformlayoutelementborderstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutelementborderstyle.html#cfn-quicksight-template-freeformlayoutelementborderstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class FreeFormLayoutScreenCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedViewPortWidth
        {
            /// <summary>
            /// OptimizedViewPortWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformlayoutscreencanvassizeoptions.html#cfn-quicksight-template-freeformlayoutscreencanvassizeoptions-optimizedviewportwidth
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedViewPortWidth { get; set; }
        }

        public class FreeFormSectionLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-freeformsectionlayoutconfiguration.html#cfn-quicksight-template-freeformsectionlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutElement> Elements { get; set; }
        }

        public class FunnelChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartaggregatedfieldwells.html#cfn-quicksight-template-funnelchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartaggregatedfieldwells.html#cfn-quicksight-template-funnelchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class FunnelChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightTemplateTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FunnelChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-datalabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartDataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FunnelChartDataLabelOptions DataLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FunnelChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartconfiguration.html#cfn-quicksight-template-funnelchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
        }

        public class FunnelChartDataLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHavePosition, IHaveMeasureLabelVisibility, IHaveCategoryLabelVisibility, IHaveLabelColor, IHaveMeasureDataLabelStyle
        {
            /// <summary>
            /// MeasureLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-measurelabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic MeasureLabelVisibility { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// CategoryLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-categorylabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CategoryLabelVisibility { get; set; }
            /// <summary>
            /// LabelColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-labelcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColor { get; set; }
            /// <summary>
            /// MeasureDataLabelStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-measuredatalabelstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureDataLabelStyle { get; set; }
            /// <summary>
            /// LabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartdatalabeloptions.html#cfn-quicksight-template-funnelchartdatalabeloptions-labelfontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class FunnelChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunnelChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartfieldwells.html#cfn-quicksight-template-funnelchartfieldwells-funnelchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FunnelChartAggregatedFieldWells FunnelChartAggregatedFieldWells { get; set; }
        }

        public class FunnelChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartsortconfiguration.html#cfn-quicksight-template-funnelchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartsortconfiguration.html#cfn-quicksight-template-funnelchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class FunnelChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FunnelChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-funnelchartvisual.html#cfn-quicksight-template-funnelchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GaugeChartArcConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartarcconditionalformatting.html#cfn-quicksight-template-gaugechartarcconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class GaugeChartConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconditionalformatting.html#cfn-quicksight-template-gaugechartconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GaugeChartConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.GaugeChartConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class GaugeChartConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconditionalformattingoption.html#cfn-quicksight-template-gaugechartconditionalformattingoption-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartArcConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartArcConditionalFormatting Arc { get; set; }
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconditionalformattingoption.html#cfn-quicksight-template-gaugechartconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartPrimaryValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartPrimaryValueConditionalFormatting PrimaryValue { get; set; }
        }

        public class GaugeChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconfiguration.html#cfn-quicksight-template-gaugechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconfiguration.html#cfn-quicksight-template-gaugechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// TooltipOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconfiguration.html#cfn-quicksight-template-gaugechartconfiguration-tooltipoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions TooltipOptions { get; set; }
            /// <summary>
            /// GaugeChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconfiguration.html#cfn-quicksight-template-gaugechartconfiguration-gaugechartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartOptions GaugeChartOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartconfiguration.html#cfn-quicksight-template-gaugechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
        }

        public class GaugeChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartfieldwells.html#cfn-quicksight-template-gaugechartfieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> TargetValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartfieldwells.html#cfn-quicksight-template-gaugechartfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class GaugeChartOptions : Humidifier.Base.BaseSubResource, IHavePrimaryValueDisplayType
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartoptions.html#cfn-quicksight-template-gaugechartoptions-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ArcConfiguration Arc { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartoptions.html#cfn-quicksight-template-gaugechartoptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComparisonConfiguration Comparison { get; set; }
            /// <summary>
            /// PrimaryValueDisplayType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartoptions.html#cfn-quicksight-template-gaugechartoptions-primaryvaluedisplaytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryValueDisplayType { get; set; }
            /// <summary>
            /// ArcAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartoptions.html#cfn-quicksight-template-gaugechartoptions-arcaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ArcAxisConfiguration ArcAxis { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartoptions.html#cfn-quicksight-template-gaugechartoptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
        }

        public class GaugeChartPrimaryValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor, IHaveQuickSightTemplateTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-template-gaugechartprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-template-gaugechartprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class GaugeChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gaugechartvisual.html#cfn-quicksight-template-gaugechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class GeospatialCoordinateBounds : Humidifier.Base.BaseSubResource, IHaveWest, IHaveSouth, IHaveNorth, IHaveEast
        {
            /// <summary>
            /// West
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialcoordinatebounds.html#cfn-quicksight-template-geospatialcoordinatebounds-west
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic West { get; set; }
            /// <summary>
            /// South
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialcoordinatebounds.html#cfn-quicksight-template-geospatialcoordinatebounds-south
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic South { get; set; }
            /// <summary>
            /// North
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialcoordinatebounds.html#cfn-quicksight-template-geospatialcoordinatebounds-north
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic North { get; set; }
            /// <summary>
            /// East
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialcoordinatebounds.html#cfn-quicksight-template-geospatialcoordinatebounds-east
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic East { get; set; }
        }

        public class GeospatialHeatmapColorScale : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialheatmapcolorscale.html#cfn-quicksight-template-geospatialheatmapcolorscale-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialHeatmapDataColor
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.GeospatialHeatmapDataColor> Colors { get; set; }
        }

        public class GeospatialHeatmapConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatmapColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialheatmapconfiguration.html#cfn-quicksight-template-geospatialheatmapconfiguration-heatmapcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapColorScale
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialHeatmapColorScale HeatmapColor { get; set; }
        }

        public class GeospatialHeatmapDataColor : Humidifier.Base.BaseSubResource, IHaveColor
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialheatmapdatacolor.html#cfn-quicksight-template-geospatialheatmapdatacolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GeospatialMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapaggregatedfieldwells.html#cfn-quicksight-template-geospatialmapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapaggregatedfieldwells.html#cfn-quicksight-template-geospatialmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapaggregatedfieldwells.html#cfn-quicksight-template-geospatialmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Geospatial { get; set; }
        }

        public class GeospatialMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette
        {
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialWindowOptions WindowOptions { get; set; }
            /// <summary>
            /// PointStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-pointstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyleOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialPointStyleOptions PointStyleOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapconfiguration.html#cfn-quicksight-template-geospatialmapconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
        }

        public class GeospatialMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GeospatialMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapfieldwells.html#cfn-quicksight-template-geospatialmapfieldwells-geospatialmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialMapAggregatedFieldWells GeospatialMapAggregatedFieldWells { get; set; }
        }

        public class GeospatialMapStyleOptions : Humidifier.Base.BaseSubResource, IHaveBaseMapStyle
        {
            /// <summary>
            /// BaseMapStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapstyleoptions.html#cfn-quicksight-template-geospatialmapstyleoptions-basemapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapStyle { get; set; }
        }

        public class GeospatialMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialmapvisual.html#cfn-quicksight-template-geospatialmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GeospatialPointStyleOptions : Humidifier.Base.BaseSubResource, IHaveSelectedPointStyle
        {
            /// <summary>
            /// SelectedPointStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialpointstyleoptions.html#cfn-quicksight-template-geospatialpointstyleoptions-selectedpointstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedPointStyle { get; set; }
            /// <summary>
            /// ClusterMarkerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialpointstyleoptions.html#cfn-quicksight-template-geospatialpointstyleoptions-clustermarkerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarkerConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ClusterMarkerConfiguration ClusterMarkerConfiguration { get; set; }
            /// <summary>
            /// HeatmapConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialpointstyleoptions.html#cfn-quicksight-template-geospatialpointstyleoptions-heatmapconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialHeatmapConfiguration HeatmapConfiguration { get; set; }
        }

        public class GeospatialWindowOptions : Humidifier.Base.BaseSubResource, IHaveMapZoomMode
        {
            /// <summary>
            /// Bounds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialwindowoptions.html#cfn-quicksight-template-geospatialwindowoptions-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapZoomMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-geospatialwindowoptions.html#cfn-quicksight-template-geospatialwindowoptions-mapzoommode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MapZoomMode { get; set; }
        }

        public class GlobalTableBorderOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UniformBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-globaltableborderoptions.html#cfn-quicksight-template-globaltableborderoptions-uniformborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions UniformBorder { get; set; }
            /// <summary>
            /// SideSpecificBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-globaltableborderoptions.html#cfn-quicksight-template-globaltableborderoptions-sidespecificborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSideBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableSideBorderOptions SideSpecificBorder { get; set; }
        }

        public class GradientColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Stops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gradientcolor.html#cfn-quicksight-template-gradientcolor-stops
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GradientStop
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.GradientStop> Stops { get; set; }
        }

        public class GradientStop : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue, IHaveGradientOffset
        {
            /// <summary>
            /// GradientOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gradientstop.html#cfn-quicksight-template-gradientstop-gradientoffset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GradientOffset { get; set; }
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gradientstop.html#cfn-quicksight-template-gradientstop-datavalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gradientstop.html#cfn-quicksight-template-gradientstop-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GridLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutcanvassizeoptions.html#cfn-quicksight-template-gridlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutScreenCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class GridLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutconfiguration.html#cfn-quicksight-template-gridlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutconfiguration.html#cfn-quicksight-template-gridlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GridLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.GridLayoutElement> Elements { get; set; }
        }

        public class GridLayoutElement : Humidifier.Base.BaseSubResource, IHaveElementType, IHaveElementId, IHaveColumnSpan, IHaveColumnIndex, IHaveRowIndex, IHaveRowSpan
        {
            /// <summary>
            /// ElementType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutelement.html#cfn-quicksight-template-gridlayoutelement-elementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementType { get; set; }
            /// <summary>
            /// ColumnSpan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutelement.html#cfn-quicksight-template-gridlayoutelement-columnspan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ColumnSpan { get; set; }
            /// <summary>
            /// ColumnIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutelement.html#cfn-quicksight-template-gridlayoutelement-columnindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ColumnIndex { get; set; }
            /// <summary>
            /// RowIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutelement.html#cfn-quicksight-template-gridlayoutelement-rowindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RowIndex { get; set; }
            /// <summary>
            /// RowSpan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutelement.html#cfn-quicksight-template-gridlayoutelement-rowspan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RowSpan { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutelement.html#cfn-quicksight-template-gridlayoutelement-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementId { get; set; }
        }

        public class GridLayoutScreenCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedViewPortWidth, IHaveResizeOption
        {
            /// <summary>
            /// OptimizedViewPortWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutscreencanvassizeoptions.html#cfn-quicksight-template-gridlayoutscreencanvassizeoptions-optimizedviewportwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedViewPortWidth { get; set; }
            /// <summary>
            /// ResizeOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-gridlayoutscreencanvassizeoptions.html#cfn-quicksight-template-gridlayoutscreencanvassizeoptions-resizeoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResizeOption { get; set; }
        }

        public class GrowthRateComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveQuickSightTemplateTypesDimensionFieldTime, IHavePeriodSize
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-growthratecomputation.html#cfn-quicksight-template-growthratecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-growthratecomputation.html#cfn-quicksight-template-growthratecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// PeriodSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-growthratecomputation.html#cfn-quicksight-template-growthratecomputation-periodsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodSize { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-growthratecomputation.html#cfn-quicksight-template-growthratecomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-growthratecomputation.html#cfn-quicksight-template-growthratecomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HeaderFooterSectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSectionId
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-headerfootersectionconfiguration.html#cfn-quicksight-template-headerfootersectionconfiguration-layout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionLayoutConfiguration Layout { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-headerfootersectionconfiguration.html#cfn-quicksight-template-headerfootersectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionStyle Style { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-headerfootersectionconfiguration.html#cfn-quicksight-template-headerfootersectionconfiguration-sectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SectionId { get; set; }
        }

        public class HeatMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapaggregatedfieldwells.html#cfn-quicksight-template-heatmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapaggregatedfieldwells.html#cfn-quicksight-template-heatmapaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapaggregatedfieldwells.html#cfn-quicksight-template-heatmapaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Rows { get; set; }
        }

        public class HeatMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HeatMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// ColumnLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-columnlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ColumnLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HeatMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColorScale ColorScale { get; set; }
            /// <summary>
            /// RowLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapconfiguration.html#cfn-quicksight-template-heatmapconfiguration-rowlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions RowLabelOptions { get; set; }
        }

        public class HeatMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapfieldwells.html#cfn-quicksight-template-heatmapfieldwells-heatmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HeatMapAggregatedFieldWells HeatMapAggregatedFieldWells { get; set; }
        }

        public class HeatMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatMapRowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapsortconfiguration.html#cfn-quicksight-template-heatmapsortconfiguration-heatmaprowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> HeatMapRowSort { get; set; }
            /// <summary>
            /// HeatMapRowItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapsortconfiguration.html#cfn-quicksight-template-heatmapsortconfiguration-heatmaprowitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration HeatMapRowItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapsortconfiguration.html#cfn-quicksight-template-heatmapsortconfiguration-heatmapcolumnitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration HeatMapColumnItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapsortconfiguration.html#cfn-quicksight-template-heatmapsortconfiguration-heatmapcolumnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> HeatMapColumnSort { get; set; }
        }

        public class HeatMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HeatMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-heatmapvisual.html#cfn-quicksight-template-heatmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class HistogramAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramaggregatedfieldwells.html#cfn-quicksight-template-histogramaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class HistogramBinOptions : Humidifier.Base.BaseSubResource, IHaveStartValue, IHaveSelectedBinType
        {
            /// <summary>
            /// BinWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogrambinoptions.html#cfn-quicksight-template-histogrambinoptions-binwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinWidthOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BinWidthOptions BinWidth { get; set; }
            /// <summary>
            /// StartValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogrambinoptions.html#cfn-quicksight-template-histogrambinoptions-startvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartValue { get; set; }
            /// <summary>
            /// SelectedBinType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogrambinoptions.html#cfn-quicksight-template-histogrambinoptions-selectedbintype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedBinType { get; set; }
            /// <summary>
            /// BinCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogrambinoptions.html#cfn-quicksight-template-histogrambinoptions-bincount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinCountOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BinCountOptions BinCount { get; set; }
        }

        public class HistogramConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveQuickSightTemplateTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// BinOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-binoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramBinOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HistogramBinOptions BinOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HistogramFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramconfiguration.html#cfn-quicksight-template-histogramconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class HistogramFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HistogramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramfieldwells.html#cfn-quicksight-template-histogramfieldwells-histogramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HistogramAggregatedFieldWells HistogramAggregatedFieldWells { get; set; }
        }

        public class HistogramVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramvisual.html#cfn-quicksight-template-histogramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramvisual.html#cfn-quicksight-template-histogramvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramvisual.html#cfn-quicksight-template-histogramvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HistogramConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramvisual.html#cfn-quicksight-template-histogramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramvisual.html#cfn-quicksight-template-histogramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-histogramvisual.html#cfn-quicksight-template-histogramvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class ImageCustomAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveTrigger, IHaveCustomActionId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomaction.html#cfn-quicksight-template-imagecustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomaction.html#cfn-quicksight-template-imagecustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomaction.html#cfn-quicksight-template-imagecustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomaction.html#cfn-quicksight-template-imagecustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomaction.html#cfn-quicksight-template-imagecustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImageCustomActionOperation
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ImageCustomActionOperation> ActionOperations { get; set; }
        }

        public class ImageCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomactionoperation.html#cfn-quicksight-template-imagecustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomactionoperation.html#cfn-quicksight-template-imagecustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagecustomactionoperation.html#cfn-quicksight-template-imagecustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class ImageInteractionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageMenuOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imageinteractionoptions.html#cfn-quicksight-template-imageinteractionoptions-imagemenuoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageMenuOption
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ImageMenuOption ImageMenuOption { get; set; }
        }

        public class ImageMenuOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-imagemenuoption.html#cfn-quicksight-template-imagemenuoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class InnerFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategoryInnerFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-innerfilter.html#cfn-quicksight-template-innerfilter-categoryinnerfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryInnerFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoryInnerFilter CategoryInnerFilter { get; set; }
        }

        public class InsightConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Computations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightconfiguration.html#cfn-quicksight-template-insightconfiguration-computations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Computation
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.Computation> Computations { get; set; }
            /// <summary>
            /// CustomNarrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightconfiguration.html#cfn-quicksight-template-insightconfiguration-customnarrative
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomNarrativeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomNarrativeOptions CustomNarrative { get; set; }
        }

        public class InsightVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// InsightConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-insightconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.InsightConfiguration InsightConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-insightvisual.html#cfn-quicksight-template-insightvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class IntegerDefaultValues : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerdefaultvalues.html#cfn-quicksight-template-integerdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerdefaultvalues.html#cfn-quicksight-template-integerdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class IntegerParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerparameterdeclaration.html#cfn-quicksight-template-integerparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerparameterdeclaration.html#cfn-quicksight-template-integerparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDefaultValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.IntegerDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerparameterdeclaration.html#cfn-quicksight-template-integerparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerparameterdeclaration.html#cfn-quicksight-template-integerparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerValueWhenUnsetConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.IntegerValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integerparameterdeclaration.html#cfn-quicksight-template-integerparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegerValueWhenUnsetConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomValue, IHaveValueWhenUnsetOption
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integervaluewhenunsetconfiguration.html#cfn-quicksight-template-integervaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-integervaluewhenunsetconfiguration.html#cfn-quicksight-template-integervaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class ItemsLimitConfiguration : Humidifier.Base.BaseSubResource, IHaveItemsLimit, IHaveOtherCategories
        {
            /// <summary>
            /// ItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-itemslimitconfiguration.html#cfn-quicksight-template-itemslimitconfiguration-itemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ItemsLimit { get; set; }
            /// <summary>
            /// OtherCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-itemslimitconfiguration.html#cfn-quicksight-template-itemslimitconfiguration-othercategories
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OtherCategories { get; set; }
        }

        public class KPIActualValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor, IHaveQuickSightTemplateTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiactualvalueconditionalformatting.html#cfn-quicksight-template-kpiactualvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiactualvalueconditionalformatting.html#cfn-quicksight-template-kpiactualvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIComparisonValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor, IHaveQuickSightTemplateTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-template-kpicomparisonvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-template-kpicomparisonvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconditionalformatting.html#cfn-quicksight-template-kpiconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KPIConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.KPIConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class KPIConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconditionalformattingoption.html#cfn-quicksight-template-kpiconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIPrimaryValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIPrimaryValueConditionalFormatting PrimaryValue { get; set; }
            /// <summary>
            /// ActualValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconditionalformattingoption.html#cfn-quicksight-template-kpiconditionalformattingoption-actualvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIActualValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIActualValueConditionalFormatting ActualValue { get; set; }
            /// <summary>
            /// ComparisonValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconditionalformattingoption.html#cfn-quicksight-template-kpiconditionalformattingoption-comparisonvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIComparisonValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIComparisonValueConditionalFormatting ComparisonValue { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconditionalformattingoption.html#cfn-quicksight-template-kpiconditionalformattingoption-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIProgressBarConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIProgressBarConditionalFormatting ProgressBar { get; set; }
        }

        public class KPIConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconfiguration.html#cfn-quicksight-template-kpiconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPISortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// KPIOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconfiguration.html#cfn-quicksight-template-kpiconfiguration-kpioptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIOptions KPIOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiconfiguration.html#cfn-quicksight-template-kpiconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIFieldWells FieldWells { get; set; }
        }

        public class KPIFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpifieldwells.html#cfn-quicksight-template-kpifieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> TargetValues { get; set; }
            /// <summary>
            /// TrendGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpifieldwells.html#cfn-quicksight-template-kpifieldwells-trendgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> TrendGroups { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpifieldwells.html#cfn-quicksight-template-kpifieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class KPIOptions : Humidifier.Base.BaseSubResource, IHavePrimaryValueDisplayType
        {
            /// <summary>
            /// SecondaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-secondaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration SecondaryValueFontConfiguration { get; set; }
            /// <summary>
            /// VisualLayoutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-visuallayoutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualLayoutOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIVisualLayoutOptions VisualLayoutOptions { get; set; }
            /// <summary>
            /// TrendArrows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-trendarrows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendArrowOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TrendArrowOptions TrendArrows { get; set; }
            /// <summary>
            /// SecondaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-secondaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecondaryValueOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SecondaryValueOptions SecondaryValue { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComparisonConfiguration Comparison { get; set; }
            /// <summary>
            /// PrimaryValueDisplayType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-primaryvaluedisplaytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryValueDisplayType { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressBarOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ProgressBarOptions ProgressBar { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
            /// <summary>
            /// Sparkline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpioptions.html#cfn-quicksight-template-kpioptions-sparkline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISparklineOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPISparklineOptions Sparkline { get; set; }
        }

        public class KPIPrimaryValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor, IHaveQuickSightTemplateTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-template-kpiprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-template-kpiprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIProgressBarConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpiprogressbarconditionalformatting.html#cfn-quicksight-template-kpiprogressbarconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class KPISortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrendGroupSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpisortconfiguration.html#cfn-quicksight-template-kpisortconfiguration-trendgroupsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> TrendGroupSort { get; set; }
        }

        public class KPISparklineOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveVisibility, IHaveColor, IHaveTooltipVisibility
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpisparklineoptions.html#cfn-quicksight-template-kpisparklineoptions-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpisparklineoptions.html#cfn-quicksight-template-kpisparklineoptions-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// TooltipVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpisparklineoptions.html#cfn-quicksight-template-kpisparklineoptions-tooltipvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TooltipVisibility { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpisparklineoptions.html#cfn-quicksight-template-kpisparklineoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class KPIVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisual.html#cfn-quicksight-template-kpivisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class KPIVisualLayoutOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StandardLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisuallayoutoptions.html#cfn-quicksight-template-kpivisuallayoutoptions-standardlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualStandardLayout
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIVisualStandardLayout StandardLayout { get; set; }
        }

        public class KPIVisualStandardLayout : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-kpivisualstandardlayout.html#cfn-quicksight-template-kpivisualstandardlayout-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class LabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveCustomLabel, IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-labeloptions.html#cfn-quicksight-template-labeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-labeloptions.html#cfn-quicksight-template-labeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-labeloptions.html#cfn-quicksight-template-labeloptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class Layout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-layout.html#cfn-quicksight-template-layout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LayoutConfiguration Configuration { get; set; }
        }

        public class LayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-layoutconfiguration.html#cfn-quicksight-template-layoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GridLayoutConfiguration GridLayout { get; set; }
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-layoutconfiguration.html#cfn-quicksight-template-layoutconfiguration-freeformlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormLayoutConfiguration FreeFormLayout { get; set; }
            /// <summary>
            /// SectionBasedLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-layoutconfiguration.html#cfn-quicksight-template-layoutconfiguration-sectionbasedlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutConfiguration SectionBasedLayout { get; set; }
        }

        public class LegendOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveWidth, IHavePosition
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-legendoptions.html#cfn-quicksight-template-legendoptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// ValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-legendoptions.html#cfn-quicksight-template-legendoptions-valuefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration ValueFontConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-legendoptions.html#cfn-quicksight-template-legendoptions-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions Title { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-legendoptions.html#cfn-quicksight-template-legendoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-legendoptions.html#cfn-quicksight-template-legendoptions-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-legendoptions.html#cfn-quicksight-template-legendoptions-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class LineChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartaggregatedfieldwells.html#cfn-quicksight-template-linechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartaggregatedfieldwells.html#cfn-quicksight-template-linechartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartaggregatedfieldwells.html#cfn-quicksight-template-linechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartaggregatedfieldwells.html#cfn-quicksight-template-linechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class LineChartConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveQuickSightTemplateTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightTemplateTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightTemplateTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SingleAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-singleaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleAxisOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SingleAxisOptions SingleAxisOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
            /// <summary>
            /// DefaultSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-defaultseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartDefaultSeriesSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ForecastConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-forecastconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ForecastConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ForecastConfiguration> ForecastConfigurations { get; set; }
            /// <summary>
            /// Series
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-series
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeriesItem
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SeriesItem> Series { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartconfiguration.html#cfn-quicksight-template-linechartconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
        }

        public class LineChartDefaultSeriesSettings : Humidifier.Base.BaseSubResource, IHaveAxisBinding
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartdefaultseriessettings.html#cfn-quicksight-template-linechartdefaultseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartdefaultseriessettings.html#cfn-quicksight-template-linechartdefaultseriessettings-axisbinding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartdefaultseriessettings.html#cfn-quicksight-template-linechartdefaultseriessettings-markerstylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartMarkerStyleSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartfieldwells.html#cfn-quicksight-template-linechartfieldwells-linechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartAggregatedFieldWells LineChartAggregatedFieldWells { get; set; }
        }

        public class LineChartLineStyleSettings : Humidifier.Base.BaseSubResource, IHaveLineInterpolation, IHaveLineStyle, IHaveLineVisibility, IHaveLineWidth
        {
            /// <summary>
            /// LineInterpolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartlinestylesettings.html#cfn-quicksight-template-linechartlinestylesettings-lineinterpolation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineInterpolation { get; set; }
            /// <summary>
            /// LineStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartlinestylesettings.html#cfn-quicksight-template-linechartlinestylesettings-linestyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineStyle { get; set; }
            /// <summary>
            /// LineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartlinestylesettings.html#cfn-quicksight-template-linechartlinestylesettings-linevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic LineVisibility { get; set; }
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartlinestylesettings.html#cfn-quicksight-template-linechartlinestylesettings-linewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineWidth { get; set; }
        }

        public class LineChartMarkerStyleSettings : Humidifier.Base.BaseSubResource, IHaveMarkerShape, IHaveMarkerSize, IHaveMarkerVisibility, IHaveMarkerColor
        {
            /// <summary>
            /// MarkerShape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartmarkerstylesettings.html#cfn-quicksight-template-linechartmarkerstylesettings-markershape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerShape { get; set; }
            /// <summary>
            /// MarkerSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartmarkerstylesettings.html#cfn-quicksight-template-linechartmarkerstylesettings-markersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerSize { get; set; }
            /// <summary>
            /// MarkerVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartmarkerstylesettings.html#cfn-quicksight-template-linechartmarkerstylesettings-markervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic MarkerVisibility { get; set; }
            /// <summary>
            /// MarkerColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartmarkerstylesettings.html#cfn-quicksight-template-linechartmarkerstylesettings-markercolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerColor { get; set; }
        }

        public class LineChartSeriesSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartseriessettings.html#cfn-quicksight-template-linechartseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartseriessettings.html#cfn-quicksight-template-linechartseriessettings-markerstylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartMarkerStyleSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// CategoryItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartsortconfiguration.html#cfn-quicksight-template-linechartsortconfiguration-categoryitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimitConfiguration { get; set; }
            /// <summary>
            /// ColorItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartsortconfiguration.html#cfn-quicksight-template-linechartsortconfiguration-coloritemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration ColorItemsLimitConfiguration { get; set; }
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartsortconfiguration.html#cfn-quicksight-template-linechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartsortconfiguration.html#cfn-quicksight-template-linechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartsortconfiguration.html#cfn-quicksight-template-linechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class LineChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-linechartvisual.html#cfn-quicksight-template-linechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class LineSeriesAxisDisplayOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MissingDataConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-lineseriesaxisdisplayoptions.html#cfn-quicksight-template-lineseriesaxisdisplayoptions-missingdataconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MissingDataConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MissingDataConfiguration> MissingDataConfigurations { get; set; }
            /// <summary>
            /// AxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-lineseriesaxisdisplayoptions.html#cfn-quicksight-template-lineseriesaxisdisplayoptions-axisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions AxisOptions { get; set; }
        }

        public class ListControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-listcontroldisplayoptions.html#cfn-quicksight-template-listcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SearchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-listcontroldisplayoptions.html#cfn-quicksight-template-listcontroldisplayoptions-searchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSearchOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ListControlSearchOptions SearchOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-listcontroldisplayoptions.html#cfn-quicksight-template-listcontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-listcontroldisplayoptions.html#cfn-quicksight-template-listcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ListControlSearchOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-listcontrolsearchoptions.html#cfn-quicksight-template-listcontrolsearchoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class ListControlSelectAllOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-listcontrolselectalloptions.html#cfn-quicksight-template-listcontrolselectalloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class LoadingAnimation : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-loadinganimation.html#cfn-quicksight-template-loadinganimation-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class LocalNavigationConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetSheetId
        {
            /// <summary>
            /// TargetSheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-localnavigationconfiguration.html#cfn-quicksight-template-localnavigationconfiguration-targetsheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetSheetId { get; set; }
        }

        public class LongFormatText : Humidifier.Base.BaseSubResource, IHaveRichText, IHavePlainText
        {
            /// <summary>
            /// RichText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-longformattext.html#cfn-quicksight-template-longformattext-richtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RichText { get; set; }
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-longformattext.html#cfn-quicksight-template-longformattext-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlainText { get; set; }
        }

        public class MappedDataSetParameter : Humidifier.Base.BaseSubResource, IHaveDataSetIdentifier, IHaveDataSetParameterName
        {
            /// <summary>
            /// DataSetParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-mappeddatasetparameter.html#cfn-quicksight-template-mappeddatasetparameter-datasetparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetParameterName { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-mappeddatasetparameter.html#cfn-quicksight-template-mappeddatasetparameter-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class MaximumLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-maximumlabeltype.html#cfn-quicksight-template-maximumlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class MaximumMinimumComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveQuickSightTemplateTypesDimensionFieldTime
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-maximumminimumcomputation.html#cfn-quicksight-template-maximumminimumcomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-maximumminimumcomputation.html#cfn-quicksight-template-maximumminimumcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-maximumminimumcomputation.html#cfn-quicksight-template-maximumminimumcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-maximumminimumcomputation.html#cfn-quicksight-template-maximumminimumcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-maximumminimumcomputation.html#cfn-quicksight-template-maximumminimumcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MeasureField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-measurefield.html#cfn-quicksight-template-measurefield-datemeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateMeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateMeasureField DateMeasureField { get; set; }
            /// <summary>
            /// NumericalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-measurefield.html#cfn-quicksight-template-measurefield-numericalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalMeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericalMeasureField NumericalMeasureField { get; set; }
            /// <summary>
            /// CategoricalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-measurefield.html#cfn-quicksight-template-measurefield-categoricalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalMeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CategoricalMeasureField CategoricalMeasureField { get; set; }
            /// <summary>
            /// CalculatedMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-measurefield.html#cfn-quicksight-template-measurefield-calculatedmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CalculatedMeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CalculatedMeasureField CalculatedMeasureField { get; set; }
        }

        public class MetricComparisonComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesDimensionFieldTime
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-metriccomparisoncomputation.html#cfn-quicksight-template-metriccomparisoncomputation-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField TargetValue { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-metriccomparisoncomputation.html#cfn-quicksight-template-metriccomparisoncomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-metriccomparisoncomputation.html#cfn-quicksight-template-metriccomparisoncomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// FromValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-metriccomparisoncomputation.html#cfn-quicksight-template-metriccomparisoncomputation-fromvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField FromValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-metriccomparisoncomputation.html#cfn-quicksight-template-metriccomparisoncomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MinimumLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-minimumlabeltype.html#cfn-quicksight-template-minimumlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class MissingDataConfiguration : Humidifier.Base.BaseSubResource, IHaveTreatmentOption
        {
            /// <summary>
            /// TreatmentOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-missingdataconfiguration.html#cfn-quicksight-template-missingdataconfiguration-treatmentoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TreatmentOption { get; set; }
        }

        public class NegativeValueConfiguration : Humidifier.Base.BaseSubResource, IHaveDisplayMode
        {
            /// <summary>
            /// DisplayMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-negativevalueconfiguration.html#cfn-quicksight-template-negativevalueconfiguration-displaymode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayMode { get; set; }
        }

        public class NestedFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-nestedfilter.html#cfn-quicksight-template-nestedfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// InnerFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-nestedfilter.html#cfn-quicksight-template-nestedfilter-innerfilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InnerFilter
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.InnerFilter InnerFilter { get; set; }
            /// <summary>
            /// IncludeInnerSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-nestedfilter.html#cfn-quicksight-template-nestedfilter-includeinnerset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeInnerSet { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-nestedfilter.html#cfn-quicksight-template-nestedfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class NullValueFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveNullString
        {
            /// <summary>
            /// NullString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-nullvalueformatconfiguration.html#cfn-quicksight-template-nullvalueformatconfiguration-nullstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullString { get; set; }
        }

        public class NumberDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveNumberScale, IHaveQuickSightTemplateTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightTemplateTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightTemplateTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightTemplateTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NumberScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-numberscale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NumberScale { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberdisplayformatconfiguration.html#cfn-quicksight-template-numberdisplayformatconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class NumberFormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numberformatconfiguration.html#cfn-quicksight-template-numberformatconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
        }

        public class NumericAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericaxisoptions.html#cfn-quicksight-template-numericaxisoptions-scale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisScale
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisScale Scale { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericaxisoptions.html#cfn-quicksight-template-numericaxisoptions-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayRange
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayRange Range { get; set; }
        }

        public class NumericEqualityDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveQuickSightTemplateTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalitydrilldownfilter.html#cfn-quicksight-template-numericequalitydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalitydrilldownfilter.html#cfn-quicksight-template-numericequalitydrilldownfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class NumericEqualityFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveParameterName, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveQuickSightTemplateTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericequalityfilter.html#cfn-quicksight-template-numericequalityfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class NumericFormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericformatconfiguration.html#cfn-quicksight-template-numericformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// CurrencyDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericformatconfiguration.html#cfn-quicksight-template-numericformatconfiguration-currencydisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CurrencyDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CurrencyDisplayFormatConfiguration CurrencyDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericformatconfiguration.html#cfn-quicksight-template-numericformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class NumericRangeFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveSelectAllOptions, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveIncludeMaximum, IHaveIncludeMinimum, IHaveQuickSightTemplateTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericRangeFilterValue RangeMinimum { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericRangeFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefilter.html#cfn-quicksight-template-numericrangefilter-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
        }

        public class NumericRangeFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue, IHaveParameter
        {
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefiltervalue.html#cfn-quicksight-template-numericrangefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StaticValue { get; set; }
            /// <summary>
            /// Parameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericrangefiltervalue.html#cfn-quicksight-template-numericrangefiltervalue-parameter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Parameter { get; set; }
        }

        public class NumericSeparatorConfiguration : Humidifier.Base.BaseSubResource, IHaveDecimalSeparator
        {
            /// <summary>
            /// DecimalSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericseparatorconfiguration.html#cfn-quicksight-template-numericseparatorconfiguration-decimalseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DecimalSeparator { get; set; }
            /// <summary>
            /// ThousandsSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericseparatorconfiguration.html#cfn-quicksight-template-numericseparatorconfiguration-thousandsseparator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThousandSeparatorOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ThousandSeparatorOptions ThousandsSeparator { get; set; }
        }

        public class NumericalAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleNumericalAggregation
        {
            /// <summary>
            /// PercentileAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericalaggregationfunction.html#cfn-quicksight-template-numericalaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentileAggregation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PercentileAggregation PercentileAggregation { get; set; }
            /// <summary>
            /// SimpleNumericalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericalaggregationfunction.html#cfn-quicksight-template-numericalaggregationfunction-simplenumericalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleNumericalAggregation { get; set; }
        }

        public class NumericalDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveHierarchyId
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericaldimensionfield.html#cfn-quicksight-template-numericaldimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericaldimensionfield.html#cfn-quicksight-template-numericaldimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericaldimensionfield.html#cfn-quicksight-template-numericaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericaldimensionfield.html#cfn-quicksight-template-numericaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class NumericalMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericalmeasurefield.html#cfn-quicksight-template-numericalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericalAggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericalmeasurefield.html#cfn-quicksight-template-numericalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericalmeasurefield.html#cfn-quicksight-template-numericalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-numericalmeasurefield.html#cfn-quicksight-template-numericalmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class PaginationConfiguration : Humidifier.Base.BaseSubResource, IHavePageNumber, IHavePageSize
        {
            /// <summary>
            /// PageSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-paginationconfiguration.html#cfn-quicksight-template-paginationconfiguration-pagesize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PageSize { get; set; }
            /// <summary>
            /// PageNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-paginationconfiguration.html#cfn-quicksight-template-paginationconfiguration-pagenumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PageNumber { get; set; }
        }

        public class PanelConfiguration : Humidifier.Base.BaseSubResource, IHaveBackgroundColor, IHaveBorderThickness, IHaveBorderStyle, IHaveGutterSpacing, IHaveBackgroundVisibility, IHaveBorderVisibility, IHaveBorderColor, IHaveGutterVisibility
        {
            /// <summary>
            /// BorderThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-borderthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderThickness { get; set; }
            /// <summary>
            /// BorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-borderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderStyle { get; set; }
            /// <summary>
            /// GutterSpacing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-gutterspacing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GutterSpacing { get; set; }
            /// <summary>
            /// BackgroundVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-backgroundvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic BackgroundVisibility { get; set; }
            /// <summary>
            /// BorderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-bordervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic BorderVisibility { get; set; }
            /// <summary>
            /// BorderColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-bordercolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderColor { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PanelTitleOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PanelTitleOptions Title { get; set; }
            /// <summary>
            /// GutterVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-guttervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic GutterVisibility { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-panelconfiguration.html#cfn-quicksight-template-panelconfiguration-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class PanelTitleOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHorizontalTextAlignment, IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-paneltitleoptions.html#cfn-quicksight-template-paneltitleoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-paneltitleoptions.html#cfn-quicksight-template-paneltitleoptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-paneltitleoptions.html#cfn-quicksight-template-paneltitleoptions-horizontaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalTextAlignment { get; set; }
        }

        public class ParameterControl : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Slider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametercontrol.html#cfn-quicksight-template-parametercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSliderControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametercontrol.html#cfn-quicksight-template-parametercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextAreaControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametercontrol.html#cfn-quicksight-template-parametercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDropDownControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametercontrol.html#cfn-quicksight-template-parametercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextFieldControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametercontrol.html#cfn-quicksight-template-parametercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterListControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametercontrol.html#cfn-quicksight-template-parametercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDateTimePickerControl
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterDateTimePickerControl DateTimePicker { get; set; }
        }

        public class ParameterDateTimePickerControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightTemplateTypesDateTimePickerControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdatetimepickercontrol.html#cfn-quicksight-template-parameterdatetimepickercontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdatetimepickercontrol.html#cfn-quicksight-template-parameterdatetimepickercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdatetimepickercontrol.html#cfn-quicksight-template-parameterdatetimepickercontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdatetimepickercontrol.html#cfn-quicksight-template-parameterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class ParameterDeclaration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdeclaration.html#cfn-quicksight-template-parameterdeclaration-stringparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.StringParameterDeclaration StringParameterDeclaration { get; set; }
            /// <summary>
            /// DateTimeParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdeclaration.html#cfn-quicksight-template-parameterdeclaration-datetimeparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DateTimeParameterDeclaration DateTimeParameterDeclaration { get; set; }
            /// <summary>
            /// DecimalParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdeclaration.html#cfn-quicksight-template-parameterdeclaration-decimalparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DecimalParameterDeclaration DecimalParameterDeclaration { get; set; }
            /// <summary>
            /// IntegerParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdeclaration.html#cfn-quicksight-template-parameterdeclaration-integerparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.IntegerParameterDeclaration IntegerParameterDeclaration { get; set; }
        }

        public class ParameterDropDownControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightTemplateTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightTemplateTypesDropDownControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterdropdowncontrol.html#cfn-quicksight-template-parameterdropdowncontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterListControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightTemplateTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightTemplateTypesListControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterlistcontrol.html#cfn-quicksight-template-parameterlistcontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterSelectableValues : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// LinkToDataSetColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterselectablevalues.html#cfn-quicksight-template-parameterselectablevalues-linktodatasetcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier LinkToDataSetColumn { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterselectablevalues.html#cfn-quicksight-template-parameterselectablevalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class ParameterSliderControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightTemplateTypesSliderControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parameterslidercontrol.html#cfn-quicksight-template-parameterslidercontrol-minimumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinimumValue { get; set; }
        }

        public class ParameterTextAreaControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveDelimiter, IHaveQuickSightTemplateTypesTextAreaControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextareacontrol.html#cfn-quicksight-template-parametertextareacontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextareacontrol.html#cfn-quicksight-template-parametertextareacontrol-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextareacontrol.html#cfn-quicksight-template-parametertextareacontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextareacontrol.html#cfn-quicksight-template-parametertextareacontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextareacontrol.html#cfn-quicksight-template-parametertextareacontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class ParameterTextFieldControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightTemplateTypesTextFieldControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// ParameterControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextfieldcontrol.html#cfn-quicksight-template-parametertextfieldcontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextfieldcontrol.html#cfn-quicksight-template-parametertextfieldcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextfieldcontrol.html#cfn-quicksight-template-parametertextfieldcontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-parametertextfieldcontrol.html#cfn-quicksight-template-parametertextfieldcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
        }

        public class PercentVisibleRange : Humidifier.Base.BaseSubResource, IHaveFrom, IHaveTo
        {
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentvisiblerange.html#cfn-quicksight-template-percentvisiblerange-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentvisiblerange.html#cfn-quicksight-template-percentvisiblerange-to
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic To { get; set; }
        }

        public class PercentageDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveQuickSightTemplateTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightTemplateTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightTemplateTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightTemplateTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentagedisplayformatconfiguration.html#cfn-quicksight-template-percentagedisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentagedisplayformatconfiguration.html#cfn-quicksight-template-percentagedisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentagedisplayformatconfiguration.html#cfn-quicksight-template-percentagedisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentagedisplayformatconfiguration.html#cfn-quicksight-template-percentagedisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentagedisplayformatconfiguration.html#cfn-quicksight-template-percentagedisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentagedisplayformatconfiguration.html#cfn-quicksight-template-percentagedisplayformatconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class PercentileAggregation : Humidifier.Base.BaseSubResource, IHavePercentileValue
        {
            /// <summary>
            /// PercentileValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-percentileaggregation.html#cfn-quicksight-template-percentileaggregation-percentilevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentileValue { get; set; }
        }

        public class PeriodOverPeriodComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveQuickSightTemplateTypesDimensionFieldTime
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodoverperiodcomputation.html#cfn-quicksight-template-periodoverperiodcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodoverperiodcomputation.html#cfn-quicksight-template-periodoverperiodcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodoverperiodcomputation.html#cfn-quicksight-template-periodoverperiodcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodoverperiodcomputation.html#cfn-quicksight-template-periodoverperiodcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PeriodToDateComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveQuickSightTemplateTypesDimensionFieldTime, IHavePeriodTimeGranularity
        {
            /// <summary>
            /// PeriodTimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodtodatecomputation.html#cfn-quicksight-template-periodtodatecomputation-periodtimegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeriodTimeGranularity { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodtodatecomputation.html#cfn-quicksight-template-periodtodatecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodtodatecomputation.html#cfn-quicksight-template-periodtodatecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodtodatecomputation.html#cfn-quicksight-template-periodtodatecomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-periodtodatecomputation.html#cfn-quicksight-template-periodtodatecomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PieChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartaggregatedfieldwells.html#cfn-quicksight-template-piechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartaggregatedfieldwells.html#cfn-quicksight-template-piechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartaggregatedfieldwells.html#cfn-quicksight-template-piechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class PieChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightTemplateTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightTemplateTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PieChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PieChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// DonutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-donutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DonutOptions DonutOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartconfiguration.html#cfn-quicksight-template-piechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
        }

        public class PieChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PieChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartfieldwells.html#cfn-quicksight-template-piechartfieldwells-piechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PieChartAggregatedFieldWells PieChartAggregatedFieldWells { get; set; }
        }

        public class PieChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightTemplateTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartsortconfiguration.html#cfn-quicksight-template-piechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartsortconfiguration.html#cfn-quicksight-template-piechartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartsortconfiguration.html#cfn-quicksight-template-piechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartsortconfiguration.html#cfn-quicksight-template-piechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class PieChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PieChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-piechartvisual.html#cfn-quicksight-template-piechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class PivotFieldSortOptions : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivotfieldsortoptions.html#cfn-quicksight-template-pivotfieldsortoptions-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableSortBy
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableSortBy SortBy { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivotfieldsortoptions.html#cfn-quicksight-template-pivotfieldsortoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class PivotTableAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableaggregatedfieldwells.html#cfn-quicksight-template-pivottableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableaggregatedfieldwells.html#cfn-quicksight-template-pivottableaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableaggregatedfieldwells.html#cfn-quicksight-template-pivottableaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Rows { get; set; }
        }

        public class PivotTableCellConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablecellconditionalformatting.html#cfn-quicksight-template-pivottablecellconditionalformatting-scope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormattingScope
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableConditionalFormattingScope Scope { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablecellconditionalformatting.html#cfn-quicksight-template-pivottablecellconditionalformatting-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingScope
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotTableConditionalFormattingScope> Scopes { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablecellconditionalformatting.html#cfn-quicksight-template-pivottablecellconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablecellconditionalformatting.html#cfn-quicksight-template-pivottablecellconditionalformatting-textformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextConditionalFormat
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextConditionalFormat TextFormat { get; set; }
        }

        public class PivotTableConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconditionalformatting.html#cfn-quicksight-template-pivottableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotTableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class PivotTableConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconditionalformattingoption.html#cfn-quicksight-template-pivottableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableCellConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableCellConditionalFormatting Cell { get; set; }
        }

        public class PivotTableConditionalFormattingScope : Humidifier.Base.BaseSubResource, IHaveRole
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconditionalformattingscope.html#cfn-quicksight-template-pivottableconditionalformattingscope-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
        }

        public class PivotTableConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconfiguration.html#cfn-quicksight-template-pivottableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconfiguration.html#cfn-quicksight-template-pivottableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTablePaginatedReportOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconfiguration.html#cfn-quicksight-template-pivottableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableOptions TableOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconfiguration.html#cfn-quicksight-template-pivottableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconfiguration.html#cfn-quicksight-template-pivottableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableconfiguration.html#cfn-quicksight-template-pivottableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableTotalOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableTotalOptions TotalOptions { get; set; }
        }

        public class PivotTableDataPathOption : Humidifier.Base.BaseSubResource, IHaveWidth
        {
            /// <summary>
            /// DataPathList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottabledatapathoption.html#cfn-quicksight-template-pivottabledatapathoption-datapathlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataPathValue> DataPathList { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottabledatapathoption.html#cfn-quicksight-template-pivottabledatapathoption-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class PivotTableFieldCollapseStateOption : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldcollapsestateoption.html#cfn-quicksight-template-pivottablefieldcollapsestateoption-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableFieldCollapseStateTarget
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableFieldCollapseStateTarget Target { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldcollapsestateoption.html#cfn-quicksight-template-pivottablefieldcollapsestateoption-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class PivotTableFieldCollapseStateTarget : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldcollapsestatetarget.html#cfn-quicksight-template-pivottablefieldcollapsestatetarget-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// FieldDataPathValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldcollapsestatetarget.html#cfn-quicksight-template-pivottablefieldcollapsestatetarget-fielddatapathvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataPathValue> FieldDataPathValues { get; set; }
        }

        public class PivotTableFieldOption : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveCustomLabel
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldoption.html#cfn-quicksight-template-pivottablefieldoption-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldoption.html#cfn-quicksight-template-pivottablefieldoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldoption.html#cfn-quicksight-template-pivottablefieldoption-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class PivotTableFieldOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CollapseStateOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldoptions.html#cfn-quicksight-template-pivottablefieldoptions-collapsestateoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldCollapseStateOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotTableFieldCollapseStateOption> CollapseStateOptions { get; set; }
            /// <summary>
            /// DataPathOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldoptions.html#cfn-quicksight-template-pivottablefieldoptions-datapathoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableDataPathOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotTableDataPathOption> DataPathOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldoptions.html#cfn-quicksight-template-pivottablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotTableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class PivotTableFieldSubtotalOptions : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldsubtotaloptions.html#cfn-quicksight-template-pivottablefieldsubtotaloptions-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class PivotTableFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PivotTableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablefieldwells.html#cfn-quicksight-template-pivottablefieldwells-pivottableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableAggregatedFieldWells PivotTableAggregatedFieldWells { get; set; }
        }

        public class PivotTableOptions : Humidifier.Base.BaseSubResource, IHaveCollapsedRowDimensionsVisibility, IHaveRowsLayout, IHaveMetricPlacement, IHaveDefaultCellWidth, IHaveColumnNamesVisibility, IHaveSingleMetricVisibility, IHaveToggleButtonsVisibility
        {
            /// <summary>
            /// RowFieldNamesStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-rowfieldnamesstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle RowFieldNamesStyle { get; set; }
            /// <summary>
            /// RowHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-rowheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle RowHeaderStyle { get; set; }
            /// <summary>
            /// CollapsedRowDimensionsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-collapsedrowdimensionsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CollapsedRowDimensionsVisibility { get; set; }
            /// <summary>
            /// RowsLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-rowslayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RowsLayout { get; set; }
            /// <summary>
            /// MetricPlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-metricplacement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricPlacement { get; set; }
            /// <summary>
            /// DefaultCellWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-defaultcellwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultCellWidth { get; set; }
            /// <summary>
            /// ColumnNamesVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-columnnamesvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ColumnNamesVisibility { get; set; }
            /// <summary>
            /// RowsLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-rowslabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableRowsLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableRowsLabelOptions RowsLabelOptions { get; set; }
            /// <summary>
            /// SingleMetricVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-singlemetricvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SingleMetricVisibility { get; set; }
            /// <summary>
            /// ColumnHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-columnheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle ColumnHeaderStyle { get; set; }
            /// <summary>
            /// ToggleButtonsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-togglebuttonsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ToggleButtonsVisibility { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottableoptions.html#cfn-quicksight-template-pivottableoptions-rowalternatecoloroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowAlternateColorOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class PivotTablePaginatedReportOptions : Humidifier.Base.BaseSubResource, IHaveOverflowColumnHeaderVisibility, IHaveVerticalOverflowVisibility
        {
            /// <summary>
            /// OverflowColumnHeaderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablepaginatedreportoptions.html#cfn-quicksight-template-pivottablepaginatedreportoptions-overflowcolumnheadervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OverflowColumnHeaderVisibility { get; set; }
            /// <summary>
            /// VerticalOverflowVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablepaginatedreportoptions.html#cfn-quicksight-template-pivottablepaginatedreportoptions-verticaloverflowvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic VerticalOverflowVisibility { get; set; }
        }

        public class PivotTableRowsLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveCustomLabel
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablerowslabeloptions.html#cfn-quicksight-template-pivottablerowslabeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablerowslabeloptions.html#cfn-quicksight-template-pivottablerowslabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class PivotTableSortBy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablesortby.html#cfn-quicksight-template-pivottablesortby-field
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FieldSort Field { get; set; }
            /// <summary>
            /// DataPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablesortby.html#cfn-quicksight-template-pivottablesortby-datapath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathSort
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataPathSort DataPath { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablesortby.html#cfn-quicksight-template-pivottablesortby-column
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnSort Column { get; set; }
        }

        public class PivotTableSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSortOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablesortconfiguration.html#cfn-quicksight-template-pivottablesortconfiguration-fieldsortoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotFieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotFieldSortOptions> FieldSortOptions { get; set; }
        }

        public class PivotTableTotalOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottabletotaloptions.html#cfn-quicksight-template-pivottabletotaloptions-columnsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SubtotalOptions ColumnSubtotalOptions { get; set; }
            /// <summary>
            /// RowSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottabletotaloptions.html#cfn-quicksight-template-pivottabletotaloptions-rowsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SubtotalOptions RowSubtotalOptions { get; set; }
            /// <summary>
            /// RowTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottabletotaloptions.html#cfn-quicksight-template-pivottabletotaloptions-rowtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTotalOptions RowTotalOptions { get; set; }
            /// <summary>
            /// ColumnTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottabletotaloptions.html#cfn-quicksight-template-pivottabletotaloptions-columntotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTotalOptions ColumnTotalOptions { get; set; }
        }

        public class PivotTableVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottablevisual.html#cfn-quicksight-template-pivottablevisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class PivotTotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHavePlacement, IHaveScrollStatus, IHaveQuickSightTemplateTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// ScrollStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-scrollstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScrollStatus { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// MetricHeaderCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pivottotaloptions.html#cfn-quicksight-template-pivottotaloptions-metricheadercellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
        }

        public class PluginVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisual.html#cfn-quicksight-template-pluginvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// PluginArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisual.html#cfn-quicksight-template-pluginvisual-pluginarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PluginArn { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisual.html#cfn-quicksight-template-pluginvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisual.html#cfn-quicksight-template-pluginvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PluginVisualConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisual.html#cfn-quicksight-template-pluginvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisual.html#cfn-quicksight-template-pluginvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class PluginVisualConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualconfiguration.html#cfn-quicksight-template-pluginvisualconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PluginVisualSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// VisualOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualconfiguration.html#cfn-quicksight-template-pluginvisualconfiguration-visualoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PluginVisualOptions VisualOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualconfiguration.html#cfn-quicksight-template-pluginvisualconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PluginVisualFieldWell
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PluginVisualFieldWell> FieldWells { get; set; }
        }

        public class PluginVisualFieldWell : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Unaggregated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualfieldwell.html#cfn-quicksight-template-pluginvisualfieldwell-unaggregated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.UnaggregatedField> Unaggregated { get; set; }
            /// <summary>
            /// AxisName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualfieldwell.html#cfn-quicksight-template-pluginvisualfieldwell-axisname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisName { get; set; }
            /// <summary>
            /// Measures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualfieldwell.html#cfn-quicksight-template-pluginvisualfieldwell-measures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Measures { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualfieldwell.html#cfn-quicksight-template-pluginvisualfieldwell-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Dimensions { get; set; }
        }

        public class PluginVisualItemsLimitConfiguration : Humidifier.Base.BaseSubResource, IHaveItemsLimit
        {
            /// <summary>
            /// ItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualitemslimitconfiguration.html#cfn-quicksight-template-pluginvisualitemslimitconfiguration-itemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ItemsLimit { get; set; }
        }

        public class PluginVisualOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VisualProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualoptions.html#cfn-quicksight-template-pluginvisualoptions-visualproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PluginVisualProperty
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PluginVisualProperty> VisualProperties { get; set; }
        }

        public class PluginVisualProperty : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualproperty.html#cfn-quicksight-template-pluginvisualproperty-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualproperty.html#cfn-quicksight-template-pluginvisualproperty-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PluginVisualSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PluginVisualTableQuerySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualsortconfiguration.html#cfn-quicksight-template-pluginvisualsortconfiguration-pluginvisualtablequerysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualTableQuerySort
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PluginVisualTableQuerySort PluginVisualTableQuerySort { get; set; }
        }

        public class PluginVisualTableQuerySort : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualtablequerysort.html#cfn-quicksight-template-pluginvisualtablequerysort-itemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PluginVisualItemsLimitConfiguration ItemsLimitConfiguration { get; set; }
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-pluginvisualtablequerysort.html#cfn-quicksight-template-pluginvisualtablequerysort-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> RowSort { get; set; }
        }

        public class PredefinedHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
        {
            /// <summary>
            /// HierarchyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-predefinedhierarchy.html#cfn-quicksight-template-predefinedhierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-predefinedhierarchy.html#cfn-quicksight-template-predefinedhierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-predefinedhierarchy.html#cfn-quicksight-template-predefinedhierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnIdentifier> Columns { get; set; }
        }

        public class ProgressBarOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-progressbaroptions.html#cfn-quicksight-template-progressbaroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class QueryExecutionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryExecutionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-queryexecutionoptions.html#cfn-quicksight-template-queryexecutionoptions-queryexecutionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryExecutionMode { get; set; }
        }

        public class RadarChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartaggregatedfieldwells.html#cfn-quicksight-template-radarchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartaggregatedfieldwells.html#cfn-quicksight-template-radarchartaggregatedfieldwells-color
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Color { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartaggregatedfieldwells.html#cfn-quicksight-template-radarchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class RadarChartAreaStyleSettings : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartareastylesettings.html#cfn-quicksight-template-radarchartareastylesettings-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class RadarChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveShape, IHaveQuickSightTemplateTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsCategoryAxis, IHaveAxesRangeScale, IHaveAlternateBandColorsVisibility, IHaveStartAngle, IHaveAlternateBandOddColor, IHaveAlternateBandEvenColor
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-shape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Shape { get; set; }
            /// <summary>
            /// BaseSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-baseseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSeriesSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartSeriesSettings BaseSeriesSettings { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// AxesRangeScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-axesrangescale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxesRangeScale { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// AlternateBandColorsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-alternatebandcolorsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AlternateBandColorsVisibility { get; set; }
            /// <summary>
            /// StartAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-startangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartAngle { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ColorAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-coloraxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions ColorAxis { get; set; }
            /// <summary>
            /// AlternateBandOddColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-alternatebandoddcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandOddColor { get; set; }
            /// <summary>
            /// AlternateBandEvenColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartconfiguration.html#cfn-quicksight-template-radarchartconfiguration-alternatebandevencolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandEvenColor { get; set; }
        }

        public class RadarChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RadarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartfieldwells.html#cfn-quicksight-template-radarchartfieldwells-radarchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartAggregatedFieldWells RadarChartAggregatedFieldWells { get; set; }
        }

        public class RadarChartSeriesSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AreaStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartseriessettings.html#cfn-quicksight-template-radarchartseriessettings-areastylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAreaStyleSettings
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartAreaStyleSettings AreaStyleSettings { get; set; }
        }

        public class RadarChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightTemplateTypesItemsLimitConfigurationColorItemsLimit
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartsortconfiguration.html#cfn-quicksight-template-radarchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartsortconfiguration.html#cfn-quicksight-template-radarchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartsortconfiguration.html#cfn-quicksight-template-radarchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartsortconfiguration.html#cfn-quicksight-template-radarchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class RadarChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-radarchartvisual.html#cfn-quicksight-template-radarchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class RangeEndsLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-rangeendslabeltype.html#cfn-quicksight-template-rangeendslabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class ReferenceLine : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referenceline.html#cfn-quicksight-template-referenceline-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// DataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referenceline.html#cfn-quicksight-template-referenceline-dataconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReferenceLineDataConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineDataConfiguration DataConfiguration { get; set; }
            /// <summary>
            /// LabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referenceline.html#cfn-quicksight-template-referenceline-labelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineLabelConfiguration LabelConfiguration { get; set; }
            /// <summary>
            /// StyleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referenceline.html#cfn-quicksight-template-referenceline-styleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineStyleConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineStyleConfiguration StyleConfiguration { get; set; }
        }

        public class ReferenceLineCustomLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomLabel
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinecustomlabelconfiguration.html#cfn-quicksight-template-referencelinecustomlabelconfiguration-customlabel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
        }

        public class ReferenceLineDataConfiguration : Humidifier.Base.BaseSubResource, IHaveAxisBinding, IHaveSeriesType
        {
            /// <summary>
            /// DynamicConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedataconfiguration.html#cfn-quicksight-template-referencelinedataconfiguration-dynamicconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineDynamicDataConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineDynamicDataConfiguration DynamicConfiguration { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedataconfiguration.html#cfn-quicksight-template-referencelinedataconfiguration-axisbinding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// SeriesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedataconfiguration.html#cfn-quicksight-template-referencelinedataconfiguration-seriestype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SeriesType { get; set; }
            /// <summary>
            /// StaticConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedataconfiguration.html#cfn-quicksight-template-referencelinedataconfiguration-staticconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineStaticDataConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineStaticDataConfiguration StaticConfiguration { get; set; }
        }

        public class ReferenceLineDynamicDataConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedynamicdataconfiguration.html#cfn-quicksight-template-referencelinedynamicdataconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// MeasureAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedynamicdataconfiguration.html#cfn-quicksight-template-referencelinedynamicdataconfiguration-measureaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AggregationFunction MeasureAggregationFunction { get; set; }
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinedynamicdataconfiguration.html#cfn-quicksight-template-referencelinedynamicdataconfiguration-calculation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericalAggregationFunction Calculation { get; set; }
        }

        public class ReferenceLineLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration, IHaveHorizontalPosition, IHaveVerticalPosition
        {
            /// <summary>
            /// HorizontalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinelabelconfiguration.html#cfn-quicksight-template-referencelinelabelconfiguration-horizontalposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalPosition { get; set; }
            /// <summary>
            /// ValueLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinelabelconfiguration.html#cfn-quicksight-template-referencelinelabelconfiguration-valuelabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineValueLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineValueLabelConfiguration ValueLabelConfiguration { get; set; }
            /// <summary>
            /// CustomLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinelabelconfiguration.html#cfn-quicksight-template-referencelinelabelconfiguration-customlabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineCustomLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ReferenceLineCustomLabelConfiguration CustomLabelConfiguration { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinelabelconfiguration.html#cfn-quicksight-template-referencelinelabelconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinelabelconfiguration.html#cfn-quicksight-template-referencelinelabelconfiguration-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// VerticalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinelabelconfiguration.html#cfn-quicksight-template-referencelinelabelconfiguration-verticalposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalPosition { get; set; }
        }

        public class ReferenceLineStaticDataConfiguration : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinestaticdataconfiguration.html#cfn-quicksight-template-referencelinestaticdataconfiguration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class ReferenceLineStyleConfiguration : Humidifier.Base.BaseSubResource, IHaveColor, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinestyleconfiguration.html#cfn-quicksight-template-referencelinestyleconfiguration-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinestyleconfiguration.html#cfn-quicksight-template-referencelinestyleconfiguration-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class ReferenceLineValueLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveRelativePosition
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinevaluelabelconfiguration.html#cfn-quicksight-template-referencelinevaluelabelconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// RelativePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-referencelinevaluelabelconfiguration.html#cfn-quicksight-template-referencelinevaluelabelconfiguration-relativeposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativePosition { get; set; }
        }

        public class RelativeDateTimeControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatetimecontroldisplayoptions.html#cfn-quicksight-template-relativedatetimecontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatetimecontroldisplayoptions.html#cfn-quicksight-template-relativedatetimecontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatetimecontroldisplayoptions.html#cfn-quicksight-template-relativedatetimecontroldisplayoptions-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class RelativeDatesFilter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveRelativeDateValue, IHaveRelativeDateType, IHaveMinimumGranularity
        {
            /// <summary>
            /// RelativeDateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-relativedatevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RelativeDateValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RelativeDateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-relativedatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativeDateType { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-timegranularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// AnchorDateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-anchordateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AnchorDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AnchorDateConfiguration AnchorDateConfiguration { get; set; }
            /// <summary>
            /// MinimumGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-minimumgranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinimumGranularity { get; set; }
            /// <summary>
            /// ExcludePeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-relativedatesfilter.html#cfn-quicksight-template-relativedatesfilter-excludeperiodconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExcludePeriodConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-resourcepermission.html#cfn-quicksight-template-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-resourcepermission.html#cfn-quicksight-template-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }

        public class RollingDateConfiguration : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-rollingdateconfiguration.html#cfn-quicksight-template-rollingdateconfiguration-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-rollingdateconfiguration.html#cfn-quicksight-template-rollingdateconfiguration-datasetidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
        }

        public class RowAlternateColorOptions : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveUsePrimaryBackgroundColor, IHaveRowAlternateColors
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-rowalternatecoloroptions.html#cfn-quicksight-template-rowalternatecoloroptions-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// UsePrimaryBackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-rowalternatecoloroptions.html#cfn-quicksight-template-rowalternatecoloroptions-useprimarybackgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsePrimaryBackgroundColor { get; set; }
            /// <summary>
            /// RowAlternateColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-rowalternatecoloroptions.html#cfn-quicksight-template-rowalternatecoloroptions-rowalternatecolors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RowAlternateColors { get; set; }
        }

        public class SameSheetTargetVisualConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetVisualOptions, IHaveTargetVisuals
        {
            /// <summary>
            /// TargetVisualOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-samesheettargetvisualconfiguration.html#cfn-quicksight-template-samesheettargetvisualconfiguration-targetvisualoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetVisualOptions { get; set; }
            /// <summary>
            /// TargetVisuals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-samesheettargetvisualconfiguration.html#cfn-quicksight-template-samesheettargetvisualconfiguration-targetvisuals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TargetVisuals { get; set; }
        }

        public class SankeyDiagramAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-template-sankeydiagramaggregatedfieldwells-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-template-sankeydiagramaggregatedfieldwells-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Source { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-template-sankeydiagramaggregatedfieldwells-weight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Weight { get; set; }
        }

        public class SankeyDiagramChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramchartconfiguration.html#cfn-quicksight-template-sankeydiagramchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SankeyDiagramSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramchartconfiguration.html#cfn-quicksight-template-sankeydiagramchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramchartconfiguration.html#cfn-quicksight-template-sankeydiagramchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SankeyDiagramFieldWells FieldWells { get; set; }
        }

        public class SankeyDiagramFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SankeyDiagramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramfieldwells.html#cfn-quicksight-template-sankeydiagramfieldwells-sankeydiagramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SankeyDiagramAggregatedFieldWells SankeyDiagramAggregatedFieldWells { get; set; }
        }

        public class SankeyDiagramSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramsortconfiguration.html#cfn-quicksight-template-sankeydiagramsortconfiguration-weightsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> WeightSort { get; set; }
            /// <summary>
            /// SourceItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramsortconfiguration.html#cfn-quicksight-template-sankeydiagramsortconfiguration-sourceitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration SourceItemsLimit { get; set; }
            /// <summary>
            /// DestinationItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramsortconfiguration.html#cfn-quicksight-template-sankeydiagramsortconfiguration-destinationitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration DestinationItemsLimit { get; set; }
        }

        public class SankeyDiagramVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramvisual.html#cfn-quicksight-template-sankeydiagramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramvisual.html#cfn-quicksight-template-sankeydiagramvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramvisual.html#cfn-quicksight-template-sankeydiagramvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SankeyDiagramChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramvisual.html#cfn-quicksight-template-sankeydiagramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramvisual.html#cfn-quicksight-template-sankeydiagramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sankeydiagramvisual.html#cfn-quicksight-template-sankeydiagramvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class ScatterPlotCategoricallyAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-template-scatterplotcategoricallyaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-template-scatterplotcategoricallyaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-template-scatterplotcategoricallyaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-template-scatterplotcategoricallyaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-template-scatterplotcategoricallyaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> YAxis { get; set; }
        }

        public class ScatterPlotConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveQuickSightTemplateTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// YAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-yaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions YAxisLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ScatterPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotconfiguration.html#cfn-quicksight-template-scatterplotconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class ScatterPlotFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScatterPlotUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotfieldwells.html#cfn-quicksight-template-scatterplotfieldwells-scatterplotunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotUnaggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ScatterPlotUnaggregatedFieldWells ScatterPlotUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// ScatterPlotCategoricallyAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotfieldwells.html#cfn-quicksight-template-scatterplotfieldwells-scatterplotcategoricallyaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotCategoricallyAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ScatterPlotCategoricallyAggregatedFieldWells ScatterPlotCategoricallyAggregatedFieldWells { get; set; }
        }

        public class ScatterPlotUnaggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotunaggregatedfieldwells.html#cfn-quicksight-template-scatterplotunaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotunaggregatedfieldwells.html#cfn-quicksight-template-scatterplotunaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotunaggregatedfieldwells.html#cfn-quicksight-template-scatterplotunaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotunaggregatedfieldwells.html#cfn-quicksight-template-scatterplotunaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotunaggregatedfieldwells.html#cfn-quicksight-template-scatterplotunaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> YAxis { get; set; }
        }

        public class ScatterPlotVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ScatterPlotConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scatterplotvisual.html#cfn-quicksight-template-scatterplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ScrollBarOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// VisibleRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scrollbaroptions.html#cfn-quicksight-template-scrollbaroptions-visiblerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisibleRangeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisibleRangeOptions VisibleRange { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-scrollbaroptions.html#cfn-quicksight-template-scrollbaroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SecondaryValueOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-secondaryvalueoptions.html#cfn-quicksight-template-secondaryvalueoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SectionAfterPageBreak : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionafterpagebreak.html#cfn-quicksight-template-sectionafterpagebreak-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class SectionBasedLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PaperCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutcanvassizeoptions.html#cfn-quicksight-template-sectionbasedlayoutcanvassizeoptions-papercanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutPaperCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions PaperCanvasSizeOptions { get; set; }
        }

        public class SectionBasedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutconfiguration.html#cfn-quicksight-template-sectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// FooterSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutconfiguration.html#cfn-quicksight-template-sectionbasedlayoutconfiguration-footersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.HeaderFooterSectionConfiguration> FooterSections { get; set; }
            /// <summary>
            /// BodySections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutconfiguration.html#cfn-quicksight-template-sectionbasedlayoutconfiguration-bodysections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BodySectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.BodySectionConfiguration> BodySections { get; set; }
            /// <summary>
            /// HeaderSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutconfiguration.html#cfn-quicksight-template-sectionbasedlayoutconfiguration-headersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.HeaderFooterSectionConfiguration> HeaderSections { get; set; }
        }

        public class SectionBasedLayoutPaperCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHavePaperSize, IHavePaperOrientation
        {
            /// <summary>
            /// PaperMargin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-template-sectionbasedlayoutpapercanvassizeoptions-papermargin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.Spacing PaperMargin { get; set; }
            /// <summary>
            /// PaperSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-template-sectionbasedlayoutpapercanvassizeoptions-papersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PaperSize { get; set; }
            /// <summary>
            /// PaperOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-template-sectionbasedlayoutpapercanvassizeoptions-paperorientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PaperOrientation { get; set; }
        }

        public class SectionLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionlayoutconfiguration.html#cfn-quicksight-template-sectionlayoutconfiguration-freeformlayout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormSectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FreeFormSectionLayoutConfiguration FreeFormLayout { get; set; }
        }

        public class SectionPageBreakConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// After
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionpagebreakconfiguration.html#cfn-quicksight-template-sectionpagebreakconfiguration-after
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionAfterPageBreak
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SectionAfterPageBreak After { get; set; }
        }

        public class SectionStyle : Humidifier.Base.BaseSubResource, IHaveHeight
        {
            /// <summary>
            /// Padding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionstyle.html#cfn-quicksight-template-sectionstyle-padding
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.Spacing Padding { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sectionstyle.html#cfn-quicksight-template-sectionstyle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
        }

        public class SelectedSheetsFilterScopeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SheetVisualScopingConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-selectedsheetsfilterscopeconfiguration.html#cfn-quicksight-template-selectedsheetsfilterscopeconfiguration-sheetvisualscopingconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetVisualScopingConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetVisualScopingConfiguration> SheetVisualScopingConfigurations { get; set; }
        }

        public class SeriesItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-seriesitem.html#cfn-quicksight-template-seriesitem-fieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSeriesItem
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FieldSeriesItem FieldSeriesItem { get; set; }
            /// <summary>
            /// DataFieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-seriesitem.html#cfn-quicksight-template-seriesitem-datafieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataFieldSeriesItem
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataFieldSeriesItem DataFieldSeriesItem { get; set; }
        }

        public class SetParameterValueConfiguration : Humidifier.Base.BaseSubResource, IHaveDestinationParameterName
        {
            /// <summary>
            /// DestinationParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-setparametervalueconfiguration.html#cfn-quicksight-template-setparametervalueconfiguration-destinationparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationParameterName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-setparametervalueconfiguration.html#cfn-quicksight-template-setparametervalueconfiguration-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationParameterValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DestinationParameterValueConfiguration Value { get; set; }
        }

        public class ShapeConditionalFormat : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-shapeconditionalformat.html#cfn-quicksight-template-shapeconditionalformat-backgroundcolor
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class Sheet : Humidifier.Base.BaseSubResource, IHaveName, IHaveSheetId
        {
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheet.html#cfn-quicksight-template-sheet-sheetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// Images
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheet.html#cfn-quicksight-template-sheet-images
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetImage
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetImage> Images { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheet.html#cfn-quicksight-template-sheet-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SheetControlInfoIconLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveInfoIconText
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetcontrolinfoiconlabeloptions.html#cfn-quicksight-template-sheetcontrolinfoiconlabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// InfoIconText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetcontrolinfoiconlabeloptions.html#cfn-quicksight-template-sheetcontrolinfoiconlabeloptions-infoicontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InfoIconText { get; set; }
        }

        public class SheetControlLayout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetcontrollayout.html#cfn-quicksight-template-sheetcontrollayout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetControlLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlLayoutConfiguration Configuration { get; set; }
        }

        public class SheetControlLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetcontrollayoutconfiguration.html#cfn-quicksight-template-sheetcontrollayoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GridLayoutConfiguration GridLayout { get; set; }
        }

        public class SheetDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveTitle, IHaveContentType, IHaveSheetId
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ParameterControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-parametercontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterControl
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ParameterControl> ParameterControls { get; set; }
            /// <summary>
            /// TextBoxes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-textboxes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetTextBox
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetTextBox> TextBoxes { get; set; }
            /// <summary>
            /// Layouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-layouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Layout
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.Layout> Layouts { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-sheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// FilterControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-filtercontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterControl
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FilterControl> FilterControls { get; set; }
            /// <summary>
            /// Images
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-images
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetImage
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetImage> Images { get; set; }
            /// <summary>
            /// SheetControlLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-sheetcontrollayouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetControlLayout
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetControlLayout> SheetControlLayouts { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// Visuals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-visuals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Visual
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.Visual> Visuals { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetdefinition.html#cfn-quicksight-template-sheetdefinition-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SheetElementConfigurationOverrides : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetelementconfigurationoverrides.html#cfn-quicksight-template-sheetelementconfigurationoverrides-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SheetElementRenderingRule : Humidifier.Base.BaseSubResource, IHaveExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetelementrenderingrule.html#cfn-quicksight-template-sheetelementrenderingrule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// ConfigurationOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetelementrenderingrule.html#cfn-quicksight-template-sheetelementrenderingrule-configurationoverrides
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetElementConfigurationOverrides
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetElementConfigurationOverrides ConfigurationOverrides { get; set; }
        }

        public class SheetImage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImageCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ImageCustomAction> Actions { get; set; }
            /// <summary>
            /// SheetImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-sheetimageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetImageId { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageTooltipConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetImageTooltipConfiguration Tooltip { get; set; }
            /// <summary>
            /// Scaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-scaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageScalingConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetImageScalingConfiguration Scaling { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageInteractionOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ImageInteractionOptions Interactions { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetImageSource
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetImageSource Source { get; set; }
            /// <summary>
            /// ImageContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimage.html#cfn-quicksight-template-sheetimage-imagecontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageContentAltText { get; set; }
        }

        public class SheetImageScalingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScalingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimagescalingconfiguration.html#cfn-quicksight-template-sheetimagescalingconfiguration-scalingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScalingType { get; set; }
        }

        public class SheetImageSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SheetImageStaticFileSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimagesource.html#cfn-quicksight-template-sheetimagesource-sheetimagestaticfilesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageStaticFileSource
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetImageStaticFileSource SheetImageStaticFileSource { get; set; }
        }

        public class SheetImageStaticFileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimagestaticfilesource.html#cfn-quicksight-template-sheetimagestaticfilesource-staticfileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticFileId { get; set; }
        }

        public class SheetImageTooltipConfiguration : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimagetooltipconfiguration.html#cfn-quicksight-template-sheetimagetooltipconfiguration-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// TooltipText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimagetooltipconfiguration.html#cfn-quicksight-template-sheetimagetooltipconfiguration-tooltiptext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageTooltipText
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetImageTooltipText TooltipText { get; set; }
        }

        public class SheetImageTooltipText : Humidifier.Base.BaseSubResource, IHavePlainText
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetimagetooltiptext.html#cfn-quicksight-template-sheetimagetooltiptext-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlainText { get; set; }
        }

        public class SheetTextBox : Humidifier.Base.BaseSubResource, IHaveContent, IHaveSheetTextBoxId
        {
            /// <summary>
            /// SheetTextBoxId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheettextbox.html#cfn-quicksight-template-sheettextbox-sheettextboxid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetTextBoxId { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheettextbox.html#cfn-quicksight-template-sheettextbox-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
        }

        public class SheetVisualScopingConfiguration : Humidifier.Base.BaseSubResource, IHaveScope, IHaveSheetId, IHaveVisualIds
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetvisualscopingconfiguration.html#cfn-quicksight-template-sheetvisualscopingconfiguration-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetvisualscopingconfiguration.html#cfn-quicksight-template-sheetvisualscopingconfiguration-sheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// VisualIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-sheetvisualscopingconfiguration.html#cfn-quicksight-template-sheetvisualscopingconfiguration-visualids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic VisualIds { get; set; }
        }

        public class ShortFormatText : Humidifier.Base.BaseSubResource, IHaveRichText, IHavePlainText
        {
            /// <summary>
            /// RichText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-shortformattext.html#cfn-quicksight-template-shortformattext-richtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RichText { get; set; }
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-shortformattext.html#cfn-quicksight-template-shortformattext-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlainText { get; set; }
        }

        public class SimpleClusterMarker : Humidifier.Base.BaseSubResource, IHaveColor
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-simpleclustermarker.html#cfn-quicksight-template-simpleclustermarker-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class SingleAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// YAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-singleaxisoptions.html#cfn-quicksight-template-singleaxisoptions-yaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: YAxisOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.YAxisOptions YAxisOptions { get; set; }
        }

        public class SliderControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-slidercontroldisplayoptions.html#cfn-quicksight-template-slidercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-slidercontroldisplayoptions.html#cfn-quicksight-template-slidercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class SmallMultiplesAxisProperties : Humidifier.Base.BaseSubResource, IHavePlacement, IHaveScale
        {
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesaxisproperties.html#cfn-quicksight-template-smallmultiplesaxisproperties-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesaxisproperties.html#cfn-quicksight-template-smallmultiplesaxisproperties-scale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scale { get; set; }
        }

        public class SmallMultiplesOptions : Humidifier.Base.BaseSubResource, IHaveMaxVisibleRows, IHaveMaxVisibleColumns
        {
            /// <summary>
            /// MaxVisibleRows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesoptions.html#cfn-quicksight-template-smallmultiplesoptions-maxvisiblerows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxVisibleRows { get; set; }
            /// <summary>
            /// PanelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesoptions.html#cfn-quicksight-template-smallmultiplesoptions-panelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PanelConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PanelConfiguration PanelConfiguration { get; set; }
            /// <summary>
            /// MaxVisibleColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesoptions.html#cfn-quicksight-template-smallmultiplesoptions-maxvisiblecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxVisibleColumns { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesoptions.html#cfn-quicksight-template-smallmultiplesoptions-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SmallMultiplesAxisProperties XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-smallmultiplesoptions.html#cfn-quicksight-template-smallmultiplesoptions-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SmallMultiplesAxisProperties YAxis { get; set; }
        }

        public class Spacing : Humidifier.Base.BaseSubResource, IHaveLeft, IHaveTop, IHaveRight, IHaveBottom
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-spacing.html#cfn-quicksight-template-spacing-left
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-spacing.html#cfn-quicksight-template-spacing-top
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Top { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-spacing.html#cfn-quicksight-template-spacing-right
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-spacing.html#cfn-quicksight-template-spacing-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bottom { get; set; }
        }

        public class StringDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues, IHaveQuickSightTemplateTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringdefaultvalues.html#cfn-quicksight-template-stringdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringdefaultvalues.html#cfn-quicksight-template-stringdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class StringFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesNullValueFormatConfigurationNullValueFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringformatconfiguration.html#cfn-quicksight-template-stringformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringformatconfiguration.html#cfn-quicksight-template-stringformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
        }

        public class StringParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringparameterdeclaration.html#cfn-quicksight-template-stringparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringparameterdeclaration.html#cfn-quicksight-template-stringparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDefaultValues
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.StringDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringparameterdeclaration.html#cfn-quicksight-template-stringparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringparameterdeclaration.html#cfn-quicksight-template-stringparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringValueWhenUnsetConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.StringValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringparameterdeclaration.html#cfn-quicksight-template-stringparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StringValueWhenUnsetConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomValue, IHaveValueWhenUnsetOption
        {
            /// <summary>
            /// ValueWhenUnsetOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringvaluewhenunsetconfiguration.html#cfn-quicksight-template-stringvaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-stringvaluewhenunsetconfiguration.html#cfn-quicksight-template-stringvaluewhenunsetconfiguration-customvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomValue { get; set; }
        }

        public class SubtotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHaveFieldLevel, IHaveQuickSightTemplateTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// FieldLevelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-fieldleveloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldSubtotalOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.PivotTableFieldSubtotalOptions> FieldLevelOptions { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// FieldLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-fieldlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldLevel { get; set; }
            /// <summary>
            /// MetricHeaderCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-metricheadercellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
            /// <summary>
            /// StyleTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-subtotaloptions.html#cfn-quicksight-template-subtotaloptions-styletargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableStyleTarget
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TableStyleTarget> StyleTargets { get; set; }
        }

        public class TableAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableaggregatedfieldwells.html#cfn-quicksight-template-tableaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableaggregatedfieldwells.html#cfn-quicksight-template-tableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class TableBorderOptions : Humidifier.Base.BaseSubResource, IHaveColor, IHaveStyle, IHaveThickness
        {
            /// <summary>
            /// Thickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableborderoptions.html#cfn-quicksight-template-tableborderoptions-thickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Thickness { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableborderoptions.html#cfn-quicksight-template-tableborderoptions-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableborderoptions.html#cfn-quicksight-template-tableborderoptions-style
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Style { get; set; }
        }

        public class TableCellConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellconditionalformatting.html#cfn-quicksight-template-tablecellconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellconditionalformatting.html#cfn-quicksight-template-tablecellconditionalformatting-textformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextConditionalFormat
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextConditionalFormat TextFormat { get; set; }
        }

        public class TableCellImageSizingConfiguration : Humidifier.Base.BaseSubResource, IHaveTableCellImageScalingConfiguration
        {
            /// <summary>
            /// TableCellImageScalingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellimagesizingconfiguration.html#cfn-quicksight-template-tablecellimagesizingconfiguration-tablecellimagescalingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableCellImageScalingConfiguration { get; set; }
        }

        public class TableCellStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveBackgroundColor, IHaveHorizontalTextAlignment, IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration, IHaveVerticalTextAlignment, IHaveTextWrap
        {
            /// <summary>
            /// VerticalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-verticaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalTextAlignment { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalTableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GlobalTableBorderOptions Border { get; set; }
            /// <summary>
            /// TextWrap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-textwrap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextWrap { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-horizontaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalTextAlignment { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablecellstyle.html#cfn-quicksight-template-tablecellstyle-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class TableConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconditionalformatting.html#cfn-quicksight-template-tableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class TableConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Row
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconditionalformattingoption.html#cfn-quicksight-template-tableconditionalformattingoption-row
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableRowConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableRowConditionalFormatting Row { get; set; }
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconditionalformattingoption.html#cfn-quicksight-template-tableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellConditionalFormatting Cell { get; set; }
        }

        public class TableConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePaginatedReportOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableOptions TableOptions { get; set; }
            /// <summary>
            /// TableInlineVisualizations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-tableinlinevisualizations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableInlineVisualization
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TableInlineVisualization> TableInlineVisualizations { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableconfiguration.html#cfn-quicksight-template-tableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TotalOptions TotalOptions { get; set; }
        }

        public class TableFieldCustomIconContent : Humidifier.Base.BaseSubResource, IHaveIcon
        {
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldcustomiconcontent.html#cfn-quicksight-template-tablefieldcustomiconcontent-icon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Icon { get; set; }
        }

        public class TableFieldCustomTextContent : Humidifier.Base.BaseSubResource, IHaveValue, IHaveQuickSightTemplateTypesFontConfigurationFontConfiguration
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldcustomtextcontent.html#cfn-quicksight-template-tablefieldcustomtextcontent-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldcustomtextcontent.html#cfn-quicksight-template-tablefieldcustomtextcontent-fontconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class TableFieldImageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SizingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldimageconfiguration.html#cfn-quicksight-template-tablefieldimageconfiguration-sizingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellImageSizingConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellImageSizingConfiguration SizingOptions { get; set; }
        }

        public class TableFieldLinkConfiguration : Humidifier.Base.BaseSubResource, IHaveTarget
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldlinkconfiguration.html#cfn-quicksight-template-tablefieldlinkconfiguration-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldlinkconfiguration.html#cfn-quicksight-template-tablefieldlinkconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TableFieldLinkContentConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldLinkContentConfiguration Content { get; set; }
        }

        public class TableFieldLinkContentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomIconContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldlinkcontentconfiguration.html#cfn-quicksight-template-tablefieldlinkcontentconfiguration-customiconcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomIconContent
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldCustomIconContent CustomIconContent { get; set; }
            /// <summary>
            /// CustomTextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldlinkcontentconfiguration.html#cfn-quicksight-template-tablefieldlinkcontentconfiguration-customtextcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomTextContent
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldCustomTextContent CustomTextContent { get; set; }
        }

        public class TableFieldOption : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveCustomLabel, IHaveWidth
        {
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoption.html#cfn-quicksight-template-tablefieldoption-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// URLStyling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoption.html#cfn-quicksight-template-tablefieldoption-urlstyling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldURLConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldURLConfiguration URLStyling { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoption.html#cfn-quicksight-template-tablefieldoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoption.html#cfn-quicksight-template-tablefieldoption-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoption.html#cfn-quicksight-template-tablefieldoption-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class TableFieldOptions : Humidifier.Base.BaseSubResource, IHaveOrder
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoptions.html#cfn-quicksight-template-tablefieldoptions-order
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Order { get; set; }
            /// <summary>
            /// PinnedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoptions.html#cfn-quicksight-template-tablefieldoptions-pinnedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePinnedFieldOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TablePinnedFieldOptions PinnedFieldOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldoptions.html#cfn-quicksight-template-tablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableFieldOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class TableFieldURLConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldurlconfiguration.html#cfn-quicksight-template-tablefieldurlconfiguration-linkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldLinkConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldLinkConfiguration LinkConfiguration { get; set; }
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldurlconfiguration.html#cfn-quicksight-template-tablefieldurlconfiguration-imageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldImageConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableFieldImageConfiguration ImageConfiguration { get; set; }
        }

        public class TableFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TableUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldwells.html#cfn-quicksight-template-tablefieldwells-tableunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableUnaggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableUnaggregatedFieldWells TableUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// TableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablefieldwells.html#cfn-quicksight-template-tablefieldwells-tableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableAggregatedFieldWells TableAggregatedFieldWells { get; set; }
        }

        public class TableInlineVisualization : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataBars
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableinlinevisualization.html#cfn-quicksight-template-tableinlinevisualization-databars
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataBarsOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataBarsOptions DataBars { get; set; }
        }

        public class TableOptions : Humidifier.Base.BaseSubResource, IHaveOrientation
        {
            /// <summary>
            /// HeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableoptions.html#cfn-quicksight-template-tableoptions-headerstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle HeaderStyle { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableoptions.html#cfn-quicksight-template-tableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableoptions.html#cfn-quicksight-template-tableoptions-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Orientation { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableoptions.html#cfn-quicksight-template-tableoptions-rowalternatecoloroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowAlternateColorOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class TablePaginatedReportOptions : Humidifier.Base.BaseSubResource, IHaveOverflowColumnHeaderVisibility, IHaveVerticalOverflowVisibility
        {
            /// <summary>
            /// OverflowColumnHeaderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablepaginatedreportoptions.html#cfn-quicksight-template-tablepaginatedreportoptions-overflowcolumnheadervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OverflowColumnHeaderVisibility { get; set; }
            /// <summary>
            /// VerticalOverflowVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablepaginatedreportoptions.html#cfn-quicksight-template-tablepaginatedreportoptions-verticaloverflowvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic VerticalOverflowVisibility { get; set; }
        }

        public class TablePinnedFieldOptions : Humidifier.Base.BaseSubResource, IHavePinnedLeftFields
        {
            /// <summary>
            /// PinnedLeftFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablepinnedfieldoptions.html#cfn-quicksight-template-tablepinnedfieldoptions-pinnedleftfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PinnedLeftFields { get; set; }
        }

        public class TableRowConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor, IHaveQuickSightTemplateTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablerowconditionalformatting.html#cfn-quicksight-template-tablerowconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablerowconditionalformatting.html#cfn-quicksight-template-tablerowconditionalformatting-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TableSideBorderOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesideborderoptions.html#cfn-quicksight-template-tablesideborderoptions-left
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesideborderoptions.html#cfn-quicksight-template-tablesideborderoptions-top
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions Top { get; set; }
            /// <summary>
            /// InnerHorizontal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesideborderoptions.html#cfn-quicksight-template-tablesideborderoptions-innerhorizontal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions InnerHorizontal { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesideborderoptions.html#cfn-quicksight-template-tablesideborderoptions-right
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesideborderoptions.html#cfn-quicksight-template-tablesideborderoptions-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions Bottom { get; set; }
            /// <summary>
            /// InnerVertical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesideborderoptions.html#cfn-quicksight-template-tablesideborderoptions-innervertical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableBorderOptions InnerVertical { get; set; }
        }

        public class TableSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesortconfiguration.html#cfn-quicksight-template-tablesortconfiguration-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> RowSort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablesortconfiguration.html#cfn-quicksight-template-tablesortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class TableStyleTarget : Humidifier.Base.BaseSubResource, IHaveCellType
        {
            /// <summary>
            /// CellType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablestyletarget.html#cfn-quicksight-template-tablestyletarget-celltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CellType { get; set; }
        }

        public class TableUnaggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tableunaggregatedfieldwells.html#cfn-quicksight-template-tableunaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.UnaggregatedField> Values { get; set; }
        }

        public class TableVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tablevisual.html#cfn-quicksight-template-tablevisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class TemplateError : Humidifier.Base.BaseSubResource, IHaveType, IHaveMessage
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateerror.html#cfn-quicksight-template-templateerror-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateerror.html#cfn-quicksight-template-templateerror-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// ViolatedEntities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateerror.html#cfn-quicksight-template-templateerror-violatedentities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Entity
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.Entity> ViolatedEntities { get; set; }
        }

        public class TemplateSourceAnalysis : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// DataSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceanalysis.html#cfn-quicksight-template-templatesourceanalysis-datasetreferences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetReference
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataSetReference> DataSetReferences { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceanalysis.html#cfn-quicksight-template-templatesourceanalysis-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class TemplateSourceEntity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceAnalysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceentity.html#cfn-quicksight-template-templatesourceentity-sourceanalysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateSourceAnalysis
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TemplateSourceAnalysis SourceAnalysis { get; set; }
            /// <summary>
            /// SourceTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceentity.html#cfn-quicksight-template-templatesourceentity-sourcetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateSourceTemplate
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate SourceTemplate { get; set; }
        }

        public class TemplateSourceTemplate : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourcetemplate.html#cfn-quicksight-template-templatesourcetemplate-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class TemplateVersion : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveStatus, IHaveCreatedTime, IHaveThemeArn, IHaveVersionNumber
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Errors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-errors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TemplateError
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TemplateError> Errors { get; set; }
            /// <summary>
            /// CreatedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-createdtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedTime { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ThemeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-themearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThemeArn { get; set; }
            /// <summary>
            /// DataSetConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-datasetconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataSetConfiguration> DataSetConfigurations { get; set; }
            /// <summary>
            /// SourceEntityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-sourceentityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceEntityArn { get; set; }
            /// <summary>
            /// VersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-versionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic VersionNumber { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html#cfn-quicksight-template-templateversion-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Sheet
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.Sheet> Sheets { get; set; }
        }

        public class TemplateVersionDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AssetOptions Options { get; set; }
            /// <summary>
            /// FilterGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-filtergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterGroup
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FilterGroup> FilterGroups { get; set; }
            /// <summary>
            /// QueryExecutionOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-queryexecutionoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryExecutionOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.QueryExecutionOptions QueryExecutionOptions { get; set; }
            /// <summary>
            /// CalculatedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-calculatedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.CalculatedField> CalculatedFields { get; set; }
            /// <summary>
            /// DataSetConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-datasetconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataSetConfiguration> DataSetConfigurations { get; set; }
            /// <summary>
            /// ColumnConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-columnconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnConfiguration> ColumnConfigurations { get; set; }
            /// <summary>
            /// AnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-analysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisDefaults
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AnalysisDefaults AnalysisDefaults { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetDefinition
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.SheetDefinition> Sheets { get; set; }
            /// <summary>
            /// ParameterDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversiondefinition.html#cfn-quicksight-template-templateversiondefinition-parameterdeclarations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterDeclaration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ParameterDeclaration> ParameterDeclarations { get; set; }
        }

        public class TextAreaControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textareacontroldisplayoptions.html#cfn-quicksight-template-textareacontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textareacontroldisplayoptions.html#cfn-quicksight-template-textareacontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textareacontroldisplayoptions.html#cfn-quicksight-template-textareacontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class TextConditionalFormat : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesConditionalFormattingColorTextColor, IHaveQuickSightTemplateTypesConditionalFormattingIconIcon, IHaveQuickSightTemplateTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textconditionalformat.html#cfn-quicksight-template-textconditionalformat-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textconditionalformat.html#cfn-quicksight-template-textconditionalformat-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingIcon Icon { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textconditionalformat.html#cfn-quicksight-template-textconditionalformat-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TextControlPlaceholderOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textcontrolplaceholderoptions.html#cfn-quicksight-template-textcontrolplaceholderoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class TextFieldControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLabelOptionsTitleOptions, IHaveQuickSightTemplateTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textfieldcontroldisplayoptions.html#cfn-quicksight-template-textfieldcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textfieldcontroldisplayoptions.html#cfn-quicksight-template-textfieldcontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-textfieldcontroldisplayoptions.html#cfn-quicksight-template-textfieldcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ThousandSeparatorOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveSymbol
        {
            /// <summary>
            /// Symbol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-thousandseparatoroptions.html#cfn-quicksight-template-thousandseparatoroptions-symbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Symbol { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-thousandseparatoroptions.html#cfn-quicksight-template-thousandseparatoroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class TimeBasedForecastProperties : Humidifier.Base.BaseSubResource, IHavePeriodsBackward, IHavePeriodsForward, IHavePredictionInterval, IHaveSeasonality, IHaveUpperBoundary, IHaveLowerBoundary
        {
            /// <summary>
            /// PeriodsBackward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timebasedforecastproperties.html#cfn-quicksight-template-timebasedforecastproperties-periodsbackward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsBackward { get; set; }
            /// <summary>
            /// PeriodsForward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timebasedforecastproperties.html#cfn-quicksight-template-timebasedforecastproperties-periodsforward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsForward { get; set; }
            /// <summary>
            /// PredictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timebasedforecastproperties.html#cfn-quicksight-template-timebasedforecastproperties-predictioninterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PredictionInterval { get; set; }
            /// <summary>
            /// Seasonality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timebasedforecastproperties.html#cfn-quicksight-template-timebasedforecastproperties-seasonality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Seasonality { get; set; }
            /// <summary>
            /// UpperBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timebasedforecastproperties.html#cfn-quicksight-template-timebasedforecastproperties-upperboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperBoundary { get; set; }
            /// <summary>
            /// LowerBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timebasedforecastproperties.html#cfn-quicksight-template-timebasedforecastproperties-lowerboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LowerBoundary { get; set; }
        }

        public class TimeEqualityFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveQuickSightTemplateTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timeequalityfilter.html#cfn-quicksight-template-timeequalityfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TimeRangeDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveTimeGranularity, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveRangeMinimum, IHaveRangeMaximum
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangedrilldownfilter.html#cfn-quicksight-template-timerangedrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangedrilldownfilter.html#cfn-quicksight-template-timerangedrilldownfilter-rangeminimum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeMinimum { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangedrilldownfilter.html#cfn-quicksight-template-timerangedrilldownfilter-timegranularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangedrilldownfilter.html#cfn-quicksight-template-timerangedrilldownfilter-rangemaximum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeMaximum { get; set; }
        }

        public class TimeRangeFilter : Humidifier.Base.BaseSubResource, IHaveTimeGranularity, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveIncludeMaximum, IHaveIncludeMinimum
        {
            /// <summary>
            /// RangeMinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-rangeminimumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TimeRangeFilterValue RangeMinimumValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-rangemaximumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TimeRangeFilterValue RangeMaximumValue { get; set; }
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
            /// <summary>
            /// ExcludePeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefilter.html#cfn-quicksight-template-timerangefilter-excludeperiodconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExcludePeriodConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class TimeRangeFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue, IHaveParameter, IHaveQuickSightTemplateTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefiltervalue.html#cfn-quicksight-template-timerangefiltervalue-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefiltervalue.html#cfn-quicksight-template-timerangefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticValue { get; set; }
            /// <summary>
            /// Parameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-timerangefiltervalue.html#cfn-quicksight-template-timerangefiltervalue-parameter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Parameter { get; set; }
        }

        public class TooltipItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tooltipitem.html#cfn-quicksight-template-tooltipitem-fieldtooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldTooltipItem
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FieldTooltipItem FieldTooltipItem { get; set; }
            /// <summary>
            /// ColumnTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tooltipitem.html#cfn-quicksight-template-tooltipitem-columntooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnTooltipItem
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnTooltipItem ColumnTooltipItem { get; set; }
        }

        public class TooltipOptions : Humidifier.Base.BaseSubResource, IHaveTooltipVisibility, IHaveSelectedTooltipType
        {
            /// <summary>
            /// SelectedTooltipType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tooltipoptions.html#cfn-quicksight-template-tooltipoptions-selectedtooltiptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedTooltipType { get; set; }
            /// <summary>
            /// TooltipVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tooltipoptions.html#cfn-quicksight-template-tooltipoptions-tooltipvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TooltipVisibility { get; set; }
            /// <summary>
            /// FieldBasedTooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-tooltipoptions.html#cfn-quicksight-template-tooltipoptions-fieldbasedtooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldBasedTooltip
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FieldBasedTooltip FieldBasedTooltip { get; set; }
        }

        public class TopBottomFilter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightTemplateTypesColumnIdentifierColumn, IHaveFilterId, IHaveLimit, IHaveQuickSightTemplateTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// AggregationSortConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-aggregationsortconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationSortConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.AggregationSortConfiguration> AggregationSortConfigurations { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Limit { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomfilter.html#cfn-quicksight-template-topbottomfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TopBottomMoversComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveQuickSightTemplateTypesDimensionFieldTime, IHaveSortOrder, IHaveMoverSize, IHaveQuickSightTemplateTypesDimensionFieldCategory
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Category { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-sortorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortOrder { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Time { get; set; }
            /// <summary>
            /// MoverSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-moversize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MoverSize { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottommoverscomputation.html#cfn-quicksight-template-topbottommoverscomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TopBottomRankedComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue, IHaveResultSize, IHaveQuickSightTemplateTypesDimensionFieldCategory
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomrankedcomputation.html#cfn-quicksight-template-topbottomrankedcomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomrankedcomputation.html#cfn-quicksight-template-topbottomrankedcomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Category { get; set; }
            /// <summary>
            /// ResultSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomrankedcomputation.html#cfn-quicksight-template-topbottomrankedcomputation-resultsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResultSize { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomrankedcomputation.html#cfn-quicksight-template-topbottomrankedcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomrankedcomputation.html#cfn-quicksight-template-topbottomrankedcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-topbottomrankedcomputation.html#cfn-quicksight-template-topbottomrankedcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TotalAggregationComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesMeasureFieldValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totalaggregationcomputation.html#cfn-quicksight-template-totalaggregationcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.MeasureField Value { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totalaggregationcomputation.html#cfn-quicksight-template-totalaggregationcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totalaggregationcomputation.html#cfn-quicksight-template-totalaggregationcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TotalAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleTotalAggregationFunction
        {
            /// <summary>
            /// SimpleTotalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totalaggregationfunction.html#cfn-quicksight-template-totalaggregationfunction-simpletotalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleTotalAggregationFunction { get; set; }
        }

        public class TotalAggregationOption : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// TotalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totalaggregationoption.html#cfn-quicksight-template-totalaggregationoption-totalaggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TotalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TotalAggregationFunction TotalAggregationFunction { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totalaggregationoption.html#cfn-quicksight-template-totalaggregationoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class TotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHavePlacement, IHaveScrollStatus, IHaveQuickSightTemplateTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totaloptions.html#cfn-quicksight-template-totaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totaloptions.html#cfn-quicksight-template-totaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ScrollStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totaloptions.html#cfn-quicksight-template-totaloptions-scrollstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScrollStatus { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totaloptions.html#cfn-quicksight-template-totaloptions-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totaloptions.html#cfn-quicksight-template-totaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-totaloptions.html#cfn-quicksight-template-totaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
        }

        public class TreeMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sizes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapaggregatedfieldwells.html#cfn-quicksight-template-treemapaggregatedfieldwells-sizes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Sizes { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapaggregatedfieldwells.html#cfn-quicksight-template-treemapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Colors { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapaggregatedfieldwells.html#cfn-quicksight-template-treemapaggregatedfieldwells-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Groups { get; set; }
        }

        public class TreeMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesTooltipOptionsTooltip, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveQuickSightTemplateTypesChartAxisLabelOptionsColorLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TreeMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// SizeLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-sizelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions SizeLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TreeMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColorScale ColorScale { get; set; }
            /// <summary>
            /// GroupLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapconfiguration.html#cfn-quicksight-template-treemapconfiguration-grouplabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions GroupLabelOptions { get; set; }
        }

        public class TreeMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreeMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapfieldwells.html#cfn-quicksight-template-treemapfieldwells-treemapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TreeMapAggregatedFieldWells TreeMapAggregatedFieldWells { get; set; }
        }

        public class TreeMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreeMapSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapsortconfiguration.html#cfn-quicksight-template-treemapsortconfiguration-treemapsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> TreeMapSort { get; set; }
            /// <summary>
            /// TreeMapGroupItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapsortconfiguration.html#cfn-quicksight-template-treemapsortconfiguration-treemapgroupitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration TreeMapGroupItemsLimitConfiguration { get; set; }
        }

        public class TreeMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TreeMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-treemapvisual.html#cfn-quicksight-template-treemapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class TrendArrowOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-trendarrowoptions.html#cfn-quicksight-template-trendarrowoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class UnaggregatedField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightTemplateTypesColumnIdentifierColumn
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-unaggregatedfield.html#cfn-quicksight-template-unaggregatedfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-unaggregatedfield.html#cfn-quicksight-template-unaggregatedfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-unaggregatedfield.html#cfn-quicksight-template-unaggregatedfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class UniqueValuesComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightTemplateTypesDimensionFieldCategory
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-uniquevaluescomputation.html#cfn-quicksight-template-uniquevaluescomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DimensionField Category { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-uniquevaluescomputation.html#cfn-quicksight-template-uniquevaluescomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-uniquevaluescomputation.html#cfn-quicksight-template-uniquevaluescomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ValidationStrategy : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-validationstrategy.html#cfn-quicksight-template-validationstrategy-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class VisibleRangeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PercentRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visiblerangeoptions.html#cfn-quicksight-template-visiblerangeoptions-percentrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentVisibleRange
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PercentVisibleRange PercentRange { get; set; }
        }

        public class Visual : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunnelChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-funnelchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FunnelChartVisual FunnelChartVisual { get; set; }
            /// <summary>
            /// FilledMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-filledmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.FilledMapVisual FilledMapVisual { get; set; }
            /// <summary>
            /// BoxPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-boxplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BoxPlotVisual BoxPlotVisual { get; set; }
            /// <summary>
            /// WaterfallVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-waterfallvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallVisual WaterfallVisual { get; set; }
            /// <summary>
            /// CustomContentVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-customcontentvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomContentVisual CustomContentVisual { get; set; }
            /// <summary>
            /// PieChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-piechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PieChartVisual PieChartVisual { get; set; }
            /// <summary>
            /// KPIVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-kpivisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.KPIVisual KPIVisual { get; set; }
            /// <summary>
            /// HistogramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-histogramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HistogramVisual HistogramVisual { get; set; }
            /// <summary>
            /// PluginVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-pluginvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PluginVisual PluginVisual { get; set; }
            /// <summary>
            /// GeospatialMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-geospatialmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GeospatialMapVisual GeospatialMapVisual { get; set; }
            /// <summary>
            /// TableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-tablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TableVisual TableVisual { get; set; }
            /// <summary>
            /// PivotTableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-pivottablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.PivotTableVisual PivotTableVisual { get; set; }
            /// <summary>
            /// ScatterPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-scatterplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ScatterPlotVisual ScatterPlotVisual { get; set; }
            /// <summary>
            /// RadarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-radarchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.RadarChartVisual RadarChartVisual { get; set; }
            /// <summary>
            /// BarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-barchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.BarChartVisual BarChartVisual { get; set; }
            /// <summary>
            /// HeatMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-heatmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.HeatMapVisual HeatMapVisual { get; set; }
            /// <summary>
            /// TreeMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-treemapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.TreeMapVisual TreeMapVisual { get; set; }
            /// <summary>
            /// ComboChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-combochartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ComboChartVisual ComboChartVisual { get; set; }
            /// <summary>
            /// WordCloudVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-wordcloudvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WordCloudVisual WordCloudVisual { get; set; }
            /// <summary>
            /// InsightVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-insightvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.InsightVisual InsightVisual { get; set; }
            /// <summary>
            /// SankeyDiagramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-sankeydiagramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.SankeyDiagramVisual SankeyDiagramVisual { get; set; }
            /// <summary>
            /// GaugeChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-gaugechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.GaugeChartVisual GaugeChartVisual { get; set; }
            /// <summary>
            /// LineChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-linechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LineChartVisual LineChartVisual { get; set; }
            /// <summary>
            /// EmptyVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visual.html#cfn-quicksight-template-visual-emptyvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyVisual
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.EmptyVisual EmptyVisual { get; set; }
        }

        public class VisualCustomAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveTrigger, IHaveCustomActionId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomaction.html#cfn-quicksight-template-visualcustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomaction.html#cfn-quicksight-template-visualcustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomaction.html#cfn-quicksight-template-visualcustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomaction.html#cfn-quicksight-template-visualcustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomaction.html#cfn-quicksight-template-visualcustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomActionOperation
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomActionOperation> ActionOperations { get; set; }
        }

        public class VisualCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomactionoperation.html#cfn-quicksight-template-visualcustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomactionoperation.html#cfn-quicksight-template-visualcustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomactionoperation.html#cfn-quicksight-template-visualcustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualcustomactionoperation.html#cfn-quicksight-template-visualcustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class VisualPalette : Humidifier.Base.BaseSubResource, IHaveChartColor
        {
            /// <summary>
            /// ChartColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualpalette.html#cfn-quicksight-template-visualpalette-chartcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChartColor { get; set; }
            /// <summary>
            /// ColorMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualpalette.html#cfn-quicksight-template-visualpalette-colormap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathColor
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DataPathColor> ColorMap { get; set; }
        }

        public class VisualSubtitleLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualsubtitlelabeloptions.html#cfn-quicksight-template-visualsubtitlelabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FormatText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualsubtitlelabeloptions.html#cfn-quicksight-template-visualsubtitlelabeloptions-formattext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LongFormatText
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LongFormatText FormatText { get; set; }
        }

        public class VisualTitleLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualtitlelabeloptions.html#cfn-quicksight-template-visualtitlelabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FormatText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-visualtitlelabeloptions.html#cfn-quicksight-template-visualtitlelabeloptions-formattext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShortFormatText
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ShortFormatText FormatText { get; set; }
        }

        public class WaterfallChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Categories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartaggregatedfieldwells.html#cfn-quicksight-template-waterfallchartaggregatedfieldwells-categories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Categories { get; set; }
            /// <summary>
            /// Breakdowns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartaggregatedfieldwells.html#cfn-quicksight-template-waterfallchartaggregatedfieldwells-breakdowns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> Breakdowns { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartaggregatedfieldwells.html#cfn-quicksight-template-waterfallchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Values { get; set; }
        }

        public class WaterfallChartColorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartcolorconfiguration.html#cfn-quicksight-template-waterfallchartcolorconfiguration-groupcolorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartGroupColorConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartGroupColorConfiguration GroupColorConfiguration { get; set; }
        }

        public class WaterfallChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesLegendOptionsLegend, IHaveQuickSightTemplateTypesVisualPaletteVisualPalette, IHaveQuickSightTemplateTypesDataLabelOptionsDataLabels, IHaveQuickSightTemplateTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightTemplateTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// CategoryAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-categoryaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryAxisLabelOptions { get; set; }
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// WaterfallChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-waterfallchartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartOptions WaterfallChartOptions { get; set; }
            /// <summary>
            /// ColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-colorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartColorConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartColorConfiguration ColorConfiguration { get; set; }
            /// <summary>
            /// CategoryAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-categoryaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions CategoryAxisDisplayOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartconfiguration.html#cfn-quicksight-template-waterfallchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualPalette VisualPalette { get; set; }
        }

        public class WaterfallChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WaterfallChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartfieldwells.html#cfn-quicksight-template-waterfallchartfieldwells-waterfallchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartAggregatedFieldWells WaterfallChartAggregatedFieldWells { get; set; }
        }

        public class WaterfallChartGroupColorConfiguration : Humidifier.Base.BaseSubResource, IHaveNegativeBarColor, IHaveTotalBarColor, IHavePositiveBarColor
        {
            /// <summary>
            /// NegativeBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-template-waterfallchartgroupcolorconfiguration-negativebarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NegativeBarColor { get; set; }
            /// <summary>
            /// TotalBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-template-waterfallchartgroupcolorconfiguration-totalbarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalBarColor { get; set; }
            /// <summary>
            /// PositiveBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-template-waterfallchartgroupcolorconfiguration-positivebarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositiveBarColor { get; set; }
        }

        public class WaterfallChartOptions : Humidifier.Base.BaseSubResource, IHaveTotalBarLabel
        {
            /// <summary>
            /// TotalBarLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartoptions.html#cfn-quicksight-template-waterfallchartoptions-totalbarlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalBarLabel { get; set; }
        }

        public class WaterfallChartSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BreakdownItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartsortconfiguration.html#cfn-quicksight-template-waterfallchartsortconfiguration-breakdownitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration BreakdownItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallchartsortconfiguration.html#cfn-quicksight-template-waterfallchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class WaterfallVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WaterfallChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-waterfallvisual.html#cfn-quicksight-template-waterfallvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class WhatIfPointScenario : Humidifier.Base.BaseSubResource, IHaveValue, IHaveDate
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-whatifpointscenario.html#cfn-quicksight-template-whatifpointscenario-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Date
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-whatifpointscenario.html#cfn-quicksight-template-whatifpointscenario-date
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Date { get; set; }
        }

        public class WhatIfRangeScenario : Humidifier.Base.BaseSubResource, IHaveValue, IHaveEndDate, IHaveStartDate
        {
            /// <summary>
            /// StartDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-whatifrangescenario.html#cfn-quicksight-template-whatifrangescenario-startdate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartDate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-whatifrangescenario.html#cfn-quicksight-template-whatifrangescenario-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-whatifrangescenario.html#cfn-quicksight-template-whatifrangescenario-enddate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndDate { get; set; }
        }

        public class WordCloudAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudaggregatedfieldwells.html#cfn-quicksight-template-wordcloudaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudaggregatedfieldwells.html#cfn-quicksight-template-wordcloudaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.MeasureField> Size { get; set; }
        }

        public class WordCloudChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesChartAxisLabelOptionsCategoryLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudchartconfiguration.html#cfn-quicksight-template-wordcloudchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WordCloudSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudchartconfiguration.html#cfn-quicksight-template-wordcloudchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudchartconfiguration.html#cfn-quicksight-template-wordcloudchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WordCloudFieldWells FieldWells { get; set; }
            /// <summary>
            /// WordCloudOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudchartconfiguration.html#cfn-quicksight-template-wordcloudchartconfiguration-wordcloudoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WordCloudOptions WordCloudOptions { get; set; }
        }

        public class WordCloudFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WordCloudAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudfieldwells.html#cfn-quicksight-template-wordcloudfieldwells-wordcloudaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WordCloudAggregatedFieldWells WordCloudAggregatedFieldWells { get; set; }
        }

        public class WordCloudOptions : Humidifier.Base.BaseSubResource, IHaveWordOrientation, IHaveWordScaling, IHaveCloudLayout, IHaveMaximumStringLength, IHaveWordCasing, IHaveWordPadding
        {
            /// <summary>
            /// WordOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudoptions.html#cfn-quicksight-template-wordcloudoptions-wordorientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordOrientation { get; set; }
            /// <summary>
            /// WordScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudoptions.html#cfn-quicksight-template-wordcloudoptions-wordscaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordScaling { get; set; }
            /// <summary>
            /// CloudLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudoptions.html#cfn-quicksight-template-wordcloudoptions-cloudlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudLayout { get; set; }
            /// <summary>
            /// MaximumStringLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudoptions.html#cfn-quicksight-template-wordcloudoptions-maximumstringlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumStringLength { get; set; }
            /// <summary>
            /// WordCasing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudoptions.html#cfn-quicksight-template-wordcloudoptions-wordcasing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordCasing { get; set; }
            /// <summary>
            /// WordPadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudoptions.html#cfn-quicksight-template-wordcloudoptions-wordpadding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordPadding { get; set; }
        }

        public class WordCloudSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightTemplateTypesItemsLimitConfigurationCategoryItemsLimit
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudsortconfiguration.html#cfn-quicksight-template-wordcloudsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudsortconfiguration.html#cfn-quicksight-template-wordcloudsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class WordCloudVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightTemplateTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightTemplateTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudChartConfiguration
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.WordCloudChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.TemplateTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-wordcloudvisual.html#cfn-quicksight-template-wordcloudvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.TemplateTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class YAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-yaxisoptions.html#cfn-quicksight-template-yaxisoptions-yaxis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic YAxis { get; set; }
        }
    }
}