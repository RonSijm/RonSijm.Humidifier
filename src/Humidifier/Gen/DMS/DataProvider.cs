namespace Humidifier.DMS
{
    using System.Collections.Generic;
    using DataProviderTypes;

    public class DataProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveEngine, IHaveDataProviderName, IHaveDataProviderIdentifier
    {
        public class Attributes
        {
            public static string DataProviderArn =  "DataProviderArn" ;
            public static string DataProviderCreationTime =  "DataProviderCreationTime" ;
        }

        public override string AWSTypeName { get => AWS.DMS.DataProvider; }
        public dynamic DataProviderName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ExactSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-exactsettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ExactSettings { get; set; }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-engine
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Engine { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Settings
        /// </summary>
        public Humidifier.DMS.DataProviderTypes.Settings Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// DataProviderIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-dataprovideridentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataProviderIdentifier { get; set; }
    }

    namespace DataProviderTypes
    {
        public class DocDbSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveDatabaseName, IHaveCertificateArn, IHaveServerName, IHaveSslMode
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-sslmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class MariaDbSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveCertificateArn, IHaveServerName, IHaveSslMode
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class MicrosoftSqlServerSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveDatabaseName, IHaveCertificateArn, IHaveServerName, IHaveSslMode
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class MongoDbSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveDatabaseName, IHaveCertificateArn, IHaveAuthType, IHaveServerName, IHaveSslMode, IHaveAuthSource, IHaveAuthMechanism
        {
            /// <summary>
            /// AuthSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-authsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthSource { get; set; }
            /// <summary>
            /// AuthMechanism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-authmechanism
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthMechanism { get; set; }
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-sslmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class MySqlSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveCertificateArn, IHaveServerName, IHaveSslMode
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class OracleSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveDatabaseName, IHaveCertificateArn, IHaveServerName, IHaveSslMode, IHaveSecretsManagerOracleAsmAccessRoleArn, IHaveSecretsManagerOracleAsmSecretId, IHaveAsmServer
        {
            /// <summary>
            /// SecretsManagerOracleAsmAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanageroracleasmaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretsManagerOracleAsmAccessRoleArn { get; set; }
            /// <summary>
            /// SecretsManagerOracleAsmSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanageroracleasmsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretsManagerOracleAsmSecretId { get; set; }
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// SecretsManagerSecurityDbEncryptionSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanagersecuritydbencryptionsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretsManagerSecurityDbEncryptionSecretId { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// AsmServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-asmserver
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AsmServer { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
            /// <summary>
            /// SecretsManagerSecurityDbEncryptionAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanagersecuritydbencryptionaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretsManagerSecurityDbEncryptionAccessRoleArn { get; set; }
        }

        public class PostgreSqlSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveDatabaseName, IHaveCertificateArn, IHaveServerName, IHaveSslMode
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class RedshiftSettings : Humidifier.Base.BaseSubResource, IHavePort, IHaveDatabaseName, IHaveServerName
        {
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-redshiftsettings.html#cfn-dms-dataprovider-redshiftsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-redshiftsettings.html#cfn-dms-dataprovider-redshiftsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-redshiftsettings.html#cfn-dms-dataprovider-redshiftsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
        }

        public class Settings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MariaDbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mariadbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MariaDbSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.MariaDbSettings MariaDbSettings { get; set; }
            /// <summary>
            /// OracleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-oraclesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OracleSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.OracleSettings OracleSettings { get; set; }
            /// <summary>
            /// MicrosoftSqlServerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-microsoftsqlserversettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrosoftSqlServerSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings MicrosoftSqlServerSettings { get; set; }
            /// <summary>
            /// RedshiftSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-redshiftsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.RedshiftSettings RedshiftSettings { get; set; }
            /// <summary>
            /// MySqlSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mysqlsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MySqlSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.MySqlSettings MySqlSettings { get; set; }
            /// <summary>
            /// DocDbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-docdbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocDbSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.DocDbSettings DocDbSettings { get; set; }
            /// <summary>
            /// PostgreSqlSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-postgresqlsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostgreSqlSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.PostgreSqlSettings PostgreSqlSettings { get; set; }
            /// <summary>
            /// MongoDbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mongodbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MongoDbSettings
            /// </summary>
            public Humidifier.DMS.DataProviderTypes.MongoDbSettings MongoDbSettings { get; set; }
        }
    }
}