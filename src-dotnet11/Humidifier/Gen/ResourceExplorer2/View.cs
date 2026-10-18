namespace Humidifier.ResourceExplorer2
{
    using global::System.Collections.Generic;
    using ViewTypes;

    public class View : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveResourceExplorer2ViewTypesSearchFilterFilters, IHaveScope, IHaveListOfResourceExplorer2ViewTypesIncludedPropertyIncludedProperties, IHaveStringDictionaryOfTags, IHaveViewName
    {
        public class Attributes
        {
            public static string ViewArn =  "ViewArn" ;
        }

        public override string AWSTypeName { get => AWS.ResourceExplorer2.View; }
        /// <summary>
        /// Filters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-filters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SearchFilter
        /// </summary>
        public Union<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter, BaseFunction>? Filters { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-scope
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Scope { get; set; }
        /// <summary>
        /// IncludedProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-includedproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IncludedProperty
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty>, IReadOnlyList<Union<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty, BaseFunction>>, BaseFunction>? IncludedProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? ViewName { get => GivenName; set => GivenName = value; }
    }

    namespace ViewTypes
    {
        public class IncludedProperty : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourceexplorer2-view-includedproperty.html#cfn-resourceexplorer2-view-includedproperty-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SearchFilter : Humidifier.Base.BaseSubResource, IHaveFilterString
        {
            /// <summary>
            /// FilterString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourceexplorer2-view-searchfilter.html#cfn-resourceexplorer2-view-searchfilter-filterstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterString { get; set; }
        }
    }
}