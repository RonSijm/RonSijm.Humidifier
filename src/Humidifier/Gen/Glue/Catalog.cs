namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using CatalogTypes;

    public class Catalog : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public List<Humidifier.Glue.CatalogTypes.PrincipalPermissions> CreateTableDefaultPermissions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Parameters { get; set; }
        /// <summary>
        /// TargetRedshiftCatalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-targetredshiftcatalog
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetRedshiftCatalog
        /// </summary>
        public Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog TargetRedshiftCatalog { get; set; }
        /// <summary>
        /// AllowFullTableExternalDataAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-allowfulltableexternaldataaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AllowFullTableExternalDataAccess { get; set; }
        /// <summary>
        /// OverwriteChildResourcePermissionsWithDefault
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-overwritechildresourcepermissionswithdefault
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OverwriteChildResourcePermissionsWithDefault { get; set; }
        /// <summary>
        /// FederatedCatalog
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-federatedcatalog
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FederatedCatalog
        /// </summary>
        public Humidifier.Glue.CatalogTypes.FederatedCatalog FederatedCatalog { get; set; }
        /// <summary>
        /// CreateDatabaseDefaultPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-createdatabasedefaultpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PrincipalPermissions
        /// </summary>
        public List<Humidifier.Glue.CatalogTypes.PrincipalPermissions> CreateDatabaseDefaultPermissions { get; set; }
        /// <summary>
        /// CatalogProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-catalogproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CatalogProperties
        /// </summary>
        public Humidifier.Glue.CatalogTypes.CatalogProperties CatalogProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-catalog.html#cfn-glue-catalog-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CatalogTypes
    {
        public class CatalogProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataLakeAccessProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-catalogproperties.html#cfn-glue-catalog-catalogproperties-datalakeaccessproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLakeAccessProperties
            /// </summary>
            public Humidifier.Glue.CatalogTypes.DataLakeAccessProperties DataLakeAccessProperties { get; set; }
            /// <summary>
            /// CustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-catalogproperties.html#cfn-glue-catalog-catalogproperties-customproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomProperties { get; set; }
        }

        public class DataLakeAccessProperties : Humidifier.Base.BaseSubResource, IHaveKmsKey
        {
            /// <summary>
            /// RedshiftDatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-redshiftdatabasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedshiftDatabaseName { get; set; }
            /// <summary>
            /// CatalogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-catalogtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogType { get; set; }
            /// <summary>
            /// DataTransferRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-datatransferrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTransferRole { get; set; }
            /// <summary>
            /// ManagedWorkgroupStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-managedworkgroupstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagedWorkgroupStatus { get; set; }
            /// <summary>
            /// AllowFullTableExternalDataAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-allowfulltableexternaldataaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowFullTableExternalDataAccess { get; set; }
            /// <summary>
            /// ManagedWorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-managedworkgroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagedWorkgroupName { get; set; }
            /// <summary>
            /// DataLakeAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-datalakeaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataLakeAccess { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-datalakeaccessproperties.html#cfn-glue-catalog-datalakeaccessproperties-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKey { get; set; }
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
            public dynamic DataLakePrincipalIdentifier { get; set; }
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
            public dynamic ConnectionName { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-federatedcatalog.html#cfn-glue-catalog-federatedcatalog-identifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class PrincipalPermissions : Humidifier.Base.BaseSubResource, IHavePermissions
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-principalpermissions.html#cfn-glue-catalog-principalpermissions-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Permissions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-principalpermissions.html#cfn-glue-catalog-principalpermissions-principal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLakePrincipal
            /// </summary>
            public Humidifier.Glue.CatalogTypes.DataLakePrincipal Principal { get; set; }
        }

        public class TargetRedshiftCatalog : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CatalogArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-catalog-targetredshiftcatalog.html#cfn-glue-catalog-targetredshiftcatalog-catalogarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogArn { get; set; }
        }
    }
}