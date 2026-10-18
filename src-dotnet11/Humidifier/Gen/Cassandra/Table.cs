namespace Humidifier.Cassandra
{
    using global::System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfCassandraTableTypesReplicaSpecificationReplicaSpecifications, IHaveListOfCassandraTableTypesClusteringKeyColumnClusteringKeyColumns, IHaveCassandraTableTypesWarmThroughputWarmThroughput, IHaveKeyspaceName, IHaveCassandraTableTypesEncryptionSpecificationEncryptionSpecification, IHaveTableName, IHavePointInTimeRecoveryEnabled_Boolean, IHaveCassandraTableTypesCdcSpecificationCdcSpecification, IHaveCassandraTableTypesAutoScalingSpecificationAutoScalingSpecifications, IHaveClientSideTimestampsEnabled_Boolean, IHaveListOfCassandraTableTypesColumnPartitionKeyColumns, IHaveCassandraTableTypesBillingModeBillingMode, IHaveDefaultTimeToLive_Integer, IHaveListOfCassandraTableTypesColumnRegularColumns
    {
        public override string AWSTypeName { get => AWS.Cassandra.Table; }
        /// <summary>
        /// ReplicaSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-replicaspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ReplicaSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cassandra.TableTypes.ReplicaSpecification>, IReadOnlyList<Union<Humidifier.Cassandra.TableTypes.ReplicaSpecification, BaseFunction>>, BaseFunction>? ReplicaSpecifications { get; set; }
        /// <summary>
        /// ClusteringKeyColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-clusteringkeycolumns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ClusteringKeyColumn
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cassandra.TableTypes.ClusteringKeyColumn>, IReadOnlyList<Union<Humidifier.Cassandra.TableTypes.ClusteringKeyColumn, BaseFunction>>, BaseFunction>? ClusteringKeyColumns { get; set; }
        /// <summary>
        /// WarmThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-warmthroughput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WarmThroughput
        /// </summary>
        public Union<Humidifier.Cassandra.TableTypes.WarmThroughput, BaseFunction>? WarmThroughput { get; set; }

        /// <summary>
        /// KeyspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-keyspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KeyspaceName { get; set; }
        /// <summary>
        /// EncryptionSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-encryptionspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionSpecification
        /// </summary>
        public Union<Humidifier.Cassandra.TableTypes.EncryptionSpecification, BaseFunction>? EncryptionSpecification { get; set; }
        public Union<string, BaseFunction>? TableName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PointInTimeRecoveryEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-pointintimerecoveryenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PointInTimeRecoveryEnabled { get; set; }
        /// <summary>
        /// CdcSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-cdcspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdcSpecification
        /// </summary>
        public Union<Humidifier.Cassandra.TableTypes.CdcSpecification, BaseFunction>? CdcSpecification { get; set; }
        /// <summary>
        /// AutoScalingSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-autoscalingspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoScalingSpecification
        /// </summary>
        public Union<Humidifier.Cassandra.TableTypes.AutoScalingSpecification, BaseFunction>? AutoScalingSpecifications { get; set; }
        /// <summary>
        /// ClientSideTimestampsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-clientsidetimestampsenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ClientSideTimestampsEnabled { get; set; }

        /// <summary>
        /// PartitionKeyColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-partitionkeycolumns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Column
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Cassandra.TableTypes.Column>, IReadOnlyList<Union<Humidifier.Cassandra.TableTypes.Column, BaseFunction>>, BaseFunction>? PartitionKeyColumns { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BillingMode
        /// </summary>
        public Union<Humidifier.Cassandra.TableTypes.BillingMode, BaseFunction>? BillingMode { get; set; }
        /// <summary>
        /// DefaultTimeToLive
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-defaulttimetolive
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DefaultTimeToLive { get; set; }
        /// <summary>
        /// RegularColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-regularcolumns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Column
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cassandra.TableTypes.Column>, IReadOnlyList<Union<Humidifier.Cassandra.TableTypes.Column, BaseFunction>>, BaseFunction>? RegularColumns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TableTypes
    {
        public class AutoScalingSetting : Humidifier.Base.BaseSubResource, IHaveMaximumUnits_Integer, IHaveCassandraTableTypesScalingPolicyScalingPolicy, IHaveMinimumUnits_Integer, IHaveAutoScalingDisabled_Boolean
        {
            /// <summary>
            /// MaximumUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-maximumunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumUnits { get; set; }
            /// <summary>
            /// ScalingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-scalingpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScalingPolicy
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.ScalingPolicy, BaseFunction>? ScalingPolicy { get; set; }
            /// <summary>
            /// MinimumUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-minimumunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumUnits { get; set; }
            /// <summary>
            /// AutoScalingDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-autoscalingdisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoScalingDisabled { get; set; }
        }

        public class AutoScalingSpecification : Humidifier.Base.BaseSubResource, IHaveCassandraTableTypesAutoScalingSettingReadCapacityAutoScaling, IHaveCassandraTableTypesAutoScalingSettingWriteCapacityAutoScaling
        {
            /// <summary>
            /// ReadCapacityAutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingspecification.html#cfn-cassandra-table-autoscalingspecification-readcapacityautoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingSetting
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.AutoScalingSetting, BaseFunction>? ReadCapacityAutoScaling { get; set; }
            /// <summary>
            /// WriteCapacityAutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingspecification.html#cfn-cassandra-table-autoscalingspecification-writecapacityautoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingSetting
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.AutoScalingSetting, BaseFunction>? WriteCapacityAutoScaling { get; set; }
        }

        public class BillingMode : Humidifier.Base.BaseSubResource, IHaveMode, IHaveCassandraTableTypesProvisionedThroughputProvisionedThroughput
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-billingmode.html#cfn-cassandra-table-billingmode-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// ProvisionedThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-billingmode.html#cfn-cassandra-table-billingmode-provisionedthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedThroughput
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.ProvisionedThroughput, BaseFunction>? ProvisionedThroughput { get; set; }
        }

        public class CdcSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveStatus, IHaveViewType
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-cdcspecification.html#cfn-cassandra-table-cdcspecification-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ViewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-cdcspecification.html#cfn-cassandra-table-cdcspecification-viewtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-cdcspecification.html#cfn-cassandra-table-cdcspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class ClusteringKeyColumn : Humidifier.Base.BaseSubResource, IHaveOrderBy, IHaveCassandraTableTypesColumnColumn
        {
            /// <summary>
            /// OrderBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-clusteringkeycolumn.html#cfn-cassandra-table-clusteringkeycolumn-orderby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrderBy { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-clusteringkeycolumn.html#cfn-cassandra-table-clusteringkeycolumn-column
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Column
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.Column, BaseFunction>? Column { get; set; }
        }

        public class Column : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveColumnType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-column.html#cfn-cassandra-table-column-columnname
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// ColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-column.html#cfn-cassandra-table-column-columntype
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnType { get; set; }
        }

        public class EncryptionSpecification : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveKmsKeyIdentifier
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-encryptionspecification.html#cfn-cassandra-table-encryptionspecification-encryptiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// KmsKeyIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-encryptionspecification.html#cfn-cassandra-table-encryptionspecification-kmskeyidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        }

        public class ProvisionedThroughput : Humidifier.Base.BaseSubResource, IHaveWriteCapacityUnits_Integer, IHaveReadCapacityUnits_Integer
        {
            /// <summary>
            /// WriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-provisionedthroughput.html#cfn-cassandra-table-provisionedthroughput-writecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteCapacityUnits { get; set; }
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-provisionedthroughput.html#cfn-cassandra-table-provisionedthroughput-readcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadCapacityUnits { get; set; }
        }

        public class ReplicaSpecification : Humidifier.Base.BaseSubResource, IHaveReadCapacityUnits_Integer, IHaveRegion, IHaveCassandraTableTypesAutoScalingSettingReadCapacityAutoScaling
        {
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-replicaspecification.html#cfn-cassandra-table-replicaspecification-readcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadCapacityUnits { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-replicaspecification.html#cfn-cassandra-table-replicaspecification-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// ReadCapacityAutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-replicaspecification.html#cfn-cassandra-table-replicaspecification-readcapacityautoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingSetting
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.AutoScalingSetting, BaseFunction>? ReadCapacityAutoScaling { get; set; }
        }

        public class ScalingPolicy : Humidifier.Base.BaseSubResource, IHaveCassandraTableTypesTargetTrackingScalingPolicyConfigurationTargetTrackingScalingPolicyConfiguration
        {
            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-scalingpolicy.html#cfn-cassandra-table-scalingpolicy-targettrackingscalingpolicyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetTrackingScalingPolicyConfiguration
            /// </summary>
            public Union<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration, BaseFunction>? TargetTrackingScalingPolicyConfiguration { get; set; }
        }

        public class TargetTrackingScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveScaleOutCooldown_Integer, IHaveTargetValue_Integer, IHaveDisableScaleIn_Boolean, IHaveScaleInCooldown_Integer
        {
            /// <summary>
            /// ScaleOutCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-scaleoutcooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleOutCooldown { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableScaleIn { get; set; }
            /// <summary>
            /// ScaleInCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-scaleincooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInCooldown { get; set; }
        }

        public class WarmThroughput : Humidifier.Base.BaseSubResource, IHaveReadUnitsPerSecond_Integer, IHaveWriteUnitsPerSecond_Integer
        {
            /// <summary>
            /// ReadUnitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-warmthroughput.html#cfn-cassandra-table-warmthroughput-readunitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReadUnitsPerSecond { get; set; }
            /// <summary>
            /// WriteUnitsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-warmthroughput.html#cfn-cassandra-table-warmthroughput-writeunitspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WriteUnitsPerSecond { get; set; }
        }
    }
}