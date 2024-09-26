namespace Humidifier.ControlTower
{
    using System.Collections.Generic;

    public class LandingZone : Humidifier.Base.BaseResource, IHaveTags, IHaveVersion, IHaveManifest
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LatestAvailableVersion =  "LatestAvailableVersion" ;
            public static string DriftStatus =  "DriftStatus" ;
            public static string Arn =  "Arn" ;
            public static string LandingZoneIdentifier =  "LandingZoneIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.ControlTower.LandingZone; }

        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-landingzone.html#cfn-controltower-landingzone-version
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Version { get; set; }

        /// <summary>
        /// Manifest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-landingzone.html#cfn-controltower-landingzone-manifest
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Manifest { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-landingzone.html#cfn-controltower-landingzone-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}