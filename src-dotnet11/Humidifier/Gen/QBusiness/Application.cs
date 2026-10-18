namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags, IHaveIdentityType, IHaveDescription, IHaveIdentityCenterInstanceArn, IHaveQBusinessApplicationTypesEncryptionConfigurationEncryptionConfiguration, IHaveIamIdentityProviderArn, IHaveRoleArn, IHaveQBusinessApplicationTypesAttachmentsConfigurationAttachmentsConfiguration, IHaveStringListOfClientIdsForOIDC, IHaveQBusinessApplicationTypesQuickSightConfigurationQuickSightConfiguration, IHaveQBusinessApplicationTypesPersonalizationConfigurationPersonalizationConfiguration, IHaveDisplayName, IHaveQBusinessApplicationTypesAutoSubscriptionConfigurationAutoSubscriptionConfiguration, IHaveQBusinessApplicationTypesQAppsConfigurationQAppsConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IdentityCenterApplicationArn =  "IdentityCenterApplicationArn" ;
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.Application; }
        /// <summary>
        /// IdentityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-identitytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IdentityCenterInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-identitycenterinstancearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityCenterInstanceArn { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.ApplicationTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// IamIdentityProviderArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-iamidentityproviderarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IamIdentityProviderArn { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// AttachmentsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-attachmentsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AttachmentsConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.ApplicationTypes.AttachmentsConfiguration, BaseFunction>? AttachmentsConfiguration { get; set; }
        /// <summary>
        /// ClientIdsForOIDC
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-clientidsforoidc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ClientIdsForOIDC { get; set; }
        /// <summary>
        /// QuickSightConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-quicksightconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: QuickSightConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.ApplicationTypes.QuickSightConfiguration, BaseFunction>? QuickSightConfiguration { get; set; }
        /// <summary>
        /// PersonalizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-personalizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PersonalizationConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.ApplicationTypes.PersonalizationConfiguration, BaseFunction>? PersonalizationConfiguration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// AutoSubscriptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-autosubscriptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoSubscriptionConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.ApplicationTypes.AutoSubscriptionConfiguration, BaseFunction>? AutoSubscriptionConfiguration { get; set; }
        /// <summary>
        /// QAppsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-qappsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QAppsConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.ApplicationTypes.QAppsConfiguration, BaseFunction>? QAppsConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ApplicationTypes
    {
        public class AttachmentsConfiguration : Humidifier.Base.BaseSubResource, IHaveAttachmentsControlMode
        {
            /// <summary>
            /// AttachmentsControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-attachmentsconfiguration.html#cfn-qbusiness-application-attachmentsconfiguration-attachmentscontrolmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachmentsControlMode { get; set; }
        }

        public class AutoSubscriptionConfiguration : Humidifier.Base.BaseSubResource, IHaveDefaultSubscriptionType, IHaveAutoSubscribe
        {
            /// <summary>
            /// DefaultSubscriptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-autosubscriptionconfiguration.html#cfn-qbusiness-application-autosubscriptionconfiguration-defaultsubscriptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultSubscriptionType { get; set; }
            /// <summary>
            /// AutoSubscribe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-autosubscriptionconfiguration.html#cfn-qbusiness-application-autosubscriptionconfiguration-autosubscribe
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoSubscribe { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-encryptionconfiguration.html#cfn-qbusiness-application-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class PersonalizationConfiguration : Humidifier.Base.BaseSubResource, IHavePersonalizationControlMode
        {
            /// <summary>
            /// PersonalizationControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-personalizationconfiguration.html#cfn-qbusiness-application-personalizationconfiguration-personalizationcontrolmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PersonalizationControlMode { get; set; }
        }

        public class QAppsConfiguration : Humidifier.Base.BaseSubResource, IHaveQAppsControlMode
        {
            /// <summary>
            /// QAppsControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-qappsconfiguration.html#cfn-qbusiness-application-qappsconfiguration-qappscontrolmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QAppsControlMode { get; set; }
        }

        public class QuickSightConfiguration : Humidifier.Base.BaseSubResource, IHaveClientNamespace
        {
            /// <summary>
            /// ClientNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-quicksightconfiguration.html#cfn-qbusiness-application-quicksightconfiguration-clientnamespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientNamespace { get; set; }
        }
    }
}