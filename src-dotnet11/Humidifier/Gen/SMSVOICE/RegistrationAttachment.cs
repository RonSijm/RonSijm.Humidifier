namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class RegistrationAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveAttachmentUrl, IHaveAttachmentBody
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
        public Union<string, BaseFunction>? AttachmentUrl { get; set; }
        /// <summary>
        /// AttachmentBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registrationattachment.html#cfn-smsvoice-registrationattachment-attachmentbody
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AttachmentBody { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-registrationattachment.html#cfn-smsvoice-registrationattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}