namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class RouteTable : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcId
    {
        public class Attributes
        {
            public static string RouteTableId =  "RouteTableId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.RouteTable; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routetable.html#cfn-ec2-routetable-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routetable.html#cfn-ec2-routetable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}