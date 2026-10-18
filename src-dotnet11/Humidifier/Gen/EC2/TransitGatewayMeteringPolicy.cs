namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayMeteringPolicy : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayId, IHaveStringListOfMiddleboxAttachmentIds
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string UpdateEffectiveAt =  "UpdateEffectiveAt" ;
            public static string TransitGatewayMeteringPolicyId =  "TransitGatewayMeteringPolicyId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayMeteringPolicy; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicy.html#cfn-ec2-transitgatewaymeteringpolicy-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }
        /// <summary>
        /// MiddleboxAttachmentIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicy.html#cfn-ec2-transitgatewaymeteringpolicy-middleboxattachmentids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MiddleboxAttachmentIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymeteringpolicy.html#cfn-ec2-transitgatewaymeteringpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}