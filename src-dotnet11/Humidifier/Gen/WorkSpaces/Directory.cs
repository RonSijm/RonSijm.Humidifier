namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;
    using DirectoryTypes;

    public class Directory : Humidifier.Base.BaseResource, IHaveTags, IHaveTenancy, IHaveWorkSpacesDirectoryTypesSelfservicePermissionsSelfservicePermissions, IHaveWorkSpacesDirectoryTypesStreamingPropertiesStreamingProperties, IHaveWorkSpacesDirectoryTypesMicrosoftEntraConfigMicrosoftEntraConfig, IHaveWorkspaceDirectoryName, IHaveStringListOfIpGroupIds, IHaveWorkSpacesDirectoryTypesSamlPropertiesSamlProperties, IHaveStringListOfSubnetIds, IHaveWorkSpacesDirectoryTypesDefaultWorkspaceCreationPropertiesWorkspaceCreationProperties, IHaveUserIdentityType, IHaveWorkspaceType, IHaveWorkSpacesDirectoryTypesActiveDirectoryConfigActiveDirectoryConfig, IHaveEnableSelfService_Boolean, IHaveWorkspaceDirectoryDescription, IHaveWorkSpacesDirectoryTypesWorkspaceAccessPropertiesWorkspaceAccessProperties, IHaveWorkSpacesDirectoryTypesCertificateBasedAuthPropertiesCertificateBasedAuthProperties, IHaveEndpointEncryptionMode, IHaveIdcInstanceArn
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
        public Union<string, BaseFunction>? Tenancy { get; set; }
        /// <summary>
        /// SelfservicePermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-selfservicepermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SelfservicePermissions
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.SelfservicePermissions, BaseFunction>? SelfservicePermissions { get; set; }
        /// <summary>
        /// StreamingProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-streamingproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamingProperties
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties, BaseFunction>? StreamingProperties { get; set; }
        /// <summary>
        /// MicrosoftEntraConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-microsoftentraconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MicrosoftEntraConfig
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig, BaseFunction>? MicrosoftEntraConfig { get; set; }
        /// <summary>
        /// WorkspaceDirectoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacedirectoryname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkspaceDirectoryName { get; set; }
        /// <summary>
        /// IpGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-ipgroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IpGroupIds { get; set; }
        /// <summary>
        /// SamlProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-samlproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SamlProperties
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.SamlProperties, BaseFunction>? SamlProperties { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-subnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// WorkspaceCreationProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacecreationproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultWorkspaceCreationProperties
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties, BaseFunction>? WorkspaceCreationProperties { get; set; }
        /// <summary>
        /// UserIdentityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-useridentitytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserIdentityType { get; set; }
        /// <summary>
        /// WorkspaceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkspaceType { get; set; }
        /// <summary>
        /// ActiveDirectoryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-activedirectoryconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ActiveDirectoryConfig
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig, BaseFunction>? ActiveDirectoryConfig { get; set; }
        /// <summary>
        /// EnableSelfService
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-enableselfservice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableSelfService { get; set; }
        /// <summary>
        /// WorkspaceDirectoryDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspacedirectorydescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkspaceDirectoryDescription { get; set; }
        /// <summary>
        /// WorkspaceAccessProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-workspaceaccessproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkspaceAccessProperties
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.WorkspaceAccessProperties, BaseFunction>? WorkspaceAccessProperties { get; set; }
        /// <summary>
        /// CertificateBasedAuthProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-certificatebasedauthproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CertificateBasedAuthProperties
        /// </summary>
        public Union<Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties, BaseFunction>? CertificateBasedAuthProperties { get; set; }
        /// <summary>
        /// EndpointEncryptionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-endpointencryptionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointEncryptionMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// IdcInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-directory.html#cfn-workspaces-directory-idcinstancearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdcInstanceArn { get; set; }
    }

    namespace DirectoryTypes
    {
        public class AccessEndpoint : Humidifier.Base.BaseSubResource, IHaveAccessEndpointType, IHaveVpcEndpointId
        {
            /// <summary>
            /// AccessEndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpoint.html#cfn-workspaces-directory-accessendpoint-accessendpointtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessEndpointType { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpoint.html#cfn-workspaces-directory-accessendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }

        public class AccessEndpointConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfInternetFallbackProtocols, IHaveListOfWorkSpacesDirectoryTypesAccessEndpointAccessEndpoints
        {
            /// <summary>
            /// InternetFallbackProtocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpointconfig.html#cfn-workspaces-directory-accessendpointconfig-internetfallbackprotocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InternetFallbackProtocols { get; set; }
            /// <summary>
            /// AccessEndpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-accessendpointconfig.html#cfn-workspaces-directory-accessendpointconfig-accessendpoints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AccessEndpoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpoint>, IReadOnlyList<Union<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpoint, BaseFunction>>, BaseFunction>? AccessEndpoints { get; set; }
        }

        public class ActiveDirectoryConfig : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveServiceAccountSecretArn
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-activedirectoryconfig.html#cfn-workspaces-directory-activedirectoryconfig-domainname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// ServiceAccountSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-activedirectoryconfig.html#cfn-workspaces-directory-activedirectoryconfig-serviceaccountsecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccountSecretArn { get; set; }
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
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// CertificateAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-certificatebasedauthproperties.html#cfn-workspaces-directory-certificatebasedauthproperties-certificateauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }
        }

        public class DefaultWorkspaceCreationProperties : Humidifier.Base.BaseSubResource, IHaveUserEnabledAsLocalAdministrator_Boolean, IHaveEnableMaintenanceMode_Boolean, IHaveInstanceIamRoleArn, IHaveCustomSecurityGroupId, IHaveEnableInternetAccess_Boolean, IHaveDefaultOu
        {
            /// <summary>
            /// UserEnabledAsLocalAdministrator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-userenabledaslocaladministrator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UserEnabledAsLocalAdministrator { get; set; }
            /// <summary>
            /// EnableMaintenanceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-enablemaintenancemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableMaintenanceMode { get; set; }
            /// <summary>
            /// InstanceIamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-instanceiamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceIamRoleArn { get; set; }
            /// <summary>
            /// CustomSecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-customsecuritygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomSecurityGroupId { get; set; }
            /// <summary>
            /// EnableInternetAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-enableinternetaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInternetAccess { get; set; }
            /// <summary>
            /// DefaultOu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-defaultworkspacecreationproperties.html#cfn-workspaces-directory-defaultworkspacecreationproperties-defaultou
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultOu { get; set; }
        }

        public class GlobalAcceleratorForDirectory : Humidifier.Base.BaseSubResource, IHavePreferredProtocol, IHaveMode
        {
            /// <summary>
            /// PreferredProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-globalacceleratorfordirectory.html#cfn-workspaces-directory-globalacceleratorfordirectory-preferredprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredProtocol { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-globalacceleratorfordirectory.html#cfn-workspaces-directory-globalacceleratorfordirectory-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class IDCConfig : Humidifier.Base.BaseSubResource, IHaveApplicationArn, IHaveInstanceArn
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-idcconfig.html#cfn-workspaces-directory-idcconfig-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationArn { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-idcconfig.html#cfn-workspaces-directory-idcconfig-instancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceArn { get; set; }
        }

        public class MicrosoftEntraConfig : Humidifier.Base.BaseSubResource, IHaveTenantId, IHaveApplicationConfigSecretArn
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-microsoftentraconfig.html#cfn-workspaces-directory-microsoftentraconfig-tenantid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// ApplicationConfigSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-microsoftentraconfig.html#cfn-workspaces-directory-microsoftentraconfig-applicationconfigsecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationConfigSecretArn { get; set; }
        }

        public class SamlProperties : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveRelayStateParameterName, IHaveUserAccessUrl
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-samlproperties.html#cfn-workspaces-directory-samlproperties-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// RelayStateParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-samlproperties.html#cfn-workspaces-directory-samlproperties-relaystateparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelayStateParameterName { get; set; }
            /// <summary>
            /// UserAccessUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-samlproperties.html#cfn-workspaces-directory-samlproperties-useraccessurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAccessUrl { get; set; }
        }

        public class SelfservicePermissions : Humidifier.Base.BaseSubResource, IHaveChangeComputeType, IHaveIncreaseVolumeSize, IHaveRestartWorkspace, IHaveSwitchRunningMode, IHaveRebuildWorkspace
        {
            /// <summary>
            /// ChangeComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-changecomputetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChangeComputeType { get; set; }
            /// <summary>
            /// IncreaseVolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-increasevolumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncreaseVolumeSize { get; set; }
            /// <summary>
            /// RestartWorkspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-restartworkspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RestartWorkspace { get; set; }
            /// <summary>
            /// SwitchRunningMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-switchrunningmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SwitchRunningMode { get; set; }
            /// <summary>
            /// RebuildWorkspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-selfservicepermissions.html#cfn-workspaces-directory-selfservicepermissions-rebuildworkspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RebuildWorkspace { get; set; }
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
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-storageconnector.html#cfn-workspaces-directory-storageconnector-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorType { get; set; }
        }

        public class StreamingProperties : Humidifier.Base.BaseSubResource, IHaveListOfWorkSpacesDirectoryTypesStorageConnectorStorageConnectors, IHaveWorkSpacesDirectoryTypesGlobalAcceleratorForDirectoryGlobalAccelerator, IHaveListOfWorkSpacesDirectoryTypesUserSettingUserSettings, IHaveStreamingExperiencePreferredProtocol
        {
            /// <summary>
            /// StorageConnectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-storageconnectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StorageConnector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkSpaces.DirectoryTypes.StorageConnector>, IReadOnlyList<Union<Humidifier.WorkSpaces.DirectoryTypes.StorageConnector, BaseFunction>>, BaseFunction>? StorageConnectors { get; set; }
            /// <summary>
            /// GlobalAccelerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-globalaccelerator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalAcceleratorForDirectory
            /// </summary>
            public Union<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory, BaseFunction>? GlobalAccelerator { get; set; }
            /// <summary>
            /// UserSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-usersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UserSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkSpaces.DirectoryTypes.UserSetting>, IReadOnlyList<Union<Humidifier.WorkSpaces.DirectoryTypes.UserSetting, BaseFunction>>, BaseFunction>? UserSettings { get; set; }
            /// <summary>
            /// StreamingExperiencePreferredProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-streamingproperties.html#cfn-workspaces-directory-streamingproperties-streamingexperiencepreferredprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamingExperiencePreferredProtocol { get; set; }
        }

        public class UserSetting : Humidifier.Base.BaseSubResource, IHaveAction, IHaveMaximumLength_Integer, IHavePermission
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-usersetting.html#cfn-workspaces-directory-usersetting-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// MaximumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-usersetting.html#cfn-workspaces-directory-usersetting-maximumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumLength { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-usersetting.html#cfn-workspaces-directory-usersetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
        }

        public class WorkspaceAccessProperties : Humidifier.Base.BaseSubResource, IHaveDeviceTypeZeroClient, IHaveDeviceTypeWorkSpacesThinClient, IHaveWorkSpacesDirectoryTypesAccessEndpointConfigAccessEndpointConfig, IHaveDeviceTypeChromeOs, IHaveDeviceTypeIos, IHaveDeviceTypeWindows, IHaveDeviceTypeOsx, IHaveDeviceTypeWeb, IHaveDeviceTypeAndroid, IHaveDeviceTypeLinux
        {
            /// <summary>
            /// DeviceTypeZeroClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypezeroclient
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeZeroClient { get; set; }
            /// <summary>
            /// DeviceTypeWorkSpacesThinClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeworkspacesthinclient
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeWorkSpacesThinClient { get; set; }
            /// <summary>
            /// AccessEndpointConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-accessendpointconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessEndpointConfig
            /// </summary>
            public Union<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig, BaseFunction>? AccessEndpointConfig { get; set; }
            /// <summary>
            /// DeviceTypeChromeOs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypechromeos
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeChromeOs { get; set; }
            /// <summary>
            /// DeviceTypeIos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeios
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeIos { get; set; }
            /// <summary>
            /// DeviceTypeWindows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypewindows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeWindows { get; set; }
            /// <summary>
            /// DeviceTypeOsx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeosx
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeOsx { get; set; }
            /// <summary>
            /// DeviceTypeWeb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeweb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeWeb { get; set; }
            /// <summary>
            /// DeviceTypeAndroid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypeandroid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeAndroid { get; set; }
            /// <summary>
            /// DeviceTypeLinux
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-directory-workspaceaccessproperties.html#cfn-workspaces-directory-workspaceaccessproperties-devicetypelinux
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceTypeLinux { get; set; }
        }
    }
}