namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;
    using ChannelNamespaceTypes;

    public class ChannelNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveApiId, IHaveCodeS3Location
    {
        public class Attributes
        {
            public static string ChannelNamespaceArn =  "ChannelNamespaceArn" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.ChannelNamespace; }
        /// <summary>
        /// SubscribeAuthModes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-subscribeauthmodes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AuthMode
        /// </summary>
        public List<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> SubscribeAuthModes { get; set; }
        /// <summary>
        /// CodeS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-codes3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CodeS3Location { get; set; }
        /// <summary>
        /// PublishAuthModes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-publishauthmodes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AuthMode
        /// </summary>
        public List<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode> PublishAuthModes { get; set; }
        /// <summary>
        /// CodeHandlers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-codehandlers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CodeHandlers { get; set; }
        /// <summary>
        /// HandlerConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-handlerconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HandlerConfigs
        /// </summary>
        public Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs HandlerConfigs { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApiId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ChannelNamespaceTypes
    {
        public class AuthMode : Humidifier.Base.BaseSubResource, IHaveAuthType
        {
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-authmode.html#cfn-appsync-channelnamespace-authmode-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
        }

        public class HandlerConfig : Humidifier.Base.BaseSubResource, IHaveBehavior
        {
            /// <summary>
            /// Integration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfig.html#cfn-appsync-channelnamespace-handlerconfig-integration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Integration
            /// </summary>
            public Humidifier.AppSync.ChannelNamespaceTypes.Integration Integration { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfig.html#cfn-appsync-channelnamespace-handlerconfig-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Behavior { get; set; }
        }

        public class HandlerConfigs : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OnPublish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfigs.html#cfn-appsync-channelnamespace-handlerconfigs-onpublish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HandlerConfig
            /// </summary>
            public Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig OnPublish { get; set; }
            /// <summary>
            /// OnSubscribe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfigs.html#cfn-appsync-channelnamespace-handlerconfigs-onsubscribe
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HandlerConfig
            /// </summary>
            public Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig OnSubscribe { get; set; }
        }

        public class Integration : Humidifier.Base.BaseSubResource, IHaveDataSourceName
        {
            /// <summary>
            /// DataSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-integration.html#cfn-appsync-channelnamespace-integration-datasourcename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceName { get; set; }
            /// <summary>
            /// LambdaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-integration.html#cfn-appsync-channelnamespace-integration-lambdaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaConfig
            /// </summary>
            public Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig LambdaConfig { get; set; }
        }

        public class LambdaConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InvokeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-lambdaconfig.html#cfn-appsync-channelnamespace-lambdaconfig-invoketype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvokeType { get; set; }
        }
    }
}