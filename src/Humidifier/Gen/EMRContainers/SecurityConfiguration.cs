namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using SecurityConfigurationTypes;

    public class SecurityConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EMRContainers.SecurityConfiguration; }
        /// <summary>
        /// ContainerProvider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-securityconfiguration.html#cfn-emrcontainers-securityconfiguration-containerprovider
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContainerProvider
        /// </summary>
        public Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider ContainerProvider { get; set; }

        /// <summary>
        /// SecurityConfigurationData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-securityconfiguration.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SecurityConfigurationData
        /// </summary>
        [Required]
        public Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData SecurityConfigurationData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-securityconfiguration.html#cfn-emrcontainers-securityconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SecurityConfigurationTypes
    {
        public class AtRestEncryptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LocalDiskEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-atrestencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-atrestencryptionconfiguration-localdiskencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalDiskEncryptionConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration LocalDiskEncryptionConfiguration { get; set; }
            /// <summary>
            /// S3EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-atrestencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-atrestencryptionconfiguration-s3encryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3EncryptionConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration S3EncryptionConfiguration { get; set; }
        }

        public class AuthenticationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IAMConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-authenticationconfiguration.html#cfn-emrcontainers-securityconfiguration-authenticationconfiguration-iamconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IAMConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration IAMConfiguration { get; set; }
            /// <summary>
            /// IdentityCenterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-authenticationconfiguration.html#cfn-emrcontainers-securityconfiguration-authenticationconfiguration-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration IdentityCenterConfiguration { get; set; }
        }

        public class AuthorizationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LakeFormationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-authorizationconfiguration.html#cfn-emrcontainers-securityconfiguration-authorizationconfiguration-lakeformationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LakeFormationConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration LakeFormationConfiguration { get; set; }
        }

        public class ContainerInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EksInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerinfo.html#cfn-emrcontainers-securityconfiguration-containerinfo-eksinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EksInfo
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo EksInfo { get; set; }
        }

        public class ContainerProvider : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerprovider.html#cfn-emrcontainers-securityconfiguration-containerprovider-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerprovider.html#cfn-emrcontainers-securityconfiguration-containerprovider-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerprovider.html#cfn-emrcontainers-securityconfiguration-containerprovider-info
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContainerInfo
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo Info { get; set; }
        }

        public class EksInfo : Humidifier.Base.BaseSubResource, IHaveNamespace_
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-eksinfo.html#cfn-emrcontainers-securityconfiguration-eksinfo-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InTransitEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-encryptionconfiguration-intransitencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InTransitEncryptionConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration InTransitEncryptionConfiguration { get; set; }
            /// <summary>
            /// AtRestEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-encryptionconfiguration-atrestencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AtRestEncryptionConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.AtRestEncryptionConfiguration AtRestEncryptionConfiguration { get; set; }
        }

        public class IAMConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SystemRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-iamconfiguration.html#cfn-emrcontainers-securityconfiguration-iamconfiguration-systemrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SystemRole { get; set; }
        }

        public class IdentityCenterConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdentityCenterInstanceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-identitycenterconfiguration.html#cfn-emrcontainers-securityconfiguration-identitycenterconfiguration-identitycenterinstancearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdentityCenterInstanceARN { get; set; }
            /// <summary>
            /// IdentityCenterApplicationAssignmentRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-identitycenterconfiguration.html#cfn-emrcontainers-securityconfiguration-identitycenterconfiguration-identitycenterapplicationassignmentrequired
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IdentityCenterApplicationAssignmentRequired { get; set; }
            /// <summary>
            /// EnableIdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-identitycenterconfiguration.html#cfn-emrcontainers-securityconfiguration-identitycenterconfiguration-enableidentitycenter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableIdentityCenter { get; set; }
        }

        public class InTransitEncryptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TLSCertificateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-intransitencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-intransitencryptionconfiguration-tlscertificateconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TLSCertificateConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration TLSCertificateConfiguration { get; set; }
        }

        public class LakeFormationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecureNamespaceInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-securenamespaceinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecureNamespaceInfo
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo SecureNamespaceInfo { get; set; }
            /// <summary>
            /// QueryAccessControlEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-queryaccesscontrolenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic QueryAccessControlEnabled { get; set; }
            /// <summary>
            /// AuthorizedSessionTagValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-authorizedsessiontagvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizedSessionTagValue { get; set; }
            /// <summary>
            /// QueryEngineRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-queryenginerolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryEngineRoleArn { get; set; }
        }

        public class LocalDiskEncryptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-localdiskencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-localdiskencryptionconfiguration-awskmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsKmsKeyId { get; set; }
            /// <summary>
            /// EncryptionKeyProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-localdiskencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-localdiskencryptionconfiguration-encryptionkeyprovidertype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyProviderType { get; set; }
        }

        public class S3EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKMSKeyId, IHaveEncryptionOption
        {
            /// <summary>
            /// KMSKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-s3encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-s3encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSKeyId { get; set; }
            /// <summary>
            /// EncryptionOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-s3encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-s3encryptionconfiguration-encryptionoption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionOption { get; set; }
        }

        public class SecureNamespaceInfo : Humidifier.Base.BaseSubResource, IHaveNamespace_, IHaveClusterId
        {
            /// <summary>
            /// ClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securenamespaceinfo.html#cfn-emrcontainers-securityconfiguration-securenamespaceinfo-clusterid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterId { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securenamespaceinfo.html#cfn-emrcontainers-securityconfiguration-securenamespaceinfo-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class SecurityConfigurationData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securityconfigurationdata.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata-authenticationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AuthenticationConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.AuthenticationConfiguration AuthenticationConfiguration { get; set; }
            /// <summary>
            /// AuthorizationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securityconfigurationdata.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata-authorizationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AuthorizationConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration AuthorizationConfiguration { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securityconfigurationdata.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata-encryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public Humidifier.EMRContainers.SecurityConfigurationTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        }

        public class TLSCertificateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PublicKeySecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-tlscertificateconfiguration.html#cfn-emrcontainers-securityconfiguration-tlscertificateconfiguration-publickeysecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PublicKeySecretArn { get; set; }
            /// <summary>
            /// PrivateKeySecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-tlscertificateconfiguration.html#cfn-emrcontainers-securityconfiguration-tlscertificateconfiguration-privatekeysecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateKeySecretArn { get; set; }
            /// <summary>
            /// CertificateProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-tlscertificateconfiguration.html#cfn-emrcontainers-securityconfiguration-tlscertificateconfiguration-certificateprovidertype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateProviderType { get; set; }
        }
    }
}