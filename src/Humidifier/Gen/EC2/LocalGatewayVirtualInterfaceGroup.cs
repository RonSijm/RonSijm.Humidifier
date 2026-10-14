namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class LocalGatewayVirtualInterfaceGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveLocalGatewayId
    {
        public class Attributes
        {
            public static string LocalGatewayVirtualInterfaceIds =  "LocalGatewayVirtualInterfaceIds" ;
            public static string ConfigurationState =  "ConfigurationState" ;
            public static string OwnerId =  "OwnerId" ;
            public static string LocalGatewayVirtualInterfaceGroupArn =  "LocalGatewayVirtualInterfaceGroupArn" ;
            public static string LocalGatewayVirtualInterfaceGroupId =  "LocalGatewayVirtualInterfaceGroupId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGatewayVirtualInterfaceGroup; }

        /// <summary>
        /// LocalGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterfacegroup.html#cfn-ec2-localgatewayvirtualinterfacegroup-localgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayId { get; set; }
        /// <summary>
        /// LocalBgpAsnExtended
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterfacegroup.html#cfn-ec2-localgatewayvirtualinterfacegroup-localbgpasnextended
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Long
        /// </summary>
        public dynamic LocalBgpAsnExtended { get; set; }
        /// <summary>
        /// LocalBgpAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterfacegroup.html#cfn-ec2-localgatewayvirtualinterfacegroup-localbgpasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic LocalBgpAsn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayvirtualinterfacegroup.html#cfn-ec2-localgatewayvirtualinterfacegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}