namespace Humidifier.Cassandra
{
    using System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTableName, IHavePointInTimeRecoveryEnabled
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
        public List<Humidifier.Cassandra.TableTypes.ReplicaSpecification> ReplicaSpecifications { get; set; }
        /// <summary>
        /// ClusteringKeyColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-clusteringkeycolumns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ClusteringKeyColumn
        /// </summary>
        public List<Humidifier.Cassandra.TableTypes.ClusteringKeyColumn> ClusteringKeyColumns { get; set; }

        /// <summary>
        /// KeyspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-keyspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KeyspaceName { get; set; }
        /// <summary>
        /// EncryptionSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-encryptionspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionSpecification
        /// </summary>
        public Humidifier.Cassandra.TableTypes.EncryptionSpecification EncryptionSpecification { get; set; }
        public dynamic TableName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PointInTimeRecoveryEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-pointintimerecoveryenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PointInTimeRecoveryEnabled { get; set; }
        /// <summary>
        /// AutoScalingSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-autoscalingspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoScalingSpecification
        /// </summary>
        public Humidifier.Cassandra.TableTypes.AutoScalingSpecification AutoScalingSpecifications { get; set; }
        /// <summary>
        /// ClientSideTimestampsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-clientsidetimestampsenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ClientSideTimestampsEnabled { get; set; }

        /// <summary>
        /// PartitionKeyColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-partitionkeycolumns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Column
        /// </summary>
        [Required]
        public List<Humidifier.Cassandra.TableTypes.Column> PartitionKeyColumns { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BillingMode
        /// </summary>
        public Humidifier.Cassandra.TableTypes.BillingMode BillingMode { get; set; }
        /// <summary>
        /// DefaultTimeToLive
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-defaulttimetolive
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DefaultTimeToLive { get; set; }
        /// <summary>
        /// RegularColumns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-regularcolumns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Column
        /// </summary>
        public List<Humidifier.Cassandra.TableTypes.Column> RegularColumns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html#cfn-cassandra-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace TableTypes
    {
        public class AutoScalingSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-maximumunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumUnits { get; set; }
            /// <summary>
            /// ScalingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-scalingpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScalingPolicy
            /// </summary>
            public Humidifier.Cassandra.TableTypes.ScalingPolicy ScalingPolicy { get; set; }
            /// <summary>
            /// MinimumUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-minimumunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumUnits { get; set; }
            /// <summary>
            /// AutoScalingDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingsetting.html#cfn-cassandra-table-autoscalingsetting-autoscalingdisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoScalingDisabled { get; set; }
        }

        public class AutoScalingSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReadCapacityAutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingspecification.html#cfn-cassandra-table-autoscalingspecification-readcapacityautoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingSetting
            /// </summary>
            public Humidifier.Cassandra.TableTypes.AutoScalingSetting ReadCapacityAutoScaling { get; set; }
            /// <summary>
            /// WriteCapacityAutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-autoscalingspecification.html#cfn-cassandra-table-autoscalingspecification-writecapacityautoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingSetting
            /// </summary>
            public Humidifier.Cassandra.TableTypes.AutoScalingSetting WriteCapacityAutoScaling { get; set; }
        }

        public class BillingMode : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-billingmode.html#cfn-cassandra-table-billingmode-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// ProvisionedThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-billingmode.html#cfn-cassandra-table-billingmode-provisionedthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedThroughput
            /// </summary>
            public Humidifier.Cassandra.TableTypes.ProvisionedThroughput ProvisionedThroughput { get; set; }
        }

        public class ClusteringKeyColumn : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OrderBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-clusteringkeycolumn.html#cfn-cassandra-table-clusteringkeycolumn-orderby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrderBy { get; set; }
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-clusteringkeycolumn.html#cfn-cassandra-table-clusteringkeycolumn-column
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Column
            /// </summary>
            public Humidifier.Cassandra.TableTypes.Column Column { get; set; }
        }

        public class Column : Humidifier.Base.BaseSubResource, IHaveColumnName
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-column.html#cfn-cassandra-table-column-columnname
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// ColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-column.html#cfn-cassandra-table-column-columntype
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnType { get; set; }
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
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// KmsKeyIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-encryptionspecification.html#cfn-cassandra-table-encryptionspecification-kmskeyidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyIdentifier { get; set; }
        }

        public class ProvisionedThroughput : Humidifier.Base.BaseSubResource, IHaveReadCapacityUnits
        {
            /// <summary>
            /// WriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-provisionedthroughput.html#cfn-cassandra-table-provisionedthroughput-writecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WriteCapacityUnits { get; set; }
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-provisionedthroughput.html#cfn-cassandra-table-provisionedthroughput-readcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReadCapacityUnits { get; set; }
        }

        public class ReplicaSpecification : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveReadCapacityUnits
        {
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-replicaspecification.html#cfn-cassandra-table-replicaspecification-readcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReadCapacityUnits { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-replicaspecification.html#cfn-cassandra-table-replicaspecification-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// ReadCapacityAutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-replicaspecification.html#cfn-cassandra-table-replicaspecification-readcapacityautoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingSetting
            /// </summary>
            public Humidifier.Cassandra.TableTypes.AutoScalingSetting ReadCapacityAutoScaling { get; set; }
        }

        public class ScalingPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-scalingpolicy.html#cfn-cassandra-table-scalingpolicy-targettrackingscalingpolicyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetTrackingScalingPolicyConfiguration
            /// </summary>
            public Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration { get; set; }
        }

        public class TargetTrackingScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue, IHaveDisableScaleIn, IHaveScaleOutCooldown, IHaveScaleInCooldown
        {
            /// <summary>
            /// ScaleOutCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-scaleoutcooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScaleOutCooldown { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetValue { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableScaleIn { get; set; }
            /// <summary>
            /// ScaleInCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-targettrackingscalingpolicyconfiguration.html#cfn-cassandra-table-targettrackingscalingpolicyconfiguration-scaleincooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScaleInCooldown { get; set; }
        }
    }
}