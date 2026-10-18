namespace Humidifier.Textract
{
    using global::System.Collections.Generic;

    public class Adapter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAdapterName, IHaveDescription, IHaveAutoUpdate, IHaveStringListOfFeatureTypes
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string AdapterId =  "AdapterId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Textract.Adapter; }
        public Union<string, BaseFunction>? AdapterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-textract-adapter.html#cfn-textract-adapter-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AutoUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-textract-adapter.html#cfn-textract-adapter-autoupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoUpdate { get; set; }

        /// <summary>
        /// FeatureTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-textract-adapter.html#cfn-textract-adapter-featuretypes
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FeatureTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-textract-adapter.html#cfn-textract-adapter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}