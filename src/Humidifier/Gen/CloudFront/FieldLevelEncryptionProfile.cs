namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using FieldLevelEncryptionProfileTypes;

    public class FieldLevelEncryptionProfile : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.FieldLevelEncryptionProfile; }

        /// <summary>
        /// FieldLevelEncryptionProfileConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-fieldlevelencryptionprofile.html#cfn-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FieldLevelEncryptionProfileConfig
        /// </summary>
        [Required]
        public Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig FieldLevelEncryptionProfileConfig { get; set; }
    }

    namespace FieldLevelEncryptionProfileTypes
    {
        public class EncryptionEntity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProviderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-encryptionentity.html#cfn-cloudfront-fieldlevelencryptionprofile-encryptionentity-providerid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderId { get; set; }
            /// <summary>
            /// PublicKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-encryptionentity.html#cfn-cloudfront-fieldlevelencryptionprofile-encryptionentity-publickeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PublicKeyId { get; set; }
            /// <summary>
            /// FieldPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-encryptionentity.html#cfn-cloudfront-fieldlevelencryptionprofile-encryptionentity-fieldpatterns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FieldPatterns { get; set; }
        }

        public class FieldLevelEncryptionProfileConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveComment
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig.html#cfn-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
            /// <summary>
            /// CallerReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig.html#cfn-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig-callerreference
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CallerReference { get; set; }
            /// <summary>
            /// EncryptionEntities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig.html#cfn-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig-encryptionentities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EncryptionEntity
            /// </summary>
            public List<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.EncryptionEntity> EncryptionEntities { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig.html#cfn-cloudfront-fieldlevelencryptionprofile-fieldlevelencryptionprofileconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}