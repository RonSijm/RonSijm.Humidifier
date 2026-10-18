namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using ConnectionFunctionTypes;

    public class ConnectionFunction : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCloudFrontConnectionFunctionTypesConnectionFunctionConfigConnectionFunctionConfig, IHaveAutoPublish_Boolean, IHaveConnectionFunctionCode, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ConnectionFunctionArn =  "ConnectionFunctionArn" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string ETag =  "ETag" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Stage =  "Stage" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.ConnectionFunction; }

        /// <summary>
        /// ConnectionFunctionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConnectionFunctionConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig, BaseFunction>? ConnectionFunctionConfig { get; set; }
        /// <summary>
        /// AutoPublish
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-autopublish
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoPublish { get; set; }

        /// <summary>
        /// ConnectionFunctionCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-connectionfunctioncode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionFunctionCode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConnectionFunctionTypes
    {
        public class ConnectionFunctionConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveRuntime, IHaveListOfCloudFrontConnectionFunctionTypesKeyValueStoreAssociationKeyValueStoreAssociations
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-connectionfunctionconfig.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-connectionfunctionconfig.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig-runtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// KeyValueStoreAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-connectionfunctionconfig.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig-keyvaluestoreassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValueStoreAssociation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFront.ConnectionFunctionTypes.KeyValueStoreAssociation>, IReadOnlyList<Union<Humidifier.CloudFront.ConnectionFunctionTypes.KeyValueStoreAssociation, BaseFunction>>, BaseFunction>? KeyValueStoreAssociations { get; set; }
        }

        public class KeyValueStoreAssociation : Humidifier.Base.BaseSubResource, IHaveKeyValueStoreARN
        {
            /// <summary>
            /// KeyValueStoreARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-keyvaluestoreassociation.html#cfn-cloudfront-connectionfunction-keyvaluestoreassociation-keyvaluestorearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyValueStoreARN { get; set; }
        }
    }
}