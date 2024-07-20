namespace Humidifier.VerifiedPermissions
{
    using System.Collections.Generic;
    using IdentitySourceTypes;

    public class IdentitySource : Humidifier.Resource
    {
        public class Attributes
        {
            public static string IdentitySourceId =  "IdentitySourceId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::VerifiedPermissions::IdentitySource";
            }
        }

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
        public IdentitySourceConfiguration Configuration { get; set; }
        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-identitysource.html#cfn-verifiedpermissions-identitysource-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyStoreId { get; set; }
    }

    namespace IdentitySourceTypes
    {
        public class CognitoGroupConfiguration
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

        public class CognitoUserPoolConfiguration
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
            public CognitoGroupConfiguration GroupConfiguration { get; set; }
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

        public class IdentitySourceConfiguration
        {
            /// <summary>
            /// CognitoUserPoolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-identitysourceconfiguration.html#cfn-verifiedpermissions-identitysource-identitysourceconfiguration-cognitouserpoolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoUserPoolConfiguration
            /// </summary>
            public CognitoUserPoolConfiguration CognitoUserPoolConfiguration { get; set; }
            /// <summary>
            /// OpenIdConnectConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-identitysourceconfiguration.html#cfn-verifiedpermissions-identitysource-identitysourceconfiguration-openidconnectconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectConfiguration
            /// </summary>
            public OpenIdConnectConfiguration OpenIdConnectConfiguration { get; set; }
        }

        public class OpenIdConnectAccessTokenConfiguration
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

        public class OpenIdConnectConfiguration
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
            public OpenIdConnectTokenSelection TokenSelection { get; set; }
            /// <summary>
            /// GroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-groupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectGroupConfiguration
            /// </summary>
            public OpenIdConnectGroupConfiguration GroupConfiguration { get; set; }
            /// <summary>
            /// EntityIdPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnectconfiguration.html#cfn-verifiedpermissions-identitysource-openidconnectconfiguration-entityidprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityIdPrefix { get; set; }
        }

        public class OpenIdConnectGroupConfiguration
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

        public class OpenIdConnectIdentityTokenConfiguration
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

        public class OpenIdConnectTokenSelection
        {
            /// <summary>
            /// AccessTokenOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnecttokenselection.html#cfn-verifiedpermissions-identitysource-openidconnecttokenselection-accesstokenonly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectAccessTokenConfiguration
            /// </summary>
            public OpenIdConnectAccessTokenConfiguration AccessTokenOnly { get; set; }
            /// <summary>
            /// IdentityTokenOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-identitysource-openidconnecttokenselection.html#cfn-verifiedpermissions-identitysource-openidconnecttokenselection-identitytokenonly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIdConnectIdentityTokenConfiguration
            /// </summary>
            public OpenIdConnectIdentityTokenConfiguration IdentityTokenOnly { get; set; }
        }
    }
}