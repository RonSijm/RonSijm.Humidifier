namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class SubnetNetworkAclAssociation : Humidifier.Base.BaseResource, IHaveSubnetId, IHaveNetworkAclId
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SubnetNetworkAclAssociation; }

        /// <summary>
        /// NetworkAclId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetnetworkaclassociation.html#cfn-ec2-subnetnetworkaclassociation-networkaclid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkAclId { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetnetworkaclassociation.html#cfn-ec2-subnetnetworkaclassociation-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubnetId { get; set; }
    }
}