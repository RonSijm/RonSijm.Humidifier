namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using IPAMResourceDiscoveryTypes;

    public class IPAMResourceDiscovery : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string IsDefault =  "IsDefault" ;
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string IpamResourceDiscoveryRegion =  "IpamResourceDiscoveryRegion" ;
            public static string IpamResourceDiscoveryArn =  "IpamResourceDiscoveryArn" ;
            public static string IpamResourceDiscoveryId =  "IpamResourceDiscoveryId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMResourceDiscovery; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// OperatingRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscovery.html#cfn-ec2-ipamresourcediscovery-operatingregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamOperatingRegion
        /// </summary>
        public List<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> OperatingRegions { get; set; }
    }

    namespace IPAMResourceDiscoveryTypes
    {
        public class IpamOperatingRegion : Humidifier.Base.BaseSubResource, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamresourcediscovery-ipamoperatingregion.html#cfn-ec2-ipamresourcediscovery-ipamoperatingregion-regionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
        }
    }
}