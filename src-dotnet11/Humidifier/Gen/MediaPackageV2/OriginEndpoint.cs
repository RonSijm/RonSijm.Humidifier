namespace Humidifier.MediaPackageV2
{
    using global::System.Collections.Generic;
    using OriginEndpointTypes;

    public class OriginEndpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfMediaPackageV2OriginEndpointTypesMssManifestConfigurationMssManifests, IHaveDescription, IHaveListOfMediaPackageV2OriginEndpointTypesLowLatencyHlsManifestConfigurationLowLatencyHlsManifests, IHaveContainerType, IHaveMediaPackageV2OriginEndpointTypesForceEndpointErrorConfigurationForceEndpointErrorConfiguration, IHaveListOfMediaPackageV2OriginEndpointTypesHlsManifestConfigurationHlsManifests, IHaveListOfMediaPackageV2OriginEndpointTypesDashManifestConfigurationDashManifests, IHaveMediaPackageV2OriginEndpointTypesSegmentSegment, IHaveChannelName, IHaveUriSeparator, IHaveOriginEndpointName, IHaveChannelGroupName, IHaveStreamNameOutputMode, IHaveStartoverWindowSeconds_Integer
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string LowLatencyHlsManifestUrls =  "LowLatencyHlsManifestUrls" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string MssManifestUrls =  "MssManifestUrls" ;
            public static string Arn =  "Arn" ;
            public static string HlsManifestUrls =  "HlsManifestUrls" ;
            public static string DashManifestUrls =  "DashManifestUrls" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackageV2.OriginEndpoint; }
        /// <summary>
        /// MssManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-mssmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MssManifestConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration>, IReadOnlyList<Union<Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration, BaseFunction>>, BaseFunction>? MssManifests { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// LowLatencyHlsManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LowLatencyHlsManifestConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsManifestConfiguration>, IReadOnlyList<Union<Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsManifestConfiguration, BaseFunction>>, BaseFunction>? LowLatencyHlsManifests { get; set; }

        /// <summary>
        /// ContainerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-containertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContainerType { get; set; }
        /// <summary>
        /// ForceEndpointErrorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-forceendpointerrorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ForceEndpointErrorConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration, BaseFunction>? ForceEndpointErrorConfiguration { get; set; }
        /// <summary>
        /// HlsManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-hlsmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HlsManifestConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaPackageV2.OriginEndpointTypes.HlsManifestConfiguration>, IReadOnlyList<Union<Humidifier.MediaPackageV2.OriginEndpointTypes.HlsManifestConfiguration, BaseFunction>>, BaseFunction>? HlsManifests { get; set; }
        /// <summary>
        /// DashManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-dashmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DashManifestConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaPackageV2.OriginEndpointTypes.DashManifestConfiguration>, IReadOnlyList<Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashManifestConfiguration, BaseFunction>>, BaseFunction>? DashManifests { get; set; }
        /// <summary>
        /// Segment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-segment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Segment
        /// </summary>
        public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.Segment, BaseFunction>? Segment { get; set; }

        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelName { get; set; }
        /// <summary>
        /// UriSeparator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-uriseparator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UriSeparator { get; set; }
        public Union<string, BaseFunction>? OriginEndpointName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelGroupName { get; set; }
        /// <summary>
        /// StreamNameOutputMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-streamnameoutputmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StreamNameOutputMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// StartoverWindowSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-startoverwindowseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? StartoverWindowSeconds { get; set; }
    }

    namespace OriginEndpointTypes
    {
        public class ContentKeyPeriodConfiguration : Humidifier.Base.BaseSubResource, IHaveContentKeyPeriodTiming
        {
            /// <summary>
            /// ContentKeyPeriodTiming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-contentkeyperiodconfiguration.html#cfn-mediapackagev2-originendpoint-contentkeyperiodconfiguration-contentkeyperiodtiming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentKeyPeriodTiming { get; set; }
        }

        public class DashAvailabilityStartTimeConfiguration : Humidifier.Base.BaseSubResource, IHaveFixedAvailabilityStartTime
        {
            /// <summary>
            /// FixedAvailabilityStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashavailabilitystarttimeconfiguration.html#cfn-mediapackagev2-originendpoint-dashavailabilitystarttimeconfiguration-fixedavailabilitystarttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FixedAvailabilityStartTime { get; set; }
        }

        public class DashBaseUrl : Humidifier.Base.BaseSubResource, IHaveServiceLocation, IHaveDvbWeight_Integer, IHaveDvbPriority_Integer, IHaveUrl
        {
            /// <summary>
            /// ServiceLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashbaseurl.html#cfn-mediapackagev2-originendpoint-dashbaseurl-servicelocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceLocation { get; set; }
            /// <summary>
            /// DvbWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashbaseurl.html#cfn-mediapackagev2-originendpoint-dashbaseurl-dvbweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DvbWeight { get; set; }
            /// <summary>
            /// DvbPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashbaseurl.html#cfn-mediapackagev2-originendpoint-dashbaseurl-dvbpriority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DvbPriority { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashbaseurl.html#cfn-mediapackagev2-originendpoint-dashbaseurl-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class DashDvbFontDownload : Humidifier.Base.BaseSubResource, IHaveFontFamily, IHaveUrl, IHaveMimeType
        {
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbfontdownload.html#cfn-mediapackagev2-originendpoint-dashdvbfontdownload-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontFamily { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbfontdownload.html#cfn-mediapackagev2-originendpoint-dashdvbfontdownload-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// MimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbfontdownload.html#cfn-mediapackagev2-originendpoint-dashdvbfontdownload-mimetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MimeType { get; set; }
        }

        public class DashDvbMetricsReporting : Humidifier.Base.BaseSubResource, IHaveReportingUrl, IHaveProbability_Integer
        {
            /// <summary>
            /// ReportingUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbmetricsreporting.html#cfn-mediapackagev2-originendpoint-dashdvbmetricsreporting-reportingurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReportingUrl { get; set; }
            /// <summary>
            /// Probability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbmetricsreporting.html#cfn-mediapackagev2-originendpoint-dashdvbmetricsreporting-probability
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Probability { get; set; }
        }

        public class DashDvbSettings : Humidifier.Base.BaseSubResource, IHaveMediaPackageV2OriginEndpointTypesDashDvbFontDownloadFontDownload, IHaveListOfMediaPackageV2OriginEndpointTypesDashDvbMetricsReportingErrorMetrics
        {
            /// <summary>
            /// FontDownload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbsettings.html#cfn-mediapackagev2-originendpoint-dashdvbsettings-fontdownload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashDvbFontDownload
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbFontDownload, BaseFunction>? FontDownload { get; set; }
            /// <summary>
            /// ErrorMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashdvbsettings.html#cfn-mediapackagev2-originendpoint-dashdvbsettings-errormetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DashDvbMetricsReporting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbMetricsReporting>, IReadOnlyList<Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbMetricsReporting, BaseFunction>>, BaseFunction>? ErrorMetrics { get; set; }
        }

        public class DashManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Integer, IHaveDrmSignaling, IHaveCompactness, IHaveMediaPackageV2OriginEndpointTypesDashProgramInformationProgramInformation, IHaveAudioTimelinePattern, IHaveMediaPackageV2OriginEndpointTypesFilterConfigurationFilterConfiguration, IHaveUriPathType, IHaveSegmentTemplateFormat, IHaveListOfMediaPackageV2OriginEndpointTypesDashBaseUrlBaseUrls, IHaveMediaPackageV2OriginEndpointTypesDashAvailabilityStartTimeConfigurationAvailabilityStartTimeConfiguration, IHaveManifestName, IHaveStringListOfPeriodTriggers, IHaveSuggestedPresentationDelaySeconds_Integer, IHaveMediaPackageV2OriginEndpointTypesDashUtcTimingUtcTiming, IHaveMediaPackageV2OriginEndpointTypesDashSubtitleConfigurationSubtitleConfiguration, IHaveMinBufferTimeSeconds_Integer, IHaveStringListOfProfiles, IHaveMediaPackageV2OriginEndpointTypesDashDvbSettingsDvbSettings, IHaveMinUpdatePeriodSeconds_Integer, IHaveMediaPackageV2OriginEndpointTypesScteDashScteDash
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// DrmSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-drmsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrmSignaling { get; set; }
            /// <summary>
            /// Compactness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-compactness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Compactness { get; set; }
            /// <summary>
            /// ProgramInformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-programinformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashProgramInformation
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashProgramInformation, BaseFunction>? ProgramInformation { get; set; }
            /// <summary>
            /// AudioTimelinePattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-audiotimelinepattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioTimelinePattern { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
            /// <summary>
            /// UriPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-uripathtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UriPathType { get; set; }
            /// <summary>
            /// SegmentTemplateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-segmenttemplateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentTemplateFormat { get; set; }
            /// <summary>
            /// BaseUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-baseurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DashBaseUrl
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaPackageV2.OriginEndpointTypes.DashBaseUrl>, IReadOnlyList<Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashBaseUrl, BaseFunction>>, BaseFunction>? BaseUrls { get; set; }
            /// <summary>
            /// AvailabilityStartTimeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-availabilitystarttimeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashAvailabilityStartTimeConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashAvailabilityStartTimeConfiguration, BaseFunction>? AvailabilityStartTimeConfiguration { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// PeriodTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-periodtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PeriodTriggers { get; set; }
            /// <summary>
            /// SuggestedPresentationDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-suggestedpresentationdelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SuggestedPresentationDelaySeconds { get; set; }
            /// <summary>
            /// UtcTiming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-utctiming
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashUtcTiming
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming, BaseFunction>? UtcTiming { get; set; }
            /// <summary>
            /// SubtitleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-subtitleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashSubtitleConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashSubtitleConfiguration, BaseFunction>? SubtitleConfiguration { get; set; }
            /// <summary>
            /// MinBufferTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-minbuffertimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinBufferTimeSeconds { get; set; }
            /// <summary>
            /// Profiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-profiles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Profiles { get; set; }
            /// <summary>
            /// DvbSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-dvbsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashDvbSettings
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashDvbSettings, BaseFunction>? DvbSettings { get; set; }
            /// <summary>
            /// MinUpdatePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-minupdateperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinUpdatePeriodSeconds { get; set; }
            /// <summary>
            /// ScteDash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-sctedash
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScteDash
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash, BaseFunction>? ScteDash { get; set; }
        }

        public class DashProgramInformation : Humidifier.Base.BaseSubResource, IHaveCopyright, IHaveLanguageCode, IHaveTitle, IHaveMoreInformationUrl, IHaveSource
        {
            /// <summary>
            /// Copyright
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashprograminformation.html#cfn-mediapackagev2-originendpoint-dashprograminformation-copyright
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Copyright { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashprograminformation.html#cfn-mediapackagev2-originendpoint-dashprograminformation-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashprograminformation.html#cfn-mediapackagev2-originendpoint-dashprograminformation-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// MoreInformationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashprograminformation.html#cfn-mediapackagev2-originendpoint-dashprograminformation-moreinformationurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MoreInformationUrl { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashprograminformation.html#cfn-mediapackagev2-originendpoint-dashprograminformation-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class DashSubtitleConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaPackageV2OriginEndpointTypesDashTtmlConfigurationTtmlConfiguration
        {
            /// <summary>
            /// TtmlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashsubtitleconfiguration.html#cfn-mediapackagev2-originendpoint-dashsubtitleconfiguration-ttmlconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashTtmlConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration, BaseFunction>? TtmlConfiguration { get; set; }
        }

        public class DashTtmlConfiguration : Humidifier.Base.BaseSubResource, IHaveTtmlProfile
        {
            /// <summary>
            /// TtmlProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashttmlconfiguration.html#cfn-mediapackagev2-originendpoint-dashttmlconfiguration-ttmlprofile
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TtmlProfile { get; set; }
        }

        public class DashUtcTiming : Humidifier.Base.BaseSubResource, IHaveTimingMode, IHaveTimingSource
        {
            /// <summary>
            /// TimingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashutctiming.html#cfn-mediapackagev2-originendpoint-dashutctiming-timingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimingMode { get; set; }
            /// <summary>
            /// TimingSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashutctiming.html#cfn-mediapackagev2-originendpoint-dashutctiming-timingsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimingSource { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveKeyRotationIntervalSeconds_Integer, IHaveCmafExcludeSegmentDrmMetadata_Boolean, IHaveConstantInitializationVector, IHaveMediaPackageV2OriginEndpointTypesSpekeKeyProviderSpekeKeyProvider, IHaveMediaPackageV2OriginEndpointTypesEncryptionMethodEncryptionMethod
        {
            /// <summary>
            /// KeyRotationIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-keyrotationintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeyRotationIntervalSeconds { get; set; }
            /// <summary>
            /// CmafExcludeSegmentDrmMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-cmafexcludesegmentdrmmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CmafExcludeSegmentDrmMetadata { get; set; }
            /// <summary>
            /// ConstantInitializationVector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-constantinitializationvector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantInitializationVector { get; set; }
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider, BaseFunction>? SpekeKeyProvider { get; set; }
            /// <summary>
            /// EncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-encryptionmethod
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EncryptionMethod
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod, BaseFunction>? EncryptionMethod { get; set; }
        }

        public class EncryptionContractConfiguration : Humidifier.Base.BaseSubResource, IHavePresetSpeke20Audio, IHavePresetSpeke20Video
        {
            /// <summary>
            /// PresetSpeke20Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptioncontractconfiguration.html#cfn-mediapackagev2-originendpoint-encryptioncontractconfiguration-presetspeke20audio
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PresetSpeke20Audio { get; set; }
            /// <summary>
            /// PresetSpeke20Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptioncontractconfiguration.html#cfn-mediapackagev2-originendpoint-encryptioncontractconfiguration-presetspeke20video
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PresetSpeke20Video { get; set; }
        }

        public class EncryptionMethod : Humidifier.Base.BaseSubResource, IHaveIsmEncryptionMethod, IHaveCmafEncryptionMethod, IHaveTsEncryptionMethod
        {
            /// <summary>
            /// IsmEncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptionmethod.html#cfn-mediapackagev2-originendpoint-encryptionmethod-ismencryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsmEncryptionMethod { get; set; }
            /// <summary>
            /// CmafEncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptionmethod.html#cfn-mediapackagev2-originendpoint-encryptionmethod-cmafencryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CmafEncryptionMethod { get; set; }
            /// <summary>
            /// TsEncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptionmethod.html#cfn-mediapackagev2-originendpoint-encryptionmethod-tsencryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TsEncryptionMethod { get; set; }
        }

        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveStart, IHaveDrmSettings, IHaveEnd, IHaveTimeDelaySeconds_Integer, IHaveClipStartTime, IHaveMediaPackageV2OriginEndpointTypesMultiviewFilterConfigurationMultiview, IHaveManifestFilter
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// DrmSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-drmsettings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrmSettings { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
            /// <summary>
            /// TimeDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-timedelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeDelaySeconds { get; set; }
            /// <summary>
            /// ClipStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-clipstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClipStartTime { get; set; }
            /// <summary>
            /// Multiview
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-multiview
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiviewFilterConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration, BaseFunction>? Multiview { get; set; }
            /// <summary>
            /// ManifestFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-manifestfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestFilter { get; set; }
        }

        public class ForceEndpointErrorConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfEndpointErrorConditions
        {
            /// <summary>
            /// EndpointErrorConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-forceendpointerrorconfiguration.html#cfn-mediapackagev2-originendpoint-forceendpointerrorconfiguration-endpointerrorconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EndpointErrorConditions { get; set; }
        }

        public class HlsManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Integer, IHaveManifestName, IHaveProgramDateTimeIntervalSeconds_Integer, IHaveChildManifestName, IHaveMediaPackageV2OriginEndpointTypesScteHlsScteHls, IHaveMediaPackageV2OriginEndpointTypesFilterConfigurationFilterConfiguration, IHaveUriPathType, IHaveUrlEncodeChildManifest_Boolean, IHaveUrl, IHaveMediaPackageV2OriginEndpointTypesStartTagStartTag
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// ChildManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-childmanifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChildManifestName { get; set; }
            /// <summary>
            /// ScteHls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-sctehls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScteHls
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls, BaseFunction>? ScteHls { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
            /// <summary>
            /// UriPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-uripathtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UriPathType { get; set; }
            /// <summary>
            /// UrlEncodeChildManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-urlencodechildmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UrlEncodeChildManifest { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// StartTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-starttag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StartTag
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag, BaseFunction>? StartTag { get; set; }
        }

        public class LowLatencyHlsFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveStart, IHaveDrmSettings, IHaveEnd, IHaveTimeDelaySeconds_Integer, IHaveClipStartTime, IHaveManifestFilter
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// DrmSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration-drmsettings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrmSettings { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
            /// <summary>
            /// TimeDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration-timedelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeDelaySeconds { get; set; }
            /// <summary>
            /// ClipStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration-clipstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClipStartTime { get; set; }
            /// <summary>
            /// ManifestFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsfilterconfiguration-manifestfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestFilter { get; set; }
        }

        public class LowLatencyHlsManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Integer, IHaveManifestName, IHaveProgramDateTimeIntervalSeconds_Integer, IHaveChildManifestName, IHaveMediaPackageV2OriginEndpointTypesScteHlsScteHls, IHaveMediaPackageV2OriginEndpointTypesLowLatencyHlsFilterConfigurationFilterConfiguration, IHaveUriPathType, IHaveUrlEncodeChildManifest_Boolean, IHaveUrl, IHaveMediaPackageV2OriginEndpointTypesStartTagStartTag
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// ChildManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-childmanifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChildManifestName { get; set; }
            /// <summary>
            /// ScteHls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-sctehls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScteHls
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls, BaseFunction>? ScteHls { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LowLatencyHlsFilterConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsFilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
            /// <summary>
            /// UriPathType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-uripathtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UriPathType { get; set; }
            /// <summary>
            /// UrlEncodeChildManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-urlencodechildmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UrlEncodeChildManifest { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// StartTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-starttag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StartTag
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag, BaseFunction>? StartTag { get; set; }
        }

        public class MssFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveStart, IHaveDrmSettings, IHaveEnd, IHaveTimeDelaySeconds_Integer, IHaveClipStartTime, IHaveManifestFilter
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssfilterconfiguration.html#cfn-mediapackagev2-originendpoint-mssfilterconfiguration-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// DrmSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssfilterconfiguration.html#cfn-mediapackagev2-originendpoint-mssfilterconfiguration-drmsettings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrmSettings { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssfilterconfiguration.html#cfn-mediapackagev2-originendpoint-mssfilterconfiguration-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
            /// <summary>
            /// TimeDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssfilterconfiguration.html#cfn-mediapackagev2-originendpoint-mssfilterconfiguration-timedelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeDelaySeconds { get; set; }
            /// <summary>
            /// ClipStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssfilterconfiguration.html#cfn-mediapackagev2-originendpoint-mssfilterconfiguration-clipstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClipStartTime { get; set; }
            /// <summary>
            /// ManifestFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssfilterconfiguration.html#cfn-mediapackagev2-originendpoint-mssfilterconfiguration-manifestfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestFilter { get; set; }
        }

        public class MssManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Integer, IHaveManifestName, IHaveManifestLayout, IHaveMediaPackageV2OriginEndpointTypesMssFilterConfigurationFilterConfiguration
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-mssmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-mssmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// ManifestLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-mssmanifestconfiguration-manifestlayout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestLayout { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-mssmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-mssmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MssFilterConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        }

        public class MultiviewFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveLayout, IHaveStringListOfSources
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-multiviewfilterconfiguration.html#cfn-mediapackagev2-originendpoint-multiviewfilterconfiguration-layout
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Layout { get; set; }
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-multiviewfilterconfiguration.html#cfn-mediapackagev2-originendpoint-multiviewfilterconfiguration-sources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Sources { get; set; }
        }

        public class Scte : Humidifier.Base.BaseSubResource, IHaveStringListOfCustomAdTypes, IHaveScteInSegments, IHaveStringListOfScteFilter
        {
            /// <summary>
            /// CustomAdTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-scte.html#cfn-mediapackagev2-originendpoint-scte-customadtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CustomAdTypes { get; set; }
            /// <summary>
            /// ScteInSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-scte.html#cfn-mediapackagev2-originendpoint-scte-scteinsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScteInSegments { get; set; }
            /// <summary>
            /// ScteFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-scte.html#cfn-mediapackagev2-originendpoint-scte-sctefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ScteFilter { get; set; }
        }

        public class ScteDash : Humidifier.Base.BaseSubResource, IHaveAdMarkerDash, IHaveScteInManifests
        {
            /// <summary>
            /// AdMarkerDash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-sctedash.html#cfn-mediapackagev2-originendpoint-sctedash-admarkerdash
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdMarkerDash { get; set; }
            /// <summary>
            /// ScteInManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-sctedash.html#cfn-mediapackagev2-originendpoint-sctedash-scteinmanifests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScteInManifests { get; set; }
        }

        public class ScteHls : Humidifier.Base.BaseSubResource, IHaveAdMarkerHls, IHaveScteInManifests
        {
            /// <summary>
            /// AdMarkerHls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-sctehls.html#cfn-mediapackagev2-originendpoint-sctehls-admarkerhls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdMarkerHls { get; set; }
            /// <summary>
            /// ScteInManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-sctehls.html#cfn-mediapackagev2-originendpoint-sctehls-scteinmanifests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScteInManifests { get; set; }
        }

        public class Segment : Humidifier.Base.BaseSubResource, IHaveSegmentName, IHaveTsUseAudioRenditionGroup_Boolean, IHaveIncludeIframeOnlyStreams_Boolean, IHaveMediaPackageV2OriginEndpointTypesScteScte, IHaveTsIncludeDvbSubtitles_Boolean, IHaveSegmentDurationSeconds_Integer, IHaveMediaPackageV2OriginEndpointTypesEncryptionEncryption, IHaveOutputTimestampMode
        {
            /// <summary>
            /// SegmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentName { get; set; }
            /// <summary>
            /// TsUseAudioRenditionGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-tsuseaudiorenditiongroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TsUseAudioRenditionGroup { get; set; }
            /// <summary>
            /// IncludeIframeOnlyStreams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-includeiframeonlystreams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeIframeOnlyStreams { get; set; }
            /// <summary>
            /// Scte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-scte
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte, BaseFunction>? Scte { get; set; }
            /// <summary>
            /// TsIncludeDvbSubtitles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-tsincludedvbsubtitles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TsIncludeDvbSubtitles { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// OutputTimestampMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-outputtimestampmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputTimestampMode { get; set; }
        }

        public class SpekeKeyProvider : Humidifier.Base.BaseSubResource, IHaveStringListOfDrmSystems, IHaveResourceId, IHaveMediaPackageV2OriginEndpointTypesEncryptionContractConfigurationEncryptionContractConfiguration, IHaveSpekeVersion, IHaveRoleArn, IHaveUrl, IHaveCertificateArn, IHaveMediaPackageV2OriginEndpointTypesContentKeyPeriodConfigurationContentKeyPeriodConfiguration
        {
            /// <summary>
            /// DrmSystems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-drmsystems
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DrmSystems { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-resourceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// EncryptionContractConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-encryptioncontractconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EncryptionContractConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration, BaseFunction>? EncryptionContractConfiguration { get; set; }
            /// <summary>
            /// SpekeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-spekeversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpekeVersion { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
            /// <summary>
            /// ContentKeyPeriodConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-contentkeyperiodconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContentKeyPeriodConfiguration
            /// </summary>
            public Union<Humidifier.MediaPackageV2.OriginEndpointTypes.ContentKeyPeriodConfiguration, BaseFunction>? ContentKeyPeriodConfiguration { get; set; }
        }

        public class StartTag : Humidifier.Base.BaseSubResource, IHaveTimeOffset_Double, IHavePrecise_Boolean
        {
            /// <summary>
            /// TimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-starttag.html#cfn-mediapackagev2-originendpoint-starttag-timeoffset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TimeOffset { get; set; }
            /// <summary>
            /// Precise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-starttag.html#cfn-mediapackagev2-originendpoint-starttag-precise
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Precise { get; set; }
        }
    }
}