namespace Humidifier.LookoutEquipment
{
    using global::System.Collections.Generic;
    using InferenceSchedulerTypes;

    public class InferenceScheduler : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInferenceSchedulerName, IHaveDataUploadFrequency, IHaveModelName, IHaveLookoutEquipmentInferenceSchedulerTypesDataInputConfigurationDataInputConfiguration, IHaveLookoutEquipmentInferenceSchedulerTypesDataOutputConfigurationDataOutputConfiguration, IHaveServerSideKmsKeyId, IHaveDataDelayOffsetInMinutes_Integer, IHaveRoleArn
    {
        public class Attributes
        {
            public static string InferenceSchedulerArn =  "InferenceSchedulerArn" ;
        }

        public override string AWSTypeName { get => AWS.LookoutEquipment.InferenceScheduler; }
        public Union<string, BaseFunction>? InferenceSchedulerName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DataUploadFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-datauploadfrequency
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataUploadFrequency { get; set; }

        /// <summary>
        /// ModelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-modelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelName { get; set; }

        /// <summary>
        /// DataInputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-datainputconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataInputConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration, BaseFunction>? DataInputConfiguration { get; set; }

        /// <summary>
        /// DataOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-dataoutputconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataOutputConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration, BaseFunction>? DataOutputConfiguration { get; set; }
        /// <summary>
        /// ServerSideKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-serversidekmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerSideKmsKeyId { get; set; }
        /// <summary>
        /// DataDelayOffsetInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-datadelayoffsetinminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DataDelayOffsetInMinutes { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutequipment-inferencescheduler.html#cfn-lookoutequipment-inferencescheduler-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InferenceSchedulerTypes
    {
        public class DataInputConfiguration : Humidifier.Base.BaseSubResource, IHaveLookoutEquipmentInferenceSchedulerTypesInputNameConfigurationInferenceInputNameConfiguration, IHaveLookoutEquipmentInferenceSchedulerTypesS3InputConfigurationS3InputConfiguration, IHaveInputTimeZoneOffset
        {
            /// <summary>
            /// InferenceInputNameConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-datainputconfiguration.html#cfn-lookoutequipment-inferencescheduler-datainputconfiguration-inferenceinputnameconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputNameConfiguration
            /// </summary>
            public Union<Humidifier.LookoutEquipment.InferenceSchedulerTypes.InputNameConfiguration, BaseFunction>? InferenceInputNameConfiguration { get; set; }
            /// <summary>
            /// S3InputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-datainputconfiguration.html#cfn-lookoutequipment-inferencescheduler-datainputconfiguration-s3inputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3InputConfiguration
            /// </summary>
            public Union<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3InputConfiguration, BaseFunction>? S3InputConfiguration { get; set; }
            /// <summary>
            /// InputTimeZoneOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-datainputconfiguration.html#cfn-lookoutequipment-inferencescheduler-datainputconfiguration-inputtimezoneoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputTimeZoneOffset { get; set; }
        }

        public class DataOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveLookoutEquipmentInferenceSchedulerTypesS3OutputConfigurationS3OutputConfiguration
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-dataoutputconfiguration.html#cfn-lookoutequipment-inferencescheduler-dataoutputconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-dataoutputconfiguration.html#cfn-lookoutequipment-inferencescheduler-dataoutputconfiguration-s3outputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3OutputConfiguration
            /// </summary>
            public Union<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration, BaseFunction>? S3OutputConfiguration { get; set; }
        }

        public class InputNameConfiguration : Humidifier.Base.BaseSubResource, IHaveComponentTimestampDelimiter, IHaveTimestampFormat
        {
            /// <summary>
            /// ComponentTimestampDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-inputnameconfiguration.html#cfn-lookoutequipment-inferencescheduler-inputnameconfiguration-componenttimestampdelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentTimestampDelimiter { get; set; }
            /// <summary>
            /// TimestampFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-inputnameconfiguration.html#cfn-lookoutequipment-inferencescheduler-inputnameconfiguration-timestampformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampFormat { get; set; }
        }

        public class S3InputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-s3inputconfiguration.html#cfn-lookoutequipment-inferencescheduler-s3inputconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-s3inputconfiguration.html#cfn-lookoutequipment-inferencescheduler-s3inputconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class S3OutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-s3outputconfiguration.html#cfn-lookoutequipment-inferencescheduler-s3outputconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutequipment-inferencescheduler-s3outputconfiguration.html#cfn-lookoutequipment-inferencescheduler-s3outputconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }
    }
}