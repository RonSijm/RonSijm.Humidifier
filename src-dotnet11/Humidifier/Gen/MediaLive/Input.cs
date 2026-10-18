namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMediaLiveInputTypesSrtSettingsRequestSrtSettings, IHaveInputNetworkLocation, IHaveListOfMediaLiveInputTypesInputDestinationRequestDestinations, IHaveMediaLiveInputTypesInputVpcRequestVpc, IHaveListOfMediaLiveInputTypesMediaConnectFlowRequestMediaConnectFlows, IHaveListOfMediaLiveInputTypesInputSourceRequestSources, IHaveRoleArn, IHaveName, IHaveMediaLiveInputTypesRouterSettingsRouterSettings, IHaveType, IHaveMediaLiveInputTypesSmpte2110ReceiverGroupSettingsSmpte2110ReceiverGroupSettings, IHaveStringListOfSdiSources, IHaveStringListOfInputSecurityGroups, IHaveMediaLiveInputTypesMulticastSettingsCreateRequestMulticastSettings, IHaveListOfMediaLiveInputTypesInputDeviceSettingsInputDevices, IHaveTags_Json
    {
        public class Attributes
        {
            public static string Destinations =  "Destinations" ;
            public static string Arn =  "Arn" ;
            public static string Sources =  "Sources" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Input; }
        /// <summary>
        /// SrtSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-srtsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SrtSettingsRequest
        /// </summary>
        public Union<Humidifier.MediaLive.InputTypes.SrtSettingsRequest, BaseFunction>? SrtSettings { get; set; }
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
        /// ItemType: InputDestinationRequest
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputDestinationRequest>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputDestinationRequest, BaseFunction>>, BaseFunction>? Destinations { get; set; }
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
        /// ItemType: MediaConnectFlowRequest
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest, BaseFunction>>, BaseFunction>? MediaConnectFlows { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSourceRequest
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputSourceRequest>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputSourceRequest, BaseFunction>>, BaseFunction>? Sources { get; set; }
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
        /// InputSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InputSecurityGroups { get; set; }
        /// <summary>
        /// MulticastSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-multicastsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MulticastSettingsCreateRequest
        /// </summary>
        public Union<Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest, BaseFunction>? MulticastSettings { get; set; }
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
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
    }

    namespace InputTypes
    {
        public class InputDestinationRequest : Humidifier.Base.BaseSubResource, IHaveStreamName, IHaveNetwork, IHaveListOfMediaLiveInputTypesInputRequestDestinationRouteNetworkRoutes, IHaveStaticIpAddress
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
            /// <summary>
            /// Network
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-network
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Network { get; set; }
            /// <summary>
            /// NetworkRoutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-networkroutes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputRequestDestinationRoute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.InputRequestDestinationRoute>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.InputRequestDestinationRoute, BaseFunction>>, BaseFunction>? NetworkRoutes { get; set; }
            /// <summary>
            /// StaticIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-staticipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StaticIpAddress { get; set; }
        }

        public class InputDeviceRequest : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdevicerequest.html#cfn-medialive-input-inputdevicerequest-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
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

        public class InputRequestDestinationRoute : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveGateway
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputrequestdestinationroute.html#cfn-medialive-input-inputrequestdestinationroute-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputrequestdestinationroute.html#cfn-medialive-input-inputrequestdestinationroute-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gateway { get; set; }
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

        public class InputSourceRequest : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePasswordParam, IHaveUrl
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html#cfn-medialive-input-inputsourcerequest-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html#cfn-medialive-input-inputsourcerequest-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PasswordParam { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html#cfn-medialive-input-inputsourcerequest-url
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
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html#cfn-medialive-input-inputvpcrequest-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class MediaConnectFlowRequest : Humidifier.Base.BaseSubResource, IHaveFlowArn
        {
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-mediaconnectflowrequest.html#cfn-medialive-input-mediaconnectflowrequest-flowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowArn { get; set; }
        }

        public class MulticastSettingsCreateRequest : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesMulticastSourceCreateRequestSources
        {
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsettingscreaterequest.html#cfn-medialive-input-multicastsettingscreaterequest-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MulticastSourceCreateRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.MulticastSourceCreateRequest>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.MulticastSourceCreateRequest, BaseFunction>>, BaseFunction>? Sources { get; set; }
        }

        public class MulticastSettingsUpdateRequest : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesMulticastSourceUpdateRequestSources
        {
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsettingsupdaterequest.html#cfn-medialive-input-multicastsettingsupdaterequest-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MulticastSourceUpdateRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.MulticastSourceUpdateRequest>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.MulticastSourceUpdateRequest, BaseFunction>>, BaseFunction>? Sources { get; set; }
        }

        public class MulticastSourceCreateRequest : Humidifier.Base.BaseSubResource, IHaveSourceIp, IHaveUrl
        {
            /// <summary>
            /// SourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourcecreaterequest.html#cfn-medialive-input-multicastsourcecreaterequest-sourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIp { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourcecreaterequest.html#cfn-medialive-input-multicastsourcecreaterequest-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class MulticastSourceUpdateRequest : Humidifier.Base.BaseSubResource, IHaveSourceIp, IHaveUrl
        {
            /// <summary>
            /// SourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourceupdaterequest.html#cfn-medialive-input-multicastsourceupdaterequest-sourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIp { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourceupdaterequest.html#cfn-medialive-input-multicastsourceupdaterequest-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class RouterDestinationSettings : Humidifier.Base.BaseSubResource, IHaveAvailabilityZoneName
        {
            /// <summary>
            /// AvailabilityZoneName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routerdestinationsettings.html#cfn-medialive-input-routerdestinationsettings-availabilityzonename
            /// Required: False
            /// UpdateType: Mutable
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
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-routersettings.html#cfn-medialive-input-routersettings-destinations
            /// Required: False
            /// UpdateType: Mutable
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

        public class SpecialRouterSettings : Humidifier.Base.BaseSubResource, IHaveRouterArn
        {
            /// <summary>
            /// RouterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-specialroutersettings.html#cfn-medialive-input-specialroutersettings-routerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RouterArn { get; set; }
        }

        public class SrtCallerDecryptionRequest : Humidifier.Base.BaseSubResource, IHaveAlgorithm, IHavePassphraseSecretArn
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryptionrequest.html#cfn-medialive-input-srtcallerdecryptionrequest-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryptionrequest.html#cfn-medialive-input-srtcallerdecryptionrequest-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassphraseSecretArn { get; set; }
        }

        public class SrtCallerSourceRequest : Humidifier.Base.BaseSubResource, IHaveSrtListenerPort, IHaveStreamId, IHaveMinimumLatency_Integer, IHaveSrtListenerAddress, IHaveMediaLiveInputTypesSrtCallerDecryptionRequestDecryption
        {
            /// <summary>
            /// SrtListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-srtlistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SrtListenerPort { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatency { get; set; }
            /// <summary>
            /// SrtListenerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-srtlisteneraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SrtListenerAddress { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerDecryptionRequest
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.SrtCallerDecryptionRequest, BaseFunction>? Decryption { get; set; }
        }

        public class SrtListenerDecryptionRequest : Humidifier.Base.BaseSubResource, IHaveAlgorithm, IHavePassphraseSecretArn
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenerdecryptionrequest.html#cfn-medialive-input-srtlistenerdecryptionrequest-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenerdecryptionrequest.html#cfn-medialive-input-srtlistenerdecryptionrequest-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassphraseSecretArn { get; set; }
        }

        public class SrtListenerSettingsRequest : Humidifier.Base.BaseSubResource, IHaveStreamId, IHaveMinimumLatency_Integer, IHaveMediaLiveInputTypesSrtListenerDecryptionRequestDecryption
        {
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettingsrequest.html#cfn-medialive-input-srtlistenersettingsrequest-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettingsrequest.html#cfn-medialive-input-srtlistenersettingsrequest-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumLatency { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtlistenersettingsrequest.html#cfn-medialive-input-srtlistenersettingsrequest-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerDecryptionRequest
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest, BaseFunction>? Decryption { get; set; }
        }

        public class SrtSettingsRequest : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveInputTypesSrtCallerSourceRequestSrtCallerSources, IHaveMediaLiveInputTypesSrtListenerSettingsRequestSrtListenerSettings
        {
            /// <summary>
            /// SrtCallerSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettingsrequest.html#cfn-medialive-input-srtsettingsrequest-srtcallersources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SrtCallerSourceRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.InputTypes.SrtCallerSourceRequest>, IReadOnlyList<Union<Humidifier.MediaLive.InputTypes.SrtCallerSourceRequest, BaseFunction>>, BaseFunction>? SrtCallerSources { get; set; }
            /// <summary>
            /// SrtListenerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettingsrequest.html#cfn-medialive-input-srtsettingsrequest-srtlistenersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerSettingsRequest
            /// </summary>
            public Union<Humidifier.MediaLive.InputTypes.SrtListenerSettingsRequest, BaseFunction>? SrtListenerSettings { get; set; }
        }
    }
}