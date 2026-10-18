namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using DataSetTypes;

    public class DataSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMapOfQuickSightDataSetTypesPhysicalTablePhysicalTableMap, IHaveMapOfQuickSightDataSetTypesFieldFolderFieldFolders, IHaveQuickSightDataSetTypesSemanticModelConfigurationSemanticModelConfiguration, IHaveStringListOfFolderArns, IHaveDataSetId, IHaveQuickSightDataSetTypesPerformanceConfigurationPerformanceConfiguration, IHaveQuickSightDataSetTypesIngestionWaitPolicyIngestionWaitPolicy, IHaveQuickSightDataSetTypesDataSetRefreshPropertiesDataSetRefreshProperties, IHaveListOfQuickSightDataSetTypesColumnLevelPermissionRuleColumnLevelPermissionRules, IHaveName, IHaveListOfQuickSightDataSetTypesColumnGroupColumnGroups, IHaveImportMode, IHaveListOfQuickSightDataSetTypesDatasetParameterDatasetParameters, IHaveListOfQuickSightDataSetTypesResourcePermissionPermissions, IHaveAwsAccountId, IHaveQuickSightDataSetTypesDataSetUsageConfigurationDataSetUsageConfiguration, IHaveUseAs, IHaveQuickSightDataSetTypesDataPrepConfigurationDataPrepConfiguration
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string OutputColumns =  "OutputColumns" ;
            public static string ConsumedSpiceCapacityInBytes =  "ConsumedSpiceCapacityInBytes" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.DataSet; }
        /// <summary>
        /// PhysicalTableMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-physicaltablemap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: PhysicalTable
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.DataSetTypes.PhysicalTable>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.DataSetTypes.PhysicalTable, BaseFunction>>, BaseFunction>? PhysicalTableMap { get; set; }
        /// <summary>
        /// FieldFolders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-fieldfolders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: FieldFolder
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.DataSetTypes.FieldFolder>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.DataSetTypes.FieldFolder, BaseFunction>>, BaseFunction>? FieldFolders { get; set; }
        /// <summary>
        /// SemanticModelConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-semanticmodelconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SemanticModelConfiguration
        /// </summary>
        public Union<Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration, BaseFunction>? SemanticModelConfiguration { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-folderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FolderArns { get; set; }
        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataSetId { get; set; }
        /// <summary>
        /// PerformanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-performanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PerformanceConfiguration
        /// </summary>
        public Union<Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration, BaseFunction>? PerformanceConfiguration { get; set; }
        /// <summary>
        /// IngestionWaitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IngestionWaitPolicy
        /// </summary>
        public Union<Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy, BaseFunction>? IngestionWaitPolicy { get; set; }
        /// <summary>
        /// DataSetRefreshProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetrefreshproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSetRefreshProperties
        /// </summary>
        public Union<Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties, BaseFunction>? DataSetRefreshProperties { get; set; }
        /// <summary>
        /// ColumnLevelPermissionRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columnlevelpermissionrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ColumnLevelPermissionRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule, BaseFunction>>, BaseFunction>? ColumnLevelPermissionRules { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ColumnGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columngroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ColumnGroup
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.ColumnGroup>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.ColumnGroup, BaseFunction>>, BaseFunction>? ColumnGroups { get; set; }
        /// <summary>
        /// ImportMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-importmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImportMode { get; set; }
        /// <summary>
        /// DatasetParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatasetParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.DatasetParameter>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.DatasetParameter, BaseFunction>>, BaseFunction>? DatasetParameters { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// DataSetUsageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetusageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSetUsageConfiguration
        /// </summary>
        public Union<Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration, BaseFunction>? DataSetUsageConfiguration { get; set; }
        /// <summary>
        /// UseAs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-useas
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UseAs { get; set; }
        /// <summary>
        /// DataPrepConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-dataprepconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataPrepConfiguration
        /// </summary>
        public Union<Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration, BaseFunction>? DataPrepConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataSetTypes
    {
        public class AdditionalNotes : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-additionalnotes.html#cfn-quicksight-dataset-additionalnotes-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class AggregateOperation : Humidifier.Base.BaseSubResource, IHaveStringListOfGroupByColumnNames, IHaveAlias, IHaveListOfQuickSightDataSetTypesAggregationAggregations, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// GroupByColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-groupbycolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GroupByColumnNames { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// Aggregations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-aggregations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Aggregation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.Aggregation>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.Aggregation, BaseFunction>>, BaseFunction>? Aggregations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class Aggregation : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesDataPrepAggregationFunctionAggregationFunction, IHaveNewColumnName, IHaveNewColumnId
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregation.html#cfn-quicksight-dataset-aggregation-aggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPrepAggregationFunction
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataPrepAggregationFunction, BaseFunction>? AggregationFunction { get; set; }
            /// <summary>
            /// NewColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregation.html#cfn-quicksight-dataset-aggregation-newcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnName { get; set; }
            /// <summary>
            /// NewColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregation.html#cfn-quicksight-dataset-aggregation-newcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnId { get; set; }
        }

        public class AppendOperation : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesAppendedColumnAppendedColumns, IHaveQuickSightDataSetTypesTransformOperationSourceSecondSource, IHaveAlias, IHaveQuickSightDataSetTypesTransformOperationSourceFirstSource
        {
            /// <summary>
            /// AppendedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-appendedcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AppendedColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.AppendedColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.AppendedColumn, BaseFunction>>, BaseFunction>? AppendedColumns { get; set; }
            /// <summary>
            /// SecondSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-secondsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? SecondSource { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// FirstSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-firstsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? FirstSource { get; set; }
        }

        public class AppendedColumn : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveNewColumnId
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendedcolumn.html#cfn-quicksight-dataset-appendedcolumn-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// NewColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendedcolumn.html#cfn-quicksight-dataset-appendedcolumn-newcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnId { get; set; }
        }

        public class CalculatedColumn : Humidifier.Base.BaseSubResource, IHaveColumnId, IHaveColumnName, IHaveExpression
        {
            /// <summary>
            /// ColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html#cfn-quicksight-dataset-calculatedcolumn-columnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnId { get; set; }
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html#cfn-quicksight-dataset-calculatedcolumn-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html#cfn-quicksight-dataset-calculatedcolumn-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class CastColumnTypeOperation : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveSubType, IHaveFormat, IHaveNewColumnType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubType { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// NewColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-newcolumntype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnType { get; set; }
        }

        public class CastColumnTypesOperation : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesCastColumnTypeOperationCastColumnTypeOperations, IHaveAlias, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// CastColumnTypeOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypesoperation.html#cfn-quicksight-dataset-castcolumntypesoperation-castcolumntypeoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CastColumnTypeOperation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.CastColumnTypeOperation>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.CastColumnTypeOperation, BaseFunction>>, BaseFunction>? CastColumnTypeOperations { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypesoperation.html#cfn-quicksight-dataset-castcolumntypesoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypesoperation.html#cfn-quicksight-dataset-castcolumntypesoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class ColumnDescription : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columndescription.html#cfn-quicksight-dataset-columndescription-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class ColumnGroup : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesGeoSpatialColumnGroupGeoSpatialColumnGroup
        {
            /// <summary>
            /// GeoSpatialColumnGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columngroup.html#cfn-quicksight-dataset-columngroup-geospatialcolumngroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoSpatialColumnGroup
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup, BaseFunction>? GeoSpatialColumnGroup { get; set; }
        }

        public class ColumnLevelPermissionRule : Humidifier.Base.BaseSubResource, IHaveStringListOfColumnNames, IHaveStringListOfPrincipals
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnlevelpermissionrule.html#cfn-quicksight-dataset-columnlevelpermissionrule-columnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
            /// <summary>
            /// Principals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnlevelpermissionrule.html#cfn-quicksight-dataset-columnlevelpermissionrule-principals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Principals { get; set; }
        }

        public class ColumnSemanticProperty : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesColumnSemanticTypeSemanticType, IHaveQuickSightDataSetTypesColumnDescriptionDescription, IHaveQuickSightDataSetTypesAdditionalNotesAdditionalNotes
        {
            /// <summary>
            /// SemanticType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemanticproperty.html#cfn-quicksight-dataset-columnsemanticproperty-semantictype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSemanticType
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ColumnSemanticType, BaseFunction>? SemanticType { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemanticproperty.html#cfn-quicksight-dataset-columnsemanticproperty-description
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnDescription
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ColumnDescription, BaseFunction>? Description { get; set; }
            /// <summary>
            /// AdditionalNotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemanticproperty.html#cfn-quicksight-dataset-columnsemanticproperty-additionalnotes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdditionalNotes
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.AdditionalNotes, BaseFunction>? AdditionalNotes { get; set; }
        }

        public class ColumnSemanticType : Humidifier.Base.BaseSubResource, IHaveGeographicalRole
        {
            /// <summary>
            /// GeographicalRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemantictype.html#cfn-quicksight-dataset-columnsemantictype-geographicalrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeographicalRole { get; set; }
        }

        public class ColumnToUnpivot : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveNewValue
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntounpivot.html#cfn-quicksight-dataset-columntounpivot-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// NewValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntounpivot.html#cfn-quicksight-dataset-columntounpivot-newvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewValue { get; set; }
        }

        public class CreateColumnsOperation : Humidifier.Base.BaseSubResource, IHaveAlias, IHaveListOfQuickSightDataSetTypesCalculatedColumnColumns, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.CalculatedColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.CalculatedColumn, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class CustomInstruction : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesInlineCustomInstructionInlineCustomInstruction
        {
            /// <summary>
            /// InlineCustomInstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-custominstruction.html#cfn-quicksight-dataset-custominstruction-inlinecustominstruction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InlineCustomInstruction
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.InlineCustomInstruction, BaseFunction>? InlineCustomInstruction { get; set; }
        }

        public class CustomSql : Humidifier.Base.BaseSubResource, IHaveDataSourceArn, IHaveSqlQuery, IHaveListOfQuickSightDataSetTypesInputColumnColumns, IHaveName
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceArn { get; set; }
            /// <summary>
            /// SqlQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-sqlquery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SqlQuery { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.InputColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.InputColumn, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DataPrepAggregationFunction : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesDataPrepPercentileAggregationFunctionPercentileAggregation, IHaveQuickSightDataSetTypesDataPrepListAggregationFunctionListAggregation, IHaveQuickSightDataSetTypesDataPrepSimpleAggregationFunctionSimpleAggregation
        {
            /// <summary>
            /// PercentileAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepaggregationfunction.html#cfn-quicksight-dataset-dataprepaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepPercentileAggregationFunction
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataPrepPercentileAggregationFunction, BaseFunction>? PercentileAggregation { get; set; }
            /// <summary>
            /// ListAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepaggregationfunction.html#cfn-quicksight-dataset-dataprepaggregationfunction-listaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepListAggregationFunction
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataPrepListAggregationFunction, BaseFunction>? ListAggregation { get; set; }
            /// <summary>
            /// SimpleAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepaggregationfunction.html#cfn-quicksight-dataset-dataprepaggregationfunction-simpleaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepSimpleAggregationFunction
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataPrepSimpleAggregationFunction, BaseFunction>? SimpleAggregation { get; set; }
        }

        public class DataPrepConfiguration : Humidifier.Base.BaseSubResource, IHaveMapOfQuickSightDataSetTypesDestinationTableDestinationTableMap, IHaveMapOfQuickSightDataSetTypesTransformStepTransformStepMap, IHaveMapOfQuickSightDataSetTypesSourceTableSourceTableMap
        {
            /// <summary>
            /// DestinationTableMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepconfiguration.html#cfn-quicksight-dataset-dataprepconfiguration-destinationtablemap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: DestinationTable
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.DataSetTypes.DestinationTable>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.DataSetTypes.DestinationTable, BaseFunction>>, BaseFunction>? DestinationTableMap { get; set; }
            /// <summary>
            /// TransformStepMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepconfiguration.html#cfn-quicksight-dataset-dataprepconfiguration-transformstepmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: TransformStep
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.DataSetTypes.TransformStep>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.DataSetTypes.TransformStep, BaseFunction>>, BaseFunction>? TransformStepMap { get; set; }
            /// <summary>
            /// SourceTableMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepconfiguration.html#cfn-quicksight-dataset-dataprepconfiguration-sourcetablemap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SourceTable
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.DataSetTypes.SourceTable>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.DataSetTypes.SourceTable, BaseFunction>>, BaseFunction>? SourceTableMap { get; set; }
        }

        public class DataPrepListAggregationFunction : Humidifier.Base.BaseSubResource, IHaveDistinct_Boolean, IHaveInputColumnName, IHaveSeparator
        {
            /// <summary>
            /// Distinct
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreplistaggregationfunction.html#cfn-quicksight-dataset-datapreplistaggregationfunction-distinct
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Distinct { get; set; }
            /// <summary>
            /// InputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreplistaggregationfunction.html#cfn-quicksight-dataset-datapreplistaggregationfunction-inputcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputColumnName { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreplistaggregationfunction.html#cfn-quicksight-dataset-datapreplistaggregationfunction-separator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Separator { get; set; }
        }

        public class DataPrepPercentileAggregationFunction : Humidifier.Base.BaseSubResource, IHaveInputColumnName, IHavePercentileValue_Double
        {
            /// <summary>
            /// InputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreppercentileaggregationfunction.html#cfn-quicksight-dataset-datapreppercentileaggregationfunction-inputcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputColumnName { get; set; }
            /// <summary>
            /// PercentileValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreppercentileaggregationfunction.html#cfn-quicksight-dataset-datapreppercentileaggregationfunction-percentilevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PercentileValue { get; set; }
        }

        public class DataPrepSimpleAggregationFunction : Humidifier.Base.BaseSubResource, IHaveFunctionType, IHaveInputColumnName
        {
            /// <summary>
            /// FunctionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepsimpleaggregationfunction.html#cfn-quicksight-dataset-dataprepsimpleaggregationfunction-functiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionType { get; set; }
            /// <summary>
            /// InputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepsimpleaggregationfunction.html#cfn-quicksight-dataset-dataprepsimpleaggregationfunction-inputcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputColumnName { get; set; }
        }

        public class DataSetColumnIdMapping : Humidifier.Base.BaseSubResource, IHaveSourceColumnId, IHaveTargetColumnId
        {
            /// <summary>
            /// SourceColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetcolumnidmapping.html#cfn-quicksight-dataset-datasetcolumnidmapping-sourcecolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumnId { get; set; }
            /// <summary>
            /// TargetColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetcolumnidmapping.html#cfn-quicksight-dataset-datasetcolumnidmapping-targetcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetColumnId { get; set; }
        }

        public class DataSetDateComparisonFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveQuickSightDataSetTypesDataSetDateFilterValueValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatecomparisonfiltercondition.html#cfn-quicksight-dataset-datasetdatecomparisonfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatecomparisonfiltercondition.html#cfn-quicksight-dataset-datasetdatecomparisonfiltercondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetDateFilterValue, BaseFunction>? Value { get; set; }
        }

        public class DataSetDateFilterCondition : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveQuickSightDataSetTypesDataSetDateRangeFilterConditionRangeFilterCondition, IHaveQuickSightDataSetTypesDataSetDateComparisonFilterConditionComparisonFilterCondition
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltercondition.html#cfn-quicksight-dataset-datasetdatefiltercondition-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// RangeFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltercondition.html#cfn-quicksight-dataset-datasetdatefiltercondition-rangefiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateRangeFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetDateRangeFilterCondition, BaseFunction>? RangeFilterCondition { get; set; }
            /// <summary>
            /// ComparisonFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltercondition.html#cfn-quicksight-dataset-datasetdatefiltercondition-comparisonfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateComparisonFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetDateComparisonFilterCondition, BaseFunction>? ComparisonFilterCondition { get; set; }
        }

        public class DataSetDateFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue
        {
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltervalue.html#cfn-quicksight-dataset-datasetdatefiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StaticValue { get; set; }
        }

        public class DataSetDateRangeFilterCondition : Humidifier.Base.BaseSubResource, IHaveIncludeMaximum_Boolean, IHaveQuickSightDataSetTypesDataSetDateFilterValueRangeMinimum, IHaveQuickSightDataSetTypesDataSetDateFilterValueRangeMaximum, IHaveIncludeMinimum_Boolean
        {
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetDateFilterValue, BaseFunction>? RangeMinimum { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetDateFilterValue, BaseFunction>? RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeMinimum { get; set; }
        }

        public class DataSetNumericComparisonFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveQuickSightDataSetTypesDataSetNumericFilterValueValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetnumericcomparisonfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetnumericcomparisonfiltercondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterValue, BaseFunction>? Value { get; set; }
        }

        public class DataSetNumericFilterCondition : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveQuickSightDataSetTypesDataSetNumericRangeFilterConditionRangeFilterCondition, IHaveQuickSightDataSetTypesDataSetNumericComparisonFilterConditionComparisonFilterCondition
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltercondition.html#cfn-quicksight-dataset-datasetnumericfiltercondition-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// RangeFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltercondition.html#cfn-quicksight-dataset-datasetnumericfiltercondition-rangefiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericRangeFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetNumericRangeFilterCondition, BaseFunction>? RangeFilterCondition { get; set; }
            /// <summary>
            /// ComparisonFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltercondition.html#cfn-quicksight-dataset-datasetnumericfiltercondition-comparisonfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericComparisonFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetNumericComparisonFilterCondition, BaseFunction>? ComparisonFilterCondition { get; set; }
        }

        public class DataSetNumericFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue_Double
        {
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltervalue.html#cfn-quicksight-dataset-datasetnumericfiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StaticValue { get; set; }
        }

        public class DataSetNumericRangeFilterCondition : Humidifier.Base.BaseSubResource, IHaveIncludeMaximum_Boolean, IHaveQuickSightDataSetTypesDataSetNumericFilterValueRangeMinimum, IHaveQuickSightDataSetTypesDataSetNumericFilterValueRangeMaximum, IHaveIncludeMinimum_Boolean
        {
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterValue, BaseFunction>? RangeMinimum { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterValue, BaseFunction>? RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeMinimum { get; set; }
        }

        public class DataSetRefreshProperties : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesRefreshConfigurationRefreshConfiguration, IHaveQuickSightDataSetTypesRefreshFailureConfigurationFailureConfiguration
        {
            /// <summary>
            /// RefreshConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetrefreshproperties.html#cfn-quicksight-dataset-datasetrefreshproperties-refreshconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration, BaseFunction>? RefreshConfiguration { get; set; }
            /// <summary>
            /// FailureConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetrefreshproperties.html#cfn-quicksight-dataset-datasetrefreshproperties-failureconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshFailureConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration, BaseFunction>? FailureConfiguration { get; set; }
        }

        public class DataSetSemanticDescription : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetsemanticdescription.html#cfn-quicksight-dataset-datasetsemanticdescription-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class DataSetSemanticMetadata : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesCustomInstructionCustomInstructions, IHaveQuickSightDataSetTypesDataSetSemanticDescriptionDescription
        {
            /// <summary>
            /// CustomInstructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetsemanticmetadata.html#cfn-quicksight-dataset-datasetsemanticmetadata-custominstructions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomInstruction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.CustomInstruction>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.CustomInstruction, BaseFunction>>, BaseFunction>? CustomInstructions { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetsemanticmetadata.html#cfn-quicksight-dataset-datasetsemanticmetadata-description
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetSemanticDescription
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetSemanticDescription, BaseFunction>? Description { get; set; }
        }

        public class DataSetStringComparisonFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveQuickSightDataSetTypesDataSetStringFilterValueValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetstringcomparisonfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetstringcomparisonfiltercondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetStringFilterValue, BaseFunction>? Value { get; set; }
        }

        public class DataSetStringFilterCondition : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveQuickSightDataSetTypesDataSetStringComparisonFilterConditionComparisonFilterCondition, IHaveQuickSightDataSetTypesDataSetStringListFilterConditionListFilterCondition
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltercondition.html#cfn-quicksight-dataset-datasetstringfiltercondition-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// ComparisonFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltercondition.html#cfn-quicksight-dataset-datasetstringfiltercondition-comparisonfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringComparisonFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetStringComparisonFilterCondition, BaseFunction>? ComparisonFilterCondition { get; set; }
            /// <summary>
            /// ListFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltercondition.html#cfn-quicksight-dataset-datasetstringfiltercondition-listfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringListFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetStringListFilterCondition, BaseFunction>? ListFilterCondition { get; set; }
        }

        public class DataSetStringFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue
        {
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltervalue.html#cfn-quicksight-dataset-datasetstringfiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StaticValue { get; set; }
        }

        public class DataSetStringListFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveQuickSightDataSetTypesDataSetStringListFilterValueValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringlistfiltercondition.html#cfn-quicksight-dataset-datasetstringlistfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringlistfiltercondition.html#cfn-quicksight-dataset-datasetstringlistfiltercondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringListFilterValue
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetStringListFilterValue, BaseFunction>? Values { get; set; }
        }

        public class DataSetStringListFilterValue : Humidifier.Base.BaseSubResource, IHaveStringListOfStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringlistfiltervalue.html#cfn-quicksight-dataset-datasetstringlistfiltervalue-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StaticValues { get; set; }
        }

        public class DataSetUsageConfiguration : Humidifier.Base.BaseSubResource, IHaveDisableUseAsImportedSource_Boolean, IHaveDisableUseAsDirectQuerySource_Boolean
        {
            /// <summary>
            /// DisableUseAsImportedSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetusageconfiguration.html#cfn-quicksight-dataset-datasetusageconfiguration-disableuseasimportedsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableUseAsImportedSource { get; set; }
            /// <summary>
            /// DisableUseAsDirectQuerySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetusageconfiguration.html#cfn-quicksight-dataset-datasetusageconfiguration-disableuseasdirectquerysource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableUseAsDirectQuerySource { get; set; }
        }

        public class DatasetParameter : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesIntegerDatasetParameterIntegerDatasetParameter, IHaveQuickSightDataSetTypesDateTimeDatasetParameterDateTimeDatasetParameter, IHaveQuickSightDataSetTypesDecimalDatasetParameterDecimalDatasetParameter, IHaveQuickSightDataSetTypesStringDatasetParameterStringDatasetParameter
        {
            /// <summary>
            /// IntegerDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-integerdatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDatasetParameter
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter, BaseFunction>? IntegerDatasetParameter { get; set; }
            /// <summary>
            /// DateTimeDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-datetimedatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDatasetParameter
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter, BaseFunction>? DateTimeDatasetParameter { get; set; }
            /// <summary>
            /// DecimalDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-decimaldatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDatasetParameter
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter, BaseFunction>? DecimalDatasetParameter { get; set; }
            /// <summary>
            /// StringDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-stringdatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDatasetParameter
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.StringDatasetParameter, BaseFunction>? StringDatasetParameter { get; set; }
        }

        public class DateTimeDatasetParameter : Humidifier.Base.BaseSubResource, IHaveValueType, IHaveTimeGranularity, IHaveQuickSightDataSetTypesDateTimeDatasetParameterDefaultValuesDefaultValues, IHaveId, IHaveName
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueType { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeGranularity { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDatasetParameterDefaultValues
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues, BaseFunction>? DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DateTimeDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource, IHaveStringListOfStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameterdefaultvalues.html#cfn-quicksight-dataset-datetimedatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StaticValues { get; set; }
        }

        public class DecimalDatasetParameter : Humidifier.Base.BaseSubResource, IHaveValueType, IHaveQuickSightDataSetTypesDecimalDatasetParameterDefaultValuesDefaultValues, IHaveId, IHaveName
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueType { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDatasetParameterDefaultValues
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues, BaseFunction>? DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DecimalDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource, IHaveDoubleListOfStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameterdefaultvalues.html#cfn-quicksight-dataset-decimaldatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyList<double>, IReadOnlyList<Union<double, BaseFunction>>, BaseFunction>? StaticValues { get; set; }
        }

        public class DestinationTable : Humidifier.Base.BaseSubResource, IHaveAlias, IHaveQuickSightDataSetTypesDestinationTableSourceSource
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-destinationtable.html#cfn-quicksight-dataset-destinationtable-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-destinationtable.html#cfn-quicksight-dataset-destinationtable-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationTableSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DestinationTableSource, BaseFunction>? Source { get; set; }
        }

        public class DestinationTableSource : Humidifier.Base.BaseSubResource, IHaveTransformOperationId
        {
            /// <summary>
            /// TransformOperationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-destinationtablesource.html#cfn-quicksight-dataset-destinationtablesource-transformoperationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransformOperationId { get; set; }
        }

        public class FieldFolder : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveStringListOfColumns
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-fieldfolder.html#cfn-quicksight-dataset-fieldfolder-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-fieldfolder.html#cfn-quicksight-dataset-fieldfolder-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Columns { get; set; }
        }

        public class FilterOperation : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesDataSetDateFilterConditionDateFilterCondition, IHaveQuickSightDataSetTypesDataSetStringFilterConditionStringFilterCondition, IHaveConditionExpression, IHaveQuickSightDataSetTypesDataSetNumericFilterConditionNumericFilterCondition
        {
            /// <summary>
            /// DateFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-datefiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetDateFilterCondition, BaseFunction>? DateFilterCondition { get; set; }
            /// <summary>
            /// StringFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-stringfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetStringFilterCondition, BaseFunction>? StringFilterCondition { get; set; }
            /// <summary>
            /// ConditionExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-conditionexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConditionExpression { get; set; }
            /// <summary>
            /// NumericFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-numericfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterCondition
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterCondition, BaseFunction>? NumericFilterCondition { get; set; }
        }

        public class FiltersOperation : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesFilterOperationFilterOperations, IHaveAlias, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// FilterOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filtersoperation.html#cfn-quicksight-dataset-filtersoperation-filteroperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterOperation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.FilterOperation>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.FilterOperation, BaseFunction>>, BaseFunction>? FilterOperations { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filtersoperation.html#cfn-quicksight-dataset-filtersoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filtersoperation.html#cfn-quicksight-dataset-filtersoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class GeoSpatialColumnGroup : Humidifier.Base.BaseSubResource, IHaveStringListOfColumns, IHaveCountryCode, IHaveName
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html#cfn-quicksight-dataset-geospatialcolumngroup-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html#cfn-quicksight-dataset-geospatialcolumngroup-countrycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CountryCode { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html#cfn-quicksight-dataset-geospatialcolumngroup-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ImportTableOperation : Humidifier.Base.BaseSubResource, IHaveAlias, IHaveQuickSightDataSetTypesImportTableOperationSourceSource
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperation.html#cfn-quicksight-dataset-importtableoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperation.html#cfn-quicksight-dataset-importtableoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ImportTableOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ImportTableOperationSource, BaseFunction>? Source { get; set; }
        }

        public class ImportTableOperationSource : Humidifier.Base.BaseSubResource, IHaveSourceTableId, IHaveListOfQuickSightDataSetTypesDataSetColumnIdMappingColumnIdMappings
        {
            /// <summary>
            /// SourceTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperationsource.html#cfn-quicksight-dataset-importtableoperationsource-sourcetableid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceTableId { get; set; }
            /// <summary>
            /// ColumnIdMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperationsource.html#cfn-quicksight-dataset-importtableoperationsource-columnidmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetColumnIdMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.DataSetColumnIdMapping>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.DataSetColumnIdMapping, BaseFunction>>, BaseFunction>? ColumnIdMappings { get; set; }
        }

        public class IncrementalRefresh : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesLookbackWindowLookbackWindow
        {
            /// <summary>
            /// LookbackWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-incrementalrefresh.html#cfn-quicksight-dataset-incrementalrefresh-lookbackwindow
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LookbackWindow
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.LookbackWindow, BaseFunction>? LookbackWindow { get; set; }
        }

        public class IngestionWaitPolicy : Humidifier.Base.BaseSubResource, IHaveWaitForSpiceIngestion_Boolean, IHaveIngestionWaitTimeInHours_Double
        {
            /// <summary>
            /// WaitForSpiceIngestion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-ingestionwaitpolicy.html#cfn-quicksight-dataset-ingestionwaitpolicy-waitforspiceingestion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WaitForSpiceIngestion { get; set; }
            /// <summary>
            /// IngestionWaitTimeInHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-ingestionwaitpolicy.html#cfn-quicksight-dataset-ingestionwaitpolicy-ingestionwaittimeinhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IngestionWaitTimeInHours { get; set; }
        }

        public class InlineCustomInstruction : Humidifier.Base.BaseSubResource, IHaveInstructionText, IHaveQuickSightDataSetTypesUploadedDocumentMetadataUploadedDocumentMetadata
        {
            /// <summary>
            /// InstructionText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inlinecustominstruction.html#cfn-quicksight-dataset-inlinecustominstruction-instructiontext
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstructionText { get; set; }
            /// <summary>
            /// UploadedDocumentMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inlinecustominstruction.html#cfn-quicksight-dataset-inlinecustominstruction-uploadeddocumentmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UploadedDocumentMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.UploadedDocumentMetadata, BaseFunction>? UploadedDocumentMetadata { get; set; }
        }

        public class InputColumn : Humidifier.Base.BaseSubResource, IHaveType, IHaveSubType, IHaveId, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubType { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IntegerDatasetParameter : Humidifier.Base.BaseSubResource, IHaveValueType, IHaveQuickSightDataSetTypesIntegerDatasetParameterDefaultValuesDefaultValues, IHaveId, IHaveName
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueType { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDatasetParameterDefaultValues
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues, BaseFunction>? DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IntegerDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource, IHaveLongListOfStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameterdefaultvalues.html#cfn-quicksight-dataset-integerdatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Long
            /// </summary>
            public Union<IReadOnlyList<long>, IReadOnlyList<Union<long, BaseFunction>>, BaseFunction>? StaticValues { get; set; }
        }

        public class JoinOperandProperties : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesOutputColumnNameOverrideOutputColumnNameOverrides
        {
            /// <summary>
            /// OutputColumnNameOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperandproperties.html#cfn-quicksight-dataset-joinoperandproperties-outputcolumnnameoverrides
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputColumnNameOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.OutputColumnNameOverride>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.OutputColumnNameOverride, BaseFunction>>, BaseFunction>? OutputColumnNameOverrides { get; set; }
        }

        public class JoinOperation : Humidifier.Base.BaseSubResource, IHaveOnClause, IHaveType, IHaveQuickSightDataSetTypesJoinOperandPropertiesRightOperandProperties, IHaveQuickSightDataSetTypesJoinOperandPropertiesLeftOperandProperties, IHaveAlias, IHaveQuickSightDataSetTypesTransformOperationSourceLeftOperand, IHaveQuickSightDataSetTypesTransformOperationSourceRightOperand
        {
            /// <summary>
            /// OnClause
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-onclause
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnClause { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RightOperandProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-rightoperandproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinOperandProperties
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.JoinOperandProperties, BaseFunction>? RightOperandProperties { get; set; }
            /// <summary>
            /// LeftOperandProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-leftoperandproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinOperandProperties
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.JoinOperandProperties, BaseFunction>? LeftOperandProperties { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// LeftOperand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-leftoperand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? LeftOperand { get; set; }
            /// <summary>
            /// RightOperand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-rightoperand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? RightOperand { get; set; }
        }

        public class LookbackWindow : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveSizeUnit, IHaveSize_Double
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-lookbackwindow.html#cfn-quicksight-dataset-lookbackwindow-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// SizeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-lookbackwindow.html#cfn-quicksight-dataset-lookbackwindow-sizeunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SizeUnit { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-lookbackwindow.html#cfn-quicksight-dataset-lookbackwindow-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Size { get; set; }
        }

        public class OutputColumn : Humidifier.Base.BaseSubResource, IHaveType, IHaveDescription, IHaveSubType, IHaveId, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubType { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OutputColumnNameOverride : Humidifier.Base.BaseSubResource, IHaveOutputColumnName, IHaveSourceColumnName
        {
            /// <summary>
            /// OutputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumnnameoverride.html#cfn-quicksight-dataset-outputcolumnnameoverride-outputcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputColumnName { get; set; }
            /// <summary>
            /// SourceColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumnnameoverride.html#cfn-quicksight-dataset-outputcolumnnameoverride-sourcecolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceColumnName { get; set; }
        }

        public class ParentDataSet : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesInputColumnInputColumns, IHaveDataSetArn
        {
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-parentdataset.html#cfn-quicksight-dataset-parentdataset-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.InputColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.InputColumn, BaseFunction>>, BaseFunction>? InputColumns { get; set; }
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-parentdataset.html#cfn-quicksight-dataset-parentdataset-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSetArn { get; set; }
        }

        public class PerformanceConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesUniqueKeyUniqueKeys
        {
            /// <summary>
            /// UniqueKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-performanceconfiguration.html#cfn-quicksight-dataset-performanceconfiguration-uniquekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UniqueKey
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.UniqueKey>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.UniqueKey, BaseFunction>>, BaseFunction>? UniqueKeys { get; set; }
        }

        public class PhysicalTable : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesSaaSTableSaaSTable, IHaveQuickSightDataSetTypesRelationalTableRelationalTable, IHaveQuickSightDataSetTypesCustomSqlCustomSql, IHaveQuickSightDataSetTypesS3SourceS3Source
        {
            /// <summary>
            /// SaaSTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-saastable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SaaSTable
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.SaaSTable, BaseFunction>? SaaSTable { get; set; }
            /// <summary>
            /// RelationalTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-relationaltable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelationalTable
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RelationalTable, BaseFunction>? RelationalTable { get; set; }
            /// <summary>
            /// CustomSql
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-customsql
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomSql
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.CustomSql, BaseFunction>? CustomSql { get; set; }
            /// <summary>
            /// S3Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-s3source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Source
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.S3Source, BaseFunction>? S3Source { get; set; }
        }

        public class PivotConfiguration : Humidifier.Base.BaseSubResource, IHaveLabelColumnName, IHaveListOfQuickSightDataSetTypesPivotedLabelPivotedLabels
        {
            /// <summary>
            /// LabelColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotconfiguration.html#cfn-quicksight-dataset-pivotconfiguration-labelcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelColumnName { get; set; }
            /// <summary>
            /// PivotedLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotconfiguration.html#cfn-quicksight-dataset-pivotconfiguration-pivotedlabels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotedLabel
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.PivotedLabel>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.PivotedLabel, BaseFunction>>, BaseFunction>? PivotedLabels { get; set; }
        }

        public class PivotOperation : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesPivotConfigurationPivotConfiguration, IHaveStringListOfGroupByColumnNames, IHaveAlias, IHaveQuickSightDataSetTypesValueColumnConfigurationValueColumnConfiguration, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// PivotConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-pivotconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.PivotConfiguration, BaseFunction>? PivotConfiguration { get; set; }
            /// <summary>
            /// GroupByColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-groupbycolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GroupByColumnNames { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// ValueColumnConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-valuecolumnconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ValueColumnConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ValueColumnConfiguration, BaseFunction>? ValueColumnConfiguration { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class PivotedLabel : Humidifier.Base.BaseSubResource, IHaveNewColumnName, IHaveNewColumnId, IHaveLabelName
        {
            /// <summary>
            /// NewColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotedlabel.html#cfn-quicksight-dataset-pivotedlabel-newcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnName { get; set; }
            /// <summary>
            /// NewColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotedlabel.html#cfn-quicksight-dataset-pivotedlabel-newcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnId { get; set; }
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotedlabel.html#cfn-quicksight-dataset-pivotedlabel-labelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelName { get; set; }
        }

        public class ProjectOperation : Humidifier.Base.BaseSubResource, IHaveAlias, IHaveStringListOfProjectedColumns, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// ProjectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-projectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ProjectedColumns { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class RefreshConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesIncrementalRefreshIncrementalRefresh
        {
            /// <summary>
            /// IncrementalRefresh
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshconfiguration.html#cfn-quicksight-dataset-refreshconfiguration-incrementalrefresh
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IncrementalRefresh
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh, BaseFunction>? IncrementalRefresh { get; set; }
        }

        public class RefreshFailureConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesRefreshFailureEmailAlertEmailAlert
        {
            /// <summary>
            /// EmailAlert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshfailureconfiguration.html#cfn-quicksight-dataset-refreshfailureconfiguration-emailalert
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshFailureEmailAlert
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert, BaseFunction>? EmailAlert { get; set; }
        }

        public class RefreshFailureEmailAlert : Humidifier.Base.BaseSubResource, IHaveAlertStatus
        {
            /// <summary>
            /// AlertStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshfailureemailalert.html#cfn-quicksight-dataset-refreshfailureemailalert-alertstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlertStatus { get; set; }
        }

        public class RelationalTable : Humidifier.Base.BaseSubResource, IHaveDataSourceArn, IHaveListOfQuickSightDataSetTypesInputColumnInputColumns, IHaveSchema, IHaveCatalog, IHaveName
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceArn { get; set; }
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.InputColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.InputColumn, BaseFunction>>, BaseFunction>? InputColumns { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-schema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-catalog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Catalog { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RenameColumnOperation : Humidifier.Base.BaseSubResource, IHaveNewColumnName, IHaveColumnName
        {
            /// <summary>
            /// NewColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnoperation.html#cfn-quicksight-dataset-renamecolumnoperation-newcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewColumnName { get; set; }
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnoperation.html#cfn-quicksight-dataset-renamecolumnoperation-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
        }

        public class RenameColumnsOperation : Humidifier.Base.BaseSubResource, IHaveAlias, IHaveListOfQuickSightDataSetTypesRenameColumnOperationRenameColumnOperations, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnsoperation.html#cfn-quicksight-dataset-renamecolumnsoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// RenameColumnOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnsoperation.html#cfn-quicksight-dataset-renamecolumnsoperation-renamecolumnoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RenameColumnOperation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.RenameColumnOperation>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.RenameColumnOperation, BaseFunction>>, BaseFunction>? RenameColumnOperations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnsoperation.html#cfn-quicksight-dataset-renamecolumnsoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-resourcepermission.html#cfn-quicksight-dataset-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-resourcepermission.html#cfn-quicksight-dataset-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }

        public class RowLevelPermissionConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesRowLevelPermissionTagConfigurationTagConfiguration, IHaveQuickSightDataSetTypesRowLevelPermissionDataSetRowLevelPermissionDataSet
        {
            /// <summary>
            /// TagConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissionconfiguration.html#cfn-quicksight-dataset-rowlevelpermissionconfiguration-tagconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowLevelPermissionTagConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration, BaseFunction>? TagConfiguration { get; set; }
            /// <summary>
            /// RowLevelPermissionDataSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissionconfiguration.html#cfn-quicksight-dataset-rowlevelpermissionconfiguration-rowlevelpermissiondataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowLevelPermissionDataSet
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet, BaseFunction>? RowLevelPermissionDataSet { get; set; }
        }

        public class RowLevelPermissionDataSet : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveFormatVersion, IHaveArn, IHaveNamespace_, IHavePermissionPolicy
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// FormatVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-formatversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FormatVersion { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// PermissionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-permissionpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PermissionPolicy { get; set; }
        }

        public class RowLevelPermissionTagConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveListOfQuickSightDataSetTypesRowLevelPermissionTagRuleTagRules, IHaveTagRuleConfigurations_Json
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// TagRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-tagrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RowLevelPermissionTagRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagRule>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagRule, BaseFunction>>, BaseFunction>? TagRules { get; set; }
            /// <summary>
            /// TagRuleConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-tagruleconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? TagRuleConfigurations { get; set; }
        }

        public class RowLevelPermissionTagRule : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveTagKey, IHaveMatchAllValue, IHaveTagMultiValueDelimiter
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// TagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-tagkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagKey { get; set; }
            /// <summary>
            /// MatchAllValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-matchallvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchAllValue { get; set; }
            /// <summary>
            /// TagMultiValueDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-tagmultivaluedelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagMultiValueDelimiter { get; set; }
        }

        public class S3Source : Humidifier.Base.BaseSubResource, IHaveDataSourceArn, IHaveListOfQuickSightDataSetTypesInputColumnInputColumns, IHaveQuickSightDataSetTypesUploadSettingsUploadSettings
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceArn { get; set; }
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.InputColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.InputColumn, BaseFunction>>, BaseFunction>? InputColumns { get; set; }
            /// <summary>
            /// UploadSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-uploadsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UploadSettings
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.UploadSettings, BaseFunction>? UploadSettings { get; set; }
        }

        public class SaaSTable : Humidifier.Base.BaseSubResource, IHaveDataSourceArn, IHaveListOfQuickSightDataSetTypesInputColumnInputColumns, IHaveListOfQuickSightDataSetTypesTablePathElementTablePath
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-saastable.html#cfn-quicksight-dataset-saastable-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceArn { get; set; }
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-saastable.html#cfn-quicksight-dataset-saastable-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.InputColumn>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.InputColumn, BaseFunction>>, BaseFunction>? InputColumns { get; set; }
            /// <summary>
            /// TablePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-saastable.html#cfn-quicksight-dataset-saastable-tablepath
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TablePathElement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.TablePathElement>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.TablePathElement, BaseFunction>>, BaseFunction>? TablePath { get; set; }
        }

        public class SemanticModelConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesDataSetSemanticMetadataSemanticMetadata, IHaveMapOfQuickSightDataSetTypesSemanticTableTableMap
        {
            /// <summary>
            /// SemanticMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semanticmodelconfiguration.html#cfn-quicksight-dataset-semanticmodelconfiguration-semanticmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetSemanticMetadata
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.DataSetSemanticMetadata>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.DataSetSemanticMetadata, BaseFunction>>, BaseFunction>? SemanticMetadata { get; set; }
            /// <summary>
            /// TableMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semanticmodelconfiguration.html#cfn-quicksight-dataset-semanticmodelconfiguration-tablemap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SemanticTable
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.DataSetTypes.SemanticTable>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.DataSetTypes.SemanticTable, BaseFunction>>, BaseFunction>? TableMap { get; set; }
        }

        public class SemanticTable : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesTableSemanticMetadataSemanticMetadata, IHaveAlias, IHaveDestinationTableId, IHaveQuickSightDataSetTypesRowLevelPermissionConfigurationRowLevelPermissionConfiguration
        {
            /// <summary>
            /// SemanticMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-semanticmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSemanticMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TableSemanticMetadata, BaseFunction>? SemanticMetadata { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// DestinationTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-destinationtableid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationTableId { get; set; }
            /// <summary>
            /// RowLevelPermissionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-rowlevelpermissionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowLevelPermissionConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionConfiguration, BaseFunction>? RowLevelPermissionConfiguration { get; set; }
        }

        public class SharedColumnSemanticMetadata : Humidifier.Base.BaseSubResource, IHaveStringListOfColumnNames, IHaveListOfQuickSightDataSetTypesColumnSemanticPropertyColumnProperties
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sharedcolumnsemanticmetadata.html#cfn-quicksight-dataset-sharedcolumnsemanticmetadata-columnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
            /// <summary>
            /// ColumnProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sharedcolumnsemanticmetadata.html#cfn-quicksight-dataset-sharedcolumnsemanticmetadata-columnproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSemanticProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.ColumnSemanticProperty>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.ColumnSemanticProperty, BaseFunction>>, BaseFunction>? ColumnProperties { get; set; }
        }

        public class SourceTable : Humidifier.Base.BaseSubResource, IHavePhysicalTableId, IHaveQuickSightDataSetTypesParentDataSetDataSet
        {
            /// <summary>
            /// PhysicalTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sourcetable.html#cfn-quicksight-dataset-sourcetable-physicaltableid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PhysicalTableId { get; set; }
            /// <summary>
            /// DataSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sourcetable.html#cfn-quicksight-dataset-sourcetable-dataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParentDataSet
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ParentDataSet, BaseFunction>? DataSet { get; set; }
        }

        public class StringDatasetParameter : Humidifier.Base.BaseSubResource, IHaveValueType, IHaveQuickSightDataSetTypesStringDatasetParameterDefaultValuesDefaultValues, IHaveId, IHaveName
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueType { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDatasetParameterDefaultValues
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues, BaseFunction>? DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class StringDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource, IHaveStringListOfStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameterdefaultvalues.html#cfn-quicksight-dataset-stringdatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StaticValues { get; set; }
        }

        public class TablePathElement : Humidifier.Base.BaseSubResource, IHaveId, IHaveName
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tablepathelement.html#cfn-quicksight-dataset-tablepathelement-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tablepathelement.html#cfn-quicksight-dataset-tablepathelement-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TableSemanticMetadata : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSetTypesSharedColumnSemanticMetadataColumnMetadata
        {
            /// <summary>
            /// ColumnMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tablesemanticmetadata.html#cfn-quicksight-dataset-tablesemanticmetadata-columnmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SharedColumnSemanticMetadata
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.SharedColumnSemanticMetadata>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.SharedColumnSemanticMetadata, BaseFunction>>, BaseFunction>? ColumnMetadata { get; set; }
        }

        public class TransformOperationSource : Humidifier.Base.BaseSubResource, IHaveTransformOperationId, IHaveListOfQuickSightDataSetTypesDataSetColumnIdMappingColumnIdMappings
        {
            /// <summary>
            /// TransformOperationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperationsource.html#cfn-quicksight-dataset-transformoperationsource-transformoperationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransformOperationId { get; set; }
            /// <summary>
            /// ColumnIdMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperationsource.html#cfn-quicksight-dataset-transformoperationsource-columnidmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetColumnIdMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.DataSetColumnIdMapping>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.DataSetColumnIdMapping, BaseFunction>>, BaseFunction>? ColumnIdMappings { get; set; }
        }

        public class TransformStep : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesProjectOperationProjectStep, IHaveQuickSightDataSetTypesCreateColumnsOperationCreateColumnsStep, IHaveQuickSightDataSetTypesRenameColumnsOperationRenameColumnsStep, IHaveQuickSightDataSetTypesCastColumnTypesOperationCastColumnTypesStep, IHaveQuickSightDataSetTypesImportTableOperationImportTableStep, IHaveQuickSightDataSetTypesUnpivotOperationUnpivotStep, IHaveQuickSightDataSetTypesJoinOperationJoinStep, IHaveQuickSightDataSetTypesAppendOperationAppendStep, IHaveQuickSightDataSetTypesFiltersOperationFiltersStep, IHaveQuickSightDataSetTypesAggregateOperationAggregateStep, IHaveQuickSightDataSetTypesPivotOperationPivotStep
        {
            /// <summary>
            /// ProjectStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-projectstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProjectOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ProjectOperation, BaseFunction>? ProjectStep { get; set; }
            /// <summary>
            /// CreateColumnsStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-createcolumnsstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreateColumnsOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.CreateColumnsOperation, BaseFunction>? CreateColumnsStep { get; set; }
            /// <summary>
            /// RenameColumnsStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-renamecolumnsstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RenameColumnsOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.RenameColumnsOperation, BaseFunction>? RenameColumnsStep { get; set; }
            /// <summary>
            /// CastColumnTypesStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-castcolumntypesstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CastColumnTypesOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.CastColumnTypesOperation, BaseFunction>? CastColumnTypesStep { get; set; }
            /// <summary>
            /// ImportTableStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-importtablestep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTableOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.ImportTableOperation, BaseFunction>? ImportTableStep { get; set; }
            /// <summary>
            /// UnpivotStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-unpivotstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UnpivotOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.UnpivotOperation, BaseFunction>? UnpivotStep { get; set; }
            /// <summary>
            /// JoinStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-joinstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.JoinOperation, BaseFunction>? JoinStep { get; set; }
            /// <summary>
            /// AppendStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-appendstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppendOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.AppendOperation, BaseFunction>? AppendStep { get; set; }
            /// <summary>
            /// FiltersStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-filtersstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FiltersOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.FiltersOperation, BaseFunction>? FiltersStep { get; set; }
            /// <summary>
            /// AggregateStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-aggregatestep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregateOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.AggregateOperation, BaseFunction>? AggregateStep { get; set; }
            /// <summary>
            /// PivotStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-pivotstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotOperation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.PivotOperation, BaseFunction>? PivotStep { get; set; }
        }

        public class UniqueKey : Humidifier.Base.BaseSubResource, IHaveStringListOfColumnNames
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uniquekey.html#cfn-quicksight-dataset-uniquekey-columnnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
        }

        public class UnpivotOperation : Humidifier.Base.BaseSubResource, IHaveUnpivotedLabelColumnName, IHaveListOfQuickSightDataSetTypesColumnToUnpivotColumnsToUnpivot, IHaveUnpivotedLabelColumnId, IHaveAlias, IHaveUnpivotedValueColumnId, IHaveUnpivotedValueColumnName, IHaveQuickSightDataSetTypesTransformOperationSourceSource
        {
            /// <summary>
            /// UnpivotedLabelColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedlabelcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnpivotedLabelColumnName { get; set; }
            /// <summary>
            /// ColumnsToUnpivot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-columnstounpivot
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnToUnpivot
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSetTypes.ColumnToUnpivot>, IReadOnlyList<Union<Humidifier.QuickSight.DataSetTypes.ColumnToUnpivot, BaseFunction>>, BaseFunction>? ColumnsToUnpivot { get; set; }
            /// <summary>
            /// UnpivotedLabelColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedlabelcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnpivotedLabelColumnId { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// UnpivotedValueColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedvaluecolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnpivotedValueColumnId { get; set; }
            /// <summary>
            /// UnpivotedValueColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedvaluecolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnpivotedValueColumnName { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.TransformOperationSource, BaseFunction>? Source { get; set; }
        }

        public class UploadSettings : Humidifier.Base.BaseSubResource, IHaveContainsHeader_Boolean, IHaveTextQualifier, IHaveFormat, IHaveStartFromRow_Double, IHaveDelimiter
        {
            /// <summary>
            /// ContainsHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-containsheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ContainsHeader { get; set; }
            /// <summary>
            /// TextQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-textqualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextQualifier { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// StartFromRow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-startfromrow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StartFromRow { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Delimiter { get; set; }
        }

        public class UploadedDocumentMetadata : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadeddocumentmetadata.html#cfn-quicksight-dataset-uploadeddocumentmetadata-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ValueColumnConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSetTypesDataPrepAggregationFunctionAggregationFunction
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-valuecolumnconfiguration.html#cfn-quicksight-dataset-valuecolumnconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepAggregationFunction
            /// </summary>
            public Union<Humidifier.QuickSight.DataSetTypes.DataPrepAggregationFunction, BaseFunction>? AggregationFunction { get; set; }
        }
    }
}