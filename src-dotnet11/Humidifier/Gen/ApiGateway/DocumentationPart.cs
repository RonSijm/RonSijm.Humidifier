namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using DocumentationPartTypes;

    public class DocumentationPart : Humidifier.Base.BaseResource, IHaveRestApiId, IHaveProperties, IHaveApiGatewayDocumentationPartTypesLocationLocation
    {
        public class Attributes
        {
            public static string DocumentationPartId =  "DocumentationPartId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.DocumentationPart; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RestApiId { get; set; }

        /// <summary>
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-properties
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Properties { get; set; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-location
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Location
        /// </summary>
        [Required]
        public Union<Humidifier.ApiGateway.DocumentationPartTypes.Location, BaseFunction>? Location { get; set; }
    }

    namespace DocumentationPartTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHavePath, IHaveType, IHaveMethod, IHaveStatusCode, IHaveName
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-documentationpart-location.html#cfn-apigateway-documentationpart-location-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-documentationpart-location.html#cfn-apigateway-documentationpart-location-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-documentationpart-location.html#cfn-apigateway-documentationpart-location-method
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-documentationpart-location.html#cfn-apigateway-documentationpart-location-statuscode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-documentationpart-location.html#cfn-apigateway-documentationpart-location-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}