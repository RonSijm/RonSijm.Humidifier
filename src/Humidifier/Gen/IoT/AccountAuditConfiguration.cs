namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using AccountAuditConfigurationTypes;

    public class AccountAuditConfiguration : Humidifier.Base.BaseResource, IHaveRoleArn, IHaveAccountId
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
        public dynamic AccountId { get; set; }

        /// <summary>
        /// AuditCheckConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AuditCheckConfigurations
        /// </summary>
        [Required]
        public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfigurations AuditCheckConfigurations { get; set; }
        /// <summary>
        /// AuditNotificationTargetConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-auditnotificationtargetconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuditNotificationTargetConfigurations
        /// </summary>
        public Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations AuditNotificationTargetConfigurations { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html#cfn-iot-accountauditconfiguration-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
    }

    namespace AccountAuditConfigurationTypes
    {
        public class AuditCheckConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfiguration.html#cfn-iot-accountauditconfiguration-auditcheckconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class AuditCheckConfigurations : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IotRoleAliasOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotrolealiasoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration IotRoleAliasOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// DeviceCertificateSharedCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificatesharedcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration DeviceCertificateSharedCheck { get; set; }
            /// <summary>
            /// ConflictingClientIdsCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-conflictingclientidscheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration ConflictingClientIdsCheck { get; set; }
            /// <summary>
            /// IntermediateCaRevokedForActiveDeviceCertificatesCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-intermediatecarevokedforactivedevicecertificatescheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration IntermediateCaRevokedForActiveDeviceCertificatesCheck { get; set; }
            /// <summary>
            /// IotRoleAliasAllowsAccessToUnusedServicesCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotrolealiasallowsaccesstounusedservicescheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration IotRoleAliasAllowsAccessToUnusedServicesCheck { get; set; }
            /// <summary>
            /// RevokedCaCertificateStillActiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-revokedcacertificatestillactivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration RevokedCaCertificateStillActiveCheck { get; set; }
            /// <summary>
            /// LoggingDisabledCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-loggingdisabledcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration LoggingDisabledCheck { get; set; }
            /// <summary>
            /// UnauthenticatedCognitoRoleOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-unauthenticatedcognitoroleoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration UnauthenticatedCognitoRoleOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// AuthenticatedCognitoRoleOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-authenticatedcognitoroleoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration AuthenticatedCognitoRoleOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// CaCertificateExpiringCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-cacertificateexpiringcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration CaCertificateExpiringCheck { get; set; }
            /// <summary>
            /// DeviceCertificateExpiringCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificateexpiringcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration DeviceCertificateExpiringCheck { get; set; }
            /// <summary>
            /// IoTPolicyPotentialMisConfigurationCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotpolicypotentialmisconfigurationcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration IoTPolicyPotentialMisConfigurationCheck { get; set; }
            /// <summary>
            /// IotPolicyOverlyPermissiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-iotpolicyoverlypermissivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration IotPolicyOverlyPermissiveCheck { get; set; }
            /// <summary>
            /// RevokedDeviceCertificateStillActiveCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-revokeddevicecertificatestillactivecheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration RevokedDeviceCertificateStillActiveCheck { get; set; }
            /// <summary>
            /// DeviceCertificateKeyQualityCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-devicecertificatekeyqualitycheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration DeviceCertificateKeyQualityCheck { get; set; }
            /// <summary>
            /// CaCertificateKeyQualityCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html#cfn-iot-accountauditconfiguration-auditcheckconfigurations-cacertificatekeyqualitycheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditCheckConfiguration
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration CaCertificateKeyQualityCheck { get; set; }
        }

        public class AuditNotificationTarget : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveEnabled, IHaveTargetArn
        {
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html#cfn-iot-accountauditconfiguration-auditnotificationtarget-targetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html#cfn-iot-accountauditconfiguration-auditnotificationtarget-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html#cfn-iot-accountauditconfiguration-auditnotificationtarget-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class AuditNotificationTargetConfigurations : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtargetconfigurations.html#cfn-iot-accountauditconfiguration-auditnotificationtargetconfigurations-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditNotificationTarget
            /// </summary>
            public Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget Sns { get; set; }
        }
    }
}