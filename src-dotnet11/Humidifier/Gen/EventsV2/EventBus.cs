namespace Humidifier.EventsV2
{
    using global::System.Collections.Generic;
    using EventBusTypes;

    public class EventBus : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveEventsV2EventBusTypesEncryptionConfigurationEncryptionConfiguration, IHaveEventsV2EventBusTypesStorageConfigurationStorageConfiguration, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// StorageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-storageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StorageConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.EventBusTypes.StorageConfiguration, BaseFunction>? StorageConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventbus.html#cfn-eventsv2-eventbus-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        }

        public class StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveRetentionPeriodInDays_Integer
        {
            /// <summary>
            /// RetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventbus-storageconfiguration.html#cfn-eventsv2-eventbus-storageconfiguration-retentionperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionPeriodInDays { get; set; }
        }
    }
}