namespace Humidifier.EventSchemas
{
    using global::System.Collections.Generic;
    using DiscovererTypes;

    public class Discoverer : Humidifier.Base.BaseResource, IHaveCrossAccount_Boolean, IHaveDescription, IHaveSourceArn, IHaveListOfEventSchemasDiscovererTypesTagsEntryTags
    {
        public class Attributes
        {
            public static string DiscovererArn =  "DiscovererArn" ;
            public static string DiscovererId =  "DiscovererId" ;
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.EventSchemas.Discoverer; }
        /// <summary>
        /// CrossAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-crossaccount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CrossAccount { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-sourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsEntry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EventSchemas.DiscovererTypes.TagsEntry>, IReadOnlyList<Union<Humidifier.EventSchemas.DiscovererTypes.TagsEntry, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DiscovererTypes
    {
        public class TagsEntry : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventschemas-discoverer-tagsentry.html#cfn-eventschemas-discoverer-tagsentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventschemas-discoverer-tagsentry.html#cfn-eventschemas-discoverer-tagsentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}