namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using AccountAuditConfigurationTypes;

    public class AccountAuditConfiguration : Humidifier.Base.BaseResource, IHaveAccountId, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationsAuditCheckConfigurations, IHaveIoTAccountAuditConfigurationTypesAuditNotificationTargetConfigurationsAuditNotificationTargetConfigurations, IHaveRoleArn
    {
        public override string AWSTypeName { get => AWS.IoT.AccountAuditConfiguration; }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccountId { get; set; }

        /// <summary>
        /// AuditCheckConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AuditCheckConfigurations
        /// </summary>
        [Required]
        public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfigurations, BaseFunction>? AuditCheckConfigurations { get; set; }
        /// <summary>
        /// AuditNotificationTargetConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-auditnotificationtargetconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuditNotificationTargetConfigurations
        /// </summary>
        public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations, BaseFunction>? AuditNotificationTargetConfigurations { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
    }

    namespace AccountAuditConfigurationTypes
    {
        public class AuditCheckConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfiguration.html#cfn-iot-accountauditconfiguration-auditcheckconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class AuditCheckConfigurations : Humidifier.Base.BaseSubResource, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationIotRoleAliasOverlyPermissiveCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationDeviceCertificateSharedCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationConflictingClientIdsCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationIntermediateCaRevokedForActiveDeviceCertificatesCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationIotRoleAliasAllowsAccessToUnusedServicesCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationRevokedCaCertificateStillActiveCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationLoggingDisabledCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationUnauthenticatedCognitoRoleOverlyPermissiveCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationAuthenticatedCognitoRoleOverlyPermissiveCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationCaCertificateExpiringCheck, IHaveIoTAccountAuditConfigurationTypesDeviceCertExpirationAuditCheckConfigurationDeviceCertificateExpiringCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationIoTPolicyPotentialMisConfigurationCheck, IHaveIoTAccountAuditConfigurationTypesDeviceCertAgeAuditCheckConfigurationDeviceCertificateAgeCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationIotPolicyOverlyPermissiveCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationRevokedDeviceCertificateStillActiveCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationDeviceCertificateKeyQualityCheck, IHaveIoTAccountAuditConfigurationTypesAuditCheckConfigurationCaCertificateKeyQualityCheck
        {
            /// <summary>
            /// IotRoleAliasOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotrolealiasoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? IotRoleAliasOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// DeviceCertificateSharedCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificatesharedcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? DeviceCertificateSharedCheck { get; set; }
            /// <summary>
            /// ConflictingClientIdsCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-conflictingclientidscheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? ConflictingClientIdsCheck { get; set; }
            /// <summary>
            /// IntermediateCaRevokedForActiveDeviceCertificatesCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-intermediatecarevokedforactivedevicecertificatescheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? IntermediateCaRevokedForActiveDeviceCertificatesCheck { get; set; }
            /// <summary>
            /// IotRoleAliasAllowsAccessToUnusedServicesCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotrolealiasallowsaccesstounusedservicescheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? IotRoleAliasAllowsAccessToUnusedServicesCheck { get; set; }
            /// <summary>
            /// RevokedCaCertificateStillActiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-revokedcacertificatestillactivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? RevokedCaCertificateStillActiveCheck { get; set; }
            /// <summary>
            /// LoggingDisabledCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-loggingdisabledcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? LoggingDisabledCheck { get; set; }
            /// <summary>
            /// UnauthenticatedCognitoRoleOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-unauthenticatedcognitoroleoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? UnauthenticatedCognitoRoleOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// AuthenticatedCognitoRoleOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-authenticatedcognitoroleoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? AuthenticatedCognitoRoleOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// CaCertificateExpiringCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-cacertificateexpiringcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? CaCertificateExpiringCheck { get; set; }
            /// <summary>
            /// DeviceCertificateExpiringCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificateexpiringcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeviceCertExpirationAuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration, BaseFunction>? DeviceCertificateExpiringCheck { get; set; }
            /// <summary>
            /// IoTPolicyPotentialMisConfigurationCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotpolicypotentialmisconfigurationcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? IoTPolicyPotentialMisConfigurationCheck { get; set; }
            /// <summary>
            /// DeviceCertificateAgeCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificateagecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeviceCertAgeAuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration, BaseFunction>? DeviceCertificateAgeCheck { get; set; }
            /// <summary>
            /// IotPolicyOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotpolicyoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? IotPolicyOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// RevokedDeviceCertificateStillActiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-revokeddevicecertificatestillactivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? RevokedDeviceCertificateStillActiveCheck { get; set; }
            /// <summary>
            /// DeviceCertificateKeyQualityCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificatekeyqualitycheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? DeviceCertificateKeyQualityCheck { get; set; }
            /// <summary>
            /// CaCertificateKeyQualityCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-cacertificatekeyqualitycheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration, BaseFunction>? CaCertificateKeyQualityCheck { get; set; }
        }

        public class AuditNotificationTarget : Humidifier.Base.BaseSubResource, IHaveTargetArn, IHaveEnabled_Boolean, IHaveRoleArn
        {
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html#cfn-iot-accountauditconfiguration-auditnotificationtarget-targetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html#cfn-iot-accountauditconfiguration-auditnotificationtarget-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html#cfn-iot-accountauditconfiguration-auditnotificationtarget-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class AuditNotificationTargetConfigurations : Humidifier.Base.BaseSubResource, IHaveIoTAccountAuditConfigurationTypesAuditNotificationTargetSns
        {
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtargetconfigurations.html#cfn-iot-accountauditconfiguration-auditnotificationtargetconfigurations-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditNotificationTarget
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget, BaseFunction>? Sns { get; set; }
        }

        public class CertAgeCheckCustomConfiguration : Humidifier.Base.BaseSubResource, IHaveCertAgeThresholdInDays
        {
            /// <summary>
            /// CertAgeThresholdInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-certagecheckcustomconfiguration.html#cfn-iot-accountauditconfiguration-certagecheckcustomconfiguration-certagethresholdindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertAgeThresholdInDays { get; set; }
        }

        public class CertExpirationCheckCustomConfiguration : Humidifier.Base.BaseSubResource, IHaveCertExpirationThresholdInDays
        {
            /// <summary>
            /// CertExpirationThresholdInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-certexpirationcheckcustomconfiguration.html#cfn-iot-accountauditconfiguration-certexpirationcheckcustomconfiguration-certexpirationthresholdindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertExpirationThresholdInDays { get; set; }
        }

        public class DeviceCertAgeAuditCheckConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTAccountAuditConfigurationTypesCertAgeCheckCustomConfigurationConfiguration, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-devicecertageauditcheckconfiguration.html#cfn-iot-accountauditconfiguration-devicecertageauditcheckconfiguration-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CertAgeCheckCustomConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-devicecertageauditcheckconfiguration.html#cfn-iot-accountauditconfiguration-devicecertageauditcheckconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DeviceCertExpirationAuditCheckConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTAccountAuditConfigurationTypesCertExpirationCheckCustomConfigurationConfiguration, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-devicecertexpirationauditcheckconfiguration.html#cfn-iot-accountauditconfiguration-devicecertexpirationauditcheckconfiguration-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CertExpirationCheckCustomConfiguration
            /// </summary>
            public Union<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-devicecertexpirationauditcheckconfiguration.html#cfn-iot-accountauditconfiguration-devicecertexpirationauditcheckconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}