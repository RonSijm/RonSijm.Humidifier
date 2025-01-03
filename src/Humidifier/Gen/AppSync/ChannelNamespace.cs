namespace Humidifier.AppSync
{
    using System.Collections.Generic;
    using ChannelNamespaceTypes;

    public class ChannelNamespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveApiId
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
        public List<Tag> Tags { get; set; }
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
    }
}