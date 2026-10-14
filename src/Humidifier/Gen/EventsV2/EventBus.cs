namespace Humidifier.EventsV2
{
    using global::System.Collections.Generic;
    using EventBusTypes;

    public class EventBus : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string EventBusArn =  "EventBusArn" ;
        }

        public override string AWSTypeName { get => AWS.EventsV2.EventBus; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary>
        /// StorageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-storageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StorageConfiguration
        /// </summary>
        public Humidifier.EventsV2.EventBusTypes.StorageConfiguration StorageConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace EventBusTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyIdentifier
        {
            /// <summary>
            /// KmsKeyIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventbus-encryptionconfiguration.html#cfn-eventsv2-eventbus-encryptionconfiguration-kmskeyidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyIdentifier { get; set; }
        }

        public class StorageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventbus-storageconfiguration.html#cfn-eventsv2-eventbus-storageconfiguration-retentionperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetentionPeriodInDays { get; set; }
        }
    }
}