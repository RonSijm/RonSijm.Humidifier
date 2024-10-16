namespace Humidifier.Wisdom
{
    using System.Collections.Generic;
    using AssistantAssociationTypes;

    public class AssistantAssociation : Humidifier.Base.BaseResource, IHaveTags
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
        public Humidifier.Wisdom.AssistantAssociationTypes.AssociationData Association { get; set; }

        /// <summary>
        /// AssociationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-associationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssociationType { get; set; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssistantId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-assistantassociation.html#cfn-wisdom-assistantassociation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace AssistantAssociationTypes
    {
        public class AssociationData : Humidifier.Base.BaseSubResource, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-assistantassociation-associationdata.html#cfn-wisdom-assistantassociation-associationdata-knowledgebaseid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseId { get; set; }
        }
    }
}