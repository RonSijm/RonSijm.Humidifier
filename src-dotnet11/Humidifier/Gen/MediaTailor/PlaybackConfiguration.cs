namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using PlaybackConfigurationTypes;

    public class PlaybackConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaTailorPlaybackConfigurationTypesBumperBumper, IHaveMediaTailorPlaybackConfigurationTypesDashConfigurationDashConfiguration, IHaveInsertionMode, IHaveMediaTailorPlaybackConfigurationTypesManifestProcessingRulesManifestProcessingRules, IHaveMediaTailorPlaybackConfigurationTypesCdnConfigurationCdnConfiguration, IHavePersonalizationThresholdSeconds_Integer, IHaveMediaTailorPlaybackConfigurationTypesLivePreRollConfigurationLivePreRollConfiguration, IHaveMediaTailorPlaybackConfigurationTypesHlsConfigurationHlsConfiguration, IHaveMediaTailorPlaybackConfigurationTypesLogConfigurationLogConfiguration, IHaveVideoContentSourceUrl, IHaveMediaTailorPlaybackConfigurationTypesAdsPersonalizationConcurrencyAdsPersonalizationConcurrency, IHaveMediaTailorPlaybackConfigurationTypesAdDecisionServerConfigurationAdDecisionServerConfiguration, IHaveName, IHaveTranscodeProfileName, IHaveJsonDictionaryOfConfigurationAliases, IHaveAdDecisionServerUrl, IHaveStringDictionaryOfFunctionMapping, IHaveMediaTailorPlaybackConfigurationTypesAdConditioningConfigurationAdConditioningConfiguration, IHaveMediaTailorPlaybackConfigurationTypesAdsPersonalizationTimeoutsAdsPersonalizationTimeouts, IHaveSlateAdUrl, IHaveMediaTailorPlaybackConfigurationTypesAvailSuppressionAvailSuppression
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
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.Bumper, BaseFunction>? Bumper { get; set; }
        /// <summary>
        /// DashConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DashConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.DashConfiguration, BaseFunction>? DashConfiguration { get; set; }
        /// <summary>
        /// InsertionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-insertionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InsertionMode { get; set; }
        /// <summary>
        /// ManifestProcessingRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-manifestprocessingrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManifestProcessingRules
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules, BaseFunction>? ManifestProcessingRules { get; set; }
        /// <summary>
        /// CdnConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CdnConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration, BaseFunction>? CdnConfiguration { get; set; }
        /// <summary>
        /// PersonalizationThresholdSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-personalizationthresholdseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? PersonalizationThresholdSeconds { get; set; }
        /// <summary>
        /// LivePreRollConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LivePreRollConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration, BaseFunction>? LivePreRollConfiguration { get; set; }
        /// <summary>
        /// HlsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-hlsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HlsConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration, BaseFunction>? HlsConfiguration { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }

        /// <summary>
        /// VideoContentSourceUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-videocontentsourceurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VideoContentSourceUrl { get; set; }
        /// <summary>
        /// AdsPersonalizationConcurrency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-adspersonalizationconcurrency
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdsPersonalizationConcurrency
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency, BaseFunction>? AdsPersonalizationConcurrency { get; set; }
        /// <summary>
        /// AdDecisionServerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdDecisionServerConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdDecisionServerConfiguration, BaseFunction>? AdDecisionServerConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TranscodeProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-transcodeprofilename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TranscodeProfileName { get; set; }
        /// <summary>
        /// ConfigurationAliases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-configurationaliases
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: Json
        /// </summary>
        public Union<IReadOnlyDictionary<string, object>, IReadOnlyDictionary<string, Union<object, BaseFunction>>, BaseFunction>? ConfigurationAliases { get; set; }

        /// <summary>
        /// AdDecisionServerUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverurl
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AdDecisionServerUrl { get; set; }
        /// <summary>
        /// FunctionMapping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-functionmapping
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? FunctionMapping { get; set; }
        /// <summary>
        /// AdConditioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-adconditioningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdConditioningConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration, BaseFunction>? AdConditioningConfiguration { get; set; }
        /// <summary>
        /// AdsPersonalizationTimeouts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdsPersonalizationTimeouts
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts, BaseFunction>? AdsPersonalizationTimeouts { get; set; }
        /// <summary>
        /// SlateAdUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-slateadurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SlateAdUrl { get; set; }
        /// <summary>
        /// AvailSuppression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-availsuppression
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailSuppression
        /// </summary>
        public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression, BaseFunction>? AvailSuppression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-playbackconfiguration.html#cfn-mediatailor-playbackconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PlaybackConfigurationTypes
    {
        public class AdConditioningConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamingMediaFileConditioning
        {
            /// <summary>
            /// StreamingMediaFileConditioning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adconditioningconfiguration.html#cfn-mediatailor-playbackconfiguration-adconditioningconfiguration-streamingmediafileconditioning
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamingMediaFileConditioning { get; set; }
        }

        public class AdDecisionServerConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaTailorPlaybackConfigurationTypesHttpRequestHttpRequest, IHaveMediaTailorPlaybackConfigurationTypesVastResponseVastResponse
        {
            /// <summary>
            /// HttpRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-addecisionserverconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverconfiguration-httprequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRequest
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.HttpRequest, BaseFunction>? HttpRequest { get; set; }
            /// <summary>
            /// VastResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-addecisionserverconfiguration.html#cfn-mediatailor-playbackconfiguration-addecisionserverconfiguration-vastresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VastResponse
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.VastResponse, BaseFunction>? VastResponse { get; set; }
        }

        public class AdMarkerPassthrough : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-admarkerpassthrough.html#cfn-mediatailor-playbackconfiguration-admarkerpassthrough-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class AdsInteractionLog : Humidifier.Base.BaseSubResource, IHaveStringListOfExcludeEventTypes, IHaveStringListOfPublishOptInEventTypes
        {
            /// <summary>
            /// ExcludeEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adsinteractionlog.html#cfn-mediatailor-playbackconfiguration-adsinteractionlog-excludeeventtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludeEventTypes { get; set; }
            /// <summary>
            /// PublishOptInEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adsinteractionlog.html#cfn-mediatailor-playbackconfiguration-adsinteractionlog-publishoptineventtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PublishOptInEventTypes { get; set; }
        }

        public class AdsPersonalizationConcurrency : Humidifier.Base.BaseSubResource, IHaveMaxConcurrentAdsRequests_Integer, IHaveEnableVodVastParallelization_Boolean
        {
            /// <summary>
            /// MaxConcurrentAdsRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationconcurrency.html#cfn-mediatailor-playbackconfiguration-adspersonalizationconcurrency-maxconcurrentadsrequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrentAdsRequests { get; set; }
            /// <summary>
            /// EnableVodVastParallelization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationconcurrency.html#cfn-mediatailor-playbackconfiguration-adspersonalizationconcurrency-enablevodvastparallelization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableVodVastParallelization { get; set; }
        }

        public class AdsPersonalizationTimeouts : Humidifier.Base.BaseSubResource, IHavePrefetchAdsRequestTimeoutMilliseconds_Integer, IHaveVodMaximumAdsPersonalizationTimeMilliseconds_Integer, IHavePrefetchMaximumAdsPersonalizationTimeMilliseconds_Integer, IHaveAdsRequestTimeoutMilliseconds_Integer, IHaveLiveMaximumAdsPersonalizationTimeMilliseconds_Integer
        {
            /// <summary>
            /// PrefetchAdsRequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-prefetchadsrequesttimeoutmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PrefetchAdsRequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// VodMaximumAdsPersonalizationTimeMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-vodmaximumadspersonalizationtimemilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VodMaximumAdsPersonalizationTimeMilliseconds { get; set; }
            /// <summary>
            /// PrefetchMaximumAdsPersonalizationTimeMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-prefetchmaximumadspersonalizationtimemilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PrefetchMaximumAdsPersonalizationTimeMilliseconds { get; set; }
            /// <summary>
            /// AdsRequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-adsrequesttimeoutmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AdsRequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// LiveMaximumAdsPersonalizationTimeMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-adspersonalizationtimeouts.html#cfn-mediatailor-playbackconfiguration-adspersonalizationtimeouts-livemaximumadspersonalizationtimemilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LiveMaximumAdsPersonalizationTimeMilliseconds { get; set; }
        }

        public class AvailSuppression : Humidifier.Base.BaseSubResource, IHaveMode, IHaveValue, IHaveFillPolicy
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-availsuppression.html#cfn-mediatailor-playbackconfiguration-availsuppression-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-availsuppression.html#cfn-mediatailor-playbackconfiguration-availsuppression-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// FillPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-availsuppression.html#cfn-mediatailor-playbackconfiguration-availsuppression-fillpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FillPolicy { get; set; }
        }

        public class Bumper : Humidifier.Base.BaseSubResource, IHaveStartUrl, IHaveEndUrl
        {
            /// <summary>
            /// StartUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-bumper.html#cfn-mediatailor-playbackconfiguration-bumper-starturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartUrl { get; set; }
            /// <summary>
            /// EndUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-bumper.html#cfn-mediatailor-playbackconfiguration-bumper-endurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndUrl { get; set; }
        }

        public class CdnConfiguration : Humidifier.Base.BaseSubResource, IHaveAdSegmentUrlPrefix, IHaveContentSegmentUrlPrefix
        {
            /// <summary>
            /// AdSegmentUrlPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-cdnconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration-adsegmenturlprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdSegmentUrlPrefix { get; set; }
            /// <summary>
            /// ContentSegmentUrlPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-cdnconfiguration.html#cfn-mediatailor-playbackconfiguration-cdnconfiguration-contentsegmenturlprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentSegmentUrlPrefix { get; set; }
        }

        public class DashConfiguration : Humidifier.Base.BaseSubResource, IHaveMpdLocation, IHaveManifestEndpointPrefix, IHaveOriginManifestType
        {
            /// <summary>
            /// MpdLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-dashconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration-mpdlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MpdLocation { get; set; }
            /// <summary>
            /// ManifestEndpointPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-dashconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration-manifestendpointprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestEndpointPrefix { get; set; }
            /// <summary>
            /// OriginManifestType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-dashconfiguration.html#cfn-mediatailor-playbackconfiguration-dashconfiguration-originmanifesttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginManifestType { get; set; }
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
            public Union<string, BaseFunction>? ManifestEndpointPrefix { get; set; }
        }

        public class HttpRequest : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfHeaders, IHaveCompressRequest, IHaveBody, IHaveHttpMethod
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// CompressRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-compressrequest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressRequest { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-httprequest.html#cfn-mediatailor-playbackconfiguration-httprequest-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpMethod { get; set; }
        }

        public class LivePreRollConfiguration : Humidifier.Base.BaseSubResource, IHaveAdDecisionServerUrl, IHaveMaxDurationSeconds_Integer, IHaveMediaTailorPlaybackConfigurationTypesPreRollAdDecisionServerConfigurationAdDecisionServerConfiguration
        {
            /// <summary>
            /// AdDecisionServerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-liveprerollconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration-addecisionserverurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdDecisionServerUrl { get; set; }
            /// <summary>
            /// MaxDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-liveprerollconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration-maxdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxDurationSeconds { get; set; }
            /// <summary>
            /// AdDecisionServerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-liveprerollconfiguration.html#cfn-mediatailor-playbackconfiguration-liveprerollconfiguration-addecisionserverconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreRollAdDecisionServerConfiguration
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration, BaseFunction>? AdDecisionServerConfiguration { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfEnabledLoggingStrategies, IHavePercentEnabled_Integer, IHaveMediaTailorPlaybackConfigurationTypesAdsInteractionLogAdsInteractionLog, IHaveMediaTailorPlaybackConfigurationTypesManifestServiceInteractionLogManifestServiceInteractionLog
        {
            /// <summary>
            /// EnabledLoggingStrategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-enabledloggingstrategies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledLoggingStrategies { get; set; }
            /// <summary>
            /// PercentEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-percentenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PercentEnabled { get; set; }
            /// <summary>
            /// AdsInteractionLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-adsinteractionlog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdsInteractionLog
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog, BaseFunction>? AdsInteractionLog { get; set; }
            /// <summary>
            /// ManifestServiceInteractionLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-logconfiguration.html#cfn-mediatailor-playbackconfiguration-logconfiguration-manifestserviceinteractionlog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManifestServiceInteractionLog
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog, BaseFunction>? ManifestServiceInteractionLog { get; set; }
        }

        public class ManifestProcessingRules : Humidifier.Base.BaseSubResource, IHaveMediaTailorPlaybackConfigurationTypesAdMarkerPassthroughAdMarkerPassthrough
        {
            /// <summary>
            /// AdMarkerPassthrough
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-manifestprocessingrules.html#cfn-mediatailor-playbackconfiguration-manifestprocessingrules-admarkerpassthrough
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdMarkerPassthrough
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough, BaseFunction>? AdMarkerPassthrough { get; set; }
        }

        public class ManifestServiceInteractionLog : Humidifier.Base.BaseSubResource, IHaveStringListOfExcludeEventTypes
        {
            /// <summary>
            /// ExcludeEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-manifestserviceinteractionlog.html#cfn-mediatailor-playbackconfiguration-manifestserviceinteractionlog-excludeeventtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludeEventTypes { get; set; }
        }

        public class PreRollAdDecisionServerConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaTailorPlaybackConfigurationTypesPreRollVastResponseVastResponse
        {
            /// <summary>
            /// VastResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-prerolladdecisionserverconfiguration.html#cfn-mediatailor-playbackconfiguration-prerolladdecisionserverconfiguration-vastresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreRollVastResponse
            /// </summary>
            public Union<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse, BaseFunction>? VastResponse { get; set; }
        }

        public class PreRollVastResponse : Humidifier.Base.BaseSubResource, IHaveAdSequencingMode
        {
            /// <summary>
            /// AdSequencingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-prerollvastresponse.html#cfn-mediatailor-playbackconfiguration-prerollvastresponse-adsequencingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdSequencingMode { get; set; }
        }

        public class VastResponse : Humidifier.Base.BaseSubResource, IHaveAdSequencingMode
        {
            /// <summary>
            /// AdSequencingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-playbackconfiguration-vastresponse.html#cfn-mediatailor-playbackconfiguration-vastresponse-adsequencingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdSequencingMode { get; set; }
        }
    }
}