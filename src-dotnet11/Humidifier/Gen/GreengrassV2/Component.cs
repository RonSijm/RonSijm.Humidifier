namespace Humidifier.GreengrassV2
{
    using global::System.Collections.Generic;
    using ComponentTypes;

    public class Component : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveComponentName, IHaveListOfGreengrassV2ComponentTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.GreengrassV2.Component; }
        public Union<string, BaseFunction>? ComponentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-component.html#cfn-greengrassv2-component-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GreengrassV2.ComponentTypes.TagsItems>, IReadOnlyList<Union<Humidifier.GreengrassV2.ComponentTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ComponentTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-component-tagsitems.html#cfn-greengrassv2-component-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-component-tagsitems.html#cfn-greengrassv2-component-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}