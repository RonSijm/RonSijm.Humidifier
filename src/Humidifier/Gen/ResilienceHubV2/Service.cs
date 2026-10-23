namespace Humidifier.ResilienceHubV2
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveKmsKeyId, IHaveRegions, IHavePolicyArn
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
        public dynamic Description { get; set; }
        /// <summary>
        /// AssociatedSystems
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-associatedsystems
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedSystem
        /// </summary>
        public List<Humidifier.ResilienceHubV2.ServiceTypes.AssociatedSystem> AssociatedSystems { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-regions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Regions { get; set; }
        /// <summary>
        /// Assertions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-assertions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssertionDefinition
        /// </summary>
        public List<Humidifier.ResilienceHubV2.ServiceTypes.AssertionDefinition> Assertions { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-policyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyArn { get; set; }
        /// <summary>
        /// PermissionModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-permissionmodel
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PermissionModel
        /// </summary>
        public Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel PermissionModel { get; set; }
        /// <summary>
        /// DependencyDiscovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-dependencydiscovery
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DependencyDiscovery { get; set; }
        /// <summary>
        /// ReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-reportconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceReportConfiguration
        /// </summary>
        public Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration ReportConfiguration { get; set; }
        /// <summary>
        /// InputSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-inputsources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSourceDefinition
        /// </summary>
        public List<Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition> InputSources { get; set; }
        /// <summary>
        /// DevOpsAgentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-devopsagentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DevOpsAgentConfiguration
        /// </summary>
        public Humidifier.ResilienceHubV2.ServiceTypes.DevOpsAgentConfiguration DevOpsAgentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-service.html#cfn-resiliencehubv2-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Text { get; set; }
        }

        public class AssociatedSystem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SystemArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-associatedsystem.html#cfn-resiliencehubv2-service-associatedsystem-systemarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SystemArn { get; set; }
            /// <summary>
            /// UserJourneyIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-associatedsystem.html#cfn-resiliencehubv2-service-associatedsystem-userjourneyids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic UserJourneyIds { get; set; }
        }

        public class CrossAccountRoleConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId
        {
            /// <summary>
            /// CrossAccountRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-crossaccountroleconfiguration.html#cfn-resiliencehubv2-service-crossaccountroleconfiguration-crossaccountrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrossAccountRoleArn { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-crossaccountroleconfiguration.html#cfn-resiliencehubv2-service-crossaccountroleconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
        }

        public class DevOpsAgentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentSpaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-devopsagentconfiguration.html#cfn-resiliencehubv2-service-devopsagentconfiguration-agentspacearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentSpaceArn { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-disasterrecoverysource.html#cfn-resiliencehubv2-service-disasterrecoverysource-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyName { get; set; }
        }

        public class EffectivePolicyValues : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AvailabilitySlo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-availabilityslo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SloSource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.SloSource AvailabilitySlo { get; set; }
            /// <summary>
            /// MultiAzRto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiazrto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.TargetSource MultiAzRto { get; set; }
            /// <summary>
            /// MultiAzRpo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiazrpo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.TargetSource MultiAzRpo { get; set; }
            /// <summary>
            /// MultiRegionDrApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiregiondrapproach
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DisasterRecoverySource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.DisasterRecoverySource MultiRegionDrApproach { get; set; }
            /// <summary>
            /// MultiRegionRto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiregionrto
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.TargetSource MultiRegionRto { get; set; }
            /// <summary>
            /// MultiAzDrApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiazdrapproach
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DisasterRecoverySource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.DisasterRecoverySource MultiAzDrApproach { get; set; }
            /// <summary>
            /// MultiRegionRpo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-effectivepolicyvalues.html#cfn-resiliencehubv2-service-effectivepolicyvalues-multiregionrpo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetSource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.TargetSource MultiRegionRpo { get; set; }
        }

        public class EksLabelSelector : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselector.html#cfn-resiliencehubv2-service-ekslabelselector-matchlabels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> MatchLabels { get; set; }
            /// <summary>
            /// MatchExpressions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselector.html#cfn-resiliencehubv2-service-ekslabelselector-matchexpressions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksLabelSelectorRequirement
            /// </summary>
            public List<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelectorRequirement> MatchExpressions { get; set; }
        }

        public class EksLabelSelectorRequirement : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselectorrequirement.html#cfn-resiliencehubv2-service-ekslabelselectorrequirement-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselectorrequirement.html#cfn-resiliencehubv2-service-ekslabelselectorrequirement-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekslabelselectorrequirement.html#cfn-resiliencehubv2-service-ekslabelselectorrequirement-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class EksSource : Humidifier.Base.BaseSubResource, IHaveClusterArn
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekssource.html#cfn-resiliencehubv2-service-ekssource-clusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterArn { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekssource.html#cfn-resiliencehubv2-service-ekssource-namespaces
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// LabelSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-ekssource.html#cfn-resiliencehubv2-service-ekssource-labelselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksLabelSelector
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector LabelSelector { get; set; }
        }

        public class InputSourceDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-inputsourcedefinition.html#cfn-resiliencehubv2-service-inputsourcedefinition-resourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceConfiguration
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration ResourceConfiguration { get; set; }
        }

        public class PermissionModel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CrossAccountRoleArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-permissionmodel.html#cfn-resiliencehubv2-service-permissionmodel-crossaccountrolearns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CrossAccountRoleConfiguration
            /// </summary>
            public List<Humidifier.ResilienceHubV2.ServiceTypes.CrossAccountRoleConfiguration> CrossAccountRoleArns { get; set; }
            /// <summary>
            /// InvokerRoleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-permissionmodel.html#cfn-resiliencehubv2-service-permissionmodel-invokerrolename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvokerRoleName { get; set; }
        }

        public class ReportOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-reportoutputconfiguration.html#cfn-resiliencehubv2-service-reportoutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ReportOutputConfiguration
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.S3ReportOutputConfiguration S3 { get; set; }
        }

        public class ResourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CfnStackArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-cfnstackarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CfnStackArn { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceTag
            /// </summary>
            public List<Humidifier.ResilienceHubV2.ServiceTypes.ResourceTag> ResourceTags { get; set; }
            /// <summary>
            /// TfStateFileUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-tfstatefileurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TfStateFileUrl { get; set; }
            /// <summary>
            /// Eks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-eks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksSource
            /// </summary>
            public Humidifier.ResilienceHubV2.ServiceTypes.EksSource Eks { get; set; }
            /// <summary>
            /// DesignFileS3Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourceconfiguration.html#cfn-resiliencehubv2-service-resourceconfiguration-designfiles3url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DesignFileS3Url { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourcetag.html#cfn-resiliencehubv2-service-resourcetag-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-resourcetag.html#cfn-resiliencehubv2-service-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class S3ReportOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketOwner
        {
            /// <summary>
            /// BucketPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-s3reportoutputconfiguration.html#cfn-resiliencehubv2-service-s3reportoutputconfiguration-bucketpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPath { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-s3reportoutputconfiguration.html#cfn-resiliencehubv2-service-s3reportoutputconfiguration-bucketowner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
        }

        public class ServiceReportConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReportOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-servicereportconfiguration.html#cfn-resiliencehubv2-service-servicereportconfiguration-reportoutput
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReportOutputConfiguration
            /// </summary>
            public List<Humidifier.ResilienceHubV2.ServiceTypes.ReportOutputConfiguration> ReportOutput { get; set; }
        }

        public class SloSource : Humidifier.Base.BaseSubResource, IHaveValue, IHavePolicyName
        {
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-slosource.html#cfn-resiliencehubv2-service-slosource-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyName { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-slosource.html#cfn-resiliencehubv2-service-slosource-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class TargetSource : Humidifier.Base.BaseSubResource, IHaveValue, IHavePolicyName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-targetsource.html#cfn-resiliencehubv2-service-targetsource-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-service-targetsource.html#cfn-resiliencehubv2-service-targetsource-policyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyName { get; set; }
        }
    }
}