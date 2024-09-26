namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using WorkteamTypes;

    public class Workteam : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string WorkteamName =  "WorkteamName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Workteam; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-notificationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        public Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration NotificationConfiguration { get; set; }
        public dynamic WorkteamName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MemberDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-memberdefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MemberDefinition
        /// </summary>
        public List<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> MemberDefinitions { get; set; }
        /// <summary>
        /// WorkforceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-workforcename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkforceName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html#cfn-sagemaker-workteam-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace WorkteamTypes
    {
        public class CognitoMemberDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CognitoUserPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitouserpool
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CognitoUserPool { get; set; }
            /// <summary>
            /// CognitoClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitoclientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CognitoClientId { get; set; }
            /// <summary>
            /// CognitoUserGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitousergroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CognitoUserGroup { get; set; }
        }

        public class MemberDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OidcMemberDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-memberdefinition.html#cfn-sagemaker-workteam-memberdefinition-oidcmemberdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OidcMemberDefinition
            /// </summary>
            public Humidifier.SageMaker.WorkteamTypes.OidcMemberDefinition OidcMemberDefinition { get; set; }
            /// <summary>
            /// CognitoMemberDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-memberdefinition.html#cfn-sagemaker-workteam-memberdefinition-cognitomemberdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoMemberDefinition
            /// </summary>
            public Humidifier.SageMaker.WorkteamTypes.CognitoMemberDefinition CognitoMemberDefinition { get; set; }
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
            public dynamic NotificationTopicArn { get; set; }
        }

        public class OidcMemberDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OidcGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-oidcmemberdefinition.html#cfn-sagemaker-workteam-oidcmemberdefinition-oidcgroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OidcGroups { get; set; }
        }
    }
}