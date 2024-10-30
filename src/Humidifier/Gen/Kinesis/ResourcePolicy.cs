namespace Humidifier.Kinesis
{
    using System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHaveResourceArn
    {
        public override string AWSTypeName { get => AWS.Kinesis.ResourcePolicy; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-resourcepolicy.html#cfn-kinesis-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// ResourcePolicy_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-resourcepolicy.html#cfn-kinesis-resourcepolicy-resourcepolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic ResourcePolicy_ { get; set; }
    }
}