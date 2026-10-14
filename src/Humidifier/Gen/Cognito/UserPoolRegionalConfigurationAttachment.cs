namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolRegionalConfigurationAttachmentTypes;

    public class UserPoolRegionalConfigurationAttachment : Humidifier.Base.BaseResource, IHaveStatus, IHaveUserPoolId
    {
        public override string AWSTypeName { get => AWS.Cognito.UserPoolRegionalConfigurationAttachment; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolregionalconfigurationattachment.html#cfn-cognito-userpoolregionalconfigurationattachment-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// UserPoolTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolregionalconfigurationattachment.html#cfn-cognito-userpoolregionalconfigurationattachment-userpooltags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> UserPoolTags { get; set; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolregionalconfigurationattachment.html#cfn-cognito-userpoolregionalconfigurationattachment-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UserPoolId { get; set; }
        /// <summary>
        /// EmailConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolregionalconfigurationattachment.html#cfn-cognito-userpoolregionalconfigurationattachment-emailconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EmailConfiguration
        /// </summary>
        public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EmailConfiguration EmailConfiguration { get; set; }
        /// <summary>
        /// SmsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolregionalconfigurationattachment.html#cfn-cognito-userpoolregionalconfigurationattachment-smsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SmsConfiguration
        /// </summary>
        public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration SmsConfiguration { get; set; }
        /// <summary>
        /// LambdaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolregionalconfigurationattachment.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LambdaConfig
        /// </summary>
        public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.LambdaConfig LambdaConfig { get; set; }
    }

    namespace UserPoolRegionalConfigurationAttachmentTypes
    {
        public class CustomEmailSender : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-customemailsender.html#cfn-cognito-userpoolregionalconfigurationattachment-customemailsender-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-customemailsender.html#cfn-cognito-userpoolregionalconfigurationattachment-customemailsender-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaVersion { get; set; }
        }

        public class CustomSMSSender : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-customsmssender.html#cfn-cognito-userpoolregionalconfigurationattachment-customsmssender-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-customsmssender.html#cfn-cognito-userpoolregionalconfigurationattachment-customsmssender-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaVersion { get; set; }
        }

        public class EmailConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceArn, IHaveFrom, IHaveConfigurationSet
        {
            /// <summary>
            /// ReplyToEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-emailconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-emailconfiguration-replytoemailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplyToEmailAddress { get; set; }
            /// <summary>
            /// ConfigurationSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-emailconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-emailconfiguration-configurationset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationSet { get; set; }
            /// <summary>
            /// EmailSendingAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-emailconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-emailconfiguration-emailsendingaccount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailSendingAccount { get; set; }
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-emailconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-emailconfiguration-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn { get; set; }
            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-emailconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-emailconfiguration-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic From { get; set; }
        }

        public class EumsSmsConfiguration : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveExternalId, IHaveConfigurationSetName
        {
            /// <summary>
            /// InTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-intemplateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InTemplateId { get; set; }
            /// <summary>
            /// InEntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-inentityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InEntityId { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// CallerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-callerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CallerArn { get; set; }
            /// <summary>
            /// ConfigurationSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-configurationsetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationSetName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// OriginationIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-eumssmsconfiguration-originationidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OriginationIdentity { get; set; }
        }

        public class InboundFederation : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-inboundfederation.html#cfn-cognito-userpoolregionalconfigurationattachment-inboundfederation-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-inboundfederation.html#cfn-cognito-userpoolregionalconfigurationattachment-inboundfederation-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaVersion { get; set; }
        }

        public class LambdaConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CreateAuthChallenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-createauthchallenge
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAuthChallenge { get; set; }
            /// <summary>
            /// PreSignUp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-presignup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreSignUp { get; set; }
            /// <summary>
            /// KMSKeyID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSKeyID { get; set; }
            /// <summary>
            /// UserMigration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-usermigration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserMigration { get; set; }
            /// <summary>
            /// PostAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-postauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostAuthentication { get; set; }
            /// <summary>
            /// VerifyAuthChallengeResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-verifyauthchallengeresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerifyAuthChallengeResponse { get; set; }
            /// <summary>
            /// PreAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-preauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreAuthentication { get; set; }
            /// <summary>
            /// DefineAuthChallenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-defineauthchallenge
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefineAuthChallenge { get; set; }
            /// <summary>
            /// PreTokenGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-pretokengeneration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreTokenGeneration { get; set; }
            /// <summary>
            /// InboundFederation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-inboundfederation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InboundFederation
            /// </summary>
            public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.InboundFederation InboundFederation { get; set; }
            /// <summary>
            /// CustomSMSSender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-customsmssender
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomSMSSender
            /// </summary>
            public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomSMSSender CustomSMSSender { get; set; }
            /// <summary>
            /// PostConfirmation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-postconfirmation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostConfirmation { get; set; }
            /// <summary>
            /// CustomMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-custommessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomMessage { get; set; }
            /// <summary>
            /// PreTokenGenerationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-pretokengenerationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreTokenGenerationConfig
            /// </summary>
            public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.PreTokenGenerationConfig PreTokenGenerationConfig { get; set; }
            /// <summary>
            /// CustomEmailSender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-lambdaconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-lambdaconfig-customemailsender
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomEmailSender
            /// </summary>
            public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomEmailSender CustomEmailSender { get; set; }
        }

        public class PreTokenGenerationConfig : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-pretokengenerationconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-pretokengenerationconfig-lambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// LambdaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-pretokengenerationconfig.html#cfn-cognito-userpoolregionalconfigurationattachment-pretokengenerationconfig-lambdaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaVersion { get; set; }
        }

        public class SmsConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalId
        {
            /// <summary>
            /// SnsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-smsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-smsconfiguration-snsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnsRegion { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-smsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-smsconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId { get; set; }
            /// <summary>
            /// EumsSms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-smsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-smsconfiguration-eumssms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EumsSmsConfiguration
            /// </summary>
            public Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration EumsSms { get; set; }
            /// <summary>
            /// SnsCallerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolregionalconfigurationattachment-smsconfiguration.html#cfn-cognito-userpoolregionalconfigurationattachment-smsconfiguration-snscallerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnsCallerArn { get; set; }
        }
    }
}