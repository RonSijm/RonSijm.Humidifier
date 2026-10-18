namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using ReferenceStoreTypes;

    public class ReferenceStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveOmicsReferenceStoreTypesSseConfigSseConfig, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string ReferenceStoreId =  "ReferenceStoreId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Omics.ReferenceStore; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-referencestore.html#cfn-omics-referencestore-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SseConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-referencestore.html#cfn-omics-referencestore-sseconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseConfig
        /// </summary>
        public Union<Humidifier.Omics.ReferenceStoreTypes.SseConfig, BaseFunction>? SseConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-referencestore.html#cfn-omics-referencestore-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ReferenceStoreTypes
    {
        public class SseConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveKeyArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-referencestore-sseconfig.html#cfn-omics-referencestore-sseconfig-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-referencestore-sseconfig.html#cfn-omics-referencestore-sseconfig-keyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyArn { get; set; }
        }
    }
}