namespace Humidifier.GuardDuty
{
    using global::System.Collections.Generic;
    using IPSetTypes;

    public class IPSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFormat, IHaveActivate_Boolean, IHaveDetectorId, IHaveExpectedBucketOwner, IHaveListOfGuardDutyIPSetTypesTagItemTags, IHaveName, IHaveLocation
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.GuardDuty.IPSet; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html#cfn-guardduty-ipset-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// Activate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html#cfn-guardduty-ipset-activate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Activate { get; set; }
        /// <summary>
        /// DetectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html#cfn-guardduty-ipset-detectorid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DetectorId { get; set; }
        /// <summary>
        /// ExpectedBucketOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html#cfn-guardduty-ipset-expectedbucketowner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html#cfn-guardduty-ipset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GuardDuty.IPSetTypes.TagItem>, IReadOnlyList<Union<Humidifier.GuardDuty.IPSetTypes.TagItem, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html#cfn-guardduty-ipset-location
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Location { get; set; }
    }

    namespace IPSetTypes
    {
        public class TagItem : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-ipset-tagitem.html#cfn-guardduty-ipset-tagitem-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-ipset-tagitem.html#cfn-guardduty-ipset-tagitem-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}