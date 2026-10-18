namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayPolicyTableAssociation : Humidifier.Base.BaseResource, IHaveTransitGatewayPolicyTableId, IHaveTransitGatewayAttachmentId
    {
        public class Attributes
        {
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayPolicyTableAssociation; }

        /// <summary>
        /// TransitGatewayPolicyTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytableassociation.html#cfn-ec2-transitgatewaypolicytableassociation-transitgatewaypolicytableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayPolicyTableId { get; set; }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytableassociation.html#cfn-ec2-transitgatewaypolicytableassociation-transitgatewayattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayAttachmentId { get; set; }
    }
}