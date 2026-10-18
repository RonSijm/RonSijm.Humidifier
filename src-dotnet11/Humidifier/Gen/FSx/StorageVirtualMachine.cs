namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using StorageVirtualMachineTypes;

    public class StorageVirtualMachine : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSvmAdminPassword, IHaveFSxStorageVirtualMachineTypesActiveDirectoryConfigurationActiveDirectoryConfiguration, IHaveRootVolumeSecurityStyle, IHaveFileSystemId, IHaveName
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string StorageVirtualMachineId =  "StorageVirtualMachineId" ;
            public static string UUID =  "UUID" ;
        }

        public override string AWSTypeName { get => AWS.FSx.StorageVirtualMachine; }
        /// <summary>
        /// SvmAdminPassword
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-storagevirtualmachine.html#cfn-fsx-storagevirtualmachine-svmadminpassword
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SvmAdminPassword { get; set; }
        /// <summary>
        /// ActiveDirectoryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-storagevirtualmachine.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ActiveDirectoryConfiguration
        /// </summary>
        public Union<Humidifier.FSx.StorageVirtualMachineTypes.ActiveDirectoryConfiguration, BaseFunction>? ActiveDirectoryConfiguration { get; set; }
        /// <summary>
        /// RootVolumeSecurityStyle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-storagevirtualmachine.html#cfn-fsx-storagevirtualmachine-rootvolumesecuritystyle
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RootVolumeSecurityStyle { get; set; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-storagevirtualmachine.html#cfn-fsx-storagevirtualmachine-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-storagevirtualmachine.html#cfn-fsx-storagevirtualmachine-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace StorageVirtualMachineTypes
    {
        public class ActiveDirectoryConfiguration : Humidifier.Base.BaseSubResource, IHaveFSxStorageVirtualMachineTypesSelfManagedActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration, IHaveNetBiosName
        {
            /// <summary>
            /// SelfManagedActiveDirectoryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedActiveDirectoryConfiguration
            /// </summary>
            public Union<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration, BaseFunction>? SelfManagedActiveDirectoryConfiguration { get; set; }
            /// <summary>
            /// NetBiosName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-netbiosname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetBiosName { get; set; }
        }

        public class SelfManagedActiveDirectoryConfiguration : Humidifier.Base.BaseSubResource, IHaveFileSystemAdministratorsGroup, IHaveUserName, IHaveDomainName, IHaveOrganizationalUnitDistinguishedName, IHaveDomainJoinServiceAccountSecret, IHaveStringListOfDnsIps, IHavePassword
        {
            /// <summary>
            /// FileSystemAdministratorsGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-filesystemadministratorsgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemAdministratorsGroup { get; set; }
            /// <summary>
            /// UserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserName { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// OrganizationalUnitDistinguishedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-organizationalunitdistinguishedname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationalUnitDistinguishedName { get; set; }
            /// <summary>
            /// DomainJoinServiceAccountSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-domainjoinserviceaccountsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainJoinServiceAccountSecret { get; set; }
            /// <summary>
            /// DnsIps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-dnsips
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DnsIps { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-storagevirtualmachine-activedirectoryconfiguration-selfmanagedactivedirectoryconfiguration-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }
    }
}