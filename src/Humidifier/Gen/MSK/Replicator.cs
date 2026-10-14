namespace Humidifier.MSK
{
    using global::System.Collections.Generic;
    using ReplicatorTypes;

    public class Replicator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveServiceExecutionRoleArn
    {
        public class Attributes
        {
            public static string ReplicatorArn =  "ReplicatorArn" ;
            public static string CurrentVersion =  "CurrentVersion" ;
        }

        public override string AWSTypeName { get => AWS.MSK.Replicator; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ServiceExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-serviceexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceExecutionRoleArn { get; set; }
        public dynamic ReplicatorName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ReplicationInfoList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-replicationinfolist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ReplicationInfo
        /// </summary>
        [Required]
        public List<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> ReplicationInfoList { get; set; }

        /// <summary>
        /// KafkaClusters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-kafkaclusters
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: KafkaCluster
        /// </summary>
        [Required]
        public List<Humidifier.MSK.ReplicatorTypes.KafkaCluster> KafkaClusters { get; set; }
        /// <summary>
        /// LogDelivery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-logdelivery
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogDelivery
        /// </summary>
        public Humidifier.MSK.ReplicatorTypes.LogDelivery LogDelivery { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ReplicatorTypes
    {
        public class AmazonMskCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MskClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-amazonmskcluster.html#cfn-msk-replicator-amazonmskcluster-mskclusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MskClusterArn { get; set; }
        }

        public class ApacheKafkaCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApacheKafkaClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-apachekafkacluster.html#cfn-msk-replicator-apachekafkacluster-apachekafkaclusterid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApacheKafkaClusterId { get; set; }
            /// <summary>
            /// BootstrapBrokerString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-apachekafkacluster.html#cfn-msk-replicator-apachekafkacluster-bootstrapbrokerstring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BootstrapBrokerString { get; set; }
        }

        public class CloudWatchLogs : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-cloudwatchlogs.html#cfn-msk-replicator-cloudwatchlogs-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-cloudwatchlogs.html#cfn-msk-replicator-cloudwatchlogs-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class ConsumerGroupReplication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConsumerGroupOffsetSyncMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-consumergroupoffsetsyncmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConsumerGroupOffsetSyncMode { get; set; }
            /// <summary>
            /// ConsumerGroupsToReplicate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-consumergroupstoreplicate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ConsumerGroupsToReplicate { get; set; }
            /// <summary>
            /// ConsumerGroupsToExclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-consumergroupstoexclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ConsumerGroupsToExclude { get; set; }
            /// <summary>
            /// SynchroniseConsumerGroupOffsets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-synchroniseconsumergroupoffsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SynchroniseConsumerGroupOffsets { get; set; }
            /// <summary>
            /// DetectAndCopyNewConsumerGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-detectandcopynewconsumergroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetectAndCopyNewConsumerGroups { get; set; }
        }

        public class Firehose : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveDeliveryStream
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-firehose.html#cfn-msk-replicator-firehose-deliverystream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-firehose.html#cfn-msk-replicator-firehose-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class KafkaCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterClientVpcConfig
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig VpcConfig { get; set; }
            /// <summary>
            /// AmazonMskCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-amazonmskcluster
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AmazonMskCluster
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.AmazonMskCluster AmazonMskCluster { get; set; }
            /// <summary>
            /// ClientAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-clientauthentication
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterClientAuthentication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterClientAuthentication ClientAuthentication { get; set; }
            /// <summary>
            /// ApacheKafkaCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-apachekafkacluster
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ApacheKafkaCluster
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ApacheKafkaCluster ApacheKafkaCluster { get; set; }
            /// <summary>
            /// EncryptionInTransit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-encryptionintransit
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterEncryptionInTransit
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterEncryptionInTransit EncryptionInTransit { get; set; }
        }

        public class KafkaClusterClientAuthentication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SaslOAuthBearer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientauthentication.html#cfn-msk-replicator-kafkaclusterclientauthentication-sasloauthbearer
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterSaslOAuthBearerAuthentication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslOAuthBearerAuthentication SaslOAuthBearer { get; set; }
            /// <summary>
            /// MTLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientauthentication.html#cfn-msk-replicator-kafkaclusterclientauthentication-mtls
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterMtlsAuthentication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterMtlsAuthentication MTLS { get; set; }
            /// <summary>
            /// SaslScram
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientauthentication.html#cfn-msk-replicator-kafkaclusterclientauthentication-saslscram
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterSaslScramAuthentication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslScramAuthentication SaslScram { get; set; }
        }

        public class KafkaClusterClientVpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientvpcconfig.html#cfn-msk-replicator-kafkaclusterclientvpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientvpcconfig.html#cfn-msk-replicator-kafkaclusterclientvpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class KafkaClusterEncryptionInTransit : Humidifier.Base.BaseSubResource, IHaveEncryptionType
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterencryptionintransit.html#cfn-msk-replicator-kafkaclusterencryptionintransit-encryptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// RootCaCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterencryptionintransit.html#cfn-msk-replicator-kafkaclusterencryptionintransit-rootcacertificate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RootCaCertificate { get; set; }
        }

        public class KafkaClusterMtlsAuthentication : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustermtlsauthentication.html#cfn-msk-replicator-kafkaclustermtlsauthentication-secretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
        }

        public class KafkaClusterOAuthClientCredentials : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TokenRequestSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthclientcredentials.html#cfn-msk-replicator-kafkaclusteroauthclientcredentials-tokenrequestsecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenRequestSecretArn { get; set; }
        }

        public class KafkaClusterOAuthClientCredentialsAssertion : Humidifier.Base.BaseSubResource, IHaveSigningAlgorithm, IHaveAudience
        {
            /// <summary>
            /// TokenRequestSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthclientcredentialsassertion.html#cfn-msk-replicator-kafkaclusteroauthclientcredentialsassertion-tokenrequestsecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenRequestSecretArn { get; set; }
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthclientcredentialsassertion.html#cfn-msk-replicator-kafkaclusteroauthclientcredentialsassertion-audience
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Audience { get; set; }
            /// <summary>
            /// SigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthclientcredentialsassertion.html#cfn-msk-replicator-kafkaclusteroauthclientcredentialsassertion-signingalgorithm
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SigningAlgorithm { get; set; }
        }

        public class KafkaClusterOAuthIamJwtBearer : Humidifier.Base.BaseSubResource, IHaveSigningAlgorithm, IHaveAudience
        {
            /// <summary>
            /// TokenRequestSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthiamjwtbearer.html#cfn-msk-replicator-kafkaclusteroauthiamjwtbearer-tokenrequestsecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenRequestSecretArn { get; set; }
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthiamjwtbearer.html#cfn-msk-replicator-kafkaclusteroauthiamjwtbearer-audience
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Audience { get; set; }
            /// <summary>
            /// SigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusteroauthiamjwtbearer.html#cfn-msk-replicator-kafkaclusteroauthiamjwtbearer-signingalgorithm
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SigningAlgorithm { get; set; }
        }

        public class KafkaClusterSaslOAuthBearerAuthentication : Humidifier.Base.BaseSubResource, IHaveScope
        {
            /// <summary>
            /// TokenEndpointUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-tokenendpointurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpointUrl { get; set; }
            /// <summary>
            /// ClientCredentialsAssertion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-clientcredentialsassertion
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterOAuthClientCredentialsAssertion
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentialsAssertion ClientCredentialsAssertion { get; set; }
            /// <summary>
            /// TokenEndpointAuthenticationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-tokenendpointauthenticationmethod
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpointAuthenticationMethod { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-scope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// IamJwtBearer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-iamjwtbearer
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterOAuthIamJwtBearer
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthIamJwtBearer IamJwtBearer { get; set; }
            /// <summary>
            /// ClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-clientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KafkaClusterOAuthClientCredentials
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentials ClientCredentials { get; set; }
            /// <summary>
            /// TokenEndpointTlsCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersasloauthbearerauthentication.html#cfn-msk-replicator-kafkaclustersasloauthbearerauthentication-tokenendpointtlscertificatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpointTlsCertificateArn { get; set; }
        }

        public class KafkaClusterSaslScramAuthentication : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersaslscramauthentication.html#cfn-msk-replicator-kafkaclustersaslscramauthentication-secretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// Mechanism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclustersaslscramauthentication.html#cfn-msk-replicator-kafkaclustersaslscramauthentication-mechanism
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mechanism { get; set; }
        }

        public class LogDelivery : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReplicatorLogDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-logdelivery.html#cfn-msk-replicator-logdelivery-replicatorlogdelivery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicatorLogDelivery
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ReplicatorLogDelivery ReplicatorLogDelivery { get; set; }
        }

        public class ReplicationInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-targetcompressiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetCompressionType { get; set; }
            /// <summary>
            /// TargetKafkaClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-targetkafkaclusterid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetKafkaClusterId { get; set; }
            /// <summary>
            /// TopicReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-topicreplication
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TopicReplication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.TopicReplication TopicReplication { get; set; }
            /// <summary>
            /// ConsumerGroupReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-consumergroupreplication
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConsumerGroupReplication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication ConsumerGroupReplication { get; set; }
            /// <summary>
            /// SourceKafkaClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-sourcekafkaclusterarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceKafkaClusterArn { get; set; }
            /// <summary>
            /// TargetKafkaClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-targetkafkaclusterarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetKafkaClusterArn { get; set; }
            /// <summary>
            /// SourceKafkaClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-sourcekafkaclusterid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceKafkaClusterId { get; set; }
        }

        public class ReplicationStartingPosition : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationstartingposition.html#cfn-msk-replicator-replicationstartingposition-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class ReplicationTopicNameConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationtopicnameconfiguration.html#cfn-msk-replicator-replicationtopicnameconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class ReplicatorLogDelivery : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicatorlogdelivery.html#cfn-msk-replicator-replicatorlogdelivery-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.S3 S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicatorlogdelivery.html#cfn-msk-replicator-replicatorlogdelivery-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Firehose
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.Firehose Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicatorlogdelivery.html#cfn-msk-replicator-replicatorlogdelivery-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogs
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.CloudWatchLogs CloudWatchLogs { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveEnabled, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-s3.html#cfn-msk-replicator-s3-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-s3.html#cfn-msk-replicator-s3-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-s3.html#cfn-msk-replicator-s3-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class TopicReplication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StartingPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-startingposition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationStartingPosition
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition StartingPosition { get; set; }
            /// <summary>
            /// TopicsToReplicate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-topicstoreplicate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TopicsToReplicate { get; set; }
            /// <summary>
            /// TopicsToExclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-topicstoexclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TopicsToExclude { get; set; }
            /// <summary>
            /// TopicNameConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-topicnameconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationTopicNameConfiguration
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration TopicNameConfiguration { get; set; }
            /// <summary>
            /// CopyTopicConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-copytopicconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CopyTopicConfigurations { get; set; }
            /// <summary>
            /// DetectAndCopyNewTopics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-detectandcopynewtopics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetectAndCopyNewTopics { get; set; }
            /// <summary>
            /// CopyAccessControlListsForTopics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-copyaccesscontrollistsfortopics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CopyAccessControlListsForTopics { get; set; }
        }
    }
}