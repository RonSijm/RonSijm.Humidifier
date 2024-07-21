namespace Humidifier.DMS
{
    using System.Collections.Generic;
    using DataProviderTypes;

    public class DataProvider : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string DataProviderArn =  "DataProviderArn" ;
            public static string DataProviderCreationTime =  "DataProviderCreationTime" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DMS::DataProvider";
            }
        }

        /// <summary>
        /// DataProviderName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-dataprovidername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataProviderName { get; set; }
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
        public dynamic Engine { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Settings
        /// </summary>
        public Settings Settings { get; set; }
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
        public class MicrosoftSqlServerSettings
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

        public class MySqlSettings
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

        public class OracleSettings
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

        public class PostgreSqlSettings
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

        public class Settings
        {
            /// <summary>
            /// OracleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-oraclesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OracleSettings
            /// </summary>
            public OracleSettings OracleSettings { get; set; }
            /// <summary>
            /// MicrosoftSqlServerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-microsoftsqlserversettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrosoftSqlServerSettings
            /// </summary>
            public MicrosoftSqlServerSettings MicrosoftSqlServerSettings { get; set; }
            /// <summary>
            /// MySqlSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mysqlsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MySqlSettings
            /// </summary>
            public MySqlSettings MySqlSettings { get; set; }
            /// <summary>
            /// PostgreSqlSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-postgresqlsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostgreSqlSettings
            /// </summary>
            public PostgreSqlSettings PostgreSqlSettings { get; set; }
        }
    }
}