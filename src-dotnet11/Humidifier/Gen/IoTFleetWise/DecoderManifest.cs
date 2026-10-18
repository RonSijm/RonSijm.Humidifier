namespace Humidifier.IoTFleetWise
{
    using global::System.Collections.Generic;
    using DecoderManifestTypes;

    public class DecoderManifest : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfIoTFleetWiseDecoderManifestTypesSignalDecodersItemsSignalDecoders, IHaveStatus, IHaveDescription, IHaveListOfIoTFleetWiseDecoderManifestTypesNetworkInterfacesItemsNetworkInterfaces, IHaveModelManifestArn, IHaveDefaultForUnmappedSignals, IHaveName
    {
        public class Attributes
        {
            public static string LastModificationTime =  "LastModificationTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTFleetWise.DecoderManifest; }
        /// <summary>
        /// SignalDecoders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-signaldecoders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SignalDecodersItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems>, IReadOnlyList<Union<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems, BaseFunction>>, BaseFunction>? SignalDecoders { get; set; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// NetworkInterfaces
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-networkinterfaces
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NetworkInterfacesItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems>, IReadOnlyList<Union<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }

        /// <summary>
        /// ModelManifestArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-modelmanifestarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelManifestArn { get; set; }
        /// <summary>
        /// DefaultForUnmappedSignals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-defaultforunmappedsignals
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultForUnmappedSignals { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleetwise-decodermanifest.html#cfn-iotfleetwise-decodermanifest-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DecoderManifestTypes
    {
        public class CanInterface : Humidifier.Base.BaseSubResource, IHaveProtocolName, IHaveProtocolVersion, IHaveName
        {
            /// <summary>
            /// ProtocolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-caninterface.html#cfn-iotfleetwise-decodermanifest-caninterface-protocolname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProtocolName { get; set; }
            /// <summary>
            /// ProtocolVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-caninterface.html#cfn-iotfleetwise-decodermanifest-caninterface-protocolversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProtocolVersion { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-caninterface.html#cfn-iotfleetwise-decodermanifest-caninterface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CanSignal : Humidifier.Base.BaseSubResource, IHaveIsBigEndian, IHaveLength, IHaveFactor, IHaveIsSigned, IHaveSignalValueType, IHaveStartBit, IHaveMessageId, IHaveOffset, IHaveName
        {
            /// <summary>
            /// IsBigEndian
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-isbigendian
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsBigEndian { get; set; }
            /// <summary>
            /// Length
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-length
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Length { get; set; }
            /// <summary>
            /// Factor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-factor
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Factor { get; set; }
            /// <summary>
            /// IsSigned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-issigned
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsSigned { get; set; }
            /// <summary>
            /// SignalValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-signalvaluetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SignalValueType { get; set; }
            /// <summary>
            /// StartBit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-startbit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartBit { get; set; }
            /// <summary>
            /// MessageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-messageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageId { get; set; }
            /// <summary>
            /// Offset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-offset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Offset { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-cansignal.html#cfn-iotfleetwise-decodermanifest-cansignal-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CustomDecodingInterface : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-customdecodinginterface.html#cfn-iotfleetwise-decodermanifest-customdecodinginterface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CustomDecodingSignal : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-customdecodingsignal.html#cfn-iotfleetwise-decodermanifest-customdecodingsignal-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class NetworkInterfacesItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveIoTFleetWiseDecoderManifestTypesCanInterfaceCanInterface, IHaveIoTFleetWiseDecoderManifestTypesCustomDecodingInterfaceCustomDecodingInterface, IHaveInterfaceId, IHaveIoTFleetWiseDecoderManifestTypesObdInterfaceObdInterface
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-networkinterfacesitems.html#cfn-iotfleetwise-decodermanifest-networkinterfacesitems-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// CanInterface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-networkinterfacesitems.html#cfn-iotfleetwise-decodermanifest-networkinterfacesitems-caninterface
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CanInterface
            /// </summary>
            public Union<Humidifier.IoTFleetWise.DecoderManifestTypes.CanInterface, BaseFunction>? CanInterface { get; set; }
            /// <summary>
            /// CustomDecodingInterface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-networkinterfacesitems.html#cfn-iotfleetwise-decodermanifest-networkinterfacesitems-customdecodinginterface
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomDecodingInterface
            /// </summary>
            public Union<Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingInterface, BaseFunction>? CustomDecodingInterface { get; set; }
            /// <summary>
            /// InterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-networkinterfacesitems.html#cfn-iotfleetwise-decodermanifest-networkinterfacesitems-interfaceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterfaceId { get; set; }
            /// <summary>
            /// ObdInterface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-networkinterfacesitems.html#cfn-iotfleetwise-decodermanifest-networkinterfacesitems-obdinterface
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObdInterface
            /// </summary>
            public Union<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdInterface, BaseFunction>? ObdInterface { get; set; }
        }

        public class ObdInterface : Humidifier.Base.BaseSubResource, IHaveHasTransmissionEcu, IHavePidRequestIntervalSeconds, IHaveUseExtendedIds, IHaveRequestMessageId, IHaveObdStandard, IHaveName, IHaveDtcRequestIntervalSeconds
        {
            /// <summary>
            /// HasTransmissionEcu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-hastransmissionecu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HasTransmissionEcu { get; set; }
            /// <summary>
            /// PidRequestIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-pidrequestintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PidRequestIntervalSeconds { get; set; }
            /// <summary>
            /// UseExtendedIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-useextendedids
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseExtendedIds { get; set; }
            /// <summary>
            /// RequestMessageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-requestmessageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestMessageId { get; set; }
            /// <summary>
            /// ObdStandard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-obdstandard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObdStandard { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// DtcRequestIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdinterface.html#cfn-iotfleetwise-decodermanifest-obdinterface-dtcrequestintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DtcRequestIntervalSeconds { get; set; }
        }

        public class ObdSignal : Humidifier.Base.BaseSubResource, IHaveBitRightShift, IHaveBitMaskLength, IHaveStartByte, IHaveByteLength, IHavePidResponseLength, IHaveScaling, IHavePid, IHaveIsSigned, IHaveSignalValueType, IHaveServiceMode, IHaveOffset
        {
            /// <summary>
            /// BitRightShift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-bitrightshift
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BitRightShift { get; set; }
            /// <summary>
            /// BitMaskLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-bitmasklength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BitMaskLength { get; set; }
            /// <summary>
            /// StartByte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-startbyte
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartByte { get; set; }
            /// <summary>
            /// ByteLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-bytelength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ByteLength { get; set; }
            /// <summary>
            /// PidResponseLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-pidresponselength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PidResponseLength { get; set; }
            /// <summary>
            /// Scaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-scaling
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scaling { get; set; }
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-pid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pid { get; set; }
            /// <summary>
            /// IsSigned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-issigned
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsSigned { get; set; }
            /// <summary>
            /// SignalValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-signalvaluetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SignalValueType { get; set; }
            /// <summary>
            /// ServiceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-servicemode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceMode { get; set; }
            /// <summary>
            /// Offset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-obdsignal.html#cfn-iotfleetwise-decodermanifest-obdsignal-offset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Offset { get; set; }
        }

        public class SignalDecodersItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveIoTFleetWiseDecoderManifestTypesObdSignalObdSignal, IHaveFullyQualifiedName, IHaveIoTFleetWiseDecoderManifestTypesCustomDecodingSignalCustomDecodingSignal, IHaveIoTFleetWiseDecoderManifestTypesCanSignalCanSignal, IHaveInterfaceId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-signaldecodersitems.html#cfn-iotfleetwise-decodermanifest-signaldecodersitems-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ObdSignal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-signaldecodersitems.html#cfn-iotfleetwise-decodermanifest-signaldecodersitems-obdsignal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObdSignal
            /// </summary>
            public Union<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal, BaseFunction>? ObdSignal { get; set; }
            /// <summary>
            /// FullyQualifiedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-signaldecodersitems.html#cfn-iotfleetwise-decodermanifest-signaldecodersitems-fullyqualifiedname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FullyQualifiedName { get; set; }
            /// <summary>
            /// CustomDecodingSignal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-signaldecodersitems.html#cfn-iotfleetwise-decodermanifest-signaldecodersitems-customdecodingsignal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomDecodingSignal
            /// </summary>
            public Union<Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingSignal, BaseFunction>? CustomDecodingSignal { get; set; }
            /// <summary>
            /// CanSignal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-signaldecodersitems.html#cfn-iotfleetwise-decodermanifest-signaldecodersitems-cansignal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CanSignal
            /// </summary>
            public Union<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal, BaseFunction>? CanSignal { get; set; }
            /// <summary>
            /// InterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotfleetwise-decodermanifest-signaldecodersitems.html#cfn-iotfleetwise-decodermanifest-signaldecodersitems-interfaceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterfaceId { get; set; }
        }
    }
}