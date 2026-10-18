namespace Humidifier.IAM
{
    using global::System.Collections.Generic;
    using SAMLProviderTypes;

    public class SAMLProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAddPrivateKey, IHaveRemovePrivateKey, IHaveAssertionEncryptionMode, IHaveSamlMetadataDocument, IHaveListOfIAMSAMLProviderTypesSAMLPrivateKeyPrivateKeyList, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string SamlProviderUUID =  "SamlProviderUUID" ;
        }

        public override string AWSTypeName { get => AWS.IAM.SAMLProvider; }
        /// <summary>
        /// AddPrivateKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html#cfn-iam-samlprovider-addprivatekey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AddPrivateKey { get; set; }
        /// <summary>
        /// RemovePrivateKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html#cfn-iam-samlprovider-removeprivatekey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RemovePrivateKey { get; set; }
        /// <summary>
        /// AssertionEncryptionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html#cfn-iam-samlprovider-assertionencryptionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssertionEncryptionMode { get; set; }
        /// <summary>
        /// SamlMetadataDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html#cfn-iam-samlprovider-samlmetadatadocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SamlMetadataDocument { get; set; }
        /// <summary>
        /// PrivateKeyList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html#cfn-iam-samlprovider-privatekeylist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SAMLPrivateKey
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey>, IReadOnlyList<Union<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey, BaseFunction>>, BaseFunction>? PrivateKeyList { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html#cfn-iam-samlprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SAMLProviderTypes
    {
        public class SAMLPrivateKey : Humidifier.Base.BaseSubResource, IHaveKeyId, IHaveTimestamp
        {
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-samlprovider-samlprivatekey.html#cfn-iam-samlprovider-samlprivatekey-keyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyId { get; set; }
            /// <summary>
            /// Timestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-samlprovider-samlprivatekey.html#cfn-iam-samlprovider-samlprivatekey-timestamp
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timestamp { get; set; }
        }
    }
}