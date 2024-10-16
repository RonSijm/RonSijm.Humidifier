namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using DataCatalogEncryptionSettingsTypes;

    public class DataCatalogEncryptionSettings : Humidifier.Base.BaseResource, IHaveCatalogId
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
        public Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings DataCatalogEncryptionSettings_ { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CatalogId { get; set; }
    }

    namespace DataCatalogEncryptionSettingsTypes
    {
        public class ConnectionPasswordEncryption : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// ReturnConnectionPasswordEncrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-returnconnectionpasswordencrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReturnConnectionPasswordEncrypted { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
        }

        public class DataCatalogEncryptionSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectionPasswordEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-connectionpasswordencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionPasswordEncryption
            /// </summary>
            public Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption ConnectionPasswordEncryption { get; set; }
            /// <summary>
            /// EncryptionAtRest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-encryptionatrest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionAtRest
            /// </summary>
            public Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest EncryptionAtRest { get; set; }
        }

        public class EncryptionAtRest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CatalogEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-catalogencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogEncryptionMode { get; set; }
            /// <summary>
            /// CatalogEncryptionServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-catalogencryptionservicerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogEncryptionServiceRole { get; set; }
            /// <summary>
            /// SseAwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-sseawskmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SseAwsKmsKeyId { get; set; }
        }
    }
}