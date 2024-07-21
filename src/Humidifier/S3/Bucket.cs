namespace Humidifier.S3
{
    using System.Collections.Generic;
    using BucketTypes;

    public class Bucket : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string RegionalDomainName =  "RegionalDomainName" ;
            public static string DomainName =  "DomainName" ;
            public static string WebsiteURL =  "WebsiteURL" ;
            public static string DualStackDomainName =  "DualStackDomainName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::S3::Bucket";
            }
        }

        /// <summary>
        /// InventoryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-inventoryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InventoryConfiguration
        /// </summary>
        public List<InventoryConfiguration> InventoryConfigurations { get; set; }
        /// <summary>
        /// BucketEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-bucketencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BucketEncryption
        /// </summary>
        public BucketEncryption BucketEncryption { get; set; }
        /// <summary>
        /// WebsiteConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-websiteconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebsiteConfiguration
        /// </summary>
        public WebsiteConfiguration WebsiteConfiguration { get; set; }
        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-notificationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        public NotificationConfiguration NotificationConfiguration { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public LifecycleConfiguration LifecycleConfiguration { get; set; }
        /// <summary>
        /// VersioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-versioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersioningConfiguration
        /// </summary>
        public VersioningConfiguration VersioningConfiguration { get; set; }
        /// <summary>
        /// MetricsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-metricsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricsConfiguration
        /// </summary>
        public List<MetricsConfiguration> MetricsConfigurations { get; set; }
        /// <summary>
        /// AccessControl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-accesscontrol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessControl { get; set; }
        /// <summary>
        /// IntelligentTieringConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-intelligenttieringconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IntelligentTieringConfiguration
        /// </summary>
        public List<IntelligentTieringConfiguration> IntelligentTieringConfigurations { get; set; }
        /// <summary>
        /// AnalyticsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-analyticsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AnalyticsConfiguration
        /// </summary>
        public List<AnalyticsConfiguration> AnalyticsConfigurations { get; set; }
        /// <summary>
        /// AccelerateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-accelerateconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccelerateConfiguration
        /// </summary>
        public AccelerateConfiguration AccelerateConfiguration { get; set; }
        /// <summary>
        /// PublicAccessBlockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-publicaccessblockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PublicAccessBlockConfiguration
        /// </summary>
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration { get; set; }
        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-bucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketName { get; set; }
        /// <summary>
        /// CorsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-corsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CorsConfiguration
        /// </summary>
        public CorsConfiguration CorsConfiguration { get; set; }
        /// <summary>
        /// OwnershipControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-ownershipcontrols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OwnershipControls
        /// </summary>
        public OwnershipControls OwnershipControls { get; set; }
        /// <summary>
        /// ObjectLockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-objectlockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ObjectLockConfiguration
        /// </summary>
        public ObjectLockConfiguration ObjectLockConfiguration { get; set; }
        /// <summary>
        /// ObjectLockEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-objectlockenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ObjectLockEnabled { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }
        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public ReplicationConfiguration ReplicationConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace BucketTypes
    {
        public class AbortIncompleteMultipartUpload
        {
            /// <summary>
            /// DaysAfterInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-abortincompletemultipartupload.html#cfn-s3-bucket-abortincompletemultipartupload-daysafterinitiation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysAfterInitiation { get; set; }
        }

        public class AccelerateConfiguration
        {
            /// <summary>
            /// AccelerationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accelerateconfiguration.html#cfn-s3-bucket-accelerateconfiguration-accelerationstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccelerationStatus { get; set; }
        }

        public class AccessControlTranslation
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accesscontroltranslation.html#cfn-s3-bucket-accesscontroltranslation-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Owner { get; set; }
        }

        public class AnalyticsConfiguration
        {
            /// <summary>
            /// StorageClassAnalysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-storageclassanalysis
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StorageClassAnalysis
            /// </summary>
            public StorageClassAnalysis StorageClassAnalysis { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class BucketEncryption
        {
            /// <summary>
            /// ServerSideEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html#cfn-s3-bucket-bucketencryption-serversideencryptionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerSideEncryptionRule
            /// </summary>
            public List<ServerSideEncryptionRule> ServerSideEncryptionConfiguration { get; set; }
        }

        public class CorsConfiguration
        {
            /// <summary>
            /// CorsRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsconfiguration.html#cfn-s3-bucket-corsconfiguration-corsrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CorsRule
            /// </summary>
            public List<CorsRule> CorsRules { get; set; }
        }

        public class CorsRule
        {
            /// <summary>
            /// ExposedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-exposedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExposedHeaders { get; set; }
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-allowedmethods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedMethods { get; set; }
            /// <summary>
            /// AllowedOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-allowedorigins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedOrigins { get; set; }
            /// <summary>
            /// AllowedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-allowedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedHeaders { get; set; }
            /// <summary>
            /// MaxAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-maxage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAge { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class DataExport
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-dataexport.html#cfn-s3-bucket-dataexport-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Destination Destination { get; set; }
            /// <summary>
            /// OutputSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-dataexport.html#cfn-s3-bucket-dataexport-outputschemaversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputSchemaVersion { get; set; }
        }

        public class DefaultRetention
        {
            /// <summary>
            /// Years
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-years
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Years { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Days { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class DeleteMarkerReplication
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-deletemarkerreplication.html#cfn-s3-bucket-deletemarkerreplication-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class Destination
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// BucketAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-bucketaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketAccountId { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class EncryptionConfiguration
        {
            /// <summary>
            /// ReplicaKmsKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-encryptionconfiguration.html#cfn-s3-bucket-encryptionconfiguration-replicakmskeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicaKmsKeyID { get; set; }
        }

        public class EventBridgeConfiguration
        {
            /// <summary>
            /// EventBridgeEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-eventbridgeconfiguration.html#cfn-s3-bucket-eventbridgeconfiguration-eventbridgeenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EventBridgeEnabled { get; set; }
        }

        public class FilterRule
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-filterrule.html#cfn-s3-bucket-filterrule-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-filterrule.html#cfn-s3-bucket-filterrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntelligentTieringConfiguration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Tierings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-tierings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tiering
            /// </summary>
            public List<Tiering> Tierings { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class InventoryConfiguration
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Destination Destination { get; set; }
            /// <summary>
            /// OptionalFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-optionalfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OptionalFields { get; set; }
            /// <summary>
            /// IncludedObjectVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-includedobjectversions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncludedObjectVersions { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// ScheduleFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-schedulefrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleFrequency { get; set; }
        }

        public class LambdaConfiguration
        {
            /// <summary>
            /// Function
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lambdaconfiguration.html#cfn-s3-bucket-lambdaconfiguration-function
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Function { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lambdaconfiguration.html#cfn-s3-bucket-lambdaconfiguration-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public NotificationFilter Filter { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lambdaconfiguration.html#cfn-s3-bucket-lambdaconfiguration-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Event { get; set; }
        }

        public class LifecycleConfiguration
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfiguration.html#cfn-s3-bucket-lifecycleconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public List<Rule> Rules { get; set; }
        }

        public class LoggingConfiguration
        {
            /// <summary>
            /// TargetObjectKeyFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfiguration.html#cfn-s3-bucket-loggingconfiguration-targetobjectkeyformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetObjectKeyFormat
            /// </summary>
            public TargetObjectKeyFormat TargetObjectKeyFormat { get; set; }
            /// <summary>
            /// LogFilePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfiguration.html#cfn-s3-bucket-loggingconfiguration-logfileprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogFilePrefix { get; set; }
            /// <summary>
            /// DestinationBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfiguration.html#cfn-s3-bucket-loggingconfiguration-destinationbucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationBucketName { get; set; }
        }

        public class Metrics
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metrics.html#cfn-s3-bucket-metrics-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// EventThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metrics.html#cfn-s3-bucket-metrics-eventthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationTimeValue
            /// </summary>
            public ReplicationTimeValue EventThreshold { get; set; }
        }

        public class MetricsConfiguration
        {
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-accesspointarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessPointArn { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class NoncurrentVersionExpiration
        {
            /// <summary>
            /// NoncurrentDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversionexpiration.html#cfn-s3-bucket-noncurrentversionexpiration-noncurrentdays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NoncurrentDays { get; set; }
            /// <summary>
            /// NewerNoncurrentVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversionexpiration.html#cfn-s3-bucket-noncurrentversionexpiration-newernoncurrentversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NewerNoncurrentVersions { get; set; }
        }

        public class NoncurrentVersionTransition
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversiontransition.html#cfn-s3-bucket-noncurrentversiontransition-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// TransitionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversiontransition.html#cfn-s3-bucket-noncurrentversiontransition-transitionindays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransitionInDays { get; set; }
            /// <summary>
            /// NewerNoncurrentVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversiontransition.html#cfn-s3-bucket-noncurrentversiontransition-newernoncurrentversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NewerNoncurrentVersions { get; set; }
        }

        public class NotificationConfiguration
        {
            /// <summary>
            /// TopicConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-topicconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicConfiguration
            /// </summary>
            public List<TopicConfiguration> TopicConfigurations { get; set; }
            /// <summary>
            /// QueueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-queueconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueueConfiguration
            /// </summary>
            public List<QueueConfiguration> QueueConfigurations { get; set; }
            /// <summary>
            /// LambdaConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-lambdaconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LambdaConfiguration
            /// </summary>
            public List<LambdaConfiguration> LambdaConfigurations { get; set; }
            /// <summary>
            /// EventBridgeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-eventbridgeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBridgeConfiguration
            /// </summary>
            public EventBridgeConfiguration EventBridgeConfiguration { get; set; }
        }

        public class NotificationFilter
        {
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationfilter.html#cfn-s3-bucket-notificationfilter-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3KeyFilter
            /// </summary>
            public S3KeyFilter S3Key { get; set; }
        }

        public class ObjectLockConfiguration
        {
            /// <summary>
            /// ObjectLockEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockconfiguration.html#cfn-s3-bucket-objectlockconfiguration-objectlockenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectLockEnabled { get; set; }
            /// <summary>
            /// Rule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockconfiguration.html#cfn-s3-bucket-objectlockconfiguration-rule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObjectLockRule
            /// </summary>
            public ObjectLockRule Rule { get; set; }
        }

        public class ObjectLockRule
        {
            /// <summary>
            /// DefaultRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockrule.html#cfn-s3-bucket-objectlockrule-defaultretention
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRetention
            /// </summary>
            public DefaultRetention DefaultRetention { get; set; }
        }

        public class OwnershipControls
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ownershipcontrols.html#cfn-s3-bucket-ownershipcontrols-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OwnershipControlsRule
            /// </summary>
            public List<OwnershipControlsRule> Rules { get; set; }
        }

        public class OwnershipControlsRule
        {
            /// <summary>
            /// ObjectOwnership
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ownershipcontrolsrule.html#cfn-s3-bucket-ownershipcontrolsrule-objectownership
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectOwnership { get; set; }
        }

        public class PartitionedPrefix
        {
            /// <summary>
            /// PartitionDateSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-partitionedprefix.html#cfn-s3-bucket-partitionedprefix-partitiondatesource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartitionDateSource { get; set; }
        }

        public class PublicAccessBlockConfiguration
        {
            /// <summary>
            /// RestrictPublicBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-restrictpublicbuckets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RestrictPublicBuckets { get; set; }
            /// <summary>
            /// BlockPublicPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-blockpublicpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BlockPublicPolicy { get; set; }
            /// <summary>
            /// BlockPublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-blockpublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BlockPublicAcls { get; set; }
            /// <summary>
            /// IgnorePublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-ignorepublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IgnorePublicAcls { get; set; }
        }

        public class QueueConfiguration
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-queueconfiguration.html#cfn-s3-bucket-queueconfiguration-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public NotificationFilter Filter { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-queueconfiguration.html#cfn-s3-bucket-queueconfiguration-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Event { get; set; }
            /// <summary>
            /// Queue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-queueconfiguration.html#cfn-s3-bucket-queueconfiguration-queue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Queue { get; set; }
        }

        public class RedirectAllRequestsTo
        {
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectallrequeststo.html#cfn-s3-bucket-redirectallrequeststo-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectallrequeststo.html#cfn-s3-bucket-redirectallrequeststo-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostName { get; set; }
        }

        public class RedirectRule
        {
            /// <summary>
            /// ReplaceKeyWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-replacekeywith
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplaceKeyWith { get; set; }
            /// <summary>
            /// HttpRedirectCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-httpredirectcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpRedirectCode { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostName { get; set; }
            /// <summary>
            /// ReplaceKeyPrefixWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-replacekeyprefixwith
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplaceKeyPrefixWith { get; set; }
        }

        public class ReplicaModifications
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicamodifications.html#cfn-s3-bucket-replicamodifications-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class ReplicationConfiguration
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html#cfn-s3-bucket-replicationconfiguration-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html#cfn-s3-bucket-replicationconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationRule
            /// </summary>
            public List<ReplicationRule> Rules { get; set; }
        }

        public class ReplicationDestination
        {
            /// <summary>
            /// AccessControlTranslation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-accesscontroltranslation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessControlTranslation
            /// </summary>
            public AccessControlTranslation AccessControlTranslation { get; set; }
            /// <summary>
            /// Account
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-account
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Account { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metrics
            /// </summary>
            public Metrics Metrics { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public EncryptionConfiguration EncryptionConfiguration { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-storageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// ReplicationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-replicationtime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationTime
            /// </summary>
            public ReplicationTime ReplicationTime { get; set; }
        }

        public class ReplicationRule
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReplicationDestination
            /// </summary>
            public ReplicationDestination Destination { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationRuleFilter
            /// </summary>
            public ReplicationRuleFilter Filter { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// SourceSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-sourceselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceSelectionCriteria
            /// </summary>
            public SourceSelectionCriteria SourceSelectionCriteria { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// DeleteMarkerReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-deletemarkerreplication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeleteMarkerReplication
            /// </summary>
            public DeleteMarkerReplication DeleteMarkerReplication { get; set; }
        }

        public class ReplicationRuleAndOperator
        {
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationruleandoperator.html#cfn-s3-bucket-replicationruleandoperator-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationruleandoperator.html#cfn-s3-bucket-replicationruleandoperator-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class ReplicationRuleFilter
        {
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html#cfn-s3-bucket-replicationrulefilter-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationRuleAndOperator
            /// </summary>
            public ReplicationRuleAndOperator And { get; set; }
            /// <summary>
            /// TagFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html#cfn-s3-bucket-replicationrulefilter-tagfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagFilter
            /// </summary>
            public TagFilter TagFilter { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html#cfn-s3-bucket-replicationrulefilter-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class ReplicationTime
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtime.html#cfn-s3-bucket-replicationtime-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtime.html#cfn-s3-bucket-replicationtime-time
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReplicationTimeValue
            /// </summary>
            public ReplicationTimeValue Time { get; set; }
        }

        public class ReplicationTimeValue
        {
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtimevalue.html#cfn-s3-bucket-replicationtimevalue-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Minutes { get; set; }
        }

        public class RoutingRule
        {
            /// <summary>
            /// RedirectRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrule.html#cfn-s3-bucket-routingrule-redirectrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedirectRule
            /// </summary>
            public RedirectRule RedirectRule { get; set; }
            /// <summary>
            /// RoutingRuleCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrule.html#cfn-s3-bucket-routingrule-routingrulecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RoutingRuleCondition
            /// </summary>
            public RoutingRuleCondition RoutingRuleCondition { get; set; }
        }

        public class RoutingRuleCondition
        {
            /// <summary>
            /// KeyPrefixEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrulecondition.html#cfn-s3-bucket-routingrulecondition-keyprefixequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefixEquals { get; set; }
            /// <summary>
            /// HttpErrorCodeReturnedEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrulecondition.html#cfn-s3-bucket-routingrulecondition-httperrorcodereturnedequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpErrorCodeReturnedEquals { get; set; }
        }

        public class Rule
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// ExpiredObjectDeleteMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-expiredobjectdeletemarker
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ExpiredObjectDeleteMarker { get; set; }
            /// <summary>
            /// NoncurrentVersionExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversionexpirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NoncurrentVersionExpirationInDays { get; set; }
            /// <summary>
            /// Transitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-transitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transition
            /// </summary>
            public List<Transition> Transitions { get; set; }
            /// <summary>
            /// ObjectSizeGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-objectsizegreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectSizeGreaterThan { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters { get; set; }
            /// <summary>
            /// NoncurrentVersionTransitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversiontransitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NoncurrentVersionTransition
            /// </summary>
            public List<NoncurrentVersionTransition> NoncurrentVersionTransitions { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// ObjectSizeLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-objectsizelessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectSizeLessThan { get; set; }
            /// <summary>
            /// NoncurrentVersionTransition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversiontransition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoncurrentVersionTransition
            /// </summary>
            public NoncurrentVersionTransition NoncurrentVersionTransition { get; set; }
            /// <summary>
            /// ExpirationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-expirationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpirationDate { get; set; }
            /// <summary>
            /// NoncurrentVersionExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversionexpiration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoncurrentVersionExpiration
            /// </summary>
            public NoncurrentVersionExpiration NoncurrentVersionExpiration { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpirationInDays { get; set; }
            /// <summary>
            /// Transition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-transition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Transition
            /// </summary>
            public Transition Transition { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// AbortIncompleteMultipartUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-abortincompletemultipartupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbortIncompleteMultipartUpload
            /// </summary>
            public AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload { get; set; }
        }

        public class S3KeyFilter
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-s3keyfilter.html#cfn-s3-bucket-s3keyfilter-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterRule
            /// </summary>
            public List<FilterRule> Rules { get; set; }
        }

        public class ServerSideEncryptionByDefault
        {
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html#cfn-s3-bucket-serversideencryptionbydefault-ssealgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SSEAlgorithm { get; set; }
            /// <summary>
            /// KMSMasterKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html#cfn-s3-bucket-serversideencryptionbydefault-kmsmasterkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSMasterKeyID { get; set; }
        }

        public class ServerSideEncryptionRule
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-bucketkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BucketKeyEnabled { get; set; }
            /// <summary>
            /// ServerSideEncryptionByDefault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-serversideencryptionbydefault
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerSideEncryptionByDefault
            /// </summary>
            public ServerSideEncryptionByDefault ServerSideEncryptionByDefault { get; set; }
        }

        public class SourceSelectionCriteria
        {
            /// <summary>
            /// ReplicaModifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-replicamodifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaModifications
            /// </summary>
            public ReplicaModifications ReplicaModifications { get; set; }
            /// <summary>
            /// SseKmsEncryptedObjects
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-ssekmsencryptedobjects
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SseKmsEncryptedObjects
            /// </summary>
            public SseKmsEncryptedObjects SseKmsEncryptedObjects { get; set; }
        }

        public class SseKmsEncryptedObjects
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ssekmsencryptedobjects.html#cfn-s3-bucket-ssekmsencryptedobjects-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class StorageClassAnalysis
        {
            /// <summary>
            /// DataExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-storageclassanalysis.html#cfn-s3-bucket-storageclassanalysis-dataexport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataExport
            /// </summary>
            public DataExport DataExport { get; set; }
        }

        public class TagFilter
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tagfilter.html#cfn-s3-bucket-tagfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tagfilter.html#cfn-s3-bucket-tagfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TargetObjectKeyFormat
        {
            /// <summary>
            /// PartitionedPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-targetobjectkeyformat.html#cfn-s3-bucket-targetobjectkeyformat-partitionedprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PartitionedPrefix
            /// </summary>
            public PartitionedPrefix PartitionedPrefix { get; set; }
            /// <summary>
            /// SimplePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-targetobjectkeyformat.html#cfn-s3-bucket-targetobjectkeyformat-simpleprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SimplePrefix { get; set; }
        }

        public class Tiering
        {
            /// <summary>
            /// AccessTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tiering.html#cfn-s3-bucket-tiering-accesstier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessTier { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tiering.html#cfn-s3-bucket-tiering-days
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Days { get; set; }
        }

        public class TopicConfiguration
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-topicconfiguration.html#cfn-s3-bucket-topicconfiguration-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public NotificationFilter Filter { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-topicconfiguration.html#cfn-s3-bucket-topicconfiguration-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Event { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-topicconfiguration.html#cfn-s3-bucket-topicconfiguration-topic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Topic { get; set; }
        }

        public class Transition
        {
            /// <summary>
            /// TransitionDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-transition.html#cfn-s3-bucket-transition-transitiondate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransitionDate { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-transition.html#cfn-s3-bucket-transition-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// TransitionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-transition.html#cfn-s3-bucket-transition-transitionindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransitionInDays { get; set; }
        }

        public class VersioningConfiguration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-versioningconfiguration.html#cfn-s3-bucket-versioningconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class WebsiteConfiguration
        {
            /// <summary>
            /// IndexDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-indexdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexDocument { get; set; }
            /// <summary>
            /// RedirectAllRequestsTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-redirectallrequeststo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedirectAllRequestsTo
            /// </summary>
            public RedirectAllRequestsTo RedirectAllRequestsTo { get; set; }
            /// <summary>
            /// RoutingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-routingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RoutingRule
            /// </summary>
            public List<RoutingRule> RoutingRules { get; set; }
            /// <summary>
            /// ErrorDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-errordocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorDocument { get; set; }
        }
    }
}