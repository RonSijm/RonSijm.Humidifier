namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class IPAMPrefixListResolverTarget : Humidifier.Base.BaseResource, IHaveTags, IHavePrefixListId
    {
        public class Attributes
        {
            public static string IpamPrefixListResolverTargetId =  "IpamPrefixListResolverTargetId" ;
            public static string IpamPrefixListResolverTargetArn =  "IpamPrefixListResolverTargetArn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMPrefixListResolverTarget; }

        /// <summary>
        /// PrefixListRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolvertarget.html#cfn-ec2-ipamprefixlistresolvertarget-prefixlistregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PrefixListRegion { get; set; }
        /// <summary>
        /// DesiredVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolvertarget.html#cfn-ec2-ipamprefixlistresolvertarget-desiredversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Long
        /// </summary>
        public dynamic DesiredVersion { get; set; }

        /// <summary>
        /// PrefixListId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolvertarget.html#cfn-ec2-ipamprefixlistresolvertarget-prefixlistid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PrefixListId { get; set; }

        /// <summary>
        /// IpamPrefixListResolverId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolvertarget.html#cfn-ec2-ipamprefixlistresolvertarget-ipamprefixlistresolverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamPrefixListResolverId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolvertarget.html#cfn-ec2-ipamprefixlistresolvertarget-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// TrackLatestVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolvertarget.html#cfn-ec2-ipamprefixlistresolvertarget-tracklatestversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic TrackLatestVersion { get; set; }
    }
}