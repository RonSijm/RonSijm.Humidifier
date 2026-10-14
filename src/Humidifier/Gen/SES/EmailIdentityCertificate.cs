namespace Humidifier.SES
{
    using global::System.Collections.Generic;

    public class EmailIdentityCertificate : Humidifier.Base.BaseResource, IHaveCertificateArn, IHaveFromAddress
    {
        public override string AWSTypeName { get => AWS.SES.EmailIdentityCertificate; }

        /// <summary>
        /// FromAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentitycertificate.html#cfn-ses-emailidentitycertificate-fromaddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FromAddress { get; set; }

        /// <summary>
        /// EmailIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentitycertificate.html#cfn-ses-emailidentitycertificate-emailidentity
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EmailIdentity { get; set; }

        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentitycertificate.html#cfn-ses-emailidentitycertificate-certificatearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateArn { get; set; }
    }
}