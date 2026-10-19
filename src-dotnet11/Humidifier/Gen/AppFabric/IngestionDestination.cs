namespace Humidifier.AppFabric
{
    using global::System.Collections.Generic;
    using IngestionDestinationTypes;

    public class IngestionDestination : Humidifier.Base.BaseResource, IHaveTags, IHaveAppBundleArn, IHaveAppFabricIngestionDestinationTypesDestinationConfigurationDestinationConfiguration, IHaveIngestionArn, IHaveAppFabricIngestionDestinationTypesProcessingConfigurationProcessingConfiguration
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
        public Union<string, BaseFunction>? AppBundleArn { get; set; }

        /// <summary>
        /// DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-destinationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DestinationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration, BaseFunction>? DestinationConfiguration { get; set; }

        /// <summary>
        /// IngestionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-ingestionarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IngestionArn { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-processingconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ProcessingConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration, BaseFunction>? ProcessingConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appfabric-ingestiondestination.html#cfn-appfabric-ingestiondestination-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IngestionDestinationTypes
    {
        public class AuditLogDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveAppFabricIngestionDestinationTypesDestinationDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-auditlogdestinationconfiguration.html#cfn-appfabric-ingestiondestination-auditlogdestinationconfiguration-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Union<Humidifier.AppFabric.IngestionDestinationTypes.Destination, BaseFunction>? Destination { get; set; }
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
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-auditlogprocessingconfiguration.html#cfn-appfabric-ingestiondestination-auditlogprocessingconfiguration-schema
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Schema { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource, IHaveAppFabricIngestionDestinationTypesS3BucketS3Bucket, IHaveAppFabricIngestionDestinationTypesFirehoseStreamFirehoseStream
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-destination.html#cfn-appfabric-ingestiondestination-destination-s3bucket
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Bucket
            /// </summary>
            public Union<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// FirehoseStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-destination.html#cfn-appfabric-ingestiondestination-destination-firehosestream
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseStream
            /// </summary>
            public Union<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream, BaseFunction>? FirehoseStream { get; set; }
        }

        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveAppFabricIngestionDestinationTypesAuditLogDestinationConfigurationAuditLog
        {
            /// <summary>
            /// AuditLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-destinationconfiguration.html#cfn-appfabric-ingestiondestination-destinationconfiguration-auditlog
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuditLogDestinationConfiguration
            /// </summary>
            public Union<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration, BaseFunction>? AuditLog { get; set; }
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
            public Union<string, BaseFunction>? StreamName { get; set; }
        }

        public class ProcessingConfiguration : Humidifier.Base.BaseSubResource, IHaveAppFabricIngestionDestinationTypesAuditLogProcessingConfigurationAuditLog
        {
            /// <summary>
            /// AuditLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-processingconfiguration.html#cfn-appfabric-ingestiondestination-processingconfiguration-auditlog
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AuditLogProcessingConfiguration
            /// </summary>
            public Union<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration, BaseFunction>? AuditLog { get; set; }
        }

        public class S3Bucket : Humidifier.Base.BaseSubResource, IHaveBucketName, IHavePrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-s3bucket.html#cfn-appfabric-ingestiondestination-s3bucket-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appfabric-ingestiondestination-s3bucket.html#cfn-appfabric-ingestiondestination-s3bucket-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }
    }
}