namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using TrialComponentTypes;

    public class TrialComponent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDisplayName
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
        public Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus Status { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: TrialComponentParameterValue
        /// </summary>
        public Dictionary<string, Humidifier.SageMaker.TrialComponentTypes.TrialComponentParameterValue> Parameters { get; set; }
        /// <summary>
        /// InputArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-inputartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: TrialComponentArtifact
        /// </summary>
        public Dictionary<string, Humidifier.SageMaker.TrialComponentTypes.TrialComponentArtifact> InputArtifacts { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// OutputArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-outputartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: TrialComponentArtifact
        /// </summary>
        public Dictionary<string, Humidifier.SageMaker.TrialComponentTypes.TrialComponentArtifact> OutputArtifacts { get; set; }
        /// <summary>
        /// MetadataProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-metadataproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataProperties
        /// </summary>
        public Humidifier.SageMaker.TrialComponentTypes.MetadataProperties MetadataProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trialcomponent.html#cfn-sagemaker-trialcomponent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.SageMaker.TrialComponentTypes.TagsItems> Tags { get; set; }
        public dynamic TrialComponentName { get => GivenName; set => GivenName = value; }
    }

    namespace TrialComponentTypes
    {
        public class MetadataProperties : Humidifier.Base.BaseSubResource, IHaveRepository, IHaveProjectId, IHaveCommitId
        {
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-repository
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Repository { get; set; }
            /// <summary>
            /// GeneratedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-generatedby
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeneratedBy { get; set; }
            /// <summary>
            /// CommitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-commitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CommitId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-metadataproperties.html#cfn-sagemaker-trialcomponent-metadataproperties-projectid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProjectId { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-tagsitems.html#cfn-sagemaker-trialcomponent-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TrialComponentArtifact : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentartifact.html#cfn-sagemaker-trialcomponent-trialcomponentartifact-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// MediaType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentartifact.html#cfn-sagemaker-trialcomponent-trialcomponentartifact-mediatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaType { get; set; }
        }

        public class TrialComponentParameterValue : Humidifier.Base.BaseSubResource, IHaveStringValue
        {
            /// <summary>
            /// NumberValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentparametervalue.html#cfn-sagemaker-trialcomponent-trialcomponentparametervalue-numbervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic NumberValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentparametervalue.html#cfn-sagemaker-trialcomponent-trialcomponentparametervalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
        }

        public class TrialComponentStatus : Humidifier.Base.BaseSubResource, IHaveMessage
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentstatus.html#cfn-sagemaker-trialcomponent-trialcomponentstatus-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// PrimaryStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trialcomponent-trialcomponentstatus.html#cfn-sagemaker-trialcomponent-trialcomponentstatus-primarystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryStatus { get; set; }
        }
    }
}