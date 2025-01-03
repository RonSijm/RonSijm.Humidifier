namespace Humidifier.Wisdom
{
    using System.Collections.Generic;

    public class AIGuardrailVersion : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AIGuardrailVersionId =  "AIGuardrailVersionId" ;
            public static string AssistantArn =  "AssistantArn" ;
            public static string AIGuardrailArn =  "AIGuardrailArn" ;
            public static string VersionNumber =  "VersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AIGuardrailVersion; }

        /// <summary>
        /// AIGuardrailId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrailversion.html#cfn-wisdom-aiguardrailversion-aiguardrailid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AIGuardrailId { get; set; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrailversion.html#cfn-wisdom-aiguardrailversion-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssistantId { get; set; }
        /// <summary>
        /// ModifiedTimeSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrailversion.html#cfn-wisdom-aiguardrailversion-modifiedtimeseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic ModifiedTimeSeconds { get; set; }
    }
}