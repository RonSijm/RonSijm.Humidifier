namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using SecurityConfigurationTypes;

    public class SecurityConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGlueSecurityConfigurationTypesEncryptionConfigurationEncryptionConfiguration, IHaveName
    {
        public override string AWSTypeName { get => AWS.Glue.SecurityConfiguration; }

        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-securityconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SecurityConfigurationTypes
    {
        public class CloudWatchEncryption : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveCloudWatchEncryptionMode
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html#cfn-glue-securityconfiguration-cloudwatchencryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// CloudWatchEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html#cfn-glue-securityconfiguration-cloudwatchencryption-cloudwatchencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchEncryptionMode { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfGlueSecurityConfigurationTypesS3EncryptionS3Encryptions, IHaveGlueSecurityConfigurationTypesCloudWatchEncryptionCloudWatchEncryption, IHaveGlueSecurityConfigurationTypesJobBookmarksEncryptionJobBookmarksEncryption
        {
            /// <summary>
            /// S3Encryptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration-s3encryptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: S3Encryption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.SecurityConfigurationTypes.S3Encryption>, IReadOnlyList<Union<Humidifier.Glue.SecurityConfigurationTypes.S3Encryption, BaseFunction>>, BaseFunction>? S3Encryptions { get; set; }
            /// <summary>
            /// CloudWatchEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration-cloudwatchencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchEncryption
            /// </summary>
            public Union<Humidifier.Glue.SecurityConfigurationTypes.CloudWatchEncryption, BaseFunction>? CloudWatchEncryption { get; set; }
            /// <summary>
            /// JobBookmarksEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration-jobbookmarksencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobBookmarksEncryption
            /// </summary>
            public Union<Humidifier.Glue.SecurityConfigurationTypes.JobBookmarksEncryption, BaseFunction>? JobBookmarksEncryption { get; set; }
        }

        public class JobBookmarksEncryption : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveJobBookmarksEncryptionMode
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-jobbookmarksencryption.html#cfn-glue-securityconfiguration-jobbookmarksencryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// JobBookmarksEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-jobbookmarksencryption.html#cfn-glue-securityconfiguration-jobbookmarksencryption-jobbookmarksencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobBookmarksEncryptionMode { get; set; }
        }

        public class S3Encryption : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveS3EncryptionMode
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-s3encryption.html#cfn-glue-securityconfiguration-s3encryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// S3EncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-s3encryption.html#cfn-glue-securityconfiguration-s3encryption-s3encryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3EncryptionMode { get; set; }
        }
    }
}