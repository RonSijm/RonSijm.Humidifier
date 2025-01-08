namespace Humidifier.VerifiedPermissions
{
    using System.Collections.Generic;
    using IdentitySourceTypes;

    public class IdentitySource : Humidifier.Base.BaseResource, IHavePolicyStoreId
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
        public dynamic PrincipalEntityType { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-identitysource.html#cfn-verifiedpermissions-identitysource-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdentitySourceConfiguration
        /// </summary>
        [Required]
        public Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration Configuration { get; set; }

        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-identitysource.html#cfn-verifiedpermissions-identitysource-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PolicyStoreId { get; set; }
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
            public dynamic GroupEntityType { get; set; }
        }

        public class CognitoUserPoolConfiguration : Humidifier.Base.BaseSubResource, IHaveUserPoolArn, IHaveClientIds
        {
            /// <summary>
            /// UserPoolArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitouserpoolconfiguration.html#cfn-verifiedpermissions-identitysource-cognitouserpoolconfiguration-userpoolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserPoolArn { get; set; }
            /// <summary>
            /// GroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitouserpoolconfiguration.html#cfn-verifiedpermissions-identitysource-cognitouserpoolconfiguration-groupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoGroupConfiguration
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration GroupConfiguration { get; set; }
            /// <summary>
            /// ClientIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-cognitouserpoolconfiguration.html#cfn-verifiedpermissions-identitysource-cognitouserpoolconfiguration-clientids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ClientIds { get; set; }
        }

        public class IdentitySourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CognitoUserPoolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-identitysourceconfiguration.html#cfn-verifiedpermissions-identitysource-identitysourceconfiguration-cognitouserpoolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoUserPoolConfiguration
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration CognitoUserPoolConfiguration { get; set; }
            /// <summary>
            /// OpenIdConnectConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-identitysourceconfiguration.html#cfn-verifiedpermissions-identitysource-identitysourceconfiguration-openidconnectconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectConfiguration
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectConfiguration OpenIdConnectConfiguration { get; set; }
        }

        public class OpenIdConnectAccessTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveAudiences, IHavePrincipalIdClaim
        {
            /// <summary>
            /// Audiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration-audiences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Audiences { get; set; }
            /// <summary>
            /// PrincipalIdClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectaccesstokenconfiguration-principalidclaim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrincipalIdClaim { get; set; }
        }

        public class OpenIdConnectConfiguration : Humidifier.Base.BaseSubResource, IHaveIssuer
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// TokenSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-tokenselection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OpenIdConnectTokenSelection
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectTokenSelection TokenSelection { get; set; }
            /// <summary>
            /// GroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-groupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectGroupConfiguration
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration GroupConfiguration { get; set; }
            /// <summary>
            /// EntityIdPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-entityidprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityIdPrefix { get; set; }
        }

        public class OpenIdConnectGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveGroupEntityType
        {
            /// <summary>
            /// GroupEntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectgroupconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectgroupconfiguration-groupentitytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupEntityType { get; set; }
            /// <summary>
            /// GroupClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectgroupconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectgroupconfiguration-groupclaim
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupClaim { get; set; }
        }

        public class OpenIdConnectIdentityTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveClientIds, IHavePrincipalIdClaim
        {
            /// <summary>
            /// ClientIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration-clientids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ClientIds { get; set; }
            /// <summary>
            /// PrincipalIdClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectidentitytokenconfiguration-principalidclaim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrincipalIdClaim { get; set; }
        }

        public class OpenIdConnectTokenSelection : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccessTokenOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnecttokenselection.html#cfn-verifiedpermissions-identitysource-openidconnecttokenselection-accesstokenonly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectAccessTokenConfiguration
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration AccessTokenOnly { get; set; }
            /// <summary>
            /// IdentityTokenOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnecttokenselection.html#cfn-verifiedpermissions-identitysource-openidconnecttokenselection-identitytokenonly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectIdentityTokenConfiguration
            /// </summary>
            public Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration IdentityTokenOnly { get; set; }
        }
    }
}