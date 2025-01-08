namespace Humidifier.MediaPackageV2
{
    using System.Collections.Generic;
    using OriginEndpointTypes;

    public class OriginEndpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveChannelName, IHaveChannelGroupName, IHaveContainerType, IHaveStartoverWindowSeconds, IHaveOriginEndpointName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string LowLatencyHlsManifestUrls =  "LowLatencyHlsManifestUrls" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string HlsManifestUrls =  "HlsManifestUrls" ;
            public static string DashManifestUrls =  "DashManifestUrls" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackageV2.OriginEndpoint; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChannelName { get; set; }
        /// <summary>
        /// LowLatencyHlsManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LowLatencyHlsManifestConfiguration
        /// </summary>
        public List<Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsManifestConfiguration> LowLatencyHlsManifests { get; set; }

        /// <summary>
        /// ContainerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-containertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContainerType { get; set; }
        /// <summary>
        /// ForceEndpointErrorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-forceendpointerrorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ForceEndpointErrorConfiguration
        /// </summary>
        public Humidifier.MediaPackageV2.OriginEndpointTypes.ForceEndpointErrorConfiguration ForceEndpointErrorConfiguration { get; set; }
        public dynamic OriginEndpointName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// HlsManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-hlsmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HlsManifestConfiguration
        /// </summary>
        public List<Humidifier.MediaPackageV2.OriginEndpointTypes.HlsManifestConfiguration> HlsManifests { get; set; }

        /// <summary>
        /// ChannelGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-channelgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChannelGroupName { get; set; }
        /// <summary>
        /// DashManifests
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-dashmanifests
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DashManifestConfiguration
        /// </summary>
        public List<Humidifier.MediaPackageV2.OriginEndpointTypes.DashManifestConfiguration> DashManifests { get; set; }
        /// <summary>
        /// Segment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-segment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Segment
        /// </summary>
        public Humidifier.MediaPackageV2.OriginEndpointTypes.Segment Segment { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// StartoverWindowSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackagev2-originendpoint.html#cfn-mediapackagev2-originendpoint-startoverwindowseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic StartoverWindowSeconds { get; set; }
    }

    namespace OriginEndpointTypes
    {
        public class DashManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestName, IHaveManifestWindowSeconds, IHaveMinBufferTimeSeconds, IHaveSegmentTemplateFormat, IHavePeriodTriggers, IHaveSuggestedPresentationDelaySeconds, IHaveMinUpdatePeriodSeconds, IHaveMediaPackageV2OriginEndpointTypesFilterConfigurationFilterConfiguration
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ManifestWindowSeconds { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
            /// <summary>
            /// PeriodTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-periodtriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PeriodTriggers { get; set; }
            /// <summary>
            /// DrmSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-drmsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DrmSignaling { get; set; }
            /// <summary>
            /// SuggestedPresentationDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-suggestedpresentationdelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SuggestedPresentationDelaySeconds { get; set; }
            /// <summary>
            /// UtcTiming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-utctiming
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashUtcTiming
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming UtcTiming { get; set; }
            /// <summary>
            /// MinBufferTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-minbuffertimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinBufferTimeSeconds { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterConfiguration
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration FilterConfiguration { get; set; }
            /// <summary>
            /// MinUpdatePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-minupdateperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinUpdatePeriodSeconds { get; set; }
            /// <summary>
            /// SegmentTemplateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-segmenttemplateformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentTemplateFormat { get; set; }
            /// <summary>
            /// ScteDash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-dashmanifestconfiguration-sctedash
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScteDash
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash ScteDash { get; set; }
        }

        public class DashUtcTiming : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TimingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashutctiming.html#cfn-mediapackagev2-originendpoint-dashutctiming-timingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimingMode { get; set; }
            /// <summary>
            /// TimingSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-dashutctiming.html#cfn-mediapackagev2-originendpoint-dashutctiming-timingsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimingSource { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveConstantInitializationVector, IHaveKeyRotationIntervalSeconds
        {
            /// <summary>
            /// KeyRotationIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-keyrotationintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic KeyRotationIntervalSeconds { get; set; }
            /// <summary>
            /// ConstantInitializationVector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-constantinitializationvector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConstantInitializationVector { get; set; }
            /// <summary>
            /// SpekeKeyProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-spekekeyprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpekeKeyProvider
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider SpekeKeyProvider { get; set; }
            /// <summary>
            /// EncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryption.html#cfn-mediapackagev2-originendpoint-encryption-encryptionmethod
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EncryptionMethod
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod EncryptionMethod { get; set; }
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
            public dynamic PresetSpeke20Audio { get; set; }
            /// <summary>
            /// PresetSpeke20Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptioncontractconfiguration.html#cfn-mediapackagev2-originendpoint-encryptioncontractconfiguration-presetspeke20video
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PresetSpeke20Video { get; set; }
        }

        public class EncryptionMethod : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CmafEncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptionmethod.html#cfn-mediapackagev2-originendpoint-encryptionmethod-cmafencryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CmafEncryptionMethod { get; set; }
            /// <summary>
            /// TsEncryptionMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-encryptionmethod.html#cfn-mediapackagev2-originendpoint-encryptionmethod-tsencryptionmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TsEncryptionMethod { get; set; }
        }

        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveEnd, IHaveStart, IHaveTimeDelaySeconds
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic End { get; set; }
            /// <summary>
            /// TimeDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-timedelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeDelaySeconds { get; set; }
            /// <summary>
            /// ClipStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-clipstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClipStartTime { get; set; }
            /// <summary>
            /// ManifestFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-filterconfiguration.html#cfn-mediapackagev2-originendpoint-filterconfiguration-manifestfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestFilter { get; set; }
        }

        public class ForceEndpointErrorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EndpointErrorConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-forceendpointerrorconfiguration.html#cfn-mediapackagev2-originendpoint-forceendpointerrorconfiguration-endpointerrorconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EndpointErrorConditions { get; set; }
        }

        public class HlsManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveManifestName, IHaveManifestWindowSeconds, IHaveProgramDateTimeIntervalSeconds, IHaveMediaPackageV2OriginEndpointTypesFilterConfigurationFilterConfiguration, IHaveChildManifestName, IHaveMediaPackageV2OriginEndpointTypesScteHlsScteHls, IHaveMediaPackageV2OriginEndpointTypesStartTagStartTag
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ManifestWindowSeconds { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// ChildManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-childmanifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChildManifestName { get; set; }
            /// <summary>
            /// ScteHls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-sctehls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScteHls
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls ScteHls { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterConfiguration
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration FilterConfiguration { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
            /// <summary>
            /// StartTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-hlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-hlsmanifestconfiguration-starttag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StartTag
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag StartTag { get; set; }
        }

        public class LowLatencyHlsManifestConfiguration : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveManifestName, IHaveManifestWindowSeconds, IHaveProgramDateTimeIntervalSeconds, IHaveMediaPackageV2OriginEndpointTypesFilterConfigurationFilterConfiguration, IHaveChildManifestName, IHaveMediaPackageV2OriginEndpointTypesScteHlsScteHls, IHaveMediaPackageV2OriginEndpointTypesStartTagStartTag
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ManifestWindowSeconds { get; set; }
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
            /// <summary>
            /// ProgramDateTimeIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-programdatetimeintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramDateTimeIntervalSeconds { get; set; }
            /// <summary>
            /// ChildManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-childmanifestname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChildManifestName { get; set; }
            /// <summary>
            /// ScteHls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-sctehls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScteHls
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls ScteHls { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterConfiguration
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration FilterConfiguration { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
            /// <summary>
            /// StartTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration.html#cfn-mediapackagev2-originendpoint-lowlatencyhlsmanifestconfiguration-starttag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StartTag
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag StartTag { get; set; }
        }

        public class Scte : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScteFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-scte.html#cfn-mediapackagev2-originendpoint-scte-sctefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ScteFilter { get; set; }
        }

        public class ScteDash : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdMarkerDash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-sctedash.html#cfn-mediapackagev2-originendpoint-sctedash-admarkerdash
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdMarkerDash { get; set; }
        }

        public class ScteHls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdMarkerHls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-sctehls.html#cfn-mediapackagev2-originendpoint-sctehls-admarkerhls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdMarkerHls { get; set; }
        }

        public class Segment : Humidifier.Base.BaseSubResource, IHaveSegmentDurationSeconds, IHaveSegmentName
        {
            /// <summary>
            /// SegmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-segmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentName { get; set; }
            /// <summary>
            /// TsUseAudioRenditionGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-tsuseaudiorenditiongroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic TsUseAudioRenditionGroup { get; set; }
            /// <summary>
            /// IncludeIframeOnlyStreams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-includeiframeonlystreams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeIframeOnlyStreams { get; set; }
            /// <summary>
            /// Scte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-scte
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.Scte Scte { get; set; }
            /// <summary>
            /// TsIncludeDvbSubtitles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-tsincludedvbsubtitles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic TsIncludeDvbSubtitles { get; set; }
            /// <summary>
            /// SegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-segmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SegmentDurationSeconds { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-segment.html#cfn-mediapackagev2-originendpoint-segment-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption Encryption { get; set; }
        }

        public class SpekeKeyProvider : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveUrl, IHaveResourceId
        {
            /// <summary>
            /// DrmSystems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-drmsystems
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DrmSystems { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-resourceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceId { get; set; }
            /// <summary>
            /// EncryptionContractConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-encryptioncontractconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EncryptionContractConfiguration
            /// </summary>
            public Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration EncryptionContractConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-spekekeyprovider.html#cfn-mediapackagev2-originendpoint-spekekeyprovider-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class StartTag : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Precise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-starttag.html#cfn-mediapackagev2-originendpoint-starttag-precise
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Precise { get; set; }
            /// <summary>
            /// TimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackagev2-originendpoint-starttag.html#cfn-mediapackagev2-originendpoint-starttag-timeoffset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TimeOffset { get; set; }
        }
    }
}