namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using RoutingRuleTypes;

    public class RoutingRule : Humidifier.Base.BaseResource, IHavePriority, IHaveDomainNameArn
    {
        public class Attributes
        {
            public static string RoutingRuleArn =  "RoutingRuleArn" ;
            public static string RoutingRuleId =  "RoutingRuleId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.RoutingRule; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public List<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> Actions { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Priority { get; set; }

        /// <summary>
        /// DomainNameArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-domainnamearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainNameArn { get; set; }

        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-conditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Condition
        /// </summary>
        [Required]
        public List<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> Conditions { get; set; }
    }

    namespace RoutingRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InvokeApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-action.html#cfn-apigatewayv2-routingrule-action-invokeapi
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionInvokeApi
            /// </summary>
            public Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi InvokeApi { get; set; }
        }

        public class ActionInvokeApi : Humidifier.Base.BaseSubResource, IHaveApiId, IHaveStage
        {
            /// <summary>
            /// StripBasePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-actioninvokeapi.html#cfn-apigatewayv2-routingrule-actioninvokeapi-stripbasepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StripBasePath { get; set; }
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-actioninvokeapi.html#cfn-apigatewayv2-routingrule-actioninvokeapi-stage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stage { get; set; }
            /// <summary>
            /// ApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-actioninvokeapi.html#cfn-apigatewayv2-routingrule-actioninvokeapi-apiid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiId { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchBasePaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-condition.html#cfn-apigatewayv2-routingrule-condition-matchbasepaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchBasePaths
            /// </summary>
            public Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths MatchBasePaths { get; set; }
            /// <summary>
            /// MatchHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-condition.html#cfn-apigatewayv2-routingrule-condition-matchheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchHeaders
            /// </summary>
            public Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders MatchHeaders { get; set; }
        }

        public class MatchBasePaths : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchbasepaths.html#cfn-apigatewayv2-routingrule-matchbasepaths-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AnyOf { get; set; }
        }

        public class MatchHeaderValue : Humidifier.Base.BaseSubResource, IHaveHeader
        {
            /// <summary>
            /// ValueGlob
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchheadervalue.html#cfn-apigatewayv2-routingrule-matchheadervalue-valueglob
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueGlob { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchheadervalue.html#cfn-apigatewayv2-routingrule-matchheadervalue-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Header { get; set; }
        }

        public class MatchHeaders : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchheaders.html#cfn-apigatewayv2-routingrule-matchheaders-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchHeaderValue
            /// </summary>
            public List<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaderValue> AnyOf { get; set; }
        }
    }
}