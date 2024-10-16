namespace Humidifier.AppStream
{
    using System.Collections.Generic;
    using DirectoryConfigTypes;

    public class DirectoryConfig : Humidifier.Base.BaseResource, IHaveDirectoryName
    {
        public override string AWSTypeName { get => AWS.AppStream.DirectoryConfig; }

        /// <summary>
        /// OrganizationalUnitDistinguishedNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-organizationalunitdistinguishednames
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic OrganizationalUnitDistinguishedNames { get; set; }

        /// <summary>
        /// ServiceAccountCredentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-serviceaccountcredentials
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ServiceAccountCredentials
        /// </summary>
        [Required]
        public Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials ServiceAccountCredentials { get; set; }
        /// <summary>
        /// CertificateBasedAuthProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-certificatebasedauthproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CertificateBasedAuthProperties
        /// </summary>
        public Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties CertificateBasedAuthProperties { get; set; }

        /// <summary>
        /// DirectoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-directoryname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DirectoryName { get; set; }
    }

    namespace DirectoryConfigTypes
    {
        public class CertificateBasedAuthProperties : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCertificateAuthorityArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-certificatebasedauthproperties.html#cfn-appstream-directoryconfig-certificatebasedauthproperties-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// CertificateAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-certificatebasedauthproperties.html#cfn-appstream-directoryconfig-certificatebasedauthproperties-certificateauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateAuthorityArn { get; set; }
        }

        public class ServiceAccountCredentials : Humidifier.Base.BaseSubResource, IHaveAccountName
        {
            /// <summary>
            /// AccountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-serviceaccountcredentials.html#cfn-appstream-directoryconfig-serviceaccountcredentials-accountname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountName { get; set; }
            /// <summary>
            /// AccountPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-serviceaccountcredentials.html#cfn-appstream-directoryconfig-serviceaccountcredentials-accountpassword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountPassword { get; set; }
        }
    }
}