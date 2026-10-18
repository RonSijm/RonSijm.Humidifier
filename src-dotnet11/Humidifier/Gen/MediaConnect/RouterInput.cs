namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using RouterInputTypes;

    public class RouterInput : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoutingScope, IHaveMediaConnectRouterInputTypesRouterContentQualityAnalysisConfigurationContentQualityAnalysisConfiguration, IHaveMediaConnectRouterInputTypesRouterInputTransitEncryptionTransitEncryption, IHaveMediaConnectRouterInputTypesRouterInputConfigurationConfiguration, IHaveTier, IHaveRegionName, IHaveMaximumBitrate_Integer, IHaveAvailabilityZone, IHaveMediaConnectRouterInputTypesMaintenanceConfigurationMaintenanceConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string InputType =  "InputType" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ContentQualityAnalysisType =  "ContentQualityAnalysisType" ;
            public static string IpAddress =  "IpAddress" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string RoutedOutputs =  "RoutedOutputs" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string MaintenanceType =  "MaintenanceType" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.RouterInput; }

        /// <summary>
        /// RoutingScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-routingscope
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoutingScope { get; set; }
        /// <summary>
        /// ContentQualityAnalysisConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-contentqualityanalysisconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouterContentQualityAnalysisConfiguration
        /// </summary>
        public Union<Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration, BaseFunction>? ContentQualityAnalysisConfiguration { get; set; }
        /// <summary>
        /// TransitEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-transitencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouterInputTransitEncryption
        /// </summary>
        public Union<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption, BaseFunction>? TransitEncryption { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouterInputConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.MediaConnect.RouterInputTypes.RouterInputConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-tier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Tier { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RegionName { get; set; }

        /// <summary>
        /// MaximumBitrate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-maximumbitrate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaximumBitrate { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// MaintenanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-maintenanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceConfiguration
        /// </summary>
        public Union<Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration, BaseFunction>? MaintenanceConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RouterInputTypes
    {
        public class BlackFramesConfiguration : Humidifier.Base.BaseSubResource, IHaveState, IHaveThresholdSeconds_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-blackframesconfiguration.html#cfn-mediaconnect-routerinput-blackframesconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-blackframesconfiguration.html#cfn-mediaconnect-routerinput-blackframesconfiguration-thresholdseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdSeconds { get; set; }
        }

        public class ContentQualityAnalysisFeatureConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesBlackFramesConfigurationBlackFrames, IHaveMediaConnectRouterInputTypesSilentAudioConfigurationSilentAudio, IHaveMediaConnectRouterInputTypesFrozenFramesConfigurationFrozenFrames
        {
            /// <summary>
            /// BlackFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration.html#cfn-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration-blackframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlackFramesConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration, BaseFunction>? BlackFrames { get; set; }
            /// <summary>
            /// SilentAudio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration.html#cfn-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration-silentaudio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SilentAudioConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration, BaseFunction>? SilentAudio { get; set; }
            /// <summary>
            /// FrozenFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration.html#cfn-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration-frozenframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrozenFramesConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration, BaseFunction>? FrozenFrames { get; set; }
        }

        public class FailoverRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveNetworkInterfaceArn, IHaveSourcePriorityMode, IHaveListOfMediaConnectRouterInputTypesFailoverRouterInputProtocolConfigurationProtocolConfigurations, IHavePrimarySourceIndex_Integer
        {
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceArn { get; set; }
            /// <summary>
            /// SourcePriorityMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-sourceprioritymode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePriorityMode { get; set; }
            /// <summary>
            /// ProtocolConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-protocolconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FailoverRouterInputProtocolConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputProtocolConfiguration>, IReadOnlyList<Union<Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputProtocolConfiguration, BaseFunction>>, BaseFunction>? ProtocolConfigurations { get; set; }
            /// <summary>
            /// PrimarySourceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-primarysourceindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PrimarySourceIndex { get; set; }
        }

        public class FailoverRouterInputProtocolConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSrtCallerRouterInputConfigurationSrtCaller, IHaveMediaConnectRouterInputTypesSrtListenerRouterInputConfigurationSrtListener, IHaveMediaConnectRouterInputTypesRistRouterInputConfigurationRist, IHaveMediaConnectRouterInputTypesRtpRouterInputConfigurationRtp
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration, BaseFunction>? SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration, BaseFunction>? SrtListener { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration, BaseFunction>? Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration, BaseFunction>? Rtp { get; set; }
        }

        public class FlowTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectRouterInputTypesFlowTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryption.html#cfn-mediaconnect-routerinput-flowtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryption.html#cfn-mediaconnect-routerinput-flowtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class FlowTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
        }

        public class FrozenFramesConfiguration : Humidifier.Base.BaseSubResource, IHaveState, IHaveThresholdSeconds_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-frozenframesconfiguration.html#cfn-mediaconnect-routerinput-frozenframesconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-frozenframesconfiguration.html#cfn-mediaconnect-routerinput-frozenframesconfiguration-thresholdseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdSeconds { get; set; }
        }

        public class MaintenanceConfiguration : Humidifier.Base.BaseSubResource, IHaveDefault_Json, IHaveMediaConnectRouterInputTypesPreferredDayTimeMaintenanceConfigurationPreferredDayTime
        {
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-maintenanceconfiguration.html#cfn-mediaconnect-routerinput-maintenanceconfiguration-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Default { get; set; }
            /// <summary>
            /// PreferredDayTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-maintenanceconfiguration.html#cfn-mediaconnect-routerinput-maintenanceconfiguration-preferreddaytime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreferredDayTimeMaintenanceConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration, BaseFunction>? PreferredDayTime { get; set; }
        }

        public class MediaConnectFlowRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveFlowOutputArn, IHaveMediaConnectRouterInputTypesFlowTransitEncryptionSourceTransitDecryption, IHaveFlowArn
        {
            /// <summary>
            /// FlowOutputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration.html#cfn-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration-flowoutputarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowOutputArn { get; set; }
            /// <summary>
            /// SourceTransitDecryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration.html#cfn-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration-sourcetransitdecryption
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryption
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption, BaseFunction>? SourceTransitDecryption { get; set; }
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration.html#cfn-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowArn { get; set; }
        }

        public class MediaLiveChannelRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaLiveChannelArn, IHaveMediaLivePipelineId, IHaveMediaLiveChannelOutputName, IHaveMediaConnectRouterInputTypesMediaLiveTransitEncryptionSourceTransitDecryption
        {
            /// <summary>
            /// MediaLiveChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-medialivechannelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaLiveChannelArn { get; set; }
            /// <summary>
            /// MediaLivePipelineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-medialivepipelineid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaLivePipelineId { get; set; }
            /// <summary>
            /// MediaLiveChannelOutputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-medialivechanneloutputname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaLiveChannelOutputName { get; set; }
            /// <summary>
            /// SourceTransitDecryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-sourcetransitdecryption
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MediaLiveTransitEncryption
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption, BaseFunction>? SourceTransitDecryption { get; set; }
        }

        public class MediaLiveTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectRouterInputTypesMediaLiveTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryption.html#cfn-mediaconnect-routerinput-medialivetransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryption.html#cfn-mediaconnect-routerinput-medialivetransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MediaLiveTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class MediaLiveTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
        }

        public class MergeRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveMergeRecoveryWindowMilliseconds_Integer, IHaveNetworkInterfaceArn, IHaveListOfMediaConnectRouterInputTypesMergeRouterInputProtocolConfigurationProtocolConfigurations
        {
            /// <summary>
            /// MergeRecoveryWindowMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputconfiguration-mergerecoverywindowmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MergeRecoveryWindowMilliseconds { get; set; }
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceArn { get; set; }
            /// <summary>
            /// ProtocolConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputconfiguration-protocolconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MergeRouterInputProtocolConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputProtocolConfiguration>, IReadOnlyList<Union<Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputProtocolConfiguration, BaseFunction>>, BaseFunction>? ProtocolConfigurations { get; set; }
        }

        public class MergeRouterInputProtocolConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesRistRouterInputConfigurationRist, IHaveMediaConnectRouterInputTypesRtpRouterInputConfigurationRtp
        {
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration, BaseFunction>? Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration, BaseFunction>? Rtp { get; set; }
        }

        public class PreferredDayTimeMaintenanceConfiguration : Humidifier.Base.BaseSubResource, IHaveTime, IHaveDay
        {
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration.html#cfn-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration-time
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Time { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration.html#cfn-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Day { get; set; }
        }

        public class RistRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveRecoveryLatencyMilliseconds_Integer, IHavePort_Integer
        {
            /// <summary>
            /// RecoveryLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-ristrouterinputconfiguration.html#cfn-mediaconnect-routerinput-ristrouterinputconfiguration-recoverylatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecoveryLatencyMilliseconds { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-ristrouterinputconfiguration.html#cfn-mediaconnect-routerinput-ristrouterinputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
        }

        public class RouterContentQualityAnalysisConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesContentQualityAnalysisFeatureConfigurationContentLevel
        {
            /// <summary>
            /// ContentLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routercontentqualityanalysisconfiguration.html#cfn-mediaconnect-routerinput-routercontentqualityanalysisconfiguration-contentlevel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ContentQualityAnalysisFeatureConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration, BaseFunction>? ContentLevel { get; set; }
        }

        public class RouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesMediaConnectFlowRouterInputConfigurationMediaConnectFlow, IHaveMediaConnectRouterInputTypesFailoverRouterInputConfigurationFailover, IHaveMediaConnectRouterInputTypesMergeRouterInputConfigurationMerge, IHaveMediaConnectRouterInputTypesMediaLiveChannelRouterInputConfigurationMediaLiveChannel, IHaveMediaConnectRouterInputTypesStandardRouterInputConfigurationStandard
        {
            /// <summary>
            /// MediaConnectFlow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-mediaconnectflow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaConnectFlowRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration, BaseFunction>? MediaConnectFlow { get; set; }
            /// <summary>
            /// Failover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-failover
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailoverRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration, BaseFunction>? Failover { get; set; }
            /// <summary>
            /// Merge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-merge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MergeRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration, BaseFunction>? Merge { get; set; }
            /// <summary>
            /// MediaLiveChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-medialivechannel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaLiveChannelRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration, BaseFunction>? MediaLiveChannel { get; set; }
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-standard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration, BaseFunction>? Standard { get; set; }
        }

        public class RouterInputProtocolConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSrtCallerRouterInputConfigurationSrtCaller, IHaveMediaConnectRouterInputTypesSrtListenerRouterInputConfigurationSrtListener, IHaveMediaConnectRouterInputTypesRistRouterInputConfigurationRist, IHaveMediaConnectRouterInputTypesRtpRouterInputConfigurationRtp
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration, BaseFunction>? SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration, BaseFunction>? SrtListener { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration, BaseFunction>? Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterInputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration, BaseFunction>? Rtp { get; set; }
        }

        public class RouterInputTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectRouterInputTypesRouterInputTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryption.html#cfn-mediaconnect-routerinput-routerinputtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryption.html#cfn-mediaconnect-routerinput-routerinputtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RouterInputTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class RouterInputTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
        }

        public class RtpRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveForwardErrorCorrection, IHavePort_Integer
        {
            /// <summary>
            /// ForwardErrorCorrection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-rtprouterinputconfiguration.html#cfn-mediaconnect-routerinput-rtprouterinputconfiguration-forwarderrorcorrection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ForwardErrorCorrection { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-rtprouterinputconfiguration.html#cfn-mediaconnect-routerinput-rtprouterinputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
        }

        public class SecretsManagerEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SilentAudioConfiguration : Humidifier.Base.BaseSubResource, IHaveState, IHaveThresholdSeconds_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-silentaudioconfiguration.html#cfn-mediaconnect-routerinput-silentaudioconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-silentaudioconfiguration.html#cfn-mediaconnect-routerinput-silentaudioconfiguration-thresholdseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdSeconds { get; set; }
        }

        public class SrtCallerRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceAddress, IHaveStreamId, IHaveMediaConnectRouterInputTypesSrtDecryptionConfigurationDecryptionConfiguration, IHaveSourcePort_Integer, IHaveMinimumLatencyMilliseconds_Integer
        {
            /// <summary>
            /// SourceAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-sourceaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceAddress { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// DecryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-decryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtDecryptionConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration, BaseFunction>? DecryptionConfiguration { get; set; }
            /// <summary>
            /// SourcePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-sourceport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourcePort { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatencyMilliseconds { get; set; }
        }

        public class SrtDecryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSecretsManagerEncryptionKeyConfigurationEncryptionKey
        {
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtdecryptionconfiguration.html#cfn-mediaconnect-routerinput-srtdecryptionconfiguration-encryptionkey
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? EncryptionKey { get; set; }
        }

        public class SrtListenerRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesSrtDecryptionConfigurationDecryptionConfiguration, IHaveMinimumLatencyMilliseconds_Integer, IHavePort_Integer
        {
            /// <summary>
            /// DecryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtlistenerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtlistenerrouterinputconfiguration-decryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtDecryptionConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration, BaseFunction>? DecryptionConfiguration { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtlistenerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtlistenerrouterinputconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatencyMilliseconds { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtlistenerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtlistenerrouterinputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
        }

        public class StandardRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterInputTypesRouterInputProtocolConfigurationProtocolConfiguration, IHaveNetworkInterfaceArn, IHaveProtocol
        {
            /// <summary>
            /// ProtocolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-standardrouterinputconfiguration.html#cfn-mediaconnect-routerinput-standardrouterinputconfiguration-protocolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RouterInputProtocolConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration, BaseFunction>? ProtocolConfiguration { get; set; }
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-standardrouterinputconfiguration.html#cfn-mediaconnect-routerinput-standardrouterinputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceArn { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-standardrouterinputconfiguration.html#cfn-mediaconnect-routerinput-standardrouterinputconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }
    }
}