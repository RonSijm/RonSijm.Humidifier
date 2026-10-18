namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;
    using ReviewTemplateTypes;

    public class ReviewTemplate : Humidifier.Base.BaseResource, IHaveDescription, IHaveTemplateName, IHaveNotes, IHaveListOfWellArchitectedReviewTemplateTypesTagsItemsTags, IHaveStringListOfLenses
    {
        public class Attributes
        {
            public static string TemplateArn =  "TemplateArn" ;
            public static string Owner =  "Owner" ;
            public static string UpdateStatus =  "UpdateStatus" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.ReviewTemplate; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-reviewtemplate.html#cfn-wellarchitected-reviewtemplate-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// TemplateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-reviewtemplate.html#cfn-wellarchitected-reviewtemplate-templatename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TemplateName { get; set; }
        /// <summary>
        /// Notes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-reviewtemplate.html#cfn-wellarchitected-reviewtemplate-notes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Notes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-reviewtemplate.html#cfn-wellarchitected-reviewtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems>, IReadOnlyList<Union<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Lenses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-reviewtemplate.html#cfn-wellarchitected-reviewtemplate-lenses
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Lenses { get; set; }
    }

    namespace ReviewTemplateTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-reviewtemplate-tagsitems.html#cfn-wellarchitected-reviewtemplate-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-reviewtemplate-tagsitems.html#cfn-wellarchitected-reviewtemplate-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}