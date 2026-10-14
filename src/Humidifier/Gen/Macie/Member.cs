namespace Humidifier.Macie
{
    using global::System.Collections.Generic;

    public class Member : Humidifier.Base.BaseResource, IHaveTags, IHaveAccountId, IHaveEmail
    {
        public class Attributes
        {
            public static string AdministratorAccountId =  "AdministratorAccountId" ;
            public static string Arn =  "Arn" ;
            public static string RelationshipStatus =  "RelationshipStatus" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Macie.Member; }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-member.html#cfn-macie-member-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AccountId { get; set; }
        /// <summary>
        /// Email
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-member.html#cfn-macie-member-email
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Email { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-member.html#cfn-macie-member-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}