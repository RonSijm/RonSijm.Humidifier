namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowOutputTypes;

    public class FlowOutput : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDestination, IHaveSmoothingLatency_Integer, IHaveStreamId, IHaveDescription, IHaveNdiSpeedHqQuality_Integer, IHavePort_Integer, IHaveRemoteId, IHaveListOfMediaConnectFlowOutputTypesMediaStreamOutputConfigurationMediaStreamOutputConfigurations, IHaveMediaConnectFlowOutputTypesEncryptionEncryption, IHaveRouterIntegrationState, IHaveOutputStatus, IHaveName, IHaveMediaConnectFlowOutputTypesVpcInterfaceAttachmentVpcInterfaceAttachment, IHaveNdiOutputTimecodeSource, IHaveMinLatency_Integer, IHaveMediaConnectFlowOutputTypesFlowTransitEncryptionRouterIntegrationTransitEncryption, IHaveProtocol, IHaveFlowArn, IHaveNdiProgramName, IHaveMaxLatency_Integer, IHaveStringListOfCidrAllowList
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
        public Union<string, BaseFunction>? Destination { get; set; }
        /// <summary>
        /// SmoothingLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-smoothinglatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SmoothingLatency { get; set; }
        /// <summary>
        /// StreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-streamid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StreamId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// NdiSpeedHqQuality
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-ndispeedhqquality
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NdiSpeedHqQuality { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// RemoteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-remoteid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RemoteId { get; set; }
        /// <summary>
        /// MediaStreamOutputConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaStreamOutputConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowOutputTypes.MediaStreamOutputConfiguration, BaseFunction>>, BaseFunction>? MediaStreamOutputConfigurations { get; set; }
        /// <summary>
        /// Encryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-encryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Encryption
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowOutputTypes.Encryption, BaseFunction>? Encryption { get; set; }
        /// <summary>
        /// RouterIntegrationState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-routerintegrationstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RouterIntegrationState { get; set; }
        /// <summary>
        /// OutputStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-outputstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutputStatus { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcInterfaceAttachment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-vpcinterfaceattachment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcInterfaceAttachment
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment, BaseFunction>? VpcInterfaceAttachment { get; set; }
        /// <summary>
        /// NdiOutputTimecodeSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-ndioutputtimecodesource
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NdiOutputTimecodeSource { get; set; }
        /// <summary>
        /// MinLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-minlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinLatency { get; set; }
        /// <summary>
        /// RouterIntegrationTransitEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-routerintegrationtransitencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FlowTransitEncryption
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption, BaseFunction>? RouterIntegrationTransitEncryption { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-protocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Protocol { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FlowArn { get; set; }
        /// <summary>
        /// NdiProgramName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-ndiprogramname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NdiProgramName { get; set; }
        /// <summary>
        /// MaxLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-maxlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxLatency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CidrAllowList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html#cfn-mediaconnect-flowoutput-cidrallowlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CidrAllowList { get; set; }
    }

    namespace FlowOutputTypes
    {
        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveDestinationIp, IHaveDestinationPort_Integer, IHaveMediaConnectFlowOutputTypesInterfaceInterface
        {
            /// <summary>
            /// DestinationIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-destinationconfiguration.html#cfn-mediaconnect-flowoutput-destinationconfiguration-destinationip
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationIp { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-destinationconfiguration.html#cfn-mediaconnect-flowoutput-destinationconfiguration-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DestinationPort { get; set; }
            /// <summary>
            /// Interface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-destinationconfiguration.html#cfn-mediaconnect-flowoutput-destinationconfiguration-interface
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Interface
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowOutputTypes.Interface, BaseFunction>? Interface { get; set; }
        }

        public class EncodingParameters : Humidifier.Base.BaseSubResource, IHaveEncoderProfile, IHaveCompressionFactor_Double
        {
            /// <summary>
            /// EncoderProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encodingparameters.html#cfn-mediaconnect-flowoutput-encodingparameters-encoderprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncoderProfile { get; set; }
            /// <summary>
            /// CompressionFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encodingparameters.html#cfn-mediaconnect-flowoutput-encodingparameters-compressionfactor
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CompressionFactor { get; set; }
        }

        public class Encryption : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKeyType, IHaveAlgorithm, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html#cfn-mediaconnect-flowoutput-encryption-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class FlowTransitEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyType, IHaveMediaConnectFlowOutputTypesFlowTransitEncryptionKeyConfigurationEncryptionKeyConfiguration
        {
            /// <summary>
            /// EncryptionKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-flowtransitencryption.html#cfn-mediaconnect-flowoutput-flowtransitencryption-encryptionkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyType { get; set; }
            /// <summary>
            /// EncryptionKeyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-flowtransitencryption.html#cfn-mediaconnect-flowoutput-flowtransitencryption-encryptionkeyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FlowTransitEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration, BaseFunction>? EncryptionKeyConfiguration { get; set; }
        }

        public class FlowTransitEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowOutputTypesSecretsManagerEncryptionKeyConfigurationSecretsManager, IHaveAutomatic_Json
        {
            /// <summary>
            /// SecretsManager
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-flowoutput-flowtransitencryptionkeyconfiguration-secretsmanager
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerEncryptionKeyConfiguration
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration, BaseFunction>? SecretsManager { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-flowtransitencryptionkeyconfiguration.html#cfn-mediaconnect-flowoutput-flowtransitencryptionkeyconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Automatic { get; set; }
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
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MediaStreamOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowOutputTypesEncodingParametersEncodingParameters, IHaveMediaStreamName, IHaveEncodingName, IHaveListOfMediaConnectFlowOutputTypesDestinationConfigurationDestinationConfigurations
        {
            /// <summary>
            /// EncodingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-encodingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncodingParameters
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters, BaseFunction>? EncodingParameters { get; set; }
            /// <summary>
            /// MediaStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-mediastreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaStreamName { get; set; }
            /// <summary>
            /// EncodingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-encodingname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncodingName { get; set; }
            /// <summary>
            /// DestinationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-mediastreamoutputconfiguration.html#cfn-mediaconnect-flowoutput-mediastreamoutputconfiguration-destinationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DestinationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConnect.FlowOutputTypes.DestinationConfiguration>, IReadOnlyList<Union<Humidifier.MediaConnect.FlowOutputTypes.DestinationConfiguration, BaseFunction>>, BaseFunction>? DestinationConfigurations { get; set; }
        }

        public class SecretsManagerEncryptionKeyConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-flowoutput-secretsmanagerencryptionkeyconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-secretsmanagerencryptionkeyconfiguration.html#cfn-mediaconnect-flowoutput-secretsmanagerencryptionkeyconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
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
            public Union<string, BaseFunction>? VpcInterfaceName { get; set; }
        }
    }
}