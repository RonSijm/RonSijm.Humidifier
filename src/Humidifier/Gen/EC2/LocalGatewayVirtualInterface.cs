namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class LocalGatewayVirtualInterface : Humidifier.Base.BaseResource, IHaveTags, IHavePeerAddress, IHaveLocalGatewayVirtualInterfaceGroupId
    {
        public class Attributes
        {
            public static string ConfigurationState =  "ConfigurationState" ;
            public static string OwnerId =  "OwnerId" ;
            public static string LocalGatewayId =  "LocalGatewayId" ;
            public static string LocalBgpAsn =  "LocalBgpAsn" ;
            public static string LocalGatewayVirtualInterfaceId =  "LocalGatewayVirtualInterfaceId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGatewayVirtualInterface; }

        /// <summary>
        /// OutpostLagId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-outpostlagid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OutpostLagId { get; set; }

        /// <summary>
        /// LocalAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-localaddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalAddress { get; set; }

        /// <summary>
        /// PeerAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-peeraddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PeerAddress { get; set; }

        /// <summary>
        /// Vlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-vlan
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Vlan { get; set; }
        /// <summary>
        /// PeerBgpAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-peerbgpasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic PeerBgpAsn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// LocalGatewayVirtualInterfaceGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-localgatewayvirtualinterfacegroupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayVirtualInterfaceGroupId { get; set; }
        /// <summary>
        /// PeerBgpAsnExtended
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterface.html#cfn-ec2-localgatewayvirtualinterface-peerbgpasnextended
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Long
        /// </summary>
        public dynamic PeerBgpAsnExtended { get; set; }
    }
}