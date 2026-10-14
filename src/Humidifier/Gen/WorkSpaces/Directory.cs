namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using DirectoryTypes;

    public class Directory : Humidifier.Base.BaseResource, IHaveTags, IHaveSubnetIds, IHaveTenancy
    {
        public class Attributes
        {
            public static string WorkspaceSecurityGroupId =  "WorkspaceSecurityGroupId" ;
            public static string RegistrationCode =  "RegistrationCode" ;
            public static string DnsIpv6Addresses =  "DnsIpv6Addresses" ;
            public static string DirectoryType =  "DirectoryType" ;
            public static string CustomerUserName =  "CustomerUserName" ;
            public static string IDCConfig =  "IDCConfig" ;
            public static string DirectoryId =  "DirectoryId" ;
            public static string State =  "State" ;
            public static string Alias =  "Alias" ;
            public static string DnsIpAddresses =  "DnsIpAddresses" ;
            public static string Arn =  "Arn" ;
            public static string DirectoryName =  "DirectoryName" ;
            public static string IamRoleId =  "IamRoleId" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.Directory; }
        /// <summary>
        /// Tenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-tenancy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Tenancy { get; set; }
        /// <summary>
        /// SelfservicePermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-selfservicepermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SelfservicePermissions
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions SelfservicePermissions { get; set; }
        /// <summary>
        /// StreamingProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-streamingproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamingProperties
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties StreamingProperties { get; set; }
        /// <summary>
        /// MicrosoftEntraConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-microsoftentraconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MicrosoftEntraConfig
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig MicrosoftEntraConfig { get; set; }
        /// <summary>
        /// WorkspaceDirectoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacedirectoryname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkspaceDirectoryName { get; set; }
        /// <summary>
        /// IpGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-ipgroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic IpGroupIds { get; set; }
        /// <summary>
        /// SamlProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-samlproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SamlProperties
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.SamlProperties SamlProperties { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-subnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubnetIds { get; set; }
        /// <summary>
        /// WorkspaceCreationProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacecreationproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultWorkspaceCreationProperties
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties WorkspaceCreationProperties { get; set; }
        /// <summary>
        /// UserIdentityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-useridentitytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserIdentityType { get; set; }
        /// <summary>
        /// WorkspaceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkspaceType { get; set; }
        /// <summary>
        /// ActiveDirectoryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-activedirectoryconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ActiveDirectoryConfig
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig ActiveDirectoryConfig { get; set; }
        /// <summary>
        /// EnableSelfService
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-enableselfservice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableSelfService { get; set; }
        /// <summary>
        /// WorkspaceDirectoryDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacedirectorydescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkspaceDirectoryDescription { get; set; }
        /// <summary>
        /// WorkspaceAccessProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspaceaccessproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkspaceAccessProperties
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties WorkspaceAccessProperties { get; set; }
        /// <summary>
        /// CertificateBasedAuthProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-certificatebasedauthproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CertificateBasedAuthProperties
        /// </summary>
        public Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties CertificateBasedAuthProperties { get; set; }
        /// <summary>
        /// EndpointEncryptionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-endpointencryptionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointEncryptionMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// IdcInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-idcinstancearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdcInstanceArn { get; set; }
    }

    namespace DirectoryTypes
    {
        public class AccessEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcEndpointId
        {
            /// <summary>
            /// AccessEndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpoint.html#cfn-workspaces-directory-accessendpoint-accessendpointtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessEndpointType { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpoint.html#cfn-workspaces-directory-accessendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcEndpointId { get; set; }
        }

        public class AccessEndpointConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InternetFallbackProtocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpointconfig.html#cfn-workspaces-directory-accessendpointconfig-internetfallbackprotocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InternetFallbackProtocols { get; set; }
            /// <summary>
            /// AccessEndpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpointconfig.html#cfn-workspaces-directory-accessendpointconfig-accessendpoints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AccessEndpoint
            /// </summary>
            public List<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpoint> AccessEndpoints { get; set; }
        }

        public class ActiveDirectoryConfig : Humidifier.Base.BaseSubResource, IHaveDomainName
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-activedirectoryconfig.html#cfn-workspaces-directory-activedirectoryconfig-domainname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// ServiceAccountSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-activedirectoryconfig.html#cfn-workspaces-directory-activedirectoryconfig-serviceaccountsecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceAccountSecretArn { get; set; }
        }

        public class CertificateBasedAuthProperties : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCertificateAuthorityArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-certificatebasedauthproperties.html#cfn-workspaces-directory-certificatebasedauthproperties-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// CertificateAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-certificatebasedauthproperties.html#cfn-workspaces-directory-certificatebasedauthproperties-certificateauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateAuthorityArn { get; set; }
        }

        public class DefaultWorkspaceCreationProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UserEnabledAsLocalAdministrator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-userenabledaslocaladministrator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UserEnabledAsLocalAdministrator { get; set; }
            /// <summary>
            /// EnableMaintenanceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-enablemaintenancemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableMaintenanceMode { get; set; }
            /// <summary>
            /// InstanceIamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-instanceiamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceIamRoleArn { get; set; }
            /// <summary>
            /// CustomSecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-customsecuritygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomSecurityGroupId { get; set; }
            /// <summary>
            /// EnableInternetAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-enableinternetaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableInternetAccess { get; set; }
            /// <summary>
            /// DefaultOu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-defaultou
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultOu { get; set; }
        }

        public class GlobalAcceleratorForDirectory : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// PreferredProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-globalacceleratorfordirectory.html#cfn-workspaces-directory-globalacceleratorfordirectory-preferredprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreferredProtocol { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-globalacceleratorfordirectory.html#cfn-workspaces-directory-globalacceleratorfordirectory-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class IDCConfig : Humidifier.Base.BaseSubResource, IHaveInstanceArn, IHaveApplicationArn
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-idcconfig.html#cfn-workspaces-directory-idcconfig-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationArn { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-idcconfig.html#cfn-workspaces-directory-idcconfig-instancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceArn { get; set; }
        }

        public class MicrosoftEntraConfig : Humidifier.Base.BaseSubResource, IHaveTenantId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-microsoftentraconfig.html#cfn-workspaces-directory-microsoftentraconfig-tenantid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// ApplicationConfigSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-microsoftentraconfig.html#cfn-workspaces-directory-microsoftentraconfig-applicationconfigsecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationConfigSecretArn { get; set; }
        }

        public class SamlProperties : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-samlproperties.html#cfn-workspaces-directory-samlproperties-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// RelayStateParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-samlproperties.html#cfn-workspaces-directory-samlproperties-relaystateparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelayStateParameterName { get; set; }
            /// <summary>
            /// UserAccessUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-samlproperties.html#cfn-workspaces-directory-samlproperties-useraccessurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserAccessUrl { get; set; }
        }

        public class SelfservicePermissions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChangeComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-changecomputetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChangeComputeType { get; set; }
            /// <summary>
            /// IncreaseVolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-increasevolumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncreaseVolumeSize { get; set; }
            /// <summary>
            /// RestartWorkspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-restartworkspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RestartWorkspace { get; set; }
            /// <summary>
            /// SwitchRunningMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-switchrunningmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SwitchRunningMode { get; set; }
            /// <summary>
            /// RebuildWorkspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-rebuildworkspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RebuildWorkspace { get; set; }
        }

        public class StorageConnector : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveConnectorType
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-storageconnector.html#cfn-workspaces-directory-storageconnector-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-storageconnector.html#cfn-workspaces-directory-storageconnector-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorType { get; set; }
        }

        public class StreamingProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StorageConnectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-storageconnectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StorageConnector
            /// </summary>
            public List<Humidifier.WorkSpaces.DirectoryTypes.StorageConnector> StorageConnectors { get; set; }
            /// <summary>
            /// GlobalAccelerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-globalaccelerator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalAcceleratorForDirectory
            /// </summary>
            public Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory GlobalAccelerator { get; set; }
            /// <summary>
            /// UserSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-usersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UserSetting
            /// </summary>
            public List<Humidifier.WorkSpaces.DirectoryTypes.UserSetting> UserSettings { get; set; }
            /// <summary>
            /// StreamingExperiencePreferredProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-streamingexperiencepreferredprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamingExperiencePreferredProtocol { get; set; }
        }

        public class UserSetting : Humidifier.Base.BaseSubResource, IHaveAction, IHavePermission, IHaveMaximumLength
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-usersetting.html#cfn-workspaces-directory-usersetting-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// MaximumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-usersetting.html#cfn-workspaces-directory-usersetting-maximumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumLength { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-usersetting.html#cfn-workspaces-directory-usersetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Permission { get; set; }
        }

        public class WorkspaceAccessProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeviceTypeZeroClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypezeroclient
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeZeroClient { get; set; }
            /// <summary>
            /// DeviceTypeWorkSpacesThinClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeworkspacesthinclient
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeWorkSpacesThinClient { get; set; }
            /// <summary>
            /// AccessEndpointConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-accessendpointconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessEndpointConfig
            /// </summary>
            public Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig AccessEndpointConfig { get; set; }
            /// <summary>
            /// DeviceTypeChromeOs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypechromeos
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeChromeOs { get; set; }
            /// <summary>
            /// DeviceTypeIos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeios
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeIos { get; set; }
            /// <summary>
            /// DeviceTypeWindows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypewindows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeWindows { get; set; }
            /// <summary>
            /// DeviceTypeOsx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeosx
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeOsx { get; set; }
            /// <summary>
            /// DeviceTypeWeb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeweb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeWeb { get; set; }
            /// <summary>
            /// DeviceTypeAndroid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeandroid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeAndroid { get; set; }
            /// <summary>
            /// DeviceTypeLinux
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypelinux
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceTypeLinux { get; set; }
        }
    }
}