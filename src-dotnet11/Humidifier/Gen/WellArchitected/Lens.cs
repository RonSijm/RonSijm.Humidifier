namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;
    using LensTypes;

    public class Lens : Humidifier.Base.BaseResource, IHaveLensVersion, IHaveJSONString, IHaveListOfWellArchitectedLensTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string Description =  "Description" ;
            public static string LensArn =  "LensArn" ;
            public static string LensId =  "LensId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.Lens; }
        /// <summary>
        /// LensVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-lens.html#cfn-wellarchitected-lens-lensversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LensVersion { get; set; }
        /// <summary>
        /// JSONString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-lens.html#cfn-wellarchitected-lens-jsonstring
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JSONString { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-lens.html#cfn-wellarchitected-lens-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WellArchitected.LensTypes.TagsItems>, IReadOnlyList<Union<Humidifier.WellArchitected.LensTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LensTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-lens-tagsitems.html#cfn-wellarchitected-lens-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-lens-tagsitems.html#cfn-wellarchitected-lens-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}