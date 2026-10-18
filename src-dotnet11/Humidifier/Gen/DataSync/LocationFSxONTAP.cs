namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationFSxONTAPTypes;

    public class LocationFSxONTAP : Humidifier.Base.BaseResource, IHaveTags, IHaveStorageVirtualMachineArn, IHaveSubdirectory, IHaveProtocolProtocol, IHaveStringListOfSecurityGroupArns
    {
        public class Attributes
        {
            public static string LocationUri =  "LocationUri" ;
            public static string FsxFilesystemArn =  "FsxFilesystemArn" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationFSxONTAP; }

        /// <summary>
        /// StorageVirtualMachineArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxontap.html#cfn-datasync-locationfsxontap-storagevirtualmachinearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StorageVirtualMachineArn { get; set; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxontap.html#cfn-datasync-locationfsxontap-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxontap.html#cfn-datasync-locationfsxontap-protocol
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Protocol
        /// </summary>
        public Union<Humidifier.Transfer.Protocol, BaseFunction>? Protocol { get; set; }

        /// <summary>
        /// SecurityGroupArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxontap.html#cfn-datasync-locationfsxontap-securitygrouparns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxontap.html#cfn-datasync-locationfsxontap-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LocationFSxONTAPTypes
    {
        public class CmkSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-cmksecretconfig.html#cfn-datasync-locationfsxontap-cmksecretconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-cmksecretconfig.html#cfn-datasync-locationfsxontap-cmksecretconfig-kmskeyarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-customsecretconfig.html#cfn-datasync-locationfsxontap-customsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-customsecretconfig.html#cfn-datasync-locationfsxontap-customsecretconfig-secretaccessrolearn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-managedsecretconfig.html#cfn-datasync-locationfsxontap-managedsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class NFS : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationFSxONTAPTypesNfsMountOptionsMountOptions
        {
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-nfs.html#cfn-datasync-locationfsxontap-nfs-mountoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NfsMountOptions
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.NfsMountOptions, BaseFunction>? MountOptions { get; set; }
        }

        public class NfsMountOptions : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-nfsmountoptions.html#cfn-datasync-locationfsxontap-nfsmountoptions-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class Protocol : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationFSxONTAPTypesSMBSMB, IHaveDataSyncLocationFSxONTAPTypesNFSNFS
        {
            /// <summary>
            /// SMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-protocol.html#cfn-datasync-locationfsxontap-protocol-smb
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SMB
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.SMB, BaseFunction>? SMB { get; set; }
            /// <summary>
            /// NFS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-protocol.html#cfn-datasync-locationfsxontap-protocol-nfs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NFS
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.NFS, BaseFunction>? NFS { get; set; }
        }

        public class SMB : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationFSxONTAPTypesManagedSecretConfigManagedSecretConfig, IHaveUser, IHaveDataSyncLocationFSxONTAPTypesCmkSecretConfigCmkSecretConfig, IHaveDataSyncLocationFSxONTAPTypesCustomSecretConfigCustomSecretConfig, IHaveDomain, IHaveDataSyncLocationFSxONTAPTypesSmbMountOptionsMountOptions, IHavePassword
        {
            /// <summary>
            /// ManagedSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-managedsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedSecretConfig
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.ManagedSecretConfig, BaseFunction>? ManagedSecretConfig { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-user
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? User { get; set; }
            /// <summary>
            /// CmkSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-cmksecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmkSecretConfig
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.CmkSecretConfig, BaseFunction>? CmkSecretConfig { get; set; }
            /// <summary>
            /// CustomSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-customsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomSecretConfig
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.CustomSecretConfig, BaseFunction>? CustomSecretConfig { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-domain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-mountoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmbMountOptions
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxONTAPTypes.SmbMountOptions, BaseFunction>? MountOptions { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smb.html#cfn-datasync-locationfsxontap-smb-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class SmbMountOptions : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxontap-smbmountoptions.html#cfn-datasync-locationfsxontap-smbmountoptions-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }
    }
}