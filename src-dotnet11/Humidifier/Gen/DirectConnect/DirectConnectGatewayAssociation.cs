namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class DirectConnectGatewayAssociation : Humidifier.Base.BaseResource, IHaveAcceptDirectConnectGatewayAssociationProposalRoleArn, IHaveDirectConnectGatewayId, IHaveAssociatedGatewayId, IHaveStringListOfAllowedPrefixesToDirectConnectGateway
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
        public Union<string, BaseFunction>? AcceptDirectConnectGatewayAssociationProposalRoleArn { get; set; }

        /// <summary>
        /// DirectConnectGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-directconnectgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectConnectGatewayId { get; set; }

        /// <summary>
        /// AssociatedGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-associatedgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssociatedGatewayId { get; set; }
        /// <summary>
        /// AllowedPrefixesToDirectConnectGateway
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-directconnectgatewayassociation.html#cfn-directconnect-directconnectgatewayassociation-allowedprefixestodirectconnectgateway
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedPrefixesToDirectConnectGateway { get; set; }
    }
}