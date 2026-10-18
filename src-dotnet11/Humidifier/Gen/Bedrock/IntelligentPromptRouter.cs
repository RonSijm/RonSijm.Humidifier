namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using IntelligentPromptRouterTypes;

    public class IntelligentPromptRouter : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHavePromptRouterName, IHaveBedrockIntelligentPromptRouterTypesPromptRouterTargetModelFallbackModel, IHaveBedrockIntelligentPromptRouterTypesRoutingCriteriaRoutingCriteria, IHaveListOfBedrockIntelligentPromptRouterTypesPromptRouterTargetModelModels
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// PromptRouterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-promptroutername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PromptRouterName { get; set; }

        /// <summary>
        /// FallbackModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-fallbackmodel
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PromptRouterTargetModel
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel, BaseFunction>? FallbackModel { get; set; }

        /// <summary>
        /// RoutingCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-routingcriteria
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RoutingCriteria
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria, BaseFunction>? RoutingCriteria { get; set; }

        /// <summary>
        /// Models
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-models
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PromptRouterTargetModel
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel>, IReadOnlyList<Union<Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel, BaseFunction>>, BaseFunction>? Models { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-intelligentpromptrouter.html#cfn-bedrock-intelligentpromptrouter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? ModelArn { get; set; }
        }

        public class RoutingCriteria : Humidifier.Base.BaseSubResource, IHaveResponseQualityDifference_Double
        {
            /// <summary>
            /// ResponseQualityDifference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-intelligentpromptrouter-routingcriteria.html#cfn-bedrock-intelligentpromptrouter-routingcriteria-responsequalitydifference
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ResponseQualityDifference { get; set; }
        }
    }
}