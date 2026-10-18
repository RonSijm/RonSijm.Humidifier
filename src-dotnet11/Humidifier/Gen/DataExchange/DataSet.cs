namespace Humidifier.DataExchange
{
    using global::System.Collections.Generic;

    public class DataSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAssetType, IHaveDescription, IHaveName
    {
        public class Attributes
        {
            public static string Origin =  "Origin" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DataExchange.DataSet; }

        /// <summary>
        /// AssetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-dataset.html#cfn-dataexchange-dataset-assettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssetType { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-dataset.html#cfn-dataexchange-dataset-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-dataset.html#cfn-dataexchange-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}