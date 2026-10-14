namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using ConnectionFunctionTypes;

    public class ConnectionFunction : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        public Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig ConnectionFunctionConfig { get; set; }
        /// <summary>
        /// AutoPublish
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-autopublish
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoPublish { get; set; }

        /// <summary>
        /// ConnectionFunctionCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-connectionfunctioncode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectionFunctionCode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-connectionfunction.html#cfn-cloudfront-connectionfunction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConnectionFunctionTypes
    {
        public class ConnectionFunctionConfig : Humidifier.Base.BaseSubResource, IHaveComment, IHaveRuntime
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-connectionfunctionconfig.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-connectionfunctionconfig.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig-runtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// KeyValueStoreAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-connectionfunctionconfig.html#cfn-cloudfront-connectionfunction-connectionfunctionconfig-keyvaluestoreassociations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValueStoreAssociation
            /// </summary>
            public List<Humidifier.CloudFront.ConnectionFunctionTypes.KeyValueStoreAssociation> KeyValueStoreAssociations { get; set; }
        }

        public class KeyValueStoreAssociation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KeyValueStoreARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-connectionfunction-keyvaluestoreassociation.html#cfn-cloudfront-connectionfunction-keyvaluestoreassociation-keyvaluestorearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyValueStoreARN { get; set; }
        }
    }
}