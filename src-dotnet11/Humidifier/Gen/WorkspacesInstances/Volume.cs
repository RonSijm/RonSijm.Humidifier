namespace Humidifier.WorkspacesInstances
{
    using global::System.Collections.Generic;
    using VolumeTypes;

    public class Volume : Humidifier.Base.BaseResource, IHaveSizeInGB_Integer, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveListOfWorkspacesInstancesVolumeTypesTagSpecificationTagSpecifications, IHaveEncrypted_Boolean, IHaveAvailabilityZone, IHaveThroughput_Integer, IHaveIops_Integer
    {
        public class Attributes
        {
            public static string VolumeId =  "VolumeId" ;
        }

        public override string AWSTypeName { get => AWS.WorkspacesInstances.Volume; }
        /// <summary>
        /// SizeInGB
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-sizeingb
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SizeInGB { get; set; }
        /// <summary>
        /// SnapshotId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-snapshotid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotId { get; set; }
        /// <summary>
        /// VolumeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-volumetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeType { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-tagspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-encrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Encrypted { get; set; }

        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-availabilityzone
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// Throughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-throughput
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Throughput { get; set; }
        /// <summary>
        /// Iops
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volume.html#cfn-workspacesinstances-volume-iops
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Iops { get; set; }
    }

    namespace VolumeTypes
    {
        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-volume-tagspecification.html#cfn-workspacesinstances-volume-tagspecification-resourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-volume-tagspecification.html#cfn-workspacesinstances-volume-tagspecification-tags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }
    }
}