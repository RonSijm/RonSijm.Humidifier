namespace Humidifier.GuardDuty
{
    using global::System.Collections.Generic;
    using TrustedEntitySetTypes;

    public class TrustedEntitySet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFormat, IHaveActivate_Boolean, IHaveDetectorId, IHaveExpectedBucketOwner, IHaveListOfGuardDutyTrustedEntitySetTypesTagItemTags, IHaveName, IHaveLocation
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string ErrorDetails =  "ErrorDetails" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.GuardDuty.TrustedEntitySet; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-trustedentityset.html#cfn-guardduty-trustedentityset-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// Activate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-trustedentityset.html#cfn-guardduty-trustedentityset-activate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Activate { get; set; }
        /// <summary>
        /// DetectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-trustedentityset.html#cfn-guardduty-trustedentityset-detectorid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DetectorId { get; set; }
        /// <summary>
        /// ExpectedBucketOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-trustedentityset.html#cfn-guardduty-trustedentityset-expectedbucketowner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-trustedentityset.html#cfn-guardduty-trustedentityset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem>, IReadOnlyList<Union<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-trustedentityset.html#cfn-guardduty-trustedentityset-location
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Location { get; set; }
    }

    namespace TrustedEntitySetTypes
    {
        public class TagItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-trustedentityset-tagitem.html#cfn-guardduty-trustedentityset-tagitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-trustedentityset-tagitem.html#cfn-guardduty-trustedentityset-tagitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}