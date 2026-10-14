namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using EncryptionConfigurationTypes;

    public class EncryptionConfiguration : Humidifier.Base.BaseResource, IHaveKmsKeyArn, IHaveEncryptionType
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
        public dynamic EncryptionType { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-encryptionconfiguration.html#cfn-iot-encryptionconfiguration-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        /// <summary>
        /// KmsAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-encryptionconfiguration.html#cfn-iot-encryptionconfiguration-kmsaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsAccessRoleArn { get; set; }
    }

    namespace EncryptionConfigurationTypes
    {
        public class ConfigurationDetails : Humidifier.Base.BaseSubResource, IHaveErrorCode, IHaveErrorMessage
        {
            /// <summary>
            /// ConfigurationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-encryptionconfiguration-configurationdetails.html#cfn-iot-encryptionconfiguration-configurationdetails-configurationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationStatus { get; set; }
            /// <summary>
            /// ErrorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-encryptionconfiguration-configurationdetails.html#cfn-iot-encryptionconfiguration-configurationdetails-errorcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorCode { get; set; }
            /// <summary>
            /// ErrorMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-encryptionconfiguration-configurationdetails.html#cfn-iot-encryptionconfiguration-configurationdetails-errormessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorMessage { get; set; }
        }
    }
}