namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using FunctionTypes;

    public class Function : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCloudFrontFunctionTypesFunctionConfigFunctionConfig, IHaveCloudFrontFunctionTypesFunctionMetadataFunctionMetadata, IHaveAutoPublish_Boolean, IHaveFunctionCode, IHaveName
    {
        public class Attributes
        {
            public static string FunctionARN =  "FunctionARN" ;
            public static string Stage =  "Stage" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.Function; }

        /// <summary>
        /// FunctionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-functionconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FunctionConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.FunctionTypes.FunctionConfig, BaseFunction>? FunctionConfig { get; set; }
        /// <summary>
        /// FunctionMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-functionmetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FunctionMetadata
        /// </summary>
        public Union<Humidifier.CloudFront.FunctionTypes.FunctionMetadata, BaseFunction>? FunctionMetadata { get; set; }
        /// <summary>
        /// AutoPublish
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-autopublish
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoPublish { get; set; }

        /// <summary>
        /// FunctionCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-functioncode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionCode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FunctionTypes
    {
        public class FunctionConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveRuntime, IHaveListOfCloudFrontFunctionTypesKeyValueStoreAssociationKeyValueStoreAssociations
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html#cfn-cloudfront-function-functionconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html#cfn-cloudfront-function-functionconfig-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// KeyValueStoreAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html#cfn-cloudfront-function-functionconfig-keyvaluestoreassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValueStoreAssociation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.FunctionTypes.KeyValueStoreAssociation>, IReadOnlyList<Union<Humidifier.CloudFront.FunctionTypes.KeyValueStoreAssociation, BaseFunction>>, BaseFunction>? KeyValueStoreAssociations { get; set; }
        }

        public class FunctionMetadata : Humidifier.Base.BaseSubResource, IHaveFunctionARN
        {
            /// <summary>
            /// FunctionARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionmetadata.html#cfn-cloudfront-function-functionmetadata-functionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionARN { get; set; }
        }

        public class KeyValueStoreAssociation : Humidifier.Base.BaseSubResource, IHaveKeyValueStoreARN
        {
            /// <summary>
            /// KeyValueStoreARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-keyvaluestoreassociation.html#cfn-cloudfront-function-keyvaluestoreassociation-keyvaluestorearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyValueStoreARN { get; set; }
        }
    }
}