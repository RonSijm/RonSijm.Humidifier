namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using OTAUpdateTypes;

    public class OTAUpdate : Humidifier.Base.BaseResource, IHaveTags, IHaveStringDictionaryOfAdditionalParameters, IHaveStringListOfProtocols, IHaveDescription, IHaveStringListOfTargets, IHaveRoleArn, IHaveIoTOTAUpdateTypesAwsJobTimeoutConfigAwsJobTimeoutConfig, IHaveIoTOTAUpdateTypesAwsJobAbortConfigAwsJobAbortConfig, IHaveOtaUpdateId, IHaveTargetSelection, IHaveIoTOTAUpdateTypesAwsJobPresignedUrlConfigAwsJobPresignedUrlConfig, IHaveListOfIoTOTAUpdateTypesOTAUpdateFileFiles, IHaveIoTOTAUpdateTypesAwsJobExecutionsRolloutConfigAwsJobExecutionsRolloutConfig
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string OtaUpdateArn =  "OtaUpdateArn" ;
            public static string OtaUpdateStatus =  "OtaUpdateStatus" ;
        }

        public override string AWSTypeName { get => AWS.IoT.OTAUpdate; }
        /// <summary>
        /// AdditionalParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-additionalparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalParameters { get; set; }
        /// <summary>
        /// Protocols
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-protocols
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Protocols { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-targets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// AwsJobTimeoutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobtimeoutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobTimeoutConfig
        /// </summary>
        public Union<Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig, BaseFunction>? AwsJobTimeoutConfig { get; set; }
        /// <summary>
        /// AwsJobAbortConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobabortconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobAbortConfig
        /// </summary>
        public Union<Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig, BaseFunction>? AwsJobAbortConfig { get; set; }

        /// <summary>
        /// OtaUpdateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-otaupdateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OtaUpdateId { get; set; }
        /// <summary>
        /// TargetSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-targetselection
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetSelection { get; set; }
        /// <summary>
        /// AwsJobPresignedUrlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobpresignedurlconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobPresignedUrlConfig
        /// </summary>
        public Union<Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig, BaseFunction>? AwsJobPresignedUrlConfig { get; set; }

        /// <summary>
        /// Files
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-files
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: OTAUpdateFile
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile>, IReadOnlyList<Union<Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile, BaseFunction>>, BaseFunction>? Files { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AwsJobExecutionsRolloutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobexecutionsrolloutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobExecutionsRolloutConfig
        /// </summary>
        public Union<Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig, BaseFunction>? AwsJobExecutionsRolloutConfig { get; set; }
    }

    namespace OTAUpdateTypes
    {
        public class AwsJobAbortConfig : Humidifier.Base.BaseSubResource, IHaveListOfIoTOTAUpdateTypesAwsJobAbortCriteriaAbortCriteriaList
        {
            /// <summary>
            /// AbortCriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortconfig.html#cfn-iot-otaupdate-awsjobabortconfig-abortcriterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AwsJobAbortCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.OTAUpdateTypes.AwsJobAbortCriteria>, IReadOnlyList<Union<Humidifier.IoT.OTAUpdateTypes.AwsJobAbortCriteria, BaseFunction>>, BaseFunction>? AbortCriteriaList { get; set; }
        }

        public class AwsJobAbortCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType, IHaveAction, IHaveThresholdPercentage_Double, IHaveMinNumberOfExecutedThings_Integer
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-action
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinNumberOfExecutedThings { get; set; }
        }

        public class AwsJobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute_Integer, IHaveIoTOTAUpdateTypesAwsJobExponentialRolloutRateExponentialRate
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexecutionsrolloutconfig.html#cfn-iot-otaupdate-awsjobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexecutionsrolloutconfig.html#cfn-iot-otaupdate-awsjobexecutionsrolloutconfig-exponentialrate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AwsJobExponentialRolloutRate
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate, BaseFunction>? ExponentialRate { get; set; }
        }

        public class AwsJobExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveIoTOTAUpdateTypesAwsJobRateIncreaseCriteriaRateIncreaseCriteria, IHaveBaseRatePerMinute_Integer, IHaveIncrementFactor_Double
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexponentialrolloutrate.html#cfn-iot-otaupdate-awsjobexponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AwsJobRateIncreaseCriteria
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria, BaseFunction>? RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexponentialrolloutrate.html#cfn-iot-otaupdate-awsjobexponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexponentialrolloutrate.html#cfn-iot-otaupdate-awsjobexponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IncrementFactor { get; set; }
        }

        public class AwsJobPresignedUrlConfig : Humidifier.Base.BaseSubResource, IHaveExpiresInSec_Integer
        {
            /// <summary>
            /// ExpiresInSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobpresignedurlconfig.html#cfn-iot-otaupdate-awsjobpresignedurlconfig-expiresinsec
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpiresInSec { get; set; }
        }

        public class AwsJobRateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings_Integer, IHaveNumberOfNotifiedThings_Integer
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobrateincreasecriteria.html#cfn-iot-otaupdate-awsjobrateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobrateincreasecriteria.html#cfn-iot-otaupdate-awsjobrateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfNotifiedThings { get; set; }
        }

        public class AwsJobTimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes_Integer
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobtimeoutconfig.html#cfn-iot-otaupdate-awsjobtimeoutconfig-inprogresstimeoutinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InProgressTimeoutInMinutes { get; set; }
        }

        public class CodeSigning : Humidifier.Base.BaseSubResource, IHaveAwsSignerJobId, IHaveIoTOTAUpdateTypesStartSigningJobParameterStartSigningJobParameter, IHaveIoTOTAUpdateTypesCustomCodeSigningCustomCodeSigning
        {
            /// <summary>
            /// AwsSignerJobId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigning.html#cfn-iot-otaupdate-codesigning-awssignerjobid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsSignerJobId { get; set; }
            /// <summary>
            /// StartSigningJobParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigning.html#cfn-iot-otaupdate-codesigning-startsigningjobparameter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StartSigningJobParameter
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter, BaseFunction>? StartSigningJobParameter { get; set; }
            /// <summary>
            /// CustomCodeSigning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigning.html#cfn-iot-otaupdate-codesigning-customcodesigning
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomCodeSigning
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning, BaseFunction>? CustomCodeSigning { get; set; }
        }

        public class CodeSigningCertificateChain : Humidifier.Base.BaseSubResource, IHaveInlineDocument, IHaveCertificateName
        {
            /// <summary>
            /// InlineDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigningcertificatechain.html#cfn-iot-otaupdate-codesigningcertificatechain-inlinedocument
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InlineDocument { get; set; }
            /// <summary>
            /// CertificateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigningcertificatechain.html#cfn-iot-otaupdate-codesigningcertificatechain-certificatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateName { get; set; }
        }

        public class CodeSigningSignature : Humidifier.Base.BaseSubResource, IHaveInlineDocument
        {
            /// <summary>
            /// InlineDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigningsignature.html#cfn-iot-otaupdate-codesigningsignature-inlinedocument
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InlineDocument { get; set; }
        }

        public class CustomCodeSigning : Humidifier.Base.BaseSubResource, IHaveIoTOTAUpdateTypesCodeSigningSignatureSignature, IHaveIoTOTAUpdateTypesCodeSigningCertificateChainCertificateChain, IHaveSignatureAlgorithm, IHaveHashAlgorithm
        {
            /// <summary>
            /// Signature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-signature
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CodeSigningSignature
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature, BaseFunction>? Signature { get; set; }
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-certificatechain
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CodeSigningCertificateChain
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain, BaseFunction>? CertificateChain { get; set; }
            /// <summary>
            /// SignatureAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-signaturealgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SignatureAlgorithm { get; set; }
            /// <summary>
            /// HashAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-hashalgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashAlgorithm { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource, IHaveIoTOTAUpdateTypesS3DestinationS3Destination
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-destination.html#cfn-iot-otaupdate-destination-s3destination
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Destination
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.S3Destination, BaseFunction>? S3Destination { get; set; }
        }

        public class FileLocation : Humidifier.Base.BaseSubResource, IHaveIoTOTAUpdateTypesStreamStream, IHaveIoTOTAUpdateTypesS3LocationS3Location
        {
            /// <summary>
            /// Stream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-filelocation.html#cfn-iot-otaupdate-filelocation-stream
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Stream
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.Stream, BaseFunction>? Stream { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-filelocation.html#cfn-iot-otaupdate-filelocation-s3location
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class OTAUpdateFile : Humidifier.Base.BaseSubResource, IHaveFileType_Integer, IHaveFileName, IHaveFileVersion, IHaveIoTOTAUpdateTypesFileLocationFileLocation, IHaveStringDictionaryOfAttributes_, IHaveIoTOTAUpdateTypesCodeSigningCodeSigning
        {
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-filetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FileType { get; set; }
            /// <summary>
            /// FileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-filename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileName { get; set; }
            /// <summary>
            /// FileVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-fileversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileVersion { get; set; }
            /// <summary>
            /// FileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-filelocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileLocation
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.FileLocation, BaseFunction>? FileLocation { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-attributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
            /// <summary>
            /// CodeSigning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-codesigning
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CodeSigning
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.CodeSigning, BaseFunction>? CodeSigning { get; set; }
        }

        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3destination.html#cfn-iot-otaupdate-s3destination-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3destination.html#cfn-iot-otaupdate-s3destination-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3location.html#cfn-iot-otaupdate-s3location-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3location.html#cfn-iot-otaupdate-s3location-version
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3location.html#cfn-iot-otaupdate-s3location-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SigningProfileParameter : Humidifier.Base.BaseSubResource, IHavePlatform, IHaveCertificatePathOnDevice, IHaveCertificateArn
        {
            /// <summary>
            /// Platform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-signingprofileparameter.html#cfn-iot-otaupdate-signingprofileparameter-platform
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Platform { get; set; }
            /// <summary>
            /// CertificatePathOnDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-signingprofileparameter.html#cfn-iot-otaupdate-signingprofileparameter-certificatepathondevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificatePathOnDevice { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-signingprofileparameter.html#cfn-iot-otaupdate-signingprofileparameter-certificatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class StartSigningJobParameter : Humidifier.Base.BaseSubResource, IHaveIoTOTAUpdateTypesDestinationDestination, IHaveSigningProfileName, IHaveIoTOTAUpdateTypesSigningProfileParameterSigningProfileParameter
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-startsigningjobparameter.html#cfn-iot-otaupdate-startsigningjobparameter-destination
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Destination
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.Destination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// SigningProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-startsigningjobparameter.html#cfn-iot-otaupdate-startsigningjobparameter-signingprofilename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningProfileName { get; set; }
            /// <summary>
            /// SigningProfileParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-startsigningjobparameter.html#cfn-iot-otaupdate-startsigningjobparameter-signingprofileparameter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SigningProfileParameter
            /// </summary>
            public Union<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter, BaseFunction>? SigningProfileParameter { get; set; }
        }

        public class Stream : Humidifier.Base.BaseSubResource, IHaveStreamId, IHaveFileId_Integer
        {
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-stream.html#cfn-iot-otaupdate-stream-streamid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamId { get; set; }
            /// <summary>
            /// FileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-stream.html#cfn-iot-otaupdate-stream-fileid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FileId { get; set; }
        }
    }
}