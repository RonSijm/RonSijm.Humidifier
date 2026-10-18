namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;

    public class KnowledgeBasePolicy : Humidifier.Base.BaseResource, IHaveKnowledgeBaseId, IHavePolicyDocument_Json
    {
        public class Attributes
        {
            public static string RevisionId =  "RevisionId" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.KnowledgeBasePolicy; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebasepolicy.html#cfn-bedrock-knowledgebasepolicy-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebasepolicy.html#cfn-bedrock-knowledgebasepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}