namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using InstanceSnapshotTypes;

    public class InstanceSnapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInstanceName, IHaveInstanceSnapshotName
    {
        public class Attributes
        {
            public static string SizeInGb =  "SizeInGb" ;
            public static string SupportCode =  "SupportCode" ;
            public static string State =  "State" ;
            public static string FromInstanceName =  "FromInstanceName" ;
            public static string ResourceType =  "ResourceType" ;
            public static string IsFromAutoSnapshot =  "IsFromAutoSnapshot" ;
            public static string FromInstanceArn =  "FromInstanceArn" ;
            public static string Arn =  "Arn" ;
            public static string Location =  "Location" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.InstanceSnapshot; }

        /// <summary>
        /// InstanceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instancesnapshot.html#cfn-lightsail-instancesnapshot-instancename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceName { get; set; }
        public Union<string, BaseFunction>? InstanceSnapshotName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instancesnapshot.html#cfn-lightsail-instancesnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InstanceSnapshotTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instancesnapshot-location.html#cfn-lightsail-instancesnapshot-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instancesnapshot-location.html#cfn-lightsail-instancesnapshot-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}