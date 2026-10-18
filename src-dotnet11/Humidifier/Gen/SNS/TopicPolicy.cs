namespace Humidifier.SNS
{
    using global::System.Collections.Generic;

    public class TopicPolicy : Humidifier.Base.BaseResource, IHaveStringListOfTopics, IHavePolicyDocument_Json
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SNS.TopicPolicy; }

        /// <summary>
        /// Topics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topicpolicy.html#cfn-sns-topicpolicy-topics
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Topics { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topicpolicy.html#cfn-sns-topicpolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}