namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using DestinationEndpointTypes;

    public class DestinationEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRegionName
    {
        public class Attributes
        {
            public static string AssociatedResourceDetails =  "AssociatedResourceDetails" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string DestinationType =  "DestinationType" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Name =  "Name" ;
            public static string RegistrationState =  "RegistrationState" ;
            public static string LifecycleManagement =  "LifecycleManagement" ;
            public static string ConnectionState =  "ConnectionState" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.DestinationEndpoint; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-destinationendpoint.html#cfn-mediaconnect-destinationendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-destinationendpoint.html#cfn-mediaconnect-destinationendpoint-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DestinationEndpointConfiguration
        /// </summary>
        [Required]
        public Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration Configuration { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-destinationendpoint.html#cfn-mediaconnect-destinationendpoint-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegionName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-destinationendpoint.html#cfn-mediaconnect-destinationendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DestinationEndpointTypes
    {
        public class DestinationEndpointAssociatedResourceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-destinationendpointassociatedresourcedetails.html#cfn-mediaconnect-destinationendpoint-destinationendpointassociatedresourcedetails-standard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Standard { get; set; }
            /// <summary>
            /// RouterInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-destinationendpointassociatedresourcedetails.html#cfn-mediaconnect-destinationendpoint-destinationendpointassociatedresourcedetails-routerinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RouterInputDestinationEndpointAssociatedResourceDetails
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointAssociatedResourceDetails RouterInput { get; set; }
        }

        public class DestinationEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-destinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-destinationendpointconfiguration-standard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardDestinationEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.StandardDestinationEndpointConfiguration Standard { get; set; }
            /// <summary>
            /// RouterInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-destinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-destinationendpointconfiguration-routerinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RouterInputDestinationEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.RouterInputDestinationEndpointConfiguration RouterInput { get; set; }
        }

        public class EndpointEncryptionSecretConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-endpointencryptionsecretconfiguration.html#cfn-mediaconnect-destinationendpoint-endpointencryptionsecretconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
        }

        public class PublicDestinationEndpointNetworkingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationAllowRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-publicdestinationendpointnetworkingconfiguration.html#cfn-mediaconnect-destinationendpoint-publicdestinationendpointnetworkingconfiguration-destinationallowrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PublicDestinationEndpointNetworkingConfigurationAllowRule
            /// </summary>
            public List<Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfigurationAllowRule> DestinationAllowRules { get; set; }
        }

        public class PublicDestinationEndpointNetworkingConfigurationAllowRule : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-publicdestinationendpointnetworkingconfigurationallowrule.html#cfn-mediaconnect-destinationendpoint-publicdestinationendpointnetworkingconfigurationallowrule-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }

        public class RistStandardDestinationEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-riststandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-riststandarddestinationendpointconfiguration-destinationingestport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationIngestPort { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-riststandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-riststandarddestinationendpointconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationAddress { get; set; }
        }

        public class RouterInputDestinationEndpointAssociatedResourceDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveState, IHaveMaximumBitrate
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-routerinputdestinationendpointassociatedresourcedetails.html#cfn-mediaconnect-destinationendpoint-routerinputdestinationendpointassociatedresourcedetails-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-routerinputdestinationendpointassociatedresourcedetails.html#cfn-mediaconnect-destinationendpoint-routerinputdestinationendpointassociatedresourcedetails-maximumbitrate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumBitrate { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-routerinputdestinationendpointassociatedresourcedetails.html#cfn-mediaconnect-destinationendpoint-routerinputdestinationendpointassociatedresourcedetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RouterInputDestinationEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RouterInputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-routerinputdestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-routerinputdestinationendpointconfiguration-routerinputarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RouterInputArn { get; set; }
        }

        public class RtpStandardDestinationEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-rtpstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-rtpstandarddestinationendpointconfiguration-destinationingestport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationIngestPort { get; set; }
            /// <summary>
            /// ForwardErrorCorrectionState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-rtpstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-rtpstandarddestinationendpointconfiguration-forwarderrorcorrectionstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ForwardErrorCorrectionState { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-rtpstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-rtpstandarddestinationendpointconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationAddress { get; set; }
        }

        public class SrtCallerStandardDestinationEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceListenerPort
        {
            /// <summary>
            /// EncryptionPassphrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtcallerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtcallerstandarddestinationendpointconfiguration-encryptionpassphrase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EndpointEncryptionSecretConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration EncryptionPassphrase { get; set; }
            /// <summary>
            /// SourceListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtcallerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtcallerstandarddestinationendpointconfiguration-sourcelistenerport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SourceListenerPort { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtcallerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtcallerstandarddestinationendpointconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatencyMilliseconds { get; set; }
        }

        public class SrtListenerStandardDestinationEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamId
        {
            /// <summary>
            /// DestinationIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration-destinationingestport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationIngestPort { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// EncryptionPassphrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration-encryptionpassphrase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EndpointEncryptionSecretConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration EncryptionPassphrase { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatencyMilliseconds { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-srtlistenerstandarddestinationendpointconfiguration-destinationaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationAddress { get; set; }
        }

        public class StandardDestinationEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveProtocol
        {
            /// <summary>
            /// DestinationNetworkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration-destinationnetworkingconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StandardDestinationEndpointNetworkingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.StandardDestinationEndpointNetworkingConfiguration DestinationNetworkingConfiguration { get; set; }
            /// <summary>
            /// ProtocolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration-protocolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StandardDestinationEndpointProtocolConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.StandardDestinationEndpointProtocolConfiguration ProtocolConfiguration { get; set; }
            /// <summary>
            /// DestinationNetworkingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration-destinationnetworkingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationNetworkingType { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StandardDestinationEndpointNetworkingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointnetworkingconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointnetworkingconfiguration-vpc
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcDestinationEndpointNetworkingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.VpcDestinationEndpointNetworkingConfiguration Vpc { get; set; }
            /// <summary>
            /// Public
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointnetworkingconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointnetworkingconfiguration-public
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicDestinationEndpointNetworkingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.PublicDestinationEndpointNetworkingConfiguration Public { get; set; }
        }

        public class StandardDestinationEndpointProtocolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerStandardDestinationEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.SrtCallerStandardDestinationEndpointConfiguration SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerStandardDestinationEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.SrtListenerStandardDestinationEndpointConfiguration SrtListener { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistStandardDestinationEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.RistStandardDestinationEndpointConfiguration Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration.html#cfn-mediaconnect-destinationendpoint-standarddestinationendpointprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpStandardDestinationEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.DestinationEndpointTypes.RtpStandardDestinationEndpointConfiguration Rtp { get; set; }
        }

        public class VpcDestinationEndpointNetworkingConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetId
        {
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-vpcdestinationendpointnetworkingconfiguration.html#cfn-mediaconnect-destinationendpoint-vpcdestinationendpointnetworkingconfiguration-subnetid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-destinationendpoint-vpcdestinationendpointnetworkingconfiguration.html#cfn-mediaconnect-destinationendpoint-vpcdestinationendpointnetworkingconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}