namespace Humidifier.ResourceGroups
{
    using global::System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfResourceGroupsGroupTypesConfigurationItemConfiguration, IHaveResourceGroupsGroupTypesResourceQueryResourceQuery, IHaveStringListOfResources, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ResourceGroups.Group; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-group.html#cfn-resourcegroups-group-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-group.html#cfn-resourcegroups-group-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfigurationItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem>, IReadOnlyList<Union<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem, BaseFunction>>, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// ResourceQuery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-group.html#cfn-resourcegroups-group-resourcequery
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourceQuery
        /// </summary>
        public Union<Humidifier.ResourceGroups.GroupTypes.ResourceQuery, BaseFunction>? ResourceQuery { get; set; }
        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-group.html#cfn-resourcegroups-group-resources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-group.html#cfn-resourcegroups-group-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace GroupTypes
    {
        public class ConfigurationItem : Humidifier.Base.BaseSubResource, IHaveType, IHaveListOfResourceGroupsGroupTypesConfigurationParameterParameters
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-configurationitem.html#cfn-resourcegroups-group-configurationitem-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-configurationitem.html#cfn-resourcegroups-group-configurationitem-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConfigurationParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ResourceGroups.GroupTypes.ConfigurationParameter>, IReadOnlyList<Union<Humidifier.ResourceGroups.GroupTypes.ConfigurationParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
        }

        public class ConfigurationParameter : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-configurationparameter.html#cfn-resourcegroups-group-configurationparameter-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-configurationparameter.html#cfn-resourcegroups-group-configurationparameter-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Query : Humidifier.Base.BaseSubResource, IHaveListOfResourceGroupsGroupTypesTagFilterTagFilters, IHaveStringListOfResourceTypeFilters, IHaveStackIdentifier
        {
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html#cfn-resourcegroups-group-query-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ResourceGroups.GroupTypes.TagFilter>, IReadOnlyList<Union<Humidifier.ResourceGroups.GroupTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
            /// <summary>
            /// ResourceTypeFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html#cfn-resourcegroups-group-query-resourcetypefilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypeFilters { get; set; }
            /// <summary>
            /// StackIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-query.html#cfn-resourcegroups-group-query-stackidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StackIdentifier { get; set; }
        }

        public class ResourceQuery : Humidifier.Base.BaseSubResource, IHaveType, IHaveResourceGroupsGroupTypesQueryQuery
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-resourcequery.html#cfn-resourcegroups-group-resourcequery-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-resourcequery.html#cfn-resourcegroups-group-resourcequery-query
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Query
            /// </summary>
            public Union<Humidifier.ResourceGroups.GroupTypes.Query, BaseFunction>? Query { get; set; }
        }

        public class TagFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-tagfilter.html#cfn-resourcegroups-group-tagfilter-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-tagfilter.html#cfn-resourcegroups-group-tagfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}