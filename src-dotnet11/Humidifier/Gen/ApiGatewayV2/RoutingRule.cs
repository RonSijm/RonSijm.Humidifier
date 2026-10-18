namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using RoutingRuleTypes;

    public class RoutingRule : Humidifier.Base.BaseResource, IHaveListOfApiGatewayV2RoutingRuleTypesActionActions, IHavePriority_Integer, IHaveDomainNameArn, IHaveListOfApiGatewayV2RoutingRuleTypesConditionConditions
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
        public Union<IReadOnlyList<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action>, IReadOnlyList<Union<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }

        /// <summary>
        /// DomainNameArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-domainnamearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainNameArn { get; set; }

        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routingrule.html#cfn-apigatewayv2-routingrule-conditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Condition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition>, IReadOnlyList<Union<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
    }

    namespace RoutingRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveApiGatewayV2RoutingRuleTypesActionInvokeApiInvokeApi
        {
            /// <summary>
            /// InvokeApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-action.html#cfn-apigatewayv2-routingrule-action-invokeapi
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionInvokeApi
            /// </summary>
            public Union<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi, BaseFunction>? InvokeApi { get; set; }
        }

        public class ActionInvokeApi : Humidifier.Base.BaseSubResource, IHaveStripBasePath_Boolean, IHaveStage, IHaveApiId
        {
            /// <summary>
            /// StripBasePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-actioninvokeapi.html#cfn-apigatewayv2-routingrule-actioninvokeapi-stripbasepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StripBasePath { get; set; }
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-actioninvokeapi.html#cfn-apigatewayv2-routingrule-actioninvokeapi-stage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stage { get; set; }
            /// <summary>
            /// ApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-actioninvokeapi.html#cfn-apigatewayv2-routingrule-actioninvokeapi-apiid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiId { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveApiGatewayV2RoutingRuleTypesMatchBasePathsMatchBasePaths, IHaveApiGatewayV2RoutingRuleTypesMatchHeadersMatchHeaders
        {
            /// <summary>
            /// MatchBasePaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-condition.html#cfn-apigatewayv2-routingrule-condition-matchbasepaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchBasePaths
            /// </summary>
            public Union<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths, BaseFunction>? MatchBasePaths { get; set; }
            /// <summary>
            /// MatchHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-condition.html#cfn-apigatewayv2-routingrule-condition-matchheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchHeaders
            /// </summary>
            public Union<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders, BaseFunction>? MatchHeaders { get; set; }
        }

        public class MatchBasePaths : Humidifier.Base.BaseSubResource, IHaveStringListOfAnyOf
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchbasepaths.html#cfn-apigatewayv2-routingrule-matchbasepaths-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AnyOf { get; set; }
        }

        public class MatchHeaderValue : Humidifier.Base.BaseSubResource, IHaveValueGlob, IHaveHeader
        {
            /// <summary>
            /// ValueGlob
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchheadervalue.html#cfn-apigatewayv2-routingrule-matchheadervalue-valueglob
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueGlob { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchheadervalue.html#cfn-apigatewayv2-routingrule-matchheadervalue-header
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
        }

        public class MatchHeaders : Humidifier.Base.BaseSubResource, IHaveListOfApiGatewayV2RoutingRuleTypesMatchHeaderValueAnyOf
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routingrule-matchheaders.html#cfn-apigatewayv2-routingrule-matchheaders-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchHeaderValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaderValue>, IReadOnlyList<Union<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaderValue, BaseFunction>>, BaseFunction>? AnyOf { get; set; }
        }
    }
}