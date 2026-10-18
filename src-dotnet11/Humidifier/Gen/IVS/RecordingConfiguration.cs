namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using RecordingConfigurationTypes;

    public class RecordingConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIVSRecordingConfigurationTypesDestinationConfigurationDestinationConfiguration, IHaveIVSRecordingConfigurationTypesRenditionConfigurationRenditionConfiguration, IHaveRecordingReconnectWindowSeconds_Integer, IHaveIVSRecordingConfigurationTypesThumbnailConfigurationThumbnailConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.RecordingConfiguration; }

        /// <summary>
        /// DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-recordingconfiguration.html#cfn-ivs-recordingconfiguration-destinationconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DestinationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IVS.RecordingConfigurationTypes.DestinationConfiguration, BaseFunction>? DestinationConfiguration { get; set; }
        /// <summary>
        /// RenditionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-recordingconfiguration.html#cfn-ivs-recordingconfiguration-renditionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RenditionConfiguration
        /// </summary>
        public Union<Humidifier.IVS.RecordingConfigurationTypes.RenditionConfiguration, BaseFunction>? RenditionConfiguration { get; set; }
        /// <summary>
        /// RecordingReconnectWindowSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-recordingconfiguration.html#cfn-ivs-recordingconfiguration-recordingreconnectwindowseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RecordingReconnectWindowSeconds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-recordingconfiguration.html#cfn-ivs-recordingconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ThumbnailConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-recordingconfiguration.html#cfn-ivs-recordingconfiguration-thumbnailconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ThumbnailConfiguration
        /// </summary>
        public Union<Humidifier.IVS.RecordingConfigurationTypes.ThumbnailConfiguration, BaseFunction>? ThumbnailConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RecordingConfigurationTypes
    {
        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveIVSRecordingConfigurationTypesS3DestinationConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-destinationconfiguration.html#cfn-ivs-recordingconfiguration-destinationconfiguration-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Union<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration, BaseFunction>? S3 { get; set; }
        }

        public class RenditionConfiguration : Humidifier.Base.BaseSubResource, IHaveRenditionSelection, IHaveStringListOfRenditions
        {
            /// <summary>
            /// RenditionSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-renditionconfiguration.html#cfn-ivs-recordingconfiguration-renditionconfiguration-renditionselection
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RenditionSelection { get; set; }
            /// <summary>
            /// Renditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-renditionconfiguration.html#cfn-ivs-recordingconfiguration-renditionconfiguration-renditions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Renditions { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-s3destinationconfiguration.html#cfn-ivs-recordingconfiguration-s3destinationconfiguration-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class ThumbnailConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetIntervalSeconds_Integer, IHaveStringListOfStorage, IHaveRecordingMode, IHaveResolution
        {
            /// <summary>
            /// TargetIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-thumbnailconfiguration.html#cfn-ivs-recordingconfiguration-thumbnailconfiguration-targetintervalseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetIntervalSeconds { get; set; }
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-thumbnailconfiguration.html#cfn-ivs-recordingconfiguration-thumbnailconfiguration-storage
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Storage { get; set; }
            /// <summary>
            /// RecordingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-thumbnailconfiguration.html#cfn-ivs-recordingconfiguration-thumbnailconfiguration-recordingmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordingMode { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-thumbnailconfiguration.html#cfn-ivs-recordingconfiguration-thumbnailconfiguration-resolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resolution { get; set; }
        }
    }
}