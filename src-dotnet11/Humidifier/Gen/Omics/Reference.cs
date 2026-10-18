namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using ReferenceTypes;

    public class Reference : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveReferenceStoreId, IHaveListOfOmicsReferenceTypesTagsItemsTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string CreationJobId =  "CreationJobId" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string CreationType =  "CreationType" ;
            public static string Md5 =  "Md5" ;
        }

        public override string AWSTypeName { get => AWS.Omics.Reference; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-reference.html#cfn-omics-reference-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ReferenceStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-reference.html#cfn-omics-reference-referencestoreid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReferenceStoreId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-reference.html#cfn-omics-reference-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Omics.ReferenceTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Omics.ReferenceTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ReferenceTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-reference-tagsitems.html#cfn-omics-reference-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-reference-tagsitems.html#cfn-omics-reference-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}