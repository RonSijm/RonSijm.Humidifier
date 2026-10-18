namespace Humidifier.OpsWorks
{
    using global::System.Collections.Generic;
    using StackTypes;

    public class Stack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAgentVersion, IHaveStringDictionaryOfAttributes_, IHaveOpsWorksStackTypesChefConfigurationChefConfiguration, IHaveStringListOfCloneAppIds, IHaveClonePermissions_Boolean, IHaveOpsWorksStackTypesStackConfigurationManagerConfigurationManager, IHaveOpsWorksStackTypesSourceCustomCookbooksSource, IHaveCustomJson_Json, IHaveDefaultAvailabilityZone, IHaveDefaultInstanceProfileArn, IHaveDefaultOs, IHaveDefaultRootDeviceType, IHaveDefaultSshKeyName, IHaveDefaultSubnetId, IHaveEcsClusterArn, IHaveListOfOpsWorksStackTypesElasticIpElasticIps, IHaveHostnameTheme, IHaveName, IHaveListOfOpsWorksStackTypesRdsDbInstanceRdsDbInstances, IHaveServiceRoleArn, IHaveSourceStackId, IHaveUseCustomCookbooks_Boolean, IHaveUseOpsworksSecurityGroups_Boolean, IHaveVpcId
    {
        public override string AWSTypeName { get => AWS.OpsWorks.Stack; }
        /// <summary>
        /// AgentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-agentversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AgentVersion { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        /// <summary>
        /// ChefConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-chefconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChefConfiguration
        /// </summary>
        public Union<Humidifier.OpsWorks.StackTypes.ChefConfiguration, BaseFunction>? ChefConfiguration { get; set; }
        /// <summary>
        /// CloneAppIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-cloneappids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CloneAppIds { get; set; }
        /// <summary>
        /// ClonePermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-clonepermissions
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ClonePermissions { get; set; }
        /// <summary>
        /// ConfigurationManager
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-configmanager
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StackConfigurationManager
        /// </summary>
        public Union<Humidifier.OpsWorks.StackTypes.StackConfigurationManager, BaseFunction>? ConfigurationManager { get; set; }
        /// <summary>
        /// CustomCookbooksSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-custcookbooksource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        public Union<Humidifier.OpsWorks.StackTypes.Source, BaseFunction>? CustomCookbooksSource { get; set; }
        /// <summary>
        /// CustomJson
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-custjson
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? CustomJson { get; set; }
        /// <summary>
        /// DefaultAvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-defaultaz
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultAvailabilityZone { get; set; }

        /// <summary>
        /// DefaultInstanceProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-defaultinstanceprof
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DefaultInstanceProfileArn { get; set; }
        /// <summary>
        /// DefaultOs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-defaultos
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultOs { get; set; }
        /// <summary>
        /// DefaultRootDeviceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-defaultrootdevicetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultRootDeviceType { get; set; }
        /// <summary>
        /// DefaultSshKeyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-defaultsshkeyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultSshKeyName { get; set; }
        /// <summary>
        /// DefaultSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#defaultsubnet
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultSubnetId { get; set; }
        /// <summary>
        /// EcsClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-ecsclusterarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EcsClusterArn { get; set; }
        /// <summary>
        /// ElasticIps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-elasticips
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ElasticIp
        /// </summary>
        public Union<IReadOnlyList<Humidifier.OpsWorks.StackTypes.ElasticIp>, IReadOnlyList<Union<Humidifier.OpsWorks.StackTypes.ElasticIp, BaseFunction>>, BaseFunction>? ElasticIps { get; set; }
        /// <summary>
        /// HostnameTheme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-hostnametheme
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostnameTheme { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RdsDbInstances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-rdsdbinstances
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RdsDbInstance
        /// </summary>
        public Union<IReadOnlyList<Humidifier.OpsWorks.StackTypes.RdsDbInstance>, IReadOnlyList<Union<Humidifier.OpsWorks.StackTypes.RdsDbInstance, BaseFunction>>, BaseFunction>? RdsDbInstances { get; set; }

        /// <summary>
        /// ServiceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-servicerolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceRoleArn { get; set; }
        /// <summary>
        /// SourceStackId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-sourcestackid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceStackId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// UseCustomCookbooks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#usecustcookbooks
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseCustomCookbooks { get; set; }
        /// <summary>
        /// UseOpsworksSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-useopsworkssecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseOpsworksSecurityGroups { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html#cfn-opsworks-stack-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
    }

    namespace StackTypes
    {
        public class ChefConfiguration : Humidifier.Base.BaseSubResource, IHaveBerkshelfVersion, IHaveManageBerkshelf_Boolean
        {
            /// <summary>
            /// BerkshelfVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-chefconfiguration.html#cfn-opsworks-chefconfiguration-berkshelfversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BerkshelfVersion { get; set; }
            /// <summary>
            /// ManageBerkshelf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-chefconfiguration.html#cfn-opsworks-chefconfiguration-berkshelfversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ManageBerkshelf { get; set; }
        }

        public class ElasticIp : Humidifier.Base.BaseSubResource, IHaveIp, IHaveName
        {
            /// <summary>
            /// Ip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-elasticip.html#cfn-opsworks-stack-elasticip-ip
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ip { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-elasticip.html#cfn-opsworks-stack-elasticip-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RdsDbInstance : Humidifier.Base.BaseSubResource, IHaveDbPassword, IHaveDbUser, IHaveRdsDbInstanceArn
        {
            /// <summary>
            /// DbPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-rdsdbinstance.html#cfn-opsworks-stack-rdsdbinstance-dbpassword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbPassword { get; set; }
            /// <summary>
            /// DbUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-rdsdbinstance.html#cfn-opsworks-stack-rdsdbinstance-dbuser
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbUser { get; set; }
            /// <summary>
            /// RdsDbInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-rdsdbinstance.html#cfn-opsworks-stack-rdsdbinstance-rdsdbinstancearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RdsDbInstanceArn { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHavePassword, IHaveRevision, IHaveSshKey, IHaveType, IHaveUrl, IHaveUsername
        {
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-revision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Revision { get; set; }
            /// <summary>
            /// SshKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-sshkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SshKey { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html#cfn-opsworks-custcookbooksource-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
        }

        public class StackConfigurationManager : Humidifier.Base.BaseSubResource, IHaveName, IHaveVersion
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-stackconfigmanager.html#cfn-opsworks-configmanager-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-stackconfigmanager.html#cfn-opsworks-configmanager-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }
    }
}