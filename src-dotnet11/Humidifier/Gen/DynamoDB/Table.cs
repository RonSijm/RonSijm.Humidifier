namespace Humidifier.DynamoDB
{
    using global::System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDynamoDBTableTypesOnDemandThroughputOnDemandThroughput, IHaveDynamoDBTableTypesSSESpecificationSSESpecification, IHaveDynamoDBTableTypesKinesisStreamSpecificationKinesisStreamSpecification, IHaveDynamoDBTableTypesStreamSpecificationStreamSpecification, IHaveDynamoDBTableTypesContributorInsightsSpecificationContributorInsightsSpecification, IHaveDynamoDBTableTypesImportSourceSpecificationImportSourceSpecification, IHaveDynamoDBTableTypesPointInTimeRecoverySpecificationPointInTimeRecoverySpecification, IHaveDynamoDBTableTypesProvisionedThroughputProvisionedThroughput, IHaveDynamoDBTableTypesWarmThroughputWarmThroughput, IHaveListOfDynamoDBTableTypesVectorIndexVectorIndexes, IHaveTableName, IHaveListOfDynamoDBTableTypesAttributeDefinitionAttributeDefinitions, IHaveListOfDynamoDBTableTypesGlobalSecondaryIndexGlobalSecondaryIndexes, IHaveBillingMode, IHaveDynamoDBTableTypesResourcePolicyResourcePolicy, IHaveListOfDynamoDBTableTypesLocalSecondaryIndexLocalSecondaryIndexes, IHaveListOfDynamoDBTableTypesKeySchemaKeySchema, IHaveDeletionProtectionEnabled_Boolean, IHaveTableClass, IHaveDynamoDBTableTypesTimeToLiveSpecificationTimeToLiveSpecification
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string StreamArn =  "StreamArn" ;
        }

        public override string AWSTypeName { get => AWS.DynamoDB.Table; }
        /// <summary>
        /// OnDemandThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ondemandthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnDemandThroughput
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.OnDemandThroughput, BaseFunction>? OnDemandThroughput { get; set; }
        /// <summary>
        /// SSESpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SSESpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.SSESpecification, BaseFunction>? SSESpecification { get; set; }
        /// <summary>
        /// KinesisStreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-kinesisstreamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisStreamSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.KinesisStreamSpecification, BaseFunction>? KinesisStreamSpecification { get; set; }
        /// <summary>
        /// StreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-streamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.StreamSpecification, BaseFunction>? StreamSpecification { get; set; }
        /// <summary>
        /// ContributorInsightsSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-contributorinsightsspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContributorInsightsSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification, BaseFunction>? ContributorInsightsSpecification { get; set; }
        /// <summary>
        /// ImportSourceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-importsourcespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImportSourceSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.ImportSourceSpecification, BaseFunction>? ImportSourceSpecification { get; set; }
        /// <summary>
        /// PointInTimeRecoverySpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-pointintimerecoveryspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PointInTimeRecoverySpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.PointInTimeRecoverySpecification, BaseFunction>? PointInTimeRecoverySpecification { get; set; }
        /// <summary>
        /// ProvisionedThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-provisionedthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedThroughput
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.ProvisionedThroughput, BaseFunction>? ProvisionedThroughput { get; set; }
        /// <summary>
        /// WarmThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-warmthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WarmThroughput
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.WarmThroughput, BaseFunction>? WarmThroughput { get; set; }
        /// <summary>
        /// VectorIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-vectorindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VectorIndex
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.VectorIndex>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.VectorIndex, BaseFunction>>, BaseFunction>? VectorIndexes { get; set; }
        public Union<string, BaseFunction>? TableName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AttributeDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-attributedefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AttributeDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.AttributeDefinition>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.AttributeDefinition, BaseFunction>>, BaseFunction>? AttributeDefinitions { get; set; }
        /// <summary>
        /// GlobalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-globalsecondaryindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalSecondaryIndex
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.GlobalSecondaryIndex>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.GlobalSecondaryIndex, BaseFunction>>, BaseFunction>? GlobalSecondaryIndexes { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingMode { get; set; }
        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-resourcepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourcePolicy
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.ResourcePolicy, BaseFunction>? ResourcePolicy { get; set; }
        /// <summary>
        /// LocalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-localsecondaryindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LocalSecondaryIndex
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex, BaseFunction>>, BaseFunction>? LocalSecondaryIndexes { get; set; }

        /// <summary>
        /// KeySchema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-keyschema
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: KeySchema
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.KeySchema>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.KeySchema, BaseFunction>>, BaseFunction>? KeySchema { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// TableClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tableclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TableClass { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TimeToLiveSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-timetolivespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeToLiveSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.TableTypes.TimeToLiveSpecification, BaseFunction>? TimeToLiveSpecification { get; set; }
    }

    namespace TableTypes
    {
        public class AttributeDefinition : Humidifier.Base.BaseSubResource, IHaveAttributeType, IHaveAttributeName
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-attributedefinition.html#cfn-dynamodb-table-attributedefinition-attributetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-attributedefinition.html#cfn-dynamodb-table-attributedefinition-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class ContributorInsightsSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveMode
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-contributorinsightsspecification.html#cfn-dynamodb-table-contributorinsightsspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-contributorinsightsspecification.html#cfn-dynamodb-table-contributorinsightsspecification-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class Csv : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveStringListOfHeaderList
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-csv.html#cfn-dynamodb-table-csv-delimiter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Delimiter { get; set; }
            /// <summary>
            /// HeaderList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-csv.html#cfn-dynamodb-table-csv-headerlist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HeaderList { get; set; }
        }

        public class GlobalSecondaryIndex : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBTableTypesOnDemandThroughputOnDemandThroughput, IHaveDynamoDBTableTypesContributorInsightsSpecificationContributorInsightsSpecification, IHaveDynamoDBTableTypesProjectionProjection, IHaveDynamoDBTableTypesProvisionedThroughputProvisionedThroughput, IHaveListOfDynamoDBTableTypesKeySchemaKeySchema, IHaveDynamoDBTableTypesWarmThroughputWarmThroughput
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// OnDemandThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-ondemandthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandThroughput
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.OnDemandThroughput, BaseFunction>? OnDemandThroughput { get; set; }
            /// <summary>
            /// ContributorInsightsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-contributorinsightsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContributorInsightsSpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification, BaseFunction>? ContributorInsightsSpecification { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.Projection, BaseFunction>? Projection { get; set; }
            /// <summary>
            /// ProvisionedThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-provisionedthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedThroughput
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.ProvisionedThroughput, BaseFunction>? ProvisionedThroughput { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.KeySchema>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.KeySchema, BaseFunction>>, BaseFunction>? KeySchema { get; set; }
            /// <summary>
            /// WarmThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-warmthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WarmThroughput
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.WarmThroughput, BaseFunction>? WarmThroughput { get; set; }
        }

        public class ImportSourceSpecification : Humidifier.Base.BaseSubResource, IHaveDynamoDBTableTypesS3BucketSourceS3BucketSource, IHaveInputFormat, IHaveDynamoDBTableTypesInputFormatOptionsInputFormatOptions, IHaveInputCompressionType
        {
            /// <summary>
            /// S3BucketSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-s3bucketsource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3BucketSource
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.S3BucketSource, BaseFunction>? S3BucketSource { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-inputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
            /// <summary>
            /// InputFormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-inputformatoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InputFormatOptions
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.InputFormatOptions, BaseFunction>? InputFormatOptions { get; set; }
            /// <summary>
            /// InputCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-inputcompressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputCompressionType { get; set; }
        }

        public class InputFormatOptions : Humidifier.Base.BaseSubResource, IHaveDynamoDBTableTypesCsvCsv
        {
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-inputformatoptions.html#cfn-dynamodb-table-inputformatoptions-csv
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Csv
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.Csv, BaseFunction>? Csv { get; set; }
        }

        public class KeySchema : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveAttributeName
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-keyschema.html#cfn-dynamodb-table-keyschema-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-keyschema.html#cfn-dynamodb-table-keyschema-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class KinesisStreamSpecification : Humidifier.Base.BaseSubResource, IHaveApproximateCreationDateTimePrecision, IHaveStreamArn
        {
            /// <summary>
            /// ApproximateCreationDateTimePrecision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-kinesisstreamspecification.html#cfn-dynamodb-table-kinesisstreamspecification-approximatecreationdatetimeprecision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApproximateCreationDateTimePrecision { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-kinesisstreamspecification.html#cfn-dynamodb-table-kinesisstreamspecification-streamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamArn { get; set; }
        }

        public class LocalSecondaryIndex : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBTableTypesProjectionProjection, IHaveListOfDynamoDBTableTypesKeySchemaKeySchema
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-localsecondaryindex.html#cfn-dynamodb-table-localsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-localsecondaryindex.html#cfn-dynamodb-table-localsecondaryindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.Projection, BaseFunction>? Projection { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-localsecondaryindex.html#cfn-dynamodb-table-localsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.KeySchema>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.KeySchema, BaseFunction>>, BaseFunction>? KeySchema { get; set; }
        }

        public class OnDemandThroughput : Humidifier.Base.BaseSubResource, IHaveMaxReadRequestUnits_Integer, IHaveMaxWriteRequestUnits_Integer
        {
            /// <summary>
            /// MaxReadRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ondemandthroughput.html#cfn-dynamodb-table-ondemandthroughput-maxreadrequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxReadRequestUnits { get; set; }
            /// <summary>
            /// MaxWriteRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ondemandthroughput.html#cfn-dynamodb-table-ondemandthroughput-maxwriterequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxWriteRequestUnits { get; set; }
        }

        public class PointInTimeRecoverySpecification : Humidifier.Base.BaseSubResource, IHavePointInTimeRecoveryEnabled_Boolean, IHaveRecoveryPeriodInDays_Integer
        {
            /// <summary>
            /// PointInTimeRecoveryEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-pointintimerecoveryspecification.html#cfn-dynamodb-table-pointintimerecoveryspecification-pointintimerecoveryenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PointInTimeRecoveryEnabled { get; set; }
            /// <summary>
            /// RecoveryPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-pointintimerecoveryspecification.html#cfn-dynamodb-table-pointintimerecoveryspecification-recoveryperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecoveryPeriodInDays { get; set; }
        }

        public class Projection : Humidifier.Base.BaseSubResource, IHaveProjectionType, IHaveStringListOfNonKeyAttributes
        {
            /// <summary>
            /// ProjectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-projection.html#cfn-dynamodb-table-projection-projectiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectionType { get; set; }
            /// <summary>
            /// NonKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-projection.html#cfn-dynamodb-table-projection-nonkeyattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NonKeyAttributes { get; set; }
        }

        public class ProvisionedThroughput : Humidifier.Base.BaseSubResource, IHaveWriteCapacityUnits_Integer, IHaveReadCapacityUnits_Integer
        {
            /// <summary>
            /// WriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-provisionedthroughput.html#cfn-dynamodb-table-provisionedthroughput-writecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteCapacityUnits { get; set; }
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-provisionedthroughput.html#cfn-dynamodb-table-provisionedthroughput-readcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadCapacityUnits { get; set; }
        }

        public class ResourcePolicy : Humidifier.Base.BaseSubResource, IHavePolicyDocument_Json
        {
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-resourcepolicy.html#cfn-dynamodb-table-resourcepolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PolicyDocument { get; set; }
        }

        public class S3BucketSource : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3KeyPrefix, IHaveS3BucketOwner
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-s3bucketsource.html#cfn-dynamodb-table-s3bucketsource-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-s3bucketsource.html#cfn-dynamodb-table-s3bucketsource-s3keyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-s3bucketsource.html#cfn-dynamodb-table-s3bucketsource-s3bucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketOwner { get; set; }
        }

        public class SSESpecification : Humidifier.Base.BaseSubResource, IHaveSSEEnabled_Boolean, IHaveSSEType, IHaveKMSMasterKeyId
        {
            /// <summary>
            /// SSEEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-sseenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SSEEnabled { get; set; }
            /// <summary>
            /// SSEType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-ssetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEType { get; set; }
            /// <summary>
            /// KMSMasterKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-kmsmasterkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSMasterKeyId { get; set; }
        }

        public class SearchSchemaElement : Humidifier.Base.BaseSubResource, IHaveAttributeName, IHaveSearchSchemaElementType
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-searchschemaelement.html#cfn-dynamodb-table-searchschemaelement-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
            /// <summary>
            /// SearchSchemaElementType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-searchschemaelement.html#cfn-dynamodb-table-searchschemaelement-searchschemaelementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchSchemaElementType { get; set; }
        }

        public class StreamSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveStreamViewType, IHaveDynamoDBTableTypesResourcePolicyResourcePolicy
        {
            /// <summary>
            /// StreamViewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-streamspecification.html#cfn-dynamodb-table-streamspecification-streamviewtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamViewType { get; set; }
            /// <summary>
            /// ResourcePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-streamspecification.html#cfn-dynamodb-table-streamspecification-resourcepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourcePolicy
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.ResourcePolicy, BaseFunction>? ResourcePolicy { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-streamspecification.html#cfn-dynamodb-table-streamspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class TimeToLiveSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveAttributeName
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-timetolivespecification.html#cfn-dynamodb-table-timetolivespecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-timetolivespecification.html#cfn-dynamodb-table-timetolivespecification-attributename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class VectorAttribute : Humidifier.Base.BaseSubResource, IHaveAttributeName
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorattribute.html#cfn-dynamodb-table-vectorattribute-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class VectorIndex : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBTableTypesVectorAttributeVectorAttribute, IHaveDynamoDBTableTypesProjectionProjection, IHaveDimensions_Integer, IHaveListOfDynamoDBTableTypesSearchSchemaElementSearchSchema, IHaveDistanceFunction
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorindex.html#cfn-dynamodb-table-vectorindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// VectorAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorindex.html#cfn-dynamodb-table-vectorindex-vectorattribute
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VectorAttribute
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.VectorAttribute, BaseFunction>? VectorAttribute { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorindex.html#cfn-dynamodb-table-vectorindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Union<Humidifier.DynamoDB.TableTypes.Projection, BaseFunction>? Projection { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorindex.html#cfn-dynamodb-table-vectorindex-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// SearchSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorindex.html#cfn-dynamodb-table-vectorindex-searchschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SearchSchemaElement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.TableTypes.SearchSchemaElement>, IReadOnlyList<Union<Humidifier.DynamoDB.TableTypes.SearchSchemaElement, BaseFunction>>, BaseFunction>? SearchSchema { get; set; }
            /// <summary>
            /// DistanceFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-vectorindex.html#cfn-dynamodb-table-vectorindex-distancefunction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DistanceFunction { get; set; }
        }

        public class WarmThroughput : Humidifier.Base.BaseSubResource, IHaveReadUnitsPerSecond_Integer, IHaveWriteUnitsPerSecond_Integer
        {
            /// <summary>
            /// ReadUnitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-warmthroughput.html#cfn-dynamodb-table-warmthroughput-readunitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadUnitsPerSecond { get; set; }
            /// <summary>
            /// WriteUnitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-warmthroughput.html#cfn-dynamodb-table-warmthroughput-writeunitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteUnitsPerSecond { get; set; }
        }
    }
}