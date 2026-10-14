namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using WorkflowTypes;

    public class Workflow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveEngine, IHaveStorageType, IHaveStorageCapacity
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
        public Dictionary<string, Humidifier.Omics.WorkflowTypes.WorkflowParameter> ParameterTemplate { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-storagetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StorageType { get; set; }
        /// <summary>
        /// ContainerRegistryMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-containerregistrymap
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContainerRegistryMap
        /// </summary>
        public Humidifier.Omics.WorkflowTypes.ContainerRegistryMap ContainerRegistryMap { get; set; }
        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-storagecapacity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic StorageCapacity { get; set; }
        /// <summary>
        /// DefinitionUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-definitionuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefinitionUri { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ParameterTemplatePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-parametertemplatepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ParameterTemplatePath { get; set; }
        /// <summary>
        /// readmeMarkdown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-readmemarkdown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic readmeMarkdown { get; set; }
        /// <summary>
        /// DefinitionRepository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-definitionrepository
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DefinitionRepository
        /// </summary>
        public Humidifier.Omics.WorkflowTypes.DefinitionRepository DefinitionRepository { get; set; }
        /// <summary>
        /// Accelerators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-accelerators
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Accelerators { get; set; }
        /// <summary>
        /// WorkflowBucketOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-workflowbucketownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkflowBucketOwnerId { get; set; }
        /// <summary>
        /// readmePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-readmepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic readmePath { get; set; }
        /// <summary>
        /// ContainerRegistryMapUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-containerregistrymapuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ContainerRegistryMapUri { get; set; }
        /// <summary>
        /// Main
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-main
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Main { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        /// <summary>
        /// readmeUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflow.html#cfn-omics-workflow-readmeuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic readmeUri { get; set; }
    }

    namespace WorkflowTypes
    {
        public class ContainerRegistryMap : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RegistryMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-containerregistrymap.html#cfn-omics-workflow-containerregistrymap-registrymappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RegistryMapping
            /// </summary>
            public List<Humidifier.Omics.WorkflowTypes.RegistryMapping> RegistryMappings { get; set; }
            /// <summary>
            /// ImageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-containerregistrymap.html#cfn-omics-workflow-containerregistrymap-imagemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ImageMapping
            /// </summary>
            public List<Humidifier.Omics.WorkflowTypes.ImageMapping> ImageMappings { get; set; }
        }

        public class DefinitionRepository : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// sourceReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-sourcereference
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceReference
            /// </summary>
            public Humidifier.Omics.WorkflowTypes.SourceReference sourceReference { get; set; }
            /// <summary>
            /// fullRepositoryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-fullrepositoryid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic fullRepositoryId { get; set; }
            /// <summary>
            /// excludeFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-excludefilepatterns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic excludeFilePatterns { get; set; }
            /// <summary>
            /// connectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-definitionrepository.html#cfn-omics-workflow-definitionrepository-connectionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic connectionArn { get; set; }
        }

        public class ImageMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-imagemapping.html#cfn-omics-workflow-imagemapping-sourceimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceImage { get; set; }
            /// <summary>
            /// DestinationImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-imagemapping.html#cfn-omics-workflow-imagemapping-destinationimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationImage { get; set; }
        }

        public class RegistryMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UpstreamRegistryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-upstreamregistryurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpstreamRegistryUrl { get; set; }
            /// <summary>
            /// EcrAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-ecraccountid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EcrAccountId { get; set; }
            /// <summary>
            /// UpstreamRepositoryPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-upstreamrepositoryprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpstreamRepositoryPrefix { get; set; }
            /// <summary>
            /// EcrRepositoryPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-registrymapping.html#cfn-omics-workflow-registrymapping-ecrrepositoryprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EcrRepositoryPrefix { get; set; }
        }

        public class SourceReference : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-sourcereference.html#cfn-omics-workflow-sourcereference-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic type { get; set; }
            /// <summary>
            /// value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-sourcereference.html#cfn-omics-workflow-sourcereference-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic value { get; set; }
        }

        public class WorkflowParameter : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveOptional
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-workflowparameter.html#cfn-omics-workflow-workflowparameter-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Optional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflow-workflowparameter.html#cfn-omics-workflow-workflowparameter-optional
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Optional { get; set; }
        }
    }
}