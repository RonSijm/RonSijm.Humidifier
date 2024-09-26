namespace Humidifier.Config
{
    using System.Collections.Generic;
    using DeliveryChannelTypes;

    public class DeliveryChannel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveS3BucketName, IHaveS3KeyPrefix
    {
        public override string AWSTypeName { get => AWS.Config.DeliveryChannel; }
        /// <summary>
        /// ConfigSnapshotDeliveryProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-configsnapshotdeliveryproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConfigSnapshotDeliveryProperties
        /// </summary>
        public Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties ConfigSnapshotDeliveryProperties { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// S3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3bucketname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic S3BucketName { get; set; }
        /// <summary>
        /// S3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3KeyPrefix { get; set; }
        /// <summary>
        /// S3KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3KmsKeyArn { get; set; }
        /// <summary>
        /// SnsTopicARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-snstopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnsTopicARN { get; set; }
    }

    namespace DeliveryChannelTypes
    {
        public class ConfigSnapshotDeliveryProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeliveryFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-deliverychannel-configsnapshotdeliveryproperties.html#cfn-config-deliverychannel-configsnapshotdeliveryproperties-deliveryfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryFrequency { get; set; }
        }
    }
}