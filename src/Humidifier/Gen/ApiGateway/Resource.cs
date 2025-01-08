namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;

    public class Resource : Humidifier.Base.BaseResource, IHaveRestApiId, IHaveParentId
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
        public dynamic ParentId { get; set; }

        /// <summary>
        /// PathPart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-resource.html#cfn-apigateway-resource-pathpart
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PathPart { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-resource.html#cfn-apigateway-resource-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RestApiId { get; set; }
    }
}