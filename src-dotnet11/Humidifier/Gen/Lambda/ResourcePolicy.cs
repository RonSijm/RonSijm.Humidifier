namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHaveResourceArn, IHavePolicyDocument_Json
    {
        public override string AWSTypeName { get => AWS.Lambda.ResourcePolicy; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-resourcepolicy.html#cfn-lambda-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceArn { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-resourcepolicy.html#cfn-lambda-resourcepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}