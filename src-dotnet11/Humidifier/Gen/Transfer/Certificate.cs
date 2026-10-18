namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;

    public class Certificate : Humidifier.Base.BaseResource, IHaveTags, IHaveInactiveDate, IHaveUsage, IHavePrivateKey, IHaveDescription, IHaveCertificateChain, IHaveActiveDate, IHaveCertificate_
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string Serial =  "Serial" ;
            public static string CertificateId =  "CertificateId" ;
            public static string NotBeforeDate =  "NotBeforeDate" ;
            public static string NotAfterDate =  "NotAfterDate" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Certificate; }
        /// <summary>
        /// InactiveDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-inactivedate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InactiveDate { get; set; }

        /// <summary>
        /// Usage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-usage
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Usage { get; set; }
        /// <summary>
        /// PrivateKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-privatekey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateKey { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CertificateChain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-certificatechain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateChain { get; set; }
        /// <summary>
        /// ActiveDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-activedate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ActiveDate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Certificate_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-certificate.html#cfn-transfer-certificate-certificate
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Certificate_ { get; set; }
    }
}