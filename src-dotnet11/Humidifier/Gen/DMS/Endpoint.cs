namespace Humidifier.DMS
{
    using global::System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveDMSEndpointTypesRedisSettingsRedisSettings, IHaveDMSEndpointTypesSybaseSettingsSybaseSettings, IHaveDMSEndpointTypesOracleSettingsOracleSettings, IHaveDMSEndpointTypesKafkaSettingsKafkaSettings, IHavePort_Integer, IHaveDMSEndpointTypesMySqlSettingsMySqlSettings, IHaveDMSEndpointTypesS3SettingsS3Settings, IHaveResourceIdentifier, IHaveDMSEndpointTypesKinesisSettingsKinesisSettings, IHaveSslMode, IHaveDMSEndpointTypesRedshiftSettingsRedshiftSettings, IHaveEndpointType, IHaveDMSEndpointTypesMongoDbSettingsMongoDbSettings, IHavePassword, IHaveDMSEndpointTypesIbmDb2SettingsIbmDb2Settings, IHaveKmsKeyId, IHaveDatabaseName, IHaveDMSEndpointTypesNeptuneSettingsNeptuneSettings, IHaveDMSEndpointTypesElasticsearchSettingsElasticsearchSettings, IHaveDMSEndpointTypesDocDbSettingsDocDbSettings, IHaveEngineName, IHaveDMSEndpointTypesDynamoDbSettingsDynamoDbSettings, IHaveUsername, IHaveDMSEndpointTypesGcpMySQLSettingsGcpMySQLSettings, IHaveDMSEndpointTypesMicrosoftSqlServerSettingsMicrosoftSqlServerSettings, IHaveExtraConnectionAttributes, IHaveServerName, IHaveCertificateArn, IHaveEndpointIdentifier, IHaveDMSEndpointTypesPostgreSqlSettingsPostgreSqlSettings
    {
        public class Attributes
        {
            public static string ExternalId =  "ExternalId" ;
            public static string EndpointArn =  "EndpointArn" ;
        }

        public override string AWSTypeName { get => AWS.DMS.Endpoint; }
        /// <summary>
        /// RedisSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-redissettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RedisSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.RedisSettings, BaseFunction>? RedisSettings { get; set; }
        /// <summary>
        /// SybaseSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-sybasesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SybaseSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.SybaseSettings, BaseFunction>? SybaseSettings { get; set; }
        /// <summary>
        /// OracleSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-oraclesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OracleSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.OracleSettings, BaseFunction>? OracleSettings { get; set; }
        /// <summary>
        /// KafkaSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-kafkasettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KafkaSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.KafkaSettings, BaseFunction>? KafkaSettings { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// MySqlSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-mysqlsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MySqlSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.MySqlSettings, BaseFunction>? MySqlSettings { get; set; }
        /// <summary>
        /// S3Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-s3settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Settings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.S3Settings, BaseFunction>? S3Settings { get; set; }
        /// <summary>
        /// ResourceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-resourceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceIdentifier { get; set; }
        /// <summary>
        /// KinesisSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-kinesissettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.KinesisSettings, BaseFunction>? KinesisSettings { get; set; }
        /// <summary>
        /// SslMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-sslmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SslMode { get; set; }
        /// <summary>
        /// RedshiftSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-redshiftsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RedshiftSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.RedshiftSettings, BaseFunction>? RedshiftSettings { get; set; }

        /// <summary>
        /// EndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-endpointtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MongoDbSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-mongodbsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MongoDbSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.MongoDbSettings, BaseFunction>? MongoDbSettings { get; set; }
        /// <summary>
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-password
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Password { get; set; }
        /// <summary>
        /// IbmDb2Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-ibmdb2settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IbmDb2Settings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.IbmDb2Settings, BaseFunction>? IbmDb2Settings { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-databasename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatabaseName { get; set; }
        /// <summary>
        /// NeptuneSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-neptunesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NeptuneSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.NeptuneSettings, BaseFunction>? NeptuneSettings { get; set; }
        /// <summary>
        /// ElasticsearchSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-elasticsearchsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ElasticsearchSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.ElasticsearchSettings, BaseFunction>? ElasticsearchSettings { get; set; }
        /// <summary>
        /// DocDbSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-docdbsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DocDbSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.DocDbSettings, BaseFunction>? DocDbSettings { get; set; }

        /// <summary>
        /// EngineName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-enginename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EngineName { get; set; }
        /// <summary>
        /// DynamoDbSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-dynamodbsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DynamoDbSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.DynamoDbSettings, BaseFunction>? DynamoDbSettings { get; set; }
        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-username
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Username { get; set; }
        /// <summary>
        /// GcpMySQLSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-gcpmysqlsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GcpMySQLSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.GcpMySQLSettings, BaseFunction>? GcpMySQLSettings { get; set; }
        /// <summary>
        /// MicrosoftSqlServerSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-microsoftsqlserversettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MicrosoftSqlServerSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.MicrosoftSqlServerSettings, BaseFunction>? MicrosoftSqlServerSettings { get; set; }
        /// <summary>
        /// ExtraConnectionAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-extraconnectionattributes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExtraConnectionAttributes { get; set; }
        /// <summary>
        /// ServerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-servername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerName { get; set; }
        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-certificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateArn { get; set; }
        /// <summary>
        /// EndpointIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-endpointidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointIdentifier { get; set; }
        /// <summary>
        /// PostgreSqlSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html#cfn-dms-endpoint-postgresqlsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PostgreSqlSettings
        /// </summary>
        public Union<Humidifier.DMS.EndpointTypes.PostgreSqlSettings, BaseFunction>? PostgreSqlSettings { get; set; }
    }

    namespace EndpointTypes
    {
        public class DocDbSettings : Humidifier.Base.BaseSubResource, IHaveDocsToInvestigate_Integer, IHaveExtractDocId_Boolean, IHaveSecretsManagerSecretId, IHaveSecretsManagerAccessRoleArn, IHaveNestingLevel
        {
            /// <summary>
            /// DocsToInvestigate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-docdbsettings.html#cfn-dms-endpoint-docdbsettings-docstoinvestigate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DocsToInvestigate { get; set; }
            /// <summary>
            /// ExtractDocId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-docdbsettings.html#cfn-dms-endpoint-docdbsettings-extractdocid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExtractDocId { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-docdbsettings.html#cfn-dms-endpoint-docdbsettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-docdbsettings.html#cfn-dms-endpoint-docdbsettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// NestingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-docdbsettings.html#cfn-dms-endpoint-docdbsettings-nestinglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NestingLevel { get; set; }
        }

        public class DynamoDbSettings : Humidifier.Base.BaseSubResource, IHaveServiceAccessRoleArn
        {
            /// <summary>
            /// ServiceAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-dynamodbsettings.html#cfn-dms-endpoint-dynamodbsettings-serviceaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
        }

        public class ElasticsearchSettings : Humidifier.Base.BaseSubResource, IHaveEndpointUri, IHaveFullLoadErrorPercentage_Integer, IHaveErrorRetryDuration_Integer, IHaveServiceAccessRoleArn
        {
            /// <summary>
            /// EndpointUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-elasticsearchsettings.html#cfn-dms-endpoint-elasticsearchsettings-endpointuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointUri { get; set; }
            /// <summary>
            /// FullLoadErrorPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-elasticsearchsettings.html#cfn-dms-endpoint-elasticsearchsettings-fullloaderrorpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FullLoadErrorPercentage { get; set; }
            /// <summary>
            /// ErrorRetryDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-elasticsearchsettings.html#cfn-dms-endpoint-elasticsearchsettings-errorretryduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ErrorRetryDuration { get; set; }
            /// <summary>
            /// ServiceAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-elasticsearchsettings.html#cfn-dms-endpoint-elasticsearchsettings-serviceaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
        }

        public class GcpMySQLSettings : Humidifier.Base.BaseSubResource, IHaveAfterConnectScript, IHavePort_Integer, IHaveDatabaseName, IHaveCleanSourceMetadataOnMismatch_Boolean, IHaveServerTimezone, IHaveEventsPollInterval_Integer, IHaveParallelLoadThreads_Integer, IHaveMaxFileSize_Integer, IHaveUsername, IHaveServerName, IHaveSecretsManagerSecretId, IHaveSecretsManagerAccessRoleArn, IHavePassword
        {
            /// <summary>
            /// AfterConnectScript
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-afterconnectscript
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfterConnectScript { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CleanSourceMetadataOnMismatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-cleansourcemetadataonmismatch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CleanSourceMetadataOnMismatch { get; set; }
            /// <summary>
            /// ServerTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-servertimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerTimezone { get; set; }
            /// <summary>
            /// EventsPollInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-eventspollinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EventsPollInterval { get; set; }
            /// <summary>
            /// ParallelLoadThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-parallelloadthreads
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParallelLoadThreads { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-servername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-gcpmysqlsettings.html#cfn-dms-endpoint-gcpmysqlsettings-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class IbmDb2Settings : Humidifier.Base.BaseSubResource, IHaveLoadTimeout_Integer, IHaveSetDataCaptureChanges_Boolean, IHaveKeepCsvFiles_Boolean, IHaveMaxFileSize_Integer, IHaveCurrentLsn, IHaveMaxKBytesPerRead_Integer, IHaveSecretsManagerSecretId, IHaveWriteBufferSize_Integer, IHaveSecretsManagerAccessRoleArn
        {
            /// <summary>
            /// LoadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-loadtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LoadTimeout { get; set; }
            /// <summary>
            /// SetDataCaptureChanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-setdatacapturechanges
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SetDataCaptureChanges { get; set; }
            /// <summary>
            /// KeepCsvFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-keepcsvfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeepCsvFiles { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// CurrentLsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-currentlsn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CurrentLsn { get; set; }
            /// <summary>
            /// MaxKBytesPerRead
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-maxkbytesperread
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxKBytesPerRead { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// WriteBufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-writebuffersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteBufferSize { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html#cfn-dms-endpoint-ibmdb2settings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
        }

        public class KafkaSettings : Humidifier.Base.BaseSubResource, IHaveBroker, IHaveSaslPassword, IHaveMessageFormat, IHaveSslClientCertificateArn, IHaveIncludeTransactionDetails_Boolean, IHaveIncludeTableAlterOperations_Boolean, IHaveSecurityProtocol, IHaveSslCaCertificateArn, IHaveIncludeControlDetails_Boolean, IHaveIncludePartitionValue_Boolean, IHaveNoHexPrefix_Boolean, IHaveSslClientKeyArn, IHaveSslClientKeyPassword, IHaveSaslUserName, IHaveMessageMaxBytes_Integer, IHaveTopic, IHavePartitionIncludeSchemaTable_Boolean, IHaveIncludeNullAndEmpty_Boolean
        {
            /// <summary>
            /// Broker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-broker
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Broker { get; set; }
            /// <summary>
            /// SaslPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-saslpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SaslPassword { get; set; }
            /// <summary>
            /// MessageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-messageformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageFormat { get; set; }
            /// <summary>
            /// SslClientCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-sslclientcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslClientCertificateArn { get; set; }
            /// <summary>
            /// IncludeTransactionDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-includetransactiondetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeTransactionDetails { get; set; }
            /// <summary>
            /// IncludeTableAlterOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-includetablealteroperations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeTableAlterOperations { get; set; }
            /// <summary>
            /// SecurityProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-securityprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityProtocol { get; set; }
            /// <summary>
            /// SslCaCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-sslcacertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslCaCertificateArn { get; set; }
            /// <summary>
            /// IncludeControlDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-includecontroldetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeControlDetails { get; set; }
            /// <summary>
            /// IncludePartitionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-includepartitionvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludePartitionValue { get; set; }
            /// <summary>
            /// NoHexPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-nohexprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoHexPrefix { get; set; }
            /// <summary>
            /// SslClientKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-sslclientkeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslClientKeyArn { get; set; }
            /// <summary>
            /// SslClientKeyPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-sslclientkeypassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslClientKeyPassword { get; set; }
            /// <summary>
            /// SaslUserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-saslusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SaslUserName { get; set; }
            /// <summary>
            /// MessageMaxBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-messagemaxbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MessageMaxBytes { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-topic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Topic { get; set; }
            /// <summary>
            /// PartitionIncludeSchemaTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-partitionincludeschematable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PartitionIncludeSchemaTable { get; set; }
            /// <summary>
            /// IncludeNullAndEmpty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html#cfn-dms-endpoint-kafkasettings-includenullandempty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeNullAndEmpty { get; set; }
        }

        public class KinesisSettings : Humidifier.Base.BaseSubResource, IHaveMessageFormat, IHaveIncludeTransactionDetails_Boolean, IHaveIncludeTableAlterOperations_Boolean, IHaveIncludeControlDetails_Boolean, IHaveIncludePartitionValue_Boolean, IHaveStreamArn, IHaveNoHexPrefix_Boolean, IHaveServiceAccessRoleArn, IHavePartitionIncludeSchemaTable_Boolean, IHaveIncludeNullAndEmpty_Boolean
        {
            /// <summary>
            /// MessageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-messageformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageFormat { get; set; }
            /// <summary>
            /// IncludeTransactionDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-includetransactiondetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeTransactionDetails { get; set; }
            /// <summary>
            /// IncludeTableAlterOperations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-includetablealteroperations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeTableAlterOperations { get; set; }
            /// <summary>
            /// IncludeControlDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-includecontroldetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeControlDetails { get; set; }
            /// <summary>
            /// IncludePartitionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-includepartitionvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludePartitionValue { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-streamarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamArn { get; set; }
            /// <summary>
            /// NoHexPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-nohexprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoHexPrefix { get; set; }
            /// <summary>
            /// ServiceAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-serviceaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
            /// <summary>
            /// PartitionIncludeSchemaTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-partitionincludeschematable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PartitionIncludeSchemaTable { get; set; }
            /// <summary>
            /// IncludeNullAndEmpty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html#cfn-dms-endpoint-kinesissettings-includenullandempty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeNullAndEmpty { get; set; }
        }

        public class MicrosoftSqlServerSettings : Humidifier.Base.BaseSubResource, IHaveReadBackupOnly_Boolean, IHaveTlogAccessMode, IHaveBcpPacketSize_Integer, IHavePort_Integer, IHaveDatabaseName, IHaveSafeguardPolicy, IHaveUseThirdPartyBackupDevice_Boolean, IHaveUseBcpFullLoad_Boolean, IHaveUsername, IHaveQuerySingleAlwaysOnNode_Boolean, IHaveServerName, IHaveSecretsManagerSecretId, IHaveControlTablesFileGroup, IHaveForceLobLookup_Boolean, IHaveSecretsManagerAccessRoleArn, IHaveTrimSpaceInChar_Boolean, IHavePassword
        {
            /// <summary>
            /// ReadBackupOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-readbackuponly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadBackupOnly { get; set; }
            /// <summary>
            /// TlogAccessMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-tlogaccessmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TlogAccessMode { get; set; }
            /// <summary>
            /// BcpPacketSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-bcppacketsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BcpPacketSize { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// SafeguardPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-safeguardpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SafeguardPolicy { get; set; }
            /// <summary>
            /// UseThirdPartyBackupDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-usethirdpartybackupdevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseThirdPartyBackupDevice { get; set; }
            /// <summary>
            /// UseBcpFullLoad
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-usebcpfullload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseBcpFullLoad { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// QuerySingleAlwaysOnNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-querysinglealwaysonnode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QuerySingleAlwaysOnNode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-servername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// ControlTablesFileGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-controltablesfilegroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ControlTablesFileGroup { get; set; }
            /// <summary>
            /// ForceLobLookup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-forceloblookup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ForceLobLookup { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// TrimSpaceInChar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-trimspaceinchar
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TrimSpaceInChar { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-microsoftsqlserversettings.html#cfn-dms-endpoint-microsoftsqlserversettings-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class MongoDbSettings : Humidifier.Base.BaseSubResource, IHaveExtractDocId, IHavePort_Integer, IHaveDatabaseName, IHaveAuthSource, IHaveAuthMechanism, IHaveDocsToInvestigate, IHaveUsername, IHaveServerName, IHaveSecretsManagerSecretId, IHaveAuthType, IHaveSecretsManagerAccessRoleArn, IHaveNestingLevel, IHavePassword
        {
            /// <summary>
            /// ExtractDocId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-extractdocid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExtractDocId { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// AuthSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-authsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthSource { get; set; }
            /// <summary>
            /// AuthMechanism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-authmechanism
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthMechanism { get; set; }
            /// <summary>
            /// DocsToInvestigate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-docstoinvestigate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocsToInvestigate { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-servername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-authtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// NestingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-nestinglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NestingLevel { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html#cfn-dms-endpoint-mongodbsettings-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class MySqlSettings : Humidifier.Base.BaseSubResource, IHaveServerTimezone, IHaveEventsPollInterval_Integer, IHaveParallelLoadThreads_Integer, IHaveAfterConnectScript, IHaveMaxFileSize_Integer, IHaveTargetDbType, IHaveSecretsManagerSecretId, IHaveSecretsManagerAccessRoleArn, IHaveCleanSourceMetadataOnMismatch_Boolean
        {
            /// <summary>
            /// ServerTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-servertimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerTimezone { get; set; }
            /// <summary>
            /// EventsPollInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-eventspollinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EventsPollInterval { get; set; }
            /// <summary>
            /// ParallelLoadThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-parallelloadthreads
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParallelLoadThreads { get; set; }
            /// <summary>
            /// AfterConnectScript
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-afterconnectscript
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfterConnectScript { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// TargetDbType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-targetdbtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetDbType { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// CleanSourceMetadataOnMismatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mysqlsettings.html#cfn-dms-endpoint-mysqlsettings-cleansourcemetadataonmismatch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CleanSourceMetadataOnMismatch { get; set; }
        }

        public class NeptuneSettings : Humidifier.Base.BaseSubResource, IHaveMaxRetryCount_Integer, IHaveMaxFileSize_Integer, IHaveErrorRetryDuration_Integer, IHaveS3BucketFolder, IHaveIamAuthEnabled_Boolean, IHaveS3BucketName, IHaveServiceAccessRoleArn
        {
            /// <summary>
            /// MaxRetryCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-maxretrycount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetryCount { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// ErrorRetryDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-errorretryduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ErrorRetryDuration { get; set; }
            /// <summary>
            /// S3BucketFolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-s3bucketfolder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketFolder { get; set; }
            /// <summary>
            /// IamAuthEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-iamauthenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IamAuthEnabled { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// ServiceAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html#cfn-dms-endpoint-neptunesettings-serviceaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
        }

        public class OracleSettings : Humidifier.Base.BaseSubResource, IHaveAsmPassword, IHaveDirectPathParallelLoad_Boolean, IHaveAdditionalArchivedLogDestId_Integer, IHaveSpatialDataOptionToGeoJsonFunctionName, IHaveReplacePathPrefix_Boolean, IHaveFailTasksOnLobTruncation_Boolean, IHaveAsmServer, IHaveOraclePathPrefix, IHaveSecretsManagerOracleAsmAccessRoleArn, IHaveReadAheadBlocks_Integer, IHaveStandbyDelayTime_Integer, IHaveAllowSelectNestedTables_Boolean, IHaveAddSupplementalLogging_Boolean, IHaveSecretsManagerSecretId, IHaveUseBFile_Boolean, IHaveAsmUser, IHaveEnableHomogenousTablespace_Boolean, IHaveUseDirectPathFullLoad_Boolean, IHaveSecurityDbEncryption, IHaveParallelAsmReadThreads_Integer, IHaveArchivedLogDestId_Integer, IHaveUsePathPrefix, IHaveUseLogminerReader_Boolean, IHaveSecurityDbEncryptionName, IHaveDirectPathNoLog_Boolean, IHaveSecretsManagerOracleAsmSecretId, IHaveCharLengthSemantics, IHaveNumberDatatypeScale_Integer, IHaveReadTableSpaceName_Boolean, IHaveAccessAlternateDirectly_Boolean, IHaveArchivedLogsOnly_Boolean, IHaveUseAlternateFolderForOnline_Boolean, IHaveIntegerListOfExtraArchivedLogDestIds, IHaveRetryInterval_Integer, IHaveSecretsManagerAccessRoleArn
        {
            /// <summary>
            /// AsmPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-asmpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AsmPassword { get; set; }
            /// <summary>
            /// DirectPathParallelLoad
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-directpathparallelload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DirectPathParallelLoad { get; set; }
            /// <summary>
            /// AdditionalArchivedLogDestId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-additionalarchivedlogdestid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AdditionalArchivedLogDestId { get; set; }
            /// <summary>
            /// SpatialDataOptionToGeoJsonFunctionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-spatialdataoptiontogeojsonfunctionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpatialDataOptionToGeoJsonFunctionName { get; set; }
            /// <summary>
            /// ReplacePathPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-replacepathprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReplacePathPrefix { get; set; }
            /// <summary>
            /// FailTasksOnLobTruncation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-failtasksonlobtruncation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FailTasksOnLobTruncation { get; set; }
            /// <summary>
            /// AsmServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-asmserver
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AsmServer { get; set; }
            /// <summary>
            /// OraclePathPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-oraclepathprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OraclePathPrefix { get; set; }
            /// <summary>
            /// SecretsManagerOracleAsmAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-secretsmanageroracleasmaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerOracleAsmAccessRoleArn { get; set; }
            /// <summary>
            /// ReadAheadBlocks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-readaheadblocks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadAheadBlocks { get; set; }
            /// <summary>
            /// StandbyDelayTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-standbydelaytime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StandbyDelayTime { get; set; }
            /// <summary>
            /// AllowSelectNestedTables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-allowselectnestedtables
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowSelectNestedTables { get; set; }
            /// <summary>
            /// AddSupplementalLogging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-addsupplementallogging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AddSupplementalLogging { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// UseBFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-usebfile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseBFile { get; set; }
            /// <summary>
            /// AsmUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-asmuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AsmUser { get; set; }
            /// <summary>
            /// EnableHomogenousTablespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-enablehomogenoustablespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableHomogenousTablespace { get; set; }
            /// <summary>
            /// UseDirectPathFullLoad
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-usedirectpathfullload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseDirectPathFullLoad { get; set; }
            /// <summary>
            /// SecurityDbEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-securitydbencryption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityDbEncryption { get; set; }
            /// <summary>
            /// ParallelAsmReadThreads
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-parallelasmreadthreads
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParallelAsmReadThreads { get; set; }
            /// <summary>
            /// ArchivedLogDestId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-archivedlogdestid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ArchivedLogDestId { get; set; }
            /// <summary>
            /// UsePathPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-usepathprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsePathPrefix { get; set; }
            /// <summary>
            /// UseLogminerReader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-uselogminerreader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseLogminerReader { get; set; }
            /// <summary>
            /// SecurityDbEncryptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-securitydbencryptionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityDbEncryptionName { get; set; }
            /// <summary>
            /// DirectPathNoLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-directpathnolog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DirectPathNoLog { get; set; }
            /// <summary>
            /// SecretsManagerOracleAsmSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-secretsmanageroracleasmsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerOracleAsmSecretId { get; set; }
            /// <summary>
            /// CharLengthSemantics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-charlengthsemantics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CharLengthSemantics { get; set; }
            /// <summary>
            /// NumberDatatypeScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-numberdatatypescale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberDatatypeScale { get; set; }
            /// <summary>
            /// ReadTableSpaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-readtablespacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadTableSpaceName { get; set; }
            /// <summary>
            /// AccessAlternateDirectly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-accessalternatedirectly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AccessAlternateDirectly { get; set; }
            /// <summary>
            /// ArchivedLogsOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-archivedlogsonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ArchivedLogsOnly { get; set; }
            /// <summary>
            /// UseAlternateFolderForOnline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-usealternatefolderforonline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseAlternateFolderForOnline { get; set; }
            /// <summary>
            /// ExtraArchivedLogDestIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-extraarchivedlogdestids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? ExtraArchivedLogDestIds { get; set; }
            /// <summary>
            /// RetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-retryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryInterval { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html#cfn-dms-endpoint-oraclesettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
        }

        public class PostgreSqlSettings : Humidifier.Base.BaseSubResource, IHavePluginName, IHaveMapBooleanAsBoolean_Boolean, IHaveAfterConnectScript, IHaveExecuteTimeout_Integer, IHaveDdlArtifactsSchema, IHaveFailTasksOnLobTruncation_Boolean, IHaveHeartbeatEnable_Boolean, IHaveBabelfishDatabaseName, IHaveDatabaseMode, IHaveCaptureDdls_Boolean, IHaveMaxFileSize_Integer, IHaveHeartbeatFrequency_Integer, IHaveSecretsManagerSecretId, IHaveHeartbeatSchema, IHaveSecretsManagerAccessRoleArn, IHaveSlotName
        {
            /// <summary>
            /// PluginName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-pluginname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PluginName { get; set; }
            /// <summary>
            /// MapBooleanAsBoolean
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-mapbooleanasboolean
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MapBooleanAsBoolean { get; set; }
            /// <summary>
            /// AfterConnectScript
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-afterconnectscript
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfterConnectScript { get; set; }
            /// <summary>
            /// ExecuteTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-executetimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExecuteTimeout { get; set; }
            /// <summary>
            /// DdlArtifactsSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-ddlartifactsschema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DdlArtifactsSchema { get; set; }
            /// <summary>
            /// FailTasksOnLobTruncation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-failtasksonlobtruncation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FailTasksOnLobTruncation { get; set; }
            /// <summary>
            /// HeartbeatEnable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-heartbeatenable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? HeartbeatEnable { get; set; }
            /// <summary>
            /// BabelfishDatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-babelfishdatabasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BabelfishDatabaseName { get; set; }
            /// <summary>
            /// DatabaseMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-databasemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseMode { get; set; }
            /// <summary>
            /// CaptureDdls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-captureddls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaptureDdls { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// HeartbeatFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-heartbeatfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HeartbeatFrequency { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// HeartbeatSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-heartbeatschema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeartbeatSchema { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-postgresqlsettings.html#cfn-dms-endpoint-postgresqlsettings-slotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotName { get; set; }
        }

        public class RedisSettings : Humidifier.Base.BaseSubResource, IHaveAuthUserName, IHaveSslSecurityProtocol, IHavePort_Double, IHaveServerName, IHaveSslCaCertificateArn, IHaveAuthPassword, IHaveAuthType
        {
            /// <summary>
            /// AuthUserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-authusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthUserName { get; set; }
            /// <summary>
            /// SslSecurityProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-sslsecurityprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslSecurityProtocol { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-servername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// SslCaCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-sslcacertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslCaCertificateArn { get; set; }
            /// <summary>
            /// AuthPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-authpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthPassword { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redissettings.html#cfn-dms-endpoint-redissettings-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
        }

        public class RedshiftSettings : Humidifier.Base.BaseSubResource, IHaveConnectionTimeout_Integer, IHaveMapBooleanAsBoolean_Boolean, IHaveAfterConnectScript, IHaveFileTransferUploadStreams_Integer, IHaveBucketName, IHaveServerSideEncryptionKmsKeyId, IHaveExplicitIds_Boolean, IHaveSecretsManagerSecretId, IHaveTruncateColumns_Boolean, IHaveServiceAccessRoleArn, IHaveReplaceChars, IHaveTimeFormat, IHaveBucketFolder, IHaveReplaceInvalidChars, IHaveRemoveQuotes_Boolean, IHaveLoadTimeout_Integer, IHaveMaxFileSize_Integer, IHaveTrimBlanks_Boolean, IHaveDateFormat, IHaveCompUpdate_Boolean, IHaveAcceptAnyDate_Boolean, IHaveWriteBufferSize_Integer, IHaveSecretsManagerAccessRoleArn, IHaveCaseSensitiveNames_Boolean, IHaveEmptyAsNull_Boolean, IHaveEncryptionMode
        {
            /// <summary>
            /// ConnectionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-connectiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionTimeout { get; set; }
            /// <summary>
            /// MapBooleanAsBoolean
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-mapbooleanasboolean
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MapBooleanAsBoolean { get; set; }
            /// <summary>
            /// AfterConnectScript
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-afterconnectscript
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfterConnectScript { get; set; }
            /// <summary>
            /// FileTransferUploadStreams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-filetransferuploadstreams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FileTransferUploadStreams { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// ServerSideEncryptionKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-serversideencryptionkmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerSideEncryptionKmsKeyId { get; set; }
            /// <summary>
            /// ExplicitIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-explicitids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExplicitIds { get; set; }
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// TruncateColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-truncatecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TruncateColumns { get; set; }
            /// <summary>
            /// ServiceAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-serviceaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
            /// <summary>
            /// ReplaceChars
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-replacechars
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplaceChars { get; set; }
            /// <summary>
            /// TimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-timeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeFormat { get; set; }
            /// <summary>
            /// BucketFolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-bucketfolder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketFolder { get; set; }
            /// <summary>
            /// ReplaceInvalidChars
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-replaceinvalidchars
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplaceInvalidChars { get; set; }
            /// <summary>
            /// RemoveQuotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-removequotes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemoveQuotes { get; set; }
            /// <summary>
            /// LoadTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-loadtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LoadTimeout { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// TrimBlanks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-trimblanks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TrimBlanks { get; set; }
            /// <summary>
            /// DateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-dateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateFormat { get; set; }
            /// <summary>
            /// CompUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-compupdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CompUpdate { get; set; }
            /// <summary>
            /// AcceptAnyDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-acceptanydate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AcceptAnyDate { get; set; }
            /// <summary>
            /// WriteBufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-writebuffersize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteBufferSize { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
            /// <summary>
            /// CaseSensitiveNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-casesensitivenames
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaseSensitiveNames { get; set; }
            /// <summary>
            /// EmptyAsNull
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-emptyasnull
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EmptyAsNull { get; set; }
            /// <summary>
            /// EncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-redshiftsettings.html#cfn-dms-endpoint-redshiftsettings-encryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionMode { get; set; }
        }

        public class S3Settings : Humidifier.Base.BaseSubResource, IHaveTimestampColumnName, IHaveEnableStatistics_Boolean, IHaveDatePartitionSequence, IHaveCsvNullValue, IHaveIncludeOpForFullLoad_Boolean, IHaveCdcInsertsAndUpdates_Boolean, IHaveBucketName, IHaveServerSideEncryptionKmsKeyId, IHaveUseTaskStartTimeForFullLoadTimestamp_Boolean, IHaveGlueCatalogGeneration_Boolean, IHaveDataFormat, IHaveCsvDelimiter, IHaveAddTrailingPaddingCharacter_Boolean, IHaveIgnoreHeaderRows_Integer, IHaveCannedAclForObjects, IHaveRfc4180_Boolean, IHaveServiceAccessRoleArn, IHaveParquetTimestampInMillisecond_Boolean, IHavePreserveTransactions_Boolean, IHaveBucketFolder, IHaveDatePartitionDelimiter, IHaveEncodingType, IHaveAddColumnName_Boolean, IHaveCdcMinFileSize_Integer, IHaveParquetVersion, IHaveExternalTableDefinition, IHaveUseCsvNoSupValue_Boolean, IHaveMaxFileSize_Integer, IHaveCdcPath, IHaveCsvNoSupValue, IHaveCdcMaxBatchInterval_Integer, IHaveCsvRowDelimiter, IHaveRowGroupLength_Integer, IHaveDataPageSize_Integer, IHaveDatePartitionEnabled_Boolean, IHaveDictPageSizeLimit_Integer, IHaveCompressionType, IHaveDatePartitionTimezone, IHaveCdcInsertsOnly_Boolean, IHaveExpectedBucketOwner, IHaveEncryptionMode
        {
            /// <summary>
            /// TimestampColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-timestampcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampColumnName { get; set; }
            /// <summary>
            /// EnableStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-enablestatistics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableStatistics { get; set; }
            /// <summary>
            /// DatePartitionSequence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-datepartitionsequence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatePartitionSequence { get; set; }
            /// <summary>
            /// CsvNullValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-csvnullvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CsvNullValue { get; set; }
            /// <summary>
            /// IncludeOpForFullLoad
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-includeopforfullload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeOpForFullLoad { get; set; }
            /// <summary>
            /// CdcInsertsAndUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-cdcinsertsandupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CdcInsertsAndUpdates { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// ServerSideEncryptionKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-serversideencryptionkmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerSideEncryptionKmsKeyId { get; set; }
            /// <summary>
            /// UseTaskStartTimeForFullLoadTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-usetaskstarttimeforfullloadtimestamp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseTaskStartTimeForFullLoadTimestamp { get; set; }
            /// <summary>
            /// GlueCatalogGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-gluecataloggeneration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? GlueCatalogGeneration { get; set; }
            /// <summary>
            /// DataFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-dataformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFormat { get; set; }
            /// <summary>
            /// CsvDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-csvdelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CsvDelimiter { get; set; }
            /// <summary>
            /// AddTrailingPaddingCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-addtrailingpaddingcharacter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AddTrailingPaddingCharacter { get; set; }
            /// <summary>
            /// IgnoreHeaderRows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-ignoreheaderrows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IgnoreHeaderRows { get; set; }
            /// <summary>
            /// CannedAclForObjects
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-cannedaclforobjects
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CannedAclForObjects { get; set; }
            /// <summary>
            /// Rfc4180
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-rfc4180
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Rfc4180 { get; set; }
            /// <summary>
            /// ServiceAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-serviceaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessRoleArn { get; set; }
            /// <summary>
            /// ParquetTimestampInMillisecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-parquettimestampinmillisecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ParquetTimestampInMillisecond { get; set; }
            /// <summary>
            /// PreserveTransactions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-preservetransactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PreserveTransactions { get; set; }
            /// <summary>
            /// BucketFolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-bucketfolder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketFolder { get; set; }
            /// <summary>
            /// DatePartitionDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-datepartitiondelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatePartitionDelimiter { get; set; }
            /// <summary>
            /// EncodingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-encodingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncodingType { get; set; }
            /// <summary>
            /// AddColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-addcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AddColumnName { get; set; }
            /// <summary>
            /// CdcMinFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-cdcminfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CdcMinFileSize { get; set; }
            /// <summary>
            /// ParquetVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-parquetversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParquetVersion { get; set; }
            /// <summary>
            /// ExternalTableDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-externaltabledefinition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalTableDefinition { get; set; }
            /// <summary>
            /// UseCsvNoSupValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-usecsvnosupvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseCsvNoSupValue { get; set; }
            /// <summary>
            /// MaxFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-maxfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFileSize { get; set; }
            /// <summary>
            /// CdcPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-cdcpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CdcPath { get; set; }
            /// <summary>
            /// CsvNoSupValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-csvnosupvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CsvNoSupValue { get; set; }
            /// <summary>
            /// CdcMaxBatchInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-cdcmaxbatchinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CdcMaxBatchInterval { get; set; }
            /// <summary>
            /// CsvRowDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-csvrowdelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CsvRowDelimiter { get; set; }
            /// <summary>
            /// RowGroupLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-rowgrouplength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RowGroupLength { get; set; }
            /// <summary>
            /// DataPageSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-datapagesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataPageSize { get; set; }
            /// <summary>
            /// DatePartitionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-datepartitionenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DatePartitionEnabled { get; set; }
            /// <summary>
            /// DictPageSizeLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-dictpagesizelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DictPageSizeLimit { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-compressiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// DatePartitionTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-datepartitiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatePartitionTimezone { get; set; }
            /// <summary>
            /// CdcInsertsOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-cdcinsertsonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CdcInsertsOnly { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-expectedbucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
            /// <summary>
            /// EncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html#cfn-dms-endpoint-s3settings-encryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionMode { get; set; }
        }

        public class SybaseSettings : Humidifier.Base.BaseSubResource, IHaveSecretsManagerSecretId, IHaveSecretsManagerAccessRoleArn
        {
            /// <summary>
            /// SecretsManagerSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-sybasesettings.html#cfn-dms-endpoint-sybasesettings-secretsmanagersecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecretId { get; set; }
            /// <summary>
            /// SecretsManagerAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-sybasesettings.html#cfn-dms-endpoint-sybasesettings-secretsmanageraccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerAccessRoleArn { get; set; }
        }
    }
}