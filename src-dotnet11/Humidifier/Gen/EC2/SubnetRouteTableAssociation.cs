namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class SubnetRouteTableAssociation : Humidifier.Base.BaseResource, IHaveRouteTableId, IHaveSubnetId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SubnetRouteTableAssociation; }

        /// <summary>
        /// RouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetroutetableassociation.html#cfn-ec2-subnetroutetableassociation-routetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RouteTableId { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetroutetableassociation.html#cfn-ec2-subnetroutetableassociation-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubnetId { get; set; }
    }
}