namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using FieldLevelEncryptionConfigTypes;

    public class FieldLevelEncryptionConfig : Humidifier.Base.BaseResource, IHaveComment
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.FieldLevelEncryptionConfig; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-fieldlevelencryptionconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Comment { get; set; }

        /// <summary>
        /// ContentTypeProfileConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-fieldlevelencryptionconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-contenttypeprofileconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ContentTypeProfileConfig
        /// </summary>
        [Required]
        public Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfileConfig ContentTypeProfileConfig { get; set; }

        /// <summary>
        /// QueryArgProfileConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-fieldlevelencryptionconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-queryargprofileconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QueryArgProfileConfig
        /// </summary>
        [Required]
        public Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfileConfig QueryArgProfileConfig { get; set; }

        /// <summary>
        /// CallerReference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-fieldlevelencryptionconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-callerreference
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CallerReference { get; set; }
    }

    namespace FieldLevelEncryptionConfigTypes
    {
        public class ContentTypeProfile : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveFormat, IHaveProfileId
        {
            /// <summary>
            /// ProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-contenttypeprofile.html#cfn-cloudfront-fieldlevelencryptionconfig-contenttypeprofile-profileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfileId { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-contenttypeprofile.html#cfn-cloudfront-fieldlevelencryptionconfig-contenttypeprofile-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-contenttypeprofile.html#cfn-cloudfront-fieldlevelencryptionconfig-contenttypeprofile-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
        }

        public class ContentTypeProfileConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentTypeProfiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-contenttypeprofileconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-contenttypeprofileconfig-contenttypeprofiles
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentTypeProfile
            /// </summary>
            public List<Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.ContentTypeProfile> ContentTypeProfiles { get; set; }
            /// <summary>
            /// ForwardWhenContentTypeIsUnknown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-contenttypeprofileconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-contenttypeprofileconfig-forwardwhencontenttypeisunknown
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ForwardWhenContentTypeIsUnknown { get; set; }
        }

        public class QueryArgProfile : Humidifier.Base.BaseSubResource, IHaveProfileId
        {
            /// <summary>
            /// ProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-queryargprofile.html#cfn-cloudfront-fieldlevelencryptionconfig-queryargprofile-profileid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfileId { get; set; }
            /// <summary>
            /// QueryArg
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-queryargprofile.html#cfn-cloudfront-fieldlevelencryptionconfig-queryargprofile-queryarg
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryArg { get; set; }
        }

        public class QueryArgProfileConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryArgProfiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-queryargprofileconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-queryargprofileconfig-queryargprofiles
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryArgProfile
            /// </summary>
            public List<Humidifier.CloudFront.FieldLevelEncryptionConfigTypes.QueryArgProfile> QueryArgProfiles { get; set; }
            /// <summary>
            /// ForwardWhenQueryArgProfileIsUnknown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionconfig-queryargprofileconfig.html#cfn-cloudfront-fieldlevelencryptionconfig-queryargprofileconfig-forwardwhenqueryargprofileisunknown
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ForwardWhenQueryArgProfileIsUnknown { get; set; }
        }
    }
}