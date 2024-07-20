namespace Humidifier.DynamoDB
{
    using System.Collections.Generic;
    using GlobalTableTypes;

    public class GlobalTable : Humidifier.Resource
    {
        public class Attributes
        {
            public static string TableId =  "TableId" ;
            public static string Arn =  "Arn" ;
            public static string StreamArn =  "StreamArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DynamoDB::GlobalTable";
            }
        }

        /// <summary>
        /// SSESpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SSESpecification
        /// </summary>
        public SSESpecification SSESpecification { get; set; }
        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TableName { get; set; }
        /// <summary>
        /// AttributeDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-attributedefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AttributeDefinition
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions { get; set; }
        /// <summary>
        /// StreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-streamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamSpecification
        /// </summary>
        public StreamSpecification StreamSpecification { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BillingMode { get; set; }
        /// <summary>
        /// GlobalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-globalsecondaryindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalSecondaryIndex
        /// </summary>
        public List<GlobalSecondaryIndex> GlobalSecondaryIndexes { get; set; }
        /// <summary>
        /// KeySchema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-keyschema
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: KeySchema
        /// </summary>
        public List<KeySchema> KeySchema { get; set; }
        /// <summary>
        /// LocalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-localsecondaryindexes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LocalSecondaryIndex
        /// </summary>
        public List<LocalSecondaryIndex> LocalSecondaryIndexes { get; set; }
        /// <summary>
        /// Replicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-replicas
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ReplicaSpecification
        /// </summary>
        public List<ReplicaSpecification> Replicas { get; set; }
        /// <summary>
        /// WriteProvisionedThroughputSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-writeprovisionedthroughputsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WriteProvisionedThroughputSettings
        /// </summary>
        public WriteProvisionedThroughputSettings WriteProvisionedThroughputSettings { get; set; }
        /// <summary>
        /// TimeToLiveSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-timetolivespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeToLiveSpecification
        /// </summary>
        public TimeToLiveSpecification TimeToLiveSpecification { get; set; }
        /// <summary>
        /// WriteOnDemandThroughputSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-writeondemandthroughputsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WriteOnDemandThroughputSettings
        /// </summary>
        public WriteOnDemandThroughputSettings WriteOnDemandThroughputSettings { get; set; }
    }

    namespace GlobalTableTypes
    {
        public class AttributeDefinition
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-attributedefinition.html#cfn-dynamodb-globaltable-attributedefinition-attributetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-attributedefinition.html#cfn-dynamodb-globaltable-attributedefinition-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class CapacityAutoScalingSettings
        {
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinCapacity { get; set; }
            /// <summary>
            /// SeedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-seedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SeedCapacity { get; set; }
            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-targettrackingscalingpolicyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TargetTrackingScalingPolicyConfiguration
            /// </summary>
            public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacity { get; set; }
        }

        public class ContributorInsightsSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-contributorinsightsspecification.html#cfn-dynamodb-globaltable-contributorinsightsspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class GlobalSecondaryIndex
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Projection Projection { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public List<KeySchema> KeySchema { get; set; }
            /// <summary>
            /// WriteProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-writeprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WriteProvisionedThroughputSettings
            /// </summary>
            public WriteProvisionedThroughputSettings WriteProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// WriteOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-writeondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WriteOnDemandThroughputSettings
            /// </summary>
            public WriteOnDemandThroughputSettings WriteOnDemandThroughputSettings { get; set; }
        }

        public class KeySchema
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-keyschema.html#cfn-dynamodb-globaltable-keyschema-keytype
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-keyschema.html#cfn-dynamodb-globaltable-keyschema-attributename
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class KinesisStreamSpecification
        {
            /// <summary>
            /// ApproximateCreationDateTimePrecision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-kinesisstreamspecification.html#cfn-dynamodb-globaltable-kinesisstreamspecification-approximatecreationdatetimeprecision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApproximateCreationDateTimePrecision { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-kinesisstreamspecification.html#cfn-dynamodb-globaltable-kinesisstreamspecification-streamarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-localsecondaryindex.html#cfn-dynamodb-globaltable-localsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-localsecondaryindex.html#cfn-dynamodb-globaltable-localsecondaryindex-projection
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Projection
            /// </summary>
            public Projection Projection { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-localsecondaryindex.html#cfn-dynamodb-globaltable-localsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public List<KeySchema> KeySchema { get; set; }
        }

        public class PointInTimeRecoverySpecification
        {
            /// <summary>
            /// PointInTimeRecoveryEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-pointintimerecoveryspecification.html#cfn-dynamodb-globaltable-pointintimerecoveryspecification-pointintimerecoveryenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PointInTimeRecoveryEnabled { get; set; }
        }

        public class Projection
        {
            /// <summary>
            /// ProjectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-projection.html#cfn-dynamodb-globaltable-projection-projectiontype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProjectionType { get; set; }
            /// <summary>
            /// NonKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-projection.html#cfn-dynamodb-globaltable-projection-nonkeyattributes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NonKeyAttributes { get; set; }
        }

        public class ReadOnDemandThroughputSettings
        {
            /// <summary>
            /// MaxReadRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readondemandthroughputsettings.html#cfn-dynamodb-globaltable-readondemandthroughputsettings-maxreadrequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxReadRequestUnits { get; set; }
        }

        public class ReadProvisionedThroughputSettings
        {
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-readprovisionedthroughputsettings-readcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReadCapacityUnits { get; set; }
            /// <summary>
            /// ReadCapacityAutoScalingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-readprovisionedthroughputsettings-readcapacityautoscalingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityAutoScalingSettings
            /// </summary>
            public CapacityAutoScalingSettings ReadCapacityAutoScalingSettings { get; set; }
        }

        public class ReplicaGlobalSecondaryIndexSpecification
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// ContributorInsightsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-contributorinsightsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContributorInsightsSpecification
            /// </summary>
            public ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }
            /// <summary>
            /// ReadProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-readprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadProvisionedThroughputSettings
            /// </summary>
            public ReadProvisionedThroughputSettings ReadProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// ReadOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-readondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadOnDemandThroughputSettings
            /// </summary>
            public ReadOnDemandThroughputSettings ReadOnDemandThroughputSettings { get; set; }
        }

        public class ReplicaSSESpecification
        {
            /// <summary>
            /// KMSMasterKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicassespecification.html#cfn-dynamodb-globaltable-replicassespecification-kmsmasterkeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSMasterKeyId { get; set; }
        }

        public class ReplicaSpecification
        {
            /// <summary>
            /// SSESpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-ssespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaSSESpecification
            /// </summary>
            public ReplicaSSESpecification SSESpecification { get; set; }
            /// <summary>
            /// KinesisStreamSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-kinesisstreamspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamSpecification
            /// </summary>
            public KinesisStreamSpecification KinesisStreamSpecification { get; set; }
            /// <summary>
            /// ContributorInsightsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-contributorinsightsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContributorInsightsSpecification
            /// </summary>
            public ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }
            /// <summary>
            /// PointInTimeRecoverySpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-pointintimerecoveryspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PointInTimeRecoverySpecification
            /// </summary>
            public PointInTimeRecoverySpecification PointInTimeRecoverySpecification { get; set; }
            /// <summary>
            /// ReplicaStreamSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-replicastreamspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaStreamSpecification
            /// </summary>
            public ReplicaStreamSpecification ReplicaStreamSpecification { get; set; }
            /// <summary>
            /// GlobalSecondaryIndexes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-globalsecondaryindexes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicaGlobalSecondaryIndexSpecification
            /// </summary>
            public List<ReplicaGlobalSecondaryIndexSpecification> GlobalSecondaryIndexes { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// ResourcePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-resourcepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourcePolicy
            /// </summary>
            public ResourcePolicy ResourcePolicy { get; set; }
            /// <summary>
            /// ReadProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-readprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadProvisionedThroughputSettings
            /// </summary>
            public ReadProvisionedThroughputSettings ReadProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// TableClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-tableclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableClass { get; set; }
            /// <summary>
            /// DeletionProtectionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-deletionprotectionenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeletionProtectionEnabled { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags { get; set; }
            /// <summary>
            /// ReadOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-readondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadOnDemandThroughputSettings
            /// </summary>
            public ReadOnDemandThroughputSettings ReadOnDemandThroughputSettings { get; set; }
        }

        public class ReplicaStreamSpecification
        {
            /// <summary>
            /// ResourcePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicastreamspecification.html#cfn-dynamodb-globaltable-replicastreamspecification-resourcepolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourcePolicy
            /// </summary>
            public ResourcePolicy ResourcePolicy { get; set; }
        }

        public class ResourcePolicy
        {
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-resourcepolicy.html#cfn-dynamodb-globaltable-resourcepolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic PolicyDocument { get; set; }
        }

        public class SSESpecification
        {
            /// <summary>
            /// SSEEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-ssespecification.html#cfn-dynamodb-globaltable-ssespecification-sseenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SSEEnabled { get; set; }
            /// <summary>
            /// SSEType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-ssespecification.html#cfn-dynamodb-globaltable-ssespecification-ssetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SSEType { get; set; }
        }

        public class StreamSpecification
        {
            /// <summary>
            /// StreamViewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-streamspecification.html#cfn-dynamodb-globaltable-streamspecification-streamviewtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamViewType { get; set; }
        }

        public class TargetTrackingScalingPolicyConfiguration
        {
            /// <summary>
            /// ScaleOutCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-scaleoutcooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScaleOutCooldown { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableScaleIn { get; set; }
            /// <summary>
            /// ScaleInCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-scaleincooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScaleInCooldown { get; set; }
        }

        public class TimeToLiveSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-timetolivespecification.html#cfn-dynamodb-globaltable-timetolivespecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-timetolivespecification.html#cfn-dynamodb-globaltable-timetolivespecification-attributename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class WriteOnDemandThroughputSettings
        {
            /// <summary>
            /// MaxWriteRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-writeondemandthroughputsettings.html#cfn-dynamodb-globaltable-writeondemandthroughputsettings-maxwriterequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxWriteRequestUnits { get; set; }
        }

        public class WriteProvisionedThroughputSettings
        {
            /// <summary>
            /// WriteCapacityAutoScalingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-writeprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-writeprovisionedthroughputsettings-writecapacityautoscalingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityAutoScalingSettings
            /// </summary>
            public CapacityAutoScalingSettings WriteCapacityAutoScalingSettings { get; set; }
        }
    }
}