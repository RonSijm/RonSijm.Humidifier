namespace Humidifier.IoTAnalytics
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveChannelName, IHaveIoTAnalyticsChannelTypesChannelStorageChannelStorage, IHaveIoTAnalyticsChannelTypesRetentionPeriodRetentionPeriod
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.IoTAnalytics.Channel; }
        public Union<string, BaseFunction>? ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ChannelStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-channel.html#cfn-iotanalytics-channel-channelstorage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChannelStorage
        /// </summary>
        public Union<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage, BaseFunction>? ChannelStorage { get; set; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-channel.html#cfn-iotanalytics-channel-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public Union<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod, BaseFunction>? RetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-channel.html#cfn-iotanalytics-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ChannelTypes
    {
        public class ChannelStorage : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsChannelTypesCustomerManagedS3CustomerManagedS3, IHaveServiceManagedS3_Json
        {
            /// <summary>
            /// CustomerManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-channelstorage.html#cfn-iotanalytics-channel-channelstorage-customermanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3
            /// </summary>
            public Union<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3, BaseFunction>? CustomerManagedS3 { get; set; }
            /// <summary>
            /// ServiceManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-channelstorage.html#cfn-iotanalytics-channel-channelstorage-servicemanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ServiceManagedS3 { get; set; }
        }

        public class CustomerManagedS3 : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveRoleArn, IHaveKeyPrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-customermanageds3.html#cfn-iotanalytics-channel-customermanageds3-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-customermanageds3.html#cfn-iotanalytics-channel-customermanageds3-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-customermanageds3.html#cfn-iotanalytics-channel-customermanageds3-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveNumberOfDays_Integer, IHaveUnlimited_Boolean
        {
            /// <summary>
            /// NumberOfDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-retentionperiod.html#cfn-iotanalytics-channel-retentionperiod-numberofdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfDays { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-retentionperiod.html#cfn-iotanalytics-channel-retentionperiod-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Unlimited { get; set; }
        }
    }
}