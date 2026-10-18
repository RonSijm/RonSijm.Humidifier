namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using DataCatalogEncryptionSettingsTypes;

    public class DataCatalogEncryptionSettings : Humidifier.Base.BaseResource, IHaveGlueDataCatalogEncryptionSettingsTypesDataCatalogEncryptionSettingsDataCatalogEncryptionSettings_, IHaveCatalogId
    {
        public override string AWSTypeName { get => AWS.Glue.DataCatalogEncryptionSettings; }

        /// <summary>
        /// DataCatalogEncryptionSettings_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataCatalogEncryptionSettings
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings, BaseFunction>? DataCatalogEncryptionSettings_ { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CatalogId { get; set; }
    }

    namespace DataCatalogEncryptionSettingsTypes
    {
        public class ConnectionPasswordEncryption : Humidifier.Base.BaseSubResource, IHaveReturnConnectionPasswordEncrypted_Boolean, IHaveKmsKeyId
        {
            /// <summary>
            /// ReturnConnectionPasswordEncrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-returnconnectionpasswordencrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReturnConnectionPasswordEncrypted { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class DataCatalogEncryptionSettings : Humidifier.Base.BaseSubResource, IHaveGlueDataCatalogEncryptionSettingsTypesConnectionPasswordEncryptionConnectionPasswordEncryption, IHaveGlueDataCatalogEncryptionSettingsTypesEncryptionAtRestEncryptionAtRest
        {
            /// <summary>
            /// ConnectionPasswordEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-connectionpasswordencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionPasswordEncryption
            /// </summary>
            public Union<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption, BaseFunction>? ConnectionPasswordEncryption { get; set; }
            /// <summary>
            /// EncryptionAtRest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-encryptionatrest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionAtRest
            /// </summary>
            public Union<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest, BaseFunction>? EncryptionAtRest { get; set; }
        }

        public class EncryptionAtRest : Humidifier.Base.BaseSubResource, IHaveCatalogEncryptionMode, IHaveCatalogEncryptionServiceRole, IHaveSseAwsKmsKeyId
        {
            /// <summary>
            /// CatalogEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-catalogencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogEncryptionMode { get; set; }
            /// <summary>
            /// CatalogEncryptionServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-catalogencryptionservicerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogEncryptionServiceRole { get; set; }
            /// <summary>
            /// SseAwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-sseawskmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SseAwsKmsKeyId { get; set; }
        }
    }
}