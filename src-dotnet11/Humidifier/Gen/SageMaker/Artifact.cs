namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ArtifactTypes;

    public class Artifact : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveArtifactType, IHaveArtifactName, IHaveStringDictionaryOfProperties, IHaveSageMakerArtifactTypesMetadataPropertiesMetadataProperties, IHaveSageMakerArtifactTypesArtifactSourceSource
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Artifact; }

        /// <summary>
        /// ArtifactType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-artifact.html#cfn-sagemaker-artifact-artifacttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ArtifactType { get; set; }
        public Union<string, BaseFunction>? ArtifactName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-artifact.html#cfn-sagemaker-artifact-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
        /// <summary>
        /// MetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-artifact.html#cfn-sagemaker-artifact-metadataproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataProperties
        /// </summary>
        public Union<Humidifier.SageMaker.ArtifactTypes.MetadataProperties, BaseFunction>? MetadataProperties { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-artifact.html#cfn-sagemaker-artifact-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ArtifactSource
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ArtifactTypes.ArtifactSource, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-artifact.html#cfn-sagemaker-artifact-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ArtifactTypes
    {
        public class ArtifactSource : Humidifier.Base.BaseSubResource, IHaveSourceUri, IHaveListOfSageMakerArtifactTypesArtifactSourceTypeSourceTypes
        {
            /// <summary>
            /// SourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-artifactsource.html#cfn-sagemaker-artifact-artifactsource-sourceuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceUri { get; set; }
            /// <summary>
            /// SourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-artifactsource.html#cfn-sagemaker-artifact-artifactsource-sourcetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ArtifactSourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ArtifactTypes.ArtifactSourceType>, IReadOnlyList<Union<Humidifier.SageMaker.ArtifactTypes.ArtifactSourceType, BaseFunction>>, BaseFunction>? SourceTypes { get; set; }
        }

        public class ArtifactSourceType : Humidifier.Base.BaseSubResource, IHaveSourceIdType, IHaveValue
        {
            /// <summary>
            /// SourceIdType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-artifactsourcetype.html#cfn-sagemaker-artifact-artifactsourcetype-sourceidtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIdType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-artifactsourcetype.html#cfn-sagemaker-artifact-artifactsourcetype-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class MetadataProperties : Humidifier.Base.BaseSubResource, IHaveRepository, IHaveGeneratedBy, IHaveCommitId, IHaveProjectId
        {
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-metadataproperties.html#cfn-sagemaker-artifact-metadataproperties-repository
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Repository { get; set; }
            /// <summary>
            /// GeneratedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-metadataproperties.html#cfn-sagemaker-artifact-metadataproperties-generatedby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeneratedBy { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-metadataproperties.html#cfn-sagemaker-artifact-metadataproperties-commitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommitId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-artifact-metadataproperties.html#cfn-sagemaker-artifact-metadataproperties-projectid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectId { get; set; }
        }
    }
}