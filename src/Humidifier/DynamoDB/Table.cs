namespace Humidifier.DynamoDB
{
    using System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string StreamArn =  "StreamArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DynamoDB::Table";
            }
        }

        /// <summary>
        /// OnDemandThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ondemandthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnDemandThroughput
        /// </summary>
        public OnDemandThroughput OnDemandThroughput { get; set; }
        /// <summary>
        /// SSESpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SSESpecification
        /// </summary>
        public SSESpecification SSESpecification { get; set; }
        /// <summary>
        /// KinesisStreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-kinesisstreamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisStreamSpecification
        /// </summary>
        public KinesisStreamSpecification KinesisStreamSpecification { get; set; }
        /// <summary>
        /// StreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-streamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamSpecification
        /// </summary>
        public StreamSpecification StreamSpecification { get; set; }
        /// <summary>
        /// ContributorInsightsSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-contributorinsightsspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContributorInsightsSpecification
        /// </summary>
        public ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }
        /// <summary>
        /// ImportSourceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-importsourcespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImportSourceSpecification
        /// </summary>
        public ImportSourceSpecification ImportSourceSpecification { get; set; }
        /// <summary>
        /// PointInTimeRecoverySpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-pointintimerecoveryspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PointInTimeRecoverySpecification
        /// </summary>
        public PointInTimeRecoverySpecification PointInTimeRecoverySpecification { get; set; }
        /// <summary>
        /// ProvisionedThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-provisionedthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedThroughput
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput { get; set; }
        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TableName { get; set; }
        /// <summary>
        /// AttributeDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-attributedefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AttributeDefinition
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BillingMode { get; set; }
        /// <summary>
        /// GlobalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-globalsecondaryindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalSecondaryIndex
        /// </summary>
        public List<GlobalSecondaryIndex> GlobalSecondaryIndexes { get; set; }
        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-resourcepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourcePolicy
        /// </summary>
        public ResourcePolicy ResourcePolicy { get; set; }
        /// <summary>
        /// KeySchema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-keyschema
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: KeySchema
        /// </summary>
        public List<KeySchema> KeySchema { get; set; }
        /// <summary>
        /// LocalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-localsecondaryindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LocalSecondaryIndex
        /// </summary>
        public List<LocalSecondaryIndex> LocalSecondaryIndexes { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// TableClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tableclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TableClass { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// TimeToLiveSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-timetolivespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeToLiveSpecification
        /// </summary>
        public TimeToLiveSpecification TimeToLiveSpecification { get; set; }
    }

    namespace TableTypes
    {
        public class AttributeDefinition
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-attributedefinition.html#cfn-dynamodb-table-attributedefinition-attributetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-attributedefinition.html#cfn-dynamodb-table-attributedefinition-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class ContributorInsightsSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-contributorinsightsspecification.html#cfn-dynamodb-table-contributorinsightsspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class Csv
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-csv.html#cfn-dynamodb-table-csv-delimiter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// HeaderList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-csv.html#cfn-dynamodb-table-csv-headerlist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HeaderList { get; set; }
        }

        public class GlobalSecondaryIndex
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// OnDemandThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-ondemandthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandThroughput
            /// </summary>
            public OnDemandThroughput OnDemandThroughput { get; set; }
            /// <summary>
            /// ContributorInsightsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-contributorinsightsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContributorInsightsSpecification
            /// </summary>
            public ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Projection Projection { get; set; }
            /// <summary>
            /// ProvisionedThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-provisionedthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedThroughput
            /// </summary>
            public ProvisionedThroughput ProvisionedThroughput { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-globalsecondaryindex.html#cfn-dynamodb-table-globalsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public List<KeySchema> KeySchema { get; set; }
        }

        public class ImportSourceSpecification
        {
            /// <summary>
            /// S3BucketSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-s3bucketsource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3BucketSource
            /// </summary>
            public S3BucketSource S3BucketSource { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-inputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputFormat { get; set; }
            /// <summary>
            /// InputFormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-inputformatoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InputFormatOptions
            /// </summary>
            public InputFormatOptions InputFormatOptions { get; set; }
            /// <summary>
            /// InputCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-importsourcespecification.html#cfn-dynamodb-table-importsourcespecification-inputcompressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputCompressionType { get; set; }
        }

        public class InputFormatOptions
        {
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-inputformatoptions.html#cfn-dynamodb-table-inputformatoptions-csv
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Csv
            /// </summary>
            public Csv Csv { get; set; }
        }

        public class KeySchema
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-keyschema.html#cfn-dynamodb-table-keyschema-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-keyschema.html#cfn-dynamodb-table-keyschema-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class KinesisStreamSpecification
        {
            /// <summary>
            /// ApproximateCreationDateTimePrecision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-kinesisstreamspecification.html#cfn-dynamodb-table-kinesisstreamspecification-approximatecreationdatetimeprecision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApproximateCreationDateTimePrecision { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-kinesisstreamspecification.html#cfn-dynamodb-table-kinesisstreamspecification-streamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamArn { get; set; }
        }

        public class LocalSecondaryIndex
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-localsecondaryindex.html#cfn-dynamodb-table-localsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-localsecondaryindex.html#cfn-dynamodb-table-localsecondaryindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Projection Projection { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-localsecondaryindex.html#cfn-dynamodb-table-localsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public List<KeySchema> KeySchema { get; set; }
        }

        public class OnDemandThroughput
        {
            /// <summary>
            /// MaxReadRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ondemandthroughput.html#cfn-dynamodb-table-ondemandthroughput-maxreadrequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxReadRequestUnits { get; set; }
            /// <summary>
            /// MaxWriteRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ondemandthroughput.html#cfn-dynamodb-table-ondemandthroughput-maxwriterequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxWriteRequestUnits { get; set; }
        }

        public class PointInTimeRecoverySpecification
        {
            /// <summary>
            /// PointInTimeRecoveryEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-pointintimerecoveryspecification.html#cfn-dynamodb-table-pointintimerecoveryspecification-pointintimerecoveryenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PointInTimeRecoveryEnabled { get; set; }
        }

        public class Projection
        {
            /// <summary>
            /// NonKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-projection.html#cfn-dynamodb-table-projection-nonkeyattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NonKeyAttributes { get; set; }
            /// <summary>
            /// ProjectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-projection.html#cfn-dynamodb-table-projection-projectiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProjectionType { get; set; }
        }

        public class ProvisionedThroughput
        {
            /// <summary>
            /// WriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-provisionedthroughput.html#cfn-dynamodb-table-provisionedthroughput-writecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WriteCapacityUnits { get; set; }
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-provisionedthroughput.html#cfn-dynamodb-table-provisionedthroughput-readcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReadCapacityUnits { get; set; }
        }

        public class ResourcePolicy
        {
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-resourcepolicy.html#cfn-dynamodb-table-resourcepolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic PolicyDocument { get; set; }
        }

        public class S3BucketSource
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-s3bucketsource.html#cfn-dynamodb-table-s3bucketsource-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket { get; set; }
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-s3bucketsource.html#cfn-dynamodb-table-s3bucketsource-s3keyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KeyPrefix { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-s3bucketsource.html#cfn-dynamodb-table-s3bucketsource-s3bucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketOwner { get; set; }
        }

        public class SSESpecification
        {
            /// <summary>
            /// SSEEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-sseenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SSEEnabled { get; set; }
            /// <summary>
            /// SSEType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-ssetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SSEType { get; set; }
            /// <summary>
            /// KMSMasterKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-kmsmasterkeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSMasterKeyId { get; set; }
        }

        public class StreamSpecification
        {
            /// <summary>
            /// StreamViewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-streamspecification.html#cfn-dynamodb-table-streamspecification-streamviewtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamViewType { get; set; }
            /// <summary>
            /// ResourcePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-streamspecification.html#cfn-dynamodb-table-streamspecification-resourcepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourcePolicy
            /// </summary>
            public ResourcePolicy ResourcePolicy { get; set; }
        }

        public class TimeToLiveSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-timetolivespecification.html#cfn-dynamodb-table-timetolivespecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-timetolivespecification.html#cfn-dynamodb-table-timetolivespecification-attributename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }
    }
}