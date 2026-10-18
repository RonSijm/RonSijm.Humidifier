namespace Humidifier.Rekognition
{
    using global::System.Collections.Generic;
    using StreamProcessorTypes;

    public class StreamProcessor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRekognitionStreamProcessorTypesS3DestinationS3Destination, IHaveRekognitionStreamProcessorTypesDataSharingPreferenceDataSharingPreference, IHaveKmsKeyId, IHaveRekognitionStreamProcessorTypesFaceSearchSettingsFaceSearchSettings, IHavePolygonRegionsOfInterest_Json, IHaveRoleArn, IHaveName, IHaveRekognitionStreamProcessorTypesConnectedHomeSettingsConnectedHomeSettings, IHaveRekognitionStreamProcessorTypesNotificationChannelNotificationChannel, IHaveRekognitionStreamProcessorTypesKinesisVideoStreamKinesisVideoStream, IHaveListOfRekognitionStreamProcessorTypesBoundingBoxBoundingBoxRegionsOfInterest, IHaveRekognitionStreamProcessorTypesKinesisDataStreamKinesisDataStream
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Rekognition.StreamProcessor; }
        /// <summary>
        /// S3Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-s3destination
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3Destination
        /// </summary>
        public Union<Humidifier.Rekognition.StreamProcessorTypes.S3Destination, BaseFunction>? S3Destination { get; set; }
        /// <summary>
        /// DataSharingPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-datasharingpreference
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataSharingPreference
        /// </summary>
        public Union<Humidifier.Rekognition.StreamProcessorTypes.DataSharingPreference, BaseFunction>? DataSharingPreference { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// FaceSearchSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-facesearchsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: FaceSearchSettings
        /// </summary>
        public Union<Humidifier.Rekognition.StreamProcessorTypes.FaceSearchSettings, BaseFunction>? FaceSearchSettings { get; set; }
        /// <summary>
        /// PolygonRegionsOfInterest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-polygonregionsofinterest
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? PolygonRegionsOfInterest { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ConnectedHomeSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-connectedhomesettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectedHomeSettings
        /// </summary>
        public Union<Humidifier.Rekognition.StreamProcessorTypes.ConnectedHomeSettings, BaseFunction>? ConnectedHomeSettings { get; set; }
        /// <summary>
        /// NotificationChannel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-notificationchannel
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NotificationChannel
        /// </summary>
        public Union<Humidifier.Rekognition.StreamProcessorTypes.NotificationChannel, BaseFunction>? NotificationChannel { get; set; }

        /// <summary>
        /// KinesisVideoStream
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-kinesisvideostream
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KinesisVideoStream
        /// </summary>
        [Required]
        public Union<Humidifier.Rekognition.StreamProcessorTypes.KinesisVideoStream, BaseFunction>? KinesisVideoStream { get; set; }
        /// <summary>
        /// BoundingBoxRegionsOfInterest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-boundingboxregionsofinterest
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: BoundingBox
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Rekognition.StreamProcessorTypes.BoundingBox>, IReadOnlyList<Union<Humidifier.Rekognition.StreamProcessorTypes.BoundingBox, BaseFunction>>, BaseFunction>? BoundingBoxRegionsOfInterest { get; set; }
        /// <summary>
        /// KinesisDataStream
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-kinesisdatastream
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KinesisDataStream
        /// </summary>
        public Union<Humidifier.Rekognition.StreamProcessorTypes.KinesisDataStream, BaseFunction>? KinesisDataStream { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace StreamProcessorTypes
    {
        public class BoundingBox : Humidifier.Base.BaseSubResource, IHaveLeft_Double, IHaveTop_Double, IHaveHeight_Double, IHaveWidth_Double
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-left
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-top
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Top { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-height
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-width
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Width { get; set; }
        }

        public class ConnectedHomeSettings : Humidifier.Base.BaseSubResource, IHaveMinConfidence_Double, IHaveStringListOfLabels
        {
            /// <summary>
            /// MinConfidence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-connectedhomesettings.html#cfn-rekognition-streamprocessor-connectedhomesettings-minconfidence
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinConfidence { get; set; }
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-connectedhomesettings.html#cfn-rekognition-streamprocessor-connectedhomesettings-labels
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Labels { get; set; }
        }

        public class DataSharingPreference : Humidifier.Base.BaseSubResource, IHaveOptIn_Boolean
        {
            /// <summary>
            /// OptIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-datasharingpreference.html#cfn-rekognition-streamprocessor-datasharingpreference-optin
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OptIn { get; set; }
        }

        public class FaceSearchSettings : Humidifier.Base.BaseSubResource, IHaveCollectionId, IHaveFaceMatchThreshold_Double
        {
            /// <summary>
            /// CollectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-facesearchsettings.html#cfn-rekognition-streamprocessor-facesearchsettings-collectionid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionId { get; set; }
            /// <summary>
            /// FaceMatchThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-facesearchsettings.html#cfn-rekognition-streamprocessor-facesearchsettings-facematchthreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FaceMatchThreshold { get; set; }
        }

        public class KinesisDataStream : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-kinesisdatastream.html#cfn-rekognition-streamprocessor-kinesisdatastream-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class KinesisVideoStream : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-kinesisvideostream.html#cfn-rekognition-streamprocessor-kinesisvideostream-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class NotificationChannel : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-notificationchannel.html#cfn-rekognition-streamprocessor-notificationchannel-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveObjectKeyPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-s3destination.html#cfn-rekognition-streamprocessor-s3destination-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-s3destination.html#cfn-rekognition-streamprocessor-s3destination-objectkeyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectKeyPrefix { get; set; }
        }
    }
}