namespace Humidifier.LakeFormation
{
    using global::System.Collections.Generic;
    using PrincipalPermissionsTypes;

    public class PrincipalPermissions : Humidifier.Base.BaseResource, IHaveLakeFormationPrincipalPermissionsTypesResourceResource, IHaveStringListOfPermissions, IHaveCatalog, IHaveLakeFormationPrincipalPermissionsTypesDataLakePrincipalPrincipal, IHaveStringListOfPermissionsWithGrantOption
    {
        public class Attributes
        {
            public static string ResourceIdentifier =  "ResourceIdentifier" ;
            public static string PrincipalIdentifier =  "PrincipalIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.LakeFormation.PrincipalPermissions; }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-principalpermissions.html#cfn-lakeformation-principalpermissions-resource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Resource
        /// </summary>
        [Required]
        public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.Resource, BaseFunction>? Resource { get; set; }

        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-principalpermissions.html#cfn-lakeformation-principalpermissions-permissions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// Catalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-principalpermissions.html#cfn-lakeformation-principalpermissions-catalog
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Catalog { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-principalpermissions.html#cfn-lakeformation-principalpermissions-principal
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DataLakePrincipal
        /// </summary>
        [Required]
        public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLakePrincipal, BaseFunction>? Principal { get; set; }

        /// <summary>
        /// PermissionsWithGrantOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-principalpermissions.html#cfn-lakeformation-principalpermissions-permissionswithgrantoption
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PermissionsWithGrantOption { get; set; }
    }

    namespace PrincipalPermissionsTypes
    {
        public class CatalogResource : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-catalogresource.html#cfn-lakeformation-principalpermissions-catalogresource-id
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class ColumnWildcard : Humidifier.Base.BaseSubResource, IHaveStringListOfExcludedColumnNames
        {
            /// <summary>
            /// ExcludedColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-columnwildcard.html#cfn-lakeformation-principalpermissions-columnwildcard-excludedcolumnnames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedColumnNames { get; set; }
        }

        public class DataCellsFilterResource : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDatabaseName, IHaveTableCatalogId, IHaveName
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datacellsfilterresource.html#cfn-lakeformation-principalpermissions-datacellsfilterresource-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datacellsfilterresource.html#cfn-lakeformation-principalpermissions-datacellsfilterresource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// TableCatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datacellsfilterresource.html#cfn-lakeformation-principalpermissions-datacellsfilterresource-tablecatalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableCatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datacellsfilterresource.html#cfn-lakeformation-principalpermissions-datacellsfilterresource-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DataLakePrincipal : Humidifier.Base.BaseSubResource, IHaveDataLakePrincipalIdentifier
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datalakeprincipal.html#cfn-lakeformation-principalpermissions-datalakeprincipal-datalakeprincipalidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLakePrincipalIdentifier { get; set; }
        }

        public class DataLocationResource : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHaveCatalogId
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datalocationresource.html#cfn-lakeformation-principalpermissions-datalocationresource-resourcearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-datalocationresource.html#cfn-lakeformation-principalpermissions-datalocationresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class DatabaseResource : Humidifier.Base.BaseSubResource, IHaveCatalogId, IHaveName
        {
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-databaseresource.html#cfn-lakeformation-principalpermissions-databaseresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-databaseresource.html#cfn-lakeformation-principalpermissions-databaseresource-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LFTag : Humidifier.Base.BaseSubResource, IHaveTagKey, IHaveStringListOfTagValues
        {
            /// <summary>
            /// TagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftag.html#cfn-lakeformation-principalpermissions-lftag-tagkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagKey { get; set; }
            /// <summary>
            /// TagValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftag.html#cfn-lakeformation-principalpermissions-lftag-tagvalues
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagValues { get; set; }
        }

        public class LFTagKeyResource : Humidifier.Base.BaseSubResource, IHaveTagKey, IHaveCatalogId, IHaveStringListOfTagValues
        {
            /// <summary>
            /// TagKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftagkeyresource.html#cfn-lakeformation-principalpermissions-lftagkeyresource-tagkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagKey { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftagkeyresource.html#cfn-lakeformation-principalpermissions-lftagkeyresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// TagValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftagkeyresource.html#cfn-lakeformation-principalpermissions-lftagkeyresource-tagvalues
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagValues { get; set; }
        }

        public class LFTagPolicyResource : Humidifier.Base.BaseSubResource, IHaveListOfLakeFormationPrincipalPermissionsTypesLFTagExpression, IHaveResourceType, IHaveCatalogId
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftagpolicyresource.html#cfn-lakeformation-principalpermissions-lftagpolicyresource-expression
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LFTag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTag>, IReadOnlyList<Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTag, BaseFunction>>, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftagpolicyresource.html#cfn-lakeformation-principalpermissions-lftagpolicyresource-resourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-lftagpolicyresource.html#cfn-lakeformation-principalpermissions-lftagpolicyresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource, IHaveLakeFormationPrincipalPermissionsTypesLFTagKeyResourceLFTag, IHaveLakeFormationPrincipalPermissionsTypesTableResourceTable, IHaveLakeFormationPrincipalPermissionsTypesDataCellsFilterResourceDataCellsFilter, IHaveLakeFormationPrincipalPermissionsTypesTableWithColumnsResourceTableWithColumns, IHaveLakeFormationPrincipalPermissionsTypesLFTagPolicyResourceLFTagPolicy, IHaveLakeFormationPrincipalPermissionsTypesDatabaseResourceDatabase, IHaveLakeFormationPrincipalPermissionsTypesDataLocationResourceDataLocation, IHaveLakeFormationPrincipalPermissionsTypesCatalogResourceCatalog
        {
            /// <summary>
            /// LFTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-lftag
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LFTagKeyResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagKeyResource, BaseFunction>? LFTag { get; set; }
            /// <summary>
            /// Table
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-table
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TableResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.TableResource, BaseFunction>? Table { get; set; }
            /// <summary>
            /// DataCellsFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-datacellsfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DataCellsFilterResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataCellsFilterResource, BaseFunction>? DataCellsFilter { get; set; }
            /// <summary>
            /// TableWithColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-tablewithcolumns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TableWithColumnsResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.TableWithColumnsResource, BaseFunction>? TableWithColumns { get; set; }
            /// <summary>
            /// LFTagPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-lftagpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LFTagPolicyResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagPolicyResource, BaseFunction>? LFTagPolicy { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-database
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DatabaseResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.DatabaseResource, BaseFunction>? Database { get; set; }
            /// <summary>
            /// DataLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-datalocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DataLocationResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataLocationResource, BaseFunction>? DataLocation { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-resource.html#cfn-lakeformation-principalpermissions-resource-catalog
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CatalogResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.CatalogResource, BaseFunction>? Catalog { get; set; }
        }

        public class TableResource : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveCatalogId, IHaveTableWildcard_Json, IHaveName
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tableresource.html#cfn-lakeformation-principalpermissions-tableresource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tableresource.html#cfn-lakeformation-principalpermissions-tableresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// TableWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tableresource.html#cfn-lakeformation-principalpermissions-tableresource-tablewildcard
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? TableWildcard { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tableresource.html#cfn-lakeformation-principalpermissions-tableresource-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TableWithColumnsResource : Humidifier.Base.BaseSubResource, IHaveStringListOfColumnNames, IHaveDatabaseName, IHaveCatalogId, IHaveName, IHaveLakeFormationPrincipalPermissionsTypesColumnWildcardColumnWildcard
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tablewithcolumnsresource.html#cfn-lakeformation-principalpermissions-tablewithcolumnsresource-columnnames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tablewithcolumnsresource.html#cfn-lakeformation-principalpermissions-tablewithcolumnsresource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tablewithcolumnsresource.html#cfn-lakeformation-principalpermissions-tablewithcolumnsresource-catalogid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tablewithcolumnsresource.html#cfn-lakeformation-principalpermissions-tablewithcolumnsresource-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ColumnWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-principalpermissions-tablewithcolumnsresource.html#cfn-lakeformation-principalpermissions-tablewithcolumnsresource-columnwildcard
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ColumnWildcard
            /// </summary>
            public Union<Humidifier.LakeFormation.PrincipalPermissionsTypes.ColumnWildcard, BaseFunction>? ColumnWildcard { get; set; }
        }
    }
}