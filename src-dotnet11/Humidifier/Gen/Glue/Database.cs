namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using DatabaseTypes;

    public class Database : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDatabaseName, IHaveGlueDatabaseTypesDatabaseInputDatabaseInput, IHaveCatalogId
    {
        public override string AWSTypeName { get => AWS.Glue.Database; }
        public Union<string, BaseFunction>? DatabaseName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DatabaseInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html#cfn-glue-database-databaseinput
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DatabaseInput
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.DatabaseTypes.DatabaseInput, BaseFunction>? DatabaseInput { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html#cfn-glue-database-catalogid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CatalogId { get; set; }
    }

    namespace DatabaseTypes
    {
        public class DataLakePrincipal : Humidifier.Base.BaseSubResource, IHaveDataLakePrincipalIdentifier
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-datalakeprincipal.html#cfn-glue-database-datalakeprincipal-datalakeprincipalidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLakePrincipalIdentifier { get; set; }
        }

        public class DatabaseIdentifier : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveRegion, IHaveCatalogId
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class DatabaseInput : Humidifier.Base.BaseSubResource, IHaveLocationUri, IHaveListOfGlueDatabaseTypesPrincipalPrivilegesCreateTableDefaultPermissions, IHaveDescription, IHaveParameters_Json, IHaveGlueDatabaseTypesDatabaseIdentifierTargetDatabase, IHaveGlueDatabaseTypesFederatedDatabaseFederatedDatabase, IHaveName
        {
            /// <summary>
            /// LocationUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-locationuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocationUri { get; set; }
            /// <summary>
            /// CreateTableDefaultPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-createtabledefaultpermissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrincipalPrivileges
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.DatabaseTypes.PrincipalPrivileges>, IReadOnlyList<Union<Humidifier.Glue.DatabaseTypes.PrincipalPrivileges, BaseFunction>>, BaseFunction>? CreateTableDefaultPermissions { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// TargetDatabase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-targetdatabase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseIdentifier
            /// </summary>
            public Union<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier, BaseFunction>? TargetDatabase { get; set; }
            /// <summary>
            /// FederatedDatabase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-federateddatabase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FederatedDatabase
            /// </summary>
            public Union<Humidifier.Glue.DatabaseTypes.FederatedDatabase, BaseFunction>? FederatedDatabase { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FederatedDatabase : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveIdentifier
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-federateddatabase.html#cfn-glue-database-federateddatabase-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-federateddatabase.html#cfn-glue-database-federateddatabase-identifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }

        public class PrincipalPrivileges : Humidifier.Base.BaseSubResource, IHaveStringListOfPermissions, IHaveGlueDatabaseTypesDataLakePrincipalPrincipal
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-principalprivileges.html#cfn-glue-database-principalprivileges-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-principalprivileges.html#cfn-glue-database-principalprivileges-principal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLakePrincipal
            /// </summary>
            public Union<Humidifier.Glue.DatabaseTypes.DataLakePrincipal, BaseFunction>? Principal { get; set; }
        }
    }
}