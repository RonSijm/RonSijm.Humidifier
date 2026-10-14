namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using RouterInputTypes;

    public class RouterInput : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAvailabilityZone, IHaveTier, IHaveRegionName, IHaveMaximumBitrate
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
        public dynamic RoutingScope { get; set; }
        /// <summary>
        /// ContentQualityAnalysisConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-contentqualityanalysisconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouterContentQualityAnalysisConfiguration
        /// </summary>
        public Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration ContentQualityAnalysisConfiguration { get; set; }
        /// <summary>
        /// TransitEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-transitencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RouterInputTransitEncryption
        /// </summary>
        public Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryption TransitEncryption { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouterInputConfiguration
        /// </summary>
        [Required]
        public Humidifier.MediaConnect.RouterInputTypes.RouterInputConfiguration Configuration { get; set; }

        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-tier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Tier { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegionName { get; set; }

        /// <summary>
        /// MaximumBitrate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-maximumbitrate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MaximumBitrate { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZone { get; set; }
        /// <summary>
        /// MaintenanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-maintenanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceConfiguration
        /// </summary>
        public Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration MaintenanceConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routerinput.html#cfn-mediaconnect-routerinput-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RouterInputTypes
    {
        public class BlackFramesConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-blackframesconfiguration.html#cfn-mediaconnect-routerinput-blackframesconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-blackframesconfiguration.html#cfn-mediaconnect-routerinput-blackframesconfiguration-thresholdseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdSeconds { get; set; }
        }

        public class ContentQualityAnalysisFeatureConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BlackFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration.html#cfn-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration-blackframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlackFramesConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration BlackFrames { get; set; }
            /// <summary>
            /// SilentAudio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration.html#cfn-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration-silentaudio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SilentAudioConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration SilentAudio { get; set; }
            /// <summary>
            /// FrozenFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration.html#cfn-mediaconnect-routerinput-contentqualityanalysisfeatureconfiguration-frozenframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrozenFramesConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration FrozenFrames { get; set; }
        }

        public class FailoverRouterInputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceArn { get; set; }
            /// <summary>
            /// SourcePriorityMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-sourceprioritymode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePriorityMode { get; set; }
            /// <summary>
            /// ProtocolConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-protocolconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FailoverRouterInputProtocolConfiguration
            /// </summary>
            public List<Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputProtocolConfiguration> ProtocolConfigurations { get; set; }
            /// <summary>
            /// PrimarySourceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputconfiguration-primarysourceindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PrimarySourceIndex { get; set; }
        }

        public class FailoverRouterInputProtocolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration SrtListener { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-failoverrouterinputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration Rtp { get; set; }
        }

        public class FlowTransitEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryption.html#cfn-mediaconnect-routerinput-flowtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryption.html#cfn-mediaconnect-routerinput-flowtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration EncryptionKeyConfiguration { get; set; }
        }

        public class FlowTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-flowtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Automatic { get; set; }
        }

        public class FrozenFramesConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-frozenframesconfiguration.html#cfn-mediaconnect-routerinput-frozenframesconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-frozenframesconfiguration.html#cfn-mediaconnect-routerinput-frozenframesconfiguration-thresholdseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdSeconds { get; set; }
        }

        public class MaintenanceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-maintenanceconfiguration.html#cfn-mediaconnect-routerinput-maintenanceconfiguration-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Default { get; set; }
            /// <summary>
            /// PreferredDayTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-maintenanceconfiguration.html#cfn-mediaconnect-routerinput-maintenanceconfiguration-preferreddaytime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreferredDayTimeMaintenanceConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration PreferredDayTime { get; set; }
        }

        public class MediaConnectFlowRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveFlowArn
        {
            /// <summary>
            /// FlowOutputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration.html#cfn-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration-flowoutputarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowOutputArn { get; set; }
            /// <summary>
            /// SourceTransitDecryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration.html#cfn-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration-sourcetransitdecryption
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryption
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption SourceTransitDecryption { get; set; }
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration.html#cfn-mediaconnect-routerinput-mediaconnectflowrouterinputconfiguration-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowArn { get; set; }
        }

        public class MediaLiveChannelRouterInputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaLiveChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-medialivechannelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaLiveChannelArn { get; set; }
            /// <summary>
            /// MediaLivePipelineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-medialivepipelineid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaLivePipelineId { get; set; }
            /// <summary>
            /// MediaLiveChannelOutputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-medialivechanneloutputname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaLiveChannelOutputName { get; set; }
            /// <summary>
            /// SourceTransitDecryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivechannelrouterinputconfiguration.html#cfn-mediaconnect-routerinput-medialivechannelrouterinputconfiguration-sourcetransitdecryption
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MediaLiveTransitEncryption
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption SourceTransitDecryption { get; set; }
        }

        public class MediaLiveTransitEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryption.html#cfn-mediaconnect-routerinput-medialivetransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryption.html#cfn-mediaconnect-routerinput-medialivetransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MediaLiveTransitEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration EncryptionKeyConfiguration { get; set; }
        }

        public class MediaLiveTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-medialivetransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Automatic { get; set; }
        }

        public class MergeRouterInputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MergeRecoveryWindowMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputconfiguration-mergerecoverywindowmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MergeRecoveryWindowMilliseconds { get; set; }
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceArn { get; set; }
            /// <summary>
            /// ProtocolConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputconfiguration-protocolconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MergeRouterInputProtocolConfiguration
            /// </summary>
            public List<Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputProtocolConfiguration> ProtocolConfigurations { get; set; }
        }

        public class MergeRouterInputProtocolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-mergerouterinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-mergerouterinputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration Rtp { get; set; }
        }

        public class PreferredDayTimeMaintenanceConfiguration : Humidifier.Base.BaseSubResource, IHaveDay, IHaveTime
        {
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration.html#cfn-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration-time
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Time { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration.html#cfn-mediaconnect-routerinput-preferreddaytimemaintenanceconfiguration-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Day { get; set; }
        }

        public class RistRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHavePort
        {
            /// <summary>
            /// RecoveryLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-ristrouterinputconfiguration.html#cfn-mediaconnect-routerinput-ristrouterinputconfiguration-recoverylatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RecoveryLatencyMilliseconds { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-ristrouterinputconfiguration.html#cfn-mediaconnect-routerinput-ristrouterinputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
        }

        public class RouterContentQualityAnalysisConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routercontentqualityanalysisconfiguration.html#cfn-mediaconnect-routerinput-routercontentqualityanalysisconfiguration-contentlevel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ContentQualityAnalysisFeatureConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration ContentLevel { get; set; }
        }

        public class RouterInputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaConnectFlow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-mediaconnectflow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaConnectFlowRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration MediaConnectFlow { get; set; }
            /// <summary>
            /// Failover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-failover
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailoverRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.FailoverRouterInputConfiguration Failover { get; set; }
            /// <summary>
            /// Merge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-merge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MergeRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration Merge { get; set; }
            /// <summary>
            /// MediaLiveChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-medialivechannel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaLiveChannelRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration MediaLiveChannel { get; set; }
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputconfiguration.html#cfn-mediaconnect-routerinput-routerinputconfiguration-standard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration Standard { get; set; }
        }

        public class RouterInputProtocolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SrtCallerRouterInputConfiguration SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SrtListenerRouterInputConfiguration SrtListener { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RistRouterInputConfiguration Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputprotocolconfiguration.html#cfn-mediaconnect-routerinput-routerinputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterInputConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RtpRouterInputConfiguration Rtp { get; set; }
        }

        public class RouterInputTransitEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryption.html#cfn-mediaconnect-routerinput-routerinputtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryption.html#cfn-mediaconnect-routerinput-routerinputtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RouterInputTransitEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RouterInputTransitEncryptionKeyConfiguration EncryptionKeyConfiguration { get; set; }
        }

        public class RouterInputTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-routerinputtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Automatic { get; set; }
        }

        public class RtpRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHavePort
        {
            /// <summary>
            /// ForwardErrorCorrection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-rtprouterinputconfiguration.html#cfn-mediaconnect-routerinput-rtprouterinputconfiguration-forwarderrorcorrection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ForwardErrorCorrection { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-rtprouterinputconfiguration.html#cfn-mediaconnect-routerinput-rtprouterinputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
        }

        public class SecretsManagerEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-routerinput-secretsmanagerencryptionkeyconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SilentAudioConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-silentaudioconfiguration.html#cfn-mediaconnect-routerinput-silentaudioconfiguration-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-silentaudioconfiguration.html#cfn-mediaconnect-routerinput-silentaudioconfiguration-thresholdseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdSeconds { get; set; }
        }

        public class SrtCallerRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamId
        {
            /// <summary>
            /// SourceAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-sourceaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceAddress { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// DecryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-decryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtDecryptionConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration DecryptionConfiguration { get; set; }
            /// <summary>
            /// SourcePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-sourceport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SourcePort { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtcallerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtcallerrouterinputconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatencyMilliseconds { get; set; }
        }

        public class SrtDecryptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtdecryptionconfiguration.html#cfn-mediaconnect-routerinput-srtdecryptionconfiguration-encryptionkey
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration EncryptionKey { get; set; }
        }

        public class SrtListenerRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHavePort
        {
            /// <summary>
            /// DecryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtlistenerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtlistenerrouterinputconfiguration-decryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtDecryptionConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration DecryptionConfiguration { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtlistenerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtlistenerrouterinputconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatencyMilliseconds { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-srtlistenerrouterinputconfiguration.html#cfn-mediaconnect-routerinput-srtlistenerrouterinputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
        }

        public class StandardRouterInputConfiguration : Humidifier.Base.BaseSubResource, IHaveProtocol
        {
            /// <summary>
            /// ProtocolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-standardrouterinputconfiguration.html#cfn-mediaconnect-routerinput-standardrouterinputconfiguration-protocolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RouterInputProtocolConfiguration
            /// </summary>
            public Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration ProtocolConfiguration { get; set; }
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-standardrouterinputconfiguration.html#cfn-mediaconnect-routerinput-standardrouterinputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceArn { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routerinput-standardrouterinputconfiguration.html#cfn-mediaconnect-routerinput-standardrouterinputconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }
    }
}