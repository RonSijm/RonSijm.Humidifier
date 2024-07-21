namespace Humidifier.Rekognition
{
    using System.Collections.Generic;
    using StreamProcessorTypes;

    public class StreamProcessor : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Rekognition::StreamProcessor";
            }
        }

        /// <summary>
        /// S3Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-s3destination
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3Destination
        /// </summary>
        public S3Destination S3Destination { get; set; }
        /// <summary>
        /// DataSharingPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-datasharingpreference
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataSharingPreference
        /// </summary>
        public DataSharingPreference DataSharingPreference { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        /// <summary>
        /// FaceSearchSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-facesearchsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: FaceSearchSettings
        /// </summary>
        public FaceSearchSettings FaceSearchSettings { get; set; }
        /// <summary>
        /// PolygonRegionsOfInterest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-polygonregionsofinterest
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic PolygonRegionsOfInterest { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
        /// <summary>
        /// ConnectedHomeSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-connectedhomesettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectedHomeSettings
        /// </summary>
        public ConnectedHomeSettings ConnectedHomeSettings { get; set; }
        /// <summary>
        /// NotificationChannel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-notificationchannel
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NotificationChannel
        /// </summary>
        public NotificationChannel NotificationChannel { get; set; }
        /// <summary>
        /// KinesisVideoStream
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-kinesisvideostream
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KinesisVideoStream
        /// </summary>
        public KinesisVideoStream KinesisVideoStream { get; set; }
        /// <summary>
        /// BoundingBoxRegionsOfInterest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-boundingboxregionsofinterest
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: BoundingBox
        /// </summary>
        public List<BoundingBox> BoundingBoxRegionsOfInterest { get; set; }
        /// <summary>
        /// KinesisDataStream
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-kinesisdatastream
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KinesisDataStream
        /// </summary>
        public KinesisDataStream KinesisDataStream { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-streamprocessor.html#cfn-rekognition-streamprocessor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace StreamProcessorTypes
    {
        public class BoundingBox
        {
            /// <summary>
            /// Left
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-left
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Left { get; set; }
            /// <summary>
            /// Top
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-top
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Top { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-height
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-boundingbox.html#cfn-rekognition-streamprocessor-boundingbox-width
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class ConnectedHomeSettings
        {
            /// <summary>
            /// MinConfidence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-connectedhomesettings.html#cfn-rekognition-streamprocessor-connectedhomesettings-minconfidence
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinConfidence { get; set; }
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-connectedhomesettings.html#cfn-rekognition-streamprocessor-connectedhomesettings-labels
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Labels { get; set; }
        }

        public class DataSharingPreference
        {
            /// <summary>
            /// OptIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-datasharingpreference.html#cfn-rekognition-streamprocessor-datasharingpreference-optin
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OptIn { get; set; }
        }

        public class FaceSearchSettings
        {
            /// <summary>
            /// CollectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-facesearchsettings.html#cfn-rekognition-streamprocessor-facesearchsettings-collectionid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionId { get; set; }
            /// <summary>
            /// FaceMatchThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-facesearchsettings.html#cfn-rekognition-streamprocessor-facesearchsettings-facematchthreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic FaceMatchThreshold { get; set; }
        }

        public class KinesisDataStream
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-kinesisdatastream.html#cfn-rekognition-streamprocessor-kinesisdatastream-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class KinesisVideoStream
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-kinesisvideostream.html#cfn-rekognition-streamprocessor-kinesisvideostream-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class NotificationChannel
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-notificationchannel.html#cfn-rekognition-streamprocessor-notificationchannel-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class S3Destination
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-s3destination.html#cfn-rekognition-streamprocessor-s3destination-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-streamprocessor-s3destination.html#cfn-rekognition-streamprocessor-s3destination-objectkeyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKeyPrefix { get; set; }
        }
    }
}