namespace Humidifier.KafkaConnect
{
    using System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveServiceExecutionRoleArn, IHaveDescription
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
        public Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster KafkaCluster { get; set; }

        /// <summary>
        /// KafkaConnectVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkaconnectversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KafkaConnectVersion { get; set; }

        /// <summary>
        /// ConnectorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-connectorconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Dictionary<string, dynamic> ConnectorConfiguration { get; set; }
        /// <summary>
        /// LogDelivery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-logdelivery
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LogDelivery
        /// </summary>
        public Humidifier.KafkaConnect.ConnectorTypes.LogDelivery LogDelivery { get; set; }
        /// <summary>
        /// WorkerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-workerconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: WorkerConfiguration
        /// </summary>
        public Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration WorkerConfiguration { get; set; }

        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-capacity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Capacity
        /// </summary>
        [Required]
        public Humidifier.KafkaConnect.ConnectorTypes.Capacity Capacity { get; set; }

        /// <summary>
        /// KafkaClusterEncryptionInTransit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkaclusterencryptionintransit
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KafkaClusterEncryptionInTransit
        /// </summary>
        [Required]
        public Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit KafkaClusterEncryptionInTransit { get; set; }
        /// <summary>
        /// ConnectorDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-connectordescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectorDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ConnectorDescription; set => ConnectorDescription = value; }

        /// <summary>
        /// KafkaClusterClientAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-kafkaclusterclientauthentication
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KafkaClusterClientAuthentication
        /// </summary>
        [Required]
        public Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication KafkaClusterClientAuthentication { get; set; }
        public dynamic ConnectorName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ServiceExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-serviceexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceExecutionRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Plugins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-connector.html#cfn-kafkaconnect-connector-plugins
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Plugin
        /// </summary>
        [Required]
        public List<Humidifier.KafkaConnect.ConnectorTypes.Plugin> Plugins { get; set; }
    }

    namespace ConnectorTypes
    {
        public class ApacheKafkaCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-apachekafkacluster.html#cfn-kafkaconnect-connector-apachekafkacluster-vpc
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Vpc
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.Vpc Vpc { get; set; }
            /// <summary>
            /// BootstrapServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-apachekafkacluster.html#cfn-kafkaconnect-connector-apachekafkacluster-bootstrapservers
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BootstrapServers { get; set; }
        }

        public class AutoScaling : Humidifier.Base.BaseSubResource, IHaveMaxWorkerCount, IHaveMinWorkerCount, IHaveMcuCount
        {
            /// <summary>
            /// ScaleOutPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-scaleoutpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScaleOutPolicy
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy ScaleOutPolicy { get; set; }
            /// <summary>
            /// ScaleInPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-scaleinpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScaleInPolicy
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy ScaleInPolicy { get; set; }
            /// <summary>
            /// MaxWorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-maxworkercount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxWorkerCount { get; set; }
            /// <summary>
            /// MinWorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-minworkercount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinWorkerCount { get; set; }
            /// <summary>
            /// McuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-autoscaling.html#cfn-kafkaconnect-connector-autoscaling-mcucount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic McuCount { get; set; }
        }

        public class Capacity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProvisionedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-capacity.html#cfn-kafkaconnect-connector-capacity-provisionedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedCapacity
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity ProvisionedCapacity { get; set; }
            /// <summary>
            /// AutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-capacity.html#cfn-kafkaconnect-connector-capacity-autoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScaling
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.AutoScaling AutoScaling { get; set; }
        }

        public class CloudWatchLogsLogDelivery : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-cloudwatchlogslogdelivery.html#cfn-kafkaconnect-connector-cloudwatchlogslogdelivery-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-cloudwatchlogslogdelivery.html#cfn-kafkaconnect-connector-cloudwatchlogslogdelivery-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class CustomPlugin : Humidifier.Base.BaseSubResource, IHaveRevision
        {
            /// <summary>
            /// CustomPluginArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-customplugin.html#cfn-kafkaconnect-connector-customplugin-custompluginarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomPluginArn { get; set; }
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-customplugin.html#cfn-kafkaconnect-connector-customplugin-revision
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Revision { get; set; }
        }

        public class FirehoseLogDelivery : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveDeliveryStream
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-firehoselogdelivery.html#cfn-kafkaconnect-connector-firehoselogdelivery-deliverystream
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-firehoselogdelivery.html#cfn-kafkaconnect-connector-firehoselogdelivery-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class KafkaCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApacheKafkaCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-kafkacluster.html#cfn-kafkaconnect-connector-kafkacluster-apachekafkacluster
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ApacheKafkaCluster
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster ApacheKafkaCluster { get; set; }
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
            public dynamic AuthenticationType { get; set; }
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
            public dynamic EncryptionType { get; set; }
        }

        public class LogDelivery : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WorkerLogDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-logdelivery.html#cfn-kafkaconnect-connector-logdelivery-workerlogdelivery
            /// Required: True
            /// UpdateType: Immutable
            /// Type: WorkerLogDelivery
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery WorkerLogDelivery { get; set; }
        }

        public class Plugin : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomPlugin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-plugin.html#cfn-kafkaconnect-connector-plugin-customplugin
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CustomPlugin
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin CustomPlugin { get; set; }
        }

        public class ProvisionedCapacity : Humidifier.Base.BaseSubResource, IHaveWorkerCount, IHaveMcuCount
        {
            /// <summary>
            /// WorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-provisionedcapacity.html#cfn-kafkaconnect-connector-provisionedcapacity-workercount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WorkerCount { get; set; }
            /// <summary>
            /// McuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-provisionedcapacity.html#cfn-kafkaconnect-connector-provisionedcapacity-mcucount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic McuCount { get; set; }
        }

        public class S3LogDelivery : Humidifier.Base.BaseSubResource, IHaveEnabled, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-s3logdelivery.html#cfn-kafkaconnect-connector-s3logdelivery-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-s3logdelivery.html#cfn-kafkaconnect-connector-s3logdelivery-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-s3logdelivery.html#cfn-kafkaconnect-connector-s3logdelivery-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class ScaleInPolicy : Humidifier.Base.BaseSubResource, IHaveCpuUtilizationPercentage
        {
            /// <summary>
            /// CpuUtilizationPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-scaleinpolicy.html#cfn-kafkaconnect-connector-scaleinpolicy-cpuutilizationpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CpuUtilizationPercentage { get; set; }
        }

        public class ScaleOutPolicy : Humidifier.Base.BaseSubResource, IHaveCpuUtilizationPercentage
        {
            /// <summary>
            /// CpuUtilizationPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-scaleoutpolicy.html#cfn-kafkaconnect-connector-scaleoutpolicy-cpuutilizationpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CpuUtilizationPercentage { get; set; }
        }

        public class Vpc : Humidifier.Base.BaseSubResource, IHaveSubnets, IHaveSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-vpc.html#cfn-kafkaconnect-connector-vpc-securitygroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-vpc.html#cfn-kafkaconnect-connector-vpc-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
        }

        public class WorkerConfiguration : Humidifier.Base.BaseSubResource, IHaveRevision
        {
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerconfiguration.html#cfn-kafkaconnect-connector-workerconfiguration-revision
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Revision { get; set; }
            /// <summary>
            /// WorkerConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerconfiguration.html#cfn-kafkaconnect-connector-workerconfiguration-workerconfigurationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkerConfigurationArn { get; set; }
        }

        public class WorkerLogDelivery : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerlogdelivery.html#cfn-kafkaconnect-connector-workerlogdelivery-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3LogDelivery
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerlogdelivery.html#cfn-kafkaconnect-connector-workerlogdelivery-firehose
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirehoseLogDelivery
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connector-workerlogdelivery.html#cfn-kafkaconnect-connector-workerlogdelivery-cloudwatchlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchLogsLogDelivery
            /// </summary>
            public Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery CloudWatchLogs { get; set; }
        }
    }
}