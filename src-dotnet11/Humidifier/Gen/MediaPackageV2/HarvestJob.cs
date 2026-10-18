namespace Humidifier.MediaPackageV2
{
    using global::System.Collections.Generic;
    using HarvestJobTypes;

    public class HarvestJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaPackageV2HarvestJobTypesDestinationDestination, IHaveHarvestJobName, IHaveDescription, IHaveMediaPackageV2HarvestJobTypesHarvesterScheduleConfigurationScheduleConfiguration, IHaveChannelName, IHaveOriginEndpointName, IHaveChannelGroupName, IHaveMediaPackageV2HarvestJobTypesHarvestedManifestsHarvestedManifests
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
        public Union<Humidifier.MediaPackageV2.HarvestJobTypes.Destination, BaseFunction>? Destination { get; set; }
        public Union<string, BaseFunction>? HarvestJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ScheduleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-scheduleconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HarvesterScheduleConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.MediaPackageV2.HarvestJobTypes.HarvesterScheduleConfiguration, BaseFunction>? ScheduleConfiguration { get; set; }

        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelName { get; set; }

        /// <summary>
        /// OriginEndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-originendpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OriginEndpointName { get; set; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelGroupName { get; set; }

        /// <summary>
        /// HarvestedManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-harvestedmanifests
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HarvestedManifests
        /// </summary>
        [Required]
        public Union<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests, BaseFunction>? HarvestedManifests { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-harvestjob.html#cfn-mediapackagev2-harvestjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace HarvestJobTypes
    {
        public class Destination : Humidifier.Base.BaseSubResource, IHaveMediaPackageV2HarvestJobTypesS3DestinationConfigS3Destination
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-destination.html#cfn-mediapackagev2-harvestjob-destination-s3destination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DestinationConfig
            /// </summary>
            public Union<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig, BaseFunction>? S3Destination { get; set; }
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
            public Union<string, BaseFunction>? ManifestName { get; set; }
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
            public Union<string, BaseFunction>? ManifestName { get; set; }
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
            public Union<string, BaseFunction>? ManifestName { get; set; }
        }

        public class HarvestedManifests : Humidifier.Base.BaseSubResource, IHaveListOfMediaPackageV2HarvestJobTypesHarvestedLowLatencyHlsManifestLowLatencyHlsManifests, IHaveListOfMediaPackageV2HarvestJobTypesHarvestedHlsManifestHlsManifests, IHaveListOfMediaPackageV2HarvestJobTypesHarvestedDashManifestDashManifests
        {
            /// <summary>
            /// LowLatencyHlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedmanifests.html#cfn-mediapackagev2-harvestjob-harvestedmanifests-lowlatencyhlsmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HarvestedLowLatencyHlsManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedLowLatencyHlsManifest>, IReadOnlyList<Union<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedLowLatencyHlsManifest, BaseFunction>>, BaseFunction>? LowLatencyHlsManifests { get; set; }
            /// <summary>
            /// HlsManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedmanifests.html#cfn-mediapackagev2-harvestjob-harvestedmanifests-hlsmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HarvestedHlsManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedHlsManifest>, IReadOnlyList<Union<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedHlsManifest, BaseFunction>>, BaseFunction>? HlsManifests { get; set; }
            /// <summary>
            /// DashManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvestedmanifests.html#cfn-mediapackagev2-harvestjob-harvestedmanifests-dashmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HarvestedDashManifest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedDashManifest>, IReadOnlyList<Union<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedDashManifest, BaseFunction>>, BaseFunction>? DashManifests { get; set; }
        }

        public class HarvesterScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvesterscheduleconfiguration.html#cfn-mediapackagev2-harvestjob-harvesterscheduleconfiguration-endtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-harvesterscheduleconfiguration.html#cfn-mediapackagev2-harvestjob-harvesterscheduleconfiguration-starttime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class S3DestinationConfig : Humidifier.Base.BaseSubResource, IHaveDestinationPath, IHaveBucketName
        {
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-s3destinationconfig.html#cfn-mediapackagev2-harvestjob-s3destinationconfig-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-harvestjob-s3destinationconfig.html#cfn-mediapackagev2-harvestjob-s3destinationconfig-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }
    }
}