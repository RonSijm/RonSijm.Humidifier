namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using DeliveryChannelTypes;

    public class DeliveryChannel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveS3KeyPrefix, IHaveConfigDeliveryChannelTypesConfigSnapshotDeliveryPropertiesConfigSnapshotDeliveryProperties, IHaveS3BucketName, IHaveSnsTopicARN, IHaveS3KmsKeyArn, IHaveName
    {
        public override string AWSTypeName { get => AWS.Config.DeliveryChannel; }
        /// <summary>
        /// S3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
        /// <summary>
        /// ConfigSnapshotDeliveryProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-configsnapshotdeliveryproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConfigSnapshotDeliveryProperties
        /// </summary>
        public Union<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties, BaseFunction>? ConfigSnapshotDeliveryProperties { get; set; }

        /// <summary>
        /// S3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3bucketname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3BucketName { get; set; }
        /// <summary>
        /// SnsTopicARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-snstopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnsTopicARN { get; set; }
        /// <summary>
        /// S3KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3KmsKeyArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DeliveryChannelTypes
    {
        public class ConfigSnapshotDeliveryProperties : Humidifier.Base.BaseSubResource, IHaveDeliveryFrequency
        {
            /// <summary>
            /// DeliveryFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-deliverychannel-configsnapshotdeliveryproperties.html#cfn-config-deliverychannel-configsnapshotdeliveryproperties-deliveryfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryFrequency { get; set; }
        }
    }
}