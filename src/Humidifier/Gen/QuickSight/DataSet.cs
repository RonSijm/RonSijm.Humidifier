namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using DataSetTypes;

    public class DataSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAwsAccountId
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
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataSetId { get; set; }
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
        /// PerformanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-performanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PerformanceConfiguration
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration PerformanceConfiguration { get; set; }
        /// <summary>
        /// RowLevelPermissionDataSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RowLevelPermissionDataSet
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }
        /// <summary>
        /// DataSetRefreshProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetrefreshproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSetRefreshProperties
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.DataSetRefreshProperties DataSetRefreshProperties { get; set; }
        /// <summary>
        /// RowLevelPermissionTagConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiontagconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RowLevelPermissionTagConfiguration
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration RowLevelPermissionTagConfiguration { get; set; }
        /// <summary>
        /// IngestionWaitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IngestionWaitPolicy
        /// </summary>
        public Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy IngestionWaitPolicy { get; set; }
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
        /// LogicalTableMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-logicaltablemap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: LogicalTable
        /// </summary>
        public Dictionary<string, Humidifier.QuickSight.DataSetTypes.LogicalTable> LogicalTableMap { get; set; }
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
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.DataSetTypes.ResourcePermission> Permissions { get; set; }
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

        public class ColumnTag : Humidifier.Base.BaseSubResource
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
            public Humidifier.QuickSight.DataSetTypes.ColumnDescription ColumnDescription { get; set; }
        }

        public class CreateColumnsOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html#cfn-quicksight-dataset-createcolumnsoperation-columns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculatedColumn
            /// </summary>
            public List<Humidifier.QuickSight.DataSetTypes.CalculatedColumn> Columns { get; set; }
        }

        public class CustomSql : Humidifier.Base.BaseSubResource, IHaveName, IHaveDataSourceArn
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
            /// Required: False
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

        public class FieldFolder : Humidifier.Base.BaseSubResource, IHaveDescription
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

        public class FilterOperation : Humidifier.Base.BaseSubResource
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

        public class GeoSpatialColumnGroup : Humidifier.Base.BaseSubResource, IHaveName, IHaveCountryCode
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

        public class InputColumn : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveSubType
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
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> StaticValues { get; set; }
        }

        public class JoinInstruction : Humidifier.Base.BaseSubResource, IHaveType
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
            public Humidifier.QuickSight.DataSetTypes.JoinKeyProperties LeftJoinKeyProperties { get; set; }
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
            public Humidifier.QuickSight.DataSetTypes.JoinKeyProperties RightJoinKeyProperties { get; set; }
        }

        public class JoinKeyProperties : Humidifier.Base.BaseSubResource
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

        public class LogicalTable : Humidifier.Base.BaseSubResource, IHaveAlias
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
            public List<Humidifier.QuickSight.DataSetTypes.TransformOperation> DataTransforms { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltable.html#cfn-quicksight-dataset-logicaltable-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogicalTableSource
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.LogicalTableSource Source { get; set; }
        }

        public class LogicalTableSource : Humidifier.Base.BaseSubResource, IHaveDataSetArn
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
            public Humidifier.QuickSight.DataSetTypes.JoinInstruction JoinInstruction { get; set; }
            /// <summary>
            /// DataSetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltablesource.html#cfn-quicksight-dataset-logicaltablesource-datasetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetArn { get; set; }
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

        public class NewDefaultValues : Humidifier.Base.BaseSubResource
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

        public class OutputColumn : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveSubType
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

        public class OverrideDatasetParameterOperation : Humidifier.Base.BaseSubResource, IHaveParameterName
        {
            /// <summary>
            /// NewDefaultValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-overridedatasetparameteroperation.html#cfn-quicksight-dataset-overridedatasetparameteroperation-newdefaultvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NewDefaultValues
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.NewDefaultValues NewDefaultValues { get; set; }
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

        public class ProjectOperation : Humidifier.Base.BaseSubResource
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
            /// Required: False
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

        public class RowLevelPermissionDataSet : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn
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
            /// PrimitiveType: Json
            /// </summary>
            public dynamic UploadSettings { get; set; }
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

        public class TagColumnOperation : Humidifier.Base.BaseSubResource, IHaveColumnName
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
            public List<Humidifier.QuickSight.DataSetTypes.ColumnTag> Tags { get; set; }
        }

        public class TransformOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TagColumnOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-tagcolumnoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagColumnOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.TagColumnOperation TagColumnOperation { get; set; }
            /// <summary>
            /// UntagColumnOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-untagcolumnoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UntagColumnOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.UntagColumnOperation UntagColumnOperation { get; set; }
            /// <summary>
            /// OverrideDatasetParameterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-overridedatasetparameteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideDatasetParameterOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.OverrideDatasetParameterOperation OverrideDatasetParameterOperation { get; set; }
            /// <summary>
            /// FilterOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-filteroperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.FilterOperation FilterOperation { get; set; }
            /// <summary>
            /// CastColumnTypeOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-castcolumntypeoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CastColumnTypeOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.CastColumnTypeOperation CastColumnTypeOperation { get; set; }
            /// <summary>
            /// RenameColumnOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-renamecolumnoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RenameColumnOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.RenameColumnOperation RenameColumnOperation { get; set; }
            /// <summary>
            /// CreateColumnsOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-createcolumnsoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreateColumnsOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.CreateColumnsOperation CreateColumnsOperation { get; set; }
            /// <summary>
            /// ProjectOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html#cfn-quicksight-dataset-transformoperation-projectoperation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProjectOperation
            /// </summary>
            public Humidifier.QuickSight.DataSetTypes.ProjectOperation ProjectOperation { get; set; }
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

        public class UntagColumnOperation : Humidifier.Base.BaseSubResource, IHaveColumnName
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
    }
}