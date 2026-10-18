namespace Humidifier.OpenSearchService
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSkipShardMigrationWait_Boolean, IHaveEngineMode, IHaveOpenSearchServiceDomainTypesSnapshotOptionsSnapshotOptions, IHaveOpenSearchServiceDomainTypesNodeToNodeEncryptionOptionsNodeToNodeEncryptionOptions, IHaveOpenSearchServiceDomainTypesDomainEndpointOptionsDomainEndpointOptions, IHaveOpenSearchServiceDomainTypesCognitoOptionsCognitoOptions, IHaveStringDictionaryOfAdvancedOptions, IHaveIPAddressType, IHaveOpenSearchServiceDomainTypesEBSOptionsEBSOptions, IHaveEngineVersion, IHaveOpenSearchServiceDomainTypesSoftwareUpdateOptionsSoftwareUpdateOptions, IHaveDomainName, IHaveMapOfOpenSearchServiceDomainTypesLogPublishingOptionLogPublishingOptions, IHaveOpenSearchServiceDomainTypesAIMLOptionsAIMLOptions, IHaveOpenSearchServiceDomainTypesVPCOptionsVPCOptions, IHaveOpenSearchServiceDomainTypesAutomatedSnapshotPauseOptionsAutomatedSnapshotPauseOptions, IHaveUseCase, IHaveOpenSearchServiceDomainTypesDeploymentStrategyOptionsDeploymentStrategyOptions, IHaveAccessPolicies_Json, IHaveOpenSearchServiceDomainTypesAdvancedSecurityOptionsInputAdvancedSecurityOptions, IHaveOpenSearchServiceDomainTypesIdentityCenterOptionsIdentityCenterOptions, IHaveOpenSearchServiceDomainTypesEncryptionAtRestOptionsEncryptionAtRestOptions, IHaveOpenSearchServiceDomainTypesOffPeakWindowOptionsOffPeakWindowOptions, IHaveOpenSearchServiceDomainTypesClusterConfigClusterConfig
    {
        public class Attributes
        {
            public static string DomainEndpointV2 =  "DomainEndpointV2" ;
            public static string DomainEndpoints =  "DomainEndpoints" ;
            public static string DomainArn =  "DomainArn" ;
            public static string DomainEndpoint =  "DomainEndpoint" ;
            public static string ServiceSoftwareOptions =  "ServiceSoftwareOptions" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchService.Domain; }
        /// <summary>
        /// SkipShardMigrationWait
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-skipshardmigrationwait
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SkipShardMigrationWait { get; set; }
        /// <summary>
        /// EngineMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-enginemode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineMode { get; set; }
        /// <summary>
        /// SnapshotOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-snapshotoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SnapshotOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.SnapshotOptions, BaseFunction>? SnapshotOptions { get; set; }
        /// <summary>
        /// NodeToNodeEncryptionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-nodetonodeencryptionoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NodeToNodeEncryptionOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.NodeToNodeEncryptionOptions, BaseFunction>? NodeToNodeEncryptionOptions { get; set; }
        /// <summary>
        /// DomainEndpointOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-domainendpointoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DomainEndpointOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.DomainEndpointOptions, BaseFunction>? DomainEndpointOptions { get; set; }
        /// <summary>
        /// CognitoOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-cognitooptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CognitoOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.CognitoOptions, BaseFunction>? CognitoOptions { get; set; }
        /// <summary>
        /// AdvancedOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-advancedoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdvancedOptions { get; set; }
        /// <summary>
        /// IPAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IPAddressType { get; set; }
        /// <summary>
        /// EBSOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-ebsoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EBSOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.EBSOptions, BaseFunction>? EBSOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// SoftwareUpdateOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-softwareupdateoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SoftwareUpdateOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.SoftwareUpdateOptions, BaseFunction>? SoftwareUpdateOptions { get; set; }
        public Union<string, BaseFunction>? DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LogPublishingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-logpublishingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: LogPublishingOption
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.OpenSearchService.DomainTypes.LogPublishingOption>, IReadOnlyDictionary<string, Union<Humidifier.OpenSearchService.DomainTypes.LogPublishingOption, BaseFunction>>, BaseFunction>? LogPublishingOptions { get; set; }
        /// <summary>
        /// AIMLOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-aimloptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIMLOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.AIMLOptions, BaseFunction>? AIMLOptions { get; set; }
        /// <summary>
        /// VPCOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-vpcoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VPCOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.VPCOptions, BaseFunction>? VPCOptions { get; set; }
        /// <summary>
        /// AutomatedSnapshotPauseOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-automatedsnapshotpauseoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutomatedSnapshotPauseOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.AutomatedSnapshotPauseOptions, BaseFunction>? AutomatedSnapshotPauseOptions { get; set; }
        /// <summary>
        /// UseCase
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-usecase
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UseCase { get; set; }
        /// <summary>
        /// DeploymentStrategyOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-deploymentstrategyoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentStrategyOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.DeploymentStrategyOptions, BaseFunction>? DeploymentStrategyOptions { get; set; }
        /// <summary>
        /// AccessPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-accesspolicies
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AccessPolicies { get; set; }
        /// <summary>
        /// AdvancedSecurityOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-advancedsecurityoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdvancedSecurityOptionsInput
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.AdvancedSecurityOptionsInput, BaseFunction>? AdvancedSecurityOptions { get; set; }
        /// <summary>
        /// IdentityCenterOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-identitycenteroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityCenterOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.IdentityCenterOptions, BaseFunction>? IdentityCenterOptions { get; set; }
        /// <summary>
        /// EncryptionAtRestOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-encryptionatrestoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionAtRestOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.EncryptionAtRestOptions, BaseFunction>? EncryptionAtRestOptions { get; set; }
        /// <summary>
        /// OffPeakWindowOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-offpeakwindowoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OffPeakWindowOptions
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions, BaseFunction>? OffPeakWindowOptions { get; set; }
        /// <summary>
        /// ClusterConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchservice-domain.html#cfn-opensearchservice-domain-clusterconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClusterConfig
        /// </summary>
        public Union<Humidifier.OpenSearchService.DomainTypes.ClusterConfig, BaseFunction>? ClusterConfig { get; set; }
    }

    namespace DomainTypes
    {
        public class AIMLOptions : Humidifier.Base.BaseSubResource, IHaveOpenSearchServiceDomainTypesS3VectorsEngineS3VectorsEngine, IHaveOpenSearchServiceDomainTypesServerlessVectorAccelerationServerlessVectorAcceleration
        {
            /// <summary>
            /// S3VectorsEngine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-aimloptions.html#cfn-opensearchservice-domain-aimloptions-s3vectorsengine
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3VectorsEngine
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine, BaseFunction>? S3VectorsEngine { get; set; }
            /// <summary>
            /// ServerlessVectorAcceleration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-aimloptions.html#cfn-opensearchservice-domain-aimloptions-serverlessvectoracceleration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServerlessVectorAcceleration
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration, BaseFunction>? ServerlessVectorAcceleration { get; set; }
        }

        public class AdvancedSecurityOptionsInput : Humidifier.Base.BaseSubResource, IHaveOpenSearchServiceDomainTypesIAMFederationOptionsIAMFederationOptions, IHaveAnonymousAuthEnabled_Boolean, IHaveInternalUserDatabaseEnabled_Boolean, IHaveOpenSearchServiceDomainTypesSAMLOptionsSAMLOptions, IHaveEnabled_Boolean, IHaveOpenSearchServiceDomainTypesJWTOptionsJWTOptions, IHaveAnonymousAuthDisableDate, IHaveOpenSearchServiceDomainTypesMasterUserOptionsMasterUserOptions
        {
            /// <summary>
            /// IAMFederationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-iamfederationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IAMFederationOptions
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.IAMFederationOptions, BaseFunction>? IAMFederationOptions { get; set; }
            /// <summary>
            /// AnonymousAuthEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-anonymousauthenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AnonymousAuthEnabled { get; set; }
            /// <summary>
            /// InternalUserDatabaseEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-internaluserdatabaseenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InternalUserDatabaseEnabled { get; set; }
            /// <summary>
            /// SAMLOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-samloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAMLOptions
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.SAMLOptions, BaseFunction>? SAMLOptions { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// JWTOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-jwtoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JWTOptions
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.JWTOptions, BaseFunction>? JWTOptions { get; set; }
            /// <summary>
            /// AnonymousAuthDisableDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-anonymousauthdisabledate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnonymousAuthDisableDate { get; set; }
            /// <summary>
            /// MasterUserOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-advancedsecurityoptionsinput.html#cfn-opensearchservice-domain-advancedsecurityoptionsinput-masteruseroptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MasterUserOptions
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.MasterUserOptions, BaseFunction>? MasterUserOptions { get; set; }
        }

        public class AutomatedSnapshotPauseOptions : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime, IHaveEnabled_Boolean
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-automatedsnapshotpauseoptions.html#cfn-opensearchservice-domain-automatedsnapshotpauseoptions-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-automatedsnapshotpauseoptions.html#cfn-opensearchservice-domain-automatedsnapshotpauseoptions-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-automatedsnapshotpauseoptions.html#cfn-opensearchservice-domain-automatedsnapshotpauseoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveMultiAZWithStandbyEnabled_Boolean, IHaveDedicatedMasterEnabled_Boolean, IHaveOpenSearchServiceDomainTypesZoneAwarenessConfigZoneAwarenessConfig, IHaveOpenSearchServiceDomainTypesColdStorageOptionsColdStorageOptions, IHaveListOfOpenSearchServiceDomainTypesNodeOptionNodeOptions, IHaveWarmType, IHaveInstanceCount_Integer, IHaveWarmEnabled_Boolean, IHaveWarmCount_Integer, IHaveDedicatedMasterCount_Integer, IHaveInstanceType, IHaveZoneAwarenessEnabled_Boolean, IHaveDedicatedMasterType
        {
            /// <summary>
            /// MultiAZWithStandbyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-multiazwithstandbyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiAZWithStandbyEnabled { get; set; }
            /// <summary>
            /// DedicatedMasterEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-dedicatedmasterenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DedicatedMasterEnabled { get; set; }
            /// <summary>
            /// ZoneAwarenessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-zoneawarenessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZoneAwarenessConfig
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig, BaseFunction>? ZoneAwarenessConfig { get; set; }
            /// <summary>
            /// ColdStorageOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-coldstorageoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColdStorageOptions
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions, BaseFunction>? ColdStorageOptions { get; set; }
            /// <summary>
            /// NodeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-nodeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NodeOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.OpenSearchService.DomainTypes.NodeOption>, IReadOnlyList<Union<Humidifier.OpenSearchService.DomainTypes.NodeOption, BaseFunction>>, BaseFunction>? NodeOptions { get; set; }
            /// <summary>
            /// WarmType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-warmtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WarmType { get; set; }
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-instancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// WarmEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-warmenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WarmEnabled { get; set; }
            /// <summary>
            /// WarmCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-warmcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WarmCount { get; set; }
            /// <summary>
            /// DedicatedMasterCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-dedicatedmastercount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DedicatedMasterCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// ZoneAwarenessEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-zoneawarenessenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ZoneAwarenessEnabled { get; set; }
            /// <summary>
            /// DedicatedMasterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-clusterconfig.html#cfn-opensearchservice-domain-clusterconfig-dedicatedmastertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DedicatedMasterType { get; set; }
        }

        public class CognitoOptions : Humidifier.Base.BaseSubResource, IHaveUserPoolId, IHaveEnabled_Boolean, IHaveIdentityPoolId, IHaveRoleArn
        {
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-cognitooptions.html#cfn-opensearchservice-domain-cognitooptions-userpoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolId { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-cognitooptions.html#cfn-opensearchservice-domain-cognitooptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// IdentityPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-cognitooptions.html#cfn-opensearchservice-domain-cognitooptions-identitypoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityPoolId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-cognitooptions.html#cfn-opensearchservice-domain-cognitooptions-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ColdStorageOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-coldstorageoptions.html#cfn-opensearchservice-domain-coldstorageoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DeploymentStrategyOptions : Humidifier.Base.BaseSubResource, IHaveDeploymentStrategy
        {
            /// <summary>
            /// DeploymentStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-deploymentstrategyoptions.html#cfn-opensearchservice-domain-deploymentstrategyoptions-deploymentstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentStrategy { get; set; }
        }

        public class DomainEndpointOptions : Humidifier.Base.BaseSubResource, IHaveCustomEndpointEnabled_Boolean, IHaveEnforceHTTPS_Boolean, IHaveCustomEndpointCertificateArn, IHaveCustomEndpoint, IHaveTLSSecurityPolicy
        {
            /// <summary>
            /// CustomEndpointEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-domainendpointoptions.html#cfn-opensearchservice-domain-domainendpointoptions-customendpointenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CustomEndpointEnabled { get; set; }
            /// <summary>
            /// EnforceHTTPS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-domainendpointoptions.html#cfn-opensearchservice-domain-domainendpointoptions-enforcehttps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnforceHTTPS { get; set; }
            /// <summary>
            /// CustomEndpointCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-domainendpointoptions.html#cfn-opensearchservice-domain-domainendpointoptions-customendpointcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEndpointCertificateArn { get; set; }
            /// <summary>
            /// CustomEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-domainendpointoptions.html#cfn-opensearchservice-domain-domainendpointoptions-customendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomEndpoint { get; set; }
            /// <summary>
            /// TLSSecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-domainendpointoptions.html#cfn-opensearchservice-domain-domainendpointoptions-tlssecuritypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TLSSecurityPolicy { get; set; }
        }

        public class EBSOptions : Humidifier.Base.BaseSubResource, IHaveEBSEnabled_Boolean, IHaveVolumeType, IHaveThroughput_Integer, IHaveIops_Integer, IHaveVolumeSize_Integer
        {
            /// <summary>
            /// EBSEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-ebsoptions.html#cfn-opensearchservice-domain-ebsoptions-ebsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EBSEnabled { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-ebsoptions.html#cfn-opensearchservice-domain-ebsoptions-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-ebsoptions.html#cfn-opensearchservice-domain-ebsoptions-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-ebsoptions.html#cfn-opensearchservice-domain-ebsoptions-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-ebsoptions.html#cfn-opensearchservice-domain-ebsoptions-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
        }

        public class EncryptionAtRestOptions : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveEnabled_Boolean
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-encryptionatrestoptions.html#cfn-opensearchservice-domain-encryptionatrestoptions-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-encryptionatrestoptions.html#cfn-opensearchservice-domain-encryptionatrestoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class IAMFederationOptions : Humidifier.Base.BaseSubResource, IHaveSubjectKey, IHaveRolesKey, IHaveEnabled_Boolean
        {
            /// <summary>
            /// SubjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-iamfederationoptions.html#cfn-opensearchservice-domain-iamfederationoptions-subjectkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubjectKey { get; set; }
            /// <summary>
            /// RolesKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-iamfederationoptions.html#cfn-opensearchservice-domain-iamfederationoptions-roleskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RolesKey { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-iamfederationoptions.html#cfn-opensearchservice-domain-iamfederationoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class IdentityCenterOptions : Humidifier.Base.BaseSubResource, IHaveIdentityCenterApplicationARN, IHaveIdentityCenterInstanceARN, IHaveSubjectKey, IHaveEnabledAPIAccess_Boolean, IHaveRolesKey, IHaveIdentityStoreId
        {
            /// <summary>
            /// IdentityCenterApplicationARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-identitycenteroptions.html#cfn-opensearchservice-domain-identitycenteroptions-identitycenterapplicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityCenterApplicationARN { get; set; }
            /// <summary>
            /// IdentityCenterInstanceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-identitycenteroptions.html#cfn-opensearchservice-domain-identitycenteroptions-identitycenterinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityCenterInstanceARN { get; set; }
            /// <summary>
            /// SubjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-identitycenteroptions.html#cfn-opensearchservice-domain-identitycenteroptions-subjectkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubjectKey { get; set; }
            /// <summary>
            /// EnabledAPIAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-identitycenteroptions.html#cfn-opensearchservice-domain-identitycenteroptions-enabledapiaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnabledAPIAccess { get; set; }
            /// <summary>
            /// RolesKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-identitycenteroptions.html#cfn-opensearchservice-domain-identitycenteroptions-roleskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RolesKey { get; set; }
            /// <summary>
            /// IdentityStoreId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-identitycenteroptions.html#cfn-opensearchservice-domain-identitycenteroptions-identitystoreid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityStoreId { get; set; }
        }

        public class Idp : Humidifier.Base.BaseSubResource, IHaveEntityId, IHaveMetadataContent
        {
            /// <summary>
            /// EntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-idp.html#cfn-opensearchservice-domain-idp-entityid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityId { get; set; }
            /// <summary>
            /// MetadataContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-idp.html#cfn-opensearchservice-domain-idp-metadatacontent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataContent { get; set; }
        }

        public class JWTOptions : Humidifier.Base.BaseSubResource, IHaveSubjectKey, IHavePublicKey, IHaveRolesKey, IHaveEnabled_Boolean
        {
            /// <summary>
            /// SubjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-jwtoptions.html#cfn-opensearchservice-domain-jwtoptions-subjectkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubjectKey { get; set; }
            /// <summary>
            /// PublicKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-jwtoptions.html#cfn-opensearchservice-domain-jwtoptions-publickey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicKey { get; set; }
            /// <summary>
            /// RolesKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-jwtoptions.html#cfn-opensearchservice-domain-jwtoptions-roleskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RolesKey { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-jwtoptions.html#cfn-opensearchservice-domain-jwtoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class LogPublishingOption : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogsLogGroupArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// CloudWatchLogsLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-logpublishingoption.html#cfn-opensearchservice-domain-logpublishingoption-cloudwatchlogsloggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogsLogGroupArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-logpublishingoption.html#cfn-opensearchservice-domain-logpublishingoption-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class MasterUserOptions : Humidifier.Base.BaseSubResource, IHaveMasterUserPassword, IHaveMasterUserARN, IHaveMasterUserName
        {
            /// <summary>
            /// MasterUserPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-masteruseroptions.html#cfn-opensearchservice-domain-masteruseroptions-masteruserpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserPassword { get; set; }
            /// <summary>
            /// MasterUserARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-masteruseroptions.html#cfn-opensearchservice-domain-masteruseroptions-masteruserarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserARN { get; set; }
            /// <summary>
            /// MasterUserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-masteruseroptions.html#cfn-opensearchservice-domain-masteruseroptions-masterusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserName { get; set; }
        }

        public class NodeConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveEnabled_Boolean, IHaveCount_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-nodeconfig.html#cfn-opensearchservice-domain-nodeconfig-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-nodeconfig.html#cfn-opensearchservice-domain-nodeconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-nodeconfig.html#cfn-opensearchservice-domain-nodeconfig-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
        }

        public class NodeOption : Humidifier.Base.BaseSubResource, IHaveNodeType, IHaveOpenSearchServiceDomainTypesNodeConfigNodeConfig
        {
            /// <summary>
            /// NodeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-nodeoption.html#cfn-opensearchservice-domain-nodeoption-nodetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeType { get; set; }
            /// <summary>
            /// NodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-nodeoption.html#cfn-opensearchservice-domain-nodeoption-nodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NodeConfig
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.NodeConfig, BaseFunction>? NodeConfig { get; set; }
        }

        public class NodeToNodeEncryptionOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-nodetonodeencryptionoptions.html#cfn-opensearchservice-domain-nodetonodeencryptionoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class OffPeakWindow : Humidifier.Base.BaseSubResource, IHaveOpenSearchServiceDomainTypesWindowStartTimeWindowStartTime
        {
            /// <summary>
            /// WindowStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-offpeakwindow.html#cfn-opensearchservice-domain-offpeakwindow-windowstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WindowStartTime
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.WindowStartTime, BaseFunction>? WindowStartTime { get; set; }
        }

        public class OffPeakWindowOptions : Humidifier.Base.BaseSubResource, IHaveOpenSearchServiceDomainTypesOffPeakWindowOffPeakWindow, IHaveEnabled_Boolean
        {
            /// <summary>
            /// OffPeakWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-offpeakwindowoptions.html#cfn-opensearchservice-domain-offpeakwindowoptions-offpeakwindow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OffPeakWindow
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow, BaseFunction>? OffPeakWindow { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-offpeakwindowoptions.html#cfn-opensearchservice-domain-offpeakwindowoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class S3VectorsEngine : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-s3vectorsengine.html#cfn-opensearchservice-domain-s3vectorsengine-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class SAMLOptions : Humidifier.Base.BaseSubResource, IHaveMasterBackendRole, IHaveSubjectKey, IHaveOpenSearchServiceDomainTypesIdpIdp, IHaveSessionTimeoutMinutes_Integer, IHaveRolesKey, IHaveEnabled_Boolean, IHaveMasterUserName
        {
            /// <summary>
            /// MasterBackendRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-masterbackendrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterBackendRole { get; set; }
            /// <summary>
            /// SubjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-subjectkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubjectKey { get; set; }
            /// <summary>
            /// Idp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-idp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Idp
            /// </summary>
            public Union<Humidifier.OpenSearchService.DomainTypes.Idp, BaseFunction>? Idp { get; set; }
            /// <summary>
            /// SessionTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-sessiontimeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SessionTimeoutMinutes { get; set; }
            /// <summary>
            /// RolesKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-roleskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RolesKey { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MasterUserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-samloptions.html#cfn-opensearchservice-domain-samloptions-masterusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MasterUserName { get; set; }
        }

        public class ServerlessVectorAcceleration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-serverlessvectoracceleration.html#cfn-opensearchservice-domain-serverlessvectoracceleration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ServiceSoftwareOptions : Humidifier.Base.BaseSubResource, IHaveNewVersion, IHaveUpdateStatus, IHaveDescription, IHaveCancellable_Boolean, IHaveCurrentVersion, IHaveAutomatedUpdateDate, IHaveUpdateAvailable_Boolean, IHaveOptionalDeployment_Boolean
        {
            /// <summary>
            /// NewVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-newversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewVersion { get; set; }
            /// <summary>
            /// UpdateStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-updatestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateStatus { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Cancellable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-cancellable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Cancellable { get; set; }
            /// <summary>
            /// CurrentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-currentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CurrentVersion { get; set; }
            /// <summary>
            /// AutomatedUpdateDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-automatedupdatedate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutomatedUpdateDate { get; set; }
            /// <summary>
            /// UpdateAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-updateavailable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UpdateAvailable { get; set; }
            /// <summary>
            /// OptionalDeployment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-servicesoftwareoptions.html#cfn-opensearchservice-domain-servicesoftwareoptions-optionaldeployment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OptionalDeployment { get; set; }
        }

        public class SnapshotOptions : Humidifier.Base.BaseSubResource, IHaveAutomatedSnapshotStartHour_Integer
        {
            /// <summary>
            /// AutomatedSnapshotStartHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-snapshotoptions.html#cfn-opensearchservice-domain-snapshotoptions-automatedsnapshotstarthour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomatedSnapshotStartHour { get; set; }
        }

        public class SoftwareUpdateOptions : Humidifier.Base.BaseSubResource, IHaveAutoSoftwareUpdateEnabled_Boolean, IHaveUseLatestServiceSoftwareForBlueGreen_Boolean
        {
            /// <summary>
            /// AutoSoftwareUpdateEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-softwareupdateoptions.html#cfn-opensearchservice-domain-softwareupdateoptions-autosoftwareupdateenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoSoftwareUpdateEnabled { get; set; }
            /// <summary>
            /// UseLatestServiceSoftwareForBlueGreen
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-softwareupdateoptions.html#cfn-opensearchservice-domain-softwareupdateoptions-uselatestservicesoftwareforbluegreen
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseLatestServiceSoftwareForBlueGreen { get; set; }
        }

        public class VPCOptions : Humidifier.Base.BaseSubResource, IHaveEgressEnabled_Boolean, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// EgressEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-vpcoptions.html#cfn-opensearchservice-domain-vpcoptions-egressenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EgressEnabled { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-vpcoptions.html#cfn-opensearchservice-domain-vpcoptions-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-vpcoptions.html#cfn-opensearchservice-domain-vpcoptions-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class WindowStartTime : Humidifier.Base.BaseSubResource, IHaveHours_Integer, IHaveMinutes_Integer
        {
            /// <summary>
            /// Hours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-windowstarttime.html#cfn-opensearchservice-domain-windowstarttime-hours
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Hours { get; set; }
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-windowstarttime.html#cfn-opensearchservice-domain-windowstarttime-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minutes { get; set; }
        }

        public class ZoneAwarenessConfig : Humidifier.Base.BaseSubResource, IHaveAvailabilityZoneCount_Integer
        {
            /// <summary>
            /// AvailabilityZoneCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchservice-domain-zoneawarenessconfig.html#cfn-opensearchservice-domain-zoneawarenessconfig-availabilityzonecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AvailabilityZoneCount { get; set; }
        }
    }
}