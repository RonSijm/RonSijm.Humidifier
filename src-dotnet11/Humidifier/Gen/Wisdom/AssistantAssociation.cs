namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using AssistantAssociationTypes;

    public class AssistantAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveWisdomAssistantAssociationTypesAssociationDataAssociation, IHaveAssociationType, IHaveAssistantId
    {
        public class Attributes
        {
            public static string AssistantAssociationArn =  "AssistantAssociationArn" ;
            public static string AssistantArn =  "AssistantArn" ;
            public static string AssistantAssociationId =  "AssistantAssociationId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AssistantAssociation; }

        /// <summary>
        /// Association
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-association
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AssociationData
        /// </summary>
        [Required]
        public Union<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData, BaseFunction>? Association { get; set; }

        /// <summary>
        /// AssociationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-associationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssociationType { get; set; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssistantId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AssistantAssociationTypes
    {
        public class AssociationData : Humidifier.Base.BaseSubResource, IHaveWisdomAssistantAssociationTypesExternalBedrockKnowledgeBaseConfigExternalBedrockKnowledgeBaseConfig, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// ExternalBedrockKnowledgeBaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-assistantassociation-associationdata.html#cfn-wisdom-assistantassociation-associationdata-externalbedrockknowledgebaseconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExternalBedrockKnowledgeBaseConfig
            /// </summary>
            public Union<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig, BaseFunction>? ExternalBedrockKnowledgeBaseConfig { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-assistantassociation-associationdata.html#cfn-wisdom-assistantassociation-associationdata-knowledgebaseid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        }

        public class ExternalBedrockKnowledgeBaseConfig : Humidifier.Base.BaseSubResource, IHaveAccessRoleArn, IHaveBedrockKnowledgeBaseArn
        {
            /// <summary>
            /// AccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-assistantassociation-externalbedrockknowledgebaseconfig.html#cfn-wisdom-assistantassociation-externalbedrockknowledgebaseconfig-accessrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessRoleArn { get; set; }
            /// <summary>
            /// BedrockKnowledgeBaseArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-assistantassociation-externalbedrockknowledgebaseconfig.html#cfn-wisdom-assistantassociation-externalbedrockknowledgebaseconfig-bedrockknowledgebasearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockKnowledgeBaseArn { get; set; }
        }
    }
}