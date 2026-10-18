namespace Humidifier.GuardDuty
{
    using global::System.Collections.Generic;
    using PublishingDestinationTypes;

    public class PublishingDestination : Humidifier.Base.BaseResource, IHaveGuardDutyPublishingDestinationTypesCFNDestinationPropertiesDestinationProperties, IHaveDetectorId, IHaveDestinationType, IHaveListOfGuardDutyPublishingDestinationTypesTagItemTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PublishingFailureStartTimestamp =  "PublishingFailureStartTimestamp" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.GuardDuty.PublishingDestination; }

        /// <summary>
        /// DestinationProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-publishingdestination.html#cfn-guardduty-publishingdestination-destinationproperties
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CFNDestinationProperties
        /// </summary>
        [Required]
        public Union<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties, BaseFunction>? DestinationProperties { get; set; }

        /// <summary>
        /// DetectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-publishingdestination.html#cfn-guardduty-publishingdestination-detectorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DetectorId { get; set; }

        /// <summary>
        /// DestinationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-publishingdestination.html#cfn-guardduty-publishingdestination-destinationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DestinationType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-publishingdestination.html#cfn-guardduty-publishingdestination-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem>, IReadOnlyList<Union<Humidifier.GuardDuty.PublishingDestinationTypes.TagItem, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PublishingDestinationTypes
    {
        public class CFNDestinationProperties : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveDestinationArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-publishingdestination-cfndestinationproperties.html#cfn-guardduty-publishingdestination-cfndestinationproperties-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-publishingdestination-cfndestinationproperties.html#cfn-guardduty-publishingdestination-cfndestinationproperties-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationArn { get; set; }
        }

        public class TagItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-publishingdestination-tagitem.html#cfn-guardduty-publishingdestination-tagitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-publishingdestination-tagitem.html#cfn-guardduty-publishingdestination-tagitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}