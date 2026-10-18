namespace Humidifier.MSK
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveKafkaVersion, IHaveNumberOfBrokerNodes_Integer, IHaveMSKClusterTypesRebalancingRebalancing, IHaveMSKClusterTypesEncryptionInfoEncryptionInfo, IHaveMSKClusterTypesOpenMonitoringOpenMonitoring, IHaveStorageMode, IHaveMSKClusterTypesConfigurationInfoConfigurationInfo, IHaveMSKClusterTypesBrokerNodeGroupInfoBrokerNodeGroupInfo, IHaveEnhancedMonitoring, IHaveClusterName, IHaveMSKClusterTypesZookeeperAccessZookeeperAccess, IHaveMSKClusterTypesClientAuthenticationClientAuthentication, IHaveMSKClusterTypesLoggingInfoLoggingInfo, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string CurrentVersion =  "CurrentVersion" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MSK.Cluster; }

        /// <summary>
        /// KafkaVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-kafkaversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KafkaVersion { get; set; }

        /// <summary>
        /// NumberOfBrokerNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-numberofbrokernodes
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? NumberOfBrokerNodes { get; set; }
        /// <summary>
        /// Rebalancing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-rebalancing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Rebalancing
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.Rebalancing, BaseFunction>? Rebalancing { get; set; }
        /// <summary>
        /// EncryptionInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-encryptioninfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionInfo
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.EncryptionInfo, BaseFunction>? EncryptionInfo { get; set; }
        /// <summary>
        /// OpenMonitoring
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-openmonitoring
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenMonitoring
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.OpenMonitoring, BaseFunction>? OpenMonitoring { get; set; }
        /// <summary>
        /// StorageMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-storagemode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StorageMode { get; set; }
        /// <summary>
        /// ConfigurationInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-configurationinfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConfigurationInfo
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.ConfigurationInfo, BaseFunction>? ConfigurationInfo { get; set; }

        /// <summary>
        /// BrokerNodeGroupInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-brokernodegroupinfo
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BrokerNodeGroupInfo
        /// </summary>
        [Required]
        public Union<Humidifier.MSK.ClusterTypes.BrokerNodeGroupInfo, BaseFunction>? BrokerNodeGroupInfo { get; set; }
        /// <summary>
        /// EnhancedMonitoring
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-enhancedmonitoring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnhancedMonitoring { get; set; }
        public Union<string, BaseFunction>? ClusterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ZookeeperAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-zookeeperaccess
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ZookeeperAccess
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.ZookeeperAccess, BaseFunction>? ZookeeperAccess { get; set; }
        /// <summary>
        /// ClientAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-clientauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientAuthentication
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.ClientAuthentication, BaseFunction>? ClientAuthentication { get; set; }
        /// <summary>
        /// LoggingInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-logginginfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingInfo
        /// </summary>
        public Union<Humidifier.MSK.ClusterTypes.LoggingInfo, BaseFunction>? LoggingInfo { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ClusterTypes
    {
        public class AuthorizerLogs : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesS3S3, IHaveMSKClusterTypesFirehoseFirehose, IHaveMSKClusterTypesCloudWatchLogsCloudWatchLogs
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-authorizerlogs.html#cfn-msk-cluster-authorizerlogs-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.S3, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-authorizerlogs.html#cfn-msk-cluster-authorizerlogs-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Firehose
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Firehose, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-authorizerlogs.html#cfn-msk-cluster-authorizerlogs-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogs
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.CloudWatchLogs, BaseFunction>? CloudWatchLogs { get; set; }
        }

        public class BrokerLogs : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesS3S3, IHaveMSKClusterTypesFirehoseFirehose, IHaveMSKClusterTypesCloudWatchLogsCloudWatchLogs
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokerlogs.html#cfn-msk-cluster-brokerlogs-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.S3, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokerlogs.html#cfn-msk-cluster-brokerlogs-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Firehose
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Firehose, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokerlogs.html#cfn-msk-cluster-brokerlogs-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogs
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.CloudWatchLogs, BaseFunction>? CloudWatchLogs { get; set; }
        }

        public class BrokerNodeGroupInfo : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfClientSubnets, IHaveMSKClusterTypesConnectivityInfoConnectivityInfo, IHaveMSKClusterTypesStorageInfoStorageInfo, IHaveBrokerAZDistribution, IHaveInstanceType
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// ClientSubnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-clientsubnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ClientSubnets { get; set; }
            /// <summary>
            /// ConnectivityInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-connectivityinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectivityInfo
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.ConnectivityInfo, BaseFunction>? ConnectivityInfo { get; set; }
            /// <summary>
            /// StorageInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-storageinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageInfo
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.StorageInfo, BaseFunction>? StorageInfo { get; set; }
            /// <summary>
            /// BrokerAZDistribution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-brokerazdistribution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BrokerAZDistribution { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ClientAuthentication : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesSaslSasl, IHaveMSKClusterTypesUnauthenticatedUnauthenticated, IHaveMSKClusterTypesTlsTls
        {
            /// <summary>
            /// Sasl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-clientauthentication.html#cfn-msk-cluster-clientauthentication-sasl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Sasl
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Sasl, BaseFunction>? Sasl { get; set; }
            /// <summary>
            /// Unauthenticated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-clientauthentication.html#cfn-msk-cluster-clientauthentication-unauthenticated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Unauthenticated
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Unauthenticated, BaseFunction>? Unauthenticated { get; set; }
            /// <summary>
            /// Tls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-clientauthentication.html#cfn-msk-cluster-clientauthentication-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Tls
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Tls, BaseFunction>? Tls { get; set; }
        }

        public class CloudWatchLogs : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveEnabled_Boolean
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-cloudwatchlogs.html#cfn-msk-cluster-cloudwatchlogs-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-cloudwatchlogs.html#cfn-msk-cluster-cloudwatchlogs-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ConfigurationInfo : Humidifier.Base.BaseSubResource, IHaveRevision_Integer, IHaveArn
        {
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-configurationinfo.html#cfn-msk-cluster-configurationinfo-revision
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Revision { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-configurationinfo.html#cfn-msk-cluster-configurationinfo-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class ConnectivityInfo : Humidifier.Base.BaseSubResource, IHaveNetworkType, IHaveMSKClusterTypesVpcConnectivityVpcConnectivity, IHaveMSKClusterTypesPublicAccessPublicAccess
        {
            /// <summary>
            /// NetworkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-connectivityinfo.html#cfn-msk-cluster-connectivityinfo-networktype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkType { get; set; }
            /// <summary>
            /// VpcConnectivity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-connectivityinfo.html#cfn-msk-cluster-connectivityinfo-vpcconnectivity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectivity
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.VpcConnectivity, BaseFunction>? VpcConnectivity { get; set; }
            /// <summary>
            /// PublicAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-connectivityinfo.html#cfn-msk-cluster-connectivityinfo-publicaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicAccess
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.PublicAccess, BaseFunction>? PublicAccess { get; set; }
        }

        public class EBSStorageInfo : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesProvisionedThroughputProvisionedThroughput, IHaveVolumeSize_Integer
        {
            /// <summary>
            /// ProvisionedThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-ebsstorageinfo.html#cfn-msk-cluster-ebsstorageinfo-provisionedthroughput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedThroughput
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.ProvisionedThroughput, BaseFunction>? ProvisionedThroughput { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-ebsstorageinfo.html#cfn-msk-cluster-ebsstorageinfo-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
        }

        public class EncryptionAtRest : Humidifier.Base.BaseSubResource, IHaveDataVolumeKMSKeyId
        {
            /// <summary>
            /// DataVolumeKMSKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionatrest.html#cfn-msk-cluster-encryptionatrest-datavolumekmskeyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataVolumeKMSKeyId { get; set; }
        }

        public class EncryptionInTransit : Humidifier.Base.BaseSubResource, IHaveClientBroker, IHaveInCluster_Boolean
        {
            /// <summary>
            /// ClientBroker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionintransit.html#cfn-msk-cluster-encryptionintransit-clientbroker
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientBroker { get; set; }
            /// <summary>
            /// InCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionintransit.html#cfn-msk-cluster-encryptionintransit-incluster
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InCluster { get; set; }
        }

        public class EncryptionInfo : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesEncryptionAtRestEncryptionAtRest, IHaveMSKClusterTypesEncryptionInTransitEncryptionInTransit
        {
            /// <summary>
            /// EncryptionAtRest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptioninfo.html#cfn-msk-cluster-encryptioninfo-encryptionatrest
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EncryptionAtRest
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.EncryptionAtRest, BaseFunction>? EncryptionAtRest { get; set; }
            /// <summary>
            /// EncryptionInTransit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptioninfo.html#cfn-msk-cluster-encryptioninfo-encryptionintransit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionInTransit
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.EncryptionInTransit, BaseFunction>? EncryptionInTransit { get; set; }
        }

        public class Firehose : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveDeliveryStream
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-firehose.html#cfn-msk-cluster-firehose-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-firehose.html#cfn-msk-cluster-firehose-deliverystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStream { get; set; }
        }

        public class Iam : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-iam.html#cfn-msk-cluster-iam-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class JmxExporter : Humidifier.Base.BaseSubResource, IHaveEnabledInBroker_Boolean
        {
            /// <summary>
            /// EnabledInBroker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-jmxexporter.html#cfn-msk-cluster-jmxexporter-enabledinbroker
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnabledInBroker { get; set; }
        }

        public class LoggingInfo : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesBrokerLogsBrokerLogs, IHaveMSKClusterTypesAuthorizerLogsAuthorizerLogs
        {
            /// <summary>
            /// BrokerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-logginginfo.html#cfn-msk-cluster-logginginfo-brokerlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BrokerLogs
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.BrokerLogs, BaseFunction>? BrokerLogs { get; set; }
            /// <summary>
            /// AuthorizerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-logginginfo.html#cfn-msk-cluster-logginginfo-authorizerlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizerLogs
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.AuthorizerLogs, BaseFunction>? AuthorizerLogs { get; set; }
        }

        public class NodeExporter : Humidifier.Base.BaseSubResource, IHaveEnabledInBroker_Boolean
        {
            /// <summary>
            /// EnabledInBroker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-nodeexporter.html#cfn-msk-cluster-nodeexporter-enabledinbroker
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnabledInBroker { get; set; }
        }

        public class OpenMonitoring : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesPrometheusPrometheus
        {
            /// <summary>
            /// Prometheus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-openmonitoring.html#cfn-msk-cluster-openmonitoring-prometheus
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Prometheus
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Prometheus, BaseFunction>? Prometheus { get; set; }
        }

        public class Prometheus : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesJmxExporterJmxExporter, IHaveMSKClusterTypesNodeExporterNodeExporter
        {
            /// <summary>
            /// JmxExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-prometheus.html#cfn-msk-cluster-prometheus-jmxexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JmxExporter
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.JmxExporter, BaseFunction>? JmxExporter { get; set; }
            /// <summary>
            /// NodeExporter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-prometheus.html#cfn-msk-cluster-prometheus-nodeexporter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NodeExporter
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.NodeExporter, BaseFunction>? NodeExporter { get; set; }
        }

        public class ProvisionedThroughput : Humidifier.Base.BaseSubResource, IHaveVolumeThroughput_Integer, IHaveEnabled_Boolean
        {
            /// <summary>
            /// VolumeThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-provisionedthroughput.html#cfn-msk-cluster-provisionedthroughput-volumethroughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeThroughput { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-provisionedthroughput.html#cfn-msk-cluster-provisionedthroughput-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class PublicAccess : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-publicaccess.html#cfn-msk-cluster-publicaccess-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class Rebalancing : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-rebalancing.html#cfn-msk-cluster-rebalancing-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveEnabled_Boolean, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-s3.html#cfn-msk-cluster-s3-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-s3.html#cfn-msk-cluster-s3-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-s3.html#cfn-msk-cluster-s3-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class Sasl : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesIamIam, IHaveMSKClusterTypesScramScram
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-sasl.html#cfn-msk-cluster-sasl-iam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Iam
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Iam, BaseFunction>? Iam { get; set; }
            /// <summary>
            /// Scram
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-sasl.html#cfn-msk-cluster-sasl-scram
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scram
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.Scram, BaseFunction>? Scram { get; set; }
        }

        public class Scram : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-scram.html#cfn-msk-cluster-scram-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class StorageInfo : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesEBSStorageInfoEBSStorageInfo
        {
            /// <summary>
            /// EBSStorageInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-storageinfo.html#cfn-msk-cluster-storageinfo-ebsstorageinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EBSStorageInfo
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.EBSStorageInfo, BaseFunction>? EBSStorageInfo { get; set; }
        }

        public class Tls : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveStringListOfCertificateAuthorityArnList
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-tls.html#cfn-msk-cluster-tls-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// CertificateAuthorityArnList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-tls.html#cfn-msk-cluster-tls-certificateauthorityarnlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CertificateAuthorityArnList { get; set; }
        }

        public class Unauthenticated : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-unauthenticated.html#cfn-msk-cluster-unauthenticated-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class VpcConnectivity : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesVpcConnectivityClientAuthenticationClientAuthentication
        {
            /// <summary>
            /// ClientAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivity.html#cfn-msk-cluster-vpcconnectivity-clientauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectivityClientAuthentication
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.VpcConnectivityClientAuthentication, BaseFunction>? ClientAuthentication { get; set; }
        }

        public class VpcConnectivityClientAuthentication : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesVpcConnectivitySaslSasl, IHaveMSKClusterTypesVpcConnectivityTlsTls
        {
            /// <summary>
            /// Sasl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivityclientauthentication.html#cfn-msk-cluster-vpcconnectivityclientauthentication-sasl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectivitySasl
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.VpcConnectivitySasl, BaseFunction>? Sasl { get; set; }
            /// <summary>
            /// Tls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivityclientauthentication.html#cfn-msk-cluster-vpcconnectivityclientauthentication-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectivityTls
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.VpcConnectivityTls, BaseFunction>? Tls { get; set; }
        }

        public class VpcConnectivityIam : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivityiam.html#cfn-msk-cluster-vpcconnectivityiam-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class VpcConnectivitySasl : Humidifier.Base.BaseSubResource, IHaveMSKClusterTypesVpcConnectivityIamIam, IHaveMSKClusterTypesVpcConnectivityScramScram
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivitysasl.html#cfn-msk-cluster-vpcconnectivitysasl-iam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectivityIam
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.VpcConnectivityIam, BaseFunction>? Iam { get; set; }
            /// <summary>
            /// Scram
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivitysasl.html#cfn-msk-cluster-vpcconnectivitysasl-scram
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConnectivityScram
            /// </summary>
            public Union<Humidifier.MSK.ClusterTypes.VpcConnectivityScram, BaseFunction>? Scram { get; set; }
        }

        public class VpcConnectivityScram : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivityscram.html#cfn-msk-cluster-vpcconnectivityscram-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class VpcConnectivityTls : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-vpcconnectivitytls.html#cfn-msk-cluster-vpcconnectivitytls-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ZookeeperAccess : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-zookeeperaccess.html#cfn-msk-cluster-zookeeperaccess-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}