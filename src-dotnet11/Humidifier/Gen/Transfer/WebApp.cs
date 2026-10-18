namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;
    using WebAppTypes;

    public class WebApp : Humidifier.Base.BaseResource, IHaveTags, IHaveTransferWebAppTypesWebAppCustomizationWebAppCustomization, IHaveTransferWebAppTypesIdentityProviderDetailsIdentityProviderDetails, IHaveTransferWebAppTypesWebAppUnitsWebAppUnits, IHaveTransferWebAppTypesEndpointDetailsEndpointDetails, IHaveWebAppEndpointPolicy, IHaveAccessEndpoint
    {
        public class Attributes
        {
            public static string WebAppId =  "WebAppId" ;
            public static string Arn =  "Arn" ;
            public static string VpcEndpointId =  "VpcEndpointId" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.WebApp; }
        /// <summary>
        /// WebAppCustomization
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-webappcustomization
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebAppCustomization
        /// </summary>
        public Union<Humidifier.Transfer.WebAppTypes.WebAppCustomization, BaseFunction>? WebAppCustomization { get; set; }

        /// <summary>
        /// IdentityProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-identityproviderdetails
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdentityProviderDetails
        /// </summary>
        [Required]
        public Union<Humidifier.Transfer.WebAppTypes.IdentityProviderDetails, BaseFunction>? IdentityProviderDetails { get; set; }
        /// <summary>
        /// WebAppUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-webappunits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebAppUnits
        /// </summary>
        public Union<Humidifier.Transfer.WebAppTypes.WebAppUnits, BaseFunction>? WebAppUnits { get; set; }
        /// <summary>
        /// EndpointDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-endpointdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EndpointDetails
        /// </summary>
        public Union<Humidifier.Transfer.WebAppTypes.EndpointDetails, BaseFunction>? EndpointDetails { get; set; }
        /// <summary>
        /// WebAppEndpointPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-webappendpointpolicy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WebAppEndpointPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AccessEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-webapp.html#cfn-transfer-webapp-accessendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessEndpoint { get; set; }
    }

    namespace WebAppTypes
    {
        public class EndpointDetails : Humidifier.Base.BaseSubResource, IHaveTransferWebAppTypesVpcVpc
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-endpointdetails.html#cfn-transfer-webapp-endpointdetails-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Vpc
            /// </summary>
            public Union<Humidifier.Transfer.WebAppTypes.Vpc, BaseFunction>? Vpc { get; set; }
        }

        public class IdentityProviderDetails : Humidifier.Base.BaseSubResource, IHaveRole, IHaveApplicationArn, IHaveInstanceArn
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-identityproviderdetails.html#cfn-transfer-webapp-identityproviderdetails-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-identityproviderdetails.html#cfn-transfer-webapp-identityproviderdetails-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationArn { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-identityproviderdetails.html#cfn-transfer-webapp-identityproviderdetails-instancearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceArn { get; set; }
        }

        public class Vpc : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveVpcId, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-vpc.html#cfn-transfer-webapp-vpc-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-vpc.html#cfn-transfer-webapp-vpc-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-vpc.html#cfn-transfer-webapp-vpc-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-vpc.html#cfn-transfer-webapp-vpc-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class WebAppCustomization : Humidifier.Base.BaseSubResource, IHaveFaviconFile, IHaveTitle, IHaveLogoFile
        {
            /// <summary>
            /// FaviconFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappcustomization.html#cfn-transfer-webapp-webappcustomization-faviconfile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FaviconFile { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappcustomization.html#cfn-transfer-webapp-webappcustomization-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// LogoFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappcustomization.html#cfn-transfer-webapp-webappcustomization-logofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogoFile { get; set; }
        }

        public class WebAppUnits : Humidifier.Base.BaseSubResource, IHaveProvisioned_Integer
        {
            /// <summary>
            /// Provisioned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-webapp-webappunits.html#cfn-transfer-webapp-webappunits-provisioned
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Provisioned { get; set; }
        }
    }
}