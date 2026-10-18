namespace Humidifier.LakeFormation
{
    using global::System.Collections.Generic;
    using PermissionsTypes;

    public class Permissions : Humidifier.Base.BaseResource, IHaveLakeFormationPermissionsTypesDataLakePrincipalDataLakePrincipal, IHaveLakeFormationPermissionsTypesResourceResource, IHaveStringListOfPermissions_, IHaveStringListOfPermissionsWithGrantOption
    {
        public override string AWSTypeName { get => AWS.LakeFormation.Permissions; }

        /// <summary>
        /// DataLakePrincipal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-datalakeprincipal
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DataLakePrincipal
        /// </summary>
        [Required]
        public Union<Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal, BaseFunction>? DataLakePrincipal { get; set; }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-resource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Resource
        /// </summary>
        [Required]
        public Union<Humidifier.LakeFormation.PermissionsTypes.Resource, BaseFunction>? Resource { get; set; }
        /// <summary>
        /// Permissions_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions_ { get; set; }
        /// <summary>
        /// PermissionsWithGrantOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissionswithgrantoption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PermissionsWithGrantOption { get; set; }
    }

    namespace PermissionsTypes
    {
        public class ColumnWildcard : Humidifier.Base.BaseSubResource, IHaveStringListOfExcludedColumnNames
        {
            /// <summary>
            /// ExcludedColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-columnwildcard.html#cfn-lakeformation-permissions-columnwildcard-excludedcolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedColumnNames { get; set; }
        }

        public class DataLakePrincipal : Humidifier.Base.BaseSubResource, IHaveDataLakePrincipalIdentifier
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalakeprincipal.html#cfn-lakeformation-permissions-datalakeprincipal-datalakeprincipalidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLakePrincipalIdentifier { get; set; }
        }

        public class DataLocationResource : Humidifier.Base.BaseSubResource, IHaveS3Resource, IHaveCatalogId
        {
            /// <summary>
            /// S3Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalocationresource.html#cfn-lakeformation-permissions-datalocationresource-s3resource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Resource { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalocationresource.html#cfn-lakeformation-permissions-datalocationresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class DatabaseResource : Humidifier.Base.BaseSubResource, IHaveCatalogId, IHaveName
        {
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-databaseresource.html#cfn-lakeformation-permissions-databaseresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-databaseresource.html#cfn-lakeformation-permissions-databaseresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource, IHaveLakeFormationPermissionsTypesTableResourceTableResource, IHaveLakeFormationPermissionsTypesDatabaseResourceDatabaseResource, IHaveLakeFormationPermissionsTypesDataLocationResourceDataLocationResource, IHaveLakeFormationPermissionsTypesTableWithColumnsResourceTableWithColumnsResource
        {
            /// <summary>
            /// TableResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tableresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PermissionsTypes.TableResource, BaseFunction>? TableResource { get; set; }
            /// <summary>
            /// DatabaseResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-databaseresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PermissionsTypes.DatabaseResource, BaseFunction>? DatabaseResource { get; set; }
            /// <summary>
            /// DataLocationResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-datalocationresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLocationResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PermissionsTypes.DataLocationResource, BaseFunction>? DataLocationResource { get; set; }
            /// <summary>
            /// TableWithColumnsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tablewithcolumnsresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableWithColumnsResource
            /// </summary>
            public Union<Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource, BaseFunction>? TableWithColumnsResource { get; set; }
        }

        public class TableResource : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveCatalogId, IHaveLakeFormationPermissionsTypesTableWildcardTableWildcard, IHaveName
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// TableWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-tablewildcard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableWildcard
            /// </summary>
            public Union<Humidifier.LakeFormation.PermissionsTypes.TableWildcard, BaseFunction>? TableWildcard { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TableWildcard : Humidifier.Base.BaseSubResource
        {
        }

        public class TableWithColumnsResource : Humidifier.Base.BaseSubResource, IHaveStringListOfColumnNames, IHaveDatabaseName, IHaveCatalogId, IHaveName, IHaveLakeFormationPermissionsTypesColumnWildcardColumnWildcard
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-columnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnNames { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ColumnWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-columnwildcard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnWildcard
            /// </summary>
            public Union<Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard, BaseFunction>? ColumnWildcard { get; set; }
        }
    }
}