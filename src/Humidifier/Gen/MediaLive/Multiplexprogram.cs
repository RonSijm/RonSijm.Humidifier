namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using MultiplexprogramTypes;

    public class Multiplexprogram : Humidifier.Base.BaseResource
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
        public dynamic MultiplexId { get; set; }
        /// <summary>
        /// PreferredChannelPipeline
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-preferredchannelpipeline
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredChannelPipeline { get; set; }
        /// <summary>
        /// PacketIdentifiersMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-packetidentifiersmap
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiplexProgramPacketIdentifiersMap
        /// </summary>
        public Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap PacketIdentifiersMap { get; set; }
        /// <summary>
        /// PipelineDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-pipelinedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MultiplexProgramPipelineDetail
        /// </summary>
        public List<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPipelineDetail> PipelineDetails { get; set; }
        /// <summary>
        /// MultiplexProgramSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-multiplexprogramsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiplexProgramSettings
        /// </summary>
        public Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramSettings MultiplexProgramSettings { get; set; }
        /// <summary>
        /// ProgramName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplexprogram.html#cfn-medialive-multiplexprogram-programname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProgramName { get; set; }
    }

    namespace MultiplexprogramTypes
    {
        public class MultiplexProgramPacketIdentifiersMap : Humidifier.Base.BaseSubResource, IHaveScte35Pid, IHaveVideoPid, IHavePcrPid, IHavePmtPid, IHaveTimedMetadataPid
        {
            /// <summary>
            /// EtvPlatformPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-etvplatformpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EtvPlatformPid { get; set; }
            /// <summary>
            /// DvbTeletextPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-dvbteletextpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DvbTeletextPid { get; set; }
            /// <summary>
            /// KlvDataPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-klvdatapids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> KlvDataPids { get; set; }
            /// <summary>
            /// PcrPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-pcrpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PcrPid { get; set; }
            /// <summary>
            /// VideoPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-videopid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VideoPid { get; set; }
            /// <summary>
            /// PmtPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-pmtpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PmtPid { get; set; }
            /// <summary>
            /// Scte27Pids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-scte27pids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> Scte27Pids { get; set; }
            /// <summary>
            /// DvbSubPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-dvbsubpids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> DvbSubPids { get; set; }
            /// <summary>
            /// Scte35Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-scte35pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Scte35Pid { get; set; }
            /// <summary>
            /// EtvSignalPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-etvsignalpid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EtvSignalPid { get; set; }
            /// <summary>
            /// PrivateMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-privatemetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PrivateMetadataPid { get; set; }
            /// <summary>
            /// TimedMetadataPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-timedmetadatapid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimedMetadataPid { get; set; }
            /// <summary>
            /// AudioPids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap.html#cfn-medialive-multiplexprogram-multiplexprogrampacketidentifiersmap-audiopids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> AudioPids { get; set; }
        }

        public class MultiplexProgramPipelineDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ActiveChannelPipeline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampipelinedetail.html#cfn-medialive-multiplexprogram-multiplexprogrampipelinedetail-activechannelpipeline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActiveChannelPipeline { get; set; }
            /// <summary>
            /// PipelineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogrampipelinedetail.html#cfn-medialive-multiplexprogram-multiplexprogrampipelinedetail-pipelineid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PipelineId { get; set; }
        }

        public class MultiplexProgramServiceDescriptor : Humidifier.Base.BaseSubResource, IHaveServiceName, IHaveProviderName
        {
            /// <summary>
            /// ProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramservicedescriptor.html#cfn-medialive-multiplexprogram-multiplexprogramservicedescriptor-providername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderName { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramservicedescriptor.html#cfn-medialive-multiplexprogram-multiplexprogramservicedescriptor-servicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
        }

        public class MultiplexProgramSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PreferredChannelPipeline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-preferredchannelpipeline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreferredChannelPipeline { get; set; }
            /// <summary>
            /// ServiceDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-servicedescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexProgramServiceDescriptor
            /// </summary>
            public Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor ServiceDescriptor { get; set; }
            /// <summary>
            /// VideoSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-videosettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexVideoSettings
            /// </summary>
            public Humidifier.MediaLive.MultiplexprogramTypes.MultiplexVideoSettings VideoSettings { get; set; }
            /// <summary>
            /// ProgramNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexprogramsettings.html#cfn-medialive-multiplexprogram-multiplexprogramsettings-programnumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramNumber { get; set; }
        }

        public class MultiplexStatmuxVideoSettings : Humidifier.Base.BaseSubResource, IHavePriority
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexstatmuxvideosettings.html#cfn-medialive-multiplexprogram-multiplexstatmuxvideosettings-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexstatmuxvideosettings.html#cfn-medialive-multiplexprogram-multiplexstatmuxvideosettings-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumBitrate { get; set; }
            /// <summary>
            /// MinimumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexstatmuxvideosettings.html#cfn-medialive-multiplexprogram-multiplexstatmuxvideosettings-minimumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumBitrate { get; set; }
        }

        public class MultiplexVideoSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StatmuxSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexvideosettings.html#cfn-medialive-multiplexprogram-multiplexvideosettings-statmuxsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexStatmuxVideoSettings
            /// </summary>
            public Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings StatmuxSettings { get; set; }
            /// <summary>
            /// ConstantBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplexprogram-multiplexvideosettings.html#cfn-medialive-multiplexprogram-multiplexvideosettings-constantbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConstantBitrate { get; set; }
        }
    }
}