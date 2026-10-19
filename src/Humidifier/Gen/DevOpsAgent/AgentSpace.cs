namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using AgentSpaceTypes;

    public class AgentSpace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveLocale
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string AgentSpaceId =  "AgentSpaceId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsAgent.AgentSpace; }
        /// <summary>
        /// Locale
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-agentspace.html#cfn-devopsagent-agentspace-locale
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Locale { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-agentspace.html#cfn-devopsagent-agentspace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-agentspace.html#cfn-devopsagent-agentspace-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        /// <summary>
        /// OperatorApp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-agentspace.html#cfn-devopsagent-agentspace-operatorapp
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OperatorApp
        /// </summary>
        public Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp OperatorApp { get; set; }
        /// <summary>
        /// Preferences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-agentspace.html#cfn-devopsagent-agentspace-preferences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Preferences
        /// </summary>
        public Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences Preferences { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-agentspace.html#cfn-devopsagent-agentspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AgentSpaceTypes
    {
        public class IamAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveCreatedAt
        {
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-iamauthconfiguration.html#cfn-devopsagent-agentspace-iamauthconfiguration-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// OperatorAppRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-iamauthconfiguration.html#cfn-devopsagent-agentspace-iamauthconfiguration-operatorapprolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OperatorAppRoleArn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-iamauthconfiguration.html#cfn-devopsagent-agentspace-iamauthconfiguration-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class IdcAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveCreatedAt
        {
            /// <summary>
            /// IdcApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idcauthconfiguration.html#cfn-devopsagent-agentspace-idcauthconfiguration-idcapplicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdcApplicationArn { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idcauthconfiguration.html#cfn-devopsagent-agentspace-idcauthconfiguration-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// OperatorAppRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idcauthconfiguration.html#cfn-devopsagent-agentspace-idcauthconfiguration-operatorapprolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OperatorAppRoleArn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idcauthconfiguration.html#cfn-devopsagent-agentspace-idcauthconfiguration-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// IdcInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idcauthconfiguration.html#cfn-devopsagent-agentspace-idcauthconfiguration-idcinstancearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdcInstanceArn { get; set; }
        }

        public class IdpAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret, IHaveProvider, IHaveCreatedAt
        {
            /// <summary>
            /// IssuerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-issuerurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IssuerUrl { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// UserIdClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-useridclaim
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserIdClaim { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// OperatorAppRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-operatorapprolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OperatorAppRoleArn { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-idpauthconfiguration.html#cfn-devopsagent-agentspace-idpauthconfiguration-provider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Provider { get; set; }
        }

        public class OperatorApp : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-operatorapp.html#cfn-devopsagent-agentspace-operatorapp-iam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamAuthConfiguration
            /// </summary>
            public Humidifier.DevOpsAgent.AgentSpaceTypes.IamAuthConfiguration Iam { get; set; }
            /// <summary>
            /// Idp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-operatorapp.html#cfn-devopsagent-agentspace-operatorapp-idp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdpAuthConfiguration
            /// </summary>
            public Humidifier.DevOpsAgent.AgentSpaceTypes.IdpAuthConfiguration Idp { get; set; }
            /// <summary>
            /// Idc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-operatorapp.html#cfn-devopsagent-agentspace-operatorapp-idc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdcAuthConfiguration
            /// </summary>
            public Humidifier.DevOpsAgent.AgentSpaceTypes.IdcAuthConfiguration Idc { get; set; }
        }

        public class Preferences : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ElevatedActionsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-agentspace-preferences.html#cfn-devopsagent-agentspace-preferences-elevatedactionsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ElevatedActionsEnabled { get; set; }
        }
    }
}