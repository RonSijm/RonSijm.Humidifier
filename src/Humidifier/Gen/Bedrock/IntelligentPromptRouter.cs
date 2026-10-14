namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using IntelligentPromptRouterTypes;

    public class IntelligentPromptRouter : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PromptRouterArn =  "PromptRouterArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.IntelligentPromptRouter; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// PromptRouterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-promptroutername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PromptRouterName { get; set; }

        /// <summary>
        /// FallbackModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-fallbackmodel
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PromptRouterTargetModel
        /// </summary>
        [Required]
        public Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel FallbackModel { get; set; }

        /// <summary>
        /// RoutingCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-routingcriteria
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RoutingCriteria
        /// </summary>
        [Required]
        public Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria RoutingCriteria { get; set; }

        /// <summary>
        /// Models
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-models
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PromptRouterTargetModel
        /// </summary>
        [Required]
        public List<Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel> Models { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace IntelligentPromptRouterTypes
    {
        public class PromptRouterTargetModel : Humidifier.Base.BaseSubResource, IHaveModelArn
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-intelligentpromptrouter-promptroutertargetmodel.html#cfn-bedrock-intelligentpromptrouter-promptroutertargetmodel-modelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelArn { get; set; }
        }

        public class RoutingCriteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResponseQualityDifference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-intelligentpromptrouter-routingcriteria.html#cfn-bedrock-intelligentpromptrouter-routingcriteria-responsequalitydifference
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResponseQualityDifference { get; set; }
        }
    }
}