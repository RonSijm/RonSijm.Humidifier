namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;

    public class Volume : Humidifier.Base.BaseResource, IHaveTags, IHaveGatewayARN, IHaveSnapshotId, IHaveKMSKey, IHaveSourceVolumeARN, IHaveKMSEncrypted_Boolean, IHaveVolumeSizeInBytes_Double, IHaveTargetName, IHaveNetworkInterfaceId
    {
        public class Attributes
        {
            public static string VolumeId =  "VolumeId" ;
            public static string VolumeType =  "VolumeType" ;
            public static string VolumeARN =  "VolumeARN" ;
            public static string VolumeAttachmentStatus =  "VolumeAttachmentStatus" ;
            public static string TargetARN =  "TargetARN" ;
            public static string VolumeUsedInBytes =  "VolumeUsedInBytes" ;
            public static string CreatedDate =  "CreatedDate" ;
            public static string VolumeStatus =  "VolumeStatus" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.Volume; }

        /// <summary>
        /// GatewayARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-gatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayARN { get; set; }
        /// <summary>
        /// SnapshotId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-snapshotid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotId { get; set; }
        /// <summary>
        /// KMSKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-kmskey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKey { get; set; }
        /// <summary>
        /// SourceVolumeARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-sourcevolumearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceVolumeARN { get; set; }
        /// <summary>
        /// KMSEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-kmsencrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? KMSEncrypted { get; set; }

        /// <summary>
        /// VolumeSizeInBytes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-volumesizeinbytes
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? VolumeSizeInBytes { get; set; }

        /// <summary>
        /// TargetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-targetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetName { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-networkinterfaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-volume.html#cfn-storagegateway-volume-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}