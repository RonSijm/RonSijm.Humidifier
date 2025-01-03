namespace Humidifier.Wisdom
{
    using System.Collections.Generic;

    public class AIPromptVersion : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AssistantArn =  "AssistantArn" ;
            public static string AIPromptVersionId =  "AIPromptVersionId" ;
            public static string AIPromptArn =  "AIPromptArn" ;
            public static string VersionNumber =  "VersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AIPromptVersion; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aipromptversion.html#cfn-wisdom-aipromptversion-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssistantId { get; set; }
        /// <summary>
        /// ModifiedTimeSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aipromptversion.html#cfn-wisdom-aipromptversion-modifiedtimeseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic ModifiedTimeSeconds { get; set; }

        /// <summary>
        /// AIPromptId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aipromptversion.html#cfn-wisdom-aipromptversion-aipromptid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AIPromptId { get; set; }
    }
}