namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using CatalogTypes;

    public class Catalog : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfGlueCatalogTypesPrincipalPermissionsCreateTableDefaultPermissions, IHaveDescription, IHaveStringDictionaryOfParameters, IHaveGlueCatalogTypesTargetRedshiftCatalogTargetRedshiftCatalog, IHaveAllowFullTableExternalDataAccess, IHaveOverwriteChildResourcePermissionsWithDefault, IHaveGlueCatalogTypesFederatedCatalogFederatedCatalog, IHaveListOfGlueCatalogTypesPrincipalPermissionsCreateDatabaseDefaultPermissions, IHaveGlueCatalogTypesCatalogPropertiesCatalogProperties, IHaveName
    {
        public class Attributes
        {
            public static string ResourceArn =  "ResourceArn" ;
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string CatalogId =  "CatalogId" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Catalog; }
        /// <summary>
        /// CreateTableDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-createtabledefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PrincipalPermissions
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Glue.CatalogTypes.PrincipalPermissions>, IReadOnlyList<Union<Humidifier.Glue.CatalogTypes.PrincipalPermissions, BaseFunction>>, BaseFunction>? CreateTableDefaultPermissions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// TargetRedshiftCatalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-targetredshiftcatalog
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetRedshiftCatalog
        /// </summary>
        public Union<Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog, BaseFunction>? TargetRedshiftCatalog { get; set; }
        /// <summary>
        /// AllowFullTableExternalDataAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-allowfulltableexternaldataaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllowFullTableExternalDataAccess { get; set; }
        /// <summary>
        /// OverwriteChildResourcePermissionsWithDefault
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-overwritechildresourcepermissionswithdefault
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OverwriteChildResourcePermissionsWithDefault { get; set; }
        /// <summary>
        /// FederatedCatalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-federatedcatalog
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FederatedCatalog
        /// </summary>
        public Union<Humidifier.Glue.CatalogTypes.FederatedCatalog, BaseFunction>? FederatedCatalog { get; set; }
        /// <summary>
        /// CreateDatabaseDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-createdatabasedefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PrincipalPermissions
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Glue.CatalogTypes.PrincipalPermissions>, IReadOnlyList<Union<Humidifier.Glue.CatalogTypes.PrincipalPermissions, BaseFunction>>, BaseFunction>? CreateDatabaseDefaultPermissions { get; set; }
        /// <summary>
        /// CatalogProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-catalogproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CatalogProperties
        /// </summary>
        public Union<Humidifier.Glue.CatalogTypes.CatalogProperties, BaseFunction>? CatalogProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CatalogTypes
    {
        public class CatalogProperties : Humidifier.Base.BaseSubResource, IHaveGlueCatalogTypesDataLakeAccessPropertiesDataLakeAccessProperties, IHaveStringDictionaryOfCustomProperties
        {
            /// <summary>
            /// DataLakeAccessProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-catalogproperties.html#cfn-glue-catalog-catalogproperties-datalakeaccessproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLakeAccessProperties
            /// </summary>
            public Union<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties, BaseFunction>? DataLakeAccessProperties { get; set; }
            /// <summary>
            /// CustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-catalogproperties.html#cfn-glue-catalog-catalogproperties-customproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomProperties { get; set; }
        }

        public class DataLakeAccessProperties : Humidifier.Base.BaseSubResource, IHaveRedshiftDatabaseName, IHaveCatalogType, IHaveDataTransferRole, IHaveManagedWorkgroupStatus, IHaveAllowFullTableExternalDataAccess, IHaveManagedWorkgroupName, IHaveDataLakeAccess_Boolean, IHaveKmsKey
        {
            /// <summary>
            /// RedshiftDatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-redshiftdatabasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedshiftDatabaseName { get; set; }
            /// <summary>
            /// CatalogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-catalogtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogType { get; set; }
            /// <summary>
            /// DataTransferRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-datatransferrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTransferRole { get; set; }
            /// <summary>
            /// ManagedWorkgroupStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-managedworkgroupstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedWorkgroupStatus { get; set; }
            /// <summary>
            /// AllowFullTableExternalDataAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-allowfulltableexternaldataaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowFullTableExternalDataAccess { get; set; }
            /// <summary>
            /// ManagedWorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-managedworkgroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedWorkgroupName { get; set; }
            /// <summary>
            /// DataLakeAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-datalakeaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DataLakeAccess { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class DataLakePrincipal : Humidifier.Base.BaseSubResource, IHaveDataLakePrincipalIdentifier
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeprincipal.html#cfn-glue-catalog-datalakeprincipal-datalakeprincipalidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLakePrincipalIdentifier { get; set; }
        }

        public class FederatedCatalog : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveIdentifier
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-federatedcatalog.html#cfn-glue-catalog-federatedcatalog-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-federatedcatalog.html#cfn-glue-catalog-federatedcatalog-identifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }

        public class PrincipalPermissions : Humidifier.Base.BaseSubResource, IHaveStringListOfPermissions, IHaveGlueCatalogTypesDataLakePrincipalPrincipal
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-principalpermissions.html#cfn-glue-catalog-principalpermissions-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-principalpermissions.html#cfn-glue-catalog-principalpermissions-principal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLakePrincipal
            /// </summary>
            public Union<Humidifier.Glue.CatalogTypes.DataLakePrincipal, BaseFunction>? Principal { get; set; }
        }

        public class TargetRedshiftCatalog : Humidifier.Base.BaseSubResource, IHaveCatalogArn
        {
            /// <summary>
            /// CatalogArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-targetredshiftcatalog.html#cfn-glue-catalog-targetredshiftcatalog-catalogarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogArn { get; set; }
        }
    }
}