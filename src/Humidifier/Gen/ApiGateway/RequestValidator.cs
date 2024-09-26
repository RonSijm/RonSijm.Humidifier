namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;

    public class RequestValidator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveRestApiId
    {
        public class Attributes
        {
            public static string RequestValidatorId =  "RequestValidatorId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.RequestValidator; }
        /// <summary>
        /// ValidateRequestParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-requestvalidator.html#cfn-apigateway-requestvalidator-validaterequestparameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ValidateRequestParameters { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-requestvalidator.html#cfn-apigateway-requestvalidator-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RestApiId { get; set; }
        /// <summary>
        /// ValidateRequestBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-requestvalidator.html#cfn-apigateway-requestvalidator-validaterequestbody
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ValidateRequestBody { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}