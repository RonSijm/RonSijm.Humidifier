namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class IPAMResourceDiscoveryAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveIpamId
    {
        public class Attributes
        {
            public static string IsDefault =  "IsDefault" ;
            public static string ResourceDiscoveryStatus =  "ResourceDiscoveryStatus" ;
            public static string OwnerId =  "OwnerId" ;
            public static string IpamArn =  "IpamArn" ;
            public static string IpamResourceDiscoveryAssociationId =  "IpamResourceDiscoveryAssociationId" ;
            public static string IpamResourceDiscoveryAssociationArn =  "IpamResourceDiscoveryAssociationArn" ;
            public static string State =  "State" ;
            public static string IpamRegion =  "IpamRegion" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMResourceDiscoveryAssociation; }

        /// <summary>
        /// IpamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscoveryassociation.html#cfn-ec2-ipamresourcediscoveryassociation-ipamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscoveryassociation.html#cfn-ec2-ipamresourcediscoveryassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// IpamResourceDiscoveryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamresourcediscoveryassociation.html#cfn-ec2-ipamresourcediscoveryassociation-ipamresourcediscoveryid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamResourceDiscoveryId { get; set; }
    }
}