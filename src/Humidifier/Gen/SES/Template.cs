namespace Humidifier.SES
{
    using System.Collections.Generic;
    using TemplateTypes;

    public class Template : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SES.Template; }
        /// <summary>
        /// Template_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-template.html#cfn-ses-template-template
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Template
        /// </summary>
        public Humidifier.SES.TemplateTypes.Template Template_ { get; set; }
    }

    namespace TemplateTypes
    {
        public class Template : Humidifier.Base.BaseSubResource, IHaveTemplateName
        {
            /// <summary>
            /// HtmlPart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-htmlpart
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HtmlPart { get; set; }
            /// <summary>
            /// TextPart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-textpart
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextPart { get; set; }
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-templatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateName { get; set; }
            /// <summary>
            /// SubjectPart
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-subjectpart
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubjectPart { get; set; }
        }
    }
}