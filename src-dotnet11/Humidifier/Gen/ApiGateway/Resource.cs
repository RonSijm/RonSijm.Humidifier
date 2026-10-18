namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;

    public class Resource : Humidifier.Base.BaseResource, IHaveParentId, IHavePathPart, IHaveRestApiId
    {
        public class Attributes
        {
            public static string ResourceId =  "ResourceId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.Resource; }

        /// <summary>
        /// ParentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-resource.html#cfn-apigateway-resource-parentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ParentId { get; set; }

        /// <summary>
        /// PathPart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-resource.html#cfn-apigateway-resource-pathpart
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PathPart { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-resource.html#cfn-apigateway-resource-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RestApiId { get; set; }
    }
}