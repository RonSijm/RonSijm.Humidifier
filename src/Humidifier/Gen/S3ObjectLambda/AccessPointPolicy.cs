namespace Humidifier.S3ObjectLambda
{
    using System.Collections.Generic;

    public class AccessPointPolicy : Humidifier.Base.BaseResource, IHavePolicyDocument
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
        public dynamic PolicyDocument { get; set; }

        /// <summary>
        /// ObjectLambdaAccessPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3objectlambda-accesspointpolicy.html#cfn-s3objectlambda-accesspointpolicy-objectlambdaaccesspoint
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ObjectLambdaAccessPoint { get; set; }
    }
}