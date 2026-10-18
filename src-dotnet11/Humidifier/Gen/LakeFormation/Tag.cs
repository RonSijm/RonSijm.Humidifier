namespace Humidifier.LakeFormation
{
    using global::System.Collections.Generic;

    public class Tag : Humidifier.Base.BaseResource, IHaveTagKey, IHaveCatalogId, IHaveStringListOfTagValues
    {
        public override string AWSTypeName { get => AWS.LakeFormation.Tag; }

        /// <summary>
        /// TagKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-tag.html#cfn-lakeformation-tag-tagkey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TagKey { get; set; }
        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-tag.html#cfn-lakeformation-tag-catalogid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CatalogId { get; set; }

        /// <summary>
        /// TagValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-tag.html#cfn-lakeformation-tag-tagvalues
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagValues { get; set; }
    }
}