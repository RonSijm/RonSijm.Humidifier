namespace Humidifier.VerifiedPermissions
{
    using global::System.Collections.Generic;
    using IdentitySourceTypes;

    public class IdentitySource : Humidifier.Base.BaseResource, IHavePrincipalEntityType, IHaveVerifiedPermissionsIdentitySourceTypesIdentitySourceConfigurationConfiguration, IHavePolicyStoreId
    {
        public class Attributes
        {
            public static string IdentitySourceId =  "IdentitySourceId" ;
        }

        public override string AWSTypeName { get => AWS.VerifiedPermissions.IdentitySource; }
        /// <summary>
        /// PrincipalEntityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-identitysource.html#cfn-verifiedpermissions-identitysource-principalentitytype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrincipalEntityType { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-identitysource.html#cfn-verifiedpermissions-identitysource-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdentitySourceConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-identitysource.html#cfn-verifiedpermissions-identitysource-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyStoreId { get; set; }
    }

    namespace IdentitySourceTypes
    {
        public class CognitoGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveGroupEntityType
        {
            /// <summary>
            /// GroupEntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitogroupconfiguration.html#cfn-verifiedpermissions-identitysource-cognitogroupconfiguration-groupentitytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupEntityType { get; set; }
        }

        public class CognitoUserPoolConfiguration : Humidifier.Base.BaseSubResource, IHaveUserPoolArn, IHaveVerifiedPermissionsIdentitySourceTypesCognitoGroupConfigurationGroupConfiguration, IHaveStringListOfClientIds
        {
            /// <summary>
            /// UserPoolArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitouserpoolconfiguration.html#cfn-verifiedpermissions-identitysource-cognitouserpoolconfiguration-userpoolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolArn { get; set; }
            /// <summary>
            /// GroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitouserpoolconfiguration.html#cfn-verifiedpermissions-identitysource-cognitouserpoolconfiguration-groupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoGroupConfiguration
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration, BaseFunction>? GroupConfiguration { get; set; }
            /// <summary>
            /// ClientIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitouserpoolconfiguration.html#cfn-verifiedpermissions-identitysource-cognitouserpoolconfiguration-clientids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ClientIds { get; set; }
        }

        public class IdentitySourceConfiguration : Humidifier.Base.BaseSubResource, IHaveVerifiedPermissionsIdentitySourceTypesCognitoUserPoolConfigurationCognitoUserPoolConfiguration, IHaveVerifiedPermissionsIdentitySourceTypesOpenIdConnectConfigurationOpenIdConnectConfiguration
        {
            /// <summary>
            /// CognitoUserPoolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-identitysourceconfiguration.html#cfn-verifiedpermissions-identitysource-identitysourceconfiguration-cognitouserpoolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoUserPoolConfiguration
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration, BaseFunction>? CognitoUserPoolConfiguration { get; set; }
            /// <summary>
            /// OpenIdConnectConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-identitysourceconfiguration.html#cfn-verifiedpermissions-identitysource-identitysourceconfiguration-openidconnectconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectConfiguration
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectConfiguration, BaseFunction>? OpenIdConnectConfiguration { get; set; }
        }

        public class OpenIdConnectAccessTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAudiences, IHavePrincipalIdClaim
        {
            /// <summary>
            /// Audiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration-audiences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Audiences { get; set; }
            /// <summary>
            /// PrincipalIdClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration-principalidclaim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalIdClaim { get; set; }
        }

        public class OpenIdConnectConfiguration : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveVerifiedPermissionsIdentitySourceTypesOpenIdConnectTokenSelectionTokenSelection, IHaveVerifiedPermissionsIdentitySourceTypesOpenIdConnectGroupConfigurationGroupConfiguration, IHaveEntityIdPrefix
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// TokenSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-tokenselection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OpenIdConnectTokenSelection
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectTokenSelection, BaseFunction>? TokenSelection { get; set; }
            /// <summary>
            /// GroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-groupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectGroupConfiguration
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration, BaseFunction>? GroupConfiguration { get; set; }
            /// <summary>
            /// EntityIdPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-entityidprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityIdPrefix { get; set; }
        }

        public class OpenIdConnectGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveGroupEntityType, IHaveGroupClaim
        {
            /// <summary>
            /// GroupEntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectgroupconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectgroupconfiguration-groupentitytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupEntityType { get; set; }
            /// <summary>
            /// GroupClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectgroupconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectgroupconfiguration-groupclaim
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupClaim { get; set; }
        }

        public class OpenIdConnectIdentityTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfClientIds, IHavePrincipalIdClaim
        {
            /// <summary>
            /// ClientIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration-clientids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ClientIds { get; set; }
            /// <summary>
            /// PrincipalIdClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration-principalidclaim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalIdClaim { get; set; }
        }

        public class OpenIdConnectTokenSelection : Humidifier.Base.BaseSubResource, IHaveVerifiedPermissionsIdentitySourceTypesOpenIdConnectAccessTokenConfigurationAccessTokenOnly, IHaveVerifiedPermissionsIdentitySourceTypesOpenIdConnectIdentityTokenConfigurationIdentityTokenOnly
        {
            /// <summary>
            /// AccessTokenOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnecttokenselection.html#cfn-verifiedpermissions-identitysource-openidconnecttokenselection-accesstokenonly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectAccessTokenConfiguration
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration, BaseFunction>? AccessTokenOnly { get; set; }
            /// <summary>
            /// IdentityTokenOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnecttokenselection.html#cfn-verifiedpermissions-identitysource-openidconnecttokenselection-identitytokenonly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectIdentityTokenConfiguration
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration, BaseFunction>? IdentityTokenOnly { get; set; }
        }
    }
}