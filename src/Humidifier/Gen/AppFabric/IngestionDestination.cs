namespace Humidifier.AppFabric
{
    using global::System.Collections.Generic;
    using IngestionDestinationTypes;

    public class IngestionDestination : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AppFabric.IngestionDestination; }

        /// <summary>
        /// AppBundleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-appbundlearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppBundleArn { get; set; }

        /// <summary>
        /// DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-destinationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DestinationConfiguration
        /// </summary>
        [Required]
        public Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// IngestionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-ingestionarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IngestionArn { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-processingconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ProcessingConfiguration
        /// </summary>
        [Required]
        public Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration ProcessingConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace IngestionDestinationTypes
    {
        public class AuditLogDestinationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-auditlogdestinationconfiguration.html#cfn-appfabric-ingestiondestination-auditlogdestinationconfiguration-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Humidifier.AppFabric.IngestionDestinationTypes.Destination Destination { get; set; }
        }

        public class AuditLogProcessingConfiguration : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveSchema
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-auditlogprocessingconfiguration.html#cfn-appfabric-ingestiondestination-auditlogprocessingconfiguration-format
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-auditlogprocessingconfiguration.html#cfn-appfabric-ingestiondestination-auditlogprocessingconfiguration-schema
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Schema { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-destination.html#cfn-appfabric-ingestiondestination-destination-s3bucket
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Bucket
            /// </summary>
            public Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket S3Bucket { get; set; }
            /// <summary>
            /// FirehoseStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-destination.html#cfn-appfabric-ingestiondestination-destination-firehosestream
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseStream
            /// </summary>
            public Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream FirehoseStream { get; set; }
        }

        public class DestinationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuditLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-destinationconfiguration.html#cfn-appfabric-ingestiondestination-destinationconfiguration-auditlog
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuditLogDestinationConfiguration
            /// </summary>
            public Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration AuditLog { get; set; }
        }

        public class FirehoseStream : Humidifier.Base.BaseSubResource, IHaveStreamName
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-firehosestream.html#cfn-appfabric-ingestiondestination-firehosestream-streamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
        }

        public class ProcessingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuditLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-processingconfiguration.html#cfn-appfabric-ingestiondestination-processingconfiguration-auditlog
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AuditLogProcessingConfiguration
            /// </summary>
            public Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration AuditLog { get; set; }
        }

        public class S3Bucket : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-s3bucket.html#cfn-appfabric-ingestiondestination-s3bucket-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-s3bucket.html#cfn-appfabric-ingestiondestination-s3bucket-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }
    }
}