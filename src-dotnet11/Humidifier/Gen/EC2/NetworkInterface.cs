namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using NetworkInterfaceTypes;

    public class NetworkInterface : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHavePrivateIpAddress, IHaveListOfEC2NetworkInterfaceTypesPrivateIpAddressSpecificationPrivateIpAddresses, IHaveSecondaryPrivateIpAddressCount_Integer, IHavePublicIpDnsHostnameTypeSpecification, IHaveIpv6PrefixCount_Integer, IHaveListOfEC2NetworkInterfaceTypesIpv4PrefixSpecificationIpv4Prefixes, IHaveIpv4PrefixCount_Integer, IHaveStringListOfGroupSet, IHaveListOfEC2NetworkInterfaceTypesInstanceIpv6AddressIpv6Addresses, IHaveListOfEC2NetworkInterfaceTypesIpv6PrefixSpecificationIpv6Prefixes, IHaveSubnetId, IHaveSourceDestCheck_Boolean, IHaveInterfaceType, IHaveIpv6AddressCount_Integer, IHaveEC2NetworkInterfaceTypesConnectionTrackingSpecificationConnectionTrackingSpecification
    {
        public class Attributes
        {
            public static string PrimaryIpv6Address =  "PrimaryIpv6Address" ;
            public static string SecondaryPrivateIpAddresses =  "SecondaryPrivateIpAddresses" ;
            public static string VpcId =  "VpcId" ;
            public static string PrimaryPrivateIpAddress =  "PrimaryPrivateIpAddress" ;
            public static string Id =  "Id" ;
            public static string PublicIpDnsNameOptions =  "PublicIpDnsNameOptions" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInterface; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PrivateIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-privateipaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
        /// <summary>
        /// PrivateIpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-privateipaddresses
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: PrivateIpAddressSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification>, IReadOnlyList<Union<Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification, BaseFunction>>, BaseFunction>? PrivateIpAddresses { get; set; }
        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-secondaryprivateipaddresscount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
        /// <summary>
        /// PublicIpDnsHostnameTypeSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-publicipdnshostnametypespecification
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PublicIpDnsHostnameTypeSpecification { get; set; }
        /// <summary>
        /// Ipv6PrefixCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6prefixcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6PrefixCount { get; set; }
        /// <summary>
        /// Ipv4Prefixes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv4prefixes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Ipv4PrefixSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification>, IReadOnlyList<Union<Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification, BaseFunction>>, BaseFunction>? Ipv4Prefixes { get; set; }
        /// <summary>
        /// Ipv4PrefixCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv4prefixcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv4PrefixCount { get; set; }
        /// <summary>
        /// GroupSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-groupset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GroupSet { get; set; }
        /// <summary>
        /// Ipv6Addresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6addresses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InstanceIpv6Address
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.NetworkInterfaceTypes.InstanceIpv6Address>, IReadOnlyList<Union<Humidifier.EC2.NetworkInterfaceTypes.InstanceIpv6Address, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
        /// <summary>
        /// Ipv6Prefixes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6prefixes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Ipv6PrefixSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification>, IReadOnlyList<Union<Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification, BaseFunction>>, BaseFunction>? Ipv6Prefixes { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// SourceDestCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-sourcedestcheck
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SourceDestCheck { get; set; }
        /// <summary>
        /// InterfaceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-interfacetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InterfaceType { get; set; }
        /// <summary>
        /// Ipv6AddressCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6addresscount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ConnectionTrackingSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-connectiontrackingspecification
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ConnectionTrackingSpecification
        /// </summary>
        public Union<Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification, BaseFunction>? ConnectionTrackingSpecification { get; set; }
    }

    namespace NetworkInterfaceTypes
    {
        public class ConnectionTrackingSpecification : Humidifier.Base.BaseSubResource, IHaveUdpTimeout_Integer, IHaveTcpEstablishedTimeout_Integer, IHaveUdpStreamTimeout_Integer
        {
            /// <summary>
            /// UdpTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-connectiontrackingspecification.html#cfn-ec2-networkinterface-connectiontrackingspecification-udptimeout
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UdpTimeout { get; set; }
            /// <summary>
            /// TcpEstablishedTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-connectiontrackingspecification.html#cfn-ec2-networkinterface-connectiontrackingspecification-tcpestablishedtimeout
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TcpEstablishedTimeout { get; set; }
            /// <summary>
            /// UdpStreamTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-connectiontrackingspecification.html#cfn-ec2-networkinterface-connectiontrackingspecification-udpstreamtimeout
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UdpStreamTimeout { get; set; }
        }

        public class InstanceIpv6Address : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-instanceipv6address.html#cfn-ec2-networkinterface-instanceipv6address-ipv6address
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class Ipv4PrefixSpecification : Humidifier.Base.BaseSubResource, IHaveIpv4Prefix
        {
            /// <summary>
            /// Ipv4Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-ipv4prefixspecification.html#cfn-ec2-networkinterface-ipv4prefixspecification-ipv4prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv4Prefix { get; set; }
        }

        public class Ipv6PrefixSpecification : Humidifier.Base.BaseSubResource, IHaveIpv6Prefix
        {
            /// <summary>
            /// Ipv6Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-ipv6prefixspecification.html#cfn-ec2-networkinterface-ipv6prefixspecification-ipv6prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Prefix { get; set; }
        }

        public class PrivateIpAddressSpecification : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary_Boolean
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-privateipaddressspecification.html#cfn-ec2-networkinterface-privateipaddressspecification-privateipaddress
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-privateipaddressspecification.html#cfn-ec2-networkinterface-privateipaddressspecification-primary
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Primary { get; set; }
        }

        public class PublicIpDnsNameOptions : Humidifier.Base.BaseSubResource, IHaveDnsHostnameType, IHavePublicIpv4DnsName, IHavePublicDualStackDnsName, IHavePublicIpv6DnsName
        {
            /// <summary>
            /// DnsHostnameType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-publicipdnsnameoptions.html#cfn-ec2-networkinterface-publicipdnsnameoptions-dnshostnametype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsHostnameType { get; set; }
            /// <summary>
            /// PublicIpv4DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-publicipdnsnameoptions.html#cfn-ec2-networkinterface-publicipdnsnameoptions-publicipv4dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicIpv4DnsName { get; set; }
            /// <summary>
            /// PublicDualStackDnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-publicipdnsnameoptions.html#cfn-ec2-networkinterface-publicipdnsnameoptions-publicdualstackdnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicDualStackDnsName { get; set; }
            /// <summary>
            /// PublicIpv6DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-publicipdnsnameoptions.html#cfn-ec2-networkinterface-publicipdnsnameoptions-publicipv6dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicIpv6DnsName { get; set; }
        }
    }
}