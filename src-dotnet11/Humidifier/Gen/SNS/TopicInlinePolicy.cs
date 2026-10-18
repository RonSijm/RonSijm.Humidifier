namespace Humidifier.SNS
{
    using global::System.Collections.Generic;

    public class TopicInlinePolicy : Humidifier.Base.BaseResource, IHaveTopicArn, IHavePolicyDocument_Json
    {
        public override string AWSTypeName { get => AWS.SNS.TopicInlinePolicy; }

        /// <summary>
        /// TopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topicinlinepolicy.html#cfn-sns-topicinlinepolicy-topicarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TopicArn { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topicinlinepolicy.html#cfn-sns-topicinlinepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}