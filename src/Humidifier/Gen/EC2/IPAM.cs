namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using IPAMTypes;

    public class IPAM : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveTier
    {
        public class Attributes
        {
            public static string DefaultResourceDiscoveryAssociationId =  "DefaultResourceDiscoveryAssociationId" ;
            public static string DefaultResourceDiscoveryId =  "DefaultResourceDiscoveryId" ;
            public static string IpamId =  "IpamId" ;
            public static string ResourceDiscoveryAssociationCount =  "ResourceDiscoveryAssociationCount" ;
            public static string ScopeCount =  "ScopeCount" ;
            public static string Arn =  "Arn" ;
            public static string PrivateDefaultScopeId =  "PrivateDefaultScopeId" ;
            public static string PublicDefaultScopeId =  "PublicDefaultScopeId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAM; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-tier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Tier { get; set; }
        /// <summary>
        /// EnablePrivateGua
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-enableprivategua
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnablePrivateGua { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// OperatingRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipam.html#cfn-ec2-ipam-operatingregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamOperatingRegion
        /// </summary>
        public List<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> OperatingRegions { get; set; }
    }

    namespace IPAMTypes
    {
        public class IpamOperatingRegion : Humidifier.Base.BaseSubResource, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipam-ipamoperatingregion.html#cfn-ec2-ipam-ipamoperatingregion-regionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
        }
    }
}