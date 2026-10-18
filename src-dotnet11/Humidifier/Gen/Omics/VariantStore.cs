namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using VariantStoreTypes;

    public class VariantStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveOmicsVariantStoreTypesReferenceItemReference, IHaveOmicsVariantStoreTypesSseConfigSseConfig, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Id =  "Id" ;
            public static string StoreSizeBytes =  "StoreSizeBytes" ;
            public static string StatusMessage =  "StatusMessage" ;
            public static string StoreArn =  "StoreArn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.VariantStore; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-variantstore.html#cfn-omics-variantstore-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Reference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-variantstore.html#cfn-omics-variantstore-reference
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ReferenceItem
        /// </summary>
        [Required]
        public Union<Humidifier.Omics.VariantStoreTypes.ReferenceItem, BaseFunction>? Reference { get; set; }
        /// <summary>
        /// SseConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-variantstore.html#cfn-omics-variantstore-sseconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseConfig
        /// </summary>
        public Union<Humidifier.Omics.VariantStoreTypes.SseConfig, BaseFunction>? SseConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-variantstore.html#cfn-omics-variantstore-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace VariantStoreTypes
    {
        public class ReferenceItem : Humidifier.Base.BaseSubResource, IHaveReferenceArn
        {
            /// <summary>
            /// ReferenceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-variantstore-referenceitem.html#cfn-omics-variantstore-referenceitem-referencearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferenceArn { get; set; }
        }

        public class SseConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveKeyArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-variantstore-sseconfig.html#cfn-omics-variantstore-sseconfig-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-variantstore-sseconfig.html#cfn-omics-variantstore-sseconfig-keyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyArn { get; set; }
        }
    }
}