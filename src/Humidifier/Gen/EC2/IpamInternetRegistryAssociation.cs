namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class IpamInternetRegistryAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveIpamId
    {
        public class Attributes
        {
            public static string IpamInternetRegistryAssociationArn =  "IpamInternetRegistryAssociationArn" ;
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string ChildRequestXml =  "ChildRequestXml" ;
            public static string IpamInternetRegistryAssociationId =  "IpamInternetRegistryAssociationId" ;
            public static string IpamRegion =  "IpamRegion" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IpamInternetRegistryAssociation; }

        /// <summary>
        /// OrganizationHandle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipaminternetregistryassociation.html#cfn-ec2-ipaminternetregistryassociation-organizationhandle
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OrganizationHandle { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipaminternetregistryassociation.html#cfn-ec2-ipaminternetregistryassociation-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// IpamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipaminternetregistryassociation.html#cfn-ec2-ipaminternetregistryassociation-ipamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamId { get; set; }

        /// <summary>
        /// Rir
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipaminternetregistryassociation.html#cfn-ec2-ipaminternetregistryassociation-rir
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Rir { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipaminternetregistryassociation.html#cfn-ec2-ipaminternetregistryassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}