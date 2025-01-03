namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class SecurityGroupVpcAssociation : Humidifier.Base.BaseResource, IHaveVpcId, IHaveGroupId
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string StateReason =  "StateReason" ;
            public static string VpcOwnerId =  "VpcOwnerId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SecurityGroupVpcAssociation; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupvpcassociation.html#cfn-ec2-securitygroupvpcassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }

        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupvpcassociation.html#cfn-ec2-securitygroupvpcassociation-groupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupId { get; set; }
    }
}