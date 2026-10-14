namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using PrivateConnectionTypes;

    public class PrivateConnection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveCertificate
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
        public Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration ConnectionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-privateconnection.html#cfn-devopsagent-privateconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Certificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-privateconnection.html#cfn-devopsagent-privateconnection-certificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Certificate { get; set; }
    }

    namespace PrivateConnectionTypes
    {
        public class ConnectionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelfManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-connectionconfiguration.html#cfn-devopsagent-privateconnection-connectionconfiguration-selfmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelfManagedMode
            /// </summary>
            public Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode SelfManaged { get; set; }
            /// <summary>
            /// ServiceManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-connectionconfiguration.html#cfn-devopsagent-privateconnection-connectionconfiguration-servicemanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceManagedMode
            /// </summary>
            public Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode ServiceManaged { get; set; }
        }

        public class SelfManagedMode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceConfigurationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-selfmanagedmode.html#cfn-devopsagent-privateconnection-selfmanagedmode-resourceconfigurationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceConfigurationId { get; set; }
        }

        public class ServiceManagedMode : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveVpcId, IHaveIpAddressType
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpAddressType { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-portranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PortRanges { get; set; }
            /// <summary>
            /// DnsResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-dnsresolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsResolution { get; set; }
            /// <summary>
            /// Ipv4AddressesPerEni
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-ipv4addressespereni
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Ipv4AddressesPerEni { get; set; }
            /// <summary>
            /// HostAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-hostaddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostAddress { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-privateconnection-servicemanagedmode.html#cfn-devopsagent-privateconnection-servicemanagedmode-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}