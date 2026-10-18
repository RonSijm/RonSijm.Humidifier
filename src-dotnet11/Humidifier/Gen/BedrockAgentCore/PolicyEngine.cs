namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;

    public class PolicyEngine : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveEncryptionKeyArn, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StatusReasons =  "StatusReasons" ;
            public static string PolicyEngineId =  "PolicyEngineId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PolicyEngineArn =  "PolicyEngineArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.PolicyEngine; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policyengine.html#cfn-bedrockagentcore-policyengine-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policyengine.html#cfn-bedrockagentcore-policyengine-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-policyengine.html#cfn-bedrockagentcore-policyengine-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}