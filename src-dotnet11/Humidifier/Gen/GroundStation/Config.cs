namespace Humidifier.GroundStation
{
    using global::System.Collections.Generic;
    using ConfigTypes;

    public class Config : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveGroundStationConfigTypesConfigDataConfigData, IHaveName
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.GroundStation.Config; }

        /// <summary>
        /// ConfigData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-config.html#cfn-groundstation-config-configdata
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConfigData
        /// </summary>
        [Required]
        public Union<Humidifier.GroundStation.ConfigTypes.ConfigData, BaseFunction>? ConfigData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-config.html#cfn-groundstation-config-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigTypes
    {
        public class AntennaDownlinkConfig : Humidifier.Base.BaseSubResource, IHaveGroundStationConfigTypesSpectrumConfigSpectrumConfig
        {
            /// <summary>
            /// SpectrumConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkconfig.html#cfn-groundstation-config-antennadownlinkconfig-spectrumconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpectrumConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.SpectrumConfig, BaseFunction>? SpectrumConfig { get; set; }
        }

        public class AntennaDownlinkDemodDecodeConfig : Humidifier.Base.BaseSubResource, IHaveGroundStationConfigTypesDemodulationConfigDemodulationConfig, IHaveGroundStationConfigTypesSpectrumConfigSpectrumConfig, IHaveGroundStationConfigTypesDecodeConfigDecodeConfig
        {
            /// <summary>
            /// DemodulationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html#cfn-groundstation-config-antennadownlinkdemoddecodeconfig-demodulationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DemodulationConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.DemodulationConfig, BaseFunction>? DemodulationConfig { get; set; }
            /// <summary>
            /// SpectrumConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html#cfn-groundstation-config-antennadownlinkdemoddecodeconfig-spectrumconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpectrumConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.SpectrumConfig, BaseFunction>? SpectrumConfig { get; set; }
            /// <summary>
            /// DecodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html#cfn-groundstation-config-antennadownlinkdemoddecodeconfig-decodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DecodeConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.DecodeConfig, BaseFunction>? DecodeConfig { get; set; }
        }

        public class AntennaUplinkConfig : Humidifier.Base.BaseSubResource, IHaveTransmitDisabled_Boolean, IHaveGroundStationConfigTypesUplinkSpectrumConfigSpectrumConfig, IHaveGroundStationConfigTypesEirpTargetEirp
        {
            /// <summary>
            /// TransmitDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html#cfn-groundstation-config-antennauplinkconfig-transmitdisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TransmitDisabled { get; set; }
            /// <summary>
            /// SpectrumConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html#cfn-groundstation-config-antennauplinkconfig-spectrumconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UplinkSpectrumConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig, BaseFunction>? SpectrumConfig { get; set; }
            /// <summary>
            /// TargetEirp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html#cfn-groundstation-config-antennauplinkconfig-targeteirp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Eirp
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.Eirp, BaseFunction>? TargetEirp { get; set; }
        }

        public class ConfigData : Humidifier.Base.BaseSubResource, IHaveGroundStationConfigTypesDataflowEndpointConfigDataflowEndpointConfig, IHaveGroundStationConfigTypesUplinkEchoConfigUplinkEchoConfig, IHaveGroundStationConfigTypesTelemetrySinkConfigTelemetrySinkConfig, IHaveGroundStationConfigTypesAntennaDownlinkConfigAntennaDownlinkConfig, IHaveGroundStationConfigTypesAntennaDownlinkDemodDecodeConfigAntennaDownlinkDemodDecodeConfig, IHaveGroundStationConfigTypesTrackingConfigTrackingConfig, IHaveGroundStationConfigTypesAntennaUplinkConfigAntennaUplinkConfig, IHaveGroundStationConfigTypesS3RecordingConfigS3RecordingConfig
        {
            /// <summary>
            /// DataflowEndpointConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-dataflowendpointconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataflowEndpointConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.DataflowEndpointConfig, BaseFunction>? DataflowEndpointConfig { get; set; }
            /// <summary>
            /// UplinkEchoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-uplinkechoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UplinkEchoConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.UplinkEchoConfig, BaseFunction>? UplinkEchoConfig { get; set; }
            /// <summary>
            /// TelemetrySinkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-telemetrysinkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelemetrySinkConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.TelemetrySinkConfig, BaseFunction>? TelemetrySinkConfig { get; set; }
            /// <summary>
            /// AntennaDownlinkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-antennadownlinkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AntennaDownlinkConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig, BaseFunction>? AntennaDownlinkConfig { get; set; }
            /// <summary>
            /// AntennaDownlinkDemodDecodeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-antennadownlinkdemoddecodeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AntennaDownlinkDemodDecodeConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.AntennaDownlinkDemodDecodeConfig, BaseFunction>? AntennaDownlinkDemodDecodeConfig { get; set; }
            /// <summary>
            /// TrackingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-trackingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrackingConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.TrackingConfig, BaseFunction>? TrackingConfig { get; set; }
            /// <summary>
            /// AntennaUplinkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-antennauplinkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AntennaUplinkConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig, BaseFunction>? AntennaUplinkConfig { get; set; }
            /// <summary>
            /// S3RecordingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html#cfn-groundstation-config-configdata-s3recordingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3RecordingConfig
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.S3RecordingConfig, BaseFunction>? S3RecordingConfig { get; set; }
        }

        public class DataflowEndpointConfig : Humidifier.Base.BaseSubResource, IHaveDataflowEndpointName, IHaveDataflowEndpointRegion
        {
            /// <summary>
            /// DataflowEndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-dataflowendpointconfig.html#cfn-groundstation-config-dataflowendpointconfig-dataflowendpointname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataflowEndpointName { get; set; }
            /// <summary>
            /// DataflowEndpointRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-dataflowendpointconfig.html#cfn-groundstation-config-dataflowendpointconfig-dataflowendpointregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataflowEndpointRegion { get; set; }
        }

        public class DecodeConfig : Humidifier.Base.BaseSubResource, IHaveUnvalidatedJSON
        {
            /// <summary>
            /// UnvalidatedJSON
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-decodeconfig.html#cfn-groundstation-config-decodeconfig-unvalidatedjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnvalidatedJSON { get; set; }
        }

        public class DemodulationConfig : Humidifier.Base.BaseSubResource, IHaveUnvalidatedJSON
        {
            /// <summary>
            /// UnvalidatedJSON
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-demodulationconfig.html#cfn-groundstation-config-demodulationconfig-unvalidatedjson
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnvalidatedJSON { get; set; }
        }

        public class Eirp : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnits
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-eirp.html#cfn-groundstation-config-eirp-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-eirp.html#cfn-groundstation-config-eirp-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Units { get; set; }
        }

        public class Frequency : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnits
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequency.html#cfn-groundstation-config-frequency-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequency.html#cfn-groundstation-config-frequency-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Units { get; set; }
        }

        public class FrequencyBandwidth : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnits
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequencybandwidth.html#cfn-groundstation-config-frequencybandwidth-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequencybandwidth.html#cfn-groundstation-config-frequencybandwidth-units
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Units { get; set; }
        }

        public class KinesisDataStreamData : Humidifier.Base.BaseSubResource, IHaveKinesisDataStreamArn, IHaveKinesisRoleArn
        {
            /// <summary>
            /// KinesisDataStreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-kinesisdatastreamdata.html#cfn-groundstation-config-kinesisdatastreamdata-kinesisdatastreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KinesisDataStreamArn { get; set; }
            /// <summary>
            /// KinesisRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-kinesisdatastreamdata.html#cfn-groundstation-config-kinesisdatastreamdata-kinesisrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KinesisRoleArn { get; set; }
        }

        public class S3RecordingConfig : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHavePrefix, IHaveRoleArn
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html#cfn-groundstation-config-s3recordingconfig-bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html#cfn-groundstation-config-s3recordingconfig-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html#cfn-groundstation-config-s3recordingconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SpectrumConfig : Humidifier.Base.BaseSubResource, IHavePolarization, IHaveGroundStationConfigTypesFrequencyCenterFrequency, IHaveGroundStationConfigTypesFrequencyBandwidthBandwidth
        {
            /// <summary>
            /// Polarization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html#cfn-groundstation-config-spectrumconfig-polarization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Polarization { get; set; }
            /// <summary>
            /// CenterFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html#cfn-groundstation-config-spectrumconfig-centerfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Frequency
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.Frequency, BaseFunction>? CenterFrequency { get; set; }
            /// <summary>
            /// Bandwidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html#cfn-groundstation-config-spectrumconfig-bandwidth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FrequencyBandwidth
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth, BaseFunction>? Bandwidth { get; set; }
        }

        public class TelemetrySinkConfig : Humidifier.Base.BaseSubResource, IHaveGroundStationConfigTypesTelemetrySinkDataTelemetrySinkData, IHaveTelemetrySinkType
        {
            /// <summary>
            /// TelemetrySinkData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-telemetrysinkconfig.html#cfn-groundstation-config-telemetrysinkconfig-telemetrysinkdata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TelemetrySinkData
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.TelemetrySinkData, BaseFunction>? TelemetrySinkData { get; set; }
            /// <summary>
            /// TelemetrySinkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-telemetrysinkconfig.html#cfn-groundstation-config-telemetrysinkconfig-telemetrysinktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TelemetrySinkType { get; set; }
        }

        public class TelemetrySinkData : Humidifier.Base.BaseSubResource, IHaveGroundStationConfigTypesKinesisDataStreamDataKinesisDataStreamData
        {
            /// <summary>
            /// KinesisDataStreamData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-telemetrysinkdata.html#cfn-groundstation-config-telemetrysinkdata-kinesisdatastreamdata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KinesisDataStreamData
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.KinesisDataStreamData, BaseFunction>? KinesisDataStreamData { get; set; }
        }

        public class TrackingConfig : Humidifier.Base.BaseSubResource, IHaveAutotrack
        {
            /// <summary>
            /// Autotrack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-trackingconfig.html#cfn-groundstation-config-trackingconfig-autotrack
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Autotrack { get; set; }
        }

        public class UplinkEchoConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveAntennaUplinkConfigArn
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkechoconfig.html#cfn-groundstation-config-uplinkechoconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// AntennaUplinkConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkechoconfig.html#cfn-groundstation-config-uplinkechoconfig-antennauplinkconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AntennaUplinkConfigArn { get; set; }
        }

        public class UplinkSpectrumConfig : Humidifier.Base.BaseSubResource, IHavePolarization, IHaveGroundStationConfigTypesFrequencyCenterFrequency
        {
            /// <summary>
            /// Polarization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkspectrumconfig.html#cfn-groundstation-config-uplinkspectrumconfig-polarization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Polarization { get; set; }
            /// <summary>
            /// CenterFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkspectrumconfig.html#cfn-groundstation-config-uplinkspectrumconfig-centerfrequency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Frequency
            /// </summary>
            public Union<Humidifier.GroundStation.ConfigTypes.Frequency, BaseFunction>? CenterFrequency { get; set; }
        }
    }
}