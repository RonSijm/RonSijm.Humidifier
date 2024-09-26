namespace Humidifier.ResourceExplorer2
{
    using System.Collections.Generic;
    using ViewTypes;

    public class View : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveScope
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
        public Humidifier.ResourceExplorer2.ViewTypes.SearchFilter Filters { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-scope
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Scope { get; set; }
        /// <summary>
        /// IncludedProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-includedproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IncludedProperty
        /// </summary>
        public List<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> IncludedProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-view.html#cfn-resourceexplorer2-view-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic ViewName { get => GivenName; set => GivenName = value; }
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
            public dynamic Name { get; set; }
        }

        public class SearchFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilterString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourceexplorer2-view-searchfilter.html#cfn-resourceexplorer2-view-searchfilter-filterstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterString { get; set; }
        }
    }
}