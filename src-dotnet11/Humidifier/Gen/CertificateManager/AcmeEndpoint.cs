namespace Humidifier.CertificateManager
{
    using global::System.Collections.Generic;
    using AcmeEndpointTypes;

    public class AcmeEndpoint : Humidifier.Base.BaseResource, IHaveTagListOfCertificateTags, IHaveAuthorizationBehavior, IHaveCertificateManagerAcmeEndpointTypesCertificateAuthorityCertificateAuthority, IHaveListOfCertificateManagerAcmeEndpointTypesTagsItemsTags, IHaveContact
    {
        public class Attributes
        {
            public static string EndpointUrl =  "EndpointUrl" ;
            public static string AcmeEndpointArn =  "AcmeEndpointArn" ;
        }

        public override string AWSTypeName { get => AWS.CertificateManager.AcmeEndpoint; }
        /// <summary>
        /// CertificateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeendpoint.html#cfn-certificatemanager-acmeendpoint-certificatetags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? CertificateTags { get; set; }

        /// <summary>
        /// AuthorizationBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeendpoint.html#cfn-certificatemanager-acmeendpoint-authorizationbehavior
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthorizationBehavior { get; set; }

        /// <summary>
        /// CertificateAuthority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeendpoint.html#cfn-certificatemanager-acmeendpoint-certificateauthority
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CertificateAuthority
        /// </summary>
        [Required]
        public Union<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority, BaseFunction>? CertificateAuthority { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeendpoint.html#cfn-certificatemanager-acmeendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems>, IReadOnlyList<Union<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Contact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmeendpoint.html#cfn-certificatemanager-acmeendpoint-contact
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Contact { get; set; }
    }

    namespace AcmeEndpointTypes
    {
        public class CertificateAuthority : Humidifier.Base.BaseSubResource, IHaveCertificateManagerAcmeEndpointTypesPublicCertificateAuthorityPublicCertificateAuthority
        {
            /// <summary>
            /// PublicCertificateAuthority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeendpoint-certificateauthority.html#cfn-certificatemanager-acmeendpoint-certificateauthority-publiccertificateauthority
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PublicCertificateAuthority
            /// </summary>
            public Union<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority, BaseFunction>? PublicCertificateAuthority { get; set; }
        }

        public class PublicCertificateAuthority : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedKeyAlgorithms
        {
            /// <summary>
            /// AllowedKeyAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeendpoint-publiccertificateauthority.html#cfn-certificatemanager-acmeendpoint-publiccertificateauthority-allowedkeyalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedKeyAlgorithms { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeendpoint-tagsitems.html#cfn-certificatemanager-acmeendpoint-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmeendpoint-tagsitems.html#cfn-certificatemanager-acmeendpoint-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}