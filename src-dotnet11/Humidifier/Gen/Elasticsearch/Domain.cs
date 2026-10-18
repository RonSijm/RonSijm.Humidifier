namespace Humidifier.Elasticsearch
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAccessPolicies_Json, IHaveStringDictionaryOfAdvancedOptions, IHaveElasticsearchDomainTypesAdvancedSecurityOptionsInputAdvancedSecurityOptions, IHaveElasticsearchDomainTypesCognitoOptionsCognitoOptions, IHaveElasticsearchDomainTypesDomainEndpointOptionsDomainEndpointOptions, IHaveDomainName, IHaveElasticsearchDomainTypesEBSOptionsEBSOptions, IHaveElasticsearchDomainTypesElasticsearchClusterConfigElasticsearchClusterConfig, IHaveElasticsearchVersion, IHaveElasticsearchDomainTypesEncryptionAtRestOptionsEncryptionAtRestOptions, IHaveMapOfElasticsearchDomainTypesLogPublishingOptionLogPublishingOptions, IHaveElasticsearchDomainTypesNodeToNodeEncryptionOptionsNodeToNodeEncryptionOptions, IHaveElasticsearchDomainTypesSnapshotOptionsSnapshotOptions, IHaveElasticsearchDomainTypesVPCOptionsVPCOptions
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string DomainArn =  "DomainArn" ;
            public static string DomainEndpoint =  "DomainEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.Elasticsearch.Domain; }
        /// <summary>
        /// AccessPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-accesspolicies
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AccessPolicies { get; set; }
        /// <summary>
        /// AdvancedOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-advancedoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdvancedOptions { get; set; }
        /// <summary>
        /// AdvancedSecurityOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-advancedsecurityoptions
        /// Required: False
        /// UpdateType: Conditional
        /// Type: AdvancedSecurityOptionsInput
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.AdvancedSecurityOptionsInput, BaseFunction>? AdvancedSecurityOptions { get; set; }
        /// <summary>
        /// CognitoOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-cognitooptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CognitoOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.CognitoOptions, BaseFunction>? CognitoOptions { get; set; }
        /// <summary>
        /// DomainEndpointOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-domainendpointoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DomainEndpointOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.DomainEndpointOptions, BaseFunction>? DomainEndpointOptions { get; set; }
        public Union<string, BaseFunction>? DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EBSOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-ebsoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EBSOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.EBSOptions, BaseFunction>? EBSOptions { get; set; }
        /// <summary>
        /// ElasticsearchClusterConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-elasticsearchclusterconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ElasticsearchClusterConfig
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.ElasticsearchClusterConfig, BaseFunction>? ElasticsearchClusterConfig { get; set; }
        /// <summary>
        /// ElasticsearchVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-elasticsearchversion
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ElasticsearchVersion { get; set; }
        /// <summary>
        /// EncryptionAtRestOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-encryptionatrestoptions
        /// Required: False
        /// UpdateType: Conditional
        /// Type: EncryptionAtRestOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.EncryptionAtRestOptions, BaseFunction>? EncryptionAtRestOptions { get; set; }
        /// <summary>
        /// LogPublishingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-logpublishingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: LogPublishingOption
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.Elasticsearch.DomainTypes.LogPublishingOption>, IReadOnlyDictionary<string, Union<Humidifier.Elasticsearch.DomainTypes.LogPublishingOption, BaseFunction>>, BaseFunction>? LogPublishingOptions { get; set; }
        /// <summary>
        /// NodeToNodeEncryptionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-nodetonodeencryptionoptions
        /// Required: False
        /// UpdateType: Conditional
        /// Type: NodeToNodeEncryptionOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.NodeToNodeEncryptionOptions, BaseFunction>? NodeToNodeEncryptionOptions { get; set; }
        /// <summary>
        /// SnapshotOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-snapshotoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SnapshotOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.SnapshotOptions, BaseFunction>? SnapshotOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// VPCOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticsearch-domain.html#cfn-elasticsearch-domain-vpcoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VPCOptions
        /// </summary>
        public Union<Humidifier.Elasticsearch.DomainTypes.VPCOptions, BaseFunction>? VPCOptions { get; set; }
    }

    namespace DomainTypes
    {
        public class AdvancedSecurityOptionsInput : Humidifier.Base.BaseSubResource, IHaveAnonymousAuthEnabled_Boolean, IHaveEnabled_Boolean, IHaveInternalUserDatabaseEnabled_Boolean, IHaveElasticsearchDomainTypesMasterUserOptionsMasterUserOptions
        {
            /// <summary>
            /// AnonymousAuthEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-advancedsecurityoptionsinput.html#cfn-elasticsearch-domain-advancedsecurityoptionsinput-anonymousauthenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AnonymousAuthEnabled { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-advancedsecurityoptionsinput.html#cfn-elasticsearch-domain-advancedsecurityoptionsinput-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// InternalUserDatabaseEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-advancedsecurityoptionsinput.html#cfn-elasticsearch-domain-advancedsecurityoptionsinput-internaluserdatabaseenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InternalUserDatabaseEnabled { get; set; }
            /// <summary>
            /// MasterUserOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-advancedsecurityoptionsinput.html#cfn-elasticsearch-domain-advancedsecurityoptionsinput-masteruseroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MasterUserOptions
            /// </summary>
            public Union<Humidifier.Elasticsearch.DomainTypes.MasterUserOptions, BaseFunction>? MasterUserOptions { get; set; }
        }

        public class CognitoOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveIdentityPoolId, IHaveRoleArn, IHaveUserPoolId
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-cognitooptions.html#cfn-elasticsearch-domain-cognitooptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// IdentityPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-cognitooptions.html#cfn-elasticsearch-domain-cognitooptions-identitypoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityPoolId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-cognitooptions.html#cfn-elasticsearch-domain-cognitooptions-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-cognitooptions.html#cfn-elasticsearch-domain-cognitooptions-userpoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolId { get; set; }
        }

        public class ColdStorageOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-coldstorageoptions.html#cfn-elasticsearch-domain-coldstorageoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DomainEndpointOptions : Humidifier.Base.BaseSubResource, IHaveCustomEndpoint, IHaveCustomEndpointCertificateArn, IHaveCustomEndpointEnabled_Boolean, IHaveEnforceHTTPS_Boolean, IHaveTLSSecurityPolicy
        {
            /// <summary>
            /// CustomEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-customendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEndpoint { get; set; }
            /// <summary>
            /// CustomEndpointCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-customendpointcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEndpointCertificateArn { get; set; }
            /// <summary>
            /// CustomEndpointEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-customendpointenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CustomEndpointEnabled { get; set; }
            /// <summary>
            /// EnforceHTTPS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-enforcehttps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnforceHTTPS { get; set; }
            /// <summary>
            /// TLSSecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-tlssecuritypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TLSSecurityPolicy { get; set; }
        }

        public class EBSOptions : Humidifier.Base.BaseSubResource, IHaveEBSEnabled_Boolean, IHaveIops_Integer, IHaveVolumeSize_Integer, IHaveVolumeType
        {
            /// <summary>
            /// EBSEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-ebsoptions.html#cfn-elasticsearch-domain-ebsoptions-ebsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EBSEnabled { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-ebsoptions.html#cfn-elasticsearch-domain-ebsoptions-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-ebsoptions.html#cfn-elasticsearch-domain-ebsoptions-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-ebsoptions.html#cfn-elasticsearch-domain-ebsoptions-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
        }

        public class ElasticsearchClusterConfig : Humidifier.Base.BaseSubResource, IHaveElasticsearchDomainTypesColdStorageOptionsColdStorageOptions, IHaveDedicatedMasterCount_Integer, IHaveDedicatedMasterEnabled_Boolean, IHaveDedicatedMasterType, IHaveInstanceCount_Integer, IHaveInstanceType, IHaveWarmCount_Integer, IHaveWarmEnabled_Boolean, IHaveWarmType, IHaveElasticsearchDomainTypesZoneAwarenessConfigZoneAwarenessConfig, IHaveZoneAwarenessEnabled_Boolean
        {
            /// <summary>
            /// ColdStorageOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticsearchclusterconfig-coldstorageoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColdStorageOptions
            /// </summary>
            public Union<Humidifier.Elasticsearch.DomainTypes.ColdStorageOptions, BaseFunction>? ColdStorageOptions { get; set; }
            /// <summary>
            /// DedicatedMasterCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticseachclusterconfig-dedicatedmastercount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DedicatedMasterCount { get; set; }
            /// <summary>
            /// DedicatedMasterEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticseachclusterconfig-dedicatedmasterenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DedicatedMasterEnabled { get; set; }
            /// <summary>
            /// DedicatedMasterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticseachclusterconfig-dedicatedmastertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DedicatedMasterType { get; set; }
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticseachclusterconfig-instancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticseachclusterconfig-instnacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// WarmCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticsearchclusterconfig-warmcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WarmCount { get; set; }
            /// <summary>
            /// WarmEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticsearchclusterconfig-warmenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WarmEnabled { get; set; }
            /// <summary>
            /// WarmType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticsearchclusterconfig-warmtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WarmType { get; set; }
            /// <summary>
            /// ZoneAwarenessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticsearchclusterconfig-zoneawarenessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZoneAwarenessConfig
            /// </summary>
            public Union<Humidifier.Elasticsearch.DomainTypes.ZoneAwarenessConfig, BaseFunction>? ZoneAwarenessConfig { get; set; }
            /// <summary>
            /// ZoneAwarenessEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-elasticsearchclusterconfig.html#cfn-elasticsearch-domain-elasticseachclusterconfig-zoneawarenessenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ZoneAwarenessEnabled { get; set; }
        }

        public class EncryptionAtRestOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveKmsKeyId
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-encryptionatrestoptions.html#cfn-elasticsearch-domain-encryptionatrestoptions-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-encryptionatrestoptions.html#cfn-elasticsearch-domain-encryptionatrestoptions-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class LogPublishingOption : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogsLogGroupArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// CloudWatchLogsLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-logpublishingoption.html#cfn-elasticsearch-domain-logpublishingoption-cloudwatchlogsloggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogsLogGroupArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-logpublishingoption.html#cfn-elasticsearch-domain-logpublishingoption-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class MasterUserOptions : Humidifier.Base.BaseSubResource, IHaveMasterUserARN, IHaveMasterUserName, IHaveMasterUserPassword
        {
            /// <summary>
            /// MasterUserARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-masteruseroptions.html#cfn-elasticsearch-domain-masteruseroptions-masteruserarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserARN { get; set; }
            /// <summary>
            /// MasterUserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-masteruseroptions.html#cfn-elasticsearch-domain-masteruseroptions-masterusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserName { get; set; }
            /// <summary>
            /// MasterUserPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-masteruseroptions.html#cfn-elasticsearch-domain-masteruseroptions-masteruserpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserPassword { get; set; }
        }

        public class NodeToNodeEncryptionOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-nodetonodeencryptionoptions.html#cfn-elasticsearch-domain-nodetonodeencryptionoptions-enabled
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class SnapshotOptions : Humidifier.Base.BaseSubResource, IHaveAutomatedSnapshotStartHour_Integer
        {
            /// <summary>
            /// AutomatedSnapshotStartHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-snapshotoptions.html#cfn-elasticsearch-domain-snapshotoptions-automatedsnapshotstarthour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomatedSnapshotStartHour { get; set; }
        }

        public class VPCOptions : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-vpcoptions.html#cfn-elasticsearch-domain-vpcoptions-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-vpcoptions.html#cfn-elasticsearch-domain-vpcoptions-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class ZoneAwarenessConfig : Humidifier.Base.BaseSubResource, IHaveAvailabilityZoneCount_Integer
        {
            /// <summary>
            /// AvailabilityZoneCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-zoneawarenessconfig.html#cfn-elasticsearch-domain-zoneawarenessconfig-availabilityzonecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AvailabilityZoneCount { get; set; }
        }
    }
}