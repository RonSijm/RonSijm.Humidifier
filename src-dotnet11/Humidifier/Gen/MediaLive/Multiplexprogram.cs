namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using MultiplexprogramTypes;

    public class Multiplexprogram : Humidifier.Base.BaseResource, IHaveMultiplexId, IHavePreferredChannelPipeline, IHaveMediaLiveMultiplexprogramTypesMultiplexProgramPacketIdentifiersMapPacketIdentifiersMap, IHaveListOfMediaLiveMultiplexprogramTypesMultiplexProgramPipelineDetailPipelineDetails, IHaveMediaLiveMultiplexprogramTypesMultiplexProgramSettingsMultiplexProgramSettings, IHaveProgramName
    {
        public class Attributes
        {
            public static string ChannelId =  "ChannelId" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Multiplexprogram; }
        /// <summary>
        /// MultiplexId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-multiplexid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MultiplexId { get; set; }
        /// <summary>
        /// PreferredChannelPipeline
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-preferredchannelpipeline
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredChannelPipeline { get; set; }
        /// <summary>
        /// PacketIdentifiersMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-packetidentifiersmap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiplexProgramPacketIdentifiersMap
        /// </summary>
        public Union<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap, BaseFunction>? PacketIdentifiersMap { get; set; }
        /// <summary>
        /// PipelineDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-pipelinedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MultiplexProgramPipelineDetail
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail>, IReadOnlyList<Union<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail, BaseFunction>>, BaseFunction>? PipelineDetails { get; set; }
        /// <summary>
        /// MultiplexProgramSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-multiplexprogramsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiplexProgramSettings
        /// </summary>
        public Union<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings, BaseFunction>? MultiplexProgramSettings { get; set; }
        /// <summary>
        /// ProgramName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-programname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProgramName { get; set; }
    }

    namespace MultiplexprogramTypes
    {
        public class MultiplexProgramPacketIdentifiersMap : Humidifier.Base.BaseSubResource, IHaveEtvPlatformPid_Integer, IHaveDvbTeletextPid_Integer, IHaveIntegerListOfKlvDataPids, IHavePcrPid_Integer, IHaveVideoPid_Integer, IHavePmtPid_Integer, IHaveIntegerListOfScte27Pids, IHaveIntegerListOfDvbSubPids, IHaveScte35Pid_Integer, IHaveEtvSignalPid_Integer, IHavePrivateMetadataPid_Integer, IHaveTimedMetadataPid_Integer, IHaveIntegerListOfAudioPids
        {
            /// <summary>
            /// EtvPlatformPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-etvplatformpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EtvPlatformPid { get; set; }
            /// <summary>
            /// DvbTeletextPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-dvbteletextpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DvbTeletextPid { get; set; }
            /// <summary>
            /// KlvDataPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-klvdatapids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? KlvDataPids { get; set; }
            /// <summary>
            /// PcrPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-pcrpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PcrPid { get; set; }
            /// <summary>
            /// VideoPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-videopid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VideoPid { get; set; }
            /// <summary>
            /// PmtPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-pmtpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PmtPid { get; set; }
            /// <summary>
            /// Scte27Pids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-scte27pids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Scte27Pids { get; set; }
            /// <summary>
            /// DvbSubPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-dvbsubpids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? DvbSubPids { get; set; }
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Scte35Pid { get; set; }
            /// <summary>
            /// EtvSignalPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-etvsignalpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EtvSignalPid { get; set; }
            /// <summary>
            /// PrivateMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-privatemetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PrivateMetadataPid { get; set; }
            /// <summary>
            /// TimedMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-timedmetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimedMetadataPid { get; set; }
            /// <summary>
            /// AudioPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-audiopids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? AudioPids { get; set; }
        }

        public class MultiplexProgramPipelineDetail : Humidifier.Base.BaseSubResource, IHaveActiveChannelPipeline, IHavePipelineId
        {
            /// <summary>
            /// ActiveChannelPipeline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampipelinedetail.html#cfn-medialive-multiplexprogram-multiplexprogrampipelinedetail-activechannelpipeline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveChannelPipeline { get; set; }
            /// <summary>
            /// PipelineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampipelinedetail.html#cfn-medialive-multiplexprogram-multiplexprogrampipelinedetail-pipelineid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipelineId { get; set; }
        }

        public class MultiplexProgramServiceDescriptor : Humidifier.Base.BaseSubResource, IHaveProviderName, IHaveServiceName
        {
            /// <summary>
            /// ProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramservicedescriptor.html#cfn-medialive-multiplexprogram-multiplexprogramservicedescriptor-providername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderName { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramservicedescriptor.html#cfn-medialive-multiplexprogram-multiplexprogramservicedescriptor-servicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
        }

        public class MultiplexProgramSettings : Humidifier.Base.BaseSubResource, IHavePreferredChannelPipeline, IHaveMediaLiveMultiplexprogramTypesMultiplexProgramServiceDescriptorServiceDescriptor, IHaveMediaLiveMultiplexprogramTypesMultiplexVideoSettingsVideoSettings, IHaveProgramNumber_Integer
        {
            /// <summary>
            /// PreferredChannelPipeline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-preferredchannelpipeline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredChannelPipeline { get; set; }
            /// <summary>
            /// ServiceDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-servicedescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexProgramServiceDescriptor
            /// </summary>
            public Union<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor, BaseFunction>? ServiceDescriptor { get; set; }
            /// <summary>
            /// VideoSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-videosettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexVideoSettings
            /// </summary>
            public Union<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings, BaseFunction>? VideoSettings { get; set; }
            /// <summary>
            /// ProgramNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-programnumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgramNumber { get; set; }
        }

        public class MultiplexStatmuxVideoSettings : Humidifier.Base.BaseSubResource, IHavePriority_Integer, IHaveMaximumBitrate_Integer, IHaveMinimumBitrate_Integer
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexstatmuxvideosettings.html#cfn-medialive-multiplexprogram-multiplexstatmuxvideosettings-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexstatmuxvideosettings.html#cfn-medialive-multiplexprogram-multiplexstatmuxvideosettings-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBitrate { get; set; }
            /// <summary>
            /// MinimumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexstatmuxvideosettings.html#cfn-medialive-multiplexprogram-multiplexstatmuxvideosettings-minimumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumBitrate { get; set; }
        }

        public class MultiplexVideoSettings : Humidifier.Base.BaseSubResource, IHaveMediaLiveMultiplexprogramTypesMultiplexStatmuxVideoSettingsStatmuxSettings, IHaveConstantBitrate_Integer
        {
            /// <summary>
            /// StatmuxSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexvideosettings.html#cfn-medialive-multiplexprogram-multiplexvideosettings-statmuxsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexStatmuxVideoSettings
            /// </summary>
            public Union<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings, BaseFunction>? StatmuxSettings { get; set; }
            /// <summary>
            /// ConstantBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexvideosettings.html#cfn-medialive-multiplexprogram-multiplexvideosettings-constantbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConstantBitrate { get; set; }
        }
    }
}