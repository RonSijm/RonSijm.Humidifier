namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using RecommenderFilterTypes;

    public class RecommenderFilter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveDomainName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RecommenderFilterArn =  "RecommenderFilterArn" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.RecommenderFilter; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderfilter.html#cfn-customerprofiles-recommenderfilter-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderfilter.html#cfn-customerprofiles-recommenderfilter-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// RecommenderFilterExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderfilter.html#cfn-customerprofiles-recommenderfilter-recommenderfilterexpression
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecommenderFilterExpression { get; set; }
        /// <summary>
        /// RecommenderSchemaName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderfilter.html#cfn-customerprofiles-recommenderfilter-recommenderschemaname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RecommenderSchemaName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommenderfilter.html#cfn-customerprofiles-recommenderfilter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> Tags { get; set; }
        public dynamic RecommenderFilterName { get => GivenName; set => GivenName = value; }
    }

    namespace RecommenderFilterTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommenderfilter-tagsitems.html#cfn-customerprofiles-recommenderfilter-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommenderfilter-tagsitems.html#cfn-customerprofiles-recommenderfilter-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}