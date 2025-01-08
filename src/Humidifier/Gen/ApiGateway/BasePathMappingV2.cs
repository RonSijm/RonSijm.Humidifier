namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;

    public class BasePathMappingV2 : Humidifier.Base.BaseResource, IHaveRestApiId, IHaveStage, IHaveBasePath, IHaveDomainNameArn
    {
        public class Attributes
        {
            public static string BasePathMappingArn =  "BasePathMappingArn" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.BasePathMappingV2; }

        /// <summary>
        /// DomainNameArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-basepathmappingv2.html#cfn-apigateway-basepathmappingv2-domainnamearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainNameArn { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-basepathmappingv2.html#cfn-apigateway-basepathmappingv2-restapiid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RestApiId { get; set; }
        /// <summary>
        /// Stage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-basepathmappingv2.html#cfn-apigateway-basepathmappingv2-stage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Stage { get; set; }
        /// <summary>
        /// BasePath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-basepathmappingv2.html#cfn-apigateway-basepathmappingv2-basepath
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BasePath { get; set; }
    }
}