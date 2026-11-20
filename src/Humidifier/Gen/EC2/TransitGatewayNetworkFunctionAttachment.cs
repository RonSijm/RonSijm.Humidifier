namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayNetworkFunctionAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveServiceName, IHaveAvailabilityZones, IHaveTransitGatewayId
    {
        public class Attributes
        {
            public static string ResourceId =  "ResourceId" ;
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string TransitGatewayAttachmentId =  "TransitGatewayAttachmentId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayNetworkFunctionAttachment; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaynetworkfunctionattachment.html#cfn-ec2-transitgatewaynetworkfunctionattachment-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayId { get; set; }
        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaynetworkfunctionattachment.html#cfn-ec2-transitgatewaynetworkfunctionattachment-servicename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceName { get; set; }
        /// <summary>
        /// AvailabilityZoneIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaynetworkfunctionattachment.html#cfn-ec2-transitgatewaynetworkfunctionattachment-availabilityzoneids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AvailabilityZoneIds { get; set; }
        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaynetworkfunctionattachment.html#cfn-ec2-transitgatewaynetworkfunctionattachment-availabilityzones
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AvailabilityZones { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaynetworkfunctionattachment.html#cfn-ec2-transitgatewaynetworkfunctionattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}