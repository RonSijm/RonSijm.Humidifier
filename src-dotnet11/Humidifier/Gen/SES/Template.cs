namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource, IHaveTags, IHaveSESTemplateTypesTemplateTemplate_
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SES.Template; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-template.html#cfn-ses-template-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Template_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-template.html#cfn-ses-template-template
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Template
        /// </summary>
        public Union<Humidifier.SES.TemplateTypes.Template, BaseFunction>? Template_ { get; set; }
    }

    namespace TemplateTypes
    {
        public class Template : Humidifier.Base.BaseSubResource, IHaveHtmlPart, IHaveTextPart, IHaveTemplateName, IHaveSubjectPart
        {
            /// <summary>
            /// HtmlPart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-htmlpart
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HtmlPart { get; set; }
            /// <summary>
            /// TextPart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-textpart
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextPart { get; set; }
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-templatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateName { get; set; }
            /// <summary>
            /// SubjectPart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-subjectpart
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubjectPart { get; set; }
        }
    }
}