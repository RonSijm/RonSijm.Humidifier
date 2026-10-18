namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using StageTypes;

    public class Stage : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIVSStageTypesAutoParticipantRecordingConfigurationAutoParticipantRecordingConfiguration, IHaveName
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
        public Union<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration, BaseFunction>? AutoParticipantRecordingConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-stage.html#cfn-ivs-stage-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace StageTypes
    {
        public class AutoParticipantRecordingConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageConfigurationArn, IHaveRecordingReconnectWindowSeconds_Integer, IHaveStringListOfMediaTypes, IHaveIVSStageTypesHlsConfigurationHlsConfiguration, IHaveIVSStageTypesThumbnailConfigurationThumbnailConfiguration
        {
            /// <summary>
            /// StorageConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-storageconfigurationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageConfigurationArn { get; set; }
            /// <summary>
            /// RecordingReconnectWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-recordingreconnectwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecordingReconnectWindowSeconds { get; set; }
            /// <summary>
            /// MediaTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-mediatypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MediaTypes { get; set; }
            /// <summary>
            /// HlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-hlsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsConfiguration
            /// </summary>
            public Union<Humidifier.IVS.StageTypes.HlsConfiguration, BaseFunction>? HlsConfiguration { get; set; }
            /// <summary>
            /// ThumbnailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-autoparticipantrecordingconfiguration.html#cfn-ivs-stage-autoparticipantrecordingconfiguration-thumbnailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThumbnailConfiguration
            /// </summary>
            public Union<Humidifier.IVS.StageTypes.ThumbnailConfiguration, BaseFunction>? ThumbnailConfiguration { get; set; }
        }

        public class HlsConfiguration : Humidifier.Base.BaseSubResource, IHaveIVSStageTypesParticipantRecordingHlsConfigurationParticipantRecordingHlsConfiguration
        {
            /// <summary>
            /// ParticipantRecordingHlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-hlsconfiguration.html#cfn-ivs-stage-hlsconfiguration-participantrecordinghlsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParticipantRecordingHlsConfiguration
            /// </summary>
            public Union<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration, BaseFunction>? ParticipantRecordingHlsConfiguration { get; set; }
        }

        public class ParticipantRecordingHlsConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetSegmentDurationSeconds_Integer
        {
            /// <summary>
            /// TargetSegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantrecordinghlsconfiguration.html#cfn-ivs-stage-participantrecordinghlsconfiguration-targetsegmentdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetSegmentDurationSeconds { get; set; }
        }

        public class ParticipantThumbnailConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetIntervalSeconds_Integer, IHaveStringListOfStorage, IHaveRecordingMode
        {
            /// <summary>
            /// TargetIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantthumbnailconfiguration.html#cfn-ivs-stage-participantthumbnailconfiguration-targetintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetIntervalSeconds { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantthumbnailconfiguration.html#cfn-ivs-stage-participantthumbnailconfiguration-storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Storage { get; set; }
            /// <summary>
            /// RecordingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-participantthumbnailconfiguration.html#cfn-ivs-stage-participantthumbnailconfiguration-recordingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordingMode { get; set; }
        }

        public class ThumbnailConfiguration : Humidifier.Base.BaseSubResource, IHaveIVSStageTypesParticipantThumbnailConfigurationParticipantThumbnailConfiguration
        {
            /// <summary>
            /// ParticipantThumbnailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-stage-thumbnailconfiguration.html#cfn-ivs-stage-thumbnailconfiguration-participantthumbnailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParticipantThumbnailConfiguration
            /// </summary>
            public Union<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration, BaseFunction>? ParticipantThumbnailConfiguration { get; set; }
        }
    }
}