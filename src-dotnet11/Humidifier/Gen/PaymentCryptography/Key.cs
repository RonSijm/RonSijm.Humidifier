namespace Humidifier.PaymentCryptography
{
    using global::System.Collections.Generic;
    using KeyTypes;

    public class Key : Humidifier.Base.BaseResource, IHaveTags, IHaveDeriveKeyUsage, IHavePolicy, IHaveExportable_Boolean, IHaveStringListOfReplicationRegions, IHavePaymentCryptographyKeyTypesKeyAttributesKeyAttributes, IHaveEnabled_Boolean, IHaveKeyCheckValueAlgorithm
    {
        public class Attributes
        {
            public static string KeyIdentifier =  "KeyIdentifier" ;
            public static string ReplicationStatus =  "ReplicationStatus" ;
            public static string KeyState =  "KeyState" ;
            public static string KeyOrigin =  "KeyOrigin" ;
        }

        public override string AWSTypeName { get => AWS.PaymentCryptography.Key; }
        /// <summary>
        /// DeriveKeyUsage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-derivekeyusage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeriveKeyUsage { get; set; }
        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-policy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Policy { get; set; }

        /// <summary>
        /// Exportable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-exportable
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? Exportable { get; set; }
        /// <summary>
        /// ReplicationRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-replicationregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReplicationRegions { get; set; }

        /// <summary>
        /// KeyAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-keyattributes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: KeyAttributes
        /// </summary>
        [Required]
        public Union<Humidifier.PaymentCryptography.KeyTypes.KeyAttributes, BaseFunction>? KeyAttributes { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// KeyCheckValueAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-keycheckvaluealgorithm
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KeyCheckValueAlgorithm { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-key.html#cfn-paymentcryptography-key-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace KeyTypes
    {
        public class KeyAttributes : Humidifier.Base.BaseSubResource, IHaveKeyClass, IHaveKeyUsage, IHavePaymentCryptographyKeyTypesKeyModesOfUseKeyModesOfUse, IHaveKeyAlgorithm
        {
            /// <summary>
            /// KeyClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keyattributes.html#cfn-paymentcryptography-key-keyattributes-keyclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyClass { get; set; }
            /// <summary>
            /// KeyUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keyattributes.html#cfn-paymentcryptography-key-keyattributes-keyusage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyUsage { get; set; }
            /// <summary>
            /// KeyModesOfUse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keyattributes.html#cfn-paymentcryptography-key-keyattributes-keymodesofuse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KeyModesOfUse
            /// </summary>
            public Union<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse, BaseFunction>? KeyModesOfUse { get; set; }
            /// <summary>
            /// KeyAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keyattributes.html#cfn-paymentcryptography-key-keyattributes-keyalgorithm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyAlgorithm { get; set; }
        }

        public class KeyModesOfUse : Humidifier.Base.BaseSubResource, IHaveUnwrap_Boolean, IHaveWrap_Boolean, IHaveDecrypt_Boolean, IHaveNoRestrictions_Boolean, IHaveGenerate_Boolean, IHaveSign_Boolean, IHaveVerify_Boolean, IHaveDeriveKey_Boolean, IHaveEncrypt_Boolean
        {
            /// <summary>
            /// Unwrap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-unwrap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Unwrap { get; set; }
            /// <summary>
            /// Wrap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-wrap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Wrap { get; set; }
            /// <summary>
            /// Decrypt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-decrypt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Decrypt { get; set; }
            /// <summary>
            /// NoRestrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-norestrictions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoRestrictions { get; set; }
            /// <summary>
            /// Generate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-generate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Generate { get; set; }
            /// <summary>
            /// Sign
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-sign
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Sign { get; set; }
            /// <summary>
            /// Verify
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-verify
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Verify { get; set; }
            /// <summary>
            /// DeriveKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-derivekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeriveKey { get; set; }
            /// <summary>
            /// Encrypt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-keymodesofuse.html#cfn-paymentcryptography-key-keymodesofuse-encrypt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypt { get; set; }
        }

        public class ReplicationStatusType : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveKmsKeyArn, IHaveKmsKeyId, IHaveStatusMessage
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-replicationstatustype.html#cfn-paymentcryptography-key-replicationstatustype-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-replicationstatustype.html#cfn-paymentcryptography-key-replicationstatustype-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-replicationstatustype.html#cfn-paymentcryptography-key-replicationstatustype-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// StatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-paymentcryptography-key-replicationstatustype.html#cfn-paymentcryptography-key-replicationstatustype-statusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusMessage { get; set; }
        }
    }
}