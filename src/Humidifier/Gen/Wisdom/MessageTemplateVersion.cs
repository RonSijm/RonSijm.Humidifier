namespace Humidifier.Wisdom
{
    using System.Collections.Generic;

    public class MessageTemplateVersion : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string MessageTemplateVersionArn =  "MessageTemplateVersionArn" ;
            public static string MessageTemplateVersionNumber =  "MessageTemplateVersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.MessageTemplateVersion; }

        /// <summary>
        /// MessageTemplateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplateversion.html#cfn-wisdom-messagetemplateversion-messagetemplatearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MessageTemplateArn { get; set; }
        /// <summary>
        /// MessageTemplateContentSha256
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplateversion.html#cfn-wisdom-messagetemplateversion-messagetemplatecontentsha256
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic MessageTemplateContentSha256 { get; set; }
    }
}