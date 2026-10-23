namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveType, IHaveRoleArn
    {
        public class Attributes
        {
            public static string SecurityGroups =  "SecurityGroups" ;
            public static string InputClass =  "InputClass" ;
            public static string DestinationUrls =  "DestinationUrls" ;
            public static string State =  "State" ;
            public static string Destinations =  "Destinations" ;
            public static string InputSourceType =  "InputSourceType" ;
            public static string Id =  "Id" ;
            public static string SourceUrls =  "SourceUrls" ;
            public static string Arn =  "Arn" ;
            public static string AttachedChannels =  "AttachedChannels" ;
            public static string Sources =  "Sources" ;
            public static string InputPartnerIds =  "InputPartnerIds" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Input; }
        /// <summary>
        /// SrtSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-srtsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SrtSettings
        /// </summary>
        public Humidifier.MediaLive.InputTypes.SrtSettings SrtSettings { get; set; }
        /// <summary>
        /// InputNetworkLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputnetworklocation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InputNetworkLocation { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputDestination
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.InputDestination> Destinations { get; set; }
        /// <summary>
        /// Vpc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-vpc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InputVpcRequest
        /// </summary>
        public Humidifier.MediaLive.InputTypes.InputVpcRequest Vpc { get; set; }
        /// <summary>
        /// MediaConnectFlows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-mediaconnectflows
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaConnectFlow
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.MediaConnectFlow> MediaConnectFlows { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSource
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.InputSource> Sources { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RouterSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-routersettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RouterSettings
        /// </summary>
        public Humidifier.MediaLive.InputTypes.RouterSettings RouterSettings { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// Smpte2110ReceiverGroupSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-smpte2110receivergroupsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Smpte2110ReceiverGroupSettings
        /// </summary>
        public Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings Smpte2110ReceiverGroupSettings { get; set; }
        /// <summary>
        /// SdiSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sdisources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SdiSources { get; set; }
        /// <summary>
        /// MulticastSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-multicastsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MulticastSettings
        /// </summary>
        public Humidifier.MediaLive.InputTypes.MulticastSettings MulticastSettings { get; set; }
        /// <summary>
        /// InputSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic InputSecurityGroups { get; set; }
        /// <summary>
        /// InputDevices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputdevices
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputDeviceSettings
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.InputDeviceSettings> InputDevices { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace InputTypes
    {
        public class InputDestination : Humidifier.Base.BaseSubResource, IHavePort, IHaveUrl, IHaveStreamName, IHaveIp
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
            /// <summary>
            /// Ip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ip { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Network
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-network
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Network { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputDestinationVpc
            /// </summary>
            public Humidifier.MediaLive.InputTypes.InputDestinationVpc Vpc { get; set; }
            /// <summary>
            /// NetworkRoutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-networkroutes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputDestinationRoute
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.InputDestinationRoute> NetworkRoutes { get; set; }
            /// <summary>
            /// StaticIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-staticipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticIpAddress { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class InputDestinationRoute : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveGateway
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationroute.html#cfn-medialive-input-inputdestinationroute-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationroute.html#cfn-medialive-input-inputdestinationroute-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gateway { get; set; }
        }

        public class InputDestinationVpc : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone, IHaveNetworkInterfaceId
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationvpc.html#cfn-medialive-input-inputdestinationvpc-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationvpc.html#cfn-medialive-input-inputdestinationvpc-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceId { get; set; }
        }

        public class InputDeviceSettings : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdevicesettings.html#cfn-medialive-input-inputdevicesettings-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class InputSdpLocation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsdplocation.html#cfn-medialive-input-inputsdplocation-mediaindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MediaIndex { get; set; }
            /// <summary>
            /// SdpUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsdplocation.html#cfn-medialive-input-inputsdplocation-sdpurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SdpUrl { get; set; }
        }

        public class InputSource : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveUsername, IHavePasswordParam
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsource.html#cfn-medialive-input-inputsource-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsource.html#cfn-medialive-input-inputsource-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PasswordParam { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsource.html#cfn-medialive-input-inputsource-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class InputVpcRequest : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html#cfn-medialive-input-inputvpcrequest-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html#cfn-medialive-input-inputvpcrequest-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class MediaConnectFlow : Humidifier.Base.BaseSubResource, IHaveFlowArn
        {
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-mediaconnectflow.html#cfn-medialive-input-mediaconnectflow-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowArn { get; set; }
        }

        public class MulticastSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsettings.html#cfn-medialive-input-multicastsettings-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MulticastSource
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.MulticastSource> Sources { get; set; }
        }

        public class MulticastSource : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveSourceIp
        {
            /// <summary>
            /// SourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsource.html#cfn-medialive-input-multicastsource-sourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceIp { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsource.html#cfn-medialive-input-multicastsource-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class RouterDestinationSettings : Humidifier.Base.BaseSubResource, IHaveAvailabilityZoneName
        {
            /// <summary>
            /// RouterOutputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routerdestinationsettings.html#cfn-medialive-input-routerdestinationsettings-routeroutputarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RouterOutputArn { get; set; }
            /// <summary>
            /// AvailabilityZoneName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routerdestinationsettings.html#cfn-medialive-input-routerdestinationsettings-availabilityzonename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZoneName { get; set; }
        }

        public class RouterSettings : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveEncryptionType
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-secretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-encryptiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-destinations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RouterDestinationSettings
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.RouterDestinationSettings> Destinations { get; set; }
        }

        public class Smpte2110ReceiverGroup : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SdpSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroup.html#cfn-medialive-input-smpte2110receivergroup-sdpsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Smpte2110ReceiverGroupSdpSettings
            /// </summary>
            public Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSdpSettings SdpSettings { get; set; }
        }

        public class Smpte2110ReceiverGroupSdpSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioSdps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsdpsettings.html#cfn-medialive-input-smpte2110receivergroupsdpsettings-audiosdps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputSdpLocation
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.InputSdpLocation> AudioSdps { get; set; }
            /// <summary>
            /// AncillarySdps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsdpsettings.html#cfn-medialive-input-smpte2110receivergroupsdpsettings-ancillarysdps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputSdpLocation
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.InputSdpLocation> AncillarySdps { get; set; }
            /// <summary>
            /// VideoSdp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsdpsettings.html#cfn-medialive-input-smpte2110receivergroupsdpsettings-videosdp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputSdpLocation
            /// </summary>
            public Humidifier.MediaLive.InputTypes.InputSdpLocation VideoSdp { get; set; }
        }

        public class Smpte2110ReceiverGroupSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Smpte2110ReceiverGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsettings.html#cfn-medialive-input-smpte2110receivergroupsettings-smpte2110receivergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Smpte2110ReceiverGroup
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroup> Smpte2110ReceiverGroups { get; set; }
        }

        public class SrtCallerDecryption : Humidifier.Base.BaseSubResource, IHaveAlgorithm
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryption.html#cfn-medialive-input-srtcallerdecryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryption.html#cfn-medialive-input-srtcallerdecryption-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PassphraseSecretArn { get; set; }
        }

        public class SrtCallerSource : Humidifier.Base.BaseSubResource, IHaveStreamId
        {
            /// <summary>
            /// SrtListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-srtlistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SrtListenerPort { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatency { get; set; }
            /// <summary>
            /// SrtListenerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-srtlisteneraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SrtListenerAddress { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerDecryption
            /// </summary>
            public Humidifier.MediaLive.InputTypes.SrtCallerDecryption Decryption { get; set; }
        }

        public class SrtListenerDecryption : Humidifier.Base.BaseSubResource, IHaveAlgorithm
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenerdecryption.html#cfn-medialive-input-srtlistenerdecryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenerdecryption.html#cfn-medialive-input-srtlistenerdecryption-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PassphraseSecretArn { get; set; }
        }

        public class SrtListenerSettings : Humidifier.Base.BaseSubResource, IHaveStreamId
        {
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettings.html#cfn-medialive-input-srtlistenersettings-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettings.html#cfn-medialive-input-srtlistenersettings-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatency { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettings.html#cfn-medialive-input-srtlistenersettings-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerDecryption
            /// </summary>
            public Humidifier.MediaLive.InputTypes.SrtListenerDecryption Decryption { get; set; }
        }

        public class SrtSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SrtCallerSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettings.html#cfn-medialive-input-srtsettings-srtcallersources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SrtCallerSource
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.SrtCallerSource> SrtCallerSources { get; set; }
            /// <summary>
            /// SrtListenerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettings.html#cfn-medialive-input-srtsettings-srtlistenersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerSettings
            /// </summary>
            public Humidifier.MediaLive.InputTypes.SrtListenerSettings SrtListenerSettings { get; set; }
        }
    }
}