namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;

    public class Profile : Humidifier.Base.BaseResource, IHaveTags, IHaveAs2Id, IHaveProfileType, IHaveStringListOfCertificateIds
    {
        public class Attributes
        {
            public static string ProfileId =  "ProfileId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Profile; }

        /// <summary>
        /// As2Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-profile.html#cfn-transfer-profile-as2id
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? As2Id { get; set; }

        /// <summary>
        /// ProfileType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-profile.html#cfn-transfer-profile-profiletype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileType { get; set; }
        /// <summary>
        /// CertificateIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-profile.html#cfn-transfer-profile-certificateids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CertificateIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-profile.html#cfn-transfer-profile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}