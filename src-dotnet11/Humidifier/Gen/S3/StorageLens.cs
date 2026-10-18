namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using StorageLensTypes;

    public class StorageLens : Humidifier.Base.BaseResource, IHaveTags, IHaveS3StorageLensTypesStorageLensConfigurationStorageLensConfiguration
    {
        public class Attributes
        {
        }

        public override string AWSTypeName { get => AWS.S3.StorageLens; }

        /// <summary>
        /// StorageLensConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelens.html#cfn-s3-storagelens-storagelensconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: StorageLensConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.S3.StorageLensTypes.StorageLensConfiguration, BaseFunction>? StorageLensConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelens.html#cfn-s3-storagelens-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace StorageLensTypes
    {
        public class AccountLevel : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesAdvancedDataProtectionMetricsAdvancedDataProtectionMetrics, IHaveS3StorageLensTypesStorageLensGroupLevelStorageLensGroupLevel, IHaveS3StorageLensTypesActivityMetricsActivityMetrics, IHaveS3StorageLensTypesAdvancedPerformanceMetricsAdvancedPerformanceMetrics, IHaveS3StorageLensTypesBucketLevelBucketLevel, IHaveS3StorageLensTypesAdvancedCostOptimizationMetricsAdvancedCostOptimizationMetrics, IHaveS3StorageLensTypesDetailedStatusCodesMetricsDetailedStatusCodesMetrics
        {
            /// <summary>
            /// AdvancedDataProtectionMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-advanceddataprotectionmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedDataProtectionMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics, BaseFunction>? AdvancedDataProtectionMetrics { get; set; }
            /// <summary>
            /// StorageLensGroupLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-storagelensgrouplevel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensGroupLevel
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.StorageLensGroupLevel, BaseFunction>? StorageLensGroupLevel { get; set; }
            /// <summary>
            /// ActivityMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-activitymetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActivityMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.ActivityMetrics, BaseFunction>? ActivityMetrics { get; set; }
            /// <summary>
            /// AdvancedPerformanceMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-advancedperformancemetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedPerformanceMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics, BaseFunction>? AdvancedPerformanceMetrics { get; set; }
            /// <summary>
            /// BucketLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-bucketlevel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BucketLevel
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.BucketLevel, BaseFunction>? BucketLevel { get; set; }
            /// <summary>
            /// AdvancedCostOptimizationMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-advancedcostoptimizationmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedCostOptimizationMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics, BaseFunction>? AdvancedCostOptimizationMetrics { get; set; }
            /// <summary>
            /// DetailedStatusCodesMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-detailedstatuscodesmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DetailedStatusCodesMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics, BaseFunction>? DetailedStatusCodesMetrics { get; set; }
        }

        public class ActivityMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-activitymetrics.html#cfn-s3-storagelens-activitymetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
        }

        public class AdvancedCostOptimizationMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-advancedcostoptimizationmetrics.html#cfn-s3-storagelens-advancedcostoptimizationmetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
        }

        public class AdvancedDataProtectionMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-advanceddataprotectionmetrics.html#cfn-s3-storagelens-advanceddataprotectionmetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
        }

        public class AdvancedPerformanceMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-advancedperformancemetrics.html#cfn-s3-storagelens-advancedperformancemetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
        }

        public class AwsOrg : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-awsorg.html#cfn-s3-storagelens-awsorg-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class BucketLevel : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesAdvancedDataProtectionMetricsAdvancedDataProtectionMetrics, IHaveS3StorageLensTypesPrefixLevelPrefixLevel, IHaveS3StorageLensTypesActivityMetricsActivityMetrics, IHaveS3StorageLensTypesAdvancedPerformanceMetricsAdvancedPerformanceMetrics, IHaveS3StorageLensTypesAdvancedCostOptimizationMetricsAdvancedCostOptimizationMetrics, IHaveS3StorageLensTypesDetailedStatusCodesMetricsDetailedStatusCodesMetrics
        {
            /// <summary>
            /// AdvancedDataProtectionMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-advanceddataprotectionmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedDataProtectionMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics, BaseFunction>? AdvancedDataProtectionMetrics { get; set; }
            /// <summary>
            /// PrefixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-prefixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrefixLevel
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.PrefixLevel, BaseFunction>? PrefixLevel { get; set; }
            /// <summary>
            /// ActivityMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-activitymetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActivityMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.ActivityMetrics, BaseFunction>? ActivityMetrics { get; set; }
            /// <summary>
            /// AdvancedPerformanceMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-advancedperformancemetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedPerformanceMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics, BaseFunction>? AdvancedPerformanceMetrics { get; set; }
            /// <summary>
            /// AdvancedCostOptimizationMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-advancedcostoptimizationmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedCostOptimizationMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics, BaseFunction>? AdvancedCostOptimizationMetrics { get; set; }
            /// <summary>
            /// DetailedStatusCodesMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-detailedstatuscodesmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DetailedStatusCodesMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics, BaseFunction>? DetailedStatusCodesMetrics { get; set; }
        }

        public class BucketsAndRegions : Humidifier.Base.BaseSubResource, IHaveStringListOfRegions, IHaveStringListOfBuckets
        {
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
            /// <summary>
            /// Buckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-buckets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Buckets { get; set; }
        }

        public class CloudWatchMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-cloudwatchmetrics.html#cfn-s3-storagelens-cloudwatchmetrics-isenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
        }

        public class DataExport : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesStorageLensTableDestinationStorageLensTableDestination, IHaveS3StorageLensTypesS3BucketDestinationS3BucketDestination, IHaveS3StorageLensTypesCloudWatchMetricsCloudWatchMetrics
        {
            /// <summary>
            /// StorageLensTableDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-dataexport.html#cfn-s3-storagelens-dataexport-storagelenstabledestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensTableDestination
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.StorageLensTableDestination, BaseFunction>? StorageLensTableDestination { get; set; }
            /// <summary>
            /// S3BucketDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-dataexport.html#cfn-s3-storagelens-dataexport-s3bucketdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3BucketDestination
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.S3BucketDestination, BaseFunction>? S3BucketDestination { get; set; }
            /// <summary>
            /// CloudWatchMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-dataexport.html#cfn-s3-storagelens-dataexport-cloudwatchmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.CloudWatchMetrics, BaseFunction>? CloudWatchMetrics { get; set; }
        }

        public class DetailedStatusCodesMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-detailedstatuscodesmetrics.html#cfn-s3-storagelens-detailedstatuscodesmetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesSSEKMSSSEKMS, IHaveSSES3_Json
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-encryption.html#cfn-s3-storagelens-encryption-ssekms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SSEKMS
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.SSEKMS, BaseFunction>? SSEKMS { get; set; }
            /// <summary>
            /// SSES3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-encryption.html#cfn-s3-storagelens-encryption-sses3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SSES3 { get; set; }
        }

        public class PrefixLevel : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesPrefixLevelStorageMetricsStorageMetrics
        {
            /// <summary>
            /// StorageMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevel.html#cfn-s3-storagelens-prefixlevel-storagemetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrefixLevelStorageMetrics
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics, BaseFunction>? StorageMetrics { get; set; }
        }

        public class PrefixLevelStorageMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean, IHaveS3StorageLensTypesSelectionCriteriaSelectionCriteria
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevelstoragemetrics.html#cfn-s3-storagelens-prefixlevelstoragemetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
            /// <summary>
            /// SelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevelstoragemetrics.html#cfn-s3-storagelens-prefixlevelstoragemetrics-selectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelectionCriteria
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.SelectionCriteria, BaseFunction>? SelectionCriteria { get; set; }
        }

        public class S3BucketDestination : Humidifier.Base.BaseSubResource, IHaveOutputSchemaVersion, IHaveFormat, IHaveAccountId, IHavePrefix, IHaveS3StorageLensTypesEncryptionEncryption, IHaveArn
        {
            /// <summary>
            /// OutputSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-outputschemaversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputSchemaVersion { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.Encryption, BaseFunction>? Encryption { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class SSEKMS : Humidifier.Base.BaseSubResource, IHaveKeyId
        {
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-ssekms.html#cfn-s3-storagelens-ssekms-keyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyId { get; set; }
        }

        public class SelectionCriteria : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveMaxDepth_Integer, IHaveMinStorageBytesPercentage_Double
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html#cfn-s3-storagelens-selectioncriteria-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Delimiter { get; set; }
            /// <summary>
            /// MaxDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html#cfn-s3-storagelens-selectioncriteria-maxdepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxDepth { get; set; }
            /// <summary>
            /// MinStorageBytesPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html#cfn-s3-storagelens-selectioncriteria-minstoragebytespercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinStorageBytesPercentage { get; set; }
        }

        public class StorageLensConfiguration : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesAccountLevelAccountLevel, IHaveS3StorageLensTypesBucketsAndRegionsExclude, IHaveIsEnabled_Boolean, IHaveS3StorageLensTypesBucketsAndRegionsInclude, IHavePrefixDelimiter, IHaveS3StorageLensTypesAwsOrgAwsOrg, IHaveId, IHaveStorageLensArn, IHaveS3StorageLensTypesDataExportDataExport, IHaveS3StorageLensTypesStorageLensExpandedPrefixesDataExportExpandedPrefixesDataExport
        {
            /// <summary>
            /// AccountLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-accountlevel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccountLevel
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AccountLevel, BaseFunction>? AccountLevel { get; set; }
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BucketsAndRegions
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.BucketsAndRegions, BaseFunction>? Exclude { get; set; }
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-isenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BucketsAndRegions
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.BucketsAndRegions, BaseFunction>? Include { get; set; }
            /// <summary>
            /// PrefixDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-prefixdelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrefixDelimiter { get; set; }
            /// <summary>
            /// AwsOrg
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-awsorg
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsOrg
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.AwsOrg, BaseFunction>? AwsOrg { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// StorageLensArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-storagelensarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageLensArn { get; set; }
            /// <summary>
            /// DataExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-dataexport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataExport
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.DataExport, BaseFunction>? DataExport { get; set; }
            /// <summary>
            /// ExpandedPrefixesDataExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-expandedprefixesdataexport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensExpandedPrefixesDataExport
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.StorageLensExpandedPrefixesDataExport, BaseFunction>? ExpandedPrefixesDataExport { get; set; }
        }

        public class StorageLensExpandedPrefixesDataExport : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesStorageLensTableDestinationStorageLensTableDestination, IHaveS3StorageLensTypesS3BucketDestinationS3BucketDestination
        {
            /// <summary>
            /// StorageLensTableDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensexpandedprefixesdataexport.html#cfn-s3-storagelens-storagelensexpandedprefixesdataexport-storagelenstabledestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensTableDestination
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.StorageLensTableDestination, BaseFunction>? StorageLensTableDestination { get; set; }
            /// <summary>
            /// S3BucketDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensexpandedprefixesdataexport.html#cfn-s3-storagelens-storagelensexpandedprefixesdataexport-s3bucketdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3BucketDestination
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.S3BucketDestination, BaseFunction>? S3BucketDestination { get; set; }
        }

        public class StorageLensGroupLevel : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesStorageLensGroupSelectionCriteriaStorageLensGroupSelectionCriteria
        {
            /// <summary>
            /// StorageLensGroupSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensgrouplevel.html#cfn-s3-storagelens-storagelensgrouplevel-storagelensgroupselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensGroupSelectionCriteria
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria, BaseFunction>? StorageLensGroupSelectionCriteria { get; set; }
        }

        public class StorageLensGroupSelectionCriteria : Humidifier.Base.BaseSubResource, IHaveStringListOfExclude, IHaveStringListOfInclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensgroupselectioncriteria.html#cfn-s3-storagelens-storagelensgroupselectioncriteria-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensgroupselectioncriteria.html#cfn-s3-storagelens-storagelensgroupselectioncriteria-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Include { get; set; }
        }

        public class StorageLensTableDestination : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean, IHaveS3StorageLensTypesEncryptionEncryption
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelenstabledestination.html#cfn-s3-storagelens-storagelenstabledestination-isenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelenstabledestination.html#cfn-s3-storagelens-storagelenstabledestination-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Union<Humidifier.S3.StorageLensTypes.Encryption, BaseFunction>? Encryption { get; set; }
        }
    }
}