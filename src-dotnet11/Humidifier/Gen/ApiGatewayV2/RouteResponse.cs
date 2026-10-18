namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using RouteResponseTypes;

    public class RouteResponse : Humidifier.Base.BaseResource, IHaveRouteResponseKey, IHaveMapOfApiGatewayV2RouteResponseTypesParameterConstraintsResponseParameters, IHaveRouteId, IHaveModelSelectionExpression, IHaveApiId, IHaveResponseModels_Json
    {
        public class Attributes
        {
            public static string RouteResponseId =  "RouteResponseId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.RouteResponse; }

        /// <summary>
        /// RouteResponseKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html#cfn-apigatewayv2-routeresponse-routeresponsekey
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RouteResponseKey { get; set; }
        /// <summary>
        /// ResponseParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html#cfn-apigatewayv2-routeresponse-responseparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ParameterConstraints
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.ApiGatewayV2.RouteResponseTypes.ParameterConstraints>, IReadOnlyDictionary<string, Union<Humidifier.ApiGatewayV2.RouteResponseTypes.ParameterConstraints, BaseFunction>>, BaseFunction>? ResponseParameters { get; set; }

        /// <summary>
        /// RouteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html#cfn-apigatewayv2-routeresponse-routeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RouteId { get; set; }
        /// <summary>
        /// ModelSelectionExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html#cfn-apigatewayv2-routeresponse-modelselectionexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelSelectionExpression { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html#cfn-apigatewayv2-routeresponse-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
        /// <summary>
        /// ResponseModels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html#cfn-apigatewayv2-routeresponse-responsemodels
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ResponseModels { get; set; }
    }

    namespace RouteResponseTypes
    {
        public class ParameterConstraints : Humidifier.Base.BaseSubResource, IHaveRequired_Boolean
        {
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-routeresponse-parameterconstraints.html#cfn-apigatewayv2-routeresponse-parameterconstraints-required
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
        }
    }
}