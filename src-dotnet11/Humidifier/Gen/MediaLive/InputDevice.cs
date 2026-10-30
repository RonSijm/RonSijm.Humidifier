namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using InputDeviceTypes;

    public class InputDevice : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string MedialiveInputArns =  "MedialiveInputArns" ;
            public static string Name =  "Name" ;
            public static string DeviceSettingsSyncState =  "DeviceSettingsSyncState" ;
            public static string Tags =  "Tags" ;
            public static string DeviceUpdateStatus =  "DeviceUpdateStatus" ;
            public static string OutputType =  "OutputType" ;
            public static string HdDeviceSettings =  "HdDeviceSettings" ;
            public static string UhdDeviceSettings =  "UhdDeviceSettings" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string MacAddress =  "MacAddress" ;
            public static string Type =  "Type" ;
            public static string NetworkSettings =  "NetworkSettings" ;
            public static string SerialNumber =  "SerialNumber" ;
            public static string Id =  "Id" ;
            public static string ConnectionState =  "ConnectionState" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.InputDevice; }
    }

    namespace InputDeviceTypes
    {
        public class InputDeviceHdSettings : Humidifier.Base.BaseSubResource, IHaveFramerate_Double, IHaveScanType, IHaveDeviceState, IHaveActiveInput, IHaveConfiguredInput, IHaveLatencyMs_Integer, IHaveHeight_Integer, IHaveMaxBitrate_Integer, IHaveWidth_Integer
        {
            /// <summary>
            /// Framerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-framerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Framerate { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanType { get; set; }
            /// <summary>
            /// DeviceState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-devicestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceState { get; set; }
            /// <summary>
            /// ActiveInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-activeinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveInput { get; set; }
            /// <summary>
            /// ConfiguredInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-configuredinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfiguredInput { get; set; }
            /// <summary>
            /// LatencyMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-latencyms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LatencyMs { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Height { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBitrate { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Width { get; set; }
        }

        public class InputDeviceMediaConnectSettings : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSourceName, IHaveFlowArn, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class InputDeviceNetworkSettings : Humidifier.Base.BaseSubResource, IHaveGateway, IHaveIpScheme, IHaveIpAddress, IHaveStringListOfDnsAddresses, IHaveSubnetMask
        {
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gateway { get; set; }
            /// <summary>
            /// IpScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-ipscheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpScheme { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-ipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddress { get; set; }
            /// <summary>
            /// DnsAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-dnsaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DnsAddresses { get; set; }
            /// <summary>
            /// SubnetMask
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-subnetmask
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetMask { get; set; }
        }

        public class InputDeviceUhdAudioChannelPairConfig : Humidifier.Base.BaseSubResource, IHaveId_Integer, IHaveProfile
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig.html#cfn-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig.html#cfn-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Profile { get; set; }
        }

        public class InputDeviceUhdSettings : Humidifier.Base.BaseSubResource, IHaveActiveInput, IHaveInputResolution, IHaveConfiguredInput, IHaveLatencyMs_Integer, IHaveListOfMediaLiveInputDeviceTypesInputDeviceUhdAudioChannelPairConfigAudioChannelPairs, IHaveFramerate_Double, IHaveScanType, IHaveDeviceState, IHaveCodec, IHaveMediaLiveInputDeviceTypesInputDeviceMediaConnectSettingsMediaconnectSettings, IHaveHeight_Integer, IHaveMaxBitrate_Integer, IHaveWidth_Integer
        {
            /// <summary>
            /// ActiveInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-activeinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveInput { get; set; }
            /// <summary>
            /// InputResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-inputresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputResolution { get; set; }
            /// <summary>
            /// ConfiguredInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-configuredinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfiguredInput { get; set; }
            /// <summary>
            /// LatencyMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-latencyms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LatencyMs { get; set; }
            /// <summary>
            /// AudioChannelPairs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-audiochannelpairs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputDeviceUhdAudioChannelPairConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputDeviceTypes.InputDeviceUhdAudioChannelPairConfig>, IReadOnlyList<Union<Humidifier.MediaLive.InputDeviceTypes.InputDeviceUhdAudioChannelPairConfig, BaseFunction>>, BaseFunction>? AudioChannelPairs { get; set; }
            /// <summary>
            /// Framerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-framerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Framerate { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanType { get; set; }
            /// <summary>
            /// DeviceState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-devicestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceState { get; set; }
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Codec { get; set; }
            /// <summary>
            /// MediaconnectSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-mediaconnectsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputDeviceMediaConnectSettings
            /// </summary>
            public Union<Humidifier.MediaLive.InputDeviceTypes.InputDeviceMediaConnectSettings, BaseFunction>? MediaconnectSettings { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Height { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBitrate { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Width { get; set; }
        }
    }
}