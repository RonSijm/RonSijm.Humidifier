namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using RouterOutputTypes;

    public class RouterOutput : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoutingScope, IHaveMediaConnectRouterOutputTypesRouterOutputConfigurationConfiguration, IHaveTier, IHaveRegionName, IHaveMaximumBitrate_Integer, IHaveAvailabilityZone, IHaveMediaConnectRouterOutputTypesMaintenanceConfigurationMaintenanceConfiguration, IHaveMediaConnectRouterOutputTypesFabricConfigurationFabricConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string IpAddress =  "IpAddress" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string RoutedState =  "RoutedState" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string MaintenanceType =  "MaintenanceType" ;
            public static string OutputType =  "OutputType" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.RouterOutput; }

        /// <summary>
        /// RoutingScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-routingscope
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoutingScope { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouterOutputConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-tier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Tier { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RegionName { get; set; }

        /// <summary>
        /// MaximumBitrate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-maximumbitrate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaximumBitrate { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// MaintenanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-maintenanceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceConfiguration
        /// </summary>
        public Union<Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration, BaseFunction>? MaintenanceConfiguration { get; set; }
        /// <summary>
        /// FabricConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-fabricconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FabricConfiguration
        /// </summary>
        public Union<Humidifier.MediaConnect.RouterOutputTypes.FabricConfiguration, BaseFunction>? FabricConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-routeroutput.html#cfn-mediaconnect-routeroutput-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RouterOutputTypes
    {
        public class FabricConfiguration : Humidifier.Base.BaseSubResource, IHaveRecoveryLatencyMode
        {
            /// <summary>
            /// RecoveryLatencyMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-fabricconfiguration.html#cfn-mediaconnect-routeroutput-fabricconfiguration-recoverylatencymode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecoveryLatencyMode { get; set; }
        }

        public class FlowTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectRouterOutputTypesFlowTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-flowtransitencryption.html#cfn-mediaconnect-routeroutput-flowtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-flowtransitencryption.html#cfn-mediaconnect-routeroutput-flowtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class FlowTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routeroutput-flowtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-routeroutput-flowtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
        }

        public class MaintenanceConfiguration : Humidifier.Base.BaseSubResource, IHaveDefault_Json, IHaveMediaConnectRouterOutputTypesPreferredDayTimeMaintenanceConfigurationPreferredDayTime
        {
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-maintenanceconfiguration.html#cfn-mediaconnect-routeroutput-maintenanceconfiguration-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Default { get; set; }
            /// <summary>
            /// PreferredDayTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-maintenanceconfiguration.html#cfn-mediaconnect-routeroutput-maintenanceconfiguration-preferreddaytime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PreferredDayTimeMaintenanceConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration, BaseFunction>? PreferredDayTime { get; set; }
        }

        public class MediaConnectFlowRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveFlowSourceArn, IHaveFlowArn, IHaveMediaConnectRouterOutputTypesFlowTransitEncryptionDestinationTransitEncryption
        {
            /// <summary>
            /// FlowSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-mediaconnectflowrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-mediaconnectflowrouteroutputconfiguration-flowsourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowSourceArn { get; set; }
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-mediaconnectflowrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-mediaconnectflowrouteroutputconfiguration-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowArn { get; set; }
            /// <summary>
            /// DestinationTransitEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-mediaconnectflowrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-mediaconnectflowrouteroutputconfiguration-destinationtransitencryption
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryption
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption, BaseFunction>? DestinationTransitEncryption { get; set; }
        }

        public class MediaLiveInputRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaLiveInputArn, IHaveMediaLivePipelineId, IHaveMediaConnectRouterOutputTypesMediaLiveTransitEncryptionDestinationTransitEncryption
        {
            /// <summary>
            /// MediaLiveInputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialiveinputrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-medialiveinputrouteroutputconfiguration-medialiveinputarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaLiveInputArn { get; set; }
            /// <summary>
            /// MediaLivePipelineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialiveinputrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-medialiveinputrouteroutputconfiguration-medialivepipelineid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaLivePipelineId { get; set; }
            /// <summary>
            /// DestinationTransitEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialiveinputrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-medialiveinputrouteroutputconfiguration-destinationtransitencryption
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MediaLiveTransitEncryption
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption, BaseFunction>? DestinationTransitEncryption { get; set; }
        }

        public class MediaLiveTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectRouterOutputTypesMediaLiveTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialivetransitencryption.html#cfn-mediaconnect-routeroutput-medialivetransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialivetransitencryption.html#cfn-mediaconnect-routeroutput-medialivetransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MediaLiveTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class MediaLiveTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialivetransitencryptionkeyconfiguration.html#cfn-mediaconnect-routeroutput-medialivetransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-medialivetransitencryptionkeyconfiguration.html#cfn-mediaconnect-routeroutput-medialivetransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
        }

        public class PreferredDayTimeMaintenanceConfiguration : Humidifier.Base.BaseSubResource, IHaveTime, IHaveDay
        {
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-preferreddaytimemaintenanceconfiguration.html#cfn-mediaconnect-routeroutput-preferreddaytimemaintenanceconfiguration-time
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Time { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-preferreddaytimemaintenanceconfiguration.html#cfn-mediaconnect-routeroutput-preferreddaytimemaintenanceconfiguration-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Day { get; set; }
        }

        public class RistRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveDestinationPort_Integer, IHaveDestinationAddress
        {
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-ristrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-ristrouteroutputconfiguration-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DestinationPort { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-ristrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-ristrouteroutputconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationAddress { get; set; }
        }

        public class RouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesMediaLiveInputRouterOutputConfigurationMediaLiveInput, IHaveMediaConnectRouterOutputTypesMediaConnectFlowRouterOutputConfigurationMediaConnectFlow, IHaveMediaConnectRouterOutputTypesStandardRouterOutputConfigurationStandard
        {
            /// <summary>
            /// MediaLiveInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputconfiguration-medialiveinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaLiveInputRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration, BaseFunction>? MediaLiveInput { get; set; }
            /// <summary>
            /// MediaConnectFlow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputconfiguration-mediaconnectflow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaConnectFlowRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration, BaseFunction>? MediaConnectFlow { get; set; }
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputconfiguration-standard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration, BaseFunction>? Standard { get; set; }
        }

        public class RouterOutputProtocolConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesSrtCallerRouterOutputConfigurationSrtCaller, IHaveMediaConnectRouterOutputTypesSrtListenerRouterOutputConfigurationSrtListener, IHaveMediaConnectRouterOutputTypesRtmpPushRouterOutputConfigurationRtmpPush, IHaveMediaConnectRouterOutputTypesRistRouterOutputConfigurationRist, IHaveMediaConnectRouterOutputTypesRtpRouterOutputConfigurationRtp
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputprotocolconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SrtCallerRouterOutputConfiguration, BaseFunction>? SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputprotocolconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SrtListenerRouterOutputConfiguration, BaseFunction>? SrtListener { get; set; }
            /// <summary>
            /// RtmpPush
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputprotocolconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputprotocolconfiguration-rtmppush
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtmpPushRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration, BaseFunction>? RtmpPush { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputprotocolconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.RistRouterOutputConfiguration, BaseFunction>? Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-routeroutputprotocolconfiguration.html#cfn-mediaconnect-routeroutput-routeroutputprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpRouterOutputConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.RtpRouterOutputConfiguration, BaseFunction>? Rtp { get; set; }
        }

        public class RtmpPushRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationName, IHaveStreamName, IHaveMediaConnectRouterOutputTypesTlsEncryptionTlsEncryption, IHaveDestinationPort_Integer, IHaveDestinationAddress
        {
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration-applicationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationName { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration-streamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
            /// <summary>
            /// TlsEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration-tlsencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsEncryption
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption, BaseFunction>? TlsEncryption { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DestinationPort { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtmppushrouteroutputconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationAddress { get; set; }
        }

        public class RtpRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveForwardErrorCorrection, IHaveDestinationPort_Integer, IHaveDestinationAddress
        {
            /// <summary>
            /// ForwardErrorCorrection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtprouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtprouteroutputconfiguration-forwarderrorcorrection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ForwardErrorCorrection { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtprouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtprouteroutputconfiguration-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DestinationPort { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-rtprouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-rtprouteroutputconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationAddress { get; set; }
        }

        public class SecretsManagerEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-routeroutput-secretsmanagerencryptionkeyconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-routeroutput-secretsmanagerencryptionkeyconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SrtCallerRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamId, IHaveMediaConnectRouterOutputTypesSrtEncryptionConfigurationEncryptionConfiguration, IHaveDestinationPort_Integer, IHaveMinimumLatencyMilliseconds_Integer, IHaveDestinationAddress
        {
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DestinationPort { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatencyMilliseconds { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtcallerrouteroutputconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationAddress { get; set; }
        }

        public class SrtEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesSecretsManagerEncryptionKeyConfigurationEncryptionKey
        {
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtencryptionconfiguration.html#cfn-mediaconnect-routeroutput-srtencryptionconfiguration-encryptionkey
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? EncryptionKey { get; set; }
        }

        public class SrtListenerRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesSrtEncryptionConfigurationEncryptionConfiguration, IHavePort_Integer, IHaveMinimumLatencyMilliseconds_Integer
        {
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtlistenerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtlistenerrouteroutputconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtlistenerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtlistenerrouteroutputconfiguration-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-srtlistenerrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-srtlistenerrouteroutputconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatencyMilliseconds { get; set; }
        }

        public class StandardRouterOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectRouterOutputTypesRouterOutputProtocolConfigurationProtocolConfiguration, IHaveNetworkInterfaceArn, IHaveProtocol
        {
            /// <summary>
            /// ProtocolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-standardrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-standardrouteroutputconfiguration-protocolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RouterOutputProtocolConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration, BaseFunction>? ProtocolConfiguration { get; set; }
            /// <summary>
            /// NetworkInterfaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-standardrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-standardrouteroutputconfiguration-networkinterfacearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceArn { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-standardrouteroutputconfiguration.html#cfn-mediaconnect-routeroutput-standardrouteroutputconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class TlsEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveMediaConnectRouterOutputTypesTlsEncryptionConfigurationEncryptionConfiguration
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-tlsencryption.html#cfn-mediaconnect-routeroutput-tlsencryption-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-tlsencryption.html#cfn-mediaconnect-routeroutput-tlsencryption-encryptionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TlsEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        }

        public class TlsEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHavePublic_Json
        {
            /// <summary>
            /// Public
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-routeroutput-tlsencryptionconfiguration.html#cfn-mediaconnect-routeroutput-tlsencryptionconfiguration-public
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Public { get; set; }
        }
    }
}