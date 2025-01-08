namespace Humidifier.Wisdom
{
    using System.Collections.Generic;

    public class AIAgentVersion : Humidifier.Base.BaseResource, IHaveAssistantId, IHaveModifiedTimeSeconds
    {
        public class Attributes
        {
            public static string AIAgentArn =  "AIAgentArn" ;
            public static string AssistantArn =  "AssistantArn" ;
            public static string AIAgentVersionId =  "AIAgentVersionId" ;
            public static string VersionNumber =  "VersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AIAgentVersion; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagentversion.html#cfn-wisdom-aiagentversion-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssistantId { get; set; }

        /// <summary>
        /// AIAgentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagentversion.html#cfn-wisdom-aiagentversion-aiagentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AIAgentId { get; set; }
        /// <summary>
        /// ModifiedTimeSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagentversion.html#cfn-wisdom-aiagentversion-modifiedtimeseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic ModifiedTimeSeconds { get; set; }
    }
}