namespace Humidifier.Grafana
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringListOfNotificationDestinations, IHavePluginAdminEnabled_Boolean, IHaveDescription, IHavePermissionType, IHaveAccountAccessType, IHaveStackSetName, IHaveGrafanaWorkspaceTypesSamlConfigurationSamlConfiguration, IHaveStringListOfOrganizationalUnits, IHaveRoleArn, IHaveName, IHaveGrafanaVersion, IHaveStringListOfDataSources, IHaveStringListOfAuthenticationProviders, IHaveOrganizationRoleName, IHaveGrafanaWorkspaceTypesVpcConfigurationVpcConfiguration, IHaveGrafanaWorkspaceTypesNetworkAccessControlNetworkAccessControl, IHaveClientToken, IHaveListOfGrafanaWorkspaceTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string GrafanaVersion =  "GrafanaVersion" ;
            public static string Endpoint =  "Endpoint" ;
            public static string CreationTimestamp =  "CreationTimestamp" ;
            public static string SsoClientId =  "SsoClientId" ;
            public static string Id =  "Id" ;
            public static string ModificationTimestamp =  "ModificationTimestamp" ;
            public static string SamlConfigurationStatus =  "SamlConfigurationStatus" ;
        }

        public override string AWSTypeName { get => AWS.Grafana.Workspace; }
        /// <summary>
        /// NotificationDestinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-notificationdestinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotificationDestinations { get; set; }
        /// <summary>
        /// PluginAdminEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-pluginadminenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PluginAdminEnabled { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// PermissionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-permissiontype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PermissionType { get; set; }

        /// <summary>
        /// AccountAccessType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-accountaccesstype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccountAccessType { get; set; }
        /// <summary>
        /// StackSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-stacksetname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StackSetName { get; set; }
        /// <summary>
        /// SamlConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-samlconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SamlConfiguration
        /// </summary>
        public Union<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration, BaseFunction>? SamlConfiguration { get; set; }
        /// <summary>
        /// OrganizationalUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-organizationalunits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrganizationalUnits { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// GrafanaVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-grafanaversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GrafanaVersion { get; set; }
        /// <summary>
        /// DataSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-datasources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DataSources { get; set; }

        /// <summary>
        /// AuthenticationProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-authenticationproviders
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthenticationProviders { get; set; }
        /// <summary>
        /// OrganizationRoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-organizationrolename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OrganizationRoleName { get; set; }
        /// <summary>
        /// VpcConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-vpcconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfiguration
        /// </summary>
        public Union<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
        /// <summary>
        /// NetworkAccessControl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-networkaccesscontrol
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkAccessControl
        /// </summary>
        public Union<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl, BaseFunction>? NetworkAccessControl { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-grafana-workspace.html#cfn-grafana-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Grafana.WorkspaceTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Grafana.WorkspaceTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkspaceTypes
    {
        public class AssertionAttributes : Humidifier.Base.BaseSubResource, IHaveRole, IHaveEmail, IHaveOrg, IHaveGroups, IHaveLogin, IHaveName
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-assertionattributes.html#cfn-grafana-workspace-assertionattributes-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-assertionattributes.html#cfn-grafana-workspace-assertionattributes-email
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Email { get; set; }
            /// <summary>
            /// Org
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-assertionattributes.html#cfn-grafana-workspace-assertionattributes-org
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Org { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-assertionattributes.html#cfn-grafana-workspace-assertionattributes-groups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// Login
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-assertionattributes.html#cfn-grafana-workspace-assertionattributes-login
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Login { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-assertionattributes.html#cfn-grafana-workspace-assertionattributes-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IdpMetadata : Humidifier.Base.BaseSubResource, IHaveXml, IHaveUrl
        {
            /// <summary>
            /// Xml
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-idpmetadata.html#cfn-grafana-workspace-idpmetadata-xml
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Xml { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-idpmetadata.html#cfn-grafana-workspace-idpmetadata-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class NetworkAccessControl : Humidifier.Base.BaseSubResource, IHaveStringListOfPrefixListIds, IHaveStringListOfVpceIds
        {
            /// <summary>
            /// PrefixListIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-networkaccesscontrol.html#cfn-grafana-workspace-networkaccesscontrol-prefixlistids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PrefixListIds { get; set; }
            /// <summary>
            /// VpceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-networkaccesscontrol.html#cfn-grafana-workspace-networkaccesscontrol-vpceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpceIds { get; set; }
        }

        public class RoleValues : Humidifier.Base.BaseSubResource, IHaveStringListOfEditor, IHaveStringListOfAdmin
        {
            /// <summary>
            /// Editor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-rolevalues.html#cfn-grafana-workspace-rolevalues-editor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Editor { get; set; }
            /// <summary>
            /// Admin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-rolevalues.html#cfn-grafana-workspace-rolevalues-admin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Admin { get; set; }
        }

        public class SamlConfiguration : Humidifier.Base.BaseSubResource, IHaveLoginValidityDuration_Double, IHaveGrafanaWorkspaceTypesRoleValuesRoleValues, IHaveGrafanaWorkspaceTypesIdpMetadataIdpMetadata, IHaveGrafanaWorkspaceTypesAssertionAttributesAssertionAttributes, IHaveStringListOfAllowedOrganizations
        {
            /// <summary>
            /// LoginValidityDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-samlconfiguration.html#cfn-grafana-workspace-samlconfiguration-loginvalidityduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LoginValidityDuration { get; set; }
            /// <summary>
            /// RoleValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-samlconfiguration.html#cfn-grafana-workspace-samlconfiguration-rolevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RoleValues
            /// </summary>
            public Union<Humidifier.Grafana.WorkspaceTypes.RoleValues, BaseFunction>? RoleValues { get; set; }
            /// <summary>
            /// IdpMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-samlconfiguration.html#cfn-grafana-workspace-samlconfiguration-idpmetadata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IdpMetadata
            /// </summary>
            public Union<Humidifier.Grafana.WorkspaceTypes.IdpMetadata, BaseFunction>? IdpMetadata { get; set; }
            /// <summary>
            /// AssertionAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-samlconfiguration.html#cfn-grafana-workspace-samlconfiguration-assertionattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssertionAttributes
            /// </summary>
            public Union<Humidifier.Grafana.WorkspaceTypes.AssertionAttributes, BaseFunction>? AssertionAttributes { get; set; }
            /// <summary>
            /// AllowedOrganizations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-samlconfiguration.html#cfn-grafana-workspace-samlconfiguration-allowedorganizations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedOrganizations { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-tagsitems.html#cfn-grafana-workspace-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-tagsitems.html#cfn-grafana-workspace-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-vpcconfiguration.html#cfn-grafana-workspace-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-grafana-workspace-vpcconfiguration.html#cfn-grafana-workspace-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}