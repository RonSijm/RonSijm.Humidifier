namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using WorkforceTypes;

    public class Workforce : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType, IHaveSageMakerWorkforceTypesOidcConfigOidcConfig, IHaveSageMakerWorkforceTypesCognitoConfigCognitoConfig, IHaveSageMakerWorkforceTypesWorkforceVpcConfigRequestWorkforceVpcConfig, IHaveWorkforceName, IHaveSageMakerWorkforceTypesSourceIpConfigSourceIpConfig
    {
        public class Attributes
        {
            public static string SubDomain =  "SubDomain" ;
            public static string WorkforceArn =  "WorkforceArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Workforce; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// OidcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-oidcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OidcConfig
        /// </summary>
        public Union<Humidifier.SageMaker.WorkforceTypes.OidcConfig, BaseFunction>? OidcConfig { get; set; }
        /// <summary>
        /// CognitoConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-cognitoconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CognitoConfig
        /// </summary>
        public Union<Humidifier.SageMaker.WorkforceTypes.CognitoConfig, BaseFunction>? CognitoConfig { get; set; }
        /// <summary>
        /// WorkforceVpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-workforcevpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkforceVpcConfigRequest
        /// </summary>
        public Union<Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest, BaseFunction>? WorkforceVpcConfig { get; set; }
        public Union<string, BaseFunction>? WorkforceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SourceIpConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-sourceipconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SourceIpConfig
        /// </summary>
        public Union<Humidifier.SageMaker.WorkforceTypes.SourceIpConfig, BaseFunction>? SourceIpConfig { get; set; }
    }

    namespace WorkforceTypes
    {
        public class CognitoConfig : Humidifier.Base.BaseSubResource, IHaveUserPool, IHaveClientId
        {
            /// <summary>
            /// UserPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-cognitoconfig.html#cfn-sagemaker-workforce-cognitoconfig-userpool
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPool { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-cognitoconfig.html#cfn-sagemaker-workforce-cognitoconfig-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
        }

        public class OidcConfig : Humidifier.Base.BaseSubResource, IHaveJwksUri, IHaveLogoutEndpoint, IHaveTokenEndpoint, IHaveScope, IHaveIssuer, IHaveClientSecret, IHaveUserInfoEndpoint, IHaveClientId, IHaveAuthorizationEndpoint, IHaveStringDictionaryOfAuthenticationRequestExtraParams
        {
            /// <summary>
            /// JwksUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-jwksuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JwksUri { get; set; }
            /// <summary>
            /// LogoutEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-logoutendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogoutEndpoint { get; set; }
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// UserInfoEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-userinfoendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserInfoEndpoint { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
            /// <summary>
            /// AuthenticationRequestExtraParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-authenticationrequestextraparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AuthenticationRequestExtraParams { get; set; }
        }

        public class SourceIpConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfCidrs
        {
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-sourceipconfig.html#cfn-sagemaker-workforce-sourceipconfig-cidrs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cidrs { get; set; }
        }

        public class WorkforceVpcConfigRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveVpcId, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-workforcevpcconfigrequest.html#cfn-sagemaker-workforce-workforcevpcconfigrequest-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-workforcevpcconfigrequest.html#cfn-sagemaker-workforce-workforcevpcconfigrequest-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-workforcevpcconfigrequest.html#cfn-sagemaker-workforce-workforcevpcconfigrequest-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}