namespace Humidifier.MediaTailor
{
    using System.Collections.Generic;
    using PlaybackConfigurationTypes;

    public class PlaybackConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAdDecisionServerUrl
    {
        public class Attributes
        {
            public static string SessionInitializationEndpointPrefix =  "SessionInitializationEndpointPrefix" ;
            public static string PlaybackConfigurationArn =  "PlaybackConfigurationArn" ;
            public static string PlaybackEndpointPrefix =  "PlaybackEndpointPrefix" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.PlaybackConfiguration; }
        /// <summary>
        /// Bumper
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-bumper
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Bumper
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper Bumper { get; set; }
        /// <summary>
        /// DashConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration DashConfiguration { get; set; }
        /// <summary>
        /// CdnConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdnConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration CdnConfiguration { get; set; }
        /// <summary>
        /// ManifestProcessingRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-manifestprocessingrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManifestProcessingRules
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules ManifestProcessingRules { get; set; }
        /// <summary>
        /// PersonalizationThresholdSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-personalizationthresholdseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic PersonalizationThresholdSeconds { get; set; }
        /// <summary>
        /// LivePreRollConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LivePreRollConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration LivePreRollConfiguration { get; set; }
        /// <summary>
        /// HlsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-hlsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HlsConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration HlsConfiguration { get; set; }

        /// <summary>
        /// VideoContentSourceUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-videocontentsourceurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VideoContentSourceUrl { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TranscodeProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-transcodeprofilename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TranscodeProfileName { get; set; }
        /// <summary>
        /// ConfigurationAliases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-configurationaliases
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: Json
        /// </summary>
        public dynamic ConfigurationAliases { get; set; }

        /// <summary>
        /// AdDecisionServerUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AdDecisionServerUrl { get; set; }
        /// <summary>
        /// SlateAdUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-slateadurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SlateAdUrl { get; set; }
        /// <summary>
        /// AvailSuppression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-availsuppression
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailSuppression
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression AvailSuppression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace PlaybackConfigurationTypes
    {
        public class AdMarkerPassthrough : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-admarkerpassthrough.html#cfn-mediatailor-playbackconfiguration-admarkerpassthrough-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class AvailSuppression : Humidifier.Base.BaseSubResource, IHaveValue, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-availsuppression.html#cfn-mediatailor-playbackconfiguration-availsuppression-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-availsuppression.html#cfn-mediatailor-playbackconfiguration-availsuppression-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// FillPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-availsuppression.html#cfn-mediatailor-playbackconfiguration-availsuppression-fillpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FillPolicy { get; set; }
        }

        public class Bumper : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StartUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-bumper.html#cfn-mediatailor-playbackconfiguration-bumper-starturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartUrl { get; set; }
            /// <summary>
            /// EndUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-bumper.html#cfn-mediatailor-playbackconfiguration-bumper-endurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndUrl { get; set; }
        }

        public class CdnConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdSegmentUrlPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-cdnconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration-adsegmenturlprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdSegmentUrlPrefix { get; set; }
            /// <summary>
            /// ContentSegmentUrlPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-cdnconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration-contentsegmenturlprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentSegmentUrlPrefix { get; set; }
        }

        public class DashConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestEndpointPrefix
        {
            /// <summary>
            /// MpdLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-dashconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration-mpdlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MpdLocation { get; set; }
            /// <summary>
            /// ManifestEndpointPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-dashconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration-manifestendpointprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestEndpointPrefix { get; set; }
            /// <summary>
            /// OriginManifestType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-dashconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration-originmanifesttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OriginManifestType { get; set; }
        }

        public class HlsConfiguration : Humidifier.Base.BaseSubResource, IHaveManifestEndpointPrefix
        {
            /// <summary>
            /// ManifestEndpointPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-hlsconfiguration.html#cfn-mediatailor-playbackconfiguration-hlsconfiguration-manifestendpointprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestEndpointPrefix { get; set; }
        }

        public class LivePreRollConfiguration : Humidifier.Base.BaseSubResource, IHaveAdDecisionServerUrl
        {
            /// <summary>
            /// AdDecisionServerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-liveprerollconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration-addecisionserverurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdDecisionServerUrl { get; set; }
            /// <summary>
            /// MaxDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-liveprerollconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration-maxdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxDurationSeconds { get; set; }
        }

        public class ManifestProcessingRules : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdMarkerPassthrough
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-manifestprocessingrules.html#cfn-mediatailor-playbackconfiguration-manifestprocessingrules-admarkerpassthrough
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdMarkerPassthrough
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough AdMarkerPassthrough { get; set; }
        }
    }
}