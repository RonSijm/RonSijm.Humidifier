namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using AnalysisTypes;

    public class Analysis : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveStatus, IHaveAwsAccountId, IHaveThemeArn
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string DataSetArns =  "DataSetArns" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Analysis; }
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
        public Humidifier.QuickSight.AnalysisTypes.Parameters Parameters { get; set; }
        /// <summary>
        /// SourceEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-sourceentity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalysisSourceEntity
        /// </summary>
        public Humidifier.QuickSight.AnalysisTypes.AnalysisSourceEntity SourceEntity { get; set; }
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
        public Humidifier.QuickSight.AnalysisTypes.AnalysisDefinition Definition { get; set; }
        /// <summary>
        /// ValidationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-validationstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ValidationStrategy
        /// </summary>
        public Humidifier.QuickSight.AnalysisTypes.ValidationStrategy ValidationStrategy { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-folderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic FolderArns { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Errors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-errors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AnalysisError
        /// </summary>
        public List<Humidifier.QuickSight.AnalysisTypes.AnalysisError> Errors { get; set; }

        /// <summary>
        /// AnalysisId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-analysisid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AnalysisId { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html#cfn-quicksight-analysis-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.AnalysisTypes.ResourcePermission> Permissions { get; set; }
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
        public List<Humidifier.QuickSight.AnalysisTypes.Sheet> Sheets { get; set; }
    }

    namespace AnalysisTypes
    {
        public class AggregationFunction : Humidifier.Base.BaseSubResource, IHaveDateAggregationFunction, IHaveCategoricalAggregationFunction
        {
            /// <summary>
            /// AttributeAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationfunction.html#cfn-quicksight-analysis-aggregationfunction-attributeaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AttributeAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AttributeAggregationFunction AttributeAggregationFunction { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NumericalAggregationFunction NumericalAggregationFunction { get; set; }
            /// <summary>
            /// CategoricalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationfunction.html#cfn-quicksight-analysis-aggregationfunction-categoricalaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CategoricalAggregationFunction { get; set; }
        }

        public class AggregationSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveQuickSightAnalysisTypesAggregationFunctionAggregationFunction, IHaveSortDirection
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-aggregationsortconfiguration.html#cfn-quicksight-analysis-aggregationsortconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AggregationFunction AggregationFunction { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
        }

        public class AnalysisDefaults : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultNewSheetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefaults.html#cfn-quicksight-analysis-analysisdefaults-defaultnewsheetconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultNewSheetConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration DefaultNewSheetConfiguration { get; set; }
        }

        public class AnalysisDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AssetOptions Options { get; set; }
            /// <summary>
            /// FilterGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-filtergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterGroup
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FilterGroup> FilterGroups { get; set; }
            /// <summary>
            /// QueryExecutionOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-queryexecutionoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryExecutionOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.QueryExecutionOptions QueryExecutionOptions { get; set; }
            /// <summary>
            /// StaticFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-staticfiles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StaticFile
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.StaticFile> StaticFiles { get; set; }
            /// <summary>
            /// CalculatedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-calculatedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.CalculatedField> CalculatedFields { get; set; }
            /// <summary>
            /// DataSetIdentifierDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-datasetidentifierdeclarations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetIdentifierDeclaration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DataSetIdentifierDeclaration> DataSetIdentifierDeclarations { get; set; }
            /// <summary>
            /// ColumnConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-columnconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnConfiguration> ColumnConfigurations { get; set; }
            /// <summary>
            /// AnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-analysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisDefaults
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults AnalysisDefaults { get; set; }
            /// <summary>
            /// Sheets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-sheets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetDefinition
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SheetDefinition> Sheets { get; set; }
            /// <summary>
            /// ParameterDeclarations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysisdefinition.html#cfn-quicksight-analysis-analysisdefinition-parameterdeclarations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterDeclaration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ParameterDeclaration> ParameterDeclarations { get; set; }
        }

        public class AnalysisError : Humidifier.Base.BaseSubResource, IHaveType, IHaveMessage
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
            public List<Humidifier.QuickSight.AnalysisTypes.Entity> ViolatedEntities { get; set; }
        }

        public class AnalysisSourceEntity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourceentity.html#cfn-quicksight-analysis-analysissourceentity-sourcetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnalysisSourceTemplate
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AnalysisSourceTemplate SourceTemplate { get; set; }
        }

        public class AnalysisSourceTemplate : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// DataSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourcetemplate.html#cfn-quicksight-analysis-analysissourcetemplate-datasetreferences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetReference
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DataSetReference> DataSetReferences { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourcetemplate.html#cfn-quicksight-analysis-analysissourcetemplate-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class AnchorDateConfiguration : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveAnchorOption
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

        public class ArcAxisConfiguration : Humidifier.Base.BaseSubResource, IHaveReserveRange
        {
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcaxisconfiguration.html#cfn-quicksight-analysis-arcaxisconfiguration-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcAxisDisplayRange
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ArcAxisDisplayRange Range { get; set; }
            /// <summary>
            /// ReserveRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-arcaxisconfiguration.html#cfn-quicksight-analysis-arcaxisconfiguration-reserverange
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

        public class ArcConfiguration : Humidifier.Base.BaseSubResource, IHaveArcThickness, IHaveArcAngle
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

        public class ArcOptions : Humidifier.Base.BaseSubResource, IHaveArcThickness
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

        public class AssetOptions : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveWeekStart
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

        public class AttributeAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleAttributeAggregation, IHaveValueForMultipleValues
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

        public class AxisDataOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdataoptions.html#cfn-quicksight-analysis-axisdataoptions-dateaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateAxisOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateAxisOptions DateAxisOptions { get; set; }
            /// <summary>
            /// NumericAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdataoptions.html#cfn-quicksight-analysis-axisdataoptions-numericaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericAxisOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericAxisOptions NumericAxisOptions { get; set; }
        }

        public class AxisDisplayMinMaxRange : Humidifier.Base.BaseSubResource, IHaveMinimum, IHaveMaximum
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

        public class AxisDisplayOptions : Humidifier.Base.BaseSubResource, IHaveAxisOffset, IHaveAxisLineVisibility, IHaveGridLineVisibility
        {
            /// <summary>
            /// DataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-dataoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDataOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDataOptions DataOptions { get; set; }
            /// <summary>
            /// TickLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisdisplayoptions.html#cfn-quicksight-analysis-axisdisplayoptions-ticklabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisTickLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisTickLabelOptions TickLabelOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ScrollBarOptions ScrollbarOptions { get; set; }
        }

        public class AxisDisplayRange : Humidifier.Base.BaseSubResource, IHaveDataDriven
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
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayMinMaxRange MinMax { get; set; }
        }

        public class AxisLabelOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.AnalysisTypes.AxisLabelReferenceOptions ApplyTo { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabeloptions.html#cfn-quicksight-analysis-axislabeloptions-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class AxisLabelReferenceOptions : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabelreferenceoptions.html#cfn-quicksight-analysis-axislabelreferenceoptions-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axislabelreferenceoptions.html#cfn-quicksight-analysis-axislabelreferenceoptions-fieldid
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

        public class AxisLogarithmicScale : Humidifier.Base.BaseSubResource, IHaveBase
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

        public class AxisScale : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Logarithmic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisscale.html#cfn-quicksight-analysis-axisscale-logarithmic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLogarithmicScale
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisLogarithmicScale Logarithmic { get; set; }
            /// <summary>
            /// Linear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-axisscale.html#cfn-quicksight-analysis-axisscale-linear
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisLinearScale
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisLinearScale Linear { get; set; }
        }

        public class AxisTickLabelOptions : Humidifier.Base.BaseSubResource, IHaveRotationAngle
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
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions LabelOptions { get; set; }
        }

        public class BarChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartaggregatedfieldwells.html#cfn-quicksight-analysis-barchartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class BarChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveOrientation, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveBarsArrangement, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightAnalysisTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ValueAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartconfiguration.html#cfn-quicksight-analysis-barchartconfiguration-valueaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions ValueAxis { get; set; }
        }

        public class BarChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartfieldwells.html#cfn-quicksight-analysis-barchartfieldwells-barchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BarChartAggregatedFieldWells BarChartAggregatedFieldWells { get; set; }
        }

        public class BarChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightAnalysisTypesItemsLimitConfigurationColorItemsLimit, IHaveQuickSightAnalysisTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartsortconfiguration.html#cfn-quicksight-analysis-barchartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class BarChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.BarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-barchartvisual.html#cfn-quicksight-analysis-barchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class BinCountOptions : Humidifier.Base.BaseSubResource, IHaveValue
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

        public class BinWidthOptions : Humidifier.Base.BaseSubResource, IHaveValue, IHaveBinCountLimit
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

        public class BodySectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSectionId
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BodySectionContent
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BodySectionContent Content { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionStyle Style { get; set; }
            /// <summary>
            /// PageBreakConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-pagebreakconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionPageBreakConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionPageBreakConfiguration PageBreakConfiguration { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectionconfiguration.html#cfn-quicksight-analysis-bodysectionconfiguration-sectionid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-bodysectioncontent.html#cfn-quicksight-analysis-bodysectioncontent-layout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionLayoutConfiguration Layout { get; set; }
        }

        public class BoxPlotAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotaggregatedfieldwells.html#cfn-quicksight-analysis-boxplotaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotaggregatedfieldwells.html#cfn-quicksight-analysis-boxplotaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class BoxPlotChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// BoxPlotOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-boxplotoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotOptions BoxPlotOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotchartconfiguration.html#cfn-quicksight-analysis-boxplotchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
        }

        public class BoxPlotFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BoxPlotAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotfieldwells.html#cfn-quicksight-analysis-boxplotfieldwells-boxplotaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotAggregatedFieldWells BoxPlotAggregatedFieldWells { get; set; }
        }

        public class BoxPlotOptions : Humidifier.Base.BaseSubResource, IHaveOutlierVisibility, IHaveAllDataPointsVisibility
        {
            /// <summary>
            /// StyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotoptions.html#cfn-quicksight-analysis-boxplotoptions-styleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotStyleOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotStyleOptions StyleOptions { get; set; }
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

        public class BoxPlotSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotsortconfiguration.html#cfn-quicksight-analysis-boxplotsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotsortconfiguration.html#cfn-quicksight-analysis-boxplotsortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class BoxPlotStyleOptions : Humidifier.Base.BaseSubResource, IHaveFillStyle
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

        public class BoxPlotVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-boxplotvisual.html#cfn-quicksight-analysis-boxplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class CalculatedField : Humidifier.Base.BaseSubResource, IHaveName, IHaveExpression, IHaveDataSetIdentifier
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

        public class CalculatedMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveExpression
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

        public class CascadingControlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-cascadingcontrolconfiguration.html#cfn-quicksight-analysis-cascadingcontrolconfiguration-sourcecontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CascadingControlSource
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.CascadingControlSource> SourceControls { get; set; }
        }

        public class CascadingControlSource : Humidifier.Base.BaseSubResource, IHaveSourceSheetControlId
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
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier ColumnToMatch { get; set; }
        }

        public class CategoricalDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveHierarchyId
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
            public Humidifier.QuickSight.AnalysisTypes.StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricaldimensionfield.html#cfn-quicksight-analysis-categoricaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricaldimensionfield.html#cfn-quicksight-analysis-categoricaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoricalMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveAggregationFunction
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
            public Humidifier.QuickSight.AnalysisTypes.StringFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricalmeasurefield.html#cfn-quicksight-analysis-categoricalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoricalmeasurefield.html#cfn-quicksight-analysis-categoricalmeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class CategoryDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveCategoryValues
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categorydrilldownfilter.html#cfn-quicksight-analysis-categorydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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

        public class CategoryFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilter.html#cfn-quicksight-analysis-categoryfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilterconfiguration.html#cfn-quicksight-analysis-categoryfilterconfiguration-customfilterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterListConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomFilterListConfiguration CustomFilterListConfiguration { get; set; }
            /// <summary>
            /// CustomFilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilterconfiguration.html#cfn-quicksight-analysis-categoryfilterconfiguration-customfilterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomFilterConfiguration CustomFilterConfiguration { get; set; }
            /// <summary>
            /// FilterListConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryfilterconfiguration.html#cfn-quicksight-analysis-categoryfilterconfiguration-filterlistconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterListConfiguration FilterListConfiguration { get; set; }
        }

        public class CategoryInnerFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryinnerfilter.html#cfn-quicksight-analysis-categoryinnerfilter-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CategoryFilterConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoryFilterConfiguration Configuration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryinnerfilter.html#cfn-quicksight-analysis-categoryinnerfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// DefaultFilterControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-categoryinnerfilter.html#cfn-quicksight-analysis-categoryinnerfilter-defaultfiltercontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
        }

        public class ChartAxisLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveSortIconVisibility
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
            public List<Humidifier.QuickSight.AnalysisTypes.AxisLabelOptions> AxisLabelOptions { get; set; }
        }

        public class ClusterMarker : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SimpleClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-clustermarker.html#cfn-quicksight-analysis-clustermarker-simpleclustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SimpleClusterMarker
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SimpleClusterMarker SimpleClusterMarker { get; set; }
        }

        public class ClusterMarkerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClusterMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-clustermarkerconfiguration.html#cfn-quicksight-analysis-clustermarkerconfiguration-clustermarker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterMarker
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ClusterMarker ClusterMarker { get; set; }
        }

        public class ColorScale : Humidifier.Base.BaseSubResource, IHaveColorFillType
        {
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-colorscale.html#cfn-quicksight-analysis-colorscale-colors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataColor
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DataColor> Colors { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DataColor NullValueColor { get; set; }
        }

        public class ColorsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-colorsconfiguration.html#cfn-quicksight-analysis-colorsconfiguration-customcolors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomColor
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.CustomColor> CustomColors { get; set; }
        }

        public class ColumnConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveRole
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
            public Humidifier.QuickSight.AnalysisTypes.FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnconfiguration.html#cfn-quicksight-analysis-columnconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// ColorsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnconfiguration.html#cfn-quicksight-analysis-columnconfiguration-colorsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorsConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColorsConfiguration ColorsConfiguration { get; set; }
        }

        public class ColumnHierarchy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateTimeHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnhierarchy.html#cfn-quicksight-analysis-columnhierarchy-datetimehierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeHierarchy
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateTimeHierarchy DateTimeHierarchy { get; set; }
            /// <summary>
            /// ExplicitHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnhierarchy.html#cfn-quicksight-analysis-columnhierarchy-explicithierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExplicitHierarchy
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ExplicitHierarchy ExplicitHierarchy { get; set; }
            /// <summary>
            /// PredefinedHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnhierarchy.html#cfn-quicksight-analysis-columnhierarchy-predefinedhierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedHierarchy
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PredefinedHierarchy PredefinedHierarchy { get; set; }
        }

        public class ColumnIdentifier : Humidifier.Base.BaseSubResource, IHaveDataSetIdentifier, IHaveColumnName
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

        public class ColumnSort : Humidifier.Base.BaseSubResource, IHaveDirection, IHaveQuickSightAnalysisTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnsort.html#cfn-quicksight-analysis-columnsort-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnsort.html#cfn-quicksight-analysis-columnsort-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier SortBy { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columnsort.html#cfn-quicksight-analysis-columnsort-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
        }

        public class ColumnTooltipItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveLabel
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-aggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AggregationFunction Aggregation { get; set; }
            /// <summary>
            /// TooltipTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-tooltiptarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTarget { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-columntooltipitem.html#cfn-quicksight-analysis-columntooltipitem-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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

        public class ComboChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BarValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-barvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> BarValues { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// LineValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartaggregatedfieldwells.html#cfn-quicksight-analysis-combochartaggregatedfieldwells-linevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> LineValues { get; set; }
        }

        public class ComboChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveBarsArrangement, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsCategoryAxis, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ComboChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// BarDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-bardatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions BarDataLabels { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SingleAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-singleaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleAxisOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SingleAxisOptions SingleAxisOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// LineDataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-linedatalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions LineDataLabels { get; set; }
            /// <summary>
            /// CategoryAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-categoryaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ComboChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartconfiguration.html#cfn-quicksight-analysis-combochartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
        }

        public class ComboChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ComboChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartfieldwells.html#cfn-quicksight-analysis-combochartfieldwells-combochartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ComboChartAggregatedFieldWells ComboChartAggregatedFieldWells { get; set; }
        }

        public class ComboChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightAnalysisTypesItemsLimitConfigurationColorItemsLimit
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartsortconfiguration.html#cfn-quicksight-analysis-combochartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class ComboChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ComboChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-combochartvisual.html#cfn-quicksight-analysis-combochartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ComparisonConfiguration : Humidifier.Base.BaseSubResource, IHaveComparisonMethod
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
            public Humidifier.QuickSight.AnalysisTypes.ComparisonFormatConfiguration ComparisonFormat { get; set; }
        }

        public class ComparisonFormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-comparisonformatconfiguration.html#cfn-quicksight-analysis-comparisonformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-comparisonformatconfiguration.html#cfn-quicksight-analysis-comparisonformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class Computation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PeriodToDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-periodtodate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodToDateComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PeriodToDateComputation PeriodToDate { get; set; }
            /// <summary>
            /// GrowthRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-growthrate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrowthRateComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GrowthRateComputation GrowthRate { get; set; }
            /// <summary>
            /// TopBottomRanked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-topbottomranked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomRankedComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TopBottomRankedComputation TopBottomRanked { get; set; }
            /// <summary>
            /// TotalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-totalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalAggregationComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TotalAggregationComputation TotalAggregation { get; set; }
            /// <summary>
            /// Forecast
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-forecast
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ForecastComputation Forecast { get; set; }
            /// <summary>
            /// MaximumMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-maximumminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumMinimumComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MaximumMinimumComputation MaximumMinimum { get; set; }
            /// <summary>
            /// PeriodOverPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-periodoverperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodOverPeriodComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PeriodOverPeriodComputation PeriodOverPeriod { get; set; }
            /// <summary>
            /// MetricComparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-metriccomparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricComparisonComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MetricComparisonComputation MetricComparison { get; set; }
            /// <summary>
            /// TopBottomMovers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-topbottommovers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomMoversComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TopBottomMoversComputation TopBottomMovers { get; set; }
            /// <summary>
            /// UniqueValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-computation.html#cfn-quicksight-analysis-computation-uniquevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UniqueValuesComputation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.UniqueValuesComputation UniqueValues { get; set; }
        }

        public class ConditionalFormattingColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcolor.html#cfn-quicksight-analysis-conditionalformattingcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingGradientColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingGradientColor Gradient { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcolor.html#cfn-quicksight-analysis-conditionalformattingcolor-solid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingSolidColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingSolidColor Solid { get; set; }
        }

        public class ConditionalFormattingCustomIconCondition : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColor
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
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIconDisplayConfiguration DisplayConfiguration { get; set; }
            /// <summary>
            /// IconOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingcustomiconcondition.html#cfn-quicksight-analysis-conditionalformattingcustomiconcondition-iconoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingCustomIconOptions IconOptions { get; set; }
        }

        public class ConditionalFormattingCustomIconOptions : Humidifier.Base.BaseSubResource, IHaveIcon, IHaveUnicodeIcon
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

        public class ConditionalFormattingGradientColor : Humidifier.Base.BaseSubResource, IHaveExpression
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
            public Humidifier.QuickSight.AnalysisTypes.GradientColor Color { get; set; }
        }

        public class ConditionalFormattingIcon : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingicon.html#cfn-quicksight-analysis-conditionalformattingicon-customcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingCustomIconCondition
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingCustomIconCondition CustomCondition { get; set; }
            /// <summary>
            /// IconSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-conditionalformattingicon.html#cfn-quicksight-analysis-conditionalformattingicon-iconset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIconSet
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIconSet IconSet { get; set; }
        }

        public class ConditionalFormattingIconDisplayConfiguration : Humidifier.Base.BaseSubResource, IHaveIconDisplayOption
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

        public class ConditionalFormattingIconSet : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveIconSetType
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

        public class ConditionalFormattingSolidColor : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColor
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

        public class ContributionAnalysisDefault : Humidifier.Base.BaseSubResource, IHaveMeasureFieldId
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
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier> ContributorDimensions { get; set; }
        }

        public class CurrencyDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveNumberScale, IHaveSymbol, IHaveQuickSightAnalysisTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightAnalysisTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightAnalysisTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightAnalysisTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-currencydisplayformatconfiguration.html#cfn-quicksight-analysis-currencydisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
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

        public class CustomActionFilterOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelectedFieldsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionfilteroperation.html#cfn-quicksight-analysis-customactionfilteroperation-selectedfieldsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationSelectedFieldsConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterOperationSelectedFieldsConfiguration SelectedFieldsConfiguration { get; set; }
            /// <summary>
            /// TargetVisualsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionfilteroperation.html#cfn-quicksight-analysis-customactionfilteroperation-targetvisualsconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterOperationTargetVisualsConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterOperationTargetVisualsConfiguration TargetVisualsConfiguration { get; set; }
        }

        public class CustomActionNavigationOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LocalNavigationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionnavigationoperation.html#cfn-quicksight-analysis-customactionnavigationoperation-localnavigationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LocalNavigationConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LocalNavigationConfiguration LocalNavigationConfiguration { get; set; }
        }

        public class CustomActionSetParametersOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParameterValueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customactionsetparametersoperation.html#cfn-quicksight-analysis-customactionsetparametersoperation-parametervalueconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SetParameterValueConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SetParameterValueConfiguration> ParameterValueConfigurations { get; set; }
        }

        public class CustomActionURLOperation : Humidifier.Base.BaseSubResource, IHaveURLTemplate, IHaveURLTarget
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

        public class CustomColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveFieldValue, IHaveSpecialValue
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

        public class CustomContentConfiguration : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContentUrl, IHaveImageScaling
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

        public class CustomContentVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.CustomContentConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-customcontentvisual.html#cfn-quicksight-analysis-customcontentvisual-visualcontentalttext
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

        public class CustomFilterListConfiguration : Humidifier.Base.BaseSubResource, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveCategoryValues
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

        public class CustomNarrativeOptions : Humidifier.Base.BaseSubResource, IHaveNarrative
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

        public class CustomParameterValues : Humidifier.Base.BaseSubResource, IHaveStringValues, IHaveDateTimeValues
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

        public class CustomValuesConfiguration : Humidifier.Base.BaseSubResource, IHaveIncludeNullValue
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
            public Humidifier.QuickSight.AnalysisTypes.CustomParameterValues CustomValues { get; set; }
        }

        public class DataBarsOptions : Humidifier.Base.BaseSubResource, IHaveFieldId, IHavePositiveColor, IHaveNegativeColor
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

        public class DataColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
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

        public class DataFieldSeriesItem : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveFieldValue, IHaveAxisBinding
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
            public Humidifier.QuickSight.AnalysisTypes.LineChartSeriesSettings Settings { get; set; }
        }

        public class DataLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHavePosition, IHaveTotalsVisibility, IHaveMeasureLabelVisibility, IHaveCategoryLabelVisibility, IHaveLabelColor, IHaveLabelContent, IHaveOverlap
        {
            /// <summary>
            /// DataLabelTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeloptions.html#cfn-quicksight-analysis-datalabeloptions-datalabeltypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataLabelType
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DataLabelType> DataLabelTypes { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class DataLabelType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-maximumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaximumLabelType
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MaximumLabelType MaximumLabelType { get; set; }
            /// <summary>
            /// DataPathLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-datapathlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathLabelType
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataPathLabelType DataPathLabelType { get; set; }
            /// <summary>
            /// RangeEndsLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-rangeendslabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangeEndsLabelType
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RangeEndsLabelType RangeEndsLabelType { get; set; }
            /// <summary>
            /// FieldLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-fieldlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldLabelType
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FieldLabelType FieldLabelType { get; set; }
            /// <summary>
            /// MinimumLabelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datalabeltype.html#cfn-quicksight-analysis-datalabeltype-minimumlabeltype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MinimumLabelType
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MinimumLabelType MinimumLabelType { get; set; }
        }

        public class DataPathColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveTimeGranularity
        {
            /// <summary>
            /// Element
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathcolor.html#cfn-quicksight-analysis-datapathcolor-element
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPathValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataPathValue Element { get; set; }
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

        public class DataPathLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveFieldValue
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

        public class DataPathSort : Humidifier.Base.BaseSubResource, IHaveDirection
        {
            /// <summary>
            /// SortPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathsort.html#cfn-quicksight-analysis-datapathsort-sortpaths
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DataPathValue> SortPaths { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathsort.html#cfn-quicksight-analysis-datapathsort-direction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathtype.html#cfn-quicksight-analysis-datapathtype-pivottabledatapathtype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datapathvalue.html#cfn-quicksight-analysis-datapathvalue-datapathtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathType
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataPathType DataPathType { get; set; }
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

        public class DataSetIdentifierDeclaration : Humidifier.Base.BaseSubResource, IHaveIdentifier, IHaveDataSetArn
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

        public class DataSetReference : Humidifier.Base.BaseSubResource, IHaveDataSetArn, IHaveDataSetPlaceholder
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

        public class DateAxisOptions : Humidifier.Base.BaseSubResource, IHaveMissingDateVisibility
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

        public class DateDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveHierarchyId, IHaveDateGranularity
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
            public Humidifier.QuickSight.AnalysisTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datedimensionfield.html#cfn-quicksight-analysis-datedimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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

        public class DateMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveAggregationFunction
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
            public Humidifier.QuickSight.AnalysisTypes.DateTimeFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datemeasurefield.html#cfn-quicksight-analysis-datemeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datemeasurefield.html#cfn-quicksight-analysis-datemeasurefield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class DateTimeDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues, IHaveQuickSightAnalysisTypesDynamicDefaultValueDynamicValue, IHaveQuickSightAnalysisTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimedefaultvalues.html#cfn-quicksight-analysis-datetimedefaultvalues-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RollingDateConfiguration RollingDate { get; set; }
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimedefaultvalues.html#cfn-quicksight-analysis-datetimedefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class DateTimeFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightAnalysisTypesNullValueFormatConfigurationNullValueFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeformatconfiguration.html#cfn-quicksight-analysis-datetimeformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeformatconfiguration.html#cfn-quicksight-analysis-datetimeformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeformatconfiguration.html#cfn-quicksight-analysis-datetimeformatconfiguration-datetimeformat
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
            public List<Humidifier.QuickSight.AnalysisTypes.DrillDownFilter> DrillDownFilters { get; set; }
        }

        public class DateTimeParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
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

        public class DateTimeParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveTimeGranularity
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDefaultValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateTimeDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DateTimeValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimeparameterdeclaration.html#cfn-quicksight-analysis-datetimeparameterdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DateTimePickerControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimepickercontroldisplayoptions.html#cfn-quicksight-analysis-datetimepickercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimepickercontroldisplayoptions.html#cfn-quicksight-analysis-datetimepickercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datetimepickercontroldisplayoptions.html#cfn-quicksight-analysis-datetimepickercontroldisplayoptions-datetimeformat
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

        public class DecimalDefaultValues : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimaldefaultvalues.html#cfn-quicksight-analysis-decimaldefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class DecimalParameter : Humidifier.Base.BaseSubResource, IHaveName
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

        public class DecimalParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDefaultValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DecimalDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DecimalValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalparameterdeclaration.html#cfn-quicksight-analysis-decimalparameterdeclaration-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-decimalplacesconfiguration.html#cfn-quicksight-analysis-decimalplacesconfiguration-decimalplaces
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

        public class DefaultDateTimePickerControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightAnalysisTypesDateTimePickerControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultdatetimepickercontroloptions.html#cfn-quicksight-analysis-defaultdatetimepickercontroloptions-commitmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontrolconfiguration.html#cfn-quicksight-analysis-defaultfiltercontrolconfiguration-controloptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultFilterControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlOptions ControlOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontrolconfiguration.html#cfn-quicksight-analysis-defaultfiltercontrolconfiguration-title
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultslideroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSliderControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultSliderControlOptions DefaultSliderOptions { get; set; }
            /// <summary>
            /// DefaultRelativeDateTimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultrelativedatetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRelativeDateTimeControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultRelativeDateTimeControlOptions DefaultRelativeDateTimeOptions { get; set; }
            /// <summary>
            /// DefaultTextFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaulttextfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextFieldControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultTextFieldControlOptions DefaultTextFieldOptions { get; set; }
            /// <summary>
            /// DefaultTextAreaOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaulttextareaoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultTextAreaControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultTextAreaControlOptions DefaultTextAreaOptions { get; set; }
            /// <summary>
            /// DefaultDropdownOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultdropdownoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterDropDownControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterDropDownControlOptions DefaultDropdownOptions { get; set; }
            /// <summary>
            /// DefaultDateTimePickerOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultdatetimepickeroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultDateTimePickerControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultDateTimePickerControlOptions DefaultDateTimePickerOptions { get; set; }
            /// <summary>
            /// DefaultListOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfiltercontroloptions.html#cfn-quicksight-analysis-defaultfiltercontroloptions-defaultlistoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFilterListControlOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterListControlOptions DefaultListOptions { get; set; }
        }

        public class DefaultFilterDropDownControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightAnalysisTypesFilterSelectableValuesSelectableValues, IHaveQuickSightAnalysisTypesDropDownControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterdropdowncontroloptions.html#cfn-quicksight-analysis-defaultfilterdropdowncontroloptions-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterdropdowncontroloptions.html#cfn-quicksight-analysis-defaultfilterdropdowncontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFilterListControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightAnalysisTypesFilterSelectableValuesSelectableValues, IHaveQuickSightAnalysisTypesListControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfilterlistcontroloptions.html#cfn-quicksight-analysis-defaultfilterlistcontroloptions-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class DefaultFreeFormLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultfreeformlayoutconfiguration.html#cfn-quicksight-analysis-defaultfreeformlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultGridLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultgridlayoutconfiguration.html#cfn-quicksight-analysis-defaultgridlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultInteractiveLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FreeForm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultinteractivelayoutconfiguration.html#cfn-quicksight-analysis-defaultinteractivelayoutconfiguration-freeform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultFreeFormLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration FreeForm { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultinteractivelayoutconfiguration.html#cfn-quicksight-analysis-defaultinteractivelayoutconfiguration-grid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultGridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration Grid { get; set; }
        }

        public class DefaultNewSheetConfiguration : Humidifier.Base.BaseSubResource, IHaveSheetContentType
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration { get; set; }
            /// <summary>
            /// PaginatedLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultnewsheetconfiguration.html#cfn-quicksight-analysis-defaultnewsheetconfiguration-paginatedlayoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultPaginatedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration PaginatedLayoutConfiguration { get; set; }
        }

        public class DefaultPaginatedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SectionBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultpaginatedlayoutconfiguration.html#cfn-quicksight-analysis-defaultpaginatedlayoutconfiguration-sectionbased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSectionBasedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration SectionBased { get; set; }
        }

        public class DefaultRelativeDateTimeControlOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultrelativedatetimecontroloptions.html#cfn-quicksight-analysis-defaultrelativedatetimecontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDateTimeControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultrelativedatetimecontroloptions.html#cfn-quicksight-analysis-defaultrelativedatetimecontroloptions-commitmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaultsectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-defaultsectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
        }

        public class DefaultSliderControlOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightAnalysisTypesSliderControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
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

        public class DefaultTextAreaControlOptions : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveQuickSightAnalysisTypesTextAreaControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DefaultTextFieldControlOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesTextFieldControlDisplayOptionsDisplayOptions
        {
            /// <summary>
            /// DisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-defaulttextfieldcontroloptions.html#cfn-quicksight-analysis-defaulttextfieldcontroloptions-displayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextFieldControlDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
        }

        public class DestinationParameterValueConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceParameterName, IHaveSelectAllValueOptions, IHaveSourceField
        {
            /// <summary>
            /// CustomValuesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-destinationparametervalueconfiguration.html#cfn-quicksight-analysis-destinationparametervalueconfiguration-customvaluesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomValuesConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomValuesConfiguration CustomValuesConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier SourceColumn { get; set; }
        }

        public class DimensionField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dimensionfield.html#cfn-quicksight-analysis-dimensionfield-datedimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateDimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateDimensionField DateDimensionField { get; set; }
            /// <summary>
            /// NumericalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dimensionfield.html#cfn-quicksight-analysis-dimensionfield-numericaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalDimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericalDimensionField NumericalDimensionField { get; set; }
            /// <summary>
            /// CategoricalDimensionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dimensionfield.html#cfn-quicksight-analysis-dimensionfield-categoricaldimensionfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalDimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoricalDimensionField CategoricalDimensionField { get; set; }
        }

        public class DonutCenterOptions : Humidifier.Base.BaseSubResource, IHaveLabelVisibility
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

        public class DonutOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DonutCenterOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-donutoptions.html#cfn-quicksight-analysis-donutoptions-donutcenteroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutCenterOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DonutCenterOptions DonutCenterOptions { get; set; }
            /// <summary>
            /// ArcOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-donutoptions.html#cfn-quicksight-analysis-donutoptions-arcoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ArcOptions ArcOptions { get; set; }
        }

        public class DrillDownFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-drilldownfilter.html#cfn-quicksight-analysis-drilldownfilter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericEqualityDrillDownFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-drilldownfilter.html#cfn-quicksight-analysis-drilldownfilter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TimeRangeDrillDownFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-drilldownfilter.html#cfn-quicksight-analysis-drilldownfilter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryDrillDownFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoryDrillDownFilter CategoryFilter { get; set; }
        }

        public class DropDownControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dropdowncontroldisplayoptions.html#cfn-quicksight-analysis-dropdowncontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dropdowncontroldisplayoptions.html#cfn-quicksight-analysis-dropdowncontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dropdowncontroldisplayoptions.html#cfn-quicksight-analysis-dropdowncontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class DynamicDefaultValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dynamicdefaultvalue.html#cfn-quicksight-analysis-dynamicdefaultvalue-groupnamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier GroupNameColumn { get; set; }
            /// <summary>
            /// DefaultValueColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dynamicdefaultvalue.html#cfn-quicksight-analysis-dynamicdefaultvalue-defaultvaluecolumn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier DefaultValueColumn { get; set; }
            /// <summary>
            /// UserNameColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-dynamicdefaultvalue.html#cfn-quicksight-analysis-dynamicdefaultvalue-usernamecolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier UserNameColumn { get; set; }
        }

        public class EmptyVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveDataSetIdentifier
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
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-emptyvisual.html#cfn-quicksight-analysis-emptyvisual-datasetidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-entity.html#cfn-quicksight-analysis-entity-path
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

        public class ExplicitHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
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
            public List<Humidifier.QuickSight.AnalysisTypes.DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-explicithierarchy.html#cfn-quicksight-analysis-explicithierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier> Columns { get; set; }
        }

        public class FieldBasedTooltip : Humidifier.Base.BaseSubResource, IHaveAggregationVisibility, IHaveTooltipTitleType
        {
            /// <summary>
            /// TooltipFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldbasedtooltip.html#cfn-quicksight-analysis-fieldbasedtooltip-tooltipfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TooltipItem
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TooltipItem> TooltipFields { get; set; }
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

        public class FieldLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId
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

        public class FieldSeriesItem : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveAxisBinding
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
            public Humidifier.QuickSight.AnalysisTypes.LineChartSeriesSettings Settings { get; set; }
        }

        public class FieldSort : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveDirection
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

        public class FieldSortOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldsortoptions.html#cfn-quicksight-analysis-fieldsortoptions-fieldsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FieldSort FieldSort { get; set; }
            /// <summary>
            /// ColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldsortoptions.html#cfn-quicksight-analysis-fieldsortoptions-columnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnSort ColumnSort { get; set; }
        }

        public class FieldTooltipItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveLabel
        {
            /// <summary>
            /// TooltipTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fieldtooltipitem.html#cfn-quicksight-analysis-fieldtooltipitem-tooltiptarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TooltipTarget { get; set; }
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

        public class FilledMapAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapaggregatedfieldwells.html#cfn-quicksight-analysis-filledmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapaggregatedfieldwells.html#cfn-quicksight-analysis-filledmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Geospatial { get; set; }
        }

        public class FilledMapConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconditionalformatting.html#cfn-quicksight-analysis-filledmapconditionalformatting-conditionalformattingoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilledMapConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FilledMapConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class FilledMapConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconditionalformattingoption.html#cfn-quicksight-analysis-filledmapconditionalformattingoption-shape
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilledMapShapeConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilledMapShapeConditionalFormatting Shape { get; set; }
        }

        public class FilledMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilledMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilledMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapconfiguration.html#cfn-quicksight-analysis-filledmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialWindowOptions WindowOptions { get; set; }
        }

        public class FilledMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilledMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapfieldwells.html#cfn-quicksight-analysis-filledmapfieldwells-filledmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilledMapAggregatedFieldWells FilledMapAggregatedFieldWells { get; set; }
        }

        public class FilledMapShapeConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapshapeconditionalformatting.html#cfn-quicksight-analysis-filledmapshapeconditionalformatting-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ShapeConditionalFormat
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ShapeConditionalFormat Format { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapshapeconditionalformatting.html#cfn-quicksight-analysis-filledmapshapeconditionalformatting-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapsortconfiguration.html#cfn-quicksight-analysis-filledmapsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class FilledMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilledMapConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FilledMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filledmapvisual.html#cfn-quicksight-analysis-filledmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NestedFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-nestedfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NestedFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NestedFilter NestedFilter { get; set; }
            /// <summary>
            /// NumericEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-numericequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericEqualityFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericEqualityFilter NumericEqualityFilter { get; set; }
            /// <summary>
            /// NumericRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-numericrangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericRangeFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericRangeFilter NumericRangeFilter { get; set; }
            /// <summary>
            /// TimeRangeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-timerangefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TimeRangeFilter TimeRangeFilter { get; set; }
            /// <summary>
            /// RelativeDatesFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-relativedatesfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeDatesFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RelativeDatesFilter RelativeDatesFilter { get; set; }
            /// <summary>
            /// TopBottomFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-topbottomfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopBottomFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TopBottomFilter TopBottomFilter { get; set; }
            /// <summary>
            /// TimeEqualityFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-timeequalityfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeEqualityFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TimeEqualityFilter TimeEqualityFilter { get; set; }
            /// <summary>
            /// CategoryFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filter.html#cfn-quicksight-analysis-filter-categoryfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoryFilter CategoryFilter { get; set; }
        }

        public class FilterControl : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Slider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterSliderControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextAreaControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDropDownControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterTextFieldControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterListControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterDateTimePickerControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterDateTimePickerControl DateTimePicker { get; set; }
            /// <summary>
            /// RelativeDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-relativedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterRelativeDateTimeControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterRelativeDateTimeControl RelativeDateTime { get; set; }
            /// <summary>
            /// CrossSheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercontrol.html#cfn-quicksight-analysis-filtercontrol-crosssheet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterCrossSheetControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilterCrossSheetControl CrossSheet { get; set; }
        }

        public class FilterCrossSheetControl : Humidifier.Base.BaseSubResource, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightAnalysisTypesCascadingControlConfigurationCascadingControlConfiguration
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
            public Humidifier.QuickSight.AnalysisTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtercrosssheetcontrol.html#cfn-quicksight-analysis-filtercrosssheetcontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDateTimePickerControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightAnalysisTypesDateTimePickerControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdatetimepickercontrol.html#cfn-quicksight-analysis-filterdatetimepickercontrol-sourcefilterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceFilterId { get; set; }
        }

        public class FilterDropDownControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightAnalysisTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightAnalysisTypesFilterSelectableValuesSelectableValues, IHaveQuickSightAnalysisTypesDropDownControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterdropdowncontrol.html#cfn-quicksight-analysis-filterdropdowncontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCrossDataset, IHaveFilterGroupId
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
            public List<Humidifier.QuickSight.AnalysisTypes.Filter> Filters { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FilterScopeConfiguration ScopeConfiguration { get; set; }
            /// <summary>
            /// FilterGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filtergroup.html#cfn-quicksight-analysis-filtergroup-filtergroupid
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

        public class FilterListControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightAnalysisTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightAnalysisTypesFilterSelectableValuesSelectableValues, IHaveQuickSightAnalysisTypesListControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.ListControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// CascadingControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterlistcontrol.html#cfn-quicksight-analysis-filterlistcontrol-cascadingcontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CascadingControlConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FilterSelectableValues SelectableValues { get; set; }
        }

        public class FilterOperationSelectedFieldsConfiguration : Humidifier.Base.BaseSubResource, IHaveSelectedFields, IHaveSelectedFieldOptions
        {
            /// <summary>
            /// SelectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filteroperationselectedfieldsconfiguration.html#cfn-quicksight-analysis-filteroperationselectedfieldsconfiguration-selectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier> SelectedColumns { get; set; }
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

        public class FilterOperationTargetVisualsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SameSheetTargetVisualConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filteroperationtargetvisualsconfiguration.html#cfn-quicksight-analysis-filteroperationtargetvisualsconfiguration-samesheettargetvisualconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SameSheetTargetVisualConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SameSheetTargetVisualConfiguration SameSheetTargetVisualConfiguration { get; set; }
        }

        public class FilterRelativeDateTimeControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId
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
            public Humidifier.QuickSight.AnalysisTypes.RelativeDateTimeControlDisplayOptions DisplayOptions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SourceFilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-filterrelativedatetimecontrol.html#cfn-quicksight-analysis-filterrelativedatetimecontrol-sourcefilterid
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
            public Humidifier.QuickSight.AnalysisTypes.SelectedSheetsFilterScopeConfiguration SelectedSheets { get; set; }
        }

        public class FilterSelectableValues : Humidifier.Base.BaseSubResource, IHaveValues
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

        public class FilterSliderControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightAnalysisTypesSliderControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
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

        public class FilterTextAreaControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveDelimiter, IHaveQuickSightAnalysisTypesTextAreaControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
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

        public class FilterTextFieldControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveFilterControlId, IHaveSourceFilterId, IHaveQuickSightAnalysisTypesTextFieldControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
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

        public class FontConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveFontStyle, IHaveFontDecoration
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
            public Humidifier.QuickSight.AnalysisTypes.FontSize FontSize { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FontWeight FontWeight { get; set; }
        }

        public class FontSize : Humidifier.Base.BaseSubResource, IHaveRelative
        {
            /// <summary>
            /// Relative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontsize.html#cfn-quicksight-analysis-fontsize-relative
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Relative { get; set; }
            /// <summary>
            /// Absolute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontsize.html#cfn-quicksight-analysis-fontsize-absolute
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-fontweight.html#cfn-quicksight-analysis-fontweight-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ForecastComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldTime, IHavePeriodsBackward, IHavePeriodsForward, IHavePredictionInterval, IHaveSeasonality, IHaveUpperBoundary, IHaveLowerBoundary, IHaveCustomSeasonalityValue
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
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastcomputation.html#cfn-quicksight-analysis-forecastcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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

        public class ForecastConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForecastProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastconfiguration.html#cfn-quicksight-analysis-forecastconfiguration-forecastproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedForecastProperties
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TimeBasedForecastProperties ForecastProperties { get; set; }
            /// <summary>
            /// Scenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastconfiguration.html#cfn-quicksight-analysis-forecastconfiguration-scenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForecastScenario
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ForecastScenario Scenario { get; set; }
        }

        public class ForecastScenario : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WhatIfRangeScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastscenario.html#cfn-quicksight-analysis-forecastscenario-whatifrangescenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfRangeScenario
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WhatIfRangeScenario WhatIfRangeScenario { get; set; }
            /// <summary>
            /// WhatIfPointScenario
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-forecastscenario.html#cfn-quicksight-analysis-forecastscenario-whatifpointscenario
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WhatIfPointScenario
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WhatIfPointScenario WhatIfPointScenario { get; set; }
        }

        public class FormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-formatconfiguration.html#cfn-quicksight-analysis-formatconfiguration-numberformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumberFormatConfiguration NumberFormatConfiguration { get; set; }
            /// <summary>
            /// DateTimeFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-formatconfiguration.html#cfn-quicksight-analysis-formatconfiguration-datetimeformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateTimeFormatConfiguration DateTimeFormatConfiguration { get; set; }
            /// <summary>
            /// StringFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-formatconfiguration.html#cfn-quicksight-analysis-formatconfiguration-stringformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StringFormatConfiguration StringFormatConfiguration { get; set; }
        }

        public class FreeFormLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutcanvassizeoptions.html#cfn-quicksight-analysis-freeformlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutScreenCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class FreeFormLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutconfiguration.html#cfn-quicksight-analysis-freeformlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformlayoutconfiguration.html#cfn-quicksight-analysis-freeformlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutElement> Elements { get; set; }
        }

        public class FreeFormLayoutElement : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveWidth, IHaveElementType, IHaveElementId, IHaveYAxisLocation, IHaveXAxisLocation
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
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutElementBorderStyle BorderStyle { get; set; }
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
            public List<Humidifier.QuickSight.AnalysisTypes.SheetElementRenderingRule> RenderingRules { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.LoadingAnimation LoadingAnimation { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutElementBackgroundStyle BackgroundStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutElementBorderStyle SelectedBorderStyle { get; set; }
        }

        public class FreeFormLayoutElementBackgroundStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveColor
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

        public class FreeFormLayoutElementBorderStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveColor
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

        public class FreeFormLayoutScreenCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedViewPortWidth
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

        public class FreeFormSectionLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-freeformsectionlayoutconfiguration.html#cfn-quicksight-analysis-freeformsectionlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FreeFormLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutElement> Elements { get; set; }
        }

        public class FunnelChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartaggregatedfieldwells.html#cfn-quicksight-analysis-funnelchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartaggregatedfieldwells.html#cfn-quicksight-analysis-funnelchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class FunnelChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FunnelChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-datalabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartDataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FunnelChartDataLabelOptions DataLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FunnelChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartconfiguration.html#cfn-quicksight-analysis-funnelchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
        }

        public class FunnelChartDataLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHavePosition, IHaveMeasureLabelVisibility, IHaveCategoryLabelVisibility, IHaveLabelColor, IHaveMeasureDataLabelStyle
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration LabelFontConfiguration { get; set; }
        }

        public class FunnelChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunnelChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartfieldwells.html#cfn-quicksight-analysis-funnelchartfieldwells-funnelchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FunnelChartAggregatedFieldWells FunnelChartAggregatedFieldWells { get; set; }
        }

        public class FunnelChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartsortconfiguration.html#cfn-quicksight-analysis-funnelchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartsortconfiguration.html#cfn-quicksight-analysis-funnelchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class FunnelChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FunnelChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-funnelchartvisual.html#cfn-quicksight-analysis-funnelchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GaugeChartArcConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartarcconditionalformatting.html#cfn-quicksight-analysis-gaugechartarcconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class GaugeChartConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconditionalformatting.html#cfn-quicksight-analysis-gaugechartconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GaugeChartConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GaugeChartConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class GaugeChartConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconditionalformattingoption.html#cfn-quicksight-analysis-gaugechartconditionalformattingoption-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartArcConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartArcConditionalFormatting Arc { get; set; }
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconditionalformattingoption.html#cfn-quicksight-analysis-gaugechartconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartPrimaryValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartPrimaryValueConditionalFormatting PrimaryValue { get; set; }
        }

        public class GaugeChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// TooltipOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-tooltipoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions TooltipOptions { get; set; }
            /// <summary>
            /// GaugeChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-gaugechartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartOptions GaugeChartOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartconfiguration.html#cfn-quicksight-analysis-gaugechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
        }

        public class GaugeChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartfieldwells.html#cfn-quicksight-analysis-gaugechartfieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> TargetValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartfieldwells.html#cfn-quicksight-analysis-gaugechartfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class GaugeChartOptions : Humidifier.Base.BaseSubResource, IHavePrimaryValueDisplayType
        {
            /// <summary>
            /// Arc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-arc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArcConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ArcConfiguration Arc { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ComparisonConfiguration Comparison { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ArcAxisConfiguration ArcAxis { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartoptions.html#cfn-quicksight-analysis-gaugechartoptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
        }

        public class GaugeChartPrimaryValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor, IHaveQuickSightAnalysisTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-gaugechartprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-gaugechartprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class GaugeChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gaugechartvisual.html#cfn-quicksight-analysis-gaugechartvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcategoricalcolor.html#cfn-quicksight-analysis-geospatialcategoricalcolor-categorydatacolors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialCategoricalDataColor
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GeospatialCategoricalDataColor> CategoryDataColors { get; set; }
            /// <summary>
            /// DefaultOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcategoricalcolor.html#cfn-quicksight-analysis-geospatialcategoricalcolor-defaultopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DefaultOpacity { get; set; }
            /// <summary>
            /// NullDataVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcategoricalcolor.html#cfn-quicksight-analysis-geospatialcategoricalcolor-nulldatavisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullDataVisibility { get; set; }
            /// <summary>
            /// NullDataSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcategoricalcolor.html#cfn-quicksight-analysis-geospatialcategoricalcolor-nulldatasettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialNullDataSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialNullDataSettings NullDataSettings { get; set; }
        }

        public class GeospatialCategoricalDataColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
        {
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcategoricaldatacolor.html#cfn-quicksight-analysis-geospatialcategoricaldatacolor-datavalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcategoricaldatacolor.html#cfn-quicksight-analysis-geospatialcategoricaldatacolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcircleradius.html#cfn-quicksight-analysis-geospatialcircleradius-radius
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcirclesymbolstyle.html#cfn-quicksight-analysis-geospatialcirclesymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialColor FillColor { get; set; }
            /// <summary>
            /// StrokeWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcirclesymbolstyle.html#cfn-quicksight-analysis-geospatialcirclesymbolstyle-strokewidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineWidth
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLineWidth StrokeWidth { get; set; }
            /// <summary>
            /// StrokeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcirclesymbolstyle.html#cfn-quicksight-analysis-geospatialcirclesymbolstyle-strokecolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialColor StrokeColor { get; set; }
            /// <summary>
            /// CircleRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcirclesymbolstyle.html#cfn-quicksight-analysis-geospatialcirclesymbolstyle-circleradius
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCircleRadius
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialCircleRadius CircleRadius { get; set; }
        }

        public class GeospatialColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcolor.html#cfn-quicksight-analysis-geospatialcolor-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialGradientColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialGradientColor Gradient { get; set; }
            /// <summary>
            /// Categorical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcolor.html#cfn-quicksight-analysis-geospatialcolor-categorical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCategoricalColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialCategoricalColor Categorical { get; set; }
            /// <summary>
            /// Solid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialcolor.html#cfn-quicksight-analysis-geospatialcolor-solid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialSolidColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialSolidColor Solid { get; set; }
        }

        public class GeospatialCoordinateBounds : Humidifier.Base.BaseSubResource, IHaveWest, IHaveSouth, IHaveNorth, IHaveEast
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

        public class GeospatialDataSourceItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialdatasourceitem.html#cfn-quicksight-analysis-geospatialdatasourceitem-staticfiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialStaticFileSource
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialStaticFileSource StaticFileDataSource { get; set; }
        }

        public class GeospatialGradientColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialgradientcolor.html#cfn-quicksight-analysis-geospatialgradientcolor-defaultopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DefaultOpacity { get; set; }
            /// <summary>
            /// StepColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialgradientcolor.html#cfn-quicksight-analysis-geospatialgradientcolor-stepcolors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialGradientStepColor
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GeospatialGradientStepColor> StepColors { get; set; }
            /// <summary>
            /// NullDataVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialgradientcolor.html#cfn-quicksight-analysis-geospatialgradientcolor-nulldatavisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullDataVisibility { get; set; }
            /// <summary>
            /// NullDataSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialgradientcolor.html#cfn-quicksight-analysis-geospatialgradientcolor-nulldatasettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialNullDataSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialNullDataSettings NullDataSettings { get; set; }
        }

        public class GeospatialGradientStepColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue
        {
            /// <summary>
            /// DataValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialgradientstepcolor.html#cfn-quicksight-analysis-geospatialgradientstepcolor-datavalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DataValue { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialgradientstepcolor.html#cfn-quicksight-analysis-geospatialgradientstepcolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialheatmapcolorscale.html#cfn-quicksight-analysis-geospatialheatmapcolorscale-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialHeatmapDataColor
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GeospatialHeatmapDataColor> Colors { get; set; }
        }

        public class GeospatialHeatmapConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatmapColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialheatmapconfiguration.html#cfn-quicksight-analysis-geospatialheatmapconfiguration-heatmapcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapColorScale
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialHeatmapColorScale HeatmapColor { get; set; }
        }

        public class GeospatialHeatmapDataColor : Humidifier.Base.BaseSubResource, IHaveColor
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

        public class GeospatialLayerColorField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColorValuesFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayercolorfield.html#cfn-quicksight-analysis-geospatiallayercolorfield-colorvaluesfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> ColorValuesFields { get; set; }
            /// <summary>
            /// ColorDimensionsFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayercolorfield.html#cfn-quicksight-analysis-geospatiallayercolorfield-colordimensionsfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> ColorDimensionsFields { get; set; }
        }

        public class GeospatialLayerDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PointLayer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayerdefinition.html#cfn-quicksight-analysis-geospatiallayerdefinition-pointlayer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointLayer
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialPointLayer PointLayer { get; set; }
            /// <summary>
            /// PolygonLayer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayerdefinition.html#cfn-quicksight-analysis-geospatiallayerdefinition-polygonlayer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPolygonLayer
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialPolygonLayer PolygonLayer { get; set; }
            /// <summary>
            /// LineLayer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayerdefinition.html#cfn-quicksight-analysis-geospatiallayerdefinition-linelayer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineLayer
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLineLayer LineLayer { get; set; }
        }

        public class GeospatialLayerItem : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveLabel, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip
        {
            /// <summary>
            /// LayerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-layerid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LayerId { get; set; }
            /// <summary>
            /// JoinDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-joindefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerJoinDefinition
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLayerJoinDefinition JoinDefinition { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LayerCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.LayerCustomAction> Actions { get; set; }
            /// <summary>
            /// LayerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-layertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LayerType { get; set; }
            /// <summary>
            /// LayerDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-layerdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerDefinition
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLayerDefinition LayerDefinition { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayeritem.html#cfn-quicksight-analysis-geospatiallayeritem-datasource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialDataSourceItem
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialDataSourceItem DataSource { get; set; }
        }

        public class GeospatialLayerJoinDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayerjoindefinition.html#cfn-quicksight-analysis-geospatiallayerjoindefinition-colorfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerColorField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLayerColorField ColorField { get; set; }
            /// <summary>
            /// ShapeKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayerjoindefinition.html#cfn-quicksight-analysis-geospatiallayerjoindefinition-shapekeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShapeKeyField { get; set; }
            /// <summary>
            /// DatasetKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayerjoindefinition.html#cfn-quicksight-analysis-geospatiallayerjoindefinition-datasetkeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UnaggregatedField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.UnaggregatedField DatasetKeyField { get; set; }
        }

        public class GeospatialLayerMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend
        {
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayermapconfiguration.html#cfn-quicksight-analysis-geospatiallayermapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayermapconfiguration.html#cfn-quicksight-analysis-geospatiallayermapconfiguration-mapstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapState
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapState MapState { get; set; }
            /// <summary>
            /// MapStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayermapconfiguration.html#cfn-quicksight-analysis-geospatiallayermapconfiguration-mapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapStyle MapStyle { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayermapconfiguration.html#cfn-quicksight-analysis-geospatiallayermapconfiguration-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Interactions { get; set; }
            /// <summary>
            /// MapLayers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallayermapconfiguration.html#cfn-quicksight-analysis-geospatiallayermapconfiguration-maplayers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GeospatialLayerItem
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GeospatialLayerItem> MapLayers { get; set; }
        }

        public class GeospatialLineLayer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallinelayer.html#cfn-quicksight-analysis-geospatiallinelayer-style
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialLineStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLineStyle Style { get; set; }
        }

        public class GeospatialLineStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineSymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallinestyle.html#cfn-quicksight-analysis-geospatiallinestyle-linesymbolstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLineSymbolStyle LineSymbolStyle { get; set; }
        }

        public class GeospatialLineSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallinesymbolstyle.html#cfn-quicksight-analysis-geospatiallinesymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialColor FillColor { get; set; }
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallinesymbolstyle.html#cfn-quicksight-analysis-geospatiallinesymbolstyle-linewidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineWidth
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLineWidth LineWidth { get; set; }
        }

        public class GeospatialLineWidth : Humidifier.Base.BaseSubResource, IHaveLineWidth
        {
            /// <summary>
            /// LineWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatiallinewidth.html#cfn-quicksight-analysis-geospatiallinewidth-linewidth
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapaggregatedfieldwells.html#cfn-quicksight-analysis-geospatialmapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapaggregatedfieldwells.html#cfn-quicksight-analysis-geospatialmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Geospatial
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapaggregatedfieldwells.html#cfn-quicksight-analysis-geospatialmapaggregatedfieldwells-geospatial
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Geospatial { get; set; }
        }

        public class GeospatialMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette
        {
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// MapStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-mapstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapStyleOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapStyleOptions MapStyleOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Interactions { get; set; }
            /// <summary>
            /// WindowOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-windowoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialWindowOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialWindowOptions WindowOptions { get; set; }
            /// <summary>
            /// PointStyleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-pointstyleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyleOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialPointStyleOptions PointStyleOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapconfiguration.html#cfn-quicksight-analysis-geospatialmapconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
        }

        public class GeospatialMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GeospatialMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapfieldwells.html#cfn-quicksight-analysis-geospatialmapfieldwells-geospatialmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapAggregatedFieldWells GeospatialMapAggregatedFieldWells { get; set; }
        }

        public class GeospatialMapState : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Bounds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstate.html#cfn-quicksight-analysis-geospatialmapstate-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapNavigation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstate.html#cfn-quicksight-analysis-geospatialmapstate-mapnavigation
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstyle.html#cfn-quicksight-analysis-geospatialmapstyle-basemapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapStyle { get; set; }
            /// <summary>
            /// BaseMapVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstyle.html#cfn-quicksight-analysis-geospatialmapstyle-basemapvisibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapVisibility { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstyle.html#cfn-quicksight-analysis-geospatialmapstyle-backgroundcolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapstyleoptions.html#cfn-quicksight-analysis-geospatialmapstyleoptions-basemapstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseMapStyle { get; set; }
        }

        public class GeospatialMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialmapvisual.html#cfn-quicksight-analysis-geospatialmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class GeospatialNullDataSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialnulldatasettings.html#cfn-quicksight-analysis-geospatialnulldatasettings-symbolstyle
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialNullSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialNullSymbolStyle SymbolStyle { get; set; }
        }

        public class GeospatialNullSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialnullsymbolstyle.html#cfn-quicksight-analysis-geospatialnullsymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FillColor { get; set; }
            /// <summary>
            /// StrokeWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialnullsymbolstyle.html#cfn-quicksight-analysis-geospatialnullsymbolstyle-strokewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StrokeWidth { get; set; }
            /// <summary>
            /// StrokeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialnullsymbolstyle.html#cfn-quicksight-analysis-geospatialnullsymbolstyle-strokecolor
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpointlayer.html#cfn-quicksight-analysis-geospatialpointlayer-style
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialPointStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialPointStyle Style { get; set; }
        }

        public class GeospatialPointStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CircleSymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpointstyle.html#cfn-quicksight-analysis-geospatialpointstyle-circlesymbolstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCircleSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialCircleSymbolStyle CircleSymbolStyle { get; set; }
        }

        public class GeospatialPointStyleOptions : Humidifier.Base.BaseSubResource, IHaveSelectedPointStyle
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
            public Humidifier.QuickSight.AnalysisTypes.ClusterMarkerConfiguration ClusterMarkerConfiguration { get; set; }
            /// <summary>
            /// HeatmapConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpointstyleoptions.html#cfn-quicksight-analysis-geospatialpointstyleoptions-heatmapconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialHeatmapConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialHeatmapConfiguration HeatmapConfiguration { get; set; }
        }

        public class GeospatialPolygonLayer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpolygonlayer.html#cfn-quicksight-analysis-geospatialpolygonlayer-style
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeospatialPolygonStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialPolygonStyle Style { get; set; }
        }

        public class GeospatialPolygonStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PolygonSymbolStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpolygonstyle.html#cfn-quicksight-analysis-geospatialpolygonstyle-polygonsymbolstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialPolygonSymbolStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialPolygonSymbolStyle PolygonSymbolStyle { get; set; }
        }

        public class GeospatialPolygonSymbolStyle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpolygonsymbolstyle.html#cfn-quicksight-analysis-geospatialpolygonsymbolstyle-fillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialColor FillColor { get; set; }
            /// <summary>
            /// StrokeWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpolygonsymbolstyle.html#cfn-quicksight-analysis-geospatialpolygonsymbolstyle-strokewidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLineWidth
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLineWidth StrokeWidth { get; set; }
            /// <summary>
            /// StrokeColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialpolygonsymbolstyle.html#cfn-quicksight-analysis-geospatialpolygonsymbolstyle-strokecolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialColor StrokeColor { get; set; }
        }

        public class GeospatialSolidColor : Humidifier.Base.BaseSubResource, IHaveColor, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialsolidcolor.html#cfn-quicksight-analysis-geospatialsolidcolor-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialsolidcolor.html#cfn-quicksight-analysis-geospatialsolidcolor-color
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialstaticfilesource.html#cfn-quicksight-analysis-geospatialstaticfilesource-staticfileid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialwindowoptions.html#cfn-quicksight-analysis-geospatialwindowoptions-bounds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialCoordinateBounds
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialCoordinateBounds Bounds { get; set; }
            /// <summary>
            /// MapZoomMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-geospatialwindowoptions.html#cfn-quicksight-analysis-geospatialwindowoptions-mapzoommode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-globaltableborderoptions.html#cfn-quicksight-analysis-globaltableborderoptions-uniformborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions UniformBorder { get; set; }
            /// <summary>
            /// SideSpecificBorder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-globaltableborderoptions.html#cfn-quicksight-analysis-globaltableborderoptions-sidespecificborder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSideBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableSideBorderOptions SideSpecificBorder { get; set; }
        }

        public class GradientColor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Stops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gradientcolor.html#cfn-quicksight-analysis-gradientcolor-stops
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GradientStop
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GradientStop> Stops { get; set; }
        }

        public class GradientStop : Humidifier.Base.BaseSubResource, IHaveColor, IHaveDataValue, IHaveGradientOffset
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

        public class GridLayoutCanvasSizeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScreenCanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutcanvassizeoptions.html#cfn-quicksight-analysis-gridlayoutcanvassizeoptions-screencanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutScreenCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions ScreenCanvasSizeOptions { get; set; }
        }

        public class GridLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutconfiguration.html#cfn-quicksight-analysis-gridlayoutconfiguration-canvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// Elements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-gridlayoutconfiguration.html#cfn-quicksight-analysis-gridlayoutconfiguration-elements
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GridLayoutElement
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.GridLayoutElement> Elements { get; set; }
        }

        public class GridLayoutElement : Humidifier.Base.BaseSubResource, IHaveElementType, IHaveElementId, IHaveColumnSpan, IHaveColumnIndex, IHaveRowIndex, IHaveRowSpan
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

        public class GridLayoutScreenCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedViewPortWidth, IHaveResizeOption
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

        public class GrowthRateComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldTime, IHavePeriodSize
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-growthratecomputation.html#cfn-quicksight-analysis-growthratecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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

        public class HeaderFooterSectionConfiguration : Humidifier.Base.BaseSubResource, IHaveSectionId
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-headerfootersectionconfiguration.html#cfn-quicksight-analysis-headerfootersectionconfiguration-layout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionLayoutConfiguration Layout { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-headerfootersectionconfiguration.html#cfn-quicksight-analysis-headerfootersectionconfiguration-style
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionStyle Style { get; set; }
            /// <summary>
            /// SectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-headerfootersectionconfiguration.html#cfn-quicksight-analysis-headerfootersectionconfiguration-sectionid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapaggregatedfieldwells.html#cfn-quicksight-analysis-heatmapaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapaggregatedfieldwells.html#cfn-quicksight-analysis-heatmapaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapaggregatedfieldwells.html#cfn-quicksight-analysis-heatmapaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Rows { get; set; }
        }

        public class HeatMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HeatMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// ColumnLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-columnlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ColumnLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HeatMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColorScale ColorScale { get; set; }
            /// <summary>
            /// RowLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapconfiguration.html#cfn-quicksight-analysis-heatmapconfiguration-rowlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions RowLabelOptions { get; set; }
        }

        public class HeatMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapfieldwells.html#cfn-quicksight-analysis-heatmapfieldwells-heatmapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HeatMapAggregatedFieldWells HeatMapAggregatedFieldWells { get; set; }
        }

        public class HeatMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeatMapRowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmaprowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> HeatMapRowSort { get; set; }
            /// <summary>
            /// HeatMapRowItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmaprowitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration HeatMapRowItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmapcolumnitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration HeatMapColumnItemsLimitConfiguration { get; set; }
            /// <summary>
            /// HeatMapColumnSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapsortconfiguration.html#cfn-quicksight-analysis-heatmapsortconfiguration-heatmapcolumnsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> HeatMapColumnSort { get; set; }
        }

        public class HeatMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.HeatMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-heatmapvisual.html#cfn-quicksight-analysis-heatmapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class HistogramAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramaggregatedfieldwells.html#cfn-quicksight-analysis-histogramaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class HistogramBinOptions : Humidifier.Base.BaseSubResource, IHaveStartValue, IHaveSelectedBinType
        {
            /// <summary>
            /// BinWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogrambinoptions.html#cfn-quicksight-analysis-histogrambinoptions-binwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BinWidthOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BinWidthOptions BinWidth { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.BinCountOptions BinCount { get; set; }
        }

        public class HistogramConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// BinOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-binoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramBinOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HistogramBinOptions BinOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HistogramFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramconfiguration.html#cfn-quicksight-analysis-histogramconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class HistogramFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HistogramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramfieldwells.html#cfn-quicksight-analysis-histogramfieldwells-histogramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HistogramAggregatedFieldWells HistogramAggregatedFieldWells { get; set; }
        }

        public class HistogramVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.HistogramConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-histogramvisual.html#cfn-quicksight-analysis-histogramvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomaction.html#cfn-quicksight-analysis-imagecustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomaction.html#cfn-quicksight-analysis-imagecustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomaction.html#cfn-quicksight-analysis-imagecustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomaction.html#cfn-quicksight-analysis-imagecustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomaction.html#cfn-quicksight-analysis-imagecustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImageCustomActionOperation
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ImageCustomActionOperation> ActionOperations { get; set; }
        }

        public class ImageCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomactionoperation.html#cfn-quicksight-analysis-imagecustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomactionoperation.html#cfn-quicksight-analysis-imagecustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagecustomactionoperation.html#cfn-quicksight-analysis-imagecustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class ImageInteractionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageMenuOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imageinteractionoptions.html#cfn-quicksight-analysis-imageinteractionoptions-imagemenuoption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageMenuOption
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ImageMenuOption ImageMenuOption { get; set; }
        }

        public class ImageMenuOption : Humidifier.Base.BaseSubResource, IHaveAvailabilityStatus
        {
            /// <summary>
            /// AvailabilityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagemenuoption.html#cfn-quicksight-analysis-imagemenuoption-availabilitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AvailabilityStatus { get; set; }
        }

        public class ImageStaticFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagestaticfile.html#cfn-quicksight-analysis-imagestaticfile-staticfileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticFileId { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-imagestaticfile.html#cfn-quicksight-analysis-imagestaticfile-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileSource
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StaticFileSource Source { get; set; }
        }

        public class InnerFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CategoryInnerFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-innerfilter.html#cfn-quicksight-analysis-innerfilter-categoryinnerfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoryInnerFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoryInnerFilter CategoryInnerFilter { get; set; }
        }

        public class InsightConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Computations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightconfiguration.html#cfn-quicksight-analysis-insightconfiguration-computations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Computation
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.Computation> Computations { get; set; }
            /// <summary>
            /// CustomNarrative
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightconfiguration.html#cfn-quicksight-analysis-insightconfiguration-customnarrative
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomNarrativeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomNarrativeOptions CustomNarrative { get; set; }
        }

        public class InsightVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.InsightConfiguration InsightConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-insightvisual.html#cfn-quicksight-analysis-insightvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class IntegerDefaultValues : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerdefaultvalues.html#cfn-quicksight-analysis-integerdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class IntegerParameter : Humidifier.Base.BaseSubResource, IHaveName
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

        public class IntegerParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDefaultValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.IntegerDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.IntegerValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-integerparameterdeclaration.html#cfn-quicksight-analysis-integerparameterdeclaration-name
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

        public class ItemsLimitConfiguration : Humidifier.Base.BaseSubResource, IHaveItemsLimit, IHaveOtherCategories
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

        public class KPIActualValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor, IHaveQuickSightAnalysisTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiactualvalueconditionalformatting.html#cfn-quicksight-analysis-kpiactualvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiactualvalueconditionalformatting.html#cfn-quicksight-analysis-kpiactualvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIComparisonValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor, IHaveQuickSightAnalysisTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-analysis-kpicomparisonvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpicomparisonvalueconditionalformatting.html#cfn-quicksight-analysis-kpicomparisonvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformatting.html#cfn-quicksight-analysis-kpiconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KPIConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.KPIConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class KPIConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-primaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIPrimaryValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIPrimaryValueConditionalFormatting PrimaryValue { get; set; }
            /// <summary>
            /// ActualValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-actualvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIActualValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIActualValueConditionalFormatting ActualValue { get; set; }
            /// <summary>
            /// ComparisonValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-comparisonvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIComparisonValueConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIComparisonValueConditionalFormatting ComparisonValue { get; set; }
            /// <summary>
            /// ProgressBar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconditionalformattingoption.html#cfn-quicksight-analysis-kpiconditionalformattingoption-progressbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIProgressBarConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIProgressBarConditionalFormatting ProgressBar { get; set; }
        }

        public class KPIConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconfiguration.html#cfn-quicksight-analysis-kpiconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPISortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// KPIOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconfiguration.html#cfn-quicksight-analysis-kpiconfiguration-kpioptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIOptions KPIOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiconfiguration.html#cfn-quicksight-analysis-kpiconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIFieldWells FieldWells { get; set; }
        }

        public class KPIFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpifieldwells.html#cfn-quicksight-analysis-kpifieldwells-targetvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> TargetValues { get; set; }
            /// <summary>
            /// TrendGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpifieldwells.html#cfn-quicksight-analysis-kpifieldwells-trendgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> TrendGroups { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpifieldwells.html#cfn-quicksight-analysis-kpifieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class KPIOptions : Humidifier.Base.BaseSubResource, IHavePrimaryValueDisplayType
        {
            /// <summary>
            /// SecondaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-secondaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration SecondaryValueFontConfiguration { get; set; }
            /// <summary>
            /// VisualLayoutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-visuallayoutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualLayoutOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIVisualLayoutOptions VisualLayoutOptions { get; set; }
            /// <summary>
            /// TrendArrows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-trendarrows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendArrowOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TrendArrowOptions TrendArrows { get; set; }
            /// <summary>
            /// SecondaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-secondaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecondaryValueOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SecondaryValueOptions SecondaryValue { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComparisonConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ComparisonConfiguration Comparison { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ProgressBarOptions ProgressBar { get; set; }
            /// <summary>
            /// PrimaryValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-primaryvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration PrimaryValueFontConfiguration { get; set; }
            /// <summary>
            /// Sparkline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpioptions.html#cfn-quicksight-analysis-kpioptions-sparkline
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPISparklineOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPISparklineOptions Sparkline { get; set; }
        }

        public class KPIPrimaryValueConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor, IHaveQuickSightAnalysisTypesConditionalFormattingIconIcon
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-kpiprimaryvalueconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiprimaryvalueconditionalformatting.html#cfn-quicksight-analysis-kpiprimaryvalueconditionalformatting-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIcon Icon { get; set; }
        }

        public class KPIProgressBarConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ForegroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpiprogressbarconditionalformatting.html#cfn-quicksight-analysis-kpiprogressbarconditionalformatting-foregroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor ForegroundColor { get; set; }
        }

        public class KPISortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrendGroupSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpisortconfiguration.html#cfn-quicksight-analysis-kpisortconfiguration-trendgroupsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> TrendGroupSort { get; set; }
        }

        public class KPISparklineOptions : Humidifier.Base.BaseSubResource, IHaveType, IHaveVisibility, IHaveColor, IHaveTooltipVisibility
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

        public class KPIVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.KPIConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisual.html#cfn-quicksight-analysis-kpivisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class KPIVisualLayoutOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StandardLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-kpivisuallayoutoptions.html#cfn-quicksight-analysis-kpivisuallayoutoptions-standardlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisualStandardLayout
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIVisualStandardLayout StandardLayout { get; set; }
        }

        public class KPIVisualStandardLayout : Humidifier.Base.BaseSubResource, IHaveType
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

        public class LabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveCustomLabel, IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class LayerCustomAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveTrigger, IHaveCustomActionId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomaction.html#cfn-quicksight-analysis-layercustomaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomaction.html#cfn-quicksight-analysis-layercustomaction-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// CustomActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomaction.html#cfn-quicksight-analysis-layercustomaction-customactionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomActionId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomaction.html#cfn-quicksight-analysis-layercustomaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ActionOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomaction.html#cfn-quicksight-analysis-layercustomaction-actionoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LayerCustomActionOperation
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.LayerCustomActionOperation> ActionOperations { get; set; }
        }

        public class LayerCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomactionoperation.html#cfn-quicksight-analysis-layercustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomactionoperation.html#cfn-quicksight-analysis-layercustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomactionoperation.html#cfn-quicksight-analysis-layercustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layercustomactionoperation.html#cfn-quicksight-analysis-layercustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class LayerMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle, IHaveDataSetIdentifier
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layermapvisual.html#cfn-quicksight-analysis-layermapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layermapvisual.html#cfn-quicksight-analysis-layermapvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layermapvisual.html#cfn-quicksight-analysis-layermapvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialLayerMapConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialLayerMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// DataSetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layermapvisual.html#cfn-quicksight-analysis-layermapvisual-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetIdentifier { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layermapvisual.html#cfn-quicksight-analysis-layermapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layermapvisual.html#cfn-quicksight-analysis-layermapvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layout.html#cfn-quicksight-analysis-layout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LayoutConfiguration Configuration { get; set; }
        }

        public class LayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layoutconfiguration.html#cfn-quicksight-analysis-layoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GridLayoutConfiguration GridLayout { get; set; }
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layoutconfiguration.html#cfn-quicksight-analysis-layoutconfiguration-freeformlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeFormLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutConfiguration FreeFormLayout { get; set; }
            /// <summary>
            /// SectionBasedLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-layoutconfiguration.html#cfn-quicksight-analysis-layoutconfiguration-sectionbasedlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutConfiguration SectionBasedLayout { get; set; }
        }

        public class LegendOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveWidth, IHavePosition
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
            /// ValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-valuefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration ValueFontConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-legendoptions.html#cfn-quicksight-analysis-legendoptions-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions Title { get; set; }
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

        public class LineChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Colors { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartaggregatedfieldwells.html#cfn-quicksight-analysis-linechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class LineChartConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightAnalysisTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// ReferenceLines
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-referencelines
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReferenceLine
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ReferenceLine> ReferenceLines { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// SingleAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-singleaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleAxisOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SingleAxisOptions SingleAxisOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
            /// <summary>
            /// DefaultSeriesSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-defaultseriessettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartDefaultSeriesSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }
            /// <summary>
            /// SecondaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-secondaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ForecastConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-forecastconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ForecastConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ForecastConfiguration> ForecastConfigurations { get; set; }
            /// <summary>
            /// Series
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-series
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeriesItem
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SeriesItem> Series { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// SecondaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-secondaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineSeriesAxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartconfiguration.html#cfn-quicksight-analysis-linechartconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
        }

        public class LineChartDefaultSeriesSettings : Humidifier.Base.BaseSubResource, IHaveAxisBinding
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartdefaultseriessettings.html#cfn-quicksight-analysis-linechartdefaultseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartfieldwells.html#cfn-quicksight-analysis-linechartfieldwells-linechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartAggregatedFieldWells LineChartAggregatedFieldWells { get; set; }
        }

        public class LineChartLineStyleSettings : Humidifier.Base.BaseSubResource, IHaveLineInterpolation, IHaveLineStyle, IHaveLineVisibility, IHaveLineWidth
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

        public class LineChartMarkerStyleSettings : Humidifier.Base.BaseSubResource, IHaveMarkerShape, IHaveMarkerSize, IHaveMarkerVisibility, IHaveMarkerColor
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

        public class LineChartSeriesSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartseriessettings.html#cfn-quicksight-analysis-linechartseriessettings-linestylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartLineStyleSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartLineStyleSettings LineStyleSettings { get; set; }
            /// <summary>
            /// MarkerStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartseriessettings.html#cfn-quicksight-analysis-linechartseriessettings-markerstylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartMarkerStyleSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartMarkerStyleSettings MarkerStyleSettings { get; set; }
        }

        public class LineChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// CategoryItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-categoryitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimitConfiguration { get; set; }
            /// <summary>
            /// ColorItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-coloritemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration ColorItemsLimitConfiguration { get; set; }
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartsortconfiguration.html#cfn-quicksight-analysis-linechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class LineChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.LineChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-linechartvisual.html#cfn-quicksight-analysis-linechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class LineSeriesAxisDisplayOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MissingDataConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-lineseriesaxisdisplayoptions.html#cfn-quicksight-analysis-lineseriesaxisdisplayoptions-missingdataconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MissingDataConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MissingDataConfiguration> MissingDataConfigurations { get; set; }
            /// <summary>
            /// AxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-lineseriesaxisdisplayoptions.html#cfn-quicksight-analysis-lineseriesaxisdisplayoptions-axisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions AxisOptions { get; set; }
        }

        public class ListControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// SearchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-searchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSearchOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ListControlSearchOptions SearchOptions { get; set; }
            /// <summary>
            /// SelectAllOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-selectalloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListControlSelectAllOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ListControlSelectAllOptions SelectAllOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-listcontroldisplayoptions.html#cfn-quicksight-analysis-listcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ListControlSearchOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class ListControlSelectAllOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class LoadingAnimation : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class LocalNavigationConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetSheetId
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

        public class LongFormatText : Humidifier.Base.BaseSubResource, IHaveRichText, IHavePlainText
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

        public class MappedDataSetParameter : Humidifier.Base.BaseSubResource, IHaveDataSetIdentifier, IHaveDataSetParameterName
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

        public class MaximumLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class MaximumMinimumComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldTime
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
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-maximumminimumcomputation.html#cfn-quicksight-analysis-maximumminimumcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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

        public class MeasureField : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DateMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-datemeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateMeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateMeasureField DateMeasureField { get; set; }
            /// <summary>
            /// NumericalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-numericalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalMeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericalMeasureField NumericalMeasureField { get; set; }
            /// <summary>
            /// CategoricalMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-categoricalmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CategoricalMeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CategoricalMeasureField CategoricalMeasureField { get; set; }
            /// <summary>
            /// CalculatedMeasureField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-measurefield.html#cfn-quicksight-analysis-measurefield-calculatedmeasurefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CalculatedMeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CalculatedMeasureField CalculatedMeasureField { get; set; }
        }

        public class MetricComparisonComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesDimensionFieldTime
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-targetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MeasureField TargetValue { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.MeasureField FromValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-metriccomparisoncomputation.html#cfn-quicksight-analysis-metriccomparisoncomputation-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-minimumlabeltype.html#cfn-quicksight-analysis-minimumlabeltype-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-missingdataconfiguration.html#cfn-quicksight-analysis-missingdataconfiguration-treatmentoption
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-negativevalueconfiguration.html#cfn-quicksight-analysis-negativevalueconfiguration-displaymode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayMode { get; set; }
        }

        public class NestedFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-nestedfilter.html#cfn-quicksight-analysis-nestedfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// InnerFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-nestedfilter.html#cfn-quicksight-analysis-nestedfilter-innerfilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InnerFilter
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.InnerFilter InnerFilter { get; set; }
            /// <summary>
            /// IncludeInnerSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-nestedfilter.html#cfn-quicksight-analysis-nestedfilter-includeinnerset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeInnerSet { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-nestedfilter.html#cfn-quicksight-analysis-nestedfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-nullvalueformatconfiguration.html#cfn-quicksight-analysis-nullvalueformatconfiguration-nullstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NullString { get; set; }
        }

        public class NumberDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveNumberScale, IHaveQuickSightAnalysisTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightAnalysisTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightAnalysisTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightAnalysisTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberdisplayformatconfiguration.html#cfn-quicksight-analysis-numberdisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numberformatconfiguration.html#cfn-quicksight-analysis-numberformatconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
        }

        public class NumericAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaxisoptions.html#cfn-quicksight-analysis-numericaxisoptions-scale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisScale
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisScale Scale { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaxisoptions.html#cfn-quicksight-analysis-numericaxisoptions-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayRange
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayRange Range { get; set; }
        }

        public class NumericEqualityDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveQuickSightAnalysisTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalitydrilldownfilter.html#cfn-quicksight-analysis-numericequalitydrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalitydrilldownfilter.html#cfn-quicksight-analysis-numericequalitydrilldownfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class NumericEqualityFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveParameterName, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveSelectAllOptions, IHaveMatchOperator, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveQuickSightAnalysisTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericequalityfilter.html#cfn-quicksight-analysis-numericequalityfilter-filterid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericformatconfiguration.html#cfn-quicksight-analysis-numericformatconfiguration-numberdisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// CurrencyDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericformatconfiguration.html#cfn-quicksight-analysis-numericformatconfiguration-currencydisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CurrencyDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CurrencyDisplayFormatConfiguration CurrencyDisplayFormatConfiguration { get; set; }
            /// <summary>
            /// PercentageDisplayFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericformatconfiguration.html#cfn-quicksight-analysis-numericformatconfiguration-percentagedisplayformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentageDisplayFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration { get; set; }
        }

        public class NumericRangeFilter : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveSelectAllOptions, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveIncludeMaximum, IHaveIncludeMinimum, IHaveQuickSightAnalysisTypesAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NumericRangeFilterValue RangeMinimum { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NumericRangeFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericrangefilter.html#cfn-quicksight-analysis-numericrangefilter-includeminimum
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

        public class NumericSeparatorConfiguration : Humidifier.Base.BaseSubResource, IHaveDecimalSeparator
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
            public Humidifier.QuickSight.AnalysisTypes.ThousandSeparatorOptions ThousandsSeparator { get; set; }
        }

        public class NumericalAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleNumericalAggregation
        {
            /// <summary>
            /// PercentileAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalaggregationfunction.html#cfn-quicksight-analysis-numericalaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentileAggregation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PercentileAggregation PercentileAggregation { get; set; }
            /// <summary>
            /// SimpleNumericalAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalaggregationfunction.html#cfn-quicksight-analysis-numericalaggregationfunction-simplenumericalaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SimpleNumericalAggregation { get; set; }
        }

        public class NumericalDimensionField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveHierarchyId
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
            public Humidifier.QuickSight.AnalysisTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaldimensionfield.html#cfn-quicksight-analysis-numericaldimensionfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericaldimensionfield.html#cfn-quicksight-analysis-numericaldimensionfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class NumericalMeasureField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericalAggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumberFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-numericalmeasurefield.html#cfn-quicksight-analysis-numericalmeasurefield-fieldid
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

        public class PanelConfiguration : Humidifier.Base.BaseSubResource, IHaveBackgroundColor, IHaveBorderThickness, IHaveBorderStyle, IHaveGutterSpacing, IHaveBackgroundVisibility, IHaveBorderVisibility, IHaveBorderColor, IHaveGutterVisibility
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
            public Humidifier.QuickSight.AnalysisTypes.PanelTitleOptions Title { get; set; }
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

        public class PanelTitleOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration, IHaveHorizontalTextAlignment
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// HorizontalTextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-paneltitleoptions.html#cfn-quicksight-analysis-paneltitleoptions-horizontaltextalignment
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-slider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSliderControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterSliderControl Slider { get; set; }
            /// <summary>
            /// TextArea
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-textarea
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextAreaControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterTextAreaControl TextArea { get; set; }
            /// <summary>
            /// Dropdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-dropdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDropDownControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterDropDownControl Dropdown { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-textfield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterTextFieldControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterTextFieldControl TextField { get; set; }
            /// <summary>
            /// List
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-list
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterListControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterListControl List { get; set; }
            /// <summary>
            /// DateTimePicker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parametercontrol.html#cfn-quicksight-analysis-parametercontrol-datetimepicker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterDateTimePickerControl
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterDateTimePickerControl DateTimePicker { get; set; }
        }

        public class ParameterDateTimePickerControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightAnalysisTypesDateTimePickerControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.DateTimePickerControlDisplayOptions DisplayOptions { get; set; }
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

        public class ParameterDeclaration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-stringparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StringParameterDeclaration StringParameterDeclaration { get; set; }
            /// <summary>
            /// DateTimeParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-datetimeparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DateTimeParameterDeclaration DateTimeParameterDeclaration { get; set; }
            /// <summary>
            /// DecimalParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-decimalparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DecimalParameterDeclaration DecimalParameterDeclaration { get; set; }
            /// <summary>
            /// IntegerParameterDeclaration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdeclaration.html#cfn-quicksight-analysis-parameterdeclaration-integerparameterdeclaration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerParameterDeclaration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.IntegerParameterDeclaration IntegerParameterDeclaration { get; set; }
        }

        public class ParameterDropDownControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightAnalysisTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightAnalysisTypesDropDownControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.DropDownControlDisplayOptions DisplayOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// CommitMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-commitmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitMode { get; set; }
            /// <summary>
            /// SelectableValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterdropdowncontrol.html#cfn-quicksight-analysis-parameterdropdowncontrol-selectablevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParameterSelectableValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterListControl : Humidifier.Base.BaseSubResource, IHaveType, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightAnalysisTypesCascadingControlConfigurationCascadingControlConfiguration, IHaveQuickSightAnalysisTypesListControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.ListControlDisplayOptions DisplayOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.CascadingControlConfiguration CascadingControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ParameterSelectableValues SelectableValues { get; set; }
        }

        public class ParameterSelectableValues : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// LinkToDataSetColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameterselectablevalues.html#cfn-quicksight-analysis-parameterselectablevalues-linktodatasetcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier LinkToDataSetColumn { get; set; }
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

        public class ParameterSliderControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveStepSize, IHaveMaximumValue, IHaveMinimumValue, IHaveQuickSightAnalysisTypesSliderControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.SliderControlDisplayOptions DisplayOptions { get; set; }
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

        public class ParameterTextAreaControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveDelimiter, IHaveQuickSightAnalysisTypesTextAreaControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.TextAreaControlDisplayOptions DisplayOptions { get; set; }
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

        public class ParameterTextFieldControl : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveSourceParameterName, IHaveParameterControlId, IHaveQuickSightAnalysisTypesTextFieldControlDisplayOptionsDisplayOptions
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
            public Humidifier.QuickSight.AnalysisTypes.TextFieldControlDisplayOptions DisplayOptions { get; set; }
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

        public class Parameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-stringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.StringParameter> StringParameters { get; set; }
            /// <summary>
            /// DecimalParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-decimalparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DecimalParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DecimalParameter> DecimalParameters { get; set; }
            /// <summary>
            /// IntegerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-integerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.IntegerParameter> IntegerParameters { get; set; }
            /// <summary>
            /// DateTimeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html#cfn-quicksight-analysis-parameters-datetimeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateTimeParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DateTimeParameter> DateTimeParameters { get; set; }
        }

        public class PercentVisibleRange : Humidifier.Base.BaseSubResource, IHaveFrom, IHaveTo
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

        public class PercentageDisplayFormatConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveQuickSightAnalysisTypesNullValueFormatConfigurationNullValueFormatConfiguration, IHaveQuickSightAnalysisTypesNegativeValueConfigurationNegativeValueConfiguration, IHaveQuickSightAnalysisTypesDecimalPlacesConfigurationDecimalPlacesConfiguration, IHaveQuickSightAnalysisTypesNumericSeparatorConfigurationSeparatorConfiguration
        {
            /// <summary>
            /// NegativeValueConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-negativevalueconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NegativeValueConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NegativeValueConfiguration NegativeValueConfiguration { get; set; }
            /// <summary>
            /// DecimalPlacesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-decimalplacesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalPlacesConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.NumericSeparatorConfiguration SeparatorConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentagedisplayformatconfiguration.html#cfn-quicksight-analysis-percentagedisplayformatconfiguration-prefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-percentileaggregation.html#cfn-quicksight-analysis-percentileaggregation-percentilevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentileValue { get; set; }
        }

        public class PeriodOverPeriodComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldTime
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodoverperiodcomputation.html#cfn-quicksight-analysis-periodoverperiodcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodoverperiodcomputation.html#cfn-quicksight-analysis-periodoverperiodcomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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

        public class PeriodToDateComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldTime, IHavePeriodTimeGranularity
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
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-periodtodatecomputation.html#cfn-quicksight-analysis-periodtodatecomputation-time
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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

        public class PieChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartaggregatedfieldwells.html#cfn-quicksight-analysis-piechartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartaggregatedfieldwells.html#cfn-quicksight-analysis-piechartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// SmallMultiples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartaggregatedfieldwells.html#cfn-quicksight-analysis-piechartaggregatedfieldwells-smallmultiples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> SmallMultiples { get; set; }
        }

        public class PieChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveQuickSightAnalysisTypesSmallMultiplesOptionsSmallMultiplesOptions, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsValueLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PieChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ContributionAnalysisDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-contributionanalysisdefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContributionAnalysisDefault
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PieChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// DonutOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-donutoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DonutOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DonutOptions DonutOptions { get; set; }
            /// <summary>
            /// SmallMultiplesOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-smallmultiplesoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SmallMultiplesOptions SmallMultiplesOptions { get; set; }
            /// <summary>
            /// ValueLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-valuelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ValueLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartconfiguration.html#cfn-quicksight-analysis-piechartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
        }

        public class PieChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PieChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartfieldwells.html#cfn-quicksight-analysis-piechartfieldwells-piechartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PieChartAggregatedFieldWells PieChartAggregatedFieldWells { get; set; }
        }

        public class PieChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightAnalysisTypesItemsLimitConfigurationSmallMultiplesLimitConfiguration
        {
            /// <summary>
            /// SmallMultiplesSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-smallmultiplessort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> SmallMultiplesSort { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
            /// <summary>
            /// SmallMultiplesLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartsortconfiguration.html#cfn-quicksight-analysis-piechartsortconfiguration-smallmultipleslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration SmallMultiplesLimitConfiguration { get; set; }
        }

        public class PieChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.PieChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-piechartvisual.html#cfn-quicksight-analysis-piechartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class PivotFieldSortOptions : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// SortBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivotfieldsortoptions.html#cfn-quicksight-analysis-pivotfieldsortoptions-sortby
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableSortBy
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableSortBy SortBy { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivotfieldsortoptions.html#cfn-quicksight-analysis-pivotfieldsortoptions-fieldid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableaggregatedfieldwells.html#cfn-quicksight-analysis-pivottableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableaggregatedfieldwells.html#cfn-quicksight-analysis-pivottableaggregatedfieldwells-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Columns { get; set; }
            /// <summary>
            /// Rows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableaggregatedfieldwells.html#cfn-quicksight-analysis-pivottableaggregatedfieldwells-rows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Rows { get; set; }
        }

        public class PivotTableCellConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablecellconditionalformatting.html#cfn-quicksight-analysis-pivottablecellconditionalformatting-scope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormattingScope
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableConditionalFormattingScope Scope { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablecellconditionalformatting.html#cfn-quicksight-analysis-pivottablecellconditionalformatting-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingScope
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PivotTableConditionalFormattingScope> Scopes { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TextConditionalFormat TextFormat { get; set; }
        }

        public class PivotTableConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconditionalformatting.html#cfn-quicksight-analysis-pivottableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PivotTableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class PivotTableConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconditionalformattingoption.html#cfn-quicksight-analysis-pivottableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableCellConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableCellConditionalFormatting Cell { get; set; }
        }

        public class PivotTableConditionalFormattingScope : Humidifier.Base.BaseSubResource, IHaveRole
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

        public class PivotTableConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTablePaginatedReportOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableOptions TableOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableFieldOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableconfiguration.html#cfn-quicksight-analysis-pivottableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableTotalOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableTotalOptions TotalOptions { get; set; }
        }

        public class PivotTableDataPathOption : Humidifier.Base.BaseSubResource, IHaveWidth
        {
            /// <summary>
            /// DataPathList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabledatapathoption.html#cfn-quicksight-analysis-pivottabledatapathoption-datapathlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataPathValue
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DataPathValue> DataPathList { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabledatapathoption.html#cfn-quicksight-analysis-pivottabledatapathoption-width
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldcollapsestateoption.html#cfn-quicksight-analysis-pivottablefieldcollapsestateoption-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotTableFieldCollapseStateTarget
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableFieldCollapseStateTarget Target { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldcollapsestateoption.html#cfn-quicksight-analysis-pivottablefieldcollapsestateoption-state
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
            public List<Humidifier.QuickSight.AnalysisTypes.DataPathValue> FieldDataPathValues { get; set; }
        }

        public class PivotTableFieldOption : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveCustomLabel
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

        public class PivotTableFieldOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CollapseStateOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoptions.html#cfn-quicksight-analysis-pivottablefieldoptions-collapsestateoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldCollapseStateOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PivotTableFieldCollapseStateOption> CollapseStateOptions { get; set; }
            /// <summary>
            /// DataPathOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoptions.html#cfn-quicksight-analysis-pivottablefieldoptions-datapathoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableDataPathOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PivotTableDataPathOption> DataPathOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldoptions.html#cfn-quicksight-analysis-pivottablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotTableFieldOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PivotTableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class PivotTableFieldSubtotalOptions : Humidifier.Base.BaseSubResource, IHaveFieldId
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

        public class PivotTableFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PivotTableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablefieldwells.html#cfn-quicksight-analysis-pivottablefieldwells-pivottableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableAggregatedFieldWells PivotTableAggregatedFieldWells { get; set; }
        }

        public class PivotTableOptions : Humidifier.Base.BaseSubResource, IHaveCollapsedRowDimensionsVisibility, IHaveRowsLayout, IHaveMetricPlacement, IHaveDefaultCellWidth, IHaveColumnNamesVisibility, IHaveSingleMetricVisibility, IHaveToggleButtonsVisibility
        {
            /// <summary>
            /// RowFieldNamesStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowfieldnamesstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle RowFieldNamesStyle { get; set; }
            /// <summary>
            /// RowHeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowheaderstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle RowHeaderStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.PivotTableRowsLabelOptions RowsLabelOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle ColumnHeaderStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle CellStyle { get; set; }
            /// <summary>
            /// RowAlternateColorOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottableoptions.html#cfn-quicksight-analysis-pivottableoptions-rowalternatecoloroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowAlternateColorOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class PivotTablePaginatedReportOptions : Humidifier.Base.BaseSubResource, IHaveOverflowColumnHeaderVisibility, IHaveVerticalOverflowVisibility
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

        public class PivotTableRowsLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveCustomLabel
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

        public class PivotTableSortBy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortby.html#cfn-quicksight-analysis-pivottablesortby-field
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSort
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FieldSort Field { get; set; }
            /// <summary>
            /// DataPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortby.html#cfn-quicksight-analysis-pivottablesortby-datapath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPathSort
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataPathSort DataPath { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortby.html#cfn-quicksight-analysis-pivottablesortby-column
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSort
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnSort Column { get; set; }
        }

        public class PivotTableSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSortOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablesortconfiguration.html#cfn-quicksight-analysis-pivottablesortconfiguration-fieldsortoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotFieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PivotFieldSortOptions> FieldSortOptions { get; set; }
        }

        public class PivotTableTotalOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-columnsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SubtotalOptions ColumnSubtotalOptions { get; set; }
            /// <summary>
            /// RowSubtotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-rowsubtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubtotalOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SubtotalOptions RowSubtotalOptions { get; set; }
            /// <summary>
            /// RowTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-rowtotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTotalOptions RowTotalOptions { get; set; }
            /// <summary>
            /// ColumnTotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottabletotaloptions.html#cfn-quicksight-analysis-pivottabletotaloptions-columntotaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTotalOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTotalOptions ColumnTotalOptions { get; set; }
        }

        public class PivotTableVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.PivotTableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottablevisual.html#cfn-quicksight-analysis-pivottablevisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class PivotTotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHavePlacement, IHaveScrollStatus, IHaveQuickSightAnalysisTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pivottotaloptions.html#cfn-quicksight-analysis-pivottotaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle ValueCellStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle TotalCellStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
        }

        public class PluginVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisual.html#cfn-quicksight-analysis-pluginvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// PluginArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisual.html#cfn-quicksight-analysis-pluginvisual-pluginarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PluginArn { get; set; }
            /// <summary>
            /// VisualId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisual.html#cfn-quicksight-analysis-pluginvisual-visualid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualId { get; set; }
            /// <summary>
            /// ChartConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisual.html#cfn-quicksight-analysis-pluginvisual-chartconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PluginVisualConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisual.html#cfn-quicksight-analysis-pluginvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisual.html#cfn-quicksight-analysis-pluginvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualconfiguration.html#cfn-quicksight-analysis-pluginvisualconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PluginVisualSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// VisualOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualconfiguration.html#cfn-quicksight-analysis-pluginvisualconfiguration-visualoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PluginVisualOptions VisualOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualconfiguration.html#cfn-quicksight-analysis-pluginvisualconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PluginVisualFieldWell
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PluginVisualFieldWell> FieldWells { get; set; }
        }

        public class PluginVisualFieldWell : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Unaggregated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualfieldwell.html#cfn-quicksight-analysis-pluginvisualfieldwell-unaggregated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.UnaggregatedField> Unaggregated { get; set; }
            /// <summary>
            /// AxisName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualfieldwell.html#cfn-quicksight-analysis-pluginvisualfieldwell-axisname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AxisName { get; set; }
            /// <summary>
            /// Measures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualfieldwell.html#cfn-quicksight-analysis-pluginvisualfieldwell-measures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Measures { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualfieldwell.html#cfn-quicksight-analysis-pluginvisualfieldwell-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Dimensions { get; set; }
        }

        public class PluginVisualItemsLimitConfiguration : Humidifier.Base.BaseSubResource, IHaveItemsLimit
        {
            /// <summary>
            /// ItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualitemslimitconfiguration.html#cfn-quicksight-analysis-pluginvisualitemslimitconfiguration-itemslimit
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualoptions.html#cfn-quicksight-analysis-pluginvisualoptions-visualproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PluginVisualProperty
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.PluginVisualProperty> VisualProperties { get; set; }
        }

        public class PluginVisualProperty : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualproperty.html#cfn-quicksight-analysis-pluginvisualproperty-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualproperty.html#cfn-quicksight-analysis-pluginvisualproperty-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualsortconfiguration.html#cfn-quicksight-analysis-pluginvisualsortconfiguration-pluginvisualtablequerysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualTableQuerySort
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PluginVisualTableQuerySort PluginVisualTableQuerySort { get; set; }
        }

        public class PluginVisualTableQuerySort : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualtablequerysort.html#cfn-quicksight-analysis-pluginvisualtablequerysort-itemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisualItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PluginVisualItemsLimitConfiguration ItemsLimitConfiguration { get; set; }
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-pluginvisualtablequerysort.html#cfn-quicksight-analysis-pluginvisualtablequerysort-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> RowSort { get; set; }
        }

        public class PredefinedHierarchy : Humidifier.Base.BaseSubResource, IHaveHierarchyId
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
            public List<Humidifier.QuickSight.AnalysisTypes.DrillDownFilter> DrillDownFilters { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-predefinedhierarchy.html#cfn-quicksight-analysis-predefinedhierarchy-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnIdentifier
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier> Columns { get; set; }
        }

        public class ProgressBarOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class QueryExecutionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryExecutionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-queryexecutionoptions.html#cfn-quicksight-analysis-queryexecutionoptions-queryexecutionmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartaggregatedfieldwells.html#cfn-quicksight-analysis-radarchartaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartaggregatedfieldwells.html#cfn-quicksight-analysis-radarchartaggregatedfieldwells-color
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Color { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartaggregatedfieldwells.html#cfn-quicksight-analysis-radarchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class RadarChartAreaStyleSettings : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class RadarChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions, IHaveShape, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsColorLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsCategoryAxis, IHaveAxesRangeScale, IHaveAlternateBandColorsVisibility, IHaveStartAngle, IHaveAlternateBandOddColor, IHaveAlternateBandEvenColor
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RadarChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.RadarChartSeriesSettings BaseSeriesSettings { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions CategoryAxis { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RadarChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// ColorAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartconfiguration.html#cfn-quicksight-analysis-radarchartconfiguration-coloraxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions ColorAxis { get; set; }
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

        public class RadarChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RadarChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartfieldwells.html#cfn-quicksight-analysis-radarchartfieldwells-radarchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RadarChartAggregatedFieldWells RadarChartAggregatedFieldWells { get; set; }
        }

        public class RadarChartSeriesSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AreaStyleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartseriessettings.html#cfn-quicksight-analysis-radarchartseriessettings-areastylesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartAreaStyleSettings
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RadarChartAreaStyleSettings AreaStyleSettings { get; set; }
        }

        public class RadarChartSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit, IHaveQuickSightAnalysisTypesItemsLimitConfigurationColorItemsLimit
        {
            /// <summary>
            /// ColorSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-colorsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> ColorSort { get; set; }
            /// <summary>
            /// ColorItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-coloritemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration ColorItemsLimit { get; set; }
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartsortconfiguration.html#cfn-quicksight-analysis-radarchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class RadarChartVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.RadarChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-radarchartvisual.html#cfn-quicksight-analysis-radarchartvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class RangeEndsLabelType : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class ReferenceLine : Humidifier.Base.BaseSubResource, IHaveStatus
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
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineDataConfiguration DataConfiguration { get; set; }
            /// <summary>
            /// LabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referenceline.html#cfn-quicksight-analysis-referenceline-labelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineLabelConfiguration LabelConfiguration { get; set; }
            /// <summary>
            /// StyleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referenceline.html#cfn-quicksight-analysis-referenceline-styleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineStyleConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineStyleConfiguration StyleConfiguration { get; set; }
        }

        public class ReferenceLineCustomLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveCustomLabel
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

        public class ReferenceLineDataConfiguration : Humidifier.Base.BaseSubResource, IHaveAxisBinding, IHaveSeriesType
        {
            /// <summary>
            /// DynamicConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedataconfiguration.html#cfn-quicksight-analysis-referencelinedataconfiguration-dynamicconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineDynamicDataConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineDynamicDataConfiguration DynamicConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineStaticDataConfiguration StaticConfiguration { get; set; }
        }

        public class ReferenceLineDynamicDataConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesColumnIdentifierColumn
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedynamicdataconfiguration.html#cfn-quicksight-analysis-referencelinedynamicdataconfiguration-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// MeasureAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedynamicdataconfiguration.html#cfn-quicksight-analysis-referencelinedynamicdataconfiguration-measureaggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AggregationFunction MeasureAggregationFunction { get; set; }
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinedynamicdataconfiguration.html#cfn-quicksight-analysis-referencelinedynamicdataconfiguration-calculation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumericalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericalAggregationFunction Calculation { get; set; }
        }

        public class ReferenceLineLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration, IHaveHorizontalPosition, IHaveVerticalPosition
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
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineValueLabelConfiguration ValueLabelConfiguration { get; set; }
            /// <summary>
            /// CustomLabelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-customlabelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceLineCustomLabelConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ReferenceLineCustomLabelConfiguration CustomLabelConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// VerticalPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinelabelconfiguration.html#cfn-quicksight-analysis-referencelinelabelconfiguration-verticalposition
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinestaticdataconfiguration.html#cfn-quicksight-analysis-referencelinestaticdataconfiguration-value
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

        public class ReferenceLineValueLabelConfiguration : Humidifier.Base.BaseSubResource, IHaveRelativePosition
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinevaluelabelconfiguration.html#cfn-quicksight-analysis-referencelinevaluelabelconfiguration-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericFormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// RelativePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-referencelinevaluelabelconfiguration.html#cfn-quicksight-analysis-referencelinevaluelabelconfiguration-relativeposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativePosition { get; set; }
        }

        public class RelativeDateTimeControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatetimecontroldisplayoptions.html#cfn-quicksight-analysis-relativedatetimecontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatetimecontroldisplayoptions.html#cfn-quicksight-analysis-relativedatetimecontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-relativedatetimecontroldisplayoptions.html#cfn-quicksight-analysis-relativedatetimecontroldisplayoptions-datetimeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class RelativeDatesFilter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveRelativeDateValue, IHaveRelativeDateType, IHaveMinimumGranularity
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
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.AnchorDateConfiguration AnchorDateConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
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

        public class RollingDateConfiguration : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveDataSetIdentifier
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

        public class RowAlternateColorOptions : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveUsePrimaryBackgroundColor, IHaveRowAlternateColors
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

        public class SameSheetTargetVisualConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetVisualOptions, IHaveTargetVisuals
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

        public class SankeyDiagramAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-analysis-sankeydiagramaggregatedfieldwells-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-analysis-sankeydiagramaggregatedfieldwells-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Source { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramaggregatedfieldwells.html#cfn-quicksight-analysis-sankeydiagramaggregatedfieldwells-weight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Weight { get; set; }
        }

        public class SankeyDiagramChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramchartconfiguration.html#cfn-quicksight-analysis-sankeydiagramchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SankeyDiagramSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramchartconfiguration.html#cfn-quicksight-analysis-sankeydiagramchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramchartconfiguration.html#cfn-quicksight-analysis-sankeydiagramchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SankeyDiagramFieldWells FieldWells { get; set; }
        }

        public class SankeyDiagramFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SankeyDiagramAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramfieldwells.html#cfn-quicksight-analysis-sankeydiagramfieldwells-sankeydiagramaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SankeyDiagramAggregatedFieldWells SankeyDiagramAggregatedFieldWells { get; set; }
        }

        public class SankeyDiagramSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramsortconfiguration.html#cfn-quicksight-analysis-sankeydiagramsortconfiguration-weightsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> WeightSort { get; set; }
            /// <summary>
            /// SourceItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramsortconfiguration.html#cfn-quicksight-analysis-sankeydiagramsortconfiguration-sourceitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration SourceItemsLimit { get; set; }
            /// <summary>
            /// DestinationItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramsortconfiguration.html#cfn-quicksight-analysis-sankeydiagramsortconfiguration-destinationitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration DestinationItemsLimit { get; set; }
        }

        public class SankeyDiagramVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.SankeyDiagramChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sankeydiagramvisual.html#cfn-quicksight-analysis-sankeydiagramvisual-visualcontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotcategoricallyaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> YAxis { get; set; }
        }

        public class ScatterPlotConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsXAxisLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsXAxisDisplayOptions
        {
            /// <summary>
            /// YAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-yaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions YAxisLabelOptions { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// YAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-yaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions YAxisDisplayOptions { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ScatterPlotFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// XAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-xaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions XAxisLabelOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
            /// <summary>
            /// XAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotconfiguration.html#cfn-quicksight-analysis-scatterplotconfiguration-xaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions XAxisDisplayOptions { get; set; }
        }

        public class ScatterPlotFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScatterPlotUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotfieldwells.html#cfn-quicksight-analysis-scatterplotfieldwells-scatterplotunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotUnaggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ScatterPlotUnaggregatedFieldWells ScatterPlotUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// ScatterPlotCategoricallyAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotfieldwells.html#cfn-quicksight-analysis-scatterplotfieldwells-scatterplotcategoricallyaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotCategoricallyAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ScatterPlotCategoricallyAggregatedFieldWells ScatterPlotCategoricallyAggregatedFieldWells { get; set; }
        }

        public class ScatterPlotUnaggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Category { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Size { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-label
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Label { get; set; }
            /// <summary>
            /// XAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-xaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotunaggregatedfieldwells.html#cfn-quicksight-analysis-scatterplotunaggregatedfieldwells-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> YAxis { get; set; }
        }

        public class ScatterPlotVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ScatterPlotConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scatterplotvisual.html#cfn-quicksight-analysis-scatterplotvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class ScrollBarOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
        {
            /// <summary>
            /// VisibleRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scrollbaroptions.html#cfn-quicksight-analysis-scrollbaroptions-visiblerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisibleRangeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisibleRangeOptions VisibleRange { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-scrollbaroptions.html#cfn-quicksight-analysis-scrollbaroptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-secondaryvalueoptions.html#cfn-quicksight-analysis-secondaryvalueoptions-visibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionafterpagebreak.html#cfn-quicksight-analysis-sectionafterpagebreak-status
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutcanvassizeoptions.html#cfn-quicksight-analysis-sectionbasedlayoutcanvassizeoptions-papercanvassizeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutPaperCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions PaperCanvasSizeOptions { get; set; }
        }

        public class SectionBasedLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CanvasSizeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-canvassizeoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SectionBasedLayoutCanvasSizeOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions CanvasSizeOptions { get; set; }
            /// <summary>
            /// FooterSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-footersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.HeaderFooterSectionConfiguration> FooterSections { get; set; }
            /// <summary>
            /// BodySections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-bodysections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BodySectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.BodySectionConfiguration> BodySections { get; set; }
            /// <summary>
            /// HeaderSections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutconfiguration.html#cfn-quicksight-analysis-sectionbasedlayoutconfiguration-headersections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HeaderFooterSectionConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.HeaderFooterSectionConfiguration> HeaderSections { get; set; }
        }

        public class SectionBasedLayoutPaperCanvasSizeOptions : Humidifier.Base.BaseSubResource, IHavePaperSize, IHavePaperOrientation
        {
            /// <summary>
            /// PaperMargin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions.html#cfn-quicksight-analysis-sectionbasedlayoutpapercanvassizeoptions-papermargin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.Spacing PaperMargin { get; set; }
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

        public class SectionLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FreeFormLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionlayoutconfiguration.html#cfn-quicksight-analysis-sectionlayoutconfiguration-freeformlayout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FreeFormSectionLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FreeFormSectionLayoutConfiguration FreeFormLayout { get; set; }
        }

        public class SectionPageBreakConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// After
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionpagebreakconfiguration.html#cfn-quicksight-analysis-sectionpagebreakconfiguration-after
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SectionAfterPageBreak
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SectionAfterPageBreak After { get; set; }
        }

        public class SectionStyle : Humidifier.Base.BaseSubResource, IHaveHeight
        {
            /// <summary>
            /// Padding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionstyle.html#cfn-quicksight-analysis-sectionstyle-padding
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spacing
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.Spacing Padding { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sectionstyle.html#cfn-quicksight-analysis-sectionstyle-height
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-selectedsheetsfilterscopeconfiguration.html#cfn-quicksight-analysis-selectedsheetsfilterscopeconfiguration-sheetvisualscopingconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetVisualScopingConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SheetVisualScopingConfiguration> SheetVisualScopingConfigurations { get; set; }
        }

        public class SeriesItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-seriesitem.html#cfn-quicksight-analysis-seriesitem-fieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldSeriesItem
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FieldSeriesItem FieldSeriesItem { get; set; }
            /// <summary>
            /// DataFieldSeriesItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-seriesitem.html#cfn-quicksight-analysis-seriesitem-datafieldseriesitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataFieldSeriesItem
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataFieldSeriesItem DataFieldSeriesItem { get; set; }
        }

        public class SetParameterValueConfiguration : Humidifier.Base.BaseSubResource, IHaveDestinationParameterName
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
            public Humidifier.QuickSight.AnalysisTypes.DestinationParameterValueConfiguration Value { get; set; }
        }

        public class ShapeConditionalFormat : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-shapeconditionalformat.html#cfn-quicksight-analysis-shapeconditionalformat-backgroundcolor
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class Sheet : Humidifier.Base.BaseSubResource, IHaveName, IHaveSheetId
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
            /// Images
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheet.html#cfn-quicksight-analysis-sheet-images
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetImage
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SheetImage> Images { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheet.html#cfn-quicksight-analysis-sheet-name
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

        public class SheetControlLayout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetcontrollayout.html#cfn-quicksight-analysis-sheetcontrollayout-configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetControlLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlLayoutConfiguration Configuration { get; set; }
        }

        public class SheetControlLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GridLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetcontrollayoutconfiguration.html#cfn-quicksight-analysis-sheetcontrollayoutconfiguration-gridlayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GridLayoutConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GridLayoutConfiguration GridLayout { get; set; }
        }

        public class SheetDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveTitle, IHaveContentType, IHaveSheetId
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
            public List<Humidifier.QuickSight.AnalysisTypes.ParameterControl> ParameterControls { get; set; }
            /// <summary>
            /// TextBoxes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-textboxes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetTextBox
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SheetTextBox> TextBoxes { get; set; }
            /// <summary>
            /// Layouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-layouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Layout
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.Layout> Layouts { get; set; }
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
            public List<Humidifier.QuickSight.AnalysisTypes.FilterControl> FilterControls { get; set; }
            /// <summary>
            /// Images
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-images
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetImage
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SheetImage> Images { get; set; }
            /// <summary>
            /// SheetControlLayouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-sheetcontrollayouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SheetControlLayout
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.SheetControlLayout> SheetControlLayouts { get; set; }
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
            public List<Humidifier.QuickSight.AnalysisTypes.Visual> Visuals { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetdefinition.html#cfn-quicksight-analysis-sheetdefinition-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetelementconfigurationoverrides.html#cfn-quicksight-analysis-sheetelementconfigurationoverrides-visibility
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
            public Humidifier.QuickSight.AnalysisTypes.SheetElementConfigurationOverrides ConfigurationOverrides { get; set; }
        }

        public class SheetImage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImageCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ImageCustomAction> Actions { get; set; }
            /// <summary>
            /// SheetImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-sheetimageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SheetImageId { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageTooltipConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetImageTooltipConfiguration Tooltip { get; set; }
            /// <summary>
            /// Scaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-scaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageScalingConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetImageScalingConfiguration Scaling { get; set; }
            /// <summary>
            /// Interactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-interactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageInteractionOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ImageInteractionOptions Interactions { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SheetImageSource
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetImageSource Source { get; set; }
            /// <summary>
            /// ImageContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimage.html#cfn-quicksight-analysis-sheetimage-imagecontentalttext
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimagescalingconfiguration.html#cfn-quicksight-analysis-sheetimagescalingconfiguration-scalingtype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimagesource.html#cfn-quicksight-analysis-sheetimagesource-sheetimagestaticfilesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageStaticFileSource
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetImageStaticFileSource SheetImageStaticFileSource { get; set; }
        }

        public class SheetImageStaticFileSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimagestaticfilesource.html#cfn-quicksight-analysis-sheetimagestaticfilesource-staticfileid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimagetooltipconfiguration.html#cfn-quicksight-analysis-sheetimagetooltipconfiguration-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Visibility { get; set; }
            /// <summary>
            /// TooltipText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimagetooltipconfiguration.html#cfn-quicksight-analysis-sheetimagetooltipconfiguration-tooltiptext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetImageTooltipText
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetImageTooltipText TooltipText { get; set; }
        }

        public class SheetImageTooltipText : Humidifier.Base.BaseSubResource, IHavePlainText
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheetimagetooltiptext.html#cfn-quicksight-analysis-sheetimagetooltiptext-plaintext
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

        public class SheetVisualScopingConfiguration : Humidifier.Base.BaseSubResource, IHaveScope, IHaveSheetId, IHaveVisualIds
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

        public class ShortFormatText : Humidifier.Base.BaseSubResource, IHaveRichText, IHavePlainText
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

        public class SimpleClusterMarker : Humidifier.Base.BaseSubResource, IHaveColor
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

        public class SingleAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// YAxisOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-singleaxisoptions.html#cfn-quicksight-analysis-singleaxisoptions-yaxisoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: YAxisOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.YAxisOptions YAxisOptions { get; set; }
        }

        public class SliderControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-slidercontroldisplayoptions.html#cfn-quicksight-analysis-slidercontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-slidercontroldisplayoptions.html#cfn-quicksight-analysis-slidercontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class SmallMultiplesAxisProperties : Humidifier.Base.BaseSubResource, IHavePlacement, IHaveScale
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

        public class SmallMultiplesOptions : Humidifier.Base.BaseSubResource, IHaveMaxVisibleRows, IHaveMaxVisibleColumns
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
            public Humidifier.QuickSight.AnalysisTypes.PanelConfiguration PanelConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.SmallMultiplesAxisProperties XAxis { get; set; }
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-smallmultiplesoptions.html#cfn-quicksight-analysis-smallmultiplesoptions-yaxis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmallMultiplesAxisProperties
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SmallMultiplesAxisProperties YAxis { get; set; }
        }

        public class Spacing : Humidifier.Base.BaseSubResource, IHaveLeft, IHaveTop, IHaveRight, IHaveBottom
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

        public class SpatialStaticFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticFileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-spatialstaticfile.html#cfn-quicksight-analysis-spatialstaticfile-staticfileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticFileId { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-spatialstaticfile.html#cfn-quicksight-analysis-spatialstaticfile-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileSource
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StaticFileSource Source { get; set; }
        }

        public class StaticFile : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageStaticFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfile.html#cfn-quicksight-analysis-staticfile-imagestaticfile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageStaticFile
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ImageStaticFile ImageStaticFile { get; set; }
            /// <summary>
            /// SpatialStaticFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfile.html#cfn-quicksight-analysis-staticfile-spatialstaticfile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpatialStaticFile
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SpatialStaticFile SpatialStaticFile { get; set; }
        }

        public class StaticFileS3SourceOptions : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveRegion
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfiles3sourceoptions.html#cfn-quicksight-analysis-staticfiles3sourceoptions-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfiles3sourceoptions.html#cfn-quicksight-analysis-staticfiles3sourceoptions-objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKey { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfiles3sourceoptions.html#cfn-quicksight-analysis-staticfiles3sourceoptions-region
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfilesource.html#cfn-quicksight-analysis-staticfilesource-urloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileUrlSourceOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StaticFileUrlSourceOptions UrlOptions { get; set; }
            /// <summary>
            /// S3Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfilesource.html#cfn-quicksight-analysis-staticfilesource-s3options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticFileS3SourceOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StaticFileS3SourceOptions S3Options { get; set; }
        }

        public class StaticFileUrlSourceOptions : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-staticfileurlsourceoptions.html#cfn-quicksight-analysis-staticfileurlsourceoptions-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class StringDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues, IHaveQuickSightAnalysisTypesDynamicDefaultValueDynamicValue
        {
            /// <summary>
            /// DynamicValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringdefaultvalues.html#cfn-quicksight-analysis-stringdefaultvalues-dynamicvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicDefaultValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DynamicDefaultValue DynamicValue { get; set; }
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

        public class StringFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesNullValueFormatConfigurationNullValueFormatConfiguration
        {
            /// <summary>
            /// NumericFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringformatconfiguration.html#cfn-quicksight-analysis-stringformatconfiguration-numericformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumericFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NumericFormatConfiguration NumericFormatConfiguration { get; set; }
            /// <summary>
            /// NullValueFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringformatconfiguration.html#cfn-quicksight-analysis-stringformatconfiguration-nullvalueformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NullValueFormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }
        }

        public class StringParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
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

        public class StringParameterDeclaration : Humidifier.Base.BaseSubResource, IHaveName, IHaveParameterValueType
        {
            /// <summary>
            /// MappedDataSetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-mappeddatasetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappedDataSetParameter
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MappedDataSetParameter> MappedDataSetParameters { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDefaultValues
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.StringDefaultValues DefaultValues { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.StringValueWhenUnsetConfiguration ValueWhenUnset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-stringparameterdeclaration.html#cfn-quicksight-analysis-stringparameterdeclaration-name
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

        public class SubtotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHaveQuickSightAnalysisTypesTableCellStyleTotalCellStyle, IHaveFieldLevel
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
            public List<Humidifier.QuickSight.AnalysisTypes.PivotTableFieldSubtotalOptions> FieldLevelOptions { get; set; }
            /// <summary>
            /// ValueCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-valuecellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle ValueCellStyle { get; set; }
            /// <summary>
            /// TotalCellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-totalcellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle TotalCellStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle MetricHeaderCellStyle { get; set; }
            /// <summary>
            /// StyleTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-subtotaloptions.html#cfn-quicksight-analysis-subtotaloptions-styletargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableStyleTarget
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TableStyleTarget> StyleTargets { get; set; }
        }

        public class TableAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableaggregatedfieldwells.html#cfn-quicksight-analysis-tableaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableaggregatedfieldwells.html#cfn-quicksight-analysis-tableaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class TableBorderOptions : Humidifier.Base.BaseSubResource, IHaveColor, IHaveStyle, IHaveThickness
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

        public class TableCellConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveFieldId
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
            public Humidifier.QuickSight.AnalysisTypes.TextConditionalFormat TextFormat { get; set; }
        }

        public class TableCellImageSizingConfiguration : Humidifier.Base.BaseSubResource, IHaveTableCellImageScalingConfiguration
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

        public class TableCellStyle : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveHeight, IHaveBackgroundColor, IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration, IHaveHorizontalTextAlignment, IHaveVerticalTextAlignment, IHaveTextWrap
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablecellstyle.html#cfn-quicksight-analysis-tablecellstyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalTableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GlobalTableBorderOptions Border { get; set; }
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

        public class TableConditionalFormatting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConditionalFormattingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconditionalformatting.html#cfn-quicksight-analysis-tableconditionalformatting-conditionalformattingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableConditionalFormattingOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TableConditionalFormattingOption> ConditionalFormattingOptions { get; set; }
        }

        public class TableConditionalFormattingOption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Row
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconditionalformattingoption.html#cfn-quicksight-analysis-tableconditionalformattingoption-row
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableRowConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableRowConditionalFormatting Row { get; set; }
            /// <summary>
            /// Cell
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconditionalformattingoption.html#cfn-quicksight-analysis-tableconditionalformattingoption-cell
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellConditionalFormatting Cell { get; set; }
        }

        public class TableConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// PaginatedReportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-paginatedreportoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TablePaginatedReportOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TablePaginatedReportOptions PaginatedReportOptions { get; set; }
            /// <summary>
            /// TableOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-tableoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableOptions TableOptions { get; set; }
            /// <summary>
            /// TableInlineVisualizations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-tableinlinevisualizations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableInlineVisualization
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TableInlineVisualization> TableInlineVisualizations { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableFieldWells FieldWells { get; set; }
            /// <summary>
            /// FieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-fieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableFieldOptions FieldOptions { get; set; }
            /// <summary>
            /// TotalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableconfiguration.html#cfn-quicksight-analysis-tableconfiguration-totaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TotalOptions TotalOptions { get; set; }
        }

        public class TableFieldCustomIconContent : Humidifier.Base.BaseSubResource, IHaveIcon
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

        public class TableFieldCustomTextContent : Humidifier.Base.BaseSubResource, IHaveValue, IHaveQuickSightAnalysisTypesFontConfigurationFontConfiguration
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
            public Humidifier.QuickSight.AnalysisTypes.FontConfiguration FontConfiguration { get; set; }
        }

        public class TableFieldImageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SizingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldimageconfiguration.html#cfn-quicksight-analysis-tablefieldimageconfiguration-sizingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellImageSizingConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellImageSizingConfiguration SizingOptions { get; set; }
        }

        public class TableFieldLinkConfiguration : Humidifier.Base.BaseSubResource, IHaveTarget
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
            public Humidifier.QuickSight.AnalysisTypes.TableFieldLinkContentConfiguration Content { get; set; }
        }

        public class TableFieldLinkContentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomIconContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldlinkcontentconfiguration.html#cfn-quicksight-analysis-tablefieldlinkcontentconfiguration-customiconcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomIconContent
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableFieldCustomIconContent CustomIconContent { get; set; }
            /// <summary>
            /// CustomTextContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldlinkcontentconfiguration.html#cfn-quicksight-analysis-tablefieldlinkcontentconfiguration-customtextcontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldCustomTextContent
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableFieldCustomTextContent CustomTextContent { get; set; }
        }

        public class TableFieldOption : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveFieldId, IHaveCustomLabel, IHaveWidth
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
            public Humidifier.QuickSight.AnalysisTypes.TableFieldURLConfiguration URLStyling { get; set; }
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

        public class TableFieldOptions : Humidifier.Base.BaseSubResource, IHaveOrder
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
            public Humidifier.QuickSight.AnalysisTypes.TablePinnedFieldOptions PinnedFieldOptions { get; set; }
            /// <summary>
            /// SelectedFieldOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldoptions.html#cfn-quicksight-analysis-tablefieldoptions-selectedfieldoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TableFieldOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TableFieldOption> SelectedFieldOptions { get; set; }
        }

        public class TableFieldURLConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldurlconfiguration.html#cfn-quicksight-analysis-tablefieldurlconfiguration-linkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldLinkConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableFieldLinkConfiguration LinkConfiguration { get; set; }
            /// <summary>
            /// ImageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldurlconfiguration.html#cfn-quicksight-analysis-tablefieldurlconfiguration-imageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableFieldImageConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableFieldImageConfiguration ImageConfiguration { get; set; }
        }

        public class TableFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TableUnaggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldwells.html#cfn-quicksight-analysis-tablefieldwells-tableunaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableUnaggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableUnaggregatedFieldWells TableUnaggregatedFieldWells { get; set; }
            /// <summary>
            /// TableAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablefieldwells.html#cfn-quicksight-analysis-tablefieldwells-tableaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableAggregatedFieldWells TableAggregatedFieldWells { get; set; }
        }

        public class TableInlineVisualization : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataBars
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableinlinevisualization.html#cfn-quicksight-analysis-tableinlinevisualization-databars
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataBarsOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataBarsOptions DataBars { get; set; }
        }

        public class TableOptions : Humidifier.Base.BaseSubResource, IHaveOrientation
        {
            /// <summary>
            /// HeaderStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableoptions.html#cfn-quicksight-analysis-tableoptions-headerstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle HeaderStyle { get; set; }
            /// <summary>
            /// CellStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableoptions.html#cfn-quicksight-analysis-tableoptions-cellstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableCellStyle
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle CellStyle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.RowAlternateColorOptions RowAlternateColorOptions { get; set; }
        }

        public class TablePaginatedReportOptions : Humidifier.Base.BaseSubResource, IHaveOverflowColumnHeaderVisibility, IHaveVerticalOverflowVisibility
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

        public class TablePinnedFieldOptions : Humidifier.Base.BaseSubResource, IHavePinnedLeftFields
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

        public class TableRowConditionalFormatting : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor, IHaveQuickSightAnalysisTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablerowconditionalformatting.html#cfn-quicksight-analysis-tablerowconditionalformatting-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablerowconditionalformatting.html#cfn-quicksight-analysis-tablerowconditionalformatting-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TableSideBorderOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-left
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-top
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions Top { get; set; }
            /// <summary>
            /// InnerHorizontal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-innerhorizontal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions InnerHorizontal { get; set; }
            /// <summary>
            /// Right
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-right
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions Right { get; set; }
            /// <summary>
            /// Bottom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-bottom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions Bottom { get; set; }
            /// <summary>
            /// InnerVertical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesideborderoptions.html#cfn-quicksight-analysis-tablesideborderoptions-innervertical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableBorderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableBorderOptions InnerVertical { get; set; }
        }

        public class TableSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RowSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesortconfiguration.html#cfn-quicksight-analysis-tablesortconfiguration-rowsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> RowSort { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablesortconfiguration.html#cfn-quicksight-analysis-tablesortconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PaginationConfiguration PaginationConfiguration { get; set; }
        }

        public class TableStyleTarget : Humidifier.Base.BaseSubResource, IHaveCellType
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

        public class TableUnaggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tableunaggregatedfieldwells.html#cfn-quicksight-analysis-tableunaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UnaggregatedField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.UnaggregatedField> Values { get; set; }
        }

        public class TableVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
            /// <summary>
            /// ConditionalFormatting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-conditionalformatting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableConditionalFormatting
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableConditionalFormatting ConditionalFormatting { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tablevisual.html#cfn-quicksight-analysis-tablevisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
        }

        public class TextAreaControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textareacontroldisplayoptions.html#cfn-quicksight-analysis-textareacontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textareacontroldisplayoptions.html#cfn-quicksight-analysis-textareacontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textareacontroldisplayoptions.html#cfn-quicksight-analysis-textareacontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class TextConditionalFormat : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesConditionalFormattingColorTextColor, IHaveQuickSightAnalysisTypesConditionalFormattingIconIcon, IHaveQuickSightAnalysisTypesConditionalFormattingColorBackgroundColor
        {
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textconditionalformat.html#cfn-quicksight-analysis-textconditionalformat-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor TextColor { get; set; }
            /// <summary>
            /// Icon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textconditionalformat.html#cfn-quicksight-analysis-textconditionalformat-icon
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingIcon
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingIcon Icon { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textconditionalformat.html#cfn-quicksight-analysis-textconditionalformat-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalFormattingColor
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ConditionalFormattingColor BackgroundColor { get; set; }
        }

        public class TextControlPlaceholderOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class TextFieldControlDisplayOptions : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLabelOptionsTitleOptions, IHaveQuickSightAnalysisTypesSheetControlInfoIconLabelOptionsInfoIconLabelOptions
        {
            /// <summary>
            /// TitleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textfieldcontroldisplayoptions.html#cfn-quicksight-analysis-textfieldcontroldisplayoptions-titleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LabelOptions TitleOptions { get; set; }
            /// <summary>
            /// PlaceholderOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textfieldcontroldisplayoptions.html#cfn-quicksight-analysis-textfieldcontroldisplayoptions-placeholderoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextControlPlaceholderOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TextControlPlaceholderOptions PlaceholderOptions { get; set; }
            /// <summary>
            /// InfoIconLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-textfieldcontroldisplayoptions.html#cfn-quicksight-analysis-textfieldcontroldisplayoptions-infoiconlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetControlInfoIconLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SheetControlInfoIconLabelOptions InfoIconLabelOptions { get; set; }
        }

        public class ThousandSeparatorOptions : Humidifier.Base.BaseSubResource, IHaveVisibility, IHaveSymbol
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

        public class TimeBasedForecastProperties : Humidifier.Base.BaseSubResource, IHavePeriodsBackward, IHavePeriodsForward, IHavePredictionInterval, IHaveSeasonality, IHaveUpperBoundary, IHaveLowerBoundary
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

        public class TimeEqualityFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveQuickSightAnalysisTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RollingDateConfiguration RollingDate { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timeequalityfilter.html#cfn-quicksight-analysis-timeequalityfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TimeRangeDrillDownFilter : Humidifier.Base.BaseSubResource, IHaveTimeGranularity, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveRangeMinimum, IHaveRangeMaximum
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangedrilldownfilter.html#cfn-quicksight-analysis-timerangedrilldownfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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

        public class TimeRangeFilter : Humidifier.Base.BaseSubResource, IHaveTimeGranularity, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveNullOption, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration, IHaveIncludeMaximum, IHaveIncludeMinimum
        {
            /// <summary>
            /// RangeMinimumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-rangeminimumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TimeRangeFilterValue RangeMinimumValue { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// RangeMaximumValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefilter.html#cfn-quicksight-analysis-timerangefilter-rangemaximumvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRangeFilterValue
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TimeRangeFilterValue RangeMaximumValue { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }
        }

        public class TimeRangeFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue, IHaveParameter, IHaveQuickSightAnalysisTypesRollingDateConfigurationRollingDate
        {
            /// <summary>
            /// RollingDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-timerangefiltervalue.html#cfn-quicksight-analysis-timerangefiltervalue-rollingdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingDateConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RollingDateConfiguration RollingDate { get; set; }
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

        public class TooltipItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FieldTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipitem.html#cfn-quicksight-analysis-tooltipitem-fieldtooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldTooltipItem
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FieldTooltipItem FieldTooltipItem { get; set; }
            /// <summary>
            /// ColumnTooltipItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-tooltipitem.html#cfn-quicksight-analysis-tooltipitem-columntooltipitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnTooltipItem
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnTooltipItem ColumnTooltipItem { get; set; }
        }

        public class TooltipOptions : Humidifier.Base.BaseSubResource, IHaveTooltipVisibility, IHaveSelectedTooltipType
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
            public Humidifier.QuickSight.AnalysisTypes.FieldBasedTooltip FieldBasedTooltip { get; set; }
        }

        public class TopBottomFilter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveTimeGranularity, IHaveQuickSightAnalysisTypesColumnIdentifierColumn, IHaveFilterId, IHaveLimit, IHaveQuickSightAnalysisTypesDefaultFilterControlConfigurationDefaultFilterControlConfiguration
        {
            /// <summary>
            /// AggregationSortConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-aggregationsortconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AggregationSortConfiguration
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.AggregationSortConfiguration> AggregationSortConfigurations { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }
            /// <summary>
            /// FilterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottomfilter.html#cfn-quicksight-analysis-topbottomfilter-filterid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterId { get; set; }
        }

        public class TopBottomMoversComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldTime, IHaveSortOrder, IHaveQuickSightAnalysisTypesDimensionFieldCategory, IHaveMoverSize
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
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Category { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-topbottommoverscomputation.html#cfn-quicksight-analysis-topbottommoverscomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Time { get; set; }
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

        public class TopBottomRankedComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue, IHaveQuickSightAnalysisTypesDimensionFieldCategory, IHaveResultSize
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
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Category { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
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

        public class TotalAggregationComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesMeasureFieldValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationcomputation.html#cfn-quicksight-analysis-totalaggregationcomputation-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MeasureField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.MeasureField Value { get; set; }
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

        public class TotalAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSimpleTotalAggregationFunction
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

        public class TotalAggregationOption : Humidifier.Base.BaseSubResource, IHaveFieldId
        {
            /// <summary>
            /// TotalAggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationoption.html#cfn-quicksight-analysis-totalaggregationoption-totalaggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TotalAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TotalAggregationFunction TotalAggregationFunction { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totalaggregationoption.html#cfn-quicksight-analysis-totalaggregationoption-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class TotalOptions : Humidifier.Base.BaseSubResource, IHaveCustomLabel, IHaveTotalsVisibility, IHavePlacement, IHaveScrollStatus, IHaveQuickSightAnalysisTypesTableCellStyleTotalCellStyle
        {
            /// <summary>
            /// TotalAggregationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-totalaggregationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TotalAggregationOption
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.TotalAggregationOption> TotalAggregationOptions { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TableCellStyle TotalCellStyle { get; set; }
            /// <summary>
            /// TotalsVisibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-totaloptions.html#cfn-quicksight-analysis-totaloptions-totalsvisibility
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapaggregatedfieldwells.html#cfn-quicksight-analysis-treemapaggregatedfieldwells-sizes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Sizes { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapaggregatedfieldwells.html#cfn-quicksight-analysis-treemapaggregatedfieldwells-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Colors { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapaggregatedfieldwells.html#cfn-quicksight-analysis-treemapaggregatedfieldwells-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Groups { get; set; }
        }

        public class TreeMapConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesTooltipOptionsTooltip, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsColorLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TreeMapSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// ColorLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-colorlabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions ColorLabelOptions { get; set; }
            /// <summary>
            /// SizeLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-sizelabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions SizeLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TreeMapFieldWells FieldWells { get; set; }
            /// <summary>
            /// Tooltip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-tooltip
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TooltipOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TooltipOptions Tooltip { get; set; }
            /// <summary>
            /// ColorScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-colorscale
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorScale
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColorScale ColorScale { get; set; }
            /// <summary>
            /// GroupLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapconfiguration.html#cfn-quicksight-analysis-treemapconfiguration-grouplabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions GroupLabelOptions { get; set; }
        }

        public class TreeMapFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreeMapAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapfieldwells.html#cfn-quicksight-analysis-treemapfieldwells-treemapaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TreeMapAggregatedFieldWells TreeMapAggregatedFieldWells { get; set; }
        }

        public class TreeMapSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TreeMapSort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapsortconfiguration.html#cfn-quicksight-analysis-treemapsortconfiguration-treemapsort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> TreeMapSort { get; set; }
            /// <summary>
            /// TreeMapGroupItemsLimitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapsortconfiguration.html#cfn-quicksight-analysis-treemapsortconfiguration-treemapgroupitemslimitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration TreeMapGroupItemsLimitConfiguration { get; set; }
        }

        public class TreeMapVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.TreeMapConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-treemapvisual.html#cfn-quicksight-analysis-treemapvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class TrendArrowOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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

        public class UnaggregatedField : Humidifier.Base.BaseSubResource, IHaveFieldId, IHaveQuickSightAnalysisTypesColumnIdentifierColumn
        {
            /// <summary>
            /// FormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-unaggregatedfield.html#cfn-quicksight-analysis-unaggregatedfield-formatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FormatConfiguration FormatConfiguration { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-unaggregatedfield.html#cfn-quicksight-analysis-unaggregatedfield-column
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ColumnIdentifier
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ColumnIdentifier Column { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-unaggregatedfield.html#cfn-quicksight-analysis-unaggregatedfield-fieldid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
        }

        public class UniqueValuesComputation : Humidifier.Base.BaseSubResource, IHaveName, IHaveComputationId, IHaveQuickSightAnalysisTypesDimensionFieldCategory
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-uniquevaluescomputation.html#cfn-quicksight-analysis-uniquevaluescomputation-category
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionField
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DimensionField Category { get; set; }
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

        public class ValidationStrategy : Humidifier.Base.BaseSubResource, IHaveMode
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

        public class VisibleRangeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PercentRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visiblerangeoptions.html#cfn-quicksight-analysis-visiblerangeoptions-percentrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PercentVisibleRange
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PercentVisibleRange PercentRange { get; set; }
        }

        public class Visual : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunnelChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-funnelchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FunnelChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FunnelChartVisual FunnelChartVisual { get; set; }
            /// <summary>
            /// BoxPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-boxplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BoxPlotVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BoxPlotVisual BoxPlotVisual { get; set; }
            /// <summary>
            /// LayerMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-layermapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LayerMapVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LayerMapVisual LayerMapVisual { get; set; }
            /// <summary>
            /// GeospatialMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-geospatialmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeospatialMapVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GeospatialMapVisual GeospatialMapVisual { get; set; }
            /// <summary>
            /// ScatterPlotVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-scatterplotvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScatterPlotVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ScatterPlotVisual ScatterPlotVisual { get; set; }
            /// <summary>
            /// RadarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-radarchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RadarChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.RadarChartVisual RadarChartVisual { get; set; }
            /// <summary>
            /// ComboChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-combochartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComboChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ComboChartVisual ComboChartVisual { get; set; }
            /// <summary>
            /// WordCloudVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-wordcloudvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WordCloudVisual WordCloudVisual { get; set; }
            /// <summary>
            /// SankeyDiagramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-sankeydiagramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SankeyDiagramVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.SankeyDiagramVisual SankeyDiagramVisual { get; set; }
            /// <summary>
            /// GaugeChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-gaugechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GaugeChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.GaugeChartVisual GaugeChartVisual { get; set; }
            /// <summary>
            /// FilledMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-filledmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilledMapVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.FilledMapVisual FilledMapVisual { get; set; }
            /// <summary>
            /// WaterfallVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-waterfallvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallVisual WaterfallVisual { get; set; }
            /// <summary>
            /// CustomContentVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-customcontentvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomContentVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomContentVisual CustomContentVisual { get; set; }
            /// <summary>
            /// PieChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-piechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PieChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PieChartVisual PieChartVisual { get; set; }
            /// <summary>
            /// KPIVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-kpivisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KPIVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.KPIVisual KPIVisual { get; set; }
            /// <summary>
            /// HistogramVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-histogramvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistogramVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HistogramVisual HistogramVisual { get; set; }
            /// <summary>
            /// PluginVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-pluginvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PluginVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PluginVisual PluginVisual { get; set; }
            /// <summary>
            /// TableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-tablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TableVisual TableVisual { get; set; }
            /// <summary>
            /// PivotTableVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-pivottablevisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotTableVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.PivotTableVisual PivotTableVisual { get; set; }
            /// <summary>
            /// BarChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-barchartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BarChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.BarChartVisual BarChartVisual { get; set; }
            /// <summary>
            /// HeatMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-heatmapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeatMapVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.HeatMapVisual HeatMapVisual { get; set; }
            /// <summary>
            /// TreeMapVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-treemapvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TreeMapVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.TreeMapVisual TreeMapVisual { get; set; }
            /// <summary>
            /// InsightVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-insightvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InsightVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.InsightVisual InsightVisual { get; set; }
            /// <summary>
            /// LineChartVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-linechartvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineChartVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LineChartVisual LineChartVisual { get; set; }
            /// <summary>
            /// EmptyVisual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visual.html#cfn-quicksight-analysis-visual-emptyvisual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyVisual
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.EmptyVisual EmptyVisual { get; set; }
        }

        public class VisualCustomAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus, IHaveTrigger, IHaveCustomActionId
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
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomActionOperation> ActionOperations { get; set; }
        }

        public class VisualCustomActionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NavigationOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-navigationoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionNavigationOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionNavigationOperation NavigationOperation { get; set; }
            /// <summary>
            /// SetParametersOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-setparametersoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionSetParametersOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionSetParametersOperation SetParametersOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionFilterOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionFilterOperation FilterOperation { get; set; }
            /// <summary>
            /// URLOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-visualcustomactionoperation.html#cfn-quicksight-analysis-visualcustomactionoperation-urloperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomActionURLOperation
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.CustomActionURLOperation URLOperation { get; set; }
        }

        public class VisualPalette : Humidifier.Base.BaseSubResource, IHaveChartColor
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
            public List<Humidifier.QuickSight.AnalysisTypes.DataPathColor> ColorMap { get; set; }
        }

        public class VisualSubtitleLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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
            public Humidifier.QuickSight.AnalysisTypes.LongFormatText FormatText { get; set; }
        }

        public class VisualTitleLabelOptions : Humidifier.Base.BaseSubResource, IHaveVisibility
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
            public Humidifier.QuickSight.AnalysisTypes.ShortFormatText FormatText { get; set; }
        }

        public class WaterfallChartAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Categories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartaggregatedfieldwells.html#cfn-quicksight-analysis-waterfallchartaggregatedfieldwells-categories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Categories { get; set; }
            /// <summary>
            /// Breakdowns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartaggregatedfieldwells.html#cfn-quicksight-analysis-waterfallchartaggregatedfieldwells-breakdowns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> Breakdowns { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartaggregatedfieldwells.html#cfn-quicksight-analysis-waterfallchartaggregatedfieldwells-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Values { get; set; }
        }

        public class WaterfallChartColorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartcolorconfiguration.html#cfn-quicksight-analysis-waterfallchartcolorconfiguration-groupcolorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartGroupColorConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartGroupColorConfiguration GroupColorConfiguration { get; set; }
        }

        public class WaterfallChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesLegendOptionsLegend, IHaveQuickSightAnalysisTypesVisualPaletteVisualPalette, IHaveQuickSightAnalysisTypesDataLabelOptionsDataLabels, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsPrimaryYAxisLabelOptions, IHaveQuickSightAnalysisTypesAxisDisplayOptionsPrimaryYAxisDisplayOptions
        {
            /// <summary>
            /// CategoryAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-categoryaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryAxisLabelOptions { get; set; }
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// Legend
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-legend
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LegendOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.LegendOptions Legend { get; set; }
            /// <summary>
            /// DataLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-datalabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.DataLabelOptions DataLabels { get; set; }
            /// <summary>
            /// PrimaryYAxisLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-primaryyaxislabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartFieldWells FieldWells { get; set; }
            /// <summary>
            /// WaterfallChartOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-waterfallchartoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartOptions WaterfallChartOptions { get; set; }
            /// <summary>
            /// ColorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-colorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartColorConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartColorConfiguration ColorConfiguration { get; set; }
            /// <summary>
            /// CategoryAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-categoryaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions CategoryAxisDisplayOptions { get; set; }
            /// <summary>
            /// PrimaryYAxisDisplayOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-primaryyaxisdisplayoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AxisDisplayOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }
            /// <summary>
            /// VisualPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartconfiguration.html#cfn-quicksight-analysis-waterfallchartconfiguration-visualpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualPalette
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualPalette VisualPalette { get; set; }
        }

        public class WaterfallChartFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WaterfallChartAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartfieldwells.html#cfn-quicksight-analysis-waterfallchartfieldwells-waterfallchartaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaterfallChartAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartAggregatedFieldWells WaterfallChartAggregatedFieldWells { get; set; }
        }

        public class WaterfallChartGroupColorConfiguration : Humidifier.Base.BaseSubResource, IHaveNegativeBarColor, IHaveTotalBarColor, IHavePositiveBarColor
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

        public class WaterfallChartOptions : Humidifier.Base.BaseSubResource, IHaveTotalBarLabel
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

        public class WaterfallChartSortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BreakdownItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartsortconfiguration.html#cfn-quicksight-analysis-waterfallchartsortconfiguration-breakdownitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration BreakdownItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallchartsortconfiguration.html#cfn-quicksight-analysis-waterfallchartsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class WaterfallVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.WaterfallChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-waterfallvisual.html#cfn-quicksight-analysis-waterfallvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class WhatIfPointScenario : Humidifier.Base.BaseSubResource, IHaveValue, IHaveDate
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

        public class WhatIfRangeScenario : Humidifier.Base.BaseSubResource, IHaveValue, IHaveEndDate, IHaveStartDate
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

        public class WordCloudAggregatedFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudaggregatedfieldwells.html#cfn-quicksight-analysis-wordcloudaggregatedfieldwells-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.DimensionField> GroupBy { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudaggregatedfieldwells.html#cfn-quicksight-analysis-wordcloudaggregatedfieldwells-size
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MeasureField
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.MeasureField> Size { get; set; }
        }

        public class WordCloudChartConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesChartAxisLabelOptionsCategoryLabelOptions
        {
            /// <summary>
            /// SortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-sortconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudSortConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WordCloudSortConfiguration SortConfiguration { get; set; }
            /// <summary>
            /// CategoryLabelOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-categorylabeloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChartAxisLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ChartAxisLabelOptions CategoryLabelOptions { get; set; }
            /// <summary>
            /// FieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-fieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WordCloudFieldWells FieldWells { get; set; }
            /// <summary>
            /// WordCloudOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudchartconfiguration.html#cfn-quicksight-analysis-wordcloudchartconfiguration-wordcloudoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WordCloudOptions WordCloudOptions { get; set; }
        }

        public class WordCloudFieldWells : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WordCloudAggregatedFieldWells
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudfieldwells.html#cfn-quicksight-analysis-wordcloudfieldwells-wordcloudaggregatedfieldwells
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WordCloudAggregatedFieldWells
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.WordCloudAggregatedFieldWells WordCloudAggregatedFieldWells { get; set; }
        }

        public class WordCloudOptions : Humidifier.Base.BaseSubResource, IHaveWordOrientation, IHaveWordScaling, IHaveCloudLayout, IHaveMaximumStringLength, IHaveWordCasing, IHaveWordPadding
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

        public class WordCloudSortConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightAnalysisTypesItemsLimitConfigurationCategoryItemsLimit
        {
            /// <summary>
            /// CategoryItemsLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudsortconfiguration.html#cfn-quicksight-analysis-wordcloudsortconfiguration-categoryitemslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ItemsLimitConfiguration
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.ItemsLimitConfiguration CategoryItemsLimit { get; set; }
            /// <summary>
            /// CategorySort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudsortconfiguration.html#cfn-quicksight-analysis-wordcloudsortconfiguration-categorysort
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldSortOptions
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.FieldSortOptions> CategorySort { get; set; }
        }

        public class WordCloudVisual : Humidifier.Base.BaseSubResource, IHaveVisualId, IHaveQuickSightAnalysisTypesVisualSubtitleLabelOptionsSubtitle, IHaveQuickSightAnalysisTypesVisualTitleLabelOptionsTitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualSubtitleLabelOptions Subtitle { get; set; }
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
            public Humidifier.QuickSight.AnalysisTypes.WordCloudChartConfiguration ChartConfiguration { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VisualCustomAction
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.VisualCustomAction> Actions { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleLabelOptions
            /// </summary>
            public Humidifier.QuickSight.AnalysisTypes.VisualTitleLabelOptions Title { get; set; }
            /// <summary>
            /// VisualContentAltText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-visualcontentalttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualContentAltText { get; set; }
            /// <summary>
            /// ColumnHierarchies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-wordcloudvisual.html#cfn-quicksight-analysis-wordcloudvisual-columnhierarchies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnHierarchy
            /// </summary>
            public List<Humidifier.QuickSight.AnalysisTypes.ColumnHierarchy> ColumnHierarchies { get; set; }
        }

        public class YAxisOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// YAxis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-yaxisoptions.html#cfn-quicksight-analysis-yaxisoptions-yaxis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic YAxis { get; set; }
        }
    }
}