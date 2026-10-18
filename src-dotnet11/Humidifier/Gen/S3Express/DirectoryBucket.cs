namespace Humidifier.S3Express
{
    using global::System.Collections.Generic;
    using DirectoryBucketTypes;

    public class DirectoryBucket : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfS3ExpressDirectoryBucketTypesInventoryConfigurationInventoryConfigurations, IHaveBucketName, IHaveS3ExpressDirectoryBucketTypesBucketEncryptionBucketEncryption, IHaveDataRedundancy, IHaveS3ExpressDirectoryBucketTypesLifecycleConfigurationLifecycleConfiguration, IHaveListOfS3ExpressDirectoryBucketTypesMetricsConfigurationMetricsConfigurations, IHaveLocationName
    {
        public class Attributes
        {
            public static string AvailabilityZoneName =  "AvailabilityZoneName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.S3Express.DirectoryBucket; }
        /// <summary>
        /// InventoryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-inventoryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InventoryConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration>, IReadOnlyList<Union<Humidifier.S3Express.DirectoryBucketTypes.InventoryConfiguration, BaseFunction>>, BaseFunction>? InventoryConfigurations { get; set; }
        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-bucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketName { get; set; }
        /// <summary>
        /// BucketEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-bucketencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BucketEncryption
        /// </summary>
        public Union<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption, BaseFunction>? BucketEncryption { get; set; }

        /// <summary>
        /// DataRedundancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-dataredundancy
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataRedundancy { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public Union<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }
        /// <summary>
        /// MetricsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-metricsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricsConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration>, IReadOnlyList<Union<Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration, BaseFunction>>, BaseFunction>? MetricsConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// LocationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3express-directorybucket.html#cfn-s3express-directorybucket-locationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LocationName { get; set; }
    }

    namespace DirectoryBucketTypes
    {
        public class AbortIncompleteMultipartUpload : Humidifier.Base.BaseSubResource, IHaveDaysAfterInitiation_Integer
        {
            /// <summary>
            /// DaysAfterInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-abortincompletemultipartupload.html#cfn-s3express-directorybucket-abortincompletemultipartupload-daysafterinitiation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysAfterInitiation { get; set; }
        }

        public class BucketEncryption : Humidifier.Base.BaseSubResource, IHaveListOfS3ExpressDirectoryBucketTypesServerSideEncryptionRuleServerSideEncryptionConfiguration
        {
            /// <summary>
            /// ServerSideEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-bucketencryption.html#cfn-s3express-directorybucket-bucketencryption-serversideencryptionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerSideEncryptionRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Express.DirectoryBucketTypes.ServerSideEncryptionRule>, IReadOnlyList<Union<Humidifier.S3Express.DirectoryBucketTypes.ServerSideEncryptionRule, BaseFunction>>, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveFormat, IHaveBucketAccountId, IHavePrefix
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-destination.html#cfn-s3express-directorybucket-destination-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-destination.html#cfn-s3express-directorybucket-destination-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// BucketAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-destination.html#cfn-s3express-directorybucket-destination-bucketaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketAccountId { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-destination.html#cfn-s3express-directorybucket-destination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class InventoryConfiguration : Humidifier.Base.BaseSubResource, IHaveS3ExpressDirectoryBucketTypesDestinationDestination, IHaveStringListOfOptionalFields, IHaveIncludedObjectVersions, IHaveEnabled_Boolean, IHaveId, IHavePrefix, IHaveScheduleFrequency
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Union<Humidifier.S3Express.DirectoryBucketTypes.Destination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// OptionalFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-optionalfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OptionalFields { get; set; }
            /// <summary>
            /// IncludedObjectVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-includedobjectversions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludedObjectVersions { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// ScheduleFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-inventoryconfiguration.html#cfn-s3express-directorybucket-inventoryconfiguration-schedulefrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleFrequency { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfS3ExpressDirectoryBucketTypesRuleRules
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-lifecycleconfiguration.html#cfn-s3express-directorybucket-lifecycleconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Express.DirectoryBucketTypes.Rule>, IReadOnlyList<Union<Humidifier.S3Express.DirectoryBucketTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class MetricsConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessPointArn, IHaveId, IHavePrefix
        {
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-metricsconfiguration.html#cfn-s3express-directorybucket-metricsconfiguration-accesspointarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-metricsconfiguration.html#cfn-s3express-directorybucket-metricsconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-metricsconfiguration.html#cfn-s3express-directorybucket-metricsconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveExpirationInDays_Integer, IHaveObjectSizeGreaterThan, IHaveId, IHavePrefix, IHaveS3ExpressDirectoryBucketTypesAbortIncompleteMultipartUploadAbortIncompleteMultipartUpload, IHaveObjectSizeLessThan
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpirationInDays { get; set; }
            /// <summary>
            /// ObjectSizeGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-objectsizegreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectSizeGreaterThan { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// AbortIncompleteMultipartUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-abortincompletemultipartupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbortIncompleteMultipartUpload
            /// </summary>
            public Union<Humidifier.S3Express.DirectoryBucketTypes.AbortIncompleteMultipartUpload, BaseFunction>? AbortIncompleteMultipartUpload { get; set; }
            /// <summary>
            /// ObjectSizeLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-rule.html#cfn-s3express-directorybucket-rule-objectsizelessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectSizeLessThan { get; set; }
        }

        public class ServerSideEncryptionByDefault : Humidifier.Base.BaseSubResource, IHaveSSEAlgorithm, IHaveKMSMasterKeyID
        {
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionbydefault.html#cfn-s3express-directorybucket-serversideencryptionbydefault-ssealgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEAlgorithm { get; set; }
            /// <summary>
            /// KMSMasterKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionbydefault.html#cfn-s3express-directorybucket-serversideencryptionbydefault-kmsmasterkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSMasterKeyID { get; set; }
        }

        public class ServerSideEncryptionRule : Humidifier.Base.BaseSubResource, IHaveBucketKeyEnabled_Boolean, IHaveS3ExpressDirectoryBucketTypesServerSideEncryptionByDefaultServerSideEncryptionByDefault
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionrule.html#cfn-s3express-directorybucket-serversideencryptionrule-bucketkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BucketKeyEnabled { get; set; }
            /// <summary>
            /// ServerSideEncryptionByDefault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3express-directorybucket-serversideencryptionrule.html#cfn-s3express-directorybucket-serversideencryptionrule-serversideencryptionbydefault
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerSideEncryptionByDefault
            /// </summary>
            public Union<Humidifier.S3Express.DirectoryBucketTypes.ServerSideEncryptionByDefault, BaseFunction>? ServerSideEncryptionByDefault { get; set; }
        }
    }
}