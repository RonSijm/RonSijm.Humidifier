namespace Humidifier.S3ObjectLambda
{
    using global::System.Collections.Generic;

    public class AccessPointPolicy : Humidifier.Base.BaseResource, IHavePolicyDocument_Json, IHaveObjectLambdaAccessPoint
    {
        public override string AWSTypeName { get => AWS.S3ObjectLambda.AccessPointPolicy; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3objectlambda-accesspointpolicy.html#cfn-s3objectlambda-accesspointpolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }

        /// <summary>
        /// ObjectLambdaAccessPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3objectlambda-accesspointpolicy.html#cfn-s3objectlambda-accesspointpolicy-objectlambdaaccesspoint
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ObjectLambdaAccessPoint { get; set; }
    }
}