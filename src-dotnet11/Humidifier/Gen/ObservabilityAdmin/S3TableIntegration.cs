namespace Humidifier.ObservabilityAdmin
{
    using global::System.Collections.Generic;
    using S3TableIntegrationTypes;

    public class S3TableIntegration : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfObservabilityAdminS3TableIntegrationTypesLogSourceLogSources, IHaveObservabilityAdminS3TableIntegrationTypesEncryptionConfigEncryption, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ObservabilityAdmin.S3TableIntegration; }
        /// <summary>
        /// LogSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-s3tableintegration.html#cfn-observabilityadmin-s3tableintegration-logsources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogSource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource, BaseFunction>>, BaseFunction>? LogSources { get; set; }

        /// <summary>
        /// Encryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-s3tableintegration.html#cfn-observabilityadmin-s3tableintegration-encryption
        /// Required: True
        /// UpdateType: Immutable
        /// Type: EncryptionConfig
        /// </summary>
        [Required]
        public Union<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig, BaseFunction>? Encryption { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-s3tableintegration.html#cfn-observabilityadmin-s3tableintegration-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-s3tableintegration.html#cfn-observabilityadmin-s3tableintegration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace S3TableIntegrationTypes
    {
        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveSseAlgorithm
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-s3tableintegration-encryptionconfig.html#cfn-observabilityadmin-s3tableintegration-encryptionconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// SseAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-s3tableintegration-encryptionconfig.html#cfn-observabilityadmin-s3tableintegration-encryptionconfig-ssealgorithm
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SseAlgorithm { get; set; }
        }

        public class LogSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-s3tableintegration-logsource.html#cfn-observabilityadmin-s3tableintegration-logsource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-s3tableintegration-logsource.html#cfn-observabilityadmin-s3tableintegration-logsource-identifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-s3tableintegration-logsource.html#cfn-observabilityadmin-s3tableintegration-logsource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}