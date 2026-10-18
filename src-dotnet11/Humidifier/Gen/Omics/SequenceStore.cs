namespace Humidifier.Omics
{
    using global::System.Collections.Generic;
    using SequenceStoreTypes;

    public class SequenceStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveStringListOfPropagatedSetLevelTags, IHaveFallbackLocation, IHaveOmicsSequenceStoreTypesSseConfigSseConfig, IHaveAccessLogLocation, IHaveETagAlgorithmFamily, IHaveS3AccessPolicy_Json, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SequenceStoreId =  "SequenceStoreId" ;
            public static string S3Uri =  "S3Uri" ;
            public static string CreationTime =  "CreationTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string S3AccessPointArn =  "S3AccessPointArn" ;
            public static string Arn =  "Arn" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Omics.SequenceStore; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PropagatedSetLevelTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-propagatedsetleveltags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PropagatedSetLevelTags { get; set; }
        /// <summary>
        /// FallbackLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-fallbacklocation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FallbackLocation { get; set; }
        /// <summary>
        /// SseConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-sseconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseConfig
        /// </summary>
        public Union<Humidifier.Omics.SequenceStoreTypes.SseConfig, BaseFunction>? SseConfig { get; set; }
        /// <summary>
        /// AccessLogLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-accessloglocation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessLogLocation { get; set; }
        /// <summary>
        /// ETagAlgorithmFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-etagalgorithmfamily
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ETagAlgorithmFamily { get; set; }
        /// <summary>
        /// S3AccessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-s3accesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? S3AccessPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-omics-sequencestore.html#cfn-omics-sequencestore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SequenceStoreTypes
    {
        public class SseConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveKeyArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-sequencestore-sseconfig.html#cfn-omics-sequencestore-sseconfig-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-omics-sequencestore-sseconfig.html#cfn-omics-sequencestore-sseconfig-keyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyArn { get; set; }
        }
    }
}