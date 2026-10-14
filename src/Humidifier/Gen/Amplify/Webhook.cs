namespace Humidifier.Amplify
{
    using global::System.Collections.Generic;

    public class Webhook : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveAppId, IHaveBranchName
    {
        public class Attributes
        {
            public static string WebhookUrl =  "WebhookUrl" ;
            public static string WebhookId =  "WebhookId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Amplify.Webhook; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-webhook.html#cfn-amplify-webhook-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-webhook.html#cfn-amplify-webhook-appid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AppId { get; set; }

        /// <summary>
        /// BranchName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-webhook.html#cfn-amplify-webhook-branchname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BranchName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-webhook.html#cfn-amplify-webhook-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}