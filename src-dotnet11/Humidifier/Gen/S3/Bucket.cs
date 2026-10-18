namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using BucketTypes;

    public class Bucket : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBucketNamespace, IHaveListOfS3BucketTypesInventoryConfigurationInventoryConfigurations, IHaveBucketNamePrefix, IHaveS3BucketTypesWebsiteConfigurationWebsiteConfiguration, IHaveAccessControl, IHaveS3BucketTypesMetadataTableConfigurationMetadataTableConfiguration, IHaveListOfS3BucketTypesAnalyticsConfigurationAnalyticsConfigurations, IHaveAbacStatus, IHaveS3BucketTypesAccelerateConfigurationAccelerateConfiguration, IHaveS3BucketTypesPublicAccessBlockConfigurationPublicAccessBlockConfiguration, IHaveBucketName, IHaveS3BucketTypesOwnershipControlsOwnershipControls, IHaveS3BucketTypesObjectLockConfigurationObjectLockConfiguration, IHaveObjectLockEnabled_Boolean, IHaveS3BucketTypesLoggingConfigurationLoggingConfiguration, IHaveS3BucketTypesMetadataConfigurationMetadataConfiguration, IHaveS3BucketTypesReplicationConfigurationReplicationConfiguration, IHaveS3BucketTypesBucketEncryptionBucketEncryption, IHaveS3BucketTypesNotificationConfigurationNotificationConfiguration, IHaveS3BucketTypesLifecycleConfigurationLifecycleConfiguration, IHaveS3BucketTypesVersioningConfigurationVersioningConfiguration, IHaveListOfS3BucketTypesMetricsConfigurationMetricsConfigurations, IHaveListOfS3BucketTypesIntelligentTieringConfigurationIntelligentTieringConfigurations, IHaveS3BucketTypesCorsConfigurationCorsConfiguration
    {
        public class Attributes
        {
            public static string DomainName =  "DomainName" ;
            public static string WebsiteURL =  "WebsiteURL" ;
            public static string DualStackDomainName =  "DualStackDomainName" ;
            public static string RegionalDomainName =  "RegionalDomainName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.S3.Bucket; }
        /// <summary>
        /// BucketNamespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-bucketnamespace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketNamespace { get; set; }
        /// <summary>
        /// InventoryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-inventoryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InventoryConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3.BucketTypes.InventoryConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.InventoryConfiguration, BaseFunction>>, BaseFunction>? InventoryConfigurations { get; set; }
        /// <summary>
        /// BucketNamePrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-bucketnameprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketNamePrefix { get; set; }
        /// <summary>
        /// WebsiteConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-websiteconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebsiteConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.WebsiteConfiguration, BaseFunction>? WebsiteConfiguration { get; set; }
        /// <summary>
        /// AccessControl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-accesscontrol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessControl { get; set; }
        /// <summary>
        /// MetadataTableConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-metadatatableconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataTableConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.MetadataTableConfiguration, BaseFunction>? MetadataTableConfiguration { get; set; }
        /// <summary>
        /// AnalyticsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-analyticsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AnalyticsConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3.BucketTypes.AnalyticsConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.AnalyticsConfiguration, BaseFunction>>, BaseFunction>? AnalyticsConfigurations { get; set; }
        /// <summary>
        /// AbacStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-abacstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AbacStatus { get; set; }
        /// <summary>
        /// AccelerateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-accelerateconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccelerateConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.AccelerateConfiguration, BaseFunction>? AccelerateConfiguration { get; set; }
        /// <summary>
        /// PublicAccessBlockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-publicaccessblockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PublicAccessBlockConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.PublicAccessBlockConfiguration, BaseFunction>? PublicAccessBlockConfiguration { get; set; }
        public Union<string, BaseFunction>? BucketName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OwnershipControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-ownershipcontrols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OwnershipControls
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.OwnershipControls, BaseFunction>? OwnershipControls { get; set; }
        /// <summary>
        /// ObjectLockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-objectlockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ObjectLockConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.ObjectLockConfiguration, BaseFunction>? ObjectLockConfiguration { get; set; }
        /// <summary>
        /// ObjectLockEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-objectlockenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ObjectLockEnabled { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.LoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }
        /// <summary>
        /// MetadataConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-metadataconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.MetadataConfiguration, BaseFunction>? MetadataConfiguration { get; set; }
        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.ReplicationConfiguration, BaseFunction>? ReplicationConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// BucketEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-bucketencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BucketEncryption
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.BucketEncryption, BaseFunction>? BucketEncryption { get; set; }
        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-notificationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.NotificationConfiguration, BaseFunction>? NotificationConfiguration { get; set; }
        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-lifecycleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.LifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }
        /// <summary>
        /// VersioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-versioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersioningConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.VersioningConfiguration, BaseFunction>? VersioningConfiguration { get; set; }
        /// <summary>
        /// MetricsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-metricsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricsConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3.BucketTypes.MetricsConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.MetricsConfiguration, BaseFunction>>, BaseFunction>? MetricsConfigurations { get; set; }
        /// <summary>
        /// IntelligentTieringConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-intelligenttieringconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IntelligentTieringConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3.BucketTypes.IntelligentTieringConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.IntelligentTieringConfiguration, BaseFunction>>, BaseFunction>? IntelligentTieringConfigurations { get; set; }
        /// <summary>
        /// CorsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-bucket.html#cfn-s3-bucket-corsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CorsConfiguration
        /// </summary>
        public Union<Humidifier.S3.BucketTypes.CorsConfiguration, BaseFunction>? CorsConfiguration { get; set; }
    }

    namespace BucketTypes
    {
        public class AbortIncompleteMultipartUpload : Humidifier.Base.BaseSubResource, IHaveDaysAfterInitiation_Integer
        {
            /// <summary>
            /// DaysAfterInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-abortincompletemultipartupload.html#cfn-s3-bucket-abortincompletemultipartupload-daysafterinitiation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysAfterInitiation { get; set; }
        }

        public class AccelerateConfiguration : Humidifier.Base.BaseSubResource, IHaveAccelerationStatus
        {
            /// <summary>
            /// AccelerationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accelerateconfiguration.html#cfn-s3-bucket-accelerateconfiguration-accelerationstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccelerationStatus { get; set; }
        }

        public class AccessControlTranslation : Humidifier.Base.BaseSubResource, IHaveOwner
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accesscontroltranslation.html#cfn-s3-bucket-accesscontroltranslation-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
        }

        public class AnalyticsConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesStorageClassAnalysisStorageClassAnalysis, IHaveListOfS3BucketTypesTagFilterTagFilters, IHaveId, IHavePrefix
        {
            /// <summary>
            /// StorageClassAnalysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-storageclassanalysis
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StorageClassAnalysis
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.StorageClassAnalysis, BaseFunction>? StorageClassAnalysis { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.TagFilter>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html#cfn-s3-bucket-analyticsconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class AnnotationTableConfiguration : Humidifier.Base.BaseSubResource, IHaveRole, IHaveTableName, IHaveConfigurationState, IHaveTableArn, IHaveS3BucketTypesMetadataTableEncryptionConfigurationEncryptionConfiguration
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-annotationtableconfiguration.html#cfn-s3-bucket-annotationtableconfiguration-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-annotationtableconfiguration.html#cfn-s3-bucket-annotationtableconfiguration-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// ConfigurationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-annotationtableconfiguration.html#cfn-s3-bucket-annotationtableconfiguration-configurationstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationState { get; set; }
            /// <summary>
            /// TableArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-annotationtableconfiguration.html#cfn-s3-bucket-annotationtableconfiguration-tablearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableArn { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-annotationtableconfiguration.html#cfn-s3-bucket-annotationtableconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataTableEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        }

        public class BlockedEncryptionTypes : Humidifier.Base.BaseSubResource, IHaveStringListOfEncryptionType
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-blockedencryptiontypes.html#cfn-s3-bucket-blockedencryptiontypes-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EncryptionType { get; set; }
        }

        public class BucketEncryption : Humidifier.Base.BaseSubResource, IHaveListOfS3BucketTypesServerSideEncryptionRuleServerSideEncryptionConfiguration
        {
            /// <summary>
            /// ServerSideEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html#cfn-s3-bucket-bucketencryption-serversideencryptionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServerSideEncryptionRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.ServerSideEncryptionRule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.ServerSideEncryptionRule, BaseFunction>>, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        }

        public class CorsConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfS3BucketTypesCorsRuleCorsRules
        {
            /// <summary>
            /// CorsRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsconfiguration.html#cfn-s3-bucket-corsconfiguration-corsrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CorsRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.CorsRule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.CorsRule, BaseFunction>>, BaseFunction>? CorsRules { get; set; }
        }

        public class CorsRule : Humidifier.Base.BaseSubResource, IHaveStringListOfExposedHeaders, IHaveStringListOfAllowedMethods, IHaveStringListOfAllowedOrigins, IHaveStringListOfAllowedHeaders, IHaveMaxAge_Integer, IHaveId
        {
            /// <summary>
            /// ExposedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-exposedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExposedHeaders { get; set; }
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-allowedmethods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedMethods { get; set; }
            /// <summary>
            /// AllowedOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-allowedorigins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedOrigins { get; set; }
            /// <summary>
            /// AllowedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-allowedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedHeaders { get; set; }
            /// <summary>
            /// MaxAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-maxage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAge { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-corsrule.html#cfn-s3-bucket-corsrule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class DataExport : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesDestinationDestination, IHaveOutputSchemaVersion
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-dataexport.html#cfn-s3-bucket-dataexport-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.Destination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// OutputSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-dataexport.html#cfn-s3-bucket-dataexport-outputschemaversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputSchemaVersion { get; set; }
        }

        public class DefaultEventHold : Humidifier.Base.BaseSubResource, IHaveYears_Integer, IHaveDays_Integer
        {
            /// <summary>
            /// Years
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaulteventhold.html#cfn-s3-bucket-defaulteventhold-years
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Years { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaulteventhold.html#cfn-s3-bucket-defaulteventhold-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Days { get; set; }
        }

        public class DefaultRetention : Humidifier.Base.BaseSubResource, IHaveYears_Integer, IHaveDays_Integer, IHaveMode, IHaveS3BucketTypesDefaultEventHoldDefaultEventHold
        {
            /// <summary>
            /// Years
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-years
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Years { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Days { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// DefaultEventHold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html#cfn-s3-bucket-defaultretention-defaulteventhold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultEventHold
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.DefaultEventHold, BaseFunction>? DefaultEventHold { get; set; }
        }

        public class DeleteMarkerReplication : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-deletemarkerreplication.html#cfn-s3-bucket-deletemarkerreplication-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveBucketAccountId, IHaveFormat, IHavePrefix
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// BucketAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-bucketaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketAccountId { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-destination.html#cfn-s3-bucket-destination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveReplicaKmsKeyID
        {
            /// <summary>
            /// ReplicaKmsKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-encryptionconfiguration.html#cfn-s3-bucket-encryptionconfiguration-replicakmskeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicaKmsKeyID { get; set; }
        }

        public class EventBridgeConfiguration : Humidifier.Base.BaseSubResource, IHaveEventBridgeEnabled_Boolean
        {
            /// <summary>
            /// EventBridgeEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-eventbridgeconfiguration.html#cfn-s3-bucket-eventbridgeconfiguration-eventbridgeenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EventBridgeEnabled { get; set; }
        }

        public class FilterRule : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-filterrule.html#cfn-s3-bucket-filterrule-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-filterrule.html#cfn-s3-bucket-filterrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IntelligentTieringConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveListOfS3BucketTypesTieringTierings, IHaveListOfS3BucketTypesTagFilterTagFilters, IHaveId, IHavePrefix
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Tierings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-tierings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tiering
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.Tiering>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.Tiering, BaseFunction>>, BaseFunction>? Tierings { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.TagFilter>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html#cfn-s3-bucket-intelligenttieringconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class InventoryConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesDestinationDestination, IHaveStringListOfOptionalFields, IHaveIncludedObjectVersions, IHaveEnabled_Boolean, IHaveId, IHavePrefix, IHaveScheduleFrequency
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Destination
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.Destination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// OptionalFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-optionalfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OptionalFields { get; set; }
            /// <summary>
            /// IncludedObjectVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-includedobjectversions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludedObjectVersions { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// ScheduleFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-schedulefrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleFrequency { get; set; }
        }

        public class InventoryTableConfiguration : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveConfigurationState, IHaveTableArn, IHaveS3BucketTypesMetadataTableEncryptionConfigurationEncryptionConfiguration
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventorytableconfiguration.html#cfn-s3-bucket-inventorytableconfiguration-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// ConfigurationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventorytableconfiguration.html#cfn-s3-bucket-inventorytableconfiguration-configurationstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationState { get; set; }
            /// <summary>
            /// TableArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventorytableconfiguration.html#cfn-s3-bucket-inventorytableconfiguration-tablearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableArn { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventorytableconfiguration.html#cfn-s3-bucket-inventorytableconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataTableEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        }

        public class JournalTableConfiguration : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveTableArn, IHaveS3BucketTypesMetadataTableEncryptionConfigurationEncryptionConfiguration, IHaveS3BucketTypesRecordExpirationRecordExpiration
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-journaltableconfiguration.html#cfn-s3-bucket-journaltableconfiguration-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// TableArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-journaltableconfiguration.html#cfn-s3-bucket-journaltableconfiguration-tablearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableArn { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-journaltableconfiguration.html#cfn-s3-bucket-journaltableconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataTableEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// RecordExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-journaltableconfiguration.html#cfn-s3-bucket-journaltableconfiguration-recordexpiration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecordExpiration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.RecordExpiration, BaseFunction>? RecordExpiration { get; set; }
        }

        public class LambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveFunction, IHaveS3BucketTypesNotificationFilterFilter, IHaveEvent
        {
            /// <summary>
            /// Function
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lambdaconfiguration.html#cfn-s3-bucket-lambdaconfiguration-function
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Function { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lambdaconfiguration.html#cfn-s3-bucket-lambdaconfiguration-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.NotificationFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lambdaconfiguration.html#cfn-s3-bucket-lambdaconfiguration-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Event { get; set; }
        }

        public class LifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveTransitionDefaultMinimumObjectSize, IHaveListOfS3BucketTypesRuleRules
        {
            /// <summary>
            /// TransitionDefaultMinimumObjectSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfiguration.html#cfn-s3-bucket-lifecycleconfiguration-transitiondefaultminimumobjectsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitionDefaultMinimumObjectSize { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfiguration.html#cfn-s3-bucket-lifecycleconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.Rule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesTargetObjectKeyFormatTargetObjectKeyFormat, IHaveLogFilePrefix, IHaveDestinationBucketName
        {
            /// <summary>
            /// TargetObjectKeyFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfiguration.html#cfn-s3-bucket-loggingconfiguration-targetobjectkeyformat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetObjectKeyFormat
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.TargetObjectKeyFormat, BaseFunction>? TargetObjectKeyFormat { get; set; }
            /// <summary>
            /// LogFilePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfiguration.html#cfn-s3-bucket-loggingconfiguration-logfileprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFilePrefix { get; set; }
            /// <summary>
            /// DestinationBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfiguration.html#cfn-s3-bucket-loggingconfiguration-destinationbucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationBucketName { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesMetadataDestinationDestination, IHaveS3BucketTypesJournalTableConfigurationJournalTableConfiguration, IHaveS3BucketTypesInventoryTableConfigurationInventoryTableConfiguration, IHaveS3BucketTypesAnnotationTableConfigurationAnnotationTableConfiguration
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadataconfiguration.html#cfn-s3-bucket-metadataconfiguration-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataDestination
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.MetadataDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// JournalTableConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadataconfiguration.html#cfn-s3-bucket-metadataconfiguration-journaltableconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: JournalTableConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.JournalTableConfiguration, BaseFunction>? JournalTableConfiguration { get; set; }
            /// <summary>
            /// InventoryTableConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadataconfiguration.html#cfn-s3-bucket-metadataconfiguration-inventorytableconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InventoryTableConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.InventoryTableConfiguration, BaseFunction>? InventoryTableConfiguration { get; set; }
            /// <summary>
            /// AnnotationTableConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadataconfiguration.html#cfn-s3-bucket-metadataconfiguration-annotationtableconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnnotationTableConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.AnnotationTableConfiguration, BaseFunction>? AnnotationTableConfiguration { get; set; }
        }

        public class MetadataDestination : Humidifier.Base.BaseSubResource, IHaveTableBucketArn, IHaveTableBucketType, IHaveTableNamespace
        {
            /// <summary>
            /// TableBucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadatadestination.html#cfn-s3-bucket-metadatadestination-tablebucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableBucketArn { get; set; }
            /// <summary>
            /// TableBucketType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadatadestination.html#cfn-s3-bucket-metadatadestination-tablebuckettype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableBucketType { get; set; }
            /// <summary>
            /// TableNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadatadestination.html#cfn-s3-bucket-metadatadestination-tablenamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableNamespace { get; set; }
        }

        public class MetadataTableConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesS3TablesDestinationS3TablesDestination
        {
            /// <summary>
            /// S3TablesDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadatatableconfiguration.html#cfn-s3-bucket-metadatatableconfiguration-s3tablesdestination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3TablesDestination
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.S3TablesDestination, BaseFunction>? S3TablesDestination { get; set; }
        }

        public class MetadataTableEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveSseAlgorithm
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadatatableencryptionconfiguration.html#cfn-s3-bucket-metadatatableencryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// SseAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metadatatableencryptionconfiguration.html#cfn-s3-bucket-metadatatableencryptionconfiguration-ssealgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SseAlgorithm { get; set; }
        }

        public class Metrics : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveS3BucketTypesReplicationTimeValueEventThreshold
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metrics.html#cfn-s3-bucket-metrics-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// EventThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metrics.html#cfn-s3-bucket-metrics-eventthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationTimeValue
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicationTimeValue, BaseFunction>? EventThreshold { get; set; }
        }

        public class MetricsConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessPointArn, IHaveListOfS3BucketTypesTagFilterTagFilters, IHaveId, IHavePrefix
        {
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-accesspointarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.TagFilter>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class NoncurrentVersionExpiration : Humidifier.Base.BaseSubResource, IHaveNoncurrentDays_Integer, IHaveNewerNoncurrentVersions_Integer
        {
            /// <summary>
            /// NoncurrentDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversionexpiration.html#cfn-s3-bucket-noncurrentversionexpiration-noncurrentdays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NoncurrentDays { get; set; }
            /// <summary>
            /// NewerNoncurrentVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversionexpiration.html#cfn-s3-bucket-noncurrentversionexpiration-newernoncurrentversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NewerNoncurrentVersions { get; set; }
        }

        public class NoncurrentVersionTransition : Humidifier.Base.BaseSubResource, IHaveStorageClass, IHaveTransitionInDays_Integer, IHaveNewerNoncurrentVersions_Integer
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversiontransition.html#cfn-s3-bucket-noncurrentversiontransition-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// TransitionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversiontransition.html#cfn-s3-bucket-noncurrentversiontransition-transitionindays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransitionInDays { get; set; }
            /// <summary>
            /// NewerNoncurrentVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-noncurrentversiontransition.html#cfn-s3-bucket-noncurrentversiontransition-newernoncurrentversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NewerNoncurrentVersions { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfS3BucketTypesTopicConfigurationTopicConfigurations, IHaveListOfS3BucketTypesQueueConfigurationQueueConfigurations, IHaveListOfS3BucketTypesLambdaConfigurationLambdaConfigurations, IHaveS3BucketTypesEventBridgeConfigurationEventBridgeConfiguration
        {
            /// <summary>
            /// TopicConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-topicconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.TopicConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.TopicConfiguration, BaseFunction>>, BaseFunction>? TopicConfigurations { get; set; }
            /// <summary>
            /// QueueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-queueconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueueConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.QueueConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.QueueConfiguration, BaseFunction>>, BaseFunction>? QueueConfigurations { get; set; }
            /// <summary>
            /// LambdaConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-lambdaconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LambdaConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.LambdaConfiguration>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.LambdaConfiguration, BaseFunction>>, BaseFunction>? LambdaConfigurations { get; set; }
            /// <summary>
            /// EventBridgeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration.html#cfn-s3-bucket-notificationconfiguration-eventbridgeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBridgeConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.EventBridgeConfiguration, BaseFunction>? EventBridgeConfiguration { get; set; }
        }

        public class NotificationFilter : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesS3KeyFilterS3Key
        {
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationfilter.html#cfn-s3-bucket-notificationfilter-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3KeyFilter
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.S3KeyFilter, BaseFunction>? S3Key { get; set; }
        }

        public class ObjectLockConfiguration : Humidifier.Base.BaseSubResource, IHaveObjectLockEnabled, IHaveS3BucketTypesObjectLockRuleRule
        {
            /// <summary>
            /// ObjectLockEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockconfiguration.html#cfn-s3-bucket-objectlockconfiguration-objectlockenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectLockEnabled { get; set; }
            /// <summary>
            /// Rule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockconfiguration.html#cfn-s3-bucket-objectlockconfiguration-rule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObjectLockRule
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ObjectLockRule, BaseFunction>? Rule { get; set; }
        }

        public class ObjectLockRule : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesDefaultRetentionDefaultRetention
        {
            /// <summary>
            /// DefaultRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockrule.html#cfn-s3-bucket-objectlockrule-defaultretention
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultRetention
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.DefaultRetention, BaseFunction>? DefaultRetention { get; set; }
        }

        public class OwnershipControls : Humidifier.Base.BaseSubResource, IHaveListOfS3BucketTypesOwnershipControlsRuleRules
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ownershipcontrols.html#cfn-s3-bucket-ownershipcontrols-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OwnershipControlsRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.OwnershipControlsRule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.OwnershipControlsRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class OwnershipControlsRule : Humidifier.Base.BaseSubResource, IHaveObjectOwnership
        {
            /// <summary>
            /// ObjectOwnership
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ownershipcontrolsrule.html#cfn-s3-bucket-ownershipcontrolsrule-objectownership
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectOwnership { get; set; }
        }

        public class PartitionedPrefix : Humidifier.Base.BaseSubResource, IHavePartitionDateSource
        {
            /// <summary>
            /// PartitionDateSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-partitionedprefix.html#cfn-s3-bucket-partitionedprefix-partitiondatesource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionDateSource { get; set; }
        }

        public class PublicAccessBlockConfiguration : Humidifier.Base.BaseSubResource, IHaveRestrictPublicBuckets_Boolean, IHaveBlockPublicPolicy_Boolean, IHaveBlockPublicAcls_Boolean, IHaveIgnorePublicAcls_Boolean
        {
            /// <summary>
            /// RestrictPublicBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-restrictpublicbuckets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RestrictPublicBuckets { get; set; }
            /// <summary>
            /// BlockPublicPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-blockpublicpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicPolicy { get; set; }
            /// <summary>
            /// BlockPublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-blockpublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BlockPublicAcls { get; set; }
            /// <summary>
            /// IgnorePublicAcls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html#cfn-s3-bucket-publicaccessblockconfiguration-ignorepublicacls
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnorePublicAcls { get; set; }
        }

        public class QueueConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesNotificationFilterFilter, IHaveEvent, IHaveQueue
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-queueconfiguration.html#cfn-s3-bucket-queueconfiguration-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.NotificationFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-queueconfiguration.html#cfn-s3-bucket-queueconfiguration-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Event { get; set; }
            /// <summary>
            /// Queue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-queueconfiguration.html#cfn-s3-bucket-queueconfiguration-queue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Queue { get; set; }
        }

        public class RecordExpiration : Humidifier.Base.BaseSubResource, IHaveDays_Integer, IHaveExpiration
        {
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-recordexpiration.html#cfn-s3-bucket-recordexpiration-days
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Days { get; set; }
            /// <summary>
            /// Expiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-recordexpiration.html#cfn-s3-bucket-recordexpiration-expiration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expiration { get; set; }
        }

        public class RedirectAllRequestsTo : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveHostName
        {
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectallrequeststo.html#cfn-s3-bucket-redirectallrequeststo-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectallrequeststo.html#cfn-s3-bucket-redirectallrequeststo-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostName { get; set; }
        }

        public class RedirectRule : Humidifier.Base.BaseSubResource, IHaveReplaceKeyWith, IHaveHttpRedirectCode, IHaveProtocol, IHaveHostName, IHaveReplaceKeyPrefixWith
        {
            /// <summary>
            /// ReplaceKeyWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-replacekeywith
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplaceKeyWith { get; set; }
            /// <summary>
            /// HttpRedirectCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-httpredirectcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpRedirectCode { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostName { get; set; }
            /// <summary>
            /// ReplaceKeyPrefixWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-redirectrule.html#cfn-s3-bucket-redirectrule-replacekeyprefixwith
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplaceKeyPrefixWith { get; set; }
        }

        public class ReplicaModifications : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicamodifications.html#cfn-s3-bucket-replicamodifications-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class ReplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveRole, IHaveListOfS3BucketTypesReplicationRuleRules
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html#cfn-s3-bucket-replicationconfiguration-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html#cfn-s3-bucket-replicationconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.ReplicationRule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.ReplicationRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class ReplicationDestination : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesAccessControlTranslationAccessControlTranslation, IHaveAccount, IHaveS3BucketTypesMetricsMetrics, IHaveBucket, IHaveS3BucketTypesEncryptionConfigurationEncryptionConfiguration, IHaveStorageClass, IHaveS3BucketTypesReplicationTimeReplicationTime
        {
            /// <summary>
            /// AccessControlTranslation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-accesscontroltranslation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessControlTranslation
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.AccessControlTranslation, BaseFunction>? AccessControlTranslation { get; set; }
            /// <summary>
            /// Account
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-account
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Account { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metrics
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.Metrics, BaseFunction>? Metrics { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-storageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// ReplicationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationdestination.html#cfn-s3-bucket-replicationdestination-replicationtime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationTime
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicationTime, BaseFunction>? ReplicationTime { get; set; }
        }

        public class ReplicationRule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveS3BucketTypesReplicationDestinationDestination, IHaveS3BucketTypesReplicationRuleFilterFilter, IHavePriority_Integer, IHaveS3BucketTypesSourceSelectionCriteriaSourceSelectionCriteria, IHaveId, IHavePrefix, IHaveS3BucketTypesDeleteMarkerReplicationDeleteMarkerReplication
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReplicationDestination
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicationDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationRuleFilter
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicationRuleFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// SourceSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-sourceselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceSelectionCriteria
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.SourceSelectionCriteria, BaseFunction>? SourceSelectionCriteria { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// DeleteMarkerReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrule.html#cfn-s3-bucket-replicationrule-deletemarkerreplication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeleteMarkerReplication
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.DeleteMarkerReplication, BaseFunction>? DeleteMarkerReplication { get; set; }
        }

        public class ReplicationRuleAndOperator : Humidifier.Base.BaseSubResource, IHaveListOfS3BucketTypesTagFilterTagFilters, IHavePrefix
        {
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationruleandoperator.html#cfn-s3-bucket-replicationruleandoperator-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.TagFilter>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationruleandoperator.html#cfn-s3-bucket-replicationruleandoperator-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class ReplicationRuleFilter : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesReplicationRuleAndOperatorAnd, IHaveS3BucketTypesTagFilterTagFilter, IHavePrefix
        {
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html#cfn-s3-bucket-replicationrulefilter-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationRuleAndOperator
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicationRuleAndOperator, BaseFunction>? And { get; set; }
            /// <summary>
            /// TagFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html#cfn-s3-bucket-replicationrulefilter-tagfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagFilter
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.TagFilter, BaseFunction>? TagFilter { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html#cfn-s3-bucket-replicationrulefilter-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class ReplicationTime : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveS3BucketTypesReplicationTimeValueTime
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtime.html#cfn-s3-bucket-replicationtime-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtime.html#cfn-s3-bucket-replicationtime-time
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReplicationTimeValue
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicationTimeValue, BaseFunction>? Time { get; set; }
        }

        public class ReplicationTimeValue : Humidifier.Base.BaseSubResource, IHaveMinutes_Integer
        {
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtimevalue.html#cfn-s3-bucket-replicationtimevalue-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minutes { get; set; }
        }

        public class RoutingRule : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesRedirectRuleRedirectRule, IHaveS3BucketTypesRoutingRuleConditionRoutingRuleCondition
        {
            /// <summary>
            /// RedirectRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrule.html#cfn-s3-bucket-routingrule-redirectrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedirectRule
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.RedirectRule, BaseFunction>? RedirectRule { get; set; }
            /// <summary>
            /// RoutingRuleCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrule.html#cfn-s3-bucket-routingrule-routingrulecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RoutingRuleCondition
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.RoutingRuleCondition, BaseFunction>? RoutingRuleCondition { get; set; }
        }

        public class RoutingRuleCondition : Humidifier.Base.BaseSubResource, IHaveKeyPrefixEquals, IHaveHttpErrorCodeReturnedEquals
        {
            /// <summary>
            /// KeyPrefixEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrulecondition.html#cfn-s3-bucket-routingrulecondition-keyprefixequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefixEquals { get; set; }
            /// <summary>
            /// HttpErrorCodeReturnedEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-routingrulecondition.html#cfn-s3-bucket-routingrulecondition-httperrorcodereturnedequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpErrorCodeReturnedEquals { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveExpiredObjectDeleteMarker_Boolean, IHaveNoncurrentVersionExpirationInDays_Integer, IHaveListOfS3BucketTypesTransitionTransitions, IHaveObjectSizeGreaterThan, IHaveListOfS3BucketTypesTagFilterTagFilters, IHaveListOfS3BucketTypesNoncurrentVersionTransitionNoncurrentVersionTransitions, IHavePrefix, IHaveObjectSizeLessThan, IHaveS3BucketTypesNoncurrentVersionTransitionNoncurrentVersionTransition, IHaveExpirationDate, IHaveS3BucketTypesNoncurrentVersionExpirationNoncurrentVersionExpiration, IHaveExpirationInDays_Integer, IHaveS3BucketTypesTransitionTransition, IHaveId, IHaveS3BucketTypesAbortIncompleteMultipartUploadAbortIncompleteMultipartUpload
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ExpiredObjectDeleteMarker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-expiredobjectdeletemarker
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExpiredObjectDeleteMarker { get; set; }
            /// <summary>
            /// NoncurrentVersionExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversionexpirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NoncurrentVersionExpirationInDays { get; set; }
            /// <summary>
            /// Transitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-transitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.Transition>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.Transition, BaseFunction>>, BaseFunction>? Transitions { get; set; }
            /// <summary>
            /// ObjectSizeGreaterThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-objectsizegreaterthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectSizeGreaterThan { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.TagFilter>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
            /// <summary>
            /// NoncurrentVersionTransitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversiontransitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NoncurrentVersionTransition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.NoncurrentVersionTransition>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.NoncurrentVersionTransition, BaseFunction>>, BaseFunction>? NoncurrentVersionTransitions { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// ObjectSizeLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-objectsizelessthan
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectSizeLessThan { get; set; }
            /// <summary>
            /// NoncurrentVersionTransition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversiontransition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoncurrentVersionTransition
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.NoncurrentVersionTransition, BaseFunction>? NoncurrentVersionTransition { get; set; }
            /// <summary>
            /// ExpirationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-expirationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpirationDate { get; set; }
            /// <summary>
            /// NoncurrentVersionExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-noncurrentversionexpiration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoncurrentVersionExpiration
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.NoncurrentVersionExpiration, BaseFunction>? NoncurrentVersionExpiration { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpirationInDays { get; set; }
            /// <summary>
            /// Transition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-transition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Transition
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.Transition, BaseFunction>? Transition { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// AbortIncompleteMultipartUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-rule.html#cfn-s3-bucket-rule-abortincompletemultipartupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbortIncompleteMultipartUpload
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.AbortIncompleteMultipartUpload, BaseFunction>? AbortIncompleteMultipartUpload { get; set; }
        }

        public class S3KeyFilter : Humidifier.Base.BaseSubResource, IHaveListOfS3BucketTypesFilterRuleRules
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-s3keyfilter.html#cfn-s3-bucket-s3keyfilter-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.FilterRule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.FilterRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class S3TablesDestination : Humidifier.Base.BaseSubResource, IHaveTableBucketArn, IHaveTableName, IHaveTableArn, IHaveTableNamespace
        {
            /// <summary>
            /// TableBucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-s3tablesdestination.html#cfn-s3-bucket-s3tablesdestination-tablebucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableBucketArn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-s3tablesdestination.html#cfn-s3-bucket-s3tablesdestination-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// TableArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-s3tablesdestination.html#cfn-s3-bucket-s3tablesdestination-tablearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableArn { get; set; }
            /// <summary>
            /// TableNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-s3tablesdestination.html#cfn-s3-bucket-s3tablesdestination-tablenamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableNamespace { get; set; }
        }

        public class ServerSideEncryptionByDefault : Humidifier.Base.BaseSubResource, IHaveSSEAlgorithm, IHaveKMSMasterKeyID
        {
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html#cfn-s3-bucket-serversideencryptionbydefault-ssealgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEAlgorithm { get; set; }
            /// <summary>
            /// KMSMasterKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html#cfn-s3-bucket-serversideencryptionbydefault-kmsmasterkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSMasterKeyID { get; set; }
        }

        public class ServerSideEncryptionRule : Humidifier.Base.BaseSubResource, IHaveBucketKeyEnabled_Boolean, IHaveS3BucketTypesBlockedEncryptionTypesBlockedEncryptionTypes, IHaveS3BucketTypesServerSideEncryptionByDefaultServerSideEncryptionByDefault
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-bucketkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BucketKeyEnabled { get; set; }
            /// <summary>
            /// BlockedEncryptionTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-blockedencryptiontypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockedEncryptionTypes
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.BlockedEncryptionTypes, BaseFunction>? BlockedEncryptionTypes { get; set; }
            /// <summary>
            /// ServerSideEncryptionByDefault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-serversideencryptionbydefault
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerSideEncryptionByDefault
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ServerSideEncryptionByDefault, BaseFunction>? ServerSideEncryptionByDefault { get; set; }
        }

        public class SourceSelectionCriteria : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesReplicaModificationsReplicaModifications, IHaveS3BucketTypesSseKmsEncryptedObjectsSseKmsEncryptedObjects
        {
            /// <summary>
            /// ReplicaModifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-replicamodifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaModifications
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.ReplicaModifications, BaseFunction>? ReplicaModifications { get; set; }
            /// <summary>
            /// SseKmsEncryptedObjects
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-ssekmsencryptedobjects
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SseKmsEncryptedObjects
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.SseKmsEncryptedObjects, BaseFunction>? SseKmsEncryptedObjects { get; set; }
        }

        public class SseKmsEncryptedObjects : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ssekmsencryptedobjects.html#cfn-s3-bucket-ssekmsencryptedobjects-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class StorageClassAnalysis : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesDataExportDataExport
        {
            /// <summary>
            /// DataExport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-storageclassanalysis.html#cfn-s3-bucket-storageclassanalysis-dataexport
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataExport
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.DataExport, BaseFunction>? DataExport { get; set; }
        }

        public class TagFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tagfilter.html#cfn-s3-bucket-tagfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tagfilter.html#cfn-s3-bucket-tagfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TargetObjectKeyFormat : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesPartitionedPrefixPartitionedPrefix, IHaveSimplePrefix_Json
        {
            /// <summary>
            /// PartitionedPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-targetobjectkeyformat.html#cfn-s3-bucket-targetobjectkeyformat-partitionedprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PartitionedPrefix
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.PartitionedPrefix, BaseFunction>? PartitionedPrefix { get; set; }
            /// <summary>
            /// SimplePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-targetobjectkeyformat.html#cfn-s3-bucket-targetobjectkeyformat-simpleprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SimplePrefix { get; set; }
        }

        public class Tiering : Humidifier.Base.BaseSubResource, IHaveAccessTier, IHaveDays_Integer
        {
            /// <summary>
            /// AccessTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tiering.html#cfn-s3-bucket-tiering-accesstier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessTier { get; set; }
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tiering.html#cfn-s3-bucket-tiering-days
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Days { get; set; }
        }

        public class TopicConfiguration : Humidifier.Base.BaseSubResource, IHaveS3BucketTypesNotificationFilterFilter, IHaveEvent, IHaveTopic
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-topicconfiguration.html#cfn-s3-bucket-topicconfiguration-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.NotificationFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-topicconfiguration.html#cfn-s3-bucket-topicconfiguration-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Event { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-topicconfiguration.html#cfn-s3-bucket-topicconfiguration-topic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Topic { get; set; }
        }

        public class Transition : Humidifier.Base.BaseSubResource, IHaveTransitionDate, IHaveStorageClass, IHaveTransitionInDays_Integer
        {
            /// <summary>
            /// TransitionDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-transition.html#cfn-s3-bucket-transition-transitiondate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitionDate { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-transition.html#cfn-s3-bucket-transition-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// TransitionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-transition.html#cfn-s3-bucket-transition-transitionindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransitionInDays { get; set; }
        }

        public class VersioningConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-versioningconfiguration.html#cfn-s3-bucket-versioningconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class WebsiteConfiguration : Humidifier.Base.BaseSubResource, IHaveIndexDocument, IHaveS3BucketTypesRedirectAllRequestsToRedirectAllRequestsTo, IHaveListOfS3BucketTypesRoutingRuleRoutingRules, IHaveErrorDocument
        {
            /// <summary>
            /// IndexDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-indexdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexDocument { get; set; }
            /// <summary>
            /// RedirectAllRequestsTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-redirectallrequeststo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedirectAllRequestsTo
            /// </summary>
            public Union<Humidifier.S3.BucketTypes.RedirectAllRequestsTo, BaseFunction>? RedirectAllRequestsTo { get; set; }
            /// <summary>
            /// RoutingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-routingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RoutingRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.BucketTypes.RoutingRule>, IReadOnlyList<Union<Humidifier.S3.BucketTypes.RoutingRule, BaseFunction>>, BaseFunction>? RoutingRules { get; set; }
            /// <summary>
            /// ErrorDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-websiteconfiguration.html#cfn-s3-bucket-websiteconfiguration-errordocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorDocument { get; set; }
        }
    }
}