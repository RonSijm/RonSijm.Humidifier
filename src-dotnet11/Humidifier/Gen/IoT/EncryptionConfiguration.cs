namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using EncryptionConfigurationTypes;

    public class EncryptionConfiguration : Humidifier.Base.BaseResource, IHaveEncryptionType, IHaveKmsKeyArn, IHaveKmsAccessRoleArn
    {
        public class Attributes
        {
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string AccountId =  "AccountId" ;
            public static string ConfigurationDetails =  "ConfigurationDetails" ;
        }

        public override string AWSTypeName { get => AWS.IoT.EncryptionConfiguration; }

        /// <summary>
        /// EncryptionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-encryptionconfiguration.html#cfn-iot-encryptionconfiguration-encryptiontype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EncryptionType { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-encryptionconfiguration.html#cfn-iot-encryptionconfiguration-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// KmsAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-encryptionconfiguration.html#cfn-iot-encryptionconfiguration-kmsaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsAccessRoleArn { get; set; }
    }

    namespace EncryptionConfigurationTypes
    {
        public class ConfigurationDetails : Humidifier.Base.BaseSubResource, IHaveConfigurationStatus, IHaveErrorCode, IHaveErrorMessage
        {
            /// <summary>
            /// ConfigurationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-encryptionconfiguration-configurationdetails.html#cfn-iot-encryptionconfiguration-configurationdetails-configurationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationStatus { get; set; }
            /// <summary>
            /// ErrorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-encryptionconfiguration-configurationdetails.html#cfn-iot-encryptionconfiguration-configurationdetails-errorcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorCode { get; set; }
            /// <summary>
            /// ErrorMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-encryptionconfiguration-configurationdetails.html#cfn-iot-encryptionconfiguration-configurationdetails-errormessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorMessage { get; set; }
        }
    }
}