namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using TrialComponentTypes;

    public class TrialComponent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveSageMakerTrialComponentTypesTrialComponentStatusStatus, IHaveMapOfSageMakerTrialComponentTypesTrialComponentParameterValueParameters, IHaveMapOfSageMakerTrialComponentTypesTrialComponentArtifactInputArtifacts, IHaveDisplayName, IHaveMapOfSageMakerTrialComponentTypesTrialComponentArtifactOutputArtifacts, IHaveSageMakerTrialComponentTypesMetadataPropertiesMetadataProperties, IHaveListOfSageMakerTrialComponentTypesTagsItemsTags, IHaveTrialComponentName
    {
        public class Attributes
        {
            public static string LineageGroupArn =  "LineageGroupArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string TrialComponentArn =  "TrialComponentArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.TrialComponent; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-status
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrialComponentStatus
        /// </summary>
        public Union<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: TrialComponentParameterValue
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.SageMaker.TrialComponentTypes.TrialComponentParameterValue>, IReadOnlyDictionary<string, Union<Humidifier.SageMaker.TrialComponentTypes.TrialComponentParameterValue, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        /// <summary>
        /// InputArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-inputartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: TrialComponentArtifact
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.SageMaker.TrialComponentTypes.TrialComponentArtifact>, IReadOnlyDictionary<string, Union<Humidifier.SageMaker.TrialComponentTypes.TrialComponentArtifact, BaseFunction>>, BaseFunction>? InputArtifacts { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// OutputArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-outputartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: TrialComponentArtifact
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.SageMaker.TrialComponentTypes.TrialComponentArtifact>, IReadOnlyDictionary<string, Union<Humidifier.SageMaker.TrialComponentTypes.TrialComponentArtifact, BaseFunction>>, BaseFunction>? OutputArtifacts { get; set; }
        /// <summary>
        /// MetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-metadataproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataProperties
        /// </summary>
        public Union<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties, BaseFunction>? MetadataProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.TrialComponentTypes.TagsItems>, IReadOnlyList<Union<Humidifier.SageMaker.TrialComponentTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? TrialComponentName { get => GivenName; set => GivenName = value; }
    }

    namespace TrialComponentTypes
    {
        public class MetadataProperties : Humidifier.Base.BaseSubResource, IHaveRepository, IHaveGeneratedBy, IHaveCommitId, IHaveProjectId
        {
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-repository
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Repository { get; set; }
            /// <summary>
            /// GeneratedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-generatedby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeneratedBy { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-commitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommitId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-projectid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectId { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-tagsitems.html#cfn-sagemaker-trialcomponent-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-tagsitems.html#cfn-sagemaker-trialcomponent-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TrialComponentArtifact : Humidifier.Base.BaseSubResource, IHaveValue, IHaveMediaType
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentartifact.html#cfn-sagemaker-trialcomponent-trialcomponentartifact-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// MediaType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentartifact.html#cfn-sagemaker-trialcomponent-trialcomponentartifact-mediatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaType { get; set; }
        }

        public class TrialComponentParameterValue : Humidifier.Base.BaseSubResource, IHaveNumberValue_Double, IHaveStringValue
        {
            /// <summary>
            /// NumberValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentparametervalue.html#cfn-sagemaker-trialcomponent-trialcomponentparametervalue-numbervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentparametervalue.html#cfn-sagemaker-trialcomponent-trialcomponentparametervalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class TrialComponentStatus : Humidifier.Base.BaseSubResource, IHaveMessage, IHavePrimaryStatus
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentstatus.html#cfn-sagemaker-trialcomponent-trialcomponentstatus-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// PrimaryStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentstatus.html#cfn-sagemaker-trialcomponent-trialcomponentstatus-primarystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryStatus { get; set; }
        }
    }
}