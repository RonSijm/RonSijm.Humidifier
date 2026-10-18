namespace Humidifier.Logs
{
    using global::System.Collections.Generic;

    public class Delivery : Humidifier.Base.BaseResource, IHaveTags, IHaveS3EnableHiveCompatiblePath_Boolean, IHaveFieldDelimiter, IHaveDeliveryDestinationArn, IHaveDeliverySourceName, IHaveStringListOfRecordFields, IHaveS3SuffixPath
    {
        public class Attributes
        {
            public static string DeliveryId =  "DeliveryId" ;
            public static string Arn =  "Arn" ;
            public static string DeliveryDestinationType =  "DeliveryDestinationType" ;
        }

        public override string AWSTypeName { get => AWS.Logs.Delivery; }
        /// <summary>
        /// S3EnableHiveCompatiblePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-s3enablehivecompatiblepath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? S3EnableHiveCompatiblePath { get; set; }
        /// <summary>
        /// FieldDelimiter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-fielddelimiter
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FieldDelimiter { get; set; }

        /// <summary>
        /// DeliveryDestinationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-deliverydestinationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeliveryDestinationArn { get; set; }

        /// <summary>
        /// DeliverySourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-deliverysourcename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeliverySourceName { get; set; }
        /// <summary>
        /// RecordFields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-recordfields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RecordFields { get; set; }
        /// <summary>
        /// S3SuffixPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-s3suffixpath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3SuffixPath { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-delivery.html#cfn-logs-delivery-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}