namespace Humidifier.B2BI
{
    using global::System.Collections.Generic;

    public class Profile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLogging, IHaveEmail, IHaveBusinessName, IHavePhone, IHaveName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string ProfileId =  "ProfileId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LogGroupName =  "LogGroupName" ;
            public static string ProfileArn =  "ProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.B2BI.Profile; }

        /// <summary>
        /// Logging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-profile.html#cfn-b2bi-profile-logging
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Logging { get; set; }
        /// <summary>
        /// Email
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-profile.html#cfn-b2bi-profile-email
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Email { get; set; }

        /// <summary>
        /// BusinessName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-profile.html#cfn-b2bi-profile-businessname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BusinessName { get; set; }

        /// <summary>
        /// Phone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-profile.html#cfn-b2bi-profile-phone
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Phone { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-profile.html#cfn-b2bi-profile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}