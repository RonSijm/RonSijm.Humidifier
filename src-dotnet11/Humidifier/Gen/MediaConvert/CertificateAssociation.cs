namespace Humidifier.MediaConvert
{
    using global::System.Collections.Generic;

    public class CertificateAssociation : Humidifier.Base.BaseResource, IHaveArn
    {
        public override string AWSTypeName { get => AWS.MediaConvert.CertificateAssociation; }

        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-certificateassociation.html#cfn-mediaconvert-certificateassociation-arn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Arn { get; set; }
    }
}