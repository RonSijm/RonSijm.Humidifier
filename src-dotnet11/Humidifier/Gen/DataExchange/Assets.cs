namespace Humidifier.DataExchange
{
    using global::System.Collections.Generic;
    using AssetsTypes;

    public class Assets : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDataSetId, IHaveRevisionId, IHaveName
    {
        public class Attributes
        {
            public static string AssetType =  "AssetType" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string AssetId =  "AssetId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.DataExchange.Assets; }
        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-assets.html#cfn-dataexchange-assets-datasetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataSetId { get; set; }
        /// <summary>
        /// RevisionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-assets.html#cfn-dataexchange-assets-revisionid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RevisionId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AssetsTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-assets-tagsitems.html#cfn-dataexchange-assets-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-assets-tagsitems.html#cfn-dataexchange-assets-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}