namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using ProgramTypes;

    public class Program : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveVodSourceName, IHaveSourceLocationName, IHaveMediaTailorProgramTypesScheduleConfigurationScheduleConfiguration, IHaveChannelName, IHaveLiveSourceName, IHaveListOfMediaTailorProgramTypesAdBreakAdBreaks, IHaveListOfMediaTailorProgramTypesAudienceMediaAudienceMedia, IHaveProgramName
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string ClipRange =  "ClipRange" ;
            public static string ScheduledStartTime =  "ScheduledStartTime" ;
            public static string Arn =  "Arn" ;
            public static string DurationMillis =  "DurationMillis" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.Program; }
        /// <summary>
        /// VodSourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-vodsourcename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VodSourceName { get; set; }

        /// <summary>
        /// SourceLocationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-sourcelocationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceLocationName { get; set; }
        /// <summary>
        /// ScheduleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-scheduleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScheduleConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration, BaseFunction>? ScheduleConfiguration { get; set; }

        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelName { get; set; }
        /// <summary>
        /// LiveSourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-livesourcename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LiveSourceName { get; set; }
        /// <summary>
        /// AdBreaks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-adbreaks
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdBreak
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaTailor.ProgramTypes.AdBreak>, IReadOnlyList<Union<Humidifier.MediaTailor.ProgramTypes.AdBreak, BaseFunction>>, BaseFunction>? AdBreaks { get; set; }
        /// <summary>
        /// AudienceMedia
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-program.html#cfn-mediatailor-program-audiencemedia
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AudienceMedia
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaTailor.ProgramTypes.AudienceMedia>, IReadOnlyList<Union<Humidifier.MediaTailor.ProgramTypes.AudienceMedia, BaseFunction>>, BaseFunction>? AudienceMedia { get; set; }
        public Union<string, BaseFunction>? ProgramName { get => GivenName; set => GivenName = value; }
    }

    namespace ProgramTypes
    {
        public class AdBreak : Humidifier.Base.BaseSubResource, IHaveOffsetMillis_Integer, IHaveMediaTailorProgramTypesTimeSignalMessageTimeSignalMessage, IHaveMediaTailorProgramTypesSpliceInsertMessageSpliceInsertMessage, IHaveMediaTailorProgramTypesSlateSourceSlate, IHaveMessageType, IHaveListOfMediaTailorProgramTypesKeyValuePairAdBreakMetadata
        {
            /// <summary>
            /// OffsetMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-adbreak.html#cfn-mediatailor-program-adbreak-offsetmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OffsetMillis { get; set; }
            /// <summary>
            /// TimeSignalMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-adbreak.html#cfn-mediatailor-program-adbreak-timesignalmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeSignalMessage
            /// </summary>
            public Union<Humidifier.MediaTailor.ProgramTypes.TimeSignalMessage, BaseFunction>? TimeSignalMessage { get; set; }
            /// <summary>
            /// SpliceInsertMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-adbreak.html#cfn-mediatailor-program-adbreak-spliceinsertmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpliceInsertMessage
            /// </summary>
            public Union<Humidifier.MediaTailor.ProgramTypes.SpliceInsertMessage, BaseFunction>? SpliceInsertMessage { get; set; }
            /// <summary>
            /// Slate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-adbreak.html#cfn-mediatailor-program-adbreak-slate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlateSource
            /// </summary>
            public Union<Humidifier.MediaTailor.ProgramTypes.SlateSource, BaseFunction>? Slate { get; set; }
            /// <summary>
            /// MessageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-adbreak.html#cfn-mediatailor-program-adbreak-messagetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageType { get; set; }
            /// <summary>
            /// AdBreakMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-adbreak.html#cfn-mediatailor-program-adbreak-adbreakmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.ProgramTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.MediaTailor.ProgramTypes.KeyValuePair, BaseFunction>>, BaseFunction>? AdBreakMetadata { get; set; }
        }

        public class AlternateMedia : Humidifier.Base.BaseSubResource, IHaveVodSourceName, IHaveSourceLocationName, IHaveLiveSourceName, IHaveListOfMediaTailorProgramTypesAdBreakAdBreaks, IHaveScheduledStartTimeMillis_Integer, IHaveMediaTailorProgramTypesClipRangeClipRange, IHaveDurationMillis_Integer
        {
            /// <summary>
            /// VodSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-vodsourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VodSourceName { get; set; }
            /// <summary>
            /// SourceLocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-sourcelocationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceLocationName { get; set; }
            /// <summary>
            /// LiveSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-livesourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LiveSourceName { get; set; }
            /// <summary>
            /// AdBreaks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-adbreaks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdBreak
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.ProgramTypes.AdBreak>, IReadOnlyList<Union<Humidifier.MediaTailor.ProgramTypes.AdBreak, BaseFunction>>, BaseFunction>? AdBreaks { get; set; }
            /// <summary>
            /// ScheduledStartTimeMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-scheduledstarttimemillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScheduledStartTimeMillis { get; set; }
            /// <summary>
            /// ClipRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-cliprange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClipRange
            /// </summary>
            public Union<Humidifier.MediaTailor.ProgramTypes.ClipRange, BaseFunction>? ClipRange { get; set; }
            /// <summary>
            /// DurationMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-alternatemedia.html#cfn-mediatailor-program-alternatemedia-durationmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationMillis { get; set; }
        }

        public class AudienceMedia : Humidifier.Base.BaseSubResource, IHaveAudience, IHaveListOfMediaTailorProgramTypesAlternateMediaAlternateMedia
        {
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-audiencemedia.html#cfn-mediatailor-program-audiencemedia-audience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Audience { get; set; }
            /// <summary>
            /// AlternateMedia
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-audiencemedia.html#cfn-mediatailor-program-audiencemedia-alternatemedia
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlternateMedia
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.ProgramTypes.AlternateMedia>, IReadOnlyList<Union<Humidifier.MediaTailor.ProgramTypes.AlternateMedia, BaseFunction>>, BaseFunction>? AlternateMedia { get; set; }
        }

        public class ClipRange : Humidifier.Base.BaseSubResource, IHaveEndOffsetMillis_Integer, IHaveStartOffsetMillis_Integer
        {
            /// <summary>
            /// EndOffsetMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-cliprange.html#cfn-mediatailor-program-cliprange-endoffsetmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndOffsetMillis { get; set; }
            /// <summary>
            /// StartOffsetMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-cliprange.html#cfn-mediatailor-program-cliprange-startoffsetmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartOffsetMillis { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-keyvaluepair.html#cfn-mediatailor-program-keyvaluepair-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-keyvaluepair.html#cfn-mediatailor-program-keyvaluepair-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaTailorProgramTypesTransitionTransition, IHaveMediaTailorProgramTypesClipRangeClipRange
        {
            /// <summary>
            /// Transition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-scheduleconfiguration.html#cfn-mediatailor-program-scheduleconfiguration-transition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Transition
            /// </summary>
            public Union<Humidifier.MediaTailor.ProgramTypes.Transition, BaseFunction>? Transition { get; set; }
            /// <summary>
            /// ClipRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-scheduleconfiguration.html#cfn-mediatailor-program-scheduleconfiguration-cliprange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClipRange
            /// </summary>
            public Union<Humidifier.MediaTailor.ProgramTypes.ClipRange, BaseFunction>? ClipRange { get; set; }
        }

        public class SegmentationDescriptor : Humidifier.Base.BaseSubResource, IHaveSegmentationUpid, IHaveSegmentsExpected_Integer, IHaveSubSegmentsExpected_Integer, IHaveSegmentationEventId_Integer, IHaveSubSegmentNum_Integer, IHaveSegmentationTypeId_Integer, IHaveSegmentationUpidType_Integer, IHaveSegmentNum_Integer
        {
            /// <summary>
            /// SegmentationUpid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-segmentationupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentationUpid { get; set; }
            /// <summary>
            /// SegmentsExpected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-segmentsexpected
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentsExpected { get; set; }
            /// <summary>
            /// SubSegmentsExpected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-subsegmentsexpected
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SubSegmentsExpected { get; set; }
            /// <summary>
            /// SegmentationEventId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-segmentationeventid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentationEventId { get; set; }
            /// <summary>
            /// SubSegmentNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-subsegmentnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SubSegmentNum { get; set; }
            /// <summary>
            /// SegmentationTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-segmentationtypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentationTypeId { get; set; }
            /// <summary>
            /// SegmentationUpidType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-segmentationupidtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentationUpidType { get; set; }
            /// <summary>
            /// SegmentNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-segmentationdescriptor.html#cfn-mediatailor-program-segmentationdescriptor-segmentnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SegmentNum { get; set; }
        }

        public class SlateSource : Humidifier.Base.BaseSubResource, IHaveVodSourceName, IHaveSourceLocationName
        {
            /// <summary>
            /// VodSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-slatesource.html#cfn-mediatailor-program-slatesource-vodsourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VodSourceName { get; set; }
            /// <summary>
            /// SourceLocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-slatesource.html#cfn-mediatailor-program-slatesource-sourcelocationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceLocationName { get; set; }
        }

        public class SpliceInsertMessage : Humidifier.Base.BaseSubResource, IHaveSpliceEventId_Integer, IHaveAvailsExpected_Integer, IHaveAvailNum_Integer, IHaveUniqueProgramId_Integer
        {
            /// <summary>
            /// SpliceEventId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-spliceinsertmessage.html#cfn-mediatailor-program-spliceinsertmessage-spliceeventid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpliceEventId { get; set; }
            /// <summary>
            /// AvailsExpected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-spliceinsertmessage.html#cfn-mediatailor-program-spliceinsertmessage-availsexpected
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AvailsExpected { get; set; }
            /// <summary>
            /// AvailNum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-spliceinsertmessage.html#cfn-mediatailor-program-spliceinsertmessage-availnum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AvailNum { get; set; }
            /// <summary>
            /// UniqueProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-spliceinsertmessage.html#cfn-mediatailor-program-spliceinsertmessage-uniqueprogramid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UniqueProgramId { get; set; }
        }

        public class TimeSignalMessage : Humidifier.Base.BaseSubResource, IHaveListOfMediaTailorProgramTypesSegmentationDescriptorSegmentationDescriptors
        {
            /// <summary>
            /// SegmentationDescriptors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-timesignalmessage.html#cfn-mediatailor-program-timesignalmessage-segmentationdescriptors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SegmentationDescriptor
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.ProgramTypes.SegmentationDescriptor>, IReadOnlyList<Union<Humidifier.MediaTailor.ProgramTypes.SegmentationDescriptor, BaseFunction>>, BaseFunction>? SegmentationDescriptors { get; set; }
        }

        public class Transition : Humidifier.Base.BaseSubResource, IHaveRelativeProgram, IHaveType, IHaveRelativePosition, IHaveScheduledStartTimeMillis_Integer, IHaveDurationMillis_Integer
        {
            /// <summary>
            /// RelativeProgram
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-transition.html#cfn-mediatailor-program-transition-relativeprogram
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelativeProgram { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-transition.html#cfn-mediatailor-program-transition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RelativePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-transition.html#cfn-mediatailor-program-transition-relativeposition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelativePosition { get; set; }
            /// <summary>
            /// ScheduledStartTimeMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-transition.html#cfn-mediatailor-program-transition-scheduledstarttimemillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScheduledStartTimeMillis { get; set; }
            /// <summary>
            /// DurationMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-program-transition.html#cfn-mediatailor-program-transition-durationmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationMillis { get; set; }
        }
    }
}