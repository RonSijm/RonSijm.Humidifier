namespace Humidifier.ResilienceHubV2
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfResilienceHubV2ServiceTypesAssociatedSystemAssociatedSystems, IHaveKmsKeyId, IHavePolicyArn, IHaveResilienceHubV2ServiceTypesPermissionModelPermissionModel, IHaveStringListOfRegions, IHaveDependencyDiscovery, IHaveResilienceHubV2ServiceTypesServiceReportConfigurationReportConfiguration, IHaveListOfResilienceHubV2ServiceTypesInputSourceDefinitionInputSources, IHaveListOfResilienceHubV2ServiceTypesAssertionDefinitionAssertions, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string EffectivePolicyValues =  "EffectivePolicyValues" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHubV2.Service; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AssociatedSystems
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-associatedsystems
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedSystem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem, BaseFunction>>, BaseFunction>? AssociatedSystems { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// PolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-policyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyArn { get; set; }
        /// <summary>
        /// PermissionModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-permissionmodel
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PermissionModel
        /// </summary>
        public Union<Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel, BaseFunction>? PermissionModel { get; set; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-regions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
        /// <summary>
        /// DependencyDiscovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-dependencydiscovery
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DependencyDiscovery { get; set; }
        /// <summary>
        /// ReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-reportconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceReportConfiguration
        /// </summary>
        public Union<Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration, BaseFunction>? ReportConfiguration { get; set; }
        /// <summary>
        /// InputSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-inputsources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSourceDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition, BaseFunction>>, BaseFunction>? InputSources { get; set; }
        /// <summary>
        /// Assertions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-assertions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssertionDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition, BaseFunction>>, BaseFunction>? Assertions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ServiceTypes
    {
        public class AssertionDefinition : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-assertiondefinition.html#cfn-resiliencehubv2-service-assertiondefinition-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class AssociatedSystem : Humidifier.Base.BaseSubResource, IHaveSystemArn, IHaveStringListOfUserJourneyIds
        {
            /// <summary>
            /// SystemArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-associatedsystem.html#cfn-resiliencehubv2-service-associatedsystem-systemarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SystemArn { get; set; }
            /// <summary>
            /// UserJourneyIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-associatedsystem.html#cfn-resiliencehubv2-service-associatedsystem-userjourneyids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? UserJourneyIds { get; set; }
        }

        public class CrossAccountRoleConfiguration : Humidifier.Base.BaseSubResource, IHaveCrossAccountRoleArn, IHaveExternalId
        {
            /// <summary>
            /// CrossAccountRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-crossaccountroleconfiguration.html#cfn-resiliencehubv2-service-crossaccountroleconfiguration-crossaccountrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossAccountRoleArn { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-crossaccountroleconfiguration.html#cfn-resiliencehubv2-service-crossaccountroleconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
        }

        public class DisasterRecoverySource : Humidifier.Base.BaseSubResource, IHaveValue, IHavePolicyName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-disasterrecoverysource.html#cfn-resiliencehubv2-service-disasterrecoverysource-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-disasterrecoverysource.html#cfn-resiliencehubv2-service-disasterrecoverysource-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
        }

        public class EffectivePolicyValues : Humidifier.Base.BaseSubResource, IHaveResilienceHubV2ServiceTypesSloSourceAvailabilitySlo, IHaveResilienceHubV2ServiceTypesTargetSourceMultiAzRto, IHaveResilienceHubV2ServiceTypesTargetSourceMultiAzRpo, IHaveResilienceHubV2ServiceTypesDisasterRecoverySourceMultiRegionDrApproach, IHaveResilienceHubV2ServiceTypesTargetSourceMultiRegionRto, IHaveResilienceHubV2ServiceTypesDisasterRecoverySourceMultiAzDrApproach, IHaveResilienceHubV2ServiceTypesTargetSourceMultiRegionRpo
        {
            /// <summary>
            /// AvailabilitySlo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-availabilityslo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SloSource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.SloSource, BaseFunction>? AvailabilitySlo { get; set; }
            /// <summary>
            /// MultiAzRto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiazrto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.TargetSource, BaseFunction>? MultiAzRto { get; set; }
            /// <summary>
            /// MultiAzRpo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiazrpo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.TargetSource, BaseFunction>? MultiAzRpo { get; set; }
            /// <summary>
            /// MultiRegionDrApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiregiondrapproach
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DisasterRecoverySource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.DisasterRecoverySource, BaseFunction>? MultiRegionDrApproach { get; set; }
            /// <summary>
            /// MultiRegionRto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiregionrto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.TargetSource, BaseFunction>? MultiRegionRto { get; set; }
            /// <summary>
            /// MultiAzDrApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiazdrapproach
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DisasterRecoverySource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.DisasterRecoverySource, BaseFunction>? MultiAzDrApproach { get; set; }
            /// <summary>
            /// MultiRegionRpo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiregionrpo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.TargetSource, BaseFunction>? MultiRegionRpo { get; set; }
        }

        public class EksLabelSelector : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfMatchLabels, IHaveListOfResilienceHubV2ServiceTypesEksLabelSelectorRequirementMatchExpressions
        {
            /// <summary>
            /// MatchLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselector.html#cfn-resiliencehubv2-service-ekslabelselector-matchlabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? MatchLabels { get; set; }
            /// <summary>
            /// MatchExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselector.html#cfn-resiliencehubv2-service-ekslabelselector-matchexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksLabelSelectorRequirement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelectorRequirement>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelectorRequirement, BaseFunction>>, BaseFunction>? MatchExpressions { get; set; }
        }

        public class EksLabelSelectorRequirement : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselectorrequirement.html#cfn-resiliencehubv2-service-ekslabelselectorrequirement-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselectorrequirement.html#cfn-resiliencehubv2-service-ekslabelselectorrequirement-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselectorrequirement.html#cfn-resiliencehubv2-service-ekslabelselectorrequirement-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class EksSource : Humidifier.Base.BaseSubResource, IHaveClusterArn, IHaveStringListOfNamespaces, IHaveResilienceHubV2ServiceTypesEksLabelSelectorLabelSelector
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekssource.html#cfn-resiliencehubv2-service-ekssource-clusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterArn { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekssource.html#cfn-resiliencehubv2-service-ekssource-namespaces
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// LabelSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekssource.html#cfn-resiliencehubv2-service-ekssource-labelselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksLabelSelector
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector, BaseFunction>? LabelSelector { get; set; }
        }

        public class InputSourceDefinition : Humidifier.Base.BaseSubResource, IHaveResilienceHubV2ServiceTypesResourceConfigurationResourceConfiguration
        {
            /// <summary>
            /// ResourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-inputsourcedefinition.html#cfn-resiliencehubv2-service-inputsourcedefinition-resourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceConfiguration
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration, BaseFunction>? ResourceConfiguration { get; set; }
        }

        public class PermissionModel : Humidifier.Base.BaseSubResource, IHaveListOfResilienceHubV2ServiceTypesCrossAccountRoleConfigurationCrossAccountRoleArns, IHaveInvokerRoleName
        {
            /// <summary>
            /// CrossAccountRoleArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-permissionmodel.html#cfn-resiliencehubv2-service-permissionmodel-crossaccountrolearns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CrossAccountRoleConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.CrossAccountRoleConfiguration>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.CrossAccountRoleConfiguration, BaseFunction>>, BaseFunction>? CrossAccountRoleArns { get; set; }
            /// <summary>
            /// InvokerRoleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-permissionmodel.html#cfn-resiliencehubv2-service-permissionmodel-invokerrolename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvokerRoleName { get; set; }
        }

        public class ReportOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveResilienceHubV2ServiceTypesS3ReportOutputConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-reportoutputconfiguration.html#cfn-resiliencehubv2-service-reportoutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ReportOutputConfiguration
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.S3ReportOutputConfiguration, BaseFunction>? S3 { get; set; }
        }

        public class ResourceConfiguration : Humidifier.Base.BaseSubResource, IHaveCfnStackArn, IHaveListOfResilienceHubV2ServiceTypesResourceTagResourceTags, IHaveTfStateFileUrl, IHaveResilienceHubV2ServiceTypesEksSourceEks, IHaveDesignFileS3Url
        {
            /// <summary>
            /// CfnStackArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-cfnstackarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CfnStackArn { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceTag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
            /// <summary>
            /// TfStateFileUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-tfstatefileurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TfStateFileUrl { get; set; }
            /// <summary>
            /// Eks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-eks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksSource
            /// </summary>
            public Union<Humidifier.ResilienceHubV2.ServiceTypes.EksSource, BaseFunction>? Eks { get; set; }
            /// <summary>
            /// DesignFileS3Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-designfiles3url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DesignFileS3Url { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourcetag.html#cfn-resiliencehubv2-service-resourcetag-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourcetag.html#cfn-resiliencehubv2-service-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class S3ReportOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketPath, IHaveBucketOwner
        {
            /// <summary>
            /// BucketPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-s3reportoutputconfiguration.html#cfn-resiliencehubv2-service-s3reportoutputconfiguration-bucketpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPath { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-s3reportoutputconfiguration.html#cfn-resiliencehubv2-service-s3reportoutputconfiguration-bucketowner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
        }

        public class ServiceReportConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfResilienceHubV2ServiceTypesReportOutputConfigurationReportOutput
        {
            /// <summary>
            /// ReportOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-servicereportconfiguration.html#cfn-resiliencehubv2-service-servicereportconfiguration-reportoutput
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReportOutputConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ResilienceHubV2.ServiceTypes.ReportOutputConfiguration>, IReadOnlyList<Union<Humidifier.ResilienceHubV2.ServiceTypes.ReportOutputConfiguration, BaseFunction>>, BaseFunction>? ReportOutput { get; set; }
        }

        public class SloSource : Humidifier.Base.BaseSubResource, IHavePolicyName, IHaveValue_Double
        {
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-slosource.html#cfn-resiliencehubv2-service-slosource-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-slosource.html#cfn-resiliencehubv2-service-slosource-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
        }

        public class TargetSource : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHavePolicyName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-targetsource.html#cfn-resiliencehubv2-service-targetsource-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-targetsource.html#cfn-resiliencehubv2-service-targetsource-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
        }
    }
}