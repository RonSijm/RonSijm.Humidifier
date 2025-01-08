namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using DatabaseTypes;

    public class Database : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDatabaseName, IHaveCatalogId
    {
        public override string AWSTypeName { get => AWS.Glue.Database; }
        public dynamic DatabaseName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DatabaseInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html#cfn-glue-database-databaseinput
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DatabaseInput
        /// </summary>
        [Required]
        public Humidifier.Glue.DatabaseTypes.DatabaseInput DatabaseInput { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html#cfn-glue-database-catalogid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CatalogId { get; set; }
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
            public dynamic DataLakePrincipalIdentifier { get; set; }
        }

        public class DatabaseIdentifier : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveCatalogId, IHaveRegion
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
        }

        public class DatabaseInput : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveParameters, IHaveLocationUri
        {
            /// <summary>
            /// LocationUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-locationuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocationUri { get; set; }
            /// <summary>
            /// CreateTableDefaultPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-createtabledefaultpermissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrincipalPrivileges
            /// </summary>
            public List<Humidifier.Glue.DatabaseTypes.PrincipalPrivileges> CreateTableDefaultPermissions { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Parameters { get; set; }
            /// <summary>
            /// TargetDatabase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-targetdatabase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseIdentifier
            /// </summary>
            public Humidifier.Glue.DatabaseTypes.DatabaseIdentifier TargetDatabase { get; set; }
            /// <summary>
            /// FederatedDatabase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-federateddatabase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FederatedDatabase
            /// </summary>
            public Humidifier.Glue.DatabaseTypes.FederatedDatabase FederatedDatabase { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html#cfn-glue-database-databaseinput-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic ConnectionName { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-federateddatabase.html#cfn-glue-database-federateddatabase-identifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class PrincipalPrivileges : Humidifier.Base.BaseSubResource, IHavePermissions
        {
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-principalprivileges.html#cfn-glue-database-principalprivileges-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Permissions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-principalprivileges.html#cfn-glue-database-principalprivileges-principal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataLakePrincipal
            /// </summary>
            public Humidifier.Glue.DatabaseTypes.DataLakePrincipal Principal { get; set; }
        }
    }
}