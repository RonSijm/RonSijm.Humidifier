namespace Humidifier.KafkaConnect
{
    using global::System.Collections.Generic;
    using CustomPluginTypes;

    public class CustomPlugin : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveContentType, IHaveName, IHaveKafkaConnectCustomPluginTypesCustomPluginLocationLocation
    {
        public class Attributes
        {
            public static string CustomPluginArn =  "CustomPluginArn" ;
            public static string FileDescription =  "FileDescription" ;
            public static string Revision =  "Revision" ;
        }

        public override string AWSTypeName { get => AWS.KafkaConnect.CustomPlugin; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-customplugin.html#cfn-kafkaconnect-customplugin-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ContentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-customplugin.html#cfn-kafkaconnect-customplugin-contenttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContentType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-customplugin.html#cfn-kafkaconnect-customplugin-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-customplugin.html#cfn-kafkaconnect-customplugin-location
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CustomPluginLocation
        /// </summary>
        [Required]
        public Union<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation, BaseFunction>? Location { get; set; }
    }

    namespace CustomPluginTypes
    {
        public class CustomPluginFileDescription : Humidifier.Base.BaseSubResource, IHaveFileMd5, IHaveFileSize_Long
        {
            /// <summary>
            /// FileMd5
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-customplugin-custompluginfiledescription.html#cfn-kafkaconnect-customplugin-custompluginfiledescription-filemd5
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileMd5 { get; set; }
            /// <summary>
            /// FileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-customplugin-custompluginfiledescription.html#cfn-kafkaconnect-customplugin-custompluginfiledescription-filesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? FileSize { get; set; }
        }

        public class CustomPluginLocation : Humidifier.Base.BaseSubResource, IHaveKafkaConnectCustomPluginTypesS3LocationS3Location
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-customplugin-custompluginlocation.html#cfn-kafkaconnect-customplugin-custompluginlocation-s3location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.KafkaConnect.CustomPluginTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveFileKey, IHaveObjectVersion
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-customplugin-s3location.html#cfn-kafkaconnect-customplugin-s3location-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// FileKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-customplugin-s3location.html#cfn-kafkaconnect-customplugin-s3location-filekey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileKey { get; set; }
            /// <summary>
            /// ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-customplugin-s3location.html#cfn-kafkaconnect-customplugin-s3location-objectversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectVersion { get; set; }
        }
    }
}