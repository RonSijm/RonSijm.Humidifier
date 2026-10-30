namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using SourceEndpointTypes;

    public class SourceEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRegionName
    {
        public class Attributes
        {
            public static string AssociatedResourceDetails =  "AssociatedResourceDetails" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string SourceType =  "SourceType" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Name =  "Name" ;
            public static string RegistrationState =  "RegistrationState" ;
            public static string LifecycleManagement =  "LifecycleManagement" ;
            public static string ConnectionState =  "ConnectionState" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.SourceEndpoint; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-sourceendpoint.html#cfn-mediaconnect-sourceendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-sourceendpoint.html#cfn-mediaconnect-sourceendpoint-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SourceEndpointConfiguration
        /// </summary>
        [Required]
        public Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration Configuration { get; set; }
        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-sourceendpoint.html#cfn-mediaconnect-sourceendpoint-regionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegionName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-sourceendpoint.html#cfn-mediaconnect-sourceendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SourceEndpointTypes
    {
        public class EndpointEncryptionSecretConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-endpointencryptionsecretconfiguration.html#cfn-mediaconnect-sourceendpoint-endpointencryptionsecretconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
        }

        public class PublicSourceEndpointNetworkingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceAllowRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-publicsourceendpointnetworkingconfiguration.html#cfn-mediaconnect-sourceendpoint-publicsourceendpointnetworkingconfiguration-sourceallowrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PublicSourceEndpointNetworkingConfigurationAllowRule
            /// </summary>
            public List<Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfigurationAllowRule> SourceAllowRules { get; set; }
        }

        public class PublicSourceEndpointNetworkingConfigurationAllowRule : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-publicsourceendpointnetworkingconfigurationallowrule.html#cfn-mediaconnect-sourceendpoint-publicsourceendpointnetworkingconfigurationallowrule-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }

        public class RistStandardSourceEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-riststandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-riststandardsourceendpointconfiguration-destinationingestport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationIngestPort { get; set; }
            /// <summary>
            /// RecoveryLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-riststandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-riststandardsourceendpointconfiguration-recoverylatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RecoveryLatencyMilliseconds { get; set; }
        }

        public class RouterOutputSourceEndpointAssociatedResourceDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveState, IHaveMaximumBitrate
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-routeroutputsourceendpointassociatedresourcedetails.html#cfn-mediaconnect-sourceendpoint-routeroutputsourceendpointassociatedresourcedetails-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-routeroutputsourceendpointassociatedresourcedetails.html#cfn-mediaconnect-sourceendpoint-routeroutputsourceendpointassociatedresourcedetails-maximumbitrate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumBitrate { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-routeroutputsourceendpointassociatedresourcedetails.html#cfn-mediaconnect-sourceendpoint-routeroutputsourceendpointassociatedresourcedetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RouterOutputSourceEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RouterOutputArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-routeroutputsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-routeroutputsourceendpointconfiguration-routeroutputarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RouterOutputArn { get; set; }
        }

        public class RtpStandardSourceEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-rtpstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-rtpstandardsourceendpointconfiguration-destinationingestport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationIngestPort { get; set; }
            /// <summary>
            /// ForwardErrorCorrectionState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-rtpstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-rtpstandardsourceendpointconfiguration-forwarderrorcorrectionstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ForwardErrorCorrectionState { get; set; }
        }

        public class SourceEndpointAssociatedResourceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-sourceendpointassociatedresourcedetails.html#cfn-mediaconnect-sourceendpoint-sourceendpointassociatedresourcedetails-standard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Standard { get; set; }
            /// <summary>
            /// RouterOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-sourceendpointassociatedresourcedetails.html#cfn-mediaconnect-sourceendpoint-sourceendpointassociatedresourcedetails-routeroutput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RouterOutputSourceEndpointAssociatedResourceDetails
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointAssociatedResourceDetails RouterOutput { get; set; }
        }

        public class SourceEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Standard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-sourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-sourceendpointconfiguration-standard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StandardSourceEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.StandardSourceEndpointConfiguration Standard { get; set; }
            /// <summary>
            /// RouterOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-sourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-sourceendpointconfiguration-routeroutput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RouterOutputSourceEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.RouterOutputSourceEndpointConfiguration RouterOutput { get; set; }
        }

        public class SrtCallerStandardSourceEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationIngestPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtcallerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtcallerstandardsourceendpointconfiguration-destinationingestport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationIngestPort { get; set; }
            /// <summary>
            /// EncryptionPassphrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtcallerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtcallerstandardsourceendpointconfiguration-encryptionpassphrase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EndpointEncryptionSecretConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration EncryptionPassphrase { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtcallerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtcallerstandardsourceendpointconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatencyMilliseconds { get; set; }
        }

        public class SrtListenerStandardSourceEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamId, IHaveSourceListenerPort
        {
            /// <summary>
            /// SourceAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration-sourceaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceAddress { get; set; }
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration-streamid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// EncryptionPassphrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration-encryptionpassphrase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EndpointEncryptionSecretConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration EncryptionPassphrase { get; set; }
            /// <summary>
            /// SourceListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration-sourcelistenerport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SourceListenerPort { get; set; }
            /// <summary>
            /// MinimumLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-srtlistenerstandardsourceendpointconfiguration-minimumlatencymilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumLatencyMilliseconds { get; set; }
        }

        public class StandardSourceEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveProtocol
        {
            /// <summary>
            /// ProtocolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointconfiguration-protocolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StandardSourceEndpointProtocolConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.StandardSourceEndpointProtocolConfiguration ProtocolConfiguration { get; set; }
            /// <summary>
            /// SourceNetworkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointconfiguration-sourcenetworkingconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StandardSourceEndpointNetworkingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.StandardSourceEndpointNetworkingConfiguration SourceNetworkingConfiguration { get; set; }
            /// <summary>
            /// SourceNetworkingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointconfiguration-sourcenetworkingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceNetworkingType { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class StandardSourceEndpointNetworkingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointnetworkingconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointnetworkingconfiguration-vpc
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcSourceEndpointNetworkingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.VpcSourceEndpointNetworkingConfiguration Vpc { get; set; }
            /// <summary>
            /// Public
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointnetworkingconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointnetworkingconfiguration-public
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicSourceEndpointNetworkingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.PublicSourceEndpointNetworkingConfiguration Public { get; set; }
        }

        public class StandardSourceEndpointProtocolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SrtCaller
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration-srtcaller
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtCallerStandardSourceEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.SrtCallerStandardSourceEndpointConfiguration SrtCaller { get; set; }
            /// <summary>
            /// SrtListener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration-srtlistener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SrtListenerStandardSourceEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.SrtListenerStandardSourceEndpointConfiguration SrtListener { get; set; }
            /// <summary>
            /// Rist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration-rist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RistStandardSourceEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.RistStandardSourceEndpointConfiguration Rist { get; set; }
            /// <summary>
            /// Rtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration.html#cfn-mediaconnect-sourceendpoint-standardsourceendpointprotocolconfiguration-rtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RtpStandardSourceEndpointConfiguration
            /// </summary>
            public Humidifier.MediaConnect.SourceEndpointTypes.RtpStandardSourceEndpointConfiguration Rtp { get; set; }
        }

        public class VpcSourceEndpointNetworkingConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetId
        {
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-vpcsourceendpointnetworkingconfiguration.html#cfn-mediaconnect-sourceendpoint-vpcsourceendpointnetworkingconfiguration-subnetid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-sourceendpoint-vpcsourceendpointnetworkingconfiguration.html#cfn-mediaconnect-sourceendpoint-vpcsourceendpointnetworkingconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}