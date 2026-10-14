namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using StageTypes;

    public class Stage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string ActiveSessionId =  "ActiveSessionId" ;
        }

        public override string AWSTypeName { get => AWS.IVS.Stage; }
        /// <summary>
        /// AutoParticipantRecordingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-stage.html#cfn-ivs-stage-autoparticipantrecordingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoParticipantRecordingConfiguration
        /// </summary>
        public Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration AutoParticipantRecordingConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-stage.html#cfn-ivs-stage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace StageTypes
    {
        public class AutoParticipantRecordingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StorageConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-storageconfigurationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageConfigurationArn { get; set; }
            /// <summary>
            /// RecordingReconnectWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-recordingreconnectwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RecordingReconnectWindowSeconds { get; set; }
            /// <summary>
            /// MediaTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-mediatypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MediaTypes { get; set; }
            /// <summary>
            /// HlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-hlsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsConfiguration
            /// </summary>
            public Humidifier.IVS.StageTypes.HlsConfiguration HlsConfiguration { get; set; }
            /// <summary>
            /// ThumbnailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-thumbnailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThumbnailConfiguration
            /// </summary>
            public Humidifier.IVS.StageTypes.ThumbnailConfiguration ThumbnailConfiguration { get; set; }
        }

        public class HlsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParticipantRecordingHlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-hlsconfiguration.html#cfn-ivs-stage-hlsconfiguration-participantrecordinghlsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParticipantRecordingHlsConfiguration
            /// </summary>
            public Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration ParticipantRecordingHlsConfiguration { get; set; }
        }

        public class ParticipantRecordingHlsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetSegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantrecordinghlsconfiguration.html#cfn-ivs-stage-participantrecordinghlsconfiguration-targetsegmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetSegmentDurationSeconds { get; set; }
        }

        public class ParticipantThumbnailConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantthumbnailconfiguration.html#cfn-ivs-stage-participantthumbnailconfiguration-targetintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetIntervalSeconds { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantthumbnailconfiguration.html#cfn-ivs-stage-participantthumbnailconfiguration-storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Storage { get; set; }
            /// <summary>
            /// RecordingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantthumbnailconfiguration.html#cfn-ivs-stage-participantthumbnailconfiguration-recordingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordingMode { get; set; }
        }

        public class ThumbnailConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParticipantThumbnailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-thumbnailconfiguration.html#cfn-ivs-stage-thumbnailconfiguration-participantthumbnailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParticipantThumbnailConfiguration
            /// </summary>
            public Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration ParticipantThumbnailConfiguration { get; set; }
        }
    }
}