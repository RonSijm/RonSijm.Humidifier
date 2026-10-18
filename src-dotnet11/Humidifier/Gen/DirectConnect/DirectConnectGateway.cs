namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class DirectConnectGateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDirectConnectGatewayName, IHaveAmazonSideAsn
    {
        public class Attributes
        {
            public static string DirectConnectGatewayId =  "DirectConnectGatewayId" ;
            public static string DirectConnectGatewayArn =  "DirectConnectGatewayArn" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.DirectConnectGateway; }
        public Union<string, BaseFunction>? DirectConnectGatewayName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgateway.html#cfn-directconnect-directconnectgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AmazonSideAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgateway.html#cfn-directconnect-directconnectgateway-amazonsideasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AmazonSideAsn { get; set; }
    }
}