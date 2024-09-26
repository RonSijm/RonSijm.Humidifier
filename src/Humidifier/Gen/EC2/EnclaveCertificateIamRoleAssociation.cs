namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class EnclaveCertificateIamRoleAssociation : Humidifier.Base.BaseResource, IHaveRoleArn, IHaveCertificateArn
    {
        public class Attributes
        {
            public static string EncryptionKmsKeyId =  "EncryptionKmsKeyId" ;
            public static string CertificateS3BucketName =  "CertificateS3BucketName" ;
            public static string CertificateS3ObjectKey =  "CertificateS3ObjectKey" ;
        }

        public override string AWSTypeName { get => AWS.EC2.EnclaveCertificateIamRoleAssociation; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-enclavecertificateiamroleassociation.html#cfn-ec2-enclavecertificateiamroleassociation-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }

        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-enclavecertificateiamroleassociation.html#cfn-ec2-enclavecertificateiamroleassociation-certificatearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CertificateArn { get; set; }
    }
}