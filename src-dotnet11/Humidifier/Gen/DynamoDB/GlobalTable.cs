namespace Humidifier.DynamoDB
{
    using global::System.Collections.Generic;
    using GlobalTableTypes;

    public class GlobalTable : Humidifier.Base.BaseResource, IHaveMultiRegionConsistency, IHaveDynamoDBGlobalTableTypesSSESpecificationSSESpecification, IHaveTableType, IHaveDynamoDBGlobalTableTypesStreamSpecificationStreamSpecification, IHaveDynamoDBGlobalTableTypesWarmThroughputWarmThroughput, IHaveListOfDynamoDBGlobalTableTypesVectorIndexVectorIndexes, IHaveListOfDynamoDBGlobalTableTypesReplicaSpecificationReplicas, IHaveDynamoDBGlobalTableTypesWriteProvisionedThroughputSettingsWriteProvisionedThroughputSettings, IHaveGlobalTableSourceArn, IHaveDynamoDBGlobalTableTypesWriteOnDemandThroughputSettingsWriteOnDemandThroughputSettings, IHaveListOfDynamoDBGlobalTableTypesGlobalTableWitnessGlobalTableWitnesses, IHaveTableName, IHaveListOfDynamoDBGlobalTableTypesAttributeDefinitionAttributeDefinitions, IHaveBillingMode, IHaveListOfDynamoDBGlobalTableTypesGlobalSecondaryIndexGlobalSecondaryIndexes, IHaveListOfDynamoDBGlobalTableTypesKeySchemaKeySchema, IHaveListOfDynamoDBGlobalTableTypesLocalSecondaryIndexLocalSecondaryIndexes, IHaveDynamoDBGlobalTableTypesGlobalReadProvisionedThroughputSettingsReadProvisionedThroughputSettings, IHaveDynamoDBGlobalTableTypesReadOnDemandThroughputSettingsReadOnDemandThroughputSettings, IHaveDynamoDBGlobalTableTypesTimeToLiveSpecificationTimeToLiveSpecification
    {
        public class Attributes
        {
            public static string TableId =  "TableId" ;
            public static string Arn =  "Arn" ;
            public static string StreamArn =  "StreamArn" ;
        }

        public override string AWSTypeName { get => AWS.DynamoDB.GlobalTable; }
        /// <summary>
        /// MultiRegionConsistency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-multiregionconsistency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MultiRegionConsistency { get; set; }
        /// <summary>
        /// SSESpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SSESpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.SSESpecification, BaseFunction>? SSESpecification { get; set; }
        /// <summary>
        /// TableType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-tabletype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TableType { get; set; }
        /// <summary>
        /// StreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-streamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.StreamSpecification, BaseFunction>? StreamSpecification { get; set; }
        /// <summary>
        /// WarmThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-warmthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WarmThroughput
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput, BaseFunction>? WarmThroughput { get; set; }
        /// <summary>
        /// VectorIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-vectorindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VectorIndex
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.VectorIndex>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.VectorIndex, BaseFunction>>, BaseFunction>? VectorIndexes { get; set; }

        /// <summary>
        /// Replicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-replicas
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ReplicaSpecification
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.ReplicaSpecification>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.ReplicaSpecification, BaseFunction>>, BaseFunction>? Replicas { get; set; }
        /// <summary>
        /// WriteProvisionedThroughputSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-writeprovisionedthroughputsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WriteProvisionedThroughputSettings
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings, BaseFunction>? WriteProvisionedThroughputSettings { get; set; }
        /// <summary>
        /// GlobalTableSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-globaltablesourcearn
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlobalTableSourceArn { get; set; }
        /// <summary>
        /// WriteOnDemandThroughputSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-writeondemandthroughputsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WriteOnDemandThroughputSettings
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings, BaseFunction>? WriteOnDemandThroughputSettings { get; set; }
        /// <summary>
        /// GlobalTableWitnesses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-globaltablewitnesses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalTableWitness
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness, BaseFunction>>, BaseFunction>? GlobalTableWitnesses { get; set; }
        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TableName { get; set; }
        /// <summary>
        /// AttributeDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-attributedefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AttributeDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition, BaseFunction>>, BaseFunction>? AttributeDefinitions { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingMode { get; set; }
        /// <summary>
        /// GlobalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-globalsecondaryindexes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalSecondaryIndex
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex, BaseFunction>>, BaseFunction>? GlobalSecondaryIndexes { get; set; }
        /// <summary>
        /// KeySchema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-keyschema
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: KeySchema
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.KeySchema>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.KeySchema, BaseFunction>>, BaseFunction>? KeySchema { get; set; }
        /// <summary>
        /// LocalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-localsecondaryindexes
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: LocalSecondaryIndex
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex, BaseFunction>>, BaseFunction>? LocalSecondaryIndexes { get; set; }
        /// <summary>
        /// ReadProvisionedThroughputSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-readprovisionedthroughputsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GlobalReadProvisionedThroughputSettings
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings, BaseFunction>? ReadProvisionedThroughputSettings { get; set; }
        /// <summary>
        /// ReadOnDemandThroughputSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-readondemandthroughputsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReadOnDemandThroughputSettings
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings, BaseFunction>? ReadOnDemandThroughputSettings { get; set; }
        /// <summary>
        /// TimeToLiveSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html#cfn-dynamodb-globaltable-timetolivespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeToLiveSpecification
        /// </summary>
        public Union<Humidifier.DynamoDB.GlobalTableTypes.TimeToLiveSpecification, BaseFunction>? TimeToLiveSpecification { get; set; }
    }

    namespace GlobalTableTypes
    {
        public class AttributeDefinition : Humidifier.Base.BaseSubResource, IHaveAttributeType, IHaveAttributeName
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-attributedefinition.html#cfn-dynamodb-globaltable-attributedefinition-attributetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-attributedefinition.html#cfn-dynamodb-globaltable-attributedefinition-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class CapacityAutoScalingSettings : Humidifier.Base.BaseSubResource, IHaveMinCapacity_Integer, IHaveSeedCapacity_Integer, IHaveDynamoDBGlobalTableTypesTargetTrackingScalingPolicyConfigurationTargetTrackingScalingPolicyConfiguration, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacity { get; set; }
            /// <summary>
            /// SeedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-seedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SeedCapacity { get; set; }
            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-targettrackingscalingpolicyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TargetTrackingScalingPolicyConfiguration
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration, BaseFunction>? TargetTrackingScalingPolicyConfiguration { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html#cfn-dynamodb-globaltable-capacityautoscalingsettings-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }

        public class ContributorInsightsSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveMode
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-contributorinsightsspecification.html#cfn-dynamodb-globaltable-contributorinsightsspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-contributorinsightsspecification.html#cfn-dynamodb-globaltable-contributorinsightsspecification-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class GlobalReadProvisionedThroughputSettings : Humidifier.Base.BaseSubResource, IHaveReadCapacityUnits_Integer
        {
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalreadprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-globalreadprovisionedthroughputsettings-readcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadCapacityUnits { get; set; }
        }

        public class GlobalSecondaryIndex : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBGlobalTableTypesProjectionProjection, IHaveListOfDynamoDBGlobalTableTypesKeySchemaKeySchema, IHaveDynamoDBGlobalTableTypesWarmThroughputWarmThroughput, IHaveDynamoDBGlobalTableTypesGlobalReadProvisionedThroughputSettingsReadProvisionedThroughputSettings, IHaveDynamoDBGlobalTableTypesWriteProvisionedThroughputSettingsWriteProvisionedThroughputSettings, IHaveDynamoDBGlobalTableTypesReadOnDemandThroughputSettingsReadOnDemandThroughputSettings, IHaveDynamoDBGlobalTableTypesWriteOnDemandThroughputSettingsWriteOnDemandThroughputSettings
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.Projection, BaseFunction>? Projection { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.KeySchema>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.KeySchema, BaseFunction>>, BaseFunction>? KeySchema { get; set; }
            /// <summary>
            /// WarmThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-warmthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WarmThroughput
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput, BaseFunction>? WarmThroughput { get; set; }
            /// <summary>
            /// ReadProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-readprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlobalReadProvisionedThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings, BaseFunction>? ReadProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// WriteProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-writeprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WriteProvisionedThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings, BaseFunction>? WriteProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// ReadOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-readondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadOnDemandThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings, BaseFunction>? ReadOnDemandThroughputSettings { get; set; }
            /// <summary>
            /// WriteOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html#cfn-dynamodb-globaltable-globalsecondaryindex-writeondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WriteOnDemandThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings, BaseFunction>? WriteOnDemandThroughputSettings { get; set; }
        }

        public class GlobalTableWitness : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globaltablewitness.html#cfn-dynamodb-globaltable-globaltablewitness-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class KeySchema : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveAttributeName
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-keyschema.html#cfn-dynamodb-globaltable-keyschema-keytype
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-keyschema.html#cfn-dynamodb-globaltable-keyschema-attributename
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class KinesisStreamSpecification : Humidifier.Base.BaseSubResource, IHaveApproximateCreationDateTimePrecision, IHaveStreamArn
        {
            /// <summary>
            /// ApproximateCreationDateTimePrecision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-kinesisstreamspecification.html#cfn-dynamodb-globaltable-kinesisstreamspecification-approximatecreationdatetimeprecision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApproximateCreationDateTimePrecision { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-kinesisstreamspecification.html#cfn-dynamodb-globaltable-kinesisstreamspecification-streamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamArn { get; set; }
        }

        public class LocalSecondaryIndex : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBGlobalTableTypesProjectionProjection, IHaveListOfDynamoDBGlobalTableTypesKeySchemaKeySchema
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-localsecondaryindex.html#cfn-dynamodb-globaltable-localsecondaryindex-indexname
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-localsecondaryindex.html#cfn-dynamodb-globaltable-localsecondaryindex-projection
            /// Required: True
            /// UpdateType: Conditional
            /// Type: Projection
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.Projection, BaseFunction>? Projection { get; set; }
            /// <summary>
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-localsecondaryindex.html#cfn-dynamodb-globaltable-localsecondaryindex-keyschema
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.KeySchema>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.KeySchema, BaseFunction>>, BaseFunction>? KeySchema { get; set; }
        }

        public class PointInTimeRecoverySpecification : Humidifier.Base.BaseSubResource, IHavePointInTimeRecoveryEnabled_Boolean, IHaveRecoveryPeriodInDays_Integer
        {
            /// <summary>
            /// PointInTimeRecoveryEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-pointintimerecoveryspecification.html#cfn-dynamodb-globaltable-pointintimerecoveryspecification-pointintimerecoveryenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PointInTimeRecoveryEnabled { get; set; }
            /// <summary>
            /// RecoveryPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-pointintimerecoveryspecification.html#cfn-dynamodb-globaltable-pointintimerecoveryspecification-recoveryperiodindays
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-projection.html#cfn-dynamodb-globaltable-projection-projectiontype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectionType { get; set; }
            /// <summary>
            /// NonKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-projection.html#cfn-dynamodb-globaltable-projection-nonkeyattributes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NonKeyAttributes { get; set; }
        }

        public class ReadOnDemandThroughputSettings : Humidifier.Base.BaseSubResource, IHaveMaxReadRequestUnits_Integer
        {
            /// <summary>
            /// MaxReadRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readondemandthroughputsettings.html#cfn-dynamodb-globaltable-readondemandthroughputsettings-maxreadrequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxReadRequestUnits { get; set; }
        }

        public class ReadProvisionedThroughputSettings : Humidifier.Base.BaseSubResource, IHaveDynamoDBGlobalTableTypesCapacityAutoScalingSettingsReadCapacityAutoScalingSettings, IHaveReadCapacityUnits_Integer
        {
            /// <summary>
            /// ReadCapacityAutoScalingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-readprovisionedthroughputsettings-readcapacityautoscalingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityAutoScalingSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings, BaseFunction>? ReadCapacityAutoScalingSettings { get; set; }
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-readprovisionedthroughputsettings-readcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadCapacityUnits { get; set; }
        }

        public class ReplicaGlobalSecondaryIndexSpecification : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBGlobalTableTypesContributorInsightsSpecificationContributorInsightsSpecification, IHaveDynamoDBGlobalTableTypesReadProvisionedThroughputSettingsReadProvisionedThroughputSettings, IHaveDynamoDBGlobalTableTypesReadOnDemandThroughputSettingsReadOnDemandThroughputSettings
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// ContributorInsightsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-contributorinsightsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContributorInsightsSpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification, BaseFunction>? ContributorInsightsSpecification { get; set; }
            /// <summary>
            /// ReadProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-readprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadProvisionedThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings, BaseFunction>? ReadProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// ReadOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html#cfn-dynamodb-globaltable-replicaglobalsecondaryindexspecification-readondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadOnDemandThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings, BaseFunction>? ReadOnDemandThroughputSettings { get; set; }
        }

        public class ReplicaSSESpecification : Humidifier.Base.BaseSubResource, IHaveKMSMasterKeyId
        {
            /// <summary>
            /// KMSMasterKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicassespecification.html#cfn-dynamodb-globaltable-replicassespecification-kmsmasterkeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSMasterKeyId { get; set; }
        }

        public class ReplicaSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveDynamoDBGlobalTableTypesReplicaSSESpecificationSSESpecification, IHaveDynamoDBGlobalTableTypesKinesisStreamSpecificationKinesisStreamSpecification, IHaveDynamoDBGlobalTableTypesContributorInsightsSpecificationContributorInsightsSpecification, IHaveGlobalTableSettingsReplicationMode, IHaveDynamoDBGlobalTableTypesPointInTimeRecoverySpecificationPointInTimeRecoverySpecification, IHaveDisassociationProtectionEnabled_Boolean, IHaveDynamoDBGlobalTableTypesReplicaStreamSpecificationReplicaStreamSpecification, IHaveListOfDynamoDBGlobalTableTypesReplicaGlobalSecondaryIndexSpecificationGlobalSecondaryIndexes, IHaveRegion, IHaveDynamoDBGlobalTableTypesResourcePolicyResourcePolicy, IHaveDynamoDBGlobalTableTypesReadProvisionedThroughputSettingsReadProvisionedThroughputSettings, IHaveTableClass, IHaveDeletionProtectionEnabled_Boolean, IHaveDynamoDBGlobalTableTypesReadOnDemandThroughputSettingsReadOnDemandThroughputSettings
        {
            /// <summary>
            /// SSESpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-ssespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaSSESpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReplicaSSESpecification, BaseFunction>? SSESpecification { get; set; }
            /// <summary>
            /// KinesisStreamSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-kinesisstreamspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamSpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.KinesisStreamSpecification, BaseFunction>? KinesisStreamSpecification { get; set; }
            /// <summary>
            /// ContributorInsightsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-contributorinsightsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContributorInsightsSpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification, BaseFunction>? ContributorInsightsSpecification { get; set; }
            /// <summary>
            /// GlobalTableSettingsReplicationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-globaltablesettingsreplicationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlobalTableSettingsReplicationMode { get; set; }
            /// <summary>
            /// PointInTimeRecoverySpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-pointintimerecoveryspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PointInTimeRecoverySpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification, BaseFunction>? PointInTimeRecoverySpecification { get; set; }
            /// <summary>
            /// DisassociationProtectionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-disassociationprotectionenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisassociationProtectionEnabled { get; set; }
            /// <summary>
            /// ReplicaStreamSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-replicastreamspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaStreamSpecification
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification, BaseFunction>? ReplicaStreamSpecification { get; set; }
            /// <summary>
            /// GlobalSecondaryIndexes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-globalsecondaryindexes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicaGlobalSecondaryIndexSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.ReplicaGlobalSecondaryIndexSpecification>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.ReplicaGlobalSecondaryIndexSpecification, BaseFunction>>, BaseFunction>? GlobalSecondaryIndexes { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// ResourcePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-resourcepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourcePolicy
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy, BaseFunction>? ResourcePolicy { get; set; }
            /// <summary>
            /// ReadProvisionedThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-readprovisionedthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadProvisionedThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings, BaseFunction>? ReadProvisionedThroughputSettings { get; set; }
            /// <summary>
            /// TableClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-tableclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableClass { get; set; }
            /// <summary>
            /// DeletionProtectionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-deletionprotectionenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// ReadOnDemandThroughputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html#cfn-dynamodb-globaltable-replicaspecification-readondemandthroughputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadOnDemandThroughputSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings, BaseFunction>? ReadOnDemandThroughputSettings { get; set; }
        }

        public class ReplicaStreamSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveDynamoDBGlobalTableTypesResourcePolicyResourcePolicy
        {
            /// <summary>
            /// ResourcePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicastreamspecification.html#cfn-dynamodb-globaltable-replicastreamspecification-resourcepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourcePolicy
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy, BaseFunction>? ResourcePolicy { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicastreamspecification.html#cfn-dynamodb-globaltable-replicastreamspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class ResourcePolicy : Humidifier.Base.BaseSubResource, IHavePolicyDocument_Json
        {
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-resourcepolicy.html#cfn-dynamodb-globaltable-resourcepolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PolicyDocument { get; set; }
        }

        public class SSESpecification : Humidifier.Base.BaseSubResource, IHaveSSEEnabled_Boolean, IHaveSSEType
        {
            /// <summary>
            /// SSEEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-ssespecification.html#cfn-dynamodb-globaltable-ssespecification-sseenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SSEEnabled { get; set; }
            /// <summary>
            /// SSEType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-ssespecification.html#cfn-dynamodb-globaltable-ssespecification-ssetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEType { get; set; }
        }

        public class SearchSchemaElement : Humidifier.Base.BaseSubResource, IHaveAttributeName, IHaveSearchSchemaElementType
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-searchschemaelement.html#cfn-dynamodb-globaltable-searchschemaelement-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
            /// <summary>
            /// SearchSchemaElementType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-searchschemaelement.html#cfn-dynamodb-globaltable-searchschemaelement-searchschemaelementtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchSchemaElementType { get; set; }
        }

        public class StreamSpecification : Humidifier.Base.BaseSubResource, IHaveStreamViewType
        {
            /// <summary>
            /// StreamViewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-streamspecification.html#cfn-dynamodb-globaltable-streamspecification-streamviewtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamViewType { get; set; }
        }

        public class TargetTrackingScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveScaleOutCooldown_Integer, IHaveTargetValue_Double, IHaveDisableScaleIn_Boolean, IHaveScaleInCooldown_Integer
        {
            /// <summary>
            /// ScaleOutCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-scaleoutcooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleOutCooldown { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableScaleIn { get; set; }
            /// <summary>
            /// ScaleInCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-targettrackingscalingpolicyconfiguration.html#cfn-dynamodb-globaltable-targettrackingscalingpolicyconfiguration-scaleincooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInCooldown { get; set; }
        }

        public class TimeToLiveSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveAttributeName
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-timetolivespecification.html#cfn-dynamodb-globaltable-timetolivespecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-timetolivespecification.html#cfn-dynamodb-globaltable-timetolivespecification-attributename
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorattribute.html#cfn-dynamodb-globaltable-vectorattribute-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class VectorIndex : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDynamoDBGlobalTableTypesVectorAttributeVectorAttribute, IHaveDynamoDBGlobalTableTypesProjectionProjection, IHaveDimensions_Integer, IHaveListOfDynamoDBGlobalTableTypesSearchSchemaElementSearchSchema, IHaveDistanceFunction
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorindex.html#cfn-dynamodb-globaltable-vectorindex-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// VectorAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorindex.html#cfn-dynamodb-globaltable-vectorindex-vectorattribute
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VectorAttribute
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute, BaseFunction>? VectorAttribute { get; set; }
            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorindex.html#cfn-dynamodb-globaltable-vectorindex-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.Projection, BaseFunction>? Projection { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorindex.html#cfn-dynamodb-globaltable-vectorindex-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// SearchSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorindex.html#cfn-dynamodb-globaltable-vectorindex-searchschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SearchSchemaElement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DynamoDB.GlobalTableTypes.SearchSchemaElement>, IReadOnlyList<Union<Humidifier.DynamoDB.GlobalTableTypes.SearchSchemaElement, BaseFunction>>, BaseFunction>? SearchSchema { get; set; }
            /// <summary>
            /// DistanceFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-vectorindex.html#cfn-dynamodb-globaltable-vectorindex-distancefunction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-warmthroughput.html#cfn-dynamodb-globaltable-warmthroughput-readunitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadUnitsPerSecond { get; set; }
            /// <summary>
            /// WriteUnitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-warmthroughput.html#cfn-dynamodb-globaltable-warmthroughput-writeunitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteUnitsPerSecond { get; set; }
        }

        public class WriteOnDemandThroughputSettings : Humidifier.Base.BaseSubResource, IHaveMaxWriteRequestUnits_Integer
        {
            /// <summary>
            /// MaxWriteRequestUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-writeondemandthroughputsettings.html#cfn-dynamodb-globaltable-writeondemandthroughputsettings-maxwriterequestunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxWriteRequestUnits { get; set; }
        }

        public class WriteProvisionedThroughputSettings : Humidifier.Base.BaseSubResource, IHaveDynamoDBGlobalTableTypesCapacityAutoScalingSettingsWriteCapacityAutoScalingSettings
        {
            /// <summary>
            /// WriteCapacityAutoScalingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-writeprovisionedthroughputsettings.html#cfn-dynamodb-globaltable-writeprovisionedthroughputsettings-writecapacityautoscalingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityAutoScalingSettings
            /// </summary>
            public Union<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings, BaseFunction>? WriteCapacityAutoScalingSettings { get; set; }
        }
    }
}