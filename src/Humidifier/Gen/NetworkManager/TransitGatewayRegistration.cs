namespace Humidifier.NetworkManager
{
    using System.Collections.Generic;

    public class TransitGatewayRegistration : Humidifier.Base.BaseResource, IHaveGlobalNetworkId
    {
        public override string AWSTypeName { get => AWS.NetworkManager.TransitGatewayRegistration; }

        /// <summary>
        /// GlobalNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayregistration.html#cfn-networkmanager-transitgatewayregistration-globalnetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GlobalNetworkId { get; set; }

        /// <summary>
        /// TransitGatewayArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayregistration.html#cfn-networkmanager-transitgatewayregistration-transitgatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayArn { get; set; }
    }
}