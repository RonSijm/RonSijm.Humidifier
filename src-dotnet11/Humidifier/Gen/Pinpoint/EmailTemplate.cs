namespace Humidifier.Pinpoint
{
    using global::System.Collections.Generic;

    public class EmailTemplate : Humidifier.Base.BaseResource, IHaveHtmlPart, IHaveTextPart, IHaveTemplateName, IHaveTemplateDescription, IHaveDefaultSubstitutions, IHaveSubject, IHaveTags_Json
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Pinpoint.EmailTemplate; }
        /// <summary>
        /// HtmlPart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-htmlpart
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HtmlPart { get; set; }
        /// <summary>
        /// TextPart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-textpart
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TextPart { get; set; }

        /// <summary>
        /// TemplateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-templatename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TemplateName { get; set; }
        /// <summary>
        /// TemplateDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-templatedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateDescription { get; set; }
        /// <summary>
        /// DefaultSubstitutions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-defaultsubstitutions
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultSubstitutions { get; set; }

        /// <summary>
        /// Subject
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-subject
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Subject { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html#cfn-pinpoint-emailtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
    }
}