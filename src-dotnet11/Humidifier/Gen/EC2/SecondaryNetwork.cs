namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SecondaryNetworkTypes;

    public class SecondaryNetwork : Humidifier.Base.BaseResource, IHaveTags, IHaveNetworkType, IHaveIpv4CidrBlock
    {
        public class Attributes
        {
            public static string Ipv4CidrBlockAssociations =  "Ipv4CidrBlockAssociations" ;
            public static string SecondaryNetworkArn =  "SecondaryNetworkArn" ;
            public static string OwnerId =  "OwnerId" ;
            public static string SecondaryNetworkId =  "SecondaryNetworkId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SecondaryNetwork; }

        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-secondarynetwork.html#cfn-ec2-secondarynetwork-networktype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-secondarynetwork.html#cfn-ec2-secondarynetwork-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Ipv4CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-secondarynetwork.html#cfn-ec2-secondarynetwork-ipv4cidrblock
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Ipv4CidrBlock { get; set; }
    }

    namespace SecondaryNetworkTypes
    {
        public class Ipv4CidrBlockAssociation : Humidifier.Base.BaseSubResource, IHaveState, IHaveCidrBlock, IHaveAssociationId
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-secondarynetwork-ipv4cidrblockassociation.html#cfn-ec2-secondarynetwork-ipv4cidrblockassociation-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-secondarynetwork-ipv4cidrblockassociation.html#cfn-ec2-secondarynetwork-ipv4cidrblockassociation-cidrblock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrBlock { get; set; }
            /// <summary>
            /// AssociationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-secondarynetwork-ipv4cidrblockassociation.html#cfn-ec2-secondarynetwork-ipv4cidrblockassociation-associationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssociationId { get; set; }
        }
    }
}