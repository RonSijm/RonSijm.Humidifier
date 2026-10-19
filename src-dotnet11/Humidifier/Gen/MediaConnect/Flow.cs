namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaConnectFlowTypesSourceMonitoringConfigSourceMonitoringConfig, IHaveMediaConnectFlowTypesFailoverConfigSourceFailoverConfig, IHaveListOfMediaConnectFlowTypesVpcInterfaceVpcInterfaces, IHaveListOfMediaConnectFlowTypesMediaStreamMediaStreams, IHaveMediaConnectFlowTypesNdiConfigNdiConfig, IHaveAvailabilityZone, IHaveMediaConnectFlowTypesMaintenanceMaintenance, IHaveMediaConnectFlowTypesEncodingConfigEncodingConfig, IHaveMediaConnectFlowTypesSourceSource, IHaveFlowSize, IHaveName
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
        public Union<Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig, BaseFunction>? SourceMonitoringConfig { get; set; }
        /// <summary>
        /// SourceFailoverConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-sourcefailoverconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FailoverConfig
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowTypes.FailoverConfig, BaseFunction>? SourceFailoverConfig { get; set; }
        /// <summary>
        /// VpcInterfaces
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-vpcinterfaces
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VpcInterface
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.VpcInterface>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.VpcInterface, BaseFunction>>, BaseFunction>? VpcInterfaces { get; set; }
        /// <summary>
        /// MediaStreams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-mediastreams
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaStream
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.MediaStream>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.MediaStream, BaseFunction>>, BaseFunction>? MediaStreams { get; set; }
        /// <summary>
        /// NdiConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-ndiconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NdiConfig
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowTypes.NdiConfig, BaseFunction>? NdiConfig { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// Maintenance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-maintenance
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Maintenance
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowTypes.Maintenance, BaseFunction>? Maintenance { get; set; }
        /// <summary>
        /// EncodingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-encodingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncodingConfig
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowTypes.EncodingConfig, BaseFunction>? EncodingConfig { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-source
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        [Required]
        public Union<Humidifier.MediaConnect.FlowTypes.Source, BaseFunction>? Source { get; set; }
        /// <summary>
        /// FlowSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-flowsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlowSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flow.html#cfn-mediaconnect-flow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowTypes
    {
        public class AudioMonitoringSetting : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowTypesSilentAudioSilentAudio
        {
            /// <summary>
            /// SilentAudio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-audiomonitoringsetting.html#cfn-mediaconnect-flow-audiomonitoringsetting-silentaudio
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SilentAudio
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.SilentAudio, BaseFunction>? SilentAudio { get; set; }
        }

        public class BlackFrames : Humidifier.Base.BaseSubResource, IHaveState, IHaveThresholdSeconds_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-blackframes.html#cfn-mediaconnect-flow-blackframes-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-blackframes.html#cfn-mediaconnect-flow-blackframes-thresholdseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdSeconds { get; set; }
        }

        public class EncodingConfig : Humidifier.Base.BaseSubResource, IHaveEncodingProfile, IHaveVideoMaxBitrate_Integer
        {
            /// <summary>
            /// EncodingProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encodingconfig.html#cfn-mediaconnect-flow-encodingconfig-encodingprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncodingProfile { get; set; }
            /// <summary>
            /// VideoMaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encodingconfig.html#cfn-mediaconnect-flow-encodingconfig-videomaxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VideoMaxBitrate { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKeyType, IHaveAlgorithm, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class FailoverConfig : Humidifier.Base.BaseSubResource, IHaveState, IHaveMediaConnectFlowTypesSourcePrioritySourcePriority, IHaveFailoverMode, IHaveRecoveryWindow_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// SourcePriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-sourcepriority
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourcePriority
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.SourcePriority, BaseFunction>? SourcePriority { get; set; }
            /// <summary>
            /// FailoverMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-failovermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailoverMode { get; set; }
            /// <summary>
            /// RecoveryWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html#cfn-mediaconnect-flow-failoverconfig-recoverywindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecoveryWindow { get; set; }
        }

        public class FlowTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectFlowTypesFlowTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryption.html#cfn-mediaconnect-flow-flowtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryption.html#cfn-mediaconnect-flow-flowtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class FlowTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-flow-flowtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-flow-flowtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
        }

        public class Fmtp : Humidifier.Base.BaseSubResource, IHavePar, IHaveScanMode, IHaveTcs, IHaveExactFramerate, IHaveChannelOrder, IHaveColorimetry, IHaveRange
        {
            /// <summary>
            /// Par
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-par
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Par { get; set; }
            /// <summary>
            /// ScanMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-scanmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanMode { get; set; }
            /// <summary>
            /// Tcs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-tcs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tcs { get; set; }
            /// <summary>
            /// ExactFramerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-exactframerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExactFramerate { get; set; }
            /// <summary>
            /// ChannelOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-channelorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelOrder { get; set; }
            /// <summary>
            /// Colorimetry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-colorimetry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Colorimetry { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-fmtp.html#cfn-mediaconnect-flow-fmtp-range
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Range { get; set; }
        }

        public class FrozenFrames : Humidifier.Base.BaseSubResource, IHaveState, IHaveThresholdSeconds_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-frozenframes.html#cfn-mediaconnect-flow-frozenframes-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-frozenframes.html#cfn-mediaconnect-flow-frozenframes-thresholdseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdSeconds { get; set; }
        }

        public class GatewayBridgeSource : Humidifier.Base.BaseSubResource, IHaveBridgeArn, IHaveMediaConnectFlowTypesVpcInterfaceAttachmentVpcInterfaceAttachment
        {
            /// <summary>
            /// BridgeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-gatewaybridgesource.html#cfn-mediaconnect-flow-gatewaybridgesource-bridgearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BridgeArn { get; set; }
            /// <summary>
            /// VpcInterfaceAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-gatewaybridgesource.html#cfn-mediaconnect-flow-gatewaybridgesource-vpcinterfaceattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcInterfaceAttachment
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment, BaseFunction>? VpcInterfaceAttachment { get; set; }
        }

        public class InputConfiguration : Humidifier.Base.BaseSubResource, IHaveInputPort_Integer, IHaveMediaConnectFlowTypesInterfaceInterface
        {
            /// <summary>
            /// InputPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-inputconfiguration.html#cfn-mediaconnect-flow-inputconfiguration-inputport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InputPort { get; set; }
            /// <summary>
            /// Interface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-inputconfiguration.html#cfn-mediaconnect-flow-inputconfiguration-interface
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Interface
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.Interface, BaseFunction>? Interface { get; set; }
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
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Maintenance : Humidifier.Base.BaseSubResource, IHaveMaintenanceDay, IHaveMaintenanceStartHour
        {
            /// <summary>
            /// MaintenanceDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-maintenance.html#cfn-mediaconnect-flow-maintenance-maintenanceday
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceDay { get; set; }
            /// <summary>
            /// MaintenanceStartHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-maintenance.html#cfn-mediaconnect-flow-maintenance-maintenancestarthour
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaintenanceStartHour { get; set; }
        }

        public class MediaStream : Humidifier.Base.BaseSubResource, IHaveTags, IHaveMediaStreamType, IHaveMediaStreamId_Integer, IHaveDescription, IHaveMediaStreamName, IHaveMediaConnectFlowTypesMediaStreamAttributesAttributes_, IHaveClockRate_Integer, IHaveVideoFormat, IHaveFmt_Integer
        {
            /// <summary>
            /// MediaStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-mediastreamtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaStreamType { get; set; }
            /// <summary>
            /// MediaStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-mediastreamid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MediaStreamId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// MediaStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-mediastreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaStreamName { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaStreamAttributes
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes, BaseFunction>? Attributes_ { get; set; }
            /// <summary>
            /// ClockRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-clockrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ClockRate { get; set; }
            /// <summary>
            /// VideoFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-videoformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoFormat { get; set; }
            /// <summary>
            /// Fmt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-fmt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Fmt { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastream.html#cfn-mediaconnect-flow-mediastream-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class MediaStreamAttributes : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowTypesFmtpFmtp, IHaveLang
        {
            /// <summary>
            /// Fmtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamattributes.html#cfn-mediaconnect-flow-mediastreamattributes-fmtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fmtp
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.Fmtp, BaseFunction>? Fmtp { get; set; }
            /// <summary>
            /// Lang
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamattributes.html#cfn-mediaconnect-flow-mediastreamattributes-lang
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Lang { get; set; }
        }

        public class MediaStreamSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaStreamName, IHaveListOfMediaConnectFlowTypesInputConfigurationInputConfigurations, IHaveEncodingName
        {
            /// <summary>
            /// MediaStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamsourceconfiguration.html#cfn-mediaconnect-flow-mediastreamsourceconfiguration-mediastreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaStreamName { get; set; }
            /// <summary>
            /// InputConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamsourceconfiguration.html#cfn-mediaconnect-flow-mediastreamsourceconfiguration-inputconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.InputConfiguration>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.InputConfiguration, BaseFunction>>, BaseFunction>? InputConfigurations { get; set; }
            /// <summary>
            /// EncodingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-mediastreamsourceconfiguration.html#cfn-mediaconnect-flow-mediastreamsourceconfiguration-encodingname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncodingName { get; set; }
        }

        public class NdiConfig : Humidifier.Base.BaseSubResource, IHaveNdiState, IHaveMachineName, IHaveListOfMediaConnectFlowTypesNdiDiscoveryServerConfigNdiDiscoveryServers
        {
            /// <summary>
            /// NdiState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndiconfig.html#cfn-mediaconnect-flow-ndiconfig-ndistate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NdiState { get; set; }
            /// <summary>
            /// MachineName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndiconfig.html#cfn-mediaconnect-flow-ndiconfig-machinename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MachineName { get; set; }
            /// <summary>
            /// NdiDiscoveryServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndiconfig.html#cfn-mediaconnect-flow-ndiconfig-ndidiscoveryservers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NdiDiscoveryServerConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.NdiDiscoveryServerConfig>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.NdiDiscoveryServerConfig, BaseFunction>>, BaseFunction>? NdiDiscoveryServers { get; set; }
        }

        public class NdiDiscoveryServerConfig : Humidifier.Base.BaseSubResource, IHaveDiscoveryServerAddress, IHaveDiscoveryServerPort_Integer, IHaveVpcInterfaceAdapter
        {
            /// <summary>
            /// DiscoveryServerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndidiscoveryserverconfig.html#cfn-mediaconnect-flow-ndidiscoveryserverconfig-discoveryserveraddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryServerAddress { get; set; }
            /// <summary>
            /// DiscoveryServerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndidiscoveryserverconfig.html#cfn-mediaconnect-flow-ndidiscoveryserverconfig-discoveryserverport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DiscoveryServerPort { get; set; }
            /// <summary>
            /// VpcInterfaceAdapter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndidiscoveryserverconfig.html#cfn-mediaconnect-flow-ndidiscoveryserverconfig-vpcinterfaceadapter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcInterfaceAdapter { get; set; }
        }

        public class NdiSourceSettings : Humidifier.Base.BaseSubResource, IHaveSourceName, IHaveAudioReferenceLevel_Integer
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndisourcesettings.html#cfn-mediaconnect-flow-ndisourcesettings-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
            /// <summary>
            /// AudioReferenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-ndisourcesettings.html#cfn-mediaconnect-flow-ndisourcesettings-audioreferencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AudioReferenceLevel { get; set; }
        }

        public class SecretsManagerEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-flow-secretsmanagerencryptionkeyconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SilentAudio : Humidifier.Base.BaseSubResource, IHaveState, IHaveThresholdSeconds_Integer
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-silentaudio.html#cfn-mediaconnect-flow-silentaudio-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ThresholdSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-silentaudio.html#cfn-mediaconnect-flow-silentaudio-thresholdseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdSeconds { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveTags, IHaveMaxSyncBuffer_Integer, IHaveIngestIp, IHaveStreamId, IHaveDescription, IHaveMediaConnectFlowTypesFlowTransitEncryptionRouterIntegrationTransitDecryption, IHaveListOfMediaConnectFlowTypesMediaStreamSourceConfigurationMediaStreamSourceConfigurations, IHaveIngestPort_Integer, IHaveMediaConnectFlowTypesEncryptionDecryption, IHaveRouterIntegrationState, IHaveMediaConnectFlowTypesGatewayBridgeSourceGatewayBridgeSource, IHaveSourceListenerAddress, IHaveSourceListenerPort_Integer, IHaveName, IHaveWhitelistCidr, IHaveMediaConnectFlowTypesNdiSourceSettingsNdiSourceSettings, IHaveEntitlementArn, IHaveSourceArn, IHaveMinLatency_Integer, IHaveVpcInterfaceName, IHaveMaxBitrate_Integer, IHaveProtocol, IHaveMaxLatency_Integer, IHaveSourceIngestPort
        {
            /// <summary>
            /// MaxSyncBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-maxsyncbuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSyncBuffer { get; set; }
            /// <summary>
            /// IngestIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-ingestip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IngestIp { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// RouterIntegrationTransitDecryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-routerintegrationtransitdecryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryption
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption, BaseFunction>? RouterIntegrationTransitDecryption { get; set; }
            /// <summary>
            /// MediaStreamSourceConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-mediastreamsourceconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaStreamSourceConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.MediaStreamSourceConfiguration>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.MediaStreamSourceConfiguration, BaseFunction>>, BaseFunction>? MediaStreamSourceConfigurations { get; set; }
            /// <summary>
            /// IngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-ingestport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IngestPort { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Encryption
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.Encryption, BaseFunction>? Decryption { get; set; }
            /// <summary>
            /// RouterIntegrationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-routerintegrationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RouterIntegrationState { get; set; }
            /// <summary>
            /// GatewayBridgeSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-gatewaybridgesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayBridgeSource
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource, BaseFunction>? GatewayBridgeSource { get; set; }
            /// <summary>
            /// SourceListenerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourcelisteneraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceListenerAddress { get; set; }
            /// <summary>
            /// SourceListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourcelistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourceListenerPort { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// WhitelistCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-whitelistcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WhitelistCidr { get; set; }
            /// <summary>
            /// NdiSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-ndisourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NdiSourceSettings
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.NdiSourceSettings, BaseFunction>? NdiSourceSettings { get; set; }
            /// <summary>
            /// EntitlementArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-entitlementarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntitlementArn { get; set; }
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceArn { get; set; }
            /// <summary>
            /// MinLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-minlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinLatency { get; set; }
            /// <summary>
            /// VpcInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-vpcinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcInterfaceName { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBitrate { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// MaxLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-maxlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLatency { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// SourceIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html#cfn-mediaconnect-flow-source-sourceingestport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIngestPort { get; set; }
        }

        public class SourceMonitoringConfig : Humidifier.Base.BaseSubResource, IHaveContentQualityAnalysisState, IHaveListOfMediaConnectFlowTypesAudioMonitoringSettingAudioMonitoringSettings, IHaveListOfMediaConnectFlowTypesVideoMonitoringSettingVideoMonitoringSettings, IHaveThumbnailState
        {
            /// <summary>
            /// ContentQualityAnalysisState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-contentqualityanalysisstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentQualityAnalysisState { get; set; }
            /// <summary>
            /// AudioMonitoringSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-audiomonitoringsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioMonitoringSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.AudioMonitoringSetting>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.AudioMonitoringSetting, BaseFunction>>, BaseFunction>? AudioMonitoringSettings { get; set; }
            /// <summary>
            /// VideoMonitoringSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-videomonitoringsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VideoMonitoringSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.FlowTypes.VideoMonitoringSetting>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowTypes.VideoMonitoringSetting, BaseFunction>>, BaseFunction>? VideoMonitoringSettings { get; set; }
            /// <summary>
            /// ThumbnailState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-sourcemonitoringconfig.html#cfn-mediaconnect-flow-sourcemonitoringconfig-thumbnailstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThumbnailState { get; set; }
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
            public Union<string, BaseFunction>? PrimarySource { get; set; }
        }

        public class VideoMonitoringSetting : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowTypesBlackFramesBlackFrames, IHaveMediaConnectFlowTypesFrozenFramesFrozenFrames
        {
            /// <summary>
            /// BlackFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-videomonitoringsetting.html#cfn-mediaconnect-flow-videomonitoringsetting-blackframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlackFrames
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.BlackFrames, BaseFunction>? BlackFrames { get; set; }
            /// <summary>
            /// FrozenFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-videomonitoringsetting.html#cfn-mediaconnect-flow-videomonitoringsetting-frozenframes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrozenFrames
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowTypes.FrozenFrames, BaseFunction>? FrozenFrames { get; set; }
        }

        public class VpcInterface : Humidifier.Base.BaseSubResource, IHaveTags, IHaveNetworkInterfaceType, IHaveStringListOfNetworkInterfaceIds, IHaveSubnetId, IHaveStringListOfSecurityGroupIds, IHaveRoleArn, IHaveName
        {
            /// <summary>
            /// NetworkInterfaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-networkinterfacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceType { get; set; }
            /// <summary>
            /// NetworkInterfaceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-networkinterfaceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NetworkInterfaceIds { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-vpcinterface.html#cfn-mediaconnect-flow-vpcinterface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
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
            public Union<string, BaseFunction>? VpcInterfaceName { get; set; }
        }
    }
}