namespace Humidifier.Logs
{
    using System.Collections.Generic;

    public class Delivery : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string DeliveryId =  "DeliveryId" ;
            public static string Arn =  "Arn" ;
            public static string DeliveryDestinationType =  "DeliveryDestinationType" ;
        }

        public override string AWSTypeName { get => AWS.Logs.Delivery; }

        /// <summary>
        /// DeliveryDestinationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-deliverydestinationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeliveryDestinationArn { get; set; }

        /// <summary>
        /// DeliverySourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-deliverysourcename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeliverySourceName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}