namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using DashboardTypes;

    public class Dashboard : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string LastPublishedTime =  "LastPublishedTime" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::QuickSight::Dashboard";
            }
        }

        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Parameters
        /// </summary>
        public Parameters Parameters { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionDescription { get; set; }
        /// <summary>
        /// SourceEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-sourceentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashboardSourceEntity
        /// </summary>
        public DashboardSourceEntity SourceEntity { get; set; }
        /// <summary>
        /// ThemeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-themearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThemeArn { get; set; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-definition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashboardVersionDefinition
        /// </summary>
        public DashboardVersionDefinition Definition { get; set; }
        /// <summary>
        /// ValidationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-validationstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ValidationStrategy
        /// </summary>
        public ValidationStrategy ValidationStrategy { get; set; }
        /// <summary>
        /// DashboardId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-dashboardid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DashboardId { get; set; }
        /// <summary>
        /// LinkSharingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-linksharingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LinkSharingConfiguration
        /// </summary>
        public LinkSharingConfiguration LinkSharingConfiguration { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
        /// <summary>
        /// DashboardPublishOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-dashboardpublishoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashboardPublishOptions
        /// </summary>
        public DashboardPublishOptions DashboardPublishOptions { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// LinkEntities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-linkentities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic LinkEntities { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DashboardTypes
    {
        public class AdHocFilteringOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-adhocfilteringoption.html#cfn-quicksight-dashboard-adhocfilteringoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class AggregationFunction
        {
            /// <summary>
            /// AttributeAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationfunction.html#cfn-quicksight-dashboard-aggregationfunction-attributeaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeAggregationFunction
            /// </summary>
            public AttributeAggregationFunction AttributeAggregationFunction { get; set; }
            /// <summary>
            /// DateAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationfunction.html#cfn-quicksight-dashboard-aggregationfunction-dateaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateAggregationFunction { get; set; }
            /// <summary>
            /// NumericalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationfunction.html#cfn-quicksight-dashboard-aggregationfunction-numericalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public NumericalAggregationFunction NumericalAggregationFunction { get; set; }
            /// <summary>
            /// CategoricalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationfunction.html#cfn-quicksight-dashboard-aggregationfunction-categoricalaggregationfunction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationsortconfiguration.html#cfn-quicksight-dashboard-aggregationsortconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortDirection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationsortconfiguration.html#cfn-quicksight-dashboard-aggregationsortconfiguration-sortdirection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortDirection { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationsortconfiguration.html#cfn-quicksight-dashboard-aggregationsortconfiguration-column
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-analysisdefaults.html#cfn-quicksight-dashboard-analysisdefaults-defaultnewsheetconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultNewSheetConfiguration
            /// </summary>
            public DefaultNewSheetConfiguration DefaultNewSheetConfiguration { get; set; }
        }

        public class AnchorDateConfiguration
        {
            /// <summary>
            /// AnchorOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-anchordateconfiguration.html#cfn-quicksight-dashboard-anchordateconfiguration-anchoroption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnchorOption { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-anchordateconfiguration.html#cfn-quicksight-dashboard-anchordateconfiguration-parametername
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcaxisconfiguration.html#cfn-quicksight-dashboard-arcaxisconfiguration-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisDisplayRange
            /// </summary>
            public ArcAxisDisplayRange Range { get; set; }
            /// <summary>
            /// ReserveRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcaxisconfiguration.html#cfn-quicksight-dashboard-arcaxisconfiguration-reserverange
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcaxisdisplayrange.html#cfn-quicksight-dashboard-arcaxisdisplayrange-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcaxisdisplayrange.html#cfn-quicksight-dashboard-arcaxisdisplayrange-max
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcconfiguration.html#cfn-quicksight-dashboard-arcconfiguration-arcangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ArcAngle { get; set; }
            /// <summary>
            /// ArcThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcconfiguration.html#cfn-quicksight-dashboard-arcconfiguration-arcthickness
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcoptions.html#cfn-quicksight-dashboard-arcoptions-arcthickness
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-assetoptions.html#cfn-quicksight-dashboard-assetoptions-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// WeekStart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-assetoptions.html#cfn-quicksight-dashboard-assetoptions-weekstart
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-attributeaggregationfunction.html#cfn-quicksight-dashboard-attributeaggregationfunction-simpleattributeaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleAttributeAggregation { get; set; }
            /// <summary>
            /// ValueForMultipleValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-attributeaggregationfunction.html#cfn-quicksight-dashboard-attributeaggregationfunction-valueformultiplevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdataoptions.html#cfn-quicksight-dashboard-axisdataoptions-dateaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateAxisOptions
            /// </summary>
            public DateAxisOptions DateAxisOptions { get; set; }
            /// <summary>
            /// NumericAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdataoptions.html#cfn-quicksight-dashboard-axisdataoptions-numericaxisoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayminmaxrange.html#cfn-quicksight-dashboard-axisdisplayminmaxrange-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayminmaxrange.html#cfn-quicksight-dashboard-axisdisplayminmaxrange-maximum
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-dataoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDataOptions
            /// </summary>
            public AxisDataOptions DataOptions { get; set; }
            /// <summary>
            /// TickLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-ticklabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisTickLabelOptions
            /// </summary>
            public AxisTickLabelOptions TickLabelOptions { get; set; }
            /// <summary>
            /// AxisOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-axisoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisOffset { get; set; }
            /// <summary>
            /// AxisLineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-axislinevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisLineVisibility { get; set; }
            /// <summary>
            /// GridLineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-gridlinevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GridLineVisibility { get; set; }
            /// <summary>
            /// ScrollbarOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-scrollbaroptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayrange.html#cfn-quicksight-dashboard-axisdisplayrange-datadriven
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic DataDriven { get; set; }
            /// <summary>
            /// MinMax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayrange.html#cfn-quicksight-dashboard-axisdisplayrange-minmax
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabeloptions.html#cfn-quicksight-dashboard-axislabeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ApplyTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabeloptions.html#cfn-quicksight-dashboard-axislabeloptions-applyto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLabelReferenceOptions
            /// </summary>
            public AxisLabelReferenceOptions ApplyTo { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabeloptions.html#cfn-quicksight-dashboard-axislabeloptions-fontconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabelreferenceoptions.html#cfn-quicksight-dashboard-axislabelreferenceoptions-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabelreferenceoptions.html#cfn-quicksight-dashboard-axislabelreferenceoptions-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislinearscale.html#cfn-quicksight-dashboard-axislinearscale-stepsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// StepCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislinearscale.html#cfn-quicksight-dashboard-axislinearscale-stepcount
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislogarithmicscale.html#cfn-quicksight-dashboard-axislogarithmicscale-base
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisscale.html#cfn-quicksight-dashboard-axisscale-logarithmic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLogarithmicScale
            /// </summary>
            public AxisLogarithmicScale Logarithmic { get; set; }
            /// <summary>
            /// Linear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisscale.html#cfn-quicksight-dashboard-axisscale-linear
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisticklabeloptions.html#cfn-quicksight-dashboard-axisticklabeloptions-rotationangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RotationAngle { get; set; }
            /// <summary>
            /// LabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisticklabeloptions.html#cfn-quicksight-dashboard-axisticklabeloptions-labeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-smallmultiples
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartSortConfiguration
            /// </summary>
            public BarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Orientation { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// BarsArrangement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-barsarrangement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BarsArrangement { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartFieldWells
            /// </summary>
            public BarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ValueAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-valueaxis
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartfieldwells.html#cfn-quicksight-dashboard-barchartfieldwells-barchartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-smallmultipleslimitconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartConfiguration
            /// </summary>
            public BarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bincountoptions.html#cfn-quicksight-dashboard-bincountoptions-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-binwidthoptions.html#cfn-quicksight-dashboard-binwidthoptions-bincountlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BinCountLimit { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-binwidthoptions.html#cfn-quicksight-dashboard-binwidthoptions-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BodySectionContent
            /// </summary>
            public BodySectionContent Content { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public SectionStyle Style { get; set; }
            /// <summary>
            /// PageBreakConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-pagebreakconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionPageBreakConfiguration
            /// </summary>
            public SectionPageBreakConfiguration PageBreakConfiguration { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-sectionid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectioncontent.html#cfn-quicksight-dashboard-bodysectioncontent-layout
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotaggregatedfieldwells.html#cfn-quicksight-dashboard-boxplotaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotaggregatedfieldwells.html#cfn-quicksight-dashboard-boxplotaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotSortConfiguration
            /// </summary>
            public BoxPlotSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotFieldWells
            /// </summary>
            public BoxPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// BoxPlotOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-boxplotoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotOptions
            /// </summary>
            public BoxPlotOptions BoxPlotOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-visualpalette
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotfieldwells.html#cfn-quicksight-dashboard-boxplotfieldwells-boxplotaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotoptions.html#cfn-quicksight-dashboard-boxplotoptions-styleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotStyleOptions
            /// </summary>
            public BoxPlotStyleOptions StyleOptions { get; set; }
            /// <summary>
            /// OutlierVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotoptions.html#cfn-quicksight-dashboard-boxplotoptions-outliervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutlierVisibility { get; set; }
            /// <summary>
            /// AllDataPointsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotoptions.html#cfn-quicksight-dashboard-boxplotoptions-alldatapointsvisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotsortconfiguration.html#cfn-quicksight-dashboard-boxplotsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotsortconfiguration.html#cfn-quicksight-dashboard-boxplotsortconfiguration-paginationconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotstyleoptions.html#cfn-quicksight-dashboard-boxplotstyleoptions-fillstyle
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotChartConfiguration
            /// </summary>
            public BoxPlotChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-calculatedfield.html#cfn-quicksight-dashboard-calculatedfield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-calculatedfield.html#cfn-quicksight-dashboard-calculatedfield-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-calculatedfield.html#cfn-quicksight-dashboard-calculatedfield-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-calculatedmeasurefield.html#cfn-quicksight-dashboard-calculatedmeasurefield-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-calculatedmeasurefield.html#cfn-quicksight-dashboard-calculatedmeasurefield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-cascadingcontrolconfiguration.html#cfn-quicksight-dashboard-cascadingcontrolconfiguration-sourcecontrols
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-cascadingcontrolsource.html#cfn-quicksight-dashboard-cascadingcontrolsource-sourcesheetcontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceSheetControlId { get; set; }
            /// <summary>
            /// ColumnToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-cascadingcontrolsource.html#cfn-quicksight-dashboard-cascadingcontrolsource-columntomatch
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricaldimensionfield.html#cfn-quicksight-dashboard-categoricaldimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricaldimensionfield.html#cfn-quicksight-dashboard-categoricaldimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricaldimensionfield.html#cfn-quicksight-dashboard-categoricaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricaldimensionfield.html#cfn-quicksight-dashboard-categoricaldimensionfield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricalmeasurefield.html#cfn-quicksight-dashboard-categoricalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricalmeasurefield.html#cfn-quicksight-dashboard-categoricalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricalmeasurefield.html#cfn-quicksight-dashboard-categoricalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricalmeasurefield.html#cfn-quicksight-dashboard-categoricalmeasurefield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categorydrilldownfilter.html#cfn-quicksight-dashboard-categorydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// CategoryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categorydrilldownfilter.html#cfn-quicksight-dashboard-categorydrilldownfilter-categoryvalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilterconfiguration.html#cfn-quicksight-dashboard-categoryfilterconfiguration-customfilterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterListConfiguration
            /// </summary>
            public CustomFilterListConfiguration CustomFilterListConfiguration { get; set; }
            /// <summary>
            /// CustomFilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilterconfiguration.html#cfn-quicksight-dashboard-categoryfilterconfiguration-customfilterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterConfiguration
            /// </summary>
            public CustomFilterConfiguration CustomFilterConfiguration { get; set; }
            /// <summary>
            /// FilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilterconfiguration.html#cfn-quicksight-dashboard-categoryfilterconfiguration-filterlistconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-chartaxislabeloptions.html#cfn-quicksight-dashboard-chartaxislabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// SortIconVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-chartaxislabeloptions.html#cfn-quicksight-dashboard-chartaxislabeloptions-sorticonvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortIconVisibility { get; set; }
            /// <summary>
            /// AxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-chartaxislabeloptions.html#cfn-quicksight-dashboard-chartaxislabeloptions-axislabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-clustermarker.html#cfn-quicksight-dashboard-clustermarker-simpleclustermarker
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-clustermarkerconfiguration.html#cfn-quicksight-dashboard-clustermarkerconfiguration-clustermarker
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-colorscale.html#cfn-quicksight-dashboard-colorscale-colors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataColor
            /// </summary>
            public List<DataColor> Colors { get; set; }
            /// <summary>
            /// ColorFillType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-colorscale.html#cfn-quicksight-dashboard-colorscale-colorfilltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorFillType { get; set; }
            /// <summary>
            /// NullValueColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-colorscale.html#cfn-quicksight-dashboard-colorscale-nullvaluecolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-colorsconfiguration.html#cfn-quicksight-dashboard-colorsconfiguration-customcolors
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnconfiguration.html#cfn-quicksight-dashboard-columnconfiguration-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnconfiguration.html#cfn-quicksight-dashboard-columnconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnconfiguration.html#cfn-quicksight-dashboard-columnconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// ColorsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnconfiguration.html#cfn-quicksight-dashboard-columnconfiguration-colorsconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnhierarchy.html#cfn-quicksight-dashboard-columnhierarchy-datetimehierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeHierarchy
            /// </summary>
            public DateTimeHierarchy DateTimeHierarchy { get; set; }
            /// <summary>
            /// ExplicitHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnhierarchy.html#cfn-quicksight-dashboard-columnhierarchy-explicithierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExplicitHierarchy
            /// </summary>
            public ExplicitHierarchy ExplicitHierarchy { get; set; }
            /// <summary>
            /// PredefinedHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnhierarchy.html#cfn-quicksight-dashboard-columnhierarchy-predefinedhierarchy
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnidentifier.html#cfn-quicksight-dashboard-columnidentifier-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnidentifier.html#cfn-quicksight-dashboard-columnidentifier-datasetidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnsort.html#cfn-quicksight-dashboard-columnsort-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnsort.html#cfn-quicksight-dashboard-columnsort-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier SortBy { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnsort.html#cfn-quicksight-dashboard-columnsort-direction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction Aggregation { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-barvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> BarValues { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// LineValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-linevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartSortConfiguration
            /// </summary>
            public ComboChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// BarDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-bardatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions BarDataLabels { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// BarsArrangement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-barsarrangement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BarsArrangement { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// LineDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-linedatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions LineDataLabels { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartFieldWells
            /// </summary>
            public ComboChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-secondaryyaxisdisplayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartfieldwells.html#cfn-quicksight-dashboard-combochartfieldwells-combochartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-categorysort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartConfiguration
            /// </summary>
            public ComboChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-comparisonconfiguration.html#cfn-quicksight-dashboard-comparisonconfiguration-comparisonmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonMethod { get; set; }
            /// <summary>
            /// ComparisonFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-comparisonconfiguration.html#cfn-quicksight-dashboard-comparisonconfiguration-comparisonformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-comparisonformatconfiguration.html#cfn-quicksight-dashboard-comparisonformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-comparisonformatconfiguration.html#cfn-quicksight-dashboard-comparisonformatconfiguration-percentagedisplayformatconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-periodtodate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodToDateComputation
            /// </summary>
            public PeriodToDateComputation PeriodToDate { get; set; }
            /// <summary>
            /// GrowthRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-growthrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrowthRateComputation
            /// </summary>
            public GrowthRateComputation GrowthRate { get; set; }
            /// <summary>
            /// TopBottomRanked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-topbottomranked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomRankedComputation
            /// </summary>
            public TopBottomRankedComputation TopBottomRanked { get; set; }
            /// <summary>
            /// TotalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-totalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalAggregationComputation
            /// </summary>
            public TotalAggregationComputation TotalAggregation { get; set; }
            /// <summary>
            /// Forecast
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-forecast
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastComputation
            /// </summary>
            public ForecastComputation Forecast { get; set; }
            /// <summary>
            /// MaximumMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-maximumminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumMinimumComputation
            /// </summary>
            public MaximumMinimumComputation MaximumMinimum { get; set; }
            /// <summary>
            /// PeriodOverPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-periodoverperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodOverPeriodComputation
            /// </summary>
            public PeriodOverPeriodComputation PeriodOverPeriod { get; set; }
            /// <summary>
            /// MetricComparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-metriccomparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricComparisonComputation
            /// </summary>
            public MetricComparisonComputation MetricComparison { get; set; }
            /// <summary>
            /// TopBottomMovers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-topbottommovers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomMoversComputation
            /// </summary>
            public TopBottomMoversComputation TopBottomMovers { get; set; }
            /// <summary>
            /// UniqueValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-uniquevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcolor.html#cfn-quicksight-dashboard-conditionalformattingcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingGradientColor
            /// </summary>
            public ConditionalFormattingGradientColor Gradient { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcolor.html#cfn-quicksight-dashboard-conditionalformattingcolor-solid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconcondition.html#cfn-quicksight-dashboard-conditionalformattingcustomiconcondition-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconcondition.html#cfn-quicksight-dashboard-conditionalformattingcustomiconcondition-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// DisplayConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconcondition.html#cfn-quicksight-dashboard-conditionalformattingcustomiconcondition-displayconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconDisplayConfiguration
            /// </summary>
            public ConditionalFormattingIconDisplayConfiguration DisplayConfiguration { get; set; }
            /// <summary>
            /// IconOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconcondition.html#cfn-quicksight-dashboard-conditionalformattingcustomiconcondition-iconoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconoptions.html#cfn-quicksight-dashboard-conditionalformattingcustomiconoptions-unicodeicon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnicodeIcon { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconoptions.html#cfn-quicksight-dashboard-conditionalformattingcustomiconoptions-icon
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattinggradientcolor.html#cfn-quicksight-dashboard-conditionalformattinggradientcolor-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattinggradientcolor.html#cfn-quicksight-dashboard-conditionalformattinggradientcolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingicon.html#cfn-quicksight-dashboard-conditionalformattingicon-customcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconCondition
            /// </summary>
            public ConditionalFormattingCustomIconCondition CustomCondition { get; set; }
            /// <summary>
            /// IconSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingicon.html#cfn-quicksight-dashboard-conditionalformattingicon-iconset
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingicondisplayconfiguration.html#cfn-quicksight-dashboard-conditionalformattingicondisplayconfiguration-icondisplayoption
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingiconset.html#cfn-quicksight-dashboard-conditionalformattingiconset-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// IconSetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingiconset.html#cfn-quicksight-dashboard-conditionalformattingiconset-iconsettype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingsolidcolor.html#cfn-quicksight-dashboard-conditionalformattingsolidcolor-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingsolidcolor.html#cfn-quicksight-dashboard-conditionalformattingsolidcolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-contributionanalysisdefault.html#cfn-quicksight-dashboard-contributionanalysisdefault-measurefieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureFieldId { get; set; }
            /// <summary>
            /// ContributorDimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-contributionanalysisdefault.html#cfn-quicksight-dashboard-contributionanalysisdefault-contributordimensions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NumberScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-numberscale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NumberScale { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Symbol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-symbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Symbol { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionfilteroperation.html#cfn-quicksight-dashboard-customactionfilteroperation-selectedfieldsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationSelectedFieldsConfiguration
            /// </summary>
            public FilterOperationSelectedFieldsConfiguration SelectedFieldsConfiguration { get; set; }
            /// <summary>
            /// TargetVisualsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionfilteroperation.html#cfn-quicksight-dashboard-customactionfilteroperation-targetvisualsconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionnavigationoperation.html#cfn-quicksight-dashboard-customactionnavigationoperation-localnavigationconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionsetparametersoperation.html#cfn-quicksight-dashboard-customactionsetparametersoperation-parametervalueconfigurations
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionurloperation.html#cfn-quicksight-dashboard-customactionurloperation-urltemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic URLTemplate { get; set; }
            /// <summary>
            /// URLTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionurloperation.html#cfn-quicksight-dashboard-customactionurloperation-urltarget
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcolor.html#cfn-quicksight-dashboard-customcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcolor.html#cfn-quicksight-dashboard-customcolor-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
            /// <summary>
            /// SpecialValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcolor.html#cfn-quicksight-dashboard-customcolor-specialvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentconfiguration.html#cfn-quicksight-dashboard-customcontentconfiguration-contenturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentUrl { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentconfiguration.html#cfn-quicksight-dashboard-customcontentconfiguration-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// ImageScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentconfiguration.html#cfn-quicksight-dashboard-customcontentconfiguration-imagescaling
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentConfiguration
            /// </summary>
            public CustomContentConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterconfiguration.html#cfn-quicksight-dashboard-customfilterconfiguration-categoryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterconfiguration.html#cfn-quicksight-dashboard-customfilterconfiguration-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterconfiguration.html#cfn-quicksight-dashboard-customfilterconfiguration-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterconfiguration.html#cfn-quicksight-dashboard-customfilterconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterconfiguration.html#cfn-quicksight-dashboard-customfilterconfiguration-selectalloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterlistconfiguration.html#cfn-quicksight-dashboard-customfilterlistconfiguration-categoryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterlistconfiguration.html#cfn-quicksight-dashboard-customfilterlistconfiguration-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterlistconfiguration.html#cfn-quicksight-dashboard-customfilterlistconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customfilterlistconfiguration.html#cfn-quicksight-dashboard-customfilterlistconfiguration-selectalloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customnarrativeoptions.html#cfn-quicksight-dashboard-customnarrativeoptions-narrative
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customparametervalues.html#cfn-quicksight-dashboard-customparametervalues-decimalvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> DecimalValues { get; set; }
            /// <summary>
            /// IntegerValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customparametervalues.html#cfn-quicksight-dashboard-customparametervalues-integervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> IntegerValues { get; set; }
            /// <summary>
            /// StringValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customparametervalues.html#cfn-quicksight-dashboard-customparametervalues-stringvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringValues { get; set; }
            /// <summary>
            /// DateTimeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customparametervalues.html#cfn-quicksight-dashboard-customparametervalues-datetimevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customvaluesconfiguration.html#cfn-quicksight-dashboard-customvaluesconfiguration-includenullvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeNullValue { get; set; }
            /// <summary>
            /// CustomValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customvaluesconfiguration.html#cfn-quicksight-dashboard-customvaluesconfiguration-customvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomParameterValues
            /// </summary>
            public CustomParameterValues CustomValues { get; set; }
        }

        public class DashboardError
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboarderror.html#cfn-quicksight-dashboard-dashboarderror-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboarderror.html#cfn-quicksight-dashboard-dashboarderror-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// ViolatedEntities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboarderror.html#cfn-quicksight-dashboard-dashboarderror-violatedentities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Entity
            /// </summary>
            public List<Entity> ViolatedEntities { get; set; }
        }

        public class DashboardPublishOptions
        {
            /// <summary>
            /// SheetControlsOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-sheetcontrolsoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlsOption
            /// </summary>
            public SheetControlsOption SheetControlsOption { get; set; }
            /// <summary>
            /// ExportToCSVOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-exporttocsvoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportToCSVOption
            /// </summary>
            public ExportToCSVOption ExportToCSVOption { get; set; }
            /// <summary>
            /// DataPointMenuLabelOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-datapointmenulabeloption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPointMenuLabelOption
            /// </summary>
            public DataPointMenuLabelOption DataPointMenuLabelOption { get; set; }
            /// <summary>
            /// DataPointDrillUpDownOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-datapointdrillupdownoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPointDrillUpDownOption
            /// </summary>
            public DataPointDrillUpDownOption DataPointDrillUpDownOption { get; set; }
            /// <summary>
            /// AdHocFilteringOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-adhocfilteringoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdHocFilteringOption
            /// </summary>
            public AdHocFilteringOption AdHocFilteringOption { get; set; }
            /// <summary>
            /// VisualPublishOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-visualpublishoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashboardVisualPublishOptions
            /// </summary>
            public DashboardVisualPublishOptions VisualPublishOptions { get; set; }
            /// <summary>
            /// VisualMenuOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-visualmenuoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualMenuOption
            /// </summary>
            public VisualMenuOption VisualMenuOption { get; set; }
            /// <summary>
            /// DataPointTooltipOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-datapointtooltipoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPointTooltipOption
            /// </summary>
            public DataPointTooltipOption DataPointTooltipOption { get; set; }
            /// <summary>
            /// VisualAxisSortOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-visualaxissortoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualAxisSortOption
            /// </summary>
            public VisualAxisSortOption VisualAxisSortOption { get; set; }
            /// <summary>
            /// ExportWithHiddenFieldsOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-exportwithhiddenfieldsoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportWithHiddenFieldsOption
            /// </summary>
            public ExportWithHiddenFieldsOption ExportWithHiddenFieldsOption { get; set; }
            /// <summary>
            /// SheetLayoutElementMaximizationOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-sheetlayoutelementmaximizationoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetLayoutElementMaximizationOption
            /// </summary>
            public SheetLayoutElementMaximizationOption SheetLayoutElementMaximizationOption { get; set; }
        }

        public class DashboardSourceEntity
        {
            /// <summary>
            /// SourceTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourceentity.html#cfn-quicksight-dashboard-dashboardsourceentity-sourcetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashboardSourceTemplate
            /// </summary>
            public DashboardSourceTemplate SourceTemplate { get; set; }
        }

        public class DashboardSourceTemplate
        {
            /// <summary>
            /// DataSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourcetemplate.html#cfn-quicksight-dashboard-dashboardsourcetemplate-datasetreferences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetReference
            /// </summary>
            public List<DataSetReference> DataSetReferences { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourcetemplate.html#cfn-quicksight-dashboard-dashboardsourcetemplate-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class DashboardVersion
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Errors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-errors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DashboardError
            /// </summary>
            public List<DashboardError> Errors { get; set; }
            /// <summary>
            /// CreatedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-createdtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedTime { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// DataSetArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-datasetarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DataSetArns { get; set; }
            /// <summary>
            /// ThemeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-themearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThemeArn { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// SourceEntityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-sourceentityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceEntityArn { get; set; }
            /// <summary>
            /// VersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-versionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic VersionNumber { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html#cfn-quicksight-dashboard-dashboardversion-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Sheet
            /// </summary>
            public List<Sheet> Sheets { get; set; }
        }

        public class DashboardVersionDefinition
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetOptions
            /// </summary>
            public AssetOptions Options { get; set; }
            /// <summary>
            /// FilterGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-filtergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterGroup
            /// </summary>
            public List<FilterGroup> FilterGroups { get; set; }
            /// <summary>
            /// CalculatedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-calculatedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedField
            /// </summary>
            public List<CalculatedField> CalculatedFields { get; set; }
            /// <summary>
            /// DataSetIdentifierDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-datasetidentifierdeclarations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetIdentifierDeclaration
            /// </summary>
            public List<DataSetIdentifierDeclaration> DataSetIdentifierDeclarations { get; set; }
            /// <summary>
            /// ColumnConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-columnconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnConfiguration
            /// </summary>
            public List<ColumnConfiguration> ColumnConfigurations { get; set; }
            /// <summary>
            /// AnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-analysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisDefaults
            /// </summary>
            public AnalysisDefaults AnalysisDefaults { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetDefinition
            /// </summary>
            public List<SheetDefinition> Sheets { get; set; }
            /// <summary>
            /// ParameterDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-parameterdeclarations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterDeclaration
            /// </summary>
            public List<ParameterDeclaration> ParameterDeclarations { get; set; }
        }

        public class DashboardVisualPublishOptions
        {
            /// <summary>
            /// ExportHiddenFieldsOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardvisualpublishoptions.html#cfn-quicksight-dashboard-dashboardvisualpublishoptions-exporthiddenfieldsoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportHiddenFieldsOption
            /// </summary>
            public ExportHiddenFieldsOption ExportHiddenFieldsOption { get; set; }
        }

        public class DataBarsOptions
        {
            /// <summary>
            /// PositiveColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-databarsoptions.html#cfn-quicksight-dashboard-databarsoptions-positivecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositiveColor { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-databarsoptions.html#cfn-quicksight-dashboard-databarsoptions-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// NegativeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-databarsoptions.html#cfn-quicksight-dashboard-databarsoptions-negativecolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datacolor.html#cfn-quicksight-dashboard-datacolor-datavalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datacolor.html#cfn-quicksight-dashboard-datacolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datafieldseriesitem.html#cfn-quicksight-dashboard-datafieldseriesitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datafieldseriesitem.html#cfn-quicksight-dashboard-datafieldseriesitem-axisbinding
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datafieldseriesitem.html#cfn-quicksight-dashboard-datafieldseriesitem-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datafieldseriesitem.html#cfn-quicksight-dashboard-datafieldseriesitem-settings
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-datalabeltypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataLabelType
            /// </summary>
            public List<DataLabelType> DataLabelTypes { get; set; }
            /// <summary>
            /// MeasureLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-measurelabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureLabelVisibility { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// LabelContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-labelcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelContent { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// Overlap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-overlap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Overlap { get; set; }
            /// <summary>
            /// CategoryLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-categorylabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryLabelVisibility { get; set; }
            /// <summary>
            /// LabelColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-labelcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColor { get; set; }
            /// <summary>
            /// LabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-labelfontconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-maximumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumLabelType
            /// </summary>
            public MaximumLabelType MaximumLabelType { get; set; }
            /// <summary>
            /// DataPathLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-datapathlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathLabelType
            /// </summary>
            public DataPathLabelType DataPathLabelType { get; set; }
            /// <summary>
            /// RangeEndsLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-rangeendslabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangeEndsLabelType
            /// </summary>
            public RangeEndsLabelType RangeEndsLabelType { get; set; }
            /// <summary>
            /// FieldLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-fieldlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldLabelType
            /// </summary>
            public FieldLabelType FieldLabelType { get; set; }
            /// <summary>
            /// MinimumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-minimumlabeltype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathcolor.html#cfn-quicksight-dashboard-datapathcolor-element
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPathValue
            /// </summary>
            public DataPathValue Element { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathcolor.html#cfn-quicksight-dashboard-datapathcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathcolor.html#cfn-quicksight-dashboard-datapathcolor-timegranularity
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathlabeltype.html#cfn-quicksight-dashboard-datapathlabeltype-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathlabeltype.html#cfn-quicksight-dashboard-datapathlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathlabeltype.html#cfn-quicksight-dashboard-datapathlabeltype-fieldvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathsort.html#cfn-quicksight-dashboard-datapathsort-sortpaths
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<DataPathValue> SortPaths { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathsort.html#cfn-quicksight-dashboard-datapathsort-direction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathtype.html#cfn-quicksight-dashboard-datapathtype-pivottabledatapathtype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathvalue.html#cfn-quicksight-dashboard-datapathvalue-datapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathType
            /// </summary>
            public DataPathType DataPathType { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathvalue.html#cfn-quicksight-dashboard-datapathvalue-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// FieldValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathvalue.html#cfn-quicksight-dashboard-datapathvalue-fieldvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldValue { get; set; }
        }

        public class DataPointDrillUpDownOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapointdrillupdownoption.html#cfn-quicksight-dashboard-datapointdrillupdownoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class DataPointMenuLabelOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapointmenulabeloption.html#cfn-quicksight-dashboard-datapointmenulabeloption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class DataPointTooltipOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapointtooltipoption.html#cfn-quicksight-dashboard-datapointtooltipoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class DataSetIdentifierDeclaration
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datasetidentifierdeclaration.html#cfn-quicksight-dashboard-datasetidentifierdeclaration-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datasetidentifierdeclaration.html#cfn-quicksight-dashboard-datasetidentifierdeclaration-datasetarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datasetreference.html#cfn-quicksight-dashboard-datasetreference-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
            /// <summary>
            /// DataSetPlaceholder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datasetreference.html#cfn-quicksight-dashboard-datasetreference-datasetplaceholder
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dateaxisoptions.html#cfn-quicksight-dashboard-dateaxisoptions-missingdatevisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datedimensionfield.html#cfn-quicksight-dashboard-datedimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datedimensionfield.html#cfn-quicksight-dashboard-datedimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datedimensionfield.html#cfn-quicksight-dashboard-datedimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datedimensionfield.html#cfn-quicksight-dashboard-datedimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// DateGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datedimensionfield.html#cfn-quicksight-dashboard-datedimensionfield-dategranularity
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datemeasurefield.html#cfn-quicksight-dashboard-datemeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datemeasurefield.html#cfn-quicksight-dashboard-datemeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datemeasurefield.html#cfn-quicksight-dashboard-datemeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datemeasurefield.html#cfn-quicksight-dashboard-datemeasurefield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimedefaultvalues.html#cfn-quicksight-dashboard-datetimedefaultvalues-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimedefaultvalues.html#cfn-quicksight-dashboard-datetimedefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimedefaultvalues.html#cfn-quicksight-dashboard-datetimedefaultvalues-staticvalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeformatconfiguration.html#cfn-quicksight-dashboard-datetimeformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeformatconfiguration.html#cfn-quicksight-dashboard-datetimeformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeformatconfiguration.html#cfn-quicksight-dashboard-datetimeformatconfiguration-datetimeformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimehierarchy.html#cfn-quicksight-dashboard-datetimehierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimehierarchy.html#cfn-quicksight-dashboard-datetimehierarchy-drilldownfilters
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameter.html#cfn-quicksight-dashboard-datetimeparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameter.html#cfn-quicksight-dashboard-datetimeparameter-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDefaultValues
            /// </summary>
            public DateTimeDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeValueWhenUnsetConfiguration
            /// </summary>
            public DateTimeValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimepickercontroldisplayoptions.html#cfn-quicksight-dashboard-datetimepickercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimepickercontroldisplayoptions.html#cfn-quicksight-dashboard-datetimepickercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimepickercontroldisplayoptions.html#cfn-quicksight-dashboard-datetimepickercontroldisplayoptions-datetimeformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimevaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-datetimevaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimevaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-datetimevaluewhenunsetconfiguration-customvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimaldefaultvalues.html#cfn-quicksight-dashboard-decimaldefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimaldefaultvalues.html#cfn-quicksight-dashboard-decimaldefaultvalues-staticvalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameter.html#cfn-quicksight-dashboard-decimalparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameter.html#cfn-quicksight-dashboard-decimalparameter-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDefaultValues
            /// </summary>
            public DecimalDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalValueWhenUnsetConfiguration
            /// </summary>
            public DecimalValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalplacesconfiguration.html#cfn-quicksight-dashboard-decimalplacesconfiguration-decimalplaces
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalvaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-decimalvaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalvaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-decimalvaluewhenunsetconfiguration-customvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultdatetimepickercontroloptions.html#cfn-quicksight-dashboard-defaultdatetimepickercontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultdatetimepickercontroloptions.html#cfn-quicksight-dashboard-defaultdatetimepickercontroloptions-displayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontrolconfiguration.html#cfn-quicksight-dashboard-defaultfiltercontrolconfiguration-controloptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlOptions
            /// </summary>
            public DefaultFilterControlOptions ControlOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontrolconfiguration.html#cfn-quicksight-dashboard-defaultfiltercontrolconfiguration-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultslideroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSliderControlOptions
            /// </summary>
            public DefaultSliderControlOptions DefaultSliderOptions { get; set; }
            /// <summary>
            /// DefaultRelativeDateTimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultrelativedatetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRelativeDateTimeControlOptions
            /// </summary>
            public DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions { get; set; }
            /// <summary>
            /// DefaultTextFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaulttextfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextFieldControlOptions
            /// </summary>
            public DefaultTextFieldControlOptions DefaultTextFieldOptions { get; set; }
            /// <summary>
            /// DefaultTextAreaOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaulttextareaoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextAreaControlOptions
            /// </summary>
            public DefaultTextAreaControlOptions DefaultTextAreaOptions { get; set; }
            /// <summary>
            /// DefaultDropdownOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultdropdownoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterDropDownControlOptions
            /// </summary>
            public DefaultFilterDropDownControlOptions DefaultDropdownOptions { get; set; }
            /// <summary>
            /// DefaultDateTimePickerOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultdatetimepickeroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultDateTimePickerControlOptions
            /// </summary>
            public DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions { get; set; }
            /// <summary>
            /// DefaultListOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultlistoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterdropdowncontroloptions.html#cfn-quicksight-dashboard-defaultfilterdropdowncontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterdropdowncontroloptions.html#cfn-quicksight-dashboard-defaultfilterdropdowncontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterdropdowncontroloptions.html#cfn-quicksight-dashboard-defaultfilterdropdowncontroloptions-selectablevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterlistcontroloptions.html#cfn-quicksight-dashboard-defaultfilterlistcontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterlistcontroloptions.html#cfn-quicksight-dashboard-defaultfilterlistcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterlistcontroloptions.html#cfn-quicksight-dashboard-defaultfilterlistcontroloptions-selectablevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfreeformlayoutconfiguration.html#cfn-quicksight-dashboard-defaultfreeformlayoutconfiguration-canvassizeoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultgridlayoutconfiguration.html#cfn-quicksight-dashboard-defaultgridlayoutconfiguration-canvassizeoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultinteractivelayoutconfiguration.html#cfn-quicksight-dashboard-defaultinteractivelayoutconfiguration-freeform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFreeFormLayoutConfiguration
            /// </summary>
            public DefaultFreeFormLayoutConfiguration FreeForm { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultinteractivelayoutconfiguration.html#cfn-quicksight-dashboard-defaultinteractivelayoutconfiguration-grid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultnewsheetconfiguration.html#cfn-quicksight-dashboard-defaultnewsheetconfiguration-sheetcontenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetContentType { get; set; }
            /// <summary>
            /// InteractiveLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultnewsheetconfiguration.html#cfn-quicksight-dashboard-defaultnewsheetconfiguration-interactivelayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultInteractiveLayoutConfiguration
            /// </summary>
            public DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration { get; set; }
            /// <summary>
            /// PaginatedLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultnewsheetconfiguration.html#cfn-quicksight-dashboard-defaultnewsheetconfiguration-paginatedlayoutconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultpaginatedlayoutconfiguration.html#cfn-quicksight-dashboard-defaultpaginatedlayoutconfiguration-sectionbased
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultrelativedatetimecontroloptions.html#cfn-quicksight-dashboard-defaultrelativedatetimecontroloptions-displayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultsectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-defaultsectionbasedlayoutconfiguration-canvassizeoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultslidercontroloptions.html#cfn-quicksight-dashboard-defaultslidercontroloptions-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultslidercontroloptions.html#cfn-quicksight-dashboard-defaultslidercontroloptions-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultslidercontroloptions.html#cfn-quicksight-dashboard-defaultslidercontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultslidercontroloptions.html#cfn-quicksight-dashboard-defaultslidercontroloptions-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultslidercontroloptions.html#cfn-quicksight-dashboard-defaultslidercontroloptions-minimumvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaulttextareacontroloptions.html#cfn-quicksight-dashboard-defaulttextareacontroloptions-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaulttextareacontroloptions.html#cfn-quicksight-dashboard-defaulttextareacontroloptions-displayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaulttextfieldcontroloptions.html#cfn-quicksight-dashboard-defaulttextfieldcontroloptions-displayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-destinationparametervalueconfiguration.html#cfn-quicksight-dashboard-destinationparametervalueconfiguration-customvaluesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomValuesConfiguration
            /// </summary>
            public CustomValuesConfiguration CustomValuesConfiguration { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-destinationparametervalueconfiguration.html#cfn-quicksight-dashboard-destinationparametervalueconfiguration-sourceparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// SelectAllValueOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-destinationparametervalueconfiguration.html#cfn-quicksight-dashboard-destinationparametervalueconfiguration-selectallvalueoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllValueOptions { get; set; }
            /// <summary>
            /// SourceField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-destinationparametervalueconfiguration.html#cfn-quicksight-dashboard-destinationparametervalueconfiguration-sourcefield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceField { get; set; }
            /// <summary>
            /// SourceColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-destinationparametervalueconfiguration.html#cfn-quicksight-dashboard-destinationparametervalueconfiguration-sourcecolumn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dimensionfield.html#cfn-quicksight-dashboard-dimensionfield-datedimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateDimensionField
            /// </summary>
            public DateDimensionField DateDimensionField { get; set; }
            /// <summary>
            /// NumericalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dimensionfield.html#cfn-quicksight-dashboard-dimensionfield-numericaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalDimensionField
            /// </summary>
            public NumericalDimensionField NumericalDimensionField { get; set; }
            /// <summary>
            /// CategoricalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dimensionfield.html#cfn-quicksight-dashboard-dimensionfield-categoricaldimensionfield
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-donutcenteroptions.html#cfn-quicksight-dashboard-donutcenteroptions-labelvisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-donutoptions.html#cfn-quicksight-dashboard-donutoptions-donutcenteroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutCenterOptions
            /// </summary>
            public DonutCenterOptions DonutCenterOptions { get; set; }
            /// <summary>
            /// ArcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-donutoptions.html#cfn-quicksight-dashboard-donutoptions-arcoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-drilldownfilter.html#cfn-quicksight-dashboard-drilldownfilter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityDrillDownFilter
            /// </summary>
            public NumericEqualityDrillDownFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-drilldownfilter.html#cfn-quicksight-dashboard-drilldownfilter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeDrillDownFilter
            /// </summary>
            public TimeRangeDrillDownFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-drilldownfilter.html#cfn-quicksight-dashboard-drilldownfilter-categoryfilter
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dropdowncontroldisplayoptions.html#cfn-quicksight-dashboard-dropdowncontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dropdowncontroldisplayoptions.html#cfn-quicksight-dashboard-dropdowncontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dropdowncontroldisplayoptions.html#cfn-quicksight-dashboard-dropdowncontroldisplayoptions-infoiconlabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dynamicdefaultvalue.html#cfn-quicksight-dashboard-dynamicdefaultvalue-groupnamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier GroupNameColumn { get; set; }
            /// <summary>
            /// DefaultValueColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dynamicdefaultvalue.html#cfn-quicksight-dashboard-dynamicdefaultvalue-defaultvaluecolumn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier DefaultValueColumn { get; set; }
            /// <summary>
            /// UserNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dynamicdefaultvalue.html#cfn-quicksight-dashboard-dynamicdefaultvalue-usernamecolumn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-emptyvisual.html#cfn-quicksight-dashboard-emptyvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-emptyvisual.html#cfn-quicksight-dashboard-emptyvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-emptyvisual.html#cfn-quicksight-dashboard-emptyvisual-datasetidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-entity.html#cfn-quicksight-dashboard-entity-path
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-excludeperiodconfiguration.html#cfn-quicksight-dashboard-excludeperiodconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-excludeperiodconfiguration.html#cfn-quicksight-dashboard-excludeperiodconfiguration-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Amount { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-excludeperiodconfiguration.html#cfn-quicksight-dashboard-excludeperiodconfiguration-granularity
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-explicithierarchy.html#cfn-quicksight-dashboard-explicithierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-explicithierarchy.html#cfn-quicksight-dashboard-explicithierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-explicithierarchy.html#cfn-quicksight-dashboard-explicithierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<ColumnIdentifier> Columns { get; set; }
        }

        public class ExportHiddenFieldsOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-exporthiddenfieldsoption.html#cfn-quicksight-dashboard-exporthiddenfieldsoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class ExportToCSVOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-exporttocsvoption.html#cfn-quicksight-dashboard-exporttocsvoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class ExportWithHiddenFieldsOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-exportwithhiddenfieldsoption.html#cfn-quicksight-dashboard-exportwithhiddenfieldsoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class FieldBasedTooltip
        {
            /// <summary>
            /// TooltipFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldbasedtooltip.html#cfn-quicksight-dashboard-fieldbasedtooltip-tooltipfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TooltipItem
            /// </summary>
            public List<TooltipItem> TooltipFields { get; set; }
            /// <summary>
            /// AggregationVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldbasedtooltip.html#cfn-quicksight-dashboard-fieldbasedtooltip-aggregationvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationVisibility { get; set; }
            /// <summary>
            /// TooltipTitleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldbasedtooltip.html#cfn-quicksight-dashboard-fieldbasedtooltip-tooltiptitletype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldlabeltype.html#cfn-quicksight-dashboard-fieldlabeltype-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldlabeltype.html#cfn-quicksight-dashboard-fieldlabeltype-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldseriesitem.html#cfn-quicksight-dashboard-fieldseriesitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldseriesitem.html#cfn-quicksight-dashboard-fieldseriesitem-axisbinding
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldseriesitem.html#cfn-quicksight-dashboard-fieldseriesitem-settings
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldsort.html#cfn-quicksight-dashboard-fieldsort-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldsort.html#cfn-quicksight-dashboard-fieldsort-direction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldsortoptions.html#cfn-quicksight-dashboard-fieldsortoptions-fieldsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public FieldSort FieldSort { get; set; }
            /// <summary>
            /// ColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldsortoptions.html#cfn-quicksight-dashboard-fieldsortoptions-columnsort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldtooltipitem.html#cfn-quicksight-dashboard-fieldtooltipitem-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldtooltipitem.html#cfn-quicksight-dashboard-fieldtooltipitem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldtooltipitem.html#cfn-quicksight-dashboard-fieldtooltipitem-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapaggregatedfieldwells.html#cfn-quicksight-dashboard-filledmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapaggregatedfieldwells.html#cfn-quicksight-dashboard-filledmapaggregatedfieldwells-geospatial
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconditionalformatting.html#cfn-quicksight-dashboard-filledmapconditionalformatting-conditionalformattingoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconditionalformattingoption.html#cfn-quicksight-dashboard-filledmapconditionalformattingoption-shape
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapSortConfiguration
            /// </summary>
            public FilledMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapFieldWells
            /// </summary>
            public FilledMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-windowoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapfieldwells.html#cfn-quicksight-dashboard-filledmapfieldwells-filledmapaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapshapeconditionalformatting.html#cfn-quicksight-dashboard-filledmapshapeconditionalformatting-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShapeConditionalFormat
            /// </summary>
            public ShapeConditionalFormat Format { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapshapeconditionalformatting.html#cfn-quicksight-dashboard-filledmapshapeconditionalformatting-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapsortconfiguration.html#cfn-quicksight-dashboard-filledmapsortconfiguration-categorysort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConditionalFormatting
            /// </summary>
            public FilledMapConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConfiguration
            /// </summary>
            public FilledMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityFilter
            /// </summary>
            public NumericEqualityFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// NumericRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-numericrangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilter
            /// </summary>
            public NumericRangeFilter NumericRangeFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilter
            /// </summary>
            public TimeRangeFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// RelativeDatesFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-relativedatesfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDatesFilter
            /// </summary>
            public RelativeDatesFilter RelativeDatesFilter { get; set; }
            /// <summary>
            /// TopBottomFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-topbottomfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomFilter
            /// </summary>
            public TopBottomFilter TopBottomFilter { get; set; }
            /// <summary>
            /// TimeEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-timeequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeEqualityFilter
            /// </summary>
            public TimeEqualityFilter TimeEqualityFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-categoryfilter
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSliderControl
            /// </summary>
            public FilterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextAreaControl
            /// </summary>
            public FilterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDropDownControl
            /// </summary>
            public FilterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextFieldControl
            /// </summary>
            public FilterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListControl
            /// </summary>
            public FilterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDateTimePickerControl
            /// </summary>
            public FilterDateTimePickerControl DateTimePicker { get; set; }
            /// <summary>
            /// RelativeDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-relativedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterRelativeDateTimeControl
            /// </summary>
            public FilterRelativeDateTimeControl RelativeDateTime { get; set; }
            /// <summary>
            /// CrossSheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-crosssheet
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercrosssheetcontrol.html#cfn-quicksight-dashboard-filtercrosssheetcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercrosssheetcontrol.html#cfn-quicksight-dashboard-filtercrosssheetcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercrosssheetcontrol.html#cfn-quicksight-dashboard-filtercrosssheetcontrol-sourcefilterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-sourcefilterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-selectablevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtergroup.html#cfn-quicksight-dashboard-filtergroup-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtergroup.html#cfn-quicksight-dashboard-filtergroup-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Filter> Filters { get; set; }
            /// <summary>
            /// CrossDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtergroup.html#cfn-quicksight-dashboard-filtergroup-crossdataset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossDataset { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtergroup.html#cfn-quicksight-dashboard-filtergroup-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterScopeConfiguration
            /// </summary>
            public FilterScopeConfiguration ScopeConfiguration { get; set; }
            /// <summary>
            /// FilterGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtergroup.html#cfn-quicksight-dashboard-filtergroup-filtergroupid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistconfiguration.html#cfn-quicksight-dashboard-filterlistconfiguration-categoryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CategoryValues { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistconfiguration.html#cfn-quicksight-dashboard-filterlistconfiguration-nulloption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistconfiguration.html#cfn-quicksight-dashboard-filterlistconfiguration-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistconfiguration.html#cfn-quicksight-dashboard-filterlistconfiguration-selectalloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-selectablevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-dashboard-filteroperationselectedfieldsconfiguration-selectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<ColumnIdentifier> SelectedColumns { get; set; }
            /// <summary>
            /// SelectedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-dashboard-filteroperationselectedfieldsconfiguration-selectedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SelectedFields { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-dashboard-filteroperationselectedfieldsconfiguration-selectedfieldoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filteroperationtargetvisualsconfiguration.html#cfn-quicksight-dashboard-filteroperationtargetvisualsconfiguration-samesheettargetvisualconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-sourcefilterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterscopeconfiguration.html#cfn-quicksight-dashboard-filterscopeconfiguration-allsheets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllSheets { get; set; }
            /// <summary>
            /// SelectedSheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterscopeconfiguration.html#cfn-quicksight-dashboard-filterscopeconfiguration-selectedsheets
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterselectablevalues.html#cfn-quicksight-dashboard-filterselectablevalues-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterslidercontrol.html#cfn-quicksight-dashboard-filterslidercontrol-minimumvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextareacontrol.html#cfn-quicksight-dashboard-filtertextareacontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextareacontrol.html#cfn-quicksight-dashboard-filtertextareacontrol-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextareacontrol.html#cfn-quicksight-dashboard-filtertextareacontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public TextAreaControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextareacontrol.html#cfn-quicksight-dashboard-filtertextareacontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextareacontrol.html#cfn-quicksight-dashboard-filtertextareacontrol-sourcefilterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextfieldcontrol.html#cfn-quicksight-dashboard-filtertextfieldcontrol-filtercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextfieldcontrol.html#cfn-quicksight-dashboard-filtertextfieldcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public TextFieldControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextfieldcontrol.html#cfn-quicksight-dashboard-filtertextfieldcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtertextfieldcontrol.html#cfn-quicksight-dashboard-filtertextfieldcontrol-sourcefilterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontconfiguration.html#cfn-quicksight-dashboard-fontconfiguration-fontstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontStyle { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontconfiguration.html#cfn-quicksight-dashboard-fontconfiguration-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontSize
            /// </summary>
            public FontSize FontSize { get; set; }
            /// <summary>
            /// FontDecoration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontconfiguration.html#cfn-quicksight-dashboard-fontconfiguration-fontdecoration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontDecoration { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontconfiguration.html#cfn-quicksight-dashboard-fontconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// FontWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontconfiguration.html#cfn-quicksight-dashboard-fontconfiguration-fontweight
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontsize.html#cfn-quicksight-dashboard-fontsize-relative
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontweight.html#cfn-quicksight-dashboard-fontweight-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-periodsbackward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsBackward { get; set; }
            /// <summary>
            /// PeriodsForward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-periodsforward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsForward { get; set; }
            /// <summary>
            /// PredictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-predictioninterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PredictionInterval { get; set; }
            /// <summary>
            /// Seasonality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-seasonality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Seasonality { get; set; }
            /// <summary>
            /// CustomSeasonalityValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-customseasonalityvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CustomSeasonalityValue { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// UpperBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-upperboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperBoundary { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// LowerBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-lowerboundary
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastconfiguration.html#cfn-quicksight-dashboard-forecastconfiguration-forecastproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedForecastProperties
            /// </summary>
            public TimeBasedForecastProperties ForecastProperties { get; set; }
            /// <summary>
            /// Scenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastconfiguration.html#cfn-quicksight-dashboard-forecastconfiguration-scenario
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastscenario.html#cfn-quicksight-dashboard-forecastscenario-whatifrangescenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfRangeScenario
            /// </summary>
            public WhatIfRangeScenario WhatIfRangeScenario { get; set; }
            /// <summary>
            /// WhatIfPointScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastscenario.html#cfn-quicksight-dashboard-forecastscenario-whatifpointscenario
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-formatconfiguration.html#cfn-quicksight-dashboard-formatconfiguration-numberformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public NumberFormatConfiguration NumberFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-formatconfiguration.html#cfn-quicksight-dashboard-formatconfiguration-datetimeformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public DateTimeFormatConfiguration DateTimeFormatConfiguration { get; set; }
            /// <summary>
            /// StringFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-formatconfiguration.html#cfn-quicksight-dashboard-formatconfiguration-stringformatconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutcanvassizeoptions.html#cfn-quicksight-dashboard-freeformlayoutcanvassizeoptions-screencanvassizeoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutconfiguration.html#cfn-quicksight-dashboard-freeformlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutconfiguration.html#cfn-quicksight-dashboard-freeformlayoutconfiguration-elements
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-elementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementType { get; set; }
            /// <summary>
            /// BorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-borderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBorderStyle
            /// </summary>
            public FreeFormLayoutElementBorderStyle BorderStyle { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-height
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// RenderingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-renderingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetElementRenderingRule
            /// </summary>
            public List<SheetElementRenderingRule> RenderingRules { get; set; }
            /// <summary>
            /// YAxisLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-yaxislocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic YAxisLocation { get; set; }
            /// <summary>
            /// LoadingAnimation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-loadinganimation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoadingAnimation
            /// </summary>
            public LoadingAnimation LoadingAnimation { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-width
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Width { get; set; }
            /// <summary>
            /// BackgroundStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-backgroundstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutElementBackgroundStyle
            /// </summary>
            public FreeFormLayoutElementBackgroundStyle BackgroundStyle { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-elementid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementId { get; set; }
            /// <summary>
            /// XAxisLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-xaxislocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic XAxisLocation { get; set; }
            /// <summary>
            /// SelectedBorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelement.html#cfn-quicksight-dashboard-freeformlayoutelement-selectedborderstyle
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelementbackgroundstyle.html#cfn-quicksight-dashboard-freeformlayoutelementbackgroundstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelementbackgroundstyle.html#cfn-quicksight-dashboard-freeformlayoutelementbackgroundstyle-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelementborderstyle.html#cfn-quicksight-dashboard-freeformlayoutelementborderstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutelementborderstyle.html#cfn-quicksight-dashboard-freeformlayoutelementborderstyle-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutscreencanvassizeoptions.html#cfn-quicksight-dashboard-freeformlayoutscreencanvassizeoptions-optimizedviewportwidth
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformsectionlayoutconfiguration.html#cfn-quicksight-dashboard-freeformsectionlayoutconfiguration-elements
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartaggregatedfieldwells.html#cfn-quicksight-dashboard-funnelchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartaggregatedfieldwells.html#cfn-quicksight-dashboard-funnelchartaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartSortConfiguration
            /// </summary>
            public FunnelChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-datalabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartDataLabelOptions
            /// </summary>
            public FunnelChartDataLabelOptions DataLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartFieldWells
            /// </summary>
            public FunnelChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-visualpalette
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-measurelabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureLabelVisibility { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// CategoryLabelVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-categorylabelvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoryLabelVisibility { get; set; }
            /// <summary>
            /// LabelColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-labelcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColor { get; set; }
            /// <summary>
            /// MeasureDataLabelStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-measuredatalabelstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureDataLabelStyle { get; set; }
            /// <summary>
            /// LabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartdatalabeloptions.html#cfn-quicksight-dashboard-funnelchartdatalabeloptions-labelfontconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartfieldwells.html#cfn-quicksight-dashboard-funnelchartfieldwells-funnelchartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartsortconfiguration.html#cfn-quicksight-dashboard-funnelchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartsortconfiguration.html#cfn-quicksight-dashboard-funnelchartsortconfiguration-categorysort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartConfiguration
            /// </summary>
            public FunnelChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartarcconditionalformatting.html#cfn-quicksight-dashboard-gaugechartarcconditionalformatting-foregroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconditionalformatting.html#cfn-quicksight-dashboard-gaugechartconditionalformatting-conditionalformattingoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconditionalformattingoption.html#cfn-quicksight-dashboard-gaugechartconditionalformattingoption-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartArcConditionalFormatting
            /// </summary>
            public GaugeChartArcConditionalFormatting Arc { get; set; }
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconditionalformattingoption.html#cfn-quicksight-dashboard-gaugechartconditionalformattingoption-primaryvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartFieldWells
            /// </summary>
            public GaugeChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// TooltipOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-tooltipoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions TooltipOptions { get; set; }
            /// <summary>
            /// GaugeChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-gaugechartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartOptions
            /// </summary>
            public GaugeChartOptions GaugeChartOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-visualpalette
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartfieldwells.html#cfn-quicksight-dashboard-gaugechartfieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> TargetValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartfieldwells.html#cfn-quicksight-dashboard-gaugechartfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcConfiguration
            /// </summary>
            public ArcConfiguration Arc { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public ComparisonConfiguration Comparison { get; set; }
            /// <summary>
            /// PrimaryValueDisplayType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-primaryvaluedisplaytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryValueDisplayType { get; set; }
            /// <summary>
            /// ArcAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-arcaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisConfiguration
            /// </summary>
            public ArcAxisConfiguration ArcAxis { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-primaryvaluefontconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting-icon
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConditionalFormatting
            /// </summary>
            public GaugeChartConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConfiguration
            /// </summary>
            public GaugeChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcoordinatebounds.html#cfn-quicksight-dashboard-geospatialcoordinatebounds-west
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic West { get; set; }
            /// <summary>
            /// South
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcoordinatebounds.html#cfn-quicksight-dashboard-geospatialcoordinatebounds-south
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic South { get; set; }
            /// <summary>
            /// North
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcoordinatebounds.html#cfn-quicksight-dashboard-geospatialcoordinatebounds-north
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic North { get; set; }
            /// <summary>
            /// East
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcoordinatebounds.html#cfn-quicksight-dashboard-geospatialcoordinatebounds-east
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialheatmapcolorscale.html#cfn-quicksight-dashboard-geospatialheatmapcolorscale-colors
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialheatmapconfiguration.html#cfn-quicksight-dashboard-geospatialheatmapconfiguration-heatmapcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialheatmapdatacolor.html#cfn-quicksight-dashboard-geospatialheatmapdatacolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapaggregatedfieldwells.html#cfn-quicksight-dashboard-geospatialmapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapaggregatedfieldwells.html#cfn-quicksight-dashboard-geospatialmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapaggregatedfieldwells.html#cfn-quicksight-dashboard-geospatialmapaggregatedfieldwells-geospatial
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapFieldWells
            /// </summary>
            public GeospatialMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public GeospatialWindowOptions WindowOptions { get; set; }
            /// <summary>
            /// PointStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-pointstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyleOptions
            /// </summary>
            public GeospatialPointStyleOptions PointStyleOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-visualpalette
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapfieldwells.html#cfn-quicksight-dashboard-geospatialmapfieldwells-geospatialmapaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapstyleoptions.html#cfn-quicksight-dashboard-geospatialmapstyleoptions-basemapstyle
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapConfiguration
            /// </summary>
            public GeospatialMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpointstyleoptions.html#cfn-quicksight-dashboard-geospatialpointstyleoptions-selectedpointstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedPointStyle { get; set; }
            /// <summary>
            /// ClusterMarkerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpointstyleoptions.html#cfn-quicksight-dashboard-geospatialpointstyleoptions-clustermarkerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarkerConfiguration
            /// </summary>
            public ClusterMarkerConfiguration ClusterMarkerConfiguration { get; set; }
            /// <summary>
            /// HeatmapConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpointstyleoptions.html#cfn-quicksight-dashboard-geospatialpointstyleoptions-heatmapconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialwindowoptions.html#cfn-quicksight-dashboard-geospatialwindowoptions-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapZoomMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialwindowoptions.html#cfn-quicksight-dashboard-geospatialwindowoptions-mapzoommode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-globaltableborderoptions.html#cfn-quicksight-dashboard-globaltableborderoptions-uniformborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions UniformBorder { get; set; }
            /// <summary>
            /// SideSpecificBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-globaltableborderoptions.html#cfn-quicksight-dashboard-globaltableborderoptions-sidespecificborder
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gradientcolor.html#cfn-quicksight-dashboard-gradientcolor-stops
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gradientstop.html#cfn-quicksight-dashboard-gradientstop-gradientoffset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GradientOffset { get; set; }
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gradientstop.html#cfn-quicksight-dashboard-gradientstop-datavalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gradientstop.html#cfn-quicksight-dashboard-gradientstop-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutcanvassizeoptions.html#cfn-quicksight-dashboard-gridlayoutcanvassizeoptions-screencanvassizeoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutconfiguration.html#cfn-quicksight-dashboard-gridlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutconfiguration.html#cfn-quicksight-dashboard-gridlayoutconfiguration-elements
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutelement.html#cfn-quicksight-dashboard-gridlayoutelement-elementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElementType { get; set; }
            /// <summary>
            /// ColumnSpan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutelement.html#cfn-quicksight-dashboard-gridlayoutelement-columnspan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ColumnSpan { get; set; }
            /// <summary>
            /// ColumnIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutelement.html#cfn-quicksight-dashboard-gridlayoutelement-columnindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ColumnIndex { get; set; }
            /// <summary>
            /// RowIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutelement.html#cfn-quicksight-dashboard-gridlayoutelement-rowindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RowIndex { get; set; }
            /// <summary>
            /// RowSpan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutelement.html#cfn-quicksight-dashboard-gridlayoutelement-rowspan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RowSpan { get; set; }
            /// <summary>
            /// ElementId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutelement.html#cfn-quicksight-dashboard-gridlayoutelement-elementid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutscreencanvassizeoptions.html#cfn-quicksight-dashboard-gridlayoutscreencanvassizeoptions-optimizedviewportwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedViewPortWidth { get; set; }
            /// <summary>
            /// ResizeOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutscreencanvassizeoptions.html#cfn-quicksight-dashboard-gridlayoutscreencanvassizeoptions-resizeoption
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// PeriodSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-periodsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodSize { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-headerfootersectionconfiguration.html#cfn-quicksight-dashboard-headerfootersectionconfiguration-layout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public SectionLayoutConfiguration Layout { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-headerfootersectionconfiguration.html#cfn-quicksight-dashboard-headerfootersectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public SectionStyle Style { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-headerfootersectionconfiguration.html#cfn-quicksight-dashboard-headerfootersectionconfiguration-sectionid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapaggregatedfieldwells.html#cfn-quicksight-dashboard-heatmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapaggregatedfieldwells.html#cfn-quicksight-dashboard-heatmapaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapaggregatedfieldwells.html#cfn-quicksight-dashboard-heatmapaggregatedfieldwells-rows
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapSortConfiguration
            /// </summary>
            public HeatMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// ColumnLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-columnlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColumnLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapFieldWells
            /// </summary>
            public HeatMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public ColorScale ColorScale { get; set; }
            /// <summary>
            /// RowLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-rowlabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapfieldwells.html#cfn-quicksight-dashboard-heatmapfieldwells-heatmapaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmaprowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> HeatMapRowSort { get; set; }
            /// <summary>
            /// HeatMapRowItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmaprowitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration HeatMapRowItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmapcolumnitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration HeatMapColumnItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmapcolumnsort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapConfiguration
            /// </summary>
            public HeatMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramaggregatedfieldwells.html#cfn-quicksight-dashboard-histogramaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogrambinoptions.html#cfn-quicksight-dashboard-histogrambinoptions-binwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinWidthOptions
            /// </summary>
            public BinWidthOptions BinWidth { get; set; }
            /// <summary>
            /// StartValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogrambinoptions.html#cfn-quicksight-dashboard-histogrambinoptions-startvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartValue { get; set; }
            /// <summary>
            /// SelectedBinType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogrambinoptions.html#cfn-quicksight-dashboard-histogrambinoptions-selectedbintype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedBinType { get; set; }
            /// <summary>
            /// BinCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogrambinoptions.html#cfn-quicksight-dashboard-histogrambinoptions-bincount
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// BinOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-binoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramBinOptions
            /// </summary>
            public HistogramBinOptions BinOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramFieldWells
            /// </summary>
            public HistogramFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-xaxisdisplayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramfieldwells.html#cfn-quicksight-dashboard-histogramfieldwells-histogramaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramConfiguration
            /// </summary>
            public HistogramConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightconfiguration.html#cfn-quicksight-dashboard-insightconfiguration-computations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Computation
            /// </summary>
            public List<Computation> Computations { get; set; }
            /// <summary>
            /// CustomNarrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightconfiguration.html#cfn-quicksight-dashboard-insightconfiguration-customnarrative
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// InsightConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-insightconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightConfiguration
            /// </summary>
            public InsightConfiguration InsightConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerdefaultvalues.html#cfn-quicksight-dashboard-integerdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerdefaultvalues.html#cfn-quicksight-dashboard-integerdefaultvalues-staticvalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameter.html#cfn-quicksight-dashboard-integerparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameter.html#cfn-quicksight-dashboard-integerparameter-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDefaultValues
            /// </summary>
            public IntegerDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerValueWhenUnsetConfiguration
            /// </summary>
            public IntegerValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integervaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-integervaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integervaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-integervaluewhenunsetconfiguration-customvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-itemslimitconfiguration.html#cfn-quicksight-dashboard-itemslimitconfiguration-itemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ItemsLimit { get; set; }
            /// <summary>
            /// OtherCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-itemslimitconfiguration.html#cfn-quicksight-dashboard-itemslimitconfiguration-othercategories
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiactualvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiactualvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiactualvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiactualvalueconditionalformatting-icon
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-dashboard-kpicomparisonvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-dashboard-kpicomparisonvalueconditionalformatting-icon
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformatting.html#cfn-quicksight-dashboard-kpiconditionalformatting-conditionalformattingoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIPrimaryValueConditionalFormatting
            /// </summary>
            public KPIPrimaryValueConditionalFormatting PrimaryValue { get; set; }
            /// <summary>
            /// ActualValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-actualvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIActualValueConditionalFormatting
            /// </summary>
            public KPIActualValueConditionalFormatting ActualValue { get; set; }
            /// <summary>
            /// ComparisonValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-comparisonvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIComparisonValueConditionalFormatting
            /// </summary>
            public KPIComparisonValueConditionalFormatting ComparisonValue { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-progressbar
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconfiguration.html#cfn-quicksight-dashboard-kpiconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISortConfiguration
            /// </summary>
            public KPISortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// KPIOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconfiguration.html#cfn-quicksight-dashboard-kpiconfiguration-kpioptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIOptions
            /// </summary>
            public KPIOptions KPIOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconfiguration.html#cfn-quicksight-dashboard-kpiconfiguration-fieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpifieldwells.html#cfn-quicksight-dashboard-kpifieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> TargetValues { get; set; }
            /// <summary>
            /// TrendGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpifieldwells.html#cfn-quicksight-dashboard-kpifieldwells-trendgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> TrendGroups { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpifieldwells.html#cfn-quicksight-dashboard-kpifieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-secondaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration SecondaryValueFontConfiguration { get; set; }
            /// <summary>
            /// VisualLayoutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-visuallayoutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualLayoutOptions
            /// </summary>
            public KPIVisualLayoutOptions VisualLayoutOptions { get; set; }
            /// <summary>
            /// TrendArrows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-trendarrows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendArrowOptions
            /// </summary>
            public TrendArrowOptions TrendArrows { get; set; }
            /// <summary>
            /// SecondaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-secondaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecondaryValueOptions
            /// </summary>
            public SecondaryValueOptions SecondaryValue { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public ComparisonConfiguration Comparison { get; set; }
            /// <summary>
            /// PrimaryValueDisplayType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-primaryvaluedisplaytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryValueDisplayType { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProgressBarOptions
            /// </summary>
            public ProgressBarOptions ProgressBar { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration PrimaryValueFontConfiguration { get; set; }
            /// <summary>
            /// Sparkline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-sparkline
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiprimaryvalueconditionalformatting-icon
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiprogressbarconditionalformatting.html#cfn-quicksight-dashboard-kpiprogressbarconditionalformatting-foregroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpisortconfiguration.html#cfn-quicksight-dashboard-kpisortconfiguration-trendgroupsort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpisparklineoptions.html#cfn-quicksight-dashboard-kpisparklineoptions-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpisparklineoptions.html#cfn-quicksight-dashboard-kpisparklineoptions-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// TooltipVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpisparklineoptions.html#cfn-quicksight-dashboard-kpisparklineoptions-tooltipvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipVisibility { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpisparklineoptions.html#cfn-quicksight-dashboard-kpisparklineoptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConditionalFormatting
            /// </summary>
            public KPIConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConfiguration
            /// </summary>
            public KPIConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisuallayoutoptions.html#cfn-quicksight-dashboard-kpivisuallayoutoptions-standardlayout
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisualstandardlayout.html#cfn-quicksight-dashboard-kpivisualstandardlayout-type
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-labeloptions.html#cfn-quicksight-dashboard-labeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-labeloptions.html#cfn-quicksight-dashboard-labeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-labeloptions.html#cfn-quicksight-dashboard-labeloptions-fontconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layout.html#cfn-quicksight-dashboard-layout-configuration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layoutconfiguration.html#cfn-quicksight-dashboard-layoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public GridLayoutConfiguration GridLayout { get; set; }
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layoutconfiguration.html#cfn-quicksight-dashboard-layoutconfiguration-freeformlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutConfiguration
            /// </summary>
            public FreeFormLayoutConfiguration FreeFormLayout { get; set; }
            /// <summary>
            /// SectionBasedLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layoutconfiguration.html#cfn-quicksight-dashboard-layoutconfiguration-sectionbasedlayout
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions Title { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-width
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-smallmultiples
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSortConfiguration
            /// </summary>
            public LineChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions XAxisDisplayOptions { get; set; }
            /// <summary>
            /// DefaultSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-defaultseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartDefaultSeriesSettings
            /// </summary>
            public LineChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ForecastConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-forecastconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ForecastConfiguration
            /// </summary>
            public List<ForecastConfiguration> ForecastConfigurations { get; set; }
            /// <summary>
            /// Series
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-series
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeriesItem
            /// </summary>
            public List<SeriesItem> Series { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartFieldWells
            /// </summary>
            public LineChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-xaxislabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartdefaultseriessettings.html#cfn-quicksight-dashboard-linechartdefaultseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartdefaultseriessettings.html#cfn-quicksight-dashboard-linechartdefaultseriessettings-axisbinding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartdefaultseriessettings.html#cfn-quicksight-dashboard-linechartdefaultseriessettings-markerstylesettings
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartfieldwells.html#cfn-quicksight-dashboard-linechartfieldwells-linechartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartlinestylesettings.html#cfn-quicksight-dashboard-linechartlinestylesettings-lineinterpolation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineInterpolation { get; set; }
            /// <summary>
            /// LineStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartlinestylesettings.html#cfn-quicksight-dashboard-linechartlinestylesettings-linestyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineStyle { get; set; }
            /// <summary>
            /// LineVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartlinestylesettings.html#cfn-quicksight-dashboard-linechartlinestylesettings-linevisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineVisibility { get; set; }
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartlinestylesettings.html#cfn-quicksight-dashboard-linechartlinestylesettings-linewidth
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartmarkerstylesettings.html#cfn-quicksight-dashboard-linechartmarkerstylesettings-markershape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerShape { get; set; }
            /// <summary>
            /// MarkerSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartmarkerstylesettings.html#cfn-quicksight-dashboard-linechartmarkerstylesettings-markersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerSize { get; set; }
            /// <summary>
            /// MarkerVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartmarkerstylesettings.html#cfn-quicksight-dashboard-linechartmarkerstylesettings-markervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MarkerVisibility { get; set; }
            /// <summary>
            /// MarkerColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartmarkerstylesettings.html#cfn-quicksight-dashboard-linechartmarkerstylesettings-markercolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartseriessettings.html#cfn-quicksight-dashboard-linechartseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartseriessettings.html#cfn-quicksight-dashboard-linechartseriessettings-markerstylesettings
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-categoryitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimitConfiguration { get; set; }
            /// <summary>
            /// ColorItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-coloritemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimitConfiguration { get; set; }
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-smallmultipleslimitconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartConfiguration
            /// </summary>
            public LineChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-lineseriesaxisdisplayoptions.html#cfn-quicksight-dashboard-lineseriesaxisdisplayoptions-missingdataconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MissingDataConfiguration
            /// </summary>
            public List<MissingDataConfiguration> MissingDataConfigurations { get; set; }
            /// <summary>
            /// AxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-lineseriesaxisdisplayoptions.html#cfn-quicksight-dashboard-lineseriesaxisdisplayoptions-axisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions AxisOptions { get; set; }
        }

        public class LinkSharingConfiguration
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linksharingconfiguration.html#cfn-quicksight-dashboard-linksharingconfiguration-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourcePermission
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }
        }

        public class ListControlDisplayOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SearchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-searchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSearchOptions
            /// </summary>
            public ListControlSearchOptions SearchOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-infoiconlabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontrolsearchoptions.html#cfn-quicksight-dashboard-listcontrolsearchoptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontrolselectalloptions.html#cfn-quicksight-dashboard-listcontrolselectalloptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-loadinganimation.html#cfn-quicksight-dashboard-loadinganimation-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-localnavigationconfiguration.html#cfn-quicksight-dashboard-localnavigationconfiguration-targetsheetid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-longformattext.html#cfn-quicksight-dashboard-longformattext-richtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RichText { get; set; }
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-longformattext.html#cfn-quicksight-dashboard-longformattext-plaintext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-mappeddatasetparameter.html#cfn-quicksight-dashboard-mappeddatasetparameter-datasetparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetParameterName { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-mappeddatasetparameter.html#cfn-quicksight-dashboard-mappeddatasetparameter-datasetidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumlabeltype.html#cfn-quicksight-dashboard-maximumlabeltype-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumminimumcomputation.html#cfn-quicksight-dashboard-maximumminimumcomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumminimumcomputation.html#cfn-quicksight-dashboard-maximumminimumcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumminimumcomputation.html#cfn-quicksight-dashboard-maximumminimumcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumminimumcomputation.html#cfn-quicksight-dashboard-maximumminimumcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumminimumcomputation.html#cfn-quicksight-dashboard-maximumminimumcomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-datemeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateMeasureField
            /// </summary>
            public DateMeasureField DateMeasureField { get; set; }
            /// <summary>
            /// NumericalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-numericalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalMeasureField
            /// </summary>
            public NumericalMeasureField NumericalMeasureField { get; set; }
            /// <summary>
            /// CategoricalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-categoricalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalMeasureField
            /// </summary>
            public CategoricalMeasureField CategoricalMeasureField { get; set; }
            /// <summary>
            /// CalculatedMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-calculatedmeasurefield
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField TargetValue { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// FromValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-fromvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField FromValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-minimumlabeltype.html#cfn-quicksight-dashboard-minimumlabeltype-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-missingdataconfiguration.html#cfn-quicksight-dashboard-missingdataconfiguration-treatmentoption
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-negativevalueconfiguration.html#cfn-quicksight-dashboard-negativevalueconfiguration-displaymode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-nullvalueformatconfiguration.html#cfn-quicksight-dashboard-nullvalueformatconfiguration-nullstring
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NumberScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-numberscale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NumberScale { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberformatconfiguration.html#cfn-quicksight-dashboard-numberformatconfiguration-formatconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaxisoptions.html#cfn-quicksight-dashboard-numericaxisoptions-scale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisScale
            /// </summary>
            public AxisScale Scale { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaxisoptions.html#cfn-quicksight-dashboard-numericaxisoptions-range
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalitydrilldownfilter.html#cfn-quicksight-dashboard-numericequalitydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalitydrilldownfilter.html#cfn-quicksight-dashboard-numericequalitydrilldownfilter-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// MatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-matchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOperator { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericformatconfiguration.html#cfn-quicksight-dashboard-numericformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// CurrencyDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericformatconfiguration.html#cfn-quicksight-dashboard-numericformatconfiguration-currencydisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CurrencyDisplayFormatConfiguration
            /// </summary>
            public CurrencyDisplayFormatConfiguration CurrencyDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericformatconfiguration.html#cfn-quicksight-dashboard-numericformatconfiguration-percentagedisplayformatconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilterValue
            /// </summary>
            public NumericRangeFilterValue RangeMinimum { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectAllOptions { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilterValue
            /// </summary>
            public NumericRangeFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-includeminimum
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefiltervalue.html#cfn-quicksight-dashboard-numericrangefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StaticValue { get; set; }
            /// <summary>
            /// Parameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefiltervalue.html#cfn-quicksight-dashboard-numericrangefiltervalue-parameter
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericseparatorconfiguration.html#cfn-quicksight-dashboard-numericseparatorconfiguration-decimalseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DecimalSeparator { get; set; }
            /// <summary>
            /// ThousandsSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericseparatorconfiguration.html#cfn-quicksight-dashboard-numericseparatorconfiguration-thousandsseparator
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalaggregationfunction.html#cfn-quicksight-dashboard-numericalaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentileAggregation
            /// </summary>
            public PercentileAggregation PercentileAggregation { get; set; }
            /// <summary>
            /// SimpleNumericalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalaggregationfunction.html#cfn-quicksight-dashboard-numericalaggregationfunction-simplenumericalaggregation
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaldimensionfield.html#cfn-quicksight-dashboard-numericaldimensionfield-hierarchyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaldimensionfield.html#cfn-quicksight-dashboard-numericaldimensionfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaldimensionfield.html#cfn-quicksight-dashboard-numericaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaldimensionfield.html#cfn-quicksight-dashboard-numericaldimensionfield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public NumericalAggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-paginationconfiguration.html#cfn-quicksight-dashboard-paginationconfiguration-pagesize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PageSize { get; set; }
            /// <summary>
            /// PageNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-paginationconfiguration.html#cfn-quicksight-dashboard-paginationconfiguration-pagenumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-borderthickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderThickness { get; set; }
            /// <summary>
            /// BorderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-borderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderStyle { get; set; }
            /// <summary>
            /// GutterSpacing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-gutterspacing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GutterSpacing { get; set; }
            /// <summary>
            /// BackgroundVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-backgroundvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundVisibility { get; set; }
            /// <summary>
            /// BorderVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-bordervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderVisibility { get; set; }
            /// <summary>
            /// BorderColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-bordercolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderColor { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PanelTitleOptions
            /// </summary>
            public PanelTitleOptions Title { get; set; }
            /// <summary>
            /// GutterVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-guttervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GutterVisibility { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-panelconfiguration.html#cfn-quicksight-dashboard-panelconfiguration-backgroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-paneltitleoptions.html#cfn-quicksight-dashboard-paneltitleoptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-paneltitleoptions.html#cfn-quicksight-dashboard-paneltitleoptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-paneltitleoptions.html#cfn-quicksight-dashboard-paneltitleoptions-horizontaltextalignment
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSliderControl
            /// </summary>
            public ParameterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextAreaControl
            /// </summary>
            public ParameterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDropDownControl
            /// </summary>
            public ParameterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextFieldControl
            /// </summary>
            public ParameterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterListControl
            /// </summary>
            public ParameterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-datetimepicker
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdatetimepickercontrol.html#cfn-quicksight-dashboard-parameterdatetimepickercontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdatetimepickercontrol.html#cfn-quicksight-dashboard-parameterdatetimepickercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimePickerControlDisplayOptions
            /// </summary>
            public DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdatetimepickercontrol.html#cfn-quicksight-dashboard-parameterdatetimepickercontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdatetimepickercontrol.html#cfn-quicksight-dashboard-parameterdatetimepickercontrol-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-stringparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringParameterDeclaration
            /// </summary>
            public StringParameterDeclaration StringParameterDeclaration { get; set; }
            /// <summary>
            /// DateTimeParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-datetimeparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeParameterDeclaration
            /// </summary>
            public DateTimeParameterDeclaration DateTimeParameterDeclaration { get; set; }
            /// <summary>
            /// DecimalParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-decimalparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalParameterDeclaration
            /// </summary>
            public DecimalParameterDeclaration DecimalParameterDeclaration { get; set; }
            /// <summary>
            /// IntegerParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-integerparameterdeclaration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DropDownControlDisplayOptions
            /// </summary>
            public DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-selectablevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlDisplayOptions
            /// </summary>
            public ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterlistcontrol.html#cfn-quicksight-dashboard-parameterlistcontrol-selectablevalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterselectablevalues.html#cfn-quicksight-dashboard-parameterselectablevalues-linktodatasetcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier LinkToDataSetColumn { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterselectablevalues.html#cfn-quicksight-dashboard-parameterselectablevalues-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// StepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-stepsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StepSize { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SliderControlDisplayOptions
            /// </summary>
            public SliderControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// MaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-maximumvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumValue { get; set; }
            /// <summary>
            /// MinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterslidercontrol.html#cfn-quicksight-dashboard-parameterslidercontrol-minimumvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextareacontrol.html#cfn-quicksight-dashboard-parametertextareacontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextareacontrol.html#cfn-quicksight-dashboard-parametertextareacontrol-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextareacontrol.html#cfn-quicksight-dashboard-parametertextareacontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAreaControlDisplayOptions
            /// </summary>
            public TextAreaControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextareacontrol.html#cfn-quicksight-dashboard-parametertextareacontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextareacontrol.html#cfn-quicksight-dashboard-parametertextareacontrol-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextfieldcontrol.html#cfn-quicksight-dashboard-parametertextfieldcontrol-parametercontrolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterControlId { get; set; }
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextfieldcontrol.html#cfn-quicksight-dashboard-parametertextfieldcontrol-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public TextFieldControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SourceParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextfieldcontrol.html#cfn-quicksight-dashboard-parametertextfieldcontrol-sourceparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceParameterName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametertextfieldcontrol.html#cfn-quicksight-dashboard-parametertextfieldcontrol-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-stringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringParameter
            /// </summary>
            public List<StringParameter> StringParameters { get; set; }
            /// <summary>
            /// DecimalParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-decimalparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DecimalParameter
            /// </summary>
            public List<DecimalParameter> DecimalParameters { get; set; }
            /// <summary>
            /// IntegerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-integerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerParameter
            /// </summary>
            public List<IntegerParameter> IntegerParameters { get; set; }
            /// <summary>
            /// DateTimeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-datetimeparameters
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentvisiblerange.html#cfn-quicksight-dashboard-percentvisiblerange-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic From { get; set; }
            /// <summary>
            /// To
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentvisiblerange.html#cfn-quicksight-dashboard-percentvisiblerange-to
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// SeparatorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-separatorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericSeparatorConfiguration
            /// </summary>
            public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentileaggregation.html#cfn-quicksight-dashboard-percentileaggregation-percentilevalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodoverperiodcomputation.html#cfn-quicksight-dashboard-periodoverperiodcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodoverperiodcomputation.html#cfn-quicksight-dashboard-periodoverperiodcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodoverperiodcomputation.html#cfn-quicksight-dashboard-periodoverperiodcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodoverperiodcomputation.html#cfn-quicksight-dashboard-periodoverperiodcomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodtodatecomputation.html#cfn-quicksight-dashboard-periodtodatecomputation-periodtimegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeriodTimeGranularity { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodtodatecomputation.html#cfn-quicksight-dashboard-periodtodatecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodtodatecomputation.html#cfn-quicksight-dashboard-periodtodatecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodtodatecomputation.html#cfn-quicksight-dashboard-periodtodatecomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodtodatecomputation.html#cfn-quicksight-dashboard-periodtodatecomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartaggregatedfieldwells.html#cfn-quicksight-dashboard-piechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartaggregatedfieldwells.html#cfn-quicksight-dashboard-piechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartaggregatedfieldwells.html#cfn-quicksight-dashboard-piechartaggregatedfieldwells-smallmultiples
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartSortConfiguration
            /// </summary>
            public PieChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartFieldWells
            /// </summary>
            public PieChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// DonutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-donutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutOptions
            /// </summary>
            public DonutOptions DonutOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-visualpalette
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartfieldwells.html#cfn-quicksight-dashboard-piechartfieldwells-piechartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-smallmultipleslimitconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartConfiguration
            /// </summary>
            public PieChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivotfieldsortoptions.html#cfn-quicksight-dashboard-pivotfieldsortoptions-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableSortBy
            /// </summary>
            public PivotTableSortBy SortBy { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivotfieldsortoptions.html#cfn-quicksight-dashboard-pivotfieldsortoptions-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableaggregatedfieldwells.html#cfn-quicksight-dashboard-pivottableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableaggregatedfieldwells.html#cfn-quicksight-dashboard-pivottableaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableaggregatedfieldwells.html#cfn-quicksight-dashboard-pivottableaggregatedfieldwells-rows
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablecellconditionalformatting.html#cfn-quicksight-dashboard-pivottablecellconditionalformatting-scope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormattingScope
            /// </summary>
            public PivotTableConditionalFormattingScope Scope { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablecellconditionalformatting.html#cfn-quicksight-dashboard-pivottablecellconditionalformatting-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingScope
            /// </summary>
            public List<PivotTableConditionalFormattingScope> Scopes { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablecellconditionalformatting.html#cfn-quicksight-dashboard-pivottablecellconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablecellconditionalformatting.html#cfn-quicksight-dashboard-pivottablecellconditionalformatting-textformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconditionalformatting.html#cfn-quicksight-dashboard-pivottableconditionalformatting-conditionalformattingoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconditionalformattingoption.html#cfn-quicksight-dashboard-pivottableconditionalformattingoption-cell
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconditionalformattingscope.html#cfn-quicksight-dashboard-pivottableconditionalformattingscope-role
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableSortConfiguration
            /// </summary>
            public PivotTableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTablePaginatedReportOptions
            /// </summary>
            public PivotTablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableOptions
            /// </summary>
            public PivotTableOptions TableOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldWells
            /// </summary>
            public PivotTableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldOptions
            /// </summary>
            public PivotTableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-totaloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabledatapathoption.html#cfn-quicksight-dashboard-pivottabledatapathoption-datapathlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<DataPathValue> DataPathList { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabledatapathoption.html#cfn-quicksight-dashboard-pivottabledatapathoption-width
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldcollapsestateoption.html#cfn-quicksight-dashboard-pivottablefieldcollapsestateoption-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableFieldCollapseStateTarget
            /// </summary>
            public PivotTableFieldCollapseStateTarget Target { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldcollapsestateoption.html#cfn-quicksight-dashboard-pivottablefieldcollapsestateoption-state
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldcollapsestatetarget.html#cfn-quicksight-dashboard-pivottablefieldcollapsestatetarget-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// FieldDataPathValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldcollapsestatetarget.html#cfn-quicksight-dashboard-pivottablefieldcollapsestatetarget-fielddatapathvalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoption.html#cfn-quicksight-dashboard-pivottablefieldoption-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoption.html#cfn-quicksight-dashboard-pivottablefieldoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoption.html#cfn-quicksight-dashboard-pivottablefieldoption-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoptions.html#cfn-quicksight-dashboard-pivottablefieldoptions-collapsestateoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldCollapseStateOption
            /// </summary>
            public List<PivotTableFieldCollapseStateOption> CollapseStateOptions { get; set; }
            /// <summary>
            /// DataPathOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoptions.html#cfn-quicksight-dashboard-pivottablefieldoptions-datapathoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableDataPathOption
            /// </summary>
            public List<PivotTableDataPathOption> DataPathOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoptions.html#cfn-quicksight-dashboard-pivottablefieldoptions-selectedfieldoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldsubtotaloptions.html#cfn-quicksight-dashboard-pivottablefieldsubtotaloptions-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldwells.html#cfn-quicksight-dashboard-pivottablefieldwells-pivottableaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowfieldnamesstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle RowFieldNamesStyle { get; set; }
            /// <summary>
            /// RowHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle RowHeaderStyle { get; set; }
            /// <summary>
            /// CollapsedRowDimensionsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-collapsedrowdimensionsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollapsedRowDimensionsVisibility { get; set; }
            /// <summary>
            /// RowsLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowslayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RowsLayout { get; set; }
            /// <summary>
            /// MetricPlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-metricplacement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricPlacement { get; set; }
            /// <summary>
            /// DefaultCellWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-defaultcellwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultCellWidth { get; set; }
            /// <summary>
            /// ColumnNamesVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-columnnamesvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnNamesVisibility { get; set; }
            /// <summary>
            /// RowsLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowslabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableRowsLabelOptions
            /// </summary>
            public PivotTableRowsLabelOptions RowsLabelOptions { get; set; }
            /// <summary>
            /// SingleMetricVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-singlemetricvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SingleMetricVisibility { get; set; }
            /// <summary>
            /// ColumnHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-columnheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle ColumnHeaderStyle { get; set; }
            /// <summary>
            /// ToggleButtonsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-togglebuttonsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToggleButtonsVisibility { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowalternatecoloroptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablepaginatedreportoptions.html#cfn-quicksight-dashboard-pivottablepaginatedreportoptions-overflowcolumnheadervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverflowColumnHeaderVisibility { get; set; }
            /// <summary>
            /// VerticalOverflowVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablepaginatedreportoptions.html#cfn-quicksight-dashboard-pivottablepaginatedreportoptions-verticaloverflowvisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablerowslabeloptions.html#cfn-quicksight-dashboard-pivottablerowslabeloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablerowslabeloptions.html#cfn-quicksight-dashboard-pivottablerowslabeloptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortby.html#cfn-quicksight-dashboard-pivottablesortby-field
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public FieldSort Field { get; set; }
            /// <summary>
            /// DataPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortby.html#cfn-quicksight-dashboard-pivottablesortby-datapath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathSort
            /// </summary>
            public DataPathSort DataPath { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortby.html#cfn-quicksight-dashboard-pivottablesortby-column
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortconfiguration.html#cfn-quicksight-dashboard-pivottablesortconfiguration-fieldsortoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-columnsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public SubtotalOptions ColumnSubtotalOptions { get; set; }
            /// <summary>
            /// RowSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-rowsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public SubtotalOptions RowSubtotalOptions { get; set; }
            /// <summary>
            /// RowTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-rowtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public PivotTotalOptions RowTotalOptions { get; set; }
            /// <summary>
            /// ColumnTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-columntotaloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormatting
            /// </summary>
            public PivotTableConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConfiguration
            /// </summary>
            public PivotTableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<TotalAggregationOption> TotalAggregationOptions { get; set; }
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// ScrollStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-scrollstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScrollStatus { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// MetricHeaderCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-metricheadercellstyle
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-predefinedhierarchy.html#cfn-quicksight-dashboard-predefinedhierarchy-hierarchyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HierarchyId { get; set; }
            /// <summary>
            /// DrillDownFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-predefinedhierarchy.html#cfn-quicksight-dashboard-predefinedhierarchy-drilldownfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DrillDownFilter
            /// </summary>
            public List<DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-predefinedhierarchy.html#cfn-quicksight-dashboard-predefinedhierarchy-columns
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-progressbaroptions.html#cfn-quicksight-dashboard-progressbaroptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartaggregatedfieldwells.html#cfn-quicksight-dashboard-radarchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartaggregatedfieldwells.html#cfn-quicksight-dashboard-radarchartaggregatedfieldwells-color
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Color { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartaggregatedfieldwells.html#cfn-quicksight-dashboard-radarchartaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartareastylesettings.html#cfn-quicksight-dashboard-radarchartareastylesettings-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSortConfiguration
            /// </summary>
            public RadarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-shape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Shape { get; set; }
            /// <summary>
            /// BaseSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-baseseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSeriesSettings
            /// </summary>
            public RadarChartSeriesSettings BaseSeriesSettings { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// AxesRangeScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-axesrangescale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxesRangeScale { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// AlternateBandColorsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-alternatebandcolorsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandColorsVisibility { get; set; }
            /// <summary>
            /// StartAngle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-startangle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartAngle { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartFieldWells
            /// </summary>
            public RadarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ColorAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-coloraxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions ColorAxis { get; set; }
            /// <summary>
            /// AlternateBandOddColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-alternatebandoddcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateBandOddColor { get; set; }
            /// <summary>
            /// AlternateBandEvenColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-alternatebandevencolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartfieldwells.html#cfn-quicksight-dashboard-radarchartfieldwells-radarchartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartseriessettings.html#cfn-quicksight-dashboard-radarchartseriessettings-areastylesettings
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-categorysort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartConfiguration
            /// </summary>
            public RadarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-rangeendslabeltype.html#cfn-quicksight-dashboard-rangeendslabeltype-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referenceline.html#cfn-quicksight-dashboard-referenceline-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// DataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referenceline.html#cfn-quicksight-dashboard-referenceline-dataconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReferenceLineDataConfiguration
            /// </summary>
            public ReferenceLineDataConfiguration DataConfiguration { get; set; }
            /// <summary>
            /// LabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referenceline.html#cfn-quicksight-dashboard-referenceline-labelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineLabelConfiguration
            /// </summary>
            public ReferenceLineLabelConfiguration LabelConfiguration { get; set; }
            /// <summary>
            /// StyleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referenceline.html#cfn-quicksight-dashboard-referenceline-styleconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinecustomlabelconfiguration.html#cfn-quicksight-dashboard-referencelinecustomlabelconfiguration-customlabel
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedataconfiguration.html#cfn-quicksight-dashboard-referencelinedataconfiguration-dynamicconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineDynamicDataConfiguration
            /// </summary>
            public ReferenceLineDynamicDataConfiguration DynamicConfiguration { get; set; }
            /// <summary>
            /// AxisBinding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedataconfiguration.html#cfn-quicksight-dashboard-referencelinedataconfiguration-axisbinding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisBinding { get; set; }
            /// <summary>
            /// SeriesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedataconfiguration.html#cfn-quicksight-dashboard-referencelinedataconfiguration-seriestype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SeriesType { get; set; }
            /// <summary>
            /// StaticConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedataconfiguration.html#cfn-quicksight-dashboard-referencelinedataconfiguration-staticconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedynamicdataconfiguration.html#cfn-quicksight-dashboard-referencelinedynamicdataconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// MeasureAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedynamicdataconfiguration.html#cfn-quicksight-dashboard-referencelinedynamicdataconfiguration-measureaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public AggregationFunction MeasureAggregationFunction { get; set; }
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedynamicdataconfiguration.html#cfn-quicksight-dashboard-referencelinedynamicdataconfiguration-calculation
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-horizontalposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalPosition { get; set; }
            /// <summary>
            /// ValueLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-valuelabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineValueLabelConfiguration
            /// </summary>
            public ReferenceLineValueLabelConfiguration ValueLabelConfiguration { get; set; }
            /// <summary>
            /// CustomLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-customlabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineCustomLabelConfiguration
            /// </summary>
            public ReferenceLineCustomLabelConfiguration CustomLabelConfiguration { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// VerticalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-verticalposition
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinestaticdataconfiguration.html#cfn-quicksight-dashboard-referencelinestaticdataconfiguration-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinestyleconfiguration.html#cfn-quicksight-dashboard-referencelinestyleconfiguration-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinestyleconfiguration.html#cfn-quicksight-dashboard-referencelinestyleconfiguration-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinevaluelabelconfiguration.html#cfn-quicksight-dashboard-referencelinevaluelabelconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// RelativePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinevaluelabelconfiguration.html#cfn-quicksight-dashboard-referencelinevaluelabelconfiguration-relativeposition
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatetimecontroldisplayoptions.html#cfn-quicksight-dashboard-relativedatetimecontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatetimecontroldisplayoptions.html#cfn-quicksight-dashboard-relativedatetimecontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatetimecontroldisplayoptions.html#cfn-quicksight-dashboard-relativedatetimecontroldisplayoptions-datetimeformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-relativedatevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RelativeDateValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RelativeDateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-relativedatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativeDateType { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-timegranularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// AnchorDateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-anchordateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AnchorDateConfiguration
            /// </summary>
            public AnchorDateConfiguration AnchorDateConfiguration { get; set; }
            /// <summary>
            /// MinimumGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-minimumgranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinimumGranularity { get; set; }
            /// <summary>
            /// ExcludePeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatesfilter.html#cfn-quicksight-dashboard-relativedatesfilter-excludeperiodconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-resourcepermission.html#cfn-quicksight-dashboard-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-resourcepermission.html#cfn-quicksight-dashboard-resourcepermission-principal
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-rollingdateconfiguration.html#cfn-quicksight-dashboard-rollingdateconfiguration-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-rollingdateconfiguration.html#cfn-quicksight-dashboard-rollingdateconfiguration-datasetidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-rowalternatecoloroptions.html#cfn-quicksight-dashboard-rowalternatecoloroptions-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// UsePrimaryBackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-rowalternatecoloroptions.html#cfn-quicksight-dashboard-rowalternatecoloroptions-useprimarybackgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsePrimaryBackgroundColor { get; set; }
            /// <summary>
            /// RowAlternateColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-rowalternatecoloroptions.html#cfn-quicksight-dashboard-rowalternatecoloroptions-rowalternatecolors
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-samesheettargetvisualconfiguration.html#cfn-quicksight-dashboard-samesheettargetvisualconfiguration-targetvisualoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetVisualOptions { get; set; }
            /// <summary>
            /// TargetVisuals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-samesheettargetvisualconfiguration.html#cfn-quicksight-dashboard-samesheettargetvisualconfiguration-targetvisuals
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-dashboard-sankeydiagramaggregatedfieldwells-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-dashboard-sankeydiagramaggregatedfieldwells-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Source { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-dashboard-sankeydiagramaggregatedfieldwells-weight
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramchartconfiguration.html#cfn-quicksight-dashboard-sankeydiagramchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramSortConfiguration
            /// </summary>
            public SankeyDiagramSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramchartconfiguration.html#cfn-quicksight-dashboard-sankeydiagramchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramchartconfiguration.html#cfn-quicksight-dashboard-sankeydiagramchartconfiguration-fieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramfieldwells.html#cfn-quicksight-dashboard-sankeydiagramfieldwells-sankeydiagramaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramsortconfiguration.html#cfn-quicksight-dashboard-sankeydiagramsortconfiguration-weightsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> WeightSort { get; set; }
            /// <summary>
            /// SourceItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramsortconfiguration.html#cfn-quicksight-dashboard-sankeydiagramsortconfiguration-sourceitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration SourceItemsLimit { get; set; }
            /// <summary>
            /// DestinationItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramsortconfiguration.html#cfn-quicksight-dashboard-sankeydiagramsortconfiguration-destinationitemslimit
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramChartConfiguration
            /// </summary>
            public SankeyDiagramChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-yaxis
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-yaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions YAxisLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotFieldWells
            /// </summary>
            public ScatterPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-xaxisdisplayoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotfieldwells.html#cfn-quicksight-dashboard-scatterplotfieldwells-scatterplotunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotUnaggregatedFieldWells
            /// </summary>
            public ScatterPlotUnaggregatedFieldWells ScatterPlotUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// ScatterPlotCategoricallyAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotfieldwells.html#cfn-quicksight-dashboard-scatterplotfieldwells-scatterplotcategoricallyaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-yaxis
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotConfiguration
            /// </summary>
            public ScatterPlotConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scrollbaroptions.html#cfn-quicksight-dashboard-scrollbaroptions-visiblerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisibleRangeOptions
            /// </summary>
            public VisibleRangeOptions VisibleRange { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scrollbaroptions.html#cfn-quicksight-dashboard-scrollbaroptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-secondaryvalueoptions.html#cfn-quicksight-dashboard-secondaryvalueoptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionafterpagebreak.html#cfn-quicksight-dashboard-sectionafterpagebreak-status
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutcanvassizeoptions.html#cfn-quicksight-dashboard-sectionbasedlayoutcanvassizeoptions-papercanvassizeoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// FooterSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-footersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<HeaderFooterSectionConfiguration> FooterSections { get; set; }
            /// <summary>
            /// BodySections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-bodysections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BodySectionConfiguration
            /// </summary>
            public List<BodySectionConfiguration> BodySections { get; set; }
            /// <summary>
            /// HeaderSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-headersections
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions-papermargin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Spacing PaperMargin { get; set; }
            /// <summary>
            /// PaperSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions-papersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PaperSize { get; set; }
            /// <summary>
            /// PaperOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions-paperorientation
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionlayoutconfiguration.html#cfn-quicksight-dashboard-sectionlayoutconfiguration-freeformlayout
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionpagebreakconfiguration.html#cfn-quicksight-dashboard-sectionpagebreakconfiguration-after
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionstyle.html#cfn-quicksight-dashboard-sectionstyle-padding
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Spacing Padding { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionstyle.html#cfn-quicksight-dashboard-sectionstyle-height
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-selectedsheetsfilterscopeconfiguration.html#cfn-quicksight-dashboard-selectedsheetsfilterscopeconfiguration-sheetvisualscopingconfigurations
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-seriesitem.html#cfn-quicksight-dashboard-seriesitem-fieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSeriesItem
            /// </summary>
            public FieldSeriesItem FieldSeriesItem { get; set; }
            /// <summary>
            /// DataFieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-seriesitem.html#cfn-quicksight-dashboard-seriesitem-datafieldseriesitem
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-setparametervalueconfiguration.html#cfn-quicksight-dashboard-setparametervalueconfiguration-destinationparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationParameterName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-setparametervalueconfiguration.html#cfn-quicksight-dashboard-setparametervalueconfiguration-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-shapeconditionalformat.html#cfn-quicksight-dashboard-shapeconditionalformat-backgroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheet.html#cfn-quicksight-dashboard-sheet-sheetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheet.html#cfn-quicksight-dashboard-sheet-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrolinfoiconlabeloptions.html#cfn-quicksight-dashboard-sheetcontrolinfoiconlabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// InfoIconText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrolinfoiconlabeloptions.html#cfn-quicksight-dashboard-sheetcontrolinfoiconlabeloptions-infoicontext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrollayout.html#cfn-quicksight-dashboard-sheetcontrollayout-configuration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrollayoutconfiguration.html#cfn-quicksight-dashboard-sheetcontrollayoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public GridLayoutConfiguration GridLayout { get; set; }
        }

        public class SheetControlsOption
        {
            /// <summary>
            /// VisibilityState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrolsoption.html#cfn-quicksight-dashboard-sheetcontrolsoption-visibilitystate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisibilityState { get; set; }
        }

        public class SheetDefinition
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ParameterControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-parametercontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterControl
            /// </summary>
            public List<ParameterControl> ParameterControls { get; set; }
            /// <summary>
            /// TextBoxes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-textboxes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetTextBox
            /// </summary>
            public List<SheetTextBox> TextBoxes { get; set; }
            /// <summary>
            /// Layouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-layouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Layout
            /// </summary>
            public List<Layout> Layouts { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-sheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// FilterControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-filtercontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterControl
            /// </summary>
            public List<FilterControl> FilterControls { get; set; }
            /// <summary>
            /// SheetControlLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-sheetcontrollayouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetControlLayout
            /// </summary>
            public List<SheetControlLayout> SheetControlLayouts { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// Visuals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-visuals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Visual
            /// </summary>
            public List<Visual> Visuals { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetelementconfigurationoverrides.html#cfn-quicksight-dashboard-sheetelementconfigurationoverrides-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetelementrenderingrule.html#cfn-quicksight-dashboard-sheetelementrenderingrule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// ConfigurationOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetelementrenderingrule.html#cfn-quicksight-dashboard-sheetelementrenderingrule-configurationoverrides
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetElementConfigurationOverrides
            /// </summary>
            public SheetElementConfigurationOverrides ConfigurationOverrides { get; set; }
        }

        public class SheetLayoutElementMaximizationOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetlayoutelementmaximizationoption.html#cfn-quicksight-dashboard-sheetlayoutelementmaximizationoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class SheetTextBox
        {
            /// <summary>
            /// SheetTextBoxId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheettextbox.html#cfn-quicksight-dashboard-sheettextbox-sheettextboxid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetTextBoxId { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheettextbox.html#cfn-quicksight-dashboard-sheettextbox-content
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetvisualscopingconfiguration.html#cfn-quicksight-dashboard-sheetvisualscopingconfiguration-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// SheetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetvisualscopingconfiguration.html#cfn-quicksight-dashboard-sheetvisualscopingconfiguration-sheetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetId { get; set; }
            /// <summary>
            /// VisualIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetvisualscopingconfiguration.html#cfn-quicksight-dashboard-sheetvisualscopingconfiguration-visualids
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-shortformattext.html#cfn-quicksight-dashboard-shortformattext-richtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RichText { get; set; }
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-shortformattext.html#cfn-quicksight-dashboard-shortformattext-plaintext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-simpleclustermarker.html#cfn-quicksight-dashboard-simpleclustermarker-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-slidercontroldisplayoptions.html#cfn-quicksight-dashboard-slidercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-slidercontroldisplayoptions.html#cfn-quicksight-dashboard-slidercontroldisplayoptions-infoiconlabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesaxisproperties.html#cfn-quicksight-dashboard-smallmultiplesaxisproperties-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesaxisproperties.html#cfn-quicksight-dashboard-smallmultiplesaxisproperties-scale
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesoptions.html#cfn-quicksight-dashboard-smallmultiplesoptions-maxvisiblerows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxVisibleRows { get; set; }
            /// <summary>
            /// PanelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesoptions.html#cfn-quicksight-dashboard-smallmultiplesoptions-panelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PanelConfiguration
            /// </summary>
            public PanelConfiguration PanelConfiguration { get; set; }
            /// <summary>
            /// MaxVisibleColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesoptions.html#cfn-quicksight-dashboard-smallmultiplesoptions-maxvisiblecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxVisibleColumns { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesoptions.html#cfn-quicksight-dashboard-smallmultiplesoptions-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public SmallMultiplesAxisProperties XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesoptions.html#cfn-quicksight-dashboard-smallmultiplesoptions-yaxis
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-spacing.html#cfn-quicksight-dashboard-spacing-left
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-spacing.html#cfn-quicksight-dashboard-spacing-top
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Top { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-spacing.html#cfn-quicksight-dashboard-spacing-right
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-spacing.html#cfn-quicksight-dashboard-spacing-bottom
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringdefaultvalues.html#cfn-quicksight-dashboard-stringdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public DynamicDefaultValue DynamicValue { get; set; }
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringdefaultvalues.html#cfn-quicksight-dashboard-stringdefaultvalues-staticvalues
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringformatconfiguration.html#cfn-quicksight-dashboard-stringformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringformatconfiguration.html#cfn-quicksight-dashboard-stringformatconfiguration-nullvalueformatconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameter.html#cfn-quicksight-dashboard-stringparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameter.html#cfn-quicksight-dashboard-stringparameter-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDefaultValues
            /// </summary>
            public StringDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// ParameterValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-parametervaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValueType { get; set; }
            /// <summary>
            /// ValueWhenUnset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-valuewhenunset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringValueWhenUnsetConfiguration
            /// </summary>
            public StringValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringvaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-stringvaluewhenunsetconfiguration-valuewhenunsetoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueWhenUnsetOption { get; set; }
            /// <summary>
            /// CustomValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringvaluewhenunsetconfiguration.html#cfn-quicksight-dashboard-stringvaluewhenunsetconfiguration-customvalue
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// FieldLevelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-fieldleveloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldSubtotalOptions
            /// </summary>
            public List<PivotTableFieldSubtotalOptions> FieldLevelOptions { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
            /// <summary>
            /// FieldLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-fieldlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldLevel { get; set; }
            /// <summary>
            /// MetricHeaderCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-metricheadercellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle MetricHeaderCellStyle { get; set; }
            /// <summary>
            /// StyleTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-styletargets
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableaggregatedfieldwells.html#cfn-quicksight-dashboard-tableaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableaggregatedfieldwells.html#cfn-quicksight-dashboard-tableaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableborderoptions.html#cfn-quicksight-dashboard-tableborderoptions-thickness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Thickness { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableborderoptions.html#cfn-quicksight-dashboard-tableborderoptions-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableborderoptions.html#cfn-quicksight-dashboard-tableborderoptions-style
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellconditionalformatting.html#cfn-quicksight-dashboard-tablecellconditionalformatting-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TextFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellconditionalformatting.html#cfn-quicksight-dashboard-tablecellconditionalformatting-textformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellimagesizingconfiguration.html#cfn-quicksight-dashboard-tablecellimagesizingconfiguration-tablecellimagescalingconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-verticaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerticalTextAlignment { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalTableBorderOptions
            /// </summary>
            public GlobalTableBorderOptions Border { get; set; }
            /// <summary>
            /// TextWrap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-textwrap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextWrap { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-horizontaltextalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HorizontalTextAlignment { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-backgroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconditionalformatting.html#cfn-quicksight-dashboard-tableconditionalformatting-conditionalformattingoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconditionalformattingoption.html#cfn-quicksight-dashboard-tableconditionalformattingoption-row
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableRowConditionalFormatting
            /// </summary>
            public TableRowConditionalFormatting Row { get; set; }
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconditionalformattingoption.html#cfn-quicksight-dashboard-tableconditionalformattingoption-cell
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSortConfiguration
            /// </summary>
            public TableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePaginatedReportOptions
            /// </summary>
            public TablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableOptions
            /// </summary>
            public TableOptions TableOptions { get; set; }
            /// <summary>
            /// TableInlineVisualizations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-tableinlinevisualizations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableInlineVisualization
            /// </summary>
            public List<TableInlineVisualization> TableInlineVisualizations { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldWells
            /// </summary>
            public TableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldOptions
            /// </summary>
            public TableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-totaloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldcustomiconcontent.html#cfn-quicksight-dashboard-tablefieldcustomiconcontent-icon
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldcustomtextcontent.html#cfn-quicksight-dashboard-tablefieldcustomtextcontent-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldcustomtextcontent.html#cfn-quicksight-dashboard-tablefieldcustomtextcontent-fontconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldimageconfiguration.html#cfn-quicksight-dashboard-tablefieldimageconfiguration-sizingoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldlinkconfiguration.html#cfn-quicksight-dashboard-tablefieldlinkconfiguration-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldlinkconfiguration.html#cfn-quicksight-dashboard-tablefieldlinkconfiguration-content
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldlinkcontentconfiguration.html#cfn-quicksight-dashboard-tablefieldlinkcontentconfiguration-customiconcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomIconContent
            /// </summary>
            public TableFieldCustomIconContent CustomIconContent { get; set; }
            /// <summary>
            /// CustomTextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldlinkcontentconfiguration.html#cfn-quicksight-dashboard-tablefieldlinkcontentconfiguration-customtextcontent
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoption.html#cfn-quicksight-dashboard-tablefieldoption-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// URLStyling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoption.html#cfn-quicksight-dashboard-tablefieldoption-urlstyling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldURLConfiguration
            /// </summary>
            public TableFieldURLConfiguration URLStyling { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoption.html#cfn-quicksight-dashboard-tablefieldoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoption.html#cfn-quicksight-dashboard-tablefieldoption-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoption.html#cfn-quicksight-dashboard-tablefieldoption-width
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoptions.html#cfn-quicksight-dashboard-tablefieldoptions-order
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Order { get; set; }
            /// <summary>
            /// PinnedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoptions.html#cfn-quicksight-dashboard-tablefieldoptions-pinnedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePinnedFieldOptions
            /// </summary>
            public TablePinnedFieldOptions PinnedFieldOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoptions.html#cfn-quicksight-dashboard-tablefieldoptions-selectedfieldoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldurlconfiguration.html#cfn-quicksight-dashboard-tablefieldurlconfiguration-linkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldLinkConfiguration
            /// </summary>
            public TableFieldLinkConfiguration LinkConfiguration { get; set; }
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldurlconfiguration.html#cfn-quicksight-dashboard-tablefieldurlconfiguration-imageconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldwells.html#cfn-quicksight-dashboard-tablefieldwells-tableunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableUnaggregatedFieldWells
            /// </summary>
            public TableUnaggregatedFieldWells TableUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// TableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldwells.html#cfn-quicksight-dashboard-tablefieldwells-tableaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableinlinevisualization.html#cfn-quicksight-dashboard-tableinlinevisualization-databars
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableoptions.html#cfn-quicksight-dashboard-tableoptions-headerstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle HeaderStyle { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableoptions.html#cfn-quicksight-dashboard-tableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// Orientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableoptions.html#cfn-quicksight-dashboard-tableoptions-orientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Orientation { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableoptions.html#cfn-quicksight-dashboard-tableoptions-rowalternatecoloroptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablepaginatedreportoptions.html#cfn-quicksight-dashboard-tablepaginatedreportoptions-overflowcolumnheadervisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverflowColumnHeaderVisibility { get; set; }
            /// <summary>
            /// VerticalOverflowVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablepaginatedreportoptions.html#cfn-quicksight-dashboard-tablepaginatedreportoptions-verticaloverflowvisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablepinnedfieldoptions.html#cfn-quicksight-dashboard-tablepinnedfieldoptions-pinnedleftfields
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablerowconditionalformatting.html#cfn-quicksight-dashboard-tablerowconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablerowconditionalformatting.html#cfn-quicksight-dashboard-tablerowconditionalformatting-backgroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-left
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-top
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Top { get; set; }
            /// <summary>
            /// InnerHorizontal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-innerhorizontal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions InnerHorizontal { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-right
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public TableBorderOptions Bottom { get; set; }
            /// <summary>
            /// InnerVertical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-innervertical
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesortconfiguration.html#cfn-quicksight-dashboard-tablesortconfiguration-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> RowSort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesortconfiguration.html#cfn-quicksight-dashboard-tablesortconfiguration-paginationconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablestyletarget.html#cfn-quicksight-dashboard-tablestyletarget-celltype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableunaggregatedfieldwells.html#cfn-quicksight-dashboard-tableunaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConditionalFormatting
            /// </summary>
            public TableConditionalFormatting ConditionalFormatting { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConfiguration
            /// </summary>
            public TableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textareacontroldisplayoptions.html#cfn-quicksight-dashboard-textareacontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textareacontroldisplayoptions.html#cfn-quicksight-dashboard-textareacontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textareacontroldisplayoptions.html#cfn-quicksight-dashboard-textareacontroldisplayoptions-infoiconlabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textconditionalformat.html#cfn-quicksight-dashboard-textconditionalformat-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textconditionalformat.html#cfn-quicksight-dashboard-textconditionalformat-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public ConditionalFormattingIcon Icon { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textconditionalformat.html#cfn-quicksight-dashboard-textconditionalformat-backgroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textcontrolplaceholderoptions.html#cfn-quicksight-dashboard-textcontrolplaceholderoptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textfieldcontroldisplayoptions.html#cfn-quicksight-dashboard-textfieldcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textfieldcontroldisplayoptions.html#cfn-quicksight-dashboard-textfieldcontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textfieldcontroldisplayoptions.html#cfn-quicksight-dashboard-textfieldcontroldisplayoptions-infoiconlabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-thousandseparatoroptions.html#cfn-quicksight-dashboard-thousandseparatoroptions-symbol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Symbol { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-thousandseparatoroptions.html#cfn-quicksight-dashboard-thousandseparatoroptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timebasedforecastproperties.html#cfn-quicksight-dashboard-timebasedforecastproperties-periodsbackward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsBackward { get; set; }
            /// <summary>
            /// PeriodsForward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timebasedforecastproperties.html#cfn-quicksight-dashboard-timebasedforecastproperties-periodsforward
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeriodsForward { get; set; }
            /// <summary>
            /// PredictionInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timebasedforecastproperties.html#cfn-quicksight-dashboard-timebasedforecastproperties-predictioninterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PredictionInterval { get; set; }
            /// <summary>
            /// Seasonality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timebasedforecastproperties.html#cfn-quicksight-dashboard-timebasedforecastproperties-seasonality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Seasonality { get; set; }
            /// <summary>
            /// UpperBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timebasedforecastproperties.html#cfn-quicksight-dashboard-timebasedforecastproperties-upperboundary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperBoundary { get; set; }
            /// <summary>
            /// LowerBoundary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timebasedforecastproperties.html#cfn-quicksight-dashboard-timebasedforecastproperties-lowerboundary
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangedrilldownfilter.html#cfn-quicksight-dashboard-timerangedrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangedrilldownfilter.html#cfn-quicksight-dashboard-timerangedrilldownfilter-rangeminimum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeMinimum { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangedrilldownfilter.html#cfn-quicksight-dashboard-timerangedrilldownfilter-timegranularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangedrilldownfilter.html#cfn-quicksight-dashboard-timerangedrilldownfilter-rangemaximum
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-rangeminimumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public TimeRangeFilterValue RangeMinimumValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-rangemaximumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public TimeRangeFilterValue RangeMaximumValue { get; set; }
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// NullOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-nulloption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullOption { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
            /// <summary>
            /// ExcludePeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-excludeperiodconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefiltervalue.html#cfn-quicksight-dashboard-timerangefiltervalue-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefiltervalue.html#cfn-quicksight-dashboard-timerangefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticValue { get; set; }
            /// <summary>
            /// Parameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefiltervalue.html#cfn-quicksight-dashboard-timerangefiltervalue-parameter
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipitem.html#cfn-quicksight-dashboard-tooltipitem-fieldtooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldTooltipItem
            /// </summary>
            public FieldTooltipItem FieldTooltipItem { get; set; }
            /// <summary>
            /// ColumnTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipitem.html#cfn-quicksight-dashboard-tooltipitem-columntooltipitem
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipoptions.html#cfn-quicksight-dashboard-tooltipoptions-selectedtooltiptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectedTooltipType { get; set; }
            /// <summary>
            /// TooltipVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipoptions.html#cfn-quicksight-dashboard-tooltipoptions-tooltipvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipVisibility { get; set; }
            /// <summary>
            /// FieldBasedTooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipoptions.html#cfn-quicksight-dashboard-tooltipoptions-fieldbasedtooltip
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-aggregationsortconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationSortConfiguration
            /// </summary>
            public List<AggregationSortConfiguration> AggregationSortConfigurations { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-parametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Limit { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Category { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-sortorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortOrder { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Time { get; set; }
            /// <summary>
            /// MoverSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-moversize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MoverSize { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomrankedcomputation.html#cfn-quicksight-dashboard-topbottomrankedcomputation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomrankedcomputation.html#cfn-quicksight-dashboard-topbottomrankedcomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Category { get; set; }
            /// <summary>
            /// ResultSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomrankedcomputation.html#cfn-quicksight-dashboard-topbottomrankedcomputation-resultsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResultSize { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomrankedcomputation.html#cfn-quicksight-dashboard-topbottomrankedcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomrankedcomputation.html#cfn-quicksight-dashboard-topbottomrankedcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomrankedcomputation.html#cfn-quicksight-dashboard-topbottomrankedcomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationcomputation.html#cfn-quicksight-dashboard-totalaggregationcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public MeasureField Value { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationcomputation.html#cfn-quicksight-dashboard-totalaggregationcomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationcomputation.html#cfn-quicksight-dashboard-totalaggregationcomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationfunction.html#cfn-quicksight-dashboard-totalaggregationfunction-simpletotalaggregationfunction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationoption.html#cfn-quicksight-dashboard-totalaggregationoption-totalaggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TotalAggregationFunction
            /// </summary>
            public TotalAggregationFunction TotalAggregationFunction { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationoption.html#cfn-quicksight-dashboard-totalaggregationoption-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<TotalAggregationOption> TotalAggregationOptions { get; set; }
            /// <summary>
            /// CustomLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-customlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomLabel { get; set; }
            /// <summary>
            /// ScrollStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-scrollstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScrollStatus { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-placement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Placement { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-totalsvisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapaggregatedfieldwells.html#cfn-quicksight-dashboard-treemapaggregatedfieldwells-sizes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Sizes { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapaggregatedfieldwells.html#cfn-quicksight-dashboard-treemapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<MeasureField> Colors { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapaggregatedfieldwells.html#cfn-quicksight-dashboard-treemapaggregatedfieldwells-groups
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapSortConfiguration
            /// </summary>
            public TreeMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// SizeLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-sizelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions SizeLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapFieldWells
            /// </summary>
            public TreeMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public ColorScale ColorScale { get; set; }
            /// <summary>
            /// GroupLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-grouplabeloptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapfieldwells.html#cfn-quicksight-dashboard-treemapfieldwells-treemapaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapsortconfiguration.html#cfn-quicksight-dashboard-treemapsortconfiguration-treemapsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<FieldSortOptions> TreeMapSort { get; set; }
            /// <summary>
            /// TreeMapGroupItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapsortconfiguration.html#cfn-quicksight-dashboard-treemapsortconfiguration-treemapgroupitemslimitconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapConfiguration
            /// </summary>
            public TreeMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-trendarrowoptions.html#cfn-quicksight-dashboard-trendarrowoptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-unaggregatedfield.html#cfn-quicksight-dashboard-unaggregatedfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-unaggregatedfield.html#cfn-quicksight-dashboard-unaggregatedfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-unaggregatedfield.html#cfn-quicksight-dashboard-unaggregatedfield-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-uniquevaluescomputation.html#cfn-quicksight-dashboard-uniquevaluescomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public DimensionField Category { get; set; }
            /// <summary>
            /// ComputationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-uniquevaluescomputation.html#cfn-quicksight-dashboard-uniquevaluescomputation-computationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputationId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-uniquevaluescomputation.html#cfn-quicksight-dashboard-uniquevaluescomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-validationstrategy.html#cfn-quicksight-dashboard-validationstrategy-mode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visiblerangeoptions.html#cfn-quicksight-dashboard-visiblerangeoptions-percentrange
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-funnelchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartVisual
            /// </summary>
            public FunnelChartVisual FunnelChartVisual { get; set; }
            /// <summary>
            /// FilledMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-filledmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapVisual
            /// </summary>
            public FilledMapVisual FilledMapVisual { get; set; }
            /// <summary>
            /// BoxPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-boxplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotVisual
            /// </summary>
            public BoxPlotVisual BoxPlotVisual { get; set; }
            /// <summary>
            /// WaterfallVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-waterfallvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallVisual
            /// </summary>
            public WaterfallVisual WaterfallVisual { get; set; }
            /// <summary>
            /// CustomContentVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-customcontentvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentVisual
            /// </summary>
            public CustomContentVisual CustomContentVisual { get; set; }
            /// <summary>
            /// PieChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-piechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartVisual
            /// </summary>
            public PieChartVisual PieChartVisual { get; set; }
            /// <summary>
            /// KPIVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-kpivisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisual
            /// </summary>
            public KPIVisual KPIVisual { get; set; }
            /// <summary>
            /// HistogramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-histogramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramVisual
            /// </summary>
            public HistogramVisual HistogramVisual { get; set; }
            /// <summary>
            /// TableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-tablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableVisual
            /// </summary>
            public TableVisual TableVisual { get; set; }
            /// <summary>
            /// PivotTableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-pivottablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableVisual
            /// </summary>
            public PivotTableVisual PivotTableVisual { get; set; }
            /// <summary>
            /// GeospatialMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-geospatialmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapVisual
            /// </summary>
            public GeospatialMapVisual GeospatialMapVisual { get; set; }
            /// <summary>
            /// BarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-barchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartVisual
            /// </summary>
            public BarChartVisual BarChartVisual { get; set; }
            /// <summary>
            /// ScatterPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-scatterplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotVisual
            /// </summary>
            public ScatterPlotVisual ScatterPlotVisual { get; set; }
            /// <summary>
            /// RadarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-radarchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartVisual
            /// </summary>
            public RadarChartVisual RadarChartVisual { get; set; }
            /// <summary>
            /// HeatMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-heatmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapVisual
            /// </summary>
            public HeatMapVisual HeatMapVisual { get; set; }
            /// <summary>
            /// TreeMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-treemapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapVisual
            /// </summary>
            public TreeMapVisual TreeMapVisual { get; set; }
            /// <summary>
            /// ComboChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-combochartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartVisual
            /// </summary>
            public ComboChartVisual ComboChartVisual { get; set; }
            /// <summary>
            /// WordCloudVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-wordcloudvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudVisual
            /// </summary>
            public WordCloudVisual WordCloudVisual { get; set; }
            /// <summary>
            /// InsightVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-insightvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightVisual
            /// </summary>
            public InsightVisual InsightVisual { get; set; }
            /// <summary>
            /// SankeyDiagramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-sankeydiagramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramVisual
            /// </summary>
            public SankeyDiagramVisual SankeyDiagramVisual { get; set; }
            /// <summary>
            /// GaugeChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-gaugechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartVisual
            /// </summary>
            public GaugeChartVisual GaugeChartVisual { get; set; }
            /// <summary>
            /// LineChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-linechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartVisual
            /// </summary>
            public LineChartVisual LineChartVisual { get; set; }
            /// <summary>
            /// EmptyVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-emptyvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyVisual
            /// </summary>
            public EmptyVisual EmptyVisual { get; set; }
        }

        public class VisualAxisSortOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualaxissortoption.html#cfn-quicksight-dashboard-visualaxissortoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class VisualCustomAction
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomaction.html#cfn-quicksight-dashboard-visualcustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomaction.html#cfn-quicksight-dashboard-visualcustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomaction.html#cfn-quicksight-dashboard-visualcustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomaction.html#cfn-quicksight-dashboard-visualcustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomaction.html#cfn-quicksight-dashboard-visualcustomaction-actionoperations
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public CustomActionURLOperation URLOperation { get; set; }
        }

        public class VisualMenuOption
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualmenuoption.html#cfn-quicksight-dashboard-visualmenuoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class VisualPalette
        {
            /// <summary>
            /// ChartColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualpalette.html#cfn-quicksight-dashboard-visualpalette-chartcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChartColor { get; set; }
            /// <summary>
            /// ColorMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualpalette.html#cfn-quicksight-dashboard-visualpalette-colormap
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualsubtitlelabeloptions.html#cfn-quicksight-dashboard-visualsubtitlelabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FormatText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualsubtitlelabeloptions.html#cfn-quicksight-dashboard-visualsubtitlelabeloptions-formattext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualtitlelabeloptions.html#cfn-quicksight-dashboard-visualtitlelabeloptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// FormatText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualtitlelabeloptions.html#cfn-quicksight-dashboard-visualtitlelabeloptions-formattext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartaggregatedfieldwells.html#cfn-quicksight-dashboard-waterfallchartaggregatedfieldwells-categories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Categories { get; set; }
            /// <summary>
            /// Breakdowns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartaggregatedfieldwells.html#cfn-quicksight-dashboard-waterfallchartaggregatedfieldwells-breakdowns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> Breakdowns { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartaggregatedfieldwells.html#cfn-quicksight-dashboard-waterfallchartaggregatedfieldwells-values
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartcolorconfiguration.html#cfn-quicksight-dashboard-waterfallchartcolorconfiguration-groupcolorconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-categoryaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryAxisLabelOptions { get; set; }
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartSortConfiguration
            /// </summary>
            public WaterfallChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartFieldWells
            /// </summary>
            public WaterfallChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// WaterfallChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-waterfallchartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartOptions
            /// </summary>
            public WaterfallChartOptions WaterfallChartOptions { get; set; }
            /// <summary>
            /// ColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-colorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartColorConfiguration
            /// </summary>
            public WaterfallChartColorConfiguration ColorConfiguration { get; set; }
            /// <summary>
            /// CategoryAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-categoryaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions CategoryAxisDisplayOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-visualpalette
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartfieldwells.html#cfn-quicksight-dashboard-waterfallchartfieldwells-waterfallchartaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-dashboard-waterfallchartgroupcolorconfiguration-negativebarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NegativeBarColor { get; set; }
            /// <summary>
            /// TotalBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-dashboard-waterfallchartgroupcolorconfiguration-totalbarcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalBarColor { get; set; }
            /// <summary>
            /// PositiveBarColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartgroupcolorconfiguration.html#cfn-quicksight-dashboard-waterfallchartgroupcolorconfiguration-positivebarcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartoptions.html#cfn-quicksight-dashboard-waterfallchartoptions-totalbarlabel
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartsortconfiguration.html#cfn-quicksight-dashboard-waterfallchartsortconfiguration-breakdownitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration BreakdownItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartsortconfiguration.html#cfn-quicksight-dashboard-waterfallchartsortconfiguration-categorysort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartConfiguration
            /// </summary>
            public WaterfallChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-columnhierarchies
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-whatifpointscenario.html#cfn-quicksight-dashboard-whatifpointscenario-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Date
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-whatifpointscenario.html#cfn-quicksight-dashboard-whatifpointscenario-date
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-whatifrangescenario.html#cfn-quicksight-dashboard-whatifrangescenario-startdate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartDate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-whatifrangescenario.html#cfn-quicksight-dashboard-whatifrangescenario-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// EndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-whatifrangescenario.html#cfn-quicksight-dashboard-whatifrangescenario-enddate
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudaggregatedfieldwells.html#cfn-quicksight-dashboard-wordcloudaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudaggregatedfieldwells.html#cfn-quicksight-dashboard-wordcloudaggregatedfieldwells-size
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudSortConfiguration
            /// </summary>
            public WordCloudSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudFieldWells
            /// </summary>
            public WordCloudFieldWells FieldWells { get; set; }
            /// <summary>
            /// WordCloudOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-wordcloudoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudfieldwells.html#cfn-quicksight-dashboard-wordcloudfieldwells-wordcloudaggregatedfieldwells
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudoptions.html#cfn-quicksight-dashboard-wordcloudoptions-wordorientation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordOrientation { get; set; }
            /// <summary>
            /// WordScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudoptions.html#cfn-quicksight-dashboard-wordcloudoptions-wordscaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordScaling { get; set; }
            /// <summary>
            /// CloudLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudoptions.html#cfn-quicksight-dashboard-wordcloudoptions-cloudlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudLayout { get; set; }
            /// <summary>
            /// MaximumStringLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudoptions.html#cfn-quicksight-dashboard-wordcloudoptions-maximumstringlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaximumStringLength { get; set; }
            /// <summary>
            /// WordCasing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudoptions.html#cfn-quicksight-dashboard-wordcloudoptions-wordcasing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WordCasing { get; set; }
            /// <summary>
            /// WordPadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudoptions.html#cfn-quicksight-dashboard-wordcloudoptions-wordpadding
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudsortconfiguration.html#cfn-quicksight-dashboard-wordcloudsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudsortconfiguration.html#cfn-quicksight-dashboard-wordcloudsortconfiguration-categorysort
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudChartConfiguration
            /// </summary>
            public WordCloudChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<ColumnHierarchy> ColumnHierarchies { get; set; }
        }
    }
}