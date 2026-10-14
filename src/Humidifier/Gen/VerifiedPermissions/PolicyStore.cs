namespace Humidifier.VerifiedPermissions
{
    using global::System.Collections.Generic;
    using PolicyStoreTypes;

    public class PolicyStore : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string EncryptionState =  "EncryptionState" ;
            public static string PolicyStoreId =  "PolicyStoreId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VerifiedPermissions.PolicyStore; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ValidationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-validationsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ValidationSettings
        /// </summary>
        [Required]
        public Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings ValidationSettings { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-schema
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaDefinition
        /// </summary>
        public Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition Schema { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeletionProtection
        /// </summary>
        public Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection DeletionProtection { get; set; }
        /// <summary>
        /// EncryptionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-encryptionsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionSettings
        /// </summary>
        public Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings EncryptionSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace PolicyStoreTypes
    {
        public class DeletionProtection : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-deletionprotection.html#cfn-verifiedpermissions-policystore-deletionprotection-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class EncryptionSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KmsEncryptionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionsettings.html#cfn-verifiedpermissions-policystore-encryptionsettings-kmsencryptionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsEncryptionSettings
            /// </summary>
            public Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings KmsEncryptionSettings { get; set; }
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionsettings.html#cfn-verifiedpermissions-policystore-encryptionsettings-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Default { get; set; }
        }

        public class EncryptionState : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KmsEncryptionState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionstate.html#cfn-verifiedpermissions-policystore-encryptionstate-kmsencryptionstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsEncryptionState
            /// </summary>
            public Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionState KmsEncryptionState { get; set; }
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionstate.html#cfn-verifiedpermissions-policystore-encryptionstate-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Default { get; set; }
        }

        public class KmsEncryptionSettings : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// EncryptionContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionsettings.html#cfn-verifiedpermissions-policystore-kmsencryptionsettings-encryptioncontext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> EncryptionContext { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionsettings.html#cfn-verifiedpermissions-policystore-kmsencryptionsettings-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class KmsEncryptionState : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// EncryptionContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionstate.html#cfn-verifiedpermissions-policystore-kmsencryptionstate-encryptioncontext
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> EncryptionContext { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionstate.html#cfn-verifiedpermissions-policystore-kmsencryptionstate-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class SchemaDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CedarJson
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-schemadefinition.html#cfn-verifiedpermissions-policystore-schemadefinition-cedarjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CedarJson { get; set; }
        }

        public class ValidationSettings : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-validationsettings.html#cfn-verifiedpermissions-policystore-validationsettings-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }
    }
}