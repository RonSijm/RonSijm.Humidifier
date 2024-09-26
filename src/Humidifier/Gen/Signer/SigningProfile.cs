namespace Humidifier.Signer
{
    using System.Collections.Generic;
    using SigningProfileTypes;

    public class SigningProfile : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ProfileVersionArn =  "ProfileVersionArn" ;
            public static string ProfileName =  "ProfileName" ;
            public static string Arn =  "Arn" ;
            public static string ProfileVersion =  "ProfileVersion" ;
        }

        public override string AWSTypeName { get => AWS.Signer.SigningProfile; }
        /// <summary>
        /// SignatureValidityPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-signer-signingprofile.html#cfn-signer-signingprofile-signaturevalidityperiod
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SignatureValidityPeriod
        /// </summary>
        public Humidifier.Signer.SigningProfileTypes.SignatureValidityPeriod SignatureValidityPeriod { get; set; }

        /// <summary>
        /// PlatformId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-signer-signingprofile.html#cfn-signer-signingprofile-platformid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PlatformId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-signer-signingprofile.html#cfn-signer-signingprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace SigningProfileTypes
    {
        public class SignatureValidityPeriod : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingprofile-signaturevalidityperiod.html#cfn-signer-signingprofile-signaturevalidityperiod-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingprofile-signaturevalidityperiod.html#cfn-signer-signingprofile-signaturevalidityperiod-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}