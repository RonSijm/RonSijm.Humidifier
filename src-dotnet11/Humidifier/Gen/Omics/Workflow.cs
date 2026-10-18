namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using WorkflowTypes;

    public class Workflow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMapOfOmicsWorkflowTypesWorkflowParameterParameterTemplate, IHaveDescription, IHaveStorageType, IHaveOmicsWorkflowTypesContainerRegistryMapContainerRegistryMap, IHaveStorageCapacity_Double, IHaveDefinitionUri, IHaveName, IHaveParameterTemplatePath, IHavereadmeMarkdown, IHaveOmicsWorkflowTypesDefinitionRepositoryDefinitionRepository, IHaveAccelerators, IHaveWorkflowBucketOwnerId, IHavereadmePath, IHaveContainerRegistryMapUri, IHaveMain, IHaveEngine, IHaveStringDictionaryOfTags, IHavereadmeUri
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string Uuid =  "Uuid" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.Workflow; }
        /// <summary>
        /// ParameterTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-parametertemplate
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// ItemType: WorkflowParameter
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.Omics.WorkflowTypes.WorkflowParameter>, IReadOnlyDictionary<string, Union<Humidifier.Omics.WorkflowTypes.WorkflowParameter, BaseFunction>>, BaseFunction>? ParameterTemplate { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-storagetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StorageType { get; set; }
        /// <summary>
        /// ContainerRegistryMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-containerregistrymap
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContainerRegistryMap
        /// </summary>
        public Union<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap, BaseFunction>? ContainerRegistryMap { get; set; }
        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-storagecapacity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? StorageCapacity { get; set; }
        /// <summary>
        /// DefinitionUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-definitionuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefinitionUri { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ParameterTemplatePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-parametertemplatepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParameterTemplatePath { get; set; }
        /// <summary>
        /// readmeMarkdown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-readmemarkdown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? readmeMarkdown { get; set; }
        /// <summary>
        /// DefinitionRepository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-definitionrepository
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DefinitionRepository
        /// </summary>
        public Union<Humidifier.Omics.WorkflowTypes.DefinitionRepository, BaseFunction>? DefinitionRepository { get; set; }
        /// <summary>
        /// Accelerators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-accelerators
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Accelerators { get; set; }
        /// <summary>
        /// WorkflowBucketOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-workflowbucketownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkflowBucketOwnerId { get; set; }
        /// <summary>
        /// readmePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-readmepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? readmePath { get; set; }
        /// <summary>
        /// ContainerRegistryMapUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-containerregistrymapuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContainerRegistryMapUri { get; set; }
        /// <summary>
        /// Main
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-main
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Main { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// readmeUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-readmeuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? readmeUri { get; set; }
    }

    namespace WorkflowTypes
    {
        public class ContainerRegistryMap : Humidifier.Base.BaseSubResource, IHaveListOfOmicsWorkflowTypesRegistryMappingRegistryMappings, IHaveListOfOmicsWorkflowTypesImageMappingImageMappings
        {
            /// <summary>
            /// RegistryMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-containerregistrymap.html#cfn-omics-workflow-containerregistrymap-registrymappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RegistryMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Omics.WorkflowTypes.RegistryMapping>, IReadOnlyList<Union<Humidifier.Omics.WorkflowTypes.RegistryMapping, BaseFunction>>, BaseFunction>? RegistryMappings { get; set; }
            /// <summary>
            /// ImageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-containerregistrymap.html#cfn-omics-workflow-containerregistrymap-imagemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ImageMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Omics.WorkflowTypes.ImageMapping>, IReadOnlyList<Union<Humidifier.Omics.WorkflowTypes.ImageMapping, BaseFunction>>, BaseFunction>? ImageMappings { get; set; }
        }

        public class DefinitionRepository : Humidifier.Base.BaseSubResource, IHaveOmicsWorkflowTypesSourceReferencesourceReference, IHavefullRepositoryId, IHaveStringListOfexcludeFilePatterns, IHaveconnectionArn
        {
            /// <summary>
            /// sourceReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-sourcereference
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceReference
            /// </summary>
            public Union<Humidifier.Omics.WorkflowTypes.SourceReference, BaseFunction>? sourceReference { get; set; }
            /// <summary>
            /// fullRepositoryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-fullrepositoryid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? fullRepositoryId { get; set; }
            /// <summary>
            /// excludeFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-excludefilepatterns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? excludeFilePatterns { get; set; }
            /// <summary>
            /// connectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-connectionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? connectionArn { get; set; }
        }

        public class ImageMapping : Humidifier.Base.BaseSubResource, IHaveSourceImage, IHaveDestinationImage
        {
            /// <summary>
            /// SourceImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-imagemapping.html#cfn-omics-workflow-imagemapping-sourceimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceImage { get; set; }
            /// <summary>
            /// DestinationImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-imagemapping.html#cfn-omics-workflow-imagemapping-destinationimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationImage { get; set; }
        }

        public class RegistryMapping : Humidifier.Base.BaseSubResource, IHaveUpstreamRegistryUrl, IHaveEcrAccountId, IHaveUpstreamRepositoryPrefix, IHaveEcrRepositoryPrefix
        {
            /// <summary>
            /// UpstreamRegistryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-upstreamregistryurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpstreamRegistryUrl { get; set; }
            /// <summary>
            /// EcrAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-ecraccountid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EcrAccountId { get; set; }
            /// <summary>
            /// UpstreamRepositoryPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-upstreamrepositoryprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpstreamRepositoryPrefix { get; set; }
            /// <summary>
            /// EcrRepositoryPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-ecrrepositoryprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EcrRepositoryPrefix { get; set; }
        }

        public class SourceReference : Humidifier.Base.BaseSubResource, IHavetype, IHavevalue
        {
            /// <summary>
            /// type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-sourcereference.html#cfn-omics-workflow-sourcereference-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? type { get; set; }
            /// <summary>
            /// value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-sourcereference.html#cfn-omics-workflow-sourcereference-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? value { get; set; }
        }

        public class WorkflowParameter : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveOptional_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-workflowparameter.html#cfn-omics-workflow-workflowparameter-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Optional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-workflowparameter.html#cfn-omics-workflow-workflowparameter-optional
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Optional { get; set; }
        }
    }
}