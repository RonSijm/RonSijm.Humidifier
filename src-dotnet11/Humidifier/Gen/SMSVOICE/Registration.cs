namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class Registration : Humidifier.Base.BaseResource, IHaveTags, IHaveRegistrationType
    {
        public class Attributes
        {
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string RegistrationStatus =  "RegistrationStatus" ;
            public static string RegistrationId =  "RegistrationId" ;
            public static string RegistrationArn =  "RegistrationArn" ;
            public static string CurrentVersionNumber =  "CurrentVersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.Registration; }

        /// <summary>
        /// RegistrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registration.html#cfn-smsvoice-registration-registrationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RegistrationType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registration.html#cfn-smsvoice-registration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}