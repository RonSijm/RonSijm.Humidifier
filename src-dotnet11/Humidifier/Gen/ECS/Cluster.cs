namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfECSClusterTypesClusterSettingsClusterSettings, IHaveListOfECSClusterTypesCapacityProviderStrategyItemDefaultCapacityProviderStrategy, IHaveECSClusterTypesClusterConfigurationConfiguration, IHaveECSClusterTypesServiceConnectDefaultsServiceConnectDefaults, IHaveStringListOfCapacityProviders, IHaveClusterName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ECS.Cluster; }
        /// <summary>
        /// ClusterSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-clustersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ClusterSettings
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ClusterTypes.ClusterSettings>, IReadOnlyList<Union<Humidifier.ECS.ClusterTypes.ClusterSettings, BaseFunction>>, BaseFunction>? ClusterSettings { get; set; }
        /// <summary>
        /// DefaultCapacityProviderStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-defaultcapacityproviderstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CapacityProviderStrategyItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem>, IReadOnlyList<Union<Humidifier.ECS.ClusterTypes.CapacityProviderStrategyItem, BaseFunction>>, BaseFunction>? DefaultCapacityProviderStrategy { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClusterConfiguration
        /// </summary>
        public Union<Humidifier.ECS.ClusterTypes.ClusterConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// ServiceConnectDefaults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-serviceconnectdefaults
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceConnectDefaults
        /// </summary>
        public Union<Humidifier.ECS.ClusterTypes.ServiceConnectDefaults, BaseFunction>? ServiceConnectDefaults { get; set; }
        /// <summary>
        /// CapacityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-capacityproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityProviders { get; set; }
        public Union<string, BaseFunction>? ClusterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ClusterTypes
    {
        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveWeight_Integer, IHaveBase_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-capacityproviderstrategyitem.html#cfn-ecs-cluster-capacityproviderstrategyitem-capacityprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-capacityproviderstrategyitem.html#cfn-ecs-cluster-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-capacityproviderstrategyitem.html#cfn-ecs-cluster-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
        }

        public class ClusterConfiguration : Humidifier.Base.BaseSubResource, IHaveECSClusterTypesManagedStorageConfigurationManagedStorageConfiguration, IHaveECSClusterTypesExecuteCommandConfigurationExecuteCommandConfiguration
        {
            /// <summary>
            /// ManagedStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-clusterconfiguration.html#cfn-ecs-cluster-clusterconfiguration-managedstorageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedStorageConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ClusterTypes.ManagedStorageConfiguration, BaseFunction>? ManagedStorageConfiguration { get; set; }
            /// <summary>
            /// ExecuteCommandConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-clusterconfiguration.html#cfn-ecs-cluster-clusterconfiguration-executecommandconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExecuteCommandConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ClusterTypes.ExecuteCommandConfiguration, BaseFunction>? ExecuteCommandConfiguration { get; set; }
        }

        public class ClusterSettings : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-clustersettings.html#cfn-ecs-cluster-clustersettings-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-clustersettings.html#cfn-ecs-cluster-clustersettings-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ExecuteCommandConfiguration : Humidifier.Base.BaseSubResource, IHaveLogging, IHaveKmsKeyId, IHaveECSClusterTypesExecuteCommandLogConfigurationLogConfiguration
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandconfiguration.html#cfn-ecs-cluster-executecommandconfiguration-logging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Logging { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandconfiguration.html#cfn-ecs-cluster-executecommandconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandconfiguration.html#cfn-ecs-cluster-executecommandconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExecuteCommandLogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration, BaseFunction>? LogConfiguration { get; set; }
        }

        public class ExecuteCommandLogConfiguration : Humidifier.Base.BaseSubResource, IHaveS3EncryptionEnabled_Boolean, IHaveCloudWatchEncryptionEnabled_Boolean, IHaveCloudWatchLogGroupName, IHaveS3KeyPrefix, IHaveS3BucketName
        {
            /// <summary>
            /// S3EncryptionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandlogconfiguration.html#cfn-ecs-cluster-executecommandlogconfiguration-s3encryptionenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? S3EncryptionEnabled { get; set; }
            /// <summary>
            /// CloudWatchEncryptionEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandlogconfiguration.html#cfn-ecs-cluster-executecommandlogconfiguration-cloudwatchencryptionenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CloudWatchEncryptionEnabled { get; set; }
            /// <summary>
            /// CloudWatchLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandlogconfiguration.html#cfn-ecs-cluster-executecommandlogconfiguration-cloudwatchloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogGroupName { get; set; }
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandlogconfiguration.html#cfn-ecs-cluster-executecommandlogconfiguration-s3keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandlogconfiguration.html#cfn-ecs-cluster-executecommandlogconfiguration-s3bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
        }

        public class ManagedStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveFargateEphemeralStorageKmsKeyId, IHaveKmsKeyId
        {
            /// <summary>
            /// FargateEphemeralStorageKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-managedstorageconfiguration.html#cfn-ecs-cluster-managedstorageconfiguration-fargateephemeralstoragekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FargateEphemeralStorageKmsKeyId { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-managedstorageconfiguration.html#cfn-ecs-cluster-managedstorageconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class ServiceConnectDefaults : Humidifier.Base.BaseSubResource, IHaveNamespace_
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-serviceconnectdefaults.html#cfn-ecs-cluster-serviceconnectdefaults-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }
    }
}