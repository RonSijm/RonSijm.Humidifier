namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class DHCPOptions : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfNetbiosNameServers, IHaveStringListOfNtpServers, IHaveDomainName, IHaveIpv6AddressPreferredLeaseTime_Integer, IHaveNetbiosNodeType_Integer, IHaveStringListOfDomainNameServers
    {
        public class Attributes
        {
            public static string DhcpOptionsId =  "DhcpOptionsId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.DHCPOptions; }
        /// <summary>
        /// NetbiosNameServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-netbiosnameservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NetbiosNameServers { get; set; }
        /// <summary>
        /// NtpServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-ntpservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NtpServers { get; set; }
        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-domainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// Ipv6AddressPreferredLeaseTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-ipv6addresspreferredleasetime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6AddressPreferredLeaseTime { get; set; }
        /// <summary>
        /// NetbiosNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-netbiosnodetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NetbiosNodeType { get; set; }
        /// <summary>
        /// DomainNameServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-domainnameservers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DomainNameServers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcpoptions.html#cfn-ec2-dhcpoptions-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}