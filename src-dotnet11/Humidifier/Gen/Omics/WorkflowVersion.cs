namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using WorkflowVersionTypes;

    public class WorkflowVersion : Humidifier.Base.BaseResource, IHaveMapOfOmicsWorkflowVersionTypesWorkflowParameterParameterTemplate, IHaveDescription, IHaveStorageType, IHaveOmicsWorkflowVersionTypesContainerRegistryMapContainerRegistryMap, IHaveStorageCapacity_Double, IHaveWorkflowId, IHaveDefinitionUri, IHaveParameterTemplatePath, IHavereadmeMarkdown, IHaveOmicsWorkflowVersionTypesDefinitionRepositoryDefinitionRepository, IHaveAccelerators, IHaveWorkflowBucketOwnerId, IHavereadmePath, IHaveVersionName, IHaveContainerRegistryMapUri, IHaveMain, IHaveEngine, IHaveStringDictionaryOfTags, IHavereadmeUri
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string Uuid =  "Uuid" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.WorkflowVersion; }
        /// <summary>
        /// ParameterTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-parametertemplate
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// ItemType: WorkflowParameter
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.Omics.WorkflowVersionTypes.WorkflowParameter>, IReadOnlyDictionary<string, Union<Humidifier.Omics.WorkflowVersionTypes.WorkflowParameter, BaseFunction>>, BaseFunction>? ParameterTemplate { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-storagetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StorageType { get; set; }
        /// <summary>
        /// ContainerRegistryMap
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-containerregistrymap
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContainerRegistryMap
        /// </summary>
        public Union<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap, BaseFunction>? ContainerRegistryMap { get; set; }
        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-storagecapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? StorageCapacity { get; set; }

        /// <summary>
        /// WorkflowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-workflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkflowId { get; set; }
        /// <summary>
        /// DefinitionUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-definitionuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefinitionUri { get; set; }
        /// <summary>
        /// ParameterTemplatePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-parametertemplatepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParameterTemplatePath { get; set; }
        /// <summary>
        /// readmeMarkdown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-readmemarkdown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? readmeMarkdown { get; set; }
        /// <summary>
        /// DefinitionRepository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-definitionrepository
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DefinitionRepository
        /// </summary>
        public Union<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository, BaseFunction>? DefinitionRepository { get; set; }
        /// <summary>
        /// Accelerators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-accelerators
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Accelerators { get; set; }
        /// <summary>
        /// WorkflowBucketOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-workflowbucketownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkflowBucketOwnerId { get; set; }
        /// <summary>
        /// readmePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-readmepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? readmePath { get; set; }

        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-versionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VersionName { get; set; }
        /// <summary>
        /// ContainerRegistryMapUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-containerregistrymapuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContainerRegistryMapUri { get; set; }
        /// <summary>
        /// Main
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-main
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Main { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// readmeUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-workflowversion.html#cfn-omics-workflowversion-readmeuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? readmeUri { get; set; }
    }

    namespace WorkflowVersionTypes
    {
        public class ContainerRegistryMap : Humidifier.Base.BaseSubResource, IHaveListOfOmicsWorkflowVersionTypesRegistryMappingRegistryMappings, IHaveListOfOmicsWorkflowVersionTypesImageMappingImageMappings
        {
            /// <summary>
            /// RegistryMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-containerregistrymap.html#cfn-omics-workflowversion-containerregistrymap-registrymappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RegistryMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Omics.WorkflowVersionTypes.RegistryMapping>, IReadOnlyList<Union<Humidifier.Omics.WorkflowVersionTypes.RegistryMapping, BaseFunction>>, BaseFunction>? RegistryMappings { get; set; }
            /// <summary>
            /// ImageMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-containerregistrymap.html#cfn-omics-workflowversion-containerregistrymap-imagemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ImageMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Omics.WorkflowVersionTypes.ImageMapping>, IReadOnlyList<Union<Humidifier.Omics.WorkflowVersionTypes.ImageMapping, BaseFunction>>, BaseFunction>? ImageMappings { get; set; }
        }

        public class DefinitionRepository : Humidifier.Base.BaseSubResource, IHaveOmicsWorkflowVersionTypesSourceReferencesourceReference, IHavefullRepositoryId, IHaveStringListOfexcludeFilePatterns, IHaveconnectionArn
        {
            /// <summary>
            /// sourceReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-definitionrepository.html#cfn-omics-workflowversion-definitionrepository-sourcereference
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceReference
            /// </summary>
            public Union<Humidifier.Omics.WorkflowVersionTypes.SourceReference, BaseFunction>? sourceReference { get; set; }
            /// <summary>
            /// fullRepositoryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-definitionrepository.html#cfn-omics-workflowversion-definitionrepository-fullrepositoryid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? fullRepositoryId { get; set; }
            /// <summary>
            /// excludeFilePatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-definitionrepository.html#cfn-omics-workflowversion-definitionrepository-excludefilepatterns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? excludeFilePatterns { get; set; }
            /// <summary>
            /// connectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-definitionrepository.html#cfn-omics-workflowversion-definitionrepository-connectionarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-imagemapping.html#cfn-omics-workflowversion-imagemapping-sourceimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceImage { get; set; }
            /// <summary>
            /// DestinationImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-imagemapping.html#cfn-omics-workflowversion-imagemapping-destinationimage
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-registrymapping.html#cfn-omics-workflowversion-registrymapping-upstreamregistryurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpstreamRegistryUrl { get; set; }
            /// <summary>
            /// EcrAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-registrymapping.html#cfn-omics-workflowversion-registrymapping-ecraccountid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EcrAccountId { get; set; }
            /// <summary>
            /// UpstreamRepositoryPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-registrymapping.html#cfn-omics-workflowversion-registrymapping-upstreamrepositoryprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpstreamRepositoryPrefix { get; set; }
            /// <summary>
            /// EcrRepositoryPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-registrymapping.html#cfn-omics-workflowversion-registrymapping-ecrrepositoryprefix
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-sourcereference.html#cfn-omics-workflowversion-sourcereference-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? type { get; set; }
            /// <summary>
            /// value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-sourcereference.html#cfn-omics-workflowversion-sourcereference-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-workflowparameter.html#cfn-omics-workflowversion-workflowparameter-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Optional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-workflowversion-workflowparameter.html#cfn-omics-workflowversion-workflowparameter-optional
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Optional { get; set; }
        }
    }
}