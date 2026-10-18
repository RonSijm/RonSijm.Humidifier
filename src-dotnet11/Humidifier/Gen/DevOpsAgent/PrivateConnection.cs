namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using PrivateConnectionTypes;

    public class PrivateConnection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDevOpsAgentPrivateConnectionTypesConnectionConfigurationConnectionConfiguration, IHaveName, IHaveCertificate
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CertificateExpiryTime =  "CertificateExpiryTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsAgent.PrivateConnection; }

        /// <summary>
        /// ConnectionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-privateconnection.html#cfn-devopsagent-privateconnection-connectionconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ConnectionConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration, BaseFunction>? ConnectionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-privateconnection.html#cfn-devopsagent-privateconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Certificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-privateconnection.html#cfn-devopsagent-privateconnection-certificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Certificate { get; set; }
    }

    namespace PrivateConnectionTypes
    {
        public class ConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentPrivateConnectionTypesSelfManagedModeSelfManaged, IHaveDevOpsAgentPrivateConnectionTypesServiceManagedModeServiceManaged
        {
            /// <summary>
            /// SelfManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-connectionconfiguration.html#cfn-devopsagent-privateconnection-connectionconfiguration-selfmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelfManagedMode
            /// </summary>
            public Union<Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode, BaseFunction>? SelfManaged { get; set; }
            /// <summary>
            /// ServiceManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-connectionconfiguration.html#cfn-devopsagent-privateconnection-connectionconfiguration-servicemanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceManagedMode
            /// </summary>
            public Union<Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode, BaseFunction>? ServiceManaged { get; set; }
        }

        public class SelfManagedMode : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationId
        {
            /// <summary>
            /// ResourceConfigurationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-selfmanagedmode.html#cfn-devopsagent-privateconnection-selfmanagedmode-resourceconfigurationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationId { get; set; }
        }

        public class ServiceManagedMode : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveVpcId, IHaveStringListOfPortRanges, IHaveDnsResolution, IHaveIpv4AddressesPerEni_Integer, IHaveHostAddress, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-portranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
            /// <summary>
            /// DnsResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-dnsresolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsResolution { get; set; }
            /// <summary>
            /// Ipv4AddressesPerEni
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-ipv4addressespereni
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv4AddressesPerEni { get; set; }
            /// <summary>
            /// HostAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-hostaddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostAddress { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}