namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAvailabilityZone
    {
        public class Attributes
        {
            public static string FlowAvailabilityZone =  "FlowAvailabilityZone" ;
            public static string EgressIp =  "EgressIp" ;
            public static string FlowArn =  "FlowArn" ;
            public static string FlowNdiMachineName =  "FlowNdiMachineName" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.Flow; }
        /// <summary>
        /// SourceMonitoringConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-sourcemonitoringconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SourceMonitoringConfig
        /// </summary>
        public Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig SourceMonitoringConfig { get; set; }
        /// <summary>
        /// SourceFailoverConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-sourcefailoverconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FailoverConfig
        /// </summary>
        public Humidifier.MediaConnect.FlowTypes.FailoverConfig SourceFailoverConfig { get; set; }
        /// <summary>
        /// VpcInterfaces
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-vpcinterfaces
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VpcInterface
        /// </summary>
        public List<Humidifier.MediaConnect.FlowTypes.VpcInterface> VpcInterfaces { get; set; }
        /// <summary>
        /// MediaStreams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-mediastreams
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaStream
        /// </summary>
        public List<Humidifier.MediaConnect.FlowTypes.MediaStream> MediaStreams { get; set; }
        /// <summary>
        /// NdiConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-ndiconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NdiConfig
        /// </summary>
        public Humidifier.MediaConnect.FlowTypes.NdiConfig NdiConfig { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZone { get; set; }
        /// <summary>
        /// Maintenance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-maintenance
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Maintenance
        /// </summary>
        public Humidifier.MediaConnect.FlowTypes.Maintenance Maintenance { get; set; }
        /// <summary>
        /// EncodingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-encodingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncodingConfig
        /// </summary>
        public Humidifier.MediaConnect.FlowTypes.EncodingConfig EncodingConfig { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-source
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        [Required]
        public Humidifier.MediaConnect.FlowTypes.Source Source { get; set; }
        /// <summary>
        /// FlowSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-flowsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FlowSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowTypes
    {
        public class AudioMonitoringSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SilentAudio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-audiomonitoringsetting.html#cfn-mediaconnect-flow-audiomonitoringsetting-silentaudio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SilentAudio
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.SilentAudio SilentAudio { get; set; }
        }

        public class BlackFrames : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-blackframes.html#cfn-mediaconnect-flow-blackframes-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-blackframes.html#cfn-mediaconnect-flow-blackframes-thresholdseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdSeconds { get; set; }
        }

        public class EncodingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncodingProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encodingconfig.html#cfn-mediaconnect-flow-encodingconfig-encodingprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncodingProfile { get; set; }
            /// <summary>
            /// VideoMaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encodingconfig.html#cfn-mediaconnect-flow-encodingconfig-videomaxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VideoMaxBitrate { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecretArn, IHaveKeyType, IHaveAlgorithm
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class FailoverConfig : Humidifier.Base.BaseSubResource, IHaveState, IHaveFailoverMode
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// SourcePriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-sourcepriority
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourcePriority
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.SourcePriority SourcePriority { get; set; }
            /// <summary>
            /// FailoverMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-failovermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailoverMode { get; set; }
            /// <summary>
            /// RecoveryWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-recoverywindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RecoveryWindow { get; set; }
        }

        public class FlowTransitEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryption.html#cfn-mediaconnect-flow-flowtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryption.html#cfn-mediaconnect-flow-flowtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration EncryptionKeyConfiguration { get; set; }
        }

        public class FlowTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-flow-flowtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-flow-flowtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Automatic { get; set; }
        }

        public class Fmtp : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Par
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-par
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Par { get; set; }
            /// <summary>
            /// ScanMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-scanmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanMode { get; set; }
            /// <summary>
            /// Tcs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-tcs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Tcs { get; set; }
            /// <summary>
            /// ExactFramerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-exactframerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExactFramerate { get; set; }
            /// <summary>
            /// ChannelOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-channelorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelOrder { get; set; }
            /// <summary>
            /// Colorimetry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-colorimetry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Colorimetry { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-range
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Range { get; set; }
        }

        public class FrozenFrames : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-frozenframes.html#cfn-mediaconnect-flow-frozenframes-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-frozenframes.html#cfn-mediaconnect-flow-frozenframes-thresholdseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdSeconds { get; set; }
        }

        public class GatewayBridgeSource : Humidifier.Base.BaseSubResource, IHaveBridgeArn
        {
            /// <summary>
            /// BridgeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-gatewaybridgesource.html#cfn-mediaconnect-flow-gatewaybridgesource-bridgearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BridgeArn { get; set; }
            /// <summary>
            /// VpcInterfaceAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-gatewaybridgesource.html#cfn-mediaconnect-flow-gatewaybridgesource-vpcinterfaceattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcInterfaceAttachment
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment VpcInterfaceAttachment { get; set; }
        }

        public class InputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-inputconfiguration.html#cfn-mediaconnect-flow-inputconfiguration-inputport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InputPort { get; set; }
            /// <summary>
            /// Interface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-inputconfiguration.html#cfn-mediaconnect-flow-inputconfiguration-interface
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Interface
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.Interface Interface { get; set; }
        }

        public class Interface : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-interface.html#cfn-mediaconnect-flow-interface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Maintenance : Humidifier.Base.BaseSubResource, IHaveMaintenanceDay
        {
            /// <summary>
            /// MaintenanceDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-maintenance.html#cfn-mediaconnect-flow-maintenance-maintenanceday
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceDay { get; set; }
            /// <summary>
            /// MaintenanceStartHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-maintenance.html#cfn-mediaconnect-flow-maintenance-maintenancestarthour
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceStartHour { get; set; }
        }

        public class MediaStream : Humidifier.Base.BaseSubResource, IHaveTags, IHaveDescription, IHaveMediaStreamName
        {
            /// <summary>
            /// MediaStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-mediastreamtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaStreamType { get; set; }
            /// <summary>
            /// MediaStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-mediastreamid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MediaStreamId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// MediaStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-mediastreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaStreamName { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaStreamAttributes
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes Attributes_ { get; set; }
            /// <summary>
            /// ClockRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-clockrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ClockRate { get; set; }
            /// <summary>
            /// VideoFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-videoformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoFormat { get; set; }
            /// <summary>
            /// Fmt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-fmt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Fmt { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> Tags { get; set; }
        }

        public class MediaStreamAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Fmtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamattributes.html#cfn-mediaconnect-flow-mediastreamattributes-fmtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fmtp
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.Fmtp Fmtp { get; set; }
            /// <summary>
            /// Lang
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamattributes.html#cfn-mediaconnect-flow-mediastreamattributes-lang
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Lang { get; set; }
        }

        public class MediaStreamSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaStreamName, IHaveEncodingName
        {
            /// <summary>
            /// MediaStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamsourceconfiguration.html#cfn-mediaconnect-flow-mediastreamsourceconfiguration-mediastreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaStreamName { get; set; }
            /// <summary>
            /// InputConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamsourceconfiguration.html#cfn-mediaconnect-flow-mediastreamsourceconfiguration-inputconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputConfiguration
            /// </summary>
            public List<Humidifier.MediaConnect.FlowTypes.InputConfiguration> InputConfigurations { get; set; }
            /// <summary>
            /// EncodingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamsourceconfiguration.html#cfn-mediaconnect-flow-mediastreamsourceconfiguration-encodingname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncodingName { get; set; }
        }

        public class NdiConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NdiState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndiconfig.html#cfn-mediaconnect-flow-ndiconfig-ndistate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NdiState { get; set; }
            /// <summary>
            /// MachineName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndiconfig.html#cfn-mediaconnect-flow-ndiconfig-machinename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MachineName { get; set; }
            /// <summary>
            /// NdiDiscoveryServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndiconfig.html#cfn-mediaconnect-flow-ndiconfig-ndidiscoveryservers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NdiDiscoveryServerConfig
            /// </summary>
            public List<Humidifier.MediaConnect.FlowTypes.NdiDiscoveryServerConfig> NdiDiscoveryServers { get; set; }
        }

        public class NdiDiscoveryServerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DiscoveryServerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndidiscoveryserverconfig.html#cfn-mediaconnect-flow-ndidiscoveryserverconfig-discoveryserveraddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscoveryServerAddress { get; set; }
            /// <summary>
            /// DiscoveryServerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndidiscoveryserverconfig.html#cfn-mediaconnect-flow-ndidiscoveryserverconfig-discoveryserverport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DiscoveryServerPort { get; set; }
            /// <summary>
            /// VpcInterfaceAdapter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndidiscoveryserverconfig.html#cfn-mediaconnect-flow-ndidiscoveryserverconfig-vpcinterfaceadapter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcInterfaceAdapter { get; set; }
        }

        public class NdiSourceSettings : Humidifier.Base.BaseSubResource, IHaveSourceName
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndisourcesettings.html#cfn-mediaconnect-flow-ndisourcesettings-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
            /// <summary>
            /// AudioReferenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndisourcesettings.html#cfn-mediaconnect-flow-ndisourcesettings-audioreferencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AudioReferenceLevel { get; set; }
        }

        public class SecretsManagerEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SilentAudio : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-silentaudio.html#cfn-mediaconnect-flow-silentaudio-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-silentaudio.html#cfn-mediaconnect-flow-silentaudio-thresholdseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdSeconds { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveName, IHaveTags, IHaveDescription, IHaveProtocol, IHaveSourceArn, IHaveVpcInterfaceName, IHaveMaxBitrate, IHaveStreamId, IHaveMinLatency, IHaveMaxLatency, IHaveEntitlementArn, IHaveIngestPort, IHaveSourceListenerAddress, IHaveSourceListenerPort, IHaveWhitelistCidr
        {
            /// <summary>
            /// MaxSyncBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-maxsyncbuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSyncBuffer { get; set; }
            /// <summary>
            /// IngestIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-ingestip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IngestIp { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// RouterIntegrationTransitDecryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-routerintegrationtransitdecryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryption
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption RouterIntegrationTransitDecryption { get; set; }
            /// <summary>
            /// MediaStreamSourceConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-mediastreamsourceconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaStreamSourceConfiguration
            /// </summary>
            public List<Humidifier.MediaConnect.FlowTypes.MediaStreamSourceConfiguration> MediaStreamSourceConfigurations { get; set; }
            /// <summary>
            /// IngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-ingestport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IngestPort { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.Encryption Decryption { get; set; }
            /// <summary>
            /// RouterIntegrationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-routerintegrationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RouterIntegrationState { get; set; }
            /// <summary>
            /// GatewayBridgeSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-gatewaybridgesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayBridgeSource
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource GatewayBridgeSource { get; set; }
            /// <summary>
            /// SourceListenerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourcelisteneraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceListenerAddress { get; set; }
            /// <summary>
            /// SourceListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourcelistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SourceListenerPort { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// WhitelistCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-whitelistcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WhitelistCidr { get; set; }
            /// <summary>
            /// NdiSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-ndisourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NdiSourceSettings
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.NdiSourceSettings NdiSourceSettings { get; set; }
            /// <summary>
            /// EntitlementArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-entitlementarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntitlementArn { get; set; }
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn { get; set; }
            /// <summary>
            /// MinLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-minlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinLatency { get; set; }
            /// <summary>
            /// VpcInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-vpcinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcInterfaceName { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBitrate { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// MaxLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-maxlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLatency { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> Tags { get; set; }
            /// <summary>
            /// SourceIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourceingestport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceIngestPort { get; set; }
        }

        public class SourceMonitoringConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentQualityAnalysisState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-contentqualityanalysisstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentQualityAnalysisState { get; set; }
            /// <summary>
            /// AudioMonitoringSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-audiomonitoringsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioMonitoringSetting
            /// </summary>
            public List<Humidifier.MediaConnect.FlowTypes.AudioMonitoringSetting> AudioMonitoringSettings { get; set; }
            /// <summary>
            /// VideoMonitoringSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-videomonitoringsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VideoMonitoringSetting
            /// </summary>
            public List<Humidifier.MediaConnect.FlowTypes.VideoMonitoringSetting> VideoMonitoringSettings { get; set; }
            /// <summary>
            /// ThumbnailState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-thumbnailstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThumbnailState { get; set; }
        }

        public class SourcePriority : Humidifier.Base.BaseSubResource, IHavePrimarySource
        {
            /// <summary>
            /// PrimarySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcepriority.html#cfn-mediaconnect-flow-sourcepriority-primarysource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimarySource { get; set; }
        }

        public class VideoMonitoringSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BlackFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-videomonitoringsetting.html#cfn-mediaconnect-flow-videomonitoringsetting-blackframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlackFrames
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.BlackFrames BlackFrames { get; set; }
            /// <summary>
            /// FrozenFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-videomonitoringsetting.html#cfn-mediaconnect-flow-videomonitoringsetting-frozenframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrozenFrames
            /// </summary>
            public Humidifier.MediaConnect.FlowTypes.FrozenFrames FrozenFrames { get; set; }
        }

        public class VpcInterface : Humidifier.Base.BaseSubResource, IHaveName, IHaveTags, IHaveRoleArn, IHaveSecurityGroupIds, IHaveSubnetId
        {
            /// <summary>
            /// NetworkInterfaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-networkinterfacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceType { get; set; }
            /// <summary>
            /// NetworkInterfaceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-networkinterfaceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NetworkInterfaceIds { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> Tags { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class VpcInterfaceAttachment : Humidifier.Base.BaseSubResource, IHaveVpcInterfaceName
        {
            /// <summary>
            /// VpcInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterfaceattachment.html#cfn-mediaconnect-flow-vpcinterfaceattachment-vpcinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcInterfaceName { get; set; }
        }
    }
}