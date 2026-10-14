namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class RegistrationAttachment : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string RegistrationAttachmentArn =  "RegistrationAttachmentArn" ;
            public static string RegistrationAttachmentId =  "RegistrationAttachmentId" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string AttachmentStatus =  "AttachmentStatus" ;
            public static string UploadedAttachmentUrl =  "UploadedAttachmentUrl" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.RegistrationAttachment; }
        /// <summary>
        /// AttachmentUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registrationattachment.html#cfn-smsvoice-registrationattachment-attachmenturl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AttachmentUrl { get; set; }
        /// <summary>
        /// AttachmentBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registrationattachment.html#cfn-smsvoice-registrationattachment-attachmentbody
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AttachmentBody { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registrationattachment.html#cfn-smsvoice-registrationattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}