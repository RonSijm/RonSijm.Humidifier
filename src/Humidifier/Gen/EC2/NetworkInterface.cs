namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using NetworkInterfaceTypes;

    public class NetworkInterface : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveSubnetId, IHavePrivateIpAddress, IHaveIpv6AddressCount, IHaveSecondaryPrivateIpAddressCount, IHaveSourceDestCheck, IHaveIpv6PrefixCount, IHaveIpv4PrefixCount, IHaveGroupSet, IHaveInterfaceType
    {
        public class Attributes
        {
            public static string PrimaryIpv6Address =  "PrimaryIpv6Address" ;
            public static string SecondaryPrivateIpAddresses =  "SecondaryPrivateIpAddresses" ;
            public static string VpcId =  "VpcId" ;
            public static string PrimaryPrivateIpAddress =  "PrimaryPrivateIpAddress" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInterface; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// PrivateIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-privateipaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrivateIpAddress { get; set; }
        /// <summary>
        /// PrivateIpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-privateipaddresses
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: PrivateIpAddressSpecification
        /// </summary>
        public List<Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification> PrivateIpAddresses { get; set; }
        /// <summary>
        /// SecondaryPrivateIpAddressCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-secondaryprivateipaddresscount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SecondaryPrivateIpAddressCount { get; set; }
        /// <summary>
        /// Ipv6PrefixCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6prefixcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Ipv6PrefixCount { get; set; }
        /// <summary>
        /// Ipv4Prefixes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv4prefixes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Ipv4PrefixSpecification
        /// </summary>
        public List<Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification> Ipv4Prefixes { get; set; }
        /// <summary>
        /// Ipv4PrefixCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv4prefixcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Ipv4PrefixCount { get; set; }
        /// <summary>
        /// GroupSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-groupset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic GroupSet { get; set; }
        /// <summary>
        /// Ipv6Addresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6addresses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InstanceIpv6Address
        /// </summary>
        public List<Humidifier.EC2.NetworkInterfaceTypes.InstanceIpv6Address> Ipv6Addresses { get; set; }
        /// <summary>
        /// Ipv6Prefixes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6prefixes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Ipv6PrefixSpecification
        /// </summary>
        public List<Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification> Ipv6Prefixes { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubnetId { get; set; }
        /// <summary>
        /// SourceDestCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-sourcedestcheck
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SourceDestCheck { get; set; }
        /// <summary>
        /// InterfaceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-interfacetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InterfaceType { get; set; }
        /// <summary>
        /// Ipv6AddressCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-ipv6addresscount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Ipv6AddressCount { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// ConnectionTrackingSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterface.html#cfn-ec2-networkinterface-connectiontrackingspecification
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ConnectionTrackingSpecification
        /// </summary>
        public Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification ConnectionTrackingSpecification { get; set; }
    }

    namespace NetworkInterfaceTypes
    {
        public class ConnectionTrackingSpecification : Humidifier.Base.BaseSubResource, IHaveUdpTimeout, IHaveTcpEstablishedTimeout, IHaveUdpStreamTimeout
        {
            /// <summary>
            /// UdpTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-connectiontrackingspecification.html#cfn-ec2-networkinterface-connectiontrackingspecification-udptimeout
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UdpTimeout { get; set; }
            /// <summary>
            /// TcpEstablishedTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-connectiontrackingspecification.html#cfn-ec2-networkinterface-connectiontrackingspecification-tcpestablishedtimeout
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TcpEstablishedTimeout { get; set; }
            /// <summary>
            /// UdpStreamTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-connectiontrackingspecification.html#cfn-ec2-networkinterface-connectiontrackingspecification-udpstreamtimeout
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UdpStreamTimeout { get; set; }
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
            public dynamic Ipv6Address { get; set; }
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
            public dynamic Ipv4Prefix { get; set; }
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
            public dynamic Ipv6Prefix { get; set; }
        }

        public class PrivateIpAddressSpecification : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-privateipaddressspecification.html#cfn-ec2-networkinterface-privateipaddressspecification-privateipaddress
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinterface-privateipaddressspecification.html#cfn-ec2-networkinterface-privateipaddressspecification-primary
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
        }
    }
}