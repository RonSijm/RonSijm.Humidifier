namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveMode, IHaveChannelId, IHaveMetadata
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string LastUpdatedTimestamp =  "LastUpdatedTimestamp" ;
            public static string ChannelFlowArn =  "ChannelFlowArn" ;
            public static string LastMessageTimestamp =  "LastMessageTimestamp" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.Channel; }
        /// <summary>
        /// Privacy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-privacy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Privacy { get; set; }
        /// <summary>
        /// ElasticChannelConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-elasticchannelconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ElasticChannelConfiguration
        /// </summary>
        public Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration ElasticChannelConfiguration { get; set; }
        /// <summary>
        /// ExpirationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-expirationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpirationSettings
        /// </summary>
        public Humidifier.Chime.ChannelTypes.ExpirationSettings ExpirationSettings { get; set; }
        /// <summary>
        /// ModeratorArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-moderatorarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ModeratorArns { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-mode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Mode { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Metadata { get; set; }
        /// <summary>
        /// MemberArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-memberarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic MemberArns { get; set; }

        /// <summary>
        /// ChimeBearer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-chimebearer
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChimeBearer { get; set; }
        /// <summary>
        /// ChannelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-channelid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ChannelId { get; set; }

        /// <summary>
        /// AppInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-appinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppInstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-channel.html#cfn-chime-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ChannelTypes
    {
        public class ElasticChannelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumMembershipPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-elasticchannelconfiguration.html#cfn-chime-channel-elasticchannelconfiguration-minimummembershippercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumMembershipPercentage { get; set; }
            /// <summary>
            /// MaximumSubChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-elasticchannelconfiguration.html#cfn-chime-channel-elasticchannelconfiguration-maximumsubchannels
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumSubChannels { get; set; }
            /// <summary>
            /// TargetMembershipsPerSubChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-elasticchannelconfiguration.html#cfn-chime-channel-elasticchannelconfiguration-targetmembershipspersubchannel
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetMembershipsPerSubChannel { get; set; }
        }

        public class ExpirationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExpirationCriterion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-expirationsettings.html#cfn-chime-channel-expirationsettings-expirationcriterion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpirationCriterion { get; set; }
            /// <summary>
            /// ExpirationDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-expirationsettings.html#cfn-chime-channel-expirationsettings-expirationdays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpirationDays { get; set; }
        }

        public class Identity : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-identity.html#cfn-chime-channel-identity-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-channel-identity.html#cfn-chime-channel-identity-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}