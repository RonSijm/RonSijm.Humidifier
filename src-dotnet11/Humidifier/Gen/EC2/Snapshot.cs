namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SnapshotTypes;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveVolumeId, IHaveDescription, IHaveListOfEC2SnapshotTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string SnapshotId =  "SnapshotId" ;
            public static string Progress =  "Progress" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string OwnerId =  "OwnerId" ;
            public static string Encrypted =  "Encrypted" ;
            public static string State =  "State" ;
            public static string StartTime =  "StartTime" ;
            public static string StorageTier =  "StorageTier" ;
            public static string Arn =  "Arn" ;
            public static string VolumeSize =  "VolumeSize" ;
        }

        public override string AWSTypeName { get => AWS.EC2.Snapshot; }

        /// <summary>
        /// VolumeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-snapshot.html#cfn-ec2-snapshot-volumeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VolumeId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-snapshot.html#cfn-ec2-snapshot-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-snapshot.html#cfn-ec2-snapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.SnapshotTypes.TagsItems>, IReadOnlyList<Union<Humidifier.EC2.SnapshotTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SnapshotTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-snapshot-tagsitems.html#cfn-ec2-snapshot-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-snapshot-tagsitems.html#cfn-ec2-snapshot-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}