namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using CACertificateTypes;

    public class CACertificate : Humidifier.Base.BaseResource, IHaveTags, IHaveStatus, IHaveCACertificatePem, IHaveCertificateMode, IHaveAutoRegistrationStatus, IHaveRemoveAutoRegistration_Boolean, IHaveIoTCACertificateTypesRegistrationConfigRegistrationConfig, IHaveVerificationCertificatePem
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.CACertificate; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// CACertificatePem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-cacertificatepem
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CACertificatePem { get; set; }
        /// <summary>
        /// CertificateMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-certificatemode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateMode { get; set; }
        /// <summary>
        /// AutoRegistrationStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-autoregistrationstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoRegistrationStatus { get; set; }
        /// <summary>
        /// RemoveAutoRegistration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-removeautoregistration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RemoveAutoRegistration { get; set; }
        /// <summary>
        /// RegistrationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-registrationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RegistrationConfig
        /// </summary>
        public Union<Humidifier.IoT.CACertificateTypes.RegistrationConfig, BaseFunction>? RegistrationConfig { get; set; }
        /// <summary>
        /// VerificationCertificatePem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-verificationcertificatepem
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VerificationCertificatePem { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-cacertificate.html#cfn-iot-cacertificate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CACertificateTypes
    {
        public class RegistrationConfig : Humidifier.Base.BaseSubResource, IHaveTemplateName, IHaveTemplateBody, IHaveRoleArn
        {
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-cacertificate-registrationconfig.html#cfn-iot-cacertificate-registrationconfig-templatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateName { get; set; }
            /// <summary>
            /// TemplateBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-cacertificate-registrationconfig.html#cfn-iot-cacertificate-registrationconfig-templatebody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateBody { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-cacertificate-registrationconfig.html#cfn-iot-cacertificate-registrationconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}