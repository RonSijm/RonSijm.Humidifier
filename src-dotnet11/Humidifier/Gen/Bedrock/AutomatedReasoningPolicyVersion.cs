namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;

    public class AutomatedReasoningPolicyVersion : Humidifier.Base.BaseResource, IHaveTags, IHaveLastUpdatedDefinitionHash, IHavePolicyArn
    {
        public class Attributes
        {
            public static string DefinitionHash =  "DefinitionHash" ;
            public static string Description =  "Description" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string PolicyId =  "PolicyId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.AutomatedReasoningPolicyVersion; }
        /// <summary>
        /// LastUpdatedDefinitionHash
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicyversion.html#cfn-bedrock-automatedreasoningpolicyversion-lastupdateddefinitionhash
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LastUpdatedDefinitionHash { get; set; }

        /// <summary>
        /// PolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicyversion.html#cfn-bedrock-automatedreasoningpolicyversion-policyarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-automatedreasoningpolicyversion.html#cfn-bedrock-automatedreasoningpolicyversion-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}