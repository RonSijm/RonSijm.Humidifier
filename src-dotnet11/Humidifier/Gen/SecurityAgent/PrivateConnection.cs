namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using PrivateConnectionTypes;

    public class PrivateConnection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePrivateConnectionName, IHaveSecurityAgentPrivateConnectionTypesModeMode, IHaveCertificate
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string CertificateExpiryTime =  "CertificateExpiryTime" ;
            public static string VpcId =  "VpcId" ;
            public static string ResourceConfigurationId =  "ResourceConfigurationId" ;
            public static string DnsResolution =  "DnsResolution" ;
            public static string HostAddress =  "HostAddress" ;
            public static string Arn =  "Arn" ;
            public static string ResourceGatewayId =  "ResourceGatewayId" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.PrivateConnection; }
        public Union<string, BaseFunction>? PrivateConnectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-privateconnection.html#cfn-securityagent-privateconnection-mode
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Mode
        /// </summary>
        public Union<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-privateconnection.html#cfn-securityagent-privateconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Certificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-privateconnection.html#cfn-securityagent-privateconnection-certificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Certificate { get; set; }
    }

    namespace PrivateConnectionTypes
    {
        public class Mode : Humidifier.Base.BaseSubResource, IHaveSecurityAgentPrivateConnectionTypesServiceManagedServiceManaged, IHaveSecurityAgentPrivateConnectionTypesSelfManagedSelfManaged
        {
            /// <summary>
            /// ServiceManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-mode.html#cfn-securityagent-privateconnection-mode-servicemanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceManaged
            /// </summary>
            public Union<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged, BaseFunction>? ServiceManaged { get; set; }
            /// <summary>
            /// SelfManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-mode.html#cfn-securityagent-privateconnection-mode-selfmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelfManaged
            /// </summary>
            public Union<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged, BaseFunction>? SelfManaged { get; set; }
        }

        public class SelfManaged : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationId
        {
            /// <summary>
            /// ResourceConfigurationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-selfmanaged.html#cfn-securityagent-privateconnection-selfmanaged-resourceconfigurationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationId { get; set; }
        }

        public class ServiceManaged : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveVpcId, IHaveStringListOfPortRanges, IHaveDnsResolution, IHaveIpv4AddressesPerEni_Integer, IHaveHostAddress, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-portranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
            /// <summary>
            /// DnsResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-dnsresolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsResolution { get; set; }
            /// <summary>
            /// Ipv4AddressesPerEni
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-ipv4addressespereni
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv4AddressesPerEni { get; set; }
            /// <summary>
            /// HostAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-hostaddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostAddress { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}