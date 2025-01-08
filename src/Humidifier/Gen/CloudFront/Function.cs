namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using FunctionTypes;

    public class Function : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
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
        public Humidifier.CloudFront.FunctionTypes.FunctionConfig FunctionConfig { get; set; }
        /// <summary>
        /// FunctionMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-functionmetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FunctionMetadata
        /// </summary>
        public Humidifier.CloudFront.FunctionTypes.FunctionMetadata FunctionMetadata { get; set; }
        /// <summary>
        /// AutoPublish
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-autopublish
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoPublish { get; set; }

        /// <summary>
        /// FunctionCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html#cfn-cloudfront-function-functioncode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionCode { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FunctionTypes
    {
        public class FunctionConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveRuntime
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html#cfn-cloudfront-function-functionconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html#cfn-cloudfront-function-functionconfig-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// KeyValueStoreAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-functionconfig.html#cfn-cloudfront-function-functionconfig-keyvaluestoreassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValueStoreAssociation
            /// </summary>
            public List<Humidifier.CloudFront.FunctionTypes.KeyValueStoreAssociation> KeyValueStoreAssociations { get; set; }
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
            public dynamic FunctionARN { get; set; }
        }

        public class KeyValueStoreAssociation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KeyValueStoreARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-function-keyvaluestoreassociation.html#cfn-cloudfront-function-keyvaluestoreassociation-keyvaluestorearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyValueStoreARN { get; set; }
        }
    }
}