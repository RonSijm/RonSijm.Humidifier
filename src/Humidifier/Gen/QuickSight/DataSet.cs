namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using DataSetTypes;

    public class DataSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAwsAccountId, IHaveFolderArns, IHaveDataSetId
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
        public Dictionary<string, Humidifier.QuickSight.DataSetTypes.PhysicalTable> PhysicalTableMap { get; set; }
        /// <summary>
        /// FieldFolders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-fieldfolders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: FieldFolder
        /// </summary>
        public Dictionary<string, Humidifier.QuickSight.DataSetTypes.FieldFolder> FieldFolders { get; set; }
        /// <summary>
        /// SemanticModelConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-semanticmodelconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SemanticModelConfiguration
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration SemanticModelConfiguration { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-folderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic FolderArns { get; set; }
        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataSetId { get; set; }
        /// <summary>
        /// PerformanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-performanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PerformanceConfiguration
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration PerformanceConfiguration { get; set; }
        /// <summary>
        /// IngestionWaitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IngestionWaitPolicy
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy IngestionWaitPolicy { get; set; }
        /// <summary>
        /// DataSetRefreshProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetrefreshproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSetRefreshProperties
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties DataSetRefreshProperties { get; set; }
        /// <summary>
        /// ColumnLevelPermissionRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columnlevelpermissionrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ColumnLevelPermissionRule
        /// </summary>
        public List<Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule> ColumnLevelPermissionRules { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ColumnGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columngroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ColumnGroup
        /// </summary>
        public List<Humidifier.QuickSight.DataSetTypes.ColumnGroup> ColumnGroups { get; set; }
        /// <summary>
        /// ImportMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-importmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImportMode { get; set; }
        /// <summary>
        /// DatasetParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatasetParameter
        /// </summary>
        public List<Humidifier.QuickSight.DataSetTypes.DatasetParameter> DatasetParameters { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.DataSetTypes.ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// DataSetUsageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetusageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSetUsageConfiguration
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration DataSetUsageConfiguration { get; set; }
        /// <summary>
        /// UseAs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-useas
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UseAs { get; set; }
        /// <summary>
        /// DataPrepConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-dataprepconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataPrepConfiguration
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration DataPrepConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Text { get; set; }
        }

        public class AggregateOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// GroupByColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-groupbycolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GroupByColumnNames { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// Aggregations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-aggregations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Aggregation
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.Aggregation> Aggregations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregateoperation.html#cfn-quicksight-dataset-aggregateoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class Aggregation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregation.html#cfn-quicksight-dataset-aggregation-aggregationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataPrepAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataPrepAggregationFunction AggregationFunction { get; set; }
            /// <summary>
            /// NewColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregation.html#cfn-quicksight-dataset-aggregation-newcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnName { get; set; }
            /// <summary>
            /// NewColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-aggregation.html#cfn-quicksight-dataset-aggregation-newcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnId { get; set; }
        }

        public class AppendOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// AppendedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-appendedcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AppendedColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.AppendedColumn> AppendedColumns { get; set; }
            /// <summary>
            /// SecondSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-secondsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource SecondSource { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// FirstSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendoperation.html#cfn-quicksight-dataset-appendoperation-firstsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource FirstSource { get; set; }
        }

        public class AppendedColumn : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendedcolumn.html#cfn-quicksight-dataset-appendedcolumn-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// NewColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-appendedcolumn.html#cfn-quicksight-dataset-appendedcolumn-newcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnId { get; set; }
        }

        public class CalculatedColumn : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveColumnName
        {
            /// <summary>
            /// ColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html#cfn-quicksight-dataset-calculatedcolumn-columnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnId { get; set; }
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html#cfn-quicksight-dataset-calculatedcolumn-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html#cfn-quicksight-dataset-calculatedcolumn-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
        }

        public class CastColumnTypeOperation : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveColumnName, IHaveSubType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubType { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// NewColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html#cfn-quicksight-dataset-castcolumntypeoperation-newcolumntype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnType { get; set; }
        }

        public class CastColumnTypesOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// CastColumnTypeOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypesoperation.html#cfn-quicksight-dataset-castcolumntypesoperation-castcolumntypeoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CastColumnTypeOperation
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.CastColumnTypeOperation> CastColumnTypeOperations { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypesoperation.html#cfn-quicksight-dataset-castcolumntypesoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypesoperation.html#cfn-quicksight-dataset-castcolumntypesoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
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
            public dynamic Text { get; set; }
        }

        public class ColumnGroup : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GeoSpatialColumnGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columngroup.html#cfn-quicksight-dataset-columngroup-geospatialcolumngroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoSpatialColumnGroup
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.GeoSpatialColumnGroup GeoSpatialColumnGroup { get; set; }
        }

        public class ColumnLevelPermissionRule : Humidifier.Base.BaseSubResource, IHaveColumnNames, IHavePrincipals
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnlevelpermissionrule.html#cfn-quicksight-dataset-columnlevelpermissionrule-columnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ColumnNames { get; set; }
            /// <summary>
            /// Principals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnlevelpermissionrule.html#cfn-quicksight-dataset-columnlevelpermissionrule-principals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Principals { get; set; }
        }

        public class ColumnSemanticProperty : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SemanticType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemanticproperty.html#cfn-quicksight-dataset-columnsemanticproperty-semantictype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnSemanticType
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ColumnSemanticType SemanticType { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemanticproperty.html#cfn-quicksight-dataset-columnsemanticproperty-description
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnDescription
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ColumnDescription Description { get; set; }
            /// <summary>
            /// AdditionalNotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemanticproperty.html#cfn-quicksight-dataset-columnsemanticproperty-additionalnotes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdditionalNotes
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.AdditionalNotes AdditionalNotes { get; set; }
        }

        public class ColumnSemanticType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GeographicalRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnsemantictype.html#cfn-quicksight-dataset-columnsemantictype-geographicalrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeographicalRole { get; set; }
        }

        public class ColumnToUnpivot : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntounpivot.html#cfn-quicksight-dataset-columntounpivot-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// NewValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntounpivot.html#cfn-quicksight-dataset-columntounpivot-newvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewValue { get; set; }
        }

        public class CreateColumnsOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.CalculatedColumn> Columns { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class CustomInstruction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InlineCustomInstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-custominstruction.html#cfn-quicksight-dataset-custominstruction-inlinecustominstruction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InlineCustomInstruction
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.InlineCustomInstruction InlineCustomInstruction { get; set; }
        }

        public class CustomSql : Humidifier.Base.BaseSubResource, IHaveName, IHaveDataSourceArn, IHaveSqlQuery
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceArn { get; set; }
            /// <summary>
            /// SqlQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-sqlquery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SqlQuery { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.InputColumn> Columns { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DataPrepAggregationFunction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PercentileAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepaggregationfunction.html#cfn-quicksight-dataset-dataprepaggregationfunction-percentileaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepPercentileAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataPrepPercentileAggregationFunction PercentileAggregation { get; set; }
            /// <summary>
            /// ListAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepaggregationfunction.html#cfn-quicksight-dataset-dataprepaggregationfunction-listaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepListAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataPrepListAggregationFunction ListAggregation { get; set; }
            /// <summary>
            /// SimpleAggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepaggregationfunction.html#cfn-quicksight-dataset-dataprepaggregationfunction-simpleaggregation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepSimpleAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataPrepSimpleAggregationFunction SimpleAggregation { get; set; }
        }

        public class DataPrepConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationTableMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepconfiguration.html#cfn-quicksight-dataset-dataprepconfiguration-destinationtablemap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: DestinationTable
            /// </summary>
            public Dictionary<string, Humidifier.QuickSight.DataSetTypes.DestinationTable> DestinationTableMap { get; set; }
            /// <summary>
            /// TransformStepMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepconfiguration.html#cfn-quicksight-dataset-dataprepconfiguration-transformstepmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: TransformStep
            /// </summary>
            public Dictionary<string, Humidifier.QuickSight.DataSetTypes.TransformStep> TransformStepMap { get; set; }
            /// <summary>
            /// SourceTableMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepconfiguration.html#cfn-quicksight-dataset-dataprepconfiguration-sourcetablemap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SourceTable
            /// </summary>
            public Dictionary<string, Humidifier.QuickSight.DataSetTypes.SourceTable> SourceTableMap { get; set; }
        }

        public class DataPrepListAggregationFunction : Humidifier.Base.BaseSubResource, IHaveSeparator
        {
            /// <summary>
            /// Distinct
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreplistaggregationfunction.html#cfn-quicksight-dataset-datapreplistaggregationfunction-distinct
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Distinct { get; set; }
            /// <summary>
            /// InputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreplistaggregationfunction.html#cfn-quicksight-dataset-datapreplistaggregationfunction-inputcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputColumnName { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreplistaggregationfunction.html#cfn-quicksight-dataset-datapreplistaggregationfunction-separator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Separator { get; set; }
        }

        public class DataPrepPercentileAggregationFunction : Humidifier.Base.BaseSubResource, IHavePercentileValue
        {
            /// <summary>
            /// InputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreppercentileaggregationfunction.html#cfn-quicksight-dataset-datapreppercentileaggregationfunction-inputcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputColumnName { get; set; }
            /// <summary>
            /// PercentileValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datapreppercentileaggregationfunction.html#cfn-quicksight-dataset-datapreppercentileaggregationfunction-percentilevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentileValue { get; set; }
        }

        public class DataPrepSimpleAggregationFunction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FunctionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepsimpleaggregationfunction.html#cfn-quicksight-dataset-dataprepsimpleaggregationfunction-functiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionType { get; set; }
            /// <summary>
            /// InputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-dataprepsimpleaggregationfunction.html#cfn-quicksight-dataset-dataprepsimpleaggregationfunction-inputcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputColumnName { get; set; }
        }

        public class DataSetColumnIdMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetcolumnidmapping.html#cfn-quicksight-dataset-datasetcolumnidmapping-sourcecolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceColumnId { get; set; }
            /// <summary>
            /// TargetColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetcolumnidmapping.html#cfn-quicksight-dataset-datasetcolumnidmapping-targetcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetColumnId { get; set; }
        }

        public class DataSetDateComparisonFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatecomparisonfiltercondition.html#cfn-quicksight-dataset-datasetdatecomparisonfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatecomparisonfiltercondition.html#cfn-quicksight-dataset-datasetdatecomparisonfiltercondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetDateFilterValue Value { get; set; }
        }

        public class DataSetDateFilterCondition : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltercondition.html#cfn-quicksight-dataset-datasetdatefiltercondition-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// RangeFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltercondition.html#cfn-quicksight-dataset-datasetdatefiltercondition-rangefiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateRangeFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetDateRangeFilterCondition RangeFilterCondition { get; set; }
            /// <summary>
            /// ComparisonFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdatefiltercondition.html#cfn-quicksight-dataset-datasetdatefiltercondition-comparisonfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateComparisonFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetDateComparisonFilterCondition ComparisonFilterCondition { get; set; }
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
            public dynamic StaticValue { get; set; }
        }

        public class DataSetDateRangeFilterCondition : Humidifier.Base.BaseSubResource, IHaveIncludeMaximum, IHaveIncludeMinimum
        {
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetDateFilterValue RangeMinimum { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetDateFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetdaterangefiltercondition.html#cfn-quicksight-dataset-datasetdaterangefiltercondition-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
        }

        public class DataSetNumericComparisonFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetnumericcomparisonfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetnumericcomparisonfiltercondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterValue Value { get; set; }
        }

        public class DataSetNumericFilterCondition : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltercondition.html#cfn-quicksight-dataset-datasetnumericfiltercondition-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// RangeFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltercondition.html#cfn-quicksight-dataset-datasetnumericfiltercondition-rangefiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericRangeFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetNumericRangeFilterCondition RangeFilterCondition { get; set; }
            /// <summary>
            /// ComparisonFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltercondition.html#cfn-quicksight-dataset-datasetnumericfiltercondition-comparisonfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericComparisonFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetNumericComparisonFilterCondition ComparisonFilterCondition { get; set; }
        }

        public class DataSetNumericFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValue
        {
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericfiltervalue.html#cfn-quicksight-dataset-datasetnumericfiltervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StaticValue { get; set; }
        }

        public class DataSetNumericRangeFilterCondition : Humidifier.Base.BaseSubResource, IHaveIncludeMaximum, IHaveIncludeMinimum
        {
            /// <summary>
            /// IncludeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-includemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMaximum { get; set; }
            /// <summary>
            /// RangeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-rangeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterValue RangeMinimum { get; set; }
            /// <summary>
            /// RangeMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-rangemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterValue RangeMaximum { get; set; }
            /// <summary>
            /// IncludeMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetnumericrangefiltercondition.html#cfn-quicksight-dataset-datasetnumericrangefiltercondition-includeminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeMinimum { get; set; }
        }

        public class DataSetRefreshProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RefreshConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetrefreshproperties.html#cfn-quicksight-dataset-datasetrefreshproperties-refreshconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshConfiguration
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RefreshConfiguration RefreshConfiguration { get; set; }
            /// <summary>
            /// FailureConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetrefreshproperties.html#cfn-quicksight-dataset-datasetrefreshproperties-failureconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshFailureConfiguration
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RefreshFailureConfiguration FailureConfiguration { get; set; }
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
            public dynamic Text { get; set; }
        }

        public class DataSetSemanticMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomInstructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetsemanticmetadata.html#cfn-quicksight-dataset-datasetsemanticmetadata-custominstructions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomInstruction
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.CustomInstruction> CustomInstructions { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetsemanticmetadata.html#cfn-quicksight-dataset-datasetsemanticmetadata-description
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetSemanticDescription
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetSemanticDescription Description { get; set; }
        }

        public class DataSetStringComparisonFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetstringcomparisonfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringcomparisonfiltercondition.html#cfn-quicksight-dataset-datasetstringcomparisonfiltercondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetStringFilterValue Value { get; set; }
        }

        public class DataSetStringFilterCondition : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltercondition.html#cfn-quicksight-dataset-datasetstringfiltercondition-columnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// ComparisonFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltercondition.html#cfn-quicksight-dataset-datasetstringfiltercondition-comparisonfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringComparisonFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetStringComparisonFilterCondition ComparisonFilterCondition { get; set; }
            /// <summary>
            /// ListFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringfiltercondition.html#cfn-quicksight-dataset-datasetstringfiltercondition-listfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringListFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetStringListFilterCondition ListFilterCondition { get; set; }
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
            public dynamic StaticValue { get; set; }
        }

        public class DataSetStringListFilterCondition : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringlistfiltercondition.html#cfn-quicksight-dataset-datasetstringlistfiltercondition-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringlistfiltercondition.html#cfn-quicksight-dataset-datasetstringlistfiltercondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringListFilterValue
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetStringListFilterValue Values { get; set; }
        }

        public class DataSetStringListFilterValue : Humidifier.Base.BaseSubResource, IHaveStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetstringlistfiltervalue.html#cfn-quicksight-dataset-datasetstringlistfiltervalue-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class DataSetUsageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DisableUseAsImportedSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetusageconfiguration.html#cfn-quicksight-dataset-datasetusageconfiguration-disableuseasimportedsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableUseAsImportedSource { get; set; }
            /// <summary>
            /// DisableUseAsDirectQuerySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetusageconfiguration.html#cfn-quicksight-dataset-datasetusageconfiguration-disableuseasdirectquerysource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableUseAsDirectQuerySource { get; set; }
        }

        public class DatasetParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IntegerDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-integerdatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDatasetParameter
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameter IntegerDatasetParameter { get; set; }
            /// <summary>
            /// DateTimeDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-datetimedatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDatasetParameter
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameter DateTimeDatasetParameter { get; set; }
            /// <summary>
            /// DecimalDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-decimaldatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDatasetParameter
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameter DecimalDatasetParameter { get; set; }
            /// <summary>
            /// StringDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-stringdatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDatasetParameter
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.StringDatasetParameter StringDatasetParameter { get; set; }
        }

        public class DateTimeDatasetParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveId, IHaveTimeGranularity, IHaveValueType
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueType { get; set; }
            /// <summary>
            /// TimeGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-timegranularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeGranularity { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDatasetParameterDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameter.html#cfn-quicksight-dataset-datetimedatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DateTimeDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datetimedatasetparameterdefaultvalues.html#cfn-quicksight-dataset-datetimedatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class DecimalDatasetParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveId, IHaveValueType
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueType { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDatasetParameterDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameter.html#cfn-quicksight-dataset-decimaldatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DecimalDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-decimaldatasetparameterdefaultvalues.html#cfn-quicksight-dataset-decimaldatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class DestinationTable : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-destinationtable.html#cfn-quicksight-dataset-destinationtable-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-destinationtable.html#cfn-quicksight-dataset-destinationtable-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationTableSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DestinationTableSource Source { get; set; }
        }

        public class DestinationTableSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TransformOperationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-destinationtablesource.html#cfn-quicksight-dataset-destinationtablesource-transformoperationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransformOperationId { get; set; }
        }

        public class FieldFolder : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveColumns
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-fieldfolder.html#cfn-quicksight-dataset-fieldfolder-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-fieldfolder.html#cfn-quicksight-dataset-fieldfolder-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Columns { get; set; }
        }

        public class FilterOperation : Humidifier.Base.BaseSubResource, IHaveConditionExpression
        {
            /// <summary>
            /// DateFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-datefiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetDateFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetDateFilterCondition DateFilterCondition { get; set; }
            /// <summary>
            /// StringFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-stringfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetStringFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetStringFilterCondition StringFilterCondition { get; set; }
            /// <summary>
            /// ConditionExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-conditionexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionExpression { get; set; }
            /// <summary>
            /// NumericFilterCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-numericfiltercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSetNumericFilterCondition
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataSetNumericFilterCondition NumericFilterCondition { get; set; }
        }

        public class FiltersOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// FilterOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filtersoperation.html#cfn-quicksight-dataset-filtersoperation-filteroperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterOperation
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.FilterOperation> FilterOperations { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filtersoperation.html#cfn-quicksight-dataset-filtersoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filtersoperation.html#cfn-quicksight-dataset-filtersoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class GeoSpatialColumnGroup : Humidifier.Base.BaseSubResource, IHaveName, IHaveCountryCode, IHaveColumns
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html#cfn-quicksight-dataset-geospatialcolumngroup-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Columns { get; set; }
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html#cfn-quicksight-dataset-geospatialcolumngroup-countrycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CountryCode { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html#cfn-quicksight-dataset-geospatialcolumngroup-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ImportTableOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperation.html#cfn-quicksight-dataset-importtableoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperation.html#cfn-quicksight-dataset-importtableoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ImportTableOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ImportTableOperationSource Source { get; set; }
        }

        public class ImportTableOperationSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperationsource.html#cfn-quicksight-dataset-importtableoperationsource-sourcetableid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceTableId { get; set; }
            /// <summary>
            /// ColumnIdMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-importtableoperationsource.html#cfn-quicksight-dataset-importtableoperationsource-columnidmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetColumnIdMapping
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.DataSetColumnIdMapping> ColumnIdMappings { get; set; }
        }

        public class IncrementalRefresh : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LookbackWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-incrementalrefresh.html#cfn-quicksight-dataset-incrementalrefresh-lookbackwindow
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LookbackWindow
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.LookbackWindow LookbackWindow { get; set; }
        }

        public class IngestionWaitPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WaitForSpiceIngestion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-ingestionwaitpolicy.html#cfn-quicksight-dataset-ingestionwaitpolicy-waitforspiceingestion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic WaitForSpiceIngestion { get; set; }
            /// <summary>
            /// IngestionWaitTimeInHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-ingestionwaitpolicy.html#cfn-quicksight-dataset-ingestionwaitpolicy-ingestionwaittimeinhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IngestionWaitTimeInHours { get; set; }
        }

        public class InlineCustomInstruction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InstructionText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inlinecustominstruction.html#cfn-quicksight-dataset-inlinecustominstruction-instructiontext
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstructionText { get; set; }
            /// <summary>
            /// UploadedDocumentMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inlinecustominstruction.html#cfn-quicksight-dataset-inlinecustominstruction-uploadeddocumentmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UploadedDocumentMetadata
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.UploadedDocumentMetadata UploadedDocumentMetadata { get; set; }
        }

        public class InputColumn : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveId, IHaveSubType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubType { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegerDatasetParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveId, IHaveValueType
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueType { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDatasetParameterDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameter.html#cfn-quicksight-dataset-integerdatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegerDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameterdefaultvalues.html#cfn-quicksight-dataset-integerdatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Long
            /// </summary>
            public List<long> StaticValues { get; set; }
        }

        public class JoinOperandProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputColumnNameOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperandproperties.html#cfn-quicksight-dataset-joinoperandproperties-outputcolumnnameoverrides
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputColumnNameOverride
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.OutputColumnNameOverride> OutputColumnNameOverrides { get; set; }
        }

        public class JoinOperation : Humidifier.Base.BaseSubResource, IHaveType, IHaveAlias
        {
            /// <summary>
            /// OnClause
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-onclause
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnClause { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// RightOperandProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-rightoperandproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinOperandProperties
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.JoinOperandProperties RightOperandProperties { get; set; }
            /// <summary>
            /// LeftOperandProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-leftoperandproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinOperandProperties
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.JoinOperandProperties LeftOperandProperties { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// LeftOperand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-leftoperand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource LeftOperand { get; set; }
            /// <summary>
            /// RightOperand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinoperation.html#cfn-quicksight-dataset-joinoperation-rightoperand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource RightOperand { get; set; }
        }

        public class LookbackWindow : Humidifier.Base.BaseSubResource, IHaveSize, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-lookbackwindow.html#cfn-quicksight-dataset-lookbackwindow-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// SizeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-lookbackwindow.html#cfn-quicksight-dataset-lookbackwindow-sizeunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SizeUnit { get; set; }
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-lookbackwindow.html#cfn-quicksight-dataset-lookbackwindow-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Size { get; set; }
        }

        public class OutputColumn : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveId, IHaveSubType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubType { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class OutputColumnNameOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumnnameoverride.html#cfn-quicksight-dataset-outputcolumnnameoverride-outputcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputColumnName { get; set; }
            /// <summary>
            /// SourceColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumnnameoverride.html#cfn-quicksight-dataset-outputcolumnnameoverride-sourcecolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceColumnName { get; set; }
        }

        public class ParentDataSet : Humidifier.Base.BaseSubResource, IHaveDataSetArn
        {
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-parentdataset.html#cfn-quicksight-dataset-parentdataset-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.InputColumn> InputColumns { get; set; }
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-parentdataset.html#cfn-quicksight-dataset-parentdataset-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
        }

        public class PerformanceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UniqueKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-performanceconfiguration.html#cfn-quicksight-dataset-performanceconfiguration-uniquekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UniqueKey
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.UniqueKey> UniqueKeys { get; set; }
        }

        public class PhysicalTable : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SaaSTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-saastable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SaaSTable
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.SaaSTable SaaSTable { get; set; }
            /// <summary>
            /// RelationalTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-relationaltable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelationalTable
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RelationalTable RelationalTable { get; set; }
            /// <summary>
            /// CustomSql
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-customsql
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomSql
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.CustomSql CustomSql { get; set; }
            /// <summary>
            /// S3Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-s3source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Source
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.S3Source S3Source { get; set; }
        }

        public class PivotConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LabelColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotconfiguration.html#cfn-quicksight-dataset-pivotconfiguration-labelcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelColumnName { get; set; }
            /// <summary>
            /// PivotedLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotconfiguration.html#cfn-quicksight-dataset-pivotconfiguration-pivotedlabels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PivotedLabel
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.PivotedLabel> PivotedLabels { get; set; }
        }

        public class PivotOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// PivotConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-pivotconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PivotConfiguration
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.PivotConfiguration PivotConfiguration { get; set; }
            /// <summary>
            /// GroupByColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-groupbycolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GroupByColumnNames { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// ValueColumnConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-valuecolumnconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ValueColumnConfiguration
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ValueColumnConfiguration ValueColumnConfiguration { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotoperation.html#cfn-quicksight-dataset-pivotoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class PivotedLabel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NewColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotedlabel.html#cfn-quicksight-dataset-pivotedlabel-newcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnName { get; set; }
            /// <summary>
            /// NewColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotedlabel.html#cfn-quicksight-dataset-pivotedlabel-newcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnId { get; set; }
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-pivotedlabel.html#cfn-quicksight-dataset-pivotedlabel-labelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelName { get; set; }
        }

        public class ProjectOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// ProjectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-projectedcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ProjectedColumns { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class RefreshConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncrementalRefresh
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshconfiguration.html#cfn-quicksight-dataset-refreshconfiguration-incrementalrefresh
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IncrementalRefresh
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.IncrementalRefresh IncrementalRefresh { get; set; }
        }

        public class RefreshFailureConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EmailAlert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshfailureconfiguration.html#cfn-quicksight-dataset-refreshfailureconfiguration-emailalert
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshFailureEmailAlert
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert EmailAlert { get; set; }
        }

        public class RefreshFailureEmailAlert : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AlertStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshfailureemailalert.html#cfn-quicksight-dataset-refreshfailureemailalert-alertstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlertStatus { get; set; }
        }

        public class RelationalTable : Humidifier.Base.BaseSubResource, IHaveName, IHaveCatalog, IHaveSchema, IHaveDataSourceArn
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceArn { get; set; }
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.InputColumn> InputColumns { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-schema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Schema { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-catalog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Catalog { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-relationaltable.html#cfn-quicksight-dataset-relationaltable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RenameColumnOperation : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// NewColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnoperation.html#cfn-quicksight-dataset-renamecolumnoperation-newcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewColumnName { get; set; }
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnoperation.html#cfn-quicksight-dataset-renamecolumnoperation-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
        }

        public class RenameColumnsOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnsoperation.html#cfn-quicksight-dataset-renamecolumnsoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// RenameColumnOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnsoperation.html#cfn-quicksight-dataset-renamecolumnsoperation-renamecolumnoperations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RenameColumnOperation
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.RenameColumnOperation> RenameColumnOperations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnsoperation.html#cfn-quicksight-dataset-renamecolumnsoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-resourcepermission.html#cfn-quicksight-dataset-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-resourcepermission.html#cfn-quicksight-dataset-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }

        public class RowLevelPermissionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TagConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissionconfiguration.html#cfn-quicksight-dataset-rowlevelpermissionconfiguration-tagconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowLevelPermissionTagConfiguration
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration TagConfiguration { get; set; }
            /// <summary>
            /// RowLevelPermissionDataSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissionconfiguration.html#cfn-quicksight-dataset-rowlevelpermissionconfiguration-rowlevelpermissiondataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowLevelPermissionDataSet
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }
        }

        public class RowLevelPermissionDataSet : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn, IHaveNamespace_, IHaveFormatVersion
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// FormatVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-formatversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FormatVersion { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
            /// <summary>
            /// PermissionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-permissionpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PermissionPolicy { get; set; }
        }

        public class RowLevelPermissionTagConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// TagRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-tagrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RowLevelPermissionTagRule
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagRule> TagRules { get; set; }
            /// <summary>
            /// TagRuleConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-tagruleconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TagRuleConfigurations { get; set; }
        }

        public class RowLevelPermissionTagRule : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveTagKey
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// TagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-tagkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TagKey { get; set; }
            /// <summary>
            /// MatchAllValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-matchallvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchAllValue { get; set; }
            /// <summary>
            /// TagMultiValueDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagrule.html#cfn-quicksight-dataset-rowlevelpermissiontagrule-tagmultivaluedelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TagMultiValueDelimiter { get; set; }
        }

        public class S3Source : Humidifier.Base.BaseSubResource, IHaveDataSourceArn
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceArn { get; set; }
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.InputColumn> InputColumns { get; set; }
            /// <summary>
            /// UploadSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-uploadsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UploadSettings
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.UploadSettings UploadSettings { get; set; }
        }

        public class SaaSTable : Humidifier.Base.BaseSubResource, IHaveDataSourceArn
        {
            /// <summary>
            /// DataSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-saastable.html#cfn-quicksight-dataset-saastable-datasourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceArn { get; set; }
            /// <summary>
            /// InputColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-saastable.html#cfn-quicksight-dataset-saastable-inputcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.InputColumn> InputColumns { get; set; }
            /// <summary>
            /// TablePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-saastable.html#cfn-quicksight-dataset-saastable-tablepath
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TablePathElement
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.TablePathElement> TablePath { get; set; }
        }

        public class SemanticModelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SemanticMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semanticmodelconfiguration.html#cfn-quicksight-dataset-semanticmodelconfiguration-semanticmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetSemanticMetadata
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.DataSetSemanticMetadata> SemanticMetadata { get; set; }
            /// <summary>
            /// TableMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semanticmodelconfiguration.html#cfn-quicksight-dataset-semanticmodelconfiguration-tablemap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SemanticTable
            /// </summary>
            public Dictionary<string, Humidifier.QuickSight.DataSetTypes.SemanticTable> TableMap { get; set; }
        }

        public class SemanticTable : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// SemanticMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-semanticmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableSemanticMetadata
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TableSemanticMetadata SemanticMetadata { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// DestinationTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-destinationtableid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationTableId { get; set; }
            /// <summary>
            /// RowLevelPermissionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-semantictable.html#cfn-quicksight-dataset-semantictable-rowlevelpermissionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RowLevelPermissionConfiguration
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RowLevelPermissionConfiguration RowLevelPermissionConfiguration { get; set; }
        }

        public class SharedColumnSemanticMetadata : Humidifier.Base.BaseSubResource, IHaveColumnNames
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sharedcolumnsemanticmetadata.html#cfn-quicksight-dataset-sharedcolumnsemanticmetadata-columnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ColumnNames { get; set; }
            /// <summary>
            /// ColumnProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sharedcolumnsemanticmetadata.html#cfn-quicksight-dataset-sharedcolumnsemanticmetadata-columnproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSemanticProperty
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.ColumnSemanticProperty> ColumnProperties { get; set; }
        }

        public class SourceTable : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PhysicalTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sourcetable.html#cfn-quicksight-dataset-sourcetable-physicaltableid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhysicalTableId { get; set; }
            /// <summary>
            /// DataSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-sourcetable.html#cfn-quicksight-dataset-sourcetable-dataset
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParentDataSet
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ParentDataSet DataSet { get; set; }
        }

        public class StringDatasetParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveId, IHaveValueType
        {
            /// <summary>
            /// ValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-valuetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueType { get; set; }
            /// <summary>
            /// DefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-defaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDatasetParameterDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues DefaultValues { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameter.html#cfn-quicksight-dataset-stringdatasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StringDatasetParameterDefaultValues : Humidifier.Base.BaseSubResource, IHaveStaticValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-stringdatasetparameterdefaultvalues.html#cfn-quicksight-dataset-stringdatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StaticValues { get; set; }
        }

        public class TablePathElement : Humidifier.Base.BaseSubResource, IHaveName, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tablepathelement.html#cfn-quicksight-dataset-tablepathelement-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tablepathelement.html#cfn-quicksight-dataset-tablepathelement-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TableSemanticMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tablesemanticmetadata.html#cfn-quicksight-dataset-tablesemanticmetadata-columnmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SharedColumnSemanticMetadata
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.SharedColumnSemanticMetadata> ColumnMetadata { get; set; }
        }

        public class TransformOperationSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TransformOperationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperationsource.html#cfn-quicksight-dataset-transformoperationsource-transformoperationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransformOperationId { get; set; }
            /// <summary>
            /// ColumnIdMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperationsource.html#cfn-quicksight-dataset-transformoperationsource-columnidmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSetColumnIdMapping
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.DataSetColumnIdMapping> ColumnIdMappings { get; set; }
        }

        public class TransformStep : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProjectStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-projectstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProjectOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ProjectOperation ProjectStep { get; set; }
            /// <summary>
            /// CreateColumnsStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-createcolumnsstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreateColumnsOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.CreateColumnsOperation CreateColumnsStep { get; set; }
            /// <summary>
            /// RenameColumnsStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-renamecolumnsstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RenameColumnsOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RenameColumnsOperation RenameColumnsStep { get; set; }
            /// <summary>
            /// CastColumnTypesStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-castcolumntypesstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CastColumnTypesOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.CastColumnTypesOperation CastColumnTypesStep { get; set; }
            /// <summary>
            /// ImportTableStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-importtablestep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTableOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ImportTableOperation ImportTableStep { get; set; }
            /// <summary>
            /// UnpivotStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-unpivotstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UnpivotOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.UnpivotOperation UnpivotStep { get; set; }
            /// <summary>
            /// JoinStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-joinstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.JoinOperation JoinStep { get; set; }
            /// <summary>
            /// AppendStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-appendstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppendOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.AppendOperation AppendStep { get; set; }
            /// <summary>
            /// FiltersStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-filtersstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FiltersOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.FiltersOperation FiltersStep { get; set; }
            /// <summary>
            /// AggregateStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-aggregatestep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregateOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.AggregateOperation AggregateStep { get; set; }
            /// <summary>
            /// PivotStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformstep.html#cfn-quicksight-dataset-transformstep-pivotstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PivotOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.PivotOperation PivotStep { get; set; }
        }

        public class UniqueKey : Humidifier.Base.BaseSubResource, IHaveColumnNames
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uniquekey.html#cfn-quicksight-dataset-uniquekey-columnnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ColumnNames { get; set; }
        }

        public class UnpivotOperation : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// UnpivotedLabelColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedlabelcolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnpivotedLabelColumnName { get; set; }
            /// <summary>
            /// ColumnsToUnpivot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-columnstounpivot
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnToUnpivot
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.ColumnToUnpivot> ColumnsToUnpivot { get; set; }
            /// <summary>
            /// UnpivotedLabelColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedlabelcolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnpivotedLabelColumnId { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// UnpivotedValueColumnId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedvaluecolumnid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnpivotedValueColumnId { get; set; }
            /// <summary>
            /// UnpivotedValueColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-unpivotedvaluecolumnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnpivotedValueColumnName { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-unpivotoperation.html#cfn-quicksight-dataset-unpivotoperation-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformOperationSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TransformOperationSource Source { get; set; }
        }

        public class UploadSettings : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveFormat, IHaveContainsHeader
        {
            /// <summary>
            /// ContainsHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-containsheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ContainsHeader { get; set; }
            /// <summary>
            /// TextQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-textqualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextQualifier { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// StartFromRow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-startfromrow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartFromRow { get; set; }
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class ValueColumnConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AggregationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-valuecolumnconfiguration.html#cfn-quicksight-dataset-valuecolumnconfiguration-aggregationfunction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataPrepAggregationFunction
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.DataPrepAggregationFunction AggregationFunction { get; set; }
        }
    }
}