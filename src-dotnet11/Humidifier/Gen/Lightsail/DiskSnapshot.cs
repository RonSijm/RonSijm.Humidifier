namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using DiskSnapshotTypes;

    public class DiskSnapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDiskSnapshotName, IHaveDiskName
    {
        public class Attributes
        {
            public static string SizeInGb =  "SizeInGb" ;
            public static string Progress =  "Progress" ;
            public static string DiskSnapshotArn =  "DiskSnapshotArn" ;
            public static string SupportCode =  "SupportCode" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FromDiskName =  "FromDiskName" ;
            public static string ResourceType =  "ResourceType" ;
            public static string IsFromAutoSnapshot =  "IsFromAutoSnapshot" ;
            public static string Location =  "Location" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.DiskSnapshot; }
        public Union<string, BaseFunction>? DiskSnapshotName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DiskName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disksnapshot.html#cfn-lightsail-disksnapshot-diskname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DiskName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-disksnapshot.html#cfn-lightsail-disksnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DiskSnapshotTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disksnapshot-location.html#cfn-lightsail-disksnapshot-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-disksnapshot-location.html#cfn-lightsail-disksnapshot-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}