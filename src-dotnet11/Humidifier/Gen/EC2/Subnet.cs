namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SubnetTypes;

    public class Subnet : Humidifier.Base.BaseResource, IHaveTags, IHaveMapPublicIpOnLaunch_Boolean, IHaveEnableDns64_Boolean, IHaveAvailabilityZoneId, IHaveOutpostArn, IHaveAvailabilityZone, IHaveCidrBlock, IHaveEnableLniAtDeviceIndex_Integer, IHaveIpv6NetmaskLength_Integer, IHaveIpv6IpamPoolId, IHaveAssignIpv6AddressOnCreation_Boolean, IHaveVpcId, IHaveIpv4NetmaskLength_Integer, IHaveEC2SubnetTypesPrivateDnsNameOptionsOnLaunchPrivateDnsNameOptionsOnLaunch, IHaveIpv4IpamPoolId, IHaveIpv6Native_Boolean, IHaveIpv6CidrBlock
    {
        public class Attributes
        {
            public static string VpcId =  "VpcId" ;
            public static string NetworkAclAssociationId =  "NetworkAclAssociationId" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string OutpostArn =  "OutpostArn" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string CidrBlock =  "CidrBlock" ;
            public static string SubnetId =  "SubnetId" ;
            public static string BlockPublicAccessStates =  "BlockPublicAccessStates" ;
            public static string Ipv6CidrBlocks =  "Ipv6CidrBlocks" ;
        }

        public override string AWSTypeName { get => AWS.EC2.Subnet; }
        /// <summary>
        /// MapPublicIpOnLaunch
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-mappubliciponlaunch
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? MapPublicIpOnLaunch { get; set; }
        /// <summary>
        /// EnableDns64
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-enabledns64
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableDns64 { get; set; }
        /// <summary>
        /// AvailabilityZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-availabilityzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
        /// <summary>
        /// OutpostArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-outpostarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutpostArn { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CidrBlock { get; set; }
        /// <summary>
        /// EnableLniAtDeviceIndex
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-enablelniatdeviceindex
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EnableLniAtDeviceIndex { get; set; }
        /// <summary>
        /// Ipv6NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv6netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6NetmaskLength { get; set; }
        /// <summary>
        /// Ipv6IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv6ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6IpamPoolId { get; set; }
        /// <summary>
        /// AssignIpv6AddressOnCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-assignipv6addressoncreation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AssignIpv6AddressOnCreation { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// Ipv4NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv4netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv4NetmaskLength { get; set; }
        /// <summary>
        /// PrivateDnsNameOptionsOnLaunch
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-privatednsnameoptionsonlaunch
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PrivateDnsNameOptionsOnLaunch
        /// </summary>
        public Union<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch, BaseFunction>? PrivateDnsNameOptionsOnLaunch { get; set; }
        /// <summary>
        /// Ipv4IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv4ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv4IpamPoolId { get; set; }
        /// <summary>
        /// Ipv6Native
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv6native
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Ipv6Native { get; set; }
        /// <summary>
        /// Ipv6CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-ipv6cidrblock
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6CidrBlock { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet.html#cfn-ec2-subnet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SubnetTypes
    {
        public class BlockPublicAccessStates : Humidifier.Base.BaseSubResource, IHaveInternetGatewayBlockMode
        {
            /// <summary>
            /// InternetGatewayBlockMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-subnet-blockpublicaccessstates.html#cfn-ec2-subnet-blockpublicaccessstates-internetgatewayblockmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InternetGatewayBlockMode { get; set; }
        }

        public class PrivateDnsNameOptionsOnLaunch : Humidifier.Base.BaseSubResource, IHaveEnableResourceNameDnsARecord_Boolean, IHaveHostnameType, IHaveEnableResourceNameDnsAAAARecord_Boolean
        {
            /// <summary>
            /// EnableResourceNameDnsARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-subnet-privatednsnameoptionsonlaunch.html#cfn-ec2-subnet-privatednsnameoptionsonlaunch-enableresourcenamednsarecord
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsARecord { get; set; }
            /// <summary>
            /// HostnameType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-subnet-privatednsnameoptionsonlaunch.html#cfn-ec2-subnet-privatednsnameoptionsonlaunch-hostnametype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostnameType { get; set; }
            /// <summary>
            /// EnableResourceNameDnsAAAARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-subnet-privatednsnameoptionsonlaunch.html#cfn-ec2-subnet-privatednsnameoptionsonlaunch-enableresourcenamednsaaaarecord
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsAAAARecord { get; set; }
        }
    }
}