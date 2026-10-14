namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayPolicyTable : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayId
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string TransitGatewayPolicyTableId =  "TransitGatewayPolicyTableId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayPolicyTable; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytable.html#cfn-ec2-transitgatewaypolicytable-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypolicytable.html#cfn-ec2-transitgatewaypolicytable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}