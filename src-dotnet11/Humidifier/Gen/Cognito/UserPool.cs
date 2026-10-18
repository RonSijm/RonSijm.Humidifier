namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolTypes;

    public class UserPool : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringDictionaryOfUserPoolTags, IHaveCognitoUserPoolTypesPoliciesPolicies, IHaveCognitoUserPoolTypesKeyConfigurationKeyConfiguration, IHaveListOfCognitoUserPoolTypesSchemaAttributeSchema, IHaveCognitoUserPoolTypesAdminCreateUserConfigAdminCreateUserConfig, IHaveUserPoolTier, IHaveCognitoUserPoolTypesUsernameConfigurationUsernameConfiguration, IHaveUserPoolName, IHaveSmsVerificationMessage, IHaveCognitoUserPoolTypesUserAttributeUpdateSettingsUserAttributeUpdateSettings, IHaveCognitoUserPoolTypesEmailConfigurationEmailConfiguration, IHaveCognitoUserPoolTypesSmsConfigurationSmsConfiguration, IHaveEmailVerificationSubject, IHaveWebAuthnRelyingPartyID, IHaveEmailAuthenticationSubject, IHaveCognitoUserPoolTypesAccountRecoverySettingAccountRecoverySetting, IHaveCognitoUserPoolTypesVerificationMessageTemplateVerificationMessageTemplate, IHaveCognitoUserPoolTypesIssuerConfigurationIssuerConfiguration, IHaveMfaConfiguration, IHaveDeletionProtection, IHaveWebAuthnFactorConfiguration, IHaveSmsAuthenticationMessage, IHaveWebAuthnUserVerification, IHaveCognitoUserPoolTypesUserPoolAddOnsUserPoolAddOns, IHaveEmailAuthenticationMessage, IHaveStringListOfAliasAttributes, IHaveStringListOfEnabledMfas, IHaveCognitoUserPoolTypesLambdaConfigLambdaConfig, IHaveStringListOfUsernameAttributes, IHaveStringListOfAutoVerifiedAttributes, IHaveCognitoUserPoolTypesDeviceConfigurationDeviceConfiguration, IHaveEmailVerificationMessage
    {
        public class Attributes
        {
            public static string ProviderName =  "ProviderName" ;
            public static string UserPoolId =  "UserPoolId" ;
            public static string ProviderURL =  "ProviderURL" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.UserPool; }
        /// <summary>
        /// UserPoolTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpooltags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserPoolTags { get; set; }
        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Policies
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.Policies, BaseFunction>? Policies { get; set; }
        /// <summary>
        /// KeyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-keyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KeyConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.KeyConfiguration, BaseFunction>? KeyConfiguration { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-schema
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SchemaAttribute
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.UserPoolTypes.SchemaAttribute>, IReadOnlyList<Union<Humidifier.Cognito.UserPoolTypes.SchemaAttribute, BaseFunction>>, BaseFunction>? Schema { get; set; }
        /// <summary>
        /// AdminCreateUserConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-admincreateuserconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdminCreateUserConfig
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig, BaseFunction>? AdminCreateUserConfig { get; set; }
        /// <summary>
        /// UserPoolTier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpooltier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserPoolTier { get; set; }
        /// <summary>
        /// UsernameConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-usernameconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UsernameConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.UsernameConfiguration, BaseFunction>? UsernameConfiguration { get; set; }
        public Union<string, BaseFunction>? UserPoolName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SmsVerificationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsverificationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SmsVerificationMessage { get; set; }
        /// <summary>
        /// UserAttributeUpdateSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userattributeupdatesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserAttributeUpdateSettings
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.UserAttributeUpdateSettings, BaseFunction>? UserAttributeUpdateSettings { get; set; }
        /// <summary>
        /// EmailConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EmailConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.EmailConfiguration, BaseFunction>? EmailConfiguration { get; set; }
        /// <summary>
        /// SmsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SmsConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.SmsConfiguration, BaseFunction>? SmsConfiguration { get; set; }
        /// <summary>
        /// EmailVerificationSubject
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationsubject
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EmailVerificationSubject { get; set; }
        /// <summary>
        /// WebAuthnRelyingPartyID
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-webauthnrelyingpartyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WebAuthnRelyingPartyID { get; set; }
        /// <summary>
        /// EmailAuthenticationSubject
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailauthenticationsubject
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EmailAuthenticationSubject { get; set; }
        /// <summary>
        /// AccountRecoverySetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-accountrecoverysetting
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccountRecoverySetting
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.AccountRecoverySetting, BaseFunction>? AccountRecoverySetting { get; set; }
        /// <summary>
        /// VerificationMessageTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-verificationmessagetemplate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VerificationMessageTemplate
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.VerificationMessageTemplate, BaseFunction>? VerificationMessageTemplate { get; set; }
        /// <summary>
        /// IssuerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-issuerconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IssuerConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.IssuerConfiguration, BaseFunction>? IssuerConfiguration { get; set; }
        /// <summary>
        /// MfaConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-mfaconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MfaConfiguration { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// WebAuthnFactorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-webauthnfactorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WebAuthnFactorConfiguration { get; set; }
        /// <summary>
        /// SmsAuthenticationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsauthenticationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SmsAuthenticationMessage { get; set; }
        /// <summary>
        /// WebAuthnUserVerification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-webauthnuserverification
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WebAuthnUserVerification { get; set; }
        /// <summary>
        /// UserPoolAddOns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpooladdons
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserPoolAddOns
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.UserPoolAddOns, BaseFunction>? UserPoolAddOns { get; set; }
        /// <summary>
        /// EmailAuthenticationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailauthenticationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EmailAuthenticationMessage { get; set; }
        /// <summary>
        /// AliasAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-aliasattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AliasAttributes { get; set; }
        /// <summary>
        /// EnabledMfas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-enabledmfas
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledMfas { get; set; }
        /// <summary>
        /// LambdaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-lambdaconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LambdaConfig
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.LambdaConfig, BaseFunction>? LambdaConfig { get; set; }
        /// <summary>
        /// UsernameAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-usernameattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? UsernameAttributes { get; set; }
        /// <summary>
        /// AutoVerifiedAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-autoverifiedattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoVerifiedAttributes { get; set; }
        /// <summary>
        /// DeviceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-deviceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeviceConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolTypes.DeviceConfiguration, BaseFunction>? DeviceConfiguration { get; set; }
        /// <summary>
        /// EmailVerificationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EmailVerificationMessage { get; set; }
    }

    namespace UserPoolTypes
    {
        public class AccountRecoverySetting : Humidifier.Base.BaseSubResource, IHaveListOfCognitoUserPoolTypesRecoveryOptionRecoveryMechanisms
        {
            /// <summary>
            /// RecoveryMechanisms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-accountrecoverysetting.html#cfn-cognito-userpool-accountrecoverysetting-recoverymechanisms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecoveryOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Cognito.UserPoolTypes.RecoveryOption>, IReadOnlyList<Union<Humidifier.Cognito.UserPoolTypes.RecoveryOption, BaseFunction>>, BaseFunction>? RecoveryMechanisms { get; set; }
        }

        public class AdminCreateUserConfig : Humidifier.Base.BaseSubResource, IHaveCognitoUserPoolTypesInviteMessageTemplateInviteMessageTemplate, IHaveUnusedAccountValidityDays_Integer, IHaveAllowAdminCreateUserOnly_Boolean
        {
            /// <summary>
            /// InviteMessageTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-invitemessagetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InviteMessageTemplate
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate, BaseFunction>? InviteMessageTemplate { get; set; }
            /// <summary>
            /// UnusedAccountValidityDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-unusedaccountvaliditydays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnusedAccountValidityDays { get; set; }
            /// <summary>
            /// AllowAdminCreateUserOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-allowadmincreateuseronly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowAdminCreateUserOnly { get; set; }
        }

        public class AdvancedSecurityAdditionalFlows : Humidifier.Base.BaseSubResource, IHaveCustomAuthMode
        {
            /// <summary>
            /// CustomAuthMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-advancedsecurityadditionalflows.html#cfn-cognito-userpool-advancedsecurityadditionalflows-customauthmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomAuthMode { get; set; }
        }

        public class CustomEmailSender : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-customemailsender.html#cfn-cognito-userpool-customemailsender-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-customemailsender.html#cfn-cognito-userpool-customemailsender-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaVersion { get; set; }
        }

        public class CustomSMSSender : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-customsmssender.html#cfn-cognito-userpool-customsmssender-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-customsmssender.html#cfn-cognito-userpool-customsmssender-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaVersion { get; set; }
        }

        public class DeviceConfiguration : Humidifier.Base.BaseSubResource, IHaveDeviceOnlyRememberedOnUserPrompt_Boolean, IHaveChallengeRequiredOnNewDevice_Boolean
        {
            /// <summary>
            /// DeviceOnlyRememberedOnUserPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html#cfn-cognito-userpool-deviceconfiguration-deviceonlyrememberedonuserprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeviceOnlyRememberedOnUserPrompt { get; set; }
            /// <summary>
            /// ChallengeRequiredOnNewDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html#cfn-cognito-userpool-deviceconfiguration-challengerequiredonnewdevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ChallengeRequiredOnNewDevice { get; set; }
        }

        public class EmailConfiguration : Humidifier.Base.BaseSubResource, IHaveReplyToEmailAddress, IHaveConfigurationSet, IHaveEmailSendingAccount, IHaveSourceArn, IHaveFrom
        {
            /// <summary>
            /// ReplyToEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-replytoemailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplyToEmailAddress { get; set; }
            /// <summary>
            /// ConfigurationSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-configurationset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationSet { get; set; }
            /// <summary>
            /// EmailSendingAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-emailsendingaccount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailSendingAccount { get; set; }
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceArn { get; set; }
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? From { get; set; }
        }

        public class EumsSmsConfiguration : Humidifier.Base.BaseSubResource, IHaveInTemplateId, IHaveInEntityId, IHaveExternalId, IHaveCallerArn, IHaveConfigurationSetName, IHaveRegion, IHaveOriginationIdentity
        {
            /// <summary>
            /// InTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-intemplateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InTemplateId { get; set; }
            /// <summary>
            /// InEntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-inentityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InEntityId { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// CallerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-callerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CallerArn { get; set; }
            /// <summary>
            /// ConfigurationSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-configurationsetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationSetName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// OriginationIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-eumssmsconfiguration.html#cfn-cognito-userpool-eumssmsconfiguration-originationidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginationIdentity { get; set; }
        }

        public class InboundFederation : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-inboundfederation.html#cfn-cognito-userpool-inboundfederation-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-inboundfederation.html#cfn-cognito-userpool-inboundfederation-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaVersion { get; set; }
        }

        public class InviteMessageTemplate : Humidifier.Base.BaseSubResource, IHaveEmailMessage, IHaveSMSMessage, IHaveEmailSubject
        {
            /// <summary>
            /// EmailMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-emailmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailMessage { get; set; }
            /// <summary>
            /// SMSMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-smsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SMSMessage { get; set; }
            /// <summary>
            /// EmailSubject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-emailsubject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailSubject { get; set; }
        }

        public class IssuerConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-issuerconfiguration.html#cfn-cognito-userpool-issuerconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class KeyConfiguration : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveKmsKeyArn
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-keyconfiguration.html#cfn-cognito-userpool-keyconfiguration-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-keyconfiguration.html#cfn-cognito-userpool-keyconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class LambdaConfig : Humidifier.Base.BaseSubResource, IHaveCreateAuthChallenge, IHavePreSignUp, IHaveKMSKeyID, IHaveUserMigration, IHavePostAuthentication, IHaveVerifyAuthChallengeResponse, IHavePreAuthentication, IHaveDefineAuthChallenge, IHavePreTokenGeneration, IHaveCognitoUserPoolTypesInboundFederationInboundFederation, IHaveCognitoUserPoolTypesCustomSMSSenderCustomSMSSender, IHavePostConfirmation, IHaveCustomMessage, IHaveCognitoUserPoolTypesPreTokenGenerationConfigPreTokenGenerationConfig, IHaveCognitoUserPoolTypesCustomEmailSenderCustomEmailSender
        {
            /// <summary>
            /// CreateAuthChallenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-createauthchallenge
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAuthChallenge { get; set; }
            /// <summary>
            /// PreSignUp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-presignup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreSignUp { get; set; }
            /// <summary>
            /// KMSKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSKeyID { get; set; }
            /// <summary>
            /// UserMigration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-usermigration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserMigration { get; set; }
            /// <summary>
            /// PostAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostAuthentication { get; set; }
            /// <summary>
            /// VerifyAuthChallengeResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-verifyauthchallengeresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VerifyAuthChallengeResponse { get; set; }
            /// <summary>
            /// PreAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-preauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreAuthentication { get; set; }
            /// <summary>
            /// DefineAuthChallenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-defineauthchallenge
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefineAuthChallenge { get; set; }
            /// <summary>
            /// PreTokenGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-pretokengeneration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreTokenGeneration { get; set; }
            /// <summary>
            /// InboundFederation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-inboundfederation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InboundFederation
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.InboundFederation, BaseFunction>? InboundFederation { get; set; }
            /// <summary>
            /// CustomSMSSender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-customsmssender
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomSMSSender
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.CustomSMSSender, BaseFunction>? CustomSMSSender { get; set; }
            /// <summary>
            /// PostConfirmation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postconfirmation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostConfirmation { get; set; }
            /// <summary>
            /// CustomMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-custommessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomMessage { get; set; }
            /// <summary>
            /// PreTokenGenerationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-pretokengenerationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreTokenGenerationConfig
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.PreTokenGenerationConfig, BaseFunction>? PreTokenGenerationConfig { get; set; }
            /// <summary>
            /// CustomEmailSender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-customemailsender
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomEmailSender
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.CustomEmailSender, BaseFunction>? CustomEmailSender { get; set; }
        }

        public class NumberAttributeConstraints : Humidifier.Base.BaseSubResource, IHaveMinValue, IHaveMaxValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-numberattributeconstraints.html#cfn-cognito-userpool-numberattributeconstraints-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-numberattributeconstraints.html#cfn-cognito-userpool-numberattributeconstraints-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxValue { get; set; }
        }

        public class PasswordPolicy : Humidifier.Base.BaseSubResource, IHaveRequireNumbers_Boolean, IHaveMinimumLength_Integer, IHaveTemporaryPasswordValidityDays_Integer, IHaveRequireUppercase_Boolean, IHaveRequireLowercase_Boolean, IHaveRequireSymbols_Boolean, IHavePasswordHistorySize_Integer
        {
            /// <summary>
            /// RequireNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requirenumbers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireNumbers { get; set; }
            /// <summary>
            /// MinimumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-minimumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLength { get; set; }
            /// <summary>
            /// TemporaryPasswordValidityDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-temporarypasswordvaliditydays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TemporaryPasswordValidityDays { get; set; }
            /// <summary>
            /// RequireUppercase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requireuppercase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireUppercase { get; set; }
            /// <summary>
            /// RequireLowercase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requirelowercase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireLowercase { get; set; }
            /// <summary>
            /// RequireSymbols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requiresymbols
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireSymbols { get; set; }
            /// <summary>
            /// PasswordHistorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-passwordhistorysize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PasswordHistorySize { get; set; }
        }

        public class Policies : Humidifier.Base.BaseSubResource, IHaveCognitoUserPoolTypesPasswordPolicyPasswordPolicy, IHaveCognitoUserPoolTypesSignInPolicySignInPolicy
        {
            /// <summary>
            /// PasswordPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-policies.html#cfn-cognito-userpool-policies-passwordpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PasswordPolicy
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.PasswordPolicy, BaseFunction>? PasswordPolicy { get; set; }
            /// <summary>
            /// SignInPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-policies.html#cfn-cognito-userpool-policies-signinpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SignInPolicy
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.SignInPolicy, BaseFunction>? SignInPolicy { get; set; }
        }

        public class PreTokenGenerationConfig : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-pretokengenerationconfig.html#cfn-cognito-userpool-pretokengenerationconfig-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-pretokengenerationconfig.html#cfn-cognito-userpool-pretokengenerationconfig-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaVersion { get; set; }
        }

        public class RecoveryOption : Humidifier.Base.BaseSubResource, IHavePriority_Integer, IHaveName
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-recoveryoption.html#cfn-cognito-userpool-recoveryoption-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-recoveryoption.html#cfn-cognito-userpool-recoveryoption-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SchemaAttribute : Humidifier.Base.BaseSubResource, IHaveDeveloperOnlyAttribute_Boolean, IHaveMutable_Boolean, IHaveAttributeDataType, IHaveCognitoUserPoolTypesStringAttributeConstraintsStringAttributeConstraints, IHaveRequired_Boolean, IHaveCognitoUserPoolTypesNumberAttributeConstraintsNumberAttributeConstraints, IHaveName
        {
            /// <summary>
            /// DeveloperOnlyAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-developeronlyattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeveloperOnlyAttribute { get; set; }
            /// <summary>
            /// Mutable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-mutable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Mutable { get; set; }
            /// <summary>
            /// AttributeDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-attributedatatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeDataType { get; set; }
            /// <summary>
            /// StringAttributeConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-stringattributeconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringAttributeConstraints
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.StringAttributeConstraints, BaseFunction>? StringAttributeConstraints { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// NumberAttributeConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-numberattributeconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberAttributeConstraints
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.NumberAttributeConstraints, BaseFunction>? NumberAttributeConstraints { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SignInPolicy : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedFirstAuthFactors
        {
            /// <summary>
            /// AllowedFirstAuthFactors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-signinpolicy.html#cfn-cognito-userpool-signinpolicy-allowedfirstauthfactors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedFirstAuthFactors { get; set; }
        }

        public class SmsConfiguration : Humidifier.Base.BaseSubResource, IHaveSnsRegion, IHaveExternalId, IHaveCognitoUserPoolTypesEumsSmsConfigurationEumsSms, IHaveSnsCallerArn
        {
            /// <summary>
            /// SnsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html#cfn-cognito-userpool-smsconfiguration-snsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnsRegion { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html#cfn-cognito-userpool-smsconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// EumsSms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html#cfn-cognito-userpool-smsconfiguration-eumssms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EumsSmsConfiguration
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration, BaseFunction>? EumsSms { get; set; }
            /// <summary>
            /// SnsCallerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html#cfn-cognito-userpool-smsconfiguration-snscallerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnsCallerArn { get; set; }
        }

        public class StringAttributeConstraints : Humidifier.Base.BaseSubResource, IHaveMinLength, IHaveMaxLength
        {
            /// <summary>
            /// MinLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-stringattributeconstraints.html#cfn-cognito-userpool-stringattributeconstraints-minlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinLength { get; set; }
            /// <summary>
            /// MaxLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-stringattributeconstraints.html#cfn-cognito-userpool-stringattributeconstraints-maxlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxLength { get; set; }
        }

        public class UserAttributeUpdateSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfAttributesRequireVerificationBeforeUpdate
        {
            /// <summary>
            /// AttributesRequireVerificationBeforeUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-userattributeupdatesettings.html#cfn-cognito-userpool-userattributeupdatesettings-attributesrequireverificationbeforeupdate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttributesRequireVerificationBeforeUpdate { get; set; }
        }

        public class UserPoolAddOns : Humidifier.Base.BaseSubResource, IHaveCognitoUserPoolTypesAdvancedSecurityAdditionalFlowsAdvancedSecurityAdditionalFlows, IHaveAdvancedSecurityMode
        {
            /// <summary>
            /// AdvancedSecurityAdditionalFlows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-userpooladdons.html#cfn-cognito-userpool-userpooladdons-advancedsecurityadditionalflows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedSecurityAdditionalFlows
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows, BaseFunction>? AdvancedSecurityAdditionalFlows { get; set; }
            /// <summary>
            /// AdvancedSecurityMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-userpooladdons.html#cfn-cognito-userpool-userpooladdons-advancedsecuritymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdvancedSecurityMode { get; set; }
        }

        public class UsernameConfiguration : Humidifier.Base.BaseSubResource, IHaveCaseSensitive_Boolean
        {
            /// <summary>
            /// CaseSensitive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-usernameconfiguration.html#cfn-cognito-userpool-usernameconfiguration-casesensitive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaseSensitive { get; set; }
        }

        public class VerificationMessageTemplate : Humidifier.Base.BaseSubResource, IHaveEmailMessageByLink, IHaveEmailMessage, IHaveSmsMessage, IHaveEmailSubject, IHaveDefaultEmailOption, IHaveEmailSubjectByLink
        {
            /// <summary>
            /// EmailMessageByLink
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html#cfn-cognito-userpool-verificationmessagetemplate-emailmessagebylink
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailMessageByLink { get; set; }
            /// <summary>
            /// EmailMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html#cfn-cognito-userpool-verificationmessagetemplate-emailmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailMessage { get; set; }
            /// <summary>
            /// SmsMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html#cfn-cognito-userpool-verificationmessagetemplate-smsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SmsMessage { get; set; }
            /// <summary>
            /// EmailSubject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html#cfn-cognito-userpool-verificationmessagetemplate-emailsubject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailSubject { get; set; }
            /// <summary>
            /// DefaultEmailOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html#cfn-cognito-userpool-verificationmessagetemplate-defaultemailoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultEmailOption { get; set; }
            /// <summary>
            /// EmailSubjectByLink
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-verificationmessagetemplate.html#cfn-cognito-userpool-verificationmessagetemplate-emailsubjectbylink
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailSubjectByLink { get; set; }
        }
    }
}