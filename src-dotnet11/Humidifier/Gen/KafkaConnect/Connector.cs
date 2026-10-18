namespace Humidifier.KafkaConnect
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKafkaConnectConnectorTypesKafkaClusterKafkaCluster, IHaveKafkaConnectVersion, IHaveStringDictionaryOfConnectorConfiguration, IHaveKafkaConnectConnectorTypesLogDeliveryLogDelivery, IHaveKafkaConnectConnectorTypesWorkerConfigurationWorkerConfiguration, IHaveKafkaConnectConnectorTypesCapacityCapacity, IHaveKafkaConnectConnectorTypesKafkaClusterEncryptionInTransitKafkaClusterEncryptionInTransit, IHaveNetworkType, IHaveConnectorDescription, IHaveKafkaConnectConnectorTypesKafkaClusterClientAuthenticationKafkaClusterClientAuthentication, IHaveConnectorName, IHaveServiceExecutionRoleArn, IHaveListOfKafkaConnectConnectorTypesPluginPlugins, IHaveDescription
    {
        public class Attributes
        {
            public static string ConnectorArn =  "ConnectorArn" ;
        }

        public override string AWSTypeName { get => AWS.KafkaConnect.Connector; }

        /// <summary>
        /// KafkaCluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkacluster
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KafkaCluster
        /// </summary>
        [Required]
        public Union<Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster, BaseFunction>? KafkaCluster { get; set; }

        /// <summary>
        /// KafkaConnectVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkaconnectversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KafkaConnectVersion { get; set; }

        /// <summary>
        /// ConnectorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-connectorconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ConnectorConfiguration { get; set; }
        /// <summary>
        /// LogDelivery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-logdelivery
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LogDelivery
        /// </summary>
        public Union<Humidifier.KafkaConnect.ConnectorTypes.LogDelivery, BaseFunction>? LogDelivery { get; set; }
        /// <summary>
        /// WorkerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-workerconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: WorkerConfiguration
        /// </summary>
        public Union<Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration, BaseFunction>? WorkerConfiguration { get; set; }

        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-capacity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Capacity
        /// </summary>
        [Required]
        public Union<Humidifier.KafkaConnect.ConnectorTypes.Capacity, BaseFunction>? Capacity { get; set; }

        /// <summary>
        /// KafkaClusterEncryptionInTransit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkaclusterencryptionintransit
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KafkaClusterEncryptionInTransit
        /// </summary>
        [Required]
        public Union<Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit, BaseFunction>? KafkaClusterEncryptionInTransit { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// ConnectorDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-connectordescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectorDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ConnectorDescription; set => ConnectorDescription = value; }

        /// <summary>
        /// KafkaClusterClientAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkaclusterclientauthentication
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KafkaClusterClientAuthentication
        /// </summary>
        [Required]
        public Union<Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication, BaseFunction>? KafkaClusterClientAuthentication { get; set; }
        public Union<string, BaseFunction>? ConnectorName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ServiceExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-serviceexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceExecutionRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Plugins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-plugins
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Plugin
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.KafkaConnect.ConnectorTypes.Plugin>, IReadOnlyList<Union<Humidifier.KafkaConnect.ConnectorTypes.Plugin, BaseFunction>>, BaseFunction>? Plugins { get; set; }
    }

    namespace ConnectorTypes
    {
        public class ApacheKafkaCluster : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesVpcVpc, IHaveBootstrapServers
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-apachekafkacluster.html#cfn-kafkaconnect-connector-apachekafkacluster-vpc
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Vpc
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.Vpc, BaseFunction>? Vpc { get; set; }
            /// <summary>
            /// BootstrapServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-apachekafkacluster.html#cfn-kafkaconnect-connector-apachekafkacluster-bootstrapservers
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BootstrapServers { get; set; }
        }

        public class AutoScaling : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesScaleOutPolicyScaleOutPolicy, IHaveKafkaConnectConnectorTypesScaleInPolicyScaleInPolicy, IHaveMaxWorkerCount_Integer, IHaveMaxAutoscalingTaskCount_Integer, IHaveMinWorkerCount_Integer, IHaveMcuCount_Integer
        {
            /// <summary>
            /// ScaleOutPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-scaleoutpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScaleOutPolicy
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy, BaseFunction>? ScaleOutPolicy { get; set; }
            /// <summary>
            /// ScaleInPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-scaleinpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScaleInPolicy
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy, BaseFunction>? ScaleInPolicy { get; set; }
            /// <summary>
            /// MaxWorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-maxworkercount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxWorkerCount { get; set; }
            /// <summary>
            /// MaxAutoscalingTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-maxautoscalingtaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAutoscalingTaskCount { get; set; }
            /// <summary>
            /// MinWorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-minworkercount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinWorkerCount { get; set; }
            /// <summary>
            /// McuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-mcucount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? McuCount { get; set; }
        }

        public class Capacity : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesProvisionedCapacityProvisionedCapacity, IHaveKafkaConnectConnectorTypesAutoScalingAutoScaling
        {
            /// <summary>
            /// ProvisionedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-capacity.html#cfn-kafkaconnect-connector-capacity-provisionedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedCapacity
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity, BaseFunction>? ProvisionedCapacity { get; set; }
            /// <summary>
            /// AutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-capacity.html#cfn-kafkaconnect-connector-capacity-autoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScaling
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling, BaseFunction>? AutoScaling { get; set; }
        }

        public class CloudWatchLogsLogDelivery : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveEnabled_Boolean
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-cloudwatchlogslogdelivery.html#cfn-kafkaconnect-connector-cloudwatchlogslogdelivery-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-cloudwatchlogslogdelivery.html#cfn-kafkaconnect-connector-cloudwatchlogslogdelivery-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class CustomPlugin : Humidifier.Base.BaseSubResource, IHaveCustomPluginArn, IHaveRevision_Long
        {
            /// <summary>
            /// CustomPluginArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-customplugin.html#cfn-kafkaconnect-connector-customplugin-custompluginarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomPluginArn { get; set; }
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-customplugin.html#cfn-kafkaconnect-connector-customplugin-revision
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? Revision { get; set; }
        }

        public class FirehoseLogDelivery : Humidifier.Base.BaseSubResource, IHaveDeliveryStream, IHaveEnabled_Boolean
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-firehoselogdelivery.html#cfn-kafkaconnect-connector-firehoselogdelivery-deliverystream
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-firehoselogdelivery.html#cfn-kafkaconnect-connector-firehoselogdelivery-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class KafkaCluster : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesApacheKafkaClusterApacheKafkaCluster
        {
            /// <summary>
            /// ApacheKafkaCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-kafkacluster.html#cfn-kafkaconnect-connector-kafkacluster-apachekafkacluster
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ApacheKafkaCluster
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster, BaseFunction>? ApacheKafkaCluster { get; set; }
        }

        public class KafkaClusterClientAuthentication : Humidifier.Base.BaseSubResource, IHaveAuthenticationType
        {
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-kafkaclusterclientauthentication.html#cfn-kafkaconnect-connector-kafkaclusterclientauthentication-authenticationtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class KafkaClusterEncryptionInTransit : Humidifier.Base.BaseSubResource, IHaveEncryptionType
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-kafkaclusterencryptionintransit.html#cfn-kafkaconnect-connector-kafkaclusterencryptionintransit-encryptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
        }

        public class LogDelivery : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesWorkerLogDeliveryWorkerLogDelivery
        {
            /// <summary>
            /// WorkerLogDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-logdelivery.html#cfn-kafkaconnect-connector-logdelivery-workerlogdelivery
            /// Required: True
            /// UpdateType: Immutable
            /// Type: WorkerLogDelivery
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery, BaseFunction>? WorkerLogDelivery { get; set; }
        }

        public class Plugin : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesCustomPluginCustomPlugin
        {
            /// <summary>
            /// CustomPlugin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-plugin.html#cfn-kafkaconnect-connector-plugin-customplugin
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CustomPlugin
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin, BaseFunction>? CustomPlugin { get; set; }
        }

        public class ProvisionedCapacity : Humidifier.Base.BaseSubResource, IHaveWorkerCount_Integer, IHaveMcuCount_Integer
        {
            /// <summary>
            /// WorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-provisionedcapacity.html#cfn-kafkaconnect-connector-provisionedcapacity-workercount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WorkerCount { get; set; }
            /// <summary>
            /// McuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-provisionedcapacity.html#cfn-kafkaconnect-connector-provisionedcapacity-mcucount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? McuCount { get; set; }
        }

        public class S3LogDelivery : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveEnabled_Boolean, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-s3logdelivery.html#cfn-kafkaconnect-connector-s3logdelivery-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-s3logdelivery.html#cfn-kafkaconnect-connector-s3logdelivery-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-s3logdelivery.html#cfn-kafkaconnect-connector-s3logdelivery-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class ScaleInPolicy : Humidifier.Base.BaseSubResource, IHaveCpuUtilizationPercentage_Integer
        {
            /// <summary>
            /// CpuUtilizationPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-scaleinpolicy.html#cfn-kafkaconnect-connector-scaleinpolicy-cpuutilizationpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CpuUtilizationPercentage { get; set; }
        }

        public class ScaleOutPolicy : Humidifier.Base.BaseSubResource, IHaveCpuUtilizationPercentage_Integer
        {
            /// <summary>
            /// CpuUtilizationPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-scaleoutpolicy.html#cfn-kafkaconnect-connector-scaleoutpolicy-cpuutilizationpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CpuUtilizationPercentage { get; set; }
        }

        public class Vpc : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-vpc.html#cfn-kafkaconnect-connector-vpc-securitygroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-vpc.html#cfn-kafkaconnect-connector-vpc-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }

        public class WorkerConfiguration : Humidifier.Base.BaseSubResource, IHaveRevision_Long, IHaveWorkerConfigurationArn
        {
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerconfiguration.html#cfn-kafkaconnect-connector-workerconfiguration-revision
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? Revision { get; set; }
            /// <summary>
            /// WorkerConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerconfiguration.html#cfn-kafkaconnect-connector-workerconfiguration-workerconfigurationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkerConfigurationArn { get; set; }
        }

        public class WorkerLogDelivery : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorTypesS3LogDeliveryS3, IHaveKafkaConnectConnectorTypesFirehoseLogDeliveryFirehose, IHaveKafkaConnectConnectorTypesCloudWatchLogsLogDeliveryCloudWatchLogs
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerlogdelivery.html#cfn-kafkaconnect-connector-workerlogdelivery-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3LogDelivery
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerlogdelivery.html#cfn-kafkaconnect-connector-workerlogdelivery-firehose
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirehoseLogDelivery
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerlogdelivery.html#cfn-kafkaconnect-connector-workerlogdelivery-cloudwatchlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchLogsLogDelivery
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery, BaseFunction>? CloudWatchLogs { get; set; }
        }
    }
}