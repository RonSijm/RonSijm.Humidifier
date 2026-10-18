namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using CrawlerTypes;

    public class Crawler : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringListOfClassifiers, IHaveDescription, IHaveGlueCrawlerTypesSchemaChangePolicySchemaChangePolicy, IHaveConfiguration, IHaveGlueCrawlerTypesRecrawlPolicyRecrawlPolicy, IHaveDatabaseName, IHaveGlueCrawlerTypesTargetsTargets, IHaveCrawlerSecurityConfiguration, IHaveName, IHaveRole, IHaveGlueCrawlerTypesLakeFormationConfigurationLakeFormationConfiguration, IHaveGlueCrawlerTypesScheduleSchedule, IHaveTablePrefix, IHaveTags_Json
    {
        public override string AWSTypeName { get => AWS.Glue.Crawler; }
        /// <summary>
        /// Classifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-classifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Classifiers { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SchemaChangePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-schemachangepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaChangePolicy
        /// </summary>
        public Union<Humidifier.Glue.CrawlerTypes.SchemaChangePolicy, BaseFunction>? SchemaChangePolicy { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// RecrawlPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-recrawlpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecrawlPolicy
        /// </summary>
        public Union<Humidifier.Glue.CrawlerTypes.RecrawlPolicy, BaseFunction>? RecrawlPolicy { get; set; }
        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-databasename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatabaseName { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Targets
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.CrawlerTypes.Targets, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// CrawlerSecurityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-crawlersecurityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CrawlerSecurityConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-role
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// LakeFormationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-lakeformationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LakeFormationConfiguration
        /// </summary>
        public Union<Humidifier.Glue.CrawlerTypes.LakeFormationConfiguration, BaseFunction>? LakeFormationConfiguration { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        public Union<Humidifier.Glue.CrawlerTypes.Schedule, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// TablePrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-tableprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TablePrefix { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
    }

    namespace CrawlerTypes
    {
        public class CatalogTarget : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveDatabaseName, IHaveDlqEventQueueArn, IHaveStringListOfTables, IHaveEventQueueArn
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// DlqEventQueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-dlqeventqueuearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DlqEventQueueArn { get; set; }
            /// <summary>
            /// Tables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-tables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Tables { get; set; }
            /// <summary>
            /// EventQueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-eventqueuearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventQueueArn { get; set; }
        }

        public class DeltaTarget : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveCreateNativeDeltaTable_Boolean, IHaveWriteManifest_Boolean, IHaveStringListOfDeltaTables
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-deltatarget.html#cfn-glue-crawler-deltatarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// CreateNativeDeltaTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-deltatarget.html#cfn-glue-crawler-deltatarget-createnativedeltatable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CreateNativeDeltaTable { get; set; }
            /// <summary>
            /// WriteManifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-deltatarget.html#cfn-glue-crawler-deltatarget-writemanifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WriteManifest { get; set; }
            /// <summary>
            /// DeltaTables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-deltatarget.html#cfn-glue-crawler-deltatarget-deltatables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DeltaTables { get; set; }
        }

        public class DynamoDBTarget : Humidifier.Base.BaseSubResource, IHavePath, IHaveScanRate_Double, IHaveScanAll_Boolean
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-dynamodbtarget.html#cfn-glue-crawler-dynamodbtarget-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// ScanRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-dynamodbtarget.html#cfn-glue-crawler-dynamodbtarget-scanrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ScanRate { get; set; }
            /// <summary>
            /// ScanAll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-dynamodbtarget.html#cfn-glue-crawler-dynamodbtarget-scanall
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ScanAll { get; set; }
        }

        public class HudiTarget : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveStringListOfExclusions, IHaveStringListOfPaths, IHaveMaximumTraversalDepth_Integer
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-huditarget.html#cfn-glue-crawler-huditarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-huditarget.html#cfn-glue-crawler-huditarget-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclusions { get; set; }
            /// <summary>
            /// Paths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-huditarget.html#cfn-glue-crawler-huditarget-paths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Paths { get; set; }
            /// <summary>
            /// MaximumTraversalDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-huditarget.html#cfn-glue-crawler-huditarget-maximumtraversaldepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumTraversalDepth { get; set; }
        }

        public class IcebergTarget : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveStringListOfExclusions, IHaveStringListOfPaths, IHaveMaximumTraversalDepth_Integer
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-icebergtarget.html#cfn-glue-crawler-icebergtarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-icebergtarget.html#cfn-glue-crawler-icebergtarget-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclusions { get; set; }
            /// <summary>
            /// Paths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-icebergtarget.html#cfn-glue-crawler-icebergtarget-paths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Paths { get; set; }
            /// <summary>
            /// MaximumTraversalDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-icebergtarget.html#cfn-glue-crawler-icebergtarget-maximumtraversaldepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumTraversalDepth { get; set; }
        }

        public class JdbcTarget : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHavePath, IHaveStringListOfExclusions, IHaveStringListOfEnableAdditionalMetadata
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclusions { get; set; }
            /// <summary>
            /// EnableAdditionalMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-enableadditionalmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnableAdditionalMetadata { get; set; }
        }

        public class LakeFormationConfiguration : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveUseLakeFormationCredentials_Boolean
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-lakeformationconfiguration.html#cfn-glue-crawler-lakeformationconfiguration-accountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// UseLakeFormationCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-lakeformationconfiguration.html#cfn-glue-crawler-lakeformationconfiguration-uselakeformationcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseLakeFormationCredentials { get; set; }
        }

        public class MongoDBTarget : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHavePath
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-mongodbtarget.html#cfn-glue-crawler-mongodbtarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-mongodbtarget.html#cfn-glue-crawler-mongodbtarget-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
        }

        public class RecrawlPolicy : Humidifier.Base.BaseSubResource, IHaveRecrawlBehavior
        {
            /// <summary>
            /// RecrawlBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-recrawlpolicy.html#cfn-glue-crawler-recrawlpolicy-recrawlbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecrawlBehavior { get; set; }
        }

        public class S3Target : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHavePath, IHaveSampleSize_Integer, IHaveStringListOfExclusions, IHaveDlqEventQueueArn, IHaveEventQueueArn
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// SampleSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-samplesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SampleSize { get; set; }
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclusions { get; set; }
            /// <summary>
            /// DlqEventQueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-dlqeventqueuearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DlqEventQueueArn { get; set; }
            /// <summary>
            /// EventQueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-eventqueuearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventQueueArn { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveScheduleExpression
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schedule.html#cfn-glue-crawler-schedule-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
        }

        public class SchemaChangePolicy : Humidifier.Base.BaseSubResource, IHaveUpdateBehavior, IHaveDeleteBehavior
        {
            /// <summary>
            /// UpdateBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schemachangepolicy.html#cfn-glue-crawler-schemachangepolicy-updatebehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateBehavior { get; set; }
            /// <summary>
            /// DeleteBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schemachangepolicy.html#cfn-glue-crawler-schemachangepolicy-deletebehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeleteBehavior { get; set; }
        }

        public class Targets : Humidifier.Base.BaseSubResource, IHaveListOfGlueCrawlerTypesHudiTargetHudiTargets, IHaveListOfGlueCrawlerTypesS3TargetS3Targets, IHaveListOfGlueCrawlerTypesCatalogTargetCatalogTargets, IHaveListOfGlueCrawlerTypesDeltaTargetDeltaTargets, IHaveListOfGlueCrawlerTypesMongoDBTargetMongoDBTargets, IHaveListOfGlueCrawlerTypesJdbcTargetJdbcTargets, IHaveListOfGlueCrawlerTypesDynamoDBTargetDynamoDBTargets, IHaveListOfGlueCrawlerTypesIcebergTargetIcebergTargets
        {
            /// <summary>
            /// HudiTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-huditargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HudiTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.HudiTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.HudiTarget, BaseFunction>>, BaseFunction>? HudiTargets { get; set; }
            /// <summary>
            /// S3Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-s3targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: S3Target
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.S3Target>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.S3Target, BaseFunction>>, BaseFunction>? S3Targets { get; set; }
            /// <summary>
            /// CatalogTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-catalogtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CatalogTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.CatalogTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.CatalogTarget, BaseFunction>>, BaseFunction>? CatalogTargets { get; set; }
            /// <summary>
            /// DeltaTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-deltatargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DeltaTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.DeltaTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.DeltaTarget, BaseFunction>>, BaseFunction>? DeltaTargets { get; set; }
            /// <summary>
            /// MongoDBTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-mongodbtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MongoDBTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.MongoDBTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.MongoDBTarget, BaseFunction>>, BaseFunction>? MongoDBTargets { get; set; }
            /// <summary>
            /// JdbcTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-jdbctargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JdbcTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.JdbcTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.JdbcTarget, BaseFunction>>, BaseFunction>? JdbcTargets { get; set; }
            /// <summary>
            /// DynamoDBTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-dynamodbtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DynamoDBTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.DynamoDBTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.DynamoDBTarget, BaseFunction>>, BaseFunction>? DynamoDBTargets { get; set; }
            /// <summary>
            /// IcebergTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-icebergtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IcebergTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.CrawlerTypes.IcebergTarget>, IReadOnlyList<Union<Humidifier.Glue.CrawlerTypes.IcebergTarget, BaseFunction>>, BaseFunction>? IcebergTargets { get; set; }
        }
    }
}