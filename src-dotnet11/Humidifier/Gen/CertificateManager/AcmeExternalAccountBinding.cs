namespace Humidifier.CertificateManager
{
    using global::System.Collections.Generic;
    using AcmeExternalAccountBindingTypes;

    public class AcmeExternalAccountBinding : Humidifier.Base.BaseResource, IHaveCertificateManagerAcmeExternalAccountBindingTypesExpirationExpiration, IHaveRoleArn, IHaveListOfCertificateManagerAcmeExternalAccountBindingTypesTagsItemsTags, IHaveAcmeEndpointArn
    {
        public class Attributes
        {
            public static string AcmeExternalAccountBindingArn =  "AcmeExternalAccountBindingArn" ;
        }

        public override string AWSTypeName { get => AWS.CertificateManager.AcmeExternalAccountBinding; }
        /// <summary>
        /// Expiration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeexternalaccountbinding.html#cfn-certificatemanager-acmeexternalaccountbinding-expiration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Expiration
        /// </summary>
        public Union<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.Expiration, BaseFunction>? Expiration { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeexternalaccountbinding.html#cfn-certificatemanager-acmeexternalaccountbinding-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeexternalaccountbinding.html#cfn-certificatemanager-acmeexternalaccountbinding-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems>, IReadOnlyList<Union<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AcmeEndpointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeexternalaccountbinding.html#cfn-certificatemanager-acmeexternalaccountbinding-acmeendpointarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AcmeEndpointArn { get; set; }
    }

    namespace AcmeExternalAccountBindingTypes
    {
        public class Expiration : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeexternalaccountbinding-expiration.html#cfn-certificatemanager-acmeexternalaccountbinding-expiration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeexternalaccountbinding-expiration.html#cfn-certificatemanager-acmeexternalaccountbinding-expiration-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeexternalaccountbinding-tagsitems.html#cfn-certificatemanager-acmeexternalaccountbinding-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeexternalaccountbinding-tagsitems.html#cfn-certificatemanager-acmeexternalaccountbinding-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}