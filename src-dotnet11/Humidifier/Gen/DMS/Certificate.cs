namespace Humidifier.DMS
{
    using global::System.Collections.Generic;

    public class Certificate : Humidifier.Base.BaseResource, IHaveCertificateIdentifier, IHaveCertificatePem, IHaveCertificateWallet
    {
        public class Attributes
        {
            public static string CertificateArn =  "CertificateArn" ;
        }

        public override string AWSTypeName { get => AWS.DMS.Certificate; }
        /// <summary>
        /// CertificateIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html#cfn-dms-certificate-certificateidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateIdentifier { get; set; }
        /// <summary>
        /// CertificatePem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html#cfn-dms-certificate-certificatepem
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificatePem { get; set; }
        /// <summary>
        /// CertificateWallet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html#cfn-dms-certificate-certificatewallet
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateWallet { get; set; }
    }
}