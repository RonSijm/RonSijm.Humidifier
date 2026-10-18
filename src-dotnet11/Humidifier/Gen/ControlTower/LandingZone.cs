namespace Humidifier.ControlTower
{
    using global::System.Collections.Generic;

    public class LandingZone : Humidifier.Base.BaseResource, IHaveTags, IHaveVersion, IHaveStringListOfRemediationTypes, IHaveManifest_Json
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
        public Union<string, BaseFunction>? Version { get; set; }
        /// <summary>
        /// RemediationTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-landingzone.html#cfn-controltower-landingzone-remediationtypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RemediationTypes { get; set; }

        /// <summary>
        /// Manifest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-landingzone.html#cfn-controltower-landingzone-manifest
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Manifest { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-controltower-landingzone.html#cfn-controltower-landingzone-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}