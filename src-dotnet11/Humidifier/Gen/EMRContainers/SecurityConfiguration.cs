namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using SecurityConfigurationTypes;

    public class SecurityConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEMRContainersSecurityConfigurationTypesContainerProviderContainerProvider, IHaveEMRContainersSecurityConfigurationTypesSecurityConfigurationDataSecurityConfigurationData, IHaveName
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
        public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider, BaseFunction>? ContainerProvider { get; set; }

        /// <summary>
        /// SecurityConfigurationData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-securityconfiguration.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SecurityConfigurationData
        /// </summary>
        [Required]
        public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData, BaseFunction>? SecurityConfigurationData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-securityconfiguration.html#cfn-emrcontainers-securityconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SecurityConfigurationTypes
    {
        public class AtRestEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesLocalDiskEncryptionConfigurationLocalDiskEncryptionConfiguration, IHaveEMRContainersSecurityConfigurationTypesS3EncryptionConfigurationS3EncryptionConfiguration
        {
            /// <summary>
            /// LocalDiskEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-atrestencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-atrestencryptionconfiguration-localdiskencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalDiskEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration, BaseFunction>? LocalDiskEncryptionConfiguration { get; set; }
            /// <summary>
            /// S3EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-atrestencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-atrestencryptionconfiguration-s3encryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3EncryptionConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration, BaseFunction>? S3EncryptionConfiguration { get; set; }
        }

        public class AuthenticationConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesIAMConfigurationIAMConfiguration, IHaveEMRContainersSecurityConfigurationTypesIdentityCenterConfigurationIdentityCenterConfiguration
        {
            /// <summary>
            /// IAMConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-authenticationconfiguration.html#cfn-emrcontainers-securityconfiguration-authenticationconfiguration-iamconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IAMConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration, BaseFunction>? IAMConfiguration { get; set; }
            /// <summary>
            /// IdentityCenterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-authenticationconfiguration.html#cfn-emrcontainers-securityconfiguration-authenticationconfiguration-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration, BaseFunction>? IdentityCenterConfiguration { get; set; }
        }

        public class AuthorizationConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesLakeFormationConfigurationLakeFormationConfiguration
        {
            /// <summary>
            /// LakeFormationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-authorizationconfiguration.html#cfn-emrcontainers-securityconfiguration-authorizationconfiguration-lakeformationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LakeFormationConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration, BaseFunction>? LakeFormationConfiguration { get; set; }
        }

        public class ContainerInfo : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesEksInfoEksInfo
        {
            /// <summary>
            /// EksInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerinfo.html#cfn-emrcontainers-securityconfiguration-containerinfo-eksinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EksInfo
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo, BaseFunction>? EksInfo { get; set; }
        }

        public class ContainerProvider : Humidifier.Base.BaseSubResource, IHaveType, IHaveId, IHaveEMRContainersSecurityConfigurationTypesContainerInfoInfo
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerprovider.html#cfn-emrcontainers-securityconfiguration-containerprovider-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerprovider.html#cfn-emrcontainers-securityconfiguration-containerprovider-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-containerprovider.html#cfn-emrcontainers-securityconfiguration-containerprovider-info
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContainerInfo
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo, BaseFunction>? Info { get; set; }
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
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesInTransitEncryptionConfigurationInTransitEncryptionConfiguration, IHaveEMRContainersSecurityConfigurationTypesAtRestEncryptionConfigurationAtRestEncryptionConfiguration
        {
            /// <summary>
            /// InTransitEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-encryptionconfiguration-intransitencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InTransitEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration, BaseFunction>? InTransitEncryptionConfiguration { get; set; }
            /// <summary>
            /// AtRestEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-encryptionconfiguration-atrestencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AtRestEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.AtRestEncryptionConfiguration, BaseFunction>? AtRestEncryptionConfiguration { get; set; }
        }

        public class IAMConfiguration : Humidifier.Base.BaseSubResource, IHaveSystemRole
        {
            /// <summary>
            /// SystemRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-iamconfiguration.html#cfn-emrcontainers-securityconfiguration-iamconfiguration-systemrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SystemRole { get; set; }
        }

        public class IdentityCenterConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentityCenterInstanceARN, IHaveIdentityCenterApplicationAssignmentRequired_Boolean, IHaveEnableIdentityCenter_Boolean
        {
            /// <summary>
            /// IdentityCenterInstanceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-identitycenterconfiguration.html#cfn-emrcontainers-securityconfiguration-identitycenterconfiguration-identitycenterinstancearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityCenterInstanceARN { get; set; }
            /// <summary>
            /// IdentityCenterApplicationAssignmentRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-identitycenterconfiguration.html#cfn-emrcontainers-securityconfiguration-identitycenterconfiguration-identitycenterapplicationassignmentrequired
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IdentityCenterApplicationAssignmentRequired { get; set; }
            /// <summary>
            /// EnableIdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-identitycenterconfiguration.html#cfn-emrcontainers-securityconfiguration-identitycenterconfiguration-enableidentitycenter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableIdentityCenter { get; set; }
        }

        public class InTransitEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesTLSCertificateConfigurationTLSCertificateConfiguration
        {
            /// <summary>
            /// TLSCertificateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-intransitencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-intransitencryptionconfiguration-tlscertificateconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TLSCertificateConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration, BaseFunction>? TLSCertificateConfiguration { get; set; }
        }

        public class LakeFormationConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesSecureNamespaceInfoSecureNamespaceInfo, IHaveQueryAccessControlEnabled_Boolean, IHaveAuthorizedSessionTagValue, IHaveQueryEngineRoleArn
        {
            /// <summary>
            /// SecureNamespaceInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-securenamespaceinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecureNamespaceInfo
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo, BaseFunction>? SecureNamespaceInfo { get; set; }
            /// <summary>
            /// QueryAccessControlEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-queryaccesscontrolenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QueryAccessControlEnabled { get; set; }
            /// <summary>
            /// AuthorizedSessionTagValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-authorizedsessiontagvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizedSessionTagValue { get; set; }
            /// <summary>
            /// QueryEngineRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-lakeformationconfiguration.html#cfn-emrcontainers-securityconfiguration-lakeformationconfiguration-queryenginerolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryEngineRoleArn { get; set; }
        }

        public class LocalDiskEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveAwsKmsKeyId, IHaveEncryptionKeyProviderType
        {
            /// <summary>
            /// AwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-localdiskencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-localdiskencryptionconfiguration-awskmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsKmsKeyId { get; set; }
            /// <summary>
            /// EncryptionKeyProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-localdiskencryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-localdiskencryptionconfiguration-encryptionkeyprovidertype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyProviderType { get; set; }
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
            public Union<string, BaseFunction>? KMSKeyId { get; set; }
            /// <summary>
            /// EncryptionOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-s3encryptionconfiguration.html#cfn-emrcontainers-securityconfiguration-s3encryptionconfiguration-encryptionoption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionOption { get; set; }
        }

        public class SecureNamespaceInfo : Humidifier.Base.BaseSubResource, IHaveClusterId, IHaveNamespace_
        {
            /// <summary>
            /// ClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securenamespaceinfo.html#cfn-emrcontainers-securityconfiguration-securenamespaceinfo-clusterid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterId { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securenamespaceinfo.html#cfn-emrcontainers-securityconfiguration-securenamespaceinfo-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class SecurityConfigurationData : Humidifier.Base.BaseSubResource, IHaveEMRContainersSecurityConfigurationTypesAuthenticationConfigurationAuthenticationConfiguration, IHaveEMRContainersSecurityConfigurationTypesAuthorizationConfigurationAuthorizationConfiguration, IHaveEMRContainersSecurityConfigurationTypesEncryptionConfigurationEncryptionConfiguration
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securityconfigurationdata.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata-authenticationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AuthenticationConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.AuthenticationConfiguration, BaseFunction>? AuthenticationConfiguration { get; set; }
            /// <summary>
            /// AuthorizationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securityconfigurationdata.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata-authorizationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AuthorizationConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration, BaseFunction>? AuthorizationConfiguration { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-securityconfigurationdata.html#cfn-emrcontainers-securityconfiguration-securityconfigurationdata-encryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.SecurityConfigurationTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        }

        public class TLSCertificateConfiguration : Humidifier.Base.BaseSubResource, IHavePublicKeySecretArn, IHavePrivateKeySecretArn, IHaveCertificateProviderType
        {
            /// <summary>
            /// PublicKeySecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-tlscertificateconfiguration.html#cfn-emrcontainers-securityconfiguration-tlscertificateconfiguration-publickeysecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicKeySecretArn { get; set; }
            /// <summary>
            /// PrivateKeySecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-tlscertificateconfiguration.html#cfn-emrcontainers-securityconfiguration-tlscertificateconfiguration-privatekeysecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateKeySecretArn { get; set; }
            /// <summary>
            /// CertificateProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-securityconfiguration-tlscertificateconfiguration.html#cfn-emrcontainers-securityconfiguration-tlscertificateconfiguration-certificateprovidertype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateProviderType { get; set; }
        }
    }
}