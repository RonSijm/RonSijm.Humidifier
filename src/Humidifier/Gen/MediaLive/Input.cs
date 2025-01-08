namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveType, IHaveRoleArn, IHaveDynamicTags
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
        public Humidifier.MediaLive.InputTypes.SrtSettingsRequest SrtSettings { get; set; }
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
        /// ItemType: InputDestinationRequest
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.InputDestinationRequest> Destinations { get; set; }
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
        /// ItemType: MediaConnectFlowRequest
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest> MediaConnectFlows { get; set; }
        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputSourceRequest
        /// </summary>
        public List<Humidifier.MediaLive.InputTypes.InputSourceRequest> Sources { get; set; }
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
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
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
        /// MulticastSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-multicastsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MulticastSettingsCreateRequest
        /// </summary>
        public Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest MulticastSettings { get; set; }
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
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
    }

    namespace InputTypes
    {
        public class InputDestinationRequest : Humidifier.Base.BaseSubResource, IHaveStreamName
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
            /// <summary>
            /// Network
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-network
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Network { get; set; }
            /// <summary>
            /// NetworkRoutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-networkroutes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputRequestDestinationRoute
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.InputRequestDestinationRoute> NetworkRoutes { get; set; }
            /// <summary>
            /// StaticIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html#cfn-medialive-input-inputdestinationrequest-staticipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticIpAddress { get; set; }
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
            public dynamic Id { get; set; }
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

        public class InputRequestDestinationRoute : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveGateway
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputrequestdestinationroute.html#cfn-medialive-input-inputrequestdestinationroute-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputrequestdestinationroute.html#cfn-medialive-input-inputrequestdestinationroute-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gateway { get; set; }
        }

        public class InputSourceRequest : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveUsername, IHavePasswordParam
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html#cfn-medialive-input-inputsourcerequest-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html#cfn-medialive-input-inputsourcerequest-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PasswordParam { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html#cfn-medialive-input-inputsourcerequest-url
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
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html#cfn-medialive-input-inputvpcrequest-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
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
            public dynamic FlowArn { get; set; }
        }

        public class MulticastSettingsCreateRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsettingscreaterequest.html#cfn-medialive-input-multicastsettingscreaterequest-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MulticastSourceCreateRequest
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.MulticastSourceCreateRequest> Sources { get; set; }
        }

        public class MulticastSettingsUpdateRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsettingsupdaterequest.html#cfn-medialive-input-multicastsettingsupdaterequest-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MulticastSourceUpdateRequest
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.MulticastSourceUpdateRequest> Sources { get; set; }
        }

        public class MulticastSourceCreateRequest : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveSourceIp
        {
            /// <summary>
            /// SourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourcecreaterequest.html#cfn-medialive-input-multicastsourcecreaterequest-sourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceIp { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourcecreaterequest.html#cfn-medialive-input-multicastsourcecreaterequest-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class MulticastSourceUpdateRequest : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveSourceIp
        {
            /// <summary>
            /// SourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourceupdaterequest.html#cfn-medialive-input-multicastsourceupdaterequest-sourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceIp { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-multicastsourceupdaterequest.html#cfn-medialive-input-multicastsourceupdaterequest-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class SrtCallerDecryptionRequest : Humidifier.Base.BaseSubResource, IHaveAlgorithm
        {
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryptionrequest.html#cfn-medialive-input-srtcallerdecryptionrequest-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// PassphraseSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallerdecryptionrequest.html#cfn-medialive-input-srtcallerdecryptionrequest-passphrasesecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PassphraseSecretArn { get; set; }
        }

        public class SrtCallerSourceRequest : Humidifier.Base.BaseSubResource, IHaveStreamId
        {
            /// <summary>
            /// SrtListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-srtlistenerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SrtListenerPort { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// MinimumLatency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-minimumlatency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatency { get; set; }
            /// <summary>
            /// SrtListenerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-srtlisteneraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SrtListenerAddress { get; set; }
            /// <summary>
            /// Decryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtcallersourcerequest.html#cfn-medialive-input-srtcallersourcerequest-decryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerDecryptionRequest
            /// </summary>
            public Humidifier.MediaLive.InputTypes.SrtCallerDecryptionRequest Decryption { get; set; }
        }

        public class SrtSettingsRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SrtCallerSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-srtsettingsrequest.html#cfn-medialive-input-srtsettingsrequest-srtcallersources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SrtCallerSourceRequest
            /// </summary>
            public List<Humidifier.MediaLive.InputTypes.SrtCallerSourceRequest> SrtCallerSources { get; set; }
        }
    }
}