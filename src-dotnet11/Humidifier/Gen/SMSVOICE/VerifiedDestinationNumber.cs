namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class VerifiedDestinationNumber : Humidifier.Base.BaseResource, IHaveTags, IHaveDestinationPhoneNumber
    {
        public class Attributes
        {
            public static string VerifiedDestinationNumberId =  "VerifiedDestinationNumberId" ;
            public static string Status =  "Status" ;
            public static string VerifiedDestinationNumberArn =  "VerifiedDestinationNumberArn" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.VerifiedDestinationNumber; }

        /// <summary>
        /// DestinationPhoneNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-verifieddestinationnumber.html#cfn-smsvoice-verifieddestinationnumber-destinationphonenumber
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DestinationPhoneNumber { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-verifieddestinationnumber.html#cfn-smsvoice-verifieddestinationnumber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}