namespace Humidifier.VerifiedPermissions
{
    using global::System.Collections.Generic;
    using PolicyStoreTypes;

    public class PolicyStore : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveVerifiedPermissionsPolicyStoreTypesValidationSettingsValidationSettings, IHaveVerifiedPermissionsPolicyStoreTypesSchemaDefinitionSchema, IHaveVerifiedPermissionsPolicyStoreTypesDeletionProtectionDeletionProtection, IHaveVerifiedPermissionsPolicyStoreTypesEncryptionSettingsEncryptionSettings
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ValidationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-validationsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ValidationSettings
        /// </summary>
        [Required]
        public Union<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings, BaseFunction>? ValidationSettings { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-schema
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaDefinition
        /// </summary>
        public Union<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition, BaseFunction>? Schema { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeletionProtection
        /// </summary>
        public Union<Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// EncryptionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-encryptionsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionSettings
        /// </summary>
        public Union<Humidifier.VerifiedPermissions.PolicyStoreTypes.EncryptionSettings, BaseFunction>? EncryptionSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystore.html#cfn-verifiedpermissions-policystore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class EncryptionSettings : Humidifier.Base.BaseSubResource, IHaveVerifiedPermissionsPolicyStoreTypesKmsEncryptionSettingsKmsEncryptionSettings, IHaveDefault_Json
        {
            /// <summary>
            /// KmsEncryptionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionsettings.html#cfn-verifiedpermissions-policystore-encryptionsettings-kmsencryptionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsEncryptionSettings
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings, BaseFunction>? KmsEncryptionSettings { get; set; }
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionsettings.html#cfn-verifiedpermissions-policystore-encryptionsettings-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Default { get; set; }
        }

        public class EncryptionState : Humidifier.Base.BaseSubResource, IHaveVerifiedPermissionsPolicyStoreTypesKmsEncryptionStateKmsEncryptionState, IHaveDefault_Json
        {
            /// <summary>
            /// KmsEncryptionState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionstate.html#cfn-verifiedpermissions-policystore-encryptionstate-kmsencryptionstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsEncryptionState
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionState, BaseFunction>? KmsEncryptionState { get; set; }
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-encryptionstate.html#cfn-verifiedpermissions-policystore-encryptionstate-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Default { get; set; }
        }

        public class KmsEncryptionSettings : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfEncryptionContext, IHaveKey
        {
            /// <summary>
            /// EncryptionContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionsettings.html#cfn-verifiedpermissions-policystore-kmsencryptionsettings-encryptioncontext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EncryptionContext { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionsettings.html#cfn-verifiedpermissions-policystore-kmsencryptionsettings-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class KmsEncryptionState : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfEncryptionContext, IHaveKey
        {
            /// <summary>
            /// EncryptionContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionstate.html#cfn-verifiedpermissions-policystore-kmsencryptionstate-encryptioncontext
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EncryptionContext { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-kmsencryptionstate.html#cfn-verifiedpermissions-policystore-kmsencryptionstate-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SchemaDefinition : Humidifier.Base.BaseSubResource, IHaveCedarJson
        {
            /// <summary>
            /// CedarJson
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policystore-schemadefinition.html#cfn-verifiedpermissions-policystore-schemadefinition-cedarjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CedarJson { get; set; }
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
            public Union<string, BaseFunction>? Mode { get; set; }
        }
    }
}