namespace Humidifier.GroundStation
{
    using System.Collections.Generic;
    using ConfigTypes;

    public class Config : Humidifier.Resource
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::GroundStation::Config";
            }
        }

        /// <summary>
        /// ConfigData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-config.html#cfn-groundstation-config-configdata
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConfigData
        /// </summary>
        public ConfigData ConfigData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-config.html#cfn-groundstation-config-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-config.html#cfn-groundstation-config-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ConfigTypes
    {
        public class AntennaDownlinkConfig
        {
            /// <summary>
            /// SpectrumConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkconfig.html#cfn-groundstation-config-antennadownlinkconfig-spectrumconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpectrumConfig
            /// </summary>
            public SpectrumConfig SpectrumConfig { get; set; }
        }

        public class AntennaDownlinkDemodDecodeConfig
        {
            /// <summary>
            /// DemodulationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html#cfn-groundstation-config-antennadownlinkdemoddecodeconfig-demodulationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DemodulationConfig
            /// </summary>
            public DemodulationConfig DemodulationConfig { get; set; }
            /// <summary>
            /// SpectrumConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html#cfn-groundstation-config-antennadownlinkdemoddecodeconfig-spectrumconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpectrumConfig
            /// </summary>
            public SpectrumConfig SpectrumConfig { get; set; }
            /// <summary>
            /// DecodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html#cfn-groundstation-config-antennadownlinkdemoddecodeconfig-decodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecodeConfig
            /// </summary>
            public DecodeConfig DecodeConfig { get; set; }
        }

        public class AntennaUplinkConfig
        {
            /// <summary>
            /// TransmitDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html#cfn-groundstation-config-antennauplinkconfig-transmitdisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic TransmitDisabled { get; set; }
            /// <summary>
            /// SpectrumConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html#cfn-groundstation-config-antennauplinkconfig-spectrumconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UplinkSpectrumConfig
            /// </summary>
            public UplinkSpectrumConfig SpectrumConfig { get; set; }
            /// <summary>
            /// TargetEirp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html#cfn-groundstation-config-antennauplinkconfig-targeteirp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Eirp
            /// </summary>
            public Eirp TargetEirp { get; set; }
        }

        public class ConfigData
        {
            /// <summary>
            /// DataflowEndpointConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-dataflowendpointconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataflowEndpointConfig
            /// </summary>
            public DataflowEndpointConfig DataflowEndpointConfig { get; set; }
            /// <summary>
            /// UplinkEchoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-uplinkechoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UplinkEchoConfig
            /// </summary>
            public UplinkEchoConfig UplinkEchoConfig { get; set; }
            /// <summary>
            /// AntennaDownlinkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-antennadownlinkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AntennaDownlinkConfig
            /// </summary>
            public AntennaDownlinkConfig AntennaDownlinkConfig { get; set; }
            /// <summary>
            /// AntennaDownlinkDemodDecodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-antennadownlinkdemoddecodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AntennaDownlinkDemodDecodeConfig
            /// </summary>
            public AntennaDownlinkDemodDecodeConfig AntennaDownlinkDemodDecodeConfig { get; set; }
            /// <summary>
            /// TrackingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-trackingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrackingConfig
            /// </summary>
            public TrackingConfig TrackingConfig { get; set; }
            /// <summary>
            /// AntennaUplinkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-antennauplinkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AntennaUplinkConfig
            /// </summary>
            public AntennaUplinkConfig AntennaUplinkConfig { get; set; }
            /// <summary>
            /// S3RecordingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-s3recordingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3RecordingConfig
            /// </summary>
            public S3RecordingConfig S3RecordingConfig { get; set; }
        }

        public class DataflowEndpointConfig
        {
            /// <summary>
            /// DataflowEndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-dataflowendpointconfig.html#cfn-groundstation-config-dataflowendpointconfig-dataflowendpointname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataflowEndpointName { get; set; }
            /// <summary>
            /// DataflowEndpointRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-dataflowendpointconfig.html#cfn-groundstation-config-dataflowendpointconfig-dataflowendpointregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataflowEndpointRegion { get; set; }
        }

        public class DecodeConfig
        {
            /// <summary>
            /// UnvalidatedJSON
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-decodeconfig.html#cfn-groundstation-config-decodeconfig-unvalidatedjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnvalidatedJSON { get; set; }
        }

        public class DemodulationConfig
        {
            /// <summary>
            /// UnvalidatedJSON
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-demodulationconfig.html#cfn-groundstation-config-demodulationconfig-unvalidatedjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnvalidatedJSON { get; set; }
        }

        public class Eirp
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-eirp.html#cfn-groundstation-config-eirp-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-eirp.html#cfn-groundstation-config-eirp-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Units { get; set; }
        }

        public class Frequency
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequency.html#cfn-groundstation-config-frequency-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequency.html#cfn-groundstation-config-frequency-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Units { get; set; }
        }

        public class FrequencyBandwidth
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequencybandwidth.html#cfn-groundstation-config-frequencybandwidth-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequencybandwidth.html#cfn-groundstation-config-frequencybandwidth-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Units { get; set; }
        }

        public class S3RecordingConfig
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html#cfn-groundstation-config-s3recordingconfig-bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html#cfn-groundstation-config-s3recordingconfig-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html#cfn-groundstation-config-s3recordingconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SpectrumConfig
        {
            /// <summary>
            /// Polarization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html#cfn-groundstation-config-spectrumconfig-polarization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Polarization { get; set; }
            /// <summary>
            /// Bandwidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html#cfn-groundstation-config-spectrumconfig-bandwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrequencyBandwidth
            /// </summary>
            public FrequencyBandwidth Bandwidth { get; set; }
            /// <summary>
            /// CenterFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html#cfn-groundstation-config-spectrumconfig-centerfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Frequency
            /// </summary>
            public Frequency CenterFrequency { get; set; }
        }

        public class TrackingConfig
        {
            /// <summary>
            /// Autotrack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-trackingconfig.html#cfn-groundstation-config-trackingconfig-autotrack
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Autotrack { get; set; }
        }

        public class UplinkEchoConfig
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkechoconfig.html#cfn-groundstation-config-uplinkechoconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// AntennaUplinkConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkechoconfig.html#cfn-groundstation-config-uplinkechoconfig-antennauplinkconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AntennaUplinkConfigArn { get; set; }
        }

        public class UplinkSpectrumConfig
        {
            /// <summary>
            /// Polarization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkspectrumconfig.html#cfn-groundstation-config-uplinkspectrumconfig-polarization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Polarization { get; set; }
            /// <summary>
            /// CenterFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkspectrumconfig.html#cfn-groundstation-config-uplinkspectrumconfig-centerfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Frequency
            /// </summary>
            public Frequency CenterFrequency { get; set; }
        }
    }
}