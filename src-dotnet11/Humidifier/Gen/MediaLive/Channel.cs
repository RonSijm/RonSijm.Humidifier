namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfMediaLiveChannelTypesInputAttachmentInputAttachments, IHaveMediaLiveChannelTypesInputSpecificationInputSpecification, IHaveStringListOfChannelSecurityGroups, IHaveListOfMediaLiveChannelTypesOutputDestinationDestinations, IHaveDryRun_Boolean, IHaveMediaLiveChannelTypesVpcOutputSettingsVpc, IHaveMediaLiveChannelTypesChannelEngineVersionRequestChannelEngineVersion, IHaveMediaLiveChannelTypesMaintenanceCreateSettingsMaintenance, IHaveLogLevel, IHaveRoleArn, IHaveName, IHaveChannelClass, IHaveMediaLiveChannelTypesEncoderSettingsEncoderSettings, IHaveMediaLiveChannelTypesLinkedChannelSettingsLinkedChannelSettings, IHaveMediaLiveChannelTypesAnywhereSettingsAnywhereSettings, IHaveMediaLiveChannelTypesCdiInputSpecificationCdiInputSpecification, IHaveTags_Json, IHaveMediaLiveChannelTypesInferenceSettingsInferenceSettings
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
        public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.InputAttachment>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.InputAttachment, BaseFunction>>, BaseFunction>? InputAttachments { get; set; }
        /// <summary>
        /// InputSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-inputspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputSpecification
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.InputSpecification, BaseFunction>? InputSpecification { get; set; }
        /// <summary>
        /// ChannelSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-channelsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ChannelSecurityGroups { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OutputDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.OutputDestination>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.OutputDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        /// <summary>
        /// DryRun
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-dryrun
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DryRun { get; set; }
        /// <summary>
        /// Vpc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-vpc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcOutputSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.VpcOutputSettings, BaseFunction>? Vpc { get; set; }
        /// <summary>
        /// ChannelEngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-channelengineversion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChannelEngineVersionRequest
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.ChannelEngineVersionRequest, BaseFunction>? ChannelEngineVersion { get; set; }
        /// <summary>
        /// Maintenance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-maintenance
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceCreateSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings, BaseFunction>? Maintenance { get; set; }
        /// <summary>
        /// LogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-loglevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogLevel { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ChannelClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-channelclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ChannelClass { get; set; }
        /// <summary>
        /// EncoderSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-encodersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncoderSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.EncoderSettings, BaseFunction>? EncoderSettings { get; set; }
        /// <summary>
        /// LinkedChannelSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-linkedchannelsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LinkedChannelSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.LinkedChannelSettings, BaseFunction>? LinkedChannelSettings { get; set; }
        /// <summary>
        /// AnywhereSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-anywheresettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnywhereSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.AnywhereSettings, BaseFunction>? AnywhereSettings { get; set; }
        /// <summary>
        /// CdiInputSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-cdiinputspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdiInputSpecification
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.CdiInputSpecification, BaseFunction>? CdiInputSpecification { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// InferenceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-inferencesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InferenceSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ChannelTypes.InferenceSettings, BaseFunction>? InferenceSettings { get; set; }
    }

    namespace ChannelTypes
    {
        public class AacSettings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveRateControlMode, IHaveSampleRate_Double, IHaveInputType, IHaveVbrQuality, IHaveRawFormat, IHaveSpec, IHaveBitrate_Double, IHaveProfile
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodingMode { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RateControlMode { get; set; }
            /// <summary>
            /// SampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-samplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SampleRate { get; set; }
            /// <summary>
            /// InputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-inputtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputType { get; set; }
            /// <summary>
            /// VbrQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-vbrquality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VbrQuality { get; set; }
            /// <summary>
            /// RawFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-rawformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RawFormat { get; set; }
            /// <summary>
            /// Spec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-spec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Spec { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html#cfn-medialive-channel-aacsettings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
        }

        public class AbWatermarkingCustomProfile : Humidifier.Base.BaseSubResource, IHaveSceneCut_Double, IHaveEmbeddingFrequency_Double, IHaveTargetPsnr_Double
        {
            /// <summary>
            /// SceneCut
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-abwatermarkingcustomprofile.html#cfn-medialive-channel-abwatermarkingcustomprofile-scenecut
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SceneCut { get; set; }
            /// <summary>
            /// EmbeddingFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-abwatermarkingcustomprofile.html#cfn-medialive-channel-abwatermarkingcustomprofile-embeddingfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? EmbeddingFrequency { get; set; }
            /// <summary>
            /// TargetPsnr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-abwatermarkingcustomprofile.html#cfn-medialive-channel-abwatermarkingcustomprofile-targetpsnr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetPsnr { get; set; }
        }

        public class Ac3Settings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveDrcProfile, IHaveMetadataControl, IHaveDialnorm_Integer, IHaveLfeFilter, IHaveBitstreamMode, IHaveAttenuationControl, IHaveBitrate_Double
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodingMode { get; set; }
            /// <summary>
            /// DrcProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-drcprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrcProfile { get; set; }
            /// <summary>
            /// MetadataControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-metadatacontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataControl { get; set; }
            /// <summary>
            /// Dialnorm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-dialnorm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dialnorm { get; set; }
            /// <summary>
            /// LfeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-lfefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LfeFilter { get; set; }
            /// <summary>
            /// BitstreamMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-bitstreammode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BitstreamMode { get; set; }
            /// <summary>
            /// AttenuationControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-attenuationcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttenuationControl { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html#cfn-medialive-channel-ac3settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Bitrate { get; set; }
        }

        public class AdditionalDestinations : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-additionaldestinations.html#cfn-medialive-channel-additionaldestinations-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
        }

        public class AncillarySourceSettings : Humidifier.Base.BaseSubResource, IHaveSourceAncillaryChannelNumber_Integer
        {
            /// <summary>
            /// SourceAncillaryChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ancillarysourcesettings.html#cfn-medialive-channel-ancillarysourcesettings-sourceancillarychannelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourceAncillaryChannelNumber { get; set; }
        }

        public class AnywhereSettings : Humidifier.Base.BaseSubResource, IHaveChannelPlacementGroupId, IHaveClusterId
        {
            /// <summary>
            /// ChannelPlacementGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-anywheresettings.html#cfn-medialive-channel-anywheresettings-channelplacementgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelPlacementGroupId { get; set; }
            /// <summary>
            /// ClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-anywheresettings.html#cfn-medialive-channel-anywheresettings-clusterid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterId { get; set; }
        }

        public class ArchiveCdnSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesArchiveFrameCaptureHlsS3SettingsArchiveS3Settings
        {
            /// <summary>
            /// ArchiveS3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecdnsettings.html#cfn-medialive-channel-archivecdnsettings-archives3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveFrameCaptureHlsS3Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveFrameCaptureHlsS3Settings, BaseFunction>? ArchiveS3Settings { get; set; }
        }

        public class ArchiveContainerSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRawSettings, IHaveMediaLiveChannelTypesM2tsSettingsM2tsSettings
        {
            /// <summary>
            /// RawSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecontainersettings.html#cfn-medialive-channel-archivecontainersettings-rawsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? RawSettings { get; set; }
            /// <summary>
            /// M2tsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecontainersettings.html#cfn-medialive-channel-archivecontainersettings-m2tssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2tsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.M2tsSettings, BaseFunction>? M2tsSettings { get; set; }
        }

        public class ArchiveFrameCaptureHlsS3Settings : Humidifier.Base.BaseSubResource, IHaveCannedAcl
        {
            /// <summary>
            /// CannedAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveframecapturehlss3settings.html#cfn-medialive-channel-archiveframecapturehlss3settings-cannedacl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CannedAcl { get; set; }
        }

        public class ArchiveGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveMediaLiveChannelTypesArchiveCdnSettingsArchiveCdnSettings, IHaveRolloverInterval_Integer
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// ArchiveCdnSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-archivecdnsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveCdnSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveCdnSettings, BaseFunction>? ArchiveCdnSettings { get; set; }
            /// <summary>
            /// RolloverInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html#cfn-medialive-channel-archivegroupsettings-rolloverinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RolloverInterval { get; set; }
        }

        public class ArchiveOutputSettings : Humidifier.Base.BaseSubResource, IHaveExtension, IHaveNameModifier, IHaveMediaLiveChannelTypesArchiveContainerSettingsContainerSettings
        {
            /// <summary>
            /// Extension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html#cfn-medialive-channel-archiveoutputsettings-extension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Extension { get; set; }
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html#cfn-medialive-channel-archiveoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NameModifier { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html#cfn-medialive-channel-archiveoutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveContainerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveContainerSettings, BaseFunction>? ContainerSettings { get; set; }
        }

        public class AudioChannelMapping : Humidifier.Base.BaseSubResource, IHaveOutputChannel_Integer, IHaveListOfMediaLiveChannelTypesInputChannelLevelInputChannelLevels
        {
            /// <summary>
            /// OutputChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiochannelmapping.html#cfn-medialive-channel-audiochannelmapping-outputchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OutputChannel { get; set; }
            /// <summary>
            /// InputChannelLevels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiochannelmapping.html#cfn-medialive-channel-audiochannelmapping-inputchannellevels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputChannelLevel
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.InputChannelLevel>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.InputChannelLevel, BaseFunction>>, BaseFunction>? InputChannelLevels { get; set; }
        }

        public class AudioCodecSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEac3SettingsEac3Settings, IHaveMediaLiveChannelTypesAc3SettingsAc3Settings, IHaveMediaLiveChannelTypesMp2SettingsMp2Settings, IHaveMediaLiveChannelTypesEac3AtmosSettingsEac3AtmosSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsPassThroughSettings, IHaveMediaLiveChannelTypesWavSettingsWavSettings, IHaveMediaLiveChannelTypesAacSettingsAacSettings
        {
            /// <summary>
            /// Eac3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-eac3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Eac3Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Eac3Settings, BaseFunction>? Eac3Settings { get; set; }
            /// <summary>
            /// Ac3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-ac3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ac3Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Ac3Settings, BaseFunction>? Ac3Settings { get; set; }
            /// <summary>
            /// Mp2Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-mp2settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mp2Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Mp2Settings, BaseFunction>? Mp2Settings { get; set; }
            /// <summary>
            /// Eac3AtmosSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-eac3atmossettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Eac3AtmosSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Eac3AtmosSettings, BaseFunction>? Eac3AtmosSettings { get; set; }
            /// <summary>
            /// PassThroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-passthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? PassThroughSettings { get; set; }
            /// <summary>
            /// WavSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-wavsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WavSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.WavSettings, BaseFunction>? WavSettings { get; set; }
            /// <summary>
            /// AacSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html#cfn-medialive-channel-audiocodecsettings-aacsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AacSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AacSettings, BaseFunction>? AacSettings { get; set; }
        }

        public class AudioDescription : Humidifier.Base.BaseSubResource, IHaveStringListOfAudioDashRoles, IHaveLanguageCodeControl, IHaveMediaLiveChannelTypesAudioCodecSettingsCodecSettings, IHaveName, IHaveMediaLiveChannelTypesAudioWatermarkSettingsAudioWatermarkingSettings, IHaveMediaLiveChannelTypesAudioNormalizationSettingsAudioNormalizationSettings, IHaveLanguageCode, IHaveMediaLiveChannelTypesRemixSettingsRemixSettings, IHaveAudioSelectorName, IHaveStreamName, IHaveDvbDashAccessibility, IHaveAudioType, IHaveAudioTypeControl
        {
            /// <summary>
            /// AudioDashRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiodashroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AudioDashRoles { get; set; }
            /// <summary>
            /// LanguageCodeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-languagecodecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCodeControl { get; set; }
            /// <summary>
            /// CodecSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-codecsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioCodecSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioCodecSettings, BaseFunction>? CodecSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// AudioWatermarkingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiowatermarkingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioWatermarkSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioWatermarkSettings, BaseFunction>? AudioWatermarkingSettings { get; set; }
            /// <summary>
            /// AudioNormalizationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audionormalizationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioNormalizationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioNormalizationSettings, BaseFunction>? AudioNormalizationSettings { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// RemixSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-remixsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RemixSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.RemixSettings, BaseFunction>? RemixSettings { get; set; }
            /// <summary>
            /// AudioSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audioselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioSelectorName { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
            /// <summary>
            /// DvbDashAccessibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-dvbdashaccessibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DvbDashAccessibility { get; set; }
            /// <summary>
            /// AudioType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiotype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioType { get; set; }
            /// <summary>
            /// AudioTypeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html#cfn-medialive-channel-audiodescription-audiotypecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioTypeControl { get; set; }
        }

        public class AudioDolbyEDecode : Humidifier.Base.BaseSubResource, IHaveProgramSelection
        {
            /// <summary>
            /// ProgramSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodolbyedecode.html#cfn-medialive-channel-audiodolbyedecode-programselection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProgramSelection { get; set; }
        }

        public class AudioFeedInput : Humidifier.Base.BaseSubResource, IHaveAudioSelectorName, IHaveFeedInput
        {
            /// <summary>
            /// AudioSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiofeedinput.html#cfn-medialive-channel-audiofeedinput-audioselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioSelectorName { get; set; }
            /// <summary>
            /// FeedInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiofeedinput.html#cfn-medialive-channel-audiofeedinput-feedinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeedInput { get; set; }
        }

        public class AudioHlsRenditionSelection : Humidifier.Base.BaseSubResource, IHaveGroupId, IHaveName
        {
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiohlsrenditionselection.html#cfn-medialive-channel-audiohlsrenditionselection-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiohlsrenditionselection.html#cfn-medialive-channel-audiohlsrenditionselection-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AudioLanguageSelection : Humidifier.Base.BaseSubResource, IHaveLanguageCode, IHaveLanguageSelectionPolicy
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html#cfn-medialive-channel-audiolanguageselection-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// LanguageSelectionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html#cfn-medialive-channel-audiolanguageselection-languageselectionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageSelectionPolicy { get; set; }
        }

        public class AudioNormalizationSettings : Humidifier.Base.BaseSubResource, IHavePeakCalculation, IHaveTargetLkfs_Double, IHaveAlgorithm, IHaveAlgorithmControl, IHavePeakLimiterThreshold_Double
        {
            /// <summary>
            /// PeakCalculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-peakcalculation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PeakCalculation { get; set; }
            /// <summary>
            /// TargetLkfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-targetlkfs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetLkfs { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// AlgorithmControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-algorithmcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlgorithmControl { get; set; }
            /// <summary>
            /// PeakLimiterThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html#cfn-medialive-channel-audionormalizationsettings-peaklimiterthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PeakLimiterThreshold { get; set; }
        }

        public class AudioOnlyHlsSettings : Humidifier.Base.BaseSubResource, IHaveSegmentType, IHaveAudioTrackType, IHaveMediaLiveChannelTypesInputLocationAudioOnlyImage, IHaveAudioGroupId
        {
            /// <summary>
            /// SegmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-segmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentType { get; set; }
            /// <summary>
            /// AudioTrackType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-audiotracktype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioTrackType { get; set; }
            /// <summary>
            /// AudioOnlyImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-audioonlyimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? AudioOnlyImage { get; set; }
            /// <summary>
            /// AudioGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html#cfn-medialive-channel-audioonlyhlssettings-audiogroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioGroupId { get; set; }
        }

        public class AudioPid : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioDolbyEDecodeDolbyEDecode, IHaveMediaLiveChannelTypesAudioPreMixerSettingsPremixSettings, IHavePid_Integer
        {
            /// <summary>
            /// DolbyEDecode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopid.html#cfn-medialive-channel-audiopid-dolbyedecode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioDolbyEDecode
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioDolbyEDecode, BaseFunction>? DolbyEDecode { get; set; }
            /// <summary>
            /// PremixSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopid.html#cfn-medialive-channel-audiopid-premixsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioPreMixerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioPreMixerSettings, BaseFunction>? PremixSettings { get; set; }
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopid.html#cfn-medialive-channel-audiopid-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Pid { get; set; }
        }

        public class AudioPidSelection : Humidifier.Base.BaseSubResource, IHavePid_Integer, IHaveListOfMediaLiveChannelTypesAudioPidPids
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopidselection.html#cfn-medialive-channel-audiopidselection-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Pid { get; set; }
            /// <summary>
            /// Pids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopidselection.html#cfn-medialive-channel-audiopidselection-pids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioPid
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AudioPid>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AudioPid, BaseFunction>>, BaseFunction>? Pids { get; set; }
        }

        public class AudioPreMixerSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioNormalizationSettingsAudioNormalizationSettings, IHaveMediaLiveChannelTypesRemixSettingsRemixSettings, IHaveGainDb_Double, IHaveChannels_Integer
        {
            /// <summary>
            /// AudioNormalizationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopremixersettings.html#cfn-medialive-channel-audiopremixersettings-audionormalizationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioNormalizationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioNormalizationSettings, BaseFunction>? AudioNormalizationSettings { get; set; }
            /// <summary>
            /// RemixSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopremixersettings.html#cfn-medialive-channel-audiopremixersettings-remixsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RemixSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.RemixSettings, BaseFunction>? RemixSettings { get; set; }
            /// <summary>
            /// GainDb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopremixersettings.html#cfn-medialive-channel-audiopremixersettings-gaindb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? GainDb { get; set; }
            /// <summary>
            /// Channels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopremixersettings.html#cfn-medialive-channel-audiopremixersettings-channels
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Channels { get; set; }
        }

        public class AudioSelector : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioSelectorSettingsSelectorSettings, IHaveName
        {
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html#cfn-medialive-channel-audioselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSelectorSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioSelectorSettings, BaseFunction>? SelectorSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html#cfn-medialive-channel-audioselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AudioSelectorSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioPidSelectionAudioPidSelection, IHaveMediaLiveChannelTypesAudioLanguageSelectionAudioLanguageSelection, IHaveMediaLiveChannelTypesAudioTrackSelectionAudioTrackSelection, IHaveMediaLiveChannelTypesAudioHlsRenditionSelectionAudioHlsRenditionSelection
        {
            /// <summary>
            /// AudioPidSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiopidselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioPidSelection
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioPidSelection, BaseFunction>? AudioPidSelection { get; set; }
            /// <summary>
            /// AudioLanguageSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiolanguageselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioLanguageSelection
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioLanguageSelection, BaseFunction>? AudioLanguageSelection { get; set; }
            /// <summary>
            /// AudioTrackSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiotrackselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioTrackSelection
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioTrackSelection, BaseFunction>? AudioTrackSelection { get; set; }
            /// <summary>
            /// AudioHlsRenditionSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiohlsrenditionselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioHlsRenditionSelection
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioHlsRenditionSelection, BaseFunction>? AudioHlsRenditionSelection { get; set; }
        }

        public class AudioSilenceFailoverSettings : Humidifier.Base.BaseSubResource, IHaveAudioSelectorName, IHaveAudioSilenceThresholdMsec_Integer
        {
            /// <summary>
            /// AudioSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiosilencefailoversettings.html#cfn-medialive-channel-audiosilencefailoversettings-audioselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioSelectorName { get; set; }
            /// <summary>
            /// AudioSilenceThresholdMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiosilencefailoversettings.html#cfn-medialive-channel-audiosilencefailoversettings-audiosilencethresholdmsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AudioSilenceThresholdMsec { get; set; }
        }

        public class AudioTrack : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioPreMixerSettingsPremixSettings, IHaveTrack_Integer
        {
            /// <summary>
            /// PremixSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrack.html#cfn-medialive-channel-audiotrack-premixsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioPreMixerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioPreMixerSettings, BaseFunction>? PremixSettings { get; set; }
            /// <summary>
            /// Track
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrack.html#cfn-medialive-channel-audiotrack-track
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Track { get; set; }
        }

        public class AudioTrackSelection : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioDolbyEDecodeDolbyEDecode, IHaveListOfMediaLiveChannelTypesAudioTrackTracks
        {
            /// <summary>
            /// DolbyEDecode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrackselection.html#cfn-medialive-channel-audiotrackselection-dolbyedecode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioDolbyEDecode
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioDolbyEDecode, BaseFunction>? DolbyEDecode { get; set; }
            /// <summary>
            /// Tracks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrackselection.html#cfn-medialive-channel-audiotrackselection-tracks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioTrack
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AudioTrack>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AudioTrack, BaseFunction>>, BaseFunction>? Tracks { get; set; }
        }

        public class AudioWatermarkSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesNielsenWatermarksSettingsNielsenWatermarksSettings
        {
            /// <summary>
            /// NielsenWatermarksSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiowatermarksettings.html#cfn-medialive-channel-audiowatermarksettings-nielsenwatermarkssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenWatermarksSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.NielsenWatermarksSettings, BaseFunction>? NielsenWatermarksSettings { get; set; }
        }

        public class AutomaticInputFailoverSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveChannelTypesFailoverConditionFailoverConditions, IHaveInputPreference, IHaveSecondaryInputId, IHaveErrorClearTimeMsec_Integer
        {
            /// <summary>
            /// FailoverConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-failoverconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FailoverCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.FailoverCondition>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.FailoverCondition, BaseFunction>>, BaseFunction>? FailoverConditions { get; set; }
            /// <summary>
            /// InputPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-inputpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputPreference { get; set; }
            /// <summary>
            /// SecondaryInputId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-secondaryinputid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecondaryInputId { get; set; }
            /// <summary>
            /// ErrorClearTimeMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html#cfn-medialive-channel-automaticinputfailoversettings-errorcleartimemsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ErrorClearTimeMsec { get; set; }
        }

        public class Av1ColorSpaceSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRec601Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRec709Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsColorSpacePassthroughSettings, IHaveMediaLiveChannelTypesHdr10SettingsHdr10Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsHlg2020Settings
        {
            /// <summary>
            /// Rec601Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1colorspacesettings.html#cfn-medialive-channel-av1colorspacesettings-rec601settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Rec601Settings { get; set; }
            /// <summary>
            /// Rec709Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1colorspacesettings.html#cfn-medialive-channel-av1colorspacesettings-rec709settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Rec709Settings { get; set; }
            /// <summary>
            /// ColorSpacePassthroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1colorspacesettings.html#cfn-medialive-channel-av1colorspacesettings-colorspacepassthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? ColorSpacePassthroughSettings { get; set; }
            /// <summary>
            /// Hdr10Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1colorspacesettings.html#cfn-medialive-channel-av1colorspacesettings-hdr10settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Hdr10Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Hdr10Settings, BaseFunction>? Hdr10Settings { get; set; }
            /// <summary>
            /// Hlg2020Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1colorspacesettings.html#cfn-medialive-channel-av1colorspacesettings-hlg2020settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Hlg2020Settings { get; set; }
        }

        public class Av1Settings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveMediaLiveChannelTypesAv1ColorSpaceSettingsColorSpaceSettings, IHaveSpatialAq, IHaveTemporalAq, IHaveQvbrQualityLevel_Integer, IHaveParDenominator_Integer, IHaveFixedAfd, IHaveGopSizeUnits, IHaveFramerateNumerator_Integer, IHaveAfdSignaling, IHaveBitrate_Integer, IHaveBitDepth, IHaveParNumerator_Integer, IHaveRateControlMode, IHaveBufSize_Integer, IHaveMinBitrate_Integer, IHaveTimecodeInsertion, IHaveMinIInterval_Integer, IHaveSceneChangeDetect, IHaveFramerateDenominator_Integer, IHaveLookAheadRateControl, IHaveLevel, IHaveMaxBitrate_Integer, IHaveGopSize_Double
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings, BaseFunction>? TimecodeBurninSettings { get; set; }
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Av1ColorSpaceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Av1ColorSpaceSettings, BaseFunction>? ColorSpaceSettings { get; set; }
            /// <summary>
            /// SpatialAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-spatialaq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpatialAq { get; set; }
            /// <summary>
            /// TemporalAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-temporalaq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemporalAq { get; set; }
            /// <summary>
            /// QvbrQualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-qvbrqualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QvbrQualityLevel { get; set; }
            /// <summary>
            /// ParDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-pardenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParDenominator { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GopSizeUnits { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateNumerator { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfdSignaling { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// BitDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-bitdepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BitDepth { get; set; }
            /// <summary>
            /// ParNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-parnumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParNumerator { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RateControlMode { get; set; }
            /// <summary>
            /// BufSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-bufsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufSize { get; set; }
            /// <summary>
            /// MinBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-minbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinBitrate { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimecodeInsertion { get; set; }
            /// <summary>
            /// MinIInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-miniinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinIInterval { get; set; }
            /// <summary>
            /// SceneChangeDetect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-scenechangedetect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SceneChangeDetect { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateDenominator { get; set; }
            /// <summary>
            /// LookAheadRateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-lookaheadratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LookAheadRateControl { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBitrate { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-av1settings.html#cfn-medialive-channel-av1settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? GopSize { get; set; }
        }

        public class AvailBlanking : Humidifier.Base.BaseSubResource, IHaveState, IHaveMediaLiveChannelTypesInputLocationAvailBlankingImage
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availblanking.html#cfn-medialive-channel-availblanking-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// AvailBlankingImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availblanking.html#cfn-medialive-channel-availblanking-availblankingimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? AvailBlankingImage { get; set; }
        }

        public class AvailConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAvailSettingsAvailSettings, IHaveScte35SegmentationScope
        {
            /// <summary>
            /// AvailSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availconfiguration.html#cfn-medialive-channel-availconfiguration-availsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AvailSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AvailSettings, BaseFunction>? AvailSettings { get; set; }
            /// <summary>
            /// Scte35SegmentationScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availconfiguration.html#cfn-medialive-channel-availconfiguration-scte35segmentationscope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35SegmentationScope { get; set; }
        }

        public class AvailSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesScte35SpliceInsertTimeSignalAposSettingsScte35SpliceInsert, IHaveMediaLiveChannelTypesScte35SpliceInsertTimeSignalAposSettingsScte35TimeSignalApos, IHaveMediaLiveChannelTypesEsamEsam
        {
            /// <summary>
            /// Scte35SpliceInsert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html#cfn-medialive-channel-availsettings-scte35spliceinsert
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte35SpliceInsertTimeSignalAposSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings, BaseFunction>? Scte35SpliceInsert { get; set; }
            /// <summary>
            /// Scte35TimeSignalApos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html#cfn-medialive-channel-availsettings-scte35timesignalapos
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte35SpliceInsertTimeSignalAposSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings, BaseFunction>? Scte35TimeSignalApos { get; set; }
            /// <summary>
            /// Esam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html#cfn-medialive-channel-availsettings-esam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Esam
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Esam, BaseFunction>? Esam { get; set; }
        }

        public class BandwidthReductionFilterSettings : Humidifier.Base.BaseSubResource, IHavePostFilterSharpening, IHaveStrength
        {
            /// <summary>
            /// PostFilterSharpening
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-bandwidthreductionfiltersettings.html#cfn-medialive-channel-bandwidthreductionfiltersettings-postfiltersharpening
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostFilterSharpening { get; set; }
            /// <summary>
            /// Strength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-bandwidthreductionfiltersettings.html#cfn-medialive-channel-bandwidthreductionfiltersettings-strength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strength { get; set; }
        }

        public class BlackoutSlate : Humidifier.Base.BaseSubResource, IHaveNetworkEndBlackout, IHaveState, IHaveNetworkId, IHaveMediaLiveChannelTypesInputLocationNetworkEndBlackoutImage, IHaveMediaLiveChannelTypesInputLocationBlackoutSlateImage
        {
            /// <summary>
            /// NetworkEndBlackout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-networkendblackout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkEndBlackout { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// NetworkId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-networkid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkId { get; set; }
            /// <summary>
            /// NetworkEndBlackoutImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-networkendblackoutimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? NetworkEndBlackoutImage { get; set; }
            /// <summary>
            /// BlackoutSlateImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html#cfn-medialive-channel-blackoutslate-blackoutslateimage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? BlackoutSlateImage { get; set; }
        }

        public class BurnInDvbSubDestinationSettings : Humidifier.Base.BaseSubResource, IHaveBackgroundOpacity_Integer, IHaveFontResolution_Integer, IHaveOutlineColor, IHaveFontColor, IHaveShadowColor, IHaveShadowOpacity_Integer, IHaveMediaLiveChannelTypesInputLocationFont, IHaveShadowYOffset_Integer, IHaveAlignment, IHaveXPosition_Integer, IHaveFontSize, IHaveYPosition_Integer, IHaveOutlineSize_Integer, IHaveTeletextGridControl, IHaveSubtitleRows, IHaveFontOpacity_Integer, IHaveShadowXOffset_Integer, IHaveBackgroundColor
        {
            /// <summary>
            /// BackgroundOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-backgroundopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BackgroundOpacity { get; set; }
            /// <summary>
            /// FontResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-fontresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FontResolution { get; set; }
            /// <summary>
            /// OutlineColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-outlinecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutlineColor { get; set; }
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontColor { get; set; }
            /// <summary>
            /// ShadowColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-shadowcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShadowColor { get; set; }
            /// <summary>
            /// ShadowOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-shadowopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ShadowOpacity { get; set; }
            /// <summary>
            /// Font
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-font
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? Font { get; set; }
            /// <summary>
            /// ShadowYOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-shadowyoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ShadowYOffset { get; set; }
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alignment { get; set; }
            /// <summary>
            /// XPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-xposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? XPosition { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontSize { get; set; }
            /// <summary>
            /// YPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-yposition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? YPosition { get; set; }
            /// <summary>
            /// OutlineSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-outlinesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OutlineSize { get; set; }
            /// <summary>
            /// TeletextGridControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-teletextgridcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TeletextGridControl { get; set; }
            /// <summary>
            /// SubtitleRows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-subtitlerows
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubtitleRows { get; set; }
            /// <summary>
            /// FontOpacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-fontopacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FontOpacity { get; set; }
            /// <summary>
            /// ShadowXOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-shadowxoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ShadowXOffset { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindvbsubdestinationsettings.html#cfn-medialive-channel-burnindvbsubdestinationsettings-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackgroundColor { get; set; }
        }

        public class CaptionDescription : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesCaptionDestinationSettingsDestinationSettings, IHaveLanguageCode, IHaveLanguageDescription, IHaveAccessibility, IHaveDvbDashAccessibility, IHaveCaptionSelectorName, IHaveStringListOfCaptionDashRoles, IHaveName
        {
            /// <summary>
            /// DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CaptionDestinationSettings, BaseFunction>? DestinationSettings { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// LanguageDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-languagedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageDescription { get; set; }
            /// <summary>
            /// Accessibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-accessibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Accessibility { get; set; }
            /// <summary>
            /// DvbDashAccessibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-dvbdashaccessibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DvbDashAccessibility { get; set; }
            /// <summary>
            /// CaptionSelectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-captionselectorname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaptionSelectorName { get; set; }
            /// <summary>
            /// CaptionDashRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-captiondashroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CaptionDashRoles { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html#cfn-medialive-channel-captiondescription-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CaptionDestinationSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsAribDestinationSettings, IHaveMediaLiveChannelTypesEbuTtDDestinationSettingsEbuTtDDestinationSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsSmpteTtDestinationSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsEmbeddedPlusScte20DestinationSettings, IHaveMediaLiveChannelTypesTtmlDestinationSettingsTtmlDestinationSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsScte20PlusEmbeddedDestinationSettings, IHaveMediaLiveChannelTypesBurnInDvbSubDestinationSettingsDvbSubDestinationSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsTeletextDestinationSettings, IHaveMediaLiveChannelTypesBurnInDvbSubDestinationSettingsBurnInDestinationSettings, IHaveMediaLiveChannelTypesWebvttDestinationSettingsWebvttDestinationSettings, IHaveMediaLiveChannelTypesEmbeddedDestinationSettingsEmbeddedDestinationSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRtmpCaptionInfoDestinationSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsScte27DestinationSettings
        {
            /// <summary>
            /// AribDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-aribdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? AribDestinationSettings { get; set; }
            /// <summary>
            /// EbuTtDDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-ebuttddestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbuTtDDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EbuTtDDestinationSettings, BaseFunction>? EbuTtDDestinationSettings { get; set; }
            /// <summary>
            /// SmpteTtDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-smptettdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? SmpteTtDestinationSettings { get; set; }
            /// <summary>
            /// EmbeddedPlusScte20DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-embeddedplusscte20destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? EmbeddedPlusScte20DestinationSettings { get; set; }
            /// <summary>
            /// TtmlDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-ttmldestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TtmlDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TtmlDestinationSettings, BaseFunction>? TtmlDestinationSettings { get; set; }
            /// <summary>
            /// Scte20PlusEmbeddedDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-scte20plusembeddeddestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Scte20PlusEmbeddedDestinationSettings { get; set; }
            /// <summary>
            /// DvbSubDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-dvbsubdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BurnInDvbSubDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.BurnInDvbSubDestinationSettings, BaseFunction>? DvbSubDestinationSettings { get; set; }
            /// <summary>
            /// TeletextDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-teletextdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? TeletextDestinationSettings { get; set; }
            /// <summary>
            /// BurnInDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-burnindestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BurnInDvbSubDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.BurnInDvbSubDestinationSettings, BaseFunction>? BurnInDestinationSettings { get; set; }
            /// <summary>
            /// WebvttDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-webvttdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebvttDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.WebvttDestinationSettings, BaseFunction>? WebvttDestinationSettings { get; set; }
            /// <summary>
            /// EmbeddedDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-embeddeddestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmbeddedDestinationSettings, BaseFunction>? EmbeddedDestinationSettings { get; set; }
            /// <summary>
            /// RtmpCaptionInfoDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-rtmpcaptioninfodestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? RtmpCaptionInfoDestinationSettings { get; set; }
            /// <summary>
            /// Scte27DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html#cfn-medialive-channel-captiondestinationsettings-scte27destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Scte27DestinationSettings { get; set; }
        }

        public class CaptionLanguageMapping : Humidifier.Base.BaseSubResource, IHaveLanguageCode, IHaveLanguageDescription, IHaveCaptionChannel_Integer
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html#cfn-medialive-channel-captionlanguagemapping-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// LanguageDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html#cfn-medialive-channel-captionlanguagemapping-languagedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageDescription { get; set; }
            /// <summary>
            /// CaptionChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html#cfn-medialive-channel-captionlanguagemapping-captionchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CaptionChannel { get; set; }
        }

        public class CaptionRectangle : Humidifier.Base.BaseSubResource, IHaveTopOffset_Double, IHaveHeight_Double, IHaveWidth_Double, IHaveLeftOffset_Double
        {
            /// <summary>
            /// TopOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-topoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopOffset { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Width { get; set; }
            /// <summary>
            /// LeftOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html#cfn-medialive-channel-captionrectangle-leftoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LeftOffset { get; set; }
        }

        public class CaptionSelector : Humidifier.Base.BaseSubResource, IHaveLanguageCode, IHaveMediaLiveChannelTypesCaptionSelectorSettingsSelectorSettings, IHaveName
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionSelectorSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CaptionSelectorSettings, BaseFunction>? SelectorSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CaptionSelectorSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesScte27DvbSubSourceSettingsDvbSubSourceSettings, IHaveMediaLiveChannelTypesScte27DvbSubSourceSettingsScte27SourceSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsAribSourceSettings, IHaveMediaLiveChannelTypesEmbeddedSourceSettingsEmbeddedSourceSettings, IHaveMediaLiveChannelTypesScte20SourceSettingsScte20SourceSettings, IHaveMediaLiveChannelTypesTeletextSourceSettingsTeletextSourceSettings, IHaveMediaLiveChannelTypesSmartSubtitleSourceSettingsSmartSubtitleSourceSettings, IHaveMediaLiveChannelTypesAncillarySourceSettingsAncillarySourceSettings
        {
            /// <summary>
            /// DvbSubSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-dvbsubsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte27DvbSubSourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Scte27DvbSubSourceSettings, BaseFunction>? DvbSubSourceSettings { get; set; }
            /// <summary>
            /// Scte27SourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-scte27sourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte27DvbSubSourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Scte27DvbSubSourceSettings, BaseFunction>? Scte27SourceSettings { get; set; }
            /// <summary>
            /// AribSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-aribsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? AribSourceSettings { get; set; }
            /// <summary>
            /// EmbeddedSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-embeddedsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedSourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmbeddedSourceSettings, BaseFunction>? EmbeddedSourceSettings { get; set; }
            /// <summary>
            /// Scte20SourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-scte20sourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte20SourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Scte20SourceSettings, BaseFunction>? Scte20SourceSettings { get; set; }
            /// <summary>
            /// TeletextSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-teletextsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TeletextSourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TeletextSourceSettings, BaseFunction>? TeletextSourceSettings { get; set; }
            /// <summary>
            /// SmartSubtitleSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-smartsubtitlesourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmartSubtitleSourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.SmartSubtitleSourceSettings, BaseFunction>? SmartSubtitleSourceSettings { get; set; }
            /// <summary>
            /// AncillarySourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-ancillarysourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AncillarySourceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AncillarySourceSettings, BaseFunction>? AncillarySourceSettings { get; set; }
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
            public Union<string, BaseFunction>? Resolution { get; set; }
        }

        public class ChannelEngineVersionRequest : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-channelengineversionrequest.html#cfn-medialive-channel-channelengineversionrequest-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class CmafIngestCaptionLanguageMapping : Humidifier.Base.BaseSubResource, IHaveLanguageCode, IHaveCaptionChannel_Integer
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestcaptionlanguagemapping.html#cfn-medialive-channel-cmafingestcaptionlanguagemapping-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// CaptionChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestcaptionlanguagemapping.html#cfn-medialive-channel-cmafingestcaptionlanguagemapping-captionchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CaptionChannel { get; set; }
        }

        public class CmafIngestFrameCaptureOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestframecaptureoutputsettings.html#cfn-medialive-channel-cmafingestframecaptureoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NameModifier { get; set; }
        }

        public class CmafIngestGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveKlvNameModifier, IHaveScte35Type, IHaveTimedMetadataId3Frame, IHaveTimedMetadataPassthrough, IHaveNielsenId3Behavior, IHaveScte35NameModifier, IHaveListOfMediaLiveChannelTypesCmafIngestCaptionLanguageMappingCaptionLanguageMappings, IHaveMediaLiveChannelTypesCmafIngestWatermarkingSettingsWatermarkingSettings, IHaveSegmentLengthUnits, IHaveTimedMetadataId3Period_Integer, IHaveListOfMediaLiveChannelTypesAdditionalDestinationsAdditionalDestinations, IHaveNielsenId3NameModifier, IHaveKlvBehavior, IHaveSegmentLength_Integer, IHaveId3Behavior, IHaveSendDelayMs_Integer, IHaveId3NameModifier
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// KlvNameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-klvnamemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KlvNameModifier { get; set; }
            /// <summary>
            /// Scte35Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-scte35type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Type { get; set; }
            /// <summary>
            /// TimedMetadataId3Frame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-timedmetadataid3frame
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataId3Frame { get; set; }
            /// <summary>
            /// TimedMetadataPassthrough
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-timedmetadatapassthrough
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataPassthrough { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3Behavior { get; set; }
            /// <summary>
            /// Scte35NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-scte35namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35NameModifier { get; set; }
            /// <summary>
            /// CaptionLanguageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-captionlanguagemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CmafIngestCaptionLanguageMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.CmafIngestCaptionLanguageMapping>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.CmafIngestCaptionLanguageMapping, BaseFunction>>, BaseFunction>? CaptionLanguageMappings { get; set; }
            /// <summary>
            /// WatermarkingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-watermarkingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestWatermarkingSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CmafIngestWatermarkingSettings, BaseFunction>? WatermarkingSettings { get; set; }
            /// <summary>
            /// SegmentLengthUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-segmentlengthunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentLengthUnits { get; set; }
            /// <summary>
            /// TimedMetadataId3Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-timedmetadataid3period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimedMetadataId3Period { get; set; }
            /// <summary>
            /// AdditionalDestinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-additionaldestinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdditionalDestinations
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AdditionalDestinations>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AdditionalDestinations, BaseFunction>>, BaseFunction>? AdditionalDestinations { get; set; }
            /// <summary>
            /// NielsenId3NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-nielsenid3namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3NameModifier { get; set; }
            /// <summary>
            /// KlvBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-klvbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KlvBehavior { get; set; }
            /// <summary>
            /// SegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-segmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentLength { get; set; }
            /// <summary>
            /// Id3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-id3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id3Behavior { get; set; }
            /// <summary>
            /// SendDelayMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-senddelayms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SendDelayMs { get; set; }
            /// <summary>
            /// Id3NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestgroupsettings.html#cfn-medialive-channel-cmafingestgroupsettings-id3namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id3NameModifier { get; set; }
        }

        public class CmafIngestMediaPackageV2AbWatermarkerIrdetoSettings : Humidifier.Base.BaseSubResource, IHaveWatermarkIdLength, IHaveListOfMediaLiveChannelTypesOutputLocationRefAdditionalDestinationsAlternateDestinations, IHavePolyPeriod_Integer, IHaveMediaLiveChannelTypesOutputLocationRefAlternateDestination, IHaveLicense, IHaveMediaLiveChannelTypesAbWatermarkingCustomProfileCustomProfile, IHaveOperatorId_Integer, IHaveProfile
        {
            /// <summary>
            /// WatermarkIdLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-watermarkidlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WatermarkIdLength { get; set; }
            /// <summary>
            /// AdditionalDestinationsAlternateDestinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-additionaldestinationsalternatedestinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputLocationRef
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.OutputLocationRef>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>>, BaseFunction>? AdditionalDestinationsAlternateDestinations { get; set; }
            /// <summary>
            /// PolyPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-polyperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PolyPeriod { get; set; }
            /// <summary>
            /// AlternateDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-alternatedestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? AlternateDestination { get; set; }
            /// <summary>
            /// License
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-license
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? License { get; set; }
            /// <summary>
            /// CustomProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-customprofile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbWatermarkingCustomProfile
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AbWatermarkingCustomProfile, BaseFunction>? CustomProfile { get; set; }
            /// <summary>
            /// OperatorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-operatorid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OperatorId { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings.html#cfn-medialive-channel-cmafingestmediapackagev2abwatermarkerirdetosettings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
        }

        public class CmafIngestWatermarkingSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesCmafIngestMediaPackageV2AbWatermarkerIrdetoSettingsCmafIngestAbWatermarkerIrdetoSettings
        {
            /// <summary>
            /// CmafIngestAbWatermarkerIrdetoSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cmafingestwatermarkingsettings.html#cfn-medialive-channel-cmafingestwatermarkingsettings-cmafingestabwatermarkerirdetosettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestMediaPackageV2AbWatermarkerIrdetoSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CmafIngestMediaPackageV2AbWatermarkerIrdetoSettings, BaseFunction>? CmafIngestAbWatermarkerIrdetoSettings { get; set; }
        }

        public class ColorCorrection : Humidifier.Base.BaseSubResource, IHaveOutputColorSpace, IHaveInputColorSpace, IHaveUri
        {
            /// <summary>
            /// OutputColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrection.html#cfn-medialive-channel-colorcorrection-outputcolorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputColorSpace { get; set; }
            /// <summary>
            /// InputColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrection.html#cfn-medialive-channel-colorcorrection-inputcolorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputColorSpace { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrection.html#cfn-medialive-channel-colorcorrection-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class ColorCorrectionSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveChannelTypesColorCorrectionGlobalColorCorrections
        {
            /// <summary>
            /// GlobalColorCorrections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-colorcorrectionsettings.html#cfn-medialive-channel-colorcorrectionsettings-globalcolorcorrections
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColorCorrection
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.ColorCorrection>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.ColorCorrection, BaseFunction>>, BaseFunction>? GlobalColorCorrections { get; set; }
        }

        public class DisabledLockingSettings : Humidifier.Base.BaseSubResource, IHaveCustomEpoch
        {
            /// <summary>
            /// CustomEpoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-disabledlockingsettings.html#cfn-medialive-channel-disabledlockingsettings-customepoch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEpoch { get; set; }
        }

        public class DvbNitSettings : Humidifier.Base.BaseSubResource, IHaveNetworkName, IHaveRepInterval_Integer, IHaveNetworkId_Integer
        {
            /// <summary>
            /// NetworkName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html#cfn-medialive-channel-dvbnitsettings-networkname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkName { get; set; }
            /// <summary>
            /// RepInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html#cfn-medialive-channel-dvbnitsettings-repinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RepInterval { get; set; }
            /// <summary>
            /// NetworkId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbnitsettings.html#cfn-medialive-channel-dvbnitsettings-networkid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NetworkId { get; set; }
        }

        public class DvbSdtSettings : Humidifier.Base.BaseSubResource, IHaveServiceProviderName, IHaveOutputSdt, IHaveServiceName, IHaveRepInterval_Integer
        {
            /// <summary>
            /// ServiceProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-serviceprovidername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceProviderName { get; set; }
            /// <summary>
            /// OutputSdt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-outputsdt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputSdt { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// RepInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html#cfn-medialive-channel-dvbsdtsettings-repinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RepInterval { get; set; }
        }

        public class DvbTdtSettings : Humidifier.Base.BaseSubResource, IHaveRepInterval_Integer
        {
            /// <summary>
            /// RepInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbtdtsettings.html#cfn-medialive-channel-dvbtdtsettings-repinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RepInterval { get; set; }
        }

        public class Eac3AtmosSettings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveDialnorm_Integer, IHaveSurroundTrim_Double, IHaveDrcRf, IHaveBitrate_Double, IHaveDrcLine, IHaveHeightTrim_Double
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodingMode { get; set; }
            /// <summary>
            /// Dialnorm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-dialnorm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dialnorm { get; set; }
            /// <summary>
            /// SurroundTrim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-surroundtrim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SurroundTrim { get; set; }
            /// <summary>
            /// DrcRf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-drcrf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrcRf { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// DrcLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-drcline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrcLine { get; set; }
            /// <summary>
            /// HeightTrim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3atmossettings.html#cfn-medialive-channel-eac3atmossettings-heighttrim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? HeightTrim { get; set; }
        }

        public class Eac3Settings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveSurroundMode, IHavePassthroughControl, IHaveDialnorm_Integer, IHaveLoRoSurroundMixLevel_Double, IHavePhaseControl, IHaveLtRtCenterMixLevel_Double, IHaveLfeFilter, IHaveLfeControl, IHaveBitrate_Double, IHaveDrcLine, IHaveDcFilter, IHaveMetadataControl, IHaveLtRtSurroundMixLevel_Double, IHaveLoRoCenterMixLevel_Double, IHaveDrcRf, IHaveAttenuationControl, IHaveBitstreamMode, IHaveSurroundExMode, IHaveStereoDownmix
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodingMode { get; set; }
            /// <summary>
            /// SurroundMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-surroundmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SurroundMode { get; set; }
            /// <summary>
            /// PassthroughControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-passthroughcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassthroughControl { get; set; }
            /// <summary>
            /// Dialnorm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-dialnorm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dialnorm { get; set; }
            /// <summary>
            /// LoRoSurroundMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lorosurroundmixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LoRoSurroundMixLevel { get; set; }
            /// <summary>
            /// PhaseControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-phasecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PhaseControl { get; set; }
            /// <summary>
            /// LtRtCenterMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-ltrtcentermixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LtRtCenterMixLevel { get; set; }
            /// <summary>
            /// LfeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lfefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LfeFilter { get; set; }
            /// <summary>
            /// LfeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lfecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LfeControl { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// DrcLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-drcline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrcLine { get; set; }
            /// <summary>
            /// DcFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-dcfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DcFilter { get; set; }
            /// <summary>
            /// MetadataControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-metadatacontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataControl { get; set; }
            /// <summary>
            /// LtRtSurroundMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-ltrtsurroundmixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LtRtSurroundMixLevel { get; set; }
            /// <summary>
            /// LoRoCenterMixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-lorocentermixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LoRoCenterMixLevel { get; set; }
            /// <summary>
            /// DrcRf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-drcrf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DrcRf { get; set; }
            /// <summary>
            /// AttenuationControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-attenuationcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttenuationControl { get; set; }
            /// <summary>
            /// BitstreamMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-bitstreammode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BitstreamMode { get; set; }
            /// <summary>
            /// SurroundExMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-surroundexmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SurroundExMode { get; set; }
            /// <summary>
            /// StereoDownmix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html#cfn-medialive-channel-eac3settings-stereodownmix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StereoDownmix { get; set; }
        }

        public class EbuTtDDestinationSettings : Humidifier.Base.BaseSubResource, IHaveFontFamily, IHaveDefaultFontSize_Integer, IHaveDefaultLineHeight_Integer, IHaveFillLineGap, IHaveStyleControl, IHaveCopyrightHolder
        {
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontFamily { get; set; }
            /// <summary>
            /// DefaultFontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-defaultfontsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DefaultFontSize { get; set; }
            /// <summary>
            /// DefaultLineHeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-defaultlineheight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DefaultLineHeight { get; set; }
            /// <summary>
            /// FillLineGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-filllinegap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FillLineGap { get; set; }
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StyleControl { get; set; }
            /// <summary>
            /// CopyrightHolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html#cfn-medialive-channel-ebuttddestinationsettings-copyrightholder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CopyrightHolder { get; set; }
        }

        public class EmbeddedCaptionPositionSettings : Humidifier.Base.BaseSubResource, IHaveYPositionLine_Integer
        {
            /// <summary>
            /// YPositionLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedcaptionpositionsettings.html#cfn-medialive-channel-embeddedcaptionpositionsettings-ypositionline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? YPositionLine { get; set; }
        }

        public class EmbeddedDestinationSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmbeddedCaptionPositionSettingsPosition, IHaveStyleControl
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddeddestinationsettings.html#cfn-medialive-channel-embeddeddestinationsettings-position
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedCaptionPositionSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmbeddedCaptionPositionSettings, BaseFunction>? Position { get; set; }
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddeddestinationsettings.html#cfn-medialive-channel-embeddeddestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StyleControl { get; set; }
        }

        public class EmbeddedSourceSettings : Humidifier.Base.BaseSubResource, IHaveSource608ChannelNumber_Integer, IHaveScte20Detection, IHaveSource608TrackNumber_Integer, IHaveConvert608To708
        {
            /// <summary>
            /// Source608ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Source608ChannelNumber { get; set; }
            /// <summary>
            /// Scte20Detection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-scte20detection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte20Detection { get; set; }
            /// <summary>
            /// Source608TrackNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608tracknumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Source608TrackNumber { get; set; }
            /// <summary>
            /// Convert608To708
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-convert608to708
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Convert608To708 { get; set; }
        }

        public class EmptyConfigurationSettings : Humidifier.Base.BaseSubResource
        {
        }

        public class EncoderSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveChannelTypesAudioDescriptionAudioDescriptions, IHaveListOfMediaLiveChannelTypesVideoDescriptionVideoDescriptions, IHaveMediaLiveChannelTypesGlobalConfigurationGlobalConfiguration, IHaveMediaLiveChannelTypesMotionGraphicsConfigurationMotionGraphicsConfiguration, IHaveMediaLiveChannelTypesThumbnailConfigurationThumbnailConfiguration, IHaveMediaLiveChannelTypesFeatureActivationsFeatureActivations, IHaveListOfMediaLiveChannelTypesCaptionDescriptionCaptionDescriptions, IHaveMediaLiveChannelTypesAvailConfigurationAvailConfiguration, IHaveMediaLiveChannelTypesColorCorrectionSettingsColorCorrectionSettings, IHaveListOfMediaLiveChannelTypesOutputGroupOutputGroups, IHaveMediaLiveChannelTypesAvailBlankingAvailBlanking, IHaveMediaLiveChannelTypesNielsenConfigurationNielsenConfiguration, IHaveMediaLiveChannelTypesBlackoutSlateBlackoutSlate, IHaveMediaLiveChannelTypesTimecodeConfigTimecodeConfig
        {
            /// <summary>
            /// AudioDescriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-audiodescriptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioDescription
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AudioDescription>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AudioDescription, BaseFunction>>, BaseFunction>? AudioDescriptions { get; set; }
            /// <summary>
            /// VideoDescriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-videodescriptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VideoDescription
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.VideoDescription>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.VideoDescription, BaseFunction>>, BaseFunction>? VideoDescriptions { get; set; }
            /// <summary>
            /// GlobalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-globalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalConfiguration
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.GlobalConfiguration, BaseFunction>? GlobalConfiguration { get; set; }
            /// <summary>
            /// MotionGraphicsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-motiongraphicsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MotionGraphicsConfiguration
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration, BaseFunction>? MotionGraphicsConfiguration { get; set; }
            /// <summary>
            /// ThumbnailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-thumbnailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThumbnailConfiguration
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration, BaseFunction>? ThumbnailConfiguration { get; set; }
            /// <summary>
            /// FeatureActivations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-featureactivations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FeatureActivations
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FeatureActivations, BaseFunction>? FeatureActivations { get; set; }
            /// <summary>
            /// CaptionDescriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-captiondescriptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionDescription
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.CaptionDescription>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.CaptionDescription, BaseFunction>>, BaseFunction>? CaptionDescriptions { get; set; }
            /// <summary>
            /// AvailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-availconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AvailConfiguration
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AvailConfiguration, BaseFunction>? AvailConfiguration { get; set; }
            /// <summary>
            /// ColorCorrectionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-colorcorrectionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColorCorrectionSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings, BaseFunction>? ColorCorrectionSettings { get; set; }
            /// <summary>
            /// OutputGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-outputgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.OutputGroup>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.OutputGroup, BaseFunction>>, BaseFunction>? OutputGroups { get; set; }
            /// <summary>
            /// AvailBlanking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-availblanking
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AvailBlanking
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AvailBlanking, BaseFunction>? AvailBlanking { get; set; }
            /// <summary>
            /// NielsenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-nielsenconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenConfiguration
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.NielsenConfiguration, BaseFunction>? NielsenConfiguration { get; set; }
            /// <summary>
            /// BlackoutSlate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-blackoutslate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlackoutSlate
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.BlackoutSlate, BaseFunction>? BlackoutSlate { get; set; }
            /// <summary>
            /// TimecodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html#cfn-medialive-channel-encodersettings-timecodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeConfig
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TimecodeConfig, BaseFunction>? TimecodeConfig { get; set; }
        }

        public class EpochLockingSettings : Humidifier.Base.BaseSubResource, IHaveJamSyncTime, IHaveCustomEpoch
        {
            /// <summary>
            /// JamSyncTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-epochlockingsettings.html#cfn-medialive-channel-epochlockingsettings-jamsynctime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JamSyncTime { get; set; }
            /// <summary>
            /// CustomEpoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-epochlockingsettings.html#cfn-medialive-channel-epochlockingsettings-customepoch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEpoch { get; set; }
        }

        public class Esam : Humidifier.Base.BaseSubResource, IHaveAdAvailOffset_Integer, IHaveZoneIdentity, IHaveAcquisitionPointId, IHavePoisEndpoint, IHaveUsername, IHavePasswordParam
        {
            /// <summary>
            /// AdAvailOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-adavailoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AdAvailOffset { get; set; }
            /// <summary>
            /// ZoneIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-zoneidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZoneIdentity { get; set; }
            /// <summary>
            /// AcquisitionPointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-acquisitionpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AcquisitionPointId { get; set; }
            /// <summary>
            /// PoisEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-poisendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PoisEndpoint { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-esam.html#cfn-medialive-channel-esam-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PasswordParam { get; set; }
        }

        public class FailoverCondition : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesFailoverConditionSettingsFailoverConditionSettings
        {
            /// <summary>
            /// FailoverConditionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failovercondition.html#cfn-medialive-channel-failovercondition-failoverconditionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailoverConditionSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FailoverConditionSettings, BaseFunction>? FailoverConditionSettings { get; set; }
        }

        public class FailoverConditionSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesAudioSilenceFailoverSettingsAudioSilenceSettings, IHaveMediaLiveChannelTypesVideoBlackFailoverSettingsVideoBlackSettings, IHaveMediaLiveChannelTypesInputLossFailoverSettingsInputLossSettings
        {
            /// <summary>
            /// AudioSilenceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html#cfn-medialive-channel-failoverconditionsettings-audiosilencesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSilenceFailoverSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioSilenceFailoverSettings, BaseFunction>? AudioSilenceSettings { get; set; }
            /// <summary>
            /// VideoBlackSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html#cfn-medialive-channel-failoverconditionsettings-videoblacksettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoBlackFailoverSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoBlackFailoverSettings, BaseFunction>? VideoBlackSettings { get; set; }
            /// <summary>
            /// InputLossSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failoverconditionsettings.html#cfn-medialive-channel-failoverconditionsettings-inputlosssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLossFailoverSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLossFailoverSettings, BaseFunction>? InputLossSettings { get; set; }
        }

        public class FeatureActivations : Humidifier.Base.BaseSubResource, IHaveInputPrepareScheduleActions, IHaveOutputStaticImageOverlayScheduleActions
        {
            /// <summary>
            /// InputPrepareScheduleActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-featureactivations.html#cfn-medialive-channel-featureactivations-inputpreparescheduleactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputPrepareScheduleActions { get; set; }
            /// <summary>
            /// OutputStaticImageOverlayScheduleActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-featureactivations.html#cfn-medialive-channel-featureactivations-outputstaticimageoverlayscheduleactions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputStaticImageOverlayScheduleActions { get; set; }
        }

        public class FecOutputSettings : Humidifier.Base.BaseSubResource, IHaveRowLength_Integer, IHaveColumnDepth_Integer, IHaveIncludeFec
        {
            /// <summary>
            /// RowLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html#cfn-medialive-channel-fecoutputsettings-rowlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RowLength { get; set; }
            /// <summary>
            /// ColumnDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html#cfn-medialive-channel-fecoutputsettings-columndepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ColumnDepth { get; set; }
            /// <summary>
            /// IncludeFec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html#cfn-medialive-channel-fecoutputsettings-includefec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludeFec { get; set; }
        }

        public class Fmp4HlsSettings : Humidifier.Base.BaseSubResource, IHaveAudioRenditionSets, IHaveNielsenId3Behavior, IHaveTimedMetadataBehavior
        {
            /// <summary>
            /// AudioRenditionSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html#cfn-medialive-channel-fmp4hlssettings-audiorenditionsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioRenditionSets { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html#cfn-medialive-channel-fmp4hlssettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3Behavior { get; set; }
            /// <summary>
            /// TimedMetadataBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html#cfn-medialive-channel-fmp4hlssettings-timedmetadatabehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataBehavior { get; set; }
        }

        public class FollowerChannelSettings : Humidifier.Base.BaseSubResource, IHavePrimaryChannelArn, IHaveLinkedChannelType
        {
            /// <summary>
            /// PrimaryChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-followerchannelsettings.html#cfn-medialive-channel-followerchannelsettings-primarychannelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryChannelArn { get; set; }
            /// <summary>
            /// LinkedChannelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-followerchannelsettings.html#cfn-medialive-channel-followerchannelsettings-linkedchanneltype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LinkedChannelType { get; set; }
        }

        public class FrameCaptureCdnSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesArchiveFrameCaptureHlsS3SettingsFrameCaptureS3Settings
        {
            /// <summary>
            /// FrameCaptureS3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturecdnsettings.html#cfn-medialive-channel-framecapturecdnsettings-framecaptures3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveFrameCaptureHlsS3Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveFrameCaptureHlsS3Settings, BaseFunction>? FrameCaptureS3Settings { get; set; }
        }

        public class FrameCaptureGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesFrameCaptureCdnSettingsFrameCaptureCdnSettings, IHaveMediaLiveChannelTypesOutputLocationRefDestination
        {
            /// <summary>
            /// FrameCaptureCdnSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturegroupsettings.html#cfn-medialive-channel-framecapturegroupsettings-framecapturecdnsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureCdnSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FrameCaptureCdnSettings, BaseFunction>? FrameCaptureCdnSettings { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturegroupsettings.html#cfn-medialive-channel-framecapturegroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
        }

        public class FrameCaptureSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveCaptureInterval_Integer, IHaveCaptureIntervalUnits
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html#cfn-medialive-channel-framecapturesettings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings, BaseFunction>? TimecodeBurninSettings { get; set; }
            /// <summary>
            /// CaptureInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html#cfn-medialive-channel-framecapturesettings-captureinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CaptureInterval { get; set; }
            /// <summary>
            /// CaptureIntervalUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturesettings.html#cfn-medialive-channel-framecapturesettings-captureintervalunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaptureIntervalUnits { get; set; }
        }

        public class GlobalConfiguration : Humidifier.Base.BaseSubResource, IHaveInputEndAction, IHaveMediaLiveChannelTypesOutputLockingSettingsOutputLockingSettings, IHaveOutputTimingSource, IHaveOutputLockingMode, IHaveSupportLowFramerateInputs, IHaveInitialAudioGain_Integer, IHaveMediaLiveChannelTypesInputLossBehaviorInputLossBehavior
        {
            /// <summary>
            /// InputEndAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-inputendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputEndAction { get; set; }
            /// <summary>
            /// OutputLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputlockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLockingSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLockingSettings, BaseFunction>? OutputLockingSettings { get; set; }
            /// <summary>
            /// OutputTimingSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputtimingsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputTimingSource { get; set; }
            /// <summary>
            /// OutputLockingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputlockingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputLockingMode { get; set; }
            /// <summary>
            /// SupportLowFramerateInputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-supportlowframerateinputs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SupportLowFramerateInputs { get; set; }
            /// <summary>
            /// InitialAudioGain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-initialaudiogain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InitialAudioGain { get; set; }
            /// <summary>
            /// InputLossBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-inputlossbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLossBehavior
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLossBehavior, BaseFunction>? InputLossBehavior { get; set; }
        }

        public class H264ColorSpaceSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRec601Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRec709Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsColorSpacePassthroughSettings
        {
            /// <summary>
            /// Rec601Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264colorspacesettings.html#cfn-medialive-channel-h264colorspacesettings-rec601settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Rec601Settings { get; set; }
            /// <summary>
            /// Rec709Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264colorspacesettings.html#cfn-medialive-channel-h264colorspacesettings-rec709settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Rec709Settings { get; set; }
            /// <summary>
            /// ColorSpacePassthroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264colorspacesettings.html#cfn-medialive-channel-h264colorspacesettings-colorspacepassthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? ColorSpacePassthroughSettings { get; set; }
        }

        public class H264H265FilterSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTemporalFilterSettingsTemporalFilterSettings, IHaveMediaLiveChannelTypesBandwidthReductionFilterSettingsBandwidthReductionFilterSettings
        {
            /// <summary>
            /// TemporalFilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264h265filtersettings.html#cfn-medialive-channel-h264h265filtersettings-temporalfiltersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemporalFilterSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TemporalFilterSettings, BaseFunction>? TemporalFilterSettings { get; set; }
            /// <summary>
            /// BandwidthReductionFilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264h265filtersettings.html#cfn-medialive-channel-h264h265filtersettings-bandwidthreductionfiltersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BandwidthReductionFilterSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.BandwidthReductionFilterSettings, BaseFunction>? BandwidthReductionFilterSettings { get; set; }
        }

        public class H264Settings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveNumRefFrames_Integer, IHaveTemporalAq, IHaveSlices_Integer, IHaveFramerateControl, IHaveQvbrQualityLevel_Integer, IHaveFramerateNumerator_Integer, IHaveParControl, IHaveGopClosedCadence_Integer, IHaveFlickerAq, IHaveProfile, IHaveQualityLevel, IHaveMinBitrate_Integer, IHaveMinIInterval_Integer, IHaveSceneChangeDetect, IHaveForceFieldPictures, IHaveFramerateDenominator_Integer, IHaveSoftness_Integer, IHaveGopSize_Double, IHaveAdaptiveQuantization, IHaveMediaLiveChannelTypesH264H265FilterSettingsFilterSettings, IHaveMinQp_Integer, IHaveMediaLiveChannelTypesH264ColorSpaceSettingsColorSpaceSettings, IHaveEntropyEncoding, IHaveSpatialAq, IHaveParDenominator_Integer, IHaveFixedAfd, IHaveGopSizeUnits, IHaveAfdSignaling, IHaveBitrate_Integer, IHaveParNumerator_Integer, IHaveRateControlMode, IHaveScanType, IHaveBufSize_Integer, IHaveTimecodeInsertion, IHaveColorMetadata, IHaveBufFillPct_Integer, IHaveGopBReference, IHaveLookAheadRateControl, IHaveLevel, IHaveMaxBitrate_Integer, IHaveSyntax, IHaveSubgopLength, IHaveGopNumBFrames_Integer
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings, BaseFunction>? TimecodeBurninSettings { get; set; }
            /// <summary>
            /// NumRefFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-numrefframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRefFrames { get; set; }
            /// <summary>
            /// TemporalAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-temporalaq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemporalAq { get; set; }
            /// <summary>
            /// Slices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-slices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Slices { get; set; }
            /// <summary>
            /// FramerateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-frameratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FramerateControl { get; set; }
            /// <summary>
            /// QvbrQualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-qvbrqualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QvbrQualityLevel { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateNumerator { get; set; }
            /// <summary>
            /// ParControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-parcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParControl { get; set; }
            /// <summary>
            /// GopClosedCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopclosedcadence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GopClosedCadence { get; set; }
            /// <summary>
            /// FlickerAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-flickeraq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlickerAq { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
            /// <summary>
            /// QualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-qualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QualityLevel { get; set; }
            /// <summary>
            /// MinBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-minbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinBitrate { get; set; }
            /// <summary>
            /// MinIInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-miniinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinIInterval { get; set; }
            /// <summary>
            /// SceneChangeDetect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-scenechangedetect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SceneChangeDetect { get; set; }
            /// <summary>
            /// ForceFieldPictures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-forcefieldpictures
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ForceFieldPictures { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateDenominator { get; set; }
            /// <summary>
            /// Softness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-softness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Softness { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? GopSize { get; set; }
            /// <summary>
            /// AdaptiveQuantization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-adaptivequantization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdaptiveQuantization { get; set; }
            /// <summary>
            /// FilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-filtersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264H265FilterSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.H264H265FilterSettings, BaseFunction>? FilterSettings { get; set; }
            /// <summary>
            /// MinQp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-minqp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinQp { get; set; }
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264ColorSpaceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.H264ColorSpaceSettings, BaseFunction>? ColorSpaceSettings { get; set; }
            /// <summary>
            /// EntropyEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-entropyencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntropyEncoding { get; set; }
            /// <summary>
            /// SpatialAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-spatialaq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpatialAq { get; set; }
            /// <summary>
            /// ParDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-pardenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParDenominator { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GopSizeUnits { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfdSignaling { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// ParNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-parnumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParNumerator { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RateControlMode { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanType { get; set; }
            /// <summary>
            /// BufSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-bufsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufSize { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimecodeInsertion { get; set; }
            /// <summary>
            /// ColorMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-colormetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorMetadata { get; set; }
            /// <summary>
            /// BufFillPct
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-buffillpct
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufFillPct { get; set; }
            /// <summary>
            /// GopBReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopbreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GopBReference { get; set; }
            /// <summary>
            /// LookAheadRateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-lookaheadratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LookAheadRateControl { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBitrate { get; set; }
            /// <summary>
            /// Syntax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-syntax
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Syntax { get; set; }
            /// <summary>
            /// SubgopLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-subgoplength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubgopLength { get; set; }
            /// <summary>
            /// GopNumBFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html#cfn-medialive-channel-h264settings-gopnumbframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GopNumBFrames { get; set; }
        }

        public class H265ColorSpaceSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRec601Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsRec709Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsColorSpacePassthroughSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsDolbyVision81Settings, IHaveMediaLiveChannelTypesHdr10SettingsHdr10Settings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsHlg2020Settings
        {
            /// <summary>
            /// Rec601Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-rec601settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Rec601Settings { get; set; }
            /// <summary>
            /// Rec709Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-rec709settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Rec709Settings { get; set; }
            /// <summary>
            /// ColorSpacePassthroughSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-colorspacepassthroughsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? ColorSpacePassthroughSettings { get; set; }
            /// <summary>
            /// DolbyVision81Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-dolbyvision81settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? DolbyVision81Settings { get; set; }
            /// <summary>
            /// Hdr10Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-hdr10settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Hdr10Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Hdr10Settings, BaseFunction>? Hdr10Settings { get; set; }
            /// <summary>
            /// Hlg2020Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265colorspacesettings.html#cfn-medialive-channel-h265colorspacesettings-hlg2020settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? Hlg2020Settings { get; set; }
        }

        public class H265Settings : Humidifier.Base.BaseSubResource, IHaveMvOverPictureBoundaries, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveSlices_Integer, IHaveQvbrQualityLevel_Integer, IHaveTileHeight_Integer, IHaveFramerateNumerator_Integer, IHaveGopClosedCadence_Integer, IHaveFlickerAq, IHaveProfile, IHaveMvTemporalPredictor, IHaveMinBitrate_Integer, IHaveMinIInterval_Integer, IHaveSceneChangeDetect, IHaveFramerateDenominator_Integer, IHaveGopSize_Double, IHaveAdaptiveQuantization, IHaveTileWidth_Integer, IHaveMediaLiveChannelTypesH264H265FilterSettingsFilterSettings, IHaveMinQp_Integer, IHaveAlternativeTransferFunction, IHaveMediaLiveChannelTypesH265ColorSpaceSettingsColorSpaceSettings, IHaveTier, IHaveParDenominator_Integer, IHaveFixedAfd, IHaveGopSizeUnits, IHaveTilePadding, IHaveAfdSignaling, IHaveBitrate_Integer, IHaveParNumerator_Integer, IHaveRateControlMode, IHaveScanType, IHaveBufSize_Integer, IHaveTimecodeInsertion, IHaveDeblocking, IHaveColorMetadata, IHaveLookAheadRateControl, IHaveGopBReference, IHaveLevel, IHaveMaxBitrate_Integer, IHaveTreeblockSize, IHaveSubgopLength, IHaveGopNumBFrames_Integer
        {
            /// <summary>
            /// MvOverPictureBoundaries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-mvoverpictureboundaries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MvOverPictureBoundaries { get; set; }
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings, BaseFunction>? TimecodeBurninSettings { get; set; }
            /// <summary>
            /// Slices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-slices
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Slices { get; set; }
            /// <summary>
            /// QvbrQualityLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-qvbrqualitylevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QvbrQualityLevel { get; set; }
            /// <summary>
            /// TileHeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tileheight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TileHeight { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateNumerator { get; set; }
            /// <summary>
            /// GopClosedCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopclosedcadence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GopClosedCadence { get; set; }
            /// <summary>
            /// FlickerAq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-flickeraq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlickerAq { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
            /// <summary>
            /// MvTemporalPredictor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-mvtemporalpredictor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MvTemporalPredictor { get; set; }
            /// <summary>
            /// MinBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-minbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinBitrate { get; set; }
            /// <summary>
            /// MinIInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-miniinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinIInterval { get; set; }
            /// <summary>
            /// SceneChangeDetect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-scenechangedetect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SceneChangeDetect { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateDenominator { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? GopSize { get; set; }
            /// <summary>
            /// AdaptiveQuantization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-adaptivequantization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdaptiveQuantization { get; set; }
            /// <summary>
            /// TileWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tilewidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TileWidth { get; set; }
            /// <summary>
            /// FilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-filtersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264H265FilterSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.H264H265FilterSettings, BaseFunction>? FilterSettings { get; set; }
            /// <summary>
            /// MinQp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-minqp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinQp { get; set; }
            /// <summary>
            /// AlternativeTransferFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-alternativetransferfunction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlternativeTransferFunction { get; set; }
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H265ColorSpaceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.H265ColorSpaceSettings, BaseFunction>? ColorSpaceSettings { get; set; }
            /// <summary>
            /// Tier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tier { get; set; }
            /// <summary>
            /// ParDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-pardenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParDenominator { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GopSizeUnits { get; set; }
            /// <summary>
            /// TilePadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-tilepadding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TilePadding { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfdSignaling { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// ParNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-parnumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParNumerator { get; set; }
            /// <summary>
            /// RateControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-ratecontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RateControlMode { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanType { get; set; }
            /// <summary>
            /// BufSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-bufsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufSize { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimecodeInsertion { get; set; }
            /// <summary>
            /// Deblocking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-deblocking
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Deblocking { get; set; }
            /// <summary>
            /// ColorMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-colormetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorMetadata { get; set; }
            /// <summary>
            /// LookAheadRateControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-lookaheadratecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LookAheadRateControl { get; set; }
            /// <summary>
            /// GopBReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopbreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GopBReference { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBitrate { get; set; }
            /// <summary>
            /// TreeblockSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-treeblocksize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TreeblockSize { get; set; }
            /// <summary>
            /// SubgopLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-subgoplength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubgopLength { get; set; }
            /// <summary>
            /// GopNumBFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html#cfn-medialive-channel-h265settings-gopnumbframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GopNumBFrames { get; set; }
        }

        public class Hdr10Settings : Humidifier.Base.BaseSubResource, IHaveMaxCll_Integer, IHaveMaxFall_Integer
        {
            /// <summary>
            /// MaxCll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hdr10settings.html#cfn-medialive-channel-hdr10settings-maxcll
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCll { get; set; }
            /// <summary>
            /// MaxFall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hdr10settings.html#cfn-medialive-channel-hdr10settings-maxfall
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFall { get; set; }
        }

        public class HlsAkamaiSettings : Humidifier.Base.BaseSubResource, IHaveSalt, IHaveFilecacheDuration_Integer, IHaveNumRetries_Integer, IHaveToken, IHaveRestartDelay_Integer, IHaveConnectionRetryInterval_Integer, IHaveHttpTransferMode
        {
            /// <summary>
            /// Salt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-salt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Salt { get; set; }
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRetries { get; set; }
            /// <summary>
            /// Token
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-token
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Token { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionRetryInterval { get; set; }
            /// <summary>
            /// HttpTransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsakamaisettings.html#cfn-medialive-channel-hlsakamaisettings-httptransfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTransferMode { get; set; }
        }

        public class HlsBasicPutSettings : Humidifier.Base.BaseSubResource, IHaveFilecacheDuration_Integer, IHaveNumRetries_Integer, IHaveRestartDelay_Integer, IHaveConnectionRetryInterval_Integer
        {
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRetries { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsbasicputsettings.html#cfn-medialive-channel-hlsbasicputsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionRetryInterval { get; set; }
        }

        public class HlsCdnSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesHlsWebdavSettingsHlsWebdavSettings, IHaveMediaLiveChannelTypesArchiveFrameCaptureHlsS3SettingsHlsS3Settings, IHaveMediaLiveChannelTypesHlsAkamaiSettingsHlsAkamaiSettings, IHaveMediaLiveChannelTypesHlsBasicPutSettingsHlsBasicPutSettings, IHaveMediaLiveChannelTypesHlsMediaStoreSettingsHlsMediaStoreSettings
        {
            /// <summary>
            /// HlsWebdavSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlswebdavsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsWebdavSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsWebdavSettings, BaseFunction>? HlsWebdavSettings { get; set; }
            /// <summary>
            /// HlsS3Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlss3settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveFrameCaptureHlsS3Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveFrameCaptureHlsS3Settings, BaseFunction>? HlsS3Settings { get; set; }
            /// <summary>
            /// HlsAkamaiSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsakamaisettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsAkamaiSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsAkamaiSettings, BaseFunction>? HlsAkamaiSettings { get; set; }
            /// <summary>
            /// HlsBasicPutSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsbasicputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsBasicPutSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsBasicPutSettings, BaseFunction>? HlsBasicPutSettings { get; set; }
            /// <summary>
            /// HlsMediaStoreSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsmediastoresettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsMediaStoreSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsMediaStoreSettings, BaseFunction>? HlsMediaStoreSettings { get; set; }
        }

        public class HlsGroupSettings : Humidifier.Base.BaseSubResource, IHaveSegmentationMode, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveCodecSpecification, IHaveIvSource, IHaveTimedMetadataId3Frame, IHaveKeyFormatVersions, IHaveRedundantManifest, IHaveOutputSelection, IHaveMediaLiveChannelTypesKeyProviderSettingsKeyProviderSettings, IHaveStreamInfResolution, IHaveListOfMediaLiveChannelTypesCaptionLanguageMappingCaptionLanguageMappings, IHaveHlsId3SegmentTagging, IHaveIFrameOnlyPlaylists, IHaveCaptionLanguageSetting, IHaveKeepSegments_Integer, IHaveConstantIv, IHaveDirectoryStructure, IHaveEncryptionType, IHaveStringListOfAdMarkers, IHaveMediaLiveChannelTypesHlsCdnSettingsHlsCdnSettings, IHaveIndexNSegments_Integer, IHaveDiscontinuityTags, IHaveInputLossAction, IHaveMode, IHaveTsFileMode, IHaveBaseUrlManifest1, IHaveClientCache, IHaveMinSegmentLength_Integer, IHaveKeyFormat, IHaveIvInManifest, IHaveBaseUrlContent1, IHaveProgramDateTimeClock, IHaveManifestCompression, IHaveManifestDurationFormat, IHaveTimedMetadataId3Period_Integer, IHaveIncompleteSegmentBehavior, IHaveProgramDateTimePeriod_Integer, IHaveSegmentLength_Integer, IHaveTimestampDeltaMilliseconds_Integer, IHaveProgramDateTime, IHaveSegmentsPerSubdirectory_Integer, IHaveBaseUrlContent, IHaveBaseUrlManifest
        {
            /// <summary>
            /// SegmentationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-segmentationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentationMode { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// CodecSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-codecspecification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodecSpecification { get; set; }
            /// <summary>
            /// IvSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-ivsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IvSource { get; set; }
            /// <summary>
            /// TimedMetadataId3Frame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-timedmetadataid3frame
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataId3Frame { get; set; }
            /// <summary>
            /// KeyFormatVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keyformatversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyFormatVersions { get; set; }
            /// <summary>
            /// RedundantManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-redundantmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedundantManifest { get; set; }
            /// <summary>
            /// OutputSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-outputselection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputSelection { get; set; }
            /// <summary>
            /// KeyProviderSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keyprovidersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeyProviderSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.KeyProviderSettings, BaseFunction>? KeyProviderSettings { get; set; }
            /// <summary>
            /// StreamInfResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-streaminfresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamInfResolution { get; set; }
            /// <summary>
            /// CaptionLanguageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-captionlanguagemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionLanguageMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.CaptionLanguageMapping>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.CaptionLanguageMapping, BaseFunction>>, BaseFunction>? CaptionLanguageMappings { get; set; }
            /// <summary>
            /// HlsId3SegmentTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-hlsid3segmenttagging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HlsId3SegmentTagging { get; set; }
            /// <summary>
            /// IFrameOnlyPlaylists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-iframeonlyplaylists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IFrameOnlyPlaylists { get; set; }
            /// <summary>
            /// CaptionLanguageSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-captionlanguagesetting
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaptionLanguageSetting { get; set; }
            /// <summary>
            /// KeepSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keepsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeepSegments { get; set; }
            /// <summary>
            /// ConstantIv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-constantiv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConstantIv { get; set; }
            /// <summary>
            /// DirectoryStructure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-directorystructure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryStructure { get; set; }
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdMarkers { get; set; }
            /// <summary>
            /// HlsCdnSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-hlscdnsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsCdnSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsCdnSettings, BaseFunction>? HlsCdnSettings { get; set; }
            /// <summary>
            /// IndexNSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-indexnsegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IndexNSegments { get; set; }
            /// <summary>
            /// DiscontinuityTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-discontinuitytags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscontinuityTags { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossAction { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// TsFileMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-tsfilemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TsFileMode { get; set; }
            /// <summary>
            /// BaseUrlManifest1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlmanifest1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseUrlManifest1 { get; set; }
            /// <summary>
            /// ClientCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-clientcache
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCache { get; set; }
            /// <summary>
            /// MinSegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-minsegmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinSegmentLength { get; set; }
            /// <summary>
            /// KeyFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-keyformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyFormat { get; set; }
            /// <summary>
            /// IvInManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-ivinmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IvInManifest { get; set; }
            /// <summary>
            /// BaseUrlContent1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlcontent1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseUrlContent1 { get; set; }
            /// <summary>
            /// ProgramDateTimeClock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-programdatetimeclock
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProgramDateTimeClock { get; set; }
            /// <summary>
            /// ManifestCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-manifestcompression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestCompression { get; set; }
            /// <summary>
            /// ManifestDurationFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-manifestdurationformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestDurationFormat { get; set; }
            /// <summary>
            /// TimedMetadataId3Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-timedmetadataid3period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimedMetadataId3Period { get; set; }
            /// <summary>
            /// IncompleteSegmentBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-incompletesegmentbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncompleteSegmentBehavior { get; set; }
            /// <summary>
            /// ProgramDateTimePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-programdatetimeperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramDateTimePeriod { get; set; }
            /// <summary>
            /// SegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-segmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentLength { get; set; }
            /// <summary>
            /// TimestampDeltaMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-timestampdeltamilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimestampDeltaMilliseconds { get; set; }
            /// <summary>
            /// ProgramDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-programdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProgramDateTime { get; set; }
            /// <summary>
            /// SegmentsPerSubdirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-segmentspersubdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentsPerSubdirectory { get; set; }
            /// <summary>
            /// BaseUrlContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseUrlContent { get; set; }
            /// <summary>
            /// BaseUrlManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html#cfn-medialive-channel-hlsgroupsettings-baseurlmanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseUrlManifest { get; set; }
        }

        public class HlsInputSettings : Humidifier.Base.BaseSubResource, IHaveScte35Source, IHaveBufferSegments_Integer, IHaveRetries_Integer, IHaveBandwidth_Integer, IHaveRetryInterval_Integer
        {
            /// <summary>
            /// Scte35Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-scte35source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Source { get; set; }
            /// <summary>
            /// BufferSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-buffersegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufferSegments { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Retries { get; set; }
            /// <summary>
            /// Bandwidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-bandwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bandwidth { get; set; }
            /// <summary>
            /// RetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryInterval { get; set; }
        }

        public class HlsMediaStoreSettings : Humidifier.Base.BaseSubResource, IHaveFilecacheDuration_Integer, IHaveNumRetries_Integer, IHaveMediaStoreStorageClass, IHaveRestartDelay_Integer, IHaveConnectionRetryInterval_Integer
        {
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRetries { get; set; }
            /// <summary>
            /// MediaStoreStorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-mediastorestorageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaStoreStorageClass { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html#cfn-medialive-channel-hlsmediastoresettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionRetryInterval { get; set; }
        }

        public class HlsOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier, IHaveMediaLiveChannelTypesHlsSettingsHlsSettings, IHaveH265PackagingType, IHaveSegmentModifier
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NameModifier { get; set; }
            /// <summary>
            /// HlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-hlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsSettings, BaseFunction>? HlsSettings { get; set; }
            /// <summary>
            /// H265PackagingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-h265packagingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? H265PackagingType { get; set; }
            /// <summary>
            /// SegmentModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsoutputsettings.html#cfn-medialive-channel-hlsoutputsettings-segmentmodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentModifier { get; set; }
        }

        public class HlsSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesStandardHlsSettingsStandardHlsSettings, IHaveMediaLiveChannelTypesAudioOnlyHlsSettingsAudioOnlyHlsSettings, IHaveMediaLiveChannelTypesFmp4HlsSettingsFmp4HlsSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsFrameCaptureHlsSettings
        {
            /// <summary>
            /// StandardHlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-standardhlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardHlsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.StandardHlsSettings, BaseFunction>? StandardHlsSettings { get; set; }
            /// <summary>
            /// AudioOnlyHlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-audioonlyhlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioOnlyHlsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AudioOnlyHlsSettings, BaseFunction>? AudioOnlyHlsSettings { get; set; }
            /// <summary>
            /// Fmp4HlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-fmp4hlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fmp4HlsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Fmp4HlsSettings, BaseFunction>? Fmp4HlsSettings { get; set; }
            /// <summary>
            /// FrameCaptureHlsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html#cfn-medialive-channel-hlssettings-framecapturehlssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? FrameCaptureHlsSettings { get; set; }
        }

        public class HlsWebdavSettings : Humidifier.Base.BaseSubResource, IHaveFilecacheDuration_Integer, IHaveNumRetries_Integer, IHaveRestartDelay_Integer, IHaveConnectionRetryInterval_Integer, IHaveHttpTransferMode
        {
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FilecacheDuration { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRetries { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartDelay { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionRetryInterval { get; set; }
            /// <summary>
            /// HttpTransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-httptransfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTransferMode { get; set; }
        }

        public class InferenceSettings : Humidifier.Base.BaseSubResource, IHaveFeedArn, IHaveListOfMediaLiveChannelTypesAudioFeedInputAudioFeedInputs, IHaveStringListOfEnrichmentMethods
        {
            /// <summary>
            /// FeedArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inferencesettings.html#cfn-medialive-channel-inferencesettings-feedarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeedArn { get; set; }
            /// <summary>
            /// AudioFeedInputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inferencesettings.html#cfn-medialive-channel-inferencesettings-audiofeedinputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioFeedInput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AudioFeedInput>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AudioFeedInput, BaseFunction>>, BaseFunction>? AudioFeedInputs { get; set; }
            /// <summary>
            /// EnrichmentMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inferencesettings.html#cfn-medialive-channel-inferencesettings-enrichmentmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnrichmentMethods { get; set; }
        }

        public class InputAttachment : Humidifier.Base.BaseSubResource, IHaveInputAttachmentName, IHaveStringListOfLogicalInterfaceNames, IHaveInputId, IHaveMediaLiveChannelTypesAutomaticInputFailoverSettingsAutomaticInputFailoverSettings, IHaveMediaLiveChannelTypesInputSettingsInputSettings
        {
            /// <summary>
            /// InputAttachmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputattachmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAttachmentName { get; set; }
            /// <summary>
            /// LogicalInterfaceNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-logicalinterfacenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogicalInterfaceNames { get; set; }
            /// <summary>
            /// InputId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputId { get; set; }
            /// <summary>
            /// AutomaticInputFailoverSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-automaticinputfailoversettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomaticInputFailoverSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings, BaseFunction>? AutomaticInputFailoverSettings { get; set; }
            /// <summary>
            /// InputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputSettings, BaseFunction>? InputSettings { get; set; }
        }

        public class InputChannelLevel : Humidifier.Base.BaseSubResource, IHaveInputChannel_Integer, IHaveGain_Integer
        {
            /// <summary>
            /// InputChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputchannellevel.html#cfn-medialive-channel-inputchannellevel-inputchannel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InputChannel { get; set; }
            /// <summary>
            /// Gain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputchannellevel.html#cfn-medialive-channel-inputchannellevel-gain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Gain { get; set; }
        }

        public class InputLocation : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePasswordParam, IHaveUri
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html#cfn-medialive-channel-inputlocation-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html#cfn-medialive-channel-inputlocation-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PasswordParam { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html#cfn-medialive-channel-inputlocation-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class InputLossBehavior : Humidifier.Base.BaseSubResource, IHaveInputLossImageColor, IHaveBlackFrameMsec_Integer, IHaveInputLossImageType, IHaveMediaLiveChannelTypesInputLocationInputLossImageSlate, IHaveRepeatFrameMsec_Integer
        {
            /// <summary>
            /// InputLossImageColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-inputlossimagecolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossImageColor { get; set; }
            /// <summary>
            /// BlackFrameMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-blackframemsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BlackFrameMsec { get; set; }
            /// <summary>
            /// InputLossImageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-inputlossimagetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossImageType { get; set; }
            /// <summary>
            /// InputLossImageSlate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-inputlossimageslate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? InputLossImageSlate { get; set; }
            /// <summary>
            /// RepeatFrameMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html#cfn-medialive-channel-inputlossbehavior-repeatframemsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RepeatFrameMsec { get; set; }
        }

        public class InputLossFailoverSettings : Humidifier.Base.BaseSubResource, IHaveInputLossThresholdMsec_Integer
        {
            /// <summary>
            /// InputLossThresholdMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossfailoversettings.html#cfn-medialive-channel-inputlossfailoversettings-inputlossthresholdmsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InputLossThresholdMsec { get; set; }
        }

        public class InputSettings : Humidifier.Base.BaseSubResource, IHaveScte35Pid_Integer, IHaveDeblockFilter, IHaveFilterStrength_Integer, IHaveInputFilter, IHaveSourceEndBehavior, IHaveMediaLiveChannelTypesVideoSelectorVideoSelector, IHaveSmpte2038DataPreference, IHaveListOfMediaLiveChannelTypesAudioSelectorAudioSelectors, IHaveListOfMediaLiveChannelTypesCaptionSelectorCaptionSelectors, IHaveDenoiseFilter, IHaveMediaLiveChannelTypesNetworkInputSettingsNetworkInputSettings
        {
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Scte35Pid { get; set; }
            /// <summary>
            /// DeblockFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-deblockfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeblockFilter { get; set; }
            /// <summary>
            /// FilterStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-filterstrength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FilterStrength { get; set; }
            /// <summary>
            /// InputFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-inputfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFilter { get; set; }
            /// <summary>
            /// SourceEndBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-sourceendbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceEndBehavior { get; set; }
            /// <summary>
            /// VideoSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-videoselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelector
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoSelector, BaseFunction>? VideoSelector { get; set; }
            /// <summary>
            /// Smpte2038DataPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-smpte2038datapreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Smpte2038DataPreference { get; set; }
            /// <summary>
            /// AudioSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-audioselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AudioSelector>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AudioSelector, BaseFunction>>, BaseFunction>? AudioSelectors { get; set; }
            /// <summary>
            /// CaptionSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-captionselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.CaptionSelector>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.CaptionSelector, BaseFunction>>, BaseFunction>? CaptionSelectors { get; set; }
            /// <summary>
            /// DenoiseFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-denoisefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DenoiseFilter { get; set; }
            /// <summary>
            /// NetworkInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-networkinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkInputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings, BaseFunction>? NetworkInputSettings { get; set; }
        }

        public class InputSpecification : Humidifier.Base.BaseSubResource, IHaveCodec, IHaveMaximumBitrate, IHaveResolution
        {
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Codec { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaximumBitrate { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-resolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resolution { get; set; }
        }

        public class KeyProviderSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesStaticKeySettingsStaticKeySettings
        {
            /// <summary>
            /// StaticKeySettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-keyprovidersettings.html#cfn-medialive-channel-keyprovidersettings-statickeysettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticKeySettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.StaticKeySettings, BaseFunction>? StaticKeySettings { get; set; }
        }

        public class LinkedChannelSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesFollowerChannelSettingsFollowerChannelSettings, IHaveMediaLiveChannelTypesPrimaryChannelSettingsPrimaryChannelSettings
        {
            /// <summary>
            /// FollowerChannelSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-linkedchannelsettings.html#cfn-medialive-channel-linkedchannelsettings-followerchannelsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FollowerChannelSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FollowerChannelSettings, BaseFunction>? FollowerChannelSettings { get; set; }
            /// <summary>
            /// PrimaryChannelSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-linkedchannelsettings.html#cfn-medialive-channel-linkedchannelsettings-primarychannelsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrimaryChannelSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.PrimaryChannelSettings, BaseFunction>? PrimaryChannelSettings { get; set; }
        }

        public class M2tsSettings : Humidifier.Base.BaseSubResource, IHaveEtvPlatformPid, IHavePatInterval_Integer, IHaveProgramNum_Integer, IHaveRateMode, IHaveKlvDataPids, IHaveNullPacketBitrate_Double, IHavePmtInterval_Integer, IHaveAribCaptionsPid, IHaveEsRateInPes, IHaveVideoPid, IHaveTransportStreamId_Integer, IHaveEbpPlacement, IHaveDvbSubPids, IHaveSegmentationStyle, IHaveScte35Pid, IHaveAudioStreamType, IHaveKlv, IHaveEbpLookaheadMs_Integer, IHaveScte35PrerollPullupMilliseconds_Double, IHaveMediaLiveChannelTypesDvbTdtSettingsDvbTdtSettings, IHaveTimedMetadataBehavior, IHaveEbpAudioInterval, IHaveFragmentTime_Double, IHaveDvbTeletextPid, IHaveScte35Control, IHavePcrPeriod_Integer, IHaveNielsenId3Behavior, IHavePcrPid, IHaveSegmentationTime_Double, IHaveCcDescriptor, IHaveAudioFramesPerPes_Integer, IHaveAbsentInputAudioBehavior, IHaveBitrate_Integer, IHavePmtPid, IHaveScte27Pids, IHaveSegmentationMarkers, IHaveMediaLiveChannelTypesDvbNitSettingsDvbNitSettings, IHaveMediaLiveChannelTypesDvbSdtSettingsDvbSdtSettings, IHaveEtvSignalPid, IHaveArib, IHaveBufferModel, IHaveEcmPid, IHaveTimedMetadataPid, IHaveAudioPids, IHaveAudioBufferModel, IHaveEbif, IHaveAribCaptionsPidControl, IHavePcrControl
        {
            /// <summary>
            /// EtvPlatformPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-etvplatformpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EtvPlatformPid { get; set; }
            /// <summary>
            /// PatInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-patinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PatInterval { get; set; }
            /// <summary>
            /// ProgramNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-programnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramNum { get; set; }
            /// <summary>
            /// RateMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ratemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RateMode { get; set; }
            /// <summary>
            /// KlvDataPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-klvdatapids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KlvDataPids { get; set; }
            /// <summary>
            /// NullPacketBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-nullpacketbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NullPacketBitrate { get; set; }
            /// <summary>
            /// PmtInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pmtinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PmtInterval { get; set; }
            /// <summary>
            /// AribCaptionsPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-aribcaptionspid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AribCaptionsPid { get; set; }
            /// <summary>
            /// EsRateInPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-esrateinpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EsRateInPes { get; set; }
            /// <summary>
            /// VideoPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-videopid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoPid { get; set; }
            /// <summary>
            /// TransportStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-transportstreamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransportStreamId { get; set; }
            /// <summary>
            /// EbpPlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebpplacement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EbpPlacement { get; set; }
            /// <summary>
            /// DvbSubPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbsubpids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DvbSubPids { get; set; }
            /// <summary>
            /// SegmentationStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-segmentationstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentationStyle { get; set; }
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Pid { get; set; }
            /// <summary>
            /// AudioStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audiostreamtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioStreamType { get; set; }
            /// <summary>
            /// Klv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-klv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Klv { get; set; }
            /// <summary>
            /// EbpLookaheadMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebplookaheadms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EbpLookaheadMs { get; set; }
            /// <summary>
            /// Scte35PrerollPullupMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte35prerollpullupmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Scte35PrerollPullupMilliseconds { get; set; }
            /// <summary>
            /// DvbTdtSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbtdtsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbTdtSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.DvbTdtSettings, BaseFunction>? DvbTdtSettings { get; set; }
            /// <summary>
            /// TimedMetadataBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-timedmetadatabehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataBehavior { get; set; }
            /// <summary>
            /// EbpAudioInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebpaudiointerval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EbpAudioInterval { get; set; }
            /// <summary>
            /// FragmentTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-fragmenttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FragmentTime { get; set; }
            /// <summary>
            /// DvbTeletextPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbteletextpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DvbTeletextPid { get; set; }
            /// <summary>
            /// Scte35Control
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte35control
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Control { get; set; }
            /// <summary>
            /// PcrPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pcrperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PcrPeriod { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3Behavior { get; set; }
            /// <summary>
            /// PcrPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pcrpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PcrPid { get; set; }
            /// <summary>
            /// SegmentationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-segmentationtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SegmentationTime { get; set; }
            /// <summary>
            /// CcDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ccdescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CcDescriptor { get; set; }
            /// <summary>
            /// AudioFramesPerPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audioframesperpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AudioFramesPerPes { get; set; }
            /// <summary>
            /// AbsentInputAudioBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-absentinputaudiobehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AbsentInputAudioBehavior { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// PmtPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pmtpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PmtPid { get; set; }
            /// <summary>
            /// Scte27Pids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-scte27pids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte27Pids { get; set; }
            /// <summary>
            /// SegmentationMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-segmentationmarkers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentationMarkers { get; set; }
            /// <summary>
            /// DvbNitSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbnitsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbNitSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.DvbNitSettings, BaseFunction>? DvbNitSettings { get; set; }
            /// <summary>
            /// DvbSdtSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-dvbsdtsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbSdtSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.DvbSdtSettings, BaseFunction>? DvbSdtSettings { get; set; }
            /// <summary>
            /// EtvSignalPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-etvsignalpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EtvSignalPid { get; set; }
            /// <summary>
            /// Arib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-arib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arib { get; set; }
            /// <summary>
            /// BufferModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-buffermodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BufferModel { get; set; }
            /// <summary>
            /// EcmPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ecmpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EcmPid { get; set; }
            /// <summary>
            /// TimedMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-timedmetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataPid { get; set; }
            /// <summary>
            /// AudioPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audiopids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioPids { get; set; }
            /// <summary>
            /// AudioBufferModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-audiobuffermodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioBufferModel { get; set; }
            /// <summary>
            /// Ebif
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-ebif
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ebif { get; set; }
            /// <summary>
            /// AribCaptionsPidControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-aribcaptionspidcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AribCaptionsPidControl { get; set; }
            /// <summary>
            /// PcrControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html#cfn-medialive-channel-m2tssettings-pcrcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PcrControl { get; set; }
        }

        public class M3u8Settings : Humidifier.Base.BaseSubResource, IHavePatInterval_Integer, IHaveProgramNum_Integer, IHavePcrPeriod_Integer, IHavePmtInterval_Integer, IHaveKlvDataPids, IHaveNielsenId3Behavior, IHavePcrPid, IHaveVideoPid, IHaveAudioFramesPerPes_Integer, IHaveTransportStreamId_Integer, IHavePmtPid, IHaveScte35Pid, IHaveScte35Behavior, IHaveKlvBehavior, IHaveEcmPid, IHaveTimedMetadataPid, IHaveAudioPids, IHavePcrControl, IHaveTimedMetadataBehavior
        {
            /// <summary>
            /// PatInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-patinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PatInterval { get; set; }
            /// <summary>
            /// ProgramNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-programnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramNum { get; set; }
            /// <summary>
            /// PcrPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PcrPeriod { get; set; }
            /// <summary>
            /// PmtInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pmtinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PmtInterval { get; set; }
            /// <summary>
            /// KlvDataPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-klvdatapids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KlvDataPids { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3Behavior { get; set; }
            /// <summary>
            /// PcrPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PcrPid { get; set; }
            /// <summary>
            /// VideoPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-videopid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoPid { get; set; }
            /// <summary>
            /// AudioFramesPerPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-audioframesperpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AudioFramesPerPes { get; set; }
            /// <summary>
            /// TransportStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-transportstreamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransportStreamId { get; set; }
            /// <summary>
            /// PmtPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pmtpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PmtPid { get; set; }
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Pid { get; set; }
            /// <summary>
            /// Scte35Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-scte35behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Behavior { get; set; }
            /// <summary>
            /// KlvBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-klvbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KlvBehavior { get; set; }
            /// <summary>
            /// EcmPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-ecmpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EcmPid { get; set; }
            /// <summary>
            /// TimedMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-timedmetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataPid { get; set; }
            /// <summary>
            /// AudioPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-audiopids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioPids { get; set; }
            /// <summary>
            /// PcrControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PcrControl { get; set; }
            /// <summary>
            /// TimedMetadataBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-timedmetadatabehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataBehavior { get; set; }
        }

        public class MaintenanceCreateSettings : Humidifier.Base.BaseSubResource, IHaveMaintenanceDay, IHaveMaintenanceStartTime
        {
            /// <summary>
            /// MaintenanceDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenancecreatesettings.html#cfn-medialive-channel-maintenancecreatesettings-maintenanceday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceDay { get; set; }
            /// <summary>
            /// MaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenancecreatesettings.html#cfn-medialive-channel-maintenancecreatesettings-maintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceStartTime { get; set; }
        }

        public class MaintenanceUpdateSettings : Humidifier.Base.BaseSubResource, IHaveMaintenanceDay, IHaveMaintenanceScheduledDate, IHaveMaintenanceStartTime
        {
            /// <summary>
            /// MaintenanceDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenanceupdatesettings.html#cfn-medialive-channel-maintenanceupdatesettings-maintenanceday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceDay { get; set; }
            /// <summary>
            /// MaintenanceScheduledDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenanceupdatesettings.html#cfn-medialive-channel-maintenanceupdatesettings-maintenancescheduleddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceScheduledDate { get; set; }
            /// <summary>
            /// MaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-maintenanceupdatesettings.html#cfn-medialive-channel-maintenanceupdatesettings-maintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceStartTime { get; set; }
        }

        public class MediaConnectRouterGroupSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfAvailabilityZones
        {
            /// <summary>
            /// AvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectroutergroupsettings.html#cfn-medialive-channel-mediaconnectroutergroupsettings-availabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
        }

        public class MediaConnectRouterOutputConnectionMap : Humidifier.Base.BaseSubResource, IHavePipeline0, IHavePipeline1
        {
            /// <summary>
            /// Pipeline0
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputconnectionmap.html#cfn-medialive-channel-mediaconnectrouteroutputconnectionmap-pipeline0
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pipeline0 { get; set; }
            /// <summary>
            /// Pipeline1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputconnectionmap.html#cfn-medialive-channel-mediaconnectrouteroutputconnectionmap-pipeline1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pipeline1 { get; set; }
        }

        public class MediaConnectRouterOutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveEncryptionType
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputdestinationsettings.html#cfn-medialive-channel-mediaconnectrouteroutputdestinationsettings-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputdestinationsettings.html#cfn-medialive-channel-mediaconnectrouteroutputdestinationsettings-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
        }

        public class MediaConnectRouterOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveMediaLiveChannelTypesUdpMediaConnectRouterContainerSettingsContainerSettings, IHaveMediaLiveChannelTypesMediaConnectRouterOutputConnectionMapConnectedRouterInputs
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputsettings.html#cfn-medialive-channel-mediaconnectrouteroutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputsettings.html#cfn-medialive-channel-mediaconnectrouteroutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpMediaConnectRouterContainerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.UdpMediaConnectRouterContainerSettings, BaseFunction>? ContainerSettings { get; set; }
            /// <summary>
            /// ConnectedRouterInputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediaconnectrouteroutputsettings.html#cfn-medialive-channel-mediaconnectrouteroutputsettings-connectedrouterinputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaConnectRouterOutputConnectionMap
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaConnectRouterOutputConnectionMap, BaseFunction>? ConnectedRouterInputs { get; set; }
        }

        public class MediaPackageGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveMediaLiveChannelTypesMediaPackageV2GroupSettingsMediapackageV2GroupSettings
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagegroupsettings.html#cfn-medialive-channel-mediapackagegroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// MediapackageV2GroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagegroupsettings.html#cfn-medialive-channel-mediapackagegroupsettings-mediapackagev2groupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageV2GroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaPackageV2GroupSettings, BaseFunction>? MediapackageV2GroupSettings { get; set; }
        }

        public class MediaPackageOutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveChannelId, IHaveChannelGroup, IHaveChannelEndpointId, IHaveMediaPackageRegionName
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-channelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelName { get; set; }
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-channelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelId { get; set; }
            /// <summary>
            /// ChannelGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-channelgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelGroup { get; set; }
            /// <summary>
            /// ChannelEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-channelendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelEndpointId { get; set; }
            /// <summary>
            /// MediaPackageRegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-mediapackageregionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaPackageRegionName { get; set; }
        }

        public class MediaPackageOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesMediaPackageV2DestinationSettingsMediaPackageV2DestinationSettings
        {
            /// <summary>
            /// MediaPackageV2DestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputsettings.html#cfn-medialive-channel-mediapackageoutputsettings-mediapackagev2destinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageV2DestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaPackageV2DestinationSettings, BaseFunction>? MediaPackageV2DestinationSettings { get; set; }
        }

        public class MediaPackageV2DestinationSettings : Humidifier.Base.BaseSubResource, IHaveAudioRenditionSets, IHaveHlsDefault, IHaveStringListOfOutputUsage, IHaveAudioGroupId, IHaveHlsAutoSelect
        {
            /// <summary>
            /// AudioRenditionSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2destinationsettings.html#cfn-medialive-channel-mediapackagev2destinationsettings-audiorenditionsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioRenditionSets { get; set; }
            /// <summary>
            /// HlsDefault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2destinationsettings.html#cfn-medialive-channel-mediapackagev2destinationsettings-hlsdefault
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HlsDefault { get; set; }
            /// <summary>
            /// OutputUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2destinationsettings.html#cfn-medialive-channel-mediapackagev2destinationsettings-outputusage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OutputUsage { get; set; }
            /// <summary>
            /// AudioGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2destinationsettings.html#cfn-medialive-channel-mediapackagev2destinationsettings-audiogroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioGroupId { get; set; }
            /// <summary>
            /// HlsAutoSelect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2destinationsettings.html#cfn-medialive-channel-mediapackagev2destinationsettings-hlsautoselect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HlsAutoSelect { get; set; }
        }

        public class MediaPackageV2GroupSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveChannelTypesCaptionLanguageMappingCaptionLanguageMappings, IHaveMediaLiveChannelTypesMediaPackageV2WatermarkingSettingsWatermarkingSettings, IHaveScte35Type, IHaveSegmentLengthUnits, IHaveTimedMetadataId3Frame, IHaveTimedMetadataId3Period_Integer, IHaveTimedMetadataPassthrough, IHaveListOfMediaLiveChannelTypesAdditionalDestinationsAdditionalDestinations, IHaveNielsenId3Behavior, IHaveKlvBehavior, IHaveId3Behavior, IHaveSegmentLength_Integer
        {
            /// <summary>
            /// CaptionLanguageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-captionlanguagemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionLanguageMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.CaptionLanguageMapping>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.CaptionLanguageMapping, BaseFunction>>, BaseFunction>? CaptionLanguageMappings { get; set; }
            /// <summary>
            /// WatermarkingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-watermarkingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageV2WatermarkingSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaPackageV2WatermarkingSettings, BaseFunction>? WatermarkingSettings { get; set; }
            /// <summary>
            /// Scte35Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-scte35type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Type { get; set; }
            /// <summary>
            /// SegmentLengthUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-segmentlengthunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentLengthUnits { get; set; }
            /// <summary>
            /// TimedMetadataId3Frame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-timedmetadataid3frame
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataId3Frame { get; set; }
            /// <summary>
            /// TimedMetadataId3Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-timedmetadataid3period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimedMetadataId3Period { get; set; }
            /// <summary>
            /// TimedMetadataPassthrough
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-timedmetadatapassthrough
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataPassthrough { get; set; }
            /// <summary>
            /// AdditionalDestinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-additionaldestinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdditionalDestinations
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AdditionalDestinations>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AdditionalDestinations, BaseFunction>>, BaseFunction>? AdditionalDestinations { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3Behavior { get; set; }
            /// <summary>
            /// KlvBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-klvbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KlvBehavior { get; set; }
            /// <summary>
            /// Id3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-id3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id3Behavior { get; set; }
            /// <summary>
            /// SegmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2groupsettings.html#cfn-medialive-channel-mediapackagev2groupsettings-segmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentLength { get; set; }
        }

        public class MediaPackageV2WatermarkingSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesCmafIngestMediaPackageV2AbWatermarkerIrdetoSettingsMediaPackageV2AbWatermarkerIrdetoSettings
        {
            /// <summary>
            /// MediaPackageV2AbWatermarkerIrdetoSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackagev2watermarkingsettings.html#cfn-medialive-channel-mediapackagev2watermarkingsettings-mediapackagev2abwatermarkerirdetosettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestMediaPackageV2AbWatermarkerIrdetoSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CmafIngestMediaPackageV2AbWatermarkerIrdetoSettings, BaseFunction>? MediaPackageV2AbWatermarkerIrdetoSettings { get; set; }
        }

        public class MotionGraphicsConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesMotionGraphicsSettingsMotionGraphicsSettings, IHaveMotionGraphicsInsertion
        {
            /// <summary>
            /// MotionGraphicsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicsconfiguration.html#cfn-medialive-channel-motiongraphicsconfiguration-motiongraphicssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MotionGraphicsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings, BaseFunction>? MotionGraphicsSettings { get; set; }
            /// <summary>
            /// MotionGraphicsInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicsconfiguration.html#cfn-medialive-channel-motiongraphicsconfiguration-motiongraphicsinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MotionGraphicsInsertion { get; set; }
        }

        public class MotionGraphicsSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsHtmlMotionGraphicsSettings
        {
            /// <summary>
            /// HtmlMotionGraphicsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicssettings.html#cfn-medialive-channel-motiongraphicssettings-htmlmotiongraphicssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? HtmlMotionGraphicsSettings { get; set; }
        }

        public class Mp2Settings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveSampleRate_Double, IHaveBitrate_Double
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html#cfn-medialive-channel-mp2settings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodingMode { get; set; }
            /// <summary>
            /// SampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html#cfn-medialive-channel-mp2settings-samplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SampleRate { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html#cfn-medialive-channel-mp2settings-bitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Bitrate { get; set; }
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
            public Union<Humidifier.MediaLive.ChannelTypes.TemporalFilterSettings, BaseFunction>? TemporalFilterSettings { get; set; }
        }

        public class Mpeg2Settings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTimecodeBurninSettingsTimecodeBurninSettings, IHaveColorSpace, IHaveFixedAfd, IHaveGopSizeUnits, IHaveFramerateNumerator_Integer, IHaveGopClosedCadence_Integer, IHaveAfdSignaling, IHaveDisplayAspectRatio, IHaveScanType, IHaveTimecodeInsertion, IHaveColorMetadata, IHaveFramerateDenominator_Integer, IHaveGopSize_Double, IHaveAdaptiveQuantization, IHaveSubgopLength, IHaveMediaLiveChannelTypesMpeg2FilterSettingsFilterSettings, IHaveGopNumBFrames_Integer
        {
            /// <summary>
            /// TimecodeBurninSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-timecodeburninsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimecodeBurninSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TimecodeBurninSettings, BaseFunction>? TimecodeBurninSettings { get; set; }
            /// <summary>
            /// ColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-colorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorSpace { get; set; }
            /// <summary>
            /// FixedAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-fixedafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FixedAfd { get; set; }
            /// <summary>
            /// GopSizeUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopsizeunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GopSizeUnits { get; set; }
            /// <summary>
            /// FramerateNumerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-frameratenumerator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateNumerator { get; set; }
            /// <summary>
            /// GopClosedCadence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopclosedcadence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GopClosedCadence { get; set; }
            /// <summary>
            /// AfdSignaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-afdsignaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AfdSignaling { get; set; }
            /// <summary>
            /// DisplayAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-displayaspectratio
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayAspectRatio { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanType { get; set; }
            /// <summary>
            /// TimecodeInsertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-timecodeinsertion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimecodeInsertion { get; set; }
            /// <summary>
            /// ColorMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-colormetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorMetadata { get; set; }
            /// <summary>
            /// FramerateDenominator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-frameratedenominator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FramerateDenominator { get; set; }
            /// <summary>
            /// GopSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? GopSize { get; set; }
            /// <summary>
            /// AdaptiveQuantization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-adaptivequantization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdaptiveQuantization { get; set; }
            /// <summary>
            /// SubgopLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-subgoplength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubgopLength { get; set; }
            /// <summary>
            /// FilterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-filtersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mpeg2FilterSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Mpeg2FilterSettings, BaseFunction>? FilterSettings { get; set; }
            /// <summary>
            /// GopNumBFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html#cfn-medialive-channel-mpeg2settings-gopnumbframes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GopNumBFrames { get; set; }
        }

        public class MsSmoothGroupSettings : Humidifier.Base.BaseSubResource, IHaveSegmentationMode, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveEventStopBehavior, IHaveFilecacheDuration_Integer, IHaveCertificateMode, IHaveAcquisitionPointId, IHaveStreamManifestBehavior, IHaveInputLossAction, IHaveFragmentLength_Integer, IHaveRestartDelay_Integer, IHaveSparseTrackType, IHaveEventIdMode, IHaveTimestampOffsetMode, IHaveAudioOnlyTimecodeControl, IHaveNumRetries_Integer, IHaveTimestampOffset, IHaveEventId, IHaveSendDelayMs_Integer, IHaveConnectionRetryInterval_Integer
        {
            /// <summary>
            /// SegmentationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-segmentationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentationMode { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// EventStopBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-eventstopbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventStopBehavior { get; set; }
            /// <summary>
            /// FilecacheDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-filecacheduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FilecacheDuration { get; set; }
            /// <summary>
            /// CertificateMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-certificatemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateMode { get; set; }
            /// <summary>
            /// AcquisitionPointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-acquisitionpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AcquisitionPointId { get; set; }
            /// <summary>
            /// StreamManifestBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-streammanifestbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamManifestBehavior { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossAction { get; set; }
            /// <summary>
            /// FragmentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-fragmentlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FragmentLength { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartDelay { get; set; }
            /// <summary>
            /// SparseTrackType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-sparsetracktype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SparseTrackType { get; set; }
            /// <summary>
            /// EventIdMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-eventidmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventIdMode { get; set; }
            /// <summary>
            /// TimestampOffsetMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-timestampoffsetmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampOffsetMode { get; set; }
            /// <summary>
            /// AudioOnlyTimecodeControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-audioonlytimecodecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioOnlyTimecodeControl { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRetries { get; set; }
            /// <summary>
            /// TimestampOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-timestampoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampOffset { get; set; }
            /// <summary>
            /// EventId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-eventid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventId { get; set; }
            /// <summary>
            /// SendDelayMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-senddelayms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SendDelayMs { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html#cfn-medialive-channel-mssmoothgroupsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionRetryInterval { get; set; }
        }

        public class MsSmoothOutputSettings : Humidifier.Base.BaseSubResource, IHaveNameModifier, IHaveH265PackagingType
        {
            /// <summary>
            /// NameModifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothoutputsettings.html#cfn-medialive-channel-mssmoothoutputsettings-namemodifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NameModifier { get; set; }
            /// <summary>
            /// H265PackagingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothoutputsettings.html#cfn-medialive-channel-mssmoothoutputsettings-h265packagingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? H265PackagingType { get; set; }
        }

        public class MulticastInputSettings : Humidifier.Base.BaseSubResource, IHaveSourceIpAddress
        {
            /// <summary>
            /// SourceIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multicastinputsettings.html#cfn-medialive-channel-multicastinputsettings-sourceipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIpAddress { get; set; }
        }

        public class MultiplexContainerSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesMultiplexM2tsSettingsMultiplexM2tsSettings
        {
            /// <summary>
            /// MultiplexM2tsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexcontainersettings.html#cfn-medialive-channel-multiplexcontainersettings-multiplexm2tssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexM2tsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MultiplexM2tsSettings, BaseFunction>? MultiplexM2tsSettings { get; set; }
        }

        public class MultiplexM2tsSettings : Humidifier.Base.BaseSubResource, IHaveScte35Control, IHavePcrPeriod_Integer, IHaveNielsenId3Behavior, IHaveEsRateInPes, IHaveCcDescriptor, IHaveAudioFramesPerPes_Integer, IHaveAbsentInputAudioBehavior, IHaveAudioStreamType, IHaveKlv, IHaveArib, IHaveAudioBufferModel, IHaveEbif, IHaveScte35PrerollPullupMilliseconds_Double, IHavePcrControl
        {
            /// <summary>
            /// Scte35Control
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-scte35control
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scte35Control { get; set; }
            /// <summary>
            /// PcrPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-pcrperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PcrPeriod { get; set; }
            /// <summary>
            /// NielsenId3Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-nielsenid3behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenId3Behavior { get; set; }
            /// <summary>
            /// EsRateInPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-esrateinpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EsRateInPes { get; set; }
            /// <summary>
            /// CcDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-ccdescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CcDescriptor { get; set; }
            /// <summary>
            /// AudioFramesPerPes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-audioframesperpes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AudioFramesPerPes { get; set; }
            /// <summary>
            /// AbsentInputAudioBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-absentinputaudiobehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AbsentInputAudioBehavior { get; set; }
            /// <summary>
            /// AudioStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-audiostreamtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioStreamType { get; set; }
            /// <summary>
            /// Klv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-klv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Klv { get; set; }
            /// <summary>
            /// Arib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-arib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arib { get; set; }
            /// <summary>
            /// AudioBufferModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-audiobuffermodel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioBufferModel { get; set; }
            /// <summary>
            /// Ebif
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-ebif
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ebif { get; set; }
            /// <summary>
            /// Scte35PrerollPullupMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-scte35prerollpullupmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Scte35PrerollPullupMilliseconds { get; set; }
            /// <summary>
            /// PcrControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexm2tssettings.html#cfn-medialive-channel-multiplexm2tssettings-pcrcontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PcrControl { get; set; }
        }

        public class MultiplexOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveMediaLiveChannelTypesMultiplexContainerSettingsContainerSettings
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexoutputsettings.html#cfn-medialive-channel-multiplexoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexoutputsettings.html#cfn-medialive-channel-multiplexoutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexContainerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MultiplexContainerSettings, BaseFunction>? ContainerSettings { get; set; }
        }

        public class MultiplexProgramChannelDestinationSettings : Humidifier.Base.BaseSubResource, IHaveMultiplexId, IHaveProgramName
        {
            /// <summary>
            /// MultiplexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html#cfn-medialive-channel-multiplexprogramchanneldestinationsettings-multiplexid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MultiplexId { get; set; }
            /// <summary>
            /// ProgramName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html#cfn-medialive-channel-multiplexprogramchanneldestinationsettings-programname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProgramName { get; set; }
        }

        public class NetworkInputSettings : Humidifier.Base.BaseSubResource, IHaveServerValidation, IHaveMediaLiveChannelTypesHlsInputSettingsHlsInputSettings, IHaveMediaLiveChannelTypesMulticastInputSettingsMulticastInputSettings
        {
            /// <summary>
            /// ServerValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-servervalidation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerValidation { get; set; }
            /// <summary>
            /// HlsInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-hlsinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsInputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsInputSettings, BaseFunction>? HlsInputSettings { get; set; }
            /// <summary>
            /// MulticastInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-multicastinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MulticastInputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings, BaseFunction>? MulticastInputSettings { get; set; }
        }

        public class NielsenCBET : Humidifier.Base.BaseSubResource, IHaveCbetCheckDigitString, IHaveCbetStepaside, IHaveCsid
        {
            /// <summary>
            /// CbetCheckDigitString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsencbet.html#cfn-medialive-channel-nielsencbet-cbetcheckdigitstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CbetCheckDigitString { get; set; }
            /// <summary>
            /// CbetStepaside
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsencbet.html#cfn-medialive-channel-nielsencbet-cbetstepaside
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CbetStepaside { get; set; }
            /// <summary>
            /// Csid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsencbet.html#cfn-medialive-channel-nielsencbet-csid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Csid { get; set; }
        }

        public class NielsenConfiguration : Humidifier.Base.BaseSubResource, IHaveDistributorId, IHaveNielsenPcmToId3Tagging
        {
            /// <summary>
            /// DistributorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html#cfn-medialive-channel-nielsenconfiguration-distributorid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DistributorId { get; set; }
            /// <summary>
            /// NielsenPcmToId3Tagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html#cfn-medialive-channel-nielsenconfiguration-nielsenpcmtoid3tagging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenPcmToId3Tagging { get; set; }
        }

        public class NielsenNaesIiNwOnlySettings : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveCheckDigitString, IHaveSid_Double
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsennaesiinwonlysettings.html#cfn-medialive-channel-nielsennaesiinwonlysettings-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// CheckDigitString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsennaesiinwonlysettings.html#cfn-medialive-channel-nielsennaesiinwonlysettings-checkdigitstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CheckDigitString { get; set; }
            /// <summary>
            /// Sid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsennaesiinwonlysettings.html#cfn-medialive-channel-nielsennaesiinwonlysettings-sid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Sid { get; set; }
        }

        public class NielsenWatermarksSettings : Humidifier.Base.BaseSubResource, IHaveNielsenDistributionType, IHaveMediaLiveChannelTypesNielsenCBETNielsenCbetSettings, IHaveMediaLiveChannelTypesNielsenNaesIiNwOnlySettingsNielsenNwOnlySettings, IHaveMediaLiveChannelTypesNielsenNaesIiNwOnlySettingsNielsenNaesIiNwSettings
        {
            /// <summary>
            /// NielsenDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsendistributiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NielsenDistributionType { get; set; }
            /// <summary>
            /// NielsenCbetSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsencbetsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenCBET
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.NielsenCBET, BaseFunction>? NielsenCbetSettings { get; set; }
            /// <summary>
            /// NielsenNwOnlySettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsennwonlysettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenNaesIiNwOnlySettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.NielsenNaesIiNwOnlySettings, BaseFunction>? NielsenNwOnlySettings { get; set; }
            /// <summary>
            /// NielsenNaesIiNwSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenwatermarkssettings.html#cfn-medialive-channel-nielsenwatermarkssettings-nielsennaesiinwsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NielsenNaesIiNwOnlySettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.NielsenNaesIiNwOnlySettings, BaseFunction>? NielsenNaesIiNwSettings { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputSettingsOutputSettings, IHaveStringListOfCaptionDescriptionNames, IHaveStringListOfAudioDescriptionNames, IHaveOutputName, IHaveVideoDescriptionName
        {
            /// <summary>
            /// OutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-outputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputSettings, BaseFunction>? OutputSettings { get; set; }
            /// <summary>
            /// CaptionDescriptionNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-captiondescriptionnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CaptionDescriptionNames { get; set; }
            /// <summary>
            /// AudioDescriptionNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-audiodescriptionnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AudioDescriptionNames { get; set; }
            /// <summary>
            /// OutputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-outputname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputName { get; set; }
            /// <summary>
            /// VideoDescriptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html#cfn-medialive-channel-output-videodescriptionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoDescriptionName { get; set; }
        }

        public class OutputDestination : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveChannelTypesSrtOutputDestinationSettingsSrtSettings, IHaveStringListOfLogicalInterfaceNames, IHaveMediaLiveChannelTypesMultiplexProgramChannelDestinationSettingsMultiplexSettings, IHaveListOfMediaLiveChannelTypesMediaConnectRouterOutputDestinationSettingsMediaConnectRouterSettings, IHaveId, IHaveListOfMediaLiveChannelTypesOutputDestinationSettingsSettings, IHaveListOfMediaLiveChannelTypesMediaPackageOutputDestinationSettingsMediaPackageSettings
        {
            /// <summary>
            /// SrtSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-srtsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SrtOutputDestinationSettings
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.SrtOutputDestinationSettings>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.SrtOutputDestinationSettings, BaseFunction>>, BaseFunction>? SrtSettings { get; set; }
            /// <summary>
            /// LogicalInterfaceNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-logicalinterfacenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogicalInterfaceNames { get; set; }
            /// <summary>
            /// MultiplexSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-multiplexsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexProgramChannelDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings, BaseFunction>? MultiplexSettings { get; set; }
            /// <summary>
            /// MediaConnectRouterSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-mediaconnectroutersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaConnectRouterOutputDestinationSettings
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.MediaConnectRouterOutputDestinationSettings>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.MediaConnectRouterOutputDestinationSettings, BaseFunction>>, BaseFunction>? MediaConnectRouterSettings { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputDestinationSettings
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.OutputDestinationSettings>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.OutputDestinationSettings, BaseFunction>>, BaseFunction>? Settings { get; set; }
            /// <summary>
            /// MediaPackageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-mediapackagesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaPackageOutputDestinationSettings
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.MediaPackageOutputDestinationSettings>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.MediaPackageOutputDestinationSettings, BaseFunction>>, BaseFunction>? MediaPackageSettings { get; set; }
        }

        public class OutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveStreamName, IHaveUsername, IHaveVirtualSourceAddress, IHavePasswordParam, IHaveUrl
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// VirtualSourceAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-virtualsourceaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualSourceAddress { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PasswordParam { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class OutputGroup : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveChannelTypesOutputOutputs, IHaveMediaLiveChannelTypesOutputGroupSettingsOutputGroupSettings, IHaveName
        {
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html#cfn-medialive-channel-outputgroup-outputs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Output
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.Output>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.Output, BaseFunction>>, BaseFunction>? Outputs { get; set; }
            /// <summary>
            /// OutputGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html#cfn-medialive-channel-outputgroup-outputgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputGroupSettings, BaseFunction>? OutputGroupSettings { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html#cfn-medialive-channel-outputgroup-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OutputGroupSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesHlsGroupSettingsHlsGroupSettings, IHaveMediaLiveChannelTypesFrameCaptureGroupSettingsFrameCaptureGroupSettings, IHaveMediaLiveChannelTypesEmptyConfigurationSettingsMultiplexGroupSettings, IHaveMediaLiveChannelTypesSrtGroupSettingsSrtGroupSettings, IHaveMediaLiveChannelTypesMediaConnectRouterGroupSettingsMediaConnectRouterGroupSettings, IHaveMediaLiveChannelTypesArchiveGroupSettingsArchiveGroupSettings, IHaveMediaLiveChannelTypesMediaPackageGroupSettingsMediaPackageGroupSettings, IHaveMediaLiveChannelTypesUdpGroupSettingsUdpGroupSettings, IHaveMediaLiveChannelTypesMsSmoothGroupSettingsMsSmoothGroupSettings, IHaveMediaLiveChannelTypesRtmpGroupSettingsRtmpGroupSettings, IHaveMediaLiveChannelTypesCmafIngestGroupSettingsCmafIngestGroupSettings
        {
            /// <summary>
            /// HlsGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-hlsgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsGroupSettings, BaseFunction>? HlsGroupSettings { get; set; }
            /// <summary>
            /// FrameCaptureGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-framecapturegroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FrameCaptureGroupSettings, BaseFunction>? FrameCaptureGroupSettings { get; set; }
            /// <summary>
            /// MultiplexGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-multiplexgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmptyConfigurationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EmptyConfigurationSettings, BaseFunction>? MultiplexGroupSettings { get; set; }
            /// <summary>
            /// SrtGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-srtgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.SrtGroupSettings, BaseFunction>? SrtGroupSettings { get; set; }
            /// <summary>
            /// MediaConnectRouterGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-mediaconnectroutergroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaConnectRouterGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaConnectRouterGroupSettings, BaseFunction>? MediaConnectRouterGroupSettings { get; set; }
            /// <summary>
            /// ArchiveGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-archivegroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveGroupSettings, BaseFunction>? ArchiveGroupSettings { get; set; }
            /// <summary>
            /// MediaPackageGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-mediapackagegroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaPackageGroupSettings, BaseFunction>? MediaPackageGroupSettings { get; set; }
            /// <summary>
            /// UdpGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-udpgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.UdpGroupSettings, BaseFunction>? UdpGroupSettings { get; set; }
            /// <summary>
            /// MsSmoothGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-mssmoothgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MsSmoothGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MsSmoothGroupSettings, BaseFunction>? MsSmoothGroupSettings { get; set; }
            /// <summary>
            /// RtmpGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-rtmpgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtmpGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.RtmpGroupSettings, BaseFunction>? RtmpGroupSettings { get; set; }
            /// <summary>
            /// CmafIngestGroupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html#cfn-medialive-channel-outputgroupsettings-cmafingestgroupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestGroupSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CmafIngestGroupSettings, BaseFunction>? CmafIngestGroupSettings { get; set; }
        }

        public class OutputLocationRef : Humidifier.Base.BaseSubResource, IHaveDestinationRefId
        {
            /// <summary>
            /// DestinationRefId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlocationref.html#cfn-medialive-channel-outputlocationref-destinationrefid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationRefId { get; set; }
        }

        public class OutputLockingSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesDisabledLockingSettingsDisabledLockingSettings, IHaveMediaLiveChannelTypesPipelineLockingSettingsPipelineLockingSettings, IHaveMediaLiveChannelTypesEpochLockingSettingsEpochLockingSettings
        {
            /// <summary>
            /// DisabledLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlockingsettings.html#cfn-medialive-channel-outputlockingsettings-disabledlockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DisabledLockingSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.DisabledLockingSettings, BaseFunction>? DisabledLockingSettings { get; set; }
            /// <summary>
            /// PipelineLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlockingsettings.html#cfn-medialive-channel-outputlockingsettings-pipelinelockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipelineLockingSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.PipelineLockingSettings, BaseFunction>? PipelineLockingSettings { get; set; }
            /// <summary>
            /// EpochLockingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlockingsettings.html#cfn-medialive-channel-outputlockingsettings-epochlockingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpochLockingSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.EpochLockingSettings, BaseFunction>? EpochLockingSettings { get; set; }
        }

        public class OutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesMediaPackageOutputSettingsMediaPackageOutputSettings, IHaveMediaLiveChannelTypesMsSmoothOutputSettingsMsSmoothOutputSettings, IHaveMediaLiveChannelTypesCmafIngestFrameCaptureOutputSettingsFrameCaptureOutputSettings, IHaveMediaLiveChannelTypesHlsOutputSettingsHlsOutputSettings, IHaveMediaLiveChannelTypesRtmpOutputSettingsRtmpOutputSettings, IHaveMediaLiveChannelTypesUdpOutputSettingsUdpOutputSettings, IHaveMediaLiveChannelTypesMultiplexOutputSettingsMultiplexOutputSettings, IHaveMediaLiveChannelTypesMediaConnectRouterOutputSettingsMediaConnectRouterOutputSettings, IHaveMediaLiveChannelTypesCmafIngestFrameCaptureOutputSettingsCmafIngestOutputSettings, IHaveMediaLiveChannelTypesSrtOutputSettingsSrtOutputSettings, IHaveMediaLiveChannelTypesArchiveOutputSettingsArchiveOutputSettings
        {
            /// <summary>
            /// MediaPackageOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-mediapackageoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaPackageOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaPackageOutputSettings, BaseFunction>? MediaPackageOutputSettings { get; set; }
            /// <summary>
            /// MsSmoothOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-mssmoothoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MsSmoothOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MsSmoothOutputSettings, BaseFunction>? MsSmoothOutputSettings { get; set; }
            /// <summary>
            /// FrameCaptureOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-framecaptureoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestFrameCaptureOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CmafIngestFrameCaptureOutputSettings, BaseFunction>? FrameCaptureOutputSettings { get; set; }
            /// <summary>
            /// HlsOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-hlsoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.HlsOutputSettings, BaseFunction>? HlsOutputSettings { get; set; }
            /// <summary>
            /// RtmpOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-rtmpoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtmpOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.RtmpOutputSettings, BaseFunction>? RtmpOutputSettings { get; set; }
            /// <summary>
            /// UdpOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-udpoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.UdpOutputSettings, BaseFunction>? UdpOutputSettings { get; set; }
            /// <summary>
            /// MultiplexOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-multiplexoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MultiplexOutputSettings, BaseFunction>? MultiplexOutputSettings { get; set; }
            /// <summary>
            /// MediaConnectRouterOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-mediaconnectrouteroutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaConnectRouterOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.MediaConnectRouterOutputSettings, BaseFunction>? MediaConnectRouterOutputSettings { get; set; }
            /// <summary>
            /// CmafIngestOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-cmafingestoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CmafIngestFrameCaptureOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CmafIngestFrameCaptureOutputSettings, BaseFunction>? CmafIngestOutputSettings { get; set; }
            /// <summary>
            /// SrtOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-srtoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.SrtOutputSettings, BaseFunction>? SrtOutputSettings { get; set; }
            /// <summary>
            /// ArchiveOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html#cfn-medialive-channel-outputsettings-archiveoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.ArchiveOutputSettings, BaseFunction>? ArchiveOutputSettings { get; set; }
        }

        public class PipelineLockingSettings : Humidifier.Base.BaseSubResource, IHavePipelineLockingMethod, IHaveCustomEpoch
        {
            /// <summary>
            /// PipelineLockingMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-pipelinelockingsettings.html#cfn-medialive-channel-pipelinelockingsettings-pipelinelockingmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipelineLockingMethod { get; set; }
            /// <summary>
            /// CustomEpoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-pipelinelockingsettings.html#cfn-medialive-channel-pipelinelockingsettings-customepoch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEpoch { get; set; }
        }

        public class PrimaryChannelSettings : Humidifier.Base.BaseSubResource, IHaveLinkedChannelType
        {
            /// <summary>
            /// LinkedChannelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-primarychannelsettings.html#cfn-medialive-channel-primarychannelsettings-linkedchanneltype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LinkedChannelType { get; set; }
        }

        public class RemixSettings : Humidifier.Base.BaseSubResource, IHaveChannelsOut_Integer, IHaveListOfMediaLiveChannelTypesAudioChannelMappingChannelMappings, IHaveChannelsIn_Integer
        {
            /// <summary>
            /// ChannelsOut
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelsout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ChannelsOut { get; set; }
            /// <summary>
            /// ChannelMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelmappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioChannelMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ChannelTypes.AudioChannelMapping>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelTypes.AudioChannelMapping, BaseFunction>>, BaseFunction>? ChannelMappings { get; set; }
            /// <summary>
            /// ChannelsIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html#cfn-medialive-channel-remixsettings-channelsin
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ChannelsIn { get; set; }
        }

        public class RtmpGroupSettings : Humidifier.Base.BaseSubResource, IHaveAuthenticationScheme, IHaveCacheLength_Integer, IHaveStringListOfAdMarkers, IHaveIncludeFillerNalUnits, IHaveInputLossAction, IHaveRestartDelay_Integer, IHaveCaptionData, IHaveCacheFullBehavior
        {
            /// <summary>
            /// AuthenticationScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-authenticationscheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationScheme { get; set; }
            /// <summary>
            /// CacheLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-cachelength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CacheLength { get; set; }
            /// <summary>
            /// AdMarkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-admarkers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdMarkers { get; set; }
            /// <summary>
            /// IncludeFillerNalUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-includefillernalunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludeFillerNalUnits { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossAction { get; set; }
            /// <summary>
            /// RestartDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-restartdelay
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartDelay { get; set; }
            /// <summary>
            /// CaptionData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-captiondata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaptionData { get; set; }
            /// <summary>
            /// CacheFullBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html#cfn-medialive-channel-rtmpgroupsettings-cachefullbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheFullBehavior { get; set; }
        }

        public class RtmpOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveCertificateMode, IHaveNumRetries_Integer, IHaveConnectionRetryInterval_Integer
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// CertificateMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-certificatemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateMode { get; set; }
            /// <summary>
            /// NumRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-numretries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumRetries { get; set; }
            /// <summary>
            /// ConnectionRetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html#cfn-medialive-channel-rtmpoutputsettings-connectionretryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionRetryInterval { get; set; }
        }

        public class Scte20SourceSettings : Humidifier.Base.BaseSubResource, IHaveSource608ChannelNumber_Integer, IHaveConvert608To708
        {
            /// <summary>
            /// Source608ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html#cfn-medialive-channel-scte20sourcesettings-source608channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Source608ChannelNumber { get; set; }
            /// <summary>
            /// Convert608To708
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html#cfn-medialive-channel-scte20sourcesettings-convert608to708
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Convert608To708 { get; set; }
        }

        public class Scte27DvbSubSourceSettings : Humidifier.Base.BaseSubResource, IHaveOcrLanguage, IHavePid_Integer
        {
            /// <summary>
            /// OcrLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte27dvbsubsourcesettings.html#cfn-medialive-channel-scte27dvbsubsourcesettings-ocrlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OcrLanguage { get; set; }
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte27dvbsubsourcesettings.html#cfn-medialive-channel-scte27dvbsubsourcesettings-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Pid { get; set; }
        }

        public class Scte35SpliceInsertTimeSignalAposSettings : Humidifier.Base.BaseSubResource, IHaveAdAvailOffset_Integer, IHaveWebDeliveryAllowedFlag, IHaveNoRegionalBlackoutFlag
        {
            /// <summary>
            /// AdAvailOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinserttimesignalapossettings.html#cfn-medialive-channel-scte35spliceinserttimesignalapossettings-adavailoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AdAvailOffset { get; set; }
            /// <summary>
            /// WebDeliveryAllowedFlag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinserttimesignalapossettings.html#cfn-medialive-channel-scte35spliceinserttimesignalapossettings-webdeliveryallowedflag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebDeliveryAllowedFlag { get; set; }
            /// <summary>
            /// NoRegionalBlackoutFlag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinserttimesignalapossettings.html#cfn-medialive-channel-scte35spliceinserttimesignalapossettings-noregionalblackoutflag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoRegionalBlackoutFlag { get; set; }
        }

        public class SmartSubtitleSourceSettings : Humidifier.Base.BaseSubResource, IHaveCaptionSynchronizationMode, IHaveInferenceFeedOutput
        {
            /// <summary>
            /// CaptionSynchronizationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-smartsubtitlesourcesettings.html#cfn-medialive-channel-smartsubtitlesourcesettings-captionsynchronizationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaptionSynchronizationMode { get; set; }
            /// <summary>
            /// InferenceFeedOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-smartsubtitlesourcesettings.html#cfn-medialive-channel-smartsubtitlesourcesettings-inferencefeedoutput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceFeedOutput { get; set; }
        }

        public class SpecialRouterSettings : Humidifier.Base.BaseSubResource, IHaveRouterArn
        {
            /// <summary>
            /// RouterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-specialroutersettings.html#cfn-medialive-channel-specialroutersettings-routerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RouterArn { get; set; }
        }

        public class SrtGroupSettings : Humidifier.Base.BaseSubResource, IHaveInputLossAction
        {
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtgroupsettings.html#cfn-medialive-channel-srtgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossAction { get; set; }
        }

        public class SrtOutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveListenerPort_Integer, IHaveStreamId, IHaveConnectionMode, IHaveEncryptionPassphraseSecretArn, IHaveUrl
        {
            /// <summary>
            /// ListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputdestinationsettings.html#cfn-medialive-channel-srtoutputdestinationsettings-listenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ListenerPort { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputdestinationsettings.html#cfn-medialive-channel-srtoutputdestinationsettings-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// ConnectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputdestinationsettings.html#cfn-medialive-channel-srtoutputdestinationsettings-connectionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionMode { get; set; }
            /// <summary>
            /// EncryptionPassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputdestinationsettings.html#cfn-medialive-channel-srtoutputdestinationsettings-encryptionpassphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionPassphraseSecretArn { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputdestinationsettings.html#cfn-medialive-channel-srtoutputdestinationsettings-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class SrtOutputSettings : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveMediaLiveChannelTypesUdpMediaConnectRouterContainerSettingsContainerSettings, IHaveBufferMsec_Integer, IHaveLatency_Integer
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputsettings.html#cfn-medialive-channel-srtoutputsettings-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputsettings.html#cfn-medialive-channel-srtoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputsettings.html#cfn-medialive-channel-srtoutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpMediaConnectRouterContainerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.UdpMediaConnectRouterContainerSettings, BaseFunction>? ContainerSettings { get; set; }
            /// <summary>
            /// BufferMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputsettings.html#cfn-medialive-channel-srtoutputsettings-buffermsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufferMsec { get; set; }
            /// <summary>
            /// Latency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-srtoutputsettings.html#cfn-medialive-channel-srtoutputsettings-latency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Latency { get; set; }
        }

        public class StandardHlsSettings : Humidifier.Base.BaseSubResource, IHaveAudioRenditionSets, IHaveMediaLiveChannelTypesM3u8SettingsM3u8Settings
        {
            /// <summary>
            /// AudioRenditionSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html#cfn-medialive-channel-standardhlssettings-audiorenditionsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioRenditionSets { get; set; }
            /// <summary>
            /// M3u8Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-standardhlssettings.html#cfn-medialive-channel-standardhlssettings-m3u8settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M3u8Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.M3u8Settings, BaseFunction>? M3u8Settings { get; set; }
        }

        public class StaticKeySettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesInputLocationKeyProviderServer, IHaveStaticKeyValue
        {
            /// <summary>
            /// KeyProviderServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html#cfn-medialive-channel-statickeysettings-keyproviderserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLocation
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.InputLocation, BaseFunction>? KeyProviderServer { get; set; }
            /// <summary>
            /// StaticKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html#cfn-medialive-channel-statickeysettings-statickeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StaticKeyValue { get; set; }
        }

        public class TeletextSourceSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesCaptionRectangleOutputRectangle, IHavePageNumber
        {
            /// <summary>
            /// OutputRectangle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-teletextsourcesettings.html#cfn-medialive-channel-teletextsourcesettings-outputrectangle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionRectangle
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.CaptionRectangle, BaseFunction>? OutputRectangle { get; set; }
            /// <summary>
            /// PageNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-teletextsourcesettings.html#cfn-medialive-channel-teletextsourcesettings-pagenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PageNumber { get; set; }
        }

        public class TemporalFilterSettings : Humidifier.Base.BaseSubResource, IHavePostFilterSharpening, IHaveStrength
        {
            /// <summary>
            /// PostFilterSharpening
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-temporalfiltersettings.html#cfn-medialive-channel-temporalfiltersettings-postfiltersharpening
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostFilterSharpening { get; set; }
            /// <summary>
            /// Strength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-temporalfiltersettings.html#cfn-medialive-channel-temporalfiltersettings-strength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strength { get; set; }
        }

        public class TextCaptionPositionSettings : Humidifier.Base.BaseSubResource, IHaveYPositionPercentage_Integer
        {
            /// <summary>
            /// YPositionPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-textcaptionpositionsettings.html#cfn-medialive-channel-textcaptionpositionsettings-ypositionpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? YPositionPercentage { get; set; }
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
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class TimecodeBurninSettings : Humidifier.Base.BaseSubResource, IHaveFontSize, IHavePosition, IHavePrefix
        {
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeburninsettings.html#cfn-medialive-channel-timecodeburninsettings-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontSize { get; set; }
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeburninsettings.html#cfn-medialive-channel-timecodeburninsettings-position
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Position { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeburninsettings.html#cfn-medialive-channel-timecodeburninsettings-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class TimecodeConfig : Humidifier.Base.BaseSubResource, IHaveSyncThreshold_Integer, IHaveSource
        {
            /// <summary>
            /// SyncThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeconfig.html#cfn-medialive-channel-timecodeconfig-syncthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SyncThreshold { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-timecodeconfig.html#cfn-medialive-channel-timecodeconfig-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class TtmlDestinationSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTextCaptionPositionSettingsPosition, IHaveStyleControl
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ttmldestinationsettings.html#cfn-medialive-channel-ttmldestinationsettings-position
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextCaptionPositionSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TextCaptionPositionSettings, BaseFunction>? Position { get; set; }
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ttmldestinationsettings.html#cfn-medialive-channel-ttmldestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StyleControl { get; set; }
        }

        public class UdpGroupSettings : Humidifier.Base.BaseSubResource, IHaveTimedMetadataId3Frame, IHaveTimedMetadataId3Period_Integer, IHaveInputLossAction
        {
            /// <summary>
            /// TimedMetadataId3Frame
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html#cfn-medialive-channel-udpgroupsettings-timedmetadataid3frame
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimedMetadataId3Frame { get; set; }
            /// <summary>
            /// TimedMetadataId3Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html#cfn-medialive-channel-udpgroupsettings-timedmetadataid3period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimedMetadataId3Period { get; set; }
            /// <summary>
            /// InputLossAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html#cfn-medialive-channel-udpgroupsettings-inputlossaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputLossAction { get; set; }
        }

        public class UdpMediaConnectRouterContainerSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesM2tsSettingsM2tsSettings
        {
            /// <summary>
            /// M2tsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpmediaconnectroutercontainersettings.html#cfn-medialive-channel-udpmediaconnectroutercontainersettings-m2tssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: M2tsSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.M2tsSettings, BaseFunction>? M2tsSettings { get; set; }
        }

        public class UdpOutputSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesOutputLocationRefDestination, IHaveMediaLiveChannelTypesFecOutputSettingsFecOutputSettings, IHaveMediaLiveChannelTypesUdpMediaConnectRouterContainerSettingsContainerSettings, IHaveBufferMsec_Integer
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputLocationRef
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.OutputLocationRef, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// FecOutputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-fecoutputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FecOutputSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FecOutputSettings, BaseFunction>? FecOutputSettings { get; set; }
            /// <summary>
            /// ContainerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-containersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UdpMediaConnectRouterContainerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.UdpMediaConnectRouterContainerSettings, BaseFunction>? ContainerSettings { get; set; }
            /// <summary>
            /// BufferMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html#cfn-medialive-channel-udpoutputsettings-buffermsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufferMsec { get; set; }
        }

        public class VideoBlackFailoverSettings : Humidifier.Base.BaseSubResource, IHaveVideoBlackThresholdMsec_Integer, IHaveBlackDetectThreshold_Double
        {
            /// <summary>
            /// VideoBlackThresholdMsec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html#cfn-medialive-channel-videoblackfailoversettings-videoblackthresholdmsec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VideoBlackThresholdMsec { get; set; }
            /// <summary>
            /// BlackDetectThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoblackfailoversettings.html#cfn-medialive-channel-videoblackfailoversettings-blackdetectthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BlackDetectThreshold { get; set; }
        }

        public class VideoCodecSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesMpeg2SettingsMpeg2Settings, IHaveMediaLiveChannelTypesFrameCaptureSettingsFrameCaptureSettings, IHaveMediaLiveChannelTypesH264SettingsH264Settings, IHaveMediaLiveChannelTypesH265SettingsH265Settings, IHaveMediaLiveChannelTypesAv1SettingsAv1Settings
        {
            /// <summary>
            /// Mpeg2Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-mpeg2settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Mpeg2Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Mpeg2Settings, BaseFunction>? Mpeg2Settings { get; set; }
            /// <summary>
            /// FrameCaptureSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-framecapturesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrameCaptureSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.FrameCaptureSettings, BaseFunction>? FrameCaptureSettings { get; set; }
            /// <summary>
            /// H264Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-h264settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H264Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.H264Settings, BaseFunction>? H264Settings { get; set; }
            /// <summary>
            /// H265Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-h265settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: H265Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.H265Settings, BaseFunction>? H265Settings { get; set; }
            /// <summary>
            /// Av1Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html#cfn-medialive-channel-videocodecsettings-av1settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Av1Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Av1Settings, BaseFunction>? Av1Settings { get; set; }
        }

        public class VideoDescription : Humidifier.Base.BaseSubResource, IHaveScalingBehavior, IHaveMediaLiveChannelTypesVideoPositionRectangleCropRectangle, IHaveRespondToAfd, IHaveHeight_Integer, IHaveSharpness_Integer, IHaveWidth_Integer, IHaveBorder_Integer, IHaveMediaLiveChannelTypesVideoCodecSettingsCodecSettings, IHaveMediaLiveChannelTypesVideoPositionRectangleOutputPositionRectangle, IHaveName
        {
            /// <summary>
            /// ScalingBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-scalingbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingBehavior { get; set; }
            /// <summary>
            /// CropRectangle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-croprectangle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoPositionRectangle
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoPositionRectangle, BaseFunction>? CropRectangle { get; set; }
            /// <summary>
            /// RespondToAfd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-respondtoafd
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RespondToAfd { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Height { get; set; }
            /// <summary>
            /// Sharpness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-sharpness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Sharpness { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Width { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-border
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Border { get; set; }
            /// <summary>
            /// CodecSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-codecsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoCodecSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoCodecSettings, BaseFunction>? CodecSettings { get; set; }
            /// <summary>
            /// OutputPositionRectangle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-outputpositionrectangle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoPositionRectangle
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoPositionRectangle, BaseFunction>? OutputPositionRectangle { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html#cfn-medialive-channel-videodescription-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class VideoPositionRectangle : Humidifier.Base.BaseSubResource, IHaveX_Integer, IHaveY_Integer, IHaveHeight_Integer, IHaveWidth_Integer
        {
            /// <summary>
            /// X
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videopositionrectangle.html#cfn-medialive-channel-videopositionrectangle-x
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? X { get; set; }
            /// <summary>
            /// Y
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videopositionrectangle.html#cfn-medialive-channel-videopositionrectangle-y
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Y { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videopositionrectangle.html#cfn-medialive-channel-videopositionrectangle-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videopositionrectangle.html#cfn-medialive-channel-videopositionrectangle-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Width { get; set; }
        }

        public class VideoSelector : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesVideoSelectorColorSpaceSettingsColorSpaceSettings, IHaveMediaLiveChannelTypesVideoSelectorSettingsSelectorSettings, IHaveColorSpace, IHaveColorSpaceUsage
        {
            /// <summary>
            /// ColorSpaceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspacesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorColorSpaceSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings, BaseFunction>? ColorSpaceSettings { get; set; }
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings, BaseFunction>? SelectorSettings { get; set; }
            /// <summary>
            /// ColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorSpace { get; set; }
            /// <summary>
            /// ColorSpaceUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspaceusage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColorSpaceUsage { get; set; }
        }

        public class VideoSelectorColorSpaceSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesHdr10SettingsHdr10Settings
        {
            /// <summary>
            /// Hdr10Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorcolorspacesettings.html#cfn-medialive-channel-videoselectorcolorspacesettings-hdr10settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Hdr10Settings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.Hdr10Settings, BaseFunction>? Hdr10Settings { get; set; }
        }

        public class VideoSelectorPid : Humidifier.Base.BaseSubResource, IHavePid_Integer
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorpid.html#cfn-medialive-channel-videoselectorpid-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Pid { get; set; }
        }

        public class VideoSelectorProgramId : Humidifier.Base.BaseSubResource, IHaveProgramId_Integer
        {
            /// <summary>
            /// ProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorprogramid.html#cfn-medialive-channel-videoselectorprogramid-programid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramId { get; set; }
        }

        public class VideoSelectorSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesVideoSelectorProgramIdVideoSelectorProgramId, IHaveMediaLiveChannelTypesVideoSelectorPidVideoSelectorPid
        {
            /// <summary>
            /// VideoSelectorProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorprogramid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorProgramId
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId, BaseFunction>? VideoSelectorProgramId { get; set; }
            /// <summary>
            /// VideoSelectorPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorpid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorPid
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid, BaseFunction>? VideoSelectorPid { get; set; }
        }

        public class VpcOutputSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfPublicAddressAllocationIds, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// PublicAddressAllocationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html#cfn-medialive-channel-vpcoutputsettings-publicaddressallocationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PublicAddressAllocationIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html#cfn-medialive-channel-vpcoutputsettings-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html#cfn-medialive-channel-vpcoutputsettings-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class WavSettings : Humidifier.Base.BaseSubResource, IHaveCodingMode, IHaveSampleRate_Double, IHaveBitDepth_Double
        {
            /// <summary>
            /// CodingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html#cfn-medialive-channel-wavsettings-codingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodingMode { get; set; }
            /// <summary>
            /// SampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html#cfn-medialive-channel-wavsettings-samplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SampleRate { get; set; }
            /// <summary>
            /// BitDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html#cfn-medialive-channel-wavsettings-bitdepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BitDepth { get; set; }
        }

        public class WebvttDestinationSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelTypesTextCaptionPositionSettingsPosition, IHaveStyleControl
        {
            /// <summary>
            /// Position
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-webvttdestinationsettings.html#cfn-medialive-channel-webvttdestinationsettings-position
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextCaptionPositionSettings
            /// </summary>
            public Union<Humidifier.MediaLive.ChannelTypes.TextCaptionPositionSettings, BaseFunction>? Position { get; set; }
            /// <summary>
            /// StyleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-webvttdestinationsettings.html#cfn-medialive-channel-webvttdestinationsettings-stylecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StyleControl { get; set; }
        }
    }
}