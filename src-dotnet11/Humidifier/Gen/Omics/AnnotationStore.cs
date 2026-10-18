namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using AnnotationStoreTypes;

    public class AnnotationStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStoreFormat, IHaveDescription, IHaveOmicsAnnotationStoreTypesReferenceItemReference, IHaveOmicsAnnotationStoreTypesSseConfigSseConfig, IHaveOmicsAnnotationStoreTypesStoreOptionsStoreOptions, IHaveStringDictionaryOfTags, IHaveName
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

        public override string AWSTypeName { get => AWS.Omics.AnnotationStore; }

        /// <summary>
        /// StoreFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-annotationstore.html#cfn-omics-annotationstore-storeformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StoreFormat { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-annotationstore.html#cfn-omics-annotationstore-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Reference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-annotationstore.html#cfn-omics-annotationstore-reference
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ReferenceItem
        /// </summary>
        public Union<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem, BaseFunction>? Reference { get; set; }
        /// <summary>
        /// SseConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-annotationstore.html#cfn-omics-annotationstore-sseconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseConfig
        /// </summary>
        public Union<Humidifier.Omics.AnnotationStoreTypes.SseConfig, BaseFunction>? SseConfig { get; set; }
        /// <summary>
        /// StoreOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-annotationstore.html#cfn-omics-annotationstore-storeoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoreOptions
        /// </summary>
        public Union<Humidifier.Omics.AnnotationStoreTypes.StoreOptions, BaseFunction>? StoreOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-annotationstore.html#cfn-omics-annotationstore-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AnnotationStoreTypes
    {
        public class ReferenceItem : Humidifier.Base.BaseSubResource, IHaveReferenceArn
        {
            /// <summary>
            /// ReferenceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-referenceitem.html#cfn-omics-annotationstore-referenceitem-referencearn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-sseconfig.html#cfn-omics-annotationstore-sseconfig-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-sseconfig.html#cfn-omics-annotationstore-sseconfig-keyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyArn { get; set; }
        }

        public class StoreOptions : Humidifier.Base.BaseSubResource, IHaveOmicsAnnotationStoreTypesTsvStoreOptionsTsvStoreOptions
        {
            /// <summary>
            /// TsvStoreOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-storeoptions.html#cfn-omics-annotationstore-storeoptions-tsvstoreoptions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TsvStoreOptions
            /// </summary>
            public Union<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions, BaseFunction>? TsvStoreOptions { get; set; }
        }

        public class TsvStoreOptions : Humidifier.Base.BaseSubResource, IHaveSchema_Json, IHaveStringDictionaryOfFormatToHeader, IHaveAnnotationType
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-tsvstoreoptions.html#cfn-omics-annotationstore-tsvstoreoptions-schema
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// FormatToHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-tsvstoreoptions.html#cfn-omics-annotationstore-tsvstoreoptions-formattoheader
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? FormatToHeader { get; set; }
            /// <summary>
            /// AnnotationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-annotationstore-tsvstoreoptions.html#cfn-omics-annotationstore-tsvstoreoptions-annotationtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnnotationType { get; set; }
        }
    }
}