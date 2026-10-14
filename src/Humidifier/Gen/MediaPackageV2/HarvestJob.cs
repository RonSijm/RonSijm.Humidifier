namespace Humidifier.MediaPackageV2
{
    using global::System.Collections.Generic;
    using HarvestJobTypes;

    public class HarvestJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveChannelName, IHaveChannelGroupName, IHaveOriginEndpointName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackageV2.HarvestJob; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-destination
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Destination
        /// </summary>
        [Required]
        public Humidifier.MediaPackageV2.HarvestJobTypes.Destination Destination { get; set; }
        public dynamic HarvestJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ScheduleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-scheduleconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HarvesterScheduleConfiguration
        /// </summary>
        [Required]
        public Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChannelName { get; set; }

        /// <summary>
        /// OriginEndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-originendpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OriginEndpointName { get; set; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChannelGroupName { get; set; }

        /// <summary>
        /// HarvestedManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-harvestedmanifests
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HarvestedManifests
        /// </summary>
        [Required]
        public Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests HarvestedManifests { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace HarvestJobTypes
    {
        public class Destination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-destination.html#cfn-mediapackagev2-harvestjob-destination-s3destination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DestinationConfig
            /// </summary>
            public Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig S3Destination { get; set; }
        }

        public class HarvestedDashManifest : Humidifier.Base.BaseSubResource, IHaveManifestName
        {
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvesteddashmanifest.html#cfn-mediapackagev2-harvestjob-harvesteddashmanifest-manifestname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
        }

        public class HarvestedHlsManifest : Humidifier.Base.BaseSubResource, IHaveManifestName
        {
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedhlsmanifest.html#cfn-mediapackagev2-harvestjob-harvestedhlsmanifest-manifestname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
        }

        public class HarvestedLowLatencyHlsManifest : Humidifier.Base.BaseSubResource, IHaveManifestName
        {
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedlowlatencyhlsmanifest.html#cfn-mediapackagev2-harvestjob-harvestedlowlatencyhlsmanifest-manifestname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
        }

        public class HarvestedManifests : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LowLatencyHlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedmanifests.html#cfn-mediapackagev2-harvestjob-harvestedmanifests-lowlatencyhlsmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HarvestedLowLatencyHlsManifest
            /// </summary>
            public List<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedLowLatencyHlsManifest> LowLatencyHlsManifests { get; set; }
            /// <summary>
            /// HlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedmanifests.html#cfn-mediapackagev2-harvestjob-harvestedmanifests-hlsmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HarvestedHlsManifest
            /// </summary>
            public List<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedHlsManifest> HlsManifests { get; set; }
            /// <summary>
            /// DashManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedmanifests.html#cfn-mediapackagev2-harvestjob-harvestedmanifests-dashmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HarvestedDashManifest
            /// </summary>
            public List<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedDashManifest> DashManifests { get; set; }
        }

        public class HarvesterScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvesterscheduleconfiguration.html#cfn-mediapackagev2-harvestjob-harvesterscheduleconfiguration-endtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvesterscheduleconfiguration.html#cfn-mediapackagev2-harvestjob-harvesterscheduleconfiguration-starttime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
        }

        public class S3DestinationConfig : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveDestinationPath
        {
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-s3destinationconfig.html#cfn-mediapackagev2-harvestjob-s3destinationconfig-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-s3destinationconfig.html#cfn-mediapackagev2-harvestjob-s3destinationconfig-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
        }
    }
}