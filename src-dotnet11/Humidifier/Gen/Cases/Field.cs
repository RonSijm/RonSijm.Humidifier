namespace Humidifier.Cases
{
    using global::System.Collections.Generic;
    using FieldTypes;

    public class Field : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveDescription, IHaveDomainId, IHaveCasesFieldTypesFieldAttributesAttributes_, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string FieldId =  "FieldId" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string FieldArn =  "FieldArn" ;
            public static string Namespace =  "Namespace" ;
        }

        public override string AWSTypeName { get => AWS.Cases.Field; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-field.html#cfn-cases-field-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-field.html#cfn-cases-field-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-field.html#cfn-cases-field-domainid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainId { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-field.html#cfn-cases-field-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FieldAttributes
        /// </summary>
        public Union<Humidifier.Cases.FieldTypes.FieldAttributes, BaseFunction>? Attributes_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-field.html#cfn-cases-field-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FieldTypes
    {
        public class FieldAttributes : Humidifier.Base.BaseSubResource, IHaveCasesFieldTypesTextAttributesText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-field-fieldattributes.html#cfn-cases-field-fieldattributes-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextAttributes
            /// </summary>
            public Union<Humidifier.Cases.FieldTypes.TextAttributes, BaseFunction>? Text { get; set; }
        }

        public class TextAttributes : Humidifier.Base.BaseSubResource, IHaveIsMultiline_Boolean
        {
            /// <summary>
            /// IsMultiline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cases-field-textattributes.html#cfn-cases-field-textattributes-ismultiline
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsMultiline { get; set; }
        }
    }
}