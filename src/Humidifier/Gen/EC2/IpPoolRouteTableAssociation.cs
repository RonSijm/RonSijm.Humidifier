namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class IpPoolRouteTableAssociation : Humidifier.Base.BaseResource, IHaveRouteTableId
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IpPoolRouteTableAssociation; }

        /// <summary>
        /// RouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ippoolroutetableassociation.html#cfn-ec2-ippoolroutetableassociation-routetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RouteTableId { get; set; }

        /// <summary>
        /// PublicIpv4Pool
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ippoolroutetableassociation.html#cfn-ec2-ippoolroutetableassociation-publicipv4pool
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PublicIpv4Pool { get; set; }
    }
}