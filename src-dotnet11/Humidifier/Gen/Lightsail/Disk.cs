namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using DiskTypes;

    public class Disk : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSizeInGb_Integer, IHaveAvailabilityZone, IHaveListOfLightsailDiskTypesAddOnAddOns, IHaveDiskName, IHaveLightsailDiskTypesLocationLocation
    {
        public class Attributes
        {
            public static string Path =  "Path" ;
            public static string AttachmentState =  "AttachmentState" ;
            public static string SupportCode =  "SupportCode" ;
            public static string State =  "State" ;
            public static string IsAttached =  "IsAttached" ;
            public static string ResourceType =  "ResourceType" ;
            public static string DiskArn =  "DiskArn" ;
            public static string AttachedTo =  "AttachedTo" ;
            public static string Iops =  "Iops" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Disk; }

        /// <summary>
        /// SizeInGb
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-sizeingb
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? SizeInGb { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// AddOns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-addons
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AddOn
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lightsail.DiskTypes.AddOn>, IReadOnlyList<Union<Humidifier.Lightsail.DiskTypes.AddOn, BaseFunction>>, BaseFunction>? AddOns { get; set; }
        public Union<string, BaseFunction>? DiskName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Location
        /// </summary>
        public Union<Humidifier.Lightsail.DiskTypes.Location, BaseFunction>? Location { get; set; }
    }

    namespace DiskTypes
    {
        public class AddOn : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveAddOnType, IHaveLightsailDiskTypesAutoSnapshotAddOnAutoSnapshotAddOnRequest
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-addon.html#cfn-lightsail-disk-addon-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// AddOnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-addon.html#cfn-lightsail-disk-addon-addontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddOnType { get; set; }
            /// <summary>
            /// AutoSnapshotAddOnRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-addon.html#cfn-lightsail-disk-addon-autosnapshotaddonrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoSnapshotAddOn
            /// </summary>
            public Union<Humidifier.Lightsail.DiskTypes.AutoSnapshotAddOn, BaseFunction>? AutoSnapshotAddOnRequest { get; set; }
        }

        public class AutoSnapshotAddOn : Humidifier.Base.BaseSubResource, IHaveSnapshotTimeOfDay
        {
            /// <summary>
            /// SnapshotTimeOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-autosnapshotaddon.html#cfn-lightsail-disk-autosnapshotaddon-snapshottimeofday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotTimeOfDay { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-location.html#cfn-lightsail-disk-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-location.html#cfn-lightsail-disk-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}