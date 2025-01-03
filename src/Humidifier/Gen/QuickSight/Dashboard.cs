namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using DashboardTypes;

    public class Dashboard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAwsAccountId, IHaveVersionDescription, IHaveThemeArn
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string LastPublishedTime =  "LastPublishedTime" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Dashboard; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Parameters
        /// </summary>
        public Humidifier.QuickSight.DashboardTypes.Parameters Parameters { get; set; }
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
        public Humidifier.QuickSight.DashboardTypes.DashboardSourceEntity SourceEntity { get; set; }
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
        public Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition Definition { get; set; }
        /// <summary>
        /// ValidationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-validationstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ValidationStrategy
        /// </summary>
        public Humidifier.QuickSight.DashboardTypes.ValidationStrategy ValidationStrategy { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-folderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic FolderArns { get; set; }

        /// <summary>
        /// DashboardId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-dashboardid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DashboardId { get; set; }
        /// <summary>
        /// LinkSharingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-linksharingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LinkSharingConfiguration
        /// </summary>
        public Humidifier.QuickSight.DashboardTypes.LinkSharingConfiguration LinkSharingConfiguration { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DashboardPublishOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-dashboardpublishoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashboardPublishOptions
        /// </summary>
        public Humidifier.QuickSight.DashboardTypes.DashboardPublishOptions DashboardPublishOptions { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html#cfn-quicksight-dashboard-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.DashboardTypes.ResourcePermission> Permissions { get; set; }
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
        public class AdHocFilteringOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class AggregationFunction : Humidifier.Base.BaseSubResource, IHaveDateAggregationFunction, IHaveCategoricalAggregationFunction
        {
            /// <summary>
            /// AttributeAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationfunction.html#cfn-quicksight-dashboard-aggregationfunction-attributeaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AttributeAggregationFunction AttributeAggregationFunction { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NumericalAggregationFunction NumericalAggregationFunction { get; set; }
            /// <summary>
            /// CategoricalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationfunction.html#cfn-quicksight-dashboard-aggregationfunction-categoricalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoricalAggregationFunction { get; set; }
        }

        public class AggregationSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveQuickSightDashboardTypesAggregationFunctionAggregationFunction, IHaveSortDirection
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-aggregationsortconfiguration.html#cfn-quicksight-dashboard-aggregationsortconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AggregationFunction AggregationFunction { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
        }

        public class AnalysisDefaults : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultNewSheetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-analysisdefaults.html#cfn-quicksight-dashboard-analysisdefaults-defaultnewsheetconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultNewSheetConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration DefaultNewSheetConfiguration { get; set; }
        }

        public class AnchorDateConfiguration : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveAnchorOption
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

        public class ArcAxisConfiguration : Humidifier.Base.BaseSubResource, IHaveReserveRange
        {
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcaxisconfiguration.html#cfn-quicksight-dashboard-arcaxisconfiguration-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisDisplayRange
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ArcAxisDisplayRange Range { get; set; }
            /// <summary>
            /// ReserveRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-arcaxisconfiguration.html#cfn-quicksight-dashboard-arcaxisconfiguration-reserverange
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

        public class ArcConfiguration : Humidifier.Base.BaseSubResource, IHaveArcThickness, IHaveArcAngle
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

        public class ArcOptions : Humidifier.Base.BaseSubResource, IHaveArcThickness
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

        public class AssetOptions : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveWeekStart
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

        public class AttributeAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleAttributeAggregation, IHaveValueForMultipleValues
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

        public class AxisDataOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdataoptions.html#cfn-quicksight-dashboard-axisdataoptions-dateaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateAxisOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateAxisOptions DateAxisOptions { get; set; }
            /// <summary>
            /// NumericAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdataoptions.html#cfn-quicksight-dashboard-axisdataoptions-numericaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericAxisOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericAxisOptions NumericAxisOptions { get; set; }
        }

        public class AxisDisplayMinMaxRange : Humidifier.Base.BaseSubResource, IHaveMinimum, IHaveMaximum
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

        public class AxisDisplayOptions : Humidifier.Base.BaseSubResource, IHaveAxisOffset, IHaveAxisLineVisibility, IHaveGridLineVisibility
        {
            /// <summary>
            /// DataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-dataoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDataOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDataOptions DataOptions { get; set; }
            /// <summary>
            /// TickLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisdisplayoptions.html#cfn-quicksight-dashboard-axisdisplayoptions-ticklabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisTickLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisTickLabelOptions TickLabelOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ScrollBarOptions ScrollbarOptions { get; set; }
        }

        public class AxisDisplayRange : Humidifier.Base.BaseSubResource, IHaveDataDriven
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
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayMinMaxRange MinMax { get; set; }
        }

        public class AxisLabelOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.DashboardTypes.AxisLabelReferenceOptions ApplyTo { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabeloptions.html#cfn-quicksight-dashboard-axislabeloptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class AxisLabelReferenceOptions : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabelreferenceoptions.html#cfn-quicksight-dashboard-axislabelreferenceoptions-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axislabelreferenceoptions.html#cfn-quicksight-dashboard-axislabelreferenceoptions-fieldid
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

        public class AxisLogarithmicScale : Humidifier.Base.BaseSubResource, IHaveBase
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

        public class AxisScale : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Logarithmic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisscale.html#cfn-quicksight-dashboard-axisscale-logarithmic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLogarithmicScale
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisLogarithmicScale Logarithmic { get; set; }
            /// <summary>
            /// Linear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-axisscale.html#cfn-quicksight-dashboard-axisscale-linear
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLinearScale
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisLinearScale Linear { get; set; }
        }

        public class AxisTickLabelOptions : Humidifier.Base.BaseSubResource, IHaveRotationAngle
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
            public Humidifier.QuickSight.DashboardTypes.LabelOptions LabelOptions { get; set; }
        }

        public class BarChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartaggregatedfieldwells.html#cfn-quicksight-dashboard-barchartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class BarChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveOrientation, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveBarsArrangement, IHaveQuickSightDashboardTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightDashboardTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightDashboardTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ValueAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartconfiguration.html#cfn-quicksight-dashboard-barchartconfiguration-valueaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions ValueAxis { get; set; }
        }

        public class BarChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartfieldwells.html#cfn-quicksight-dashboard-barchartfieldwells-barchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BarChartAggregatedFieldWells BarChartAggregatedFieldWells { get; set; }
        }

        public class BarChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightDashboardTypesItemsLimitConfigurationColorItemsLimit, IHaveQuickSightDashboardTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartsortconfiguration.html#cfn-quicksight-dashboard-barchartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class BarChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.BarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-barchartvisual.html#cfn-quicksight-dashboard-barchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class BinCountOptions : Humidifier.Base.BaseSubResource, IHaveValue
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

        public class BinWidthOptions : Humidifier.Base.BaseSubResource, IHaveValue, IHaveBinCountLimit
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

        public class BodySectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSectionId
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BodySectionContent
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BodySectionContent Content { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionStyle Style { get; set; }
            /// <summary>
            /// PageBreakConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-pagebreakconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionPageBreakConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionPageBreakConfiguration PageBreakConfiguration { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectionconfiguration.html#cfn-quicksight-dashboard-bodysectionconfiguration-sectionid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-bodysectioncontent.html#cfn-quicksight-dashboard-bodysectioncontent-layout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionLayoutConfiguration Layout { get; set; }
        }

        public class BoxPlotAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotaggregatedfieldwells.html#cfn-quicksight-dashboard-boxplotaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotaggregatedfieldwells.html#cfn-quicksight-dashboard-boxplotaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class BoxPlotChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightDashboardTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BoxPlotSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BoxPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// BoxPlotOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-boxplotoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BoxPlotOptions BoxPlotOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotchartconfiguration.html#cfn-quicksight-dashboard-boxplotchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
        }

        public class BoxPlotFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BoxPlotAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotfieldwells.html#cfn-quicksight-dashboard-boxplotfieldwells-boxplotaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BoxPlotAggregatedFieldWells BoxPlotAggregatedFieldWells { get; set; }
        }

        public class BoxPlotOptions : Humidifier.Base.BaseSubResource, IHaveOutlierVisibility, IHaveAllDataPointsVisibility
        {
            /// <summary>
            /// StyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotoptions.html#cfn-quicksight-dashboard-boxplotoptions-styleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotStyleOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BoxPlotStyleOptions StyleOptions { get; set; }
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

        public class BoxPlotSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotsortconfiguration.html#cfn-quicksight-dashboard-boxplotsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotsortconfiguration.html#cfn-quicksight-dashboard-boxplotsortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class BoxPlotStyleOptions : Humidifier.Base.BaseSubResource, IHaveFillStyle
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

        public class BoxPlotVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.BoxPlotChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-boxplotvisual.html#cfn-quicksight-dashboard-boxplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class CalculatedField : Humidifier.Base.BaseSubResource, IHaveName, IHaveExpression, IHaveDataSetIdentifier
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

        public class CalculatedMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveExpression
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

        public class CascadingControlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-cascadingcontrolconfiguration.html#cfn-quicksight-dashboard-cascadingcontrolconfiguration-sourcecontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CascadingControlSource
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.CascadingControlSource> SourceControls { get; set; }
        }

        public class CascadingControlSource : Humidifier.Base.BaseSubResource, IHaveSourceSheetControlId
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
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier ColumnToMatch { get; set; }
        }

        public class CategoricalDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveHierarchyId
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
            public Humidifier.QuickSight.DashboardTypes.StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricaldimensionfield.html#cfn-quicksight-dashboard-categoricaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricaldimensionfield.html#cfn-quicksight-dashboard-categoricaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoricalMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveAggregationFunction
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
            public Humidifier.QuickSight.DashboardTypes.StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricalmeasurefield.html#cfn-quicksight-dashboard-categoricalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoricalmeasurefield.html#cfn-quicksight-dashboard-categoricalmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoryDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveCategoryValues
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categorydrilldownfilter.html#cfn-quicksight-dashboard-categorydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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

        public class CategoryFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilter.html#cfn-quicksight-dashboard-categoryfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilterconfiguration.html#cfn-quicksight-dashboard-categoryfilterconfiguration-customfilterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterListConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomFilterListConfiguration CustomFilterListConfiguration { get; set; }
            /// <summary>
            /// CustomFilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilterconfiguration.html#cfn-quicksight-dashboard-categoryfilterconfiguration-customfilterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomFilterConfiguration CustomFilterConfiguration { get; set; }
            /// <summary>
            /// FilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryfilterconfiguration.html#cfn-quicksight-dashboard-categoryfilterconfiguration-filterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterListConfiguration FilterListConfiguration { get; set; }
        }

        public class CategoryInnerFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryinnerfilter.html#cfn-quicksight-dashboard-categoryinnerfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryinnerfilter.html#cfn-quicksight-dashboard-categoryinnerfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-categoryinnerfilter.html#cfn-quicksight-dashboard-categoryinnerfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
        }

        public class ChartAxisLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveSortIconVisibility
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
            public List<Humidifier.QuickSight.DashboardTypes.AxisLabelOptions> AxisLabelOptions { get; set; }
        }

        public class ClusterMarker : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SimpleClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-clustermarker.html#cfn-quicksight-dashboard-clustermarker-simpleclustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SimpleClusterMarker
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SimpleClusterMarker SimpleClusterMarker { get; set; }
        }

        public class ClusterMarkerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-clustermarkerconfiguration.html#cfn-quicksight-dashboard-clustermarkerconfiguration-clustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarker
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ClusterMarker ClusterMarker { get; set; }
        }

        public class ColorScale : Humidifier.Base.BaseSubResource, IHaveColorFillType
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-colorscale.html#cfn-quicksight-dashboard-colorscale-colors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataColor
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DataColor> Colors { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DataColor NullValueColor { get; set; }
        }

        public class ColorsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-colorsconfiguration.html#cfn-quicksight-dashboard-colorsconfiguration-customcolors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomColor
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.CustomColor> CustomColors { get; set; }
        }

        public class ColumnConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveRole
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
            public Humidifier.QuickSight.DashboardTypes.FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnconfiguration.html#cfn-quicksight-dashboard-columnconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// ColorsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnconfiguration.html#cfn-quicksight-dashboard-columnconfiguration-colorsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorsConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColorsConfiguration ColorsConfiguration { get; set; }
        }

        public class ColumnHierarchy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateTimeHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnhierarchy.html#cfn-quicksight-dashboard-columnhierarchy-datetimehierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeHierarchy
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateTimeHierarchy DateTimeHierarchy { get; set; }
            /// <summary>
            /// ExplicitHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnhierarchy.html#cfn-quicksight-dashboard-columnhierarchy-explicithierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExplicitHierarchy
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ExplicitHierarchy ExplicitHierarchy { get; set; }
            /// <summary>
            /// PredefinedHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnhierarchy.html#cfn-quicksight-dashboard-columnhierarchy-predefinedhierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedHierarchy
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PredefinedHierarchy PredefinedHierarchy { get; set; }
        }

        public class ColumnIdentifier : Humidifier.Base.BaseSubResource, IHaveDataSetIdentifier, IHaveColumnName
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

        public class ColumnSort : Humidifier.Base.BaseSubResource, IHaveDirection, IHaveQuickSightDashboardTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnsort.html#cfn-quicksight-dashboard-columnsort-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnsort.html#cfn-quicksight-dashboard-columnsort-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier SortBy { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columnsort.html#cfn-quicksight-dashboard-columnsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class ColumnTooltipItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveLabel
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AggregationFunction Aggregation { get; set; }
            /// <summary>
            /// TooltipTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-tooltiptarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTarget { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-columntooltipitem.html#cfn-quicksight-dashboard-columntooltipitem-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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

        public class ComboChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BarValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-barvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> BarValues { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// LineValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartaggregatedfieldwells.html#cfn-quicksight-dashboard-combochartaggregatedfieldwells-linevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> LineValues { get; set; }
        }

        public class ComboChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveBarsArrangement, IHaveQuickSightDashboardTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightDashboardTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ComboChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// BarDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-bardatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions BarDataLabels { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SingleAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-singleaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleAxisOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SingleAxisOptions SingleAxisOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// LineDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-linedatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions LineDataLabels { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ComboChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartconfiguration.html#cfn-quicksight-dashboard-combochartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
        }

        public class ComboChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ComboChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartfieldwells.html#cfn-quicksight-dashboard-combochartfieldwells-combochartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ComboChartAggregatedFieldWells ComboChartAggregatedFieldWells { get; set; }
        }

        public class ComboChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightDashboardTypesItemsLimitConfigurationColorItemsLimit
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartsortconfiguration.html#cfn-quicksight-dashboard-combochartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class ComboChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ComboChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-combochartvisual.html#cfn-quicksight-dashboard-combochartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ComparisonConfiguration : Humidifier.Base.BaseSubResource, IHaveComparisonMethod
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
            public Humidifier.QuickSight.DashboardTypes.ComparisonFormatConfiguration ComparisonFormat { get; set; }
        }

        public class ComparisonFormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-comparisonformatconfiguration.html#cfn-quicksight-dashboard-comparisonformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-comparisonformatconfiguration.html#cfn-quicksight-dashboard-comparisonformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class Computation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PeriodToDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-periodtodate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodToDateComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PeriodToDateComputation PeriodToDate { get; set; }
            /// <summary>
            /// GrowthRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-growthrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrowthRateComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GrowthRateComputation GrowthRate { get; set; }
            /// <summary>
            /// TopBottomRanked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-topbottomranked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomRankedComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TopBottomRankedComputation TopBottomRanked { get; set; }
            /// <summary>
            /// TotalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-totalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalAggregationComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TotalAggregationComputation TotalAggregation { get; set; }
            /// <summary>
            /// Forecast
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-forecast
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ForecastComputation Forecast { get; set; }
            /// <summary>
            /// MaximumMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-maximumminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumMinimumComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MaximumMinimumComputation MaximumMinimum { get; set; }
            /// <summary>
            /// PeriodOverPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-periodoverperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodOverPeriodComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PeriodOverPeriodComputation PeriodOverPeriod { get; set; }
            /// <summary>
            /// MetricComparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-metriccomparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricComparisonComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MetricComparisonComputation MetricComparison { get; set; }
            /// <summary>
            /// TopBottomMovers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-topbottommovers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomMoversComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TopBottomMoversComputation TopBottomMovers { get; set; }
            /// <summary>
            /// UniqueValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-computation.html#cfn-quicksight-dashboard-computation-uniquevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UniqueValuesComputation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.UniqueValuesComputation UniqueValues { get; set; }
        }

        public class ConditionalFormattingColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcolor.html#cfn-quicksight-dashboard-conditionalformattingcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingGradientColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingGradientColor Gradient { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcolor.html#cfn-quicksight-dashboard-conditionalformattingcolor-solid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingSolidColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingSolidColor Solid { get; set; }
        }

        public class ConditionalFormattingCustomIconCondition : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColor
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
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIconDisplayConfiguration DisplayConfiguration { get; set; }
            /// <summary>
            /// IconOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingcustomiconcondition.html#cfn-quicksight-dashboard-conditionalformattingcustomiconcondition-iconoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingCustomIconOptions IconOptions { get; set; }
        }

        public class ConditionalFormattingCustomIconOptions : Humidifier.Base.BaseSubResource, IHaveIcon, IHaveUnicodeIcon
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

        public class ConditionalFormattingGradientColor : Humidifier.Base.BaseSubResource, IHaveExpression
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
            public Humidifier.QuickSight.DashboardTypes.GradientColor Color { get; set; }
        }

        public class ConditionalFormattingIcon : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingicon.html#cfn-quicksight-dashboard-conditionalformattingicon-customcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconCondition
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingCustomIconCondition CustomCondition { get; set; }
            /// <summary>
            /// IconSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-conditionalformattingicon.html#cfn-quicksight-dashboard-conditionalformattingicon-iconset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconSet
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIconSet IconSet { get; set; }
        }

        public class ConditionalFormattingIconDisplayConfiguration : Humidifier.Base.BaseSubResource, IHaveIconDisplayOption
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

        public class ConditionalFormattingIconSet : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveIconSetType
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

        public class ConditionalFormattingSolidColor : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColor
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

        public class ContributionAnalysisDefault : Humidifier.Base.BaseSubResource, IHaveMeasureFieldId
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
            public List<Humidifier.QuickSight.DashboardTypes.ColumnIdentifier> ContributorDimensions { get; set; }
        }

        public class CurrencyDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveNumberScale, IHaveSymbol, IHaveQuickSightDashboardTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightDashboardTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightDashboardTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightDashboardTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-currencydisplayformatconfiguration.html#cfn-quicksight-dashboard-currencydisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
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

        public class CustomActionFilterOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelectedFieldsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionfilteroperation.html#cfn-quicksight-dashboard-customactionfilteroperation-selectedfieldsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationSelectedFieldsConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterOperationSelectedFieldsConfiguration SelectedFieldsConfiguration { get; set; }
            /// <summary>
            /// TargetVisualsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionfilteroperation.html#cfn-quicksight-dashboard-customactionfilteroperation-targetvisualsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationTargetVisualsConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterOperationTargetVisualsConfiguration TargetVisualsConfiguration { get; set; }
        }

        public class CustomActionNavigationOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LocalNavigationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionnavigationoperation.html#cfn-quicksight-dashboard-customactionnavigationoperation-localnavigationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocalNavigationConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LocalNavigationConfiguration LocalNavigationConfiguration { get; set; }
        }

        public class CustomActionSetParametersOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParameterValueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customactionsetparametersoperation.html#cfn-quicksight-dashboard-customactionsetparametersoperation-parametervalueconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SetParameterValueConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SetParameterValueConfiguration> ParameterValueConfigurations { get; set; }
        }

        public class CustomActionURLOperation : Humidifier.Base.BaseSubResource, IHaveURLTemplate, IHaveURLTarget
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

        public class CustomColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveFieldValue, IHaveSpecialValue
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

        public class CustomContentConfiguration : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContentUrl, IHaveImageScaling
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

        public class CustomContentVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.CustomContentConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-customcontentvisual.html#cfn-quicksight-dashboard-customcontentvisual-visualcontentalttext
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

        public class CustomFilterListConfiguration : Humidifier.Base.BaseSubResource, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveCategoryValues
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

        public class CustomNarrativeOptions : Humidifier.Base.BaseSubResource, IHaveNarrative
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

        public class CustomParameterValues : Humidifier.Base.BaseSubResource, IHaveStringValues, IHaveDateTimeValues
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

        public class CustomValuesConfiguration : Humidifier.Base.BaseSubResource, IHaveIncludeNullValue
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
            public Humidifier.QuickSight.DashboardTypes.CustomParameterValues CustomValues { get; set; }
        }

        public class DashboardError : Humidifier.Base.BaseSubResource, IHaveType, IHaveMessage
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
            public List<Humidifier.QuickSight.DashboardTypes.Entity> ViolatedEntities { get; set; }
        }

        public class DashboardPublishOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SheetControlsOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-sheetcontrolsoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlsOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlsOption SheetControlsOption { get; set; }
            /// <summary>
            /// ExportToCSVOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-exporttocsvoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportToCSVOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ExportToCSVOption ExportToCSVOption { get; set; }
            /// <summary>
            /// DataPointMenuLabelOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-datapointmenulabeloption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPointMenuLabelOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPointMenuLabelOption DataPointMenuLabelOption { get; set; }
            /// <summary>
            /// DataPointDrillUpDownOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-datapointdrillupdownoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPointDrillUpDownOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPointDrillUpDownOption DataPointDrillUpDownOption { get; set; }
            /// <summary>
            /// AdHocFilteringOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-adhocfilteringoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdHocFilteringOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AdHocFilteringOption AdHocFilteringOption { get; set; }
            /// <summary>
            /// VisualPublishOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-visualpublishoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashboardVisualPublishOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions VisualPublishOptions { get; set; }
            /// <summary>
            /// VisualMenuOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-visualmenuoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic VisualMenuOption { get; set; }
            /// <summary>
            /// DataPointTooltipOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-datapointtooltipoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPointTooltipOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPointTooltipOption DataPointTooltipOption { get; set; }
            /// <summary>
            /// VisualAxisSortOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-visualaxissortoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualAxisSortOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualAxisSortOption VisualAxisSortOption { get; set; }
            /// <summary>
            /// ExportWithHiddenFieldsOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-exportwithhiddenfieldsoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportWithHiddenFieldsOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ExportWithHiddenFieldsOption ExportWithHiddenFieldsOption { get; set; }
            /// <summary>
            /// SheetLayoutElementMaximizationOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html#cfn-quicksight-dashboard-dashboardpublishoptions-sheetlayoutelementmaximizationoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetLayoutElementMaximizationOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetLayoutElementMaximizationOption SheetLayoutElementMaximizationOption { get; set; }
        }

        public class DashboardSourceEntity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourceentity.html#cfn-quicksight-dashboard-dashboardsourceentity-sourcetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashboardSourceTemplate
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate SourceTemplate { get; set; }
        }

        public class DashboardSourceTemplate : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// DataSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourcetemplate.html#cfn-quicksight-dashboard-dashboardsourcetemplate-datasetreferences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetReference
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DataSetReference> DataSetReferences { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourcetemplate.html#cfn-quicksight-dashboard-dashboardsourcetemplate-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class DashboardVersion : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveStatus, IHaveArn, IHaveCreatedTime, IHaveThemeArn, IHaveVersionNumber
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
            public List<Humidifier.QuickSight.DashboardTypes.DashboardError> Errors { get; set; }
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
            public List<Humidifier.QuickSight.DashboardTypes.Sheet> Sheets { get; set; }
        }

        public class DashboardVersionDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AssetOptions Options { get; set; }
            /// <summary>
            /// FilterGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-filtergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterGroup
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FilterGroup> FilterGroups { get; set; }
            /// <summary>
            /// StaticFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-staticfiles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StaticFile
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.StaticFile> StaticFiles { get; set; }
            /// <summary>
            /// CalculatedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-calculatedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.CalculatedField> CalculatedFields { get; set; }
            /// <summary>
            /// DataSetIdentifierDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-datasetidentifierdeclarations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetIdentifierDeclaration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DataSetIdentifierDeclaration> DataSetIdentifierDeclarations { get; set; }
            /// <summary>
            /// ColumnConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-columnconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnConfiguration> ColumnConfigurations { get; set; }
            /// <summary>
            /// AnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-analysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisDefaults
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AnalysisDefaults AnalysisDefaults { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetDefinition
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SheetDefinition> Sheets { get; set; }
            /// <summary>
            /// ParameterDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversiondefinition.html#cfn-quicksight-dashboard-dashboardversiondefinition-parameterdeclarations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterDeclaration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ParameterDeclaration> ParameterDeclarations { get; set; }
        }

        public class DashboardVisualPublishOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExportHiddenFieldsOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardvisualpublishoptions.html#cfn-quicksight-dashboard-dashboardvisualpublishoptions-exporthiddenfieldsoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportHiddenFieldsOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption ExportHiddenFieldsOption { get; set; }
        }

        public class DataBarsOptions : Humidifier.Base.BaseSubResource, IHaveFieldId, IHavePositiveColor, IHaveNegativeColor
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

        public class DataColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
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

        public class DataFieldSeriesItem : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveFieldValue, IHaveAxisBinding
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
            public Humidifier.QuickSight.DashboardTypes.LineChartSeriesSettings Settings { get; set; }
        }

        public class DataLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHavePosition, IHaveTotalsVisibility, IHaveMeasureLabelVisibility, IHaveCategoryLabelVisibility, IHaveLabelColor, IHaveLabelContent, IHaveOverlap
        {
            /// <summary>
            /// DataLabelTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeloptions.html#cfn-quicksight-dashboard-datalabeloptions-datalabeltypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataLabelType
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DataLabelType> DataLabelTypes { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class DataLabelType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-maximumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumLabelType
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MaximumLabelType MaximumLabelType { get; set; }
            /// <summary>
            /// DataPathLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-datapathlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathLabelType
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPathLabelType DataPathLabelType { get; set; }
            /// <summary>
            /// RangeEndsLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-rangeendslabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangeEndsLabelType
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RangeEndsLabelType RangeEndsLabelType { get; set; }
            /// <summary>
            /// FieldLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-fieldlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldLabelType
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FieldLabelType FieldLabelType { get; set; }
            /// <summary>
            /// MinimumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datalabeltype.html#cfn-quicksight-dashboard-datalabeltype-minimumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MinimumLabelType
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MinimumLabelType MinimumLabelType { get; set; }
        }

        public class DataPathColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveTimeGranularity
        {
            /// <summary>
            /// Element
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathcolor.html#cfn-quicksight-dashboard-datapathcolor-element
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPathValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPathValue Element { get; set; }
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

        public class DataPathLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveFieldValue
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

        public class DataPathSort : Humidifier.Base.BaseSubResource, IHaveDirection
        {
            /// <summary>
            /// SortPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathsort.html#cfn-quicksight-dashboard-datapathsort-sortpaths
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DataPathValue> SortPaths { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathsort.html#cfn-quicksight-dashboard-datapathsort-direction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathtype.html#cfn-quicksight-dashboard-datapathtype-pivottabledatapathtype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datapathvalue.html#cfn-quicksight-dashboard-datapathvalue-datapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathType
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPathType DataPathType { get; set; }
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

        public class DataPointDrillUpDownOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class DataPointMenuLabelOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class DataPointTooltipOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class DataSetIdentifierDeclaration : Humidifier.Base.BaseSubResource, IHaveIdentifier, IHaveDataSetArn
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

        public class DataSetReference : Humidifier.Base.BaseSubResource, IHaveDataSetArn, IHaveDataSetPlaceholder
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

        public class DateAxisOptions : Humidifier.Base.BaseSubResource, IHaveMissingDateVisibility
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

        public class DateDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveHierarchyId, IHaveDateGranularity
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
            public Humidifier.QuickSight.DashboardTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datedimensionfield.html#cfn-quicksight-dashboard-datedimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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

        public class DateMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveAggregationFunction
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
            public Humidifier.QuickSight.DashboardTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datemeasurefield.html#cfn-quicksight-dashboard-datemeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datemeasurefield.html#cfn-quicksight-dashboard-datemeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class DateTimeDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues, IHaveQuickSightDashboardTypesDynamicDefaultValueDynamicValue, IHaveQuickSightDashboardTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimedefaultvalues.html#cfn-quicksight-dashboard-datetimedefaultvalues-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimedefaultvalues.html#cfn-quicksight-dashboard-datetimedefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class DateTimeFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightDashboardTypesNullValueFormatConfigurationNullValueFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeformatconfiguration.html#cfn-quicksight-dashboard-datetimeformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeformatconfiguration.html#cfn-quicksight-dashboard-datetimeformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeformatconfiguration.html#cfn-quicksight-dashboard-datetimeformatconfiguration-datetimeformat
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
            public List<Humidifier.QuickSight.DashboardTypes.DrillDownFilter> DrillDownFilters { get; set; }
        }

        public class DateTimeParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
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

        public class DateTimeParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveTimeGranularity
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateTimeDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DateTimeValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameterdeclaration.html#cfn-quicksight-dashboard-datetimeparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DateTimePickerControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimepickercontroldisplayoptions.html#cfn-quicksight-dashboard-datetimepickercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimepickercontroldisplayoptions.html#cfn-quicksight-dashboard-datetimepickercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimepickercontroldisplayoptions.html#cfn-quicksight-dashboard-datetimepickercontroldisplayoptions-datetimeformat
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

        public class DecimalDefaultValues : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimaldefaultvalues.html#cfn-quicksight-dashboard-decimaldefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class DecimalParameter : Humidifier.Base.BaseSubResource, IHaveName
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

        public class DecimalParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DecimalDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DecimalValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalparameterdeclaration.html#cfn-quicksight-dashboard-decimalparameterdeclaration-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-decimalplacesconfiguration.html#cfn-quicksight-dashboard-decimalplacesconfiguration-decimalplaces
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

        public class DefaultDateTimePickerControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightDashboardTypesDateTimePickerControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultdatetimepickercontroloptions.html#cfn-quicksight-dashboard-defaultdatetimepickercontroloptions-commitmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontrolconfiguration.html#cfn-quicksight-dashboard-defaultfiltercontrolconfiguration-controloptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlOptions ControlOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontrolconfiguration.html#cfn-quicksight-dashboard-defaultfiltercontrolconfiguration-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultslideroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSliderControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultSliderControlOptions DefaultSliderOptions { get; set; }
            /// <summary>
            /// DefaultRelativeDateTimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultrelativedatetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRelativeDateTimeControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions { get; set; }
            /// <summary>
            /// DefaultTextFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaulttextfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextFieldControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultTextFieldControlOptions DefaultTextFieldOptions { get; set; }
            /// <summary>
            /// DefaultTextAreaOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaulttextareaoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextAreaControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultTextAreaControlOptions DefaultTextAreaOptions { get; set; }
            /// <summary>
            /// DefaultDropdownOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultdropdownoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterDropDownControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterDropDownControlOptions DefaultDropdownOptions { get; set; }
            /// <summary>
            /// DefaultDateTimePickerOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultdatetimepickeroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultDateTimePickerControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions { get; set; }
            /// <summary>
            /// DefaultListOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfiltercontroloptions.html#cfn-quicksight-dashboard-defaultfiltercontroloptions-defaultlistoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterListControlOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterListControlOptions DefaultListOptions { get; set; }
        }

        public class DefaultFilterDropDownControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightDashboardTypesFilterSelectableValuesSelectableValues, IHaveQuickSightDashboardTypesDropDownControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterdropdowncontroloptions.html#cfn-quicksight-dashboard-defaultfilterdropdowncontroloptions-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterdropdowncontroloptions.html#cfn-quicksight-dashboard-defaultfilterdropdowncontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFilterListControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightDashboardTypesFilterSelectableValuesSelectableValues, IHaveQuickSightDashboardTypesListControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfilterlistcontroloptions.html#cfn-quicksight-dashboard-defaultfilterlistcontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFreeFormLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultfreeformlayoutconfiguration.html#cfn-quicksight-dashboard-defaultfreeformlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultGridLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultgridlayoutconfiguration.html#cfn-quicksight-dashboard-defaultgridlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultInteractiveLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FreeForm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultinteractivelayoutconfiguration.html#cfn-quicksight-dashboard-defaultinteractivelayoutconfiguration-freeform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFreeFormLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration FreeForm { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultinteractivelayoutconfiguration.html#cfn-quicksight-dashboard-defaultinteractivelayoutconfiguration-grid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultGridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration Grid { get; set; }
        }

        public class DefaultNewSheetConfiguration : Humidifier.Base.BaseSubResource, IHaveSheetContentType
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
            public Humidifier.QuickSight.DashboardTypes.DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration { get; set; }
            /// <summary>
            /// PaginatedLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultnewsheetconfiguration.html#cfn-quicksight-dashboard-defaultnewsheetconfiguration-paginatedlayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultPaginatedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration PaginatedLayoutConfiguration { get; set; }
        }

        public class DefaultPaginatedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SectionBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultpaginatedlayoutconfiguration.html#cfn-quicksight-dashboard-defaultpaginatedlayoutconfiguration-sectionbased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSectionBasedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration SectionBased { get; set; }
        }

        public class DefaultRelativeDateTimeControlOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultrelativedatetimecontroloptions.html#cfn-quicksight-dashboard-defaultrelativedatetimecontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultrelativedatetimecontroloptions.html#cfn-quicksight-dashboard-defaultrelativedatetimecontroloptions-commitmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaultsectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-defaultsectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultSliderControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightDashboardTypesSliderControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
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

        public class DefaultTextAreaControlOptions : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveQuickSightDashboardTypesTextAreaControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DefaultTextFieldControlOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesTextFieldControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-defaulttextfieldcontroloptions.html#cfn-quicksight-dashboard-defaulttextfieldcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DestinationParameterValueConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceParameterName, IHaveSelectAllValueOptions, IHaveSourceField
        {
            /// <summary>
            /// CustomValuesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-destinationparametervalueconfiguration.html#cfn-quicksight-dashboard-destinationparametervalueconfiguration-customvaluesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomValuesConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomValuesConfiguration CustomValuesConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier SourceColumn { get; set; }
        }

        public class DimensionField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dimensionfield.html#cfn-quicksight-dashboard-dimensionfield-datedimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateDimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateDimensionField DateDimensionField { get; set; }
            /// <summary>
            /// NumericalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dimensionfield.html#cfn-quicksight-dashboard-dimensionfield-numericaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalDimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericalDimensionField NumericalDimensionField { get; set; }
            /// <summary>
            /// CategoricalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dimensionfield.html#cfn-quicksight-dashboard-dimensionfield-categoricaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalDimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoricalDimensionField CategoricalDimensionField { get; set; }
        }

        public class DonutCenterOptions : Humidifier.Base.BaseSubResource, IHaveLabelVisibility
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

        public class DonutOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DonutCenterOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-donutoptions.html#cfn-quicksight-dashboard-donutoptions-donutcenteroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutCenterOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DonutCenterOptions DonutCenterOptions { get; set; }
            /// <summary>
            /// ArcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-donutoptions.html#cfn-quicksight-dashboard-donutoptions-arcoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ArcOptions ArcOptions { get; set; }
        }

        public class DrillDownFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-drilldownfilter.html#cfn-quicksight-dashboard-drilldownfilter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericEqualityDrillDownFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-drilldownfilter.html#cfn-quicksight-dashboard-drilldownfilter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TimeRangeDrillDownFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-drilldownfilter.html#cfn-quicksight-dashboard-drilldownfilter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoryDrillDownFilter CategoryFilter { get; set; }
        }

        public class DropDownControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dropdowncontroldisplayoptions.html#cfn-quicksight-dashboard-dropdowncontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dropdowncontroldisplayoptions.html#cfn-quicksight-dashboard-dropdowncontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dropdowncontroldisplayoptions.html#cfn-quicksight-dashboard-dropdowncontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class DynamicDefaultValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dynamicdefaultvalue.html#cfn-quicksight-dashboard-dynamicdefaultvalue-groupnamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier GroupNameColumn { get; set; }
            /// <summary>
            /// DefaultValueColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dynamicdefaultvalue.html#cfn-quicksight-dashboard-dynamicdefaultvalue-defaultvaluecolumn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier DefaultValueColumn { get; set; }
            /// <summary>
            /// UserNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dynamicdefaultvalue.html#cfn-quicksight-dashboard-dynamicdefaultvalue-usernamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier UserNameColumn { get; set; }
        }

        public class EmptyVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveDataSetIdentifier
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
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-emptyvisual.html#cfn-quicksight-dashboard-emptyvisual-datasetidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-entity.html#cfn-quicksight-dashboard-entity-path
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

        public class ExplicitHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
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
            public List<Humidifier.QuickSight.DashboardTypes.DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-explicithierarchy.html#cfn-quicksight-dashboard-explicithierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnIdentifier> Columns { get; set; }
        }

        public class ExportHiddenFieldsOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class ExportToCSVOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class ExportWithHiddenFieldsOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class FieldBasedTooltip : Humidifier.Base.BaseSubResource, IHaveAggregationVisibility, IHaveTooltipTitleType
        {
            /// <summary>
            /// TooltipFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldbasedtooltip.html#cfn-quicksight-dashboard-fieldbasedtooltip-tooltipfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TooltipItem
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TooltipItem> TooltipFields { get; set; }
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

        public class FieldLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId
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

        public class FieldSeriesItem : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveAxisBinding
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
            public Humidifier.QuickSight.DashboardTypes.LineChartSeriesSettings Settings { get; set; }
        }

        public class FieldSort : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveDirection
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

        public class FieldSortOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldsortoptions.html#cfn-quicksight-dashboard-fieldsortoptions-fieldsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FieldSort FieldSort { get; set; }
            /// <summary>
            /// ColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldsortoptions.html#cfn-quicksight-dashboard-fieldsortoptions-columnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnSort ColumnSort { get; set; }
        }

        public class FieldTooltipItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveLabel
        {
            /// <summary>
            /// TooltipTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fieldtooltipitem.html#cfn-quicksight-dashboard-fieldtooltipitem-tooltiptarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTarget { get; set; }
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

        public class FilledMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapaggregatedfieldwells.html#cfn-quicksight-dashboard-filledmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapaggregatedfieldwells.html#cfn-quicksight-dashboard-filledmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Geospatial { get; set; }
        }

        public class FilledMapConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconditionalformatting.html#cfn-quicksight-dashboard-filledmapconditionalformatting-conditionalformattingoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilledMapConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FilledMapConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class FilledMapConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconditionalformattingoption.html#cfn-quicksight-dashboard-filledmapconditionalformattingoption-shape
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilledMapShapeConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilledMapShapeConditionalFormatting Shape { get; set; }
        }

        public class FilledMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilledMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilledMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapconfiguration.html#cfn-quicksight-dashboard-filledmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialWindowOptions WindowOptions { get; set; }
        }

        public class FilledMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilledMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapfieldwells.html#cfn-quicksight-dashboard-filledmapfieldwells-filledmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilledMapAggregatedFieldWells FilledMapAggregatedFieldWells { get; set; }
        }

        public class FilledMapShapeConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapshapeconditionalformatting.html#cfn-quicksight-dashboard-filledmapshapeconditionalformatting-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShapeConditionalFormat
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ShapeConditionalFormat Format { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapshapeconditionalformatting.html#cfn-quicksight-dashboard-filledmapshapeconditionalformatting-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapsortconfiguration.html#cfn-quicksight-dashboard-filledmapsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class FilledMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilledMapConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FilledMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filledmapvisual.html#cfn-quicksight-dashboard-filledmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NestedFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-nestedfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NestedFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NestedFilter NestedFilter { get; set; }
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericEqualityFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// NumericRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-numericrangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericRangeFilter NumericRangeFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TimeRangeFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// RelativeDatesFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-relativedatesfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDatesFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RelativeDatesFilter RelativeDatesFilter { get; set; }
            /// <summary>
            /// TopBottomFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-topbottomfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TopBottomFilter TopBottomFilter { get; set; }
            /// <summary>
            /// TimeEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-timeequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeEqualityFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TimeEqualityFilter TimeEqualityFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filter.html#cfn-quicksight-dashboard-filter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoryFilter CategoryFilter { get; set; }
        }

        public class FilterControl : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Slider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSliderControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextAreaControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDropDownControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextFieldControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDateTimePickerControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterDateTimePickerControl DateTimePicker { get; set; }
            /// <summary>
            /// RelativeDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-relativedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterRelativeDateTimeControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterRelativeDateTimeControl RelativeDateTime { get; set; }
            /// <summary>
            /// CrossSheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercontrol.html#cfn-quicksight-dashboard-filtercontrol-crosssheet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterCrossSheetControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilterCrossSheetControl CrossSheet { get; set; }
        }

        public class FilterCrossSheetControl : Humidifier.Base.BaseSubResource, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightDashboardTypesCascadingControlConfigurationCascadingControlConfiguration
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
            public Humidifier.QuickSight.DashboardTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtercrosssheetcontrol.html#cfn-quicksight-dashboard-filtercrosssheetcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDateTimePickerControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightDashboardTypesDateTimePickerControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdatetimepickercontrol.html#cfn-quicksight-dashboard-filterdatetimepickercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDropDownControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightDashboardTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightDashboardTypesFilterSelectableValuesSelectableValues, IHaveQuickSightDashboardTypesDropDownControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterdropdowncontrol.html#cfn-quicksight-dashboard-filterdropdowncontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCrossDataset, IHaveFilterGroupId
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
            public List<Humidifier.QuickSight.DashboardTypes.Filter> Filters { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FilterScopeConfiguration ScopeConfiguration { get; set; }
            /// <summary>
            /// FilterGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filtergroup.html#cfn-quicksight-dashboard-filtergroup-filtergroupid
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

        public class FilterListControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightDashboardTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightDashboardTypesFilterSelectableValuesSelectableValues, IHaveQuickSightDashboardTypesListControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterlistcontrol.html#cfn-quicksight-dashboard-filterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterOperationSelectedFieldsConfiguration : Humidifier.Base.BaseSubResource, IHaveSelectedFields, IHaveSelectedFieldOptions
        {
            /// <summary>
            /// SelectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-dashboard-filteroperationselectedfieldsconfiguration-selectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnIdentifier> SelectedColumns { get; set; }
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

        public class FilterOperationTargetVisualsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SameSheetTargetVisualConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filteroperationtargetvisualsconfiguration.html#cfn-quicksight-dashboard-filteroperationtargetvisualsconfiguration-samesheettargetvisualconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SameSheetTargetVisualConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SameSheetTargetVisualConfiguration SameSheetTargetVisualConfiguration { get; set; }
        }

        public class FilterRelativeDateTimeControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId
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
            public Humidifier.QuickSight.DashboardTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-filterrelativedatetimecontrol.html#cfn-quicksight-dashboard-filterrelativedatetimecontrol-sourcefilterid
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
            public Humidifier.QuickSight.DashboardTypes.SelectedSheetsFilterScopeConfiguration SelectedSheets { get; set; }
        }

        public class FilterSelectableValues : Humidifier.Base.BaseSubResource, IHaveValues
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

        public class FilterSliderControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightDashboardTypesSliderControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
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

        public class FilterTextAreaControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveDelimiter, IHaveQuickSightDashboardTypesTextAreaControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
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

        public class FilterTextFieldControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightDashboardTypesTextFieldControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
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

        public class FontConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveFontStyle, IHaveFontDecoration
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
            public Humidifier.QuickSight.DashboardTypes.FontSize FontSize { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FontWeight FontWeight { get; set; }
        }

        public class FontSize : Humidifier.Base.BaseSubResource, IHaveRelative
        {
            /// <summary>
            /// Relative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontsize.html#cfn-quicksight-dashboard-fontsize-relative
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Relative { get; set; }
            /// <summary>
            /// Absolute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-fontsize.html#cfn-quicksight-dashboard-fontsize-absolute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Absolute { get; set; }
        }

        public class FontWeight : Humidifier.Base.BaseSubResource, IHaveName
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

        public class ForecastComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveQuickSightDashboardTypesDimensionFieldTime, IHavePeriodsBackward, IHavePeriodsForward, IHavePredictionInterval, IHaveSeasonality, IHaveUpperBoundary, IHaveLowerBoundary, IHaveCustomSeasonalityValue
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
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastcomputation.html#cfn-quicksight-dashboard-forecastcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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

        public class ForecastConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForecastProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastconfiguration.html#cfn-quicksight-dashboard-forecastconfiguration-forecastproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedForecastProperties
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TimeBasedForecastProperties ForecastProperties { get; set; }
            /// <summary>
            /// Scenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastconfiguration.html#cfn-quicksight-dashboard-forecastconfiguration-scenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastScenario
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ForecastScenario Scenario { get; set; }
        }

        public class ForecastScenario : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WhatIfRangeScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastscenario.html#cfn-quicksight-dashboard-forecastscenario-whatifrangescenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfRangeScenario
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WhatIfRangeScenario WhatIfRangeScenario { get; set; }
            /// <summary>
            /// WhatIfPointScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-forecastscenario.html#cfn-quicksight-dashboard-forecastscenario-whatifpointscenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfPointScenario
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WhatIfPointScenario WhatIfPointScenario { get; set; }
        }

        public class FormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-formatconfiguration.html#cfn-quicksight-dashboard-formatconfiguration-numberformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumberFormatConfiguration NumberFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-formatconfiguration.html#cfn-quicksight-dashboard-formatconfiguration-datetimeformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateTimeFormatConfiguration DateTimeFormatConfiguration { get; set; }
            /// <summary>
            /// StringFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-formatconfiguration.html#cfn-quicksight-dashboard-formatconfiguration-stringformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StringFormatConfiguration StringFormatConfiguration { get; set; }
        }

        public class FreeFormLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutcanvassizeoptions.html#cfn-quicksight-dashboard-freeformlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutScreenCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class FreeFormLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutconfiguration.html#cfn-quicksight-dashboard-freeformlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformlayoutconfiguration.html#cfn-quicksight-dashboard-freeformlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutElement> Elements { get; set; }
        }

        public class FreeFormLayoutElement : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveWidth, IHaveElementType, IHaveElementId, IHaveYAxisLocation, IHaveXAxisLocation
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
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutElementBorderStyle BorderStyle { get; set; }
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
            public List<Humidifier.QuickSight.DashboardTypes.SheetElementRenderingRule> RenderingRules { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.LoadingAnimation LoadingAnimation { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutElementBackgroundStyle BackgroundStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutElementBorderStyle SelectedBorderStyle { get; set; }
        }

        public class FreeFormLayoutElementBackgroundStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveColor
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

        public class FreeFormLayoutElementBorderStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveColor
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

        public class FreeFormLayoutScreenCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedViewPortWidth
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

        public class FreeFormSectionLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-freeformsectionlayoutconfiguration.html#cfn-quicksight-dashboard-freeformsectionlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutElement> Elements { get; set; }
        }

        public class FunnelChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartaggregatedfieldwells.html#cfn-quicksight-dashboard-funnelchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartaggregatedfieldwells.html#cfn-quicksight-dashboard-funnelchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class FunnelChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightDashboardTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FunnelChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-datalabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartDataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FunnelChartDataLabelOptions DataLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FunnelChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartconfiguration.html#cfn-quicksight-dashboard-funnelchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
        }

        public class FunnelChartDataLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHavePosition, IHaveMeasureLabelVisibility, IHaveCategoryLabelVisibility, IHaveLabelColor, IHaveMeasureDataLabelStyle
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class FunnelChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunnelChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartfieldwells.html#cfn-quicksight-dashboard-funnelchartfieldwells-funnelchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FunnelChartAggregatedFieldWells FunnelChartAggregatedFieldWells { get; set; }
        }

        public class FunnelChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartsortconfiguration.html#cfn-quicksight-dashboard-funnelchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartsortconfiguration.html#cfn-quicksight-dashboard-funnelchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class FunnelChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FunnelChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-funnelchartvisual.html#cfn-quicksight-dashboard-funnelchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GaugeChartArcConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartarcconditionalformatting.html#cfn-quicksight-dashboard-gaugechartarcconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class GaugeChartConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconditionalformatting.html#cfn-quicksight-dashboard-gaugechartconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GaugeChartConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GaugeChartConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class GaugeChartConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconditionalformattingoption.html#cfn-quicksight-dashboard-gaugechartconditionalformattingoption-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartArcConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GaugeChartArcConditionalFormatting Arc { get; set; }
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconditionalformattingoption.html#cfn-quicksight-dashboard-gaugechartconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartPrimaryValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GaugeChartPrimaryValueConditionalFormatting PrimaryValue { get; set; }
        }

        public class GaugeChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GaugeChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// TooltipOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-tooltipoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions TooltipOptions { get; set; }
            /// <summary>
            /// GaugeChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-gaugechartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GaugeChartOptions GaugeChartOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartconfiguration.html#cfn-quicksight-dashboard-gaugechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
        }

        public class GaugeChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartfieldwells.html#cfn-quicksight-dashboard-gaugechartfieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> TargetValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartfieldwells.html#cfn-quicksight-dashboard-gaugechartfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class GaugeChartOptions : Humidifier.Base.BaseSubResource, IHavePrimaryValueDisplayType
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ArcConfiguration Arc { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ComparisonConfiguration Comparison { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ArcAxisConfiguration ArcAxis { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartoptions.html#cfn-quicksight-dashboard-gaugechartoptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
        }

        public class GaugeChartPrimaryValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor, IHaveQuickSightDashboardTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-gaugechartprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class GaugeChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GaugeChartConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.GaugeChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gaugechartvisual.html#cfn-quicksight-dashboard-gaugechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class GeospatialCategoricalColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategoryDataColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcategoricalcolor.html#cfn-quicksight-dashboard-geospatialcategoricalcolor-categorydatacolors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialCategoricalDataColor
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GeospatialCategoricalDataColor> CategoryDataColors { get; set; }
            /// <summary>
            /// DefaultOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcategoricalcolor.html#cfn-quicksight-dashboard-geospatialcategoricalcolor-defaultopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DefaultOpacity { get; set; }
            /// <summary>
            /// NullDataVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcategoricalcolor.html#cfn-quicksight-dashboard-geospatialcategoricalcolor-nulldatavisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullDataVisibility { get; set; }
            /// <summary>
            /// NullDataSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcategoricalcolor.html#cfn-quicksight-dashboard-geospatialcategoricalcolor-nulldatasettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialNullDataSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialNullDataSettings NullDataSettings { get; set; }
        }

        public class GeospatialCategoricalDataColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
        {
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcategoricaldatacolor.html#cfn-quicksight-dashboard-geospatialcategoricaldatacolor-datavalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcategoricaldatacolor.html#cfn-quicksight-dashboard-geospatialcategoricaldatacolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GeospatialCircleRadius : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Radius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcircleradius.html#cfn-quicksight-dashboard-geospatialcircleradius-radius
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Radius { get; set; }
        }

        public class GeospatialCircleSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcirclesymbolstyle.html#cfn-quicksight-dashboard-geospatialcirclesymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialColor FillColor { get; set; }
            /// <summary>
            /// StrokeWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcirclesymbolstyle.html#cfn-quicksight-dashboard-geospatialcirclesymbolstyle-strokewidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineWidth
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLineWidth StrokeWidth { get; set; }
            /// <summary>
            /// StrokeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcirclesymbolstyle.html#cfn-quicksight-dashboard-geospatialcirclesymbolstyle-strokecolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialColor StrokeColor { get; set; }
            /// <summary>
            /// CircleRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcirclesymbolstyle.html#cfn-quicksight-dashboard-geospatialcirclesymbolstyle-circleradius
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCircleRadius
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialCircleRadius CircleRadius { get; set; }
        }

        public class GeospatialColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcolor.html#cfn-quicksight-dashboard-geospatialcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialGradientColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialGradientColor Gradient { get; set; }
            /// <summary>
            /// Categorical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcolor.html#cfn-quicksight-dashboard-geospatialcolor-categorical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCategoricalColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialCategoricalColor Categorical { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialcolor.html#cfn-quicksight-dashboard-geospatialcolor-solid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialSolidColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialSolidColor Solid { get; set; }
        }

        public class GeospatialCoordinateBounds : Humidifier.Base.BaseSubResource, IHaveWest, IHaveSouth, IHaveNorth, IHaveEast
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

        public class GeospatialDataSourceItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialdatasourceitem.html#cfn-quicksight-dashboard-geospatialdatasourceitem-staticfiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialStaticFileSource
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialStaticFileSource StaticFileDataSource { get; set; }
        }

        public class GeospatialGradientColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialgradientcolor.html#cfn-quicksight-dashboard-geospatialgradientcolor-defaultopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DefaultOpacity { get; set; }
            /// <summary>
            /// StepColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialgradientcolor.html#cfn-quicksight-dashboard-geospatialgradientcolor-stepcolors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialGradientStepColor
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GeospatialGradientStepColor> StepColors { get; set; }
            /// <summary>
            /// NullDataVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialgradientcolor.html#cfn-quicksight-dashboard-geospatialgradientcolor-nulldatavisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullDataVisibility { get; set; }
            /// <summary>
            /// NullDataSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialgradientcolor.html#cfn-quicksight-dashboard-geospatialgradientcolor-nulldatasettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialNullDataSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialNullDataSettings NullDataSettings { get; set; }
        }

        public class GeospatialGradientStepColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
        {
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialgradientstepcolor.html#cfn-quicksight-dashboard-geospatialgradientstepcolor-datavalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialgradientstepcolor.html#cfn-quicksight-dashboard-geospatialgradientstepcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GeospatialHeatmapColorScale : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialheatmapcolorscale.html#cfn-quicksight-dashboard-geospatialheatmapcolorscale-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialHeatmapDataColor
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GeospatialHeatmapDataColor> Colors { get; set; }
        }

        public class GeospatialHeatmapConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatmapColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialheatmapconfiguration.html#cfn-quicksight-dashboard-geospatialheatmapconfiguration-heatmapcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapColorScale
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialHeatmapColorScale HeatmapColor { get; set; }
        }

        public class GeospatialHeatmapDataColor : Humidifier.Base.BaseSubResource, IHaveColor
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

        public class GeospatialLayerColorField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColorValuesFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayercolorfield.html#cfn-quicksight-dashboard-geospatiallayercolorfield-colorvaluesfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> ColorValuesFields { get; set; }
            /// <summary>
            /// ColorDimensionsFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayercolorfield.html#cfn-quicksight-dashboard-geospatiallayercolorfield-colordimensionsfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> ColorDimensionsFields { get; set; }
        }

        public class GeospatialLayerDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PointLayer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayerdefinition.html#cfn-quicksight-dashboard-geospatiallayerdefinition-pointlayer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointLayer
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialPointLayer PointLayer { get; set; }
            /// <summary>
            /// PolygonLayer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayerdefinition.html#cfn-quicksight-dashboard-geospatiallayerdefinition-polygonlayer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPolygonLayer
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialPolygonLayer PolygonLayer { get; set; }
            /// <summary>
            /// LineLayer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayerdefinition.html#cfn-quicksight-dashboard-geospatiallayerdefinition-linelayer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineLayer
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLineLayer LineLayer { get; set; }
        }

        public class GeospatialLayerItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveLabel, IHaveQuickSightDashboardTypesTooltipOptionsTooltip
        {
            /// <summary>
            /// LayerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-layerid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LayerId { get; set; }
            /// <summary>
            /// JoinDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-joindefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerJoinDefinition
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLayerJoinDefinition JoinDefinition { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LayerCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.LayerCustomAction> Actions { get; set; }
            /// <summary>
            /// LayerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-layertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LayerType { get; set; }
            /// <summary>
            /// LayerDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-layerdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerDefinition
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLayerDefinition LayerDefinition { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayeritem.html#cfn-quicksight-dashboard-geospatiallayeritem-datasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialDataSourceItem
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialDataSourceItem DataSource { get; set; }
        }

        public class GeospatialLayerJoinDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayerjoindefinition.html#cfn-quicksight-dashboard-geospatiallayerjoindefinition-colorfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerColorField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLayerColorField ColorField { get; set; }
            /// <summary>
            /// ShapeKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayerjoindefinition.html#cfn-quicksight-dashboard-geospatiallayerjoindefinition-shapekeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShapeKeyField { get; set; }
            /// <summary>
            /// DatasetKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayerjoindefinition.html#cfn-quicksight-dashboard-geospatiallayerjoindefinition-datasetkeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UnaggregatedField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.UnaggregatedField DatasetKeyField { get; set; }
        }

        public class GeospatialLayerMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend
        {
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayermapconfiguration.html#cfn-quicksight-dashboard-geospatiallayermapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayermapconfiguration.html#cfn-quicksight-dashboard-geospatiallayermapconfiguration-mapstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapState
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapState MapState { get; set; }
            /// <summary>
            /// MapStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayermapconfiguration.html#cfn-quicksight-dashboard-geospatiallayermapconfiguration-mapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapStyle MapStyle { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayermapconfiguration.html#cfn-quicksight-dashboard-geospatiallayermapconfiguration-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Interactions { get; set; }
            /// <summary>
            /// MapLayers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallayermapconfiguration.html#cfn-quicksight-dashboard-geospatiallayermapconfiguration-maplayers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialLayerItem
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GeospatialLayerItem> MapLayers { get; set; }
        }

        public class GeospatialLineLayer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallinelayer.html#cfn-quicksight-dashboard-geospatiallinelayer-style
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialLineStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLineStyle Style { get; set; }
        }

        public class GeospatialLineStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineSymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallinestyle.html#cfn-quicksight-dashboard-geospatiallinestyle-linesymbolstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLineSymbolStyle LineSymbolStyle { get; set; }
        }

        public class GeospatialLineSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallinesymbolstyle.html#cfn-quicksight-dashboard-geospatiallinesymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialColor FillColor { get; set; }
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallinesymbolstyle.html#cfn-quicksight-dashboard-geospatiallinesymbolstyle-linewidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineWidth
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLineWidth LineWidth { get; set; }
        }

        public class GeospatialLineWidth : Humidifier.Base.BaseSubResource, IHaveLineWidth
        {
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatiallinewidth.html#cfn-quicksight-dashboard-geospatiallinewidth-linewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LineWidth { get; set; }
        }

        public class GeospatialMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapaggregatedfieldwells.html#cfn-quicksight-dashboard-geospatialmapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapaggregatedfieldwells.html#cfn-quicksight-dashboard-geospatialmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapaggregatedfieldwells.html#cfn-quicksight-dashboard-geospatialmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Geospatial { get; set; }
        }

        public class GeospatialMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette
        {
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Interactions { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialWindowOptions WindowOptions { get; set; }
            /// <summary>
            /// PointStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-pointstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyleOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialPointStyleOptions PointStyleOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapconfiguration.html#cfn-quicksight-dashboard-geospatialmapconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
        }

        public class GeospatialMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GeospatialMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapfieldwells.html#cfn-quicksight-dashboard-geospatialmapfieldwells-geospatialmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapAggregatedFieldWells GeospatialMapAggregatedFieldWells { get; set; }
        }

        public class GeospatialMapState : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Bounds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapstate.html#cfn-quicksight-dashboard-geospatialmapstate-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapNavigation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapstate.html#cfn-quicksight-dashboard-geospatialmapstate-mapnavigation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MapNavigation { get; set; }
        }

        public class GeospatialMapStyle : Humidifier.Base.BaseSubResource, IHaveBackgroundColor, IHaveBaseMapStyle
        {
            /// <summary>
            /// BaseMapStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapstyle.html#cfn-quicksight-dashboard-geospatialmapstyle-basemapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapStyle { get; set; }
            /// <summary>
            /// BaseMapVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapstyle.html#cfn-quicksight-dashboard-geospatialmapstyle-basemapvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapVisibility { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapstyle.html#cfn-quicksight-dashboard-geospatialmapstyle-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class GeospatialMapStyleOptions : Humidifier.Base.BaseSubResource, IHaveBaseMapStyle
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

        public class GeospatialMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialmapvisual.html#cfn-quicksight-dashboard-geospatialmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GeospatialNullDataSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialnulldatasettings.html#cfn-quicksight-dashboard-geospatialnulldatasettings-symbolstyle
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialNullSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialNullSymbolStyle SymbolStyle { get; set; }
        }

        public class GeospatialNullSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialnullsymbolstyle.html#cfn-quicksight-dashboard-geospatialnullsymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FillColor { get; set; }
            /// <summary>
            /// StrokeWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialnullsymbolstyle.html#cfn-quicksight-dashboard-geospatialnullsymbolstyle-strokewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StrokeWidth { get; set; }
            /// <summary>
            /// StrokeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialnullsymbolstyle.html#cfn-quicksight-dashboard-geospatialnullsymbolstyle-strokecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrokeColor { get; set; }
        }

        public class GeospatialPointLayer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpointlayer.html#cfn-quicksight-dashboard-geospatialpointlayer-style
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialPointStyle Style { get; set; }
        }

        public class GeospatialPointStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CircleSymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpointstyle.html#cfn-quicksight-dashboard-geospatialpointstyle-circlesymbolstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCircleSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialCircleSymbolStyle CircleSymbolStyle { get; set; }
        }

        public class GeospatialPointStyleOptions : Humidifier.Base.BaseSubResource, IHaveSelectedPointStyle
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
            public Humidifier.QuickSight.DashboardTypes.ClusterMarkerConfiguration ClusterMarkerConfiguration { get; set; }
            /// <summary>
            /// HeatmapConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpointstyleoptions.html#cfn-quicksight-dashboard-geospatialpointstyleoptions-heatmapconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialHeatmapConfiguration HeatmapConfiguration { get; set; }
        }

        public class GeospatialPolygonLayer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpolygonlayer.html#cfn-quicksight-dashboard-geospatialpolygonlayer-style
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialPolygonStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialPolygonStyle Style { get; set; }
        }

        public class GeospatialPolygonStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PolygonSymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpolygonstyle.html#cfn-quicksight-dashboard-geospatialpolygonstyle-polygonsymbolstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPolygonSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialPolygonSymbolStyle PolygonSymbolStyle { get; set; }
        }

        public class GeospatialPolygonSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpolygonsymbolstyle.html#cfn-quicksight-dashboard-geospatialpolygonsymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialColor FillColor { get; set; }
            /// <summary>
            /// StrokeWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpolygonsymbolstyle.html#cfn-quicksight-dashboard-geospatialpolygonsymbolstyle-strokewidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineWidth
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLineWidth StrokeWidth { get; set; }
            /// <summary>
            /// StrokeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialpolygonsymbolstyle.html#cfn-quicksight-dashboard-geospatialpolygonsymbolstyle-strokecolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialColor StrokeColor { get; set; }
        }

        public class GeospatialSolidColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialsolidcolor.html#cfn-quicksight-dashboard-geospatialsolidcolor-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialsolidcolor.html#cfn-quicksight-dashboard-geospatialsolidcolor-color
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Color { get; set; }
        }

        public class GeospatialStaticFileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialstaticfilesource.html#cfn-quicksight-dashboard-geospatialstaticfilesource-staticfileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticFileId { get; set; }
        }

        public class GeospatialWindowOptions : Humidifier.Base.BaseSubResource, IHaveMapZoomMode
        {
            /// <summary>
            /// Bounds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialwindowoptions.html#cfn-quicksight-dashboard-geospatialwindowoptions-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapZoomMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-geospatialwindowoptions.html#cfn-quicksight-dashboard-geospatialwindowoptions-mapzoommode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-globaltableborderoptions.html#cfn-quicksight-dashboard-globaltableborderoptions-uniformborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions UniformBorder { get; set; }
            /// <summary>
            /// SideSpecificBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-globaltableborderoptions.html#cfn-quicksight-dashboard-globaltableborderoptions-sidespecificborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSideBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableSideBorderOptions SideSpecificBorder { get; set; }
        }

        public class GradientColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Stops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gradientcolor.html#cfn-quicksight-dashboard-gradientcolor-stops
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GradientStop
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GradientStop> Stops { get; set; }
        }

        public class GradientStop : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue, IHaveGradientOffset
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

        public class GridLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutcanvassizeoptions.html#cfn-quicksight-dashboard-gridlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutScreenCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class GridLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutconfiguration.html#cfn-quicksight-dashboard-gridlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-gridlayoutconfiguration.html#cfn-quicksight-dashboard-gridlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GridLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.GridLayoutElement> Elements { get; set; }
        }

        public class GridLayoutElement : Humidifier.Base.BaseSubResource, IHaveElementType, IHaveElementId, IHaveColumnSpan, IHaveColumnIndex, IHaveRowIndex, IHaveRowSpan
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

        public class GridLayoutScreenCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedViewPortWidth, IHaveResizeOption
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

        public class GrowthRateComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveQuickSightDashboardTypesDimensionFieldTime, IHavePeriodSize
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-growthratecomputation.html#cfn-quicksight-dashboard-growthratecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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

        public class HeaderFooterSectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSectionId
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-headerfootersectionconfiguration.html#cfn-quicksight-dashboard-headerfootersectionconfiguration-layout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionLayoutConfiguration Layout { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-headerfootersectionconfiguration.html#cfn-quicksight-dashboard-headerfootersectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionStyle Style { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-headerfootersectionconfiguration.html#cfn-quicksight-dashboard-headerfootersectionconfiguration-sectionid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapaggregatedfieldwells.html#cfn-quicksight-dashboard-heatmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapaggregatedfieldwells.html#cfn-quicksight-dashboard-heatmapaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapaggregatedfieldwells.html#cfn-quicksight-dashboard-heatmapaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Rows { get; set; }
        }

        public class HeatMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HeatMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// ColumnLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-columnlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ColumnLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HeatMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColorScale ColorScale { get; set; }
            /// <summary>
            /// RowLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapconfiguration.html#cfn-quicksight-dashboard-heatmapconfiguration-rowlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions RowLabelOptions { get; set; }
        }

        public class HeatMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapfieldwells.html#cfn-quicksight-dashboard-heatmapfieldwells-heatmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HeatMapAggregatedFieldWells HeatMapAggregatedFieldWells { get; set; }
        }

        public class HeatMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatMapRowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmaprowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> HeatMapRowSort { get; set; }
            /// <summary>
            /// HeatMapRowItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmaprowitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration HeatMapRowItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmapcolumnitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration HeatMapColumnItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapsortconfiguration.html#cfn-quicksight-dashboard-heatmapsortconfiguration-heatmapcolumnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> HeatMapColumnSort { get; set; }
        }

        public class HeatMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.HeatMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-heatmapvisual.html#cfn-quicksight-dashboard-heatmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class HistogramAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramaggregatedfieldwells.html#cfn-quicksight-dashboard-histogramaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class HistogramBinOptions : Humidifier.Base.BaseSubResource, IHaveStartValue, IHaveSelectedBinType
        {
            /// <summary>
            /// BinWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogrambinoptions.html#cfn-quicksight-dashboard-histogrambinoptions-binwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinWidthOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BinWidthOptions BinWidth { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.BinCountOptions BinCount { get; set; }
        }

        public class HistogramConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveQuickSightDashboardTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// BinOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-binoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramBinOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HistogramBinOptions BinOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HistogramFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramconfiguration.html#cfn-quicksight-dashboard-histogramconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class HistogramFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HistogramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramfieldwells.html#cfn-quicksight-dashboard-histogramfieldwells-histogramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HistogramAggregatedFieldWells HistogramAggregatedFieldWells { get; set; }
        }

        public class HistogramVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.HistogramConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-histogramvisual.html#cfn-quicksight-dashboard-histogramvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomaction.html#cfn-quicksight-dashboard-imagecustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomaction.html#cfn-quicksight-dashboard-imagecustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomaction.html#cfn-quicksight-dashboard-imagecustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomaction.html#cfn-quicksight-dashboard-imagecustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomaction.html#cfn-quicksight-dashboard-imagecustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImageCustomActionOperation
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ImageCustomActionOperation> ActionOperations { get; set; }
        }

        public class ImageCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomactionoperation.html#cfn-quicksight-dashboard-imagecustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomactionoperation.html#cfn-quicksight-dashboard-imagecustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagecustomactionoperation.html#cfn-quicksight-dashboard-imagecustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class ImageInteractionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageMenuOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imageinteractionoptions.html#cfn-quicksight-dashboard-imageinteractionoptions-imagemenuoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageMenuOption
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ImageMenuOption ImageMenuOption { get; set; }
        }

        public class ImageMenuOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagemenuoption.html#cfn-quicksight-dashboard-imagemenuoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class ImageStaticFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagestaticfile.html#cfn-quicksight-dashboard-imagestaticfile-staticfileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticFileId { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-imagestaticfile.html#cfn-quicksight-dashboard-imagestaticfile-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileSource
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StaticFileSource Source { get; set; }
        }

        public class InnerFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategoryInnerFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-innerfilter.html#cfn-quicksight-dashboard-innerfilter-categoryinnerfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryInnerFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoryInnerFilter CategoryInnerFilter { get; set; }
        }

        public class InsightConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Computations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightconfiguration.html#cfn-quicksight-dashboard-insightconfiguration-computations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Computation
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.Computation> Computations { get; set; }
            /// <summary>
            /// CustomNarrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightconfiguration.html#cfn-quicksight-dashboard-insightconfiguration-customnarrative
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomNarrativeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomNarrativeOptions CustomNarrative { get; set; }
        }

        public class InsightVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.InsightConfiguration InsightConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-insightvisual.html#cfn-quicksight-dashboard-insightvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class IntegerDefaultValues : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerdefaultvalues.html#cfn-quicksight-dashboard-integerdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class IntegerParameter : Humidifier.Base.BaseSubResource, IHaveName
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

        public class IntegerParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.IntegerDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.IntegerValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameterdeclaration.html#cfn-quicksight-dashboard-integerparameterdeclaration-name
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

        public class ItemsLimitConfiguration : Humidifier.Base.BaseSubResource, IHaveItemsLimit, IHaveOtherCategories
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

        public class KPIActualValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor, IHaveQuickSightDashboardTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiactualvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiactualvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiactualvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiactualvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIComparisonValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor, IHaveQuickSightDashboardTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-dashboard-kpicomparisonvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-dashboard-kpicomparisonvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformatting.html#cfn-quicksight-dashboard-kpiconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KPIConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.KPIConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class KPIConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIPrimaryValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIPrimaryValueConditionalFormatting PrimaryValue { get; set; }
            /// <summary>
            /// ActualValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-actualvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIActualValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIActualValueConditionalFormatting ActualValue { get; set; }
            /// <summary>
            /// ComparisonValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-comparisonvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIComparisonValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIComparisonValueConditionalFormatting ComparisonValue { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconditionalformattingoption.html#cfn-quicksight-dashboard-kpiconditionalformattingoption-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIProgressBarConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIProgressBarConditionalFormatting ProgressBar { get; set; }
        }

        public class KPIConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconfiguration.html#cfn-quicksight-dashboard-kpiconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPISortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// KPIOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconfiguration.html#cfn-quicksight-dashboard-kpiconfiguration-kpioptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIOptions KPIOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiconfiguration.html#cfn-quicksight-dashboard-kpiconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIFieldWells FieldWells { get; set; }
        }

        public class KPIFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpifieldwells.html#cfn-quicksight-dashboard-kpifieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> TargetValues { get; set; }
            /// <summary>
            /// TrendGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpifieldwells.html#cfn-quicksight-dashboard-kpifieldwells-trendgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> TrendGroups { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpifieldwells.html#cfn-quicksight-dashboard-kpifieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class KPIOptions : Humidifier.Base.BaseSubResource, IHavePrimaryValueDisplayType
        {
            /// <summary>
            /// SecondaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-secondaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration SecondaryValueFontConfiguration { get; set; }
            /// <summary>
            /// VisualLayoutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-visuallayoutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualLayoutOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIVisualLayoutOptions VisualLayoutOptions { get; set; }
            /// <summary>
            /// TrendArrows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-trendarrows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendArrowOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TrendArrowOptions TrendArrows { get; set; }
            /// <summary>
            /// SecondaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-secondaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecondaryValueOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SecondaryValueOptions SecondaryValue { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ComparisonConfiguration Comparison { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ProgressBarOptions ProgressBar { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
            /// <summary>
            /// Sparkline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpioptions.html#cfn-quicksight-dashboard-kpioptions-sparkline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISparklineOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPISparklineOptions Sparkline { get; set; }
        }

        public class KPIPrimaryValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor, IHaveQuickSightDashboardTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-dashboard-kpiprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIProgressBarConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpiprogressbarconditionalformatting.html#cfn-quicksight-dashboard-kpiprogressbarconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class KPISortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrendGroupSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpisortconfiguration.html#cfn-quicksight-dashboard-kpisortconfiguration-trendgroupsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> TrendGroupSort { get; set; }
        }

        public class KPISparklineOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveVisibility, IHaveColor, IHaveTooltipVisibility
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

        public class KPIVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.KPIConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisual.html#cfn-quicksight-dashboard-kpivisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class KPIVisualLayoutOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StandardLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-kpivisuallayoutoptions.html#cfn-quicksight-dashboard-kpivisuallayoutoptions-standardlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualStandardLayout
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIVisualStandardLayout StandardLayout { get; set; }
        }

        public class KPIVisualStandardLayout : Humidifier.Base.BaseSubResource, IHaveType
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

        public class LabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveCustomLabel, IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class LayerCustomAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveTrigger, IHaveCustomActionId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomaction.html#cfn-quicksight-dashboard-layercustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomaction.html#cfn-quicksight-dashboard-layercustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomaction.html#cfn-quicksight-dashboard-layercustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomaction.html#cfn-quicksight-dashboard-layercustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomaction.html#cfn-quicksight-dashboard-layercustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LayerCustomActionOperation
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.LayerCustomActionOperation> ActionOperations { get; set; }
        }

        public class LayerCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomactionoperation.html#cfn-quicksight-dashboard-layercustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomactionoperation.html#cfn-quicksight-dashboard-layercustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomactionoperation.html#cfn-quicksight-dashboard-layercustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layercustomactionoperation.html#cfn-quicksight-dashboard-layercustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class LayerMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layermapvisual.html#cfn-quicksight-dashboard-layermapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layermapvisual.html#cfn-quicksight-dashboard-layermapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layermapvisual.html#cfn-quicksight-dashboard-layermapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerMapConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialLayerMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layermapvisual.html#cfn-quicksight-dashboard-layermapvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layermapvisual.html#cfn-quicksight-dashboard-layermapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layermapvisual.html#cfn-quicksight-dashboard-layermapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class Layout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layout.html#cfn-quicksight-dashboard-layout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LayoutConfiguration Configuration { get; set; }
        }

        public class LayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layoutconfiguration.html#cfn-quicksight-dashboard-layoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GridLayoutConfiguration GridLayout { get; set; }
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layoutconfiguration.html#cfn-quicksight-dashboard-layoutconfiguration-freeformlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FreeFormLayoutConfiguration FreeFormLayout { get; set; }
            /// <summary>
            /// SectionBasedLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-layoutconfiguration.html#cfn-quicksight-dashboard-layoutconfiguration-sectionbasedlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutConfiguration SectionBasedLayout { get; set; }
        }

        public class LegendOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveWidth, IHavePosition
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
            /// ValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-valuefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration ValueFontConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-legendoptions.html#cfn-quicksight-dashboard-legendoptions-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions Title { get; set; }
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

        public class LineChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartaggregatedfieldwells.html#cfn-quicksight-dashboard-linechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class LineChartConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveQuickSightDashboardTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightDashboardTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightDashboardTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SingleAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-singleaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleAxisOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SingleAxisOptions SingleAxisOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
            /// <summary>
            /// DefaultSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-defaultseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartDefaultSeriesSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ForecastConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-forecastconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ForecastConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ForecastConfiguration> ForecastConfigurations { get; set; }
            /// <summary>
            /// Series
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-series
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeriesItem
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SeriesItem> Series { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartconfiguration.html#cfn-quicksight-dashboard-linechartconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
        }

        public class LineChartDefaultSeriesSettings : Humidifier.Base.BaseSubResource, IHaveAxisBinding
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartdefaultseriessettings.html#cfn-quicksight-dashboard-linechartdefaultseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartfieldwells.html#cfn-quicksight-dashboard-linechartfieldwells-linechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartAggregatedFieldWells LineChartAggregatedFieldWells { get; set; }
        }

        public class LineChartLineStyleSettings : Humidifier.Base.BaseSubResource, IHaveLineInterpolation, IHaveLineStyle, IHaveLineVisibility, IHaveLineWidth
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

        public class LineChartMarkerStyleSettings : Humidifier.Base.BaseSubResource, IHaveMarkerShape, IHaveMarkerSize, IHaveMarkerVisibility, IHaveMarkerColor
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

        public class LineChartSeriesSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartseriessettings.html#cfn-quicksight-dashboard-linechartseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartseriessettings.html#cfn-quicksight-dashboard-linechartseriessettings-markerstylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartMarkerStyleSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// CategoryItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-categoryitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimitConfiguration { get; set; }
            /// <summary>
            /// ColorItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-coloritemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration ColorItemsLimitConfiguration { get; set; }
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartsortconfiguration.html#cfn-quicksight-dashboard-linechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class LineChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.LineChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linechartvisual.html#cfn-quicksight-dashboard-linechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class LineSeriesAxisDisplayOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MissingDataConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-lineseriesaxisdisplayoptions.html#cfn-quicksight-dashboard-lineseriesaxisdisplayoptions-missingdataconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MissingDataConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MissingDataConfiguration> MissingDataConfigurations { get; set; }
            /// <summary>
            /// AxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-lineseriesaxisdisplayoptions.html#cfn-quicksight-dashboard-lineseriesaxisdisplayoptions-axisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions AxisOptions { get; set; }
        }

        public class LinkSharingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-linksharingconfiguration.html#cfn-quicksight-dashboard-linksharingconfiguration-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourcePermission
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ResourcePermission> Permissions { get; set; }
        }

        public class ListControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SearchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-searchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSearchOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ListControlSearchOptions SearchOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-listcontroldisplayoptions.html#cfn-quicksight-dashboard-listcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ListControlSearchOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class ListControlSelectAllOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class LoadingAnimation : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class LocalNavigationConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetSheetId
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

        public class LongFormatText : Humidifier.Base.BaseSubResource, IHaveRichText, IHavePlainText
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

        public class MappedDataSetParameter : Humidifier.Base.BaseSubResource, IHaveDataSetIdentifier, IHaveDataSetParameterName
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

        public class MaximumLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class MaximumMinimumComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveQuickSightDashboardTypesDimensionFieldTime
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
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-maximumminimumcomputation.html#cfn-quicksight-dashboard-maximumminimumcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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

        public class MeasureField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-datemeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateMeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateMeasureField DateMeasureField { get; set; }
            /// <summary>
            /// NumericalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-numericalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalMeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericalMeasureField NumericalMeasureField { get; set; }
            /// <summary>
            /// CategoricalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-categoricalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalMeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CategoricalMeasureField CategoricalMeasureField { get; set; }
            /// <summary>
            /// CalculatedMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-measurefield.html#cfn-quicksight-dashboard-measurefield-calculatedmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CalculatedMeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CalculatedMeasureField CalculatedMeasureField { get; set; }
        }

        public class MetricComparisonComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesDimensionFieldTime
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MeasureField TargetValue { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.MeasureField FromValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-metriccomparisoncomputation.html#cfn-quicksight-dashboard-metriccomparisoncomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-minimumlabeltype.html#cfn-quicksight-dashboard-minimumlabeltype-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class MissingDataConfiguration : Humidifier.Base.BaseSubResource, IHaveTreatmentOption
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

        public class NegativeValueConfiguration : Humidifier.Base.BaseSubResource, IHaveDisplayMode
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

        public class NestedFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-nestedfilter.html#cfn-quicksight-dashboard-nestedfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// InnerFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-nestedfilter.html#cfn-quicksight-dashboard-nestedfilter-innerfilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InnerFilter
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.InnerFilter InnerFilter { get; set; }
            /// <summary>
            /// IncludeInnerSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-nestedfilter.html#cfn-quicksight-dashboard-nestedfilter-includeinnerset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeInnerSet { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-nestedfilter.html#cfn-quicksight-dashboard-nestedfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-nullvalueformatconfiguration.html#cfn-quicksight-dashboard-nullvalueformatconfiguration-nullstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullString { get; set; }
        }

        public class NumberDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveNumberScale, IHaveQuickSightDashboardTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightDashboardTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightDashboardTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightDashboardTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberdisplayformatconfiguration.html#cfn-quicksight-dashboard-numberdisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numberformatconfiguration.html#cfn-quicksight-dashboard-numberformatconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
        }

        public class NumericAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaxisoptions.html#cfn-quicksight-dashboard-numericaxisoptions-scale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisScale
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisScale Scale { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaxisoptions.html#cfn-quicksight-dashboard-numericaxisoptions-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayRange
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayRange Range { get; set; }
        }

        public class NumericEqualityDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveQuickSightDashboardTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalitydrilldownfilter.html#cfn-quicksight-dashboard-numericequalitydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalitydrilldownfilter.html#cfn-quicksight-dashboard-numericequalitydrilldownfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class NumericEqualityFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveParameterName, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveQuickSightDashboardTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericequalityfilter.html#cfn-quicksight-dashboard-numericequalityfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericformatconfiguration.html#cfn-quicksight-dashboard-numericformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// CurrencyDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericformatconfiguration.html#cfn-quicksight-dashboard-numericformatconfiguration-currencydisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CurrencyDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CurrencyDisplayFormatConfiguration CurrencyDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericformatconfiguration.html#cfn-quicksight-dashboard-numericformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class NumericRangeFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveSelectAllOptions, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveIncludeMaximum, IHaveIncludeMinimum, IHaveQuickSightDashboardTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NumericRangeFilterValue RangeMinimum { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NumericRangeFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericrangefilter.html#cfn-quicksight-dashboard-numericrangefilter-includeminimum
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

        public class NumericSeparatorConfiguration : Humidifier.Base.BaseSubResource, IHaveDecimalSeparator
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
            public Humidifier.QuickSight.DashboardTypes.ThousandSeparatorOptions ThousandsSeparator { get; set; }
        }

        public class NumericalAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleNumericalAggregation
        {
            /// <summary>
            /// PercentileAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalaggregationfunction.html#cfn-quicksight-dashboard-numericalaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentileAggregation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PercentileAggregation PercentileAggregation { get; set; }
            /// <summary>
            /// SimpleNumericalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalaggregationfunction.html#cfn-quicksight-dashboard-numericalaggregationfunction-simplenumericalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleNumericalAggregation { get; set; }
        }

        public class NumericalDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveHierarchyId
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
            public Humidifier.QuickSight.DashboardTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaldimensionfield.html#cfn-quicksight-dashboard-numericaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericaldimensionfield.html#cfn-quicksight-dashboard-numericaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class NumericalMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericalAggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-numericalmeasurefield.html#cfn-quicksight-dashboard-numericalmeasurefield-fieldid
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

        public class PanelConfiguration : Humidifier.Base.BaseSubResource, IHaveBackgroundColor, IHaveBorderThickness, IHaveBorderStyle, IHaveGutterSpacing, IHaveBackgroundVisibility, IHaveBorderVisibility, IHaveBorderColor, IHaveGutterVisibility
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
            public Humidifier.QuickSight.DashboardTypes.PanelTitleOptions Title { get; set; }
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

        public class PanelTitleOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHorizontalTextAlignment, IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-paneltitleoptions.html#cfn-quicksight-dashboard-paneltitleoptions-horizontaltextalignment
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSliderControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextAreaControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDropDownControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextFieldControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterListControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parametercontrol.html#cfn-quicksight-dashboard-parametercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDateTimePickerControl
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterDateTimePickerControl DateTimePicker { get; set; }
        }

        public class ParameterDateTimePickerControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightDashboardTypesDateTimePickerControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
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

        public class ParameterDeclaration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-stringparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StringParameterDeclaration StringParameterDeclaration { get; set; }
            /// <summary>
            /// DateTimeParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-datetimeparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DateTimeParameterDeclaration DateTimeParameterDeclaration { get; set; }
            /// <summary>
            /// DecimalParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-decimalparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DecimalParameterDeclaration DecimalParameterDeclaration { get; set; }
            /// <summary>
            /// IntegerParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdeclaration.html#cfn-quicksight-dashboard-parameterdeclaration-integerparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.IntegerParameterDeclaration IntegerParameterDeclaration { get; set; }
        }

        public class ParameterDropDownControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightDashboardTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightDashboardTypesDropDownControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterdropdowncontrol.html#cfn-quicksight-dashboard-parameterdropdowncontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterListControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightDashboardTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightDashboardTypesListControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.ListControlDisplayOptions DisplayOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterSelectableValues : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// LinkToDataSetColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameterselectablevalues.html#cfn-quicksight-dashboard-parameterselectablevalues-linktodatasetcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier LinkToDataSetColumn { get; set; }
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

        public class ParameterSliderControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightDashboardTypesSliderControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
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

        public class ParameterTextAreaControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveDelimiter, IHaveQuickSightDashboardTypesTextAreaControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
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

        public class ParameterTextFieldControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightDashboardTypesTextFieldControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.DashboardTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
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

        public class Parameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-stringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.StringParameter> StringParameters { get; set; }
            /// <summary>
            /// DecimalParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-decimalparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DecimalParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DecimalParameter> DecimalParameters { get; set; }
            /// <summary>
            /// IntegerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-integerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.IntegerParameter> IntegerParameters { get; set; }
            /// <summary>
            /// DateTimeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html#cfn-quicksight-dashboard-parameters-datetimeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateTimeParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DateTimeParameter> DateTimeParameters { get; set; }
        }

        public class PercentVisibleRange : Humidifier.Base.BaseSubResource, IHaveFrom, IHaveTo
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

        public class PercentageDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveQuickSightDashboardTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightDashboardTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightDashboardTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightDashboardTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentagedisplayformatconfiguration.html#cfn-quicksight-dashboard-percentagedisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-percentileaggregation.html#cfn-quicksight-dashboard-percentileaggregation-percentilevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentileValue { get; set; }
        }

        public class PeriodOverPeriodComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveQuickSightDashboardTypesDimensionFieldTime
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodoverperiodcomputation.html#cfn-quicksight-dashboard-periodoverperiodcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodoverperiodcomputation.html#cfn-quicksight-dashboard-periodoverperiodcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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

        public class PeriodToDateComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveQuickSightDashboardTypesDimensionFieldTime, IHavePeriodTimeGranularity
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
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-periodtodatecomputation.html#cfn-quicksight-dashboard-periodtodatecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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

        public class PieChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartaggregatedfieldwells.html#cfn-quicksight-dashboard-piechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartaggregatedfieldwells.html#cfn-quicksight-dashboard-piechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartaggregatedfieldwells.html#cfn-quicksight-dashboard-piechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class PieChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightDashboardTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightDashboardTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PieChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PieChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// DonutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-donutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DonutOptions DonutOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartconfiguration.html#cfn-quicksight-dashboard-piechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
        }

        public class PieChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PieChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartfieldwells.html#cfn-quicksight-dashboard-piechartfieldwells-piechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PieChartAggregatedFieldWells PieChartAggregatedFieldWells { get; set; }
        }

        public class PieChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightDashboardTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartsortconfiguration.html#cfn-quicksight-dashboard-piechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class PieChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.PieChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-piechartvisual.html#cfn-quicksight-dashboard-piechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class PivotFieldSortOptions : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivotfieldsortoptions.html#cfn-quicksight-dashboard-pivotfieldsortoptions-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableSortBy
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableSortBy SortBy { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivotfieldsortoptions.html#cfn-quicksight-dashboard-pivotfieldsortoptions-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableaggregatedfieldwells.html#cfn-quicksight-dashboard-pivottableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableaggregatedfieldwells.html#cfn-quicksight-dashboard-pivottableaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableaggregatedfieldwells.html#cfn-quicksight-dashboard-pivottableaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Rows { get; set; }
        }

        public class PivotTableCellConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablecellconditionalformatting.html#cfn-quicksight-dashboard-pivottablecellconditionalformatting-scope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormattingScope
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableConditionalFormattingScope Scope { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablecellconditionalformatting.html#cfn-quicksight-dashboard-pivottablecellconditionalformatting-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingScope
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PivotTableConditionalFormattingScope> Scopes { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TextConditionalFormat TextFormat { get; set; }
        }

        public class PivotTableConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconditionalformatting.html#cfn-quicksight-dashboard-pivottableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PivotTableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class PivotTableConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconditionalformattingoption.html#cfn-quicksight-dashboard-pivottableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableCellConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableCellConditionalFormatting Cell { get; set; }
        }

        public class PivotTableConditionalFormattingScope : Humidifier.Base.BaseSubResource, IHaveRole
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

        public class PivotTableConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTablePaginatedReportOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableOptions TableOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableconfiguration.html#cfn-quicksight-dashboard-pivottableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableTotalOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableTotalOptions TotalOptions { get; set; }
        }

        public class PivotTableDataPathOption : Humidifier.Base.BaseSubResource, IHaveWidth
        {
            /// <summary>
            /// DataPathList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabledatapathoption.html#cfn-quicksight-dashboard-pivottabledatapathoption-datapathlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DataPathValue> DataPathList { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabledatapathoption.html#cfn-quicksight-dashboard-pivottabledatapathoption-width
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldcollapsestateoption.html#cfn-quicksight-dashboard-pivottablefieldcollapsestateoption-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableFieldCollapseStateTarget
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableFieldCollapseStateTarget Target { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldcollapsestateoption.html#cfn-quicksight-dashboard-pivottablefieldcollapsestateoption-state
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
            public List<Humidifier.QuickSight.DashboardTypes.DataPathValue> FieldDataPathValues { get; set; }
        }

        public class PivotTableFieldOption : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveCustomLabel
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

        public class PivotTableFieldOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CollapseStateOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoptions.html#cfn-quicksight-dashboard-pivottablefieldoptions-collapsestateoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldCollapseStateOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PivotTableFieldCollapseStateOption> CollapseStateOptions { get; set; }
            /// <summary>
            /// DataPathOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoptions.html#cfn-quicksight-dashboard-pivottablefieldoptions-datapathoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableDataPathOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PivotTableDataPathOption> DataPathOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldoptions.html#cfn-quicksight-dashboard-pivottablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PivotTableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class PivotTableFieldSubtotalOptions : Humidifier.Base.BaseSubResource, IHaveFieldId
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

        public class PivotTableFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PivotTableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablefieldwells.html#cfn-quicksight-dashboard-pivottablefieldwells-pivottableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableAggregatedFieldWells PivotTableAggregatedFieldWells { get; set; }
        }

        public class PivotTableOptions : Humidifier.Base.BaseSubResource, IHaveCollapsedRowDimensionsVisibility, IHaveRowsLayout, IHaveMetricPlacement, IHaveDefaultCellWidth, IHaveColumnNamesVisibility, IHaveSingleMetricVisibility, IHaveToggleButtonsVisibility
        {
            /// <summary>
            /// RowFieldNamesStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowfieldnamesstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle RowFieldNamesStyle { get; set; }
            /// <summary>
            /// RowHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle RowHeaderStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.PivotTableRowsLabelOptions RowsLabelOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle ColumnHeaderStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottableoptions.html#cfn-quicksight-dashboard-pivottableoptions-rowalternatecoloroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowAlternateColorOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class PivotTablePaginatedReportOptions : Humidifier.Base.BaseSubResource, IHaveOverflowColumnHeaderVisibility, IHaveVerticalOverflowVisibility
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

        public class PivotTableRowsLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveCustomLabel
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

        public class PivotTableSortBy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortby.html#cfn-quicksight-dashboard-pivottablesortby-field
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FieldSort Field { get; set; }
            /// <summary>
            /// DataPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortby.html#cfn-quicksight-dashboard-pivottablesortby-datapath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathSort
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataPathSort DataPath { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortby.html#cfn-quicksight-dashboard-pivottablesortby-column
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnSort Column { get; set; }
        }

        public class PivotTableSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSortOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablesortconfiguration.html#cfn-quicksight-dashboard-pivottablesortconfiguration-fieldsortoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotFieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PivotFieldSortOptions> FieldSortOptions { get; set; }
        }

        public class PivotTableTotalOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-columnsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SubtotalOptions ColumnSubtotalOptions { get; set; }
            /// <summary>
            /// RowSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-rowsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SubtotalOptions RowSubtotalOptions { get; set; }
            /// <summary>
            /// RowTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-rowtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTotalOptions RowTotalOptions { get; set; }
            /// <summary>
            /// ColumnTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottabletotaloptions.html#cfn-quicksight-dashboard-pivottabletotaloptions-columntotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTotalOptions ColumnTotalOptions { get; set; }
        }

        public class PivotTableVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.PivotTableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottablevisual.html#cfn-quicksight-dashboard-pivottablevisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class PivotTotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHavePlacement, IHaveScrollStatus, IHaveQuickSightDashboardTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pivottotaloptions.html#cfn-quicksight-dashboard-pivottotaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle ValueCellStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle TotalCellStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
        }

        public class PluginVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisual.html#cfn-quicksight-dashboard-pluginvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// PluginArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisual.html#cfn-quicksight-dashboard-pluginvisual-pluginarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PluginArn { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisual.html#cfn-quicksight-dashboard-pluginvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisual.html#cfn-quicksight-dashboard-pluginvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PluginVisualConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisual.html#cfn-quicksight-dashboard-pluginvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisual.html#cfn-quicksight-dashboard-pluginvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualconfiguration.html#cfn-quicksight-dashboard-pluginvisualconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PluginVisualSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// VisualOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualconfiguration.html#cfn-quicksight-dashboard-pluginvisualconfiguration-visualoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PluginVisualOptions VisualOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualconfiguration.html#cfn-quicksight-dashboard-pluginvisualconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PluginVisualFieldWell
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PluginVisualFieldWell> FieldWells { get; set; }
        }

        public class PluginVisualFieldWell : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Unaggregated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualfieldwell.html#cfn-quicksight-dashboard-pluginvisualfieldwell-unaggregated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.UnaggregatedField> Unaggregated { get; set; }
            /// <summary>
            /// AxisName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualfieldwell.html#cfn-quicksight-dashboard-pluginvisualfieldwell-axisname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisName { get; set; }
            /// <summary>
            /// Measures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualfieldwell.html#cfn-quicksight-dashboard-pluginvisualfieldwell-measures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Measures { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualfieldwell.html#cfn-quicksight-dashboard-pluginvisualfieldwell-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Dimensions { get; set; }
        }

        public class PluginVisualItemsLimitConfiguration : Humidifier.Base.BaseSubResource, IHaveItemsLimit
        {
            /// <summary>
            /// ItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualitemslimitconfiguration.html#cfn-quicksight-dashboard-pluginvisualitemslimitconfiguration-itemslimit
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualoptions.html#cfn-quicksight-dashboard-pluginvisualoptions-visualproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PluginVisualProperty
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.PluginVisualProperty> VisualProperties { get; set; }
        }

        public class PluginVisualProperty : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualproperty.html#cfn-quicksight-dashboard-pluginvisualproperty-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualproperty.html#cfn-quicksight-dashboard-pluginvisualproperty-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualsortconfiguration.html#cfn-quicksight-dashboard-pluginvisualsortconfiguration-pluginvisualtablequerysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualTableQuerySort
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PluginVisualTableQuerySort PluginVisualTableQuerySort { get; set; }
        }

        public class PluginVisualTableQuerySort : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualtablequerysort.html#cfn-quicksight-dashboard-pluginvisualtablequerysort-itemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PluginVisualItemsLimitConfiguration ItemsLimitConfiguration { get; set; }
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-pluginvisualtablequerysort.html#cfn-quicksight-dashboard-pluginvisualtablequerysort-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> RowSort { get; set; }
        }

        public class PredefinedHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
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
            public List<Humidifier.QuickSight.DashboardTypes.DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-predefinedhierarchy.html#cfn-quicksight-dashboard-predefinedhierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnIdentifier> Columns { get; set; }
        }

        public class ProgressBarOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class RadarChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartaggregatedfieldwells.html#cfn-quicksight-dashboard-radarchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartaggregatedfieldwells.html#cfn-quicksight-dashboard-radarchartaggregatedfieldwells-color
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Color { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartaggregatedfieldwells.html#cfn-quicksight-dashboard-radarchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class RadarChartAreaStyleSettings : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class RadarChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveShape, IHaveQuickSightDashboardTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsCategoryAxis, IHaveAxesRangeScale, IHaveAlternateBandColorsVisibility, IHaveStartAngle, IHaveAlternateBandOddColor, IHaveAlternateBandEvenColor
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RadarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.RadarChartSeriesSettings BaseSeriesSettings { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RadarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ColorAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartconfiguration.html#cfn-quicksight-dashboard-radarchartconfiguration-coloraxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions ColorAxis { get; set; }
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

        public class RadarChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RadarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartfieldwells.html#cfn-quicksight-dashboard-radarchartfieldwells-radarchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RadarChartAggregatedFieldWells RadarChartAggregatedFieldWells { get; set; }
        }

        public class RadarChartSeriesSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AreaStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartseriessettings.html#cfn-quicksight-dashboard-radarchartseriessettings-areastylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAreaStyleSettings
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RadarChartAreaStyleSettings AreaStyleSettings { get; set; }
        }

        public class RadarChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightDashboardTypesItemsLimitConfigurationColorItemsLimit
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartsortconfiguration.html#cfn-quicksight-dashboard-radarchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class RadarChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.RadarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-radarchartvisual.html#cfn-quicksight-dashboard-radarchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class RangeEndsLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class ReferenceLine : Humidifier.Base.BaseSubResource, IHaveStatus
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
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineDataConfiguration DataConfiguration { get; set; }
            /// <summary>
            /// LabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referenceline.html#cfn-quicksight-dashboard-referenceline-labelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineLabelConfiguration LabelConfiguration { get; set; }
            /// <summary>
            /// StyleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referenceline.html#cfn-quicksight-dashboard-referenceline-styleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineStyleConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineStyleConfiguration StyleConfiguration { get; set; }
        }

        public class ReferenceLineCustomLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomLabel
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

        public class ReferenceLineDataConfiguration : Humidifier.Base.BaseSubResource, IHaveAxisBinding, IHaveSeriesType
        {
            /// <summary>
            /// DynamicConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedataconfiguration.html#cfn-quicksight-dashboard-referencelinedataconfiguration-dynamicconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineDynamicDataConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineDynamicDataConfiguration DynamicConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineStaticDataConfiguration StaticConfiguration { get; set; }
        }

        public class ReferenceLineDynamicDataConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedynamicdataconfiguration.html#cfn-quicksight-dashboard-referencelinedynamicdataconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// MeasureAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedynamicdataconfiguration.html#cfn-quicksight-dashboard-referencelinedynamicdataconfiguration-measureaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AggregationFunction MeasureAggregationFunction { get; set; }
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinedynamicdataconfiguration.html#cfn-quicksight-dashboard-referencelinedynamicdataconfiguration-calculation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericalAggregationFunction Calculation { get; set; }
        }

        public class ReferenceLineLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration, IHaveHorizontalPosition, IHaveVerticalPosition
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
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineValueLabelConfiguration ValueLabelConfiguration { get; set; }
            /// <summary>
            /// CustomLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-customlabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineCustomLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ReferenceLineCustomLabelConfiguration CustomLabelConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// VerticalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinelabelconfiguration.html#cfn-quicksight-dashboard-referencelinelabelconfiguration-verticalposition
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinestaticdataconfiguration.html#cfn-quicksight-dashboard-referencelinestaticdataconfiguration-value
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

        public class ReferenceLineValueLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveRelativePosition
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinevaluelabelconfiguration.html#cfn-quicksight-dashboard-referencelinevaluelabelconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// RelativePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-referencelinevaluelabelconfiguration.html#cfn-quicksight-dashboard-referencelinevaluelabelconfiguration-relativeposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativePosition { get; set; }
        }

        public class RelativeDateTimeControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatetimecontroldisplayoptions.html#cfn-quicksight-dashboard-relativedatetimecontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatetimecontroldisplayoptions.html#cfn-quicksight-dashboard-relativedatetimecontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-relativedatetimecontroldisplayoptions.html#cfn-quicksight-dashboard-relativedatetimecontroldisplayoptions-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class RelativeDatesFilter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveRelativeDateValue, IHaveRelativeDateType, IHaveMinimumGranularity
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
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.AnchorDateConfiguration AnchorDateConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
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

        public class RollingDateConfiguration : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveDataSetIdentifier
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

        public class RowAlternateColorOptions : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveUsePrimaryBackgroundColor, IHaveRowAlternateColors
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

        public class SameSheetTargetVisualConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetVisualOptions, IHaveTargetVisuals
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

        public class SankeyDiagramAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-dashboard-sankeydiagramaggregatedfieldwells-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-dashboard-sankeydiagramaggregatedfieldwells-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Source { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-dashboard-sankeydiagramaggregatedfieldwells-weight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Weight { get; set; }
        }

        public class SankeyDiagramChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramchartconfiguration.html#cfn-quicksight-dashboard-sankeydiagramchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SankeyDiagramSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramchartconfiguration.html#cfn-quicksight-dashboard-sankeydiagramchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramchartconfiguration.html#cfn-quicksight-dashboard-sankeydiagramchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SankeyDiagramFieldWells FieldWells { get; set; }
        }

        public class SankeyDiagramFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SankeyDiagramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramfieldwells.html#cfn-quicksight-dashboard-sankeydiagramfieldwells-sankeydiagramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SankeyDiagramAggregatedFieldWells SankeyDiagramAggregatedFieldWells { get; set; }
        }

        public class SankeyDiagramSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramsortconfiguration.html#cfn-quicksight-dashboard-sankeydiagramsortconfiguration-weightsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> WeightSort { get; set; }
            /// <summary>
            /// SourceItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramsortconfiguration.html#cfn-quicksight-dashboard-sankeydiagramsortconfiguration-sourceitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration SourceItemsLimit { get; set; }
            /// <summary>
            /// DestinationItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramsortconfiguration.html#cfn-quicksight-dashboard-sankeydiagramsortconfiguration-destinationitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration DestinationItemsLimit { get; set; }
        }

        public class SankeyDiagramVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.SankeyDiagramChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sankeydiagramvisual.html#cfn-quicksight-dashboard-sankeydiagramvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotcategoricallyaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> YAxis { get; set; }
        }

        public class ScatterPlotConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveQuickSightDashboardTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// YAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-yaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions YAxisLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ScatterPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotconfiguration.html#cfn-quicksight-dashboard-scatterplotconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class ScatterPlotFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScatterPlotUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotfieldwells.html#cfn-quicksight-dashboard-scatterplotfieldwells-scatterplotunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotUnaggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ScatterPlotUnaggregatedFieldWells ScatterPlotUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// ScatterPlotCategoricallyAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotfieldwells.html#cfn-quicksight-dashboard-scatterplotfieldwells-scatterplotcategoricallyaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotCategoricallyAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ScatterPlotCategoricallyAggregatedFieldWells ScatterPlotCategoricallyAggregatedFieldWells { get; set; }
        }

        public class ScatterPlotUnaggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotunaggregatedfieldwells.html#cfn-quicksight-dashboard-scatterplotunaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> YAxis { get; set; }
        }

        public class ScatterPlotVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ScatterPlotConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scatterplotvisual.html#cfn-quicksight-dashboard-scatterplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ScrollBarOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// VisibleRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scrollbaroptions.html#cfn-quicksight-dashboard-scrollbaroptions-visiblerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisibleRangeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisibleRangeOptions VisibleRange { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-scrollbaroptions.html#cfn-quicksight-dashboard-scrollbaroptions-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SecondaryValueOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class SectionAfterPageBreak : Humidifier.Base.BaseSubResource, IHaveStatus
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

        public class SectionBasedLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PaperCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutcanvassizeoptions.html#cfn-quicksight-dashboard-sectionbasedlayoutcanvassizeoptions-papercanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutPaperCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions PaperCanvasSizeOptions { get; set; }
        }

        public class SectionBasedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// FooterSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-footersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.HeaderFooterSectionConfiguration> FooterSections { get; set; }
            /// <summary>
            /// BodySections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-bodysections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BodySectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.BodySectionConfiguration> BodySections { get; set; }
            /// <summary>
            /// HeaderSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutconfiguration.html#cfn-quicksight-dashboard-sectionbasedlayoutconfiguration-headersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.HeaderFooterSectionConfiguration> HeaderSections { get; set; }
        }

        public class SectionBasedLayoutPaperCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHavePaperSize, IHavePaperOrientation
        {
            /// <summary>
            /// PaperMargin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-dashboard-sectionbasedlayoutpapercanvassizeoptions-papermargin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.Spacing PaperMargin { get; set; }
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

        public class SectionLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionlayoutconfiguration.html#cfn-quicksight-dashboard-sectionlayoutconfiguration-freeformlayout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormSectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FreeFormSectionLayoutConfiguration FreeFormLayout { get; set; }
        }

        public class SectionPageBreakConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// After
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionpagebreakconfiguration.html#cfn-quicksight-dashboard-sectionpagebreakconfiguration-after
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionAfterPageBreak
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SectionAfterPageBreak After { get; set; }
        }

        public class SectionStyle : Humidifier.Base.BaseSubResource, IHaveHeight
        {
            /// <summary>
            /// Padding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionstyle.html#cfn-quicksight-dashboard-sectionstyle-padding
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.Spacing Padding { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sectionstyle.html#cfn-quicksight-dashboard-sectionstyle-height
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-selectedsheetsfilterscopeconfiguration.html#cfn-quicksight-dashboard-selectedsheetsfilterscopeconfiguration-sheetvisualscopingconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetVisualScopingConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SheetVisualScopingConfiguration> SheetVisualScopingConfigurations { get; set; }
        }

        public class SeriesItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-seriesitem.html#cfn-quicksight-dashboard-seriesitem-fieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSeriesItem
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FieldSeriesItem FieldSeriesItem { get; set; }
            /// <summary>
            /// DataFieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-seriesitem.html#cfn-quicksight-dashboard-seriesitem-datafieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataFieldSeriesItem
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataFieldSeriesItem DataFieldSeriesItem { get; set; }
        }

        public class SetParameterValueConfiguration : Humidifier.Base.BaseSubResource, IHaveDestinationParameterName
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
            public Humidifier.QuickSight.DashboardTypes.DestinationParameterValueConfiguration Value { get; set; }
        }

        public class ShapeConditionalFormat : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-shapeconditionalformat.html#cfn-quicksight-dashboard-shapeconditionalformat-backgroundcolor
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class Sheet : Humidifier.Base.BaseSubResource, IHaveName, IHaveSheetId
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
            /// Images
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheet.html#cfn-quicksight-dashboard-sheet-images
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetImage
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SheetImage> Images { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheet.html#cfn-quicksight-dashboard-sheet-name
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

        public class SheetControlLayout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrollayout.html#cfn-quicksight-dashboard-sheetcontrollayout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetControlLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlLayoutConfiguration Configuration { get; set; }
        }

        public class SheetControlLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrollayoutconfiguration.html#cfn-quicksight-dashboard-sheetcontrollayoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GridLayoutConfiguration GridLayout { get; set; }
        }

        public class SheetControlsOption : Humidifier.Base.BaseSubResource
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

        public class SheetDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveTitle, IHaveContentType, IHaveSheetId
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
            public List<Humidifier.QuickSight.DashboardTypes.ParameterControl> ParameterControls { get; set; }
            /// <summary>
            /// TextBoxes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-textboxes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetTextBox
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SheetTextBox> TextBoxes { get; set; }
            /// <summary>
            /// Layouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-layouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Layout
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.Layout> Layouts { get; set; }
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
            public List<Humidifier.QuickSight.DashboardTypes.FilterControl> FilterControls { get; set; }
            /// <summary>
            /// Images
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-images
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetImage
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SheetImage> Images { get; set; }
            /// <summary>
            /// SheetControlLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-sheetcontrollayouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetControlLayout
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.SheetControlLayout> SheetControlLayouts { get; set; }
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
            public List<Humidifier.QuickSight.DashboardTypes.Visual> Visuals { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetdefinition.html#cfn-quicksight-dashboard-sheetdefinition-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetelementconfigurationoverrides.html#cfn-quicksight-dashboard-sheetelementconfigurationoverrides-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
        }

        public class SheetElementRenderingRule : Humidifier.Base.BaseSubResource, IHaveExpression
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
            public Humidifier.QuickSight.DashboardTypes.SheetElementConfigurationOverrides ConfigurationOverrides { get; set; }
        }

        public class SheetImage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImageCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ImageCustomAction> Actions { get; set; }
            /// <summary>
            /// SheetImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-sheetimageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetImageId { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageTooltipConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetImageTooltipConfiguration Tooltip { get; set; }
            /// <summary>
            /// Scaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-scaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageScalingConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetImageScalingConfiguration Scaling { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageInteractionOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ImageInteractionOptions Interactions { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetImageSource
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetImageSource Source { get; set; }
            /// <summary>
            /// ImageContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimage.html#cfn-quicksight-dashboard-sheetimage-imagecontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimagescalingconfiguration.html#cfn-quicksight-dashboard-sheetimagescalingconfiguration-scalingtype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimagesource.html#cfn-quicksight-dashboard-sheetimagesource-sheetimagestaticfilesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageStaticFileSource
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetImageStaticFileSource SheetImageStaticFileSource { get; set; }
        }

        public class SheetImageStaticFileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimagestaticfilesource.html#cfn-quicksight-dashboard-sheetimagestaticfilesource-staticfileid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimagetooltipconfiguration.html#cfn-quicksight-dashboard-sheetimagetooltipconfiguration-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// TooltipText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimagetooltipconfiguration.html#cfn-quicksight-dashboard-sheetimagetooltipconfiguration-tooltiptext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageTooltipText
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetImageTooltipText TooltipText { get; set; }
        }

        public class SheetImageTooltipText : Humidifier.Base.BaseSubResource, IHavePlainText
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetimagetooltiptext.html#cfn-quicksight-dashboard-sheetimagetooltiptext-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlainText { get; set; }
        }

        public class SheetLayoutElementMaximizationOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class SheetTextBox : Humidifier.Base.BaseSubResource, IHaveContent, IHaveSheetTextBoxId
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

        public class SheetVisualScopingConfiguration : Humidifier.Base.BaseSubResource, IHaveScope, IHaveSheetId, IHaveVisualIds
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

        public class ShortFormatText : Humidifier.Base.BaseSubResource, IHaveRichText, IHavePlainText
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

        public class SimpleClusterMarker : Humidifier.Base.BaseSubResource, IHaveColor
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

        public class SingleAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// YAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-singleaxisoptions.html#cfn-quicksight-dashboard-singleaxisoptions-yaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: YAxisOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.YAxisOptions YAxisOptions { get; set; }
        }

        public class SliderControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-slidercontroldisplayoptions.html#cfn-quicksight-dashboard-slidercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-slidercontroldisplayoptions.html#cfn-quicksight-dashboard-slidercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class SmallMultiplesAxisProperties : Humidifier.Base.BaseSubResource, IHavePlacement, IHaveScale
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

        public class SmallMultiplesOptions : Humidifier.Base.BaseSubResource, IHaveMaxVisibleRows, IHaveMaxVisibleColumns
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
            public Humidifier.QuickSight.DashboardTypes.PanelConfiguration PanelConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.SmallMultiplesAxisProperties XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-smallmultiplesoptions.html#cfn-quicksight-dashboard-smallmultiplesoptions-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SmallMultiplesAxisProperties YAxis { get; set; }
        }

        public class Spacing : Humidifier.Base.BaseSubResource, IHaveLeft, IHaveTop, IHaveRight, IHaveBottom
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

        public class SpatialStaticFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-spatialstaticfile.html#cfn-quicksight-dashboard-spatialstaticfile-staticfileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticFileId { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-spatialstaticfile.html#cfn-quicksight-dashboard-spatialstaticfile-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileSource
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StaticFileSource Source { get; set; }
        }

        public class StaticFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageStaticFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfile.html#cfn-quicksight-dashboard-staticfile-imagestaticfile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStaticFile
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ImageStaticFile ImageStaticFile { get; set; }
            /// <summary>
            /// SpatialStaticFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfile.html#cfn-quicksight-dashboard-staticfile-spatialstaticfile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpatialStaticFile
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SpatialStaticFile SpatialStaticFile { get; set; }
        }

        public class StaticFileS3SourceOptions : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveRegion
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfiles3sourceoptions.html#cfn-quicksight-dashboard-staticfiles3sourceoptions-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfiles3sourceoptions.html#cfn-quicksight-dashboard-staticfiles3sourceoptions-objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKey { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfiles3sourceoptions.html#cfn-quicksight-dashboard-staticfiles3sourceoptions-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
        }

        public class StaticFileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UrlOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfilesource.html#cfn-quicksight-dashboard-staticfilesource-urloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileUrlSourceOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StaticFileUrlSourceOptions UrlOptions { get; set; }
            /// <summary>
            /// S3Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfilesource.html#cfn-quicksight-dashboard-staticfilesource-s3options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileS3SourceOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StaticFileS3SourceOptions S3Options { get; set; }
        }

        public class StaticFileUrlSourceOptions : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-staticfileurlsourceoptions.html#cfn-quicksight-dashboard-staticfileurlsourceoptions-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class StringDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues, IHaveQuickSightDashboardTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringdefaultvalues.html#cfn-quicksight-dashboard-stringdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class StringFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesNullValueFormatConfigurationNullValueFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringformatconfiguration.html#cfn-quicksight-dashboard-stringformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringformatconfiguration.html#cfn-quicksight-dashboard-stringformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
        }

        public class StringParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
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

        public class StringParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.StringDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.StringValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-stringparameterdeclaration.html#cfn-quicksight-dashboard-stringparameterdeclaration-name
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

        public class SubtotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHaveFieldLevel, IHaveQuickSightDashboardTypesTableCellStyleTotalCellStyle
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
            public List<Humidifier.QuickSight.DashboardTypes.PivotTableFieldSubtotalOptions> FieldLevelOptions { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle TotalCellStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
            /// <summary>
            /// StyleTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-subtotaloptions.html#cfn-quicksight-dashboard-subtotaloptions-styletargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableStyleTarget
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TableStyleTarget> StyleTargets { get; set; }
        }

        public class TableAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableaggregatedfieldwells.html#cfn-quicksight-dashboard-tableaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableaggregatedfieldwells.html#cfn-quicksight-dashboard-tableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class TableBorderOptions : Humidifier.Base.BaseSubResource, IHaveColor, IHaveStyle, IHaveThickness
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

        public class TableCellConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
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
            public Humidifier.QuickSight.DashboardTypes.TextConditionalFormat TextFormat { get; set; }
        }

        public class TableCellImageSizingConfiguration : Humidifier.Base.BaseSubResource, IHaveTableCellImageScalingConfiguration
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

        public class TableCellStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveBackgroundColor, IHaveHorizontalTextAlignment, IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration, IHaveVerticalTextAlignment, IHaveTextWrap
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablecellstyle.html#cfn-quicksight-dashboard-tablecellstyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalTableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GlobalTableBorderOptions Border { get; set; }
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

        public class TableConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconditionalformatting.html#cfn-quicksight-dashboard-tableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class TableConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Row
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconditionalformattingoption.html#cfn-quicksight-dashboard-tableconditionalformattingoption-row
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableRowConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableRowConditionalFormatting Row { get; set; }
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconditionalformattingoption.html#cfn-quicksight-dashboard-tableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellConditionalFormatting Cell { get; set; }
        }

        public class TableConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePaginatedReportOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableOptions TableOptions { get; set; }
            /// <summary>
            /// TableInlineVisualizations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-tableinlinevisualizations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableInlineVisualization
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TableInlineVisualization> TableInlineVisualizations { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableconfiguration.html#cfn-quicksight-dashboard-tableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TotalOptions TotalOptions { get; set; }
        }

        public class TableFieldCustomIconContent : Humidifier.Base.BaseSubResource, IHaveIcon
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

        public class TableFieldCustomTextContent : Humidifier.Base.BaseSubResource, IHaveValue, IHaveQuickSightDashboardTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.DashboardTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class TableFieldImageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SizingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldimageconfiguration.html#cfn-quicksight-dashboard-tablefieldimageconfiguration-sizingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellImageSizingConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellImageSizingConfiguration SizingOptions { get; set; }
        }

        public class TableFieldLinkConfiguration : Humidifier.Base.BaseSubResource, IHaveTarget
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
            public Humidifier.QuickSight.DashboardTypes.TableFieldLinkContentConfiguration Content { get; set; }
        }

        public class TableFieldLinkContentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomIconContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldlinkcontentconfiguration.html#cfn-quicksight-dashboard-tablefieldlinkcontentconfiguration-customiconcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomIconContent
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableFieldCustomIconContent CustomIconContent { get; set; }
            /// <summary>
            /// CustomTextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldlinkcontentconfiguration.html#cfn-quicksight-dashboard-tablefieldlinkcontentconfiguration-customtextcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomTextContent
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableFieldCustomTextContent CustomTextContent { get; set; }
        }

        public class TableFieldOption : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveCustomLabel, IHaveWidth
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
            public Humidifier.QuickSight.DashboardTypes.TableFieldURLConfiguration URLStyling { get; set; }
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

        public class TableFieldOptions : Humidifier.Base.BaseSubResource, IHaveOrder
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
            public Humidifier.QuickSight.DashboardTypes.TablePinnedFieldOptions PinnedFieldOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldoptions.html#cfn-quicksight-dashboard-tablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableFieldOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class TableFieldURLConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldurlconfiguration.html#cfn-quicksight-dashboard-tablefieldurlconfiguration-linkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldLinkConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableFieldLinkConfiguration LinkConfiguration { get; set; }
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldurlconfiguration.html#cfn-quicksight-dashboard-tablefieldurlconfiguration-imageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldImageConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableFieldImageConfiguration ImageConfiguration { get; set; }
        }

        public class TableFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TableUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldwells.html#cfn-quicksight-dashboard-tablefieldwells-tableunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableUnaggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableUnaggregatedFieldWells TableUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// TableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablefieldwells.html#cfn-quicksight-dashboard-tablefieldwells-tableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableAggregatedFieldWells TableAggregatedFieldWells { get; set; }
        }

        public class TableInlineVisualization : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataBars
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableinlinevisualization.html#cfn-quicksight-dashboard-tableinlinevisualization-databars
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataBarsOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataBarsOptions DataBars { get; set; }
        }

        public class TableOptions : Humidifier.Base.BaseSubResource, IHaveOrientation
        {
            /// <summary>
            /// HeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableoptions.html#cfn-quicksight-dashboard-tableoptions-headerstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle HeaderStyle { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableoptions.html#cfn-quicksight-dashboard-tableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle CellStyle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class TablePaginatedReportOptions : Humidifier.Base.BaseSubResource, IHaveOverflowColumnHeaderVisibility, IHaveVerticalOverflowVisibility
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

        public class TablePinnedFieldOptions : Humidifier.Base.BaseSubResource, IHavePinnedLeftFields
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

        public class TableRowConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor, IHaveQuickSightDashboardTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablerowconditionalformatting.html#cfn-quicksight-dashboard-tablerowconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablerowconditionalformatting.html#cfn-quicksight-dashboard-tablerowconditionalformatting-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TableSideBorderOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-left
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-top
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions Top { get; set; }
            /// <summary>
            /// InnerHorizontal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-innerhorizontal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions InnerHorizontal { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-right
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions Bottom { get; set; }
            /// <summary>
            /// InnerVertical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesideborderoptions.html#cfn-quicksight-dashboard-tablesideborderoptions-innervertical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableBorderOptions InnerVertical { get; set; }
        }

        public class TableSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesortconfiguration.html#cfn-quicksight-dashboard-tablesortconfiguration-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> RowSort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablesortconfiguration.html#cfn-quicksight-dashboard-tablesortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class TableStyleTarget : Humidifier.Base.BaseSubResource, IHaveCellType
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

        public class TableUnaggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tableunaggregatedfieldwells.html#cfn-quicksight-dashboard-tableunaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.UnaggregatedField> Values { get; set; }
        }

        public class TableVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tablevisual.html#cfn-quicksight-dashboard-tablevisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class TextAreaControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textareacontroldisplayoptions.html#cfn-quicksight-dashboard-textareacontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textareacontroldisplayoptions.html#cfn-quicksight-dashboard-textareacontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textareacontroldisplayoptions.html#cfn-quicksight-dashboard-textareacontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class TextConditionalFormat : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesConditionalFormattingColorTextColor, IHaveQuickSightDashboardTypesConditionalFormattingIconIcon, IHaveQuickSightDashboardTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textconditionalformat.html#cfn-quicksight-dashboard-textconditionalformat-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textconditionalformat.html#cfn-quicksight-dashboard-textconditionalformat-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingIcon Icon { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textconditionalformat.html#cfn-quicksight-dashboard-textconditionalformat-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TextControlPlaceholderOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class TextFieldControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLabelOptionsTitleOptions, IHaveQuickSightDashboardTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textfieldcontroldisplayoptions.html#cfn-quicksight-dashboard-textfieldcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textfieldcontroldisplayoptions.html#cfn-quicksight-dashboard-textfieldcontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-textfieldcontroldisplayoptions.html#cfn-quicksight-dashboard-textfieldcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ThousandSeparatorOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveSymbol
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

        public class TimeBasedForecastProperties : Humidifier.Base.BaseSubResource, IHavePeriodsBackward, IHavePeriodsForward, IHavePredictionInterval, IHaveSeasonality, IHaveUpperBoundary, IHaveLowerBoundary
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

        public class TimeEqualityFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveQuickSightDashboardTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RollingDateConfiguration RollingDate { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timeequalityfilter.html#cfn-quicksight-dashboard-timeequalityfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TimeRangeDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveTimeGranularity, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveRangeMinimum, IHaveRangeMaximum
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangedrilldownfilter.html#cfn-quicksight-dashboard-timerangedrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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

        public class TimeRangeFilter : Humidifier.Base.BaseSubResource, IHaveTimeGranularity, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveIncludeMaximum, IHaveIncludeMinimum
        {
            /// <summary>
            /// RangeMinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-rangeminimumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TimeRangeFilterValue RangeMinimumValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefilter.html#cfn-quicksight-dashboard-timerangefilter-rangemaximumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TimeRangeFilterValue RangeMaximumValue { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class TimeRangeFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue, IHaveParameter, IHaveQuickSightDashboardTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-timerangefiltervalue.html#cfn-quicksight-dashboard-timerangefiltervalue-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RollingDateConfiguration RollingDate { get; set; }
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

        public class TooltipItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipitem.html#cfn-quicksight-dashboard-tooltipitem-fieldtooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldTooltipItem
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FieldTooltipItem FieldTooltipItem { get; set; }
            /// <summary>
            /// ColumnTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-tooltipitem.html#cfn-quicksight-dashboard-tooltipitem-columntooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnTooltipItem
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnTooltipItem ColumnTooltipItem { get; set; }
        }

        public class TooltipOptions : Humidifier.Base.BaseSubResource, IHaveTooltipVisibility, IHaveSelectedTooltipType
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
            public Humidifier.QuickSight.DashboardTypes.FieldBasedTooltip FieldBasedTooltip { get; set; }
        }

        public class TopBottomFilter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightDashboardTypesColumnIdentifierColumn, IHaveFilterId, IHaveLimit, IHaveQuickSightDashboardTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// AggregationSortConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-aggregationsortconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationSortConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.AggregationSortConfiguration> AggregationSortConfigurations { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottomfilter.html#cfn-quicksight-dashboard-topbottomfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TopBottomMoversComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveQuickSightDashboardTypesDimensionFieldTime, IHaveSortOrder, IHaveMoverSize, IHaveQuickSightDashboardTypesDimensionFieldCategory
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
            public Humidifier.QuickSight.DashboardTypes.DimensionField Category { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-topbottommoverscomputation.html#cfn-quicksight-dashboard-topbottommoverscomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.DimensionField Time { get; set; }
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

        public class TopBottomRankedComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue, IHaveResultSize, IHaveQuickSightDashboardTypesDimensionFieldCategory
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
            public Humidifier.QuickSight.DashboardTypes.DimensionField Category { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
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

        public class TotalAggregationComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesMeasureFieldValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationcomputation.html#cfn-quicksight-dashboard-totalaggregationcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.MeasureField Value { get; set; }
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

        public class TotalAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleTotalAggregationFunction
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

        public class TotalAggregationOption : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// TotalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationoption.html#cfn-quicksight-dashboard-totalaggregationoption-totalaggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TotalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TotalAggregationFunction TotalAggregationFunction { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totalaggregationoption.html#cfn-quicksight-dashboard-totalaggregationoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class TotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHavePlacement, IHaveScrollStatus, IHaveQuickSightDashboardTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-totaloptions.html#cfn-quicksight-dashboard-totaloptions-totalsvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TotalsVisibility { get; set; }
        }

        public class TreeMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sizes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapaggregatedfieldwells.html#cfn-quicksight-dashboard-treemapaggregatedfieldwells-sizes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Sizes { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapaggregatedfieldwells.html#cfn-quicksight-dashboard-treemapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Colors { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapaggregatedfieldwells.html#cfn-quicksight-dashboard-treemapaggregatedfieldwells-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Groups { get; set; }
        }

        public class TreeMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesTooltipOptionsTooltip, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveQuickSightDashboardTypesChartAxisLabelOptionsColorLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TreeMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// SizeLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-sizelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions SizeLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TreeMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColorScale ColorScale { get; set; }
            /// <summary>
            /// GroupLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapconfiguration.html#cfn-quicksight-dashboard-treemapconfiguration-grouplabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions GroupLabelOptions { get; set; }
        }

        public class TreeMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreeMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapfieldwells.html#cfn-quicksight-dashboard-treemapfieldwells-treemapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TreeMapAggregatedFieldWells TreeMapAggregatedFieldWells { get; set; }
        }

        public class TreeMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreeMapSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapsortconfiguration.html#cfn-quicksight-dashboard-treemapsortconfiguration-treemapsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> TreeMapSort { get; set; }
            /// <summary>
            /// TreeMapGroupItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapsortconfiguration.html#cfn-quicksight-dashboard-treemapsortconfiguration-treemapgroupitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration TreeMapGroupItemsLimitConfiguration { get; set; }
        }

        public class TreeMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.TreeMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-treemapvisual.html#cfn-quicksight-dashboard-treemapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class TrendArrowOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class UnaggregatedField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightDashboardTypesColumnIdentifierColumn
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-unaggregatedfield.html#cfn-quicksight-dashboard-unaggregatedfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-unaggregatedfield.html#cfn-quicksight-dashboard-unaggregatedfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-unaggregatedfield.html#cfn-quicksight-dashboard-unaggregatedfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class UniqueValuesComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightDashboardTypesDimensionFieldCategory
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-uniquevaluescomputation.html#cfn-quicksight-dashboard-uniquevaluescomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DimensionField Category { get; set; }
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

        public class ValidationStrategy : Humidifier.Base.BaseSubResource, IHaveMode
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

        public class VisibleRangeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PercentRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visiblerangeoptions.html#cfn-quicksight-dashboard-visiblerangeoptions-percentrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentVisibleRange
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PercentVisibleRange PercentRange { get; set; }
        }

        public class Visual : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunnelChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-funnelchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FunnelChartVisual FunnelChartVisual { get; set; }
            /// <summary>
            /// BoxPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-boxplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BoxPlotVisual BoxPlotVisual { get; set; }
            /// <summary>
            /// LayerMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-layermapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LayerMapVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LayerMapVisual LayerMapVisual { get; set; }
            /// <summary>
            /// GeospatialMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-geospatialmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GeospatialMapVisual GeospatialMapVisual { get; set; }
            /// <summary>
            /// ScatterPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-scatterplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ScatterPlotVisual ScatterPlotVisual { get; set; }
            /// <summary>
            /// RadarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-radarchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.RadarChartVisual RadarChartVisual { get; set; }
            /// <summary>
            /// ComboChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-combochartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ComboChartVisual ComboChartVisual { get; set; }
            /// <summary>
            /// WordCloudVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-wordcloudvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WordCloudVisual WordCloudVisual { get; set; }
            /// <summary>
            /// SankeyDiagramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-sankeydiagramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.SankeyDiagramVisual SankeyDiagramVisual { get; set; }
            /// <summary>
            /// GaugeChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-gaugechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.GaugeChartVisual GaugeChartVisual { get; set; }
            /// <summary>
            /// FilledMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-filledmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.FilledMapVisual FilledMapVisual { get; set; }
            /// <summary>
            /// WaterfallVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-waterfallvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallVisual WaterfallVisual { get; set; }
            /// <summary>
            /// CustomContentVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-customcontentvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomContentVisual CustomContentVisual { get; set; }
            /// <summary>
            /// PieChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-piechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PieChartVisual PieChartVisual { get; set; }
            /// <summary>
            /// KPIVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-kpivisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.KPIVisual KPIVisual { get; set; }
            /// <summary>
            /// HistogramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-histogramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HistogramVisual HistogramVisual { get; set; }
            /// <summary>
            /// PluginVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-pluginvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PluginVisual PluginVisual { get; set; }
            /// <summary>
            /// TableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-tablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TableVisual TableVisual { get; set; }
            /// <summary>
            /// PivotTableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-pivottablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.PivotTableVisual PivotTableVisual { get; set; }
            /// <summary>
            /// BarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-barchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.BarChartVisual BarChartVisual { get; set; }
            /// <summary>
            /// HeatMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-heatmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.HeatMapVisual HeatMapVisual { get; set; }
            /// <summary>
            /// TreeMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-treemapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.TreeMapVisual TreeMapVisual { get; set; }
            /// <summary>
            /// InsightVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-insightvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.InsightVisual InsightVisual { get; set; }
            /// <summary>
            /// LineChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-linechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LineChartVisual LineChartVisual { get; set; }
            /// <summary>
            /// EmptyVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visual.html#cfn-quicksight-dashboard-visual-emptyvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyVisual
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.EmptyVisual EmptyVisual { get; set; }
        }

        public class VisualAxisSortOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
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

        public class VisualCustomAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveTrigger, IHaveCustomActionId
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
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomActionOperation> ActionOperations { get; set; }
        }

        public class VisualCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-visualcustomactionoperation.html#cfn-quicksight-dashboard-visualcustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class VisualPalette : Humidifier.Base.BaseSubResource, IHaveChartColor
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
            public List<Humidifier.QuickSight.DashboardTypes.DataPathColor> ColorMap { get; set; }
        }

        public class VisualSubtitleLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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
            public Humidifier.QuickSight.DashboardTypes.LongFormatText FormatText { get; set; }
        }

        public class VisualTitleLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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
            public Humidifier.QuickSight.DashboardTypes.ShortFormatText FormatText { get; set; }
        }

        public class WaterfallChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Categories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartaggregatedfieldwells.html#cfn-quicksight-dashboard-waterfallchartaggregatedfieldwells-categories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Categories { get; set; }
            /// <summary>
            /// Breakdowns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartaggregatedfieldwells.html#cfn-quicksight-dashboard-waterfallchartaggregatedfieldwells-breakdowns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> Breakdowns { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartaggregatedfieldwells.html#cfn-quicksight-dashboard-waterfallchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Values { get; set; }
        }

        public class WaterfallChartColorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartcolorconfiguration.html#cfn-quicksight-dashboard-waterfallchartcolorconfiguration-groupcolorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartGroupColorConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartGroupColorConfiguration GroupColorConfiguration { get; set; }
        }

        public class WaterfallChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesLegendOptionsLegend, IHaveQuickSightDashboardTypesVisualPaletteVisualPalette, IHaveQuickSightDashboardTypesDataLabelOptionsDataLabels, IHaveQuickSightDashboardTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightDashboardTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// CategoryAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-categoryaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryAxisLabelOptions { get; set; }
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// WaterfallChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-waterfallchartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartOptions WaterfallChartOptions { get; set; }
            /// <summary>
            /// ColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-colorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartColorConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartColorConfiguration ColorConfiguration { get; set; }
            /// <summary>
            /// CategoryAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-categoryaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions CategoryAxisDisplayOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartconfiguration.html#cfn-quicksight-dashboard-waterfallchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualPalette VisualPalette { get; set; }
        }

        public class WaterfallChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WaterfallChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartfieldwells.html#cfn-quicksight-dashboard-waterfallchartfieldwells-waterfallchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartAggregatedFieldWells WaterfallChartAggregatedFieldWells { get; set; }
        }

        public class WaterfallChartGroupColorConfiguration : Humidifier.Base.BaseSubResource, IHaveNegativeBarColor, IHaveTotalBarColor, IHavePositiveBarColor
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

        public class WaterfallChartOptions : Humidifier.Base.BaseSubResource, IHaveTotalBarLabel
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

        public class WaterfallChartSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BreakdownItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartsortconfiguration.html#cfn-quicksight-dashboard-waterfallchartsortconfiguration-breakdownitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration BreakdownItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallchartsortconfiguration.html#cfn-quicksight-dashboard-waterfallchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class WaterfallVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.WaterfallChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-waterfallvisual.html#cfn-quicksight-dashboard-waterfallvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class WhatIfPointScenario : Humidifier.Base.BaseSubResource, IHaveValue, IHaveDate
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

        public class WhatIfRangeScenario : Humidifier.Base.BaseSubResource, IHaveValue, IHaveEndDate, IHaveStartDate
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

        public class WordCloudAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudaggregatedfieldwells.html#cfn-quicksight-dashboard-wordcloudaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudaggregatedfieldwells.html#cfn-quicksight-dashboard-wordcloudaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.MeasureField> Size { get; set; }
        }

        public class WordCloudChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesChartAxisLabelOptionsCategoryLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WordCloudSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WordCloudFieldWells FieldWells { get; set; }
            /// <summary>
            /// WordCloudOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudchartconfiguration.html#cfn-quicksight-dashboard-wordcloudchartconfiguration-wordcloudoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WordCloudOptions WordCloudOptions { get; set; }
        }

        public class WordCloudFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WordCloudAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudfieldwells.html#cfn-quicksight-dashboard-wordcloudfieldwells-wordcloudaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.WordCloudAggregatedFieldWells WordCloudAggregatedFieldWells { get; set; }
        }

        public class WordCloudOptions : Humidifier.Base.BaseSubResource, IHaveWordOrientation, IHaveWordScaling, IHaveCloudLayout, IHaveMaximumStringLength, IHaveWordCasing, IHaveWordPadding
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

        public class WordCloudSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDashboardTypesItemsLimitConfigurationCategoryItemsLimit
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudsortconfiguration.html#cfn-quicksight-dashboard-wordcloudsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudsortconfiguration.html#cfn-quicksight-dashboard-wordcloudsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class WordCloudVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightDashboardTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightDashboardTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.DashboardTypes.WordCloudChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.DashboardTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-wordcloudvisual.html#cfn-quicksight-dashboard-wordcloudvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.DashboardTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class YAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-yaxisoptions.html#cfn-quicksight-dashboard-yaxisoptions-yaxis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic YAxis { get; set; }
        }
    }
}