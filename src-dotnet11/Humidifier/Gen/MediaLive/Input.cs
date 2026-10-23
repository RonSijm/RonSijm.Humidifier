namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMediaLiveInputTypesSrtSettingsSrtSettings, IHaveInputNetworkLocation, IHaveListOfMediaLiveInputTypesInputDestinationDestinations, IHaveMediaLiveInputTypesInputVpcRequestVpc, IHaveListOfMediaLiveInputTypesMediaConnectFlowMediaConnectFlows, IHaveListOfMediaLiveInputTypesInputSourceSources, IHaveRoleArn, IHaveName, IHaveMediaLiveInputTypesRouterSettingsRouterSettings, IHaveType, IHaveMediaLiveInputTypesSmpte2110ReceiverGroupSettingsSmpte2110ReceiverGroupSettings, IHaveStringListOfSdiSources, IHaveMediaLiveInputTypesMulticastSettingsMulticastSettings, IHaveStringListOfInputSecurityGroups, IHaveListOfMediaLiveInputTypesInputDeviceSettingsInputDevices, IHaveStringDictionaryOfTags
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
        public Union<Humidifier.MediaLive.InputTypes.SrtSettings, BaseFunction>? SrtSettings { get; set; }
        /// <summary>
        /// InputNetworkLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputnetworklocation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InputNetworkLocation { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputDestination>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        /// <summary>
        /// Vpc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-vpc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InputVpcRequest
        /// </summary>
        public Union<Humidifier.MediaLive.InputTypes.InputVpcRequest, BaseFunction>? Vpc { get; set; }
        /// <summary>
        /// MediaConnectFlows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-mediaconnectflows
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaConnectFlow
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.MediaConnectFlow>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.MediaConnectFlow, BaseFunction>>, BaseFunction>? MediaConnectFlows { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputSource>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RouterSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-routersettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RouterSettings
        /// </summary>
        public Union<Humidifier.MediaLive.InputTypes.RouterSettings, BaseFunction>? RouterSettings { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Smpte2110ReceiverGroupSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-smpte2110receivergroupsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Smpte2110ReceiverGroupSettings
        /// </summary>
        public Union<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSettings, BaseFunction>? Smpte2110ReceiverGroupSettings { get; set; }
        /// <summary>
        /// SdiSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sdisources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SdiSources { get; set; }
        /// <summary>
        /// MulticastSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-multicastsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MulticastSettings
        /// </summary>
        public Union<Humidifier.MediaLive.InputTypes.MulticastSettings, BaseFunction>? MulticastSettings { get; set; }
        /// <summary>
        /// InputSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InputSecurityGroups { get; set; }
        /// <summary>
        /// InputDevices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputdevices
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputDeviceSettings
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputDeviceSettings>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputDeviceSettings, BaseFunction>>, BaseFunction>? InputDevices { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InputTypes
    {
        public class InputDestination : Humidifier.Base.BaseSubResource, IHaveStreamName, IHaveIp, IHavePort, IHaveNetwork, IHaveMediaLiveInputTypesInputDestinationVpcVpc, IHaveListOfMediaLiveInputTypesInputDestinationRouteNetworkRoutes, IHaveStaticIpAddress, IHaveUrl
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
            /// <summary>
            /// Ip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ip { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Network
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-network
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Network { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputDestinationVpc
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.InputDestinationVpc, BaseFunction>? Vpc { get; set; }
            /// <summary>
            /// NetworkRoutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-networkroutes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputDestinationRoute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputDestinationRoute>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputDestinationRoute, BaseFunction>>, BaseFunction>? NetworkRoutes { get; set; }
            /// <summary>
            /// StaticIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-staticipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StaticIpAddress { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestination.html#cfn-medialive-input-inputdestination-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
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
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationroute.html#cfn-medialive-input-inputdestinationroute-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gateway { get; set; }
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
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationvpc.html#cfn-medialive-input-inputdestinationvpc-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
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
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class InputSdpLocation : Humidifier.Base.BaseSubResource, IHaveMediaIndex_Integer, IHaveSdpUrl
        {
            /// <summary>
            /// MediaIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsdplocation.html#cfn-medialive-input-inputsdplocation-mediaindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MediaIndex { get; set; }
            /// <summary>
            /// SdpUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsdplocation.html#cfn-medialive-input-inputsdplocation-sdpurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SdpUrl { get; set; }
        }

        public class InputSource : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePasswordParam, IHaveUrl
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsource.html#cfn-medialive-input-inputsource-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsource.html#cfn-medialive-input-inputsource-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PasswordParam { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsource.html#cfn-medialive-input-inputsource-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class InputVpcRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html#cfn-medialive-input-inputvpcrequest-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html#cfn-medialive-input-inputvpcrequest-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
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
            public Union<string, BaseFunction>? FlowArn { get; set; }
        }

        public class MulticastSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesMulticastSourceSources
        {
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsettings.html#cfn-medialive-input-multicastsettings-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MulticastSource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.MulticastSource>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.MulticastSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        }

        public class MulticastSource : Humidifier.Base.BaseSubResource, IHaveSourceIp, IHaveUrl
        {
            /// <summary>
            /// SourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsource.html#cfn-medialive-input-multicastsource-sourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIp { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsource.html#cfn-medialive-input-multicastsource-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class RouterDestinationSettings : Humidifier.Base.BaseSubResource, IHaveRouterOutputArn, IHaveAvailabilityZoneName
        {
            /// <summary>
            /// RouterOutputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routerdestinationsettings.html#cfn-medialive-input-routerdestinationsettings-routeroutputarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RouterOutputArn { get; set; }
            /// <summary>
            /// AvailabilityZoneName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routerdestinationsettings.html#cfn-medialive-input-routerdestinationsettings-availabilityzonename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneName { get; set; }
        }

        public class RouterSettings : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveEncryptionType, IHaveListOfMediaLiveInputTypesRouterDestinationSettingsDestinations
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-secretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-encryptiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-destinations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RouterDestinationSettings
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.RouterDestinationSettings>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.RouterDestinationSettings, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        }

        public class Smpte2110ReceiverGroup : Humidifier.Base.BaseSubResource, IHaveMediaLiveInputTypesSmpte2110ReceiverGroupSdpSettingsSdpSettings
        {
            /// <summary>
            /// SdpSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroup.html#cfn-medialive-input-smpte2110receivergroup-sdpsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Smpte2110ReceiverGroupSdpSettings
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroupSdpSettings, BaseFunction>? SdpSettings { get; set; }
        }

        public class Smpte2110ReceiverGroupSdpSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesInputSdpLocationAudioSdps, IHaveListOfMediaLiveInputTypesInputSdpLocationAncillarySdps, IHaveMediaLiveInputTypesInputSdpLocationVideoSdp
        {
            /// <summary>
            /// AudioSdps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsdpsettings.html#cfn-medialive-input-smpte2110receivergroupsdpsettings-audiosdps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputSdpLocation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputSdpLocation>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputSdpLocation, BaseFunction>>, BaseFunction>? AudioSdps { get; set; }
            /// <summary>
            /// AncillarySdps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsdpsettings.html#cfn-medialive-input-smpte2110receivergroupsdpsettings-ancillarysdps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputSdpLocation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputSdpLocation>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputSdpLocation, BaseFunction>>, BaseFunction>? AncillarySdps { get; set; }
            /// <summary>
            /// VideoSdp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsdpsettings.html#cfn-medialive-input-smpte2110receivergroupsdpsettings-videosdp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputSdpLocation
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.InputSdpLocation, BaseFunction>? VideoSdp { get; set; }
        }

        public class Smpte2110ReceiverGroupSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesSmpte2110ReceiverGroupSmpte2110ReceiverGroups
        {
            /// <summary>
            /// Smpte2110ReceiverGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-smpte2110receivergroupsettings.html#cfn-medialive-input-smpte2110receivergroupsettings-smpte2110receivergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Smpte2110ReceiverGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroup>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.Smpte2110ReceiverGroup, BaseFunction>>, BaseFunction>? Smpte2110ReceiverGroups { get; set; }
        }

        public class SrtCallerDecryption : Humidifier.Base.BaseSubResource, IHaveAlgorithm, IHavePassphraseSecretArn
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryption.html#cfn-medialive-input-srtcallerdecryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryption.html#cfn-medialive-input-srtcallerdecryption-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassphraseSecretArn { get; set; }
        }

        public class SrtCallerSource : Humidifier.Base.BaseSubResource, IHaveSrtListenerPort, IHaveStreamId, IHaveMinimumLatency_Integer, IHaveSrtListenerAddress, IHaveMediaLiveInputTypesSrtCallerDecryptionDecryption
        {
            /// <summary>
            /// SrtListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-srtlistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SrtListenerPort { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatency { get; set; }
            /// <summary>
            /// SrtListenerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-srtlisteneraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SrtListenerAddress { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersource.html#cfn-medialive-input-srtcallersource-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerDecryption
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.SrtCallerDecryption, BaseFunction>? Decryption { get; set; }
        }

        public class SrtListenerDecryption : Humidifier.Base.BaseSubResource, IHaveAlgorithm, IHavePassphraseSecretArn
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenerdecryption.html#cfn-medialive-input-srtlistenerdecryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenerdecryption.html#cfn-medialive-input-srtlistenerdecryption-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassphraseSecretArn { get; set; }
        }

        public class SrtListenerSettings : Humidifier.Base.BaseSubResource, IHaveStreamId, IHaveMinimumLatency_Integer, IHaveMediaLiveInputTypesSrtListenerDecryptionDecryption
        {
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettings.html#cfn-medialive-input-srtlistenersettings-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettings.html#cfn-medialive-input-srtlistenersettings-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatency { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettings.html#cfn-medialive-input-srtlistenersettings-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerDecryption
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.SrtListenerDecryption, BaseFunction>? Decryption { get; set; }
        }

        public class SrtSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesSrtCallerSourceSrtCallerSources, IHaveMediaLiveInputTypesSrtListenerSettingsSrtListenerSettings
        {
            /// <summary>
            /// SrtCallerSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettings.html#cfn-medialive-input-srtsettings-srtcallersources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SrtCallerSource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.SrtCallerSource>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.SrtCallerSource, BaseFunction>>, BaseFunction>? SrtCallerSources { get; set; }
            /// <summary>
            /// SrtListenerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettings.html#cfn-medialive-input-srtsettings-srtlistenersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerSettings
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.SrtListenerSettings, BaseFunction>? SrtListenerSettings { get; set; }
        }
    }
}