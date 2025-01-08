namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class IPAMScope : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveIpamId
    {
        public class Attributes
        {
            public static string IpamScopeId =  "IpamScopeId" ;
            public static string IsDefault =  "IsDefault" ;
            public static string IpamArn =  "IpamArn" ;
            public static string IpamScopeType =  "IpamScopeType" ;
            public static string PoolCount =  "PoolCount" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMScope; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// IpamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-ipamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}