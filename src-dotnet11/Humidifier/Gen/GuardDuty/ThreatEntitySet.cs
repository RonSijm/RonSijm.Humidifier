namespace Humidifier.GuardDuty
{
    using global::System.Collections.Generic;
    using ThreatEntitySetTypes;

    public class ThreatEntitySet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFormat, IHaveActivate_Boolean, IHaveDetectorId, IHaveExpectedBucketOwner, IHaveListOfGuardDutyThreatEntitySetTypesTagItemTags, IHaveName, IHaveLocation
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string ErrorDetails =  "ErrorDetails" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.GuardDuty.ThreatEntitySet; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatentityset.html#cfn-guardduty-threatentityset-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// Activate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatentityset.html#cfn-guardduty-threatentityset-activate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Activate { get; set; }
        /// <summary>
        /// DetectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatentityset.html#cfn-guardduty-threatentityset-detectorid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DetectorId { get; set; }
        /// <summary>
        /// ExpectedBucketOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatentityset.html#cfn-guardduty-threatentityset-expectedbucketowner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatentityset.html#cfn-guardduty-threatentityset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem>, IReadOnlyList<Union<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatentityset.html#cfn-guardduty-threatentityset-location
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Location { get; set; }
    }

    namespace ThreatEntitySetTypes
    {
        public class TagItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-threatentityset-tagitem.html#cfn-guardduty-threatentityset-tagitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-threatentityset-tagitem.html#cfn-guardduty-threatentityset-tagitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}