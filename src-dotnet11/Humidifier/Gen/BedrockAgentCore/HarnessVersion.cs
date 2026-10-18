namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class HarnessVersion : Humidifier.Base.BaseResource, IHaveHarnessId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string HarnessArn =  "HarnessArn" ;
            public static string HarnessName =  "HarnessName" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string HarnessVersion =  "HarnessVersion" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.HarnessVersion; }

        /// <summary>
        /// HarnessId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-harnessversion.html#cfn-bedrockagentcore-harnessversion-harnessid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HarnessId { get; set; }
    }
}