namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class DirectConnectGateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAmazonSideAsn
    {
        public class Attributes
        {
            public static string DirectConnectGatewayId =  "DirectConnectGatewayId" ;
            public static string DirectConnectGatewayArn =  "DirectConnectGatewayArn" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.DirectConnectGateway; }
        public dynamic DirectConnectGatewayName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgateway.html#cfn-directconnect-directconnectgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AmazonSideAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgateway.html#cfn-directconnect-directconnectgateway-amazonsideasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AmazonSideAsn { get; set; }
    }
}