namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class RouteServerPropagation : Humidifier.Base.BaseResource, IHaveRouteTableId
    {
        public override string AWSTypeName { get => AWS.EC2.RouteServerPropagation; }

        /// <summary>
        /// RouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverpropagation.html#cfn-ec2-routeserverpropagation-routetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RouteTableId { get; set; }

        /// <summary>
        /// RouteServerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverpropagation.html#cfn-ec2-routeserverpropagation-routeserverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RouteServerId { get; set; }
    }
}