namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;
    using ChannelNamespaceTypes;

    public class ChannelNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfAppSyncChannelNamespaceTypesAuthModeSubscribeAuthModes, IHaveCodeS3Location, IHaveListOfAppSyncChannelNamespaceTypesAuthModePublishAuthModes, IHaveCodeHandlers, IHaveAppSyncChannelNamespaceTypesHandlerConfigsHandlerConfigs, IHaveApiId, IHaveName
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
        public Union<IReadOnlyList<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode>, IReadOnlyList<Union<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode, BaseFunction>>, BaseFunction>? SubscribeAuthModes { get; set; }
        /// <summary>
        /// CodeS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-codes3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CodeS3Location { get; set; }
        /// <summary>
        /// PublishAuthModes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-publishauthmodes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AuthMode
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode>, IReadOnlyList<Union<Humidifier.AppSync.ChannelNamespaceTypes.AuthMode, BaseFunction>>, BaseFunction>? PublishAuthModes { get; set; }
        /// <summary>
        /// CodeHandlers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-codehandlers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CodeHandlers { get; set; }
        /// <summary>
        /// HandlerConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-handlerconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HandlerConfigs
        /// </summary>
        public Union<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfigs, BaseFunction>? HandlerConfigs { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-channelnamespace.html#cfn-appsync-channelnamespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? AuthType { get; set; }
        }

        public class HandlerConfig : Humidifier.Base.BaseSubResource, IHaveAppSyncChannelNamespaceTypesIntegrationIntegration, IHaveBehavior
        {
            /// <summary>
            /// Integration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfig.html#cfn-appsync-channelnamespace-handlerconfig-integration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Integration
            /// </summary>
            public Union<Humidifier.AppSync.ChannelNamespaceTypes.Integration, BaseFunction>? Integration { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfig.html#cfn-appsync-channelnamespace-handlerconfig-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
        }

        public class HandlerConfigs : Humidifier.Base.BaseSubResource, IHaveAppSyncChannelNamespaceTypesHandlerConfigOnPublish, IHaveAppSyncChannelNamespaceTypesHandlerConfigOnSubscribe
        {
            /// <summary>
            /// OnPublish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfigs.html#cfn-appsync-channelnamespace-handlerconfigs-onpublish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HandlerConfig
            /// </summary>
            public Union<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig, BaseFunction>? OnPublish { get; set; }
            /// <summary>
            /// OnSubscribe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-handlerconfigs.html#cfn-appsync-channelnamespace-handlerconfigs-onsubscribe
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HandlerConfig
            /// </summary>
            public Union<Humidifier.AppSync.ChannelNamespaceTypes.HandlerConfig, BaseFunction>? OnSubscribe { get; set; }
        }

        public class Integration : Humidifier.Base.BaseSubResource, IHaveDataSourceName, IHaveAppSyncChannelNamespaceTypesLambdaConfigLambdaConfig
        {
            /// <summary>
            /// DataSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-integration.html#cfn-appsync-channelnamespace-integration-datasourcename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceName { get; set; }
            /// <summary>
            /// LambdaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-integration.html#cfn-appsync-channelnamespace-integration-lambdaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaConfig
            /// </summary>
            public Union<Humidifier.AppSync.ChannelNamespaceTypes.LambdaConfig, BaseFunction>? LambdaConfig { get; set; }
        }

        public class LambdaConfig : Humidifier.Base.BaseSubResource, IHaveInvokeType
        {
            /// <summary>
            /// InvokeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-channelnamespace-lambdaconfig.html#cfn-appsync-channelnamespace-lambdaconfig-invoketype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvokeType { get; set; }
        }
    }
}