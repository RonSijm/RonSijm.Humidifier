namespace Humidifier.MediaConnect
{
    using System.Collections.Generic;
    using FlowOutputTypes;

    public class FlowOutput : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHavePort, IHaveProtocol, IHaveDestination, IHaveFlowArn, IHaveStreamId, IHaveMinLatency, IHaveMaxLatency
    {
        public class Attributes
        {
            public static string OutputArn =  "OutputArn" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.FlowOutput; }
        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-destination
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Destination { get; set; }
        /// <summary>
        /// SmoothingLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-smoothinglatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SmoothingLatency { get; set; }
        /// <summary>
        /// StreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-streamid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StreamId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Port { get; set; }
        /// <summary>
        /// RemoteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-remoteid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RemoteId { get; set; }
        /// <summary>
        /// MediaStreamOutputConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaStreamOutputConfiguration
        /// </summary>
        public List<Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration> MediaStreamOutputConfigurations { get; set; }
        /// <summary>
        /// Encryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-encryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Encryption
        /// </summary>
        public Humidifier.MediaConnect.FlowOutputTypes.Encryption Encryption { get; set; }
        /// <summary>
        /// OutputStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-outputstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OutputStatus { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcInterfaceAttachment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-vpcinterfaceattachment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcInterfaceAttachment
        /// </summary>
        public Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment VpcInterfaceAttachment { get; set; }
        /// <summary>
        /// MinLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-minlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinLatency { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Protocol { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-flowarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FlowArn { get; set; }
        /// <summary>
        /// MaxLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-maxlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxLatency { get; set; }
        /// <summary>
        /// CidrAllowList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-cidrallowlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic CidrAllowList { get; set; }
    }

    namespace FlowOutputTypes
    {
        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveDestinationPort, IHaveDestinationIp
        {
            /// <summary>
            /// DestinationIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-destinationconfiguration.html#cfn-mediaconnect-flowoutput-destinationconfiguration-destinationip
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationIp { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-destinationconfiguration.html#cfn-mediaconnect-flowoutput-destinationconfiguration-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DestinationPort { get; set; }
            /// <summary>
            /// Interface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-destinationconfiguration.html#cfn-mediaconnect-flowoutput-destinationconfiguration-interface
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Interface
            /// </summary>
            public Humidifier.MediaConnect.FlowOutputTypes.Interface Interface { get; set; }
        }

        public class EncodingParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EncoderProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encodingparameters.html#cfn-mediaconnect-flowoutput-encodingparameters-encoderprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncoderProfile { get; set; }
            /// <summary>
            /// CompressionFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encodingparameters.html#cfn-mediaconnect-flowoutput-encodingparameters-compressionfactor
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CompressionFactor { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecretArn, IHaveKeyType, IHaveAlgorithm
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class Interface : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-interface.html#cfn-mediaconnect-flowoutput-interface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MediaStreamOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaStreamName, IHaveEncodingName
        {
            /// <summary>
            /// EncodingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-encodingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncodingParameters
            /// </summary>
            public Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters EncodingParameters { get; set; }
            /// <summary>
            /// MediaStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-mediastreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaStreamName { get; set; }
            /// <summary>
            /// EncodingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-encodingname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncodingName { get; set; }
            /// <summary>
            /// DestinationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-destinationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DestinationConfiguration
            /// </summary>
            public List<Humidifier.MediaConnect.FlowOutputTypes.DestinationConfiguration> DestinationConfigurations { get; set; }
        }

        public class VpcInterfaceAttachment : Humidifier.Base.BaseSubResource, IHaveVpcInterfaceName
        {
            /// <summary>
            /// VpcInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-vpcinterfaceattachment.html#cfn-mediaconnect-flowoutput-vpcinterfaceattachment-vpcinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcInterfaceName { get; set; }
        }
    }
}