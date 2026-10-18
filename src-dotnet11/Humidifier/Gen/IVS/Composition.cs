namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using CompositionTypes;

    public class Composition : Humidifier.Base.BaseResource, IHaveTags, IHaveIVSCompositionTypesLayoutConfigurationLayout, IHaveListOfIVSCompositionTypesDestinationConfigurationDestinations, IHaveStageArn
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string StartTime =  "StartTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.Composition; }
        /// <summary>
        /// Layout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-layout
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LayoutConfiguration
        /// </summary>
        public Union<Humidifier.IVS.CompositionTypes.LayoutConfiguration, BaseFunction>? Layout { get; set; }

        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-destinations
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DestinationConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.IVS.CompositionTypes.DestinationConfiguration>, IReadOnlyList<Union<Humidifier.IVS.CompositionTypes.DestinationConfiguration, BaseFunction>>, BaseFunction>? Destinations { get; set; }

        /// <summary>
        /// StageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-stagearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StageArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CompositionTypes
    {
        public class ChannelDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveChannelArn, IHaveEncoderConfigurationArn
        {
            /// <summary>
            /// ChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-channeldestinationconfiguration.html#cfn-ivs-composition-channeldestinationconfiguration-channelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelArn { get; set; }
            /// <summary>
            /// EncoderConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-channeldestinationconfiguration.html#cfn-ivs-composition-channeldestinationconfiguration-encoderconfigurationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncoderConfigurationArn { get; set; }
        }

        public class CompositionRecordingHlsConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetSegmentDurationSeconds_Integer
        {
            /// <summary>
            /// TargetSegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-compositionrecordinghlsconfiguration.html#cfn-ivs-composition-compositionrecordinghlsconfiguration-targetsegmentdurationseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetSegmentDurationSeconds { get; set; }
        }

        public class CompositionThumbnailConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetIntervalSeconds_Integer, IHaveStringListOfStorage
        {
            /// <summary>
            /// TargetIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-compositionthumbnailconfiguration.html#cfn-ivs-composition-compositionthumbnailconfiguration-targetintervalseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetIntervalSeconds { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-compositionthumbnailconfiguration.html#cfn-ivs-composition-compositionthumbnailconfiguration-storage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Storage { get; set; }
        }

        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveIVSCompositionTypesS3DestinationConfigurationS3, IHaveIVSCompositionTypesChannelDestinationConfigurationChannel, IHaveName
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-destinationconfiguration.html#cfn-ivs-composition-destinationconfiguration-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Union<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-destinationconfiguration.html#cfn-ivs-composition-destinationconfiguration-channel
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ChannelDestinationConfiguration
            /// </summary>
            public Union<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration, BaseFunction>? Channel { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-destinationconfiguration.html#cfn-ivs-composition-destinationconfiguration-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GridConfiguration : Humidifier.Base.BaseSubResource, IHaveParticipantOrderAttribute, IHaveOmitStoppedVideo_Boolean, IHaveVideoAspectRatio, IHaveGridGap_Integer, IHaveFeaturedParticipantAttribute, IHaveVideoFillMode
        {
            /// <summary>
            /// ParticipantOrderAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-participantorderattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantOrderAttribute { get; set; }
            /// <summary>
            /// OmitStoppedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-omitstoppedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OmitStoppedVideo { get; set; }
            /// <summary>
            /// VideoAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-videoaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoAspectRatio { get; set; }
            /// <summary>
            /// GridGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-gridgap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GridGap { get; set; }
            /// <summary>
            /// FeaturedParticipantAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-featuredparticipantattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeaturedParticipantAttribute { get; set; }
            /// <summary>
            /// VideoFillMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-videofillmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoFillMode { get; set; }
        }

        public class LayoutConfiguration : Humidifier.Base.BaseSubResource, IHaveIVSCompositionTypesPipConfigurationPip, IHaveIVSCompositionTypesGridConfigurationGrid
        {
            /// <summary>
            /// Pip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-layoutconfiguration.html#cfn-ivs-composition-layoutconfiguration-pip
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PipConfiguration
            /// </summary>
            public Union<Humidifier.IVS.CompositionTypes.PipConfiguration, BaseFunction>? Pip { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-layoutconfiguration.html#cfn-ivs-composition-layoutconfiguration-grid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GridConfiguration
            /// </summary>
            public Union<Humidifier.IVS.CompositionTypes.GridConfiguration, BaseFunction>? Grid { get; set; }
        }

        public class PipConfiguration : Humidifier.Base.BaseSubResource, IHaveParticipantOrderAttribute, IHaveOmitStoppedVideo_Boolean, IHavePipParticipantAttribute, IHavePipPosition, IHaveGridGap_Integer, IHavePipBehavior, IHavePipWidth_Integer, IHaveFeaturedParticipantAttribute, IHavePipHeight_Integer, IHaveVideoFillMode, IHavePipOffset_Integer
        {
            /// <summary>
            /// ParticipantOrderAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-participantorderattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantOrderAttribute { get; set; }
            /// <summary>
            /// OmitStoppedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-omitstoppedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OmitStoppedVideo { get; set; }
            /// <summary>
            /// PipParticipantAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipparticipantattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipParticipantAttribute { get; set; }
            /// <summary>
            /// PipPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipPosition { get; set; }
            /// <summary>
            /// GridGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-gridgap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GridGap { get; set; }
            /// <summary>
            /// PipBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipbehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipBehavior { get; set; }
            /// <summary>
            /// PipWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipwidth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PipWidth { get; set; }
            /// <summary>
            /// FeaturedParticipantAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-featuredparticipantattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeaturedParticipantAttribute { get; set; }
            /// <summary>
            /// PipHeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipheight
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PipHeight { get; set; }
            /// <summary>
            /// VideoFillMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-videofillmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoFillMode { get; set; }
            /// <summary>
            /// PipOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PipOffset { get; set; }
        }

        public class RecordingConfiguration : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveIVSCompositionTypesCompositionRecordingHlsConfigurationHlsConfiguration
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-recordingconfiguration.html#cfn-ivs-composition-recordingconfiguration-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// HlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-recordingconfiguration.html#cfn-ivs-composition-recordingconfiguration-hlsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CompositionRecordingHlsConfiguration
            /// </summary>
            public Union<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration, BaseFunction>? HlsConfiguration { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageConfigurationArn, IHaveStringListOfEncoderConfigurationArns, IHaveIVSCompositionTypesRecordingConfigurationRecordingConfiguration, IHaveListOfIVSCompositionTypesCompositionThumbnailConfigurationThumbnailConfigurations
        {
            /// <summary>
            /// StorageConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-storageconfigurationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageConfigurationArn { get; set; }
            /// <summary>
            /// EncoderConfigurationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-encoderconfigurationarns
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EncoderConfigurationArns { get; set; }
            /// <summary>
            /// RecordingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-recordingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RecordingConfiguration
            /// </summary>
            public Union<Humidifier.IVS.CompositionTypes.RecordingConfiguration, BaseFunction>? RecordingConfiguration { get; set; }
            /// <summary>
            /// ThumbnailConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-thumbnailconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CompositionThumbnailConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IVS.CompositionTypes.CompositionThumbnailConfiguration>, IReadOnlyList<Union<Humidifier.IVS.CompositionTypes.CompositionThumbnailConfiguration, BaseFunction>>, BaseFunction>? ThumbnailConfigurations { get; set; }
        }
    }
}