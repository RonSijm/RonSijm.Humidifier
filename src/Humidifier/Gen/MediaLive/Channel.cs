namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveRoleArn, IHaveDynamicTags, IHaveLogLevel
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Inputs =  "Inputs" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Channel; }
        /// <summary>
        /// InputAttachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-inputattachments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputAttachment
        /// </summary>
        public List<Humidifier.MediaLive.ChannelTypes.InputAttachment> InputAttachments { get; set; }
        /// <summary>
        /// InputSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-inputspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputSpecification
        /// </summary>
        public Humidifier.MediaLive.ChannelTypes.InputSpecification InputSpecification { get; set; }
        /// <summary>
        /// ChannelClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-channelclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ChannelClass { get; set; }
        /// <summary>
        /// EncoderSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-encodersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncoderSettings
        /// </summary>
        public Humidifier.MediaLive.ChannelTypes.EncoderSettings EncoderSettings { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OutputDestination
        /// </summary>
        public List<Humidifier.MediaLive.ChannelTypes.OutputDestination> Destinations { get; set; }
        /// <summary>
        /// Vpc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-vpc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcOutputSettings
        /// </summary>
        public Humidifier.MediaLive.ChannelTypes.VpcOutputSettings Vpc { get; set; }
        /// <summary>
        /// CdiInputSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-cdiinputspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdiInputSpecification
        /// </summary>
        public Humidifier.MediaLive.ChannelTypes.CdiInputSpecification CdiInputSpecification { get; set; }
        /// <summary>
        /// Maintenance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-maintenance
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceCreateSettings
        /// </summary>
        public Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings Maintenance { get; set; }
        /// <summary>
        /// LogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-loglevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogLevel { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ChannelTypes
    {
        public class AacSettings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveCodingMode, IHaveProfile, IHaveRateControlMode, IHaveSampleRate
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodingMode { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RateControlMode { get; set; }
            /// <summary>
            /// SampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-samplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SampleRate { get; set; }
            /// <summary>
            /// InputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-inputtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputType { get; set; }
            /// <summary>
            /// VbrQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-vbrquality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VbrQuality { get; set; }
            /// <summary>
            /// RawFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-rawformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RawFormat { get; set; }
            /// <summary>
            /// Spec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-spec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Spec { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Bitrate { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Profile { get; set; }
        }

        public class Ac3Settings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveCodingMode, IHaveDialnorm
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodingMode { get; set; }
            /// <summary>
            /// DrcProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-drcprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DrcProfile { get; set; }
            /// <summary>
            /// MetadataControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-metadatacontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataControl { get; set; }
            /// <summary>
            /// Dialnorm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-dialnorm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Dialnorm { get; set; }
            /// <summary>
            /// LfeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-lfefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LfeFilter { get; set; }
            /// <summary>
            /// BitstreamMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-bitstreammode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BitstreamMode { get; set; }
            /// <summary>
            /// AttenuationControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-attenuationcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttenuationControl { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Bitrate { get; set; }
        }

        public class AncillarySourceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceAncillaryChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ancillarysourcesettings.html#cfn-medialive-channel-ancillarysourcesettings-sourceancillarychannelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SourceAncillaryChannelNumber { get; set; }
        }

        public class ArchiveCdnSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ArchiveS3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecdnsettings.html#cfn-medialive-channel-archivecdnsettings-archives3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveS3Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ArchiveS3Settings ArchiveS3Settings { get; set; }
        }

        public class ArchiveContainerSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RawSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecontainersettings.html#cfn-medialive-channel-archivecontainersettings-rawsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RawSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.RawSettings RawSettings { get; set; }
            /// <summary>
            /// M2tsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecontainersettings.html#cfn-medialive-channel-archivecontainersettings-m2tssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2tsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.M2tsSettings M2tsSettings { get; set; }
        }

        public class ArchiveGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
            /// <summary>
            /// ArchiveCdnSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-archivecdnsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveCdnSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ArchiveCdnSettings ArchiveCdnSettings { get; set; }
            /// <summary>
            /// RolloverInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-rolloverinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RolloverInterval { get; set; }
        }

        public class ArchiveOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier
        {
            /// <summary>
            /// Extension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html#cfn-medialive-channel-archiveoutputsettings-extension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Extension { get; set; }
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html#cfn-medialive-channel-archiveoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NameModifier { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html#cfn-medialive-channel-archiveoutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveContainerSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ArchiveContainerSettings ContainerSettings { get; set; }
        }

        public class ArchiveS3Settings : Humidifier.Base.BaseSubResource, IHaveCannedAcl
        {
            /// <summary>
            /// CannedAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archives3settings.html#cfn-medialive-channel-archives3settings-cannedacl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CannedAcl { get; set; }
        }

        public class AribDestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class AribSourceSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class AudioChannelMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiochannelmapping.html#cfn-medialive-channel-audiochannelmapping-outputchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OutputChannel { get; set; }
            /// <summary>
            /// InputChannelLevels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiochannelmapping.html#cfn-medialive-channel-audiochannelmapping-inputchannellevels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputChannelLevel
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.InputChannelLevel> InputChannelLevels { get; set; }
        }

        public class AudioCodecSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Eac3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-eac3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Eac3Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Eac3Settings Eac3Settings { get; set; }
            /// <summary>
            /// Ac3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-ac3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ac3Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Ac3Settings Ac3Settings { get; set; }
            /// <summary>
            /// Mp2Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-mp2settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mp2Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Mp2Settings Mp2Settings { get; set; }
            /// <summary>
            /// Eac3AtmosSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-eac3atmossettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Eac3AtmosSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Eac3AtmosSettings Eac3AtmosSettings { get; set; }
            /// <summary>
            /// PassThroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-passthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PassThroughSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.PassThroughSettings PassThroughSettings { get; set; }
            /// <summary>
            /// WavSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-wavsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WavSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.WavSettings WavSettings { get; set; }
            /// <summary>
            /// AacSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-aacsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AacSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AacSettings AacSettings { get; set; }
        }

        public class AudioDescription : Humidifier.Base.BaseSubResource, IHaveName, IHaveLanguageCode, IHaveStreamName
        {
            /// <summary>
            /// AudioDashRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiodashroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AudioDashRoles { get; set; }
            /// <summary>
            /// LanguageCodeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-languagecodecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCodeControl { get; set; }
            /// <summary>
            /// CodecSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-codecsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioCodecSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioCodecSettings CodecSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// AudioWatermarkingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiowatermarkingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioWatermarkSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioWatermarkSettings AudioWatermarkingSettings { get; set; }
            /// <summary>
            /// AudioNormalizationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audionormalizationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioNormalizationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioNormalizationSettings AudioNormalizationSettings { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// RemixSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-remixsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RemixSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.RemixSettings RemixSettings { get; set; }
            /// <summary>
            /// AudioSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audioselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioSelectorName { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
            /// <summary>
            /// DvbDashAccessibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-dvbdashaccessibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DvbDashAccessibility { get; set; }
            /// <summary>
            /// AudioType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiotype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioType { get; set; }
            /// <summary>
            /// AudioTypeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiotypecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioTypeControl { get; set; }
        }

        public class AudioDolbyEDecode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProgramSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodolbyedecode.html#cfn-medialive-channel-audiodolbyedecode-programselection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProgramSelection { get; set; }
        }

        public class AudioHlsRenditionSelection : Humidifier.Base.BaseSubResource, IHaveName, IHaveGroupId
        {
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiohlsrenditionselection.html#cfn-medialive-channel-audiohlsrenditionselection-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiohlsrenditionselection.html#cfn-medialive-channel-audiohlsrenditionselection-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class AudioLanguageSelection : Humidifier.Base.BaseSubResource, IHaveLanguageCode
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html#cfn-medialive-channel-audiolanguageselection-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// LanguageSelectionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html#cfn-medialive-channel-audiolanguageselection-languageselectionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageSelectionPolicy { get; set; }
        }

        public class AudioNormalizationSettings : Humidifier.Base.BaseSubResource, IHaveAlgorithm
        {
            /// <summary>
            /// TargetLkfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-targetlkfs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetLkfs { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// AlgorithmControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-algorithmcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlgorithmControl { get; set; }
        }

        public class AudioOnlyHlsSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SegmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-segmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentType { get; set; }
            /// <summary>
            /// AudioTrackType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-audiotracktype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioTrackType { get; set; }
            /// <summary>
            /// AudioOnlyImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-audioonlyimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation AudioOnlyImage { get; set; }
            /// <summary>
            /// AudioGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-audiogroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioGroupId { get; set; }
        }

        public class AudioPidSelection : Humidifier.Base.BaseSubResource, IHavePid
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopidselection.html#cfn-medialive-channel-audiopidselection-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid { get; set; }
        }

        public class AudioSelector : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html#cfn-medialive-channel-audioselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSelectorSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioSelectorSettings SelectorSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html#cfn-medialive-channel-audioselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class AudioSelectorSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioPidSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiopidselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioPidSelection
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioPidSelection AudioPidSelection { get; set; }
            /// <summary>
            /// AudioLanguageSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiolanguageselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioLanguageSelection
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioLanguageSelection AudioLanguageSelection { get; set; }
            /// <summary>
            /// AudioTrackSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiotrackselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioTrackSelection
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioTrackSelection AudioTrackSelection { get; set; }
            /// <summary>
            /// AudioHlsRenditionSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiohlsrenditionselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioHlsRenditionSelection
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioHlsRenditionSelection AudioHlsRenditionSelection { get; set; }
        }

        public class AudioSilenceFailoverSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiosilencefailoversettings.html#cfn-medialive-channel-audiosilencefailoversettings-audioselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioSelectorName { get; set; }
            /// <summary>
            /// AudioSilenceThresholdMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiosilencefailoversettings.html#cfn-medialive-channel-audiosilencefailoversettings-audiosilencethresholdmsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AudioSilenceThresholdMsec { get; set; }
        }

        public class AudioTrack : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Track
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrack.html#cfn-medialive-channel-audiotrack-track
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Track { get; set; }
        }

        public class AudioTrackSelection : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DolbyEDecode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrackselection.html#cfn-medialive-channel-audiotrackselection-dolbyedecode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioDolbyEDecode
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioDolbyEDecode DolbyEDecode { get; set; }
            /// <summary>
            /// Tracks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrackselection.html#cfn-medialive-channel-audiotrackselection-tracks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioTrack
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.AudioTrack> Tracks { get; set; }
        }

        public class AudioWatermarkSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NielsenWatermarksSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiowatermarksettings.html#cfn-medialive-channel-audiowatermarksettings-nielsenwatermarkssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenWatermarksSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.NielsenWatermarksSettings NielsenWatermarksSettings { get; set; }
        }

        public class AutomaticInputFailoverSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FailoverConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-failoverconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FailoverCondition
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.FailoverCondition> FailoverConditions { get; set; }
            /// <summary>
            /// InputPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-inputpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputPreference { get; set; }
            /// <summary>
            /// SecondaryInputId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-secondaryinputid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecondaryInputId { get; set; }
            /// <summary>
            /// ErrorClearTimeMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-errorcleartimemsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ErrorClearTimeMsec { get; set; }
        }

        public class AvailBlanking : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availblanking.html#cfn-medialive-channel-availblanking-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// AvailBlankingImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availblanking.html#cfn-medialive-channel-availblanking-availblankingimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation AvailBlankingImage { get; set; }
        }

        public class AvailConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AvailSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availconfiguration.html#cfn-medialive-channel-availconfiguration-availsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AvailSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AvailSettings AvailSettings { get; set; }
            /// <summary>
            /// Scte35SegmentationScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availconfiguration.html#cfn-medialive-channel-availconfiguration-scte35segmentationscope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35SegmentationScope { get; set; }
        }

        public class AvailSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scte35SpliceInsert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html#cfn-medialive-channel-availsettings-scte35spliceinsert
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte35SpliceInsert
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsert Scte35SpliceInsert { get; set; }
            /// <summary>
            /// Scte35TimeSignalApos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html#cfn-medialive-channel-availsettings-scte35timesignalapos
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte35TimeSignalApos
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Scte35TimeSignalApos Scte35TimeSignalApos { get; set; }
            /// <summary>
            /// Esam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html#cfn-medialive-channel-availsettings-esam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Esam
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Esam Esam { get; set; }
        }

        public class BlackoutSlate : Humidifier.Base.BaseSubResource, IHaveState, IHaveNetworkId
        {
            /// <summary>
            /// NetworkEndBlackout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-networkendblackout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkEndBlackout { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// NetworkId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-networkid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkId { get; set; }
            /// <summary>
            /// NetworkEndBlackoutImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-networkendblackoutimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation NetworkEndBlackoutImage { get; set; }
            /// <summary>
            /// BlackoutSlateImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-blackoutslateimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation BlackoutSlateImage { get; set; }
        }

        public class BurnInDestinationSettings : Humidifier.Base.BaseSubResource, IHaveBackgroundColor, IHaveFontColor, IHaveAlignment, IHaveFontSize
        {
            /// <summary>
            /// BackgroundOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-backgroundopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BackgroundOpacity { get; set; }
            /// <summary>
            /// FontResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FontResolution { get; set; }
            /// <summary>
            /// OutlineColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-outlinecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutlineColor { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// ShadowColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShadowColor { get; set; }
            /// <summary>
            /// ShadowOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ShadowOpacity { get; set; }
            /// <summary>
            /// Font
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-font
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation Font { get; set; }
            /// <summary>
            /// ShadowYOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowyoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ShadowYOffset { get; set; }
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alignment { get; set; }
            /// <summary>
            /// XPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-xposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic XPosition { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontSize { get; set; }
            /// <summary>
            /// YPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-yposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic YPosition { get; set; }
            /// <summary>
            /// OutlineSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-outlinesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OutlineSize { get; set; }
            /// <summary>
            /// TeletextGridControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-teletextgridcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TeletextGridControl { get; set; }
            /// <summary>
            /// FontOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-fontopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FontOpacity { get; set; }
            /// <summary>
            /// ShadowXOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-shadowxoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ShadowXOffset { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html#cfn-medialive-channel-burnindestinationsettings-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class CaptionDescription : Humidifier.Base.BaseSubResource, IHaveName, IHaveLanguageCode
        {
            /// <summary>
            /// DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.CaptionDestinationSettings DestinationSettings { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// LanguageDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-languagedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageDescription { get; set; }
            /// <summary>
            /// Accessibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-accessibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Accessibility { get; set; }
            /// <summary>
            /// DvbDashAccessibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-dvbdashaccessibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DvbDashAccessibility { get; set; }
            /// <summary>
            /// CaptionSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-captionselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptionSelectorName { get; set; }
            /// <summary>
            /// CaptionDashRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-captiondashroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CaptionDashRoles { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CaptionDestinationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AribDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-aribdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AribDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AribDestinationSettings AribDestinationSettings { get; set; }
            /// <summary>
            /// EbuTtDDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-ebuttddestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbuTtDDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.EbuTtDDestinationSettings EbuTtDDestinationSettings { get; set; }
            /// <summary>
            /// SmpteTtDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-smptettdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmpteTtDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.SmpteTtDestinationSettings SmpteTtDestinationSettings { get; set; }
            /// <summary>
            /// EmbeddedPlusScte20DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-embeddedplusscte20destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedPlusScte20DestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.EmbeddedPlusScte20DestinationSettings EmbeddedPlusScte20DestinationSettings { get; set; }
            /// <summary>
            /// TtmlDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-ttmldestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TtmlDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TtmlDestinationSettings TtmlDestinationSettings { get; set; }
            /// <summary>
            /// Scte20PlusEmbeddedDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-scte20plusembeddeddestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte20PlusEmbeddedDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Scte20PlusEmbeddedDestinationSettings Scte20PlusEmbeddedDestinationSettings { get; set; }
            /// <summary>
            /// DvbSubDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-dvbsubdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbSubDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.DvbSubDestinationSettings DvbSubDestinationSettings { get; set; }
            /// <summary>
            /// TeletextDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-teletextdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TeletextDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TeletextDestinationSettings TeletextDestinationSettings { get; set; }
            /// <summary>
            /// BurnInDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-burnindestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BurnInDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.BurnInDestinationSettings BurnInDestinationSettings { get; set; }
            /// <summary>
            /// WebvttDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-webvttdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebvttDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.WebvttDestinationSettings WebvttDestinationSettings { get; set; }
            /// <summary>
            /// EmbeddedDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-embeddeddestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.EmbeddedDestinationSettings EmbeddedDestinationSettings { get; set; }
            /// <summary>
            /// RtmpCaptionInfoDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-rtmpcaptioninfodestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtmpCaptionInfoDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.RtmpCaptionInfoDestinationSettings RtmpCaptionInfoDestinationSettings { get; set; }
            /// <summary>
            /// Scte27DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-scte27destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte27DestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Scte27DestinationSettings Scte27DestinationSettings { get; set; }
        }

        public class CaptionLanguageMapping : Humidifier.Base.BaseSubResource, IHaveLanguageCode
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html#cfn-medialive-channel-captionlanguagemapping-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// LanguageDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html#cfn-medialive-channel-captionlanguagemapping-languagedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageDescription { get; set; }
            /// <summary>
            /// CaptionChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html#cfn-medialive-channel-captionlanguagemapping-captionchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CaptionChannel { get; set; }
        }

        public class CaptionRectangle : Humidifier.Base.BaseSubResource, IHaveHeight, IHaveWidth
        {
            /// <summary>
            /// TopOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-topoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopOffset { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Width { get; set; }
            /// <summary>
            /// LeftOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-leftoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LeftOffset { get; set; }
        }

        public class CaptionSelector : Humidifier.Base.BaseSubResource, IHaveName, IHaveLanguageCode
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionSelectorSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.CaptionSelectorSettings SelectorSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CaptionSelectorSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DvbSubSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-dvbsubsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbSubSourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.DvbSubSourceSettings DvbSubSourceSettings { get; set; }
            /// <summary>
            /// Scte27SourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-scte27sourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte27SourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Scte27SourceSettings Scte27SourceSettings { get; set; }
            /// <summary>
            /// AribSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-aribsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AribSourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AribSourceSettings AribSourceSettings { get; set; }
            /// <summary>
            /// EmbeddedSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-embeddedsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedSourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.EmbeddedSourceSettings EmbeddedSourceSettings { get; set; }
            /// <summary>
            /// Scte20SourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-scte20sourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte20SourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Scte20SourceSettings Scte20SourceSettings { get; set; }
            /// <summary>
            /// TeletextSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-teletextsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TeletextSourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TeletextSourceSettings TeletextSourceSettings { get; set; }
            /// <summary>
            /// AncillarySourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-ancillarysourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AncillarySourceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AncillarySourceSettings AncillarySourceSettings { get; set; }
        }

        public class CdiInputSpecification : Humidifier.Base.BaseSubResource, IHaveResolution
        {
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cdiinputspecification.html#cfn-medialive-channel-cdiinputspecification-resolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resolution { get; set; }
        }

        public class CmafIngestGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveNielsenId3Behavior
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
            /// <summary>
            /// Scte35Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-scte35type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35Type { get; set; }
            /// <summary>
            /// SegmentLengthUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-segmentlengthunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentLengthUnits { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NielsenId3Behavior { get; set; }
            /// <summary>
            /// SegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-segmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SegmentLength { get; set; }
            /// <summary>
            /// SendDelayMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-senddelayms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SendDelayMs { get; set; }
        }

        public class CmafIngestOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestoutputsettings.html#cfn-medialive-channel-cmafingestoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NameModifier { get; set; }
        }

        public class ColorCorrection : Humidifier.Base.BaseSubResource, IHaveUri
        {
            /// <summary>
            /// OutputColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrection.html#cfn-medialive-channel-colorcorrection-outputcolorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputColorSpace { get; set; }
            /// <summary>
            /// InputColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrection.html#cfn-medialive-channel-colorcorrection-inputcolorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputColorSpace { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrection.html#cfn-medialive-channel-colorcorrection-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri { get; set; }
        }

        public class ColorCorrectionSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GlobalColorCorrections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrectionsettings.html#cfn-medialive-channel-colorcorrectionsettings-globalcolorcorrections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColorCorrection
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.ColorCorrection> GlobalColorCorrections { get; set; }
        }

        public class ColorSpacePassthroughSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class DolbyVision81Settings : Humidifier.Base.BaseSubResource
        {
        }

        public class DvbNitSettings : Humidifier.Base.BaseSubResource, IHaveNetworkName, IHaveNetworkId, IHaveRepInterval
        {
            /// <summary>
            /// NetworkName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html#cfn-medialive-channel-dvbnitsettings-networkname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkName { get; set; }
            /// <summary>
            /// RepInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html#cfn-medialive-channel-dvbnitsettings-repinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RepInterval { get; set; }
            /// <summary>
            /// NetworkId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html#cfn-medialive-channel-dvbnitsettings-networkid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NetworkId { get; set; }
        }

        public class DvbSdtSettings : Humidifier.Base.BaseSubResource, IHaveServiceName, IHaveRepInterval
        {
            /// <summary>
            /// ServiceProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-serviceprovidername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceProviderName { get; set; }
            /// <summary>
            /// OutputSdt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-outputsdt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputSdt { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
            /// <summary>
            /// RepInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-repinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RepInterval { get; set; }
        }

        public class DvbSubDestinationSettings : Humidifier.Base.BaseSubResource, IHaveBackgroundColor, IHaveFontColor, IHaveAlignment, IHaveFontSize
        {
            /// <summary>
            /// BackgroundOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-backgroundopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BackgroundOpacity { get; set; }
            /// <summary>
            /// FontResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-fontresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FontResolution { get; set; }
            /// <summary>
            /// OutlineColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-outlinecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutlineColor { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontColor { get; set; }
            /// <summary>
            /// ShadowColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-shadowcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShadowColor { get; set; }
            /// <summary>
            /// ShadowOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-shadowopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ShadowOpacity { get; set; }
            /// <summary>
            /// Font
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-font
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation Font { get; set; }
            /// <summary>
            /// ShadowYOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-shadowyoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ShadowYOffset { get; set; }
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alignment { get; set; }
            /// <summary>
            /// XPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-xposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic XPosition { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontSize { get; set; }
            /// <summary>
            /// YPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-yposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic YPosition { get; set; }
            /// <summary>
            /// OutlineSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-outlinesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OutlineSize { get; set; }
            /// <summary>
            /// TeletextGridControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-teletextgridcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TeletextGridControl { get; set; }
            /// <summary>
            /// FontOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-fontopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FontOpacity { get; set; }
            /// <summary>
            /// ShadowXOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-shadowxoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ShadowXOffset { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubdestinationsettings.html#cfn-medialive-channel-dvbsubdestinationsettings-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackgroundColor { get; set; }
        }

        public class DvbSubSourceSettings : Humidifier.Base.BaseSubResource, IHavePid
        {
            /// <summary>
            /// OcrLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubsourcesettings.html#cfn-medialive-channel-dvbsubsourcesettings-ocrlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OcrLanguage { get; set; }
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubsourcesettings.html#cfn-medialive-channel-dvbsubsourcesettings-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid { get; set; }
        }

        public class DvbTdtSettings : Humidifier.Base.BaseSubResource, IHaveRepInterval
        {
            /// <summary>
            /// RepInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbtdtsettings.html#cfn-medialive-channel-dvbtdtsettings-repinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RepInterval { get; set; }
        }

        public class Eac3AtmosSettings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveCodingMode, IHaveDialnorm
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodingMode { get; set; }
            /// <summary>
            /// Dialnorm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-dialnorm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Dialnorm { get; set; }
            /// <summary>
            /// SurroundTrim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-surroundtrim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SurroundTrim { get; set; }
            /// <summary>
            /// DrcRf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-drcrf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DrcRf { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Bitrate { get; set; }
            /// <summary>
            /// DrcLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-drcline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DrcLine { get; set; }
            /// <summary>
            /// HeightTrim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-heighttrim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic HeightTrim { get; set; }
        }

        public class Eac3Settings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveCodingMode, IHaveDialnorm
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodingMode { get; set; }
            /// <summary>
            /// SurroundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-surroundmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SurroundMode { get; set; }
            /// <summary>
            /// PassthroughControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-passthroughcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PassthroughControl { get; set; }
            /// <summary>
            /// Dialnorm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-dialnorm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Dialnorm { get; set; }
            /// <summary>
            /// LoRoSurroundMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lorosurroundmixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LoRoSurroundMixLevel { get; set; }
            /// <summary>
            /// PhaseControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-phasecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhaseControl { get; set; }
            /// <summary>
            /// LtRtCenterMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-ltrtcentermixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LtRtCenterMixLevel { get; set; }
            /// <summary>
            /// LfeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lfefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LfeFilter { get; set; }
            /// <summary>
            /// LfeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lfecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LfeControl { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Bitrate { get; set; }
            /// <summary>
            /// DrcLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-drcline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DrcLine { get; set; }
            /// <summary>
            /// DcFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-dcfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DcFilter { get; set; }
            /// <summary>
            /// MetadataControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-metadatacontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataControl { get; set; }
            /// <summary>
            /// LtRtSurroundMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-ltrtsurroundmixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LtRtSurroundMixLevel { get; set; }
            /// <summary>
            /// LoRoCenterMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lorocentermixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LoRoCenterMixLevel { get; set; }
            /// <summary>
            /// DrcRf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-drcrf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DrcRf { get; set; }
            /// <summary>
            /// AttenuationControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-attenuationcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttenuationControl { get; set; }
            /// <summary>
            /// BitstreamMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-bitstreammode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BitstreamMode { get; set; }
            /// <summary>
            /// SurroundExMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-surroundexmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SurroundExMode { get; set; }
            /// <summary>
            /// StereoDownmix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-stereodownmix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StereoDownmix { get; set; }
        }

        public class EbuTtDDestinationSettings : Humidifier.Base.BaseSubResource, IHaveStyleControl
        {
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontFamily { get; set; }
            /// <summary>
            /// FillLineGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-filllinegap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FillLineGap { get; set; }
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StyleControl { get; set; }
            /// <summary>
            /// CopyrightHolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-copyrightholder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CopyrightHolder { get; set; }
        }

        public class EmbeddedDestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class EmbeddedPlusScte20DestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class EmbeddedSourceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source608ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Source608ChannelNumber { get; set; }
            /// <summary>
            /// Scte20Detection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-scte20detection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte20Detection { get; set; }
            /// <summary>
            /// Source608TrackNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608tracknumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Source608TrackNumber { get; set; }
            /// <summary>
            /// Convert608To708
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-convert608to708
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Convert608To708 { get; set; }
        }

        public class EncoderSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioDescriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-audiodescriptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioDescription
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.AudioDescription> AudioDescriptions { get; set; }
            /// <summary>
            /// VideoDescriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-videodescriptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VideoDescription
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.VideoDescription> VideoDescriptions { get; set; }
            /// <summary>
            /// GlobalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-globalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalConfiguration
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.GlobalConfiguration GlobalConfiguration { get; set; }
            /// <summary>
            /// MotionGraphicsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-motiongraphicsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MotionGraphicsConfiguration
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration MotionGraphicsConfiguration { get; set; }
            /// <summary>
            /// ThumbnailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-thumbnailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThumbnailConfiguration
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration ThumbnailConfiguration { get; set; }
            /// <summary>
            /// FeatureActivations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-featureactivations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FeatureActivations
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FeatureActivations FeatureActivations { get; set; }
            /// <summary>
            /// CaptionDescriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-captiondescriptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionDescription
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.CaptionDescription> CaptionDescriptions { get; set; }
            /// <summary>
            /// AvailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-availconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AvailConfiguration
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AvailConfiguration AvailConfiguration { get; set; }
            /// <summary>
            /// ColorCorrectionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-colorcorrectionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorCorrectionSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings ColorCorrectionSettings { get; set; }
            /// <summary>
            /// OutputGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-outputgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputGroup
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.OutputGroup> OutputGroups { get; set; }
            /// <summary>
            /// AvailBlanking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-availblanking
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AvailBlanking
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AvailBlanking AvailBlanking { get; set; }
            /// <summary>
            /// NielsenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-nielsenconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenConfiguration
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.NielsenConfiguration NielsenConfiguration { get; set; }
            /// <summary>
            /// BlackoutSlate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-blackoutslate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlackoutSlate
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.BlackoutSlate BlackoutSlate { get; set; }
            /// <summary>
            /// TimecodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-timecodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeConfig
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TimecodeConfig TimecodeConfig { get; set; }
        }

        public class EpochLockingSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JamSyncTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-epochlockingsettings.html#cfn-medialive-channel-epochlockingsettings-jamsynctime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JamSyncTime { get; set; }
            /// <summary>
            /// CustomEpoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-epochlockingsettings.html#cfn-medialive-channel-epochlockingsettings-customepoch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomEpoch { get; set; }
        }

        public class Esam : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePasswordParam, IHaveAdAvailOffset
        {
            /// <summary>
            /// AdAvailOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-adavailoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AdAvailOffset { get; set; }
            /// <summary>
            /// ZoneIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-zoneidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZoneIdentity { get; set; }
            /// <summary>
            /// AcquisitionPointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-acquisitionpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AcquisitionPointId { get; set; }
            /// <summary>
            /// PoisEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-poisendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PoisEndpoint { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PasswordParam { get; set; }
        }

        public class FailoverCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FailoverConditionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failovercondition.html#cfn-medialive-channel-failovercondition-failoverconditionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailoverConditionSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FailoverConditionSettings FailoverConditionSettings { get; set; }
        }

        public class FailoverConditionSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioSilenceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html#cfn-medialive-channel-failoverconditionsettings-audiosilencesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSilenceFailoverSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioSilenceFailoverSettings AudioSilenceSettings { get; set; }
            /// <summary>
            /// VideoBlackSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html#cfn-medialive-channel-failoverconditionsettings-videoblacksettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoBlackFailoverSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoBlackFailoverSettings VideoBlackSettings { get; set; }
            /// <summary>
            /// InputLossSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html#cfn-medialive-channel-failoverconditionsettings-inputlosssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLossFailoverSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLossFailoverSettings InputLossSettings { get; set; }
        }

        public class FeatureActivations : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputPrepareScheduleActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-featureactivations.html#cfn-medialive-channel-featureactivations-inputpreparescheduleactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputPrepareScheduleActions { get; set; }
            /// <summary>
            /// OutputStaticImageOverlayScheduleActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-featureactivations.html#cfn-medialive-channel-featureactivations-outputstaticimageoverlayscheduleactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputStaticImageOverlayScheduleActions { get; set; }
        }

        public class FecOutputSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RowLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html#cfn-medialive-channel-fecoutputsettings-rowlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RowLength { get; set; }
            /// <summary>
            /// ColumnDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html#cfn-medialive-channel-fecoutputsettings-columndepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ColumnDepth { get; set; }
            /// <summary>
            /// IncludeFec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html#cfn-medialive-channel-fecoutputsettings-includefec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncludeFec { get; set; }
        }

        public class Fmp4HlsSettings : Humidifier.Base.BaseSubResource, IHaveNielsenId3Behavior, IHaveTimedMetadataBehavior
        {
            /// <summary>
            /// AudioRenditionSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html#cfn-medialive-channel-fmp4hlssettings-audiorenditionsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioRenditionSets { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html#cfn-medialive-channel-fmp4hlssettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NielsenId3Behavior { get; set; }
            /// <summary>
            /// TimedMetadataBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html#cfn-medialive-channel-fmp4hlssettings-timedmetadatabehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataBehavior { get; set; }
        }

        public class FrameCaptureCdnSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FrameCaptureS3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturecdnsettings.html#cfn-medialive-channel-framecapturecdnsettings-framecaptures3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureS3Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FrameCaptureS3Settings FrameCaptureS3Settings { get; set; }
        }

        public class FrameCaptureGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// FrameCaptureCdnSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturegroupsettings.html#cfn-medialive-channel-framecapturegroupsettings-framecapturecdnsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureCdnSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FrameCaptureCdnSettings FrameCaptureCdnSettings { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturegroupsettings.html#cfn-medialive-channel-framecapturegroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
        }

        public class FrameCaptureHlsSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class FrameCaptureOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecaptureoutputsettings.html#cfn-medialive-channel-framecaptureoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NameModifier { get; set; }
        }

        public class FrameCaptureS3Settings : Humidifier.Base.BaseSubResource, IHaveCannedAcl
        {
            /// <summary>
            /// CannedAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecaptures3settings.html#cfn-medialive-channel-framecaptures3settings-cannedacl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CannedAcl { get; set; }
        }

        public class FrameCaptureSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html#cfn-medialive-channel-framecapturesettings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings TimecodeBurninSettings { get; set; }
            /// <summary>
            /// CaptureInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html#cfn-medialive-channel-framecapturesettings-captureinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CaptureInterval { get; set; }
            /// <summary>
            /// CaptureIntervalUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html#cfn-medialive-channel-framecapturesettings-captureintervalunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptureIntervalUnits { get; set; }
        }

        public class GlobalConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputEndAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-inputendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputEndAction { get; set; }
            /// <summary>
            /// OutputLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputlockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLockingSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLockingSettings OutputLockingSettings { get; set; }
            /// <summary>
            /// OutputTimingSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputtimingsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputTimingSource { get; set; }
            /// <summary>
            /// OutputLockingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputlockingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputLockingMode { get; set; }
            /// <summary>
            /// SupportLowFramerateInputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-supportlowframerateinputs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SupportLowFramerateInputs { get; set; }
            /// <summary>
            /// InitialAudioGain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-initialaudiogain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InitialAudioGain { get; set; }
            /// <summary>
            /// InputLossBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-inputlossbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLossBehavior
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLossBehavior InputLossBehavior { get; set; }
        }

        public class H264ColorSpaceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Rec601Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264colorspacesettings.html#cfn-medialive-channel-h264colorspacesettings-rec601settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Rec601Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Rec601Settings Rec601Settings { get; set; }
            /// <summary>
            /// Rec709Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264colorspacesettings.html#cfn-medialive-channel-h264colorspacesettings-rec709settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Rec709Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Rec709Settings Rec709Settings { get; set; }
            /// <summary>
            /// ColorSpacePassthroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264colorspacesettings.html#cfn-medialive-channel-h264colorspacesettings-colorspacepassthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorSpacePassthroughSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ColorSpacePassthroughSettings ColorSpacePassthroughSettings { get; set; }
        }

        public class H264FilterSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTemporalFilterSettingsTemporalFilterSettings
        {
            /// <summary>
            /// TemporalFilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264filtersettings.html#cfn-medialive-channel-h264filtersettings-temporalfiltersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemporalFilterSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TemporalFilterSettings TemporalFilterSettings { get; set; }
        }

        public class H264Settings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveLevel, IHaveMaxBitrate, IHaveProfile, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveRateControlMode, IHaveFramerateNumerator, IHaveGopClosedCadence, IHaveFramerateDenominator, IHaveGopSize, IHaveAdaptiveQuantization, IHaveFixedAfd, IHaveGopSizeUnits, IHaveAfdSignaling, IHaveScanType, IHaveTimecodeInsertion, IHaveColorMetadata
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings TimecodeBurninSettings { get; set; }
            /// <summary>
            /// NumRefFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-numrefframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRefFrames { get; set; }
            /// <summary>
            /// TemporalAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-temporalaq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemporalAq { get; set; }
            /// <summary>
            /// Slices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-slices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Slices { get; set; }
            /// <summary>
            /// FramerateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-frameratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FramerateControl { get; set; }
            /// <summary>
            /// QvbrQualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-qvbrqualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QvbrQualityLevel { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FramerateNumerator { get; set; }
            /// <summary>
            /// ParControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-parcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParControl { get; set; }
            /// <summary>
            /// GopClosedCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopclosedcadence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GopClosedCadence { get; set; }
            /// <summary>
            /// FlickerAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-flickeraq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlickerAq { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Profile { get; set; }
            /// <summary>
            /// QualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-qualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QualityLevel { get; set; }
            /// <summary>
            /// MinIInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-miniinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinIInterval { get; set; }
            /// <summary>
            /// SceneChangeDetect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-scenechangedetect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SceneChangeDetect { get; set; }
            /// <summary>
            /// ForceFieldPictures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-forcefieldpictures
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ForceFieldPictures { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FramerateDenominator { get; set; }
            /// <summary>
            /// Softness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-softness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Softness { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GopSize { get; set; }
            /// <summary>
            /// AdaptiveQuantization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-adaptivequantization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdaptiveQuantization { get; set; }
            /// <summary>
            /// FilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-filtersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264FilterSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.H264FilterSettings FilterSettings { get; set; }
            /// <summary>
            /// MinQp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-minqp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinQp { get; set; }
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264ColorSpaceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.H264ColorSpaceSettings ColorSpaceSettings { get; set; }
            /// <summary>
            /// EntropyEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-entropyencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntropyEncoding { get; set; }
            /// <summary>
            /// SpatialAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-spatialaq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpatialAq { get; set; }
            /// <summary>
            /// ParDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-pardenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ParDenominator { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GopSizeUnits { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AfdSignaling { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Bitrate { get; set; }
            /// <summary>
            /// ParNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-parnumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ParNumerator { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RateControlMode { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanType { get; set; }
            /// <summary>
            /// BufSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-bufsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufSize { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimecodeInsertion { get; set; }
            /// <summary>
            /// ColorMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-colormetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorMetadata { get; set; }
            /// <summary>
            /// BufFillPct
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-buffillpct
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufFillPct { get; set; }
            /// <summary>
            /// GopBReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopbreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GopBReference { get; set; }
            /// <summary>
            /// LookAheadRateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-lookaheadratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LookAheadRateControl { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Level { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBitrate { get; set; }
            /// <summary>
            /// Syntax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-syntax
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Syntax { get; set; }
            /// <summary>
            /// SubgopLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-subgoplength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubgopLength { get; set; }
            /// <summary>
            /// GopNumBFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopnumbframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GopNumBFrames { get; set; }
        }

        public class H265ColorSpaceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Rec601Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-rec601settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Rec601Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Rec601Settings Rec601Settings { get; set; }
            /// <summary>
            /// Rec709Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-rec709settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Rec709Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Rec709Settings Rec709Settings { get; set; }
            /// <summary>
            /// ColorSpacePassthroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-colorspacepassthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorSpacePassthroughSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ColorSpacePassthroughSettings ColorSpacePassthroughSettings { get; set; }
            /// <summary>
            /// DolbyVision81Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-dolbyvision81settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DolbyVision81Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.DolbyVision81Settings DolbyVision81Settings { get; set; }
            /// <summary>
            /// Hdr10Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-hdr10settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Hdr10Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Hdr10Settings Hdr10Settings { get; set; }
        }

        public class H265FilterSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTemporalFilterSettingsTemporalFilterSettings
        {
            /// <summary>
            /// TemporalFilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265filtersettings.html#cfn-medialive-channel-h265filtersettings-temporalfiltersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemporalFilterSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TemporalFilterSettings TemporalFilterSettings { get; set; }
        }

        public class H265Settings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveLevel, IHaveTier, IHaveMaxBitrate, IHaveProfile, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveRateControlMode, IHaveFramerateNumerator, IHaveGopClosedCadence, IHaveFramerateDenominator, IHaveGopSize, IHaveAdaptiveQuantization, IHaveFixedAfd, IHaveGopSizeUnits, IHaveAfdSignaling, IHaveScanType, IHaveTimecodeInsertion, IHaveColorMetadata
        {
            /// <summary>
            /// MvOverPictureBoundaries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-mvoverpictureboundaries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MvOverPictureBoundaries { get; set; }
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings TimecodeBurninSettings { get; set; }
            /// <summary>
            /// Slices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-slices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Slices { get; set; }
            /// <summary>
            /// QvbrQualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-qvbrqualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QvbrQualityLevel { get; set; }
            /// <summary>
            /// TileHeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tileheight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TileHeight { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FramerateNumerator { get; set; }
            /// <summary>
            /// GopClosedCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopclosedcadence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GopClosedCadence { get; set; }
            /// <summary>
            /// FlickerAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-flickeraq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlickerAq { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Profile { get; set; }
            /// <summary>
            /// MvTemporalPredictor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-mvtemporalpredictor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MvTemporalPredictor { get; set; }
            /// <summary>
            /// MinIInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-miniinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinIInterval { get; set; }
            /// <summary>
            /// SceneChangeDetect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-scenechangedetect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SceneChangeDetect { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FramerateDenominator { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GopSize { get; set; }
            /// <summary>
            /// AdaptiveQuantization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-adaptivequantization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdaptiveQuantization { get; set; }
            /// <summary>
            /// TileWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tilewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TileWidth { get; set; }
            /// <summary>
            /// FilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-filtersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H265FilterSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.H265FilterSettings FilterSettings { get; set; }
            /// <summary>
            /// MinQp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-minqp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinQp { get; set; }
            /// <summary>
            /// AlternativeTransferFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-alternativetransferfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternativeTransferFunction { get; set; }
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H265ColorSpaceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.H265ColorSpaceSettings ColorSpaceSettings { get; set; }
            /// <summary>
            /// Tier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Tier { get; set; }
            /// <summary>
            /// ParDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-pardenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ParDenominator { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GopSizeUnits { get; set; }
            /// <summary>
            /// TilePadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tilepadding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TilePadding { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AfdSignaling { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Bitrate { get; set; }
            /// <summary>
            /// ParNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-parnumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ParNumerator { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RateControlMode { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanType { get; set; }
            /// <summary>
            /// BufSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-bufsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufSize { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimecodeInsertion { get; set; }
            /// <summary>
            /// ColorMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-colormetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorMetadata { get; set; }
            /// <summary>
            /// LookAheadRateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-lookaheadratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LookAheadRateControl { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Level { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBitrate { get; set; }
            /// <summary>
            /// TreeblockSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-treeblocksize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TreeblockSize { get; set; }
        }

        public class Hdr10Settings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxCll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hdr10settings.html#cfn-medialive-channel-hdr10settings-maxcll
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCll { get; set; }
            /// <summary>
            /// MaxFall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hdr10settings.html#cfn-medialive-channel-hdr10settings-maxfall
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxFall { get; set; }
        }

        public class HlsAkamaiSettings : Humidifier.Base.BaseSubResource, IHaveNumRetries, IHaveRestartDelay, IHaveConnectionRetryInterval, IHaveFilecacheDuration
        {
            /// <summary>
            /// Salt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-salt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Salt { get; set; }
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRetries { get; set; }
            /// <summary>
            /// Token
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-token
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Token { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConnectionRetryInterval { get; set; }
            /// <summary>
            /// HttpTransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-httptransfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpTransferMode { get; set; }
        }

        public class HlsBasicPutSettings : Humidifier.Base.BaseSubResource, IHaveNumRetries, IHaveRestartDelay, IHaveConnectionRetryInterval, IHaveFilecacheDuration
        {
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRetries { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConnectionRetryInterval { get; set; }
        }

        public class HlsCdnSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HlsWebdavSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlswebdavsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsWebdavSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsWebdavSettings HlsWebdavSettings { get; set; }
            /// <summary>
            /// HlsS3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlss3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsS3Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsS3Settings HlsS3Settings { get; set; }
            /// <summary>
            /// HlsAkamaiSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsakamaisettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsAkamaiSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsAkamaiSettings HlsAkamaiSettings { get; set; }
            /// <summary>
            /// HlsBasicPutSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsbasicputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsBasicPutSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsBasicPutSettings HlsBasicPutSettings { get; set; }
            /// <summary>
            /// HlsMediaStoreSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsmediastoresettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsMediaStoreSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsMediaStoreSettings HlsMediaStoreSettings { get; set; }
        }

        public class HlsGroupSettings : Humidifier.Base.BaseSubResource, IHaveMode, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveEncryptionType, IHaveAdMarkers, IHaveInputLossAction
        {
            /// <summary>
            /// SegmentationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-segmentationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentationMode { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
            /// <summary>
            /// CodecSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-codecspecification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodecSpecification { get; set; }
            /// <summary>
            /// IvSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-ivsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IvSource { get; set; }
            /// <summary>
            /// TimedMetadataId3Frame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-timedmetadataid3frame
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataId3Frame { get; set; }
            /// <summary>
            /// KeyFormatVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keyformatversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyFormatVersions { get; set; }
            /// <summary>
            /// RedundantManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-redundantmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedundantManifest { get; set; }
            /// <summary>
            /// OutputSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-outputselection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputSelection { get; set; }
            /// <summary>
            /// KeyProviderSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keyprovidersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyProviderSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.KeyProviderSettings KeyProviderSettings { get; set; }
            /// <summary>
            /// StreamInfResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-streaminfresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamInfResolution { get; set; }
            /// <summary>
            /// CaptionLanguageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-captionlanguagemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionLanguageMapping
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.CaptionLanguageMapping> CaptionLanguageMappings { get; set; }
            /// <summary>
            /// HlsId3SegmentTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-hlsid3segmenttagging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HlsId3SegmentTagging { get; set; }
            /// <summary>
            /// IFrameOnlyPlaylists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-iframeonlyplaylists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IFrameOnlyPlaylists { get; set; }
            /// <summary>
            /// CaptionLanguageSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-captionlanguagesetting
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptionLanguageSetting { get; set; }
            /// <summary>
            /// KeepSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keepsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic KeepSegments { get; set; }
            /// <summary>
            /// ConstantIv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-constantiv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConstantIv { get; set; }
            /// <summary>
            /// DirectoryStructure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-directorystructure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DirectoryStructure { get; set; }
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdMarkers { get; set; }
            /// <summary>
            /// HlsCdnSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-hlscdnsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsCdnSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsCdnSettings HlsCdnSettings { get; set; }
            /// <summary>
            /// IndexNSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-indexnsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IndexNSegments { get; set; }
            /// <summary>
            /// DiscontinuityTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-discontinuitytags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscontinuityTags { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputLossAction { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// TsFileMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-tsfilemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TsFileMode { get; set; }
            /// <summary>
            /// BaseUrlManifest1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlmanifest1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrlManifest1 { get; set; }
            /// <summary>
            /// ClientCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-clientcache
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientCache { get; set; }
            /// <summary>
            /// MinSegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-minsegmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinSegmentLength { get; set; }
            /// <summary>
            /// KeyFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keyformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyFormat { get; set; }
            /// <summary>
            /// IvInManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-ivinmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IvInManifest { get; set; }
            /// <summary>
            /// BaseUrlContent1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlcontent1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrlContent1 { get; set; }
            /// <summary>
            /// ProgramDateTimeClock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-programdatetimeclock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProgramDateTimeClock { get; set; }
            /// <summary>
            /// ManifestCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-manifestcompression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestCompression { get; set; }
            /// <summary>
            /// ManifestDurationFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-manifestdurationformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestDurationFormat { get; set; }
            /// <summary>
            /// TimedMetadataId3Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-timedmetadataid3period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimedMetadataId3Period { get; set; }
            /// <summary>
            /// IncompleteSegmentBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-incompletesegmentbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncompleteSegmentBehavior { get; set; }
            /// <summary>
            /// ProgramDateTimePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-programdatetimeperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramDateTimePeriod { get; set; }
            /// <summary>
            /// SegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-segmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SegmentLength { get; set; }
            /// <summary>
            /// TimestampDeltaMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-timestampdeltamilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimestampDeltaMilliseconds { get; set; }
            /// <summary>
            /// ProgramDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-programdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProgramDateTime { get; set; }
            /// <summary>
            /// SegmentsPerSubdirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-segmentspersubdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SegmentsPerSubdirectory { get; set; }
            /// <summary>
            /// BaseUrlContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrlContent { get; set; }
            /// <summary>
            /// BaseUrlManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseUrlManifest { get; set; }
        }

        public class HlsInputSettings : Humidifier.Base.BaseSubResource, IHaveRetries
        {
            /// <summary>
            /// Scte35Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-scte35source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35Source { get; set; }
            /// <summary>
            /// BufferSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-buffersegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufferSegments { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Retries { get; set; }
            /// <summary>
            /// Bandwidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-bandwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Bandwidth { get; set; }
            /// <summary>
            /// RetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetryInterval { get; set; }
        }

        public class HlsMediaStoreSettings : Humidifier.Base.BaseSubResource, IHaveNumRetries, IHaveRestartDelay, IHaveConnectionRetryInterval, IHaveFilecacheDuration
        {
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRetries { get; set; }
            /// <summary>
            /// MediaStoreStorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-mediastorestorageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaStoreStorageClass { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConnectionRetryInterval { get; set; }
        }

        public class HlsOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NameModifier { get; set; }
            /// <summary>
            /// HlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-hlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsSettings HlsSettings { get; set; }
            /// <summary>
            /// H265PackagingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-h265packagingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic H265PackagingType { get; set; }
            /// <summary>
            /// SegmentModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-segmentmodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentModifier { get; set; }
        }

        public class HlsS3Settings : Humidifier.Base.BaseSubResource, IHaveCannedAcl
        {
            /// <summary>
            /// CannedAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlss3settings.html#cfn-medialive-channel-hlss3settings-cannedacl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CannedAcl { get; set; }
        }

        public class HlsSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StandardHlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-standardhlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardHlsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.StandardHlsSettings StandardHlsSettings { get; set; }
            /// <summary>
            /// AudioOnlyHlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-audioonlyhlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioOnlyHlsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AudioOnlyHlsSettings AudioOnlyHlsSettings { get; set; }
            /// <summary>
            /// Fmp4HlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-fmp4hlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fmp4HlsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Fmp4HlsSettings Fmp4HlsSettings { get; set; }
            /// <summary>
            /// FrameCaptureHlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-framecapturehlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureHlsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FrameCaptureHlsSettings FrameCaptureHlsSettings { get; set; }
        }

        public class HlsWebdavSettings : Humidifier.Base.BaseSubResource, IHaveNumRetries, IHaveRestartDelay, IHaveConnectionRetryInterval, IHaveFilecacheDuration
        {
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRetries { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConnectionRetryInterval { get; set; }
            /// <summary>
            /// HttpTransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-httptransfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpTransferMode { get; set; }
        }

        public class HtmlMotionGraphicsSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class InputAttachment : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputAttachmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputattachmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputAttachmentName { get; set; }
            /// <summary>
            /// InputId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputId { get; set; }
            /// <summary>
            /// AutomaticInputFailoverSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-automaticinputfailoversettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticInputFailoverSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings AutomaticInputFailoverSettings { get; set; }
            /// <summary>
            /// InputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputSettings InputSettings { get; set; }
        }

        public class InputChannelLevel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputchannellevel.html#cfn-medialive-channel-inputchannellevel-inputchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InputChannel { get; set; }
            /// <summary>
            /// Gain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputchannellevel.html#cfn-medialive-channel-inputchannellevel-gain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Gain { get; set; }
        }

        public class InputLocation : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveUri, IHavePasswordParam
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html#cfn-medialive-channel-inputlocation-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html#cfn-medialive-channel-inputlocation-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PasswordParam { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html#cfn-medialive-channel-inputlocation-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri { get; set; }
        }

        public class InputLossBehavior : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputLossImageColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-inputlossimagecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputLossImageColor { get; set; }
            /// <summary>
            /// BlackFrameMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-blackframemsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlackFrameMsec { get; set; }
            /// <summary>
            /// InputLossImageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-inputlossimagetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputLossImageType { get; set; }
            /// <summary>
            /// InputLossImageSlate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-inputlossimageslate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation InputLossImageSlate { get; set; }
            /// <summary>
            /// RepeatFrameMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-repeatframemsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RepeatFrameMsec { get; set; }
        }

        public class InputLossFailoverSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputLossThresholdMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossfailoversettings.html#cfn-medialive-channel-inputlossfailoversettings-inputlossthresholdmsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InputLossThresholdMsec { get; set; }
        }

        public class InputSettings : Humidifier.Base.BaseSubResource, IHaveScte35Pid
        {
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Scte35Pid { get; set; }
            /// <summary>
            /// DeblockFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-deblockfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeblockFilter { get; set; }
            /// <summary>
            /// FilterStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-filterstrength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilterStrength { get; set; }
            /// <summary>
            /// InputFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-inputfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputFilter { get; set; }
            /// <summary>
            /// SourceEndBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-sourceendbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceEndBehavior { get; set; }
            /// <summary>
            /// VideoSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-videoselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelector
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoSelector VideoSelector { get; set; }
            /// <summary>
            /// Smpte2038DataPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-smpte2038datapreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Smpte2038DataPreference { get; set; }
            /// <summary>
            /// AudioSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-audioselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioSelector
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.AudioSelector> AudioSelectors { get; set; }
            /// <summary>
            /// CaptionSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-captionselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionSelector
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.CaptionSelector> CaptionSelectors { get; set; }
            /// <summary>
            /// DenoiseFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-denoisefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DenoiseFilter { get; set; }
            /// <summary>
            /// NetworkInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-networkinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkInputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.NetworkInputSettings NetworkInputSettings { get; set; }
        }

        public class InputSpecification : Humidifier.Base.BaseSubResource, IHaveResolution
        {
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Codec { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaximumBitrate { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-resolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resolution { get; set; }
        }

        public class KeyProviderSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticKeySettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-keyprovidersettings.html#cfn-medialive-channel-keyprovidersettings-statickeysettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticKeySettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.StaticKeySettings StaticKeySettings { get; set; }
        }

        public class M2tsSettings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveNielsenId3Behavior, IHaveScte35Pid, IHaveTimedMetadataBehavior, IHaveVideoPid, IHaveTransportStreamId, IHavePcrPid, IHavePmtPid, IHaveTimedMetadataPid
        {
            /// <summary>
            /// EtvPlatformPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-etvplatformpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EtvPlatformPid { get; set; }
            /// <summary>
            /// PatInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-patinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PatInterval { get; set; }
            /// <summary>
            /// ProgramNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-programnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramNum { get; set; }
            /// <summary>
            /// RateMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ratemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RateMode { get; set; }
            /// <summary>
            /// KlvDataPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-klvdatapids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KlvDataPids { get; set; }
            /// <summary>
            /// NullPacketBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-nullpacketbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic NullPacketBitrate { get; set; }
            /// <summary>
            /// PmtInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pmtinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PmtInterval { get; set; }
            /// <summary>
            /// AribCaptionsPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-aribcaptionspid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AribCaptionsPid { get; set; }
            /// <summary>
            /// EsRateInPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-esrateinpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EsRateInPes { get; set; }
            /// <summary>
            /// VideoPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-videopid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoPid { get; set; }
            /// <summary>
            /// TransportStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-transportstreamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransportStreamId { get; set; }
            /// <summary>
            /// EbpPlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebpplacement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EbpPlacement { get; set; }
            /// <summary>
            /// DvbSubPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbsubpids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DvbSubPids { get; set; }
            /// <summary>
            /// SegmentationStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-segmentationstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentationStyle { get; set; }
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35Pid { get; set; }
            /// <summary>
            /// AudioStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audiostreamtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioStreamType { get; set; }
            /// <summary>
            /// Klv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-klv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Klv { get; set; }
            /// <summary>
            /// EbpLookaheadMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebplookaheadms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EbpLookaheadMs { get; set; }
            /// <summary>
            /// Scte35PrerollPullupMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte35prerollpullupmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Scte35PrerollPullupMilliseconds { get; set; }
            /// <summary>
            /// DvbTdtSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbtdtsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbTdtSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.DvbTdtSettings DvbTdtSettings { get; set; }
            /// <summary>
            /// TimedMetadataBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-timedmetadatabehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataBehavior { get; set; }
            /// <summary>
            /// EbpAudioInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebpaudiointerval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EbpAudioInterval { get; set; }
            /// <summary>
            /// FragmentTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-fragmenttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic FragmentTime { get; set; }
            /// <summary>
            /// DvbTeletextPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbteletextpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DvbTeletextPid { get; set; }
            /// <summary>
            /// Scte35Control
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte35control
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35Control { get; set; }
            /// <summary>
            /// PcrPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pcrperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PcrPeriod { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NielsenId3Behavior { get; set; }
            /// <summary>
            /// PcrPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pcrpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PcrPid { get; set; }
            /// <summary>
            /// SegmentationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-segmentationtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SegmentationTime { get; set; }
            /// <summary>
            /// CcDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ccdescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CcDescriptor { get; set; }
            /// <summary>
            /// AudioFramesPerPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audioframesperpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AudioFramesPerPes { get; set; }
            /// <summary>
            /// AbsentInputAudioBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-absentinputaudiobehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AbsentInputAudioBehavior { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Bitrate { get; set; }
            /// <summary>
            /// PmtPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pmtpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PmtPid { get; set; }
            /// <summary>
            /// Scte27Pids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte27pids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte27Pids { get; set; }
            /// <summary>
            /// SegmentationMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-segmentationmarkers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentationMarkers { get; set; }
            /// <summary>
            /// DvbNitSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbnitsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbNitSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.DvbNitSettings DvbNitSettings { get; set; }
            /// <summary>
            /// DvbSdtSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbsdtsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbSdtSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.DvbSdtSettings DvbSdtSettings { get; set; }
            /// <summary>
            /// EtvSignalPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-etvsignalpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EtvSignalPid { get; set; }
            /// <summary>
            /// Arib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-arib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arib { get; set; }
            /// <summary>
            /// BufferModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-buffermodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BufferModel { get; set; }
            /// <summary>
            /// EcmPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ecmpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EcmPid { get; set; }
            /// <summary>
            /// TimedMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-timedmetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataPid { get; set; }
            /// <summary>
            /// AudioPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audiopids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioPids { get; set; }
            /// <summary>
            /// AudioBufferModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audiobuffermodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioBufferModel { get; set; }
            /// <summary>
            /// Ebif
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebif
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ebif { get; set; }
            /// <summary>
            /// AribCaptionsPidControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-aribcaptionspidcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AribCaptionsPidControl { get; set; }
            /// <summary>
            /// PcrControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pcrcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PcrControl { get; set; }
        }

        public class M3u8Settings : Humidifier.Base.BaseSubResource, IHaveNielsenId3Behavior, IHaveScte35Pid, IHaveTimedMetadataBehavior, IHaveVideoPid, IHaveTransportStreamId, IHavePcrPid, IHavePmtPid, IHaveTimedMetadataPid
        {
            /// <summary>
            /// PatInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-patinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PatInterval { get; set; }
            /// <summary>
            /// ProgramNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-programnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramNum { get; set; }
            /// <summary>
            /// PcrPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PcrPeriod { get; set; }
            /// <summary>
            /// PmtInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pmtinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PmtInterval { get; set; }
            /// <summary>
            /// KlvDataPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-klvdatapids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KlvDataPids { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NielsenId3Behavior { get; set; }
            /// <summary>
            /// PcrPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PcrPid { get; set; }
            /// <summary>
            /// VideoPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-videopid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoPid { get; set; }
            /// <summary>
            /// AudioFramesPerPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-audioframesperpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AudioFramesPerPes { get; set; }
            /// <summary>
            /// TransportStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-transportstreamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransportStreamId { get; set; }
            /// <summary>
            /// PmtPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pmtpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PmtPid { get; set; }
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35Pid { get; set; }
            /// <summary>
            /// Scte35Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-scte35behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte35Behavior { get; set; }
            /// <summary>
            /// KlvBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-klvbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KlvBehavior { get; set; }
            /// <summary>
            /// EcmPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-ecmpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EcmPid { get; set; }
            /// <summary>
            /// TimedMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-timedmetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataPid { get; set; }
            /// <summary>
            /// AudioPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-audiopids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioPids { get; set; }
            /// <summary>
            /// PcrControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PcrControl { get; set; }
            /// <summary>
            /// TimedMetadataBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-timedmetadatabehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataBehavior { get; set; }
        }

        public class MaintenanceCreateSettings : Humidifier.Base.BaseSubResource, IHaveMaintenanceDay
        {
            /// <summary>
            /// MaintenanceDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenancecreatesettings.html#cfn-medialive-channel-maintenancecreatesettings-maintenanceday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceDay { get; set; }
            /// <summary>
            /// MaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenancecreatesettings.html#cfn-medialive-channel-maintenancecreatesettings-maintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceStartTime { get; set; }
        }

        public class MaintenanceUpdateSettings : Humidifier.Base.BaseSubResource, IHaveMaintenanceDay
        {
            /// <summary>
            /// MaintenanceDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenanceupdatesettings.html#cfn-medialive-channel-maintenanceupdatesettings-maintenanceday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceDay { get; set; }
            /// <summary>
            /// MaintenanceScheduledDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenanceupdatesettings.html#cfn-medialive-channel-maintenanceupdatesettings-maintenancescheduleddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceScheduledDate { get; set; }
            /// <summary>
            /// MaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenanceupdatesettings.html#cfn-medialive-channel-maintenanceupdatesettings-maintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceStartTime { get; set; }
        }

        public class MediaPackageGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagegroupsettings.html#cfn-medialive-channel-mediapackagegroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
        }

        public class MediaPackageOutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveChannelId
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-channelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelId { get; set; }
        }

        public class MediaPackageOutputSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class MotionGraphicsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MotionGraphicsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicsconfiguration.html#cfn-medialive-channel-motiongraphicsconfiguration-motiongraphicssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MotionGraphicsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings MotionGraphicsSettings { get; set; }
            /// <summary>
            /// MotionGraphicsInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicsconfiguration.html#cfn-medialive-channel-motiongraphicsconfiguration-motiongraphicsinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MotionGraphicsInsertion { get; set; }
        }

        public class MotionGraphicsSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HtmlMotionGraphicsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicssettings.html#cfn-medialive-channel-motiongraphicssettings-htmlmotiongraphicssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HtmlMotionGraphicsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings HtmlMotionGraphicsSettings { get; set; }
        }

        public class Mp2Settings : Humidifier.Base.BaseSubResource, IHaveBitrate, IHaveCodingMode, IHaveSampleRate
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html#cfn-medialive-channel-mp2settings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodingMode { get; set; }
            /// <summary>
            /// SampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html#cfn-medialive-channel-mp2settings-samplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SampleRate { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html#cfn-medialive-channel-mp2settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Bitrate { get; set; }
        }

        public class Mpeg2FilterSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTemporalFilterSettingsTemporalFilterSettings
        {
            /// <summary>
            /// TemporalFilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2filtersettings.html#cfn-medialive-channel-mpeg2filtersettings-temporalfiltersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemporalFilterSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TemporalFilterSettings TemporalFilterSettings { get; set; }
        }

        public class Mpeg2Settings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveFramerateNumerator, IHaveGopClosedCadence, IHaveFramerateDenominator, IHaveGopSize, IHaveAdaptiveQuantization, IHaveFixedAfd, IHaveGopSizeUnits, IHaveAfdSignaling, IHaveScanType, IHaveTimecodeInsertion, IHaveColorMetadata
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings TimecodeBurninSettings { get; set; }
            /// <summary>
            /// ColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-colorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorSpace { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GopSizeUnits { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FramerateNumerator { get; set; }
            /// <summary>
            /// GopClosedCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopclosedcadence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GopClosedCadence { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AfdSignaling { get; set; }
            /// <summary>
            /// DisplayAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-displayaspectratio
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayAspectRatio { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanType { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimecodeInsertion { get; set; }
            /// <summary>
            /// ColorMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-colormetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorMetadata { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FramerateDenominator { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GopSize { get; set; }
            /// <summary>
            /// AdaptiveQuantization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-adaptivequantization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdaptiveQuantization { get; set; }
            /// <summary>
            /// SubgopLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-subgoplength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubgopLength { get; set; }
            /// <summary>
            /// FilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-filtersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mpeg2FilterSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Mpeg2FilterSettings FilterSettings { get; set; }
            /// <summary>
            /// GopNumBFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopnumbframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GopNumBFrames { get; set; }
        }

        public class MsSmoothGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveNumRetries, IHaveRestartDelay, IHaveConnectionRetryInterval, IHaveFilecacheDuration, IHaveCertificateMode, IHaveInputLossAction
        {
            /// <summary>
            /// SegmentationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-segmentationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentationMode { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
            /// <summary>
            /// EventStopBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-eventstopbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventStopBehavior { get; set; }
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilecacheDuration { get; set; }
            /// <summary>
            /// CertificateMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-certificatemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateMode { get; set; }
            /// <summary>
            /// AcquisitionPointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-acquisitionpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AcquisitionPointId { get; set; }
            /// <summary>
            /// StreamManifestBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-streammanifestbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamManifestBehavior { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputLossAction { get; set; }
            /// <summary>
            /// FragmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-fragmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FragmentLength { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartDelay { get; set; }
            /// <summary>
            /// SparseTrackType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-sparsetracktype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SparseTrackType { get; set; }
            /// <summary>
            /// EventIdMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-eventidmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventIdMode { get; set; }
            /// <summary>
            /// TimestampOffsetMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-timestampoffsetmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimestampOffsetMode { get; set; }
            /// <summary>
            /// AudioOnlyTimecodeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-audioonlytimecodecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioOnlyTimecodeControl { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRetries { get; set; }
            /// <summary>
            /// TimestampOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-timestampoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimestampOffset { get; set; }
            /// <summary>
            /// EventId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-eventid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventId { get; set; }
            /// <summary>
            /// SendDelayMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-senddelayms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SendDelayMs { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConnectionRetryInterval { get; set; }
        }

        public class MsSmoothOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothoutputsettings.html#cfn-medialive-channel-mssmoothoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NameModifier { get; set; }
            /// <summary>
            /// H265PackagingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothoutputsettings.html#cfn-medialive-channel-mssmoothoutputsettings-h265packagingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic H265PackagingType { get; set; }
        }

        public class MultiplexGroupSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class MultiplexOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexoutputsettings.html#cfn-medialive-channel-multiplexoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
        }

        public class MultiplexProgramChannelDestinationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MultiplexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html#cfn-medialive-channel-multiplexprogramchanneldestinationsettings-multiplexid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MultiplexId { get; set; }
            /// <summary>
            /// ProgramName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html#cfn-medialive-channel-multiplexprogramchanneldestinationsettings-programname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProgramName { get; set; }
        }

        public class NetworkInputSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-servervalidation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerValidation { get; set; }
            /// <summary>
            /// HlsInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-hlsinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsInputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsInputSettings HlsInputSettings { get; set; }
        }

        public class NielsenCBET : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CbetCheckDigitString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsencbet.html#cfn-medialive-channel-nielsencbet-cbetcheckdigitstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CbetCheckDigitString { get; set; }
            /// <summary>
            /// CbetStepaside
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsencbet.html#cfn-medialive-channel-nielsencbet-cbetstepaside
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CbetStepaside { get; set; }
            /// <summary>
            /// Csid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsencbet.html#cfn-medialive-channel-nielsencbet-csid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Csid { get; set; }
        }

        public class NielsenConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DistributorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html#cfn-medialive-channel-nielsenconfiguration-distributorid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DistributorId { get; set; }
            /// <summary>
            /// NielsenPcmToId3Tagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html#cfn-medialive-channel-nielsenconfiguration-nielsenpcmtoid3tagging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NielsenPcmToId3Tagging { get; set; }
        }

        public class NielsenNaesIiNw : Humidifier.Base.BaseSubResource, IHaveTimezone
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsennaesiinw.html#cfn-medialive-channel-nielsennaesiinw-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// CheckDigitString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsennaesiinw.html#cfn-medialive-channel-nielsennaesiinw-checkdigitstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CheckDigitString { get; set; }
            /// <summary>
            /// Sid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsennaesiinw.html#cfn-medialive-channel-nielsennaesiinw-sid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Sid { get; set; }
        }

        public class NielsenWatermarksSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NielsenDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsendistributiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NielsenDistributionType { get; set; }
            /// <summary>
            /// NielsenCbetSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsencbetsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenCBET
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.NielsenCBET NielsenCbetSettings { get; set; }
            /// <summary>
            /// NielsenNaesIiNwSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsennaesiinwsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenNaesIiNw
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.NielsenNaesIiNw NielsenNaesIiNwSettings { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-outputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputSettings OutputSettings { get; set; }
            /// <summary>
            /// CaptionDescriptionNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-captiondescriptionnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CaptionDescriptionNames { get; set; }
            /// <summary>
            /// AudioDescriptionNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-audiodescriptionnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AudioDescriptionNames { get; set; }
            /// <summary>
            /// OutputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-outputname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputName { get; set; }
            /// <summary>
            /// VideoDescriptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-videodescriptionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoDescriptionName { get; set; }
        }

        public class OutputDestination : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// MultiplexSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-multiplexsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexProgramChannelDestinationSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings MultiplexSettings { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputDestinationSettings
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.OutputDestinationSettings> Settings { get; set; }
            /// <summary>
            /// MediaPackageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-mediapackagesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaPackageOutputDestinationSettings
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.MediaPackageOutputDestinationSettings> MediaPackageSettings { get; set; }
        }

        public class OutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveUrl, IHaveStreamName, IHavePasswordParam
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PasswordParam { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class OutputGroup : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html#cfn-medialive-channel-outputgroup-outputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Output
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.Output> Outputs { get; set; }
            /// <summary>
            /// OutputGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html#cfn-medialive-channel-outputgroup-outputgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputGroupSettings OutputGroupSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html#cfn-medialive-channel-outputgroup-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class OutputGroupSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HlsGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-hlsgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsGroupSettings HlsGroupSettings { get; set; }
            /// <summary>
            /// FrameCaptureGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-framecapturegroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FrameCaptureGroupSettings FrameCaptureGroupSettings { get; set; }
            /// <summary>
            /// MultiplexGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-multiplexgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MultiplexGroupSettings MultiplexGroupSettings { get; set; }
            /// <summary>
            /// ArchiveGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-archivegroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ArchiveGroupSettings ArchiveGroupSettings { get; set; }
            /// <summary>
            /// MediaPackageGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-mediapackagegroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MediaPackageGroupSettings MediaPackageGroupSettings { get; set; }
            /// <summary>
            /// UdpGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-udpgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.UdpGroupSettings UdpGroupSettings { get; set; }
            /// <summary>
            /// MsSmoothGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-mssmoothgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MsSmoothGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MsSmoothGroupSettings MsSmoothGroupSettings { get; set; }
            /// <summary>
            /// RtmpGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-rtmpgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtmpGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.RtmpGroupSettings RtmpGroupSettings { get; set; }
            /// <summary>
            /// CmafIngestGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-cmafingestgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestGroupSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.CmafIngestGroupSettings CmafIngestGroupSettings { get; set; }
        }

        public class OutputLocationRef : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlocationref.html#cfn-medialive-channel-outputlocationref-destinationrefid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationRefId { get; set; }
        }

        public class OutputLockingSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PipelineLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlockingsettings.html#cfn-medialive-channel-outputlockingsettings-pipelinelockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipelineLockingSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings PipelineLockingSettings { get; set; }
            /// <summary>
            /// EpochLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlockingsettings.html#cfn-medialive-channel-outputlockingsettings-epochlockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpochLockingSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.EpochLockingSettings EpochLockingSettings { get; set; }
        }

        public class OutputSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaPackageOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-mediapackageoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MediaPackageOutputSettings MediaPackageOutputSettings { get; set; }
            /// <summary>
            /// MsSmoothOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-mssmoothoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MsSmoothOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MsSmoothOutputSettings MsSmoothOutputSettings { get; set; }
            /// <summary>
            /// FrameCaptureOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-framecaptureoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FrameCaptureOutputSettings FrameCaptureOutputSettings { get; set; }
            /// <summary>
            /// HlsOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-hlsoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.HlsOutputSettings HlsOutputSettings { get; set; }
            /// <summary>
            /// RtmpOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-rtmpoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtmpOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.RtmpOutputSettings RtmpOutputSettings { get; set; }
            /// <summary>
            /// UdpOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-udpoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.UdpOutputSettings UdpOutputSettings { get; set; }
            /// <summary>
            /// MultiplexOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-multiplexoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.MultiplexOutputSettings MultiplexOutputSettings { get; set; }
            /// <summary>
            /// CmafIngestOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-cmafingestoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.CmafIngestOutputSettings CmafIngestOutputSettings { get; set; }
            /// <summary>
            /// ArchiveOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-archiveoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.ArchiveOutputSettings ArchiveOutputSettings { get; set; }
        }

        public class PassThroughSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class PipelineLockingSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class RawSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class Rec601Settings : Humidifier.Base.BaseSubResource
        {
        }

        public class Rec709Settings : Humidifier.Base.BaseSubResource
        {
        }

        public class RemixSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChannelsOut
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelsout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ChannelsOut { get; set; }
            /// <summary>
            /// ChannelMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioChannelMapping
            /// </summary>
            public List<Humidifier.MediaLive.ChannelTypes.AudioChannelMapping> ChannelMappings { get; set; }
            /// <summary>
            /// ChannelsIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelsin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ChannelsIn { get; set; }
        }

        public class RtmpCaptionInfoDestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class RtmpGroupSettings : Humidifier.Base.BaseSubResource, IHaveRestartDelay, IHaveAdMarkers, IHaveInputLossAction
        {
            /// <summary>
            /// AuthenticationScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-authenticationscheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthenticationScheme { get; set; }
            /// <summary>
            /// CacheLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-cachelength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CacheLength { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdMarkers { get; set; }
            /// <summary>
            /// IncludeFillerNalUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-includefillernalunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncludeFillerNalUnits { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputLossAction { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartDelay { get; set; }
            /// <summary>
            /// CaptionData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-captiondata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaptionData { get; set; }
            /// <summary>
            /// CacheFullBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-cachefullbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheFullBehavior { get; set; }
        }

        public class RtmpOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveNumRetries, IHaveConnectionRetryInterval, IHaveCertificateMode
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
            /// <summary>
            /// CertificateMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-certificatemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateMode { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumRetries { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConnectionRetryInterval { get; set; }
        }

        public class Scte20PlusEmbeddedDestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class Scte20SourceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source608ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html#cfn-medialive-channel-scte20sourcesettings-source608channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Source608ChannelNumber { get; set; }
            /// <summary>
            /// Convert608To708
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html#cfn-medialive-channel-scte20sourcesettings-convert608to708
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Convert608To708 { get; set; }
        }

        public class Scte27DestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class Scte27SourceSettings : Humidifier.Base.BaseSubResource, IHavePid
        {
            /// <summary>
            /// OcrLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte27sourcesettings.html#cfn-medialive-channel-scte27sourcesettings-ocrlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OcrLanguage { get; set; }
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte27sourcesettings.html#cfn-medialive-channel-scte27sourcesettings-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid { get; set; }
        }

        public class Scte35SpliceInsert : Humidifier.Base.BaseSubResource, IHaveAdAvailOffset
        {
            /// <summary>
            /// AdAvailOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinsert.html#cfn-medialive-channel-scte35spliceinsert-adavailoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AdAvailOffset { get; set; }
            /// <summary>
            /// WebDeliveryAllowedFlag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinsert.html#cfn-medialive-channel-scte35spliceinsert-webdeliveryallowedflag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebDeliveryAllowedFlag { get; set; }
            /// <summary>
            /// NoRegionalBlackoutFlag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinsert.html#cfn-medialive-channel-scte35spliceinsert-noregionalblackoutflag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoRegionalBlackoutFlag { get; set; }
        }

        public class Scte35TimeSignalApos : Humidifier.Base.BaseSubResource, IHaveAdAvailOffset
        {
            /// <summary>
            /// AdAvailOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35timesignalapos.html#cfn-medialive-channel-scte35timesignalapos-adavailoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AdAvailOffset { get; set; }
            /// <summary>
            /// WebDeliveryAllowedFlag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35timesignalapos.html#cfn-medialive-channel-scte35timesignalapos-webdeliveryallowedflag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebDeliveryAllowedFlag { get; set; }
            /// <summary>
            /// NoRegionalBlackoutFlag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35timesignalapos.html#cfn-medialive-channel-scte35timesignalapos-noregionalblackoutflag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoRegionalBlackoutFlag { get; set; }
        }

        public class SmpteTtDestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class StandardHlsSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioRenditionSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html#cfn-medialive-channel-standardhlssettings-audiorenditionsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioRenditionSets { get; set; }
            /// <summary>
            /// M3u8Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html#cfn-medialive-channel-standardhlssettings-m3u8settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M3u8Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.M3u8Settings M3u8Settings { get; set; }
        }

        public class StaticKeySettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KeyProviderServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html#cfn-medialive-channel-statickeysettings-keyproviderserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.InputLocation KeyProviderServer { get; set; }
            /// <summary>
            /// StaticKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html#cfn-medialive-channel-statickeysettings-statickeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticKeyValue { get; set; }
        }

        public class TeletextDestinationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class TeletextSourceSettings : Humidifier.Base.BaseSubResource, IHavePageNumber
        {
            /// <summary>
            /// OutputRectangle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-teletextsourcesettings.html#cfn-medialive-channel-teletextsourcesettings-outputrectangle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionRectangle
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.CaptionRectangle OutputRectangle { get; set; }
            /// <summary>
            /// PageNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-teletextsourcesettings.html#cfn-medialive-channel-teletextsourcesettings-pagenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PageNumber { get; set; }
        }

        public class TemporalFilterSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PostFilterSharpening
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-temporalfiltersettings.html#cfn-medialive-channel-temporalfiltersettings-postfiltersharpening
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostFilterSharpening { get; set; }
            /// <summary>
            /// Strength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-temporalfiltersettings.html#cfn-medialive-channel-temporalfiltersettings-strength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Strength { get; set; }
        }

        public class ThumbnailConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-thumbnailconfiguration.html#cfn-medialive-channel-thumbnailconfiguration-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class TimecodeBurninSettings : Humidifier.Base.BaseSubResource, IHavePrefix, IHavePosition, IHaveFontSize
        {
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeburninsettings.html#cfn-medialive-channel-timecodeburninsettings-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontSize { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeburninsettings.html#cfn-medialive-channel-timecodeburninsettings-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Position { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeburninsettings.html#cfn-medialive-channel-timecodeburninsettings-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class TimecodeConfig : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// SyncThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeconfig.html#cfn-medialive-channel-timecodeconfig-syncthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SyncThreshold { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeconfig.html#cfn-medialive-channel-timecodeconfig-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class TtmlDestinationSettings : Humidifier.Base.BaseSubResource, IHaveStyleControl
        {
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ttmldestinationsettings.html#cfn-medialive-channel-ttmldestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StyleControl { get; set; }
        }

        public class UdpContainerSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// M2tsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpcontainersettings.html#cfn-medialive-channel-udpcontainersettings-m2tssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2tsSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.M2tsSettings M2tsSettings { get; set; }
        }

        public class UdpGroupSettings : Humidifier.Base.BaseSubResource, IHaveInputLossAction
        {
            /// <summary>
            /// TimedMetadataId3Frame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html#cfn-medialive-channel-udpgroupsettings-timedmetadataid3frame
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimedMetadataId3Frame { get; set; }
            /// <summary>
            /// TimedMetadataId3Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html#cfn-medialive-channel-udpgroupsettings-timedmetadataid3period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimedMetadataId3Period { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html#cfn-medialive-channel-udpgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputLossAction { get; set; }
        }

        public class UdpOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.OutputLocationRef Destination { get; set; }
            /// <summary>
            /// FecOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-fecoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FecOutputSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FecOutputSettings FecOutputSettings { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpContainerSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.UdpContainerSettings ContainerSettings { get; set; }
            /// <summary>
            /// BufferMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-buffermsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufferMsec { get; set; }
        }

        public class VideoBlackFailoverSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VideoBlackThresholdMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html#cfn-medialive-channel-videoblackfailoversettings-videoblackthresholdmsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VideoBlackThresholdMsec { get; set; }
            /// <summary>
            /// BlackDetectThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html#cfn-medialive-channel-videoblackfailoversettings-blackdetectthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BlackDetectThreshold { get; set; }
        }

        public class VideoCodecSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Mpeg2Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-mpeg2settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mpeg2Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Mpeg2Settings Mpeg2Settings { get; set; }
            /// <summary>
            /// FrameCaptureSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-framecapturesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.FrameCaptureSettings FrameCaptureSettings { get; set; }
            /// <summary>
            /// H264Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-h264settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.H264Settings H264Settings { get; set; }
            /// <summary>
            /// H265Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-h265settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H265Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.H265Settings H265Settings { get; set; }
        }

        public class VideoDescription : Humidifier.Base.BaseSubResource, IHaveName, IHaveHeight, IHaveWidth
        {
            /// <summary>
            /// ScalingBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-scalingbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScalingBehavior { get; set; }
            /// <summary>
            /// RespondToAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-respondtoafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RespondToAfd { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Sharpness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-sharpness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Sharpness { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Width { get; set; }
            /// <summary>
            /// CodecSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-codecsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoCodecSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoCodecSettings CodecSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class VideoSelector : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorColorSpaceSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings ColorSpaceSettings { get; set; }
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorSettings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings SelectorSettings { get; set; }
            /// <summary>
            /// ColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorSpace { get; set; }
            /// <summary>
            /// ColorSpaceUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspaceusage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorSpaceUsage { get; set; }
        }

        public class VideoSelectorColorSpaceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Hdr10Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorcolorspacesettings.html#cfn-medialive-channel-videoselectorcolorspacesettings-hdr10settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Hdr10Settings
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.Hdr10Settings Hdr10Settings { get; set; }
        }

        public class VideoSelectorPid : Humidifier.Base.BaseSubResource, IHavePid
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorpid.html#cfn-medialive-channel-videoselectorpid-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid { get; set; }
        }

        public class VideoSelectorProgramId : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorprogramid.html#cfn-medialive-channel-videoselectorprogramid-programid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramId { get; set; }
        }

        public class VideoSelectorSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VideoSelectorProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorprogramid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorProgramId
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId VideoSelectorProgramId { get; set; }
            /// <summary>
            /// VideoSelectorPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorpid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorPid
            /// </summary>
            public Humidifier.MediaLive.ChannelTypes.VideoSelectorPid VideoSelectorPid { get; set; }
        }

        public class VpcOutputSettings : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// PublicAddressAllocationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html#cfn-medialive-channel-vpcoutputsettings-publicaddressallocationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PublicAddressAllocationIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html#cfn-medialive-channel-vpcoutputsettings-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html#cfn-medialive-channel-vpcoutputsettings-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class WavSettings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveSampleRate
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html#cfn-medialive-channel-wavsettings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodingMode { get; set; }
            /// <summary>
            /// SampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html#cfn-medialive-channel-wavsettings-samplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SampleRate { get; set; }
            /// <summary>
            /// BitDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html#cfn-medialive-channel-wavsettings-bitdepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BitDepth { get; set; }
        }

        public class WebvttDestinationSettings : Humidifier.Base.BaseSubResource, IHaveStyleControl
        {
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-webvttdestinationsettings.html#cfn-medialive-channel-webvttdestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StyleControl { get; set; }
        }
    }
}