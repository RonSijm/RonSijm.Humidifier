namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationHDFSTypes;

    public class LocationHDFS : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyProviderUri, IHaveDataSyncLocationHDFSTypesQopConfigurationQopConfiguration, IHaveKerberosPrincipal, IHaveSimpleUser, IHaveReplicationFactor_Long, IHaveKerberosKeytab, IHaveListOfDataSyncLocationHDFSTypesNameNodeNameNodes, IHaveDataSyncLocationHDFSTypesCmkSecretConfigCmkSecretConfig, IHaveSubdirectory, IHaveKerberosKrb5Conf, IHaveDataSyncLocationHDFSTypesCustomSecretConfigCustomSecretConfig, IHaveBlockSize_Long, IHaveStringListOfAgentArns, IHaveAuthenticationType
    {
        public class Attributes
        {
            public static string ManagedSecretConfig =  "ManagedSecretConfig" ;
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationHDFS; }
        /// <summary>
        /// KmsKeyProviderUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-kmskeyprovideruri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyProviderUri { get; set; }
        /// <summary>
        /// QopConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-qopconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QopConfiguration
        /// </summary>
        public Union<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration, BaseFunction>? QopConfiguration { get; set; }
        /// <summary>
        /// KerberosPrincipal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-kerberosprincipal
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KerberosPrincipal { get; set; }
        /// <summary>
        /// SimpleUser
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-simpleuser
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SimpleUser { get; set; }
        /// <summary>
        /// ReplicationFactor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-replicationfactor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Long
        /// </summary>
        public Union<long, BaseFunction>? ReplicationFactor { get; set; }
        /// <summary>
        /// KerberosKeytab
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-kerberoskeytab
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KerberosKeytab { get; set; }

        /// <summary>
        /// NameNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-namenodes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NameNode
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DataSync.LocationHDFSTypes.NameNode>, IReadOnlyList<Union<Humidifier.DataSync.LocationHDFSTypes.NameNode, BaseFunction>>, BaseFunction>? NameNodes { get; set; }
        /// <summary>
        /// CmkSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-cmksecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CmkSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationHDFSTypes.CmkSecretConfig, BaseFunction>? CmkSecretConfig { get; set; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// KerberosKrb5Conf
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-kerberoskrb5conf
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KerberosKrb5Conf { get; set; }
        /// <summary>
        /// CustomSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-customsecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationHDFSTypes.CustomSecretConfig, BaseFunction>? CustomSecretConfig { get; set; }
        /// <summary>
        /// BlockSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-blocksize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Long
        /// </summary>
        public Union<long, BaseFunction>? BlockSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AgentArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-agentarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AgentArns { get; set; }

        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationhdfs.html#cfn-datasync-locationhdfs-authenticationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthenticationType { get; set; }
    }

    namespace LocationHDFSTypes
    {
        public class CmkSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-cmksecretconfig.html#cfn-datasync-locationhdfs-cmksecretconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-cmksecretconfig.html#cfn-datasync-locationhdfs-cmksecretconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class CustomSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSecretAccessRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-customsecretconfig.html#cfn-datasync-locationhdfs-customsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-customsecretconfig.html#cfn-datasync-locationhdfs-customsecretconfig-secretaccessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretAccessRoleArn { get; set; }
        }

        public class ManagedSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-managedsecretconfig.html#cfn-datasync-locationhdfs-managedsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class NameNode : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveHostname
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-namenode.html#cfn-datasync-locationhdfs-namenode-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-namenode.html#cfn-datasync-locationhdfs-namenode-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
        }

        public class QopConfiguration : Humidifier.Base.BaseSubResource, IHaveRpcProtection, IHaveDataTransferProtection
        {
            /// <summary>
            /// RpcProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-qopconfiguration.html#cfn-datasync-locationhdfs-qopconfiguration-rpcprotection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RpcProtection { get; set; }
            /// <summary>
            /// DataTransferProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationhdfs-qopconfiguration.html#cfn-datasync-locationhdfs-qopconfiguration-datatransferprotection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTransferProtection { get; set; }
        }
    }
}