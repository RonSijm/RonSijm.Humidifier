namespace Humidifier.SES
{
    using global::System.Collections.Generic;

    public class CustomVerificationEmailTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveTemplateName
    {
        public override string AWSTypeName { get => AWS.SES.CustomVerificationEmailTemplate; }

        /// <summary>
        /// FromEmailAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-fromemailaddress
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FromEmailAddress { get; set; }

        /// <summary>
        /// TemplateContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-templatecontent
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TemplateContent { get; set; }

        /// <summary>
        /// SuccessRedirectionURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-successredirectionurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SuccessRedirectionURL { get; set; }

        /// <summary>
        /// TemplateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-templatename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TemplateName { get; set; }

        /// <summary>
        /// FailureRedirectionURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-failureredirectionurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FailureRedirectionURL { get; set; }

        /// <summary>
        /// TemplateSubject
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-templatesubject
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TemplateSubject { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-customverificationemailtemplate.html#cfn-ses-customverificationemailtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}