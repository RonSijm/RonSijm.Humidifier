namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using VolumeTypes;

    public class Volume : Humidifier.Base.BaseResource, IHaveFleetId, IHaveFarmId, IHaveListOfDeadlineVolumeTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string SizeGiB =  "SizeGiB" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string LastReleasedAt =  "LastReleasedAt" ;
            public static string Iops =  "Iops" ;
            public static string VolumeId =  "VolumeId" ;
            public static string LastAssignedAt =  "LastAssignedAt" ;
            public static string VolumeType =  "VolumeType" ;
            public static string State =  "State" ;
            public static string ThroughputMiB =  "ThroughputMiB" ;
            public static string Arn =  "Arn" ;
            public static string ExpiresAt =  "ExpiresAt" ;
            public static string AttachedWorkerId =  "AttachedWorkerId" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Volume; }
        /// <summary>
        /// FleetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-volume.html#cfn-deadline-volume-fleetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FleetId { get; set; }
        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-volume.html#cfn-deadline-volume-farmid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FarmId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-volume.html#cfn-deadline-volume-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Deadline.VolumeTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Deadline.VolumeTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VolumeTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-volume-tagsitems.html#cfn-deadline-volume-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-volume-tagsitems.html#cfn-deadline-volume-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}