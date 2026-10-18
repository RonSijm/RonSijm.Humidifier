namespace Humidifier.Logs
{
    using global::System.Collections.Generic;
    using DeliveryDestinationTypes;

    public class DeliveryDestination : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDestinationResourceArn, IHaveOutputFormat, IHaveLogsDeliveryDestinationTypesDestinationPolicyDeliveryDestinationPolicy, IHaveDeliveryDestinationType, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Logs.DeliveryDestination; }
        /// <summary>
        /// DestinationResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverydestination.html#cfn-logs-deliverydestination-destinationresourcearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DestinationResourceArn { get; set; }
        /// <summary>
        /// OutputFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverydestination.html#cfn-logs-deliverydestination-outputformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutputFormat { get; set; }
        /// <summary>
        /// DeliveryDestinationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverydestination.html#cfn-logs-deliverydestination-deliverydestinationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DestinationPolicy
        /// </summary>
        public Union<Humidifier.Logs.DeliveryDestinationTypes.DestinationPolicy, BaseFunction>? DeliveryDestinationPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverydestination.html#cfn-logs-deliverydestination-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// DeliveryDestinationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-deliverydestination.html#cfn-logs-deliverydestination-deliverydestinationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliveryDestinationType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DeliveryDestinationTypes
    {
        public class DestinationPolicy : Humidifier.Base.BaseSubResource, IHaveDeliveryDestinationName, IHaveDeliveryDestinationPolicy_Json
        {
            /// <summary>
            /// DeliveryDestinationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-deliverydestination-destinationpolicy.html#cfn-logs-deliverydestination-destinationpolicy-deliverydestinationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryDestinationName { get; set; }
            /// <summary>
            /// DeliveryDestinationPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-deliverydestination-destinationpolicy.html#cfn-logs-deliverydestination-destinationpolicy-deliverydestinationpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? DeliveryDestinationPolicy { get; set; }
        }
    }
}