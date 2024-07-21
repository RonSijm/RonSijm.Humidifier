namespace Humidifier.Lightsail
{
    using System.Collections.Generic;
    using DiskTypes;

    public class Disk : Humidifier.Resource, IHaveTags
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

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lightsail::Disk";
            }
        }

        /// <summary>
        /// SizeInGb
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-sizeingb
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SizeInGb { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZone { get; set; }
        /// <summary>
        /// AddOns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-addons
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AddOn
        /// </summary>
        public List<AddOn> AddOns { get; set; }
        /// <summary>
        /// DiskName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-diskname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DiskName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disk.html#cfn-lightsail-disk-location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Location
        /// </summary>
        public Location Location { get; set; }
    }

    namespace DiskTypes
    {
        public class AddOn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-addon.html#cfn-lightsail-disk-addon-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// AddOnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-addon.html#cfn-lightsail-disk-addon-addontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddOnType { get; set; }
            /// <summary>
            /// AutoSnapshotAddOnRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-addon.html#cfn-lightsail-disk-addon-autosnapshotaddonrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoSnapshotAddOn
            /// </summary>
            public AutoSnapshotAddOn AutoSnapshotAddOnRequest { get; set; }
        }

        public class AutoSnapshotAddOn
        {
            /// <summary>
            /// SnapshotTimeOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-autosnapshotaddon.html#cfn-lightsail-disk-autosnapshotaddon-snapshottimeofday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotTimeOfDay { get; set; }
        }

        public class Location
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-location.html#cfn-lightsail-disk-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disk-location.html#cfn-lightsail-disk-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
        }
    }
}