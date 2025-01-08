namespace Humidifier.LakeFormation
{
    using System.Collections.Generic;
    using PermissionsTypes;

    public class Permissions : Humidifier.Base.BaseResource, IHavePermissionsWithGrantOption
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
        public Humidifier.LakeFormation.PermissionsTypes.DataLakePrincipal DataLakePrincipal { get; set; }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-resource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Resource
        /// </summary>
        [Required]
        public Humidifier.LakeFormation.PermissionsTypes.Resource Resource { get; set; }
        /// <summary>
        /// Permissions_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Permissions_ { get; set; }
        /// <summary>
        /// PermissionsWithGrantOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissionswithgrantoption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PermissionsWithGrantOption { get; set; }
    }

    namespace PermissionsTypes
    {
        public class ColumnWildcard : Humidifier.Base.BaseSubResource, IHaveExcludedColumnNames
        {
            /// <summary>
            /// ExcludedColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-columnwildcard.html#cfn-lakeformation-permissions-columnwildcard-excludedcolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedColumnNames { get; set; }
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
            public dynamic DataLakePrincipalIdentifier { get; set; }
        }

        public class DataLocationResource : Humidifier.Base.BaseSubResource, IHaveCatalogId
        {
            /// <summary>
            /// S3Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalocationresource.html#cfn-lakeformation-permissions-datalocationresource-s3resource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Resource { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalocationresource.html#cfn-lakeformation-permissions-datalocationresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
        }

        public class DatabaseResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveCatalogId
        {
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-databaseresource.html#cfn-lakeformation-permissions-databaseresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-databaseresource.html#cfn-lakeformation-permissions-databaseresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TableResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tableresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableResource
            /// </summary>
            public Humidifier.LakeFormation.PermissionsTypes.TableResource TableResource { get; set; }
            /// <summary>
            /// DatabaseResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-databaseresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseResource
            /// </summary>
            public Humidifier.LakeFormation.PermissionsTypes.DatabaseResource DatabaseResource { get; set; }
            /// <summary>
            /// DataLocationResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-datalocationresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLocationResource
            /// </summary>
            public Humidifier.LakeFormation.PermissionsTypes.DataLocationResource DataLocationResource { get; set; }
            /// <summary>
            /// TableWithColumnsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tablewithcolumnsresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableWithColumnsResource
            /// </summary>
            public Humidifier.LakeFormation.PermissionsTypes.TableWithColumnsResource TableWithColumnsResource { get; set; }
        }

        public class TableResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveDatabaseName, IHaveCatalogId
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
            /// <summary>
            /// TableWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-tablewildcard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableWildcard
            /// </summary>
            public Humidifier.LakeFormation.PermissionsTypes.TableWildcard TableWildcard { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TableWildcard : Humidifier.Base.BaseSubResource
        {
        }

        public class TableWithColumnsResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveDatabaseName, IHaveCatalogId, IHaveColumnNames
        {
            /// <summary>
            /// ColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-columnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ColumnNames { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// ColumnWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html#cfn-lakeformation-permissions-tablewithcolumnsresource-columnwildcard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnWildcard
            /// </summary>
            public Humidifier.LakeFormation.PermissionsTypes.ColumnWildcard ColumnWildcard { get; set; }
        }
    }
}