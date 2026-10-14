namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;

    public class PortalProduct : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDisplayName
    {
        public class Attributes
        {
            public static string LastModified =  "LastModified" ;
            public static string PortalProductId =  "PortalProductId" ;
            public static string PortalProductArn =  "PortalProductArn" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.PortalProduct; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-portalproduct.html#cfn-apigatewayv2-portalproduct-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-portalproduct.html#cfn-apigatewayv2-portalproduct-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-portalproduct.html#cfn-apigatewayv2-portalproduct-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}