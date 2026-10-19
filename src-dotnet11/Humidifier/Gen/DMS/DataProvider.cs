namespace Humidifier.DMS
{
    using global::System.Collections.Generic;
    using DataProviderTypes;

    public class DataProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataProviderName, IHaveDescription, IHaveExactSettings_Boolean, IHaveVirtual_Boolean, IHaveEngine, IHaveDMSDataProviderTypesSettingsSettings
    {
        public class Attributes
        {
            public static string DataProviderArn =  "DataProviderArn" ;
            public static string DataProviderCreationTime =  "DataProviderCreationTime" ;
        }

        public override string AWSTypeName { get => AWS.DMS.DataProvider; }
        public Union<string, BaseFunction>? DataProviderName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ExactSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-exactsettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ExactSettings { get; set; }
        /// <summary>
        /// Virtual
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-virtual
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Virtual { get; set; }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-engine
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-settings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Settings
        /// </summary>
        public Union<Humidifier.DMS.DataProviderTypes.Settings, BaseFunction>? Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-dataprovider.html#cfn-dms-dataprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataProviderTypes
    {
        public class DocDbSettings : Humidifier.Base.BaseSubResource, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveCertificateArn
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-sslmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-docdbsettings.html#cfn-dms-dataprovider-docdbsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class IbmDb2LuwSettings : Humidifier.Base.BaseSubResource, IHaveSecurityMechanism_Integer, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveEncryptionAlgorithm_Integer, IHaveCertificateArn
        {
            /// <summary>
            /// SecurityMechanism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-securitymechanism
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SecurityMechanism { get; set; }
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// EncryptionAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-encryptionalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EncryptionAlgorithm { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2luwsettings.html#cfn-dms-dataprovider-ibmdb2luwsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class IbmDb2zOsSettings : Humidifier.Base.BaseSubResource, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveCertificateArn
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2zossettings.html#cfn-dms-dataprovider-ibmdb2zossettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2zossettings.html#cfn-dms-dataprovider-ibmdb2zossettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2zossettings.html#cfn-dms-dataprovider-ibmdb2zossettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2zossettings.html#cfn-dms-dataprovider-ibmdb2zossettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-ibmdb2zossettings.html#cfn-dms-dataprovider-ibmdb2zossettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class MariaDbSettings : Humidifier.Base.BaseSubResource, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveCertificateArn
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mariadbsettings.html#cfn-dms-dataprovider-mariadbsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class MicrosoftSqlServerSettings : Humidifier.Base.BaseSubResource, IHaveS3AccessRoleArn, IHaveS3Path, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveCertificateArn
        {
            /// <summary>
            /// S3AccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-s3accessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3AccessRoleArn { get; set; }
            /// <summary>
            /// S3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-s3path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Path { get; set; }
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-microsoftsqlserversettings.html#cfn-dms-dataprovider-microsoftsqlserversettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class MongoDbSettings : Humidifier.Base.BaseSubResource, IHaveAuthSource, IHaveAuthMechanism, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveAuthType, IHaveCertificateArn
        {
            /// <summary>
            /// AuthSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-authsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthSource { get; set; }
            /// <summary>
            /// AuthMechanism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-authmechanism
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthMechanism { get; set; }
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-sslmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mongodbsettings.html#cfn-dms-dataprovider-mongodbsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class MySqlSettings : Humidifier.Base.BaseSubResource, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveCertificateArn
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-mysqlsettings.html#cfn-dms-dataprovider-mysqlsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class OracleSettings : Humidifier.Base.BaseSubResource, IHaveSecretsManagerOracleAsmAccessRoleArn, IHaveSecretsManagerOracleAsmSecretId, IHaveSslMode, IHaveSecretsManagerSecurityDbEncryptionSecretId, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveAsmServer, IHaveCertificateArn, IHaveSecretsManagerSecurityDbEncryptionAccessRoleArn
        {
            /// <summary>
            /// SecretsManagerOracleAsmAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanageroracleasmaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerOracleAsmAccessRoleArn { get; set; }
            /// <summary>
            /// SecretsManagerOracleAsmSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanageroracleasmsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerOracleAsmSecretId { get; set; }
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// SecretsManagerSecurityDbEncryptionSecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanagersecuritydbencryptionsecretid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecurityDbEncryptionSecretId { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// AsmServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-asmserver
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AsmServer { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
            /// <summary>
            /// SecretsManagerSecurityDbEncryptionAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-oraclesettings.html#cfn-dms-dataprovider-oraclesettings-secretsmanagersecuritydbencryptionaccessrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsManagerSecurityDbEncryptionAccessRoleArn { get; set; }
        }

        public class PostgreSqlSettings : Humidifier.Base.BaseSubResource, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveDatabaseName, IHaveCertificateArn
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-postgresqlsettings.html#cfn-dms-dataprovider-postgresqlsettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class RedshiftSettings : Humidifier.Base.BaseSubResource, IHaveServerName, IHavePort_Integer, IHaveDatabaseName
        {
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-redshiftsettings.html#cfn-dms-dataprovider-redshiftsettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-redshiftsettings.html#cfn-dms-dataprovider-redshiftsettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-redshiftsettings.html#cfn-dms-dataprovider-redshiftsettings-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
        }

        public class Settings : Humidifier.Base.BaseSubResource, IHaveDMSDataProviderTypesMariaDbSettingsMariaDbSettings, IHaveDMSDataProviderTypesOracleSettingsOracleSettings, IHaveDMSDataProviderTypesSybaseAseSettingsSybaseAseSettings, IHaveDMSDataProviderTypesMicrosoftSqlServerSettingsMicrosoftSqlServerSettings, IHaveDMSDataProviderTypesRedshiftSettingsRedshiftSettings, IHaveDMSDataProviderTypesIbmDb2zOsSettingsIbmDb2zOsSettings, IHaveDMSDataProviderTypesMySqlSettingsMySqlSettings, IHaveDMSDataProviderTypesIbmDb2LuwSettingsIbmDb2LuwSettings, IHaveDMSDataProviderTypesDocDbSettingsDocDbSettings, IHaveDMSDataProviderTypesPostgreSqlSettingsPostgreSqlSettings, IHaveDMSDataProviderTypesMongoDbSettingsMongoDbSettings
        {
            /// <summary>
            /// MariaDbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mariadbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MariaDbSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.MariaDbSettings, BaseFunction>? MariaDbSettings { get; set; }
            /// <summary>
            /// OracleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-oraclesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OracleSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.OracleSettings, BaseFunction>? OracleSettings { get; set; }
            /// <summary>
            /// SybaseAseSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-sybaseasesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SybaseAseSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.SybaseAseSettings, BaseFunction>? SybaseAseSettings { get; set; }
            /// <summary>
            /// MicrosoftSqlServerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-microsoftsqlserversettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrosoftSqlServerSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.MicrosoftSqlServerSettings, BaseFunction>? MicrosoftSqlServerSettings { get; set; }
            /// <summary>
            /// RedshiftSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-redshiftsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.RedshiftSettings, BaseFunction>? RedshiftSettings { get; set; }
            /// <summary>
            /// IbmDb2zOsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-ibmdb2zossettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IbmDb2zOsSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.IbmDb2zOsSettings, BaseFunction>? IbmDb2zOsSettings { get; set; }
            /// <summary>
            /// MySqlSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mysqlsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MySqlSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.MySqlSettings, BaseFunction>? MySqlSettings { get; set; }
            /// <summary>
            /// IbmDb2LuwSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-ibmdb2luwsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IbmDb2LuwSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.IbmDb2LuwSettings, BaseFunction>? IbmDb2LuwSettings { get; set; }
            /// <summary>
            /// DocDbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-docdbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocDbSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.DocDbSettings, BaseFunction>? DocDbSettings { get; set; }
            /// <summary>
            /// PostgreSqlSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-postgresqlsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostgreSqlSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.PostgreSqlSettings, BaseFunction>? PostgreSqlSettings { get; set; }
            /// <summary>
            /// MongoDbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-settings.html#cfn-dms-dataprovider-settings-mongodbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MongoDbSettings
            /// </summary>
            public Union<Humidifier.DMS.DataProviderTypes.MongoDbSettings, BaseFunction>? MongoDbSettings { get; set; }
        }

        public class SybaseAseSettings : Humidifier.Base.BaseSubResource, IHaveSslMode, IHaveServerName, IHavePort_Integer, IHaveEncryptPassword_Boolean, IHaveDatabaseName, IHaveCertificateArn
        {
            /// <summary>
            /// SslMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-sybaseasesettings.html#cfn-dms-dataprovider-sybaseasesettings-sslmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SslMode { get; set; }
            /// <summary>
            /// ServerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-sybaseasesettings.html#cfn-dms-dataprovider-sybaseasesettings-servername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-sybaseasesettings.html#cfn-dms-dataprovider-sybaseasesettings-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// EncryptPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-sybaseasesettings.html#cfn-dms-dataprovider-sybaseasesettings-encryptpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncryptPassword { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-sybaseasesettings.html#cfn-dms-dataprovider-sybaseasesettings-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-dataprovider-sybaseasesettings.html#cfn-dms-dataprovider-sybaseasesettings-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }
    }
}