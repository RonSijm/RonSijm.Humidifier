namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
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
        /// InsertionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-insertionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InsertionMode { get; set; }
        /// <summary>
        /// ManifestProcessingRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-manifestprocessingrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManifestProcessingRules
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules ManifestProcessingRules { get; set; }
        /// <summary>
        /// CdnConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdnConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration CdnConfiguration { get; set; }
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
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// VideoContentSourceUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-videocontentsourceurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VideoContentSourceUrl { get; set; }
        /// <summary>
        /// AdsPersonalizationConcurrency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-adspersonalizationconcurrency
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdsPersonalizationConcurrency
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency AdsPersonalizationConcurrency { get; set; }
        /// <summary>
        /// AdDecisionServerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdDecisionServerConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.AdDecisionServerConfiguration AdDecisionServerConfiguration { get; set; }
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
        /// FunctionMapping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-functionmapping
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> FunctionMapping { get; set; }
        /// <summary>
        /// AdConditioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-adconditioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdConditioningConfiguration
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration AdConditioningConfiguration { get; set; }
        /// <summary>
        /// AdsPersonalizationTimeouts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdsPersonalizationTimeouts
        /// </summary>
        public Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts AdsPersonalizationTimeouts { get; set; }
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
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace PlaybackConfigurationTypes
    {
        public class AdConditioningConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StreamingMediaFileConditioning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adconditioningconfiguration.html#cfn-mediatailor-playbackconfiguration-adconditioningconfiguration-streamingmediafileconditioning
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamingMediaFileConditioning { get; set; }
        }

        public class AdDecisionServerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HttpRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-addecisionserverconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverconfiguration-httprequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRequest
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest HttpRequest { get; set; }
            /// <summary>
            /// VastResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-addecisionserverconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverconfiguration-vastresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VastResponse
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse VastResponse { get; set; }
        }

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

        public class AdsInteractionLog : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExcludeEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adsinteractionlog.html#cfn-mediatailor-playbackconfiguration-adsinteractionlog-excludeeventtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeEventTypes { get; set; }
            /// <summary>
            /// PublishOptInEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adsinteractionlog.html#cfn-mediatailor-playbackconfiguration-adsinteractionlog-publishoptineventtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PublishOptInEventTypes { get; set; }
        }

        public class AdsPersonalizationConcurrency : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxConcurrentAdsRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationconcurrency.html#cfn-mediatailor-playbackconfiguration-adspersonalizationconcurrency-maxconcurrentadsrequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrentAdsRequests { get; set; }
            /// <summary>
            /// EnableVodVastParallelization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationconcurrency.html#cfn-mediatailor-playbackconfiguration-adspersonalizationconcurrency-enablevodvastparallelization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableVodVastParallelization { get; set; }
        }

        public class AdsPersonalizationTimeouts : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrefetchAdsRequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-prefetchadsrequesttimeoutmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PrefetchAdsRequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// VodMaximumAdsPersonalizationTimeMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-vodmaximumadspersonalizationtimemilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VodMaximumAdsPersonalizationTimeMilliseconds { get; set; }
            /// <summary>
            /// PrefetchMaximumAdsPersonalizationTimeMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-prefetchmaximumadspersonalizationtimemilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PrefetchMaximumAdsPersonalizationTimeMilliseconds { get; set; }
            /// <summary>
            /// AdsRequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-adsrequesttimeoutmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AdsRequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// LiveMaximumAdsPersonalizationTimeMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-livemaximumadspersonalizationtimemilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LiveMaximumAdsPersonalizationTimeMilliseconds { get; set; }
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

        public class HttpRequest : Humidifier.Base.BaseSubResource, IHaveBody, IHaveHttpMethod
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Headers { get; set; }
            /// <summary>
            /// CompressRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-compressrequest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressRequest { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpMethod { get; set; }
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
            /// <summary>
            /// AdDecisionServerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-liveprerollconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration-addecisionserverconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreRollAdDecisionServerConfiguration
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration AdDecisionServerConfiguration { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnabledLoggingStrategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-enabledloggingstrategies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EnabledLoggingStrategies { get; set; }
            /// <summary>
            /// PercentEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-percentenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PercentEnabled { get; set; }
            /// <summary>
            /// AdsInteractionLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-adsinteractionlog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdsInteractionLog
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog AdsInteractionLog { get; set; }
            /// <summary>
            /// ManifestServiceInteractionLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-manifestserviceinteractionlog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManifestServiceInteractionLog
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog ManifestServiceInteractionLog { get; set; }
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

        public class ManifestServiceInteractionLog : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExcludeEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-manifestserviceinteractionlog.html#cfn-mediatailor-playbackconfiguration-manifestserviceinteractionlog-excludeeventtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludeEventTypes { get; set; }
        }

        public class PreRollAdDecisionServerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VastResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-prerolladdecisionserverconfiguration.html#cfn-mediatailor-playbackconfiguration-prerolladdecisionserverconfiguration-vastresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreRollVastResponse
            /// </summary>
            public Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse VastResponse { get; set; }
        }

        public class PreRollVastResponse : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdSequencingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-prerollvastresponse.html#cfn-mediatailor-playbackconfiguration-prerollvastresponse-adsequencingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdSequencingMode { get; set; }
        }

        public class VastResponse : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdSequencingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-vastresponse.html#cfn-mediatailor-playbackconfiguration-vastresponse-adsequencingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdSequencingMode { get; set; }
        }
    }
}