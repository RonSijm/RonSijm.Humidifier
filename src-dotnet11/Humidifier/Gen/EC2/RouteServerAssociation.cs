namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class RouteServerAssociation : Humidifier.Base.BaseResource, IHaveVpcId, IHaveRouteServerId
    {
        public override string AWSTypeName { get => AWS.EC2.RouteServerAssociation; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverassociation.html#cfn-ec2-routeserverassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// RouteServerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverassociation.html#cfn-ec2-routeserverassociation-routeserverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RouteServerId { get; set; }
    }
}