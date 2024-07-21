namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using DataSetTypes;

    public class DataSet : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string OutputColumns =  "OutputColumns" ;
            public static string ConsumedSpiceCapacityInBytes =  "ConsumedSpiceCapacityInBytes" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::QuickSight::DataSet";
            }
        }

        /// <summary>
        /// PhysicalTableMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-physicaltablemap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: PhysicalTable
        /// </summary>
        public Dictionary<string, PhysicalTable> PhysicalTableMap { get; set; }
        /// <summary>
        /// FieldFolders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-fieldfolders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: FieldFolder
        /// </summary>
        public Dictionary<string, FieldFolder> FieldFolders { get; set; }
        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataSetId { get; set; }
        /// <summary>
        /// RowLevelPermissionDataSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RowLevelPermissionDataSet
        /// </summary>
        public RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }
        /// <summary>
        /// DataSetRefreshProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetrefreshproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSetRefreshProperties
        /// </summary>
        public DataSetRefreshProperties DataSetRefreshProperties { get; set; }
        /// <summary>
        /// RowLevelPermissionTagConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RowLevelPermissionTagConfiguration
        /// </summary>
        public RowLevelPermissionTagConfiguration RowLevelPermissionTagConfiguration { get; set; }
        /// <summary>
        /// IngestionWaitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IngestionWaitPolicy
        /// </summary>
        public IngestionWaitPolicy IngestionWaitPolicy { get; set; }
        /// <summary>
        /// ColumnLevelPermissionRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columnlevelpermissionrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ColumnLevelPermissionRule
        /// </summary>
        public List<ColumnLevelPermissionRule> ColumnLevelPermissionRules { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
        /// <summary>
        /// ColumnGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columngroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ColumnGroup
        /// </summary>
        public List<ColumnGroup> ColumnGroups { get; set; }
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
        public List<DatasetParameter> DatasetParameters { get; set; }
        /// <summary>
        /// LogicalTableMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-logicaltablemap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: LogicalTable
        /// </summary>
        public Dictionary<string, LogicalTable> LogicalTableMap { get; set; }
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
        public DataSetUsageConfiguration DataSetUsageConfiguration { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DataSetTypes
    {
        public class CalculatedColumn
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

        public class CastColumnTypeOperation
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

        public class ColumnDescription
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

        public class ColumnGroup
        {
            /// <summary>
            /// GeoSpatialColumnGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columngroup.html#cfn-quicksight-dataset-columngroup-geospatialcolumngroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoSpatialColumnGroup
            /// </summary>
            public GeoSpatialColumnGroup GeoSpatialColumnGroup { get; set; }
        }

        public class ColumnLevelPermissionRule
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

        public class ColumnTag
        {
            /// <summary>
            /// ColumnGeographicRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntag.html#cfn-quicksight-dataset-columntag-columngeographicrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnGeographicRole { get; set; }
            /// <summary>
            /// ColumnDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntag.html#cfn-quicksight-dataset-columntag-columndescription
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnDescription
            /// </summary>
            public ColumnDescription ColumnDescription { get; set; }
        }

        public class CreateColumnsOperation
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedColumn
            /// </summary>
            public List<CalculatedColumn> Columns { get; set; }
        }

        public class CustomSql
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
            public List<InputColumn> Columns { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html#cfn-quicksight-dataset-customsql-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DataSetRefreshProperties
        {
            /// <summary>
            /// RefreshConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetrefreshproperties.html#cfn-quicksight-dataset-datasetrefreshproperties-refreshconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RefreshConfiguration
            /// </summary>
            public RefreshConfiguration RefreshConfiguration { get; set; }
        }

        public class DataSetUsageConfiguration
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

        public class DatasetParameter
        {
            /// <summary>
            /// IntegerDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-integerdatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerDatasetParameter
            /// </summary>
            public IntegerDatasetParameter IntegerDatasetParameter { get; set; }
            /// <summary>
            /// DateTimeDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-datetimedatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateTimeDatasetParameter
            /// </summary>
            public DateTimeDatasetParameter DateTimeDatasetParameter { get; set; }
            /// <summary>
            /// DecimalDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-decimaldatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecimalDatasetParameter
            /// </summary>
            public DecimalDatasetParameter DecimalDatasetParameter { get; set; }
            /// <summary>
            /// StringDatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-datasetparameter.html#cfn-quicksight-dataset-datasetparameter-stringdatasetparameter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringDatasetParameter
            /// </summary>
            public StringDatasetParameter StringDatasetParameter { get; set; }
        }

        public class DateTimeDatasetParameter
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
            public DateTimeDatasetParameterDefaultValues DefaultValues { get; set; }
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

        public class DateTimeDatasetParameterDefaultValues
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

        public class DecimalDatasetParameter
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
            public DecimalDatasetParameterDefaultValues DefaultValues { get; set; }
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

        public class DecimalDatasetParameterDefaultValues
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

        public class FieldFolder
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

        public class FilterOperation
        {
            /// <summary>
            /// ConditionExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html#cfn-quicksight-dataset-filteroperation-conditionexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionExpression { get; set; }
        }

        public class GeoSpatialColumnGroup
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

        public class IncrementalRefresh
        {
            /// <summary>
            /// LookbackWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-incrementalrefresh.html#cfn-quicksight-dataset-incrementalrefresh-lookbackwindow
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LookbackWindow
            /// </summary>
            public LookbackWindow LookbackWindow { get; set; }
        }

        public class IngestionWaitPolicy
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

        public class InputColumn
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
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html#cfn-quicksight-dataset-inputcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegerDatasetParameter
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
            public IntegerDatasetParameterDefaultValues DefaultValues { get; set; }
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

        public class IntegerDatasetParameterDefaultValues
        {
            /// <summary>
            /// StaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-integerdatasetparameterdefaultvalues.html#cfn-quicksight-dataset-integerdatasetparameterdefaultvalues-staticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class JoinInstruction
        {
            /// <summary>
            /// OnClause
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html#cfn-quicksight-dataset-joininstruction-onclause
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnClause { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html#cfn-quicksight-dataset-joininstruction-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// LeftJoinKeyProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html#cfn-quicksight-dataset-joininstruction-leftjoinkeyproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinKeyProperties
            /// </summary>
            public JoinKeyProperties LeftJoinKeyProperties { get; set; }
            /// <summary>
            /// LeftOperand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html#cfn-quicksight-dataset-joininstruction-leftoperand
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LeftOperand { get; set; }
            /// <summary>
            /// RightOperand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html#cfn-quicksight-dataset-joininstruction-rightoperand
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RightOperand { get; set; }
            /// <summary>
            /// RightJoinKeyProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html#cfn-quicksight-dataset-joininstruction-rightjoinkeyproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinKeyProperties
            /// </summary>
            public JoinKeyProperties RightJoinKeyProperties { get; set; }
        }

        public class JoinKeyProperties
        {
            /// <summary>
            /// UniqueKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinkeyproperties.html#cfn-quicksight-dataset-joinkeyproperties-uniquekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UniqueKey { get; set; }
        }

        public class LogicalTable
        {
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltable.html#cfn-quicksight-dataset-logicaltable-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// DataTransforms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltable.html#cfn-quicksight-dataset-logicaltable-datatransforms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TransformOperation
            /// </summary>
            public List<TransformOperation> DataTransforms { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltable.html#cfn-quicksight-dataset-logicaltable-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LogicalTableSource
            /// </summary>
            public LogicalTableSource Source { get; set; }
        }

        public class LogicalTableSource
        {
            /// <summary>
            /// PhysicalTableId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltablesource.html#cfn-quicksight-dataset-logicaltablesource-physicaltableid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhysicalTableId { get; set; }
            /// <summary>
            /// JoinInstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltablesource.html#cfn-quicksight-dataset-logicaltablesource-joininstruction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JoinInstruction
            /// </summary>
            public JoinInstruction JoinInstruction { get; set; }
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltablesource.html#cfn-quicksight-dataset-logicaltablesource-datasetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
        }

        public class LookbackWindow
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

        public class NewDefaultValues
        {
            /// <summary>
            /// DecimalStaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-newdefaultvalues.html#cfn-quicksight-dataset-newdefaultvalues-decimalstaticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> DecimalStaticValues { get; set; }
            /// <summary>
            /// IntegerStaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-newdefaultvalues.html#cfn-quicksight-dataset-newdefaultvalues-integerstaticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> IntegerStaticValues { get; set; }
            /// <summary>
            /// StringStaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-newdefaultvalues.html#cfn-quicksight-dataset-newdefaultvalues-stringstaticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringStaticValues { get; set; }
            /// <summary>
            /// DateTimeStaticValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-newdefaultvalues.html#cfn-quicksight-dataset-newdefaultvalues-datetimestaticvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DateTimeStaticValues { get; set; }
        }

        public class OutputColumn
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
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html#cfn-quicksight-dataset-outputcolumn-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class OverrideDatasetParameterOperation
        {
            /// <summary>
            /// NewDefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-overridedatasetparameteroperation.html#cfn-quicksight-dataset-overridedatasetparameteroperation-newdefaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NewDefaultValues
            /// </summary>
            public NewDefaultValues NewDefaultValues { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-overridedatasetparameteroperation.html#cfn-quicksight-dataset-overridedatasetparameteroperation-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
            /// <summary>
            /// NewParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-overridedatasetparameteroperation.html#cfn-quicksight-dataset-overridedatasetparameteroperation-newparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewParameterName { get; set; }
        }

        public class PhysicalTable
        {
            /// <summary>
            /// RelationalTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-relationaltable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelationalTable
            /// </summary>
            public RelationalTable RelationalTable { get; set; }
            /// <summary>
            /// CustomSql
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-customsql
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomSql
            /// </summary>
            public CustomSql CustomSql { get; set; }
            /// <summary>
            /// S3Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html#cfn-quicksight-dataset-physicaltable-s3source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Source
            /// </summary>
            public S3Source S3Source { get; set; }
        }

        public class ProjectOperation
        {
            /// <summary>
            /// ProjectedColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html#cfn-quicksight-dataset-projectoperation-projectedcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ProjectedColumns { get; set; }
        }

        public class RefreshConfiguration
        {
            /// <summary>
            /// IncrementalRefresh
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-refreshconfiguration.html#cfn-quicksight-dataset-refreshconfiguration-incrementalrefresh
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IncrementalRefresh
            /// </summary>
            public IncrementalRefresh IncrementalRefresh { get; set; }
        }

        public class RelationalTable
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
            public List<InputColumn> InputColumns { get; set; }
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

        public class RenameColumnOperation
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

        public class ResourcePermission
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

        public class RowLevelPermissionDataSet
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
            /// Namespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace { get; set; }
            /// <summary>
            /// PermissionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset-permissionpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PermissionPolicy { get; set; }
        }

        public class RowLevelPermissionTagConfiguration
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
            public List<RowLevelPermissionTagRule> TagRules { get; set; }
            /// <summary>
            /// TagRuleConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiontagconfiguration.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration-tagruleconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TagRuleConfigurations { get; set; }
        }

        public class RowLevelPermissionTagRule
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

        public class S3Source
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
            public List<InputColumn> InputColumns { get; set; }
            /// <summary>
            /// UploadSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html#cfn-quicksight-dataset-s3source-uploadsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UploadSettings
            /// </summary>
            public UploadSettings UploadSettings { get; set; }
        }

        public class StringDatasetParameter
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
            public StringDatasetParameterDefaultValues DefaultValues { get; set; }
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

        public class StringDatasetParameterDefaultValues
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

        public class TagColumnOperation
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tagcolumnoperation.html#cfn-quicksight-dataset-tagcolumnoperation-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tagcolumnoperation.html#cfn-quicksight-dataset-tagcolumnoperation-tags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnTag
            /// </summary>
            public List<ColumnTag> Tags { get; set; }
        }

        public class TransformOperation
        {
            /// <summary>
            /// TagColumnOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-tagcolumnoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagColumnOperation
            /// </summary>
            public TagColumnOperation TagColumnOperation { get; set; }
            /// <summary>
            /// UntagColumnOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-untagcolumnoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UntagColumnOperation
            /// </summary>
            public UntagColumnOperation UntagColumnOperation { get; set; }
            /// <summary>
            /// OverrideDatasetParameterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-overridedatasetparameteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideDatasetParameterOperation
            /// </summary>
            public OverrideDatasetParameterOperation OverrideDatasetParameterOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterOperation
            /// </summary>
            public FilterOperation FilterOperation { get; set; }
            /// <summary>
            /// CastColumnTypeOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-castcolumntypeoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CastColumnTypeOperation
            /// </summary>
            public CastColumnTypeOperation CastColumnTypeOperation { get; set; }
            /// <summary>
            /// CreateColumnsOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-createcolumnsoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreateColumnsOperation
            /// </summary>
            public CreateColumnsOperation CreateColumnsOperation { get; set; }
            /// <summary>
            /// RenameColumnOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-renamecolumnoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RenameColumnOperation
            /// </summary>
            public RenameColumnOperation RenameColumnOperation { get; set; }
            /// <summary>
            /// ProjectOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-projectoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProjectOperation
            /// </summary>
            public ProjectOperation ProjectOperation { get; set; }
        }

        public class UntagColumnOperation
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-untagcolumnoperation.html#cfn-quicksight-dataset-untagcolumnoperation-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// TagNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-untagcolumnoperation.html#cfn-quicksight-dataset-untagcolumnoperation-tagnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TagNames { get; set; }
        }

        public class UploadSettings
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
    }
}