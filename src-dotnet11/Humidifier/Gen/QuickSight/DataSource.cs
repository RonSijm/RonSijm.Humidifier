namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveQuickSightDataSourceTypesDataSourceErrorInfoErrorInfo, IHaveStringListOfFolderArns, IHaveName, IHaveQuickSightDataSourceTypesDataSourceParametersDataSourceParameters, IHaveType, IHaveQuickSightDataSourceTypesVpcConnectionPropertiesVpcConnectionProperties, IHaveListOfQuickSightDataSourceTypesDataSourceParametersAlternateDataSourceParameters, IHaveAwsAccountId, IHaveListOfQuickSightDataSourceTypesResourcePermissionPermissions, IHaveQuickSightDataSourceTypesSslPropertiesSslProperties, IHaveQuickSightDataSourceTypesDataSourceCredentialsCredentials, IHaveDataSourceId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.DataSource; }
        /// <summary>
        /// ErrorInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-errorinfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceErrorInfo
        /// </summary>
        public Union<Humidifier.QuickSight.DataSourceTypes.DataSourceErrorInfo, BaseFunction>? ErrorInfo { get; set; }
        /// <summary>
        /// FolderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-folderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FolderArns { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DataSourceParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-datasourceparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceParameters
        /// </summary>
        public Union<Humidifier.QuickSight.DataSourceTypes.DataSourceParameters, BaseFunction>? DataSourceParameters { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// VpcConnectionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-vpcconnectionproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConnectionProperties
        /// </summary>
        public Union<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties, BaseFunction>? VpcConnectionProperties { get; set; }
        /// <summary>
        /// AlternateDataSourceParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-alternatedatasourceparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataSourceParameters
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.DataSourceTypes.DataSourceParameters>, IReadOnlyList<Union<Humidifier.QuickSight.DataSourceTypes.DataSourceParameters, BaseFunction>>, BaseFunction>? AlternateDataSourceParameters { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.DataSourceTypes.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.DataSourceTypes.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// SslProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-sslproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SslProperties
        /// </summary>
        public Union<Humidifier.QuickSight.DataSourceTypes.SslProperties, BaseFunction>? SslProperties { get; set; }
        /// <summary>
        /// Credentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-credentials
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceCredentials
        /// </summary>
        public Union<Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials, BaseFunction>? Credentials { get; set; }
        /// <summary>
        /// DataSourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-datasourceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataSourceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html#cfn-quicksight-datasource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataSourceTypes
    {
        public class AmazonElasticsearchParameters : Humidifier.Base.BaseSubResource, IHaveDomain
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-amazonelasticsearchparameters.html#cfn-quicksight-datasource-amazonelasticsearchparameters-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class AmazonOpenSearchParameters : Humidifier.Base.BaseSubResource, IHaveDomain
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-amazonopensearchparameters.html#cfn-quicksight-datasource-amazonopensearchparameters-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class AthenaParameters : Humidifier.Base.BaseSubResource, IHaveWorkGroup, IHaveConsumerAccountRoleArn, IHaveQuickSightDataSourceTypesIdentityCenterConfigurationIdentityCenterConfiguration, IHaveRoleArn
        {
            /// <summary>
            /// WorkGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-athenaparameters.html#cfn-quicksight-datasource-athenaparameters-workgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkGroup { get; set; }
            /// <summary>
            /// ConsumerAccountRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-athenaparameters.html#cfn-quicksight-datasource-athenaparameters-consumeraccountrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumerAccountRoleArn { get; set; }
            /// <summary>
            /// IdentityCenterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-athenaparameters.html#cfn-quicksight-datasource-athenaparameters-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration, BaseFunction>? IdentityCenterConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-athenaparameters.html#cfn-quicksight-datasource-athenaparameters-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class AuroraParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-auroraparameters.html#cfn-quicksight-datasource-auroraparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-auroraparameters.html#cfn-quicksight-datasource-auroraparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-auroraparameters.html#cfn-quicksight-datasource-auroraparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class AuroraPostgreSqlParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-aurorapostgresqlparameters.html#cfn-quicksight-datasource-aurorapostgresqlparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-aurorapostgresqlparameters.html#cfn-quicksight-datasource-aurorapostgresqlparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-aurorapostgresqlparameters.html#cfn-quicksight-datasource-aurorapostgresqlparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class CredentialPair : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDataSourceTypesDataSourceParametersAlternateDataSourceParameters, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// AlternateDataSourceParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-credentialpair.html#cfn-quicksight-datasource-credentialpair-alternatedatasourceparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataSourceParameters
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DataSourceTypes.DataSourceParameters>, IReadOnlyList<Union<Humidifier.QuickSight.DataSourceTypes.DataSourceParameters, BaseFunction>>, BaseFunction>? AlternateDataSourceParameters { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-credentialpair.html#cfn-quicksight-datasource-credentialpair-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-credentialpair.html#cfn-quicksight-datasource-credentialpair-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class DataSourceCredentials : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveCopySourceArn, IHaveQuickSightDataSourceTypesCredentialPairCredentialPair, IHaveQuickSightDataSourceTypesKeyPairCredentialsKeyPairCredentials, IHaveQuickSightDataSourceTypesOAuthClientCredentialsOAuthClientCredentials
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourcecredentials.html#cfn-quicksight-datasource-datasourcecredentials-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// CopySourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourcecredentials.html#cfn-quicksight-datasource-datasourcecredentials-copysourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CopySourceArn { get; set; }
            /// <summary>
            /// CredentialPair
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourcecredentials.html#cfn-quicksight-datasource-datasourcecredentials-credentialpair
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CredentialPair
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.CredentialPair, BaseFunction>? CredentialPair { get; set; }
            /// <summary>
            /// KeyPairCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourcecredentials.html#cfn-quicksight-datasource-datasourcecredentials-keypaircredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyPairCredentials
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials, BaseFunction>? KeyPairCredentials { get; set; }
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourcecredentials.html#cfn-quicksight-datasource-datasourcecredentials-oauthclientcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthClientCredentials
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.OAuthClientCredentials, BaseFunction>? OAuthClientCredentials { get; set; }
        }

        public class DataSourceErrorInfo : Humidifier.Base.BaseSubResource, IHaveType, IHaveMessage
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceerrorinfo.html#cfn-quicksight-datasource-datasourceerrorinfo-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceerrorinfo.html#cfn-quicksight-datasource-datasourceerrorinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
        }

        public class DataSourceParameters : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSourceTypesS3TablesParametersS3TablesParameters, IHaveQuickSightDataSourceTypesAuroraPostgreSqlParametersAuroraPostgreSqlParameters, IHaveQuickSightDataSourceTypesTeradataParametersTeradataParameters, IHaveQuickSightDataSourceTypesRdsParametersRdsParameters, IHaveQuickSightDataSourceTypesAthenaParametersAthenaParameters, IHaveQuickSightDataSourceTypesSparkParametersSparkParameters, IHaveQuickSightDataSourceTypesMariaDbParametersMariaDbParameters, IHaveQuickSightDataSourceTypesOracleParametersOracleParameters, IHaveQuickSightDataSourceTypesPrestoParametersPrestoParameters, IHaveQuickSightDataSourceTypesStarburstParametersStarburstParameters, IHaveQuickSightDataSourceTypesRedshiftParametersRedshiftParameters, IHaveQuickSightDataSourceTypesMySqlParametersMySqlParameters, IHaveQuickSightDataSourceTypesSqlServerParametersSqlServerParameters, IHaveQuickSightDataSourceTypesSnowflakeParametersSnowflakeParameters, IHaveQuickSightDataSourceTypesAmazonElasticsearchParametersAmazonElasticsearchParameters, IHaveQuickSightDataSourceTypesAmazonOpenSearchParametersAmazonOpenSearchParameters, IHaveQuickSightDataSourceTypesPostgreSqlParametersPostgreSqlParameters, IHaveQuickSightDataSourceTypesAuroraParametersAuroraParameters, IHaveQuickSightDataSourceTypesS3ParametersS3Parameters, IHaveQuickSightDataSourceTypesTrinoParametersTrinoParameters, IHaveQuickSightDataSourceTypesDatabricksParametersDatabricksParameters
        {
            /// <summary>
            /// S3TablesParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-s3tablesparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3TablesParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.S3TablesParameters, BaseFunction>? S3TablesParameters { get; set; }
            /// <summary>
            /// AuroraPostgreSqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-aurorapostgresqlparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuroraPostgreSqlParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.AuroraPostgreSqlParameters, BaseFunction>? AuroraPostgreSqlParameters { get; set; }
            /// <summary>
            /// TeradataParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-teradataparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TeradataParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.TeradataParameters, BaseFunction>? TeradataParameters { get; set; }
            /// <summary>
            /// RdsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-rdsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.RdsParameters, BaseFunction>? RdsParameters { get; set; }
            /// <summary>
            /// AthenaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-athenaparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AthenaParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.AthenaParameters, BaseFunction>? AthenaParameters { get; set; }
            /// <summary>
            /// SparkParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-sparkparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SparkParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.SparkParameters, BaseFunction>? SparkParameters { get; set; }
            /// <summary>
            /// MariaDbParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-mariadbparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MariaDbParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.MariaDbParameters, BaseFunction>? MariaDbParameters { get; set; }
            /// <summary>
            /// OracleParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-oracleparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OracleParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.OracleParameters, BaseFunction>? OracleParameters { get; set; }
            /// <summary>
            /// PrestoParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-prestoparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrestoParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.PrestoParameters, BaseFunction>? PrestoParameters { get; set; }
            /// <summary>
            /// StarburstParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-starburstparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StarburstParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.StarburstParameters, BaseFunction>? StarburstParameters { get; set; }
            /// <summary>
            /// RedshiftParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-redshiftparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.RedshiftParameters, BaseFunction>? RedshiftParameters { get; set; }
            /// <summary>
            /// MySqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-mysqlparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MySqlParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.MySqlParameters, BaseFunction>? MySqlParameters { get; set; }
            /// <summary>
            /// SqlServerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-sqlserverparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqlServerParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.SqlServerParameters, BaseFunction>? SqlServerParameters { get; set; }
            /// <summary>
            /// SnowflakeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-snowflakeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters, BaseFunction>? SnowflakeParameters { get; set; }
            /// <summary>
            /// AmazonElasticsearchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-amazonelasticsearchparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonElasticsearchParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.AmazonElasticsearchParameters, BaseFunction>? AmazonElasticsearchParameters { get; set; }
            /// <summary>
            /// AmazonOpenSearchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-amazonopensearchparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonOpenSearchParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.AmazonOpenSearchParameters, BaseFunction>? AmazonOpenSearchParameters { get; set; }
            /// <summary>
            /// PostgreSqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-postgresqlparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostgreSqlParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.PostgreSqlParameters, BaseFunction>? PostgreSqlParameters { get; set; }
            /// <summary>
            /// AuroraParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-auroraparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuroraParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.AuroraParameters, BaseFunction>? AuroraParameters { get; set; }
            /// <summary>
            /// S3Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-s3parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Parameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.S3Parameters, BaseFunction>? S3Parameters { get; set; }
            /// <summary>
            /// TrinoParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-trinoparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrinoParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.TrinoParameters, BaseFunction>? TrinoParameters { get; set; }
            /// <summary>
            /// DatabricksParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html#cfn-quicksight-datasource-datasourceparameters-databricksparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabricksParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.DatabricksParameters, BaseFunction>? DatabricksParameters { get; set; }
        }

        public class DatabricksParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveQuickSightDataSourceTypesOAuthParametersOAuthParameters, IHaveHost, IHaveSqlEndpointPath, IHaveAuthenticationType
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-databricksparameters.html#cfn-quicksight-datasource-databricksparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// OAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-databricksparameters.html#cfn-quicksight-datasource-databricksparameters-oauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.OAuthParameters, BaseFunction>? OAuthParameters { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-databricksparameters.html#cfn-quicksight-datasource-databricksparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// SqlEndpointPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-databricksparameters.html#cfn-quicksight-datasource-databricksparameters-sqlendpointpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SqlEndpointPath { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-databricksparameters.html#cfn-quicksight-datasource-databricksparameters-authenticationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class IdentityCenterConfiguration : Humidifier.Base.BaseSubResource, IHaveEnableIdentityPropagation_Boolean
        {
            /// <summary>
            /// EnableIdentityPropagation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-identitycenterconfiguration.html#cfn-quicksight-datasource-identitycenterconfiguration-enableidentitypropagation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableIdentityPropagation { get; set; }
        }

        public class KeyPairCredentials : Humidifier.Base.BaseSubResource, IHaveKeyPairUsername, IHavePrivateKey, IHavePrivateKeyPassphrase
        {
            /// <summary>
            /// KeyPairUsername
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-keypaircredentials.html#cfn-quicksight-datasource-keypaircredentials-keypairusername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPairUsername { get; set; }
            /// <summary>
            /// PrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-keypaircredentials.html#cfn-quicksight-datasource-keypaircredentials-privatekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateKey { get; set; }
            /// <summary>
            /// PrivateKeyPassphrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-keypaircredentials.html#cfn-quicksight-datasource-keypaircredentials-privatekeypassphrase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateKeyPassphrase { get; set; }
        }

        public class ManifestFileLocation : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-manifestfilelocation.html#cfn-quicksight-datasource-manifestfilelocation-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-manifestfilelocation.html#cfn-quicksight-datasource-manifestfilelocation-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class MariaDbParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-mariadbparameters.html#cfn-quicksight-datasource-mariadbparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-mariadbparameters.html#cfn-quicksight-datasource-mariadbparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-mariadbparameters.html#cfn-quicksight-datasource-mariadbparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class MySqlParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-mysqlparameters.html#cfn-quicksight-datasource-mysqlparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-mysqlparameters.html#cfn-quicksight-datasource-mysqlparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-mysqlparameters.html#cfn-quicksight-datasource-mysqlparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class OAuthClientCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveClientSecret, IHaveClientId
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthclientcredentials.html#cfn-quicksight-datasource-oauthclientcredentials-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthclientcredentials.html#cfn-quicksight-datasource-oauthclientcredentials-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthclientcredentials.html#cfn-quicksight-datasource-oauthclientcredentials-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
        }

        public class OAuthParameters : Humidifier.Base.BaseSubResource, IHaveTokenProviderUrl, IHaveOAuthScope, IHaveQuickSightDataSourceTypesVpcConnectionPropertiesIdentityProviderVpcConnectionProperties, IHaveIdentityProviderResourceUri
        {
            /// <summary>
            /// TokenProviderUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthparameters.html#cfn-quicksight-datasource-oauthparameters-tokenproviderurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenProviderUrl { get; set; }
            /// <summary>
            /// OAuthScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthparameters.html#cfn-quicksight-datasource-oauthparameters-oauthscope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OAuthScope { get; set; }
            /// <summary>
            /// IdentityProviderVpcConnectionProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthparameters.html#cfn-quicksight-datasource-oauthparameters-identityprovidervpcconnectionproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectionProperties
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties, BaseFunction>? IdentityProviderVpcConnectionProperties { get; set; }
            /// <summary>
            /// IdentityProviderResourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oauthparameters.html#cfn-quicksight-datasource-oauthparameters-identityproviderresourceuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityProviderResourceUri { get; set; }
        }

        public class OracleParameters : Humidifier.Base.BaseSubResource, IHaveUseServiceName_Boolean, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// UseServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oracleparameters.html#cfn-quicksight-datasource-oracleparameters-useservicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseServiceName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oracleparameters.html#cfn-quicksight-datasource-oracleparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oracleparameters.html#cfn-quicksight-datasource-oracleparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oracleparameters.html#cfn-quicksight-datasource-oracleparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class PostgreSqlParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-postgresqlparameters.html#cfn-quicksight-datasource-postgresqlparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-postgresqlparameters.html#cfn-quicksight-datasource-postgresqlparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-postgresqlparameters.html#cfn-quicksight-datasource-postgresqlparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class PrestoParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveHost, IHaveCatalog
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-prestoparameters.html#cfn-quicksight-datasource-prestoparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-prestoparameters.html#cfn-quicksight-datasource-prestoparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-prestoparameters.html#cfn-quicksight-datasource-prestoparameters-catalog
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Catalog { get; set; }
        }

        public class RdsParameters : Humidifier.Base.BaseSubResource, IHaveInstanceId, IHaveDatabase
        {
            /// <summary>
            /// InstanceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-rdsparameters.html#cfn-quicksight-datasource-rdsparameters-instanceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceId { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-rdsparameters.html#cfn-quicksight-datasource-rdsparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
        }

        public class RedshiftIAMParameters : Humidifier.Base.BaseSubResource, IHaveAutoCreateDatabaseUser_Boolean, IHaveDatabaseUser, IHaveRoleArn, IHaveStringListOfDatabaseGroups
        {
            /// <summary>
            /// AutoCreateDatabaseUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftiamparameters.html#cfn-quicksight-datasource-redshiftiamparameters-autocreatedatabaseuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoCreateDatabaseUser { get; set; }
            /// <summary>
            /// DatabaseUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftiamparameters.html#cfn-quicksight-datasource-redshiftiamparameters-databaseuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseUser { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftiamparameters.html#cfn-quicksight-datasource-redshiftiamparameters-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// DatabaseGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftiamparameters.html#cfn-quicksight-datasource-redshiftiamparameters-databasegroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DatabaseGroups { get; set; }
        }

        public class RedshiftParameters : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSourceTypesRedshiftIAMParametersIAMParameters, IHaveClusterId, IHavePort_Double, IHaveDatabase, IHaveHost, IHaveQuickSightDataSourceTypesIdentityCenterConfigurationIdentityCenterConfiguration
        {
            /// <summary>
            /// IAMParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html#cfn-quicksight-datasource-redshiftparameters-iamparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftIAMParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.RedshiftIAMParameters, BaseFunction>? IAMParameters { get; set; }
            /// <summary>
            /// ClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html#cfn-quicksight-datasource-redshiftparameters-clusterid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterId { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html#cfn-quicksight-datasource-redshiftparameters-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html#cfn-quicksight-datasource-redshiftparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html#cfn-quicksight-datasource-redshiftparameters-host
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// IdentityCenterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html#cfn-quicksight-datasource-redshiftparameters-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration, BaseFunction>? IdentityCenterConfiguration { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveResource, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-resourcepermission.html#cfn-quicksight-datasource-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-resourcepermission.html#cfn-quicksight-datasource-resourcepermission-resource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resource { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-resourcepermission.html#cfn-quicksight-datasource-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }

        public class S3Parameters : Humidifier.Base.BaseSubResource, IHaveQuickSightDataSourceTypesManifestFileLocationManifestFileLocation, IHaveRoleArn
        {
            /// <summary>
            /// ManifestFileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-s3parameters.html#cfn-quicksight-datasource-s3parameters-manifestfilelocation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ManifestFileLocation
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation, BaseFunction>? ManifestFileLocation { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-s3parameters.html#cfn-quicksight-datasource-s3parameters-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class S3TablesParameters : Humidifier.Base.BaseSubResource, IHaveTableBucketArn
        {
            /// <summary>
            /// TableBucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-s3tablesparameters.html#cfn-quicksight-datasource-s3tablesparameters-tablebucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableBucketArn { get; set; }
        }

        public class SnowflakeParameters : Humidifier.Base.BaseSubResource, IHaveWarehouse, IHaveDatabaseAccessControlRole, IHaveDatabase, IHaveQuickSightDataSourceTypesOAuthParametersOAuthParameters, IHaveHost, IHaveAuthenticationType
        {
            /// <summary>
            /// Warehouse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html#cfn-quicksight-datasource-snowflakeparameters-warehouse
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Warehouse { get; set; }
            /// <summary>
            /// DatabaseAccessControlRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html#cfn-quicksight-datasource-snowflakeparameters-databaseaccesscontrolrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseAccessControlRole { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html#cfn-quicksight-datasource-snowflakeparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// OAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html#cfn-quicksight-datasource-snowflakeparameters-oauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.OAuthParameters, BaseFunction>? OAuthParameters { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html#cfn-quicksight-datasource-snowflakeparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html#cfn-quicksight-datasource-snowflakeparameters-authenticationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class SparkParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sparkparameters.html#cfn-quicksight-datasource-sparkparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sparkparameters.html#cfn-quicksight-datasource-sparkparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class SqlServerParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sqlserverparameters.html#cfn-quicksight-datasource-sqlserverparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sqlserverparameters.html#cfn-quicksight-datasource-sqlserverparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sqlserverparameters.html#cfn-quicksight-datasource-sqlserverparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class SslProperties : Humidifier.Base.BaseSubResource, IHaveDisableSsl_Boolean
        {
            /// <summary>
            /// DisableSsl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sslproperties.html#cfn-quicksight-datasource-sslproperties-disablessl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableSsl { get; set; }
        }

        public class StarburstParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabaseAccessControlRole, IHaveProductType, IHaveQuickSightDataSourceTypesOAuthParametersOAuthParameters, IHaveHost, IHaveCatalog, IHaveAuthenticationType
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseAccessControlRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-databaseaccesscontrolrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseAccessControlRole { get; set; }
            /// <summary>
            /// ProductType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-producttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductType { get; set; }
            /// <summary>
            /// OAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-oauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthParameters
            /// </summary>
            public Union<Humidifier.QuickSight.DataSourceTypes.OAuthParameters, BaseFunction>? OAuthParameters { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-catalog
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Catalog { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-starburstparameters.html#cfn-quicksight-datasource-starburstparameters-authenticationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class TeradataParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveDatabase, IHaveHost
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-teradataparameters.html#cfn-quicksight-datasource-teradataparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-teradataparameters.html#cfn-quicksight-datasource-teradataparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-teradataparameters.html#cfn-quicksight-datasource-teradataparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
        }

        public class TrinoParameters : Humidifier.Base.BaseSubResource, IHavePort_Double, IHaveHost, IHaveCatalog
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-trinoparameters.html#cfn-quicksight-datasource-trinoparameters-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-trinoparameters.html#cfn-quicksight-datasource-trinoparameters-host
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-trinoparameters.html#cfn-quicksight-datasource-trinoparameters-catalog
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Catalog { get; set; }
        }

        public class VpcConnectionProperties : Humidifier.Base.BaseSubResource, IHaveVpcConnectionArn
        {
            /// <summary>
            /// VpcConnectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-vpcconnectionproperties.html#cfn-quicksight-datasource-vpcconnectionproperties-vpcconnectionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcConnectionArn { get; set; }
        }
    }
}