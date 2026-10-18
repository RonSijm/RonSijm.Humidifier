namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using RecommenderSchemaTypes;

    public class RecommenderSchema : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFields_Json, IHaveDomainName, IHaveRecommenderSchemaName, IHaveListOfCustomerProfilesRecommenderSchemaTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.RecommenderSchema; }

        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderschema.html#cfn-customerprofiles-recommenderschema-fields
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Fields { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderschema.html#cfn-customerprofiles-recommenderschema-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        public Union<string, BaseFunction>? RecommenderSchemaName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderschema.html#cfn-customerprofiles-recommenderschema-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems>, IReadOnlyList<Union<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RecommenderSchemaTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommenderschema-tagsitems.html#cfn-customerprofiles-recommenderschema-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommenderschema-tagsitems.html#cfn-customerprofiles-recommenderschema-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}