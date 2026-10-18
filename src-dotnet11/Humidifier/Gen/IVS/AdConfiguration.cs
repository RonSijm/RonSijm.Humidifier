namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using AdConfigurationTypes;

    public class AdConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIVSAdConfigurationTypesPostRollConfigurationPostRollConfiguration, IHaveListOfIVSAdConfigurationTypesMediaTailorPlaybackConfigurationMediaTailorPlaybackConfigurations, IHaveName
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
        public Union<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration, BaseFunction>? PostRollConfiguration { get; set; }

        /// <summary>
        /// MediaTailorPlaybackConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-adconfiguration.html#cfn-ivs-adconfiguration-mediatailorplaybackconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaTailorPlaybackConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration>, IReadOnlyList<Union<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration, BaseFunction>>, BaseFunction>? MediaTailorPlaybackConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-adconfiguration.html#cfn-ivs-adconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AdConfigurationTypes
    {
        public class MediaTailorPlaybackConfiguration : Humidifier.Base.BaseSubResource, IHavePlaybackConfigurationArn
        {
            /// <summary>
            /// PlaybackConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-adconfiguration-mediatailorplaybackconfiguration.html#cfn-ivs-adconfiguration-mediatailorplaybackconfiguration-playbackconfigurationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlaybackConfigurationArn { get; set; }
        }

        public class PostRollConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveDurationSeconds_Integer
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-adconfiguration-postrollconfiguration.html#cfn-ivs-adconfiguration-postrollconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// DurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-adconfiguration-postrollconfiguration.html#cfn-ivs-adconfiguration-postrollconfiguration-durationseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationSeconds { get; set; }
        }
    }
}