namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using PrivateConnectionTypes;

    public class PrivateConnection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCertificate
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
        public dynamic PrivateConnectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-privateconnection.html#cfn-securityagent-privateconnection-mode
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Mode
        /// </summary>
        public Humidifier.SecurityAgent.PrivateConnectionTypes.Mode Mode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-privateconnection.html#cfn-securityagent-privateconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// Certificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-privateconnection.html#cfn-securityagent-privateconnection-certificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Certificate { get; set; }
    }

    namespace PrivateConnectionTypes
    {
        public class Mode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServiceManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-mode.html#cfn-securityagent-privateconnection-mode-servicemanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceManaged
            /// </summary>
            public Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged ServiceManaged { get; set; }
            /// <summary>
            /// SelfManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-mode.html#cfn-securityagent-privateconnection-mode-selfmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelfManaged
            /// </summary>
            public Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged SelfManaged { get; set; }
        }

        public class SelfManaged : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceConfigurationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-selfmanaged.html#cfn-securityagent-privateconnection-selfmanaged-resourceconfigurationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceConfigurationId { get; set; }
        }

        public class ServiceManaged : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveVpcId, IHaveIpAddressType
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpAddressType { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-portranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PortRanges { get; set; }
            /// <summary>
            /// DnsResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-dnsresolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsResolution { get; set; }
            /// <summary>
            /// Ipv4AddressesPerEni
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-ipv4addressespereni
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Ipv4AddressesPerEni { get; set; }
            /// <summary>
            /// HostAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-hostaddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostAddress { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-privateconnection-servicemanaged.html#cfn-securityagent-privateconnection-servicemanaged-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}