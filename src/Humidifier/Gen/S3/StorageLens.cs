namespace Humidifier.S3
{
    using System.Collections.Generic;
    using StorageLensTypes;

    public class StorageLens : Humidifier.Base.BaseResource, IHaveTags
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
        public Humidifier.S3.StorageLensTypes.StorageLensConfiguration StorageLensConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelens.html#cfn-s3-storagelens-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace StorageLensTypes
    {
        public class AccountLevel : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesAdvancedDataProtectionMetricsAdvancedDataProtectionMetrics, IHaveS3StorageLensTypesActivityMetricsActivityMetrics, IHaveS3StorageLensTypesAdvancedCostOptimizationMetricsAdvancedCostOptimizationMetrics, IHaveS3StorageLensTypesDetailedStatusCodesMetricsDetailedStatusCodesMetrics
        {
            /// <summary>
            /// AdvancedDataProtectionMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-advanceddataprotectionmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedDataProtectionMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics AdvancedDataProtectionMetrics { get; set; }
            /// <summary>
            /// StorageLensGroupLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-storagelensgrouplevel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensGroupLevel
            /// </summary>
            public Humidifier.S3.StorageLensTypes.StorageLensGroupLevel StorageLensGroupLevel { get; set; }
            /// <summary>
            /// ActivityMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-activitymetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActivityMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.ActivityMetrics ActivityMetrics { get; set; }
            /// <summary>
            /// BucketLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-bucketlevel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BucketLevel
            /// </summary>
            public Humidifier.S3.StorageLensTypes.BucketLevel BucketLevel { get; set; }
            /// <summary>
            /// AdvancedCostOptimizationMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-advancedcostoptimizationmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedCostOptimizationMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics AdvancedCostOptimizationMetrics { get; set; }
            /// <summary>
            /// DetailedStatusCodesMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html#cfn-s3-storagelens-accountlevel-detailedstatuscodesmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DetailedStatusCodesMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics DetailedStatusCodesMetrics { get; set; }
        }

        public class ActivityMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-activitymetrics.html#cfn-s3-storagelens-activitymetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
        }

        public class AdvancedCostOptimizationMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-advancedcostoptimizationmetrics.html#cfn-s3-storagelens-advancedcostoptimizationmetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
        }

        public class AdvancedDataProtectionMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-advanceddataprotectionmetrics.html#cfn-s3-storagelens-advanceddataprotectionmetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
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
            public dynamic Arn { get; set; }
        }

        public class BucketLevel : Humidifier.Base.BaseSubResource, IHaveS3StorageLensTypesAdvancedDataProtectionMetricsAdvancedDataProtectionMetrics, IHaveS3StorageLensTypesActivityMetricsActivityMetrics, IHaveS3StorageLensTypesAdvancedCostOptimizationMetricsAdvancedCostOptimizationMetrics, IHaveS3StorageLensTypesDetailedStatusCodesMetricsDetailedStatusCodesMetrics
        {
            /// <summary>
            /// AdvancedDataProtectionMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-advanceddataprotectionmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedDataProtectionMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics AdvancedDataProtectionMetrics { get; set; }
            /// <summary>
            /// PrefixLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-prefixlevel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrefixLevel
            /// </summary>
            public Humidifier.S3.StorageLensTypes.PrefixLevel PrefixLevel { get; set; }
            /// <summary>
            /// ActivityMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-activitymetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActivityMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.ActivityMetrics ActivityMetrics { get; set; }
            /// <summary>
            /// AdvancedCostOptimizationMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-advancedcostoptimizationmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedCostOptimizationMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics AdvancedCostOptimizationMetrics { get; set; }
            /// <summary>
            /// DetailedStatusCodesMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html#cfn-s3-storagelens-bucketlevel-detailedstatuscodesmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DetailedStatusCodesMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics DetailedStatusCodesMetrics { get; set; }
        }

        public class BucketsAndRegions : Humidifier.Base.BaseSubResource, IHaveRegions
        {
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Regions { get; set; }
            /// <summary>
            /// Buckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-buckets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Buckets { get; set; }
        }

        public class CloudWatchMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-cloudwatchmetrics.html#cfn-s3-storagelens-cloudwatchmetrics-isenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
        }

        public class DataExport : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3BucketDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-dataexport.html#cfn-s3-storagelens-dataexport-s3bucketdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3BucketDestination
            /// </summary>
            public Humidifier.S3.StorageLensTypes.S3BucketDestination S3BucketDestination { get; set; }
            /// <summary>
            /// CloudWatchMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-dataexport.html#cfn-s3-storagelens-dataexport-cloudwatchmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.CloudWatchMetrics CloudWatchMetrics { get; set; }
        }

        public class DetailedStatusCodesMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-detailedstatuscodesmetrics.html#cfn-s3-storagelens-detailedstatuscodesmetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-encryption.html#cfn-s3-storagelens-encryption-ssekms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SSEKMS
            /// </summary>
            public Humidifier.S3.StorageLensTypes.SSEKMS SSEKMS { get; set; }
            /// <summary>
            /// SSES3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-encryption.html#cfn-s3-storagelens-encryption-sses3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SSES3 { get; set; }
        }

        public class PrefixLevel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StorageMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevel.html#cfn-s3-storagelens-prefixlevel-storagemetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrefixLevelStorageMetrics
            /// </summary>
            public Humidifier.S3.StorageLensTypes.PrefixLevelStorageMetrics StorageMetrics { get; set; }
        }

        public class PrefixLevelStorageMetrics : Humidifier.Base.BaseSubResource, IHaveIsEnabled
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevelstoragemetrics.html#cfn-s3-storagelens-prefixlevelstoragemetrics-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
            /// <summary>
            /// SelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevelstoragemetrics.html#cfn-s3-storagelens-prefixlevelstoragemetrics-selectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelectionCriteria
            /// </summary>
            public Humidifier.S3.StorageLensTypes.SelectionCriteria SelectionCriteria { get; set; }
        }

        public class S3BucketDestination : Humidifier.Base.BaseSubResource, IHaveArn, IHavePrefix, IHaveFormat, IHaveAccountId, IHaveOutputSchemaVersion
        {
            /// <summary>
            /// OutputSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-outputschemaversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputSchemaVersion { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountId { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Humidifier.S3.StorageLensTypes.Encryption Encryption { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-s3bucketdestination.html#cfn-s3-storagelens-s3bucketdestination-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
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
            public dynamic KeyId { get; set; }
        }

        public class SelectionCriteria : Humidifier.Base.BaseSubResource, IHaveDelimiter
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html#cfn-s3-storagelens-selectioncriteria-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// MaxDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html#cfn-s3-storagelens-selectioncriteria-maxdepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxDepth { get; set; }
            /// <summary>
            /// MinStorageBytesPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html#cfn-s3-storagelens-selectioncriteria-minstoragebytespercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinStorageBytesPercentage { get; set; }
        }

        public class StorageLensConfiguration : Humidifier.Base.BaseSubResource, IHaveId, IHaveIsEnabled
        {
            /// <summary>
            /// AccountLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-accountlevel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccountLevel
            /// </summary>
            public Humidifier.S3.StorageLensTypes.AccountLevel AccountLevel { get; set; }
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BucketsAndRegions
            /// </summary>
            public Humidifier.S3.StorageLensTypes.BucketsAndRegions Exclude { get; set; }
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-isenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEnabled { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BucketsAndRegions
            /// </summary>
            public Humidifier.S3.StorageLensTypes.BucketsAndRegions Include { get; set; }
            /// <summary>
            /// AwsOrg
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-awsorg
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsOrg
            /// </summary>
            public Humidifier.S3.StorageLensTypes.AwsOrg AwsOrg { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// StorageLensArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-storagelensarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageLensArn { get; set; }
            /// <summary>
            /// DataExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html#cfn-s3-storagelens-storagelensconfiguration-dataexport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataExport
            /// </summary>
            public Humidifier.S3.StorageLensTypes.DataExport DataExport { get; set; }
        }

        public class StorageLensGroupLevel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StorageLensGroupSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensgrouplevel.html#cfn-s3-storagelens-storagelensgrouplevel-storagelensgroupselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageLensGroupSelectionCriteria
            /// </summary>
            public Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria StorageLensGroupSelectionCriteria { get; set; }
        }

        public class StorageLensGroupSelectionCriteria : Humidifier.Base.BaseSubResource, IHaveInclude, IHaveExclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensgroupselectioncriteria.html#cfn-s3-storagelens-storagelensgroupselectioncriteria-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensgroupselectioncriteria.html#cfn-s3-storagelens-storagelensgroupselectioncriteria-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Include { get; set; }
        }
    }
}