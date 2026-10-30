namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using OTAUpdateTypes;

    public class OTAUpdate : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHaveProtocols
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
        public Dictionary<string, dynamic> AdditionalParameters { get; set; }
        /// <summary>
        /// Protocols
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-protocols
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Protocols { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-targets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Targets { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// AwsJobTimeoutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobtimeoutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobTimeoutConfig
        /// </summary>
        public Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig AwsJobTimeoutConfig { get; set; }
        /// <summary>
        /// AwsJobAbortConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobabortconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobAbortConfig
        /// </summary>
        public Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig AwsJobAbortConfig { get; set; }

        /// <summary>
        /// OtaUpdateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-otaupdateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OtaUpdateId { get; set; }
        /// <summary>
        /// TargetSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-targetselection
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetSelection { get; set; }
        /// <summary>
        /// AwsJobPresignedUrlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobpresignedurlconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobPresignedUrlConfig
        /// </summary>
        public Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig AwsJobPresignedUrlConfig { get; set; }

        /// <summary>
        /// Files
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-files
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: OTAUpdateFile
        /// </summary>
        [Required]
        public List<Humidifier.IoT.OTAUpdateTypes.OTAUpdateFile> Files { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AwsJobExecutionsRolloutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-otaupdate.html#cfn-iot-otaupdate-awsjobexecutionsrolloutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AwsJobExecutionsRolloutConfig
        /// </summary>
        public Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig AwsJobExecutionsRolloutConfig { get; set; }
    }

    namespace OTAUpdateTypes
    {
        public class AwsJobAbortConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AbortCriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortconfig.html#cfn-iot-otaupdate-awsjobabortconfig-abortcriterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AwsJobAbortCriteria
            /// </summary>
            public List<Humidifier.IoT.OTAUpdateTypes.AwsJobAbortCriteria> AbortCriteriaList { get; set; }
        }

        public class AwsJobAbortCriteria : Humidifier.Base.BaseSubResource, IHaveAction, IHaveFailureType, IHaveThresholdPercentage, IHaveMinNumberOfExecutedThings
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-action
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobabortcriteria.html#cfn-iot-otaupdate-awsjobabortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinNumberOfExecutedThings { get; set; }
        }

        public class AwsJobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexecutionsrolloutconfig.html#cfn-iot-otaupdate-awsjobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexecutionsrolloutconfig.html#cfn-iot-otaupdate-awsjobexecutionsrolloutconfig-exponentialrate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AwsJobExponentialRolloutRate
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate ExponentialRate { get; set; }
        }

        public class AwsJobExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveBaseRatePerMinute, IHaveIncrementFactor
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexponentialrolloutrate.html#cfn-iot-otaupdate-awsjobexponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AwsJobRateIncreaseCriteria
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexponentialrolloutrate.html#cfn-iot-otaupdate-awsjobexponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobexponentialrolloutrate.html#cfn-iot-otaupdate-awsjobexponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IncrementFactor { get; set; }
        }

        public class AwsJobPresignedUrlConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExpiresInSec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobpresignedurlconfig.html#cfn-iot-otaupdate-awsjobpresignedurlconfig-expiresinsec
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpiresInSec { get; set; }
        }

        public class AwsJobRateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings, IHaveNumberOfNotifiedThings
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobrateincreasecriteria.html#cfn-iot-otaupdate-awsjobrateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobrateincreasecriteria.html#cfn-iot-otaupdate-awsjobrateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfNotifiedThings { get; set; }
        }

        public class AwsJobTimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-awsjobtimeoutconfig.html#cfn-iot-otaupdate-awsjobtimeoutconfig-inprogresstimeoutinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InProgressTimeoutInMinutes { get; set; }
        }

        public class CodeSigning : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AwsSignerJobId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigning.html#cfn-iot-otaupdate-codesigning-awssignerjobid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsSignerJobId { get; set; }
            /// <summary>
            /// StartSigningJobParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigning.html#cfn-iot-otaupdate-codesigning-startsigningjobparameter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StartSigningJobParameter
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter StartSigningJobParameter { get; set; }
            /// <summary>
            /// CustomCodeSigning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigning.html#cfn-iot-otaupdate-codesigning-customcodesigning
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomCodeSigning
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.CustomCodeSigning CustomCodeSigning { get; set; }
        }

        public class CodeSigningCertificateChain : Humidifier.Base.BaseSubResource, IHaveCertificateName
        {
            /// <summary>
            /// InlineDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigningcertificatechain.html#cfn-iot-otaupdate-codesigningcertificatechain-inlinedocument
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InlineDocument { get; set; }
            /// <summary>
            /// CertificateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigningcertificatechain.html#cfn-iot-otaupdate-codesigningcertificatechain-certificatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateName { get; set; }
        }

        public class CodeSigningSignature : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InlineDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-codesigningsignature.html#cfn-iot-otaupdate-codesigningsignature-inlinedocument
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InlineDocument { get; set; }
        }

        public class CustomCodeSigning : Humidifier.Base.BaseSubResource, IHaveHashAlgorithm
        {
            /// <summary>
            /// Signature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-signature
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CodeSigningSignature
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.CodeSigningSignature Signature { get; set; }
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-certificatechain
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CodeSigningCertificateChain
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.CodeSigningCertificateChain CertificateChain { get; set; }
            /// <summary>
            /// SignatureAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-signaturealgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SignatureAlgorithm { get; set; }
            /// <summary>
            /// HashAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-customcodesigning.html#cfn-iot-otaupdate-customcodesigning-hashalgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HashAlgorithm { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-destination.html#cfn-iot-otaupdate-destination-s3destination
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Destination
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.S3Destination S3Destination { get; set; }
        }

        public class FileLocation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Stream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-filelocation.html#cfn-iot-otaupdate-filelocation-stream
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Stream
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.Stream Stream { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-filelocation.html#cfn-iot-otaupdate-filelocation-s3location
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.S3Location S3Location { get; set; }
        }

        public class OTAUpdateFile : Humidifier.Base.BaseSubResource, IHaveFileType
        {
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-filetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FileType { get; set; }
            /// <summary>
            /// FileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-filename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileName { get; set; }
            /// <summary>
            /// FileVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-fileversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileVersion { get; set; }
            /// <summary>
            /// FileLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-filelocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileLocation
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.FileLocation FileLocation { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-attributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Attributes_ { get; set; }
            /// <summary>
            /// CodeSigning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-otaupdatefile.html#cfn-iot-otaupdate-otaupdatefile-codesigning
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CodeSigning
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.CodeSigning CodeSigning { get; set; }
        }

        public class S3Destination : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3destination.html#cfn-iot-otaupdate-s3destination-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3destination.html#cfn-iot-otaupdate-s3destination-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveKey, IHaveVersion, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3location.html#cfn-iot-otaupdate-s3location-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3location.html#cfn-iot-otaupdate-s3location-version
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-s3location.html#cfn-iot-otaupdate-s3location-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class SigningProfileParameter : Humidifier.Base.BaseSubResource, IHaveCertificateArn, IHavePlatform
        {
            /// <summary>
            /// Platform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-signingprofileparameter.html#cfn-iot-otaupdate-signingprofileparameter-platform
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Platform { get; set; }
            /// <summary>
            /// CertificatePathOnDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-signingprofileparameter.html#cfn-iot-otaupdate-signingprofileparameter-certificatepathondevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificatePathOnDevice { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-signingprofileparameter.html#cfn-iot-otaupdate-signingprofileparameter-certificatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class StartSigningJobParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-startsigningjobparameter.html#cfn-iot-otaupdate-startsigningjobparameter-destination
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Destination
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.Destination Destination { get; set; }
            /// <summary>
            /// SigningProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-startsigningjobparameter.html#cfn-iot-otaupdate-startsigningjobparameter-signingprofilename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SigningProfileName { get; set; }
            /// <summary>
            /// SigningProfileParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-startsigningjobparameter.html#cfn-iot-otaupdate-startsigningjobparameter-signingprofileparameter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SigningProfileParameter
            /// </summary>
            public Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter SigningProfileParameter { get; set; }
        }

        public class Stream : Humidifier.Base.BaseSubResource, IHaveStreamId
        {
            /// <summary>
            /// StreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-stream.html#cfn-iot-otaupdate-stream-streamid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamId { get; set; }
            /// <summary>
            /// FileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-otaupdate-stream.html#cfn-iot-otaupdate-stream-fileid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FileId { get; set; }
        }
    }
}