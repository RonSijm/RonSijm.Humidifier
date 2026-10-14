namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using AdConfigurationTypes;

    public class AdConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.AdConfiguration; }
        /// <summary>
        /// PostRollConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-adconfiguration.html#cfn-ivs-adconfiguration-postrollconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PostRollConfiguration
        /// </summary>
        public Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration PostRollConfiguration { get; set; }

        /// <summary>
        /// MediaTailorPlaybackConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-adconfiguration.html#cfn-ivs-adconfiguration-mediatailorplaybackconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaTailorPlaybackConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> MediaTailorPlaybackConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-adconfiguration.html#cfn-ivs-adconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AdConfigurationTypes
    {
        public class MediaTailorPlaybackConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PlaybackConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-adconfiguration-mediatailorplaybackconfiguration.html#cfn-ivs-adconfiguration-mediatailorplaybackconfiguration-playbackconfigurationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlaybackConfigurationArn { get; set; }
        }

        public class PostRollConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveDurationSeconds
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-adconfiguration-postrollconfiguration.html#cfn-ivs-adconfiguration-postrollconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// DurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-adconfiguration-postrollconfiguration.html#cfn-ivs-adconfiguration-postrollconfiguration-durationseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationSeconds { get; set; }
        }
    }
}