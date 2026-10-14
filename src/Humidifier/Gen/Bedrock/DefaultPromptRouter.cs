namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using DefaultPromptRouterTypes;

    public class DefaultPromptRouter : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Description =  "Description" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FallbackModel =  "FallbackModel" ;
            public static string RoutingCriteria =  "RoutingCriteria" ;
            public static string PromptRouterArn =  "PromptRouterArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Type =  "Type" ;
            public static string PromptRouterName =  "PromptRouterName" ;
            public static string PromptRouterId =  "PromptRouterId" ;
            public static string Models =  "Models" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.DefaultPromptRouter; }
    }

    namespace DefaultPromptRouterTypes
    {
        public class PromptRouterTargetModel : Humidifier.Base.BaseSubResource, IHaveModelArn
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-defaultpromptrouter-promptroutertargetmodel.html#cfn-bedrock-defaultpromptrouter-promptroutertargetmodel-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelArn { get; set; }
        }

        public class RoutingCriteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResponseQualityDifference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-defaultpromptrouter-routingcriteria.html#cfn-bedrock-defaultpromptrouter-routingcriteria-responsequalitydifference
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResponseQualityDifference { get; set; }
        }
    }
}