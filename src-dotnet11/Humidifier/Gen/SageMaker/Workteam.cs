namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using WorkteamTypes;

    public class Workteam : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveSageMakerWorkteamTypesNotificationConfigurationNotificationConfiguration, IHaveWorkteamName, IHaveListOfSageMakerWorkteamTypesMemberDefinitionMemberDefinitions, IHaveWorkforceName
    {
        public class Attributes
        {
            public static string WorkteamArn =  "WorkteamArn" ;
            public static string WorkteamName =  "WorkteamName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Workteam; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-notificationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        public Union<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration, BaseFunction>? NotificationConfiguration { get; set; }
        public Union<string, BaseFunction>? WorkteamName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// MemberDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-memberdefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MemberDefinition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SageMaker.WorkteamTypes.MemberDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.WorkteamTypes.MemberDefinition, BaseFunction>>, BaseFunction>? MemberDefinitions { get; set; }
        /// <summary>
        /// WorkforceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-workforcename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkforceName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkteamTypes
    {
        public class CognitoMemberDefinition : Humidifier.Base.BaseSubResource, IHaveCognitoUserPool, IHaveCognitoClientId, IHaveCognitoUserGroup
        {
            /// <summary>
            /// CognitoUserPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitouserpool
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CognitoUserPool { get; set; }
            /// <summary>
            /// CognitoClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitoclientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CognitoClientId { get; set; }
            /// <summary>
            /// CognitoUserGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitousergroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CognitoUserGroup { get; set; }
        }

        public class MemberDefinition : Humidifier.Base.BaseSubResource, IHaveSageMakerWorkteamTypesOidcMemberDefinitionOidcMemberDefinition, IHaveSageMakerWorkteamTypesCognitoMemberDefinitionCognitoMemberDefinition
        {
            /// <summary>
            /// OidcMemberDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-memberdefinition.html#cfn-sagemaker-workteam-memberdefinition-oidcmemberdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OidcMemberDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition, BaseFunction>? OidcMemberDefinition { get; set; }
            /// <summary>
            /// CognitoMemberDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-memberdefinition.html#cfn-sagemaker-workteam-memberdefinition-cognitomemberdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoMemberDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition, BaseFunction>? CognitoMemberDefinition { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveNotificationTopicArn
        {
            /// <summary>
            /// NotificationTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-notificationconfiguration.html#cfn-sagemaker-workteam-notificationconfiguration-notificationtopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationTopicArn { get; set; }
        }

        public class OidcMemberDefinition : Humidifier.Base.BaseSubResource, IHaveStringListOfOidcGroups
        {
            /// <summary>
            /// OidcGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-oidcmemberdefinition.html#cfn-sagemaker-workteam-oidcmemberdefinition-oidcgroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OidcGroups { get; set; }
        }
    }
}