namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using WorkforceTypes;

    public class Workforce : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType
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
        public dynamic IpAddressType { get; set; }
        /// <summary>
        /// OidcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-oidcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OidcConfig
        /// </summary>
        public Humidifier.SageMaker.WorkforceTypes.OidcConfig OidcConfig { get; set; }
        /// <summary>
        /// CognitoConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-cognitoconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CognitoConfig
        /// </summary>
        public Humidifier.SageMaker.WorkforceTypes.CognitoConfig CognitoConfig { get; set; }
        /// <summary>
        /// WorkforceVpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-workforcevpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkforceVpcConfigRequest
        /// </summary>
        public Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest WorkforceVpcConfig { get; set; }
        public dynamic WorkforceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// SourceIpConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workforce.html#cfn-sagemaker-workforce-sourceipconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SourceIpConfig
        /// </summary>
        public Humidifier.SageMaker.WorkforceTypes.SourceIpConfig SourceIpConfig { get; set; }
    }

    namespace WorkforceTypes
    {
        public class CognitoConfig : Humidifier.Base.BaseSubResource, IHaveClientId
        {
            /// <summary>
            /// UserPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-cognitoconfig.html#cfn-sagemaker-workforce-cognitoconfig-userpool
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserPool { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-cognitoconfig.html#cfn-sagemaker-workforce-cognitoconfig-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
        }

        public class OidcConfig : Humidifier.Base.BaseSubResource, IHaveScope, IHaveClientId, IHaveClientSecret, IHaveIssuer, IHaveAuthorizationEndpoint, IHaveTokenEndpoint, IHaveUserInfoEndpoint
        {
            /// <summary>
            /// JwksUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-jwksuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JwksUri { get; set; }
            /// <summary>
            /// LogoutEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-logoutendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogoutEndpoint { get; set; }
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpoint { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// UserInfoEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-userinfoendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserInfoEndpoint { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationEndpoint { get; set; }
            /// <summary>
            /// AuthenticationRequestExtraParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-oidcconfig.html#cfn-sagemaker-workforce-oidcconfig-authenticationrequestextraparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> AuthenticationRequestExtraParams { get; set; }
        }

        public class SourceIpConfig : Humidifier.Base.BaseSubResource, IHaveCidrs
        {
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-sourceipconfig.html#cfn-sagemaker-workforce-sourceipconfig-cidrs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Cidrs { get; set; }
        }

        public class WorkforceVpcConfigRequest : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveVpcId, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-workforcevpcconfigrequest.html#cfn-sagemaker-workforce-workforcevpcconfigrequest-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-workforcevpcconfigrequest.html#cfn-sagemaker-workforce-workforcevpcconfigrequest-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workforce-workforcevpcconfigrequest.html#cfn-sagemaker-workforce-workforcevpcconfigrequest-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}