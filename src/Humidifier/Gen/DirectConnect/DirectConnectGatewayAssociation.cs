namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class DirectConnectGatewayAssociation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.DirectConnectGatewayAssociation; }
        /// <summary>
        /// AcceptDirectConnectGatewayAssociationProposalRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-acceptdirectconnectgatewayassociationproposalrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AcceptDirectConnectGatewayAssociationProposalRoleArn { get; set; }

        /// <summary>
        /// DirectConnectGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-directconnectgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DirectConnectGatewayId { get; set; }

        /// <summary>
        /// AssociatedGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-associatedgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssociatedGatewayId { get; set; }
        /// <summary>
        /// AllowedPrefixesToDirectConnectGateway
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-allowedprefixestodirectconnectgateway
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AllowedPrefixesToDirectConnectGateway { get; set; }
    }
}