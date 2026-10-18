namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using DomainNameV2Types;

    public class DomainNameV2 : Humidifier.Base.BaseResource, IHaveTags, IHavePolicy_Json, IHaveRoutingMode, IHaveDomainName, IHaveSecurityPolicy, IHaveApiGatewayDomainNameV2TypesEndpointConfigurationEndpointConfiguration, IHaveCertificateArn, IHaveEndpointAccessMode
    {
        public class Attributes
        {
            public static string DomainNameId =  "DomainNameId" ;
            public static string DomainNameArn =  "DomainNameArn" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.DomainNameV2; }
        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-policy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Policy { get; set; }
        /// <summary>
        /// RoutingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-routingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingMode { get; set; }
        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-domainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// SecurityPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-securitypolicy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityPolicy { get; set; }
        /// <summary>
        /// EndpointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-endpointconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EndpointConfiguration
        /// </summary>
        public Union<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration, BaseFunction>? EndpointConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-certificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateArn { get; set; }
        /// <summary>
        /// EndpointAccessMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainnamev2.html#cfn-apigateway-domainnamev2-endpointaccessmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointAccessMode { get; set; }
    }

    namespace DomainNameV2Types
    {
        public class EndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveStringListOfTypes
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainnamev2-endpointconfiguration.html#cfn-apigateway-domainnamev2-endpointconfiguration-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainnamev2-endpointconfiguration.html#cfn-apigateway-domainnamev2-endpointconfiguration-types
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
        }
    }
}