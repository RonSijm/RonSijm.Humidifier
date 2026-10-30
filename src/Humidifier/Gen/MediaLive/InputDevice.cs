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
        public class InputDeviceHdSettings : Humidifier.Base.BaseSubResource, IHaveHeight, IHaveWidth, IHaveMaxBitrate, IHaveScanType
        {
            /// <summary>
            /// Framerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-framerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Framerate { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanType { get; set; }
            /// <summary>
            /// DeviceState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-devicestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceState { get; set; }
            /// <summary>
            /// ActiveInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-activeinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActiveInput { get; set; }
            /// <summary>
            /// ConfiguredInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-configuredinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfiguredInput { get; set; }
            /// <summary>
            /// LatencyMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-latencyms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LatencyMs { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBitrate { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicehdsettings.html#cfn-medialive-inputdevice-inputdevicehdsettings-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class InputDeviceMediaConnectSettings : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecretArn, IHaveFlowArn, IHaveSourceName
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-sourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicemediaconnectsettings.html#cfn-medialive-inputdevice-inputdevicemediaconnectsettings-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class InputDeviceNetworkSettings : Humidifier.Base.BaseSubResource, IHaveIpAddress, IHaveGateway
        {
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gateway { get; set; }
            /// <summary>
            /// IpScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-ipscheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpScheme { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-ipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpAddress { get; set; }
            /// <summary>
            /// DnsAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-dnsaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DnsAddresses { get; set; }
            /// <summary>
            /// SubnetMask
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdevicenetworksettings.html#cfn-medialive-inputdevice-inputdevicenetworksettings-subnetmask
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetMask { get; set; }
        }

        public class InputDeviceUhdAudioChannelPairConfig : Humidifier.Base.BaseSubResource, IHaveId, IHaveProfile
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig.html#cfn-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Profile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig.html#cfn-medialive-inputdevice-inputdeviceuhdaudiochannelpairconfig-profile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Profile { get; set; }
        }

        public class InputDeviceUhdSettings : Humidifier.Base.BaseSubResource, IHaveHeight, IHaveWidth, IHaveMaxBitrate, IHaveScanType
        {
            /// <summary>
            /// ActiveInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-activeinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActiveInput { get; set; }
            /// <summary>
            /// InputResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-inputresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputResolution { get; set; }
            /// <summary>
            /// ConfiguredInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-configuredinput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfiguredInput { get; set; }
            /// <summary>
            /// LatencyMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-latencyms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LatencyMs { get; set; }
            /// <summary>
            /// AudioChannelPairs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-audiochannelpairs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputDeviceUhdAudioChannelPairConfig
            /// </summary>
            public List<Humidifier.MediaLive.InputDeviceTypes.InputDeviceUhdAudioChannelPairConfig> AudioChannelPairs { get; set; }
            /// <summary>
            /// Framerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-framerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Framerate { get; set; }
            /// <summary>
            /// ScanType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-scantype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanType { get; set; }
            /// <summary>
            /// DeviceState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-devicestate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceState { get; set; }
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Codec { get; set; }
            /// <summary>
            /// MediaconnectSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-mediaconnectsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputDeviceMediaConnectSettings
            /// </summary>
            public Humidifier.MediaLive.InputDeviceTypes.InputDeviceMediaConnectSettings MediaconnectSettings { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// MaxBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-maxbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBitrate { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputdevice-inputdeviceuhdsettings.html#cfn-medialive-inputdevice-inputdeviceuhdsettings-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Width { get; set; }
        }
    }
}