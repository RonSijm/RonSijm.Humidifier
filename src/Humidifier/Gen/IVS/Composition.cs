namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using CompositionTypes;

    public class Composition : Humidifier.Base.BaseResource, IHaveTags
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
        public Humidifier.IVS.CompositionTypes.LayoutConfiguration Layout { get; set; }

        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-destinations
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DestinationConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.IVS.CompositionTypes.DestinationConfiguration> Destinations { get; set; }

        /// <summary>
        /// StageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-stagearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StageArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-composition.html#cfn-ivs-composition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CompositionTypes
    {
        public class ChannelDestinationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-channeldestinationconfiguration.html#cfn-ivs-composition-channeldestinationconfiguration-channelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelArn { get; set; }
            /// <summary>
            /// EncoderConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-channeldestinationconfiguration.html#cfn-ivs-composition-channeldestinationconfiguration-encoderconfigurationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncoderConfigurationArn { get; set; }
        }

        public class CompositionRecordingHlsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetSegmentDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-compositionrecordinghlsconfiguration.html#cfn-ivs-composition-compositionrecordinghlsconfiguration-targetsegmentdurationseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetSegmentDurationSeconds { get; set; }
        }

        public class CompositionThumbnailConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-compositionthumbnailconfiguration.html#cfn-ivs-composition-compositionthumbnailconfiguration-targetintervalseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetIntervalSeconds { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-compositionthumbnailconfiguration.html#cfn-ivs-composition-compositionthumbnailconfiguration-storage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Storage { get; set; }
        }

        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-destinationconfiguration.html#cfn-ivs-composition-destinationconfiguration-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Humidifier.IVS.CompositionTypes.S3DestinationConfiguration S3 { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-destinationconfiguration.html#cfn-ivs-composition-destinationconfiguration-channel
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ChannelDestinationConfiguration
            /// </summary>
            public Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration Channel { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-destinationconfiguration.html#cfn-ivs-composition-destinationconfiguration-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class GridConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParticipantOrderAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-participantorderattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParticipantOrderAttribute { get; set; }
            /// <summary>
            /// OmitStoppedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-omitstoppedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OmitStoppedVideo { get; set; }
            /// <summary>
            /// VideoAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-videoaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoAspectRatio { get; set; }
            /// <summary>
            /// GridGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-gridgap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GridGap { get; set; }
            /// <summary>
            /// FeaturedParticipantAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-featuredparticipantattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeaturedParticipantAttribute { get; set; }
            /// <summary>
            /// VideoFillMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-gridconfiguration.html#cfn-ivs-composition-gridconfiguration-videofillmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoFillMode { get; set; }
        }

        public class LayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Pip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-layoutconfiguration.html#cfn-ivs-composition-layoutconfiguration-pip
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PipConfiguration
            /// </summary>
            public Humidifier.IVS.CompositionTypes.PipConfiguration Pip { get; set; }
            /// <summary>
            /// Grid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-layoutconfiguration.html#cfn-ivs-composition-layoutconfiguration-grid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GridConfiguration
            /// </summary>
            public Humidifier.IVS.CompositionTypes.GridConfiguration Grid { get; set; }
        }

        public class PipConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParticipantOrderAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-participantorderattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParticipantOrderAttribute { get; set; }
            /// <summary>
            /// OmitStoppedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-omitstoppedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OmitStoppedVideo { get; set; }
            /// <summary>
            /// PipParticipantAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipparticipantattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PipParticipantAttribute { get; set; }
            /// <summary>
            /// PipPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PipPosition { get; set; }
            /// <summary>
            /// GridGap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-gridgap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GridGap { get; set; }
            /// <summary>
            /// PipBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipbehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PipBehavior { get; set; }
            /// <summary>
            /// PipWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipwidth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PipWidth { get; set; }
            /// <summary>
            /// FeaturedParticipantAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-featuredparticipantattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeaturedParticipantAttribute { get; set; }
            /// <summary>
            /// PipHeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipheight
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PipHeight { get; set; }
            /// <summary>
            /// VideoFillMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-videofillmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoFillMode { get; set; }
            /// <summary>
            /// PipOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-pipconfiguration.html#cfn-ivs-composition-pipconfiguration-pipoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PipOffset { get; set; }
        }

        public class RecordingConfiguration : Humidifier.Base.BaseSubResource, IHaveFormat
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-recordingconfiguration.html#cfn-ivs-composition-recordingconfiguration-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// HlsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-recordingconfiguration.html#cfn-ivs-composition-recordingconfiguration-hlsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CompositionRecordingHlsConfiguration
            /// </summary>
            public Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration HlsConfiguration { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StorageConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-storageconfigurationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageConfigurationArn { get; set; }
            /// <summary>
            /// EncoderConfigurationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-encoderconfigurationarns
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EncoderConfigurationArns { get; set; }
            /// <summary>
            /// RecordingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-recordingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RecordingConfiguration
            /// </summary>
            public Humidifier.IVS.CompositionTypes.RecordingConfiguration RecordingConfiguration { get; set; }
            /// <summary>
            /// ThumbnailConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-composition-s3destinationconfiguration.html#cfn-ivs-composition-s3destinationconfiguration-thumbnailconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CompositionThumbnailConfiguration
            /// </summary>
            public List<Humidifier.IVS.CompositionTypes.CompositionThumbnailConfiguration> ThumbnailConfigurations { get; set; }
        }
    }
}